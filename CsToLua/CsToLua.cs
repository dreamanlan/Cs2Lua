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

namespace RoslynTool.CsToLua
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
    internal sealed partial class CsLuaTranslater : CSharpSyntaxVisitor
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
            get
            {
                return Logger.Instance.HaveError;
            }
        }
        internal string ErrorLog
        {
            get
            {
                return Logger.Instance.ErrorLog;
            }
        }
        internal void Translate(SyntaxNode node)
        {
            m_SkipGenericTypeDefine = true;
            Visit(node);
            if (null != m_LastToplevelClass) {
                m_LastToplevelClass.AfterOuterCodeBuilder.Append(m_ToplevelCodeBuilder.ToString());
                m_ToplevelCodeBuilder.Clear();
            }
        }
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
            return m_SymbolTable.NameMangling(sym);
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
                    switch (sym.Kind){
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
        internal void OutputArgumentList(IList<ExpressionSyntax> args, IList<ITypeSymbol> typeArgs, bool arrayToParams, bool useTypeNameString, SyntaxNode node)
        {
            if (typeArgs.Count > 0) {
                OutputTypeArgumentList(typeArgs, useTypeNameString, node);
            }
            if (args.Count > 0) {
                if (typeArgs.Count > 0)
                    CodeBuilder.Append(", ");
                OutputExpressionList(args, arrayToParams);
            }
        }

        internal CsLuaTranslater(SemanticModel model, bool enableInherit)
        {
            m_Model = model;
            m_SymbolTable = SymbolTable.Instance;
            m_EnableInherit = enableInherit;
        }

        private string GetIndentString()
        {
            return GetIndentString(m_Indent);
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
            } else {
                var refType = sym as INamedTypeSymbol;
                if (null == refType) {
                    refType = sym.ContainingType;
                }
                while (null != refType && refType.TypeKind != TypeKind.Class && refType.TypeKind != TypeKind.Struct && refType.TypeKind != TypeKind.Structure) {
                    refType = refType.ContainingType;
                }
                if (null != refType && refType.IsGenericType && refType.ContainingAssembly == m_SymbolTable.AssemblySymbol) {
                    if (m_SkipGenericTypeDefine) {
                        SymbolTable.Instance.AddGenericTypeInstance(ClassInfo.GetFullName(refType), refType);
                    } else {
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
                if (mi.ValueParams.Contains(i)) {
                    codeBuilder.AppendFormat("{0}{1} = wrapvaluetype({2});", GetIndentString(), name, name);
                    codeBuilder.AppendLine();
                } else if (mi.ExternValueParams.Contains(i)) {
                    codeBuilder.AppendFormat("{0}{1} = wrapexternvaluetype({2});", GetIndentString(), name, name);
                    codeBuilder.AppendLine();
                }
            }
        }
        private void OutputExpressionList(IList<ExpressionSyntax> args)
        {
            OutputExpressionList(args, false);
        }
        private void OutputExpressionList(IList<ExpressionSyntax> args, bool arrayToParams)
        {
            int ct = args.Count;
            for (int i = 0; i < ct; ++i) {
                var exp = args[i];
                //表达式对象为空表明这个是一个out实参，替换为__cs2lua_out
                if (null == exp) {
                    CodeBuilder.Append("__cs2lua_out");
                } else if (i < ct - 1) {
                    VisitExpressionSyntax(exp);
                } else {
                    if (arrayToParams) {
                        CodeBuilder.Append("unpack(");
                        VisitExpressionSyntax(exp);
                        CodeBuilder.Append(")");
                    } else {
                        VisitExpressionSyntax(exp);
                    }
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
                } else {
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
                            CodeBuilder.Append((int)constVal.Value + 1);
                            isConst = true;
                        }
                    }
                    if (!isConst) {
                        VisitArgument(arg);
                        CodeBuilder.Append(" + 1");
                    }
                } else if (null != indexerOper) {
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
                } else {
                    VisitArgument(arg);
                }
                if (i < ct - 1) {
                    CodeBuilder.Append(split);
                }
            }
        }
        private void OutputConstValue(object val, object operOrSym)
        {
            string v = val as string;
            if (null != v) {
                CodeBuilder.AppendFormat("wrapstring(\"{0}\")", Escape(v));
            } else if (val is bool) {
                CodeBuilder.Append((bool)val ? "true" : "false");
            } else if (val is char) {
                CodeBuilder.AppendFormat("wrapchar('{0}', 0x0{1:X})", Escape((char)val), (int)(char)val);
            } else if (null == val) {
                CodeBuilder.Append("nil");
            } else {
                string sv = val.ToString();
                char c = sv.Length>0 ? sv[0] : '\0';
                if (c == '-' || c == '.' || char.IsNumber(c)) {
                    CodeBuilder.Append(val);
                } else {
                    var oper = operOrSym as IFieldReferenceExpression;
                    if (null != oper) {
                        var fieldSym = oper.Field;
                        CodeBuilder.AppendFormat("wrapconst({0}, \"{1}\")", ClassInfo.GetFullName(fieldSym.Type), fieldSym.Name);
                    } else {
                        CodeBuilder.Append(val);
                    }
                }
            }
        }
        private void OutputType(ITypeSymbol type, SyntaxNode node, ClassInfo ci, string errorTag)
        {
            if (null != type && type.TypeKind != TypeKind.Error) {
                if (type.TypeKind == TypeKind.TypeParameter) {
                    var typeParam = type as ITypeParameterSymbol;
                    if (typeParam.TypeParameterKind == TypeParameterKind.Type && !m_SkipGenericTypeDefine && null != m_GenericTypeInstance) {
                        IMethodSymbol sym = FindClassMethodDeclaredSymbol(node);
                        if (null != sym) {
                            var t = m_SymbolTable.FindTypeArgument(type);
                            if (t.TypeKind != TypeKind.TypeParameter) {
                                CodeBuilder.Append(ClassInfo.GetFullName(t));
                                AddReferenceAndTryDeriveGenericTypeInstance(ci, t);
                            } else {
                                CodeBuilder.Append(t.Name);
                            }
                        } else {
                            ISymbol varSym = FindVariableDeclaredSymbol(node);
                            if (null != varSym) {
                                var t = m_SymbolTable.FindTypeArgument(type);
                                if (t.TypeKind != TypeKind.TypeParameter) {
                                    CodeBuilder.Append(ClassInfo.GetFullName(t));
                                    AddReferenceAndTryDeriveGenericTypeInstance(ci, t);
                                } else {
                                    CodeBuilder.Append(t.Name);
                                }
                            } else {
                                Log(node, "Can't find declaration for type param !", type.Name);
                            }
                        }
                    } else {
                        CodeBuilder.Append(type.Name);
                    }
                } else {
                    var fullName = ClassInfo.GetFullName(type);
                    CodeBuilder.Append(fullName);

                    var namedType = type as INamedTypeSymbol;
                    if (null != namedType) {
                        AddReferenceAndTryDeriveGenericTypeInstance(ci, namedType);
                    }
                }
            } else if (null != type) {
                CodeBuilder.Append("nil");
                ReportIllegalType(node, type);
            } else {
                CodeBuilder.Append("nil");
                Log(node, "Unknown {0} Type !", errorTag);
            }
        }
        private void ProcessUnaryOperator(CSharpSyntaxNode node, ref string op)
        {
            if (s_UnsupportedUnaryOperators.Contains(op)) {
                Log(node, "Cs2Lua can't support {0} unary operators !", op);
            } else {
                string nop;
                if (s_UnaryAlias.TryGetValue(op, out nop)) {
                    op = nop;
                }
            }
        }
        private void ProcessBinaryOperator(CSharpSyntaxNode node, ref string op)
        {
            if (s_UnsupportedBinaryOperators.Contains(op)) {
                Log(node, "Cs2Lua can't support {0} binary operators !", op);
            } else {
                string nop;
                if (s_BinaryAlias.TryGetValue(op, out nop)) {
                    op = nop;
                }
            }
        }
        private void ProcessAddOrStringConcat(ExpressionSyntax left, ExpressionSyntax right)
        {
            var leftOper = m_Model.GetOperation(left);
            var rightOper = m_Model.GetOperation(right);
            string leftAssemblyName = leftOper.Type.ContainingAssembly.Name;
            string rightAssemblyName = rightOper.Type.ContainingAssembly.Name;
            string leftNamespace = ClassInfo.GetNamespaces(leftOper.Type);
            string rightNamespace = ClassInfo.GetNamespaces(rightOper.Type);
            string leftTypeFullName = ClassInfo.GetFullName(leftOper.Type);
            string rightTypeFullName = ClassInfo.GetFullName(rightOper.Type);
            if (leftTypeFullName == "System.String" && rightTypeFullName == "System.String") {
                CodeBuilder.Append("System.String.Concat(");
                VisitExpressionSyntax(left);
                CodeBuilder.Append(", ");
                VisitExpressionSyntax(right);
                CodeBuilder.Append(")");
            } else if (leftTypeFullName == "System.String") {
                CodeBuilder.Append("System.String.Concat(");
                VisitExpressionSyntax(left);
                CodeBuilder.Append(", wrapstring(");
                VisitExpressionSyntax(right);
                CodeBuilder.Append("):ToString())");
            } else if (rightTypeFullName == "System.String") {
                CodeBuilder.Append("System.String.Concat(wrapstring(");
                VisitExpressionSyntax(left);
                CodeBuilder.Append("):ToString(), ");
                VisitExpressionSyntax(right);
                CodeBuilder.Append(")");
            } else {
                CodeBuilder.Append("(");
                VisitExpressionSyntax(left);
                CodeBuilder.Append(" + ");
                VisitExpressionSyntax(right);
                CodeBuilder.Append(")");
            }
        }        
        private void ProcessEqualOrNotEqual(string op, ExpressionSyntax left, ExpressionSyntax right)
        {
            var leftOper = m_Model.GetOperation(left);
            var rightOper = m_Model.GetOperation(right);
            if (null != leftOper.Type && leftOper.Type.TypeKind == TypeKind.Delegate && (!leftOper.ConstantValue.HasValue || null != leftOper.ConstantValue.Value) && rightOper.ConstantValue.HasValue && rightOper.ConstantValue.Value == null) {
                var leftAssembly = leftOper.Type.ContainingAssembly;
                var sym = m_Model.GetSymbolInfo(left);
                OutputDelegationCompareWithNull(sym.Symbol, left, leftAssembly == m_SymbolTable.AssemblySymbol, op == "==");
            } else if (null!=rightOper.Type && rightOper.Type.TypeKind == TypeKind.Delegate && (!rightOper.ConstantValue.HasValue || null != rightOper.ConstantValue.Value) && leftOper.ConstantValue.HasValue && leftOper.ConstantValue.Value == null) {
                var rightAssembly = rightOper.Type.ContainingAssembly;
                var sym = m_Model.GetSymbolInfo(right);
                OutputDelegationCompareWithNull(sym.Symbol, right, rightAssembly == m_SymbolTable.AssemblySymbol, op == "==");
            } else {
                CodeBuilder.Append("(");
                VisitExpressionSyntax(left);
                CodeBuilder.AppendFormat(" {0} ", op);
                VisitExpressionSyntax(right);
                CodeBuilder.Append(")");
            }
        }
        private void OutputDelegationCompareWithNull(ISymbol leftSym, ExpressionSyntax left, bool isCs2LuaAssembly, bool isEqual)
        {
            var ci = m_ClassInfoStack.Peek();
            CodeBuilder.AppendFormat("{0}delegationcomparewithnil(", isCs2LuaAssembly ? string.Empty : "extern");
            if (null != leftSym && (leftSym.Kind == SymbolKind.Field || leftSym.Kind == SymbolKind.Property || leftSym.Kind == SymbolKind.Event)) {
                var memberAccess = left as MemberAccessExpressionSyntax;
                if (null != memberAccess) {
                    VisitExpressionSyntax(memberAccess.Expression);
                    CodeBuilder.Append(", ");
                    string intf = "nil";
                    string mname = string.Format("\"{0}\"", memberAccess.Name.Identifier.Text);
                    CheckExplicitInterfaceAccess(leftSym, ref intf, ref mname);
                    CodeBuilder.AppendFormat("{0}, {1}", intf, mname);
                } else if (leftSym.ContainingType == ci.SemanticInfo || ci.IsInherit(leftSym.ContainingType)) {
                    CodeBuilder.Append("this, nil, ");
                    CodeBuilder.AppendFormat("\"{0}\"", leftSym.Name);
                } else {
                    VisitExpressionSyntax(left);
                    CodeBuilder.Append(", nil, nil");
                }
            } else {
                VisitExpressionSyntax(left);
                CodeBuilder.Append(", nil, nil");
            }
            CodeBuilder.AppendFormat(", {0})", isEqual ? "true" : "false");
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
            ret = ret && (parent.IsKind(SyntaxKind.MethodDeclaration) || parent.IsKind(SyntaxKind.ConstructorDeclaration));
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
            } else {
                if (nextNode.IsKind(SyntaxKind.ElseClause)) {
                    return true;
                }
                return false;
            }
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
        private void OutputOperatorInvoke(InvocationInfo ii, SyntaxNode node)
        {
            if (ii.MethodSymbol.ContainingAssembly == m_SymbolTable.AssemblySymbol) {
                CodeBuilder.AppendFormat("{0}.", ii.ClassKey);
                string manglingName = NameMangling(ii.MethodSymbol);
                CodeBuilder.Append(manglingName);
                CodeBuilder.Append("(");
                OutputArgumentList(ii.Args, ii.GenericTypeArgs, ii.ArrayToParams, false, node);
                CodeBuilder.Append(")");
            } else {
                string method = ii.MethodSymbol.Name;
                string luaOp = string.Empty;
                if (SymbolTable.ForSlua) {
                    //slua导出时把重载操作符导出成lua实例方法了，然后利用lua实例上支持的操作符元方法在运行时绑定到重载实现
                    //这里把lua支持的操作符方法转成lua操作（可能比invokeexternoperator要快一些）
                    if (method == "op_Addition") {
                        luaOp = "+";
                    } else if (method == "op_Subtraction") {
                        luaOp = "-";
                    } else if (method == "op_Multiply") {
                        luaOp = "*";
                    } else if (method == "op_Division") {
                        luaOp = "/";
                    } else if (method == "op_UnaryNegation") {
                        luaOp = "-";
                    } else if (method == "op_UnaryPlus") {
                        luaOp = "+";
                    } else if (method == "op_Equality") {
                        luaOp = "==";
                    } else if (method == "op_Inequality") {
                        luaOp = "~=";
                    } else if (method == "op_LessThan") {
                        luaOp = "<";
                    } else if (method == "op_GreaterThan") {
                        luaOp = "< ";
                    } else if (method == "op_LessThanOrEqual") {
                        luaOp = "<=";
                    } else if (method == "op_GreaterThanOrEqual") {
                        luaOp = "<= ";
                    }
                }
                if (string.IsNullOrEmpty(luaOp)) {
                    CodeBuilder.AppendFormat("invokeexternoperator({0}, ", ii.GenericClassKey);
                    CodeBuilder.AppendFormat("\"{0}\"", method);
                    CodeBuilder.Append(", ");
                    OutputArgumentList(ii.Args, ii.GenericTypeArgs, ii.ArrayToParams, false, node);
                    CodeBuilder.Append(")");
                } else {
                    if (ii.Args.Count == 1) {
                        if (luaOp == "-") {
                            CodeBuilder.Append("(");
                            CodeBuilder.Append(luaOp);
                            CodeBuilder.Append(" ");
                            VisitExpressionSyntax(ii.Args[0]);
                            CodeBuilder.Append(")");
                        }
                    } else if (ii.Args.Count == 2) {
                        CodeBuilder.Append("(");
                        VisitExpressionSyntax(ii.Args[0]);
                        CodeBuilder.Append(" ");
                        CodeBuilder.Append(luaOp);
                        CodeBuilder.Append(" ");
                        VisitExpressionSyntax(ii.Args[1]);
                        CodeBuilder.Append(")");
                    }
                }
            }
        }
        
        private StringBuilder CodeBuilder
        {
            get
            {
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
        private SymbolTable m_SymbolTable = null;
        private StringBuilder m_LogBuilder = new StringBuilder();
        private int m_Indent = 0;
        private StringBuilder m_ToplevelCodeBuilder = new StringBuilder();

        private Stack<ClassInfo> m_ClassInfoStack = new Stack<ClassInfo>();
        private Stack<MethodInfo> m_MethodInfoStack = new Stack<MethodInfo>();
        private Stack<ITypeSymbol> m_ObjectCreateStack = new Stack<ITypeSymbol>();
        private Stack<ContinueInfo> m_ContinueInfoStack = new Stack<ContinueInfo>();
        private Stack<SwitchInfo> m_SwitchInfoStack = new Stack<SwitchInfo>();
        private Queue<PostfixUnaryExpressionSyntax> m_PostfixUnaryExpressions = new Queue<PostfixUnaryExpressionSyntax>();

        private Dictionary<string, List<ClassInfo>> m_ToplevelClasses = new Dictionary<string, List<ClassInfo>>();
        private ClassInfo m_LastToplevelClass = null;
        private string m_LastComment = string.Empty;

        internal static string GetIndentString(int indent)
        {
            const string c_IndentString = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t";
            return c_IndentString.Substring(0, indent);
        }
        private static bool IsSubclassOf(ITypeSymbol symInfo, string name)
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
        private static bool IsImplementationOfSys(ITypeSymbol symInfo, string name)
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
        private static bool IsImplementationOf(ITypeSymbol symInfo, string name)
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
                default:
                    return c.ToString();
            }
        }

        private static HashSet<string> s_UnsupportedUnaryOperators = new HashSet<string> { "&", "*" };
        private static HashSet<string> s_UnsupportedBinaryOperators = new HashSet<string> { "->" };

        private static Dictionary<string, string> s_UnaryAlias = new Dictionary<string, string> { 
            {"!", "not"}
        };
        private static Dictionary<string, string> s_BinaryAlias = new Dictionary<string, string> { 
            {"!=", "~="},
            {"&&", "and"},
            {"||", "or"}
        };

        private static Dictionary<string, string> s_UnaryFunctor = new Dictionary<string, string> {
            {"~", "bitnot"},
        };
        private static Dictionary<string, string> s_BinaryFunctor = new Dictionary<string, string> {
            {"<<", "lshift"},
            {">>", "rshift"},
            {"&", "bitand"},
            {"|", "bitor"},
            {"^", "bitxor"},
            {"as", "typecast"},
            {"is", "typeis"},
            {"??", "nullcoalescing"}
        };
    }
}
