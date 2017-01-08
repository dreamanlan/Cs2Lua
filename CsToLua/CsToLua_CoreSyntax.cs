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
    internal partial class CsLuaTranslater
    {
        internal void VisitExpressionSyntax(ExpressionSyntax node)
        {
            IOperation oper = m_Model.GetOperation(node);
            if (null != oper && oper.ConstantValue.HasValue) {
                object val = oper.ConstantValue.Value;
                OutputConstValue(val, oper);
                return;
            }
            node.Accept(this);
        }
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
            if (m_SkipGenericTypeDefine && declSym.IsGenericType) {
                node.Accept(new InnerClassAnalysis(m_Model));
                return;
            }
            if (!m_SkipGenericTypeDefine && !ClassInfo.IsOriginalOrContainingGenericType(m_GenericTypeInstance, declSym)) {
                DerivedGenericTypeInstanceInfo instInfo = new DerivedGenericTypeInstanceInfo();
                instInfo.Symbol = declSym;
                instInfo.Node = node;
                instInfo.FillTypeParamsAndArgs(declSym);
                m_DerivedGenericTypeInstances.Enqueue(instInfo);
                return;
            }
            declSym = GetTypeDefineSymbol(declSym);

            ClassInfo ci = new ClassInfo();
            ClassSymbolInfo info;
            m_SymbolTable.ClassSymbols.TryGetValue(ClassInfo.GetFullNameWithTypeParameters(declSym), out info);
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
                string fullBaseClassName = null != declSym.BaseType ? ClassInfo.GetFullName(declSym.BaseType) : string.Empty;
                if (!string.IsNullOrEmpty(fullBaseClassName) && fullBaseClassName != "System.Object" && fullBaseClassName != "System.ValueType") {
                    Log(node, "Cs2Lua class/struct can't inherit !");
                }
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

            TypeInfo typeInfo = m_Model.GetTypeInfo(node);
            var type = typeInfo.Type;

            ++m_Indent;
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
            --m_Indent;
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
            mi.Init(declSym, node);
            m_MethodInfoStack.Push(mi);

            string manglingName = NameMangling(declSym);
            bool isExtension = declSym.IsExtensionMethod;
            if (isExtension && declSym.Parameters.Length > 0) {
                var targetType = declSym.Parameters[0].Type;
                AddReferenceAndTryDeriveGenericTypeInstance(ci, targetType);
                string key = ClassInfo.GetFullName(targetType);
                StringBuilder extensionCodeBuilder;
                if (!ci.ExtensionCodeBuilders.TryGetValue(key, out extensionCodeBuilder)) {
                    extensionCodeBuilder = new StringBuilder();
                    ci.ExtensionCodeBuilders.Add(key, extensionCodeBuilder);
                }

                ++m_Indent;
                ++m_Indent;
                extensionCodeBuilder.AppendFormat("{0}rawset(obj, \"{1}\", {2}.{3});", GetIndentString(), manglingName, ci.Key, manglingName);
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
            if (!mi.ExistTopLevelReturn && mi.ReturnParamNames.Count > 0) {
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
                                if (fieldSym.Type.IsValueType) {
                                    CodeBuilder.AppendLine(" = 0,");
                                } else {
                                    CodeBuilder.AppendLine(" = __cs2lua_nil_field_value,");
                                }
                                if (isStatic) {
                                    ci.CurrentCodeBuilder = ci.StaticInitializerCodeBuilder;
                                } else {
                                    ci.CurrentCodeBuilder = ci.InstanceInitializerCodeBuilder;
                                }
                                CodeBuilder.AppendFormat("{0}{1}.{2}", GetIndentString(), isStatic ? ci.Key : "this", name);
                                CodeBuilder.AppendFormat(" = {0}", fieldSym.Type.TypeKind == TypeKind.Delegate ? "delegationwrap(" : string.Empty);
                                VisitExpressionSyntax(v.Initializer.Value);
                                CodeBuilder.AppendFormat("{0};", fieldSym.Type.TypeKind == TypeKind.Delegate ? ")" : string.Empty);
                                CodeBuilder.AppendLine();
                                if (isStatic) {
                                    ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;
                                } else {
                                    ci.CurrentCodeBuilder = ci.InstanceFieldCodeBuilder;
                                }
                                continue;
                            } else {
                                CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                                CodeBuilder.AppendFormat(" = {0}", fieldSym.Type.TypeKind == TypeKind.Delegate ? "delegationwrap(" : string.Empty);
                                VisitExpressionSyntax(v.Initializer.Value);
                                CodeBuilder.AppendFormat("{0}", fieldSym.Type.TypeKind == TypeKind.Delegate ? ")" : string.Empty);
                            }
                        } else if (fieldSym.Type.TypeKind == TypeKind.Delegate) {
                            CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                            CodeBuilder.Append(" = delegationwrap(");
                            if (null != constVal.Value) {
                                OutputConstValue(constVal.Value, expOper);
                            }
                            CodeBuilder.Append(")");
                        } else {
                            CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                            CodeBuilder.Append(" = ");
                            if (null != constVal.Value) {
                                OutputConstValue(constVal.Value, expOper);
                            } else if (fieldSym.Type.IsValueType) {
                                CodeBuilder.Append("0");
                            } else {
                                CodeBuilder.Append("__cs2lua_nil_field_value");
                            }
                        }
                    } else if (fieldSym.Type.TypeKind == TypeKind.Delegate) {
                        CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                        CodeBuilder.Append(" = wrapdelegation{}");
                    } else if (fieldSym.Type.IsValueType) {
                        CodeBuilder.AppendFormat("{0}{1} = 0", GetIndentString(), name);
                    } else {
                        CodeBuilder.AppendFormat("{0}{1} = __cs2lua_nil_field_value", GetIndentString(), name);
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
                        var expOper = m_Model.GetOperation(v.Initializer.Value);
                        var constVal = expOper.ConstantValue;
                        CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                        CodeBuilder.Append(" = delegationwrap(");
                        if (!constVal.HasValue || constVal.Value != null) {
                            VisitExpressionSyntax(v.Initializer.Value);
                        }
                        CodeBuilder.Append(")");
                    } else {
                        CodeBuilder.AppendFormat("{0}{1} = wrapdelegation{{}}", GetIndentString(), name);
                    }
                    CodeBuilder.Append(",");
                    CodeBuilder.AppendLine();
                }
            }
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
                var leftPsym = leftSym as IPropertySymbol;
                var leftMemberAccess = assign.Left as MemberAccessExpressionSyntax;
                var leftElementAccess = assign.Left as ElementAccessExpressionSyntax;
                var leftCondAccess = assign.Left as ConditionalAccessExpressionSyntax;

                SpecialAssignmentType specialType = SpecialAssignmentType.None;
                if (null != leftMemberAccess && null != leftPsym) {
                    if(!leftPsym.IsStatic) {
                        if (CheckExplicitInterfaceAccess(leftPsym)) {
                            specialType = SpecialAssignmentType.PropExplicitImplementInterface;
                        } else if (SymbolTable.IsBasicValueProperty(leftPsym)) {
                            specialType = SpecialAssignmentType.PropForBasicValueType;
                        }
                    }
                }
                VisitAssignment(ci, op, baseOp, assign, expTerminater, true, leftOper, leftSym, leftPsym, leftMemberAccess, leftElementAccess, leftCondAccess, specialType);
                var oper = m_Model.GetOperation(assign.Right);
                if (null != leftSym && leftSym.Kind == SymbolKind.Local && null != oper && null != oper.Type && oper.Type.TypeKind == TypeKind.Struct && oper.Type.ContainingAssembly == m_SymbolTable.AssemblySymbol) {
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
                    string functor;
                    if (s_UnaryFunctor.TryGetValue(op, out functor)) {
                        CodeBuilder.AppendFormat("{0}(", functor);
                        VisitExpressionSyntax(prefixUnary.Operand);
                    } else {
                        CodeBuilder.Append("(");
                        CodeBuilder.Append(op);
                        CodeBuilder.Append(" ");
                        VisitExpressionSyntax(prefixUnary.Operand);
                    }
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
                        ii.Init(sym, invocation.ArgumentList, m_Model);
                        if (sym.IsStatic) {
                            AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                        }

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
                            ii.OutputInvocation(CodeBuilder, this, memberAccess.Expression, true, m_Model, memberAccess);
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
                            ii.OutputInvocation(CodeBuilder, this, invocation.Expression, false, m_Model, invocation);
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
        private void VisitAssignment(ClassInfo ci, string op, string baseOp, AssignmentExpressionSyntax assign, string expTerminater, bool toplevel, IOperation leftOper, ISymbol leftSym, IPropertySymbol leftPsym, MemberAccessExpressionSyntax leftMemberAccess, ElementAccessExpressionSyntax leftElementAccess, ConditionalAccessExpressionSyntax leftCondAccess, SpecialAssignmentType specialType)
        {
            var assignOper = m_Model.GetOperation(assign);
            InvocationExpressionSyntax invocation = assign.Right as InvocationExpressionSyntax;
            if (specialType == SpecialAssignmentType.PropExplicitImplementInterface) {
                string fnOfIntf = "nil";
                string mname = "nil";
                CheckExplicitInterfaceAccess(leftPsym, ref fnOfIntf, ref mname);
                CodeBuilder.AppendFormat("setwithinterface(");
                VisitExpressionSyntax(leftMemberAccess.Expression);
                CodeBuilder.AppendFormat(", {0}, {1}, ", fnOfIntf, mname);
                VisitExpressionSyntax(assign.Right);
                CodeBuilder.Append(")");
            } else if (specialType == SpecialAssignmentType.PropForBasicValueType) {
                string className = ClassInfo.GetFullName(leftPsym.ContainingType);
                string pname = leftPsym.Name;
                CodeBuilder.AppendFormat("setforbasicvalue(");
                VisitExpressionSyntax(leftMemberAccess.Expression);
                CodeBuilder.AppendFormat(", {0}, \"{1}\", ", className, pname);
                VisitExpressionSyntax(assign.Right);
                CodeBuilder.Append(")");
            } else if (null != leftElementAccess) {
                if (null != leftSym && leftSym.IsStatic) {
                    AddReferenceAndTryDeriveGenericTypeInstance(ci, leftSym);
                }
                if (null != leftPsym && leftPsym.IsIndexer) {
                    CodeBuilder.AppendFormat("set{0}{1}indexer(", leftPsym.ContainingAssembly == m_SymbolTable.AssemblySymbol ? string.Empty : "extern", leftPsym.IsStatic ? "static" : "instance");
                    if (leftPsym.IsStatic) {
                        string fullName = ClassInfo.GetFullName(leftPsym.ContainingType);
                        CodeBuilder.Append(fullName);
                    } else {
                        VisitExpressionSyntax(leftElementAccess.Expression);
                    }
                    CodeBuilder.Append(", ");
                    if (!leftPsym.IsStatic) {
                        string fnOfIntf = "nil";
                        CheckExplicitInterfaceAccess(leftPsym.SetMethod, ref fnOfIntf);
                        CodeBuilder.AppendFormat("{0}, ", fnOfIntf);
                    }
                    string manglingName = NameMangling(leftPsym.SetMethod);
                    CodeBuilder.AppendFormat("\"{0}\", ", manglingName);
                    InvocationInfo ii = new InvocationInfo();
                    ii.Init(leftPsym.SetMethod, leftElementAccess.ArgumentList, m_Model);
                    OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ArrayToParams, false, leftElementAccess);
                    CodeBuilder.Append(", ");
                    VisitExpressionSyntax(assign.Right);
                    CodeBuilder.Append(")");
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
                } else if (null != leftSym) {
                    CodeBuilder.AppendFormat("set{0}{1}element(", leftSym.ContainingAssembly == m_SymbolTable.AssemblySymbol ? string.Empty : "extern", leftSym.IsStatic ? "static" : "instance");
                    if (leftSym.IsStatic) {
                        string fullName = ClassInfo.GetFullName(leftSym.ContainingType);
                        CodeBuilder.Append(fullName);
                    } else {
                        VisitExpressionSyntax(leftElementAccess.Expression);
                    }
                    CodeBuilder.Append(", ");
                    CodeBuilder.AppendFormat("\"{0}\", ", leftSym.Name);
                    VisitBracketedArgumentList(leftElementAccess.ArgumentList);
                    CodeBuilder.Append(", ");
                    VisitExpressionSyntax(assign.Right);
                    CodeBuilder.Append(")");
                } else {
                    Log(assign, "unknown set element symbol !");
                }
            } else if (null != leftCondAccess) {
                CodeBuilder.Append("condaccess(");
                VisitExpressionSyntax(leftCondAccess.Expression);
                CodeBuilder.Append(", ");
                var elementBinding = leftCondAccess.WhenNotNull as ElementBindingExpressionSyntax;
                if (null != elementBinding) {
                    var bindingOper = m_Model.GetOperation(leftCondAccess.WhenNotNull);
                    var symInfo = m_Model.GetSymbolInfo(leftCondAccess.WhenNotNull);
                    var sym = symInfo.Symbol;
                    var psym = sym as IPropertySymbol;
                    if (null != sym && sym.IsStatic) {
                        AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                    }
                    if (null != psym && psym.IsIndexer) {
                        CodeBuilder.Append("(function() return ");
                        CodeBuilder.AppendFormat("set{0}{1}indexer(", psym.ContainingAssembly == m_SymbolTable.AssemblySymbol ? string.Empty : "extern", psym.IsStatic ? "static" : "instance");
                        if (psym.IsStatic) {
                            string fullName = ClassInfo.GetFullName(psym.ContainingType);
                            CodeBuilder.Append(fullName);
                        } else {
                            VisitExpressionSyntax(leftCondAccess.Expression);
                        }
                        CodeBuilder.Append(", ");
                        if (!psym.IsStatic) {
                            string fnOfIntf = "nil";
                            CheckExplicitInterfaceAccess(psym.SetMethod, ref fnOfIntf);
                            CodeBuilder.AppendFormat("{0}, ", fnOfIntf);
                        }
                        string manglingName = NameMangling(psym.SetMethod);
                        CodeBuilder.AppendFormat("\"{0}\", ", manglingName);
                        InvocationInfo ii = new InvocationInfo();
                        List<ExpressionSyntax> args = new List<ExpressionSyntax> { leftCondAccess.WhenNotNull };
                        ii.Init(psym.SetMethod, args, m_Model);
                        OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ArrayToParams, false, leftCondAccess);
                        CodeBuilder.Append(", ");
                        VisitExpressionSyntax(assign.Right);
                        CodeBuilder.Append(")");
                        CodeBuilder.Append("; end)");
                    } else if (bindingOper.Kind == OperationKind.ArrayElementReferenceExpression) {
                        CodeBuilder.Append("(function() ");
                        VisitExpressionSyntax(leftCondAccess.Expression);
                        CodeBuilder.Append("[");
                        VisitExpressionSyntax(leftCondAccess.WhenNotNull);
                        CodeBuilder.Append(" + 1] = ");
                        VisitExpressionSyntax(assign.Right);
                        CodeBuilder.Append("; return ");
                        VisitExpressionSyntax(assign.Right);
                        CodeBuilder.Append("; end)");
                    } else if (null != sym) {
                        CodeBuilder.Append("(function() return ");
                        CodeBuilder.AppendFormat("set{0}{1}element(", sym.ContainingAssembly == m_SymbolTable.AssemblySymbol ? string.Empty : "extern", sym.IsStatic ? "static" : "instance");
                        if (sym.IsStatic) {
                            string fullName = ClassInfo.GetFullName(sym.ContainingType);
                            CodeBuilder.Append(fullName);
                        } else {
                            VisitExpressionSyntax(leftCondAccess.Expression);
                        }
                        CodeBuilder.Append(", ");
                        CodeBuilder.AppendFormat("\"{0}\", ", leftSym.Name);
                        VisitExpressionSyntax(leftCondAccess.WhenNotNull);
                        CodeBuilder.Append(", ");
                        VisitExpressionSyntax(assign.Right);
                        CodeBuilder.Append(")");
                        CodeBuilder.Append("; end)");
                    } else {
                        ReportIllegalSymbol(assign, symInfo);
                    }
                } else {
                    CodeBuilder.Append("(function() ");
                    VisitExpressionSyntax(leftCondAccess.Expression);
                    VisitExpressionSyntax(leftCondAccess.WhenNotNull);
                    CodeBuilder.Append(" = ");
                    VisitExpressionSyntax(assign.Right);
                    CodeBuilder.Append("; return ");
                    VisitExpressionSyntax(assign.Right);
                    CodeBuilder.Append("; end)");
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
                            string intf = "nil";
                            string mname = string.Format("\"{0}\"", memberAccess.Name.Identifier.Text);
                            CheckExplicitInterfaceAccess(leftSym, ref intf, ref mname);
                            CodeBuilder.AppendFormat("{0}, {1}", intf, mname);
                        } else if (leftSym.ContainingType == ci.SemanticInfo || ci.IsInherit(leftSym.ContainingType)) {
                            CodeBuilder.Append("this, nil, ");
                            CodeBuilder.AppendFormat("\"{0}\"", leftSym.Name);
                        } else {
                            VisitExpressionSyntax(assign.Left);
                            CodeBuilder.Append(", nil, nil");
                        }
                    } else {
                        VisitExpressionSyntax(assign.Left);
                        CodeBuilder.Append(", nil, nil");
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
                    ii.Init(sym, invocation.ArgumentList, m_Model);
                    if (sym.IsStatic) {
                        AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                    }

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
                        ii.OutputInvocation(CodeBuilder, this, memberAccess.Expression, true, m_Model, memberAccess);
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
                        ii.OutputInvocation(CodeBuilder, this, invocation.Expression, false, m_Model, invocation);
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
                        ii.Init(msym, arglist, m_Model);
                        OutputOperatorInvoke(ii, assign);
                    } else {
                        ProcessBinaryOperator(assign, ref baseOp);
                        string functor;
                        if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                            CodeBuilder.AppendFormat("{0}(", functor);
                            VisitExpressionSyntax(assign.Left);
                            CodeBuilder.Append(", ");
                            VisitExpressionSyntax(assign.Right);
                            CodeBuilder.Append(")");
                        } else if (baseOp == "+") {
                            ProcessAddOrStringConcat(assign.Left, assign.Right);
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
                ii.Init(sym, invocation.ArgumentList, m_Model);
                if (sym.IsStatic) {
                    AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                }

                MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                if (null != memberAccess) {
                    if (memberAccess.OperatorToken.Text == "->") {
                        Log(memberAccess, "Unsupported -> member access !");
                    }

                    if (ii.ReturnArgs.Count > 0) {
                        if (!toplevel) {
                            CodeBuilder.AppendFormat("(function() local {0}; {1}, ", localName, localName);
                        } else if (!sym.ReturnsVoid) {
                            CodeBuilder.AppendFormat("local {0}; {1}, ", localName, localName);
                        }
                        OutputExpressionList(ii.ReturnArgs);
                        CodeBuilder.Append(" = ");
                    }
                    ii.OutputInvocation(CodeBuilder, this, memberAccess.Expression, true, m_Model, memberAccess);
                    if (ii.ReturnArgs.Count > 0) {
                        if (!toplevel) {
                            CodeBuilder.AppendFormat(" return {0}; end)()", localName);
                        }
                    }
                    CodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
                } else {
                    if (ii.ReturnArgs.Count > 0) {
                        if (!toplevel) {
                            CodeBuilder.AppendFormat("(function() local {0}; {1}, ", localName, localName);
                        } else if (!sym.ReturnsVoid) {
                            CodeBuilder.AppendFormat("local {0}; {1}, ", localName, localName);
                        }
                        OutputExpressionList(ii.ReturnArgs);
                        CodeBuilder.Append(" = ");
                    }
                    ii.OutputInvocation(CodeBuilder, this, invocation.Expression, false, m_Model, invocation);
                    if (ii.ReturnArgs.Count > 0) {
                        if (!toplevel) {
                            CodeBuilder.AppendFormat(" return {0}; end)()", localName);
                        }
                    }
                    CodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
                }
            }
        }
    }
}