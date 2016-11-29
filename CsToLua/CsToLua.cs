using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Semantics;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace RoslynTool.CsToLua
{
    internal sealed partial class CsLuaTranslater : CSharpSyntaxVisitor
    {
        public Dictionary<string, List<ClassInfo>> ToplevelClasses
        {
            get { return m_ToplevelClasses; }
        }
        public bool HaveError
        {
            get
            {
                return Logger.Instance.HaveError;
            }
        }
        public string ErrorLog
        {
            get
            {
                return Logger.Instance.ErrorLog;
            }
        }
        public void Translate(SyntaxNode node)
        {
            Visit(node);
            if (null != m_LastToplevelClass) {
                m_LastToplevelClass.AfterOuterCodeBuilder.Append(m_ToplevelCodeBuilder.ToString());
                m_ToplevelCodeBuilder.Clear();
            }
        }
        public CsLuaTranslater(SemanticModel model, SymbolTable symbolTable, bool enableInherit)
        {
            m_Model = model;
            m_SymbolTable = symbolTable;
            m_EnableInherit = enableInherit;
        }

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
            } else {
                if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia)) {
                    string content = trivia.ToString();
                    content = content.Substring(2);
                    CodeBuilder.AppendFormat("--{0}", content);
                    CodeBuilder.AppendLine();
                } else if (trivia.IsKind(SyntaxKind.MultiLineCommentTrivia)) {
                    string content = trivia.ToString();
                    content = content.Substring(2, content.Length - 4);
                    var lines = content.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in lines) {
                        CodeBuilder.AppendFormat("--{0}", line);
                        CodeBuilder.AppendLine();
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
        #endregion

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
            //允许在C#里定义与使用接口，lua里隐式支持任何接口
        }
        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            INamedTypeSymbol sym = m_Model.GetDeclaredSymbol(node);
            ClassInfo ci = new ClassInfo();
            ClassSymbolInfo info;
            m_SymbolTable.ClassSymbols.TryGetValue(ClassInfo.GetFullName(sym), out info);
            ci.Init(sym, info);
            m_ClassInfoStack.Push(ci);

            if (m_ClassInfoStack.Count == 1) {
                ci.BeforeOuterCodeBuilder.Append(m_ToplevelCodeBuilder.ToString());
                m_ToplevelCodeBuilder.Clear();
            }

            ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;

            ++m_Indent;
            foreach (var member in node.Members) {
                VisitEnumMemberDeclaration(member);
            }
            --m_Indent;

            m_ClassInfoStack.Pop();

            if (m_ClassInfoStack.Count <= 0) {
                AddToplevelClass(ci.Key, ci);
            } else {
                m_ClassInfoStack.Peek().InnerClasses.Add(ci.Key, ci);
            }

            if (m_Indent <= 0 && null != m_LastToplevelClass) {
                m_LastToplevelClass.AfterOuterCodeBuilder.Append(m_ToplevelCodeBuilder.ToString());
                m_ToplevelCodeBuilder.Clear();
            }
        }
        public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            IFieldSymbol sym = m_Model.GetDeclaredSymbol(node);
            CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), node.Identifier.Text);
            if (null != node.EqualsValue) {
                CodeBuilder.AppendFormat(" {0} ", node.EqualsValue.EqualsToken.Text);
                VisitExpressionSyntax(node.EqualsValue.Value);
            } else if (sym.HasConstantValue) {
                CodeBuilder.Append(" = ");
                OutputConstValue(sym.ConstantValue);
            } else {
                Log(node, "enum member can't deduce a value !");
                CodeBuilder.Append(" = 0");
            }
            CodeBuilder.AppendLine(",");
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
                string require = ClassInfo.GetAttributeArgument<string>(declSym, "Cs2Lua.RequireAttribute", 0);
                if (!string.IsNullOrEmpty(require)) {
                    m_SymbolTable.AddRequire(ci.Key, require);
                }
                if (ClassInfo.HasAttribute(declSym, "Cs2Lua.IgnoreAttribute"))
                    return;
                if (declSym.IsAbstract)
                    return;
                isExportConstructor = ClassInfo.HasAttribute(declSym, "Cs2Lua.ExportAttribute");
            }

            bool generateBasicCtor = false;
            bool generateBasicCctor = false;
            ClassSymbolInfo csi;
            if (m_SymbolTable.ClassSymbols.TryGetValue(ci.Key, out csi)) {
                generateBasicCtor = csi.GenerateBasicCtor;
                generateBasicCctor = csi.GenerateBasicCctor;
            }

            bool isStatic = declSym.IsStatic;
            var mi = new MethodInfo();
            mi.Init(declSym, m_SymbolTable.AssemblySymbol, node, m_SymbolTable.IsUseExplicitTypeParam(declSym));
            m_MethodInfoStack.Push(mi);

            string manglingName = NameMangling(declSym);
            if (isStatic) {
                ci.ExistStaticConstructor = true;
            } else {
                ci.ExistConstructor = true;

                if (isExportConstructor) {
                    ci.ExportConstructor = manglingName;
                    ci.ExportConstructorInfo = mi;
                } else if (string.IsNullOrEmpty(ci.ExportConstructor)) {
                    //有构造但还没有明确指定的导出构造，则使用第一次遇到的构造
                    ci.ExportConstructor = manglingName;
                    ci.ExportConstructorInfo = mi;
                }
            }

            bool myselfDefinedBaseClass = ci.SemanticInfo.BaseType.ContainingAssembly == m_SymbolTable.AssemblySymbol;

            if (isStatic && mi.UseExplicitTypeParam) {
                Log(node, "typeof/as/is/cast(GenericTypeParameter) or new GenericTypeParameter() can't be used in static constructor or static field initializer !");
            }

            CodeBuilder.AppendFormat("{0}{1} = function({2}", GetIndentString(), manglingName, isStatic ? string.Empty : "this");
            if (mi.ParamNames.Count > 0) {
                if (!isStatic) {
                    CodeBuilder.Append(", ");
                }
                CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
            }
            CodeBuilder.Append(")");
            CodeBuilder.AppendLine();
            ++m_Indent;
            if (mi.ValueParams.Count > 0) {
                OutputWrapValueParams(CodeBuilder, mi);
            }
            if (!string.IsNullOrEmpty(mi.OriginalParamsName)) {
                if (mi.ParamsIsValueType) {
                    CodeBuilder.AppendFormat("{0}local {1} = wrapvaluetypearray{{...}};", GetIndentString(), mi.OriginalParamsName);
                } else if (mi.ParamsIsExternValueType) {
                    CodeBuilder.AppendFormat("{0}local {1} = wrapexternvaluetypearray{{...}};", GetIndentString(), mi.OriginalParamsName);
                } else {
                    CodeBuilder.AppendFormat("{0}local {1} = wraparray{{...}};", GetIndentString(), mi.OriginalParamsName);
                }
                CodeBuilder.AppendLine();
            }
            foreach (string name in mi.OutParamNames) {
                CodeBuilder.AppendFormat("{0}local {1} = nil;", GetIndentString(), name);
                CodeBuilder.AppendLine();
            }
            //首先执行初始化列表
            var init = node.Initializer;
            if (null != init) {
                var oper = m_Model.GetOperation(init) as IInvocationExpression;
                string manglingName2 = NameMangling(oper.TargetMethod);
                if (init.ThisOrBaseKeyword.Text == "this") {
                    CodeBuilder.AppendFormat("{0}this:{1}(", GetIndentString(), manglingName2);
                } else if (init.ThisOrBaseKeyword.Text == "base") {
                    CodeBuilder.AppendFormat("{0}base.{1}(this", GetIndentString(), manglingName2);
                    if (init.ArgumentList.Arguments.Count > 0) {
                        CodeBuilder.Append(", ");
                    }
                }
                VisitArgumentList(init.ArgumentList);
                CodeBuilder.AppendLine(");");
            }
            //再执行构造函数内容（字段初始化部分）
            if (isStatic) {
                if (!string.IsNullOrEmpty(ci.BaseKey) && myselfDefinedBaseClass) {
                    CodeBuilder.AppendFormat("{0}{1}.cctor();", GetIndentString(), ci.BaseKey);
                    CodeBuilder.AppendLine();
                }
                if (generateBasicCctor) {
                    CodeBuilder.AppendFormat("{0}{1}.__cctor();", GetIndentString(), ci.Key);
                    CodeBuilder.AppendLine();
                }
            } else {
                if (!string.IsNullOrEmpty(ci.BaseKey) && !ClassInfo.IsBaseInitializerCalled(node, m_Model) && myselfDefinedBaseClass) {
                    //如果当前构造没有调父类构造并且委托的其它构造也没有调父类构造，则调用默认构造。
                    CodeBuilder.AppendFormat("{0}base.ctor(this);", GetIndentString());
                    CodeBuilder.AppendLine();
                }
                if (generateBasicCtor) {
                    CodeBuilder.AppendFormat("{0}this:__ctor({1});", GetIndentString(), string.Join(", ", mi.GenericTypeTypeParamNames.ToArray()));
                    CodeBuilder.AppendLine();
                }
            }
            //再执行构造函数内容（构造函数部分）
            if (null != node.Body) {
                VisitBlock(node.Body);
            }
            if (mi.ReturnParamNames.Count > 0) {
                CodeBuilder.AppendFormat("{0}return this, {1};", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                CodeBuilder.AppendLine();
            } else if (!isStatic) {
                CodeBuilder.AppendFormat("{0}return this;", GetIndentString());
                CodeBuilder.AppendLine();
            }
            --m_Indent;
            CodeBuilder.AppendFormat("{0}end,", GetIndentString());
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
                string require = ClassInfo.GetAttributeArgument<string>(declSym, "Cs2Lua.RequireAttribute", 0);
                if (!string.IsNullOrEmpty(require)) {
                    m_SymbolTable.AddRequire(ci.Key, require);
                }
                if (ClassInfo.HasAttribute(declSym, "Cs2Lua.IgnoreAttribute"))
                    return;
                if (declSym.IsAbstract)
                    return;
            }

            bool noimpl = true;
            foreach (var accessor in node.AccessorList.Accessors) {
                if (null != accessor.Body) {
                    noimpl = false;
                    break;
                }
            }

            if (noimpl) {
                //退化为field
                StringBuilder curBuilder = ci.CurrentCodeBuilder;

                if (declSym.IsStatic) {
                    ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;
                } else {
                    ci.CurrentCodeBuilder = ci.InstanceFieldCodeBuilder;
                }
                CodeBuilder.AppendFormat("{0}{1} = ", GetIndentString(), node.Identifier.Text);
                if (null != node.Initializer) {
                    VisitExpressionSyntax(node.Initializer.Value);
                    CodeBuilder.Append(",");
                } else {
                    CodeBuilder.Append("true,");
                }
                CodeBuilder.AppendLine();

                ci.CurrentCodeBuilder = curBuilder;
            } else {
                CodeBuilder.AppendFormat("{0}{1} = {{", GetIndentString(), node.Identifier.Text);
                CodeBuilder.AppendLine();
                ++m_Indent;
                foreach (var accessor in node.AccessorList.Accessors) {
                    var sym = m_Model.GetDeclaredSymbol(accessor);
                    if (null != sym) {
                        var mi = new MethodInfo();
                        mi.Init(sym, m_SymbolTable.AssemblySymbol, accessor, m_SymbolTable.IsUseExplicitTypeParam(sym));
                        m_MethodInfoStack.Push(mi);

                        if (mi.SemanticInfo.IsStatic && mi.UseExplicitTypeParam) {
                            Log(node, "typeof/as/is/cast(GenericTypeParameter) or new GenericTypeParameter() can't be used in static property accessor !");
                        }

                        string keyword = accessor.Keyword.Text;
                        CodeBuilder.AppendFormat("{0}{1} = {2}function({3})", GetIndentString(), keyword, mi.ExistYield ? "wrapenumerable(" : string.Empty, keyword == "get" ? "this" : "this, value");
                        CodeBuilder.AppendLine();
                        ++m_Indent;
                        if (null != accessor.Body) {
                            if (mi.ValueParams.Count > 0) {
                                OutputWrapValueParams(CodeBuilder, mi);
                            }
                            VisitBlock(accessor.Body);
                        }
                        --m_Indent;
                        CodeBuilder.AppendFormat("{0}end{1},", GetIndentString(), mi.ExistYield ? ")" : string.Empty);
                        CodeBuilder.AppendLine();

                        m_MethodInfoStack.Pop();
                    }
                }
                --m_Indent;
                CodeBuilder.AppendFormat("{0}", GetIndentString());
                CodeBuilder.AppendLine("},");
            }
        }
        public override void VisitEventDeclaration(EventDeclarationSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            IEventSymbol declSym = m_Model.GetDeclaredSymbol(node);
            if (null != declSym) {
                string require = ClassInfo.GetAttributeArgument<string>(declSym, "Cs2Lua.RequireAttribute", 0);
                if (!string.IsNullOrEmpty(require)) {
                    m_SymbolTable.AddRequire(ci.Key, require);
                }
                if (ClassInfo.HasAttribute(declSym, "Cs2Lua.IgnoreAttribute"))
                    return;
                if (declSym.IsAbstract)
                    return;
            }

            CodeBuilder.AppendFormat("{0}{1} = {{", GetIndentString(), node.Identifier.Text);
            CodeBuilder.AppendLine();
            ++m_Indent;
            foreach (var accessor in node.AccessorList.Accessors) {
                var sym = m_Model.GetDeclaredSymbol(accessor);
                if (null != sym) {
                    var mi = new MethodInfo();
                    mi.Init(sym, m_SymbolTable.AssemblySymbol, accessor, m_SymbolTable.IsUseExplicitTypeParam(sym));
                    m_MethodInfoStack.Push(mi);

                    if (mi.SemanticInfo.IsStatic && mi.UseExplicitTypeParam) {
                        Log(node, "typeof/as/is/cast(GenericTypeParameter) or new GenericTypeParameter() can't be used in static event accessor !");
                    }

                    string keyword = accessor.Keyword.Text;
                    CodeBuilder.AppendFormat("{0}{1} = function({2})", GetIndentString(), keyword, "this, value");
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    if (null != accessor.Body) {
                        VisitBlock(accessor.Body);
                    }
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}end,", GetIndentString());
                    CodeBuilder.AppendLine();

                    m_MethodInfoStack.Pop();
                }
            }
            --m_Indent;
            CodeBuilder.AppendFormat("{0}", GetIndentString());
            CodeBuilder.AppendLine("},");
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
                string require = ClassInfo.GetAttributeArgument<string>(declSym, "Cs2Lua.RequireAttribute", 0);
                if (!string.IsNullOrEmpty(require)) {
                    m_SymbolTable.AddRequire(ci.Key, require);
                }
                if (ClassInfo.HasAttribute(declSym, "Cs2Lua.IgnoreAttribute"))
                    return;
                if (declSym.IsAbstract)
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
                    mi.Init(sym, m_SymbolTable.AssemblySymbol, accessor, m_SymbolTable.IsUseExplicitTypeParam(sym));
                    m_MethodInfoStack.Push(mi);

                    if (mi.SemanticInfo.IsStatic && mi.UseExplicitTypeParam) {
                        Log(node, "typeof/as/is/cast(GenericTypeParameter) or new GenericTypeParameter() can't be used in static indexer accessor !");
                    }

                    string keyword = accessor.Keyword.Text;
                    CodeBuilder.AppendFormat("{0}__indexer_{1} = function(this, {2})", GetIndentString(), keyword, string.Join(", ", mi.ParamNames.ToArray()));
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    if (null != accessor.Body) {
                        if (mi.ValueParams.Count > 0) {
                            OutputWrapValueParams(CodeBuilder, mi);
                        }
                        if (!string.IsNullOrEmpty(mi.OriginalParamsName)) {
                            if (mi.ParamsIsValueType) {
                                CodeBuilder.AppendFormat("{0}local {1} = wrapvaluetypearray{{...}};", GetIndentString(), mi.OriginalParamsName);
                            } else if (mi.ParamsIsExternValueType) {
                                CodeBuilder.AppendFormat("{0}local {1} = wrapexternvaluetypearray{{...}};", GetIndentString(), mi.OriginalParamsName);
                            } else {
                                CodeBuilder.AppendFormat("{0}local {1} = wraparray{{...}};", GetIndentString(), mi.OriginalParamsName);
                            }
                            CodeBuilder.AppendLine();
                        }
                        VisitBlock(accessor.Body);
                    }
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}end,", GetIndentString());
                    CodeBuilder.AppendLine();

                    m_MethodInfoStack.Pop();
                }
            }

            ci.CurrentCodeBuilder = currentBuilder;
        }
        public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
        {
            SymbolInfo symInfo = m_Model.GetSymbolInfo(node);
            var sym = symInfo.Symbol as IMethodSymbol;

            if (null != sym && sym.Parameters.Length == 1) {
                var param = sym.Parameters[0];
                CodeBuilder.AppendFormat("(function({0}) return ", param.Name);
                node.Body.Accept(this);
                CodeBuilder.Append("; end)");
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
                mi.Init(sym, m_SymbolTable.AssemblySymbol, node);
                m_MethodInfoStack.Push(mi);

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
                CodeBuilder.AppendLine(")");
                ++m_Indent;
                node.Body.Accept(this);
                --m_Indent;
                CodeBuilder.AppendFormat("{0}end)", GetIndentString());

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
                mi.Init(sym, m_SymbolTable.AssemblySymbol, node);
                m_MethodInfoStack.Push(mi);

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
                CodeBuilder.AppendLine(")");
                ++m_Indent;
                node.Body.Accept(this);
                --m_Indent;
                CodeBuilder.AppendFormat("{0}end)", GetIndentString());

                m_MethodInfoStack.Pop();
            } else {
                ReportIllegalSymbol(node, symInfo);
            }
        }
        public override void VisitBlock(BlockSyntax node)
        {
            bool isBlock = node.Parent is BlockSyntax;
            if (isBlock) {
                CodeBuilder.AppendFormat("{0}do", GetIndentString());
                CodeBuilder.AppendLine();
                ++m_Indent;
            }
            base.VisitBlock(node);
            if (isBlock) {
                --m_Indent;
                CodeBuilder.AppendFormat("{0}end;", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitUsingStatement(UsingStatementSyntax node)
        {
            VisitVariableDeclaration(node.Declaration);
            node.Statement.Accept(this);

            foreach (var decl in node.Declaration.Variables) {
                CodeBuilder.AppendFormat("{0}{1}:Dispose();", GetIndentString(), decl.Identifier.Text);
                CodeBuilder.AppendLine();
            }
        }
        #endregion

        #region 表达式
        public override void VisitExpressionStatement(ExpressionStatementSyntax node)
        {
            CodeBuilder.Append(GetIndentString());

            VisitToplevelExpression(node.Expression, ";");
        }
        public override void VisitLiteralExpression(LiteralExpressionSyntax node)
        {
            CodeBuilder.Append(node.Token.Text);
        }
        public override void VisitBinaryExpression(BinaryExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            var oper = m_Model.GetOperation(node) as IHasOperatorMethodExpression;

            if (null != oper && oper.UsesOperatorMethod) {
                IMethodSymbol msym = oper.OperatorMethod;
                var castOper = oper as IConversionExpression;
                if (null != castOper) {
                    InvocationInfo ii = new InvocationInfo();
                    var arglist = new List<ExpressionSyntax>() { node.Left };
                    ii.Init(msym, m_SymbolTable.AssemblySymbol, arglist, m_SymbolTable.IsUseExplicitTypeParam(msym), m_Model);
                    OutputOperatorInvoke(ii);
                } else {
                    InvocationInfo ii = new InvocationInfo();
                    var arglist = new List<ExpressionSyntax>() { node.Left, node.Right };
                    ii.Init(msym, m_SymbolTable.AssemblySymbol, arglist, m_SymbolTable.IsUseExplicitTypeParam(msym), m_Model);
                    OutputOperatorInvoke(ii);
                }
            } else {
                string op = node.OperatorToken.Text;
                ProcessBinaryOperator(node, ref op);
                string functor;
                if (s_BinaryFunctor.TryGetValue(op, out functor)) {
                    CodeBuilder.AppendFormat("{0}(", functor);
                    VisitExpressionSyntax(node.Left);
                    CodeBuilder.Append(", ");
                    if (op == "as" || op == "is") {
                        var typeInfo = m_Model.GetTypeInfo(node.Right);
                        var type = typeInfo.Type;
                        OutputType(type, node, ci, op);
                    } else {
                        VisitExpressionSyntax(node.Right);
                    }
                    CodeBuilder.Append(")");
                } else {
                    CodeBuilder.Append("(");
                    VisitExpressionSyntax(node.Left);
                    CodeBuilder.AppendFormat(" {0} ", op);
                    VisitExpressionSyntax(node.Right);
                    CodeBuilder.Append(")");
                }
            }
        }
        public override void VisitConditionalExpression(ConditionalExpressionSyntax node)
        {
            CodeBuilder.Append("condexp(");
            VisitExpressionSyntax(node.Condition);
            CodeBuilder.Append(", ");
            VisitExpressionSyntax(node.WhenTrue);
            CodeBuilder.Append(", ");
            VisitExpressionSyntax(node.WhenFalse);
            CodeBuilder.Append(")");
        }
        public override void VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
        {
            CodeBuilder.Append("condaccess(");
            VisitExpressionSyntax(node.Expression);
            CodeBuilder.Append(", ");
            var elementBinding = node.WhenNotNull as ElementBindingExpressionSyntax;
            if (null != elementBinding) {
                var oper = m_Model.GetOperation(node.WhenNotNull);
                var symInfo = m_Model.GetSymbolInfo(node.WhenNotNull);
                var sym = symInfo.Symbol as IPropertySymbol;

                if (null != sym && sym.IsIndexer) {
                    if (sym.ContainingAssembly == m_SymbolTable.AssemblySymbol) {
                        VisitExpressionSyntax(node.Expression);
                        if (sym.IsStatic)
                            CodeBuilder.Append(".__indexer_get(");
                        else
                            CodeBuilder.Append(":__indexer_get(");
                        VisitExpressionSyntax(node.WhenNotNull);
                        CodeBuilder.Append(")");
                    } else {
                        CodeBuilder.AppendFormat("getextern{0}indexer(", sym.IsStatic ? "static" : "instance");
                        if (sym.IsStatic) {
                            string fullName = ClassInfo.GetFullName(sym.ContainingType);
                            CodeBuilder.Append(fullName);
                        } else {
                            VisitExpressionSyntax(node.Expression);
                        }
                        CodeBuilder.Append(", ");
                        VisitExpressionSyntax(node.WhenNotNull);
                        CodeBuilder.Append(")");
                    }
                } else if (oper.Kind == OperationKind.ArrayElementReferenceExpression) {
                    VisitExpressionSyntax(node.Expression);
                    CodeBuilder.Append("[");
                    VisitExpressionSyntax(node.WhenNotNull);
                    CodeBuilder.Append("]");
                } else {
                    CodeBuilder.AppendFormat("get{0}element(", sym.ContainingAssembly == m_SymbolTable.AssemblySymbol ? string.Empty : "extern");
                    VisitExpressionSyntax(node.Expression);
                    CodeBuilder.Append(", ");
                    VisitExpressionSyntax(node.WhenNotNull);
                    CodeBuilder.Append(")");
                }
            } else {
                VisitExpressionSyntax(node.Expression);
                VisitExpressionSyntax(node.WhenNotNull);
            }
            CodeBuilder.Append(")");
        }
        public override void VisitThisExpression(ThisExpressionSyntax node)
        {
            CodeBuilder.Append("this");
        }
        public override void VisitBaseExpression(BaseExpressionSyntax node)
        {
            CodeBuilder.Append("base");
        }
        public override void VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
        {
            CodeBuilder.Append("( ");
            VisitExpressionSyntax(node.Expression);
            CodeBuilder.Append(" )");
        }
        public override void VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
        {
            var oper = m_Model.GetOperation(node) as IHasOperatorMethodExpression;
            if (null != oper && oper.UsesOperatorMethod) {
                IMethodSymbol msym = oper.OperatorMethod;
                InvocationInfo ii = new InvocationInfo();
                var arglist = new List<ExpressionSyntax>() { node.Operand };
                ii.Init(msym, m_SymbolTable.AssemblySymbol, arglist, m_SymbolTable.IsUseExplicitTypeParam(msym), m_Model);
                OutputOperatorInvoke(ii);
            } else {
                string op = node.OperatorToken.Text;
                if (op == "++" || op == "--") {
                    CodeBuilder.Append("(function() ");
                    VisitExpressionSyntax(node.Operand);
                    CodeBuilder.Append(" = ");
                    VisitExpressionSyntax(node.Operand);
                    CodeBuilder.Append(" ");
                    CodeBuilder.Append(op == "++" ? "+" : "-");
                    CodeBuilder.Append(" 1; return ");
                    VisitExpressionSyntax(node.Operand);
                    CodeBuilder.Append("; end)()");
                } else {
                    ProcessUnaryOperator(node, ref op);
                    CodeBuilder.Append("(");
                    CodeBuilder.Append(op);
                    CodeBuilder.Append(" ");
                    VisitExpressionSyntax(node.Operand);
                    CodeBuilder.Append(")");
                }
            }
        }
        public override void VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
        {
            var oper = m_Model.GetOperation(node) as IHasOperatorMethodExpression;
            if (null != oper && oper.UsesOperatorMethod) {
                IMethodSymbol msym = oper.OperatorMethod;
                InvocationInfo ii = new InvocationInfo();
                var arglist = new List<ExpressionSyntax>() { node.Operand };
                ii.Init(msym, m_SymbolTable.AssemblySymbol, arglist, m_SymbolTable.IsUseExplicitTypeParam(msym), m_Model);
                OutputOperatorInvoke(ii);
            } else {
                string op = node.OperatorToken.Text;
                if (op == "++" || op == "--") {
                    VisitExpressionSyntax(node.Operand);
                    m_PostfixUnaryExpressions.Enqueue(node);
                } else {
                    CodeBuilder.Append("(");
                    CodeBuilder.Append(op);
                    CodeBuilder.Append(" ");
                    VisitExpressionSyntax(node.Operand);
                    CodeBuilder.Append(")");
                }
            }
        }
        public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();

            var oper = m_Model.GetOperation(node) as ITypeOfExpression;
            var type = oper.TypeOperand;
            OutputType(type, node, ci, "typeof");
        }
        public override void VisitCastExpression(CastExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            var oper = m_Model.GetOperation(node) as IConversionExpression;

            if (null != oper && oper.UsesOperatorMethod) {
                IMethodSymbol msym = oper.OperatorMethod;
                InvocationInfo ii = new InvocationInfo();
                var arglist = new List<ExpressionSyntax>() { node.Expression };
                ii.Init(msym, m_SymbolTable.AssemblySymbol, arglist, m_SymbolTable.IsUseExplicitTypeParam(msym), m_Model);
                OutputOperatorInvoke(ii);
            } else {
                CodeBuilder.Append("typecast(");
                VisitExpressionSyntax(node.Expression);
                var typeInfo = m_Model.GetTypeInfo(node.Type);
                var type = typeInfo.Type;
                CodeBuilder.Append(", ");
                OutputType(type, node, ci, "cast");
                CodeBuilder.Append(")");
            }
        }
        public override void VisitDefaultExpression(DefaultExpressionSyntax node)
        {
            CodeBuilder.Append("nil");
        }
        #endregion

        #region 语句
        public override void VisitEmptyStatement(EmptyStatementSyntax node)
        { }
        public override void VisitBreakStatement(BreakStatementSyntax node)
        {
            if (m_ContinueInfoStack.Count > 0) {
                var ci = m_ContinueInfoStack.Peek();
                if (ci.IsIgnoreBreak)
                    return;
                if (ci.HaveContinue) {
                    CodeBuilder.AppendFormat("{0}{1} = true;", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}break;", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitContinueStatement(ContinueStatementSyntax node)
        {
            if (m_ContinueInfoStack.Count > 0) {
                var ci = m_ContinueInfoStack.Peek();
                if (ci.IsIgnoreBreak)
                    return;
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}{1} = false;", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}break;", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitReturnStatement(ReturnStatementSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            mi.ExistReturn = true;

            bool isLastNode = IsLastNodeOfParent(node);
            if (!isLastNode) {
                CodeBuilder.AppendFormat("{0}do", GetIndentString());
                CodeBuilder.AppendLine();
            }

            CodeBuilder.AppendFormat("{0}return ", GetIndentString());
            string prestr = "";
            if (null != node.Expression) {
                VisitExpressionSyntax(node.Expression);
                prestr = ", ";
            }
            var names = mi.ReturnParamNames;
            if (names.Count > 0) {
                for (int i = 0; i < names.Count; ++i) {
                    CodeBuilder.Append(prestr);
                    CodeBuilder.Append(names[i]);
                    prestr = ", ";
                }
            }
            CodeBuilder.AppendLine(";");

            if (!isLastNode) {
                CodeBuilder.AppendFormat("{0}end;", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitWhileStatement(WhileStatementSyntax node)
        {
            ContinueInfo ci = new ContinueInfo();
            ci.Init(node.Statement);
            m_ContinueInfoStack.Push(ci);

            CodeBuilder.AppendFormat("{0}while ", GetIndentString());
            VisitExpressionSyntax(node.Condition);
            CodeBuilder.AppendLine(" do");
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}local {1} = false", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}repeat", GetIndentString());
                CodeBuilder.AppendLine();
            }
            ++m_Indent;
            node.Statement.Accept(this);
            --m_Indent;
            if (ci.HaveContinue) {
                CodeBuilder.AppendFormat("{0}until true;", GetIndentString());
                CodeBuilder.AppendLine();
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}if {1} then break; end;", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
            }
            CodeBuilder.AppendFormat("{0}end;", GetIndentString());
            CodeBuilder.AppendLine();

            m_ContinueInfoStack.Pop();
        }
        public override void VisitDoStatement(DoStatementSyntax node)
        {
            ContinueInfo ci = new ContinueInfo();
            ci.Init(node.Statement);
            m_ContinueInfoStack.Push(ci);

            CodeBuilder.AppendFormat("{0}repeat", GetIndentString());
            CodeBuilder.AppendLine();
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}local {1} = false", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}repeat", GetIndentString());
                CodeBuilder.AppendLine();
            }
            ++m_Indent;
            node.Statement.Accept(this);
            --m_Indent;
            if (ci.HaveContinue) {
                CodeBuilder.AppendFormat("{0}until true;", GetIndentString());
                CodeBuilder.AppendLine();
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}if {1} then break; end;", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
            }
            CodeBuilder.AppendFormat("{0}until not (", GetIndentString());
            VisitExpressionSyntax(node.Condition);
            CodeBuilder.AppendLine(");");

            m_ContinueInfoStack.Pop();
        }
        public override void VisitForStatement(ForStatementSyntax node)
        {
            ContinueInfo ci = new ContinueInfo();
            ci.Init(node.Statement);
            m_ContinueInfoStack.Push(ci);

            if (null != node.Declaration)
                VisitVariableDeclaration(node.Declaration);
            CodeBuilder.AppendFormat("{0}while ", GetIndentString());
            if(null!=node.Condition)
                VisitExpressionSyntax(node.Condition);
            else
                CodeBuilder.AppendLine("true");
            CodeBuilder.AppendLine(" do");
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}local {1} = false", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}repeat", GetIndentString());
                CodeBuilder.AppendLine();
            }
            ++m_Indent;
            node.Statement.Accept(this);
            foreach (var exp in node.Incrementors) {
                CodeBuilder.AppendFormat("{0}", GetIndentString());
                VisitToplevelExpression(exp, ";");
            }
            --m_Indent;
            if (ci.HaveContinue) {
                CodeBuilder.AppendFormat("{0}until true;", GetIndentString());
                CodeBuilder.AppendLine();
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}if {1} then break; end;", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
            }
            CodeBuilder.AppendFormat("{0}end;", GetIndentString());
            CodeBuilder.AppendLine();

            m_ContinueInfoStack.Pop();
        }
        public override void VisitForEachStatement(ForEachStatementSyntax node)
        {
            ContinueInfo ci = new ContinueInfo();
            ci.Init(node.Statement);
            m_ContinueInfoStack.Push(ci);

            string varName = string.Format("__compiler_foreach_{0}", node.GetLocation().GetLineSpan().StartLinePosition.Line);
            CodeBuilder.AppendFormat("{0}local {1} = (", GetIndentString(), varName);
            VisitExpressionSyntax(node.Expression);
            CodeBuilder.AppendLine("):GetEnumerator();");
            CodeBuilder.AppendFormat("{0}while {1}:MoveNext() do", GetIndentString(), varName);
            CodeBuilder.AppendLine();
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}local {1} = false", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}repeat", GetIndentString());
                CodeBuilder.AppendLine();
            }
            ++m_Indent;
            CodeBuilder.AppendFormat("{0}{1} = {2}.Current;", GetIndentString(), node.Identifier.Text, varName);
            CodeBuilder.AppendLine();
            node.Statement.Accept(this);
            --m_Indent;
            if (ci.HaveContinue) {
                CodeBuilder.AppendFormat("{0}until true;", GetIndentString());
                CodeBuilder.AppendLine();
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}if {1} then break; end;", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
            }
            CodeBuilder.AppendFormat("{0}end;", GetIndentString());
            CodeBuilder.AppendLine();

            m_ContinueInfoStack.Pop();
        }
        public override void VisitIfStatement(IfStatementSyntax node)
        {
            CodeBuilder.AppendFormat("{0}if ", GetIndentString());
            VisitExpressionSyntax(node.Condition);
            CodeBuilder.AppendLine(" then");
            ++m_Indent;
            node.Statement.Accept(this);
            --m_Indent;
            if (null != node.Else) {
                VisitElseClause(node.Else);
            } else {
                CodeBuilder.AppendFormat("{0}end;", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitElseClause(ElseClauseSyntax node)
        {
            IfStatementSyntax ifNode = node.Statement as IfStatementSyntax;
            if (null != ifNode) {
                CodeBuilder.AppendFormat("{0}elseif ", GetIndentString());
                VisitExpressionSyntax(ifNode.Condition);
                CodeBuilder.AppendLine(" then");
                ++m_Indent;
                ifNode.Statement.Accept(this);
                --m_Indent;
                if (null != ifNode.Else) {
                    VisitElseClause(ifNode.Else);
                } else {
                    CodeBuilder.AppendFormat("{0}end;", GetIndentString());
                    CodeBuilder.AppendLine();
                }
            } else {
                CodeBuilder.AppendFormat("{0}else", GetIndentString());
                CodeBuilder.AppendLine();
                ++m_Indent;
                node.Statement.Accept(this);
                --m_Indent;
                CodeBuilder.AppendFormat("{0}end;", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitSwitchStatement(SwitchStatementSyntax node)
        {
            string varName = string.Format("__compiler_switch_{0}", node.GetLocation().GetLineSpan().StartLinePosition.Line);
            SwitchInfo si = new SwitchInfo();
            si.SwitchVarName = varName;
            m_SwitchInfoStack.Push(si);

            CodeBuilder.AppendFormat("{0}local {1} = ", GetIndentString(), varName);
            VisitExpressionSyntax(node.Expression);
            CodeBuilder.AppendLine(";");

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

                CodeBuilder.AppendFormat("{0}{1} ", GetIndentString(), i == 0 ? "if" : "elseif");
                int lct = section.Labels.Count;
                for (int j = 0; j < lct; ++j) {
                    var label = section.Labels[j] as CaseSwitchLabelSyntax;
                    if (null != label) {
                        if (lct > 1) {
                            CodeBuilder.Append("(");
                        }
                        CodeBuilder.AppendFormat("{0} == ", varName);
                        VisitExpressionSyntax(label.Value);
                        if (lct > 1) {
                            CodeBuilder.Append(")");
                            if (j < lct - 1) {
                                CodeBuilder.Append(" and ");
                            }
                        }
                    }
                }
                CodeBuilder.AppendLine(" then");
                if (ba.BreakCount > 1) {
                    CodeBuilder.AppendFormat("{0}repeat", GetIndentString());
                    CodeBuilder.AppendLine();
                }
                ++m_Indent;

                int sct = section.Statements.Count;
                for (int j = 0; j < sct; ++j) {
                    var statement = section.Statements[j];
                    statement.Accept(this);
                }

                --m_Indent;
                if (ba.BreakCount > 1) {
                    CodeBuilder.AppendFormat("{0}until 0 ~= 0;", GetIndentString());
                    CodeBuilder.AppendLine();
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
                CodeBuilder.AppendFormat("{0}else", GetIndentString());
                CodeBuilder.AppendLine();
                if (ba.BreakCount > 1) {
                    CodeBuilder.AppendFormat("{0}repeat", GetIndentString());
                    CodeBuilder.AppendLine();
                }
                ++m_Indent;

                int sct = defaultSection.Statements.Count;
                for (int j = 0; j < sct; ++j) {
                    var statement = defaultSection.Statements[j];
                    statement.Accept(this);
                }

                --m_Indent;
                if (ba.BreakCount > 1) {
                    CodeBuilder.AppendFormat("{0}until 0 ~= 0;", GetIndentString());
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}end;", GetIndentString());
                CodeBuilder.AppendLine();

                m_ContinueInfoStack.Pop();
            } else {
                CodeBuilder.AppendFormat("{0}end;", GetIndentString());
                CodeBuilder.AppendLine();
            }

            m_SwitchInfoStack.Pop();
        }
        public override void VisitUnsafeStatement(UnsafeStatementSyntax node)
        {
            //Log(node, "Unsupported Syntax, ignore it !");
            //忽略
            if (null != node.Block) {
                CodeBuilder.AppendFormat("{0}do", GetIndentString());
                CodeBuilder.AppendLine();
                ++m_Indent;
                VisitBlock(node.Block);
                --m_Indent;
                CodeBuilder.AppendFormat("{0}end;", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitLockStatement(LockStatementSyntax node)
        {
            //Log(node, "Unsupported Syntax, ignore it !");
            //忽略
            if (null != node.Statement) {
                CodeBuilder.AppendFormat("{0}do", GetIndentString());
                CodeBuilder.AppendLine();
                ++m_Indent;
                node.Statement.Accept(this);
                --m_Indent;
                CodeBuilder.AppendFormat("{0}end;", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitYieldStatement(YieldStatementSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            mi.ExistReturn = true;
            mi.ExistYield = true;

            if (node.ReturnOrBreakKeyword.Text == "return") {
                CodeBuilder.AppendFormat("{0}wrapyield(", GetIndentString());
                if (null != node.Expression) {
                    var oper = m_Model.GetOperation(node.Expression);
                    var type = oper.Type;
                    VisitExpressionSyntax(node.Expression);
                    if (null != type && (IsImplementationOfSys(type, "IEnumerable") || IsImplementationOfSys(type, "IEnumerator"))) {
                        CodeBuilder.Append(", true");
                    } else {
                        CodeBuilder.Append(", false");
                    }
                    if (null != type && IsSubclassOf(type, "UnityEngine.YieldInstruction")) {
                        CodeBuilder.Append(", true");
                    } else {
                        CodeBuilder.Append(", false");
                    }
                } else {
                    CodeBuilder.Append("nil, false, false");
                }
                CodeBuilder.Append(");");
                CodeBuilder.AppendLine();
            } else {
                bool isLastNode = IsLastNodeOfParent(node);
                if (!isLastNode) {
                    CodeBuilder.AppendFormat("{0}do", GetIndentString());
                    CodeBuilder.AppendLine();
                }

                CodeBuilder.AppendFormat("{0}return nil;", GetIndentString());
                CodeBuilder.AppendLine();

                if (!isLastNode) {
                    CodeBuilder.AppendFormat("{0}end;", GetIndentString());
                    CodeBuilder.AppendLine();
                }
            }
        }
        #endregion

        #region 异常处理

        public override void VisitThrowStatement(ThrowStatementSyntax node)
        {
            //忽略
        }
        public override void VisitTryStatement(TryStatementSyntax node)
        {
            if (null != node.Block) {
                CodeBuilder.AppendFormat("{0}do", GetIndentString());
                CodeBuilder.AppendLine();
                ++m_Indent;
                VisitBlock(node.Block);
                --m_Indent;
                CodeBuilder.AppendFormat("{0}end;", GetIndentString());
                CodeBuilder.AppendLine();
            }
            foreach (var clause in node.Catches) {
                VisitCatchClause(clause);
            }
            if (null != node.Finally) {
                VisitFinallyClause(node.Finally);
            }
        }
        public override void VisitCatchClause(CatchClauseSyntax node)
        {
            if (null != node.Declaration) {
                VisitCatchDeclaration(node.Declaration);
            }
            if (null != node.Filter) {
                VisitCatchFilterClause(node.Filter);
            }
            //忽略
            //VisitBlock(node.Block);
        }
        public override void VisitCatchDeclaration(CatchDeclarationSyntax node)
        {
            //忽略
        }
        public override void VisitCatchFilterClause(CatchFilterClauseSyntax node)
        {
            //忽略
        }
        public override void VisitFinallyClause(FinallyClauseSyntax node)
        {
            CodeBuilder.AppendFormat("{0}do", GetIndentString());
            CodeBuilder.AppendLine();
            ++m_Indent;
            VisitBlock(node.Block);
            --m_Indent;
            CodeBuilder.AppendFormat("{0}end;", GetIndentString());
            CodeBuilder.AppendLine();
        }
        #endregion

        public void SaveLog(TextWriter writer)
        {
            Logger.Instance.SaveLog(writer);
        }
        public void SaveLog(string path)
        {
            Logger.Instance.SaveLog(path);
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
        private string NameMangling(IMethodSymbol sym)
        {
            return m_SymbolTable.NameMangling(sym);
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
        private void OutputArgumentList(IList<ExpressionSyntax> args, IList<ITypeSymbol> typeArgs, bool arrayToParams)
        {
            if (typeArgs.Count > 0) {
                OutputTypeArgumentList(typeArgs);
            }
            if (args.Count > 0) {
                if (typeArgs.Count > 0)
                    CodeBuilder.Append(", ");
                OutputExpressionList(args, arrayToParams);
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
                //表达式对象为空表明这个是一个slua的out实参，替换为Slua.out，这里为了容错，将非Slua情形为空换为lua的空
                if (null == exp) {
                    if (SymbolTable.ForSlua) {
                        CodeBuilder.Append("Slua.out");
                    } else {
                        CodeBuilder.Append("nil");
                    }
                } else if (i < ct - 1) {
                    VisitExpressionSyntax(exp);
                } else {
                    if (arrayToParams) {
                        CodeBuilder.Append("arraytoparams(");
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
        private void OutputTypeArgumentList(IList<ITypeSymbol> typeArgs)
        {
            int ct = typeArgs.Count;
            for (int i = 0; i < ct; ++i) {
                var type = typeArgs[i];
                string typeName = ClassInfo.GetFullName(type);
                CodeBuilder.Append(typeName);
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
        private void OutputConstValue(object val)
        {
            string v = val as string;
            if (null != v) {
                CodeBuilder.AppendFormat("wrapstring(\"{0}\")", Escape(v));
            } else if (val is bool) {
                CodeBuilder.Append((bool)val ? "true" : "false");
            } else if (val is char) {
                CodeBuilder.AppendFormat("wrapstring('{0}')", Escape((char)val));
            } else if (null == val) {
                CodeBuilder.Append("nil");
            } else {
                CodeBuilder.Append(val);
            }
        }
        private void OutputType(ITypeSymbol type, SyntaxNode node, ClassInfo ci, string errorTag)
        {
            if (null != type && type.TypeKind != TypeKind.Error) {
                if (type.TypeKind == TypeKind.TypeParameter) {
                    var typeParam = type as ITypeParameterSymbol;
                    if (typeParam.TypeParameterKind == TypeParameterKind.Type) {
                        IMethodSymbol sym = FindClassMethodDeclaredSymbol(node);
                        if (null != sym) {
                            if (sym.IsStatic || sym.MethodKind==MethodKind.Constructor) {
                                //静态函数与构造函数泛型参数直接作函数参数，不用读数据成员
                                CodeBuilder.Append(type.Name);
                            } else if (null != ci.ClassSemanticInfo) {
                                //普通函数泛型参数不作函数参数，读数据成员获取信息
                                int ix = ci.ClassSemanticInfo.GenericTypeParamNames.IndexOf(type.Name);
                                CodeBuilder.AppendFormat("this.__type_params[{0}]", ix + 1);
                            } else {
                                Log(node, "class {0} ClassSemanticInfo == null !", ci.Key);
                            }
                        } else {
                            ISymbol varSym = FindVariableDeclaredSymbol(node);
                            if (null != varSym) {
                                //数据成员初始化里使用type参数的，初始化代码合并到构造里面，所以不需要借助数据成员取泛型参数
                                CodeBuilder.Append(type.Name);
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
                        ci.AddReference(namedType, ci.SemanticInfo);
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
        private void OutputOperatorInvoke(InvocationInfo ii)
        {
            if (ii.MethodSymbol.ContainingAssembly == m_SymbolTable.AssemblySymbol) {
                CodeBuilder.AppendFormat("{0}.", ii.ClassKey);
                string manglingName = NameMangling(ii.MethodSymbol);
                CodeBuilder.Append(manglingName);
                CodeBuilder.Append("(");
                OutputArgumentList(ii.Args, ii.GenericTypeArgs, ii.ArrayToParams);
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
                    CodeBuilder.AppendFormat("invokeexternoperator({0}, ", ii.ClassKey);
                    CodeBuilder.AppendFormat("\"{0}\"", method);
                    CodeBuilder.Append(", ");
                    OutputArgumentList(ii.Args, ii.GenericTypeArgs, ii.ArrayToParams);
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

        #region 符号相关的处理
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

            if (null != node.Initializer) {
                CodeBuilder.AppendFormat("{0}local {1}; {2}", GetIndentString(), node.Identifier.Text, node.Identifier.Text);
            } else {
                CodeBuilder.AppendFormat("{0}local {1}", GetIndentString(), node.Identifier.Text);
            }
            if (null != localSym && localSym.HasConstantValue) {
                CodeBuilder.Append(" = ");
                OutputConstValue(localSym.ConstantValue);
                CodeBuilder.AppendLine(";");
                return;
            }
            VisitLocalVariableDeclarator(ci, node);
            if (null != node.Initializer) {
                var oper = m_Model.GetOperation(node.Initializer.Value);
                if (null != oper && null != oper.Type && oper.Type.IsValueType && oper.Type.ContainingAssembly == m_SymbolTable.AssemblySymbol) {
                    CodeBuilder.AppendFormat("{0}{1} = wrapvaluetype({2});", GetIndentString(), node.Identifier.Text, node.Identifier.Text);
                    CodeBuilder.AppendLine();
                }
            }
        }
        public override void VisitArgumentList(ArgumentListSyntax node)
        {
            OutputArgumentList(node.Arguments, ", ", null);
        }
        public override void VisitBracketedArgumentList(BracketedArgumentListSyntax node)
        {
            var oper = m_Model.GetOperation(node);
            if (oper.Kind == OperationKind.IndexedPropertyReferenceExpression) {
                OutputArgumentList(node.Arguments, ", ", oper);
            } else {
                OutputArgumentList(node.Arguments, "][", oper);
            }
        }
        public override void VisitArgument(ArgumentSyntax node)
        {
            VisitExpressionSyntax(node.Expression);
        }
        public override void VisitAssignmentExpression(AssignmentExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();

            string op = node.OperatorToken.Text;
            string baseOp = op.Substring(0, op.Length - 1);

            bool needWrapFunction = true;
            var leftOper = m_Model.GetOperation(node.Left);
            var leftSymbolInfo = m_Model.GetSymbolInfo(node.Left);
            var leftSym = leftSymbolInfo.Symbol;
            var leftElementAccess = node.Left as ElementAccessExpressionSyntax;
            var leftCondAccess = node.Left as ConditionalAccessExpressionSyntax;
            if (null != leftElementAccess || null != leftCondAccess || leftOper.Type.TypeKind == TypeKind.Delegate && (leftSym.Kind != SymbolKind.Local || op != "=")) {
                needWrapFunction = false;
            }
            if (needWrapFunction) {
                //顶层的赋值语句已经处理，这里的赋值都需要包装成lambda函数的样式
                CodeBuilder.Append("(function() ");
            }
            VisitAssignment(ci, op, baseOp, node, string.Empty, false, leftOper, leftSym, leftElementAccess, leftCondAccess);
            var oper = m_Model.GetOperation(node.Right);
            if (null != leftSym && leftSym.Kind == SymbolKind.Local && null != oper && null != oper.Type && oper.Type.IsValueType && oper.Type.ContainingAssembly == m_SymbolTable.AssemblySymbol) {
                CodeBuilder.AppendFormat("; {0} = wrapvaluetype({1})", leftSym.Name, leftSym.Name);
            }
            if (needWrapFunction) {
                CodeBuilder.Append("; return ");
                VisitExpressionSyntax(node.Left);
                CodeBuilder.Append("; end)()");
            }
        }
        public override void VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            VisitInvocation(ci, node, string.Empty, false);
        }
        public override void VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
        {
            SymbolInfo symInfo = m_Model.GetSymbolInfo(node);
            var sym = symInfo.Symbol;

            string className = string.Empty;
            if (null != sym && sym.IsStatic && null != sym.ContainingType) {
                className = ClassInfo.GetFullName(sym.ContainingType);
            }

            if (null != sym) {
                var ci = m_ClassInfoStack.Peek();
                ci.AddReference(sym, ci.SemanticInfo);
            } else {
                ReportIllegalSymbol(node, symInfo);
            }
            if (node.Parent is InvocationExpressionSyntax) {
                var msym = sym as IMethodSymbol;
                string manglingName = NameMangling(msym);
                if (string.IsNullOrEmpty(className)) {
                    VisitExpressionSyntax(node.Expression);
                    CodeBuilder.Append(":");
                } else {
                    CodeBuilder.Append(className);
                    CodeBuilder.Append(".");
                }
                CodeBuilder.Append(manglingName);
            } else {
                var msym = sym as IMethodSymbol;
                if (null != msym) {
                    string manglingName = NameMangling(msym);
                    var mi = new MethodInfo();
                    mi.Init(msym, m_SymbolTable.AssemblySymbol, node);

                    CodeBuilder.Append("(function(");
                    string paramsString = string.Join(", ", mi.ParamNames.ToArray());
                    CodeBuilder.Append(paramsString);
                    CodeBuilder.Append(") ");
                    if (!msym.ReturnsVoid) {
                        CodeBuilder.Append("return ");
                    }
                    if (string.IsNullOrEmpty(className)) {
                        VisitExpressionSyntax(node.Expression);
                        CodeBuilder.Append(":");
                    } else {
                        CodeBuilder.Append(className);
                        CodeBuilder.Append(".");
                    }
                    CodeBuilder.Append(manglingName);
                    CodeBuilder.AppendFormat("({0}) end)", paramsString);
                } else {
                    if (string.IsNullOrEmpty(className)) {
                        VisitExpressionSyntax(node.Expression);
                    } else {
                        CodeBuilder.Append(className);
                    }
                    CodeBuilder.Append(node.OperatorToken.Text);
                    CodeBuilder.Append(node.Name.Identifier.Text);
                }
            }
        }
        public override void VisitElementAccessExpression(ElementAccessExpressionSyntax node)
        {
            var oper = m_Model.GetOperation(node);
            var symInfo = m_Model.GetSymbolInfo(node);
            var sym = symInfo.Symbol as IPropertySymbol;

            if (null != sym && sym.IsIndexer) {
                if (sym.ContainingAssembly == m_SymbolTable.AssemblySymbol) {
                    VisitExpressionSyntax(node.Expression);
                    if (sym.IsStatic)
                        CodeBuilder.Append(".__indexer_get(");
                    else
                        CodeBuilder.Append(":__indexer_get(");
                    VisitBracketedArgumentList(node.ArgumentList);
                    CodeBuilder.Append(")");
                } else {
                    CodeBuilder.AppendFormat("getextern{0}indexer(", sym.IsStatic ? "static" : "instance");
                    if (sym.IsStatic) {
                        string fullName = ClassInfo.GetFullName(sym.ContainingType);
                        CodeBuilder.Append(fullName);
                    } else {
                        VisitExpressionSyntax(node.Expression);
                    }
                    CodeBuilder.Append(", ");
                    VisitBracketedArgumentList(node.ArgumentList);
                    CodeBuilder.Append(")");
                }
            } else if (oper.Kind == OperationKind.ArrayElementReferenceExpression) {
                VisitExpressionSyntax(node.Expression);
                CodeBuilder.Append("[");
                VisitBracketedArgumentList(node.ArgumentList);
                CodeBuilder.Append("]");
            } else {
                CodeBuilder.AppendFormat("get{0}element(", sym.ContainingAssembly == m_SymbolTable.AssemblySymbol ? string.Empty : "extern");
                VisitExpressionSyntax(node.Expression);
                CodeBuilder.Append(", ");
                VisitBracketedArgumentList(node.ArgumentList);
                CodeBuilder.Append(")");
            }
        }
        public override void VisitMemberBindingExpression(MemberBindingExpressionSyntax node)
        {
            var symInfo = m_Model.GetSymbolInfo(node.Name);
            var sym = symInfo.Symbol;
            var msym = sym as IMethodSymbol;
            if (null != msym) {
                string manglingName = NameMangling(msym);
                if (sym.IsStatic) {
                    CodeBuilder.AppendFormat(".{0}", manglingName);
                } else {
                    CodeBuilder.AppendFormat(":{0}", manglingName);
                }
            } else {
                CodeBuilder.AppendFormat("{0}{1}", node.OperatorToken.Text, node.Name.Identifier.Text);
            }
        }
        public override void VisitElementBindingExpression(ElementBindingExpressionSyntax node)
        {
            VisitBracketedArgumentList(node.ArgumentList);
        }
        public override void VisitInitializerExpression(InitializerExpressionSyntax node)
        {
            var oper = m_Model.GetOperation(node);
            if (null != oper) {
                bool isCollection = node.IsKind(SyntaxKind.CollectionInitializerExpression);
                bool isObjectInitializer = node.IsKind(SyntaxKind.ObjectInitializerExpression);
                bool isArray = node.IsKind(SyntaxKind.ArrayInitializerExpression);
                bool isComplex = node.IsKind(SyntaxKind.ComplexElementInitializerExpression);
                if (isCollection) {
                    if (null != oper.Type) {
                        bool isDictionary = IsImplementationOfSys(oper.Type, "IDictionary");
                        bool isList = IsImplementationOfSys(oper.Type, "IList");
                        if (isDictionary) {
                            CodeBuilder.Append("{");
                            var args = node.Expressions;
                            int ct = args.Count;
                            for (int i = 0; i < ct; ++i) {
                                var exp = args[i] as InitializerExpressionSyntax;
                                if (null != exp) {
                                    CodeBuilder.Append("[");
                                    VisitToplevelExpression(exp.Expressions[0], string.Empty);
                                    CodeBuilder.Append("] = ");
                                    VisitToplevelExpression(exp.Expressions[1], string.Empty);
                                } else {
                                    Log(args[i], "Dictionary init error !");
                                }
                                if (i < ct - 1) {
                                    CodeBuilder.Append(", ");
                                }
                            }
                            CodeBuilder.Append("}");
                        } else if(isList) {
                            CodeBuilder.Append("{");
                            var args = node.Expressions;
                            int ct = args.Count;
                            for (int i = 0; i < ct; ++i) {
                                VisitExpressionSyntax(args[i]);
                                if (i < ct - 1) {
                                    CodeBuilder.Append(", ");
                                }
                            }
                            CodeBuilder.Append("}");
                        } else {
                            CodeBuilder.Append("{");
                            var args = node.Expressions;
                            int ct = args.Count;
                            for (int i = 0; i < ct; ++i) {
                                VisitExpressionSyntax(args[i]);
                                if (i < ct - 1) {
                                    CodeBuilder.Append(", ");
                                }
                            }
                            CodeBuilder.Append("}");
                        }
                    } else {
                        Log(node, "Can't find operation type ! operation info: {0}", oper.ToString());
                    }
                } else if (isComplex) {
                    CodeBuilder.Append("{");
                    var args = node.Expressions;
                    int ct = args.Count;
                    for (int i = 0; i < ct; ++i) {
                        VisitExpressionSyntax(args[i]);
                        if (i < ct - 1) {
                            CodeBuilder.Append(", ");
                        }
                    }
                    CodeBuilder.Append("}");
                } else {
                    if (isArray)
                        CodeBuilder.Append("wraparray{");
                    var args = node.Expressions;
                    int ct = args.Count;
                    for (int i = 0; i < ct; ++i) {
                        var exp = args[i];
                        VisitToplevelExpression(exp, string.Empty);
                        if (i < ct - 1) {
                            CodeBuilder.Append(", ");
                        }
                    }
                    if (isArray)
                        CodeBuilder.Append("}");
                }
            } else {
                Log(node, "Can't find operation info !");
            }
        }
        public override void VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            var oper = m_Model.GetOperation(node);
            var objectCreate = oper as IObjectCreationExpression;
            if (null != objectCreate) {
                var typeSymInfo = objectCreate.Type;
                var sym = objectCreate.Constructor;

                m_ObjectCreateStack.Push(typeSymInfo);

                string fullTypeName = ClassInfo.GetFullName(typeSymInfo);

                //处理ref/out参数
                InvocationInfo ii = new InvocationInfo();
                ii.Init(sym, m_SymbolTable.AssemblySymbol, node.ArgumentList, m_SymbolTable.IsUseExplicitTypeParam(sym), m_Model);
                ci.AddReference(sym, ci.SemanticInfo);

                bool isCollection = IsImplementationOfSys(typeSymInfo, "ICollection");
                bool isExternal = typeSymInfo.ContainingAssembly != m_SymbolTable.AssemblySymbol;

                string ctor = NameMangling(sym);
                string localName = string.Format("__compiler_newobject_{0}", node.GetLocation().GetLineSpan().StartLinePosition.Line);
                if (ii.ReturnArgs.Count > 0) {
                    CodeBuilder.Append("(function() ");
                    CodeBuilder.AppendFormat("local {0}; {1}", localName, localName);
                    CodeBuilder.Append(", ");
                    OutputExpressionList(ii.ReturnArgs);
                    CodeBuilder.Append(" = ");
                }
                if (isCollection) {
                    bool isDictionary = IsImplementationOfSys(typeSymInfo, "IDictionary");
                    bool isList = IsImplementationOfSys(typeSymInfo, "IList");
                    if (isDictionary) {
                        //字典对象的处理
                        CodeBuilder.AppendFormat("new{0}dictionary({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                        if (isExternal) {
                            CodeBuilder.AppendFormat("\"{0}\", ", fullTypeName);
                        }
                    } else if (isList) {
                        //列表对象的处理
                        CodeBuilder.AppendFormat("new{0}list({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                        if (isExternal) {
                            CodeBuilder.AppendFormat("\"{0}\", ", fullTypeName);
                        }
                    } else {
                        //集合对象的处理
                        CodeBuilder.AppendFormat("new{0}collection({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                        if (isExternal) {
                            CodeBuilder.AppendFormat("\"{0}\", ", fullTypeName);
                        }
                    }                        
                } else {
                    CodeBuilder.AppendFormat("new{0}object({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                    if (isExternal) {
                        CodeBuilder.AppendFormat("\"{0}\", ", fullTypeName);
                    }
                }
                if (string.IsNullOrEmpty(ctor)) {
                    CodeBuilder.Append("nil");
                } else {
                    CodeBuilder.AppendFormat("\"{0}\"", ctor);
                }
                if (isExternal) {
                    ClassSymbolInfo csi;
                    if (m_SymbolTable.ClassSymbols.TryGetValue(fullTypeName, out csi)) {
                        if (csi.ExtensionClasses.Count > 0) {
                            CodeBuilder.Append(", (function(obj)");
                            foreach (var pair in csi.ExtensionClasses) {
                                string refname = pair.Key;
                                CodeBuilder.AppendFormat(" {0}.__install_{1}(obj);", fullTypeName, refname.Replace(".", "_"));
                            }
                            CodeBuilder.Append(" end)");
                        } else {
                            CodeBuilder.Append(", nil");
                        }
                    } else {
                        CodeBuilder.Append(", nil");
                    }
                }
                if (null != node.Initializer) {
                    CodeBuilder.Append(", ");
                    if (!isCollection) {
                        CodeBuilder.Append("{");
                    }
                    VisitInitializerExpression(node.Initializer);
                    if (!isCollection) {
                        CodeBuilder.Append("}");
                    }
                } else {
                    CodeBuilder.Append(", {}");
                }
                if (ii.Args.Count + ii.GenericTypeArgs.Count > 0) {
                    CodeBuilder.Append(", ");
                }
                OutputArgumentList(ii.Args, ii.GenericTypeArgs, ii.ArrayToParams);
                CodeBuilder.Append(")");
                if (ii.ReturnArgs.Count > 0) {
                    CodeBuilder.Append("; ");
                    CodeBuilder.AppendFormat("return {0}; end)()", localName);
                }

                m_ObjectCreateStack.Pop();
            } else {
                var methodBinding = oper as IMethodBindingExpression;
                if (null != methodBinding) {
                    var typeSymInfo = methodBinding.Type;
                    var msym = methodBinding.Method;
                    if (null != msym) {
                        string manglingName = NameMangling(msym);
                        var mi = new MethodInfo();
                        mi.Init(msym, m_SymbolTable.AssemblySymbol, node);

                        CodeBuilder.Append("(function(");
                        string paramsString = string.Join(", ", mi.ParamNames.ToArray());
                        CodeBuilder.Append(paramsString);
                        CodeBuilder.Append(") ");
                        if (!msym.ReturnsVoid) {
                            CodeBuilder.Append("return ");
                        }
                        if (msym.IsStatic) {
                            string className = ClassInfo.GetFullName(msym.ContainingType);
                            CodeBuilder.Append(className);
                            CodeBuilder.Append(".");
                        } else {
                            CodeBuilder.Append("this:");
                        }
                        CodeBuilder.Append(manglingName);
                        CodeBuilder.AppendFormat("({0}) end)", paramsString);
                    } else {
                        VisitArgumentList(node.ArgumentList);
                    }
                } else {
                    var typeParamObjCreate = oper as ITypeParameterObjectCreationExpression;
                    if (null != typeParamObjCreate) {
                        CodeBuilder.Append("newtypeparamobject(");
                        OutputType(typeParamObjCreate.Type, node, ci, "new");
                        CodeBuilder.Append(")");
                    } else {
                        Log(node, "Unknown ObjectCreationExpressionSyntax !");
                    }
                }
            }
        }
        public override void VisitAnonymousObjectCreationExpression(AnonymousObjectCreationExpressionSyntax node)
        {
            CodeBuilder.Append("wrapdictionary{");
            int ct = node.Initializers.Count;
            for (int i = 0; i < ct; ++i) {
                var init = node.Initializers[i];
                CodeBuilder.Append(init.NameEquals.Name);
                CodeBuilder.AppendFormat(" {0} ", init.NameEquals.EqualsToken.Text);
                VisitToplevelExpression(init.Expression, string.Empty);
                if (i < ct - 1)
                    CodeBuilder.Append(", ");
            }
            CodeBuilder.Append("}");
        }
        public override void VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
        {
            if (null == node.Initializer) {
                var rankspecs = node.Type.RankSpecifiers;
                var rankspec = rankspecs[0];
                int rank = rankspec.Rank;
                if (rank > 1) {
                    CodeBuilder.Append("(function() local arr = wraparray{};");
                    int ct = rankspec.Sizes.Count;
                    for (int i = 0; i < ct; ++i) {
                        CodeBuilder.AppendFormat(" local d{0} = ", i);
                        var exp = rankspec.Sizes[i];
                        VisitExpressionSyntax(exp);
                        CodeBuilder.AppendFormat("; for i{0} = 1,d{1} do arr{2} = ", i, i, GetArraySubscriptString(i));
                        if (i < ct - 1) {
                            CodeBuilder.Append("{};");
                        } else {
                            CodeBuilder.Append("nil;");
                        }
                    }
                    for (int i = 0; i < ct; ++i) {
                        CodeBuilder.Append(" end;");
                    }
                    CodeBuilder.Append(" return arr; end)()");
                } else {
                    CodeBuilder.Append("wraparray{}");
                }
            } else {
                VisitInitializerExpression(node.Initializer);
            }
        }
        public override void VisitImplicitArrayCreationExpression(ImplicitArrayCreationExpressionSyntax node)
        {
            VisitInitializerExpression(node.Initializer);
        }
        public override void VisitPredefinedType(PredefinedTypeSyntax node)
        {
            TypeInfo typeInfo = m_Model.GetTypeInfo(node);
            var type = typeInfo.Type;

            if (null != type) {
                string fullName = ClassInfo.GetFullName(type);
                CodeBuilder.Append(fullName);
            } else {
                CodeBuilder.Append(node.Keyword.Text);
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
                    if (sym.Kind == SymbolKind.NamedType || sym.Kind == SymbolKind.Namespace) {
                        string fullName = ClassInfo.GetFullName(sym);
                        CodeBuilder.Append(fullName);

                        if (sym.Kind == SymbolKind.NamedType) {
                            classInfo.AddReference(sym as INamedTypeSymbol, classInfo.SemanticInfo);
                        }
                        return;
                    } else if (sym.Kind == SymbolKind.Field || sym.Kind == SymbolKind.Property || sym.Kind == SymbolKind.Event) {
                        if (m_ObjectCreateStack.Count > 0) {
                            ITypeSymbol symInfo = m_ObjectCreateStack.Peek();
                            if (null != symInfo) {
                                var names = symInfo.GetMembers(name);
                                if (names.Length > 0) {
                                    CodeBuilder.AppendFormat("{0}", name);
                                    return;
                                }
                            }
                        }
                        if (sym.ContainingType == classInfo.SemanticInfo) {
                            if (sym.IsStatic) {
                                CodeBuilder.AppendFormat("{0}.{1}", classInfo.Key, sym.Name);
                            } else {
                                CodeBuilder.AppendFormat("this.{0}", sym.Name);
                            }
                            return;
                        }
                    } else if (sym.Kind == SymbolKind.Method && sym.ContainingType == classInfo.SemanticInfo) {
                        var msym = sym as IMethodSymbol;
                        string manglingName = NameMangling(msym);
                        var mi = new MethodInfo();
                        mi.Init(msym, m_SymbolTable.AssemblySymbol, node);
                        if (node.Parent is InvocationExpressionSyntax) {
                            if (sym.IsStatic) {
                                CodeBuilder.AppendFormat("{0}.{1}", classInfo.Key, manglingName);
                            } else {
                                CodeBuilder.AppendFormat("this:{0}", manglingName);
                            }
                        } else {
                            CodeBuilder.Append("(function(");
                            string paramsString = string.Join(", ", mi.ParamNames.ToArray());
                            CodeBuilder.Append(paramsString);
                            if (sym.IsStatic) {
                                CodeBuilder.AppendFormat(") {0}.{1}({2}) end)", classInfo.Key, manglingName, paramsString);
                            } else {
                                CodeBuilder.AppendFormat(") this:{0}({1}) end)", manglingName, paramsString);
                            }
                        }
                        return;
                    }
                } else {
                    if (m_ObjectCreateStack.Count > 0) {
                        ITypeSymbol symInfo = m_ObjectCreateStack.Peek();
                        if (null != symInfo) {
                            var names = symInfo.GetMembers(name);
                            if (names.Length > 0) {
                                CodeBuilder.AppendFormat("{0}", name);
                                return;
                            }
                        }
                    } else {
                        ReportIllegalSymbol(node, symbolInfo);
                    }
                }
            }
            CodeBuilder.Append(name);
        }
        public override void VisitQualifiedName(QualifiedNameSyntax node)
        {
            SymbolInfo symInfo = m_Model.GetSymbolInfo(node);
            var sym = symInfo.Symbol;
            if (null != sym) {
                string fullName = ClassInfo.GetFullName(sym);
                CodeBuilder.Append(fullName);
            } else {
                ReportIllegalSymbol(node, symInfo);
                CodeBuilder.Append(node.GetText());
            }
        }
        #endregion

        private void VisitToplevelExpression(ExpressionSyntax expression, string expTerminater)
        {
            VisitToplevelExpressionFirstPass(expression, expTerminater);
            while (m_PostfixUnaryExpressions.Count > 0) {
                PostfixUnaryExpressionSyntax postfixUnary = m_PostfixUnaryExpressions.Dequeue();
                if (null != postfixUnary) {
                    string op = postfixUnary.OperatorToken.Text;
                    if (op == "++" || op == "--") {
                        CodeBuilder.AppendFormat("{0}", GetIndentString());
                        VisitExpressionSyntax(postfixUnary.Operand);
                        CodeBuilder.Append(" = ");
                        VisitExpressionSyntax(postfixUnary.Operand);
                        CodeBuilder.Append(op == "++" ? " + 1" : " - 1");
                        CodeBuilder.AppendFormat("{0}", expTerminater);
                        if (expTerminater.Length > 0)
                            CodeBuilder.AppendLine();
                    }
                }
            }
        }
        private void VisitTypeDeclarationSyntax(TypeDeclarationSyntax node)
        {
            INamedTypeSymbol declSym = m_Model.GetDeclaredSymbol(node);
            ClassInfo ci = new ClassInfo();
            ClassSymbolInfo info;
            m_SymbolTable.ClassSymbols.TryGetValue(ClassInfo.GetFullName(declSym), out info);
            ci.Init(declSym, info);
            if (null != declSym) {
                string require = ClassInfo.GetAttributeArgument<string>(declSym, "Cs2Lua.RequireAttribute", 0);
                if (!string.IsNullOrEmpty(require)) {
                    m_SymbolTable.AddRequire(ci.Key, require);
                }
                if (ClassInfo.HasAttribute(declSym, "Cs2Lua.IgnoreAttribute"))
                    return;
            }

            m_ClassInfoStack.Push(ci);

            if (m_ClassInfoStack.Count == 1) {
                ci.BeforeOuterCodeBuilder.Append(m_ToplevelCodeBuilder.ToString());
                m_ToplevelCodeBuilder.Clear();
            }

            if (!m_EnableInherit && !ClassInfo.HasAttribute(declSym, "Cs2Lua.EnableInheritAttribute") && !ClassInfo.HasAttribute(declSym.BaseType, "Cs2Lua.EnableInheritAttribute")) {
                if (!string.IsNullOrEmpty(ci.BaseClassName) && ci.BaseClassName != "Object" && ci.BaseClassName != "ValueType") {
                    Log(node, "Cs2Lua class/struct can't inherit !");
                }
            }

            if (!string.IsNullOrEmpty(ci.BaseKey)) {
                ci.AddReference(declSym.BaseType, declSym);
            }

            TypeInfo typeInfo = m_Model.GetTypeInfo(node);
            var type = typeInfo.Type;

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
                    ++m_Indent;
                    ++m_Indent;
                    ci.CurrentCodeBuilder = ci.StaticPropertyCodeBuilder;
                    member.Accept(this);
                    --m_Indent;
                    --m_Indent;
                }
                if (null != eventSym && eventSym.IsStatic) {
                    ++m_Indent;
                    ++m_Indent;
                    ci.CurrentCodeBuilder = ci.StaticEventCodeBuilder;
                    member.Accept(this);
                    --m_Indent;
                    --m_Indent;
                }
            }
            ++m_Indent;
            ++m_Indent;
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
            ++m_Indent;
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
            } else {
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
                string require = ClassInfo.GetAttributeArgument<string>(declSym, "Cs2Lua.RequireAttribute", 0);
                if (!string.IsNullOrEmpty(require)) {
                    m_SymbolTable.AddRequire(ci.Key, require);
                }
                if (ClassInfo.HasAttribute(declSym, "Cs2Lua.IgnoreAttribute"))
                    return;
                if (declSym.IsAbstract)
                    return;
            }

            var mi = new MethodInfo();
            mi.Init(declSym, m_SymbolTable.AssemblySymbol, node, m_SymbolTable.IsUseExplicitTypeParam(declSym));
            m_MethodInfoStack.Push(mi);

            string manglingName = NameMangling(declSym);
            bool isExtension = declSym.IsExtensionMethod;
            if (isExtension && declSym.Parameters.Length > 0) {
                var targetType = declSym.Parameters[0].Type;
                ci.AddReference(targetType, ci.SemanticInfo);
                string key = ClassInfo.GetFullName(targetType);
                StringBuilder extensionCodeBuilder;
                if (!ci.ExtensionCodeBuilders.TryGetValue(key, out extensionCodeBuilder)) {
                    extensionCodeBuilder = new StringBuilder();
                    ci.ExtensionCodeBuilders.Add(key, extensionCodeBuilder);
                }

                ++m_Indent;
                ++m_Indent;
                extensionCodeBuilder.AppendFormat("{0}obj.{1} = {2}.{3};", GetIndentString(), manglingName, ci.Key, manglingName);
                extensionCodeBuilder.AppendLine();
                --m_Indent;
                --m_Indent;
            }
            bool isStatic = declSym.IsStatic;
            CodeBuilder.AppendFormat("{0}{1} = {2}function({3}", GetIndentString(), manglingName, mi.ExistYield ? "wrapenumerable(" : string.Empty, isStatic ? string.Empty : "this");
            if (mi.ParamNames.Count > 0) {
                if (!isStatic) {
                    CodeBuilder.Append(", ");
                }
                CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
            }
            CodeBuilder.Append(")");
            CodeBuilder.AppendLine();
            ++m_Indent;
            if (mi.ValueParams.Count > 0) {
                OutputWrapValueParams(CodeBuilder, mi);
            }
            if (!string.IsNullOrEmpty(mi.OriginalParamsName)) {
                if (mi.ParamsIsValueType) {
                    CodeBuilder.AppendFormat("{0}local {1} = wrapvaluetypearray{{...}};", GetIndentString(), mi.OriginalParamsName);
                } else if (mi.ParamsIsExternValueType) {
                    CodeBuilder.AppendFormat("{0}local {1} = wrapexternvaluetypearray{{...}};", GetIndentString(), mi.OriginalParamsName);
                } else {
                    CodeBuilder.AppendFormat("{0}local {1} = wraparray{{...}};", GetIndentString(), mi.OriginalParamsName);
                }
                CodeBuilder.AppendLine();
            }
            foreach (string name in mi.OutParamNames) {
                CodeBuilder.AppendFormat("{0}local {1} = nil;", GetIndentString(), name);
                CodeBuilder.AppendLine();
            }
            if (null != body) {
                VisitBlock(body);
            } else if (null != expressionBody) {
                if (declSym.ReturnsVoid) {
                    CodeBuilder.AppendFormat("{0}", GetIndentString());
                } else {
                    CodeBuilder.AppendFormat("{0}return ", GetIndentString());
                }
                VisitExpressionSyntax(expressionBody.Expression);
                CodeBuilder.AppendLine(";");
            }
            if (!mi.ExistReturn && mi.ReturnParamNames.Count > 0) {
                CodeBuilder.AppendFormat("{0}return {1};", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                CodeBuilder.AppendLine();
            }
            --m_Indent;
            CodeBuilder.AppendFormat("{0}end{1}", GetIndentString(), mi.ExistYield ? ")" : string.Empty);
            if (m_Indent > 0) {
                CodeBuilder.Append(",");
            }
            CodeBuilder.AppendLine();
            m_MethodInfoStack.Pop();
        }
        private void VisitFieldDeclaration(ClassInfo ci, FieldDeclarationSyntax fieldDecl, bool isStatic)
        {
            foreach (var v in fieldDecl.Declaration.Variables) {
                var baseSym = m_Model.GetDeclaredSymbol(v);
                if (null != baseSym) {
                    string require = ClassInfo.GetAttributeArgument<string>(baseSym, "Cs2Lua.RequireAttribute", 0);
                    if (!string.IsNullOrEmpty(require)) {
                        m_SymbolTable.AddRequire(ci.Key, require);
                    }
                    if (ClassInfo.HasAttribute(baseSym, "Cs2Lua.IgnoreAttribute"))
                        continue;
                } else {
                    Log(v, "Can't get field declared symbol !");
                    continue;
                }
                var fieldSym = baseSym as IFieldSymbol;
                if (isStatic && fieldSym.IsStatic || !isStatic && !fieldSym.IsStatic) {
                    string name = v.Identifier.Text;
                    if (null != v.Initializer) {
                        var expOper = m_Model.GetOperation(v.Initializer.Value);
                        var constVal = expOper.ConstantValue;
                        if (!constVal.HasValue) {
                            bool useExplicitTypeParam = m_SymbolTable.IsUseExplicitTypeParam(fieldSym);
                            bool createSelf = m_SymbolTable.IsFieldCreateSelf(fieldSym);
                            if (useExplicitTypeParam || createSelf) {
                                CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                                CodeBuilder.AppendLine(" = true,");
                                if (isStatic && useExplicitTypeParam) {
                                    Log(v, "typeof/as/is/cast(GenericTypeParameter) or new GenericTypeParameter() can't be used in static field initializer !");
                                }
                                if (isStatic) {
                                    ci.CurrentCodeBuilder = ci.StaticInitializerCodeBuilder;
                                    --m_Indent;
                                } else {
                                    ci.CurrentCodeBuilder = ci.InstanceInitializerCodeBuilder;
                                }
                                CodeBuilder.AppendFormat("{0}{1}.{2}", GetIndentString(), isStatic ? ci.Key : "this", name);
                                CodeBuilder.AppendFormat(" = ", fieldSym.Type.TypeKind == TypeKind.Delegate ? "delegationwrap(" : string.Empty);
                                VisitExpressionSyntax(v.Initializer.Value);
                                CodeBuilder.AppendFormat("{0};", fieldSym.Type.TypeKind == TypeKind.Delegate ? ")" : string.Empty);
                                CodeBuilder.AppendLine();
                                if (isStatic) {
                                    ++m_Indent;
                                    ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;
                                } else {
                                    ci.CurrentCodeBuilder = ci.InstanceFieldCodeBuilder;
                                }
                                continue;
                            } else {
                                CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                                CodeBuilder.AppendFormat(" = ", fieldSym.Type.TypeKind == TypeKind.Delegate ? "delegationwrap(" : string.Empty);
                                VisitExpressionSyntax(v.Initializer.Value);
                                CodeBuilder.AppendFormat("{0}", fieldSym.Type.TypeKind == TypeKind.Delegate ? ")" : string.Empty);
                            }
                        } else {
                            CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                            CodeBuilder.Append(" = ");
                            OutputConstValue(constVal.Value);
                        }
                    } else if (fieldSym.Type.TypeKind == TypeKind.Delegate) {
                        CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                        CodeBuilder.Append(" = wrapdelegation{}");
                    } else {
                        CodeBuilder.AppendFormat("{0}{1} = true", GetIndentString(), name);
                    }
                    CodeBuilder.Append(",");
                    CodeBuilder.AppendLine();
                }
            }
        }
        private void VisitEventFieldDeclaration(ClassInfo ci, EventFieldDeclarationSyntax eventFieldDecl, bool isStatic)
        {
            foreach (var v in eventFieldDecl.Declaration.Variables) {
                var baseSym = m_Model.GetDeclaredSymbol(v);
                if (null != baseSym) {
                    string require = ClassInfo.GetAttributeArgument<string>(baseSym, "Cs2Lua.RequireAttribute", 0);
                    if (!string.IsNullOrEmpty(require)) {
                        m_SymbolTable.AddRequire(ci.Key, require);
                    }
                    if (ClassInfo.HasAttribute(baseSym, "Cs2Lua.IgnoreAttribute"))
                        continue;
                } else {
                    Log(v, "Can't get event field declared symbol !");
                    continue;
                }
                var fieldSym = baseSym as IEventSymbol;
                if (isStatic && fieldSym.IsStatic || !isStatic && !fieldSym.IsStatic) {
                    string name = v.Identifier.Text;
                    if (null != v.Initializer) {
                        CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                        CodeBuilder.Append(" = delegationwrap(");
                        VisitExpressionSyntax(v.Initializer.Value);
                        CodeBuilder.Append(");");
                    } else {
                        CodeBuilder.AppendFormat("{0}{1} = wrapdelegation{{}}", GetIndentString(), name);
                    }
                    CodeBuilder.Append(",");
                    CodeBuilder.AppendLine();
                }
            }
        }
        private void VisitExpressionSyntax(ExpressionSyntax node)
        {
            IOperation oper = m_Model.GetOperation(node);
            if (null != oper && oper.ConstantValue.HasValue) {
                object val = oper.ConstantValue.Value;
                OutputConstValue(val);
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
                var leftOper = m_Model.GetOperation(assign.Left);
                var leftSymbolInfo = m_Model.GetSymbolInfo(assign.Left);
                var leftSym = leftSymbolInfo.Symbol;
                var leftElementAccess = assign.Left as ElementAccessExpressionSyntax;
                var leftCondAccess = assign.Left as ConditionalAccessExpressionSyntax;
                VisitAssignment(ci, op, baseOp, assign, expTerminater, true, leftOper, leftSym, leftElementAccess, leftCondAccess);
                var oper = m_Model.GetOperation(assign.Right);
                if (null != leftSym && leftSym.Kind == SymbolKind.Local && null != oper && null != oper.Type && oper.Type.IsValueType && oper.Type.ContainingAssembly == m_SymbolTable.AssemblySymbol) {
                    CodeBuilder.AppendFormat("{0}{1} = wrapvaluetype({2});", GetIndentString(), leftSym.Name, leftSym.Name);
                    CodeBuilder.AppendLine();
                }
                return;
            } else {
                InvocationExpressionSyntax invocation = expression as InvocationExpressionSyntax;
                if (null != invocation) {
                    VisitInvocation(ci, invocation, expTerminater, true);
                    return;
                }
            }
            PrefixUnaryExpressionSyntax prefixUnary = expression as PrefixUnaryExpressionSyntax;
            if (null != prefixUnary) {
                string op = prefixUnary.OperatorToken.Text;
                if (op == "++" || op == "--") {
                    VisitExpressionSyntax(prefixUnary.Operand);
                    CodeBuilder.Append(" = ");
                    VisitExpressionSyntax(prefixUnary.Operand);
                    CodeBuilder.Append(op == "++" ? " + 1" : " - 1");
                    CodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
                } else {
                    ProcessUnaryOperator(expression, ref op);
                    CodeBuilder.Append("(");
                    CodeBuilder.Append(op);
                    CodeBuilder.Append(" ");
                    VisitExpressionSyntax(prefixUnary.Operand);
                    CodeBuilder.AppendFormat("){0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
                }
                return;
            }
            PostfixUnaryExpressionSyntax postfixUnary = expression as PostfixUnaryExpressionSyntax;
            if (null != postfixUnary) {
                string op = postfixUnary.OperatorToken.Text;
                if (op == "++" || op == "--") {
                    VisitExpressionSyntax(postfixUnary.Operand);
                    CodeBuilder.Append(" = ");
                    VisitExpressionSyntax(postfixUnary.Operand);
                    CodeBuilder.Append(op == "++" ? " + 1" : " - 1");
                    CodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
                }
                return;
            }
            VisitExpressionSyntax(expression);
            CodeBuilder.AppendFormat("{0}", expTerminater);
            if (expTerminater.Length > 0)
                CodeBuilder.AppendLine();
        }

        private void VisitLocalVariableDeclarator(ClassInfo ci, VariableDeclaratorSyntax node)
        {
            if (null != node.Initializer) {
                bool isDelegate = false;
                var declSym = m_Model.GetDeclaredSymbol(node) as ILocalSymbol;
                if (null != declSym && declSym.Type.TypeKind == TypeKind.Delegate) {
                    isDelegate = true;
                }

                var token = node.Initializer.EqualsToken;
                var invocation = node.Initializer.Value as InvocationExpressionSyntax;
                if (null != invocation) {
                    SymbolInfo symInfo = m_Model.GetSymbolInfo(invocation);
                    IMethodSymbol sym = symInfo.Symbol as IMethodSymbol;

                    if (null == sym) {
                        ReportIllegalSymbol(invocation, symInfo);
                    } else {
                        //处理ref/out参数
                        InvocationInfo ii = new InvocationInfo();
                        ii.Init(sym, m_SymbolTable.AssemblySymbol, invocation.ArgumentList, m_SymbolTable.IsUseExplicitTypeParam(sym), m_Model);
                        ci.AddReference(sym, ci.SemanticInfo);

                        MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                        if (null != memberAccess) {
                            if (memberAccess.OperatorToken.Text == "->") {
                                Log(memberAccess, "Unsupported -> member access !");
                            }

                            int ct = ii.ReturnArgs.Count;
                            if (ct > 0) {
                                CodeBuilder.Append(", ");
                            }
                            OutputExpressionList(ii.ReturnArgs);
                            CodeBuilder.AppendFormat(" {0} ", token.Text);
                            if (isDelegate) {
                                CodeBuilder.Append("delegationwrap(");
                            }
                            if (sym.IsStatic) {
                                CodeBuilder.Append(ii.ClassKey);
                                CodeBuilder.Append(".");
                            } else {
                                VisitExpressionSyntax(memberAccess.Expression);
                                CodeBuilder.Append(":");
                            }
                            CodeBuilder.Append(NameMangling(sym));
                            CodeBuilder.Append("(");
                            OutputArgumentList(ii.Args, ii.GenericTypeArgs, ii.ArrayToParams);
                            CodeBuilder.Append(")");
                        } else {
                            int ct = ii.ReturnArgs.Count;
                            if (ct > 0) {
                                CodeBuilder.Append(", ");
                            }
                            OutputExpressionList(ii.ReturnArgs);
                            CodeBuilder.AppendFormat(" {0} ", token.Text);
                            if (isDelegate) {
                                CodeBuilder.Append("delegationwrap(");
                            }
                            if (sym.MethodKind == MethodKind.DelegateInvoke) {
                                VisitExpressionSyntax(invocation.Expression);
                            } else if (sym.IsStatic) {
                                CodeBuilder.AppendFormat("{0}.", ii.ClassKey);
                                CodeBuilder.Append(NameMangling(sym));
                            } else {
                                CodeBuilder.Append("this:");
                                CodeBuilder.Append(NameMangling(sym));
                            }
                            CodeBuilder.Append("(");
                            OutputArgumentList(ii.Args, ii.GenericTypeArgs, ii.ArrayToParams);
                            CodeBuilder.Append(")");
                        }
                    }
                } else {
                    var init = node.Initializer;
                    CodeBuilder.AppendFormat(" {0} ", token.Text);
                    if (isDelegate) {
                        CodeBuilder.Append("delegationwrap(");
                    }
                    VisitExpressionSyntax(init.Value);
                }
                if (isDelegate) {
                    CodeBuilder.Append(")");
                }
            }
            CodeBuilder.AppendLine(";");
        }
        private void VisitAssignment(ClassInfo ci, string op, string baseOp, AssignmentExpressionSyntax assign, string expTerminater, bool toplevel, IOperation leftOper, ISymbol leftSym, ElementAccessExpressionSyntax leftElementAccess, ConditionalAccessExpressionSyntax leftCondAccess)
        {
            var assignOper = m_Model.GetOperation(assign);
            InvocationExpressionSyntax invocation = assign.Right as InvocationExpressionSyntax;
            if (null != leftElementAccess) {
                var propSym = leftSym as IPropertySymbol;
                if (null != propSym && propSym.IsIndexer) {
                    if (propSym.ContainingAssembly == m_SymbolTable.AssemblySymbol) {
                        VisitExpressionSyntax(leftElementAccess.Expression);
                        if (propSym.IsStatic)
                            CodeBuilder.Append(".__indexer_set(");
                        else
                            CodeBuilder.Append(":__indexer_set(");
                        VisitBracketedArgumentList(leftElementAccess.ArgumentList);
                        CodeBuilder.Append(", ");
                        VisitExpressionSyntax(assign.Right);
                        CodeBuilder.Append(")");
                    } else {
                        CodeBuilder.AppendFormat("setextern{0}indexer(", propSym.IsStatic ? "static" : "instance");
                        if (propSym.IsStatic) {
                            string fullName = ClassInfo.GetFullName(propSym.ContainingType);
                            CodeBuilder.Append(fullName);
                        } else {
                            VisitExpressionSyntax(leftElementAccess.Expression);
                        }
                        CodeBuilder.Append(", ");
                        VisitBracketedArgumentList(leftElementAccess.ArgumentList);
                        CodeBuilder.Append(", ");
                        VisitExpressionSyntax(assign.Right);
                        CodeBuilder.Append(")");
                    }
                } else if (leftOper.Kind == OperationKind.ArrayElementReferenceExpression) {
                    if (!toplevel) {
                        CodeBuilder.Append("(function() ");
                    }
                    VisitExpressionSyntax(leftElementAccess.Expression);
                    CodeBuilder.Append("[");
                    VisitBracketedArgumentList(leftElementAccess.ArgumentList);
                    CodeBuilder.Append("] = ");
                    VisitExpressionSyntax(assign.Right);
                    if (!toplevel) {
                        CodeBuilder.Append("; return ");
                        VisitExpressionSyntax(assign.Right);
                        CodeBuilder.Append("; end)()");
                    }
                } else {
                    CodeBuilder.AppendFormat("set{0}element(", leftSym.ContainingAssembly == m_SymbolTable.AssemblySymbol ? string.Empty : "extern");
                    VisitExpressionSyntax(leftElementAccess.Expression);
                    CodeBuilder.Append(", ");
                    VisitBracketedArgumentList(leftElementAccess.ArgumentList);
                    CodeBuilder.Append(", ");
                    VisitExpressionSyntax(assign.Right);
                    CodeBuilder.Append(")");
                }
            } else if (null != leftCondAccess) {
                CodeBuilder.Append("condaccess(");
                VisitExpressionSyntax(leftCondAccess.Expression);
                CodeBuilder.Append(", ");
                var elementBinding = leftCondAccess.WhenNotNull as ElementBindingExpressionSyntax;
                if (null != elementBinding) {
                    var bindingOper = m_Model.GetOperation(leftCondAccess.WhenNotNull);
                    var symInfo = m_Model.GetSymbolInfo(leftCondAccess.WhenNotNull);
                    var sym = symInfo.Symbol as IPropertySymbol;

                    if (null != sym && sym.IsIndexer) {
                        if (sym.ContainingAssembly == m_SymbolTable.AssemblySymbol) {
                            VisitExpressionSyntax(leftCondAccess.Expression);
                            if (sym.IsStatic)
                                CodeBuilder.Append(".__indexer_set(");
                            else
                                CodeBuilder.Append(":__indexer_set(");
                            VisitExpressionSyntax(leftCondAccess.WhenNotNull);
                            CodeBuilder.Append(", ");
                            VisitExpressionSyntax(assign.Right);
                            CodeBuilder.Append(")");
                        } else {
                            CodeBuilder.AppendFormat("setextern{0}indexer(", sym.IsStatic ? "static" : "instance");
                            if (sym.IsStatic) {
                                string fullName = ClassInfo.GetFullName(sym.ContainingType);
                                CodeBuilder.Append(fullName);
                            } else {
                                VisitExpressionSyntax(leftCondAccess.Expression);
                            }
                            CodeBuilder.Append(", ");
                            VisitExpressionSyntax(leftCondAccess.WhenNotNull);
                            CodeBuilder.Append(", ");
                            VisitExpressionSyntax(assign.Right);
                            CodeBuilder.Append(")");
                        }
                    } else if (bindingOper.Kind == OperationKind.ArrayElementReferenceExpression) {
                        CodeBuilder.Append("(function() ");
                        VisitExpressionSyntax(leftCondAccess.Expression);
                        CodeBuilder.Append("[");
                        VisitExpressionSyntax(leftCondAccess.WhenNotNull);
                        CodeBuilder.Append("] = ");
                        VisitExpressionSyntax(assign.Right);
                        CodeBuilder.Append("; return ");
                        VisitExpressionSyntax(assign.Right);
                        CodeBuilder.Append("; end)()");
                    } else {
                        CodeBuilder.AppendFormat("set{0}element(", sym.ContainingAssembly == m_SymbolTable.AssemblySymbol ? string.Empty : "extern");
                        VisitExpressionSyntax(leftCondAccess.Expression);
                        CodeBuilder.Append(", ");
                        VisitExpressionSyntax(leftCondAccess.WhenNotNull);
                        CodeBuilder.Append(", ");
                        VisitExpressionSyntax(assign.Right);
                        CodeBuilder.Append(")");
                    }
                } else {
                    CodeBuilder.Append("(function() ");
                    VisitExpressionSyntax(leftCondAccess.Expression);
                    VisitExpressionSyntax(leftCondAccess.WhenNotNull);
                    CodeBuilder.Append(" = ");
                    VisitExpressionSyntax(assign.Right);
                    CodeBuilder.Append("; return ");
                    VisitExpressionSyntax(assign.Right);
                    CodeBuilder.Append("; end)()");
                }
                CodeBuilder.Append(")");
            } else if (leftOper.Type.TypeKind == TypeKind.Delegate) {
                if (leftSym.Kind == SymbolKind.Local && op == "=") {
                    VisitExpressionSyntax(assign.Left);
                    CodeBuilder.Append(" = ");
                    CodeBuilder.AppendFormat("delegationwrap");
                    CodeBuilder.Append("(");
                    VisitExpressionSyntax(assign.Right);
                    CodeBuilder.Append(")");
                } else {
                    string prefix;
                    if (leftSym.ContainingAssembly == m_SymbolTable.AssemblySymbol) {
                        prefix = string.Empty;
                    } else {
                        prefix = "extern";
                    }
                    string postfix;
                    if (op == "=") {
                        postfix = "set";
                    } else if (op == "+=") {
                        postfix = "add";
                    } else if (op == "-=") {
                        postfix = "remove";
                    } else {
                        Log(assign, "Unsupported delegation operator {0} !");
                        postfix = "error";
                    }
                    CodeBuilder.AppendFormat("{0}delegation{1}", prefix, postfix);
                    CodeBuilder.Append("(");
                    if (leftSym.Kind == SymbolKind.Field || leftSym.Kind == SymbolKind.Property || leftSym.Kind == SymbolKind.Event) {
                        var memberAccess = assign.Left as MemberAccessExpressionSyntax;
                        if (null != memberAccess) {
                            VisitExpressionSyntax(memberAccess.Expression);
                            CodeBuilder.Append(", ");
                            CodeBuilder.AppendFormat("\"{0}\"", memberAccess.Name.Identifier.Text);
                        } else if (leftSym.ContainingType == ci.SemanticInfo) {
                            CodeBuilder.Append("this, ");
                            CodeBuilder.AppendFormat("\"{0}\"", leftSym.Name);
                        } else {
                            VisitExpressionSyntax(assign.Left);
                            CodeBuilder.Append(", nil");
                        }
                    } else {
                        VisitExpressionSyntax(assign.Left);
                        CodeBuilder.Append(", nil");
                    }
                    CodeBuilder.Append(", ");
                    VisitExpressionSyntax(assign.Right);
                    CodeBuilder.Append(")");
                }
            } else if (null != invocation) {
                string localName = string.Format("__compiler_assigninvoke_{0}", invocation.GetLocation().GetLineSpan().StartLinePosition.Line);
                SymbolInfo symInfo = m_Model.GetSymbolInfo(invocation);
                IMethodSymbol sym = symInfo.Symbol as IMethodSymbol;
                if (null == sym) {
                    ReportIllegalSymbol(invocation, symInfo);
                } else {
                    //处理ref/out参数
                    InvocationInfo ii = new InvocationInfo();
                    ii.Init(sym, m_SymbolTable.AssemblySymbol, invocation.ArgumentList, m_SymbolTable.IsUseExplicitTypeParam(sym), m_Model);
                    ci.AddReference(sym, ci.SemanticInfo);

                    MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                    if (null != memberAccess) {
                        if (memberAccess.OperatorToken.Text == "->") {
                            Log(memberAccess, "Unsupported -> member access !");
                        }

                        int ct = ii.ReturnArgs.Count;
                        if (op != "=") {
                            VisitExpressionSyntax(assign.Left);
                            CodeBuilder.Append(" = ");
                            ProcessBinaryOperator(assign, ref baseOp);
                            string functor;
                            if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                                CodeBuilder.AppendFormat("{0}(", functor);
                                VisitExpressionSyntax(assign.Left);
                                CodeBuilder.Append(", ");
                            } else {
                                VisitExpressionSyntax(assign.Left);
                                CodeBuilder.AppendFormat(" {0} ", baseOp);
                            }
                            CodeBuilder.AppendFormat("(function() local {0}; {1}", localName, localName);
                        } else {
                            VisitExpressionSyntax(assign.Left);
                        }

                        if (ct > 0) {
                            CodeBuilder.Append(", ");
                            OutputExpressionList(ii.ReturnArgs);
                        }
                        CodeBuilder.Append(" = ");
                        if (sym.IsStatic) {
                            CodeBuilder.Append(ii.ClassKey);
                            CodeBuilder.Append(".");
                        } else {
                            VisitExpressionSyntax(memberAccess.Expression);
                            CodeBuilder.Append(":");
                        }
                        CodeBuilder.Append(NameMangling(sym));
                        CodeBuilder.Append("(");
                        OutputArgumentList(ii.Args, ii.GenericTypeArgs, ii.ArrayToParams);
                        CodeBuilder.Append(")");

                        if (op != "=") {
                            CodeBuilder.AppendFormat("; return {0}; end)()", localName);
                            string functor;
                            if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                                CodeBuilder.Append(")");
                            }
                        }
                    } else {
                        int ct = ii.ReturnArgs.Count;
                        if (op != "=") {
                            VisitExpressionSyntax(assign.Left);
                            CodeBuilder.Append(" = ");
                            ProcessBinaryOperator(assign, ref baseOp);
                            string functor;
                            if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                                CodeBuilder.AppendFormat("{0}(", functor);
                                VisitExpressionSyntax(assign.Left);
                                CodeBuilder.Append(", ");
                            } else {
                                VisitExpressionSyntax(assign.Left);
                                CodeBuilder.AppendFormat(" {0} ", baseOp);
                            }
                            CodeBuilder.AppendFormat("(function() local {0}; {1}", localName, localName);
                        } else {
                            VisitExpressionSyntax(assign.Left);
                        }

                        if (ct > 0) {
                            CodeBuilder.Append(", ");
                            OutputExpressionList(ii.ReturnArgs);
                        }
                        CodeBuilder.Append(" = ");
                        if (sym.MethodKind == MethodKind.DelegateInvoke) {
                            VisitExpressionSyntax(invocation.Expression);
                        } else if (sym.IsStatic) {
                            CodeBuilder.AppendFormat("{0}.", ii.ClassKey);
                            CodeBuilder.Append(NameMangling(sym));
                        } else {
                            CodeBuilder.Append("this:");
                            CodeBuilder.Append(NameMangling(sym));
                        }
                        CodeBuilder.Append("(");
                        OutputArgumentList(ii.Args, ii.GenericTypeArgs, ii.ArrayToParams);
                        CodeBuilder.Append(")");

                        if (op != "=") {
                            CodeBuilder.AppendFormat("; return {0}; end)()", localName);
                            string functor;
                            if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                                CodeBuilder.Append(")");
                            }
                        }
                    }
                }
            } else {
                if (op == "=") {
                    VisitExpressionSyntax(assign.Left);
                    CodeBuilder.Append(" = ");
                    VisitExpressionSyntax(assign.Right);
                } else {
                    VisitExpressionSyntax(assign.Left);
                    CodeBuilder.Append(" = ");

                    var operatorInfo = assignOper as IHasOperatorMethodExpression;
                    if (null != operatorInfo && operatorInfo.UsesOperatorMethod) {
                        IMethodSymbol msym = operatorInfo.OperatorMethod;
                        InvocationInfo ii = new InvocationInfo();
                        var arglist = new List<ExpressionSyntax>() { assign.Left, assign.Right };
                        ii.Init(msym, m_SymbolTable.AssemblySymbol, arglist, m_SymbolTable.IsUseExplicitTypeParam(msym), m_Model);
                        OutputOperatorInvoke(ii);
                    } else {
                        ProcessBinaryOperator(assign, ref baseOp);
                        string functor;
                        if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                            CodeBuilder.AppendFormat("{0}(", functor);
                            VisitExpressionSyntax(assign.Left);
                            CodeBuilder.Append(", ");
                            VisitExpressionSyntax(assign.Right);
                            CodeBuilder.Append(")");
                        } else {
                            VisitExpressionSyntax(assign.Left);
                            CodeBuilder.AppendFormat(" {0} ", baseOp);
                            VisitExpressionSyntax(assign.Right);
                        }
                    }
                }
            }
            CodeBuilder.AppendFormat("{0}", expTerminater);
            if (expTerminater.Length > 0)
                CodeBuilder.AppendLine();
        }
        private void VisitInvocation(ClassInfo ci, InvocationExpressionSyntax invocation, string expTerminater, bool toplevel)
        {
            string localName = string.Format("__compiler_invoke_{0}", invocation.GetLocation().GetLineSpan().StartLinePosition.Line);
            SymbolInfo symInfo = m_Model.GetSymbolInfo(invocation);
            IMethodSymbol sym = symInfo.Symbol as IMethodSymbol;

            if (null == sym) {
                ReportIllegalSymbol(invocation, symInfo);
            } else {
                //处理ref/out参数
                InvocationInfo ii = new InvocationInfo();
                ii.Init(sym, m_SymbolTable.AssemblySymbol, invocation.ArgumentList, m_SymbolTable.IsUseExplicitTypeParam(sym), m_Model);
                ci.AddReference(sym, ci.SemanticInfo);

                MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                if (null != memberAccess) {
                    if (memberAccess.OperatorToken.Text == "->") {
                        Log(memberAccess, "Unsupported -> member access !");
                    }

                    if (ii.ReturnArgs.Count > 0) {
                        if (!toplevel) {
                            CodeBuilder.AppendFormat("(function() local {0}; {1}, ", localName, localName);
                        }
                        OutputExpressionList(ii.ReturnArgs);
                        CodeBuilder.Append(" = ");
                    }
                    if (sym.IsStatic) {
                        CodeBuilder.Append(ii.ClassKey);
                        CodeBuilder.Append(".");
                    } else {
                        VisitExpressionSyntax(memberAccess.Expression);
                        CodeBuilder.Append(":");
                    }
                    CodeBuilder.Append(NameMangling(sym));
                    CodeBuilder.Append("(");
                    OutputArgumentList(ii.Args, ii.GenericTypeArgs, ii.ArrayToParams);
                    CodeBuilder.Append(")");
                    if (ii.ReturnArgs.Count > 0 && !toplevel) {
                        CodeBuilder.AppendFormat(" return {0}; end)()", localName);
                    }
                    CodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
                } else {
                    if (ii.ReturnArgs.Count > 0) {
                        if (!toplevel) {
                            CodeBuilder.AppendFormat("(function() local {0}; {1}, ", localName, localName);
                        }
                        OutputExpressionList(ii.ReturnArgs);
                        CodeBuilder.Append(" = ");
                    }
                    if (sym.MethodKind == MethodKind.DelegateInvoke) {
                        VisitExpressionSyntax(invocation.Expression);
                    } else if (sym.IsStatic) {
                        CodeBuilder.AppendFormat("{0}.", ii.ClassKey);
                        CodeBuilder.Append(NameMangling(sym));
                    } else {
                        CodeBuilder.Append("this:");
                        CodeBuilder.Append(NameMangling(sym));
                    }
                    CodeBuilder.Append("(");
                    OutputArgumentList(ii.Args, ii.GenericTypeArgs, ii.ArrayToParams);
                    CodeBuilder.Append(")");
                    if (ii.ReturnArgs.Count > 0 && !toplevel) {
                        CodeBuilder.AppendFormat(" return {0}; end)()", localName);
                    }
                    CodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
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
