﻿using System;
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
        #region 基础遍历机制部分
        public void VisitToken(SyntaxToken token)
        {
            this.VisitLeadingTrivia(token, true);
            this.VisitTrailingTrivia(token, true);
        }
        public void VisitLeadingTrivia(SyntaxToken token, bool onlyComment)
        {
            bool hasLeadingTrivia = token.HasLeadingTrivia;
            if (hasLeadingTrivia) {
                SyntaxTriviaList.Enumerator enumerator = token.LeadingTrivia.GetEnumerator();
                while (enumerator.MoveNext()) {
                    SyntaxTrivia current = enumerator.Current;
                    this.VisitTrivia(current, onlyComment);
                }
            }
        }
        public void VisitTrailingTrivia(SyntaxToken token, bool onlyComment)
        {
            bool hasTrailingTrivia = token.HasTrailingTrivia;
            if (hasTrailingTrivia) {
                SyntaxTriviaList.Enumerator enumerator = token.TrailingTrivia.GetEnumerator();
                while (enumerator.MoveNext()) {
                    SyntaxTrivia current = enumerator.Current;
                    this.VisitTrivia(current, onlyComment);
                }
            }
        }
        public void VisitTrivia(SyntaxTrivia trivia, bool onlyComment)
        {
            bool flag = trivia.HasStructure;
            if (flag) {
                if (!onlyComment) {
                    this.Visit((CSharpSyntaxNode)trivia.GetStructure());
                }
            }
            else {
                if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia)) {
                    string content = trivia.ToString();
                    content = content.Substring(2);
                    if (content != m_LastComment) {
                        m_LastComment = content;
                        CodeBuilder.AppendFormat("{0}comment(\"{1}\");", GetIndentString(), Escape(content));
                        CodeBuilder.AppendLine();
                    }
                }
                else if (trivia.IsKind(SyntaxKind.MultiLineCommentTrivia)) {
                    string content = trivia.ToString();
                    content = content.Substring(2, content.Length - 4);
                    if (content != m_LastComment) {
                        m_LastComment = content;
                        CodeBuilder.AppendFormat("{0}comments {{", GetIndentString());
                        ++m_Indent;
                        var lines = content.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var line in lines) {
                            CodeBuilder.AppendFormat("{0}comment(\"{1}\");", GetIndentString(), Escape(line));
                            CodeBuilder.AppendLine();
                        }
                        --m_Indent;
                        CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                        CodeBuilder.AppendLine();
                    }
                }
            }
        }
        public override void DefaultVisit(SyntaxNode node)
        {
            try {
                var nodes = node.ChildNodes();
                var enumer = nodes.GetEnumerator();
                while (enumer.MoveNext()) {
                    this.Visit(enumer.Current);
                }
                var tokens = node.ChildTokens();
                var enumer2 = tokens.GetEnumerator();
                while (enumer2.MoveNext()) {
                    this.VisitToken(enumer2.Current);
                }
            }
            catch (Exception ex) {
                Log(node, "DefaultVisit throw exception:{0}\n{1}", ex.Message, ex.StackTrace);
            }
        }
        public override void Visit(SyntaxNode node)
        {
            try {
                bool flag = node != null;
                if (flag) {
                    if (node.HasLeadingTrivia && !(node is CompilationUnitSyntax)) {
                        SyntaxTriviaList.Enumerator enumerator = node.GetLeadingTrivia().GetEnumerator();
                        while (enumerator.MoveNext()) {
                            SyntaxTrivia current = enumerator.Current;
                            this.VisitTrivia(current, false);
                        }
                    }
                    try {
                        ((CSharpSyntaxNode)node).Accept(this);
                    }
                    catch (Exception ex) {
                        Log(node, "CSharpSyntaxNode.Accept throw exception:{0}\n{1}", ex.Message, ex.StackTrace);
                    }
                    m_LastComment = string.Empty;
                    if (node.HasTrailingTrivia) {
                        SyntaxTriviaList.Enumerator enumerator = node.GetTrailingTrivia().GetEnumerator();
                        while (enumerator.MoveNext()) {
                            SyntaxTrivia current = enumerator.Current;
                            this.VisitTrivia(current, false);
                        }
                    }
                }
            }
            catch (Exception ex) {
                Log(node, "Visit throw exception:{0}\n{1}", ex.Message, ex.StackTrace);
            }
        }
        #endregion

        #region 符号、变量、参数等相关的处理
        public override void VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
        {
            base.VisitLocalDeclarationStatement(node);
        }
        public override void VisitVariableDeclaration(VariableDeclarationSyntax node)
        {
            foreach (var v in node.Variables) {
                VisitVariableDeclarator(v);
            }
        }
        public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            var localSym = m_Model.GetDeclaredSymbol(node) as ILocalSymbol;

            if (null != localSym && localSym.HasConstantValue) {
                if (null != node.Initializer) {
                    CodeBuilder.AppendFormat("{0}local({1}); {2}", GetIndentString(), node.Identifier.Text, node.Identifier.Text);
                }
                else {
                    CodeBuilder.AppendFormat("{0}local({1})", GetIndentString(), node.Identifier.Text);
                }
                CodeBuilder.Append(" = ");
                OutputConstValue(localSym.ConstantValue, localSym);
                CodeBuilder.AppendLine(";");
                return;
            }
            bool dslToObject = false;
            ITypeSymbol type = null;
            if (null != node.Initializer) {
                type = m_Model.GetTypeInfoEx(node.Initializer.Value).Type;
                if (null != localSym && null != localSym.Type && null != type) {
                    dslToObject = InvocationInfo.IsDslToObject(localSym.Type, type);
                }
            }
            VisitLocalVariableDeclarator(ci, node, dslToObject);
            if (null != node.Initializer) {
                var valSyntax = node.Initializer.Value;
                var rightType = m_Model.GetTypeInfoEx(valSyntax).Type;
                var rightOper = m_Model.GetOperationEx(valSyntax);
                if (null == rightType && null != rightOper) {
                    rightType = rightOper.Type;
                };
                bool needWrapStruct = NeedWrapStruct(valSyntax, rightType, rightOper, dslToObject);
                if (needWrapStruct) {
                    MarkNeedFuncInfo();
                    if (SymbolTable.Instance.IsCs2DslSymbol(type)) {
                        CodeBuilder.AppendFormat("{0}{1} = wrapstruct({2}, {3});", GetIndentString(), node.Identifier.Text, node.Identifier.Text, ClassInfo.GetFullName(type));
                        CodeBuilder.AppendLine();
                    }
                    else {
                        string ns = ClassInfo.GetNamespaces(type);
                        if (ns != "System") {
                            CodeBuilder.AppendFormat("{0}{1} = wrapexternstruct({2}, {3});", GetIndentString(), node.Identifier.Text, node.Identifier.Text, ClassInfo.GetFullName(type));
                            CodeBuilder.AppendLine();
                        }
                    }
                }
            }
        }
        public override void VisitArgument(ArgumentSyntax node)
        {
            var oper = m_Model.GetOperationEx(node) as IArgumentOperation;
            IConversionOperation opd = null;
            if (null != oper) {
                opd = oper.Value as IConversionOperation;
            }
            OutputExpressionSyntax(node.Expression, opd);
        }
        public override void VisitPredefinedType(PredefinedTypeSyntax node)
        {
            TypeInfo typeInfo = m_Model.GetTypeInfoEx(node);
            var type = typeInfo.Type;

            if (null != type) {
                string fullName = ClassInfo.GetFullName(type);
                CodeBuilder.Append(fullName);
            }
            else {
                CodeBuilder.Append(node.Keyword.Text);
            }
        }
        public override void VisitIdentifierName(IdentifierNameSyntax node)
        {
            string name = node.Identifier.Text;
            if (m_ClassInfoStack.Count > 0) {
                ClassInfo classInfo = m_ClassInfoStack.Peek();
                SymbolInfo symbolInfo = m_Model.GetSymbolInfoEx(node);
                var sym = symbolInfo.Symbol;
                if (null != sym) {
                    bool isExtern = !SymbolTable.Instance.IsCs2DslSymbol(sym);
                    if (sym.Kind == SymbolKind.NamedType || sym.Kind == SymbolKind.Namespace) {
                        string fullName = ClassInfo.GetFullName(sym);
                        CodeBuilder.Append(fullName);

                        if (sym.Kind == SymbolKind.NamedType) {
                            var namedType = sym as INamedTypeSymbol;
                            AddReferenceAndTryDeriveGenericTypeInstance(classInfo, namedType);
                        }
                        return;
                    }
                    else if (sym.Kind == SymbolKind.Field || sym.Kind == SymbolKind.Property || sym.Kind == SymbolKind.Event) {
                        var fsym = sym as IFieldSymbol;
                        var psym = sym as IPropertySymbol;
                        string fullName = ClassInfo.GetFullName(sym.ContainingType);
                        if (sym.IsStatic) {
                            if (isExtern && null != fsym && fsym.Type.IsValueType && !SymbolTable.IsBasicType(fsym.Type)) {
                                MarkNeedFuncInfo();
                                CodeBuilder.AppendFormat("getexternstaticstructmember(SymbolKind.{0}, {1}, \"{2}\")", SymbolTable.Instance.GetSymbolKind(sym), fullName, sym.Name);
                            }
                            else if (isExtern && null != psym && psym.Type.IsValueType && !SymbolTable.IsBasicType(psym.Type)) {
                                MarkNeedFuncInfo();
                                CodeBuilder.AppendFormat("getexternstaticstructmember(SymbolKind.{0}, {1}, \"{2}\")", SymbolTable.Instance.GetSymbolKind(sym), fullName, sym.Name);
                            }
                            else {
                                string luaLibFunc;
                                if (null != fsym && SymbolTable.Instance.IsInvokeToLuaLibField(fsym, out luaLibFunc)) {
                                    OutputInvokeToLuaLib(true, luaLibFunc, fsym.Type, "SymbolKind.");
                                    CodeBuilder.AppendFormat("{0}, {1}, \"{2}\")", SymbolTable.Instance.GetSymbolKind(sym), fullName, sym.Name);
                                }
                                else if (null != psym && SymbolTable.Instance.IsInvokeToLuaLibProperty(psym, out luaLibFunc)) {
                                    OutputInvokeToLuaLib(true, luaLibFunc, psym.Type, "SymbolKind.");
                                    CodeBuilder.AppendFormat("{0}, {1}, \"{2}\")", SymbolTable.Instance.GetSymbolKind(sym), fullName, sym.Name);
                                }
                                else {
                                    CodeBuilder.AppendFormat("{0}(SymbolKind.{1}, {2}, \"{3}\")", isExtern ? "getexternstatic" : "getstatic", SymbolTable.Instance.GetSymbolKind(sym), fullName, sym.Name);
                                }
                            }
                            return;
                        }
                        else if (IsNewObjMember(name)) {
                            if (isExtern && null != fsym && fsym.Type.IsValueType && !SymbolTable.IsBasicType(fsym.Type)) {
                                MarkNeedFuncInfo();
                                CodeBuilder.AppendFormat("getexterninstancestructmember(SymbolKind.{0}, newobj, {1}, \"{2}\")", SymbolTable.Instance.GetSymbolKind(sym), fullName, name);
                            }
                            else if (isExtern && null != psym && psym.Type.IsValueType && !SymbolTable.IsBasicType(psym.Type)) {
                                MarkNeedFuncInfo();
                                CodeBuilder.AppendFormat("getexterninstancestructmember(SymbolKind.{0}, newobj, {1}, \"{2}\")", SymbolTable.Instance.GetSymbolKind(sym), fullName, name);
                            }
                            else {
                                string luaLibFunc;
                                if (null != fsym && SymbolTable.Instance.IsInvokeToLuaLibField(fsym, out luaLibFunc)) {
                                    OutputInvokeToLuaLib(true, luaLibFunc, fsym.Type, "SymbolKind.");
                                    CodeBuilder.AppendFormat("{0}, {1}, newobj, \"{2}\")", SymbolTable.Instance.GetSymbolKind(sym), fullName, sym.Name);
                                }
                                else if (null != psym && SymbolTable.Instance.IsInvokeToLuaLibProperty(psym, out luaLibFunc)) {
                                    OutputInvokeToLuaLib(true, luaLibFunc, psym.Type, "SymbolKind.");
                                    CodeBuilder.AppendFormat("{0}, {1}, newobj, \"{2}\")", SymbolTable.Instance.GetSymbolKind(sym), fullName, sym.Name);
                                }
                                else {
                                    CodeBuilder.AppendFormat("{0}(SymbolKind.{1}, newobj, {2}, \"{3}\")", isExtern ? "getexterninstance" : "getinstance", SymbolTable.Instance.GetSymbolKind(sym), fullName, name);
                                }
                            }
                            return;
                        }
                        else if (sym.ContainingType == classInfo.SemanticInfo || sym.ContainingType == classInfo.SemanticInfo.OriginalDefinition || classInfo.IsInherit(sym.ContainingType)) {
                            if (isExtern && null != fsym && fsym.Type.IsValueType && !SymbolTable.IsBasicType(fsym.Type)) {
                                MarkNeedFuncInfo();
                                CodeBuilder.AppendFormat("getexterninstancestructmember(SymbolKind.{0}, this, {1}, \"{2}\")", SymbolTable.Instance.GetSymbolKind(sym), fullName, sym.Name);
                            }
                            else if (isExtern && null != psym && psym.Type.IsValueType && !SymbolTable.IsBasicType(psym.Type)) {
                                MarkNeedFuncInfo();
                                CodeBuilder.AppendFormat("getexterninstancestructmember(SymbolKind.{0}, this, {1}, \"{2}\")", SymbolTable.Instance.GetSymbolKind(sym), fullName, sym.Name);
                            }
                            else {
                                string luaLibFunc;
                                if (null != fsym && SymbolTable.Instance.IsInvokeToLuaLibField(fsym, out luaLibFunc)) {
                                    OutputInvokeToLuaLib(true, luaLibFunc, fsym.Type, "SymbolKind.");
                                    CodeBuilder.AppendFormat("{0}, this, {1}, \"{2}\")", SymbolTable.Instance.GetSymbolKind(sym), fullName, sym.Name);
                                }
                                else if (null != psym && SymbolTable.Instance.IsInvokeToLuaLibProperty(psym, out luaLibFunc)) {
                                    OutputInvokeToLuaLib(true, luaLibFunc, psym.Type, "SymbolKind.");
                                    CodeBuilder.AppendFormat("{0}, this, {1}, \"{2}\")", SymbolTable.Instance.GetSymbolKind(sym), fullName, sym.Name);
                                }
                                else {
                                    CodeBuilder.AppendFormat("{0}(SymbolKind.{1}, this, {2}, \"{3}\")", isExtern ? "getexterninstance" : "getinstance", SymbolTable.Instance.GetSymbolKind(sym), fullName, sym.Name);
                                }
                            }
                            return;
                        }
                    }
                    else if (sym.Kind == SymbolKind.Method) {
                        var msym = sym as IMethodSymbol;
                        string manglingName = NameMangling(msym);
                        var mi = new MethodInfo();
                        mi.Init(msym, node);
                        string fullName = ClassInfo.GetFullName(sym.ContainingType);
                        if (sym.IsStatic && node.Parent is InvocationExpressionSyntax) {
                            CodeBuilder.AppendFormat("{0}(SymbolKind.{1}, {2}, \"{3}\")", isExtern ? "getexternstatic" : "getstatic", SymbolTable.Instance.GetSymbolKind(sym), fullName, manglingName);
                            return;
                        }
                        else if (sym.ContainingType == classInfo.SemanticInfo || sym.ContainingType == classInfo.SemanticInfo.OriginalDefinition || classInfo.IsInherit(sym.ContainingType)) {
                            if (node.Parent is InvocationExpressionSyntax) {
                                CodeBuilder.AppendFormat("{0}(SymbolKind.{1}, this, {2}, \"{3}\")", isExtern ? "getexterninstance" : "getinstance", SymbolTable.Instance.GetSymbolKind(sym), fullName, manglingName);
                            }
                            else {
                                string srcPos = GetSourcePosForVar(node);
                                string delegationKey = string.Format("{0}:{1}", fullName, manglingName);
                                if (msym.IsStatic) {
                                    CodeBuilder.AppendFormat("builddelegation(\"{0}\", \"{1}\", {2}, {3}, {4})", srcPos, delegationKey, fullName, manglingName, "true");
                                }
                                else {
                                    CodeBuilder.AppendFormat("builddelegation(\"{0}\", \"{1}\", this, {2}, {3})", srcPos, delegationKey, manglingName, "false");
                                }
                            }
                            return;
                        }
                    }
                }
                else {
                    string fn;
                    SymbolKind kind;
                    if (IsNewObjMember(name, out fn, out kind)) {
                        CodeBuilder.AppendFormat("getinstance(SymbolKind.{0}, newobj, {1}, \"{2}\")", kind.ToString(), fn, name);
                        return;
                    }
                    ReportIllegalSymbol(node, symbolInfo);
                }
            }
            CodeBuilder.Append(name);
        }
        public override void VisitQualifiedName(QualifiedNameSyntax node)
        {
            SymbolInfo symInfo = m_Model.GetSymbolInfoEx(node);
            var sym = symInfo.Symbol;
            if (null != sym) {
                string fullName = ClassInfo.GetFullName(sym);
                CodeBuilder.Append(fullName);
            }
            else {
                ReportIllegalSymbol(node, symInfo);
                CodeBuilder.Append(node.GetText());
            }
        }
        #endregion
    }
}