using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Semantics;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace RoslynTool.CsToDsl
{
    internal partial class CsDslTranslater
    {
        #region OO语法框架部分
        public override void VisitCompilationUnit(CompilationUnitSyntax node)
        {
            base.VisitCompilationUnit(node);
        }
        public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            /*
            //--别名语法处理在这里跳过
            //--using alias = namespaces;
            //--extern alias Name;
            */

            /*
            为了支持partial类，命名空间不能写成嵌套形式
            ns1 = {
                ns2= {
                },
            }
            而必须写成赋值语句的形式，所以这里不需要缩进
            */

            var members = node.Members;
            foreach (var member in members) {
                member.Accept(this);
            }
        }
        public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            //允许在C#里定义与使用接口，动态语言里隐式支持任何接口
            INamedTypeSymbol sym = m_Model.GetDeclaredSymbol(node);
            if (SymbolTable.Instance.IsCs2DslSymbol(sym)) {
                var fullName = ClassInfo.GetFullName(sym);

                Dictionary<string, List<string>> intfs;
                if (m_ClassInfoStack.Count <= 0) {
                    intfs = SymbolTable.Instance.Cs2DslInterfaces;
                }
                else {
                    intfs = m_ClassInfoStack.Peek().InnerInterfaces;
                }
                lock (intfs) {
                    List<string> list;
                    if (!intfs.TryGetValue(fullName, out list)) {
                        list = new List<string>();
                        intfs.Add(fullName, list);
                    }
                    foreach (var intf in sym.AllInterfaces) {
                        var fn = ClassInfo.GetFullName(intf);
                        if (!list.Contains(fn)) {
                            list.Add(fn);
                        }
                    }
                }
            }
        }
        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            INamedTypeSymbol sym = m_Model.GetDeclaredSymbol(node);
            ClassInfo ci = new ClassInfo();
            ClassSymbolInfo info;
            SymbolTable.Instance.ClassSymbols.TryGetValue(ClassInfo.GetFullName(sym), out info);
            ci.Init(sym, info);
            m_ClassInfoStack.Push(ci);

            if (m_ClassInfoStack.Count == 1) {
                ci.BeforeOuterCodeBuilder.Append(m_ToplevelCodeBuilder.ToString());
                m_ToplevelCodeBuilder.Clear();
            }

            ++m_Indent;
            foreach (var member in node.Members) {
                VisitEnumMemberDeclaration(member);
            }
            --m_Indent;

            m_ClassInfoStack.Pop();

            if (m_ClassInfoStack.Count <= 0) {
                AddToplevelClass(ci.Key, ci);
            }
            else {
                m_ClassInfoStack.Peek().InnerClasses.Add(ci.Key, ci);
            }

            if (m_Indent <= 0 && null != m_LastToplevelClass) {
                m_LastToplevelClass.AfterOuterCodeBuilder.Append(m_ToplevelCodeBuilder.ToString());
                m_ToplevelCodeBuilder.Clear();
            }
        }
        public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            IFieldSymbol sym = m_Model.GetDeclaredSymbol(node);

            ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;
            CodeBuilder.AppendFormat("{0}member(\"{1}\", ", GetIndentString(), node.Identifier.Text);
            if (sym.HasConstantValue) {
                OutputConstValue(sym.ConstantValue, sym);
                CodeBuilder.AppendLine(");");
            }
            else if (null != node.EqualsValue) {
                OutputExpressionSyntax(node.EqualsValue.Value);
                CodeBuilder.AppendLine(");");
            }
            else {
                Log(node, "enum member can't deduce a value !");
                CodeBuilder.AppendLine("0);");
            }
        }
        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            VisitTypeDeclarationSyntax(node);
        }
        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            VisitTypeDeclarationSyntax(node);
        }
        public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
        {
            bool isExportConstructor = false;
            var ci = m_ClassInfoStack.Peek();
            IMethodSymbol declSym = m_Model.GetDeclaredSymbol(node);
            if (null != declSym) {
                string[] requires = ClassInfo.GetAttributeArguments<string>(declSym, "Cs2Dsl.RequireAttribute", 0);
                if (null != requires) {
                    foreach (var req in requires) {
                        SymbolTable.Instance.AddRequire(ci.Key, req);
                    }
                }
                if (ClassInfo.HasAttribute(declSym, "Cs2Dsl.IgnoreAttribute"))
                    return;
                if (declSym.IsAbstract)
                    return;
                isExportConstructor = ClassInfo.HasAttribute(declSym, "Cs2Dsl.ExportAttribute");
            }

            bool isStatic = declSym.IsStatic;
            var mi = new MethodInfo();
            mi.Init(declSym, node);
            m_MethodInfoStack.Push(mi);

            TryUsingAnalysis tryCatch = new TryUsingAnalysis();
            tryCatch.Visit(node);
            mi.ExistTry = tryCatch.ExistTry;
            mi.ExistUsing = tryCatch.ExistUsing;

            string manglingName = NameMangling(declSym);
            if (isStatic) {
                ci.ExistStaticConstructor = true;
            }
            else {
                ci.ExistConstructor = true;

                if (isExportConstructor) {
                    ci.ExportConstructor = manglingName;
                    ci.ExportConstructorInfo = mi;
                }
                else if (string.IsNullOrEmpty(ci.ExportConstructor)) {
                    //有构造但还没有明确指定的导出构造，则使用第一次遇到的构造
                    ci.ExportConstructor = manglingName;
                    ci.ExportConstructorInfo = mi;
                }
            }

            bool myselfDefinedBaseClass = SymbolTable.Instance.IsCs2DslSymbol(ci.SemanticInfo.BaseType);
            CodeBuilder.AppendFormat("{0}{1} = function({2}", GetIndentString(), manglingName, isStatic ? string.Empty : "this");
            if (mi.ParamNames.Count > 0) {
                if (!isStatic) {
                    CodeBuilder.Append(", ");
                }
                CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
            }
            CodeBuilder.Append("){");
            CodeBuilder.AppendLine();
            ++m_Indent;
            TryWrapValueParams(CodeBuilder, mi);
            if (!string.IsNullOrEmpty(mi.OriginalParamsName)) {
                CodeBuilder.AppendFormat("{0}local{{{1} = params({2});}};", GetIndentString(), mi.OriginalParamsName, mi.ParamsElementInfo);
                CodeBuilder.AppendLine();
            }
            //首先执行初始化列表
            var init = node.Initializer;
            if (null != init) {
                var oper = m_Model.GetOperationEx(init) as IInvocationExpression;
                string manglingName2 = NameMangling(oper.TargetMethod);
                if (init.ThisOrBaseKeyword.Text == "this") {
                    CodeBuilder.AppendFormat("{0}callinstance(this, \"{1}\"", GetIndentString(), manglingName2);
                }
                else if (init.ThisOrBaseKeyword.Text == "base") {
                    CodeBuilder.AppendFormat("{0}callinstance(getinstance(SymbolKind.Field, this, \"base\"), \"{1}\"", GetIndentString(), manglingName2);
                }
                if (init.ArgumentList.Arguments.Count > 0) {
                    CodeBuilder.Append(", ");
                }
                VisitArgumentList(init.ArgumentList);
                CodeBuilder.AppendLine(");");
            }
            //再执行构造函数内容（字段初始化部分）
            if (isStatic) {
                if (!string.IsNullOrEmpty(ci.BaseKey) && myselfDefinedBaseClass) {
                    CodeBuilder.AppendFormat("{0}callstatic({1}, \"cctor\");", GetIndentString(), ci.BaseKey);
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}callstatic({1}, \"__cctor\");", GetIndentString(), ci.Key);
                CodeBuilder.AppendLine();
            }
            else {
                if (!string.IsNullOrEmpty(ci.BaseKey) && !ClassInfo.IsBaseInitializerCalled(node, m_Model) && myselfDefinedBaseClass) {
                    //如果当前构造没有调父类构造并且委托的其它构造也没有调父类构造，则调用默认构造。
                    CodeBuilder.AppendFormat("{0}callinstance(getinstance(SymbolKind.Field, this, \"base\"), \"ctor\");", GetIndentString());
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}callinstance(this, \"__ctor\");", GetIndentString());
                CodeBuilder.AppendLine();
            }
            //再执行构造函数内容（构造函数部分）
            if (null != node.Body) {
                VisitBlock(node.Body);
                if (!mi.ExistTopLevelReturn) {
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("{0}return(this, {1});", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                        CodeBuilder.AppendLine();
                    }
                    else if (!isStatic) {
                        CodeBuilder.AppendFormat("{0}return(this);", GetIndentString());
                        CodeBuilder.AppendLine();
                    }
                }
            }
            else if (null != node.ExpressionBody) {
                IConversionExpression opd = null;
                var oper = m_Model.GetOperationEx(node.ExpressionBody) as IBlockStatement;
                if (null != oper && oper.Statements.Length == 1) {
                    var iret = oper.Statements[0] as IReturnStatement;
                    if (null != iret) {
                        opd = iret.ReturnedValue as IConversionExpression;
                    }
                }
                CodeBuilder.AppendFormat("{0}", GetIndentString());
                if (node.ExpressionBody.Expression is AssignmentExpressionSyntax) {
                    VisitToplevelExpression(node.ExpressionBody.Expression, string.Empty);
                }
                else {
                    OutputExpressionSyntax(node.ExpressionBody.Expression, opd);
                }
                if (mi.ReturnParamNames.Count > 0) {
                    CodeBuilder.AppendFormat("; return(this, {0})", string.Join(", ", mi.ReturnParamNames));
                }
                else {
                    CodeBuilder.AppendFormat("; return(this)");
                }
                CodeBuilder.AppendLine(";");
            }
            --m_Indent;
            CodeBuilder.AppendFormat("{0}}},", GetIndentString());
            CodeBuilder.AppendLine();
            m_MethodInfoStack.Pop();
        }
        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            IMethodSymbol declSym = m_Model.GetDeclaredSymbol(node);
            VisitCommonMethodDeclaration(declSym, node, node.Body, node.ExpressionBody);
        }
        public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            IPropertySymbol declSym = m_Model.GetDeclaredSymbol(node);
            if (null != declSym) {
                string[] requires = ClassInfo.GetAttributeArguments<string>(declSym, "Cs2Dsl.RequireAttribute", 0);
                if (null != requires) {
                    foreach (var req in requires) {
                        SymbolTable.Instance.AddRequire(ci.Key, req);
                    }
                }
                if (ClassInfo.HasAttribute(declSym, "Cs2Dsl.IgnoreAttribute"))
                    return;
                if (declSym.IsAbstract)
                    return;
            }

            if (null != node.ExpressionBody) {
                SymbolTable.Instance.NoImplProperties.TryAdd(declSym, false);
                //只读特性表达式体初始化写法
                StringBuilder curBuilder = ci.CurrentCodeBuilder;
                if (declSym.IsStatic) {
                    ci.CurrentCodeBuilder = ci.StaticFunctionCodeBuilder;
                }
                else {
                    ci.CurrentCodeBuilder = ci.InstanceFunctionCodeBuilder;
                }

                var sym = declSym.GetMethod;
                if (null != sym) {
                    var mi = new MethodInfo();
                    mi.Init(sym, node);
                    m_MethodInfoStack.Push(mi);

                    TryUsingAnalysis tryCatch = new TryUsingAnalysis();
                    tryCatch.Visit(node);
                    mi.ExistTry = tryCatch.ExistTry;
                    mi.ExistUsing = tryCatch.ExistUsing;

                    string manglingName = NameMangling(sym);
                    string paramStr = string.Join(", ", mi.ParamNames.ToArray());
                    if (!declSym.IsStatic) {
                        if (string.IsNullOrEmpty(paramStr))
                            paramStr = "this";
                        else
                            paramStr = "this, " + paramStr;
                    }
                    CodeBuilder.AppendFormat("{0}{1} = function({2}){{", GetIndentString(), manglingName, paramStr);
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    TryWrapValueParams(CodeBuilder, mi);
                    string varName = string.Format("__expbody_{0}", GetSourcePosForVar(node));
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("{0}local({1}); {1} = ", GetIndentString(), varName);
                    }
                    else {
                        CodeBuilder.AppendFormat("{0}return(", GetIndentString());
                    }
                    IConversionExpression opd = null;
                    var oper = m_Model.GetOperationEx(node.ExpressionBody) as IBlockStatement;
                    if (null != oper && oper.Statements.Length == 1) {
                        var iret = oper.Statements[0] as IReturnStatement;
                        if (null != iret) {
                            opd = iret.ReturnedValue as IConversionExpression;
                        }
                    }
                    OutputExpressionSyntax(node.ExpressionBody.Expression, opd);
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("; return({0}, {1})", varName, string.Join(", ", mi.ReturnParamNames));
                    }
                    else {
                        CodeBuilder.Append(")");
                    }
                    CodeBuilder.AppendLine(";");
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}},", GetIndentString());
                    CodeBuilder.AppendLine();

                    m_MethodInfoStack.Pop();
                }
                ci.CurrentCodeBuilder = curBuilder;

                CodeBuilder.AppendFormat("{0}{1} = {{", GetIndentString(), SymbolTable.GetPropertyName(declSym));
                CodeBuilder.AppendLine();
                ++m_Indent;
                CodeBuilder.AppendFormat("{0}get = {1}.get_{2};", GetIndentString(), declSym.IsStatic ? "static_methods" : "instance_methods", declSym.Name);
                CodeBuilder.AppendLine();
                --m_Indent;
                CodeBuilder.AppendFormat("{0}", GetIndentString());
                CodeBuilder.AppendLine("};");
                return;
            }

            bool noimpl = true;
            foreach (var accessor in node.AccessorList.Accessors) {
                var sym = m_Model.GetDeclaredSymbol(accessor);
                if (null != accessor.Body || null != accessor.ExpressionBody) {
                    noimpl = false;
                    break;
                }
            }
            SymbolTable.Instance.NoImplProperties.TryAdd(declSym, noimpl);

            if (noimpl) {
                //退化为field
                StringBuilder curBuilder = ci.CurrentCodeBuilder;

                if (declSym.IsStatic) {
                    ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;
                }
                else {
                    ci.CurrentCodeBuilder = ci.InstanceFieldCodeBuilder;
                }

                ++m_Indent;
                CodeBuilder.AppendFormat("{0}{1} = ", GetIndentString(), SymbolTable.GetPropertyName(declSym));
                if (null != node.Initializer) {
                    IConversionExpression opd = null;
                    var oper = m_Model.GetOperationEx(node.Initializer) as ISymbolInitializer;
                    if (null != oper) {
                        opd = oper.Value as IConversionExpression;
                    }
                    OutputExpressionSyntax(node.Initializer.Value, opd);
                }
                else {
                    OutputDefaultValue(declSym.Type);
                    CodeBuilder.Append(";");
                }
                CodeBuilder.AppendLine();
                --m_Indent;

                ci.CurrentCodeBuilder = curBuilder;
            }
            else {
                StringBuilder curBuilder = ci.CurrentCodeBuilder;
                if (declSym.IsStatic) {
                    ci.CurrentCodeBuilder = ci.StaticFunctionCodeBuilder;
                }
                else {
                    ci.CurrentCodeBuilder = ci.InstanceFunctionCodeBuilder;
                }
                foreach (var accessor in node.AccessorList.Accessors) {
                    var sym = m_Model.GetDeclaredSymbol(accessor);
                    if (null != sym) {
                        var mi = new MethodInfo();
                        mi.Init(sym, accessor);
                        m_MethodInfoStack.Push(mi);

                        TryUsingAnalysis tryCatch = new TryUsingAnalysis();
                        tryCatch.Visit(node);
                        mi.ExistTry = tryCatch.ExistTry;
                        mi.ExistUsing = tryCatch.ExistUsing;

                        string manglingName = NameMangling(sym);
                        string paramStr = string.Join(", ", mi.ParamNames.ToArray());
                        if (!declSym.IsStatic) {
                            if (string.IsNullOrEmpty(paramStr))
                                paramStr = "this";
                            else
                                paramStr = "this, " + paramStr;
                        }
                        CodeBuilder.AppendFormat("{0}{1} = {2}function({3}){{", GetIndentString(), manglingName, mi.ExistYield ? "wrapenumerable(" : string.Empty, paramStr);
                        CodeBuilder.AppendLine();
                        ++m_Indent;
                        bool isStatic = declSym.IsStatic;
                        string dslModule = ClassInfo.GetAttributeArgument<string>(sym, "Cs2Dsl.TranslateToAttribute", 0);
                        string dslFuncName = ClassInfo.GetAttributeArgument<string>(sym, "Cs2Dsl.TranslateToAttribute", 1);
                        if (string.IsNullOrEmpty(dslModule) && string.IsNullOrEmpty(dslFuncName)) {
                            if (!sym.ReturnsVoid && (mi.ExistTry || mi.ExistUsing)) {
                                string retVar = string.Format("__method_ret_{0}", GetSourcePosForVar(node));
                                mi.ReturnVarName = retVar;

                                CodeBuilder.AppendFormat("{0}local({1}); {1} = null;", GetIndentString(), retVar);
                                CodeBuilder.AppendLine();
                            }
                        }
                        if (!string.IsNullOrEmpty(dslModule) || !string.IsNullOrEmpty(dslFuncName)) {
                            if (!string.IsNullOrEmpty(dslModule)) {
                                SymbolTable.Instance.AddRequire(ci.Key, dslModule);
                            }
                            if (sym.ReturnsVoid && mi.ReturnParamNames.Count <= 0) {
                                CodeBuilder.AppendFormat("{0}{1}({2}", GetIndentString(), dslFuncName, isStatic ? string.Empty : "this");
                            }
                            else {
                                CodeBuilder.AppendFormat("{0}return({1}({2}", GetIndentString(), dslFuncName, isStatic ? string.Empty : "this");
                            }
                            if (mi.ParamNames.Count > 0) {
                                if (!isStatic) {
                                    CodeBuilder.Append(", ");
                                }
                                CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
                            }
                            else if (!sym.ReturnsVoid) {
                                CodeBuilder.Append(")");
                            }
                            CodeBuilder.AppendLine(");");
                        }
                        else if (null != accessor.Body) {
                            TryWrapValueParams(CodeBuilder, mi);
                            VisitBlock(accessor.Body);
                            if (!mi.ExistTopLevelReturn) {
                                if (!sym.ReturnsVoid) {
                                    if (mi.ExistTry) {
                                        CodeBuilder.AppendFormat("{0}return({1});", GetIndentString(), mi.ReturnVarName);
                                        CodeBuilder.AppendLine();
                                    }
                                    else {
                                        CodeBuilder.AppendFormat("{0}return(null);", GetIndentString());
                                        CodeBuilder.AppendLine();
                                    }
                                }
                            }
                        }
                        else if (null != accessor.ExpressionBody) {
                            TryWrapValueParams(CodeBuilder, mi);
                            string varName = string.Format("__expbody_{0}", GetSourcePosForVar(node));
                            if (!sym.ReturnsVoid) {
                                if (mi.ReturnParamNames.Count > 0) {
                                    CodeBuilder.AppendFormat("{0}local({1}); {1} = ", GetIndentString(), varName);
                                }
                                else {
                                    CodeBuilder.AppendFormat("{0}return(", GetIndentString());
                                }
                            }
                            IConversionExpression opd = null;
                            var oper = m_Model.GetOperationEx(accessor.ExpressionBody) as IBlockStatement;
                            if (null != oper && oper.Statements.Length == 1) {
                                var iret = oper.Statements[0] as IReturnStatement;
                                if (null != iret) {
                                    opd = iret.ReturnedValue as IConversionExpression;
                                }
                            }
                            if (sym.ReturnsVoid) {
                                CodeBuilder.AppendFormat("{0}", GetIndentString());
                                if (accessor.ExpressionBody.Expression is AssignmentExpressionSyntax) {
                                    VisitToplevelExpression(accessor.ExpressionBody.Expression, string.Empty);
                                }
                                else {
                                    OutputExpressionSyntax(accessor.ExpressionBody.Expression, opd);
                                }
                                if (mi.ReturnParamNames.Count > 0) {
                                    CodeBuilder.AppendFormat("; return({0})", string.Join(", ", mi.ReturnParamNames));
                                }
                                CodeBuilder.AppendLine(";");
                            }
                            else {
                                OutputExpressionSyntax(accessor.ExpressionBody.Expression, opd);
                                if (mi.ReturnParamNames.Count > 0) {
                                    CodeBuilder.AppendFormat("; return({0}, {1})", varName, string.Join(", ", mi.ReturnParamNames));
                                }
                                else {
                                    CodeBuilder.Append(")");
                                }
                                CodeBuilder.AppendLine(";");
                            }
                        }
                        --m_Indent;
                        CodeBuilder.AppendFormat("{0}}}{1};", GetIndentString(), mi.ExistYield ? ")" : string.Empty);
                        CodeBuilder.AppendLine();

                        m_MethodInfoStack.Pop();
                    }
                }
                ci.CurrentCodeBuilder = curBuilder;

                CodeBuilder.AppendFormat("{0}{1} = {{", GetIndentString(), SymbolTable.GetPropertyName(declSym));
                CodeBuilder.AppendLine();
                ++m_Indent;
                foreach (var accessor in node.AccessorList.Accessors) {
                    var sym = m_Model.GetDeclaredSymbol(accessor);
                    if (null != sym) {
                        string manglingName = NameMangling(sym);
                        string keyword = accessor.Keyword.Text;
                        CodeBuilder.AppendFormat("{0}{1} = {2}.{3};", GetIndentString(), keyword, declSym.IsStatic ? "static_methods" : "instance_methods", manglingName);
                        CodeBuilder.AppendLine();
                    }
                }
                --m_Indent;
                CodeBuilder.AppendFormat("{0}", GetIndentString());
                CodeBuilder.AppendLine("};");
            }
        }
        public override void VisitEventDeclaration(EventDeclarationSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            IEventSymbol declSym = m_Model.GetDeclaredSymbol(node);
            if (null != declSym) {
                string[] requires = ClassInfo.GetAttributeArguments<string>(declSym, "Cs2Dsl.RequireAttribute", 0);
                if (null != requires) {
                    foreach (var req in requires) {
                        SymbolTable.Instance.AddRequire(ci.Key, req);
                    }
                }
                if (ClassInfo.HasAttribute(declSym, "Cs2Dsl.IgnoreAttribute"))
                    return;
                if (declSym.IsAbstract)
                    return;
            }

            StringBuilder curBuilder = ci.CurrentCodeBuilder;
            if (declSym.IsStatic) {
                ci.CurrentCodeBuilder = ci.StaticFunctionCodeBuilder;
            }
            else {
                ci.CurrentCodeBuilder = ci.InstanceFunctionCodeBuilder;
            }
            foreach (var accessor in node.AccessorList.Accessors) {
                var sym = m_Model.GetDeclaredSymbol(accessor);
                if (null != sym) {
                    var mi = new MethodInfo();
                    mi.Init(sym, accessor);
                    m_MethodInfoStack.Push(mi);

                    TryUsingAnalysis tryCatch = new TryUsingAnalysis();
                    tryCatch.Visit(node);
                    mi.ExistTry = tryCatch.ExistTry;
                    mi.ExistUsing = tryCatch.ExistUsing;

                    string manglingName = NameMangling(sym);
                    string keyword = accessor.Keyword.Text;
                    string paramStr = string.Join(", ", mi.ParamNames.ToArray());
                    if (!declSym.IsStatic) {
                        if (string.IsNullOrEmpty(paramStr))
                            paramStr = "this";
                        else
                            paramStr = "this, " + paramStr;
                    }
                    CodeBuilder.AppendFormat("{0}{1} = function({2}){{", GetIndentString(), manglingName, paramStr);
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    bool isStatic = declSym.IsStatic;
                    string dslModule = ClassInfo.GetAttributeArgument<string>(sym, "Cs2Dsl.TranslateToAttribute", 0);
                    string dslFuncName = ClassInfo.GetAttributeArgument<string>(sym, "Cs2Dsl.TranslateToAttribute", 1);
                    if (!string.IsNullOrEmpty(dslModule) || !string.IsNullOrEmpty(dslFuncName)) {
                        if (!string.IsNullOrEmpty(dslModule)) {
                            SymbolTable.Instance.AddRequire(ci.Key, dslModule);
                        }
                        CodeBuilder.AppendFormat("{0}{1}({2}", GetIndentString(), dslFuncName, isStatic ? string.Empty : "this");
                        if (mi.ParamNames.Count > 0) {
                            if (!isStatic) {
                                CodeBuilder.Append(", ");
                            }
                            CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
                        }
                        else if (!sym.ReturnsVoid) {
                            CodeBuilder.Append(")");
                        }
                        CodeBuilder.AppendLine(");");
                    }
                    else if (null != accessor.Body) {
                        TryWrapValueParams(CodeBuilder, mi);
                        VisitBlock(accessor.Body);
                    }
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                    CodeBuilder.AppendLine();

                    m_MethodInfoStack.Pop();
                }
            }
            ci.CurrentCodeBuilder = curBuilder;

            CodeBuilder.AppendFormat("{0}{1} = {{", GetIndentString(), SymbolTable.GetEventName(declSym));
            CodeBuilder.AppendLine();
            ++m_Indent;
            foreach (var accessor in node.AccessorList.Accessors) {
                var sym = m_Model.GetDeclaredSymbol(accessor);
                if (null != sym) {
                    string manglingName = NameMangling(sym);
                    string keyword = accessor.Keyword.Text;
                    CodeBuilder.AppendFormat("{0}{1} = {2}.{3},", GetIndentString(), keyword, declSym.IsStatic ? "static_methods" : "instance_methods", manglingName);
                    CodeBuilder.AppendLine();
                }
            }
            --m_Indent;
            CodeBuilder.AppendFormat("{0}", GetIndentString());
            CodeBuilder.AppendLine("};");
        }
        public override void VisitOperatorDeclaration(OperatorDeclarationSyntax node)
        {
            IMethodSymbol declSym = m_Model.GetDeclaredSymbol(node);
            VisitCommonMethodDeclaration(declSym, node, node.Body, node.ExpressionBody);
        }
        public override void VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
        {
            IMethodSymbol declSym = m_Model.GetDeclaredSymbol(node);
            VisitCommonMethodDeclaration(declSym, node, node.Body, node.ExpressionBody);
        }
        public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            var declSym = m_Model.GetDeclaredSymbol(node);
            if (null != declSym) {
                string[] requires = ClassInfo.GetAttributeArguments<string>(declSym, "Cs2Dsl.RequireAttribute", 0);
                if (null != requires) {
                    foreach (var req in requires) {
                        SymbolTable.Instance.AddRequire(ci.Key, req);
                    }
                }
                if (ClassInfo.HasAttribute(declSym, "Cs2Dsl.IgnoreAttribute"))
                    return;
                if (declSym.IsAbstract)
                    return;
            }

            if (null != node.ExpressionBody) {
                //只读特性表达式体初始化写法
                StringBuilder curBuilder = ci.CurrentCodeBuilder;
                if (declSym.IsStatic) {
                    ci.CurrentCodeBuilder = ci.StaticFunctionCodeBuilder;
                }
                else {
                    ci.CurrentCodeBuilder = ci.InstanceFunctionCodeBuilder;
                }

                var sym = declSym.GetMethod;
                if (null != sym) {
                    var mi = new MethodInfo();
                    mi.Init(sym, node);
                    m_MethodInfoStack.Push(mi);

                    TryUsingAnalysis tryCatch = new TryUsingAnalysis();
                    tryCatch.Visit(node);
                    mi.ExistTry = tryCatch.ExistTry;
                    mi.ExistUsing = tryCatch.ExistUsing;

                    string manglingName = NameMangling(sym);
                    string paramStr = string.Join(", ", mi.ParamNames.ToArray());
                    if (!declSym.IsStatic) {
                        if (string.IsNullOrEmpty(paramStr))
                            paramStr = "this";
                        else
                            paramStr = "this, " + paramStr;
                    }
                    CodeBuilder.AppendFormat("{0}{1} = function(this, {2}){{", GetIndentString(), manglingName, string.Join(", ", mi.ParamNames.ToArray()));
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    TryWrapValueParams(CodeBuilder, mi);
                    if (!string.IsNullOrEmpty(mi.OriginalParamsName)) {
                        CodeBuilder.AppendFormat("{0}local{{{1} = params({2});}};", GetIndentString(), mi.OriginalParamsName, mi.ParamsElementInfo);
                        CodeBuilder.AppendLine();
                    }
                    string varName = string.Format("__expbody_{0}", GetSourcePosForVar(node));
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("{0}local({1}); {1} = ", GetIndentString(), varName);
                    }
                    else {
                        CodeBuilder.AppendFormat("{0}return(", GetIndentString());
                    }
                    IConversionExpression opd = null;
                    var oper = m_Model.GetOperationEx(node.ExpressionBody) as IBlockStatement;
                    if (null != oper && oper.Statements.Length == 1) {
                        var iret = oper.Statements[0] as IReturnStatement;
                        if (null != iret) {
                            opd = iret.ReturnedValue as IConversionExpression;
                        }
                    }
                    OutputExpressionSyntax(node.ExpressionBody.Expression, opd);
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("; return({0}, {1})", varName, string.Join(", ", mi.ReturnParamNames));
                    }
                    else {
                        CodeBuilder.Append(")");
                    }
                    CodeBuilder.AppendLine(";");
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                    CodeBuilder.AppendLine();

                    m_MethodInfoStack.Pop();
                }
                ci.CurrentCodeBuilder = curBuilder;
                return;
            }

            StringBuilder currentBuilder = ci.CurrentCodeBuilder;
            if (declSym.IsStatic)
                ci.CurrentCodeBuilder = ci.StaticFunctionCodeBuilder;
            else
                ci.CurrentCodeBuilder = ci.InstanceFunctionCodeBuilder;

            foreach (var accessor in node.AccessorList.Accessors) {
                var sym = m_Model.GetDeclaredSymbol(accessor);
                if (null != sym) {
                    var mi = new MethodInfo();
                    mi.Init(sym, accessor);
                    m_MethodInfoStack.Push(mi);

                    TryUsingAnalysis tryCatch = new TryUsingAnalysis();
                    tryCatch.Visit(node);
                    mi.ExistTry = tryCatch.ExistTry;
                    mi.ExistUsing = tryCatch.ExistUsing;

                    string manglingName = NameMangling(sym);
                    string keyword = accessor.Keyword.Text;
                    CodeBuilder.AppendFormat("{0}{1} = {2}function(this, {3}){{", GetIndentString(), manglingName, mi.ExistYield ? "wrapenumerable(" : string.Empty, string.Join(", ", mi.ParamNames.ToArray()));
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    bool isStatic = declSym.IsStatic;
                    string dslModule = ClassInfo.GetAttributeArgument<string>(sym, "Cs2Dsl.TranslateToAttribute", 0);
                    string dslFuncName = ClassInfo.GetAttributeArgument<string>(sym, "Cs2Dsl.TranslateToAttribute", 1);
                    if (string.IsNullOrEmpty(dslModule) && string.IsNullOrEmpty(dslFuncName)) {
                        if (!sym.ReturnsVoid && (mi.ExistTry || mi.ExistUsing)) {
                            string retVar = string.Format("__method_ret_{0}", GetSourcePosForVar(node));
                            mi.ReturnVarName = retVar;

                            CodeBuilder.AppendFormat("{0}local({1}); {1} = null;", GetIndentString(), retVar);
                            CodeBuilder.AppendLine();
                        }
                    }
                    if (!string.IsNullOrEmpty(dslModule) || !string.IsNullOrEmpty(dslFuncName)) {
                        if (!string.IsNullOrEmpty(dslModule)) {
                            SymbolTable.Instance.AddRequire(ci.Key, dslModule);
                        }
                        if (sym.ReturnsVoid && mi.ReturnParamNames.Count <= 0) {
                            CodeBuilder.AppendFormat("{0}{1}({2}", GetIndentString(), dslFuncName, isStatic ? string.Empty : "this");
                        }
                        else {
                            CodeBuilder.AppendFormat("{0}return({1}({2}", GetIndentString(), dslFuncName, isStatic ? string.Empty : "this");
                        }
                        if (mi.ParamNames.Count > 0) {
                            if (!isStatic) {
                                CodeBuilder.Append(", ");
                            }
                            CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
                        }
                        else if (!sym.ReturnsVoid) {
                            CodeBuilder.Append(")");
                        }
                        CodeBuilder.AppendLine(");");
                    }
                    else {
                        TryWrapValueParams(CodeBuilder, mi);
                        if (!string.IsNullOrEmpty(mi.OriginalParamsName)) {
                            if (keyword == "get") {
                                CodeBuilder.AppendFormat("{0}local{{{1} = params({2});}};", GetIndentString(), mi.OriginalParamsName, mi.ParamsElementInfo);
                                CodeBuilder.AppendLine();
                            }
                            else {
                                CodeBuilder.AppendFormat("{0}local{{{1} = params({2});}};", GetIndentString(), mi.OriginalParamsName, mi.ParamsElementInfo);
                                CodeBuilder.AppendLine();
                                CodeBuilder.AppendFormat("{0}local{{value = paramsremove({1});}};", GetIndentString(), mi.OriginalParamsName);
                                CodeBuilder.AppendLine();
                            }
                        }
                        if (null != accessor.Body) {
                            VisitBlock(accessor.Body);
                            if (!mi.ExistTopLevelReturn) {
                                if (sym.ReturnsVoid) {
                                    if (mi.ReturnParamNames.Count > 0) {
                                        CodeBuilder.AppendFormat("{0}return({1});", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                                        CodeBuilder.AppendLine();
                                    }
                                }
                                else {
                                    if (mi.ExistTry) {
                                        if (mi.ReturnParamNames.Count > 0) {
                                            CodeBuilder.AppendFormat("{0}return({1}, {2});", GetIndentString(), mi.ReturnVarName, string.Join(", ", mi.ReturnParamNames));
                                            CodeBuilder.AppendLine();
                                        }
                                        else {
                                            CodeBuilder.AppendFormat("{0}return({1});", GetIndentString(), mi.ReturnVarName);
                                            CodeBuilder.AppendLine();
                                        }
                                    }
                                    else if (mi.ReturnParamNames.Count > 0) {
                                        CodeBuilder.AppendFormat("{0}return(null, {1});", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                                        CodeBuilder.AppendLine();
                                    }
                                    else {
                                        CodeBuilder.AppendFormat("{0}return(null);", GetIndentString());
                                        CodeBuilder.AppendLine();
                                    }
                                }
                            }
                        }
                        else if (null != accessor.ExpressionBody) {
                            string varName = string.Format("__expbody_{0}", GetSourcePosForVar(node));
                            if (!sym.ReturnsVoid) {
                                if (mi.ReturnParamNames.Count > 0) {
                                    CodeBuilder.AppendFormat("{0}local({1}); {1} = ", GetIndentString(), varName);
                                }
                                else {
                                    CodeBuilder.AppendFormat("{0}return(", GetIndentString());
                                }
                            }
                            IConversionExpression opd = null;
                            var oper = m_Model.GetOperationEx(accessor.ExpressionBody) as IBlockStatement;
                            if (null != oper && oper.Statements.Length == 1) {
                                var iret = oper.Statements[0] as IReturnStatement;
                                if (null != iret) {
                                    opd = iret.ReturnedValue as IConversionExpression;
                                }
                            }
                            if (sym.ReturnsVoid) {
                                CodeBuilder.AppendFormat("{0}", GetIndentString());
                                if (accessor.ExpressionBody.Expression is AssignmentExpressionSyntax) {
                                    VisitToplevelExpression(accessor.ExpressionBody.Expression, string.Empty);
                                }
                                else {
                                    OutputExpressionSyntax(accessor.ExpressionBody.Expression, opd);
                                }
                                if (mi.ReturnParamNames.Count > 0) {
                                    CodeBuilder.AppendFormat("; return({0})", string.Join(", ", mi.ReturnParamNames));
                                }
                                CodeBuilder.AppendLine(";");
                            }
                            else {
                                OutputExpressionSyntax(accessor.ExpressionBody.Expression, opd);
                                if (mi.ReturnParamNames.Count > 0) {
                                    CodeBuilder.AppendFormat("; return({0}, {1})", varName, string.Join(", ", mi.ReturnParamNames));
                                }
                                else {
                                    CodeBuilder.Append(")");
                                }
                                CodeBuilder.AppendLine(";");
                            }
                        }
                    }
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}}{1};", GetIndentString(), mi.ExistYield ? ")" : string.Empty);
                    CodeBuilder.AppendLine();

                    m_MethodInfoStack.Pop();
                }
            }

            ci.CurrentCodeBuilder = currentBuilder;
        }
        public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
        {
            SymbolInfo symInfo = m_Model.GetSymbolInfoEx(node);
            var sym = symInfo.Symbol as IMethodSymbol;

            if (null != sym && sym.Parameters.Length == 1) {
                if (node.Body is BlockSyntax) {
                    var param = sym.Parameters[0];
                    CodeBuilder.AppendFormat("(function({0}) {{", param.Name);
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    node.Body.Accept(this);
                    if (!sym.ReturnsVoid) {
                        CodeBuilder.AppendFormat("{0}return({1});", GetIndentString(), param.Name);
                        CodeBuilder.AppendLine();
                    }
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}};)", GetIndentString());
                }
                else {
                    var param = sym.Parameters[0];
                    CodeBuilder.AppendFormat("(function({0}) {{ return(", param.Name);
                    IConversionExpression opd = null;
                    var oper = m_Model.GetOperationEx(node) as ILambdaExpression;
                    if (null != oper && oper.Body.Statements.Length == 1) {
                        var iret = oper.Body.Statements[0] as IReturnStatement;
                        if (null != iret) {
                            opd = iret.ReturnedValue as IConversionExpression;
                        }
                    }
                    var exp = node.Body as ExpressionSyntax;
                    if (null != exp) {
                        OutputExpressionSyntax(exp, opd);
                    }
                    else {
                        ReportIllegalSymbol(node, symInfo);
                    }
                    CodeBuilder.Append("); };)");
                }
            }
            else {
                ReportIllegalSymbol(node, symInfo);
            }
        }
        public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
        {
            SymbolInfo symInfo = m_Model.GetSymbolInfoEx(node);
            var sym = symInfo.Symbol as IMethodSymbol;
            if (null != sym) {
                var mi = new MethodInfo();
                mi.Init(sym, node);
                m_MethodInfoStack.Push(mi);

                TryUsingAnalysis tryCatch = new TryUsingAnalysis();
                tryCatch.Visit(node);
                mi.ExistTry = tryCatch.ExistTry;
                mi.ExistUsing = tryCatch.ExistUsing;

                CodeBuilder.Append("(function(");
                CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
                if (node.Body is BlockSyntax) {
                    CodeBuilder.AppendLine("){");
                    ++m_Indent;
                    if (!sym.ReturnsVoid && (mi.ExistTry || mi.ExistUsing)) {
                        string retVar = string.Format("__method_ret_{0}", GetSourcePosForVar(node));
                        mi.ReturnVarName = retVar;

                        CodeBuilder.AppendFormat("{0}local({1}); {1} = null;", GetIndentString(), retVar);
                        CodeBuilder.AppendLine();
                    }
                    TryWrapValueParams(CodeBuilder, mi);
                    if (!string.IsNullOrEmpty(mi.OriginalParamsName)) {
                        CodeBuilder.AppendFormat("{0}local{{{1} = params({2});}};", GetIndentString(), mi.OriginalParamsName, mi.ParamsElementInfo);
                        CodeBuilder.AppendLine();
                    }
                    node.Body.Accept(this);
                    if (!mi.ExistTopLevelReturn) {
                        if (sym.ReturnsVoid) {
                            if (mi.ReturnParamNames.Count > 0) {
                                CodeBuilder.AppendFormat("{0}return({1});", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                                CodeBuilder.AppendLine();
                            }
                        }
                        else {
                            if (mi.ExistTry) {
                                if (mi.ReturnParamNames.Count > 0) {
                                    CodeBuilder.AppendFormat("{0}return({1}, {2});", GetIndentString(), mi.ReturnVarName, string.Join(", ", mi.ReturnParamNames));
                                    CodeBuilder.AppendLine();
                                }
                                else {
                                    CodeBuilder.AppendFormat("{0}return({1});", GetIndentString(), mi.ReturnVarName);
                                    CodeBuilder.AppendLine();
                                }
                            }
                            else if (mi.ReturnParamNames.Count > 0) {
                                CodeBuilder.AppendFormat("{0}return(null, {1});", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                                CodeBuilder.AppendLine();
                            }
                            else {
                                CodeBuilder.AppendFormat("{0}return(null);", GetIndentString());
                                CodeBuilder.AppendLine();
                            }
                        }
                    }
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}})", GetIndentString());
                }
                else {
                    string varName = string.Format("__lambda_{0}", GetSourcePosForVar(node));
                    CodeBuilder.Append("){ ");
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("local({0}); {0} = ", varName);
                    }
                    else {
                        CodeBuilder.Append("return(");
                    }
                    IConversionExpression opd = null;
                    var oper = m_Model.GetOperationEx(node) as ILambdaExpression;
                    if (null != oper && oper.Body.Statements.Length == 1) {
                        var iret = oper.Body.Statements[0] as IReturnStatement;
                        if (null != iret) {
                            opd = iret.ReturnedValue as IConversionExpression;
                        }
                    }
                    var exp = node.Body as ExpressionSyntax;
                    if (null != exp) {
                        OutputExpressionSyntax(exp, opd);
                    }
                    else {
                        ReportIllegalSymbol(node, symInfo);
                    }
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("; return({0}, {1})", varName, string.Join(", ", mi.ReturnParamNames));
                    }
                    else {
                        CodeBuilder.Append(")");
                    }
                    CodeBuilder.Append("; })");
                }
                m_MethodInfoStack.Pop();
            }
            else {
                ReportIllegalSymbol(node, symInfo);
            }
        }
        public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
        {
            SymbolInfo symInfo = m_Model.GetSymbolInfoEx(node);
            var sym = symInfo.Symbol as IMethodSymbol;
            if (null != sym) {
                var mi = new MethodInfo();
                mi.Init(sym, node);
                m_MethodInfoStack.Push(mi);

                TryUsingAnalysis tryCatch = new TryUsingAnalysis();
                tryCatch.Visit(node);
                mi.ExistTry = tryCatch.ExistTry;
                mi.ExistUsing = tryCatch.ExistUsing;

                CodeBuilder.Append("(function(");
                int ct = sym.Parameters.Length;
                if (ct > 0) {
                    for (int i = 0; i < ct; ++i) {
                        var param = sym.Parameters[i];
                        CodeBuilder.Append(param.Name);
                        if (i < ct - 1) {
                            CodeBuilder.Append(", ");
                        }
                    }
                }
                CodeBuilder.AppendLine("){");
                ++m_Indent;
                if (!sym.ReturnsVoid && (mi.ExistTry || mi.ExistUsing)) {
                    string retVar = string.Format("__method_ret_{0}", GetSourcePosForVar(node));
                    mi.ReturnVarName = retVar;

                    CodeBuilder.AppendFormat("{0}local({1}); {1} = null;", GetIndentString(), retVar);
                    CodeBuilder.AppendLine();
                }
                node.Body.Accept(this);
                if (!mi.ExistTopLevelReturn) {
                    if (sym.ReturnsVoid) {
                        if (mi.ReturnParamNames.Count > 0) {
                            CodeBuilder.AppendFormat("{0}return({1});", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                            CodeBuilder.AppendLine();
                        }
                    }
                    else {
                        if (mi.ExistTry) {
                            if (mi.ReturnParamNames.Count > 0) {
                                CodeBuilder.AppendFormat("{0}return({1}, {2});", GetIndentString(), mi.ReturnVarName, string.Join(", ", mi.ReturnParamNames));
                                CodeBuilder.AppendLine();
                            }
                            else {
                                CodeBuilder.AppendFormat("{0}return({1});", GetIndentString(), mi.ReturnVarName);
                                CodeBuilder.AppendLine();
                            }
                        }
                        else if (mi.ReturnParamNames.Count > 0) {
                            CodeBuilder.AppendFormat("{0}return(null, {1});", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                            CodeBuilder.AppendLine();
                        }
                        else {
                            CodeBuilder.AppendFormat("{0}return(null);", GetIndentString());
                            CodeBuilder.AppendLine();
                        }
                    }
                }
                --m_Indent;
                CodeBuilder.AppendFormat("{0}}})", GetIndentString());

                m_MethodInfoStack.Pop();
            }
            else {
                ReportIllegalSymbol(node, symInfo);
            }
        }
        public override void VisitBlock(BlockSyntax node)
        {
            bool isBlock = node.Parent is BlockSyntax;
            if (isBlock) {
                CodeBuilder.AppendFormat("{0}block{{", GetIndentString());
                CodeBuilder.AppendLine();
                ++m_Indent;
            }
            base.VisitBlock(node);
            if (isBlock) {
                --m_Indent;
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitUsingStatement(UsingStatementSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();

            string varName = string.Format("__using_{0}", GetSourcePosForVar(node));
            string retVar = string.Format("__using_ret_{0}", GetSourcePosForVar(node));
            string retValVar = string.Format("__using_ret_val_{0}", GetSourcePosForVar(node));
            if (null != node.Declaration) {
                VisitVariableDeclaration(node.Declaration);
            }
            else if (null != node.Expression) {
                CodeBuilder.AppendFormat("{0}local{{{1} = ", GetIndentString(), varName);
                IConversionExpression opd = m_Model.GetOperationEx(node.Expression) as IConversionExpression;
                OutputExpressionSyntax(node.Expression, opd);
                CodeBuilder.AppendLine(";};");
            }
            else {
                Log(node, "node.Declaration and node.Expression are null.");
            }
            if (null != node.Statement) {
                ReturnContinueBreakAnalysis returnAnalysis = new ReturnContinueBreakAnalysis();
                returnAnalysis.Visit(node.Statement);
                if (returnAnalysis.Exist) {
                    CodeBuilder.AppendFormat("{0}local({1}, {2}); multiassign({1}, {2}) = dslusing{{", GetIndentString(), retVar, retValVar);
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    ++mi.TryUsingLayer;
                    node.Statement.Accept(this);
                    --mi.TryUsingLayer;
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                    CodeBuilder.AppendLine();

                    OutputTryCatchUsingReturn(returnAnalysis, mi, retVar, retValVar);
                }
                else {
                    node.Statement.Accept(this);
                }
            }
            else {
                Log(node, "node.Statement is null.");
            }
            if (null != node.Declaration && null != node.Declaration.Variables) {
                foreach (var decl in node.Declaration.Variables) {
                    CodeBuilder.AppendFormat("{0}callexterninstance({1}, \"Dispose\");", GetIndentString(), decl.Identifier.Text);
                    CodeBuilder.AppendLine();
                }
            }
            else if (null != node.Expression) {
                CodeBuilder.AppendFormat("{0}callexterninstance({1}, \"Dispose\");", GetIndentString(), varName);
                CodeBuilder.AppendLine();
            }
            else {
                Log(node, "node.Declaration is null or node.Declaration.Variables is null, and node.Expression is null.");
            }
        }
        #endregion
    }
}