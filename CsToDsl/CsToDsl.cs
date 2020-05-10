using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Semantics;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace RoslynTool.CsToDsl
{
    internal sealed class DerivedGenericTypeInstanceInfo
    {
        internal INamedTypeSymbol Symbol;
        internal SyntaxNode Node;
        internal List<ITypeParameterSymbol> TypeParameters = new List<ITypeParameterSymbol>();
        internal List<ITypeSymbol> TypeArguments = new List<ITypeSymbol>();

        internal void FillTypeParamsAndArgs(INamedTypeSymbol refType)
        {
            TypeParameters.AddRange(SymbolTable.Instance.TypeParameters);
            TypeArguments.AddRange(SymbolTable.Instance.TypeArguments);
            SymbolTable.MergeTypeParamsAndArgs(TypeParameters, TypeArguments, refType);
        }
    }
    internal sealed partial class CsDslTranslater : CSharpSyntaxVisitor
    {
        internal enum SpecialAssignmentType
        {
            None = 0,
            PropExplicitImplementInterface,
            PropForBasicValueType,
        }
        internal bool IsSkipGenericTypeDefine
        {
            get { return m_SkipGenericTypeDefine; }
        }
        internal Queue<DerivedGenericTypeInstanceInfo> DerivedGenericTypeInstances
        {
            get { return m_DerivedGenericTypeInstances; }
        }
        internal Dictionary<string, List<ClassInfo>> ToplevelClasses
        {
            get { return m_ToplevelClasses; }
        }
        internal bool HaveError
        {
            get {
                return Logger.Instance.HaveError;
            }
        }
        internal string ErrorLog
        {
            get {
                return Logger.Instance.ErrorLog;
            }
        }
        /// <summary>
        /// 单文件翻译分为两遍，一遍是非泛型的翻译，此时跳过泛型类型。
        /// 另一遍是泛型的翻译，采用C++模板实例化的方式翻译。
        /// 这里是非泛型的翻译入口。
        /// </summary>
        /// <param name="node"></param>
        internal void Translate(SyntaxNode node)
        {
            m_SkipGenericTypeDefine = true;
            Visit(node);
            if (null != m_LastToplevelClass) {
                m_LastToplevelClass.AfterOuterCodeBuilder.Append(m_ToplevelCodeBuilder.ToString());
                m_ToplevelCodeBuilder.Clear();
            }
        }
        /// <summary>
        /// 这是泛型类实例翻译的入口点，处理之前翻译时添加到队列里的泛型类实例。
        /// 翻译的方式和c++的模板实例化类似。
        /// 在翻译的过程发现新的泛型实例也会添加到翻译队列里处理。
        /// </summary>
        /// <param name="node"></param>
        /// <param name="sym"></param>
        internal void Translate(SyntaxNode node, INamedTypeSymbol sym)
        {
            m_SkipGenericTypeDefine = false;
            m_GenericTypeInstance = sym;
            Visit(node);
            if (null != m_LastToplevelClass) {
                m_LastToplevelClass.AfterOuterCodeBuilder.Append(m_ToplevelCodeBuilder.ToString());
                m_ToplevelCodeBuilder.Clear();
            }
        }
        internal void ClearLog()
        {
            Logger.Instance.ClearLog();
        }
        internal void SaveLog(TextWriter writer)
        {
            Logger.Instance.SaveLog(writer);
        }
        internal void SaveLog(string path)
        {
            Logger.Instance.SaveLog(path);
        }
        internal string NameMangling(IMethodSymbol sym)
        {
            return SymbolTable.Instance.NameMangling(sym);
        }
        internal bool CheckExplicitInterfaceAccess(ISymbol sym)
        {
            string nameOfIntf = null;
            string mname = null;
            return CheckExplicitInterfaceAccess(sym, ref nameOfIntf, ref mname);
        }
        internal bool CheckExplicitInterfaceAccess(ISymbol sym, ref string nameOfIntf)
        {
            string mname = null;
            return CheckExplicitInterfaceAccess(sym, ref nameOfIntf, ref mname);
        }
        internal bool CheckExplicitInterfaceAccess(ISymbol sym, ref string nameOfIntf, ref string mname)
        {
            bool ret = false;
            if (sym.ContainingType.TypeKind == TypeKind.Interface) {
                string fn = ClassInfo.GetFullName(sym.ContainingType);
                ClassSymbolInfo csi;
                if (SymbolTable.Instance.ClassSymbols.TryGetValue(fn, out csi)) {
                    switch (sym.Kind) {
                        case SymbolKind.Method:
                            IMethodSymbol msym = sym as IMethodSymbol;
                            if (csi.ExplicitInterfaceImplementationMethods.Contains(msym)) {
                                ret = true;
                                if (null != nameOfIntf) {
                                    nameOfIntf = string.Format("\"{0}\"", fn.Replace(".", "_"));
                                }
                                if (null != mname) {
                                    mname = string.Format("\"{0}\"", NameMangling(msym));
                                }
                            }
                            break;
                        case SymbolKind.Property:
                            IPropertySymbol psym = sym as IPropertySymbol;
                            if (csi.ExplicitInterfaceImplementationProperties.Contains(psym)) {
                                ret = true;
                                if (null != nameOfIntf) {
                                    nameOfIntf = string.Format("\"{0}\"", fn.Replace(".", "_"));
                                }
                                if (null != mname) {
                                    mname = string.Format("\"{0}\"", SymbolTable.GetPropertyName(psym));
                                }
                            }
                            break;
                        case SymbolKind.Event:
                            IEventSymbol esym = sym as IEventSymbol;
                            if (csi.ExplicitInterfaceImplementationEvents.Contains(esym)) {
                                ret = true;
                                if (null != nameOfIntf) {
                                    nameOfIntf = string.Format("\"{0}\"", fn.Replace(".", "_"));
                                }
                                if (null != mname) {
                                    mname = string.Format("\"{0}\"", SymbolTable.GetEventName(esym));
                                }
                            }
                            break;
                    }
                }
            }
            return ret;
        }
        internal void OutputArgumentList(IList<ExpressionSyntax> args, IList<ArgDefaultValueInfo> defValArgs, IList<ITypeSymbol> typeArgs, string externOverloadedMethodSignature, bool postpositionGenericTypeArgs, bool arrayToParams, bool useTypeNameString, SyntaxNode node, params IConversionExpression[] opds)
        {
            if (!string.IsNullOrEmpty(externOverloadedMethodSignature)) {
                CodeBuilder.AppendFormat("\"{0}\"", externOverloadedMethodSignature);
            }
            if (!postpositionGenericTypeArgs && typeArgs.Count > 0) {
                if (!string.IsNullOrEmpty(externOverloadedMethodSignature))
                    CodeBuilder.Append(", ");
                OutputTypeArgumentList(typeArgs, useTypeNameString, node);
            }
            if (args.Count + defValArgs.Count > 0) {
                if (!string.IsNullOrEmpty(externOverloadedMethodSignature) || !postpositionGenericTypeArgs && typeArgs.Count > 0)
                    CodeBuilder.Append(", ");
                OutputExpressionList(args, defValArgs, arrayToParams, opds);
            }
            if (postpositionGenericTypeArgs && typeArgs.Count > 0) {
                if (!string.IsNullOrEmpty(externOverloadedMethodSignature) || args.Count + defValArgs.Count > 0)
                    CodeBuilder.Append(", ");
                OutputTypeArgumentList(typeArgs, useTypeNameString, node);
            }
        }
        internal void OutputExpressionSyntax(ExpressionSyntax node)
        {
            OutputExpressionSyntax(node, null);
        }
        internal void OutputExpressionSyntax(ExpressionSyntax node, IConversionExpression opd)
        {
            if (null != opd && opd.UsesOperatorMethod && !(node is CastExpressionSyntax)) {
                IMethodSymbol msym = opd.OperatorMethod;
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                var arglist = new List<ExpressionSyntax>() { node };
                ii.Init(msym, arglist, m_Model);
                OutputOperatorInvoke(ii, node);
            }
            else {
                VisitExpressionSyntax(node);
            }
        }
        internal ClassInfo GetCurClassInfo()
        {
            return m_ClassInfoStack.Peek();
        }
        internal INamedTypeSymbol GetCurClassSemanticInfo()
        {
            if (m_ClassInfoStack.Count > 0) {
                var info = m_ClassInfoStack.Peek();
                if (null != info) {
                    return info.SemanticInfo;
                }
            }
            return null;
        }
        internal MethodInfo GetCurMethodInfo()
        {
            return m_MethodInfoStack.Peek();
        }
        internal IMethodSymbol GetCurMethodSemanticInfo()
        {
            if (m_MethodInfoStack.Count > 0) {
                var info = m_MethodInfoStack.Peek();
                if (null != info) {
                    return info.SemanticInfo;
                }
            }
            return null;
        }

        internal CsDslTranslater(SemanticModel model, bool enableInherit, bool enableLinq)
        {
            m_Model = model;
            m_EnableInherit = enableInherit;
            m_EnableLinq = enableLinq;
        }

        private string GetIndentString()
        {
            return GetIndentString(m_Indent);
        }
        private void Log(string tag, string format, params object[] args)
        {
            Logger.Instance.Log(tag, format, args);
        }
        private void Log(SyntaxNode node, string format, params object[] args)
        {
            Logger.Instance.Log(node, format, args);
        }
        private void ReportIllegalSymbol(SyntaxNode node, SymbolInfo symInfo)
        {
            Logger.Instance.ReportIllegalSymbol(node, symInfo);
        }
        private void ReportIllegalType(SyntaxNode node, ITypeSymbol typeSym)
        {
            Logger.Instance.ReportIllegalType(node, typeSym);
        }
        private void ReportIllegalType(ITypeSymbol typeSym)
        {
            Logger.Instance.ReportIllegalType(typeSym);
        }
        private INamedTypeSymbol GetTypeDefineSymbol(INamedTypeSymbol declSym)
        {
            if (m_SkipGenericTypeDefine)
                return declSym;
            else
                return m_GenericTypeInstance;
        }
        private void AddReferenceAndTryDeriveGenericTypeInstance(ClassInfo ci, ISymbol refSym)
        {
            ci.AddReference(refSym);
            TryDeriveGenericTypeInstance(refSym);
        }
        private void TryDeriveGenericTypeInstance(ISymbol sym)
        {
            TryDeriveGenericTypeInstance(sym, null);
        }
        private void TryDeriveGenericTypeInstance(ISymbol sym, SyntaxNode node)
        {
            var arrType = sym as IArrayTypeSymbol;
            if (null != arrType) {
                TryDeriveGenericTypeInstance(arrType.ElementType, node);
            }
            else {
                var refType = sym as INamedTypeSymbol;
                if (null == refType) {
                    refType = sym.ContainingType;
                }
                while (null != refType && refType.TypeKind != TypeKind.Class && refType.TypeKind != TypeKind.Struct && refType.TypeKind != TypeKind.Structure) {
                    refType = refType.ContainingType;
                }
                if (null != refType && refType.IsGenericType && SymbolTable.Instance.IsCs2DslSymbol(refType)) {
                    if (m_SkipGenericTypeDefine) {
                        SymbolTable.Instance.AddGenericTypeInstance(ClassInfo.GetFullName(refType), refType);
                    }
                    else if (!ClassInfo.HasAttribute(refType, "Cs2Dsl.IgnoreAttribute")) {
                        var instInfo = new DerivedGenericTypeInstanceInfo();
                        instInfo.Symbol = refType;
                        instInfo.Node = null;
                        instInfo.FillTypeParamsAndArgs(refType);
                        m_DerivedGenericTypeInstances.Enqueue(instInfo);
                    }
                }
            }
        }
        private void TryConvertTypeArgmentList(IMethodSymbol sym, int argCount)
        {
            var typeArgs = sym.TypeArguments;
            for (int i = 0; i < typeArgs.Length; ++i) {
                var t = typeArgs[i];
                string ns = ClassInfo.GetFullName(t);
                string fullName = string.IsNullOrEmpty(ns) ? t.Name : ns + "." + t.Name;
                CodeBuilder.Append(fullName);
                if (i < typeArgs.Length - 1) {
                    CodeBuilder.Append(", ");
                }
            }
            if (typeArgs.Length > 0 && argCount > 0) {
                CodeBuilder.Append(", ");
            }
        }
        private void OutputWrapValueParams(StringBuilder codeBuilder, MethodInfo mi)
        {
            for (int i = 0; i < mi.ParamNames.Count; ++i) {
                var name = mi.ParamNames[i];
                var type = mi.ParamTypes[i];
                if (mi.ValueParams.Contains(i)) {
                    codeBuilder.AppendFormat("{0}{1} = wrapstruct({2}, {3});", GetIndentString(), name, name, type);
                    codeBuilder.AppendLine();
                }
                else if (mi.ExternValueParams.Contains(i)) {
                    codeBuilder.AppendFormat("{0}{1} = wrapexternstruct({2}, {3});", GetIndentString(), name, name, type);
                    codeBuilder.AppendLine();
                }
            }
        }
        private void OutputExpressionList(IList<ExpressionSyntax> args)
        {
            OutputExpressionList(args, null, false);
        }
        private void OutputExpressionList(IList<ExpressionSyntax> args, IList<ArgDefaultValueInfo> defValArgs, bool arrayToParams, params IConversionExpression[] opds)
        {
            int ct = args.Count;
            for (int i = 0; i < ct; ++i) {
                var exp = args[i];
                var opd = opds.Length > i ? opds[i] : null;
                //表达式对象为空表明这个是一个out实参，替换为__cs2dsl_out
                if (null == exp) {
                    CodeBuilder.Append("__cs2dsl_out");
                }
                else if (i < ct - 1) {
                    OutputExpressionSyntax(exp, opd);
                }
                else {
                    if (arrayToParams) {
                        CodeBuilder.Append("dslunpack(");
                        OutputExpressionSyntax(exp, opd);
                        CodeBuilder.Append(")");
                    }
                    else {
                        OutputExpressionSyntax(exp, opd);
                    }
                }
                if (i < ct - 1) {
                    CodeBuilder.Append(", ");
                }
            }
            if (null != defValArgs) {
                int dvCt = defValArgs.Count;
                if (ct > 0 && dvCt > 0) {
                    CodeBuilder.Append(", ");
                }
                for (int i = 0; i < dvCt; ++i) {
                    var info = defValArgs[i];
                    var opd = opds.Length > ct + i ? opds[ct + i] : null;
                    if (null != info.Expression) {
                        OutputExpressionSyntax(info.Expression, opd);
                    }
                    else {
                        OutputArgumentDefaultValue(info.Value, info.OperOrSym, opd);
                    }
                    if (i < dvCt - 1) {
                        CodeBuilder.Append(", ");
                    }
                }
            }
        }
        private void OutputTypeArgumentList(IList<ITypeSymbol> typeArgs, bool useTypeNameString, SyntaxNode node)
        {
            int ct = typeArgs.Count;
            for (int i = 0; i < ct; ++i) {
                var type = typeArgs[i];
                if (useTypeNameString) {
                    CodeBuilder.Append("\"");
                    string typeName = ClassInfo.GetFullName(type);
                    CodeBuilder.Append(typeName);
                    CodeBuilder.Append("\"");
                }
                else {
                    var ci = m_ClassInfoStack.Peek();
                    OutputType(type, node, ci, "invoke");
                }
                if (i < ct - 1) {
                    CodeBuilder.Append(", ");
                }
            }
        }
        private void OutputArgumentList(SeparatedSyntaxList<ArgumentSyntax> args, string split, IOperation oper)
        {
            var arrOper = oper as IArrayElementReferenceExpression;
            var indexerOper = oper as IIndexedPropertyReferenceExpression;
            int ct = args.Count;
            for (int i = 0; i < ct; ++i) {
                var arg = args[i];
                if (null != arrOper) {
                    bool isConst = false;
                    if (i < arrOper.Indices.Length) {
                        var constVal = arrOper.Indices[i].ConstantValue;
                        if (constVal.HasValue) {
                            if (SymbolTable.ArrayLowerBoundIsOne)
                                CodeBuilder.Append((int)constVal.Value + 1);
                            else
                                CodeBuilder.Append((int)constVal.Value);
                            isConst = true;
                        }
                    }
                    if (!isConst) {
                        VisitArgument(arg);
                        if (SymbolTable.ArrayLowerBoundIsOne) {
                            CodeBuilder.Append(" + 1");
                        }
                    }
                }
                else if (null != indexerOper) {
                    bool isConst = false;
                    if (i < indexerOper.ArgumentsInParameterOrder.Length) {
                        var argSym = indexerOper.ArgumentsInParameterOrder[i];
                        var constVal = argSym.Value.ConstantValue;
                        if (constVal.HasValue && constVal.Value is int) {
                            CodeBuilder.Append((int)constVal.Value);
                            isConst = true;
                        }
                    }
                    if (!isConst) {
                        VisitArgument(arg);
                    }
                }
                else {
                    VisitArgument(arg);
                }
                if (i < ct - 1) {
                    CodeBuilder.Append(split);
                }
            }
        }
        private void OutputNewValueType(INamedTypeSymbol namedTypeSym)
        {
            if (null == namedTypeSym) {
                return;
            }

            bool isCollection = IsImplementationOfSys(namedTypeSym, "ICollection");
            bool isExternal = !SymbolTable.Instance.IsCs2DslSymbol(namedTypeSym);
            string fullTypeName = ClassInfo.GetFullName(namedTypeSym);

            IMethodSymbol sym = null;
            foreach (var c in namedTypeSym.InstanceConstructors) {
                if (!c.IsGenericMethod && c.Parameters.Length == 0) {
                    sym = c;
                }
            }

            string ctor = null;
            if (null != sym) {
                ctor = NameMangling(sym);
            }

            if (isCollection) {
                bool isDictionary = IsImplementationOfSys(namedTypeSym, "IDictionary");
                bool isList = IsImplementationOfSys(namedTypeSym, "IList");
                if (isDictionary) {
                    //字典对象的处理
                    CodeBuilder.AppendFormat("new{0}dictionary({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                }
                else if (isList) {
                    //列表对象的处理
                    CodeBuilder.AppendFormat("new{0}list({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                }
                else {
                    //集合对象的处理
                    CodeBuilder.AppendFormat("new{0}collection({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                }
            }
            else {
                CodeBuilder.AppendFormat("new{0}object({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
            }
            if (!isExternal) {
                //外部对象函数名不会换名，所以没必要提供名字，总是ctor。翻译的类在没有明确构造时，会生成
                if (string.IsNullOrEmpty(ctor)) {
                    CodeBuilder.Append(", \"ctor\"");
                }
                else {
                    CodeBuilder.AppendFormat(", \"{0}\"", ctor);
                }
            }
            if (isCollection) {
                bool isDictionary = IsImplementationOfSys(namedTypeSym, "IDictionary");
                bool isList = IsImplementationOfSys(namedTypeSym, "IList");
                if (isDictionary) {
                    CodeBuilder.Append(", literaldictionary(");
                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                    CodeBuilder.Append(")");
                }
                else if (isList) {
                    CodeBuilder.Append(", literallist(");
                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                    CodeBuilder.Append(")");
                }
                else {
                    CodeBuilder.Append(", literalcollection(");
                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                    CodeBuilder.Append(")");
                }
            }
            else {
                CodeBuilder.Append(", null");
            }
            CodeBuilder.Append(");");
        }
        private void OutputDefaultValue(ITypeSymbol type)
        {
            OutputDefaultValue(type, false);
        }
        private void OutputDefaultValue(ITypeSymbol type, bool setValueTypeToNull)
        {
            OutputDefaultValue(CodeBuilder, type, setValueTypeToNull);
        }
        private void OutputArgumentDefaultValue(object val, object operOrSym, IConversionExpression opd)
        {
            if (null != opd && opd.UsesOperatorMethod) {
                IMethodSymbol msym = opd.OperatorMethod;
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                ii.Init(msym, (List<ExpressionSyntax>)null, m_Model);
                OutputConversionInvokePrefix(ii);
            }
            if (null == val) {
                bool handled = false;
                var oper = operOrSym as IOperation;
                if (null != oper) {
                    var tree = oper.Syntax.SyntaxTree;
                    var newModel = m_Model.Compilation.GetSemanticModel(tree, true);
                    if (null != newModel) {
                        if (m_ClassInfoStack.Count > 0 && m_MethodInfoStack.Count > 0) {
                            CsToDsl.CsDslTranslater trans = new CsDslTranslater(newModel, m_EnableInherit, m_EnableLinq);

                            var ci = new ClassInfo();
                            trans.m_ClassInfoStack.Push(ci);
                            var curCi = m_ClassInfoStack.Peek();
                            ci.Init(curCi.SemanticInfo, curCi.ClassSemanticInfo);

                            var mi = new MethodInfo();
                            trans.m_MethodInfoStack.Push(mi);
                            var curMi = m_MethodInfoStack.Peek();
                            mi.Init(curMi.SemanticInfo, curMi.SyntaxNode);

                            trans.Visit(oper.Syntax);
                            CodeBuilder.Append(trans.CodeBuilder.ToString());

                            trans.m_MethodInfoStack.Pop();
                            trans.m_ClassInfoStack.Pop();
                            handled = true;
                        }
                    }
                }
                if (!handled) {
                    var objCreate = operOrSym as IObjectCreationExpression;
                    var arrCreate = operOrSym as IArrayCreationExpression;
                    var fieldRef = operOrSym as IFieldReferenceExpression;
                    var propRef = operOrSym as IPropertyReferenceExpression;
                    if (null != objCreate) {
                        var namedTypeSym = objCreate.Type as INamedTypeSymbol;
                        var sym = objCreate.Constructor;
                        var args = objCreate.ArgumentsInParameterOrder;
                        var memberInit = objCreate.MemberInitializers;

                        bool isCollection = IsImplementationOfSys(namedTypeSym, "ICollection");
                        bool isExternal = !SymbolTable.Instance.IsCs2DslSymbol(namedTypeSym);
                        string fullTypeName = ClassInfo.GetFullName(namedTypeSym);

                        string ctor = null;
                        if (null != sym) {
                            ctor = NameMangling(sym);
                        }

                        if (isCollection) {
                            bool isDictionary = IsImplementationOfSys(namedTypeSym, "IDictionary");
                            bool isList = IsImplementationOfSys(namedTypeSym, "IList");
                            if (isDictionary) {
                                //字典对象的处理
                                CodeBuilder.AppendFormat("new{0}dictionary({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                                CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                            }
                            else if (isList) {
                                //列表对象的处理
                                CodeBuilder.AppendFormat("new{0}list({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                                CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                            }
                            else {
                                //集合对象的处理
                                CodeBuilder.AppendFormat("new{0}collection({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                                CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                            }
                        }
                        else {
                            CodeBuilder.AppendFormat("new{0}object({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                            CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                        }
                        if (!isExternal) {
                            //外部对象函数名不会换名，所以没必要提供名字，总是ctor
                            if (string.IsNullOrEmpty(ctor)) {
                                CodeBuilder.Append(", null");
                            }
                            else {
                                CodeBuilder.AppendFormat(", \"{0}\"", ctor);
                            }
                        }
                        if (null == memberInit || memberInit.Length <= 0) {
                            if (isCollection) {
                                bool isDictionary = IsImplementationOfSys(namedTypeSym, "IDictionary");
                                bool isList = IsImplementationOfSys(namedTypeSym, "IList");
                                if (isDictionary) {
                                    CodeBuilder.Append(", literaldictionary(");
                                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                                    CodeBuilder.Append(")");
                                }
                                else if (isList) {
                                    CodeBuilder.Append(", literallist(");
                                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                                    CodeBuilder.Append(")");
                                }
                                else {
                                    CodeBuilder.Append(", literalcollection(");
                                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                                    CodeBuilder.Append(")");
                                }
                            }
                            else {
                                CodeBuilder.Append(", null");
                            }
                        }
                        else {
                            Log(objCreate.Syntax, "Too complex default parameter value of extern method !");
                        }
                        if (null != args) {
                            foreach (var arg in args) {
                                CodeBuilder.Append(", ");
                                if (arg.Value.ConstantValue.HasValue) {
                                    OutputConstValue(arg.Value.ConstantValue.Value, arg.Value);
                                }
                                else {
                                    Log(objCreate.Syntax, "Too complex default parameter value of extern method !");
                                }
                            }
                        }
                        CodeBuilder.Append(" );}");
                    }
                    else if (null != arrCreate) {
                        ITypeSymbol etype = SymbolTable.GetElementType(arrCreate.ElementType);
                        string elementType = ClassInfo.GetFullName(etype);
                        if (arrCreate.DimensionSizes.Length == 1) {
                            if (null == arrCreate.Initializer || arrCreate.Initializer.ElementValues.Length == 0) {
                                CodeBuilder.AppendFormat("newarray({0}, TypeKind.{1})", elementType, etype.TypeKind.ToString());
                            }
                            else {
                                CodeBuilder.AppendFormat("literalarray({0}, TypeKind.{1}, ", elementType, etype.TypeKind.ToString());
                                string prestr = string.Empty;
                                foreach (var arg in arrCreate.Initializer.ElementValues) {
                                    CodeBuilder.Append(prestr);
                                    prestr = ", ";
                                    if (arg.ConstantValue.HasValue) {
                                        OutputConstValue(arg.ConstantValue.Value, arg);
                                    }
                                    else {
                                        Log(arrCreate.Syntax, "Too complex default parameter value of extern method !");
                                    }
                                }
                                CodeBuilder.Append(")");
                            }
                        }
                        else {
                            Log(arrCreate.Syntax, "Too complex default parameter value of extern method !");
                        }
                    }
                    else if (null != fieldRef) {
                        var field = fieldRef.Field;
                        bool isExtern = !SymbolTable.Instance.IsCs2DslSymbol(field);
                        if(isExtern)
                            CodeBuilder.Append("getexternstatic(SymbolKind.");
                        else
                            CodeBuilder.Append("getstatic(SymbolKind.");
                        CodeBuilder.Append(field.Kind.ToString());
                        CodeBuilder.Append(", ");
                        CodeBuilder.Append(ClassInfo.GetFullName(field.Type));
                        CodeBuilder.Append(", \"");
                        CodeBuilder.Append(field.Name);
                        CodeBuilder.Append("\")");
                    }
                    else if (null != propRef) {
                        var property = propRef.Property;
                        bool isExtern = !SymbolTable.Instance.IsCs2DslSymbol(property);
                        if (isExtern)
                            CodeBuilder.Append("getexternstatic(SymbolKind.");
                        else
                            CodeBuilder.Append("getstatic(SymbolKind.");
                        CodeBuilder.Append(property.Kind.ToString());
                        CodeBuilder.Append(", ");
                        CodeBuilder.Append(ClassInfo.GetFullName(property.Type));
                        CodeBuilder.Append(", \"");
                        CodeBuilder.Append(property.Name);
                        CodeBuilder.Append("\")");
                    }
                    else {
                        OutputConstValue(val, operOrSym);
                    }
                }
            }
            else {
                OutputConstValue(val, operOrSym);
            }
            if (null != opd && opd.UsesOperatorMethod) {
                CodeBuilder.Append(")");
            }
        }
        private void OutputConstValue(object val, object operOrSym)
        {
            OutputConstValue(CodeBuilder, val, operOrSym);
        }
        private void OutputType(ITypeSymbol type, SyntaxNode node, ClassInfo ci, string errorTag)
        {
            if (null != type && type.TypeKind != TypeKind.Error) {
                if (type.TypeKind == TypeKind.TypeParameter) {
                    var typeParam = type as ITypeParameterSymbol;
                    if (typeParam.TypeParameterKind == TypeParameterKind.Type && !m_SkipGenericTypeDefine && null != m_GenericTypeInstance) {
                        IMethodSymbol sym = FindClassMethodDeclaredSymbol(node);
                        if (null != sym) {
                            var t = SymbolTable.Instance.FindTypeArgument(type);
                            if (t.TypeKind != TypeKind.TypeParameter) {
                                CodeBuilder.Append(ClassInfo.GetFullName(t));
                                AddReferenceAndTryDeriveGenericTypeInstance(ci, t);
                            }
                            else {
                                CodeBuilder.Append(t.Name);
                            }
                        }
                        else {
                            ISymbol varSym = FindVariableDeclaredSymbol(node);
                            if (null != varSym) {
                                var t = SymbolTable.Instance.FindTypeArgument(type);
                                if (t.TypeKind != TypeKind.TypeParameter) {
                                    CodeBuilder.Append(ClassInfo.GetFullName(t));
                                    AddReferenceAndTryDeriveGenericTypeInstance(ci, t);
                                }
                                else {
                                    CodeBuilder.Append(t.Name);
                                }
                            }
                            else {
                                Log(node, "Can't find declaration for type param !", type.Name);
                            }
                        }
                    }
                    else {
                        CodeBuilder.Append(type.Name);
                    }
                }
                else if (type.TypeKind == TypeKind.Array) {
                    var arrType = type as IArrayTypeSymbol;
                    CodeBuilder.Append("System.Array");
                }
                else if (type.TypeKind == TypeKind.Delegate) {
                    var fullName = ClassInfo.GetFullName(type);
                    CodeBuilder.AppendFormat("\"{0}\"", fullName);
                }
                else {
                    var fullName = ClassInfo.GetFullName(type);
                    CodeBuilder.Append(fullName);

                    var namedType = type as INamedTypeSymbol;
                    if (null != namedType) {
                        AddReferenceAndTryDeriveGenericTypeInstance(ci, namedType);
                    }
                }
            }
            else if (null != type) {
                CodeBuilder.Append("null");
                ReportIllegalType(node, type);
            }
            else {
                CodeBuilder.Append("null");
                Log(node, "Unknown {0} Type !", errorTag);
            }
        }
        private void ProcessUnaryOperator(CSharpSyntaxNode node, ref string op)
        {
            if (s_UnsupportedUnaryOperators.Contains(op)) {
                Log(node, "Cs2Dsl can't support {0} unary operators !", op);
            }
            else {
                string nop;
                if (s_UnaryAlias.TryGetValue(op, out nop)) {
                    op = nop;
                }
            }
        }
        private void ProcessBinaryOperator(CSharpSyntaxNode node, ref string op)
        {
            if (s_UnsupportedBinaryOperators.Contains(op)) {
                Log(node, "Cs2Dsl can't support {0} binary operators !", op);
            }
            else {
                string nop;
                if (s_BinaryAlias.TryGetValue(op, out nop)) {
                    op = nop;
                }
            }
        }
        private void OutputOperatorInvoke(InvocationInfo ii, SyntaxNode node)
        {
            if (!ii.IsExternMethod) {
                CodeBuilder.AppendFormat("invokeoperator({0}, {1}, ", ClassInfo.GetFullName(ii.MethodSymbol.ReturnType), ii.ClassKey);
                string manglingName = NameMangling(ii.MethodSymbol);
                CodeBuilder.AppendFormat("\"{0}\"", manglingName);
                CodeBuilder.Append(", ");
                OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ExternOverloadedMethodSignature, ii.PostPositionGenericTypeArgs, ii.ArrayToParams, false, node, ii.ArgConversions.ToArray());
                CodeBuilder.Append(")");
            }
            else {
                string method = ii.MethodSymbol.Name;
                CodeBuilder.AppendFormat("invokeexternoperator({0}, {1}, ", ClassInfo.GetFullName(ii.MethodSymbol.ReturnType), ii.GenericClassKey);
                CodeBuilder.AppendFormat("\"{0}\"", method);
                CodeBuilder.Append(", ");
                OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ExternOverloadedMethodSignature, ii.PostPositionGenericTypeArgs, ii.ArrayToParams, false, node, ii.ArgConversions.ToArray());
                CodeBuilder.Append(")");
            }
        }
        private void OutputConversionInvokePrefix(InvocationInfo ii)
        {
            if (!ii.IsExternMethod) {
                CodeBuilder.AppendFormat("invokeoperator({0}, {1}, ", ClassInfo.GetFullName(ii.MethodSymbol.ReturnType), ii.ClassKey);
                string manglingName = NameMangling(ii.MethodSymbol);
                CodeBuilder.AppendFormat("\"{0}\"", manglingName);
                CodeBuilder.Append(", ");
            }
            else {
                string method = ii.MethodSymbol.Name;
                CodeBuilder.AppendFormat("invokeexternoperator({0}, {1}, ", ClassInfo.GetFullName(ii.MethodSymbol.ReturnType), ii.GenericClassKey);
                CodeBuilder.AppendFormat("\"{0}\"", method);
                CodeBuilder.Append(", ");
                if (!string.IsNullOrEmpty(ii.ExternOverloadedMethodSignature)) {
                    CodeBuilder.AppendFormat("\"{0}\"", ii.ExternOverloadedMethodSignature);
                    CodeBuilder.Append(", ");
                }
            }
        }
        private bool ProcessEqualOrNotEqual(string op, ExpressionSyntax left, ExpressionSyntax right, IConversionExpression lopd, IConversionExpression ropd)
        {
            bool handled = false;
            var leftOper = m_Model.GetOperation(left);
            var rightOper = m_Model.GetOperation(right);
            //外部的delegation只能是成员，因为delegation类型就是普通的function，这里不能以delegation的类型来判断是否外部类型
            if (null != leftOper && null != rightOper && null != leftOper.Type && leftOper.Type.TypeKind == TypeKind.Delegate && (!leftOper.ConstantValue.HasValue || null != leftOper.ConstantValue.Value) && rightOper.ConstantValue.HasValue && rightOper.ConstantValue.Value == null) {
                var sym = m_Model.GetSymbolInfo(left);
                var leftSym = sym.Symbol;
                bool isCs2Lua = true;
                if (null != leftSym && (leftSym.Kind == SymbolKind.Field || leftSym.Kind == SymbolKind.Property || leftSym.Kind == SymbolKind.Event) && !SymbolTable.Instance.IsCs2DslSymbol(leftSym.ContainingType)) {
                    isCs2Lua = false;
                }
                bool isEvent = (null != leftOper && leftOper is IEventReferenceExpression) || (null != rightOper && rightOper is IEventReferenceExpression);                
                OutputDelegationCompareWithNull(leftSym, leftOper, left, isCs2Lua, isEvent, op == "==", lopd);
                handled = true;
            }
            else if (null != leftOper && null != rightOper && null != rightOper.Type && rightOper.Type.TypeKind == TypeKind.Delegate && (!rightOper.ConstantValue.HasValue || null != rightOper.ConstantValue.Value) && leftOper.ConstantValue.HasValue && leftOper.ConstantValue.Value == null) {
                var sym = m_Model.GetSymbolInfo(right);
                var rightSym = sym.Symbol;
                bool isCs2Lua = true;
                if (null != rightSym && (rightSym.Kind == SymbolKind.Field || rightSym.Kind == SymbolKind.Property || rightSym.Kind == SymbolKind.Event) && !SymbolTable.Instance.IsCs2DslSymbol(rightSym.ContainingType)) {
                    isCs2Lua = false;
                }
                bool isEvent = (null != leftOper && leftOper is IEventReferenceExpression) || (null != rightOper && rightOper is IEventReferenceExpression);
                OutputDelegationCompareWithNull(rightSym, rightOper, right, isCs2Lua, isEvent, op == "==", ropd);
                handled = true;
            }
            return handled;
        }
        private void OutputDelegationCompareWithNull(ISymbol leftSym, IOperation leftOper, ExpressionSyntax left, bool isCs2LuaAssembly, bool isEvent, bool isEqual, IConversionExpression opd)
        {
            if (null == leftSym && null == leftOper) {
                Log(left, "delegation compare with null, left symbol == null and left oper == null");
                return;
            }
            bool isStatic = null != leftSym ? leftSym.IsStatic : false;
            var ci = m_ClassInfoStack.Peek();
            CodeBuilder.AppendFormat("{0}delegationcomparewithnil({1}, {2}, ", isCs2LuaAssembly ? string.Empty : "extern", isEvent ? "true" : "false", isStatic ? "true" : "false");
            if (null != leftSym && (leftSym.Kind == SymbolKind.Field || leftSym.Kind == SymbolKind.Property || leftSym.Kind == SymbolKind.Event)) {
                string containingName = ClassInfo.GetFullName(leftSym.ContainingType);
                var memberAccess = left as MemberAccessExpressionSyntax;
                if (null != memberAccess) {
                    CodeBuilder.AppendFormat("\"{0}:{1}\", ", containingName, memberAccess.Name.Identifier.Text);
                    OutputExpressionSyntax(memberAccess.Expression, opd);
                    CodeBuilder.Append(", ");
                    string intf = "null";
                    string mname = string.Format("\"{0}\"", memberAccess.Name.Identifier.Text);
                    CheckExplicitInterfaceAccess(leftSym, ref intf, ref mname);
                    CodeBuilder.AppendFormat("{0}, {1}", intf, mname);
                }
                else if (leftSym.ContainingType == ci.SemanticInfo || leftSym.ContainingType == ci.SemanticInfo.OriginalDefinition || ci.IsInherit(leftSym.ContainingType)) {
                    CodeBuilder.AppendFormat("\"{0}:{1}\", ", containingName, leftSym.Name);
                    if (isStatic)
                        CodeBuilder.AppendFormat("{0}, null, ", ClassInfo.GetFullName(leftSym.ContainingType));
                    else
                        CodeBuilder.Append("this, null, ");
                    CodeBuilder.AppendFormat("\"{0}\"", leftSym.Name);
                }
                else {
                    CodeBuilder.AppendFormat("\"{0}:{1}\", ", containingName, leftSym.Name);
                    OutputExpressionSyntax(left, opd);
                    CodeBuilder.Append(", null, null");
                }
            }
            else if (null != leftSym) {
                string containingName = ClassInfo.GetFullName(leftSym.ContainingType);
                CodeBuilder.AppendFormat("\"{0}:{1}\", ", containingName, leftSym.Name);
                OutputExpressionSyntax(left, opd);
                CodeBuilder.Append(", null, null");
            }
            else {
                string containingName = ClassInfo.GetFullName(leftOper.Type);
                CodeBuilder.AppendFormat("\"{0}\", ", containingName);
                OutputExpressionSyntax(left, opd);
                CodeBuilder.Append(", null, null");
            }
            CodeBuilder.AppendFormat(", {0})", isEqual ? "true" : "false");
        }
        private void OutputTryCatchUsingReturn(ReturnContinueBreakAnalysis returnAnalysis, MethodInfo mi, string retVar, string retValVar)
        {
            if (mi.TryCatchUsingLayer > 0) {
                CodeBuilder.AppendFormat("{0}if({1} && {2} && {2}>=1 && {2}<=3){{", GetIndentString(), retVar, retValVar);
                CodeBuilder.AppendLine();
                ++m_Indent;
                CodeBuilder.AppendFormat("{0}return({1});", GetIndentString(), retValVar);
                CodeBuilder.AppendLine();
                --m_Indent;
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
            }
            else {
                CodeBuilder.AppendFormat("{0}if({1} && {2}){{", GetIndentString(), retVar, retValVar);
                CodeBuilder.AppendLine();
                bool existIf = false;
                if (returnAnalysis.ExistReturn) {
                    CodeBuilder.AppendFormat("{0}if({1}==1){{", GetIndentString(), retValVar);
                    CodeBuilder.AppendLine();
                    ++m_Indent;

                    string prestr;
                    if (mi.SemanticInfo.MethodKind == MethodKind.Constructor) {
                        CodeBuilder.AppendFormat("{0}return(this", GetIndentString());
                        prestr = ", ";
                    }
                    else {
                        CodeBuilder.AppendFormat("{0}return(", GetIndentString());
                        prestr = string.Empty;
                    }
                    CodeBuilder.Append(prestr);
                    CodeBuilder.Append(mi.ReturnVarName);
                    prestr = ", ";
                    var names = mi.ReturnParamNames;
                    if (names.Count > 0) {
                        for (int i = 0; i < names.Count; ++i) {
                            CodeBuilder.Append(prestr);
                            CodeBuilder.Append(names[i]);
                            prestr = ", ";
                        }
                    }
                    CodeBuilder.AppendLine(");");
                    existIf = true;
                }
                if (returnAnalysis.ExistContinue) {
                    if (existIf) {
                        --m_Indent;
                        CodeBuilder.AppendFormat("{0}}}elseif({1}==2){{", GetIndentString(), retValVar);
                    }
                    else {
                        CodeBuilder.AppendFormat("{0}if({1}==2){{", GetIndentString(), retValVar);
                    }
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    CodeBuilder.AppendFormat("{0}break;", GetIndentString());
                    CodeBuilder.AppendLine();
                    existIf = true;
                }
                if (returnAnalysis.ExistBreak) {
                    if (existIf) {
                        --m_Indent;
                        CodeBuilder.AppendFormat("{0}}}elseif({1}==3){{", GetIndentString(), retValVar);
                    }
                    else {
                        CodeBuilder.AppendFormat("{0}if({1}==3){{", GetIndentString(), retValVar);
                    }
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    CodeBuilder.AppendFormat("{0}break;", GetIndentString());
                    CodeBuilder.AppendLine();
                    existIf = true;
                }
                if (existIf) {
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        private void AddToplevelClass(string key, ClassInfo ci)
        {
            List<ClassInfo> list;
            if (!m_ToplevelClasses.TryGetValue(key, out list)) {
                list = new List<ClassInfo>();
                m_ToplevelClasses.Add(key, list);
            }
            list.Add(ci);
            m_LastToplevelClass = ci;
        }
        private bool IsNewObjMember(string name)
        {
            SymbolKind kind;
            return IsNewObjMember(name, out kind);
        }
        private bool IsNewObjMember(string name, out SymbolKind kind)
        {
            if (m_ObjectInitializerStack.Count > 0) {
                ITypeSymbol symInfo = m_ObjectInitializerStack.Peek();
                if (null != symInfo) {
                    var names = symInfo.GetMembers(name);
                    if (names.Length > 0) {
                        kind = names[0].Kind;
                        return true;
                    }
                }
            }
            kind = SymbolKind.ErrorType;
            return false;
        }
        private IMethodSymbol FindClassMethodDeclaredSymbol(SyntaxNode node)
        {
            while (null != node) {
                var constructor = node as ConstructorDeclarationSyntax;
                if (null != constructor) {
                    return m_Model.GetDeclaredSymbol(constructor);
                }
                var method = node as MethodDeclarationSyntax;
                if (null != method) {
                    return m_Model.GetDeclaredSymbol(method);
                }
                var accessor = node as AccessorDeclarationSyntax;
                if (null != accessor) {
                    return m_Model.GetDeclaredSymbol(accessor);
                }
                node = node.Parent;
            }
            return null;
        }
        private ISymbol FindVariableDeclaredSymbol(SyntaxNode node)
        {
            while (null != node) {
                var varDecl = node as VariableDeclaratorSyntax;
                if (null != varDecl) {
                    return m_Model.GetDeclaredSymbol(varDecl);
                }
                node = node.Parent;
            }
            return null;
        }
        private bool IsLastNodeOfTryCatch(SyntaxNode node)
        {
            bool ret = false;
            var parent = node.Parent;
            if (null != node && null != parent) {
                int ix = -1;
                int ct = 0;
                var nodes = parent.ChildNodes();
                var enumer = nodes.GetEnumerator();
                while (enumer.MoveNext()) {
                    if (enumer.Current == node) {
                        ix = ct;
                    }
                    ++ct;
                }
                ret = ix == ct - 1;
            }
            while (null != parent && parent.IsKind(SyntaxKind.Block)) {
                parent = parent.Parent;
            }
            ret = ret && (parent.IsKind(SyntaxKind.TryStatement) || parent.IsKind(SyntaxKind.CatchClause));
            return ret;
        }
        private bool IsLastNodeOfMethod(SyntaxNode node)
        {
            bool ret = false;
            var parent = node.Parent;
            if (null != node && null != parent) {
                int ix = -1;
                int ct = 0;
                var nodes = parent.ChildNodes();
                var enumer = nodes.GetEnumerator();
                while (enumer.MoveNext()) {
                    if (enumer.Current == node) {
                        ix = ct;
                    }
                    ++ct;
                }
                ret = ix == ct - 1;
            }
            while (null != parent && parent.IsKind(SyntaxKind.Block)) {
                parent = parent.Parent;
            }
            ret = ret && (parent.IsKind(SyntaxKind.MethodDeclaration) || parent.IsKind(SyntaxKind.ConstructorDeclaration) || parent.IsKind(SyntaxKind.ParenthesizedLambdaExpression) || parent.IsKind(SyntaxKind.AnonymousMethodExpression) || null != parent.Parent && parent.Parent.IsKind(SyntaxKind.AccessorList));
            return ret;
        }
        private bool IsLastNodeOfFor(SyntaxNode node)
        {
            bool ret = false;
            var parent = node.Parent;
            if (null != node && null != parent) {
                int ix = -1;
                int ct = 0;
                var nodes = parent.ChildNodes();
                var enumer = nodes.GetEnumerator();
                while (enumer.MoveNext()) {
                    if (enumer.Current == node) {
                        ix = ct;
                    }
                    ++ct;
                }
                ret = ix == ct - 1;
            }
            while (null != parent && parent.IsKind(SyntaxKind.Block)) {
                parent = parent.Parent;
            }
            ret = ret && (parent.IsKind(SyntaxKind.ForStatement));
            return ret;
        }
        private bool IsLastNodeOfParent(SyntaxNode node)
        {
            var parent = node.Parent;
            var nextNode = GetNextNode(node, parent);
            if (null == nextNode) {
                if (parent.IsKind(SyntaxKind.Block)) {
                    parent = parent.Parent;
                    if (parent.IsKind(SyntaxKind.ForEachStatement) || parent.IsKind(SyntaxKind.ForStatement) || parent.IsKind(SyntaxKind.DoStatement) || parent.IsKind(SyntaxKind.WhileStatement)) {
                        return false;
                    }
                }
                return true;
            }
            else {
                if (nextNode.IsKind(SyntaxKind.ElseClause)) {
                    return true;
                }
                return false;
            }
        }
        private SyntaxNode GetParentBlockNode(SyntaxNode node)
        {
            var parent = node.Parent;
            while (null != parent) {
                if (parent.IsKind(SyntaxKind.Block))
                    return parent;
                parent = parent.Parent;
            }
            return null;
        }
        private SyntaxNode GetNextNode(SyntaxNode node, SyntaxNode parent)
        {
            if (null != node && null != parent) {
                int ix = -1;
                int ct = 0;
                var nodes = parent.ChildNodes();
                var enumer = nodes.GetEnumerator();
                while (enumer.MoveNext()) {
                    if (enumer.Current == node) {
                        ix = ct;
                    }
                    if (ix >= 0 && ix + 1 == ct) {
                        return enumer.Current;
                    }
                    ++ct;
                }
            }
            return null;
        }

        private StringBuilder CodeBuilder
        {
            get {
                if (m_ClassInfoStack.Count > 0) {
                    var ci = m_ClassInfoStack.Peek();
                    var builder = ci.CurrentCodeBuilder;
                    if (null != builder) {
                        return builder;
                    }
                }
                return m_ToplevelCodeBuilder;
            }
        }

        private bool m_SkipGenericTypeDefine = false;
        private INamedTypeSymbol m_GenericTypeInstance = null;
        private Queue<DerivedGenericTypeInstanceInfo> m_DerivedGenericTypeInstances = new Queue<DerivedGenericTypeInstanceInfo>();

        private SemanticModel m_Model = null;
        private bool m_EnableInherit = false;
        private bool m_EnableLinq = false;
        private StringBuilder m_LogBuilder = new StringBuilder();
        private int m_Indent = 0;
        private StringBuilder m_ToplevelCodeBuilder = new StringBuilder();

        private Stack<ClassInfo> m_ClassInfoStack = new Stack<ClassInfo>();
        private Stack<MethodInfo> m_MethodInfoStack = new Stack<MethodInfo>();
        private Stack<ITypeSymbol> m_ObjectInitializerStack = new Stack<ITypeSymbol>();
        private Stack<ContinueInfo> m_ContinueInfoStack = new Stack<ContinueInfo>();
        private Stack<SwitchInfo> m_SwitchInfoStack = new Stack<SwitchInfo>();
        private Queue<PostfixUnaryExpressionSyntax> m_PostfixUnaryExpressions = new Queue<PostfixUnaryExpressionSyntax>();

        private class LinqParamInfo
        {
            internal List<string> ParamNames = new List<string>();
            internal string JoinParamName = string.Empty;
            internal string Prestr = string.Empty;
            internal string OrderByPrestr = string.Empty;
        }
        private Stack<LinqParamInfo> m_LinqParamInfoStack = new Stack<LinqParamInfo>();

        private Dictionary<string, List<ClassInfo>> m_ToplevelClasses = new Dictionary<string, List<ClassInfo>>();
        private ClassInfo m_LastToplevelClass = null;
        private string m_LastComment = string.Empty;

        internal static string GetSourcePosForVar(SyntaxNode node)
        {
            var st = node.GetLocation().GetLineSpan().StartLinePosition;
            var ed = node.GetLocation().GetLineSpan().EndLinePosition;
            return string.Format("{0}_{1}_{2}_{3}", st.Line, st.Character, ed.Line, ed.Character);
        }
        internal static string GetSourcePosForLog(SyntaxNode node)
        {
            var st = node.GetLocation().GetLineSpan().StartLinePosition;
            var ed = node.GetLocation().GetLineSpan().EndLinePosition;
            return string.Format("({0},{1})-({2},{3})", st.Line, st.Character, ed.Line, ed.Character);
        }
        internal static string GetIndentString(int indent)
        {
            const string c_IndentString = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t";
            return c_IndentString.Substring(0, indent);
        }
        internal static void OutputTypeArgsInfo(StringBuilder sb, INamedTypeSymbol namedTypeSym)
        {
            if (null != namedTypeSym) {
                sb.Append("typeargs(");
                string prestr = string.Empty;
                foreach (var ta in namedTypeSym.TypeArguments) {
                    sb.Append(prestr);
                    if (ta.TypeKind == TypeKind.Delegate) {
                        sb.AppendFormat("\"{0}\"", ClassInfo.GetFullName(ta));
                    }
                    else if (ta.TypeKind == TypeKind.TypeParameter) {
                        sb.Append(ta.Name);
                    }
                    else {
                        sb.Append(ClassInfo.GetFullName(ta));
                    }
                    prestr = ", ";
                }
                sb.Append("), typekinds(");
                prestr = string.Empty;
                foreach (var ta in namedTypeSym.TypeArguments) {
                    sb.Append(prestr);
                    sb.Append("TypeKind.");
                    sb.Append(ta.TypeKind);
                    prestr = ", ";
                }
                sb.Append(")");
            }
            else {
                sb.Append("typeargs(), typekinds()");
            }
        }
        internal static void OutputDefaultValue(StringBuilder sb, ITypeSymbol type, bool setValueTypeToNull)
        {
            if (null != type) {
                if (type.IsValueType) {
                    if (SymbolTable.IsBasicType(type, false)) {
                        if (type.Name == "Boolean")
                            sb.Append("false");
                        else
                            sb.Append("0");
                    }
                    else if (setValueTypeToNull) {
                        sb.Append("null");
                    }
                    else {
                        bool isExternal = !SymbolTable.Instance.IsCs2DslSymbol(type);
                        string fn = ClassInfo.GetFullName(type);
                        sb.AppendFormat("defaultvalue({0}, \"{1}\", {2})", fn, fn, isExternal ? "true" : "false");
                    }
                }
                else {
                    sb.Append("null");
                }
            }
            else {
                sb.Append("null");
            }
        }
        internal static void OutputConstValue(StringBuilder sb, object val, object operOrSym)
        {
            string v = val as string;
            if (null != v) {
                sb.AppendFormat("\"{0}\"", Escape(v));
            }
            else if (val is bool) {
                sb.Append((bool)val ? "true" : "false");
            }
            else if (val is char) {
                sb.AppendFormat("wrapchar('{0}', 0x0{1:X})", Escape((char)val), (int)(char)val);
            }
            else if (null == val) {
                sb.Append("null");
            }
            else {
                string sv = val.ToString();
                char c1 = sv.Length > 0 ? sv[0] : '\0';
                char c2 = sv.Length > 1 ? sv[1] : '\0';
                char c3 = sv.Length > 2 ? sv[2] : '\0';
                if (c1 == '-' && c2 == '.' && char.IsNumber(c3) || (c1 == '-' || c1 == '.') && char.IsNumber(c2) || char.IsNumber(c1)) {
                    if (val is float || val is double)
                        sb.AppendFormat("{0:f}", val);
                    else
                        sb.Append(val);
                }
                else {
                    var oper = operOrSym as IFieldReferenceExpression;
                    if (null != oper) {
                        var fieldSym = oper.Field;
                        sb.AppendFormat("wrapconst({0}, \"{1}\")", ClassInfo.GetFullName(fieldSym.Type), fieldSym.Name);
                    }
                    else {
                        if (val is float || val is double)
                            sb.AppendFormat("{0:f}", val);
                        else
                            sb.Append(val);
                    }
                }
            }
        }
        internal static bool IsSubclassOf(ITypeSymbol symInfo, string name)
        {
            bool ret = false;
            INamedTypeSymbol baseType = symInfo.BaseType;
            while (null != baseType) {
                string fullName = ClassInfo.GetFullName(baseType);
                if (fullName == name) {
                    ret = true;
                    break;
                }
                baseType = baseType.BaseType;
            }
            return ret;
        }
        internal static bool IsImplementationOfSys(ITypeSymbol symInfo, string name)
        {
            if (null != symInfo) {
                foreach (var intf in symInfo.AllInterfaces) {
                    if (intf.Name == name) {
                        string ns = ClassInfo.GetNamespaces(intf);
                        if (ns.StartsWith("System.") || ns == "System") {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        internal static bool IsImplementationOf(ITypeSymbol symInfo, string name)
        {
            if (null != symInfo) {
                foreach (var intf in symInfo.AllInterfaces) {
                    if (intf.Name == name) {
                        return true;
                    }
                }
            }
            return false;
        }
        internal static string EscapeType(string type, string typeKind)
        {
            if (typeKind == "TypeKind.Delegate")
                return "\"" + type + "\"";
            else
                return type;
        }

        private static string GetArraySubscriptString(int index)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= index; ++i) {
                sb.AppendFormat("[i{0}]", i);
            }
            return sb.ToString();
        }
        private static string Escape(string src)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < src.Length; ++i) {
                char c = src[i];
                string es = Escape(c);
                sb.Append(es);
            }
            return sb.ToString();
        }
        private static string Escape(char c)
        {
            switch (c) {
                case '\a':
                    return "\\a";
                case '\b':
                    return "\\b";
                case '\f':
                    return "\\f";
                case '\n':
                    return "\\n";
                case '\r':
                    return "\\r";
                case '\t':
                    return "\\t";
                case '\v':
                    return "\\v";
                case '\\':
                    return "\\\\";
                case '\"':
                    return "\\\"";
                case '\'':
                    return "\\'";
                case '\0':
                    return "\\0";
                default:
                    return c.ToString();
            }
        }

        private static HashSet<string> s_UnsupportedUnaryOperators = new HashSet<string> { "&", "*" };
        private static HashSet<string> s_UnsupportedBinaryOperators = new HashSet<string> { "->" };

        private static Dictionary<string, string> s_UnaryAlias = new Dictionary<string, string> {
        };
        private static Dictionary<string, string> s_BinaryAlias = new Dictionary<string, string> {
        };

        private static Dictionary<string, string> s_UnaryFunctor = new Dictionary<string, string> {
        };
        private static Dictionary<string, string> s_BinaryFunctor = new Dictionary<string, string> {
            {"as", "typeas"},
            {"is", "typeis"},
            {"??", "nullcoalescing"}
        };
    }
}
