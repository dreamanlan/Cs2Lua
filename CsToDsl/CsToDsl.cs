using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Operations;
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
            if (SymbolTable.Instance.IsCs2DslSymbol(sym)) {
                return SymbolTable.Instance.NameCs2DslMangling(sym);
            }
            else {
                var externMethodInfos = SymbolTable.Instance.ExternMethodInfos;
                InvocationInfo ii;
                if(!externMethodInfos.TryGetValue(sym, out ii)) {
                    ii = new InvocationInfo();
                    ii.Init(sym, m_Model);
                    externMethodInfos.TryAdd(sym, ii);
                }
                return ii.GetMethodName();
            }
        }
        internal bool CheckExplicitInterfaceAccess(ISymbol sym)
        {
            string mname = null;
            return CheckExplicitInterfaceAccess(sym, ref mname);
        }
        internal bool CheckExplicitInterfaceAccess(ISymbol sym, ref string mname)
        {
            bool ret = false;
            if (sym.ContainingType.TypeKind == TypeKind.Interface) {
                string fn = ClassInfo.GetFullName(sym.ContainingType);
                ClassSymbolInfo csi;
                if (SymbolTable.Instance.ClassSymbols.TryGetValue(fn, out csi)) {
                    switch (sym.Kind) {
                        case SymbolKind.Method:
                            IMethodSymbol msym = sym as IMethodSymbol;
                            IMethodSymbol rmsym;
                            if (csi.ExplicitInterfaceImplementationMethods.TryGetValue(msym, out rmsym)) {
                                ret = true;
                                mname = SymbolTable.GetMethodName(rmsym);
                            }
                            break;
                        case SymbolKind.Property:
                            IPropertySymbol psym = sym as IPropertySymbol;
                            IPropertySymbol rpsym;
                            if (csi.ExplicitInterfaceImplementationProperties.TryGetValue(psym, out rpsym)) {
                                ret = true;
                                mname = SymbolTable.GetPropertyName(rpsym);
                            }
                            break;
                        case SymbolKind.Event:
                            IEventSymbol esym = sym as IEventSymbol;
                            IEventSymbol resym;
                            if (csi.ExplicitInterfaceImplementationEvents.TryGetValue(esym, out resym)) {
                                ret = true;
                                mname = SymbolTable.GetEventName(esym);
                            }
                            break;
                    }
                }
            }
            return ret;
        }
        internal bool NeedWrapStruct(ExpressionSyntax exp, ITypeSymbol expType, IOperation expOper, bool dslToObject)
        {
            bool rightNeededIfWrap;
            bool needWrap = NeedWrapStruct(exp, expType, expOper, dslToObject, out rightNeededIfWrap);
            return needWrap && rightNeededIfWrap;
        }
        internal bool NeedWrapStruct(ExpressionSyntax exp, ITypeSymbol expType, IOperation expOper, bool dslToObject, out bool rightNeededIfWrap)
        {
            return NeedWrapStruct(exp, expType, expOper, null, dslToObject, out rightNeededIfWrap);
        }
        internal bool NeedWrapStruct(ExpressionSyntax exp, ITypeSymbol expType, IOperation expOper, ISymbol expSym, bool dslToObject)
        {
            bool rightNeededIfWrap;
            bool needWrap = NeedWrapStruct(exp, expType, expOper, expSym, dslToObject, out rightNeededIfWrap);
            return needWrap && rightNeededIfWrap;
        }
        internal bool NeedWrapStruct(ExpressionSyntax exp, ITypeSymbol expType, IOperation expOper, ISymbol expSym, bool dslToObject, out bool rightNeededIfWrap)
        {
            if (null != exp) {
                if (null == expType) {
                    expType = m_Model.GetTypeInfoEx(exp).Type;
                }
                if (null == expOper) {
                    expOper = m_Model.GetOperationEx(exp);
                }
                if (null == expSym) {
                    expSym = m_Model.GetSymbolInfoEx(exp).Symbol;
                }
                if (null == expType && null != expOper) {
                    expType = expOper.Type;
                }
            }
            bool needWrap = null != expType && expType.IsValueType && !dslToObject && !SymbolTable.IsBasicType(expType) && !CsDslTranslater.IsImplementationOfSys(expType, "IEnumerator");
            INamedTypeSymbol rightPropType = null;
            var propOper = expOper as IPropertyReferenceOperation;
            if (null != propOper) {
                var elementAccessNode = propOper.Syntax as ElementAccessExpressionSyntax;
                var condAccessNode = propOper.Syntax as ConditionalAccessExpressionSyntax;
                if (null != elementAccessNode) {
                    rightPropType = m_Model.GetTypeInfoEx(elementAccessNode.Expression).Type as INamedTypeSymbol;
                }
                else if (null != condAccessNode) {
                    rightPropType = m_Model.GetTypeInfoEx(condAccessNode.Expression).Type as INamedTypeSymbol;
                }
            }
            var arrElementOper = expOper as IArrayElementReferenceOperation;
            ISymbol rightArrSym = null;
            if (null != arrElementOper) {
                rightArrSym = m_Model.GetSymbolInfoEx(arrElementOper.ArrayReference.Syntax).Symbol;
            }
            rightNeededIfWrap =  null != expSym && (expSym.Kind == SymbolKind.Method || expSym.Kind == SymbolKind.Property || expSym.Kind == SymbolKind.Field || expSym.Kind == SymbolKind.Local) && SymbolTable.Instance.IsCs2DslSymbol((ISymbol)expSym) || null != rightPropType && (rightPropType.IsGenericType || SymbolTable.Instance.IsCs2DslSymbol(rightPropType)) || null != rightArrSym && SymbolTable.Instance.IsCs2DslSymbol(rightArrSym);
            return needWrap;
        }
        internal void OutputArgumentList(InvocationInfo ii, ITypeSymbol callerType, bool useTypeNameString, SyntaxNode node)
        {
            var namedCallerType = callerType as INamedTypeSymbol;
            bool isCs2DslType = null != callerType && SymbolTable.Instance.IsCs2DslSymbol(callerType) || null != namedCallerType && namedCallerType.IsGenericType || SymbolTable.Instance.IsCs2DslSymbol(ii.MethodSymbol) || null == callerType && ii.MethodSymbol.ContainingType.IsGenericType;
            var callerClassName = ClassInfo.GetFullName(callerType);
            if (string.IsNullOrEmpty(callerClassName))
                callerClassName = "null";
            var className = ClassInfo.GetFullName(ii.MethodSymbol.ContainingType);
            if (string.IsNullOrEmpty(className))
                className = "null";
            if (!ii.PostPositionGenericTypeArgs && ii.GenericTypeArgs.Count > 0) {
                OutputTypeArgumentList(ii.GenericTypeArgs, useTypeNameString, node);
            }
            if (ii.Args.Count + ii.NameOrDefaultValueArgs.Count > 0) {
                if (!ii.PostPositionGenericTypeArgs && ii.GenericTypeArgs.Count > 0)
                    CodeBuilder.Append(", ");
                int ct = ii.Args.Count;
                for (int i = 0; i < ct; ++i) {
                    var exp = ii.Args[i];
                    var argType = ii.ArgTypes[i];
                    var argOper = ii.ArgOperations[i];
                    var argSym = ii.ArgSymbols[i];
                    var arrType = argType as IArrayTypeSymbol;
                    if (null != arrType && i == ct - 1 && ii.ArrayToParams) {
                        argType = arrType.ElementType;
                    }
                    bool needWrapStruct = NeedWrapStruct(exp, argType, argOper, argSym, false);
                    string externFlag = string.Empty;
                    string argTypeName = null;
                    string argOperKind = null;
                    string argSymKind = null;
                    if (needWrapStruct) {
                        if (!SymbolTable.Instance.IsCs2DslSymbol(argType)) {
                            externFlag = "extern";
                        }
                        argTypeName = ClassInfo.GetFullName(argType);
                        if (string.IsNullOrEmpty(argTypeName))
                            argTypeName = "null";
                        argOperKind = null != argOper ? "OperationKind."+argOper.Kind.ToString() : "null";
                        argSymKind = null != argSym ? "SymbolKind." + argSym.Kind.ToString() : "null";
                        MarkNeedFuncInfo();
                    }
                    var opd = ii.ArgConversions.Count > i ? ii.ArgConversions[i] : null;
                    bool dslToObject = null != ii.DslToObjectArgs ? ii.DslToObjectArgs.Contains(i) : false;
                    //表达式对象为空表明这个是一个out实参，替换为__cs2dsl_out
                    if (null == exp) {
                        CodeBuilder.Append("__cs2dsl_out");
                    }
                    else if (i < ct - 1) {
                        if (needWrapStruct) {
                            CodeBuilder.AppendFormat("wrap{0}structargument(", externFlag);
                            OutputExpressionSyntax(exp, opd, dslToObject, ii.IsExternMethod, ii.MethodSymbol);
                            CodeBuilder.Append(", ");
                            CodeBuilder.Append(argTypeName);
                            CodeBuilder.Append(", ");
                            CodeBuilder.Append(argOperKind);
                            CodeBuilder.Append(", ");
                            CodeBuilder.Append(argSymKind);
                            CodeBuilder.Append(", ");
                            CodeBuilder.Append(className);
                            CodeBuilder.Append(", ");
                            CodeBuilder.Append(callerClassName);
                            CodeBuilder.Append(")");
                        }
                        else {
                            OutputExpressionSyntax(exp, opd, dslToObject, ii.IsExternMethod, ii.MethodSymbol);
                        }
                    }
                    else {
                        if (ii.ArrayToParams) {
                            CodeBuilder.Append("dslunpack(");
                            if (needWrapStruct) {
                                CodeBuilder.AppendFormat("wrap{0}structarguments(", externFlag);
                                OutputExpressionSyntax(exp, opd, dslToObject, ii.IsExternMethod, ii.MethodSymbol);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(argTypeName);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(argOperKind);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(argSymKind);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(className);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(callerClassName);
                                CodeBuilder.Append(")");
                            }
                            else {
                                OutputExpressionSyntax(exp, opd, dslToObject, ii.IsExternMethod, ii.MethodSymbol);
                            }
                            CodeBuilder.Append(")");
                        }
                        else {
                            if (needWrapStruct) {
                                CodeBuilder.AppendFormat("wrap{0}structargument(", externFlag);
                                OutputExpressionSyntax(exp, opd, dslToObject, ii.IsExternMethod, ii.MethodSymbol);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(argTypeName);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(argOperKind);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(argSymKind);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(className);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(callerClassName);
                                CodeBuilder.Append(")");
                            }
                            else {
                                OutputExpressionSyntax(exp, opd, dslToObject, ii.IsExternMethod, ii.MethodSymbol);
                            }
                        }
                    }
                    if (i < ct - 1) {
                        CodeBuilder.Append(", ");
                    }
                }
                if (null != ii.NameOrDefaultValueArgs) {
                    int dvCt = ii.NameOrDefaultValueArgs.Count;
                    if (ct > 0 && dvCt > 0) {
                        CodeBuilder.Append(", ");
                    }
                    for (int i = 0; i < dvCt; ++i) {
                        var info = ii.NameOrDefaultValueArgs[i];
                        var argType = info.Type;
                        var argOper = info.Operation;
                        var argSym = info.Symbol;
                        bool needWrapStruct = NeedWrapStruct(info.Expression, argType, argOper, argSym, false); string externFlag = string.Empty;
                        string argTypeName = null;
                        string argOperKind = null;
                        string argSymKind = null;
                        if (needWrapStruct) {
                            if (!SymbolTable.Instance.IsCs2DslSymbol(argType)) {
                                externFlag = "extern";
                            }
                            argTypeName = ClassInfo.GetFullName(argType);
                            if (string.IsNullOrEmpty(argTypeName))
                                argTypeName = "null";
                            argOperKind = null != argOper ? "OperationKind." + argOper.Kind.ToString() : "null";
                            argSymKind = null != argSym ? "SymbolKind." + argSym.Kind.ToString() : "null";
                            MarkNeedFuncInfo();
                        }
                        var opd = ii.ArgConversions.Count > ct + i ? ii.ArgConversions[ct + i] : null;
                        bool dslToObject = null != ii.DslToObjectDefArgs ? ii.DslToObjectDefArgs.Contains(i) : false;
                        if (null != info.Expression) {
                            if (needWrapStruct) {
                                CodeBuilder.AppendFormat("wrap{0}structargument(", externFlag);
                                OutputExpressionSyntax(info.Expression, opd, dslToObject, ii.IsExternMethod, ii.MethodSymbol);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(argTypeName);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(argOperKind);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(argSymKind);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(className);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(callerClassName);
                                CodeBuilder.Append(")");
                            }
                            else {
                                OutputExpressionSyntax(info.Expression, opd, dslToObject, ii.IsExternMethod, ii.MethodSymbol);
                            }
                        }
                        else {
                            if (needWrapStruct) {
                                CodeBuilder.AppendFormat("wrap{0}structargument(", externFlag);
                                if (dslToObject)
                                    OutputDslToObjectPrefix(ii.MethodSymbol);
                                OutputArgumentDefaultValue(info.Value, info.Operation, ii.IsExternMethod, opd, node);
                                if (dslToObject)
                                    CodeBuilder.Append(")");
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(argTypeName);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(argOperKind);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(argSymKind);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(className);
                                CodeBuilder.Append(", ");
                                CodeBuilder.Append(callerClassName);
                                CodeBuilder.Append(")");
                            }
                            else {
                                if (dslToObject)
                                    OutputDslToObjectPrefix(ii.MethodSymbol);
                                OutputArgumentDefaultValue(info.Value, info.Operation, ii.IsExternMethod, opd, node);
                                if (dslToObject)
                                    CodeBuilder.Append(")");
                            }
                        }
                        if (i < dvCt - 1) {
                            CodeBuilder.Append(", ");
                        }
                    }
                }
            }
            if (ii.PostPositionGenericTypeArgs && ii.GenericTypeArgs.Count > 0) {
                if (ii.Args.Count + ii.NameOrDefaultValueArgs.Count > 0)
                    CodeBuilder.Append(", ");
                OutputTypeArgumentList(ii.GenericTypeArgs, useTypeNameString, node);
            }
        }
        internal void OutputExpressionSyntax(ExpressionSyntax node)
        {
            OutputExpressionSyntax(node, null, false, false, null);
        }
        internal void OutputExpressionSyntax(ExpressionSyntax node, IConversionOperation opd)
        {
            OutputExpressionSyntax(node, opd, false, false, null);
        }
        internal void OutputExpressionSyntax(ExpressionSyntax node, IConversionOperation opd, bool dslToObject, bool dslStrToCsStr, ISymbol sym)
        {
            if (dslToObject) {
                OutputDslToObjectPrefix(sym);
            }
            if (null != opd && null != opd.OperatorMethod && !(node is CastExpressionSyntax)) {
                IMethodSymbol msym = opd.OperatorMethod;
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                var arglist = new List<ExpressionSyntax>() { node };
                ii.Init(msym, arglist, m_Model);
                OutputOperatorInvoke(ii, opd.Operand.Type, node);
            }
            else {
                VisitExpressionSyntax(node, dslStrToCsStr);
            }
            if (dslToObject) {
                CodeBuilder.Append(")");
            }
        }
        internal void OutputDslToObjectPrefix(ISymbol sym)
        {
            var fsym = sym as IFieldSymbol;
            var psym = sym as IPropertySymbol;
            var esym = sym as IEventSymbol;
            var msym = sym as IMethodSymbol;
            string isStatic = "false";
            if (null != sym && sym.IsStatic) {
                isStatic = "true";
            }
            if (null != fsym || null != psym || null != esym || null != msym) {
                string fullName = ClassInfo.GetFullName(sym.ContainingType);
                CodeBuilder.AppendFormat("dsltoobject(SymbolKind.{0}, {1}, \"{2}:{3}\", ", SymbolTable.Instance.GetSymbolKind(sym), isStatic, fullName, sym.Name);
            }
            else if (null != sym) {
                if (sym.Kind == SymbolKind.NamedType) {
                    string fullName = ClassInfo.GetFullName(sym);
                    CodeBuilder.AppendFormat("dsltoobject(SymbolKind.{0}, {1}, \"{2}\", ", SymbolTable.Instance.GetSymbolKind(sym), isStatic, fullName);
                }
                else {
                    CodeBuilder.AppendFormat("dsltoobject(SymbolKind.{0}, {1}, \"{2}\", ", SymbolTable.Instance.GetSymbolKind(sym), isStatic, sym.Name);
                }
            }
            else {
                CodeBuilder.AppendFormat("dsltoobject(SymbolKind.ErrorType, false, \"\", ");
            }
        }
        internal bool HasItemGetMethodDefined(INamedTypeSymbol obj)
        {
            var gis = obj.GetMembers("get_Item");
            foreach (var gi in gis) {
                var m = gi as IMethodSymbol;
                if (null != m && m.Parameters.Length == 1 && m.Parameters[0].Type.Name == "Int32" && !m.ReturnsVoid) {
                    return true;
                }
            }
            return false;
        }
        internal bool HasForeachDefined(INamedTypeSymbol obj)
        {
            var ges = obj.GetMembers("GetEnumerator");
            foreach (var ge in ges) {
                var m = ge as IMethodSymbol;
                if (null != m && m.Parameters.Length == 0 && !m.ReturnsVoid) {
                    var type = m.ReturnType;
                    var cs = GetMembers(type, "Current");
                    foreach (var c in cs) {
                        if (c.Kind == SymbolKind.Property) {
                            var mns = GetMembers(type, "MoveNext");
                            foreach (var mn in mns) {
                                var _m = mn as IMethodSymbol;
                                if (null != _m && _m.Parameters.Length == 0 && !_m.ReturnsVoid && _m.ReturnType.Name == "Boolean") {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        internal List<ISymbol> GetMembers(ITypeSymbol obj, string name)
        {
            List<ISymbol> members = new List<ISymbol>();
            var ms = obj.GetMembers(name);
            members.AddRange(ms);
            var bobj = obj.BaseType;
            while (null != bobj) {
                ms = bobj.GetMembers(name);
                members.AddRange(ms);
                bobj = bobj.BaseType;
            }
            foreach(var intf in obj.AllInterfaces) {
                ms = intf.GetMembers(name);
                members.AddRange(ms);
            }
            return members;
        }
        internal void MarkNeedFuncInfo()
        {
            var minfo = GetCurMethodInfo();
            if (null != minfo) {
                minfo.NeedFuncInfo = true;
            }
            else if (m_FieldInitializerStack.Count > 0) {
                var fieldSym = m_FieldInitializerStack.Peek();
                if (fieldSym.IsStatic) {
                    MarkStaticCtorNeedFuncInfo();
                }
                else {
                    MarkCtorNeedFuncInfo();
                }
            }
        }
        internal void MarkCtorNeedFuncInfo()
        {
            var cinfo = GetCurClassInfo();
            if (null != cinfo) {
                cinfo.CtorNeedFuncInfo = true;
            }
        }
        internal void MarkStaticCtorNeedFuncInfo()
        {
            var cinfo = GetCurClassInfo();
            if (null != cinfo) {
                cinfo.StaticCtorNeedFuncInfo = true;
            }
        }
        internal ClassInfo GetCurClassInfo()
        {
            if (m_ClassInfoStack.Count > 0)
                return m_ClassInfoStack.Peek();
            else
                return null;
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
            if (m_MethodInfoStack.Count > 0)
                return m_MethodInfoStack.Peek();
            else
                return null;
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
        private void TryWrapParams(StringBuilder codeBuilder, MethodInfo mi)
        {
            for (int i = 0; i < mi.ParamNames.Count; ++i) {
                var name = mi.ParamNames[i];
                var type = mi.ParamTypes[i];
                if (mi.OutValueParams.Contains(i)) {
                    codeBuilder.AppendFormat("{0}{1} = wrapoutstruct({2}, {3});", GetIndentString(), name, name, type);
                    codeBuilder.AppendLine();
                }
                else if (mi.OutExternValueParams.Contains(i)) {
                    codeBuilder.AppendFormat("{0}{1} = wrapoutexternstruct({2}, {3});", GetIndentString(), name, name, type);
                    codeBuilder.AppendLine();
                }
            }
            if (!string.IsNullOrEmpty(mi.OriginalParamsName)) {
                CodeBuilder.AppendFormat("{0}local({1}); {1} = params({2});", GetIndentString(), mi.OriginalParamsName, mi.ParamsElementInfo);
                CodeBuilder.AppendLine();
            }
        }
        private void OutputExpressionList(IList<ExpressionSyntax> args, SyntaxNode node)
        {
            int ct = args.Count;
            for (int i = 0; i < ct; ++i) {
                var exp = args[i];
                //表达式对象为空表明这个是一个out实参，替换为__cs2dsl_out
                if (null == exp) {
                    CodeBuilder.Append("__cs2dsl_out");
                }
                else if (i < ct - 1) {
                    OutputExpressionSyntax(exp);
                }
                else {
                    OutputExpressionSyntax(exp);
                }
                if (i < ct - 1) {
                    CodeBuilder.Append(", ");
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
            var arrOper = oper as IArrayElementReferenceOperation;
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

            bool isValueType = namedTypeSym.IsValueType;
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
                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
                }
                else if (isList) {
                    //列表对象的处理
                    CodeBuilder.AppendFormat("new{0}list({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
                }
                else {
                    //集合对象的处理
                    CodeBuilder.AppendFormat("new{0}collection({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
                }
            }
            else if (isValueType) {
                MarkNeedFuncInfo();
                CodeBuilder.AppendFormat("new{0}struct({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
            }
            else {
                CodeBuilder.AppendFormat("new{0}object({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
            }
            if (string.IsNullOrEmpty(ctor)) {
                CodeBuilder.Append(", \"ctor\"");
            }
            else {
                CodeBuilder.AppendFormat(", \"{0}\"", ctor);
            }
            CodeBuilder.AppendFormat(", 0");
            if (isCollection) {
                bool isDictionary = IsImplementationOfSys(namedTypeSym, "IDictionary");
                bool isList = IsImplementationOfSys(namedTypeSym, "IList");
                if (isDictionary) {
                    CodeBuilder.Append(", literaldictionary(");
                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
                    CodeBuilder.Append(")");
                }
                else if (isList) {
                    CodeBuilder.Append(", literallist(");
                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
                    CodeBuilder.Append(")");
                }
                else {
                    CodeBuilder.Append(", literalcollection(");
                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
                    CodeBuilder.Append(")");
                }
            }
            else {
                CodeBuilder.Append(", null");
            }
            CodeBuilder.Append(")");
        }
        private void OutputDefaultValue(ITypeSymbol type)
        {
            OutputDefaultValue(type, false);
        }
        private void OutputDefaultValue(ITypeSymbol type, bool setValueTypeToNull)
        {
            OutputDefaultValue(CodeBuilder, type, setValueTypeToNull);
        }
        private void OutputArgumentDefaultValue(object val, IOperation oper, bool dslStrToCsStr, IConversionOperation opd, SyntaxNode node)
        {
            if (null != opd && null != opd.OperatorMethod) {
                IMethodSymbol msym = opd.OperatorMethod;
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                ii.Init(msym, m_Model);
                OutputConversionInvokePrefix(ii);
            }
            if (null == val) {
                bool handled = false;
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

                            if (mi.NeedFuncInfo) {
                                MarkNeedFuncInfo();
                            }
                            handled = true;
                        }
                    }
                }
                if (!handled) {
                    var objCreate = oper as IObjectCreationOperation;
                    var arrCreate = oper as IArrayCreationOperation;
                    var fieldRef = oper as IFieldReferenceOperation;
                    var propRef = oper as IPropertyReferenceOperation;
                    if (null != objCreate) {
                        var namedTypeSym = objCreate.Type as INamedTypeSymbol;
                        var sym = objCreate.Constructor;
                        var args = objCreate.Arguments;
                        var memberInit = objCreate.Initializer;

                        bool isCollection = IsImplementationOfSys(namedTypeSym, "ICollection");
                        bool isExternal = !SymbolTable.Instance.IsCs2DslSymbol(namedTypeSym);
                        string fullTypeName = ClassInfo.GetFullName(namedTypeSym);

                        string ctor = null;
                        int retArgCt = 0;
                        if (null != sym) {
                            ctor = NameMangling(sym);
                            foreach (var p in sym.Parameters) {
                                if (p.RefKind == RefKind.Ref || p.RefKind == RefKind.Out)
                                    ++retArgCt;
                            }
                        }

                        if (isCollection) {
                            bool isDictionary = IsImplementationOfSys(namedTypeSym, "IDictionary");
                            bool isList = IsImplementationOfSys(namedTypeSym, "IList");
                            if (isDictionary) {
                                //字典对象的处理
                                CodeBuilder.AppendFormat("new{0}dictionary({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                                CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
                            }
                            else if (isList) {
                                //列表对象的处理
                                CodeBuilder.AppendFormat("new{0}list({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                                CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
                            }
                            else {
                                //集合对象的处理
                                CodeBuilder.AppendFormat("new{0}collection({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                                CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
                            }
                        }
                        else if (namedTypeSym.IsValueType) {
                            MarkNeedFuncInfo();
                            CodeBuilder.AppendFormat("new{0}struct({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                            CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
                        }
                        else {
                            CodeBuilder.AppendFormat("new{0}object({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                            CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
                        }
                        if (string.IsNullOrEmpty(ctor)) {
                            CodeBuilder.Append(", null");
                        }
                        else {
                            CodeBuilder.AppendFormat(", \"{0}\"", ctor);
                        }
                        CodeBuilder.AppendFormat(", {0}", retArgCt);
                        if (null == memberInit || memberInit.Initializers.Length <= 0) {
                            if (isCollection) {
                                bool isDictionary = IsImplementationOfSys(namedTypeSym, "IDictionary");
                                bool isList = IsImplementationOfSys(namedTypeSym, "IList");
                                if (isDictionary) {
                                    CodeBuilder.Append(", literaldictionary(");
                                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
                                    CodeBuilder.Append(")");
                                }
                                else if (isList) {
                                    CodeBuilder.Append(", literallist(");
                                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
                                    CodeBuilder.Append(")");
                                }
                                else {
                                    CodeBuilder.Append(", literalcollection(");
                                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym, this);
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
                        var arrSym = arrCreate.Type as IArrayTypeSymbol;
                        ITypeSymbol etype = SymbolTable.GetElementType(arrSym.ElementType);
                        if (etype.IsValueType && !SymbolTable.IsBasicType(etype)) {
                            MarkNeedFuncInfo();
                        }
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
                        if (isExtern && field.Type.IsValueType && !SymbolTable.IsBasicType(field.Type)) {
                            MarkNeedFuncInfo();
                            CodeBuilder.Append("getexternstaticstructmember(SymbolKind.");
                            CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(field));
                            CodeBuilder.Append(", ");
                            CodeBuilder.Append(ClassInfo.GetFullName(field.ContainingType));
                            CodeBuilder.Append(", \"");
                            CodeBuilder.Append(field.Name);
                            CodeBuilder.Append("\")");
                        }
                        else {
                            if (isExtern)
                                CodeBuilder.Append("getexternstatic(SymbolKind.");
                            else
                                CodeBuilder.Append("getstatic(SymbolKind.");
                            CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(field));
                            CodeBuilder.Append(", ");
                            CodeBuilder.Append(ClassInfo.GetFullName(field.ContainingType));
                            CodeBuilder.Append(", \"");
                            CodeBuilder.Append(field.Name);
                            CodeBuilder.Append("\")");
                        }
                    }
                    else if (null != propRef) {
                        var property = propRef.Property;
                        bool isExtern = !SymbolTable.Instance.IsCs2DslSymbol(property);
                        if (isExtern && property.Type.IsValueType && !SymbolTable.IsBasicType(property.Type)) {
                            MarkNeedFuncInfo();
                            CodeBuilder.Append("getexternstaticstructmember(SymbolKind.");
                            CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(property));
                            CodeBuilder.Append(", ");
                            CodeBuilder.Append(ClassInfo.GetFullName(property.ContainingType));
                            CodeBuilder.Append(", \"");
                            CodeBuilder.Append(property.Name);
                            CodeBuilder.Append("\")");
                        }
                        else {
                            if (isExtern)
                                CodeBuilder.Append("getexternstatic(SymbolKind.");
                            else
                                CodeBuilder.Append("getstatic(SymbolKind.");
                            CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(property));
                            CodeBuilder.Append(", ");
                            CodeBuilder.Append(ClassInfo.GetFullName(property.ContainingType));
                            CodeBuilder.Append(", \"");
                            CodeBuilder.Append(property.Name);
                            CodeBuilder.Append("\")");
                        }
                    }
                    else {
                        OutputConstValue(val, oper, dslStrToCsStr);
                    }
                }
            }
            else {
                OutputConstValue(val, oper, dslStrToCsStr);
            }
            if (null != opd && null != opd.OperatorMethod) {
                CodeBuilder.Append(")");
            }
        }
        private void OutputConstValue(object val, object operOrSym)
        {
            OutputConstValue(CodeBuilder, val, operOrSym);
        }
        private void OutputConstValue(object val, object operOrSym, bool dslStrToCsStr)
        {
            OutputConstValue(CodeBuilder, val, operOrSym, dslStrToCsStr);
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
        private void OutputOperatorInvoke(InvocationInfo ii, ITypeSymbol opdType, SyntaxNode node)
        {
            if (!ii.IsExternMethod) {
                CodeBuilder.AppendFormat("invokeoperator({0}, {1}, ", ClassInfo.GetFullName(ii.MethodSymbol.ReturnType), ii.ClassKey);
                string manglingName = ii.GetMethodName();
                CodeBuilder.AppendFormat("\"{0}\"", manglingName);
                CodeBuilder.Append(", ");
                OutputArgumentList(ii, opdType, false, node);
                CodeBuilder.Append(")");
            }
            else {
                bool externReturnStruct = !ii.MethodSymbol.ReturnsVoid && ii.MethodSymbol.ReturnType.IsValueType && !SymbolTable.IsBasicType(ii.MethodSymbol.ReturnType);
                if (externReturnStruct) {
                    MarkNeedFuncInfo();
                }
                string method = ii.GetMethodName();
                CodeBuilder.AppendFormat("{0}({1}, {2}, ", externReturnStruct ? "invokeexternoperatorreturnstruct" : "invokeexternoperator", ClassInfo.GetFullName(ii.MethodSymbol.ReturnType), ii.GenericClassKey);
                CodeBuilder.AppendFormat("\"{0}\"", method);
                CodeBuilder.Append(", ");
                OutputArgumentList(ii, opdType, false, node);
                CodeBuilder.Append(")");
            }
        }
        private void OutputConversionInvokePrefix(InvocationInfo ii)
        {
            if (!ii.IsExternMethod) {
                CodeBuilder.AppendFormat("invokeoperator({0}, {1}, ", ClassInfo.GetFullName(ii.MethodSymbol.ReturnType), ii.ClassKey);
                string manglingName = ii.GetMethodName();
                CodeBuilder.AppendFormat("\"{0}\"", manglingName);
                CodeBuilder.Append(", ");
            }
            else {
                bool externReturnStruct = !ii.MethodSymbol.ReturnsVoid && ii.MethodSymbol.ReturnType.IsValueType && !SymbolTable.IsBasicType(ii.MethodSymbol.ReturnType);
                if (externReturnStruct) {
                    MarkNeedFuncInfo();
                }
                string method = ii.GetMethodName();
                CodeBuilder.AppendFormat("{0}({1}, {2}, ", externReturnStruct ? "invokeexternoperatorreturnstruct" : "invokeexternoperator", ClassInfo.GetFullName(ii.MethodSymbol.ReturnType), ii.GenericClassKey);
                CodeBuilder.AppendFormat("\"{0}\"", method);
                CodeBuilder.Append(", ");
            }
        }
        private bool ProcessEqualOrNotEqual(string op, ExpressionSyntax left, ExpressionSyntax right, IConversionOperation lopd, IConversionOperation ropd)
        {
            bool handled = false;
            var leftOper = m_Model.GetOperationEx(left);
            var rightOper = m_Model.GetOperationEx(right);
            //外部的delegation只能是成员，因为delegation类型就是普通的function，这里不能以delegation的类型来判断是否外部类型
            if (null != leftOper && null != rightOper && null != leftOper.Type && leftOper.Type.TypeKind == TypeKind.Delegate && (!leftOper.ConstantValue.HasValue || null != leftOper.ConstantValue.Value) && rightOper.ConstantValue.HasValue && rightOper.ConstantValue.Value == null) {
                var sym = m_Model.GetSymbolInfoEx(left);
                var leftSym = sym.Symbol;
                bool isCs2Dsl = true;
                if (null != leftSym && (leftSym.Kind == SymbolKind.Field || leftSym.Kind == SymbolKind.Property || leftSym.Kind == SymbolKind.Event) && !SymbolTable.Instance.IsCs2DslSymbol(leftSym.ContainingType)) {
                    isCs2Dsl = false;
                }
                OutputDelegationCompareWithNull(leftSym, leftOper, left, isCs2Dsl, op == "==", lopd);
                handled = true;
            }
            else if (null != leftOper && null != rightOper && null != rightOper.Type && rightOper.Type.TypeKind == TypeKind.Delegate && (!rightOper.ConstantValue.HasValue || null != rightOper.ConstantValue.Value) && leftOper.ConstantValue.HasValue && leftOper.ConstantValue.Value == null) {
                var sym = m_Model.GetSymbolInfoEx(right);
                var rightSym = sym.Symbol;
                bool isCs2Dsl = true;
                if (null != rightSym && (rightSym.Kind == SymbolKind.Field || rightSym.Kind == SymbolKind.Property || rightSym.Kind == SymbolKind.Event) && !SymbolTable.Instance.IsCs2DslSymbol(rightSym.ContainingType)) {
                    isCs2Dsl = false;
                }
                OutputDelegationCompareWithNull(rightSym, rightOper, right, isCs2Dsl, op == "==", ropd);
                handled = true;
            }
            return handled;
        }
        private void OutputDelegationCompareWithNull(ISymbol leftSym, IOperation leftOper, ExpressionSyntax left, bool isCs2DslAssembly, bool isEqual, IConversionOperation opd)
        {
            if (null == leftSym && null == leftOper) {
                Log(left, "delegation compare with null, left symbol == null and left oper == null");
                return;
            }
            var leftPsym = leftSym as IPropertySymbol;
            bool isIndexer = null != leftPsym && leftPsym.IsIndexer;
            bool isWriteOnly = null != leftPsym && leftPsym.IsWriteOnly;
            bool isStatic = null != leftSym ? leftSym.IsStatic : false;
            string kind = null != leftSym ? SymbolTable.Instance.GetSymbolKind(leftSym) : null;
            string namePrefix = isCs2DslAssembly && !isWriteOnly && kind == "Property" ? "get_" : string.Empty;
            var ci = m_ClassInfoStack.Peek();
            CodeBuilder.AppendFormat("{0}delegationcomparewithnil({1}, ", isCs2DslAssembly ? string.Empty : "extern", isStatic ? "true" : "false");
            if (null != leftSym){
                string containingName = ClassInfo.GetFullName(leftSym.ContainingType);
                if (isWriteOnly) {
                    CodeBuilder.AppendFormat("null, null, SymbolKind.{0}", kind);
                }
                else if (!isIndexer && (leftSym.Kind == SymbolKind.Field || leftSym.Kind == SymbolKind.Property || leftSym.Kind == SymbolKind.Event)) {
                    var memberAccess = left as MemberAccessExpressionSyntax;
                    if (null != memberAccess) {
                        OutputExpressionSyntax(memberAccess.Expression, opd);
                        CodeBuilder.Append(", ");
                        string mname = memberAccess.Name.Identifier.Text;
                        CheckExplicitInterfaceAccess(leftSym, ref mname);
                        CodeBuilder.AppendFormat("\"{0}{1}\", SymbolKind.{2}", namePrefix, mname, kind);
                    }
                    else if (leftSym.ContainingType == ci.SemanticInfo || leftSym.ContainingType == ci.SemanticInfo.OriginalDefinition || ci.IsInherit(leftSym.ContainingType)) {
                        if (isStatic)
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
                    OutputExpressionSyntax(left, opd);
                    CodeBuilder.AppendFormat(", null, SymbolKind.{0}", kind);
                }
            }
            else {
                OutputExpressionSyntax(left, opd);
                CodeBuilder.Append(", null, null");
            }
            CodeBuilder.AppendFormat(", {0})", isEqual ? "true" : "false");
        }
        private void OutputTryCatchUsingReturn(ReturnContinueBreakAnalysis returnAnalysis, MethodInfo mi, string retValVar)
        {
            if (mi.TryUsingLayer > 0) {
                CodeBuilder.AppendFormat("{0}if({1} && {1}>=1 && {1}<=3){{", GetIndentString(), retValVar);
                CodeBuilder.AppendLine();
                ++m_Indent;
                //嵌入的try/using，返回给外层try/using。此情形只能使用函数对象，所以是return(1/2/3)
                CodeBuilder.AppendFormat("{0}return({1});", GetIndentString(), retValVar);
                CodeBuilder.AppendLine();
                --m_Indent;
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
            }
            else {
                CodeBuilder.AppendFormat("{0}if({1}){{", GetIndentString(), retValVar);
                CodeBuilder.AppendLine();
                bool existIf = false;
                if (returnAnalysis.ExistReturn) {
                    CodeBuilder.AppendFormat("{0}if({1}==1){{", GetIndentString(), retValVar);
                    CodeBuilder.AppendLine();
                    ++m_Indent;

                    string prestr;
                    CodeBuilder.AppendFormat("{0}return(", GetIndentString());
                    prestr = string.Empty;
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
            string fn;
            SymbolKind kind;
            return IsNewObjMember(name, out fn, out kind);
        }
        private bool IsNewObjMember(string name, out string fullName, out SymbolKind kind)
        {
            if (m_ObjectInitializerStack.Count > 0) {
                ITypeSymbol symInfo = m_ObjectInitializerStack.Peek();
                if (null != symInfo) {
                    var names = symInfo.GetMembers(name);
                    if (names.Length > 0) {
                        fullName = ClassInfo.GetFullName(symInfo);
                        kind = names[0].Kind;
                        return true;
                    }
                }
            }
            fullName = string.Empty;
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
        private Stack<IFieldSymbol> m_FieldInitializerStack = new Stack<IFieldSymbol>();
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
        internal static void OutputTypeArgsInfo(StringBuilder sb, INamedTypeSymbol namedTypeSym, CsDslTranslater cs2dsl)
        {
            if (null != namedTypeSym) {
                sb.Append('"');
                sb.Append("g_");
                var fullNameKey = ClassInfo.CalcFullNameKey(namedTypeSym);
                sb.Append(fullNameKey.Replace('.', '_'));
                sb.Append('"');
                sb.Append(", typeargs(");
                string prestr = string.Empty;
                foreach (var ta in namedTypeSym.TypeArguments) {
                    if (null != cs2dsl && ta.IsValueType && !SymbolTable.IsBasicType(ta)) {
                        cs2dsl.MarkNeedFuncInfo();
                    }
                    if (ta.TypeKind != TypeKind.TypeParameter) {
                        SymbolTable.Instance.TryAddExternReference(ta);
                    }
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
                sb.Append("null, typeargs(), typekinds()");
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
            OutputConstValue(sb, val, operOrSym, false);
        }
        internal static void OutputConstValue(StringBuilder sb, object val, object operOrSym, bool dslStrToCsStr)
        {
            string v = val as string;
            if (null != v) {
                if(dslStrToCsStr)
                    sb.AppendFormat("dslstrtocsstr(\"{0}\")", Escape(v));
                else
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
                    if (val is float)
                        sb.AppendFormat("{0:f8}", val);
                    else if(val is double)
                        sb.AppendFormat("{0:f16}", val);
                    else
                        sb.Append(val);
                }
                else {
                    var oper = operOrSym as IFieldReferenceOperation;
                    if (null != oper) {
                        var fieldSym = oper.Field;
                        sb.AppendFormat("wrapconst({0}, \"{1}\")", ClassInfo.GetFullName(fieldSym.Type), fieldSym.Name);
                    }
                    else {
                        var fs = operOrSym as IFieldSymbol;
                        if (null != fs) {
                            sb.AppendFormat("wrapconst({0}, \"{1}\")", ClassInfo.GetFullName(fs.Type), fs.Name);
                        }
                        else {
                            if (val is float)
                                sb.AppendFormat("{0:f8}", val);
                            else if (val is double)
                                sb.AppendFormat("{0:f16}", val);
                            else
                                sb.Append(val);
                        }
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
        internal static IMethodSymbol GetDisposeMethod(ITypeSymbol type)
        {
            while (null != type && ClassInfo.GetFullName(type) != "System.ValueType" && ClassInfo.GetFullName(type) != "System.Object") {
                var ms = type.GetMembers("Dispose");
                foreach (var m in ms) {
                    var msym = m as IMethodSymbol;
                    if (null != msym && msym.Parameters.Length == 0 && msym.ReturnsVoid) {
                        return msym;
                    }
                }
                type = type.BaseType;
            }
            return null;
        }
        internal static string EscapeType(string type, string typeKind)
        {
            if (typeKind == "TypeKind.Delegate")
                return "\"" + type + "\"";
            else
                return type;
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
