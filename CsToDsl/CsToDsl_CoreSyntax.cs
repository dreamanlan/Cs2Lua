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
        internal void VisitExpressionSyntax(ExpressionSyntax node)
        {
            VisitExpressionSyntax(node, false);
        }
        private void VisitExpressionSyntax(ExpressionSyntax node, bool dslStrToCsStr)
        {
            var oper = m_Model.GetOperationEx(node);
            var constVal = m_Model.GetConstantValueEx(node);
            if (constVal.HasValue) {
                object val = constVal.Value;
                OutputConstValue(val, oper, dslStrToCsStr);
                return;
            }
            node.Accept(this);
        }        
        private void VisitTypeDeclarationSyntax(TypeDeclarationSyntax node)
        {
            INamedTypeSymbol declSym = m_Model.GetDeclaredSymbol(node);
            bool ignore = ClassInfo.HasAttribute(declSym, "Cs2Dsl.IgnoreAttribute");
            if (!ignore) {
                if (m_SkipGenericTypeDefine && declSym.IsGenericType) {
                    node.Accept(new InnerClassAnalysis(m_Model));
                    return;
                }
            }
            if (!m_SkipGenericTypeDefine && !ClassInfo.IsOriginalOrContainingGenericType(m_GenericTypeInstance, declSym)) {
                if (!ignore) {
                    DerivedGenericTypeInstanceInfo instInfo = new DerivedGenericTypeInstanceInfo();
                    instInfo.Symbol = declSym;
                    instInfo.Node = node;
                    instInfo.FillTypeParamsAndArgs(declSym);
                    m_DerivedGenericTypeInstances.Enqueue(instInfo);
                }
                return;
            }
            declSym = GetTypeDefineSymbol(declSym);

            ClassInfo ci = new ClassInfo();
            ClassSymbolInfo info;
            SymbolTable.Instance.ClassSymbols.TryGetValue(ClassInfo.GetFullNameWithTypeParameters(declSym), out info);
            ci.Init(declSym, info);
            if (null != declSym) {
                string[] requires = ClassInfo.GetAttributeArguments<string>(declSym, "Cs2Dsl.RequireAttribute", 0);
                if (null != requires) {
                    foreach (var req in requires) {
                        SymbolTable.Instance.AddRequire(ci.Key, req);
                    }
                }
                if (ClassInfo.HasAttribute(declSym, "Cs2Dsl.IgnoreAttribute"))
                    return;
            }

            m_ClassInfoStack.Push(ci);

            if (m_ClassInfoStack.Count == 1) {
                ci.BeforeOuterCodeBuilder.Append(m_ToplevelCodeBuilder.ToString());
                m_ToplevelCodeBuilder.Clear();
            }

            if (!m_EnableInherit && !ClassInfo.HasAttribute(declSym, "Cs2Dsl.EnableInheritAttribute") && !ClassInfo.HasAttribute(declSym.BaseType, "Cs2Dsl.EnableInheritAttribute")) {
                if (!string.IsNullOrEmpty(ci.BaseKey)) {
                    Log(node, "Cs2Dsl class/struct '{0}' can't inherit '{1}' !", ci.Key, ci.BaseKey);
                }
            }
            if(null != declSym.BaseType && declSym.BaseType.IsAbstract && !string.IsNullOrEmpty(ci.BaseKey) && !SymbolTable.Instance.IsCs2DslSymbol(declSym.BaseType)) {
                Log(node, "Cs2Dsl class/struct '{0}' can't inherit c# abstract class '{1}' !", ci.Key, ci.BaseKey);
            }

            if (!string.IsNullOrEmpty(ci.BaseKey)) {
                AddReferenceAndTryDeriveGenericTypeInstance(ci, declSym.BaseType);
            }
            if (declSym.IsGenericType || ci.IsInnerOfGenericType) {
                //泛型类及其嵌入类不与包含类放在同一文件里，所以需要依赖包含类
                var ctype = declSym.ContainingType;
                if (null != ctype) {
                    AddReferenceAndTryDeriveGenericTypeInstance(ci, ctype);
                }
            }

            TypeInfo typeInfo = m_Model.GetTypeInfoEx(node);
            var type = typeInfo.Type;

            ++m_Indent;
            ++m_Indent;
            foreach (var member in node.Members) {
                var baseSym = m_Model.GetDeclaredSymbol(member);
                var methodSym = baseSym as IMethodSymbol;
                var propSym = baseSym as IPropertySymbol;
                var eventSym = baseSym as IEventSymbol;
                if (null != methodSym && methodSym.IsStatic) {
                    ci.CurrentCodeBuilder = ci.StaticFunctionCodeBuilder;
                    member.Accept(this);
                }
                if (null != propSym && propSym.IsStatic) {
                    ci.CurrentCodeBuilder = ci.StaticPropertyCodeBuilder;
                    member.Accept(this);
                }
                if (null != eventSym && eventSym.IsStatic) {
                    ci.CurrentCodeBuilder = ci.StaticEventCodeBuilder;
                    member.Accept(this);
                }
            }
            ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;
            foreach (var member in node.Members) {
                FieldDeclarationSyntax fieldDecl = member as FieldDeclarationSyntax;
                if (null != fieldDecl) {
                    VisitFieldDeclaration(ci, fieldDecl, true);
                }
                EventFieldDeclarationSyntax eventFieldDecl = member as EventFieldDeclarationSyntax;
                if (null != eventFieldDecl) {
                    VisitEventFieldDeclaration(ci, eventFieldDecl, true);
                }
            }
            foreach (var member in node.Members) {
                var baseSym = m_Model.GetDeclaredSymbol(member);
                var methodSym = baseSym as IMethodSymbol;
                var propSym = baseSym as IPropertySymbol;
                var eventSym = baseSym as IEventSymbol;
                if (null != methodSym && !methodSym.IsStatic) {
                    ci.CurrentCodeBuilder = ci.InstanceFunctionCodeBuilder;
                    member.Accept(this);
                }
                if (null != propSym && !propSym.IsStatic) {
                    ci.CurrentCodeBuilder = ci.InstancePropertyCodeBuilder;
                    member.Accept(this);
                }
                if (null != eventSym && !eventSym.IsStatic) {
                    ci.CurrentCodeBuilder = ci.InstanceEventCodeBuilder;
                    member.Accept(this);
                }
            }
            ci.CurrentCodeBuilder = ci.InstanceFieldCodeBuilder;
            foreach (var member in node.Members) {
                FieldDeclarationSyntax fieldDecl = member as FieldDeclarationSyntax;
                if (null != fieldDecl) {
                    VisitFieldDeclaration(ci, fieldDecl, false);
                }
                EventFieldDeclarationSyntax eventFieldDecl = member as EventFieldDeclarationSyntax;
                if (null != eventFieldDecl) {
                    VisitEventFieldDeclaration(ci, eventFieldDecl, false);
                }
            }
            --m_Indent;
            --m_Indent;

            foreach (var member in node.Members) {
                var typeDecl = member as BaseTypeDeclarationSyntax;
                if (null != typeDecl) {
                    typeDecl.Accept(this);
                }
            }

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
        private void VisitCommonMethodDeclaration(IMethodSymbol declSym, SyntaxNode node, BlockSyntax body, ArrowExpressionClauseSyntax expressionBody)
        {
            var ci = m_ClassInfoStack.Peek();

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
                if (null == body && null == expressionBody) //partial method declaration
                    return;
            }

            var mi = new MethodInfo();
            mi.Init(declSym, node);
            m_MethodInfoStack.Push(mi);

            TryUsingAnalysis tryUsing = new TryUsingAnalysis();
            tryUsing.Visit(node);
            mi.ExistTry = tryUsing.ExistTry;
            mi.ExistUsing = tryUsing.ExistUsing;

            string manglingName = NameMangling(declSym);
            bool isExtension = declSym.IsExtensionMethod;
            if (isExtension && declSym.Parameters.Length > 0) {
                var targetType = declSym.Parameters[0].Type;
                AddReferenceAndTryDeriveGenericTypeInstance(ci, targetType);
            }
            bool isStatic = declSym.IsStatic;
            CodeBuilder.AppendFormat("{0}{1} = {2}deffunc({3})args({4}", GetIndentString(), manglingName, mi.ExistYield ? "wrapenumerable(" : string.Empty, mi.ReturnValueCount, isStatic ? string.Empty : "this");
            if (mi.ParamNames.Count > 0) {
                if (!isStatic) {
                    CodeBuilder.Append(", ");
                }
                CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
            }
            CodeBuilder.Append("){");
            CodeBuilder.AppendLine();
            ++m_Indent;

            string dslModule = ClassInfo.GetAttributeArgument<string>(declSym, "Cs2Dsl.TranslateToAttribute", 0);
            string dslFuncName = ClassInfo.GetAttributeArgument<string>(declSym, "Cs2Dsl.TranslateToAttribute", 1);
            if (!declSym.ReturnsVoid) {
                string retVar = string.Format("__method_ret_{0}", GetSourcePosForVar(node));
                mi.ReturnVarName = retVar;

                CodeBuilder.AppendFormat("{0}local({1});", GetIndentString(), retVar);
                CodeBuilder.AppendLine();
            }
            if (string.IsNullOrEmpty(dslModule) && string.IsNullOrEmpty(dslFuncName)) {                
                TryWrapParams(CodeBuilder, mi);
            }
            if (!string.IsNullOrEmpty(dslModule) || !string.IsNullOrEmpty(dslFuncName)) {
                if (!string.IsNullOrEmpty(dslModule)) {
                    SymbolTable.Instance.AddRequire(ci.Key, dslModule);
                }
                if (declSym.ReturnsVoid && mi.ReturnParamNames.Count <= 0) {
                    CodeBuilder.AppendFormat("{0}{1}({2}", GetIndentString(), dslFuncName, isStatic ? string.Empty : "this");
                }
                else {
                    string ma1 = string.Empty;
                    string ma2 = string.Empty;
                    if (!declSym.ReturnsVoid && mi.ReturnParamNames.Count > 0 || mi.ReturnParamNames.Count > 1) {
                        ma1 = "multiassign(";
                        ma2 = ")";
                    }
                    CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), ma1);
                    string prestr = "";
                    if (!declSym.ReturnsVoid) {
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
                if (!declSym.ReturnsVoid || mi.ParamNames.Count > 0) {
                    CodeBuilder.AppendFormat("{0}return(", GetIndentString());
                    string prestr = "";
                    if (!declSym.ReturnsVoid) {
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
            else if (null != body) {
                VisitBlock(body);
                if (!mi.ExistTopLevelReturn) {
                    if (declSym.ReturnsVoid) {
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
            else if (null != expressionBody) {
                string varName = string.Format("__expbody_{0}", GetSourcePosForVar(node));
                if (!declSym.ReturnsVoid) {
                    CodeBuilder.AppendFormat("{0}local({1}); {1} = ", GetIndentString(), varName);
                }
                IConversionOperation opd = null;
                var oper = m_Model.GetOperationEx(expressionBody) as IBlockOperation;
                if (null != oper && oper.Operations.Length == 1) {
                    var iret = oper.Operations[0] as IReturnOperation;
                    if (null != iret) {
                        opd = iret.ReturnedValue as IConversionOperation;
                    }
                }
                if (declSym.ReturnsVoid) {
                    CodeBuilder.AppendFormat("{0}", GetIndentString());
                    if (expressionBody.Expression is AssignmentExpressionSyntax) {
                        VisitToplevelExpression(expressionBody.Expression, string.Empty);
                    }
                    else {
                        OutputExpressionSyntax(expressionBody.Expression, opd);
                    }
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("; return({0})", string.Join(", ", mi.ReturnParamNames));
                    }
                    CodeBuilder.AppendLine(";");
                }
                else {
                    OutputExpressionSyntax(expressionBody.Expression, opd);
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("; return({0}, {1})", varName, string.Join(", ", mi.ReturnParamNames));
                    }
                    else {
                        CodeBuilder.AppendFormat("; return({0})", varName);
                    }
                    CodeBuilder.AppendLine(";");
                }
            }
            --m_Indent;
            CodeBuilder.AppendFormat("{0}}}options[{1}]{2};", GetIndentString(), mi.CalcFunctionOptions(), mi.ExistYield ? ")" : string.Empty);
            CodeBuilder.AppendLine();
            m_MethodInfoStack.Pop();
        }
        private void VisitFieldDeclaration(ClassInfo ci, FieldDeclarationSyntax fieldDecl, bool isStatic)
        {
            foreach (var v in fieldDecl.Declaration.Variables) {
                var baseSym = m_Model.GetDeclaredSymbol(v);
                if (null != baseSym) {
                    string[] requires = ClassInfo.GetAttributeArguments<string>(baseSym, "Cs2Dsl.RequireAttribute", 0);
                    if (null != requires) {
                        foreach (var req in requires) {
                            SymbolTable.Instance.AddRequire(ci.Key, req);
                        }
                    }
                    if (ClassInfo.HasAttribute(baseSym, "Cs2Dsl.IgnoreAttribute"))
                        continue;
                }
                else {
                    Log(v, "Can't get field declared symbol !");
                    continue;
                }
                var fieldSym = baseSym as IFieldSymbol;
                if (isStatic && fieldSym.IsStatic || !isStatic && !fieldSym.IsStatic) {
                    var type = fieldSym.Type;
                    if (type.TypeKind == TypeKind.TypeParameter && !m_SkipGenericTypeDefine && null != m_GenericTypeInstance) {
                        for (int i = 0; i < m_GenericTypeInstance.TypeParameters.Length; ++i) {
                            var t = m_GenericTypeInstance.TypeParameters[i];
                            var rt = m_GenericTypeInstance.TypeArguments[i];
                            string name1 = ClassInfo.SpecialGetFullTypeNameWithTypeParameters(t);
                            string name2 = ClassInfo.SpecialGetFullTypeNameWithTypeParameters(type);
                            if (name1 == name2) {
                                type = rt;
                            }
                        }
                    }

                    string name = v.Identifier.Text;
                    if (null != v.Initializer) {
                        m_FieldInitializerStack.Push(fieldSym);

                        IConversionOperation opd = null;
                        var initOper = m_Model.GetOperationEx(v.Initializer) as ISymbolInitializerOperation;
                        if (null != initOper) {
                            opd = initOper.Value as IConversionOperation;
                        }
                        var expOper = m_Model.GetOperationEx(v.Initializer.Value);
                        var constVal = expOper.ConstantValue;
                        if (!constVal.HasValue) {
                            CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                            CodeBuilder.Append(" = ");
                            OutputDefaultValue(type, true);
                            CodeBuilder.AppendLine(";");
                            if (isStatic) {
                                ci.CurrentCodeBuilder = ci.StaticInitializerCodeBuilder;
                            }
                            else {
                                ci.CurrentCodeBuilder = ci.InstanceInitializerCodeBuilder;
                            }
                            ++m_Indent;
                            CodeBuilder.Append(GetIndentString());
                            if (isStatic) {
                                CodeBuilder.Append("setstatic(SymbolKind.Field, ");
                                CodeBuilder.Append(ci.Key);
                                CodeBuilder.AppendFormat(", \"{0}\", ", name);
                            }
                            else {
                                CodeBuilder.Append("setinstance(SymbolKind.Field, this, ");
                                CodeBuilder.Append(ci.Key);
                                CodeBuilder.AppendFormat(", \"{0}\", ", name);
                            }
                            OutputExpressionSyntax(v.Initializer.Value, opd);
                            CodeBuilder.AppendLine(");");
                            if (type.IsValueType && !SymbolTable.IsBasicType(type)) {
                                if (isStatic)
                                    MarkStaticCtorNeedFuncInfo();
                                else
                                    MarkCtorNeedFuncInfo();
                                //回收旧值，保持新值
                                CodeBuilder.Append(GetIndentString());
                                CodeBuilder.Append("recycleandkeepstructvalue(");
                                CodeBuilder.Append(ClassInfo.GetFullName(type));
                                CodeBuilder.Append(", nil, ");
                                if (isStatic) {
                                    CodeBuilder.Append("getstatic(SymbolKind.Field, ");
                                    CodeBuilder.Append(ci.Key);
                                    CodeBuilder.AppendFormat(", \"{0}\")", name);
                                }
                                else {
                                    CodeBuilder.Append("getinstance(SymbolKind.Field, this, ");
                                    CodeBuilder.Append(ci.Key);
                                    CodeBuilder.AppendFormat(", \"{0}\")", name);
                                }
                                CodeBuilder.AppendLine(");");
                            }
                            --m_Indent;
                            if (isStatic) {
                                ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;
                            }
                            else {
                                ci.CurrentCodeBuilder = ci.InstanceFieldCodeBuilder;
                            }

                            m_FieldInitializerStack.Pop();
                            continue;
                        }
                        else if (type.TypeKind == TypeKind.Delegate) {
                            CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                            CodeBuilder.Append(" = ");
                            if (null != constVal.Value) {
                                OutputConstValue(constVal.Value, expOper);
                            }
                            else {
                                CodeBuilder.Append("null");
                            }
                        }
                        else {
                            CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                            CodeBuilder.Append(" = ");
                            if (null != constVal.Value) {
                                OutputConstValue(constVal.Value, expOper);
                            }
                            else if (type.IsValueType) {
                                OutputDefaultValue(type, true);
                                if (isStatic) {
                                    ci.CurrentCodeBuilder = ci.StaticInitializerCodeBuilder;
                                }
                                else {
                                    ci.CurrentCodeBuilder = ci.InstanceInitializerCodeBuilder;
                                }
                                ++m_Indent;
                                CodeBuilder.Append(GetIndentString());
                                if (isStatic) {
                                    CodeBuilder.Append("setstatic(SymbolKind.Field, ");
                                    CodeBuilder.Append(ci.Key);
                                    CodeBuilder.AppendFormat(", \"{0}\", ", name);
                                }
                                else {
                                    CodeBuilder.Append("setinstance(SymbolKind.Field, this, ");
                                    CodeBuilder.Append(ci.Key);
                                    CodeBuilder.AppendFormat(", \"{0}\", ", name);
                                }
                                OutputNewValueType(type as INamedTypeSymbol);
                                CodeBuilder.AppendLine(");");
                                if (!SymbolTable.IsBasicType(type)) {
                                    if (isStatic)
                                        MarkStaticCtorNeedFuncInfo();
                                    else
                                        MarkCtorNeedFuncInfo();
                                    //回收旧值，保持新值
                                    CodeBuilder.Append(GetIndentString());
                                    CodeBuilder.Append("recycleandkeepstructvalue(");
                                    CodeBuilder.Append(ClassInfo.GetFullName(type));
                                    CodeBuilder.Append(", nil, ");
                                    if (isStatic) {
                                        CodeBuilder.Append("getstatic(SymbolKind.Field, ");
                                        CodeBuilder.Append(ci.Key);
                                        CodeBuilder.AppendFormat(", \"{0}\")", name);
                                    }
                                    else {
                                        CodeBuilder.Append("getinstance(SymbolKind.Field, this, ");
                                        CodeBuilder.Append(ci.Key);
                                        CodeBuilder.AppendFormat(", \"{0}\")", name);
                                    }
                                    CodeBuilder.AppendLine(");");
                                }
                                --m_Indent;
                                if (isStatic) {
                                    ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;
                                }
                                else {
                                    ci.CurrentCodeBuilder = ci.InstanceFieldCodeBuilder;
                                }
                            }
                            else {
                                OutputDefaultValue(type);
                            }
                        }

                        m_FieldInitializerStack.Pop();
                    }
                    else if (type.IsValueType) {
                        if (SymbolTable.IsBasicType(type)) {
                            CodeBuilder.AppendFormat("{0}{1} = ", GetIndentString(), name);
                            OutputDefaultValue(type);
                        }
                        else {
                            CodeBuilder.AppendFormat("{0}{1} = ", GetIndentString(), name);
                            OutputDefaultValue(type, true);
                            if (isStatic) {
                                ci.CurrentCodeBuilder = ci.StaticInitializerCodeBuilder;
                            }
                            else {
                                ci.CurrentCodeBuilder = ci.InstanceInitializerCodeBuilder;
                            }
                            ++m_Indent;
                            CodeBuilder.Append(GetIndentString());
                            if (isStatic) {
                                CodeBuilder.Append("setstatic(SymbolKind.Field, ");
                                CodeBuilder.Append(ci.Key);
                                CodeBuilder.AppendFormat(", \"{0}\", ", name);
                            }
                            else {
                                CodeBuilder.Append("setinstance(SymbolKind.Field, this, ");
                                CodeBuilder.Append(ci.Key);
                                CodeBuilder.AppendFormat(", \"{0}\", ", name);
                            }
                            OutputNewValueType(type as INamedTypeSymbol);
                            CodeBuilder.AppendLine(");");
                            if (isStatic)
                                MarkStaticCtorNeedFuncInfo();
                            else
                                MarkCtorNeedFuncInfo();
                            //回收旧值，保持新值
                            CodeBuilder.Append(GetIndentString());
                            CodeBuilder.Append("recycleandkeepstructvalue(");
                            CodeBuilder.Append(ClassInfo.GetFullName(type));
                            CodeBuilder.Append(", nil, ");
                            if (isStatic) {
                                CodeBuilder.Append("getstatic(SymbolKind.Field, ");
                                CodeBuilder.Append(ci.Key);
                                CodeBuilder.AppendFormat(", \"{0}\")", name);
                            }
                            else {
                                CodeBuilder.Append("getinstance(SymbolKind.Field, this, ");
                                CodeBuilder.Append(ci.Key);
                                CodeBuilder.AppendFormat(", \"{0}\")", name);
                            }
                            CodeBuilder.AppendLine(");");
                            --m_Indent;
                            if (isStatic) {
                                ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;
                            }
                            else {
                                ci.CurrentCodeBuilder = ci.InstanceFieldCodeBuilder;
                            }
                        }
                    }
                    else {
                        CodeBuilder.AppendFormat("{0}{1} = ", GetIndentString(), name);
                        OutputDefaultValue(type);
                    }
                    CodeBuilder.Append(";");
                    CodeBuilder.AppendLine();
                }
            }
        }
        private void VisitEventFieldDeclaration(ClassInfo ci, EventFieldDeclarationSyntax eventFieldDecl, bool isStatic)
        {
            foreach (var v in eventFieldDecl.Declaration.Variables) {
                var baseSym = m_Model.GetDeclaredSymbol(v);
                if (null != baseSym) {
                    string[] requires = ClassInfo.GetAttributeArguments<string>(baseSym, "Cs2Dsl.RequireAttribute", 0);
                    if (null != requires) {
                        foreach (var req in requires) {
                            SymbolTable.Instance.AddRequire(ci.Key, req);
                        }
                    }
                    if (ClassInfo.HasAttribute(baseSym, "Cs2Dsl.IgnoreAttribute"))
                        continue;
                }
                else {
                    Log(v, "Can't get event field declared symbol !");
                    continue;
                }
                var fieldSym = baseSym as IEventSymbol;
                if (isStatic && fieldSym.IsStatic || !isStatic && !fieldSym.IsStatic) {
                    string name = v.Identifier.Text;
                    if (null != v.Initializer) {
                        IConversionOperation opd = null;
                        var initOper = m_Model.GetOperationEx(v.Initializer) as ISymbolInitializerOperation;
                        if (null != initOper) {
                            opd = initOper.Value as IConversionOperation;
                        }
                        var expOper = m_Model.GetOperationEx(v.Initializer.Value);
                        var constVal = expOper.ConstantValue;
                        CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                        CodeBuilder.Append(" = ");
                        if (!constVal.HasValue || constVal.Value != null) {
                            OutputExpressionSyntax(v.Initializer.Value, opd);
                        }
                        else {
                            CodeBuilder.Append("null");
                        }
                    }
                    else {
                        CodeBuilder.AppendFormat("{0}{1} = null", GetIndentString(), name);
                    }
                    CodeBuilder.Append(";");
                    CodeBuilder.AppendLine();
                }
            }
        }
        /// <summary>
        /// C#的ref/out参数需要翻译到lua的多返回语句，由于函数调用可能是表达式的一部分，这导致作为顶层表达式与嵌入在表达式中的一部分
        /// 的翻译方式不一样，嵌入的部分需要使用匿名函数封装。这里是作为顶层表达式的入口。
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="expTerminater"></param>
        private void VisitToplevelExpression(ExpressionSyntax expression, string expTerminater)
        {
            var ci = m_ClassInfoStack.Peek();

            AssignmentExpressionSyntax assign = expression as AssignmentExpressionSyntax;
            if (null != assign) {
                string op = assign.OperatorToken.Text;
                string baseOp = op.Substring(0, op.Length - 1);
                var leftMemberAccess = assign.Left as MemberAccessExpressionSyntax;
                var leftElementAccess = assign.Left as ElementAccessExpressionSyntax;
                var leftCondAccess = assign.Left as ConditionalAccessExpressionSyntax;

                var leftOper = m_Model.GetOperationEx(assign.Left);
                var leftSymbolInfo = m_Model.GetSymbolInfoEx(assign.Left);
                var leftSym = leftSymbolInfo.Symbol;
                var leftPsym = leftSym as IPropertySymbol;
                var leftEsym = leftSym as IEventSymbol;
                var leftFsym = leftSym as IFieldSymbol;

                var rightOper = m_Model.GetOperationEx(assign.Right);
                var rightSymbolInfo = m_Model.GetSymbolInfoEx(assign.Right);
                var rightSym = rightSymbolInfo.Symbol;

                var leftType = m_Model.GetTypeInfoEx(assign.Left).Type;
                var rightType = m_Model.GetTypeInfoEx(assign.Right).Type;

                var rightConstValue = m_Model.GetConstantValueEx(assign.Right);

                var curMethod = GetCurMethodSemanticInfo();
                if (null != leftType && null != rightType) {
                    TypeChecker.CheckConvert(m_Model, rightType, leftType, assign, curMethod);
                }
                else if (null == leftType || leftType.TypeKind != TypeKind.Delegate && !rightConstValue.HasValue) {
                    Log(assign, "assignment type checker failed ! left type:{0} right type:{1}", leftType, rightType);
                }

                SpecialAssignmentType specialType = SpecialAssignmentType.None;
                if (null != leftMemberAccess && null != leftPsym) {
                    if (!leftPsym.IsStatic) {
                        bool expIsBasicType = false;
                        var expOper = m_Model.GetOperationEx(leftMemberAccess.Expression);
                        if (null != expOper && SymbolTable.IsBasicType(expOper.Type)) {
                            expIsBasicType = true;
                        }
                        if (CheckExplicitInterfaceAccess(leftPsym)) {
                            specialType = SpecialAssignmentType.PropExplicitImplementInterface;
                        }
                        else if (SymbolTable.IsBasicValueProperty(leftPsym) || expIsBasicType) {
                            specialType = SpecialAssignmentType.PropForBasicValueType;
                        }
                    }
                }
                bool dslToObject = false;
                if (null != leftOper && null != leftOper.Type && null != rightOper && null != rightOper.Type) {
                    dslToObject = InvocationInfo.IsDslToObject(leftOper.Type, rightOper.Type);
                }
                bool needWrapStruct = null != rightOper && null != rightOper.Type && rightOper.Type.IsValueType && !dslToObject && !SymbolTable.IsBasicType(rightOper.Type) && !CsDslTranslater.IsImplementationOfSys(rightOper.Type, "IEnumerator");
                string postfix = GetSourcePosForVar(expression);
                string oldValVar = string.Format("__old_val_{0}", postfix);
                string newValVar = string.Format("__new_val_{0}", postfix);
                if (needWrapStruct) {
                    MarkNeedFuncInfo();
                    if (null != leftSym && SymbolTable.Instance.IsCs2DslSymbol(leftSym) && SymbolTable.Instance.IsFieldSymbolKind(leftSym)) {
                        CodeBuilder.AppendFormat("local({0}); {0} = ", oldValVar);
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.AppendLine(";");
                        CodeBuilder.Append(GetIndentString());
                    }
                }
                VisitAssignment(ci, op, baseOp, assign, expTerminater, true, leftOper, leftSym, leftPsym, leftEsym, leftFsym, leftMemberAccess, leftElementAccess, leftCondAccess, specialType, dslToObject);
                if (needWrapStruct) {
                    //只有变量赋值与字段赋值需要处理，其它的都在相应的函数调用里处理了
                    if (null != rightSym && (rightSym.Kind == SymbolKind.Method || rightSym.Kind == SymbolKind.Property || rightSym.Kind == SymbolKind.Field || rightSym.Kind == SymbolKind.Local || rightSym.Kind == SymbolKind.Parameter) && SymbolTable.Instance.IsCs2DslSymbol(rightSym)) {
                        if (null != leftSym && (leftSym.Kind == SymbolKind.Local || leftSym.Kind == SymbolKind.Parameter || SymbolTable.Instance.IsFieldSymbolKind(leftSym)) && SymbolTable.Instance.IsCs2DslSymbol(leftSym)) {
                            if (SymbolTable.Instance.IsCs2DslSymbol(rightOper.Type)) {
                                CodeBuilder.Append(GetIndentString());
                                OutputExpressionSyntax(assign.Left);
                                CodeBuilder.Append(" = wrapstruct(");
                                OutputExpressionSyntax(assign.Left);
                                CodeBuilder.AppendFormat(", {0});", ClassInfo.GetFullName(rightOper.Type));
                                CodeBuilder.AppendLine();
                            }
                            else {
                                string ns = ClassInfo.GetNamespaces(rightOper.Type);
                                if (ns != "System") {
                                    CodeBuilder.Append(GetIndentString());
                                    OutputExpressionSyntax(assign.Left);
                                    CodeBuilder.Append(" = wrapexternstruct(");
                                    OutputExpressionSyntax(assign.Left);
                                    CodeBuilder.AppendFormat(", {0});", ClassInfo.GetFullName(rightOper.Type));
                                    CodeBuilder.AppendLine();
                                }
                            }
                        }
                    }
                    //dsl脚本里的字段赋值，需要保证该对象不在函数退出时回收
                    if (null != leftSym && SymbolTable.Instance.IsCs2DslSymbol(leftSym) && SymbolTable.Instance.IsFieldSymbolKind(leftSym)) {
                        string fieldType = string.Empty;
                        if (null != leftPsym)
                            fieldType = ClassInfo.GetFullName(leftPsym.Type);
                        else if (null != leftFsym)
                            fieldType = ClassInfo.GetFullName(leftFsym.Type);
                        //获取新值
                        CodeBuilder.Append(GetIndentString());
                        CodeBuilder.AppendFormat("local({0}); {0} = ", newValVar);
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.AppendLine(";");
                        //回收旧值，保持新值
                        CodeBuilder.Append(GetIndentString());
                        CodeBuilder.Append("recycleandkeepstructvalue(");
                        CodeBuilder.Append(fieldType);
                        CodeBuilder.AppendFormat(", {0}, {1});", oldValVar, newValVar);
                        CodeBuilder.AppendLine();
                    }
                }
                return;
            }
            else {
                InvocationExpressionSyntax invocation = expression as InvocationExpressionSyntax;
                if (null != invocation) {
                    VisitInvocation(ci, invocation, string.Empty, expTerminater, true);
                    return;
                }
            }
            PrefixUnaryExpressionSyntax prefixUnary = expression as PrefixUnaryExpressionSyntax;
            if (null != prefixUnary) {
                var oper = m_Model.GetOperationEx(prefixUnary);
                IConversionOperation opd = null;
                var unaryOper = oper as IUnaryOperation;
                if (null != unaryOper) {
                    opd = unaryOper.Operand as IConversionOperation;
                }
                var assignOper = oper as ICompoundAssignmentOperation;
                if (null != assignOper) {
                    opd = assignOper.Value as IConversionOperation;
                }
                ITypeSymbol typeSym = null;
                string type = "null";
                string typeKind = "null";
                if (null != unaryOper && null != unaryOper.Operand) {
                    typeSym = unaryOper.Operand.Type;
                }
                else if (null != assignOper && null != assignOper.Target) {
                    typeSym = assignOper.Target.Type;
                }
                if (null != typeSym) {
                    type = ClassInfo.GetFullName(typeSym);
                    typeKind = "TypeKind." + typeSym.TypeKind.ToString();
                }
                if (null != unaryOper && null != unaryOper.OperatorMethod) {
                    IMethodSymbol msym = unaryOper.OperatorMethod;
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), expression);
                    var arglist = new List<ExpressionSyntax>() { prefixUnary.Operand };
                    ii.Init(msym, arglist, m_Model, opd);
                    OutputOperatorInvoke(ii, typeSym, prefixUnary);
                    CodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
                }
                else if (null != assignOper && null != assignOper.OperatorMethod) {
                    //++/--的重载调这里
                    OutputExpressionSyntax(prefixUnary.Operand, opd);
                    CodeBuilder.Append(" = ");
                    IMethodSymbol msym = assignOper.OperatorMethod;
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), expression);
                    var arglist = new List<ExpressionSyntax>() { prefixUnary.Operand };
                    ii.Init(msym, arglist, m_Model, opd);
                    OutputOperatorInvoke(ii, typeSym, prefixUnary);
                    CodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
                }
                else {
                    string op = prefixUnary.OperatorToken.Text;
                    if (op == "++" || op == "--") {
                        op = op == "++" ? "+" : "-";
                        OutputExpressionSyntax(prefixUnary.Operand, opd);
                        CodeBuilder.Append(" = ");
                        CodeBuilder.Append("execbinary(");
                        CodeBuilder.AppendFormat("\"{0}\", ", op);
                        OutputExpressionSyntax(prefixUnary.Operand, opd);
                        CodeBuilder.AppendFormat(", 1, {0}, {1}, {2}, {3}", CsDslTranslater.EscapeType(type, typeKind), CsDslTranslater.EscapeType(type, typeKind), typeKind, typeKind);
                        CodeBuilder.AppendFormat("){0}", expTerminater);
                        if (expTerminater.Length > 0)
                            CodeBuilder.AppendLine();
                    }
                    else {
                        ProcessUnaryOperator(expression, ref op);
                        string functor;
                        if (s_UnaryFunctor.TryGetValue(op, out functor)) {
                            CodeBuilder.AppendFormat("{0}(", functor);
                            OutputExpressionSyntax(prefixUnary.Operand, opd);
                        }
                        else {
                            CodeBuilder.Append("execunary(");
                            CodeBuilder.AppendFormat("\"{0}\", ", op);
                            OutputExpressionSyntax(prefixUnary.Operand, opd);
                            CodeBuilder.AppendFormat(", {0}, {1}", CsDslTranslater.EscapeType(type, typeKind), typeKind);
                        }
                        CodeBuilder.AppendFormat("){0}", expTerminater);
                        if (expTerminater.Length > 0)
                            CodeBuilder.AppendLine();
                    }
                }
                return;
            }
            PostfixUnaryExpressionSyntax postfixUnary = expression as PostfixUnaryExpressionSyntax;
            if (null != postfixUnary) {
                var oper = m_Model.GetOperationEx(postfixUnary);
                IConversionOperation opd = null;
                var unaryOper = oper as IUnaryOperation;
                if (null != unaryOper) {
                    opd = unaryOper.Operand as IConversionOperation;
                }
                var assignOper = oper as ICompoundAssignmentOperation;
                if (null != assignOper) {
                    opd = assignOper.Value as IConversionOperation;
                }
                ITypeSymbol typeSym = null;
                string type = "null";
                string typeKind = "null";
                if (null != assignOper && null != assignOper.Target) {
                    typeSym = assignOper.Target.Type;
                }
                if (null != typeSym) {
                    type = ClassInfo.GetFullName(typeSym);
                    typeKind = "TypeKind." + typeSym.TypeKind.ToString();
                }
                if (null != unaryOper && null != unaryOper.OperatorMethod) {
                    IMethodSymbol msym = unaryOper.OperatorMethod;
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), expression);
                    var arglist = new List<ExpressionSyntax>() { prefixUnary.Operand };
                    ii.Init(msym, arglist, m_Model, opd);
                    OutputOperatorInvoke(ii, typeSym, prefixUnary);
                    CodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
                }
                else if (null != assignOper && null != assignOper.OperatorMethod) {
                    //++/--的重载调这里
                    OutputExpressionSyntax(postfixUnary.Operand, opd);
                    CodeBuilder.Append(" = ");
                    IMethodSymbol msym = assignOper.OperatorMethod;
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), expression);
                    var arglist = new List<ExpressionSyntax>() { postfixUnary.Operand };
                    ii.Init(msym, arglist, m_Model, opd);
                    OutputOperatorInvoke(ii, typeSym, postfixUnary);
                    CodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
                }
                else {
                    string op = postfixUnary.OperatorToken.Text;
                    if (op == "++" || op == "--") {
                        op = op == "++" ? "+" : "-";
                        OutputExpressionSyntax(postfixUnary.Operand, opd);
                        CodeBuilder.Append(" = ");
                        CodeBuilder.Append("execbinary(");
                        CodeBuilder.AppendFormat("\"{0}\", ", op);
                        OutputExpressionSyntax(postfixUnary.Operand, opd);
                        CodeBuilder.AppendFormat(", 1, {0}, {1}, {2}, {3}", CsDslTranslater.EscapeType(type, typeKind), CsDslTranslater.EscapeType(type, typeKind), typeKind, typeKind);
                        CodeBuilder.AppendFormat("){0}", expTerminater);
                        if (expTerminater.Length > 0)
                            CodeBuilder.AppendLine();
                    }
                }
                return;
            }
            OutputExpressionSyntax(expression);
            CodeBuilder.AppendFormat("{0}", expTerminater);
            if (expTerminater.Length > 0)
                CodeBuilder.AppendLine();
        }
        private void VisitLocalVariableDeclarator(ClassInfo ci, VariableDeclaratorSyntax node, bool dslToObject)
        {
            var declSym = m_Model.GetDeclaredSymbol(node) as ILocalSymbol;
            var typeSym = null != declSym ? declSym.Type : null;
            var namedTypeSym = null != typeSym ? typeSym as INamedTypeSymbol : null;
            if (null != node.Initializer) {
                var init = node.Initializer;
                var srcType = m_Model.GetTypeInfoEx(init.Value).Type;
                var constVal = m_Model.GetConstantValueEx(init.Value);
                if (null != srcType) {
                    TypeChecker.CheckConvert(m_Model, srcType, typeSym, node, GetCurMethodSemanticInfo());
                }
                var oper = m_Model.GetOperationEx(init) as IVariableDeclarationOperation;
                IConversionOperation opd = null;
                if (null != oper && oper.Declarators.Length == 1) {
                    opd = oper.Declarators[0] as IConversionOperation;
                }
                var token = init.EqualsToken;
                var invocation = init.Value as InvocationExpressionSyntax;
                if (null != invocation) {
                    string srcPos = GetSourcePosForVar(invocation);
                    string localName = string.Format("__localdecl_{0}", srcPos);
                    SymbolInfo symInfo = m_Model.GetSymbolInfoEx(invocation);
                    IMethodSymbol sym = symInfo.Symbol as IMethodSymbol;

                    if (null == sym) {
                        ReportIllegalSymbol(invocation, symInfo);
                    }
                    else {
                        //处理ref/out参数
                        InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), invocation);
                        ii.Init(sym, invocation.ArgumentList, m_Model);
                        if (sym.IsStatic || sym.IsExtensionMethod) {
                            AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                        }
                        int ct = ii.ReturnArgs.Count;
                        string preCodeBlock = string.Empty;
                        string postCodeBlock = string.Empty;
                        if (ct > 0) {
                            int indent = m_Indent + 1;
                            StringBuilder old = ci.CurrentCodeBuilder;
                            StringBuilder sb = new StringBuilder();
                            ci.CurrentCodeBuilder = sb;
                            sb.AppendLine();
                            ii.OutputStructFieldsValue(sb, indent + 1, this, "__old_var", srcPos);
                            sb.Append(GetIndentString(indent));
                            preCodeBlock = sb.ToString();
                            sb.Length = 0;
                            sb.AppendLine();
                            ii.OutputWrapStructFields(sb, indent + 1, this);
                            ii.OutputStructFieldsValue(sb, indent + 1, this, "__new_var", srcPos);
                            ii.OutputRecycleAndKeepStructFields(sb, indent + 1, this, "__old_var", "__new_var", srcPos);
                            sb.Append(GetIndentString(indent));
                            postCodeBlock = sb.ToString();
                            ci.CurrentCodeBuilder = old;
                        }
                        bool useOperator = false;
                        if (null != opd && null != opd.OperatorMethod) {
                            useOperator = true;
                            IMethodSymbol msym = opd.OperatorMethod;
                            InvocationInfo iop = new InvocationInfo(GetCurMethodSemanticInfo(), invocation);
                            iop.Init(msym, m_Model);
                            CodeBuilder.AppendFormat("{0}local({1}); {2}", GetIndentString(), node.Identifier.Text, node.Identifier.Text);
                            CodeBuilder.AppendFormat(" {0} ", token.Text);
                            if (dslToObject) {
                                OutputDslToObjectPrefix(declSym);
                            }
                            OutputConversionInvokePrefix(iop);
                            if (ct > 0) {
                                CodeBuilder.AppendFormat("execclosure(true, {0}, true){{ multiassign(precode{{{1}}},postcode{{{2}}})varlist({0}", localName, preCodeBlock, postCodeBlock);
                            }
                        }
                        else {
                            if (ct > 0) {
                                CodeBuilder.AppendFormat("{0}local({1}); multiassign(precode{{{2}}},postcode{{{3}}})varlist({1}", GetIndentString(), node.Identifier.Text, preCodeBlock, postCodeBlock);
                            }
                            else {
                                CodeBuilder.AppendFormat("{0}local({1}); {2}", GetIndentString(), node.Identifier.Text, node.Identifier.Text);
                            }
                        }
                        MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                        if (null != memberAccess) {
                            if (memberAccess.OperatorToken.Text == "->") {
                                Log(memberAccess, "Unsupported -> member access !");
                            }
                            if (ct > 0) {
                                CodeBuilder.Append(", ");
                                OutputExpressionList(ii.ReturnArgs, memberAccess);
                                CodeBuilder.AppendFormat(") {0} ", token.Text);
                            }
                            else if (!useOperator) {
                                CodeBuilder.AppendFormat(" {0} ", token.Text);
                            }
                            if (!useOperator) {
                                if (dslToObject) {
                                    OutputDslToObjectPrefix(declSym);
                                }
                            }
                            ii.OutputInvocation(CodeBuilder, this, memberAccess.Expression, true, m_Model, memberAccess);
                        }
                        else {
                            if (ct > 0) {
                                CodeBuilder.Append(", ");
                                OutputExpressionList(ii.ReturnArgs, invocation);
                                CodeBuilder.AppendFormat(") {0} ", token.Text);
                            }
                            else if (!useOperator) {
                                CodeBuilder.AppendFormat(" {0} ", token.Text);
                            }
                            if (!useOperator) {
                                if (dslToObject) {
                                    OutputDslToObjectPrefix(declSym);
                                }
                            }
                            ii.OutputInvocation(CodeBuilder, this, invocation.Expression, false, m_Model, invocation);
                        }
                        if (useOperator) {
                            if (ct > 0) {
                                CodeBuilder.Append("; }");
                            }
                            CodeBuilder.Append(")");
                        }
                        if (dslToObject) {
                            CodeBuilder.Append(")");
                        }
                    }
                }
                else {
                    CodeBuilder.AppendFormat("{0}local({1}); {2}", GetIndentString(), node.Identifier.Text, node.Identifier.Text);
                    CodeBuilder.AppendFormat(" {0} ", token.Text);
                    OutputExpressionSyntax(init.Value, opd, dslToObject, false, declSym);
                }
            }
            else if (null != namedTypeSym && namedTypeSym.IsValueType && !SymbolTable.IsBasicType(namedTypeSym)) {
                var block = GetParentBlockNode(node);
                LocalVariableAccessAnalysis analysis = new LocalVariableAccessAnalysis(node.Identifier.Text);
                analysis.Visit(block);
                if (analysis.NeedInitOnDeclaration) {
                    CodeBuilder.AppendFormat("{0}local({1}); {1} = ", GetIndentString(), node.Identifier.Text);
                    OutputNewValueType(namedTypeSym);
                    CodeBuilder.Append(";");
                }
                else {
                    CodeBuilder.AppendFormat("{0}local({1})", GetIndentString(), node.Identifier.Text);
                }
            }
            else {
                CodeBuilder.AppendFormat("{0}local({1})", GetIndentString(), node.Identifier.Text);
            }
            CodeBuilder.AppendLine(";");
        }
        /// <summary>
        /// 赋值语句的翻译可能是翻译里最复杂的一部分，这个函数与后面几个分别对赋值的不同情形进行处理。
        /// </summary>
        /// <param name="ci"></param>
        /// <param name="op"></param>
        /// <param name="baseOp"></param>
        /// <param name="assign"></param>
        /// <param name="expTerminater"></param>
        /// <param name="toplevel"></param>
        /// <param name="leftOper"></param>
        /// <param name="leftSym"></param>
        /// <param name="leftPsym"></param>
        /// <param name="leftEsym"></param>
        /// <param name="leftFsym"></param>
        /// <param name="leftMemberAccess"></param>
        /// <param name="leftElementAccess"></param>
        /// <param name="leftCondAccess"></param>
        /// <param name="specialType"></param>
        /// <param name="convertType"></param>
        private void VisitAssignment(ClassInfo ci, string op, string baseOp, AssignmentExpressionSyntax assign, string expTerminater, bool toplevel, IOperation leftOper, ISymbol leftSym, IPropertySymbol leftPsym, IEventSymbol leftEsym, IFieldSymbol leftFsym, MemberAccessExpressionSyntax leftMemberAccess, ElementAccessExpressionSyntax leftElementAccess, ConditionalAccessExpressionSyntax leftCondAccess, SpecialAssignmentType specialType, bool dslToObject)
        {
            var assignOper = m_Model.GetOperationEx(assign);
            IConversionOperation opd = null, lopd = null, ropd = null;
            var assignInfo = assignOper as IAssignmentOperation;
            if (null != assignInfo) {
                opd = assignInfo.Value as IConversionOperation;
            }
            var compAssignInfo = assignOper as ICompoundAssignmentOperation;
            if (null != compAssignInfo) {
                lopd = compAssignInfo.Target as IConversionOperation;
                ropd = compAssignInfo.Value as IConversionOperation;
            }
            InvocationExpressionSyntax invocation = assign.Right as InvocationExpressionSyntax;
            if (specialType == SpecialAssignmentType.PropExplicitImplementInterface) {
                //这里不区分是否外部符号了，委托到动态语言的脚本库实现，可根据对象运行时信息判断
                string mname = string.Empty;
                CheckExplicitInterfaceAccess(leftPsym, ref mname);
                CodeBuilder.AppendFormat("setinstance(SymbolKind.Property, ");
                OutputExpressionSyntax(leftMemberAccess.Expression);
                string fn = ClassInfo.GetFullName(leftSym.ContainingType);
                CodeBuilder.AppendFormat(", {0}, \"{1}\", ", fn, mname);
                OutputExpressionSyntax(assign.Right, opd, dslToObject, false, leftSym);
                CodeBuilder.Append(")");
            }
            else if (specialType == SpecialAssignmentType.PropForBasicValueType) {
                if (null != leftSym) {
                    if (leftSym.IsStatic) {
                        AddReferenceAndTryDeriveGenericTypeInstance(ci, leftSym);
                    }
                    else {
                        SymbolTable.Instance.TryAddExternReference(leftSym);
                    }
                }
                //这里不区分是否外部符号了，委托到动态语言的脚本库实现，可根据对象运行时信息判断
                string className = ClassInfo.GetFullName(leftPsym.ContainingType);
                bool isEnumClass = leftPsym.ContainingType.TypeKind == TypeKind.Enum || className == "System.Enum";
                string pname = leftPsym.Name;
                string ckey = InvocationInfo.CalcInvokeTarget(isEnumClass, className, this, leftOper.Type);
                CodeBuilder.AppendFormat("setforbasicvalue(");
                OutputExpressionSyntax(leftMemberAccess.Expression);
                CodeBuilder.AppendFormat(", {0}, {1}, \"{2}\", ", isEnumClass ? "true" : "false", ckey, pname);
                OutputExpressionSyntax(assign.Right, opd, dslToObject, false, leftSym);
                CodeBuilder.Append(")");
            }
            else if (null != leftElementAccess) {
                VisitAssignmentLeftElementAccess(ci, op, baseOp, assign, toplevel, leftOper, leftSym, leftPsym, leftElementAccess, opd, lopd, ropd, compAssignInfo, dslToObject);
            }
            else if (null != leftCondAccess) {
                VisitAssignmentLeftCondAccess(ci, op, baseOp, assign, toplevel, leftSym, leftCondAccess, opd, lopd, ropd, compAssignInfo, dslToObject);
            }
            else if (leftOper.Type.TypeKind == TypeKind.Delegate) {
                bool isMemberAccess = null != leftPsym || null != leftEsym || null != leftFsym;
                if (isMemberAccess) {
                    if (null != leftSym) {
                        if (leftSym.IsStatic) {
                            AddReferenceAndTryDeriveGenericTypeInstance(ci, leftSym);
                        }
                        else {
                            SymbolTable.Instance.TryAddExternReference(leftSym);
                        }
                    }
                    string className = ClassInfo.GetFullName(leftSym.ContainingType);
                    string memberName = leftSym.Name;
                    //delegation就不用区分是否外部符号了，基本上在动态语言里都是函数对象，作为普通数据成员
                    if (leftSym.IsStatic) {
                        CodeBuilder.Append("setstaticdelegation(SymbolKind.");
                        CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(leftSym));
                        CodeBuilder.Append(", ");
                        CodeBuilder.Append(className);
                        CodeBuilder.AppendFormat(", \"{0}\", ", memberName);
                    }
                    else {
                        CodeBuilder.Append("setinstancedelegation(SymbolKind.");
                        CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(leftSym));
                        CodeBuilder.Append(", ");
                        if (null != leftMemberAccess)
                            OutputExpressionSyntax(leftMemberAccess.Expression);
                        else if (IsNewObjMember(memberName))
                            CodeBuilder.Append("newobj");
                        else
                            CodeBuilder.Append("this");
                        CodeBuilder.AppendFormat(", {0}, \"{1}\", ", className, memberName);
                    }
                }
                else {
                    CodeBuilder.Append("setdelegation(SymbolKind.");
                    CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(leftSym));
                    CodeBuilder.Append(", ");
                    OutputExpressionSyntax(assign.Left);
                    CodeBuilder.Append(", ");
                }
                VisitAssignmentDelegation(ci, op, baseOp, assign, leftOper, leftSym, opd);
                CodeBuilder.Append(")");
            }
            else if (null != invocation) {
                VisitAssignmentInvocation(ci, op, baseOp, assign, invocation, leftSym, opd, lopd, ropd, compAssignInfo, dslToObject);
            }
            else {
                bool isCs2Lua = SymbolTable.Instance.IsCs2DslSymbol(leftSym);
                bool isExtern = !isCs2Lua;
                bool isMemberAccess = null != leftPsym || null != leftEsym || null != leftFsym;
                if(isMemberAccess && null != leftSym) {
                    if (leftSym.IsStatic) {
                        AddReferenceAndTryDeriveGenericTypeInstance(ci, leftSym);
                    }
                    else {
                        SymbolTable.Instance.TryAddExternReference(leftSym);
                    }
                }
                if (op == "=") {
                    if (isMemberAccess) {
                        string className = ClassInfo.GetFullName(leftSym.ContainingType);
                        string memberName = leftSym.Name;
                        if (leftSym.IsStatic) {
                            if(isExtern)
                                CodeBuilder.Append("setexternstatic(SymbolKind.");
                            else
                                CodeBuilder.Append("setstatic(SymbolKind.");
                            CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(leftSym));
                            CodeBuilder.Append(", ");
                            CodeBuilder.Append(className);
                            CodeBuilder.AppendFormat(", \"{0}\", ", memberName);
                        }
                        else {
                            if (isExtern)
                                CodeBuilder.Append("setexterninstance(SymbolKind.");
                            else
                                CodeBuilder.Append("setinstance(SymbolKind.");
                            CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(leftSym));
                            CodeBuilder.Append(", ");
                            if (null != leftMemberAccess)
                                OutputExpressionSyntax(leftMemberAccess.Expression);
                            else if (IsNewObjMember(memberName))
                                CodeBuilder.Append("newobj");
                            else
                                CodeBuilder.Append("this");
                            CodeBuilder.AppendFormat(", {0}, \"{1}\", ", className, memberName);
                        }
                    }
                    else {
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.Append(" = ");
                    }
                    OutputExpressionSyntax(assign.Right, opd, dslToObject, isExtern, leftSym);
                }
                else {
                    if (isMemberAccess) {
                        string className = ClassInfo.GetFullName(leftSym.ContainingType);
                        string memberName = leftSym.Name;
                        if (leftSym.IsStatic) {
                            if (isExtern)
                                CodeBuilder.Append("setexternstatic(SymbolKind.");
                            else
                                CodeBuilder.Append("setstatic(SymbolKind.");
                            CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(leftSym));
                            CodeBuilder.Append(", ");
                            CodeBuilder.Append(className);
                            CodeBuilder.AppendFormat(", \"{0}\", ", memberName);
                        }
                        else {
                            if (isExtern)
                                CodeBuilder.Append("setexterninstance(SymbolKind.");
                            else
                                CodeBuilder.Append("setinstance(SymbolKind.");
                            CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(leftSym));
                            CodeBuilder.Append(", ");
                            if (null != leftMemberAccess)
                                OutputExpressionSyntax(leftMemberAccess.Expression);
                            else if (IsNewObjMember(memberName))
                                CodeBuilder.Append("newobj");
                            else
                                CodeBuilder.Append("this");
                            CodeBuilder.AppendFormat(", {0}, \"{1}\", ", className, memberName);
                        }
                    }
                    else {
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.Append(" = ");
                    }
                    if (dslToObject) {
                        OutputDslToObjectPrefix(leftSym);
                    }
                    if (null != compAssignInfo && null != compAssignInfo.OperatorMethod) {
                        IMethodSymbol msym = compAssignInfo.OperatorMethod;
                        InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), assign);
                        var arglist = new List<ExpressionSyntax>() { assign.Left, assign.Right };
                        ii.Init(msym, arglist, m_Model, lopd, ropd);
                        OutputOperatorInvoke(ii, null != leftSym ? leftSym.ContainingType : null, assign);
                    }
                    else {
                        ITypeSymbol ltypeSym = null;
                        ITypeSymbol rtypeSym = null;
                        string ltype = "null";
                        string rtype = "null";
                        string ltypeKind = "null";
                        string rtypeKind = "null";
                        if (null != compAssignInfo && null != compAssignInfo.Target && null != compAssignInfo.Value) {
                            ltypeSym = compAssignInfo.Target.Type;
                            if (null != ltypeSym) {
                                ltype = ClassInfo.GetFullName(ltypeSym);
                                ltypeKind = "TypeKind." + ltypeSym.TypeKind.ToString();
                            }
                            rtypeSym = compAssignInfo.Value.Type;
                            if (null != rtypeSym) {
                                rtype = ClassInfo.GetFullName(rtypeSym);
                                rtypeKind = "TypeKind." + rtypeSym.TypeKind.ToString();
                            }
                        }
                        ProcessBinaryOperator(assign, ref baseOp);
                        CompoundAssignBegin(baseOp, assign, lopd);
                        OutputExpressionSyntax(assign.Right, ropd);
                        CompoundAssignEnd(ltype, rtype, ltypeKind, rtypeKind);
                    }
                    if (dslToObject) {
                        CodeBuilder.Append(")");
                    }
                }
                if (isMemberAccess) {
                    CodeBuilder.Append(")");
                }
            }
            CodeBuilder.AppendFormat("{0}", expTerminater);
            if (expTerminater.Length > 0)
                CodeBuilder.AppendLine();
        }
        private void VisitAssignmentLeftElementAccess(ClassInfo ci, string op, string baseOp, AssignmentExpressionSyntax assign, bool toplevel, IOperation leftOper, ISymbol leftSym, IPropertySymbol leftPsym, ElementAccessExpressionSyntax leftElementAccess, IConversionOperation opd, IConversionOperation lopd, IConversionOperation ropd, ICompoundAssignmentOperation compAssignInfo, bool dslToObject)
        {
            ProcessBinaryOperator(assign, ref baseOp);
            if (op != "=" && (null == compAssignInfo || null == compAssignInfo.Target || null == compAssignInfo.Value)) {
                Log(leftElementAccess, "illegal compound assign !");
            }

            ITypeSymbol ltype = null;
            ITypeSymbol rtype = null;
            string leftType = "null";
            string rightType = "null";
            string leftTypeKind = "null";
            string rightTypeKind = "null";
            if (null != compAssignInfo) {
                ltype = compAssignInfo.Target.Type;
                rtype = compAssignInfo.Value.Type;
                if (null != ltype) {
                    leftType = ClassInfo.GetFullName(ltype);
                    leftTypeKind = "TypeKind." + ltype.TypeKind.ToString();
                }
                if (null != rtype) {
                    rightType = ClassInfo.GetFullName(rtype);
                    rightTypeKind = "TypeKind." + rtype.TypeKind.ToString();
                }
            }

            if (null != leftSym) {
                if (leftSym.IsStatic) {
                    AddReferenceAndTryDeriveGenericTypeInstance(ci, leftSym);
                }
                else {
                    SymbolTable.Instance.TryAddExternReference(leftSym);
                }
            }
            if (null != leftPsym && leftPsym.IsIndexer) {
                bool isCs2Lua = SymbolTable.Instance.IsCs2DslSymbol(leftPsym);
                CodeBuilder.AppendFormat("set{0}{1}indexer(", isCs2Lua ? string.Empty : "extern", leftPsym.IsStatic ? "static" : "instance");
                var expType = m_Model.GetTypeInfoEx(leftElementAccess.Expression).Type;
                if (!isCs2Lua) {
                    if (null != expType) {
                        string fullName = ClassInfo.GetFullName(expType);
                        CodeBuilder.Append(fullName);
                    }
                    else {
                        CodeBuilder.Append("null");
                    }
                    CodeBuilder.Append(", ");
                }
                if (leftPsym.IsStatic) {
                    string fullName = ClassInfo.GetFullName(leftPsym.ContainingType);
                    CodeBuilder.Append(fullName);
                }
                else {
                    OutputExpressionSyntax(leftElementAccess.Expression);
                }
                CodeBuilder.Append(", ");
                string manglingName = NameMangling(leftPsym.SetMethod);
                if (!leftPsym.IsStatic) {
                    CheckExplicitInterfaceAccess(leftPsym.SetMethod, ref manglingName);
                    string fullName = ClassInfo.GetFullName(leftPsym.ContainingType);
                    CodeBuilder.Append(fullName);
                    CodeBuilder.Append(", ");
                }
                CodeBuilder.AppendFormat("\"{0}\", {1}, {2}, ", manglingName, leftPsym.SetMethod.Parameters.Length, toplevel ? "true" : "false");
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), leftElementAccess);
                ii.Init(leftPsym.SetMethod, leftElementAccess.ArgumentList, m_Model);
                OutputArgumentList(ii, expType, false, leftElementAccess);
                CodeBuilder.Append(", ");

                if (op != "=") {
                    CompoundAssignBegin(baseOp, assign, lopd);
                    OutputExpressionSyntax(assign.Right, ropd, dslToObject, ii.IsExternMethod, leftSym);
                    CompoundAssignEnd(leftType, rightType, leftTypeKind, rightTypeKind);
                }
                else {
                    OutputExpressionSyntax(assign.Right, opd, dslToObject, ii.IsExternMethod, leftSym);
                }
                CodeBuilder.Append(")");
            }
            else if (leftOper.Kind == OperationKind.ArrayElementReference) {
                if (leftOper.Type.IsValueType && !SymbolTable.IsBasicType(leftOper.Type)) {
                    MarkNeedFuncInfo();
                    CodeBuilder.AppendFormat("arraysetstruct({0}, ", toplevel ? "true" : "false");
                    var arrSym = m_Model.GetSymbolInfoEx(leftElementAccess.Expression).Symbol;
                    var arrOper = leftOper as IArrayElementReferenceOperation;
                    if (null != arrSym) {
                        bool isCs2Dsl = SymbolTable.Instance.IsCs2DslSymbol(arrSym);
                        CodeBuilder.Append(isCs2Dsl ? "false" : "true");
                        CodeBuilder.AppendFormat(", SymbolKind.{0}, ", arrSym.Kind.ToString());
                    }
                    else {
                        bool isCs2Dsl = SymbolTable.Instance.IsCs2DslSymbol(arrOper.ArrayReference.Type);
                        CodeBuilder.Append(isCs2Dsl ? "false" : "true");
                        CodeBuilder.AppendFormat(", OperationKind.{0}, ", arrOper.ArrayReference.Kind);
                    }
                    var fn = ClassInfo.GetFullName(leftOper.Type);
                    CodeBuilder.Append(fn);
                    CodeBuilder.Append(", ");
                    OutputExpressionSyntax(leftElementAccess.Expression);
                    CodeBuilder.Append(", ");
                    OutputArgumentList(leftElementAccess.ArgumentList.Arguments, ", ", leftOper);
                    CodeBuilder.Append(", ");
                    if (op != "=") {
                        CompoundAssignBegin(baseOp, assign, lopd);
                        OutputExpressionSyntax(assign.Right, ropd, dslToObject, false, leftSym);
                        CompoundAssignEnd(leftType, rightType, leftTypeKind, rightTypeKind);
                    }
                    else {
                        OutputExpressionSyntax(assign.Right, opd, dslToObject, false, leftSym);
                    }
                    CodeBuilder.Append(")");
                }
                else {
                    if (!toplevel) {
                        string localName = string.Format("__ret_{0}", GetSourcePosForVar(assign));
                        CodeBuilder.AppendFormat("execclosure(true, {0}, true){{ ", localName);
                        OutputExpressionSyntax(leftElementAccess.Expression);
                        CodeBuilder.Append("[");
                        OutputArgumentList(leftElementAccess.ArgumentList.Arguments, "][", leftOper);
                        CodeBuilder.Append("] = ");

                        if (op != "=") {
                            CompoundAssignBegin(baseOp, assign, lopd);
                            OutputExpressionSyntax(assign.Right, ropd, dslToObject, false, leftSym);
                            CompoundAssignEnd(leftType, rightType, leftTypeKind, rightTypeKind);
                        }
                        else {
                            CodeBuilder.AppendFormat("execclosure(true, {0}, false){{ {1} = ", localName, localName);
                            OutputExpressionSyntax(assign.Right, opd, dslToObject, false, leftSym);
                            CodeBuilder.Append("; };");
                        }
                        CodeBuilder.Append("; }");
                    }
                    else {
                        OutputExpressionSyntax(leftElementAccess.Expression);
                        CodeBuilder.Append("[");
                        OutputArgumentList(leftElementAccess.ArgumentList.Arguments, "][", leftOper);
                        CodeBuilder.Append("] = ");

                        if (op != "=") {
                            CompoundAssignBegin(baseOp, assign, lopd);
                            OutputExpressionSyntax(assign.Right, ropd, dslToObject, false, leftSym);
                            CompoundAssignEnd(leftType, rightType, leftTypeKind, rightTypeKind);
                        }
                        else {
                            OutputExpressionSyntax(assign.Right, opd, dslToObject, false, leftSym);
                        }
                    }
                }
            }
            else {
                Log(assign, "unknown set element symbol !");
            }
        }
        private void VisitAssignmentLeftCondAccess(ClassInfo ci, string op, string baseOp, AssignmentExpressionSyntax assign, bool toplevel, ISymbol leftSym, ConditionalAccessExpressionSyntax leftCondAccess, IConversionOperation opd, IConversionOperation lopd, IConversionOperation ropd, ICompoundAssignmentOperation compAssignInfo, bool dslToObject)
        {
            ProcessBinaryOperator(assign, ref baseOp);
            if (op != "=" && (null == compAssignInfo || null == compAssignInfo.Target || null == compAssignInfo.Value)) {
                Log(leftCondAccess, "illegal compound assign !");
            }

            ITypeSymbol ltype = null;
            ITypeSymbol rtype = null;
            string leftType = "null";
            string rightType = "null";
            string leftTypeKind = "null";
            string rightTypeKind = "null";
            if (null != compAssignInfo) {
                ltype = compAssignInfo.Target.Type;
                rtype = compAssignInfo.Value.Type;
                if (null != ltype) {
                    leftType = ClassInfo.GetFullName(ltype);
                    leftTypeKind = "TypeKind." + ltype.TypeKind.ToString();
                }
                if (null != rtype) {
                    rightType = ClassInfo.GetFullName(rtype);
                    rightTypeKind = "TypeKind." + rtype.TypeKind.ToString();
                }
            }

            CodeBuilder.Append("condaccess(");
            OutputExpressionSyntax(leftCondAccess.Expression);
            CodeBuilder.Append(", ");
            var elementBinding = leftCondAccess.WhenNotNull as ElementBindingExpressionSyntax;
            if (null != elementBinding) {
                var bindingOper = m_Model.GetOperationEx(leftCondAccess.WhenNotNull);
                var symInfo = m_Model.GetSymbolInfoEx(leftCondAccess.WhenNotNull);
                var sym = symInfo.Symbol;
                var psym = sym as IPropertySymbol;
                if (null != sym){
                    if (sym.IsStatic) {
                        AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                    }
                    else {
                        SymbolTable.Instance.TryAddExternReference(sym);
                    }
                }
                if (null != psym && psym.IsIndexer) {
                    bool isCs2Lua = SymbolTable.Instance.IsCs2DslSymbol(psym);
                    CodeBuilder.AppendFormat("set{0}{1}indexer(", isCs2Lua ? string.Empty : "extern", psym.IsStatic ? "static" : "instance");
                    var expType = m_Model.GetTypeInfoEx(leftCondAccess.Expression).Type;
                    if (!isCs2Lua) {                        
                        if (null != expType) {
                            string fullName = ClassInfo.GetFullName(expType);
                            CodeBuilder.Append(fullName);
                        }
                        else {
                            CodeBuilder.Append("null");
                        }
                        CodeBuilder.Append(", ");
                    }
                    if (psym.IsStatic) {
                        string fullName = ClassInfo.GetFullName(psym.ContainingType);
                        CodeBuilder.Append(fullName);
                    }
                    else {
                        OutputExpressionSyntax(leftCondAccess.Expression);
                    }
                    CodeBuilder.Append(", ");
                    string manglingName = NameMangling(psym.SetMethod);
                    if (!psym.IsStatic) {
                        CheckExplicitInterfaceAccess(psym.SetMethod, ref manglingName);
                        string fullName = ClassInfo.GetFullName(psym.ContainingType);
                        CodeBuilder.Append(fullName);
                        CodeBuilder.Append(", ");
                    }
                    CodeBuilder.AppendFormat("\"{0}\", {1}, false, ", manglingName, psym.SetMethod.Parameters.Length);
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), leftCondAccess);
                    List<ExpressionSyntax> args = new List<ExpressionSyntax> { leftCondAccess.WhenNotNull };
                    ii.Init(psym.SetMethod, args, m_Model);
                    OutputArgumentList(ii, expType, false, leftCondAccess);
                    CodeBuilder.Append(", ");

                    if (op != "=") {
                        CompoundAssignBegin(baseOp, assign, lopd);
                        OutputExpressionSyntax(assign.Right, ropd, dslToObject, ii.IsExternMethod, leftSym);
                        CompoundAssignEnd(leftType, rightType, leftTypeKind, rightTypeKind);
                    }
                    else {
                        OutputExpressionSyntax(assign.Right, opd, dslToObject, ii.IsExternMethod, leftSym);
                    }
                    CodeBuilder.Append(")");
                }
                else if (bindingOper.Kind == OperationKind.ArrayElementReference) {
                    if (bindingOper.Type.IsValueType && !SymbolTable.IsBasicType(bindingOper.Type)) {
                        MarkNeedFuncInfo();
                        CodeBuilder.AppendFormat("arraysetstruct({0}, ", toplevel ? "true" : "false");
                        var arrSym = m_Model.GetSymbolInfoEx(leftCondAccess.Expression).Symbol;
                        var arrOper = bindingOper as IArrayElementReferenceOperation;
                        if (null != arrSym) {
                            bool isCs2Dsl = SymbolTable.Instance.IsCs2DslSymbol(arrSym);
                            CodeBuilder.Append(isCs2Dsl ? "false" : "true");
                            CodeBuilder.AppendFormat(", SymbolKind.{0}, ", arrSym.Kind.ToString());
                        }
                        else {
                            bool isCs2Dsl = SymbolTable.Instance.IsCs2DslSymbol(arrOper.ArrayReference.Type);
                            CodeBuilder.Append(isCs2Dsl ? "false" : "true");
                            CodeBuilder.AppendFormat(", OperationKind.{0}, ", arrOper.ArrayReference.Kind);
                        }
                        var fn = ClassInfo.GetFullName(bindingOper.Type);
                        CodeBuilder.Append(fn);
                        CodeBuilder.Append(", ");
                        OutputExpressionSyntax(leftCondAccess.Expression);
                        CodeBuilder.Append(", ");
                        OutputExpressionSyntax(leftCondAccess.WhenNotNull);
                        CodeBuilder.Append(", ");
                        if (op != "=") {
                            CompoundAssignBegin(baseOp, assign, lopd);
                            OutputExpressionSyntax(assign.Right, ropd, dslToObject, false, leftSym);
                            CompoundAssignEnd(leftType, rightType, leftTypeKind, rightTypeKind);
                        }
                        else {
                            OutputExpressionSyntax(assign.Right, opd, dslToObject, false, leftSym);
                        }
                        CodeBuilder.Append(")");
                    }
                    else {
                        if (!toplevel) {
                            string localName = string.Format("__ret_{0}", GetSourcePosForVar(assign));
                            CodeBuilder.AppendFormat("function(){{ local({0}); ", localName);
                            OutputExpressionSyntax(leftCondAccess.Expression);
                            CodeBuilder.Append("[");
                            OutputExpressionSyntax(leftCondAccess.WhenNotNull);
                            CodeBuilder.Append("] = ");

                            if (op != "=") {
                                CompoundAssignBegin(baseOp, assign, lopd);
                                OutputExpressionSyntax(assign.Right, ropd, dslToObject, false, leftSym);
                                CompoundAssignEnd(leftType, rightType, leftTypeKind, rightTypeKind);
                            }
                            else {
                                CodeBuilder.AppendFormat("execclosure(true, {0}, false){{ {1} = ", localName, localName);
                                OutputExpressionSyntax(assign.Right, opd, dslToObject, false, leftSym);
                                CodeBuilder.Append("; };");
                            }
                            CodeBuilder.Append(" funcobjret(");
                            CodeBuilder.Append(localName);
                            CodeBuilder.Append("); }");
                        }
                        else {
                            OutputExpressionSyntax(leftCondAccess.Expression);
                            CodeBuilder.Append("[");
                            OutputExpressionSyntax(leftCondAccess.WhenNotNull);
                            CodeBuilder.Append("] = ");

                            if (op != "=") {
                                CompoundAssignBegin(baseOp, assign, lopd);
                                OutputExpressionSyntax(assign.Right, ropd, dslToObject, false, leftSym);
                                CompoundAssignEnd(leftType, rightType, leftTypeKind, rightTypeKind);
                            }
                            else {
                                OutputExpressionSyntax(assign.Right, opd, dslToObject, false, leftSym);
                            }
                        }
                    }
                }
                else {
                    ReportIllegalSymbol(assign, symInfo);
                }
            }
            else {
                string localName = string.Format("__ret_{0}", GetSourcePosForVar(assign));
                CodeBuilder.AppendFormat("function(){{ local({0}); ", localName);
                OutputExpressionSyntax(leftCondAccess.Expression);
                OutputExpressionSyntax(leftCondAccess.WhenNotNull);
                CodeBuilder.Append(" = ");

                if (op != "=") {
                    CompoundAssignBegin(baseOp, assign, lopd);
                    OutputExpressionSyntax(assign.Right, ropd, dslToObject, false, leftSym);
                    CompoundAssignEnd(leftType, rightType, leftTypeKind, rightTypeKind);
                }
                else {
                    CodeBuilder.AppendFormat("execclosure(true, {0}, false){{ {1} = ", localName, localName);
                    OutputExpressionSyntax(assign.Right, opd, dslToObject, false, leftSym);
                    CodeBuilder.Append("; };");
                }
                CodeBuilder.Append(" funcobjret(");
                CodeBuilder.Append(localName);
                CodeBuilder.Append("); }");
            }
            CodeBuilder.Append(")");
        }
        private void VisitAssignmentInvocation(ClassInfo ci, string op, string baseOp, AssignmentExpressionSyntax assign, InvocationExpressionSyntax invocation, ISymbol leftSym, IConversionOperation opd, IConversionOperation lopd, IConversionOperation ropd, ICompoundAssignmentOperation compAssignInfo, bool dslToObject)
        {
            string srcPos = GetSourcePosForVar(invocation);
            string localName = string.Format("__assigninvoke_{0}", srcPos);
            SymbolInfo symInfo = m_Model.GetSymbolInfoEx(invocation);
            IMethodSymbol sym = symInfo.Symbol as IMethodSymbol;
            if (null == sym || op != "=" && (null == compAssignInfo || null == compAssignInfo.Target || null == compAssignInfo.Value)) {
                ReportIllegalSymbol(invocation, symInfo);
            }
            else {
                //处理ref/out参数
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), invocation);
                ii.Init(sym, invocation.ArgumentList, m_Model);
                if (sym.IsStatic || sym.IsExtensionMethod) {
                    AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                }
                int ct = ii.ReturnArgs.Count;
                string preCodeBlock = string.Empty;
                string postCodeBlock = string.Empty;
                if (ct > 0) {
                    int indent = m_Indent + 1;
                    StringBuilder old = ci.CurrentCodeBuilder;
                    StringBuilder sb = new StringBuilder();
                    ci.CurrentCodeBuilder = sb;
                    sb.AppendLine();
                    ii.OutputStructFieldsValue(sb, indent + 1, this, "__old_var", srcPos);
                    sb.Append(GetIndentString(indent));
                    preCodeBlock = sb.ToString();
                    sb.Length = 0;
                    sb.AppendLine();
                    ii.OutputWrapStructFields(sb, indent + 1, this);
                    ii.OutputStructFieldsValue(sb, indent + 1, this, "__new_var", srcPos);
                    ii.OutputRecycleAndKeepStructFields(sb, indent + 1, this, "__old_var", "__new_var", srcPos);
                    sb.Append(GetIndentString(indent));
                    postCodeBlock = sb.ToString();
                    ci.CurrentCodeBuilder = old;
                }

                ProcessBinaryOperator(assign, ref baseOp);
                ITypeSymbol ltype = null;
                ITypeSymbol rtype = null;
                string leftType = "null";
                string rightType = "null";
                string leftTypeKind = "null";
                string rightTypeKind = "null";
                if (null != compAssignInfo) {
                    ltype = compAssignInfo.Target.Type;
                    rtype = compAssignInfo.Value.Type;
                    if (null != ltype) {
                        leftType = ClassInfo.GetFullName(ltype);
                        leftTypeKind = "TypeKind." + ltype.TypeKind.ToString();
                    }
                    if (null != rtype) {
                        rightType = ClassInfo.GetFullName(rtype);
                        rightTypeKind = "TypeKind." + rtype.TypeKind.ToString();
                    }
                }

                MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                if (null != memberAccess) {
                    if (memberAccess.OperatorToken.Text == "->") {
                        Log(memberAccess, "Unsupported -> member access !");
                    }

                    bool outputEqualOp = false;
                    bool convertHandled = false;
                    if (op != "=") {
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.Append(" = ");
                        if (dslToObject) {
                            OutputDslToObjectPrefix(leftSym);
                        }
                        convertHandled = true;
                        CompoundAssignBegin(baseOp, assign, lopd);
                        if (null != ropd && null != ropd.OperatorMethod) {
                            IMethodSymbol msym = ropd.OperatorMethod;
                            InvocationInfo iop = new InvocationInfo(GetCurMethodSemanticInfo(), assign);
                            iop.Init(msym, (List<ExpressionSyntax>)null, m_Model);
                            OutputConversionInvokePrefix(iop);
                        }
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("execclosure(true, {0}, true){{ multiassign(precode{{{1}}},postcode{{{2}}})varlist({0}", localName, preCodeBlock, postCodeBlock);
                            outputEqualOp = true;
                        }
                    }
                    else if (null != opd && null != opd.OperatorMethod) {
                        IMethodSymbol msym = opd.OperatorMethod;
                        InvocationInfo iop = new InvocationInfo(GetCurMethodSemanticInfo(), assign);
                        iop.Init(msym, (List<ExpressionSyntax>)null, m_Model);
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.Append(" = ");
                        if (dslToObject) {
                            OutputDslToObjectPrefix(leftSym);
                        }
                        convertHandled = true;
                        OutputConversionInvokePrefix(iop);
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("execclosure(true, {0}, true){{ multiassign(precode{{{1}}},postcode{{{2}}})varlist({0}", localName, preCodeBlock, postCodeBlock);
                            outputEqualOp = true;
                        }
                    }
                    else {
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("multiassign(precode{{{0}}},postcode{{{1}}})varlist(", preCodeBlock, postCodeBlock);
                        }
                        OutputExpressionSyntax(assign.Left);
                        outputEqualOp = true;
                    }

                    if (ct > 0) {
                        CodeBuilder.Append(", ");
                        OutputExpressionList(ii.ReturnArgs, memberAccess);
                        CodeBuilder.Append(")");
                    }
                    if (outputEqualOp) {
                        CodeBuilder.Append(" = ");
                    }
                    if (!convertHandled) {
                        if (dslToObject) {
                            OutputDslToObjectPrefix(leftSym);
                        }
                    }
                    ii.OutputInvocation(CodeBuilder, this, memberAccess.Expression, true, m_Model, memberAccess);
                    if (op != "=") {
                        if (ct > 0) {
                            CodeBuilder.Append("; }");
                        }
                        if (null != ropd && null != ropd.OperatorMethod) {
                            CodeBuilder.Append(")");
                        }
                        CompoundAssignEnd(leftType, rightType, leftTypeKind, rightTypeKind);
                    }
                    else if (null != opd && null != opd.OperatorMethod) {
                        if (ct > 0) {
                            CodeBuilder.Append("; }");
                        }
                        CodeBuilder.Append(")");
                    }
                }
                else {
                    bool outputEqualOp = false;
                    bool convertHandled = false;
                    if (op != "=") {
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.Append(" = ");
                        if (dslToObject) {
                            OutputDslToObjectPrefix(leftSym);
                        }
                        convertHandled = true;
                        CompoundAssignBegin(baseOp, assign, lopd);
                        if (null != ropd && null != ropd.OperatorMethod) {
                            IMethodSymbol msym = ropd.OperatorMethod;
                            InvocationInfo iop = new InvocationInfo(GetCurMethodSemanticInfo(), assign);
                            iop.Init(msym, (List<ExpressionSyntax>)null, m_Model);
                            OutputConversionInvokePrefix(iop);
                        }
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("execclosure(true, {0}, true){{ multiassign(precode{{{1}}},postcode{{{2}}})varlist({0}", localName, preCodeBlock, postCodeBlock);
                            outputEqualOp = true;
                        }
                    }
                    else if (null != opd && null != opd.OperatorMethod) {
                        IMethodSymbol msym = opd.OperatorMethod;
                        InvocationInfo iop = new InvocationInfo(GetCurMethodSemanticInfo(), assign);
                        iop.Init(msym, (List<ExpressionSyntax>)null, m_Model);
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.Append(" = ");
                        if (dslToObject) {
                            OutputDslToObjectPrefix(leftSym);
                        }
                        convertHandled = true;
                        OutputConversionInvokePrefix(iop);
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("execclosure(true, {0}, true){{ multiassign(precode{{{1}}},postcode{{{2}}})varlist({0}", localName, preCodeBlock, postCodeBlock);
                            outputEqualOp = true;
                        }
                    }
                    else {
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("multiassign(precode{{{0}}},postcode{{{1}}})varlist(", preCodeBlock, postCodeBlock);
                        }
                        OutputExpressionSyntax(assign.Left);
                        outputEqualOp = true;
                    }

                    if (ct > 0) {
                        CodeBuilder.Append(", ");
                        OutputExpressionList(ii.ReturnArgs, invocation);
                        CodeBuilder.Append(")");
                    }
                    if (outputEqualOp) {
                        CodeBuilder.Append(" = ");
                    }
                    if (!convertHandled) {
                        if (dslToObject) {
                            OutputDslToObjectPrefix(leftSym);
                        }
                    }
                    ii.OutputInvocation(CodeBuilder, this, invocation.Expression, false, m_Model, invocation);
                    if (op != "=") {
                        if (ct > 0) {
                            CodeBuilder.Append("; }");
                        }
                        if (null != ropd && null != ropd.OperatorMethod) {
                            CodeBuilder.Append(")");
                        }
                        CompoundAssignEnd(leftType, rightType, leftTypeKind, rightTypeKind);
                    }
                    else if (null != opd && null != opd.OperatorMethod) {
                        if (ct > 0) {
                            CodeBuilder.Append("; }");
                        }
                        CodeBuilder.Append(")");
                    }
                }
                if (dslToObject) {
                    CodeBuilder.Append(")");
                }
            }
        }
        private void VisitAssignmentDelegation(ClassInfo ci, string op, string baseOp, AssignmentExpressionSyntax assign, IOperation leftOper, ISymbol leftSym, IConversionOperation opd)
        {
            if (null == leftSym) {
                Log(assign, "assignment delegation, left symbol == null");
                return;
            }
            var leftPsym = leftSym as IPropertySymbol;
            bool isIndexer = null != leftPsym && leftPsym.IsIndexer;
            bool isWriteOnly = null != leftPsym && leftPsym.IsWriteOnly;
            //外部的delegation只能是成员，因为delegation类型就是普通的function，这里不能以delegation的类型来判断是否外部类型
            bool isCs2LuaAssembly = SymbolTable.Instance.IsCs2DslSymbol(leftSym.ContainingType);
            string prefix;
            if ((leftSym.Kind == SymbolKind.Field || leftSym.Kind == SymbolKind.Property || leftSym.Kind == SymbolKind.Event) && !isCs2LuaAssembly) {
                prefix = "extern";
            }
            else {
                prefix = string.Empty;                
            }
            string postfix;
            if (op == "=") {
                postfix = "set";
            }
            else if (baseOp == "+") {
                postfix = "add";
            }
            else if (baseOp == "-") {
                postfix = "remove";
            }
            else {
                Log(assign, "Unsupported delegation operator {0} !", op);
                postfix = "error";
            }
            bool isStatic = leftSym.IsStatic;
            string containingName = ClassInfo.GetFullName(leftSym.ContainingType);
            string kind = null != leftSym ? SymbolTable.Instance.GetSymbolKind(leftSym) : null;
            string namePrefix = isCs2LuaAssembly && !isWriteOnly && kind == "Property" ? "get_" : string.Empty;
            CodeBuilder.AppendFormat("{0}delegation{1}", prefix, postfix);
            CodeBuilder.Append("(");
            CodeBuilder.AppendFormat("{0}, ", isStatic ? "true" : "false");
            if (isWriteOnly) {
                CodeBuilder.AppendFormat("null, null, SymbolKind.{0}", kind);
            }
            else if (!isIndexer && (leftSym.Kind == SymbolKind.Field || leftSym.Kind == SymbolKind.Property || leftSym.Kind == SymbolKind.Event)) {
                var memberAccess = assign.Left as MemberAccessExpressionSyntax;
                if (null != memberAccess) {
                    OutputExpressionSyntax(memberAccess.Expression);
                    CodeBuilder.Append(", ");
                    string mname = memberAccess.Name.Identifier.Text;
                    CheckExplicitInterfaceAccess(leftSym, ref mname);
                    CodeBuilder.AppendFormat("\"{0}{1}\", SymbolKind.{2}", namePrefix, mname, kind);
                }
                else if (leftSym.ContainingType == ci.SemanticInfo || leftSym.ContainingType == ci.SemanticInfo.OriginalDefinition || ci.IsInherit(leftSym.ContainingType)) {
                    if (leftSym.IsStatic)
                        CodeBuilder.AppendFormat("{0}, ", ClassInfo.GetFullName(leftSym.ContainingType));
                    else
                        CodeBuilder.Append("this, ");
                    CodeBuilder.AppendFormat("\"{0}{1}\", SymbolKind.{2}", namePrefix, leftSym.Name, kind);
                }
                else {
                    CodeBuilder.Append("newobj, ");
                    CodeBuilder.AppendFormat("\"{0}{1}\", SymbolKind.{2}", namePrefix, leftSym.Name, kind);
                }
            }
            else {
                OutputExpressionSyntax(assign.Left);
                CodeBuilder.AppendFormat(", null, SymbolKind.{0}", kind);
            }
            CodeBuilder.Append(", ");
            OutputExpressionSyntax(assign.Right, opd);
            CodeBuilder.Append(")");
        }
        private void VisitInvocation(ClassInfo ci, InvocationExpressionSyntax invocation, string returnVarName, string expTerminater, bool toplevel)
        {
            string srcPos = GetSourcePosForVar(invocation);
            string localName = string.Empty;
            if (!toplevel || string.IsNullOrEmpty(returnVarName)) {
                localName = string.Format("__invoke_{0}", srcPos);
            }
            SymbolInfo symInfo = m_Model.GetSymbolInfoEx(invocation);
            IMethodSymbol sym = symInfo.Symbol as IMethodSymbol;

            if (null != sym && sym.DeclaringSyntaxReferences.Length > 0) {
                var decl = sym.DeclaringSyntaxReferences[0].GetSyntax() as MethodDeclarationSyntax;
                if (null != decl && null == decl.Body && null == decl.ExpressionBody && sym.ReceiverType.TypeKind != TypeKind.Interface && !sym.IsAbstract) {
                    //partial method invocation
                    if (null == sym.PartialDefinitionPart && null == sym.PartialImplementationPart) {
                        if (expTerminater.Length > 0)
                            CodeBuilder.AppendLine();
                        return;
                    }
                }
            }

            if (null == sym) {
                ReportIllegalSymbol(invocation, symInfo);
            }
            else {
                //处理ref/out参数
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), invocation);
                ii.Init(sym, invocation.ArgumentList, m_Model);
                if (sym.IsStatic || sym.IsExtensionMethod) {
                    AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                }
                int ct = ii.ReturnArgs.Count;
                string preCodeBlock = string.Empty;
                string postCodeBlock = string.Empty;
                if (ct > 0) {
                    int indent = m_Indent + 1;
                    StringBuilder old = ci.CurrentCodeBuilder;
                    StringBuilder sb = new StringBuilder();
                    ci.CurrentCodeBuilder = sb;
                    sb.AppendLine();
                    ii.OutputStructFieldsValue(sb, indent + 1, this, "__old_var", srcPos);
                    sb.Append(GetIndentString(indent));
                    preCodeBlock = sb.ToString();
                    sb.Length = 0;
                    sb.AppendLine();
                    ii.OutputWrapStructFields(sb, indent + 1, this);
                    ii.OutputStructFieldsValue(sb, indent + 1, this, "__new_var", srcPos);
                    ii.OutputRecycleAndKeepStructFields(sb, indent + 1, this, "__old_var", "__new_var", srcPos);
                    sb.Append(GetIndentString(indent));
                    postCodeBlock = sb.ToString();
                    ci.CurrentCodeBuilder = old;
                }

                MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                if (null != memberAccess) {
                    if (memberAccess.OperatorToken.Text == "->") {
                        Log(memberAccess, "Unsupported -> member access !");
                    }

                    if (!sym.ReturnsVoid && ct > 0 || ct > 1) {
                        if (!toplevel) {
                            CodeBuilder.AppendFormat("execclosure(true, {0}, true){{ multiassign(precode{{{1}}},postcode{{{2}}})varlist({0}, ", localName, preCodeBlock, postCodeBlock);
                        }
                        else if (!sym.ReturnsVoid) {
                            if (!string.IsNullOrEmpty(returnVarName)) {
                                CodeBuilder.AppendFormat("multiassign(precode{{{1}}},postcode{{{2}}})varlist({0}, ", returnVarName, preCodeBlock, postCodeBlock);
                            }
                            else {
                                CodeBuilder.AppendFormat("local({0}); multiassign(precode{{{1}}},postcode{{{2}}})varlist({0}, ", localName, preCodeBlock, postCodeBlock);
                            }
                        }
                        else {
                            CodeBuilder.AppendFormat("multiassign(precode{{{0}}},postcode{{{1}}})varlist(", preCodeBlock, postCodeBlock);
                        }
                        OutputExpressionList(ii.ReturnArgs, memberAccess);
                        CodeBuilder.Append(") = ");
                    }
                    else if(!sym.ReturnsVoid && !string.IsNullOrEmpty(returnVarName)) {
                        CodeBuilder.Append(returnVarName);
                        CodeBuilder.Append(" = ");
                    }
                    else if(ct > 0) {
                        OutputExpressionList(ii.ReturnArgs, memberAccess);
                        CodeBuilder.Append(" = ");
                    }
                    ii.OutputInvocation(CodeBuilder, this, memberAccess.Expression, true, m_Model, memberAccess);
                    if (ct > 0) {
                        if (!toplevel) {
                            CodeBuilder.Append("; }");
                        }
                    }
                    CodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
                }
                else {
                    if (!sym.ReturnsVoid && ct > 0 || ct > 1) {
                        if (!toplevel) {
                            CodeBuilder.AppendFormat("execclosure(true, {0}, true){{ multiassign(precode{{{1}}},postcode{{{2}}})varlist({0}, ", localName, preCodeBlock, postCodeBlock);
                        }
                        else if (!sym.ReturnsVoid) {
                            if (!string.IsNullOrEmpty(returnVarName)) {
                                CodeBuilder.AppendFormat("multiassign(precode{{{1}}},postcode{{{2}}})varlist({0}, ", returnVarName, preCodeBlock, postCodeBlock);
                            }
                            else {
                                CodeBuilder.AppendFormat("local({0}); multiassign(precode{{{1}}},postcode{{{2}}})varlist({0}, ", localName, preCodeBlock, postCodeBlock);
                            }
                        }
                        else {
                            CodeBuilder.AppendFormat("multiassign(precode{{{0}}},postcode{{{1}}})varlist(", preCodeBlock, postCodeBlock);
                        }
                        OutputExpressionList(ii.ReturnArgs, memberAccess);
                        CodeBuilder.Append(") = ");
                    }
                    else if (!sym.ReturnsVoid && !string.IsNullOrEmpty(returnVarName)) {
                        CodeBuilder.Append(returnVarName);
                        CodeBuilder.Append(" = ");
                    }
                    else if (ct > 0) {
                        OutputExpressionList(ii.ReturnArgs, memberAccess);
                        CodeBuilder.Append(" = ");
                    }
                    ii.OutputInvocation(CodeBuilder, this, invocation.Expression, false, m_Model, invocation);
                    if (ct > 0) {
                        if (!toplevel) {
                            CodeBuilder.Append("; }");
                        }
                    }
                    CodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
                }
            }
        }
        private void CompoundAssignBegin(string baseOp, AssignmentExpressionSyntax assign, IConversionOperation lopd)
        {
            string functor;
            if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                CodeBuilder.AppendFormat("{0}(", functor);
                OutputExpressionSyntax(assign.Left, lopd);
                CodeBuilder.Append(", ");
            }
            else {
                CodeBuilder.Append("execbinary(");
                CodeBuilder.AppendFormat("\"{0}\", ", baseOp);
                OutputExpressionSyntax(assign.Left, lopd);
                CodeBuilder.Append(", ");
            }
        }
        private void CompoundAssignEnd(string leftType, string rightType, string leftTypeKind, string rightTypeKind)
        {
            CodeBuilder.AppendFormat(", {0}, {1}, {2}, {3}", CsDslTranslater.EscapeType(leftType, leftTypeKind), CsDslTranslater.EscapeType(rightType, rightTypeKind), leftTypeKind, rightTypeKind);
            CodeBuilder.Append(")");
        }
    }
}