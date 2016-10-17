using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using RoslynTool.CsToLua;

namespace RoslynTool.CsToLua
{
    internal sealed partial class CsLuaTranslater : CSharpSyntaxVisitor
    {
        public Dictionary<string, ClassInfo> ToplevelClasses
        {
            get { return m_ToplevelClasses; }
        }
        public bool HaveError
        {
            get
            {
                return m_LogBuilder.Length > 0;
            }
        }
        public string ErrorLog
        {
            get
            {
                return m_LogBuilder.ToString();
            }
        }
        public void Translate(SyntaxNode node)
        {
            Visit(node);
            if (null != m_LastToplevelClass) {
                m_LastToplevelClass.AfterOuterCodeBuilder.Append(m_ToplevelSourceCodeBuilder.ToString());
                m_ToplevelSourceCodeBuilder.Clear();
            }
        }
        public CsLuaTranslater(SemanticModel model, SymbolTable symbolTable)
        {
            m_Model = model;
            m_SymbolTable = symbolTable;
        }
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
            } else {
                if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia)) {
                    string content = trivia.ToString();
                    content = content.Substring(2);
                    SourceCodeBuilder.AppendFormat("--{0}", content);
                    SourceCodeBuilder.AppendLine();
                } else if (trivia.IsKind(SyntaxKind.MultiLineCommentTrivia)) {
                    string content = trivia.ToString();
                    content = content.Substring(2, content.Length - 4);
                    var lines = content.Split(new char[]{'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in lines) {
                        SourceCodeBuilder.AppendFormat("--{0}", line);
                        SourceCodeBuilder.AppendLine();
                    }
                }
            }
        }
        public override void DefaultVisit(SyntaxNode node)
        {
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
        public override void Visit(SyntaxNode node)
        {
            bool flag = node != null;
            if (flag) {
                if (node.HasLeadingTrivia && !(node is CompilationUnitSyntax)) {
                    SyntaxTriviaList.Enumerator enumerator = node.GetLeadingTrivia().GetEnumerator();
                    while (enumerator.MoveNext()) {
                        SyntaxTrivia current = enumerator.Current;
                        this.VisitTrivia(current, false);
                    }
                }
                ((CSharpSyntaxNode)node).Accept(this);
                if (node.HasTrailingTrivia) {
                    SyntaxTriviaList.Enumerator enumerator = node.GetTrailingTrivia().GetEnumerator();
                    while (enumerator.MoveNext()) {
                        SyntaxTrivia current = enumerator.Current;
                        this.VisitTrivia(current, false);
                    }
                }
            }
        }
        public override void VisitCompilationUnit(CompilationUnitSyntax node)
        {
            base.VisitCompilationUnit(node);
        }
        public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            ++m_Indent;
            var members = node.Members;
            foreach (var member in members) {
                member.Accept(this);
            }
            --m_Indent;

            if (m_Indent <= 0 && null != m_LastToplevelClass) {
                m_LastToplevelClass.AfterOuterCodeBuilder.Append(m_ToplevelSourceCodeBuilder.ToString());
                m_ToplevelSourceCodeBuilder.Clear();
            }
        }
        public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            //允许在C#里定义与使用接口，lua里隐式支持任何接口
        }
        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            INamedTypeSymbol sym = m_Model.GetDeclaredSymbol(node);
            ClassInfo ci = new ClassInfo();
            ci.Init(sym);
            m_ClassInfoStack.Push(ci);
            
            if (m_ClassInfoStack.Count == 1) {
                ci.BeforeOuterCodeBuilder.Append(m_ToplevelSourceCodeBuilder.ToString());
                m_ToplevelSourceCodeBuilder.Clear();
            }

            ci.CurrentSourceCodeBuilder = ci.StaticFieldSourceCodeBuilder;

            ++m_Indent;
            foreach (var member in node.Members) {
                VisitEnumMemberDeclaration(member);
            }
            --m_Indent;

            m_ClassInfoStack.Pop();

            if (m_ClassInfoStack.Count <= 0) {
                AddToplevelClass(ci.Key, ci);
            }
        }
        public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            IFieldSymbol sym = m_Model.GetDeclaredSymbol(node);
            SourceCodeBuilder.AppendFormat("{0}{1}", GetIndentString(), node.Identifier.Text);
            if (null != node.EqualsValue) {
                VisitEqualsValueClause(node.EqualsValue);
            } else if (sym.HasConstantValue) {
                SourceCodeBuilder.AppendFormat(" = {0}", sym.ConstantValue);
            } else {
                Log(node, "enum member can't deduce a value ! syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
                SourceCodeBuilder.Append(" = nil");
            }
            SourceCodeBuilder.AppendLine(",");
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
            IMethodSymbol sym = m_Model.GetDeclaredSymbol(node);
            var mi = new MethodInfo();
            mi.Init(sym);
            m_MethodInfoStack.Push(mi);

            SourceCodeBuilder.AppendFormat("{0}ctor = function(self", GetIndentString());
            if (mi.ParamNames.Count > 0) {
                SourceCodeBuilder.Append(", ");
                SourceCodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
            }
            SourceCodeBuilder.Append(")");
            SourceCodeBuilder.AppendLine();
            ++m_Indent;
            foreach (string name in mi.OutParamNames) {
                SourceCodeBuilder.AppendFormat("{0}local {1} = nil;", GetIndentString(), name);
                SourceCodeBuilder.AppendLine();
            }
            VisitBlock(node.Body);
            if (!mi.ExistReturn && mi.ReturnParamNames.Count > 0) {
                SourceCodeBuilder.AppendFormat("{0}return {1};", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                SourceCodeBuilder.AppendLine();
            }
            --m_Indent;
            SourceCodeBuilder.AppendFormat("{0}end,", GetIndentString());
            SourceCodeBuilder.AppendLine();
            m_MethodInfoStack.Pop();
        }
        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            IMethodSymbol sym = m_Model.GetDeclaredSymbol(node);
            var mi = new MethodInfo();
            mi.Init(sym);
            m_MethodInfoStack.Push(mi);

            bool isStatic = sym.IsStatic;
            SourceCodeBuilder.AppendFormat("{0}{1} = function({2}", GetIndentString(), NameMangling(sym), isStatic ? string.Empty : "self");
            if (mi.ParamNames.Count > 0) {
                if (!isStatic) {
                    SourceCodeBuilder.Append(", ");
                }
                SourceCodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
            }
            SourceCodeBuilder.Append(")");
            SourceCodeBuilder.AppendLine();
            ++m_Indent;
            foreach (string name in mi.OutParamNames) {
                SourceCodeBuilder.AppendFormat("{0}local {1} = nil;", GetIndentString(), name);
                SourceCodeBuilder.AppendLine();
            }
            VisitBlock(node.Body);
            if (!mi.ExistReturn && mi.ReturnParamNames.Count > 0) {
                SourceCodeBuilder.AppendFormat("{0}return {1};", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                SourceCodeBuilder.AppendLine();
            }
            --m_Indent;
            SourceCodeBuilder.AppendFormat("{0}end", GetIndentString());
            if (m_Indent > 0) {
                SourceCodeBuilder.Append(",");
            }
            SourceCodeBuilder.AppendLine();
            m_MethodInfoStack.Pop();
        }
        public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
        {
            SymbolInfo symInfo = m_Model.GetSymbolInfo(node);
            var sym = symInfo.Symbol as IMethodSymbol;

            if (null != sym && sym.Parameters.Length == 1) {
                var param = sym.Parameters[0];
                SourceCodeBuilder.AppendFormat("(function({0}) return ", param.Name);
                node.Body.Accept(this);
                SourceCodeBuilder.Append("; end)");
            } else {
                ReportIllegalSymbol(node, symInfo);
            }
        }
        public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
        {
            SymbolInfo symInfo = m_Model.GetSymbolInfo(node);
            var sym = symInfo.Symbol as IMethodSymbol;
            if (null != sym) {
                var mi = new MethodInfo();
                mi.Init(sym);
                m_MethodInfoStack.Push(mi);

                SourceCodeBuilder.Append("(function(");
                int ct = sym.Parameters.Length;
                if (ct > 0) {
                    for (int i = 0; i < ct; ++i) {
                        var param = sym.Parameters[i];
                        SourceCodeBuilder.Append(param.Name);
                        if (i < ct - 1) {
                            SourceCodeBuilder.Append(", ");
                        }
                    }
                }
                SourceCodeBuilder.AppendLine(")");
                ++m_Indent;
                node.Body.Accept(this);
                --m_Indent;
                SourceCodeBuilder.AppendFormat("{0}end)", GetIndentString());

                m_MethodInfoStack.Pop();
            } else {
                ReportIllegalSymbol(node, symInfo);
            }
        }
        public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
        {
            SymbolInfo symInfo = m_Model.GetSymbolInfo(node);
            var sym = symInfo.Symbol as IMethodSymbol;
            if (null != sym) {
                var mi = new MethodInfo();
                mi.Init(sym);
                m_MethodInfoStack.Push(mi);

                SourceCodeBuilder.Append("(function(");
                int ct = sym.Parameters.Length;
                if (ct > 0) {
                    for (int i = 0; i < ct; ++i) {
                        var param = sym.Parameters[i];
                        SourceCodeBuilder.Append(param.Name);
                        if (i < ct - 1) {
                            SourceCodeBuilder.Append(", ");
                        }
                    }
                }
                SourceCodeBuilder.AppendLine(")");
                ++m_Indent;
                node.Body.Accept(this);
                --m_Indent;
                SourceCodeBuilder.AppendFormat("{0}end)", GetIndentString());

                m_MethodInfoStack.Pop();
            } else {
                ReportIllegalSymbol(node, symInfo);
            }
        }
        #region 暂时不支持的语法特性
        public override void VisitEventDeclaration(EventDeclarationSyntax node)
        {
            IEventSymbol sym = m_Model.GetDeclaredSymbol(node);
            Log(node, "Unsupported event declaration !!! code: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            IPropertySymbol sym = m_Model.GetDeclaredSymbol(node);
            Log(node, "Unsupported property declaration !!! code: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
        {
            Log(node, "Unsupported typeof expression !!! code: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitCastExpression(CastExpressionSyntax node)
        {
            SourceCodeBuilder.Append("typecast(");
            VisitExpressionSyntax(node.Expression);
            TypeInfo typeInfo = m_Model.GetTypeInfo(node.Type);
            SourceCodeBuilder.AppendFormat(", \"{0}\")", typeInfo.Type.Name);
        }
        #endregion
        public override void VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
        {
            foreach (var v in node.Declaration.Variables) {
                SourceCodeBuilder.AppendFormat("{0}{1}", GetIndentString(), v.Identifier.Text);
                if (null != v.Initializer) {
                    SourceCodeBuilder.Append(" = ");
                    VisitExpressionSyntax(v.Initializer.Value);
                } else {
                    SourceCodeBuilder.Append(" = nil");
                }
                SourceCodeBuilder.Append(",");
                SourceCodeBuilder.AppendLine();
            }
        }
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

            SourceCodeBuilder.AppendFormat("{0}local {1}", GetIndentString(), node.Identifier.Text);
            if (null != localSym && localSym.HasConstantValue) {
                SourceCodeBuilder.Append(" = ");
                SourceCodeBuilder.Append(localSym.ConstantValue);
                SourceCodeBuilder.AppendLine(";");
                return;
            }
            if (null != node.Initializer) {
                var token = node.Initializer.EqualsToken;
                var invocation = node.Initializer.Value as InvocationExpressionSyntax;
                if (null != invocation) {
                    MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                    if (null != memberAccess) {
                        SymbolInfo symInfo = m_Model.GetSymbolInfo(invocation);
                        IMethodSymbol sym = symInfo.Symbol as IMethodSymbol;
                        if (null == sym) {
                            ReportIllegalSymbol(invocation, symInfo);
                        } else {
                            //处理ref/out参数
                            InvocationInfo ii = new InvocationInfo();
                            ii.Init(sym, invocation.ArgumentList);
                            ci.AddReference(ii.ClassKey);

                            int ct = ii.ReturnArgs.Count;
                            if (ct > 0) {
                                SourceCodeBuilder.Append(", ");
                            }
                            OutputExpressionList(ii.ReturnArgs);
                            SourceCodeBuilder.AppendFormat(" {0} ", token.Text);
                            if (token.Text != "=" && ct > 0) {
                                Log(node, "Only = can used in invocation including ref or out ! syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
                            }
                            VisitExpressionSyntax(memberAccess.Expression);
                            if (sym.IsStatic) {
                                SourceCodeBuilder.Append(".");
                            } else {
                                SourceCodeBuilder.Append(":");
                            }
                            SourceCodeBuilder.Append(NameMangling(sym));
                            SourceCodeBuilder.Append("(");
                            OutputExpressionList(ii.Args);
                            SourceCodeBuilder.AppendLine(");");

                            return;
                        }
                    }
                }
                VisitEqualsValueClause(node.Initializer);
            }
            SourceCodeBuilder.AppendLine(";");
        }
        public override void VisitArgumentList(ArgumentListSyntax node)
        {
            OutputArgumentList(node.Arguments, ", ");
        }
        public override void VisitBracketedArgumentList(BracketedArgumentListSyntax node)
        {
            OutputArgumentList(node.Arguments, "][");
        }
        public override void VisitArgument(ArgumentSyntax node)
        {
            VisitExpressionSyntax(node.Expression);
        }
        public override void VisitBlock(BlockSyntax node)
        {
            bool isBlock = node.Parent is BlockSyntax;
            if (isBlock) {
                SourceCodeBuilder.AppendFormat("{0}do", GetIndentString());
                SourceCodeBuilder.AppendLine();
                ++m_Indent;
            }
            base.VisitBlock(node);
            if (isBlock) {
                --m_Indent;
                SourceCodeBuilder.AppendFormat("{0}end;", GetIndentString());
                SourceCodeBuilder.AppendLine();
            }
        }
        public override void VisitIdentifierName(IdentifierNameSyntax node)
        {
            string name = node.Identifier.Text;
            if (m_ClassInfoStack.Count > 0) {
                ClassInfo classInfo = m_ClassInfoStack.Peek();
                SymbolInfo symbolInfo = m_Model.GetSymbolInfo(node);
                var sym = symbolInfo.Symbol;
                if (null != sym) {
                    if (sym.Kind == SymbolKind.Parameter) {
                        var paramSym = sym as IParameterSymbol;
                        if (null != paramSym && paramSym.IsParams) {
                            SourceCodeBuilder.Append("...");
                            return;
                        }
                    } else if (sym.Kind != SymbolKind.Parameter && sym.Kind != SymbolKind.Local && sym.ContainingType == classInfo.SemanticInfo) {
                        var msym = sym as IMethodSymbol;
                        if (null != msym) {
                            SourceCodeBuilder.AppendFormat("self.{0}", NameMangling(msym));
                        } else {
                            SourceCodeBuilder.AppendFormat("self.{0}", name);
                        }
                        return;
                    } else if (sym.Kind == SymbolKind.Field || sym.Kind == SymbolKind.Property) {
                        if (m_ObjectCreateStack.Count > 0) {
                            ITypeSymbol symInfo = m_ObjectCreateStack.Peek();
                            if (null != symInfo) {
                                var names = symInfo.GetMembers(name);
                                if (names.Length > 0) {
                                    SourceCodeBuilder.AppendFormat("self.{0}", name);
                                    return;
                                }
                            }
                        }
                    } else if (sym.Kind == SymbolKind.NamedType || sym.Kind == SymbolKind.Namespace) {
                        if (null != sym.ContainingType) {
                            string ns = ClassInfo.GetNamespaces(sym.ContainingType);
                            string fullName;
                            if (ns.Length > 0) {
                                fullName = ns + "." + sym.Name;
                            } else {
                                fullName = sym.Name;
                            }
                            SourceCodeBuilder.Append(fullName);
                        } else if (null != sym.ContainingNamespace) {
                            string ns = ClassInfo.GetNamespaces(sym.ContainingNamespace);
                            string fullName;
                            if (ns.Length > 0) {
                                fullName = ns + "." + sym.Name;
                            } else {
                                fullName = sym.Name;
                            }
                            SourceCodeBuilder.Append(fullName);
                        } else {
                            SourceCodeBuilder.Append(sym.Name);
                        }
                        return;
                    }
                } else {
                    if (m_ObjectCreateStack.Count > 0) {
                        ITypeSymbol symInfo = m_ObjectCreateStack.Peek();
                        if (null != symInfo) {
                            var names = symInfo.GetMembers(name);
                            if (names.Length > 0) {
                                SourceCodeBuilder.AppendFormat("self.{0}", name);
                                return;
                            }
                        }
                    } else {
                        ReportIllegalSymbol(node, symbolInfo);
                    }
                }
            }
            SourceCodeBuilder.Append(name);
        }
        public override void VisitQualifiedName(QualifiedNameSyntax node)
        {
            SymbolInfo symInfo = m_Model.GetSymbolInfo(node);
            var sym = symInfo.Symbol;
            if (null != sym) {
                if (null != sym.ContainingType) {
                    string ns = ClassInfo.GetNamespaces(sym.ContainingType);
                    string fullName;
                    if (ns.Length > 0) {
                        fullName = ns + "." + sym.Name;
                    } else {
                        fullName = sym.Name;
                    }
                    SourceCodeBuilder.Append(fullName);
                } else if (null != sym.ContainingNamespace) {
                    string ns = ClassInfo.GetNamespaces(sym.ContainingNamespace);
                    string fullName;
                    if (ns.Length > 0) {
                        fullName = ns + "." + sym.Name;
                    } else {
                        fullName = sym.Name;
                    }
                    SourceCodeBuilder.Append(fullName);
                } else {
                    SourceCodeBuilder.Append(sym.Name);
                }
            } else {
                ReportIllegalSymbol(node, symInfo);
                SourceCodeBuilder.Append(node.GetText());
            }
        }
        public override void VisitExpressionStatement(ExpressionStatementSyntax node)
        {
            SourceCodeBuilder.Append(GetIndentString());

            VisitToplevelExpression(node.Expression, ";");
        }
        public override void VisitLiteralExpression(LiteralExpressionSyntax node)
        {
            SourceCodeBuilder.Append(node.Token.Text);
        }
        public override void VisitBinaryExpression(BinaryExpressionSyntax node)
        {
            string op = node.OperatorToken.Text;
            ProcessBinaryOperator(node, ref op);
            string functor;
            if(s_BinaryFunctor.TryGetValue(op, out functor)) {
                SourceCodeBuilder.AppendFormat("{0}(",functor);
                VisitExpressionSyntax(node.Left);
                SourceCodeBuilder.Append(", ");
                VisitExpressionSyntax(node.Right);
                SourceCodeBuilder.Append(")");
            } else {
                VisitExpressionSyntax(node.Left);
                SourceCodeBuilder.AppendFormat(" {0} ", op);
                VisitExpressionSyntax(node.Right);
            }
        }
        public override void VisitConditionalExpression(ConditionalExpressionSyntax node)
        {
            SourceCodeBuilder.Append("condexp(");
            VisitExpressionSyntax(node.Condition);
            SourceCodeBuilder.Append(", ");
            VisitExpressionSyntax(node.WhenTrue);
            SourceCodeBuilder.Append(", ");
            VisitExpressionSyntax(node.WhenFalse);
            SourceCodeBuilder.Append(")");
        }
        public override void VisitThisExpression(ThisExpressionSyntax node)
        {
            SourceCodeBuilder.Append("self");
        }
        public override void VisitBaseExpression(BaseExpressionSyntax node)
        {
            SourceCodeBuilder.Append("self");
        }
        public override void VisitElementAccessExpression(ElementAccessExpressionSyntax node)
        {
            var id = node.Expression as IdentifierNameSyntax;
            if (null != id) {
                var mi = m_MethodInfoStack.Peek();
                if (mi.OriginalParamsName == id.Identifier.Text) {
                    SourceCodeBuilder.Append("({...})[");
                    VisitArgument(node.ArgumentList.Arguments[0]);
                    SourceCodeBuilder.Append(" + 1]");
                    return;
                }
            }
            VisitExpressionSyntax(node.Expression);
            SourceCodeBuilder.Append("[");
            VisitBracketedArgumentList(node.ArgumentList);
            SourceCodeBuilder.Append("]");
        }
        public override void VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
        {
            SourceCodeBuilder.Append("( ");
            VisitExpressionSyntax(node.Expression);
            SourceCodeBuilder.Append(" )");
        }
        public override void VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
        {
            string op = node.OperatorToken.Text;
            if (op == "++" || op == "--") {
                SourceCodeBuilder.Append("(function() ");
                VisitExpressionSyntax(node.Operand);
                SourceCodeBuilder.Append(" = ");
                VisitExpressionSyntax(node.Operand);
                SourceCodeBuilder.Append(" ");
                SourceCodeBuilder.Append(op == "++" ? "+" : "-");
                SourceCodeBuilder.Append(" 1; return ");
                VisitExpressionSyntax(node.Operand);
                SourceCodeBuilder.Append("; end)()");
            } else {
                ProcessUnaryOperator(node, ref op);
                SourceCodeBuilder.Append("(");
                SourceCodeBuilder.Append(op);
                VisitExpressionSyntax(node.Operand);
                SourceCodeBuilder.Append(")");
            }
        }
        public override void VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
        {
            string op = node.OperatorToken.Text;
            if (op == "++" || op == "--") {
                VisitExpressionSyntax(node.Operand);
                m_PostfixUnaryExpressions.Enqueue(node);
            } else {
                SourceCodeBuilder.Append("(");
                SourceCodeBuilder.Append(op);
                VisitExpressionSyntax(node.Operand);
                SourceCodeBuilder.Append(")");
            }
        }
        public override void VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
        {
            SymbolInfo symInfo = m_Model.GetSymbolInfo(node);
            var sym = symInfo.Symbol;

            if (null != sym) {
                var ci = m_ClassInfoStack.Peek();
                string refKey = ClassInfo.CalcMemberReference(sym);
                ci.AddReference(refKey);
            } else {
                ReportIllegalSymbol(node, symInfo);
            }

            VisitExpressionSyntax(node.Expression);
            SourceCodeBuilder.Append(node.OperatorToken.Text);
            SourceCodeBuilder.Append(node.Name.Identifier.Text);
        }
        public override void VisitInitializerExpression(InitializerExpressionSyntax node)
        {
            bool isCollection = node.IsKind(SyntaxKind.CollectionInitializerExpression);
            if (isCollection) {
                var args = node.Expressions;
                int ct = args.Count;
                for (int i = 0; i < ct; ++i) {
                    var exp = args[i] as InitializerExpressionSyntax;
                    if (null != exp) {
                        SourceCodeBuilder.Append("[");
                        VisitToplevelExpression(exp.Expressions[0], string.Empty);
                        SourceCodeBuilder.Append("] = ");
                        VisitToplevelExpression(exp.Expressions[1], string.Empty);
                        if (i < ct - 1)
                            SourceCodeBuilder.Append(";");
                        return;
                    } else {
                        Log(node, "Error collection initializer ! syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
                    }
                }
            } else {
                bool isArray = node.IsKind(SyntaxKind.ArrayInitializerExpression);
                if (isArray)
                    SourceCodeBuilder.Append("{");
                var args = node.Expressions;
                int ct = args.Count;
                for (int i = 0; i < ct; ++i) {
                    var exp = args[i];
                    VisitToplevelExpression(exp, string.Empty);
                    if (i < ct - 1) {
                        SourceCodeBuilder.Append(", ");
                    }
                }
                if (isArray)
                    SourceCodeBuilder.Append("}");
            }
        }
        public override void VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
        {
            TypeInfo typeInfo = m_Model.GetTypeInfo(node);
            ITypeSymbol symInfo = typeInfo.Type;
            m_ObjectCreateStack.Push(symInfo);

            string ns = ClassInfo.GetNamespaces(symInfo);
            string fullTypeName;
            if (ns.Length > 0) {
                fullTypeName = ns + "." + symInfo.Name;
            } else {
                fullTypeName = symInfo.Name;
            }

            bool isDictionary = IsInterface(symInfo, "IDictionary");
            if (symInfo.ContainingAssembly == m_SymbolTable.AssemblySymbol || isDictionary) {
                //脚本定义对象的处理
                SourceCodeBuilder.AppendFormat("(function() local obj = {0}:new();", fullTypeName);
                if (null != node.ArgumentList) {
                    SourceCodeBuilder.Append("obj:ctor(");
                    VisitArgumentList(node.ArgumentList);
                    SourceCodeBuilder.Append(");");
                }
                if (null != node.Initializer) {
                    SourceCodeBuilder.Append("local self = obj;");
                    if (isDictionary) {
                        SourceCodeBuilder.Append("obj");
                    }
                    VisitInitializerExpression(node.Initializer);
                    SourceCodeBuilder.Append(";");
                }
                SourceCodeBuilder.Append("return obj; end)()");
            } else {
                //外部对象的处理，这里按Slua的规则处理，不支持初始化列表的写法
                SourceCodeBuilder.AppendFormat("{0}(", fullTypeName);
                if (null != node.ArgumentList) {
                    VisitArgumentList(node.ArgumentList);
                }
                SourceCodeBuilder.Append(")");
            }

            m_ObjectCreateStack.Pop();
        }
        public override void VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
        {
            if (null == node.Initializer) {
                var rankspecs = node.Type.RankSpecifiers;
                var rankspec = rankspecs[0];
                int rank = rankspec.Rank;
                if (rank > 1) {
                    SourceCodeBuilder.Append("(function() local arr={};");
                    int ct = rankspec.Sizes.Count;
                    for (int i = 0; i < ct; ++i) {
                        SourceCodeBuilder.AppendFormat("local d{0}=",i);
                        var exp = rankspec.Sizes[i];
                        VisitExpressionSyntax(exp);
                        SourceCodeBuilder.AppendFormat(";for i{0}=1,d{1} do arr{2} = ", i, i, GetArraySubscriptString(i));
                        if (i < ct - 1) {
                            SourceCodeBuilder.Append("{};");
                        } else {
                            SourceCodeBuilder.Append("nil;");
                        }
                    }
                    for (int i = 0; i < ct; ++i) {
                        SourceCodeBuilder.Append(" end;");
                    }
                    SourceCodeBuilder.Append(" return arr; end)()");
                } else {
                    SourceCodeBuilder.Append("{}");
                }
            } else {
                VisitInitializerExpression(node.Initializer);
            }
        }
        public override void VisitImplicitArrayCreationExpression(ImplicitArrayCreationExpressionSyntax node)
        {
            VisitInitializerExpression(node.Initializer);
        }
        public override void VisitEqualsValueClause(EqualsValueClauseSyntax node)
        {
            SourceCodeBuilder.AppendFormat(" {0} ", node.EqualsToken.Text);
            VisitExpressionSyntax(node.Value);
        }
        public override void VisitEmptyStatement(EmptyStatementSyntax node)
        { }
        public override void VisitBreakStatement(BreakStatementSyntax node)
        {
            if (m_ContinueInfoStack.Count > 0) {
                var ci = m_ContinueInfoStack.Peek();
                if (ci.IsIgnoreBreak)
                    return;
                if (ci.HaveContinue) {
                    SourceCodeBuilder.AppendFormat("{0}{1} = true;", GetIndentString(), ci.BreakFlagVarName);
                    SourceCodeBuilder.AppendLine();
                }
                SourceCodeBuilder.AppendFormat("{0}break;", GetIndentString());
                SourceCodeBuilder.AppendLine();
            }
        }
        public override void VisitContinueStatement(ContinueStatementSyntax node)
        {
            if (m_ContinueInfoStack.Count > 0) {
                var ci = m_ContinueInfoStack.Peek();
                if (ci.IsIgnoreBreak)
                    return;
                if (ci.HaveBreak) {
                    SourceCodeBuilder.AppendFormat("{0}{1} = false;", GetIndentString(), ci.BreakFlagVarName);
                    SourceCodeBuilder.AppendLine();
                }
                SourceCodeBuilder.AppendFormat("{0}break;", GetIndentString());
                SourceCodeBuilder.AppendLine();
            }
        }
        public override void VisitReturnStatement(ReturnStatementSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            mi.ExistReturn = true;

            SourceCodeBuilder.AppendFormat("{0}return ", GetIndentString());
            string prestr = "";
            if(null!=node.Expression){
                VisitExpressionSyntax(node.Expression);
                prestr = ", ";
            }
            var names = mi.ReturnParamNames;
            if (names.Count > 0) {
                for (int i = 0; i < names.Count; ++i) {
                    SourceCodeBuilder.Append(prestr);
                    SourceCodeBuilder.Append(names[i]);
                    prestr = ", ";
                }
            }
            SourceCodeBuilder.AppendLine(";");
        }
        public override void VisitWhileStatement(WhileStatementSyntax node)
        {
            ContinueInfo ci = new ContinueInfo();
            ci.Init(node.Statement);
            m_ContinueInfoStack.Push(ci);

            SourceCodeBuilder.AppendFormat("{0}while ", GetIndentString());
            VisitExpressionSyntax(node.Condition);
            SourceCodeBuilder.AppendLine(" do");
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    SourceCodeBuilder.AppendFormat("{0}local {1} = false", GetIndentString(), ci.BreakFlagVarName);
                    SourceCodeBuilder.AppendLine();
                }
                SourceCodeBuilder.AppendFormat("{0}repeat", GetIndentString());
                SourceCodeBuilder.AppendLine();
            }
            ++m_Indent;
            node.Statement.Accept(this);
            --m_Indent;
            if (ci.HaveContinue) {
                SourceCodeBuilder.AppendFormat("{0}until 0~= 0;", GetIndentString());
                SourceCodeBuilder.AppendLine();
                if (ci.HaveBreak) {
                    SourceCodeBuilder.AppendFormat("{0}if {1} then break; end;", GetIndentString(), ci.BreakFlagVarName);
                    SourceCodeBuilder.AppendLine();
                }
            }
            SourceCodeBuilder.AppendFormat("{0}end;", GetIndentString());
            SourceCodeBuilder.AppendLine();

            m_ContinueInfoStack.Pop();
        }
        public override void VisitDoStatement(DoStatementSyntax node)
        {
            ContinueInfo ci = new ContinueInfo();
            ci.Init(node.Statement);
            m_ContinueInfoStack.Push(ci);
            
            SourceCodeBuilder.AppendFormat("{0}repeat", GetIndentString());
            SourceCodeBuilder.AppendLine();
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    SourceCodeBuilder.AppendFormat("{0}local {1} = false", GetIndentString(), ci.BreakFlagVarName);
                    SourceCodeBuilder.AppendLine();
                }
                SourceCodeBuilder.AppendFormat("{0}repeat", GetIndentString());
                SourceCodeBuilder.AppendLine();
            }
            ++m_Indent;
            node.Statement.Accept(this);
            --m_Indent;
            if (ci.HaveContinue) {
                SourceCodeBuilder.AppendFormat("{0}until 0~= 0;", GetIndentString());
                SourceCodeBuilder.AppendLine();
                if (ci.HaveBreak) {
                    SourceCodeBuilder.AppendFormat("{0}if {1} then break; end;", GetIndentString(), ci.BreakFlagVarName);
                    SourceCodeBuilder.AppendLine();
                }
            }
            SourceCodeBuilder.AppendFormat("{0}until not (", GetIndentString());
            VisitExpressionSyntax(node.Condition);
            SourceCodeBuilder.AppendLine(");");

            m_ContinueInfoStack.Pop();
        }
        public override void VisitForStatement(ForStatementSyntax node)
        {
            ContinueInfo ci = new ContinueInfo();
            ci.Init(node.Statement);
            m_ContinueInfoStack.Push(ci);

            VisitVariableDeclaration(node.Declaration);
            SourceCodeBuilder.AppendFormat("{0}while ", GetIndentString());
            VisitExpressionSyntax(node.Condition);
            SourceCodeBuilder.AppendLine(" do");
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    SourceCodeBuilder.AppendFormat("{0}local {1} = false", GetIndentString(), ci.BreakFlagVarName);
                    SourceCodeBuilder.AppendLine();
                }
                SourceCodeBuilder.AppendFormat("{0}repeat", GetIndentString());
                SourceCodeBuilder.AppendLine();
            }
            ++m_Indent;
            node.Statement.Accept(this);
            foreach (var exp in node.Incrementors) {
                SourceCodeBuilder.AppendFormat("{0}", GetIndentString());
                VisitToplevelExpression(exp, ";");
            }
            --m_Indent;
            if (ci.HaveContinue) {
                SourceCodeBuilder.AppendFormat("{0}until 0~= 0;", GetIndentString());
                SourceCodeBuilder.AppendLine();
                if (ci.HaveBreak) {
                    SourceCodeBuilder.AppendFormat("{0}if {1} then break; end;", GetIndentString(), ci.BreakFlagVarName);
                    SourceCodeBuilder.AppendLine();
                }
            }
            SourceCodeBuilder.AppendFormat("{0}end;", GetIndentString());
            SourceCodeBuilder.AppendLine();

            m_ContinueInfoStack.Pop();
        }
        public override void VisitForEachStatement(ForEachStatementSyntax node)
        {
            ContinueInfo ci = new ContinueInfo();
            ci.Init(node.Statement);
            m_ContinueInfoStack.Push(ci);

            string varName = string.Format("__compiler_foreach_{0}__", node.GetLocation().GetLineSpan().StartLinePosition.Line);
            SourceCodeBuilder.AppendFormat("{0}local {1} = (", GetIndentString(), varName);
            VisitExpressionSyntax(node.Expression);
            SourceCodeBuilder.AppendLine("):GetEnumerator();");
            SourceCodeBuilder.AppendFormat("{0}while {1}:MoveNext() do", GetIndentString(), varName);
            SourceCodeBuilder.AppendLine();
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    SourceCodeBuilder.AppendFormat("{0}local {1} = false", GetIndentString(), ci.BreakFlagVarName);
                    SourceCodeBuilder.AppendLine();
                }
                SourceCodeBuilder.AppendFormat("{0}repeat", GetIndentString());
                SourceCodeBuilder.AppendLine();
            }
            ++m_Indent;
            SourceCodeBuilder.AppendFormat("{0}{1} = {2}.Current;", GetIndentString(), node.Identifier.Text, varName);
            SourceCodeBuilder.AppendLine();
            node.Statement.Accept(this);
            --m_Indent;
            if (ci.HaveContinue) {
                SourceCodeBuilder.AppendFormat("{0}until 0~= 0;", GetIndentString());
                SourceCodeBuilder.AppendLine();
                if (ci.HaveBreak) {
                    SourceCodeBuilder.AppendFormat("{0}if {1} then break; end;", GetIndentString(), ci.BreakFlagVarName);
                    SourceCodeBuilder.AppendLine();
                }
            }
            SourceCodeBuilder.AppendFormat("{0}end;", GetIndentString());
            SourceCodeBuilder.AppendLine();

            m_ContinueInfoStack.Pop();
        }
        public override void VisitIfStatement(IfStatementSyntax node)
        {
            SourceCodeBuilder.AppendFormat("{0}if ", GetIndentString());
            VisitExpressionSyntax(node.Condition);
            SourceCodeBuilder.AppendLine(" then");
            ++m_Indent;
            node.Statement.Accept(this);
            --m_Indent;
            if (null != node.Else) {
                VisitElseClause(node.Else);
            } else {
                SourceCodeBuilder.AppendFormat("{0}end;", GetIndentString());
                SourceCodeBuilder.AppendLine();
            }
        }
        public override void VisitElseClause(ElseClauseSyntax node)
        {
            IfStatementSyntax ifNode = node.Statement as IfStatementSyntax;
            if (null != ifNode) {
                SourceCodeBuilder.AppendFormat("{0}elseif ", GetIndentString());
                VisitExpressionSyntax(ifNode.Condition);
                SourceCodeBuilder.AppendLine(" then");
                ++m_Indent;
                ifNode.Statement.Accept(this);
                --m_Indent;
                if (null != ifNode.Else) {
                    VisitElseClause(ifNode.Else);
                } else {
                    SourceCodeBuilder.AppendFormat("{0}end;", GetIndentString());
                    SourceCodeBuilder.AppendLine();
                }
            } else {
                SourceCodeBuilder.AppendFormat("{0}else", GetIndentString());
                SourceCodeBuilder.AppendLine();
                ++m_Indent;
                node.Statement.Accept(this);
                --m_Indent;
                SourceCodeBuilder.AppendFormat("{0}end;", GetIndentString());
                SourceCodeBuilder.AppendLine();
            }
        }
        public override void VisitSwitchStatement(SwitchStatementSyntax node)
        {
            string varName = string.Format("__compiler_switch_{0}__", node.GetLocation().GetLineSpan().StartLinePosition.Line);
            SwitchInfo si = new SwitchInfo();
            si.SwitchVarName = varName;
            m_SwitchInfoStack.Push(si);

            SourceCodeBuilder.AppendFormat("{0}local {1} = ", GetIndentString(), varName);
            VisitExpressionSyntax(node.Expression);
            SourceCodeBuilder.AppendLine(";");

            int ct = node.Sections.Count;
            SwitchSectionSyntax defaultSection = null;
            for (int i = 0; i < ct; ++i) {
                var section = node.Sections[i];
                int lct = section.Labels.Count;
                for (int j = 0; j < lct; ++j) {
                    var label = section.Labels[j];
                    if (label is DefaultSwitchLabelSyntax) {
                        defaultSection = section;
                        break;
                    }
                }
            }
            for (int i = 0; i < ct; ++i) {
                var section = node.Sections[i];
                if (section == defaultSection) {
                    continue;
                }
                ContinueInfo ci = new ContinueInfo();
                ci.Init(section);
                m_ContinueInfoStack.Push(ci);
                
                BreakAnalysis ba = new BreakAnalysis();
                ba.Visit(section);
                if (ba.BreakCount > 1) {
                    ci.IsIgnoreBreak = false;
                } else {
                    ci.IsIgnoreBreak = true;
                }
                
                SourceCodeBuilder.AppendFormat("{0}{1} ", GetIndentString(), i == 0 ? "if" : "elseif");
                int lct = section.Labels.Count;
                for (int j = 0; j < lct; ++j) {
                    var label = section.Labels[j] as CaseSwitchLabelSyntax;
                    if (null != label) {
                        if (lct > 1) {
                            SourceCodeBuilder.Append("(");
                        }
                        SourceCodeBuilder.AppendFormat("{0} == ",varName);
                        VisitExpressionSyntax(label.Value);
                        if (lct > 1) {
                            SourceCodeBuilder.Append(")");
                            if (j < lct - 1) {
                                SourceCodeBuilder.Append(" and ");
                            }
                        }
                    }
                }
                SourceCodeBuilder.AppendLine(" then");
                if (ba.BreakCount > 1) {
                    SourceCodeBuilder.AppendFormat("{0}repeat", GetIndentString());
                    SourceCodeBuilder.AppendLine();
                }
                ++m_Indent;

                int sct = section.Statements.Count;
                for (int j = 0; j < sct; ++j) {
                    var statement = section.Statements[j];
                    statement.Accept(this);
                }
                
                --m_Indent;
                if (ba.BreakCount > 1) {
                    SourceCodeBuilder.AppendFormat("{0}until 0 ~= 0;", GetIndentString());
                    SourceCodeBuilder.AppendLine();
                }

                m_ContinueInfoStack.Pop();
            }
            if (null != defaultSection) {
                ContinueInfo ci = new ContinueInfo();
                ci.Init(defaultSection);
                m_ContinueInfoStack.Push(ci);

                BreakAnalysis ba = new BreakAnalysis();
                ba.Visit(defaultSection);
                if (ba.BreakCount > 1) {
                    ci.IsIgnoreBreak = false;
                } else {
                    ci.IsIgnoreBreak = true;
                }
                SourceCodeBuilder.AppendFormat("{0}else", GetIndentString());
                SourceCodeBuilder.AppendLine();
                if (ba.BreakCount > 1) {
                    SourceCodeBuilder.AppendFormat("{0}repeat", GetIndentString());
                    SourceCodeBuilder.AppendLine();
                }
                ++m_Indent;

                int sct = defaultSection.Statements.Count;
                for (int j = 0; j < sct; ++j) {
                    var statement = defaultSection.Statements[j];
                    statement.Accept(this);
                }

                --m_Indent;
                if (ba.BreakCount > 1) {
                    SourceCodeBuilder.AppendFormat("{0}until 0 ~= 0;", GetIndentString());
                    SourceCodeBuilder.AppendLine();
                }
                SourceCodeBuilder.AppendFormat("{0}end;", GetIndentString());
                SourceCodeBuilder.AppendLine();

                m_ContinueInfoStack.Pop();
            }
            
            m_SwitchInfoStack.Pop();
        }
        public void SaveLog(string path)
        {
            File.WriteAllText(path, m_LogBuilder.ToString());
        }

        private string GetIndentString()
        {
            return GetIndentString(m_Indent);
        }
        private void Log(CSharpSyntaxNode node, string format, params object[] args)
        {
            m_LogBuilder.AppendFormat("<<<[Log for {0}]>>> ", node.GetType().Name);
            m_LogBuilder.AppendFormat(format, args);
            m_LogBuilder.AppendLine();
        }
        private void ReportIllegalSymbol(CSharpSyntaxNode node, SymbolInfo symInfo)
        {
            m_LogBuilder.AppendFormat("<<<[Log for {0}]>>> ", node.GetType().Name);
            m_LogBuilder.AppendFormat("Can't determine symbol: {0}, syntax part: {1} location{2}", symInfo.CandidateReason, node.ToString(), node.GetLocation().GetLineSpan());
            m_LogBuilder.AppendLine();
            foreach (var candidateSymbol in symInfo.CandidateSymbols) {
                m_LogBuilder.AppendFormat("\tCandidateSymbol: {0}", candidateSymbol.ToString());
                m_LogBuilder.AppendLine();
            }
        }
        private string NameMangling(IMethodSymbol sym)
        {
            return m_SymbolTable.NameMangling(sym);
        }
        private void OutputExpressionList(IList<ExpressionSyntax> args)
        {
            int ct = args.Count;
            for (int i = 0; i < ct; ++i) {
                var exp = args[i];
                VisitExpressionSyntax(exp);
                if (i < ct - 1) {
                    SourceCodeBuilder.Append(", ");
                }
            }
        }
        private void OutputArgumentList(SeparatedSyntaxList<ArgumentSyntax> args, string split)
        {
            int ct = args.Count;
            for (int i = 0; i < ct; ++i) {
                var arg = args[i];
                VisitArgument(arg);
                if (i < ct - 1) {
                    SourceCodeBuilder.Append(split);
                }
            }
        }
        private void ProcessUnaryOperator(CSharpSyntaxNode node, ref string op)
        {
            if (s_UnsupportedUnaryOperators.Contains(op)) {
                Log(node, "Cs2Lua can't support {0} unary operators ! syntax part: {1} location{2}", op, node.ToString(), node.GetLocation().GetLineSpan());
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
                Log(node, "Cs2Lua can't support {0} binary operators ! syntax part: {1} location{2}", op, node.ToString(), node.GetLocation().GetLineSpan());
            } else {
                string nop;
                if (s_BinaryAlias.TryGetValue(op, out nop)) {
                    op = nop;
                }
            }
        }
        private void AddToplevelClass(string key, ClassInfo ci)
        {
            m_ToplevelClasses.Add(key, ci);
            m_LastToplevelClass = ci;
        }

        public override void VisitAssignmentExpression(AssignmentExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            //顶层的赋值语句已经处理，这里的赋值都需要包装成lambda函数的样式
            SourceCodeBuilder.Append("(function() ");

            string op = node.OperatorToken.Text;
            string baseOp = op.Substring(0, op.Length - 1);
            InvocationExpressionSyntax invocation = node.Right as InvocationExpressionSyntax;
            if (null != invocation) {
                SymbolInfo symInfo = m_Model.GetSymbolInfo(invocation);
                IMethodSymbol sym = symInfo.Symbol as IMethodSymbol;

                MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                if (null != memberAccess) {
                    if (null == sym) {
                        ReportIllegalSymbol(invocation, symInfo);
                    } else {
                        //处理ref/out参数
                        InvocationInfo ii = new InvocationInfo();
                        ii.Init(sym, invocation.ArgumentList);
                        ci.AddReference(ii.ClassKey);

                        int ct = ii.ReturnArgs.Count;
                        if (ct > 0) {
                            if (op != "=") {
                                VisitExpressionSyntax(node.Left);
                                SourceCodeBuilder.Append(" = ");
                                ProcessBinaryOperator(node, ref baseOp);
                                string functor;
                                if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                                    SourceCodeBuilder.AppendFormat("{0}(", functor);
                                    VisitExpressionSyntax(node.Left);
                                    SourceCodeBuilder.Append(", ");
                                } else {
                                    VisitExpressionSyntax(node.Left);
                                    SourceCodeBuilder.AppendFormat(" {0} ", baseOp);
                                }
                                SourceCodeBuilder.Append("(function() local ret; ret, ");
                            } else {
                                VisitExpressionSyntax(node.Left);
                                SourceCodeBuilder.Append(", ");
                            }

                            OutputExpressionList(ii.ReturnArgs);
                            SourceCodeBuilder.Append(" = ");
                            VisitExpressionSyntax(memberAccess.Expression);
                            if (sym.IsStatic) {
                                SourceCodeBuilder.Append(".");
                            } else {
                                SourceCodeBuilder.Append(":");
                            }
                            SourceCodeBuilder.Append(NameMangling(sym));
                            SourceCodeBuilder.Append("(");
                            OutputExpressionList(ii.Args);
                            SourceCodeBuilder.Append(")");

                            if (op != "=") {
                                SourceCodeBuilder.Append("; return ret; end)()");
                                string functor;
                                if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                                    SourceCodeBuilder.Append(")");
                                }
                            }
                            SourceCodeBuilder.Append("; return ");
                            VisitExpressionSyntax(node.Left);
                            SourceCodeBuilder.Append("; end)()");
                            return;
                        }
                    }
                } else if (null != sym) {
                    //处理ref/out参数
                    InvocationInfo ii = new InvocationInfo();
                    ii.Init(sym, invocation.ArgumentList);
                    ci.AddReference(ii.ClassKey);

                    int ct = ii.ReturnArgs.Count;
                    if (ct > 0) {
                        if (op != "=") {
                            VisitExpressionSyntax(node.Left);
                            SourceCodeBuilder.Append(" = ");
                            ProcessBinaryOperator(node, ref baseOp);
                            string functor;
                            if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                                SourceCodeBuilder.AppendFormat("{0}(", functor);
                                VisitExpressionSyntax(node.Left);
                                SourceCodeBuilder.Append(", ");
                            } else {
                                VisitExpressionSyntax(node.Left);
                                SourceCodeBuilder.AppendFormat(" {0} ", baseOp);
                            }
                            SourceCodeBuilder.Append("(function() local ret; ret, ");
                        } else {
                            VisitExpressionSyntax(node.Left);
                            SourceCodeBuilder.Append(", ");
                        }

                        OutputExpressionList(ii.ReturnArgs);
                        SourceCodeBuilder.Append(" = ");
                        VisitExpressionSyntax(node.Right);
                        SourceCodeBuilder.Append("(");
                        OutputExpressionList(ii.Args);
                        SourceCodeBuilder.Append(")");

                        if (op != "=") {
                            SourceCodeBuilder.Append("; return ret; end)()");
                            string functor;
                            if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                                SourceCodeBuilder.Append(")");
                            }
                        }
                        SourceCodeBuilder.Append("; return ");
                        VisitExpressionSyntax(node.Left);
                        SourceCodeBuilder.Append("; end)()");
                        return;
                    }
                }
            }
            if (op == "=") {
                VisitExpressionSyntax(node.Left);
                SourceCodeBuilder.Append(" = ");
                VisitExpressionSyntax(node.Right);
            } else {
                VisitExpressionSyntax(node.Left);
                SourceCodeBuilder.Append(" = ");
                ProcessBinaryOperator(node, ref baseOp);
                string functor;
                if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                    SourceCodeBuilder.AppendFormat("{0}(", functor);
                    VisitExpressionSyntax(node.Left);
                    SourceCodeBuilder.Append(", ");
                    VisitExpressionSyntax(node.Right);
                    SourceCodeBuilder.Append(")");
                } else {
                    VisitExpressionSyntax(node.Left);
                    SourceCodeBuilder.AppendFormat(" {0} ", baseOp);
                    VisitExpressionSyntax(node.Right);
                }
            }
            SourceCodeBuilder.Append("; return ");
            VisitExpressionSyntax(node.Left);
            SourceCodeBuilder.Append("; end)()");
        }
        public override void VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();

            SymbolInfo symInfo = m_Model.GetSymbolInfo(node);
            IMethodSymbol sym = symInfo.Symbol as IMethodSymbol;
            if (null != sym) {
                string refKey = ClassInfo.CalcMemberReference(sym);
                ci.AddReference(refKey);
            }

            MemberAccessExpressionSyntax memberAccess = node.Expression as MemberAccessExpressionSyntax;
            if (null != memberAccess) {
                if (null == sym) {
                    ReportIllegalSymbol(node, symInfo);
                } else {
                    //处理ref/out参数
                    InvocationInfo ii = new InvocationInfo();
                    ii.Init(sym, node.ArgumentList);
                    ci.AddReference(ii.ClassKey);

                    if (ii.ReturnArgs.Count > 0) {
                        SourceCodeBuilder.Append("(function() ");
                        OutputExpressionList(ii.ReturnArgs);
                        SourceCodeBuilder.Append(" = ");
                    }
                    VisitExpressionSyntax(memberAccess.Expression);
                    if (sym.IsStatic) {
                        SourceCodeBuilder.Append(".");
                    } else {
                        SourceCodeBuilder.Append(":");
                    }
                    SourceCodeBuilder.Append(NameMangling(sym));
                    SourceCodeBuilder.Append("(");
                    OutputExpressionList(ii.Args);
                    SourceCodeBuilder.Append(")");
                    if (ii.ReturnArgs.Count > 0) {
                        SourceCodeBuilder.Append("; end)()");
                    }
                }
            } else if (null != sym) {
                //处理ref/out参数
                InvocationInfo ii = new InvocationInfo();
                ii.Init(sym, node.ArgumentList);
                ci.AddReference(ii.ClassKey);

                if (ii.ReturnArgs.Count > 0) {
                    SourceCodeBuilder.Append("(function() ");
                    OutputExpressionList(ii.ReturnArgs);
                    SourceCodeBuilder.Append(" = ");
                }
                VisitExpressionSyntax(node.Expression);
                SourceCodeBuilder.Append("(");
                OutputExpressionList(ii.Args);
                SourceCodeBuilder.Append(")");
                if (ii.ReturnArgs.Count > 0) {
                    SourceCodeBuilder.Append("; end)()");
                }
            } else {
                VisitExpressionSyntax(node.Expression);
                SourceCodeBuilder.Append("(");
                VisitArgumentList(node.ArgumentList);
                SourceCodeBuilder.Append(")");
            }
        }
        private void VisitToplevelExpression(ExpressionSyntax expression, string expTerminater)
        {
            VisitToplevelExpressionFirstPass(expression, expTerminater);
            while (m_PostfixUnaryExpressions.Count > 0) {
                PostfixUnaryExpressionSyntax postfixUnary = m_PostfixUnaryExpressions.Dequeue();
                if (null != postfixUnary) {
                    string op = postfixUnary.OperatorToken.Text;
                    if (op == "++" || op == "--") {
                        VisitExpressionSyntax(postfixUnary.Operand);
                        SourceCodeBuilder.Append(" = ");
                        VisitExpressionSyntax(postfixUnary.Operand);
                        SourceCodeBuilder.Append(op == "++" ? " + 1" : " - 1");
                        SourceCodeBuilder.AppendFormat("{0}", expTerminater);
                        if (expTerminater.Length > 0)
                            SourceCodeBuilder.AppendLine();
                    }
                }
            }
        }
        private void VisitTypeDeclarationSyntax(TypeDeclarationSyntax node)
        {
            INamedTypeSymbol sym = m_Model.GetDeclaredSymbol(node);
            ClassInfo ci = new ClassInfo();
            ci.Init(sym);
            m_ClassInfoStack.Push(ci);

            if (m_ClassInfoStack.Count == 1) {
                ci.BeforeOuterCodeBuilder.Append(m_ToplevelSourceCodeBuilder.ToString());
                m_ToplevelSourceCodeBuilder.Clear();
            }

            string className = node.Identifier.Text;
            if (!string.IsNullOrEmpty(ci.BaseClassName) && ci.BaseClassName != "Object" && ci.BaseClassName != "ValueType") {
                Log(node, "Cs2Lua only support Class inherit System.Object ! syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
            }

            TypeInfo typeInfo = m_Model.GetTypeInfo(node);
            var type = typeInfo.Type;

            ++m_Indent;
            ci.CurrentSourceCodeBuilder = ci.StaticFunctionSourceCodeBuilder;
            foreach (var member in node.Members) {
                var baseSym = m_Model.GetDeclaredSymbol(member);
                var methodSym = baseSym as IMethodSymbol;
                var propSym = baseSym as IPropertySymbol;
                var eventSym = baseSym as IEventSymbol;
                if (null != methodSym && methodSym.IsStatic) {
                    member.Accept(this);
                }
                if (null != propSym && propSym.IsStatic) {
                    member.Accept(this);
                }
            }
            ci.CurrentSourceCodeBuilder = ci.StaticFieldSourceCodeBuilder;
            foreach (var member in node.Members) {
                FieldDeclarationSyntax fieldDecl = member as FieldDeclarationSyntax;
                if (null != fieldDecl) {
                    foreach (var v in fieldDecl.Declaration.Variables) {
                        var baseSym = m_Model.GetDeclaredSymbol(v);
                        var fieldSym = baseSym as IFieldSymbol;
                        if (fieldSym.IsStatic) {
                            SourceCodeBuilder.AppendFormat("{0}{1}", GetIndentString(), v.Identifier.Text);
                            if (null != v.Initializer) {
                                SourceCodeBuilder.Append(" = ");
                                if (fieldSym.HasConstantValue) {
                                    SourceCodeBuilder.Append(fieldSym.ConstantValue);
                                } else {
                                    VisitExpressionSyntax(v.Initializer.Value);
                                }
                            } else {
                                SourceCodeBuilder.Append(" = nil");
                            }
                            SourceCodeBuilder.Append(",");
                            SourceCodeBuilder.AppendLine();
                        }
                    }
                    member.Accept(this);
                }
            }
            ++m_Indent;
            ++m_Indent;
            ci.CurrentSourceCodeBuilder = ci.InstanceFunctionSourceCodeBuilder;
            foreach (var member in node.Members) {
                var baseSym = m_Model.GetDeclaredSymbol(member);
                var methodSym = baseSym as IMethodSymbol;
                var propSym = baseSym as IPropertySymbol;
                var eventSym = baseSym as IEventSymbol;
                if (null != methodSym && !methodSym.IsStatic) {
                    member.Accept(this);
                }
                if (null != propSym && !propSym.IsStatic) {
                    member.Accept(this);
                }
            }
            ci.CurrentSourceCodeBuilder = ci.InstanceFieldSourceCodeBuilder;
            foreach (var member in node.Members) {
                FieldDeclarationSyntax fieldDecl = member as FieldDeclarationSyntax;
                if (null != fieldDecl) {
                    foreach (var v in fieldDecl.Declaration.Variables) {
                        var baseSym = m_Model.GetDeclaredSymbol(v);
                        var fieldSym = baseSym as IFieldSymbol;
                        if (!fieldSym.IsStatic) {
                            SourceCodeBuilder.AppendFormat("{0}{1}", GetIndentString(), v.Identifier.Text);
                            if (null != v.Initializer) {
                                SourceCodeBuilder.Append(" = ");
                                if (fieldSym.HasConstantValue) {
                                    SourceCodeBuilder.Append(fieldSym.ConstantValue);
                                } else {
                                    VisitExpressionSyntax(v.Initializer.Value);
                                }
                            } else {
                                SourceCodeBuilder.Append(" = nil");
                            }
                            SourceCodeBuilder.Append(",");
                            SourceCodeBuilder.AppendLine();
                        }
                    }
                    member.Accept(this);
                }
            }
            --m_Indent;
            --m_Indent;
            --m_Indent;
            m_ClassInfoStack.Pop();

            if (m_ClassInfoStack.Count <= 0) {
                AddToplevelClass(ci.Key, ci);
            }
        }
        private void VisitExpressionSyntax(ExpressionSyntax node)
        {
            IOperation oper = m_Model.GetOperation(node);
            if (null != oper && oper.ConstantValue.HasValue) {
                object val = oper.ConstantValue.Value;
                string v = val as string;
                if (null != v) {
                    SourceCodeBuilder.AppendFormat("\"{0}\"", Escape(v));
                } else if (val is bool) {
                    SourceCodeBuilder.Append((bool)val ? "true" : "false");
                } else {
                    SourceCodeBuilder.Append(val);
                }
                return;
            }
            node.Accept(this);            
        }

        private void VisitToplevelExpressionFirstPass(ExpressionSyntax expression, string expTerminater)
        {
            var ci = m_ClassInfoStack.Peek();

            AssignmentExpressionSyntax assign = expression as AssignmentExpressionSyntax;
            if (null != assign) {
                string op = assign.OperatorToken.Text;
                string baseOp = op.Substring(0, op.Length - 1);
                InvocationExpressionSyntax invocation = assign.Right as InvocationExpressionSyntax;
                if (null != invocation) {
                    SymbolInfo symInfo = m_Model.GetSymbolInfo(invocation);
                    IMethodSymbol sym = symInfo.Symbol as IMethodSymbol;
                    MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                    if (null != memberAccess) {
                        if (null == sym) {
                            ReportIllegalSymbol(invocation, symInfo);
                        } else {
                            //处理ref/out参数
                            InvocationInfo ii = new InvocationInfo();
                            ii.Init(sym, invocation.ArgumentList);
                            ci.AddReference(ii.ClassKey);

                            int ct = ii.ReturnArgs.Count;
                            if (ct > 0) {
                                if (op != "=") {
                                    VisitExpressionSyntax(assign.Left);
                                    SourceCodeBuilder.Append(" = ");
                                    ProcessBinaryOperator(assign, ref baseOp);
                                    string functor;
                                    if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                                        SourceCodeBuilder.AppendFormat("{0}(", functor);
                                        VisitExpressionSyntax(assign.Left);
                                        SourceCodeBuilder.Append(", ");
                                    } else {
                                        VisitExpressionSyntax(assign.Left);
                                        SourceCodeBuilder.AppendFormat(" {0} ", baseOp);
                                    }
                                    SourceCodeBuilder.Append("(function() local ret; ret, ");
                                } else {
                                    VisitExpressionSyntax(assign.Left);
                                    SourceCodeBuilder.Append(", ");
                                }

                                OutputExpressionList(ii.ReturnArgs);
                                SourceCodeBuilder.Append(" = ");
                                VisitExpressionSyntax(memberAccess.Expression);
                                if (sym.IsStatic) {
                                    SourceCodeBuilder.Append(".");
                                } else {
                                    SourceCodeBuilder.Append(":");
                                }
                                SourceCodeBuilder.Append(NameMangling(sym));
                                SourceCodeBuilder.Append("(");
                                OutputExpressionList(ii.Args);
                                SourceCodeBuilder.Append(")");

                                if (op != "=") {
                                    SourceCodeBuilder.Append("; return ret; end)()");
                                    string functor;
                                    if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                                        SourceCodeBuilder.Append(")");
                                    }
                                }

                                SourceCodeBuilder.AppendFormat("{0}", expTerminater);
                                if (expTerminater.Length > 0)
                                    SourceCodeBuilder.AppendLine();
                                return;
                            }
                        }
                    } else if (null != sym) {
                        //处理ref/out参数
                        InvocationInfo ii = new InvocationInfo();
                        ii.Init(sym, invocation.ArgumentList);
                        ci.AddReference(ii.ClassKey);

                        int ct = ii.ReturnArgs.Count;
                        if (ct > 0) {
                            if (op != "=") {
                                VisitExpressionSyntax(assign.Left);
                                SourceCodeBuilder.Append(" = ");
                                ProcessBinaryOperator(assign, ref baseOp);
                                string functor;
                                if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                                    SourceCodeBuilder.AppendFormat("{0}(", functor);
                                    VisitExpressionSyntax(assign.Left);
                                    SourceCodeBuilder.Append(", ");
                                } else {
                                    VisitExpressionSyntax(assign.Left);
                                    SourceCodeBuilder.AppendFormat(" {0} ", baseOp);
                                }
                                SourceCodeBuilder.Append("(function() local ret; ret, ");
                            } else {
                                VisitExpressionSyntax(assign.Left);
                                SourceCodeBuilder.Append(", ");
                            }

                            OutputExpressionList(ii.ReturnArgs);
                            SourceCodeBuilder.Append(" = ");
                            VisitExpressionSyntax(assign.Right);
                            SourceCodeBuilder.Append("(");
                            OutputExpressionList(ii.Args);
                            SourceCodeBuilder.Append(")");

                            if (op != "=") {
                                SourceCodeBuilder.Append("; return ret; end)()");
                                string functor;
                                if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                                    SourceCodeBuilder.Append(")");
                                }
                            }

                            SourceCodeBuilder.AppendFormat("{0}", expTerminater);
                            if (expTerminater.Length > 0)
                                SourceCodeBuilder.AppendLine();
                            return;
                        }
                    }
                }
                if (op == "=") {
                    VisitExpressionSyntax(assign.Left);
                    SourceCodeBuilder.Append(" = ");
                    VisitExpressionSyntax(assign.Right);
                } else {
                    VisitExpressionSyntax(assign.Left);
                    SourceCodeBuilder.Append(" = ");
                    ProcessBinaryOperator(assign, ref baseOp);
                    string functor;
                    if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                        SourceCodeBuilder.AppendFormat("{0}(", functor);
                        VisitExpressionSyntax(assign.Left);
                        SourceCodeBuilder.Append(", ");
                        VisitExpressionSyntax(assign.Right);
                        SourceCodeBuilder.Append(")");
                    } else {
                        VisitExpressionSyntax(assign.Left);
                        SourceCodeBuilder.AppendFormat(" {0} ", baseOp);
                        VisitExpressionSyntax(assign.Right);
                    }
                }
                SourceCodeBuilder.AppendFormat("{0}", expTerminater);
                if (expTerminater.Length > 0)
                    SourceCodeBuilder.AppendLine();
                return;
            } else {
                InvocationExpressionSyntax invocation = expression as InvocationExpressionSyntax;
                if (null != invocation) {
                    SymbolInfo symInfo = m_Model.GetSymbolInfo(invocation);
                    IMethodSymbol sym = symInfo.Symbol as IMethodSymbol;
                    MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                    if (null != memberAccess) {
                        if (null == sym) {
                            ReportIllegalSymbol(invocation, symInfo);
                        } else {
                            //处理ref/out参数
                            InvocationInfo ii = new InvocationInfo();
                            ii.Init(sym, invocation.ArgumentList);
                            ci.AddReference(ii.ClassKey);

                            if (ii.ReturnArgs.Count > 0) {
                                OutputExpressionList(ii.ReturnArgs);
                                SourceCodeBuilder.Append(" = ");
                            }
                            VisitExpressionSyntax(memberAccess.Expression);
                            if (sym.IsStatic) {
                                SourceCodeBuilder.Append(".");
                            } else {
                                SourceCodeBuilder.Append(":");
                            }
                            SourceCodeBuilder.Append(NameMangling(sym));
                            SourceCodeBuilder.Append("(");
                            OutputExpressionList(ii.Args);
                            SourceCodeBuilder.AppendFormat("){0}", expTerminater);
                            if (expTerminater.Length > 0)
                                SourceCodeBuilder.AppendLine();

                            return;
                        }
                    } else if (null != sym) {
                        //处理ref/out参数
                        InvocationInfo ii = new InvocationInfo();
                        ii.Init(sym, invocation.ArgumentList);
                        ci.AddReference(ii.ClassKey);

                        if (ii.ReturnArgs.Count > 0) {
                            OutputExpressionList(ii.ReturnArgs);
                            SourceCodeBuilder.Append(" = ");
                        }
                        VisitExpressionSyntax(invocation.Expression);
                        SourceCodeBuilder.Append("(");
                        OutputExpressionList(ii.Args);
                        SourceCodeBuilder.AppendFormat("){0}", expTerminater);
                        if (expTerminater.Length > 0)
                            SourceCodeBuilder.AppendLine();

                        return;
                    }
                }
            }
            PrefixUnaryExpressionSyntax prefixUnary = expression as PrefixUnaryExpressionSyntax;
            if (null != prefixUnary) {
                string op = prefixUnary.OperatorToken.Text;
                if (op == "++" || op == "--") {
                    VisitExpressionSyntax(prefixUnary.Operand);
                    SourceCodeBuilder.Append(" = ");
                    VisitExpressionSyntax(prefixUnary.Operand);
                    SourceCodeBuilder.Append(op == "++" ? " + 1" : " - 1");
                    SourceCodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        SourceCodeBuilder.AppendLine();
                } else {
                    ProcessUnaryOperator(expression, ref op);
                    SourceCodeBuilder.Append("(");
                    SourceCodeBuilder.Append(op);
                    SourceCodeBuilder.Append(" ");
                    VisitExpressionSyntax(prefixUnary.Operand);
                    SourceCodeBuilder.AppendFormat("){0}", expTerminater);
                    if (expTerminater.Length > 0)
                        SourceCodeBuilder.AppendLine();
                }
                return;
            }
            PostfixUnaryExpressionSyntax postfixUnary = expression as PostfixUnaryExpressionSyntax;
            if (null != postfixUnary) {
                string op = postfixUnary.OperatorToken.Text;
                if (op == "++" || op == "--") {
                    VisitExpressionSyntax(postfixUnary.Operand);
                    SourceCodeBuilder.Append(" = ");
                    VisitExpressionSyntax(postfixUnary.Operand);
                    SourceCodeBuilder.Append(op == "++" ? " + 1" : " - 1");
                    SourceCodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        SourceCodeBuilder.AppendLine();
                }
                return;
            }
            VisitExpressionSyntax(expression);
            SourceCodeBuilder.AppendFormat("{0}", expTerminater);
            if (expTerminater.Length > 0)
                SourceCodeBuilder.AppendLine();
        }

        private StringBuilder SourceCodeBuilder
        {
            get 
            {
                if (m_ClassInfoStack.Count > 0) {
                    var ci = m_ClassInfoStack.Peek();
                    var builder = ci.CurrentSourceCodeBuilder;
                    if (null != builder) {
                        return builder;
                    }
                }
                return m_ToplevelSourceCodeBuilder; 
            }
        }
        
        private SemanticModel m_Model = null;
        private SymbolTable m_SymbolTable = null;
        private StringBuilder m_LogBuilder = new StringBuilder();
        private int m_Indent = 0;
        private StringBuilder m_ToplevelSourceCodeBuilder = new StringBuilder();
        
        private Stack<ClassInfo> m_ClassInfoStack = new Stack<ClassInfo>();
        private Stack<MethodInfo> m_MethodInfoStack = new Stack<MethodInfo>();
        private Stack<ITypeSymbol> m_ObjectCreateStack = new Stack<ITypeSymbol>();
        private Stack<ContinueInfo> m_ContinueInfoStack = new Stack<ContinueInfo>();
        private Stack<SwitchInfo> m_SwitchInfoStack = new Stack<SwitchInfo>();
        private Queue<PostfixUnaryExpressionSyntax> m_PostfixUnaryExpressions = new Queue<PostfixUnaryExpressionSyntax>();

        private Dictionary<string, ClassInfo> m_ToplevelClasses = new Dictionary<string, ClassInfo>();
        private ClassInfo m_LastToplevelClass = null;

        internal static string GetIndentString(int indent)
        {
            const string c_IndentString = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t";
            return c_IndentString.Substring(0, indent);
        }
        private static bool IsInterface(ITypeSymbol symInfo, string name)
        {
            foreach (var intf in symInfo.AllInterfaces) {
                if (intf.Name == name) {
                    return true;
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
                switch (c) {
                    case '\a':
                        sb.Append("\\a");
                        break;
                    case '\b':
                        sb.Append("\\b");
                        break;
                    case '\f':
                        sb.Append("\\f");
                        break;
                    case '\n':
                        sb.Append("\\n");
                        break;
                    case '\r':
                        sb.Append("\\r");
                        break;
                    case '\t':
                        sb.Append("\\t");
                        break;
                    case '\v':
                        sb.Append("\\v");
                        break;
                    case '\\':
                        sb.Append("\\\\");
                        break;
                    case '\"':
                        sb.Append("\\\"");
                        break;
                    case '\'':
                        sb.Append("\\'");
                        break;
                    default:
                        sb.Append(c);
                        break;
                }
            }
            return sb.ToString();
        }

        private static HashSet<string> s_UnsupportedUnaryOperators = new HashSet<string> { "~", "&", "*" };
        private static HashSet<string> s_UnsupportedBinaryOperators = new HashSet<string> { "&", "|", "^" };

        private static Dictionary<string, string> s_UnaryAlias = new Dictionary<string, string> { 
            {"!","not"}
        };
        private static Dictionary<string, string> s_BinaryAlias = new Dictionary<string, string> { 
            {"!=","~="},
            {"&&","and"},
            {"||","or"}
        };

        private static Dictionary<string, string> s_UnaryFunctor = new Dictionary<string, string> {};
        private static Dictionary<string, string> s_BinaryFunctor = new Dictionary<string, string> {
            {"<<","lshift"},
            {">>","rshift"}
        };
    }
}
