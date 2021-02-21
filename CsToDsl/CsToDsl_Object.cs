using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Operations;
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
                    return;//构造函数不会是抽象的，应该不会走到这里
                isExportConstructor = ClassInfo.HasAttribute(declSym, "Cs2Dsl.ExportAttribute");
            }

            bool isStatic = declSym.IsStatic;
            var mi = new MethodInfo();
            mi.Init(declSym, node);
            m_MethodInfoStack.Push(mi);

            TryUsingAnalysis tryUsing = new TryUsingAnalysis();
            tryUsing.Visit(node);
            mi.ExistTry = tryUsing.ExistTry;
            mi.ExistUsing = tryUsing.ExistUsing;

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
            CodeBuilder.AppendFormat("{0}{1} = deffunc({2})args({3}", GetIndentString(), manglingName, mi.ReturnValueCount, isStatic ? string.Empty : "this");
            if (mi.ParamNames.Count > 0) {
                if (!isStatic) {
                    CodeBuilder.Append(", ");
                }
                CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
            }
            CodeBuilder.Append("){");
            CodeBuilder.AppendLine();
            ++m_Indent;
            TryWrapParams(CodeBuilder, mi);
            if (!string.IsNullOrEmpty(mi.OriginalParamsName)) {
                CodeBuilder.AppendFormat("{0}local({1}); {1} = params({2});", GetIndentString(), mi.OriginalParamsName, mi.ParamsElementInfo);
                CodeBuilder.AppendLine();
            }
            //首先执行初始化列表
            var init = node.Initializer;
            if (null != init) {
                var oper = m_Model.GetOperationEx(init) as IInvocationOperation;
                string manglingName2 = NameMangling(oper.TargetMethod);
                if (init.ThisOrBaseKeyword.Text == "this") {
                    CodeBuilder.AppendFormat("{0}callinstance(this, {1}, \"{2}\"", GetIndentString(), ci.Key, manglingName2);
                }
                else if (init.ThisOrBaseKeyword.Text == "base") {
                    if(myselfDefinedBaseClass)
                        CodeBuilder.AppendFormat("{0}buildbaseobj(this, {1}, {2}, \"{3}\"", GetIndentString(), ci.Key, ci.BaseKey, manglingName2);
                    else
                        CodeBuilder.AppendFormat("{0}buildexternbaseobj(this, {1}, {2}, \"{3}\"", GetIndentString(), ci.Key, ci.BaseKey, manglingName2);
                }
                int retCt = 0;
                if (null != oper.TargetMethod) {
                    foreach (var p in oper.TargetMethod.Parameters) {
                        if (p.RefKind == RefKind.Ref || p.RefKind == RefKind.Out)
                            ++retCt;
                    }
                }
                CodeBuilder.Append(", ");
                CodeBuilder.Append(retCt);
                if (init.ArgumentList.Arguments.Count > 0) {
                    CodeBuilder.Append(", ");
                }
                OutputArgumentList(init.ArgumentList.Arguments, ", ", oper);
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
                    CodeBuilder.AppendFormat("{0}buildbaseobj(this, {1}, {2}, \"ctor\", 0);", GetIndentString(), ci.Key, ci.BaseKey);
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}callinstance(this, {1}, \"__ctor\");", GetIndentString(), ci.Key);
                CodeBuilder.AppendLine();
            }
            //再执行构造函数内容（构造函数部分）
            if (null != node.Body) {
                VisitBlock(node.Body);
                if (!mi.ExistTopLevelReturn) {
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("{0}return({1});", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                        CodeBuilder.AppendLine();
                    }
                }
            }
            else if (null != node.ExpressionBody) {
                IConversionOperation opd = null;
                var oper = m_Model.GetOperationEx(node.ExpressionBody) as IBlockOperation;
                if (null != oper && oper.Operations.Length == 1) {
                    var iret = oper.Operations[0] as IReturnOperation;
                    if (null != iret) {
                        opd = iret.ReturnedValue as IConversionOperation;
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
                    CodeBuilder.AppendFormat("; return({0})", string.Join(", ", mi.ReturnParamNames));
                }
                CodeBuilder.AppendLine(";");
            }
            --m_Indent;
            CodeBuilder.AppendFormat("{0}}}options[{1}],", GetIndentString(), mi.CalcFunctionOptions());
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
                    return;//抽象特性不翻译，生成最终代码时补上
            }
            else {
                return;
            }

            string propertyName = SymbolTable.GetPropertyName(declSym);
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

                    TryUsingAnalysis tryUsing = new TryUsingAnalysis();
                    tryUsing.Visit(node);
                    mi.ExistTry = tryUsing.ExistTry;
                    mi.ExistUsing = tryUsing.ExistUsing;

                    string manglingName = NameMangling(sym);
                    string paramStr = string.Join(", ", mi.ParamNames.ToArray());
                    if (!declSym.IsStatic) {
                        if (string.IsNullOrEmpty(paramStr))
                            paramStr = "this";
                        else
                            paramStr = "this, " + paramStr;
                    }
                    CodeBuilder.AppendFormat("{0}{1} = deffunc({2})args({3}){{", GetIndentString(), manglingName, mi.ReturnValueCount, paramStr);
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    TryWrapParams(CodeBuilder, mi);
                    string varName = string.Format("__expbody_{0}", GetSourcePosForVar(node));
                    CodeBuilder.AppendFormat("{0}local({1}); {1} = ", GetIndentString(), varName);
                    IConversionOperation opd = null;
                    var oper = m_Model.GetOperationEx(node.ExpressionBody) as IBlockOperation;
                    if (null != oper && oper.Operations.Length == 1) {
                        var iret = oper.Operations[0] as IReturnOperation;
                        if (null != iret) {
                            opd = iret.ReturnedValue as IConversionOperation;
                        }
                    }
                    OutputExpressionSyntax(node.ExpressionBody.Expression, opd);
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("; return({0}, {1})", varName, string.Join(", ", mi.ReturnParamNames));
                    }
                    else {
                        CodeBuilder.AppendFormat("; return({0})", varName);
                    }
                    CodeBuilder.AppendLine(";");
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}}options[{1}],", GetIndentString(), mi.CalcFunctionOptions());
                    CodeBuilder.AppendLine();

                    m_MethodInfoStack.Pop();
                }
                ci.CurrentCodeBuilder = curBuilder;

                CodeBuilder.AppendFormat("{0}{1} = {{", GetIndentString(), propertyName);
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

            bool noimplAndIntfImpl = false;
            if (noimpl) {
                foreach (var intf in ci.ClassSemanticInfo.InterfaceSymbols) {
                    foreach(var prop in intf.GetMembers()) {
                        if (prop.Kind == SymbolKind.Property) {
                            var implSym = ci.SemanticInfo.FindImplementationForInterfaceMember(prop);
                            if (implSym == declSym) {
                                noimplAndIntfImpl = true;
                                break;
                            }
                        }
                    }
                }
                //退化为field
                StringBuilder curBuilder = ci.CurrentCodeBuilder;

                if (declSym.IsStatic) {
                    ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;
                }
                else {
                    ci.CurrentCodeBuilder = ci.InstanceFieldCodeBuilder;
                }

                CodeBuilder.AppendFormat("{0}{1} = ", GetIndentString(), propertyName);
                if (null != node.Initializer) {
                    IConversionOperation opd = null;
                    var oper = m_Model.GetOperationEx(node.Initializer) as ISymbolInitializerOperation;
                    if (null != oper) {
                        opd = oper.Value as IConversionOperation;
                    }
                    OutputExpressionSyntax(node.Initializer.Value, opd);
                }
                else {
                    OutputDefaultValue(declSym.Type);
                    CodeBuilder.Append(";");
                }
                CodeBuilder.AppendLine();

                ci.CurrentCodeBuilder = curBuilder;
            }
            if(!noimpl || noimplAndIntfImpl) {
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

                        TryUsingAnalysis tryUsing = new TryUsingAnalysis();
                        tryUsing.Visit(accessor);
                        mi.ExistTry = tryUsing.ExistTry;
                        mi.ExistUsing = tryUsing.ExistUsing;

                        string manglingName = NameMangling(sym);
                        string paramStr = string.Join(", ", mi.ParamNames.ToArray());
                        if (!declSym.IsStatic) {
                            if (string.IsNullOrEmpty(paramStr))
                                paramStr = "this";
                            else
                                paramStr = "this, " + paramStr;
                        }
                        CodeBuilder.AppendFormat("{0}{1} = {2}deffunc({3})args({4}){{", GetIndentString(), manglingName, mi.ExistYield ? "wrapenumerable(" : string.Empty, mi.ReturnValueCount, paramStr);
                        CodeBuilder.AppendLine();
                        ++m_Indent;
                        bool isStatic = declSym.IsStatic;
                        string dslModule = ClassInfo.GetAttributeArgument<string>(sym, "Cs2Dsl.TranslateToAttribute", 0);
                        string dslFuncName = ClassInfo.GetAttributeArgument<string>(sym, "Cs2Dsl.TranslateToAttribute", 1);
                        if (!sym.ReturnsVoid) {
                            string retVar = string.Format("__method_ret_{0}", GetSourcePosForVar(node));
                            mi.ReturnVarName = retVar;

                            CodeBuilder.AppendFormat("{0}local({1});", GetIndentString(), retVar);
                            CodeBuilder.AppendLine();
                        }
                        if (!string.IsNullOrEmpty(dslModule) || !string.IsNullOrEmpty(dslFuncName)) {
                            if (!string.IsNullOrEmpty(dslModule)) {
                                SymbolTable.Instance.AddRequire(ci.Key, dslModule);
                            }
                            if (sym.ReturnsVoid && mi.ReturnParamNames.Count <= 0) {
                                CodeBuilder.AppendFormat("{0}{1}({2}", GetIndentString(), dslFuncName, isStatic ? string.Empty : "this");
                            }
                            else {
                                string ma1 = string.Empty;
                                string ma2 = string.Empty;
                                if (!sym.ReturnsVoid && mi.ReturnParamNames.Count > 0 || mi.ReturnParamNames.Count > 1) {
                                    ma1 = "multiassign(";
                                    ma2 = ")";
                                }
                                CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), ma1);
                                string prestr = "";
                                if (!sym.ReturnsVoid) {
                                    CodeBuilder.Append(mi.ReturnVarName);
                                    prestr = ",";
                                }
                                foreach (var name in mi.ReturnParamNames) {
                                    CodeBuilder.Append(prestr);
                                    CodeBuilder.Append(name);
                                    prestr = ", ";
                                }
                                CodeBuilder.AppendFormat("{0} = {1}({2}", ma2, dslFuncName, isStatic ? string.Empty : "this");
                            }
                            if (mi.ParamNames.Count > 0) {
                                if (!isStatic) {
                                    CodeBuilder.Append(", ");
                                }
                                CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
                            }
                            CodeBuilder.AppendLine(");");
                            if (!sym.ReturnsVoid || mi.ParamNames.Count > 0) {
                                CodeBuilder.AppendFormat("{0}return(", GetIndentString());
                                string prestr = "";
                                if (!sym.ReturnsVoid) {
                                    CodeBuilder.Append(mi.ReturnVarName);
                                    prestr = ",";
                                }
                                foreach (var name in mi.ReturnParamNames) {
                                    CodeBuilder.Append(prestr);
                                    CodeBuilder.Append(name);
                                    prestr = ", ";
                                }
                                CodeBuilder.AppendLine(");");
                            }
                        }
                        else if (null != accessor.Body) {
                            TryWrapParams(CodeBuilder, mi);
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
                            TryWrapParams(CodeBuilder, mi);
                            if (!sym.ReturnsVoid) {
                                CodeBuilder.AppendFormat("{0}{1} = ", GetIndentString(), mi.ReturnVarName);
                            }
                            IConversionOperation opd = null;
                            var oper = m_Model.GetOperationEx(accessor.ExpressionBody) as IBlockOperation;
                            if (null != oper && oper.Operations.Length == 1) {
                                var iret = oper.Operations[0] as IReturnOperation;
                                if (null != iret) {
                                    opd = iret.ReturnedValue as IConversionOperation;
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
                                    CodeBuilder.AppendFormat("; return({0}, {1})", mi.ReturnVarName, string.Join(", ", mi.ReturnParamNames));
                                }
                                else {
                                    CodeBuilder.AppendFormat("; return({0})", mi.ReturnVarName);
                                }
                                CodeBuilder.AppendLine(";");
                            }
                        }
                        else if (noimplAndIntfImpl) {
                            TryWrapParams(CodeBuilder, mi);
                            if (!sym.ReturnsVoid) {
                                CodeBuilder.AppendFormat("{0}{1} = ", GetIndentString(), mi.ReturnVarName);
                                if (declSym.IsStatic) {
                                    CodeBuilder.AppendFormat("getstatic(SymbolKind.Field, {0}, \"{1}\")", ci.Key, propertyName);
                                }
                                else {
                                    CodeBuilder.AppendFormat("getinstance(SymbolKind.Field, this, {0}, \"{1}\")", ci.Key, propertyName);
                                }
                                CodeBuilder.AppendFormat("; return({0})", mi.ReturnVarName);
                                CodeBuilder.AppendLine(";");
                            }
                            else {
                                string postfix = GetSourcePosForVar(node);
                                string oldValVar = string.Format("__old_val_{0}", postfix);
                                string newValVar = string.Format("__new_val_{0}", postfix);
                                string fieldType = ClassInfo.GetFullName(declSym.Type);
                                bool isStruct = declSym.Type.IsValueType && !SymbolTable.IsBasicType(declSym.Type);
                                if (isStruct) {
                                    //记录旧值
                                    CodeBuilder.Append(GetIndentString());
                                    CodeBuilder.AppendFormat("local({0}); {0} = ", oldValVar);
                                    if (declSym.IsStatic) {
                                        CodeBuilder.Append("getstatic(SymbolKind.Field, ");
                                        CodeBuilder.Append(ci.Key);
                                        CodeBuilder.AppendFormat(", \"{0}\");", propertyName);
                                        CodeBuilder.AppendLine();
                                    }
                                    else {
                                        CodeBuilder.Append("getinstance(SymbolKind.Field, this, ");
                                        CodeBuilder.AppendFormat("{0}, \"{1}\");", ci.Key, propertyName);
                                        CodeBuilder.AppendLine();
                                    }
                                }
                                CodeBuilder.Append(GetIndentString());
                                if (declSym.IsStatic) {
                                    CodeBuilder.AppendFormat("setstatic(SymbolKind.Field, {0}, \"{1}\", {2})", ci.Key, propertyName, mi.ParamNames[0]);
                                }
                                else {
                                    CodeBuilder.AppendFormat("setinstance(SymbolKind.Field, this, {0}, \"{1}\", {2})", ci.Key, propertyName, mi.ParamNames[0]);
                                }
                                CodeBuilder.AppendLine(";");
                                if (isStruct) {
                                    //记录新值
                                    CodeBuilder.Append(GetIndentString());
                                    CodeBuilder.AppendFormat("local({0}); {0} = ", newValVar);
                                    if (declSym.IsStatic) {
                                        CodeBuilder.Append("getstatic(SymbolKind.Field, ");
                                        CodeBuilder.Append(ci.Key);
                                        CodeBuilder.AppendFormat(", \"{0}\");", propertyName);
                                        CodeBuilder.AppendLine();
                                    }
                                    else {
                                        CodeBuilder.Append("getinstance(SymbolKind.Field, this, ");
                                        CodeBuilder.AppendFormat("{0}, \"{1}\");", ci.Key, propertyName);
                                        CodeBuilder.AppendLine();
                                    }
                                    //回收旧值，保持新值
                                    CodeBuilder.Append(GetIndentString());
                                    CodeBuilder.Append("recycleandkeepstructvalue(");
                                    CodeBuilder.Append(fieldType);
                                    CodeBuilder.Append(", ");
                                    CodeBuilder.Append(oldValVar);
                                    CodeBuilder.Append(", ");
                                    CodeBuilder.Append(newValVar);
                                    CodeBuilder.AppendLine(");");
                                }
                            }
                        }
                        --m_Indent;
                        CodeBuilder.AppendFormat("{0}}}options[{1}]{2};", GetIndentString(), mi.CalcFunctionOptions(), mi.ExistYield ? ")" : string.Empty);
                        CodeBuilder.AppendLine();

                        m_MethodInfoStack.Pop();
                    }
                }
                ci.CurrentCodeBuilder = curBuilder;

                CodeBuilder.AppendFormat("{0}{1} = {{", GetIndentString(), propertyName);
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
                    return;//应该不会走到这里
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

                    TryUsingAnalysis tryUsing = new TryUsingAnalysis();
                    tryUsing.Visit(node);
                    mi.ExistTry = tryUsing.ExistTry;
                    mi.ExistUsing = tryUsing.ExistUsing;

                    string manglingName = NameMangling(sym);
                    string keyword = accessor.Keyword.Text;
                    string paramStr = string.Join(", ", mi.ParamNames.ToArray());
                    if (!declSym.IsStatic) {
                        if (string.IsNullOrEmpty(paramStr))
                            paramStr = "this";
                        else
                            paramStr = "this, " + paramStr;
                    }
                    CodeBuilder.AppendFormat("{0}{1} = deffunc({2})args({3}){{", GetIndentString(), manglingName, mi.ReturnValueCount, paramStr);
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
                        CodeBuilder.AppendLine(");");
                    }
                    else if (null != accessor.Body) {
                        TryWrapParams(CodeBuilder, mi);
                        VisitBlock(accessor.Body);
                    }
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}}options[{1}];", GetIndentString(), mi.CalcFunctionOptions());
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
                    return;//抽象indexer不翻译，运行时处理
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

                    TryUsingAnalysis tryUsing = new TryUsingAnalysis();
                    tryUsing.Visit(node);
                    mi.ExistTry = tryUsing.ExistTry;
                    mi.ExistUsing = tryUsing.ExistUsing;

                    string manglingName = NameMangling(sym);
                    string paramStr = string.Join(", ", mi.ParamNames.ToArray());
                    if (!declSym.IsStatic) {
                        if (string.IsNullOrEmpty(paramStr))
                            paramStr = "this";
                        else
                            paramStr = "this, " + paramStr;
                    }
                    CodeBuilder.AppendFormat("{0}{1} = deffunc({2})args(this, {3}){{", GetIndentString(), manglingName, mi.ReturnValueCount, string.Join(", ", mi.ParamNames.ToArray()));
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    TryWrapParams(CodeBuilder, mi);
                    if (!string.IsNullOrEmpty(mi.OriginalParamsName)) {
                        CodeBuilder.AppendFormat("{0}local({1}); {1} = params({2});", GetIndentString(), mi.OriginalParamsName, mi.ParamsElementInfo);
                        CodeBuilder.AppendLine();
                    }
                    string varName = string.Format("__expbody_{0}", GetSourcePosForVar(node));
                    CodeBuilder.AppendFormat("{0}local({1}); {1} = ", GetIndentString(), varName);
                    IConversionOperation opd = null;
                    var oper = m_Model.GetOperationEx(node.ExpressionBody) as IBlockOperation;
                    if (null != oper && oper.Operations.Length == 1) {
                        var iret = oper.Operations[0] as IReturnOperation;
                        if (null != iret) {
                            opd = iret.ReturnedValue as IConversionOperation;
                        }
                    }
                    OutputExpressionSyntax(node.ExpressionBody.Expression, opd);
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("; return({0}, {1})", varName, string.Join(", ", mi.ReturnParamNames));
                    }
                    else {
                        CodeBuilder.AppendFormat("; return({0})", varName);
                    }
                    CodeBuilder.AppendLine(";");
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}}options[{1}];", GetIndentString(), mi.CalcFunctionOptions());
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

                    TryUsingAnalysis tryUsing = new TryUsingAnalysis();
                    tryUsing.Visit(node);
                    mi.ExistTry = tryUsing.ExistTry;
                    mi.ExistUsing = tryUsing.ExistUsing;

                    string manglingName = NameMangling(sym);
                    string keyword = accessor.Keyword.Text;
                    CodeBuilder.AppendFormat("{0}{1} = {2}deffunc({3})args(this, {4}){{", GetIndentString(), manglingName, mi.ExistYield ? "wrapenumerable(" : string.Empty, mi.ReturnValueCount, string.Join(", ", mi.ParamNames.ToArray()));
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    bool isStatic = declSym.IsStatic;
                    string dslModule = ClassInfo.GetAttributeArgument<string>(sym, "Cs2Dsl.TranslateToAttribute", 0);
                    string dslFuncName = ClassInfo.GetAttributeArgument<string>(sym, "Cs2Dsl.TranslateToAttribute", 1);
                    if (!sym.ReturnsVoid) {
                        string retVar = string.Format("__method_ret_{0}", GetSourcePosForVar(node));
                        mi.ReturnVarName = retVar;

                        CodeBuilder.AppendFormat("{0}local({1});", GetIndentString(), retVar);
                        CodeBuilder.AppendLine();
                    }
                    if (!string.IsNullOrEmpty(dslModule) || !string.IsNullOrEmpty(dslFuncName)) {
                        if (!string.IsNullOrEmpty(dslModule)) {
                            SymbolTable.Instance.AddRequire(ci.Key, dslModule);
                        }
                        if (sym.ReturnsVoid && mi.ReturnParamNames.Count <= 0) {
                            CodeBuilder.AppendFormat("{0}{1}({2}", GetIndentString(), dslFuncName, isStatic ? string.Empty : "this");
                        }
                        else {
                            string ma1 = string.Empty;
                            string ma2 = string.Empty;
                            if (!sym.ReturnsVoid && mi.ReturnParamNames.Count > 0 || mi.ReturnParamNames.Count > 1) {
                                ma1 = "multiassign(";
                                ma2 = ")";
                            }
                            CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), ma1);
                            string prestr = "";
                            if (!sym.ReturnsVoid) {
                                CodeBuilder.Append(mi.ReturnVarName);
                                prestr = ",";
                            }
                            foreach (var name in mi.ReturnParamNames) {
                                CodeBuilder.Append(prestr);
                                CodeBuilder.Append(name);
                                prestr = ", ";
                            }
                            CodeBuilder.AppendFormat("{0} = {1}({2}", ma2, dslFuncName, isStatic ? string.Empty : "this");
                        }
                        if (mi.ParamNames.Count > 0) {
                            if (!isStatic) {
                                CodeBuilder.Append(", ");
                            }
                            CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
                        }
                        CodeBuilder.AppendLine(");");
                        if (!sym.ReturnsVoid || mi.ParamNames.Count > 0) {
                            CodeBuilder.AppendFormat("{0}return(", GetIndentString());
                            string prestr = "";
                            if (!sym.ReturnsVoid) {
                                CodeBuilder.Append(mi.ReturnVarName);
                                prestr = ",";
                            }
                            foreach (var name in mi.ReturnParamNames) {
                                CodeBuilder.Append(prestr);
                                CodeBuilder.Append(name);
                                prestr = ", ";
                            }
                            CodeBuilder.AppendLine(");");
                        }
                    }
                    else {
                        TryWrapParams(CodeBuilder, mi);
                        if (!string.IsNullOrEmpty(mi.OriginalParamsName)) {
                            if (keyword == "get") {
                                CodeBuilder.AppendFormat("{0}local({1}); {1} = params({2});", GetIndentString(), mi.OriginalParamsName, mi.ParamsElementInfo);
                                CodeBuilder.AppendLine();
                            }
                            else {
                                CodeBuilder.AppendFormat("{0}local({1}); {1} = params({2});", GetIndentString(), mi.OriginalParamsName, mi.ParamsElementInfo);
                                CodeBuilder.AppendLine();
                                CodeBuilder.AppendFormat("{0}local(value); value = paramsremove({1});", GetIndentString(), mi.OriginalParamsName);
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
                                CodeBuilder.AppendFormat("{0}local({1}); {1} = ", GetIndentString(), varName);
                            }
                            IConversionOperation opd = null;
                            var oper = m_Model.GetOperationEx(accessor.ExpressionBody) as IBlockOperation;
                            if (null != oper && oper.Operations.Length == 1) {
                                var iret = oper.Operations[0] as IReturnOperation;
                                if (null != iret) {
                                    opd = iret.ReturnedValue as IConversionOperation;
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
                                    CodeBuilder.AppendFormat("; return({0})", varName);
                                }
                                CodeBuilder.AppendLine(";");
                            }
                        }
                    }
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}}options[{1}]{2};", GetIndentString(), mi.CalcFunctionOptions(), mi.ExistYield ? ")" : string.Empty);
                    CodeBuilder.AppendLine();

                    m_MethodInfoStack.Pop();
                }
            }

            ci.CurrentCodeBuilder = currentBuilder;
        }
        public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
        {
            AnalyzeCapturedValueVariable(node);
            SymbolInfo symInfo = m_Model.GetSymbolInfoEx(node);
            var sym = symInfo.Symbol as IMethodSymbol;

            if (null != sym && sym.Parameters.Length == 1) {
                var mi = new MethodInfo();
                mi.Init(sym, node);
                m_MethodInfoStack.Push(mi);
                if (node.Body is BlockSyntax) {
                    var param = sym.Parameters[0];
                    CodeBuilder.AppendFormat("deffunc({0})args({1}) {{", sym.ReturnsVoid ? 0 : 1, param.Name);
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    node.Body.Accept(this);
                    if (!sym.ReturnsVoid) {
                        CodeBuilder.AppendFormat("{0}return({1});", GetIndentString(), param.Name);
                        CodeBuilder.AppendLine();
                    }
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}}options[{1}]", GetIndentString(), mi.CalcFunctionOptions());
                }
                else {
                    var param = sym.Parameters[0];
                    string varName = string.Format("__lambda_{0}", GetSourcePosForVar(node));
                    CodeBuilder.AppendFormat("deffunc({0})args({1}) {{ local({2}); {2} = ", sym.ReturnsVoid ? 0 : 1, param.Name, varName);
                    IConversionOperation opd = null;
                    var oper = m_Model.GetOperationEx(node) as IAnonymousFunctionOperation;
                    if (null != oper && oper.Body.Operations.Length == 1) {
                        var iret = oper.Body.Operations[0] as IReturnOperation;
                        if (null != iret) {
                            opd = iret.ReturnedValue as IConversionOperation;
                        }
                    }
                    var exp = node.Body as ExpressionSyntax;
                    if (null != exp) {
                        OutputExpressionSyntax(exp, opd);
                    }
                    else {
                        ReportIllegalSymbol(node, symInfo);
                    }
                    CodeBuilder.AppendFormat("; return({0}); }}options[{1}]", varName, mi.CalcFunctionOptions());
                }
                m_MethodInfoStack.Pop();
            }
            else {
                ReportIllegalSymbol(node, symInfo);
            }
        }
        public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
        {
            AnalyzeCapturedValueVariable(node);
            SymbolInfo symInfo = m_Model.GetSymbolInfoEx(node);
            var sym = symInfo.Symbol as IMethodSymbol;
            if (null != sym) {
                var mi = new MethodInfo();
                mi.Init(sym, node);
                m_MethodInfoStack.Push(mi);

                TryUsingAnalysis tryUsing = new TryUsingAnalysis();
                tryUsing.Visit(node);
                mi.ExistTry = tryUsing.ExistTry;
                mi.ExistUsing = tryUsing.ExistUsing;

                CodeBuilder.AppendFormat("deffunc({0})args(", mi.ReturnValueCount);
                CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
                if (node.Body is BlockSyntax) {
                    CodeBuilder.AppendLine("){");
                    ++m_Indent;
                    if (!sym.ReturnsVoid) {
                        string retVar = string.Format("__method_ret_{0}", GetSourcePosForVar(node));
                        mi.ReturnVarName = retVar;

                        CodeBuilder.AppendFormat("{0}local({1});", GetIndentString(), retVar);
                        CodeBuilder.AppendLine();
                    }
                    TryWrapParams(CodeBuilder, mi);
                    if (!string.IsNullOrEmpty(mi.OriginalParamsName)) {
                        CodeBuilder.AppendFormat("{0}local({1}); {1} = params({2});", GetIndentString(), mi.OriginalParamsName, mi.ParamsElementInfo);
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
                    CodeBuilder.AppendFormat("{0}}}options[{1}]", GetIndentString(), mi.CalcFunctionOptions());
                }
                else {
                    string varName = string.Format("__lambda_{0}", GetSourcePosForVar(node));
                    CodeBuilder.Append("){ ");
                    CodeBuilder.AppendFormat("local({0}); {0} = ", varName);
                    IConversionOperation opd = null;
                    var oper = m_Model.GetOperationEx(node) as IAnonymousFunctionOperation;
                    if (null != oper && oper.Body.Operations.Length == 1) {
                        var iret = oper.Body.Operations[0] as IReturnOperation;
                        if (null != iret) {
                            opd = iret.ReturnedValue as IConversionOperation;
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
                        CodeBuilder.AppendFormat("; return({0})", varName);
                    }
                    CodeBuilder.Append("; }");
                    CodeBuilder.AppendFormat("options[{0}]", mi.CalcFunctionOptions());
                }
                m_MethodInfoStack.Pop();
            }
            else {
                ReportIllegalSymbol(node, symInfo);
            }
        }
        public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
        {
            AnalyzeCapturedValueVariable(node);
            SymbolInfo symInfo = m_Model.GetSymbolInfoEx(node);
            var sym = symInfo.Symbol as IMethodSymbol;
            if (null != sym) {
                var mi = new MethodInfo();
                mi.Init(sym, node);
                m_MethodInfoStack.Push(mi);

                TryUsingAnalysis tryUsing = new TryUsingAnalysis();
                tryUsing.Visit(node);
                mi.ExistTry = tryUsing.ExistTry;
                mi.ExistUsing = tryUsing.ExistUsing;

                CodeBuilder.AppendFormat("deffunc({0})args(", mi.ReturnValueCount);
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
                if (!sym.ReturnsVoid) {
                    string retVar = string.Format("__method_ret_{0}", GetSourcePosForVar(node));
                    mi.ReturnVarName = retVar;

                    CodeBuilder.AppendFormat("{0}local({1});", GetIndentString(), retVar);
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
                CodeBuilder.AppendFormat("{0}}}options[{1}]", GetIndentString(), mi.CalcFunctionOptions());

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
            ClassInfo ci = m_ClassInfoStack.Peek();
            MethodInfo mi = m_MethodInfoStack.Peek();

            string srcPos = GetSourcePosForVar(node);
            string varName = string.Format("__using_{0}", srcPos);
            string retVar = string.Format("__using_ret_{0}", srcPos);
            string retValVar = string.Format("__using_ret_val_{0}", srcPos);
            if (null != node.Declaration) {
                VisitVariableDeclaration(node.Declaration);
            }
            else if (null != node.Expression) {
                CodeBuilder.AppendFormat("{0}local({1}); {1} = ", GetIndentString(), varName);
                IConversionOperation opd = m_Model.GetOperationEx(node.Expression) as IConversionOperation;
                OutputExpressionSyntax(node.Expression, opd);
                CodeBuilder.AppendLine(";");
            }
            else {
                Log(node, "node.Declaration and node.Expression are null.");
            }
            if (null != node.Statement) {
                ReturnContinueBreakAnalysis returnAnalysis = new ReturnContinueBreakAnalysis();
                returnAnalysis.RetValVar = retValVar;
                returnAnalysis.Visit(node.Statement);

                mi.TempReturnAnalysisStack.Push(returnAnalysis);

                if (mi.IsAnonymousOrLambdaMethod) {
                    CodeBuilder.AppendFormat("{0}local({1}, {2}); multiassign({1}, {2}) = dslusing({3}, {1}){{", GetIndentString(), retVar, retValVar, returnAnalysis.ExistReturnInLoopOrSwitch ? "true" : "false");
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    ++mi.TryUsingLayer;
                    node.Statement.Accept(this);
                    --mi.TryUsingLayer;
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                    CodeBuilder.AppendLine();
                }
                else {
                    //普通函数里的using块拆分成方法
                    var dataFlow = m_Model.AnalyzeDataFlow(node.Statement);
                    var ctrlFlow = m_Model.AnalyzeControlFlow(node.Statement);
                    List<string> inputs, outputs;
                    string paramsStr;
                    string outParamsStr = mi.CalcTryUsingFuncInfo(dataFlow, ctrlFlow, out inputs, out outputs, out paramsStr);

                    returnAnalysis.OutParamsStr = outParamsStr;

                    string prestr = ", ";
                    string usingFunc = string.Format("__using_func_{0}", srcPos);
                    bool isStatic = mi.SemanticInfo.IsStatic;

                    if (ctrlFlow.ReturnStatements.Length > 0 && !string.IsNullOrEmpty(mi.ReturnVarName)) {
                        CodeBuilder.AppendFormat("{0}local({1}_0); {1}_0 = {2}", GetIndentString(), retValVar, mi.ReturnVarName);
                        CodeBuilder.AppendLine(";");
                    }
                    if (outputs.Count > 0) {
                        for (int i = 0; i < outputs.Count; ++i) {
                            CodeBuilder.AppendFormat("{0}local({1}_{2}); {1}_{2} = {3}", GetIndentString(), retValVar, i + 1, outputs[i]);
                            CodeBuilder.AppendLine(";");
                        }
                    }
                    CodeBuilder.AppendFormat("{0}local({1}, {2}); multiassign({1}, {2}", GetIndentString(), retVar, retValVar);
                    if (ctrlFlow.ReturnStatements.Length > 0 && !string.IsNullOrEmpty(mi.ReturnVarName)) {
                        CodeBuilder.AppendFormat(", {0}_0", retValVar);
                    }
                    if (outputs.Count > 0) {
                        for (int i = 0; i < outputs.Count; ++i) {
                            CodeBuilder.AppendFormat(", {0}_{1}", retValVar, i + 1);
                        }
                    }
                    CodeBuilder.AppendFormat(") = dslusingfunc({0}, {1}, {2}, {3}, {4}, {5}", retVar, retValVar, usingFunc, ci.Key, isStatic ? "true" : "false", dataFlow.DataFlowsOut.Length + (string.IsNullOrEmpty(mi.ReturnVarName) ? 1 : 2));
                    if (!string.IsNullOrEmpty(paramsStr)) {
                        CodeBuilder.Append(prestr);
                        CodeBuilder.Append(paramsStr);
                    }
                    CodeBuilder.AppendLine("){");
                    ++m_Indent;
                    ++mi.TryUsingLayer;
                    node.Statement.Accept(this);
                    if (outputs.Count > 0) {
                        bool needReturn = true;
                        if (ctrlFlow.ReturnStatements.Length > 0) {
                            var returnNode = ctrlFlow.ReturnStatements[ctrlFlow.ReturnStatements.Length - 1];
                            var retSyntax = returnNode as ReturnStatementSyntax;
                            if (null != retSyntax) {
                                if (IsLastNodeOfTryCatch(returnNode))
                                    needReturn = false;
                            }
                        }
                        if (needReturn) {
                            //return(0)代表非try块里的返回语句
                            CodeBuilder.AppendFormat("{0}return(0", GetIndentString());
                            if (!string.IsNullOrEmpty(outParamsStr)) {
                                CodeBuilder.Append(prestr);
                                CodeBuilder.Append(outParamsStr);
                            }
                            CodeBuilder.AppendLine(");");
                        }
                    }
                    --mi.TryUsingLayer;
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}}options[{1}];", GetIndentString(), mi.CalcTryUsingFuncOptions(dataFlow, ctrlFlow, inputs, outputs));
                    CodeBuilder.AppendLine();

                    if (!string.IsNullOrEmpty(outParamsStr)) {
                        CodeBuilder.AppendFormat("{0}if({1}){{", GetIndentString(), retVar);
                        CodeBuilder.AppendLine();
                        ++m_Indent;
                        if (ctrlFlow.ReturnStatements.Length > 0 && !string.IsNullOrEmpty(mi.ReturnVarName)) {
                            CodeBuilder.AppendFormat("{0}{1} = {2}_0", GetIndentString(), mi.ReturnVarName, retValVar);
                            CodeBuilder.AppendLine(";");
                        }
                        if (outputs.Count > 0) {
                            for (int i = 0; i < outputs.Count; ++i) {
                                CodeBuilder.AppendFormat("{0}{1} = {2}_{3}", GetIndentString(), outputs[i], retValVar, i + 1);
                                CodeBuilder.AppendLine(";");
                            }
                        }
                        --m_Indent;
                        CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                        CodeBuilder.AppendLine();
                    }
                }

                mi.TempReturnAnalysisStack.Pop();

                if (null != node.Declaration && null != node.Declaration.Variables) {
                    foreach (var decl in node.Declaration.Variables) {
                        var declSym = m_Model.GetDeclaredSymbol(decl) as ILocalSymbol;
                        var type = declSym.Type;
                        var msym = GetDisposeMethod(type);
                        if (null != msym) {
                            var fn = ClassInfo.GetFullName(msym.ContainingType);
                            CodeBuilder.AppendFormat("{0}callexterninstance({1}, {2}, \"Dispose\");", GetIndentString(), decl.Identifier.Text, fn);
                            CodeBuilder.AppendLine();
                        }
                    }
                }
                else if (null != node.Expression) {
                    var type = m_Model.GetTypeInfoEx(node.Expression).Type;
                    var msym = GetDisposeMethod(type);
                    if (null != msym) {
                        var fn = ClassInfo.GetFullName(msym.ContainingType);
                        CodeBuilder.AppendFormat("{0}callexterninstance({1}, {2}, \"Dispose\");", GetIndentString(), varName, fn);
                        CodeBuilder.AppendLine();
                    }
                }
                else {
                    Log(node, "node.Declaration is null or node.Declaration.Variables is null, and node.Expression is null.");
                }

                OutputTryCatchUsingReturn(returnAnalysis, mi, retValVar);
                return;
            }
            else {
                Log(node, "node.Statement is null.");
            }
            if (null != node.Declaration && null != node.Declaration.Variables) {
                foreach (var decl in node.Declaration.Variables) {
                    var declSym = m_Model.GetDeclaredSymbol(decl) as ILocalSymbol;
                    var type = declSym.Type;
                    var msym = GetDisposeMethod(type);
                    if (null != msym) {
                        var fn = ClassInfo.GetFullName(msym.ContainingType);
                        CodeBuilder.AppendFormat("{0}callexterninstance({1}, {2}, \"Dispose\");", GetIndentString(), decl.Identifier.Text, fn);
                        CodeBuilder.AppendLine();
                    }
                }
            }
            else if (null != node.Expression) {
                var type = m_Model.GetTypeInfoEx(node.Expression).Type;
                var msym = GetDisposeMethod(type);
                if (null != msym) {
                    var fn = ClassInfo.GetFullName(msym.ContainingType);
                    CodeBuilder.AppendFormat("{0}callexterninstance({1}, {2}, \"Dispose\");", GetIndentString(), varName, fn);
                    CodeBuilder.AppendLine();
                }
            }
            else {
                Log(node, "node.Declaration is null or node.Declaration.Variables is null, and node.Expression is null.");
            }
        }
        #endregion
    }
}