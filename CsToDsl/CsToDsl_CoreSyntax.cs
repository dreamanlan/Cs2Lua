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
                        op = op == "++" ? "+" : "-";
                        string type = "null";
                        string typeKind = "null";
                        IConversionExpression opd = null;
                        var assignOper = m_Model.GetOperation(postfixUnary) as ICompoundAssignmentExpression; 
                        if (null != assignOper && null != assignOper.Target) {
                            var typeSym = assignOper.Target.Type;
                            type = ClassInfo.GetFullName(typeSym);
                            typeKind = "TypeKind." + typeSym.TypeKind.ToString();
                            opd = assignOper.Value as IConversionExpression;
                        }
                        CodeBuilder.AppendFormat("{0}", GetIndentString());
                        OutputExpressionSyntax(postfixUnary.Operand, opd);
                        CodeBuilder.Append(" = ");
                        if (null != assignOper && assignOper.UsesOperatorMethod) {
                            IMethodSymbol msym = assignOper.OperatorMethod;
                            InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                            var arglist = new List<ExpressionSyntax>() { postfixUnary.Operand };
                            ii.Init(msym, arglist, m_Model, opd);
                            OutputOperatorInvoke(ii, postfixUnary);
                            CodeBuilder.AppendFormat("{0}", expTerminater);
                        } else {
                            CodeBuilder.Append("execbinary(");
                            CodeBuilder.AppendFormat("\"{0}\", ", op);
                            OutputExpressionSyntax(postfixUnary.Operand);
                            CodeBuilder.AppendFormat(", 1, {0}, {1}, {2}, {3}", type, type, typeKind, typeKind);
                            CodeBuilder.AppendFormat("){0}", expTerminater);
                        }
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
            SymbolTable.Instance.ClassSymbols.TryGetValue(ClassInfo.GetFullNameWithTypeParameters(declSym), out info);
            ci.Init(declSym, info);
            if (null != declSym) {
                string[] requires = ClassInfo.GetAttributeArguments<string>(declSym, "Cs2Lua.RequireAttribute", 0);
                if (null != requires) {
                    foreach (var req in requires) {
                        SymbolTable.Instance.AddRequire(ci.Key, req);
                    }
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
                if (!string.IsNullOrEmpty(fullBaseClassName) && fullBaseClassName != SymbolTable.PrefixExternClassName("System.Object") && fullBaseClassName != SymbolTable.PrefixExternClassName("System.ValueType")) {
                    Log(node, "Cs2Dsl class/struct can't inherit !");
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
                string[] requires = ClassInfo.GetAttributeArguments<string>(declSym, "Cs2Lua.RequireAttribute", 0);
                if (null != requires) {
                    foreach (var req in requires) {
                        SymbolTable.Instance.AddRequire(ci.Key, req);
                    }
                }
                if (ClassInfo.HasAttribute(declSym, "Cs2Lua.IgnoreAttribute"))
                    return;
                if (declSym.IsAbstract)
                    return;
                if (null == body && null == expressionBody) //partial method declaration
                    return;
            }

            var mi = new MethodInfo();
            mi.Init(declSym, node);
            m_MethodInfoStack.Push(mi);

            TryCatchAnalysis tryCatch = new TryCatchAnalysis();
            tryCatch.Visit(node);
            mi.ExistTryCatch = tryCatch.Exist;
            
            string manglingName = NameMangling(declSym);
            bool isExtension = declSym.IsExtensionMethod;
            if (isExtension && declSym.Parameters.Length > 0) {
                var targetType = declSym.Parameters[0].Type;
                AddReferenceAndTryDeriveGenericTypeInstance(ci, targetType);
            }
            bool isStatic = declSym.IsStatic;
            CodeBuilder.AppendFormat("{0}{1} = {2}function({3}", GetIndentString(), manglingName, mi.ExistYield ? "wrapenumerable(" : string.Empty, isStatic ? string.Empty : "this");
            if (mi.ParamNames.Count > 0) {
                if (!isStatic) {
                    CodeBuilder.Append(", ");
                }
                CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
            }
            CodeBuilder.Append("){");
            CodeBuilder.AppendLine();
            ++m_Indent;

            string dslModule = ClassInfo.GetAttributeArgument<string>(declSym, "Cs2Lua.TranslateToAttribute", 0);
            string dslFuncName = ClassInfo.GetAttributeArgument<string>(declSym, "Cs2Lua.TranslateToAttribute", 1);
            if (string.IsNullOrEmpty(dslModule) && string.IsNullOrEmpty(dslFuncName)) {
                if (!declSym.ReturnsVoid && mi.ExistTryCatch) {
                    string retVar = string.Format("__method_ret_{0}", GetSourcePosForVar(node));
                    mi.ReturnVarName = retVar;

                    CodeBuilder.AppendFormat("{0}local({1}); {1} = nil;", GetIndentString(), retVar);
                    CodeBuilder.AppendLine();
                }
                if (mi.ValueParams.Count > 0) {
                    OutputWrapValueParams(CodeBuilder, mi);
                }
                if (!string.IsNullOrEmpty(mi.OriginalParamsName)) {
                    CodeBuilder.AppendFormat("{0}local{{{1} = params({2});}};", GetIndentString(), mi.OriginalParamsName, mi.ParamsIsExternValueType ? 2 : (mi.ParamsIsValueType ? 1 : 0));
                    CodeBuilder.AppendLine();
                }
            }
            if (!string.IsNullOrEmpty(dslModule) || !string.IsNullOrEmpty(dslFuncName)) {
                if (!string.IsNullOrEmpty(dslModule)) {
                    SymbolTable.Instance.AddRequire(ci.Key, dslModule);
                }
                if (declSym.ReturnsVoid && mi.ReturnParamNames.Count <= 0) {
                    CodeBuilder.AppendFormat("{0}{1}({2}", GetIndentString(), dslFuncName, isStatic ? string.Empty : "this");
                } else {
                    CodeBuilder.AppendFormat("{0}return({1}({2}", GetIndentString(), dslFuncName, isStatic ? string.Empty : "this");
                }
                if (mi.ParamNames.Count > 0) {
                    if (!isStatic) {
                        CodeBuilder.Append(", ");
                    }
                    CodeBuilder.Append(string.Join(", ", mi.ParamNames.ToArray()));
                }
                if (!declSym.ReturnsVoid || mi.ParamNames.Count > 0) {
                    CodeBuilder.Append(")");
                }
                CodeBuilder.AppendLine(");");
            } else if (null != body) {
                VisitBlock(body);
                if (!mi.ExistTopLevelReturn) {
                    if (declSym.ReturnsVoid) {
                        if (mi.ReturnParamNames.Count > 0) {
                            CodeBuilder.AppendFormat("{0}return({1});", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                            CodeBuilder.AppendLine();
                        }
                    } else {
                        if (mi.ExistTryCatch) {
                            CodeBuilder.AppendFormat("{0}return({1}, {2});", GetIndentString(), mi.ReturnVarName, string.Join(", ", mi.ReturnParamNames));
                            CodeBuilder.AppendLine();
                        } else if (mi.ReturnParamNames.Count > 0) {
                            CodeBuilder.AppendFormat("{0}return(nil, {1});", GetIndentString(), string.Join(", ", mi.ReturnParamNames));
                            CodeBuilder.AppendLine();
                        } else {
                            CodeBuilder.AppendFormat("{0}return(nil);", GetIndentString());
                            CodeBuilder.AppendLine();
                        }
                    }
                }
            } else if (null != expressionBody) {
                string varName = string.Format("__expbody_{0}", GetSourcePosForVar(node));
                if (!declSym.ReturnsVoid) {
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("{0}local({1}); {1} = ", GetIndentString(), varName);
                    } else {
                        CodeBuilder.AppendFormat("{0}return(", GetIndentString());
                    }
                }
                IConversionExpression opd = null;
                var oper = m_Model.GetOperation(expressionBody) as IBlockStatement;
                if (null != oper && oper.Statements.Length == 1) {
                    var iret = oper.Statements[0] as IReturnStatement;
                    if (null != iret) {
                        opd = iret.ReturnedValue as IConversionExpression;
                    }
                }
                if (declSym.ReturnsVoid) {
                    CodeBuilder.AppendFormat("{0}", GetIndentString());
                    if (expressionBody.Expression is AssignmentExpressionSyntax) {
                        VisitToplevelExpressionFirstPass(expressionBody.Expression, string.Empty);
                    } else {
                        OutputExpressionSyntax(expressionBody.Expression, opd);
                    }
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("; return({0})", string.Join(", ", mi.ReturnParamNames));
                    }
                    CodeBuilder.AppendLine(";");
                } else {
                    OutputExpressionSyntax(expressionBody.Expression, opd);
                    if (mi.ReturnParamNames.Count > 0) {
                        CodeBuilder.AppendFormat("; return({0}, {1})", varName, string.Join(", ", mi.ReturnParamNames));
                    } else {
                        CodeBuilder.AppendFormat("; return({0})", varName);
                    }
                    CodeBuilder.AppendLine(";");
                }
            }
            --m_Indent;
            CodeBuilder.AppendFormat("{0}}}{1};", GetIndentString(), mi.ExistYield ? ")" : string.Empty);
            CodeBuilder.AppendLine();
            m_MethodInfoStack.Pop();
        }
        private void VisitFieldDeclaration(ClassInfo ci, FieldDeclarationSyntax fieldDecl, bool isStatic)
        {
            foreach (var v in fieldDecl.Declaration.Variables) {
                var baseSym = m_Model.GetDeclaredSymbol(v);
                if (null != baseSym) {
                    string[] requires = ClassInfo.GetAttributeArguments<string>(baseSym, "Cs2Lua.RequireAttribute", 0);
                    if (null != requires) {
                        foreach (var req in requires) {
                            SymbolTable.Instance.AddRequire(ci.Key, req);
                        }
                    }
                    if (ClassInfo.HasAttribute(baseSym, "Cs2Lua.IgnoreAttribute"))
                        continue;
                } else {
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
                        IConversionExpression opd = null;
                        var initOper = m_Model.GetOperation(v.Initializer) as ISymbolInitializer;
                        if (null != initOper) {
                            opd = initOper.Value as IConversionExpression;
                        }
                        var expOper = m_Model.GetOperation(v.Initializer.Value);
                        var constVal = expOper.ConstantValue;
                        if (!constVal.HasValue) {
                            bool useExplicitTypeParam = SymbolTable.Instance.IsUseExplicitTypeParam(fieldSym);
                            bool createSelf = SymbolTable.Instance.IsFieldCreateSelf(fieldSym);
                            if (useExplicitTypeParam || createSelf) {
                                CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                                CodeBuilder.Append(" = ");
                                OutputDefaultValue(type);
                                CodeBuilder.AppendLine(";");
                                if (isStatic) {
                                    ci.CurrentCodeBuilder = ci.StaticInitializerCodeBuilder;
                                    ci.ClassSemanticInfo.GenerateBasicCctor = true;
                                } else {
                                    ci.CurrentCodeBuilder = ci.InstanceInitializerCodeBuilder;
                                    ci.ClassSemanticInfo.GenerateBasicCtor = true;
                                }
                                ++m_Indent;
                                CodeBuilder.AppendFormat("{0}{1}.{2}", GetIndentString(), isStatic ? ci.Key : "this", name);
                                CodeBuilder.Append(" = ");
                                OutputExpressionSyntax(v.Initializer.Value, opd);
                                CodeBuilder.Append(";");
                                CodeBuilder.AppendLine();
                                --m_Indent;
                                if (isStatic) {
                                    ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;
                                } else {
                                    ci.CurrentCodeBuilder = ci.InstanceFieldCodeBuilder;
                                }
                                continue;
                            } else {
                                CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                                CodeBuilder.Append(" = ");
                                OutputExpressionSyntax(v.Initializer.Value, opd);
                            }
                        } else if (type.TypeKind == TypeKind.Delegate) {
                            CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                            CodeBuilder.Append(" = ");
                            if (null != constVal.Value) {
                                OutputConstValue(constVal.Value, expOper);
                            } else {
                                CodeBuilder.Append("null");
                            }
                        } else {
                            CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                            CodeBuilder.Append(" = ");
                            if (null != constVal.Value) {
                                OutputConstValue(constVal.Value, expOper);
                            } else if (type.IsValueType) {
                                OutputDefaultValue(type);
                                if (isStatic) {
                                    ci.CurrentCodeBuilder = ci.StaticInitializerCodeBuilder;
                                    ci.ClassSemanticInfo.GenerateBasicCctor = true;
                                } else {
                                    ci.CurrentCodeBuilder = ci.InstanceInitializerCodeBuilder;
                                    ci.ClassSemanticInfo.GenerateBasicCtor = true;
                                }
                                ++m_Indent;
                                CodeBuilder.AppendFormat("{0}{1}.{2}", GetIndentString(), isStatic ? ci.Key : "this", name);
                                string fullTypeName = ClassInfo.GetFullName(type);
                                if (SymbolTable.Instance.IsCs2DslSymbol(type)) {
                                    CodeBuilder.AppendFormat(" = new {0}();", fullTypeName);
                                } else {
                                    CodeBuilder.AppendFormat(" = newexternobject({0}, \"{0}\", null, null);", fullTypeName);
                                }
                                CodeBuilder.AppendLine();
                                --m_Indent;
                                if (isStatic) {
                                    ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;
                                } else {
                                    ci.CurrentCodeBuilder = ci.InstanceFieldCodeBuilder;
                                }
                            } else {
                                OutputDefaultValue(type);                            
							}
                        }
                    } else if (type.IsValueType) {
                        if (SymbolTable.IsBasicType(type)) {
                            CodeBuilder.AppendFormat("{0}{1} = ", GetIndentString(), name);
                            OutputDefaultValue(type);
                        } else {
                            CodeBuilder.AppendFormat("{0}{1} = ", GetIndentString(), name);
                            OutputDefaultValue(type);
                            if (isStatic) {
                                ci.CurrentCodeBuilder = ci.StaticInitializerCodeBuilder;
                                ci.ClassSemanticInfo.GenerateBasicCctor = true;
                            } else {
                                ci.CurrentCodeBuilder = ci.InstanceInitializerCodeBuilder;
                                ci.ClassSemanticInfo.GenerateBasicCtor = true;
                            }
                            ++m_Indent;
                            CodeBuilder.AppendFormat("{0}{1}.{2}", GetIndentString(), isStatic ? ci.Key : "this", name);
                            string fullTypeName = ClassInfo.GetFullName(type);
                            if (SymbolTable.Instance.IsCs2DslSymbol(type)) {
                                CodeBuilder.AppendFormat(" = new {0}();", fullTypeName);
                            } else {
                                CodeBuilder.AppendFormat(" = newexternobject({0}, \"{0}\", null, null);", fullTypeName);
                            }
                            CodeBuilder.AppendLine();
                            --m_Indent;
                            if (isStatic) {
                                ci.CurrentCodeBuilder = ci.StaticFieldCodeBuilder;
                            } else {
                                ci.CurrentCodeBuilder = ci.InstanceFieldCodeBuilder;
                            }
                        }
                    } else {
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
                    string[] requires = ClassInfo.GetAttributeArguments<string>(baseSym, "Cs2Lua.RequireAttribute", 0);
                    if (null != requires) {
                        foreach (var req in requires) {
                            SymbolTable.Instance.AddRequire(ci.Key, req);
                        }
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
                        IConversionExpression opd = null;
                        var initOper = m_Model.GetOperation(v.Initializer) as ISymbolInitializer;
                        if (null != initOper) {
                            opd = initOper.Value as IConversionExpression;
                        }
                        var expOper = m_Model.GetOperation(v.Initializer.Value);
                        var constVal = expOper.ConstantValue;
                        CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), name);
                        CodeBuilder.Append(" = ");
                        if (!constVal.HasValue || constVal.Value != null) {
                            OutputExpressionSyntax(v.Initializer.Value, opd);
                        }
                    } else {
                        CodeBuilder.AppendFormat("{0}{1} = null", GetIndentString(), name);
                    }
                    CodeBuilder.Append(";");
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
                var leftEsym = leftSym as IEventSymbol;
                var leftFsym = leftSym as IFieldSymbol;
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
                VisitAssignment(ci, op, baseOp, assign, expTerminater, true, leftOper, leftSym, leftPsym, leftEsym, leftFsym, leftMemberAccess, leftElementAccess, leftCondAccess, specialType);
                var oper = m_Model.GetOperation(assign.Right);
                if (null != leftSym && leftSym.Kind == SymbolKind.Local && null != oper && null != oper.Type && oper.Type.TypeKind == TypeKind.Struct && SymbolTable.Instance.IsCs2DslSymbol(oper.Type)) {
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
                var oper = m_Model.GetOperation(prefixUnary);
                IConversionExpression opd = null;
                var unaryOper = oper as IUnaryOperatorExpression;
                if (null != unaryOper) {
                    opd = unaryOper.Operand as IConversionExpression;
                }
                var assignOper = oper as ICompoundAssignmentExpression;
                if (null != assignOper) {
                    opd = assignOper.Value as IConversionExpression;
                }
                ITypeSymbol typeSym = null;
                string type = "null";
                string typeKind = "null";
                if (null != unaryOper && null != unaryOper.Operand) {
                    typeSym = unaryOper.Operand.Type;
                } else if (null != assignOper && null != assignOper.Target) {
                    typeSym = assignOper.Target.Type;
                }
                if (null != typeSym) {
                    type = ClassInfo.GetFullName(typeSym);
                    typeKind = "TypeKind." + typeSym.TypeKind.ToString();
                }
                if (null != unaryOper && unaryOper.UsesOperatorMethod) {
                    IMethodSymbol msym = unaryOper.OperatorMethod;
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                    var arglist = new List<ExpressionSyntax>() { prefixUnary.Operand };
                    ii.Init(msym, arglist, m_Model, opd);
                    OutputOperatorInvoke(ii, prefixUnary);
                } else if (null != assignOper && assignOper.UsesOperatorMethod) {
                    OutputExpressionSyntax(prefixUnary.Operand, opd);
                    CodeBuilder.Append(" = ");
                    IMethodSymbol msym = assignOper.OperatorMethod;
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                    var arglist = new List<ExpressionSyntax>() { prefixUnary.Operand };
                    ii.Init(msym, arglist, m_Model, opd);
                    OutputOperatorInvoke(ii, prefixUnary);
                } else {
                    string op = prefixUnary.OperatorToken.Text;
                    if (op == "++" || op == "--") {
                        op = op == "++" ? "+" : "-";
                        OutputExpressionSyntax(prefixUnary.Operand, opd);
                        CodeBuilder.Append(" = ");
                        CodeBuilder.Append("execbinary(");
                        CodeBuilder.AppendFormat("\"{0}\", ", op);
                        OutputExpressionSyntax(prefixUnary.Operand, opd);
                        CodeBuilder.AppendFormat(", 1, {0}, {1}, {2}, {3}", type, type, typeKind, typeKind);
                        CodeBuilder.AppendFormat("){0}", expTerminater);
                        if (expTerminater.Length > 0)
                            CodeBuilder.AppendLine();
                    } else {
                        ProcessUnaryOperator(expression, ref op);
                        string functor;
                        if (s_UnaryFunctor.TryGetValue(op, out functor)) {
                            CodeBuilder.AppendFormat("{0}(", functor);
                            OutputExpressionSyntax(prefixUnary.Operand, opd);
                        } else {
                            CodeBuilder.Append("execunary(");
                            CodeBuilder.AppendFormat("\"{0}\", ", op);
                            OutputExpressionSyntax(prefixUnary.Operand, opd);
                            CodeBuilder.AppendFormat(", {0}, {1}", type, typeKind);
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
                var oper = m_Model.GetOperation(postfixUnary);
                IConversionExpression opd = null;
                var assignOper = oper as ICompoundAssignmentExpression;
                if (null != assignOper) {
                    opd = assignOper.Value as IConversionExpression;
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
                if (null != assignOper && assignOper.UsesOperatorMethod) {
                    OutputExpressionSyntax(postfixUnary.Operand, opd);
                    CodeBuilder.Append(" = ");
                    IMethodSymbol msym = assignOper.OperatorMethod;
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                    var arglist = new List<ExpressionSyntax>() { postfixUnary.Operand };
                    ii.Init(msym, arglist, m_Model, opd);
                    OutputOperatorInvoke(ii, postfixUnary);
                } else {
                    string op = postfixUnary.OperatorToken.Text;
                    if (op == "++" || op == "--") {
                        op = op == "++" ? "+" : "-";
                        OutputExpressionSyntax(postfixUnary.Operand, opd);
                        CodeBuilder.Append(" = ");
                        CodeBuilder.Append("execbinary(");
                        CodeBuilder.AppendFormat("\"{0}\", ", op);
                        OutputExpressionSyntax(postfixUnary.Operand, opd);
                        CodeBuilder.AppendFormat(", 1, {0}, {1}, {2}, {3}", type, type, typeKind, typeKind);
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
        private void VisitLocalVariableDeclarator(ClassInfo ci, VariableDeclaratorSyntax node)
        {
            var declSym = m_Model.GetDeclaredSymbol(node) as ILocalSymbol;
            var namedTypeSym = null != declSym ? declSym.Type as INamedTypeSymbol : null;
            if (null != node.Initializer) {
                var oper = m_Model.GetOperation(node.Initializer) as IVariableDeclarationStatement;
                IConversionExpression opd = null;
                if (null != oper && oper.Variables.Length == 1) {
                    opd = oper.Variables[0].InitialValue as IConversionExpression;
                }
                var token = node.Initializer.EqualsToken;
                var invocation = node.Initializer.Value as InvocationExpressionSyntax;
                if (null != invocation) {
                    string localName = string.Format("__localdecl_{0}", GetSourcePosForVar(invocation));
                    SymbolInfo symInfo = m_Model.GetSymbolInfo(invocation);
                    IMethodSymbol sym = symInfo.Symbol as IMethodSymbol;

                    if (null == sym) {
                        ReportIllegalSymbol(invocation, symInfo);
                    } else {
                        //处理ref/out参数
                        InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                        ii.Init(sym, invocation.ArgumentList, m_Model);
                        if (sym.IsStatic || sym.IsExtensionMethod) {
                            AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                        }
                        int ct = ii.ReturnArgs.Count;
                        bool useOperator = false;
                        if (null != opd && opd.UsesOperatorMethod) {
                            useOperator = true;
                            IMethodSymbol msym = opd.OperatorMethod;
                            InvocationInfo iop = new InvocationInfo(GetCurMethodSemanticInfo());
                            iop.Init(msym, (List<ExpressionSyntax>)null, m_Model);
                            CodeBuilder.AppendFormat("{0}local({1}); {2}", GetIndentString(), node.Identifier.Text, node.Identifier.Text);
                            CodeBuilder.AppendFormat(" {0} ", token.Text);
                            OutputConversionInvokePrefix(iop);
                            if (ct > 0) {
                                CodeBuilder.AppendFormat("(function(){{ local({0}); multiassign({1}", localName, localName);
                            }
                        } else {
                            if (ct > 0)
                                CodeBuilder.AppendFormat("{0}local({1}); multiassign({2}", GetIndentString(), node.Identifier.Text, node.Identifier.Text);
                            else
                                CodeBuilder.AppendFormat("{0}local({1}); {2}", GetIndentString(), node.Identifier.Text, node.Identifier.Text);
                        }
                        MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                        if (null != memberAccess) {
                            if (memberAccess.OperatorToken.Text == "->") {
                                Log(memberAccess, "Unsupported -> member access !");
                            }
                            if (ct > 0) {
                                CodeBuilder.Append(", ");
                                OutputExpressionList(ii.ReturnArgs);
                                CodeBuilder.AppendFormat(") {0} ", token.Text);
                            } else if (!useOperator) {
                                CodeBuilder.AppendFormat(" {0} ", token.Text);
                            }
                            ii.OutputInvocation(CodeBuilder, this, memberAccess.Expression, true, m_Model, memberAccess);
                        } else {
                            if (ct > 0) {
                                CodeBuilder.Append(", ");
                                OutputExpressionList(ii.ReturnArgs);
                                CodeBuilder.AppendFormat(") {0} ", token.Text);
                            } else if (!useOperator) {
                                CodeBuilder.AppendFormat(" {0} ", token.Text);
                            }
                            ii.OutputInvocation(CodeBuilder, this, invocation.Expression, false, m_Model, invocation);
                        } 
                        if (useOperator) {
                            if (ct > 0) {
                                CodeBuilder.AppendFormat("; return({0}); }})()", localName);
                            }
                            CodeBuilder.Append(")");
                        }
                    }
                } else {
                    CodeBuilder.AppendFormat("{0}local({1}); {2}", GetIndentString(), node.Identifier.Text, node.Identifier.Text);
                    CodeBuilder.AppendFormat(" {0} ", token.Text);
                    var init = node.Initializer;
                    OutputExpressionSyntax(init.Value, opd);
                }
            } else if (null != namedTypeSym && namedTypeSym.IsValueType && !SymbolTable.IsBasicType(namedTypeSym)) {
                var block = GetParentBlockNode(node);
                LocalVariableAccessAnalysis analysis = new LocalVariableAccessAnalysis(node.Identifier.Text);
                analysis.Visit(block);
                if (analysis.NeedInitOnDeclaration) {
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

                    CodeBuilder.AppendFormat("{0}local{{{1} = ", GetIndentString(), node.Identifier.Text);

                    if (isCollection) {
                        bool isDictionary = IsImplementationOfSys(namedTypeSym, "IDictionary");
                        bool isList = IsImplementationOfSys(namedTypeSym, "IList");
                        if (isDictionary) {
                            //字典对象的处理
                            CodeBuilder.AppendFormat("new{0}dictionary({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                            CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                        } else if (isList) {
                            //列表对象的处理
                            CodeBuilder.AppendFormat("new{0}list({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                            CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                        } else {
                            //集合对象的处理
                            CodeBuilder.AppendFormat("new{0}collection({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                            CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                        }
                    } else {
                        CodeBuilder.AppendFormat("new{0}object({1}, ", isExternal ? "extern" : string.Empty, fullTypeName);
                        CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                    }
                    if (!isExternal) {
                        //外部对象函数名不会换名，所以没必要提供名字，总是ctor
                        if (string.IsNullOrEmpty(ctor)) {
                            CodeBuilder.Append(", null");
                        } else {
                            CodeBuilder.AppendFormat(", \"{0}\"", ctor);
                        }
                    }
                    if (isCollection) {
                        bool isDictionary = IsImplementationOfSys(namedTypeSym, "IDictionary");
                        bool isList = IsImplementationOfSys(namedTypeSym, "IList");
                        if (isDictionary)
                            CodeBuilder.Append(", literaldictionary()");
                        else if (isList)
                            CodeBuilder.Append(", literallist()");
                        else
                            CodeBuilder.Append(", literalcollection()");
                    } else {
                        CodeBuilder.Append(", null");
                    }
                    CodeBuilder.Append(");}");
                } else {
                    CodeBuilder.AppendFormat("{0}local({1})", GetIndentString(), node.Identifier.Text);
                }
            } else {
                CodeBuilder.AppendFormat("{0}local({1})", GetIndentString(), node.Identifier.Text);
            }
            CodeBuilder.AppendLine(";");
        }
        private void VisitAssignment(ClassInfo ci, string op, string baseOp, AssignmentExpressionSyntax assign, string expTerminater, bool toplevel, IOperation leftOper, ISymbol leftSym, IPropertySymbol leftPsym, IEventSymbol leftEsym, IFieldSymbol leftFsym, MemberAccessExpressionSyntax leftMemberAccess, ElementAccessExpressionSyntax leftElementAccess, ConditionalAccessExpressionSyntax leftCondAccess, SpecialAssignmentType specialType)
        {
            var assignOper = m_Model.GetOperation(assign);
            IConversionExpression opd = null, lopd = null, ropd = null;
            var assignInfo = assignOper as IAssignmentExpression;
            if (null != assignInfo) {
                opd = assignInfo.Value as IConversionExpression;
            }
            var compAssignInfo = assignOper as ICompoundAssignmentExpression;
            if (null != compAssignInfo) {
                lopd = compAssignInfo.Target as IConversionExpression;
                ropd = compAssignInfo.Value as IConversionExpression;
            }
            InvocationExpressionSyntax invocation = assign.Right as InvocationExpressionSyntax;
            if (specialType == SpecialAssignmentType.PropExplicitImplementInterface) {
                string fnOfIntf = "null";
                string mname = "null";
                CheckExplicitInterfaceAccess(leftPsym, ref fnOfIntf, ref mname);
                CodeBuilder.AppendFormat("setwithinterface(");
                OutputExpressionSyntax(leftMemberAccess.Expression);
                CodeBuilder.AppendFormat(", {0}, {1}, ", fnOfIntf, mname);
                OutputExpressionSyntax(assign.Right, opd);
                CodeBuilder.Append(")");
            } else if (specialType == SpecialAssignmentType.PropForBasicValueType) {
                string className = ClassInfo.GetFullName(leftPsym.ContainingType);
                bool isEnumClass = leftPsym.ContainingType.TypeKind == TypeKind.Enum || className == SymbolTable.PrefixExternClassName("System.Enum");
                string pname = leftPsym.Name;
                string ckey = InvocationInfo.CalcInvokeTarget(isEnumClass, className, this, leftMemberAccess.Expression, m_Model);
                CodeBuilder.AppendFormat("setforbasicvalue(");
                OutputExpressionSyntax(leftMemberAccess.Expression);
                CodeBuilder.AppendFormat(", {0}, {1}, \"{2}\", ", isEnumClass ? "true" : "false", ckey, pname);
                OutputExpressionSyntax(assign.Right, opd);
                CodeBuilder.Append(")");
            } else if (null != leftElementAccess) {
                VisitAssignmentLeftElementAccess(ci, assign, toplevel, leftOper, leftSym, leftPsym, leftElementAccess, opd);
            } else if (null != leftCondAccess) {
                VisitAssignmentLeftCondAccess(ci, assign, leftSym, leftCondAccess, opd);
            } else if (leftOper.Type.TypeKind == TypeKind.Delegate) {
                bool isMemberAccess = null != leftPsym || null != leftEsym || null != leftFsym;
                if (isMemberAccess) {
                    string className = ClassInfo.GetFullName(leftSym.ContainingType);
                    string memberName = leftSym.Name;
                    if (leftSym.IsStatic) {
                        CodeBuilder.Append("setstaticdelegation(");
                        CodeBuilder.Append(className);
                        CodeBuilder.AppendFormat(", \"{0}\", ", memberName);
                    } else {
                        CodeBuilder.Append("setinstancedelegation(");
                        if (null != leftMemberAccess)
                            OutputExpressionSyntax(leftMemberAccess.Expression);
                        else if (IsNewObjMember(memberName))
                            CodeBuilder.Append("newobj");
                        else
                            CodeBuilder.Append("this");
                        CodeBuilder.AppendFormat(", \"{0}\", ", memberName);
                    }
                } else {
                    CodeBuilder.Append("setdelegation(");
                    OutputExpressionSyntax(assign.Left);
                    CodeBuilder.Append(", ");
                }
                VisitAssignmentDelegation(ci, op, baseOp, assign, leftOper, leftSym, opd);
                CodeBuilder.Append(")");
            } else if (null != invocation) {
                VisitAssignmentInvocation(ci, op, baseOp, assign, invocation, opd, lopd, ropd, compAssignInfo);
            } else {
                bool isMemberAccess = null != leftPsym || null != leftEsym || null != leftFsym;
                if (op == "=") {
                    if (isMemberAccess) {
                        string className = ClassInfo.GetFullName(leftSym.ContainingType);
                        string memberName = leftSym.Name;
                        if (leftSym.IsStatic) {
                            CodeBuilder.Append("setstatic(");
                            CodeBuilder.Append(className);
                            CodeBuilder.AppendFormat(", \"{0}\", ", memberName);
                        } else {
                            CodeBuilder.Append("setinstance(");
                            if (null != leftMemberAccess)
                                OutputExpressionSyntax(leftMemberAccess.Expression);
                            else if (IsNewObjMember(memberName))
                                CodeBuilder.Append("newobj");
                            else
                                CodeBuilder.Append("this");
                            CodeBuilder.AppendFormat(", \"{0}\", ", memberName);
                        }
                    } else {
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.Append(" = ");
                    }
                    OutputExpressionSyntax(assign.Right, opd);
                } else {
                    if (isMemberAccess) {
                        string className = ClassInfo.GetFullName(leftSym.ContainingType);
                        string memberName = leftSym.Name;
                        if (leftSym.IsStatic) {
                            CodeBuilder.Append("setstatic(");
                            CodeBuilder.Append(className);
                            CodeBuilder.AppendFormat(", \"{0}\", ", memberName);
                        } else {
                            CodeBuilder.Append("setinstance(");
                            if (null != leftMemberAccess)
                                OutputExpressionSyntax(leftMemberAccess.Expression);
                            else if (IsNewObjMember(memberName))
                                CodeBuilder.Append("newobj");
                            else
                                CodeBuilder.Append("this");
                            CodeBuilder.AppendFormat(", \"{0}\", ", memberName);
                        }
                    } else {
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.Append(" = ");
                    }
                    if (null != compAssignInfo && compAssignInfo.UsesOperatorMethod) {
                        IMethodSymbol msym = compAssignInfo.OperatorMethod;
                        InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                        var arglist = new List<ExpressionSyntax>() { assign.Left, assign.Right };
                        ii.Init(msym, arglist, m_Model, lopd, ropd);
                        OutputOperatorInvoke(ii, assign);
                    } else {
                        ITypeSymbol ltypeSym = null;
                        ITypeSymbol rtypeSym = null;
                        string ltype = "null";
                        string rtype = "null";
                        string ltypeKind = "null";
                        string rtypeKind = "null";
                        if (null != compAssignInfo && null != compAssignInfo.Target && null != compAssignInfo.Value) {
                            ltypeSym = compAssignInfo.Target.Type;
                            rtypeSym = compAssignInfo.Value.Type;
                            ltype = ClassInfo.GetFullName(ltypeSym);
                            rtype = ClassInfo.GetFullName(rtypeSym);
                            ltypeKind = "TypeKind." + ltypeSym.TypeKind.ToString();
                            rtypeKind = "TypeKind." + rtypeSym.TypeKind.ToString();
                        }
                        ProcessBinaryOperator(assign, ref baseOp);
                        string functor;
                        if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                            CodeBuilder.AppendFormat("{0}(", functor);
                            OutputExpressionSyntax(assign.Left, lopd);
                            CodeBuilder.Append(", ");
                            OutputExpressionSyntax(assign.Right, ropd);
                            CodeBuilder.AppendFormat(", {0}, {1}", ltype, rtype);
                            CodeBuilder.Append(")");
                        } else {
                            CodeBuilder.AppendFormat("execbinary(\"{0}\", ", baseOp);
                            OutputExpressionSyntax(assign.Left, lopd);
                            CodeBuilder.Append(", ");
                            OutputExpressionSyntax(assign.Right, ropd);
                            CodeBuilder.AppendFormat(", {0}, {1}, {2}, {3}", ltype, rtype, ltypeKind, rtypeKind);
                            CodeBuilder.Append(")");
                        }
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
        private void VisitAssignmentLeftElementAccess(ClassInfo ci, AssignmentExpressionSyntax assign, bool toplevel, IOperation leftOper, ISymbol leftSym, IPropertySymbol leftPsym, ElementAccessExpressionSyntax leftElementAccess, IConversionExpression opd)
        {
            if (null != leftSym && leftSym.IsStatic) {
                AddReferenceAndTryDeriveGenericTypeInstance(ci, leftSym);
            }
            if (null != leftPsym && leftPsym.IsIndexer) {
                CodeBuilder.AppendFormat("set{0}{1}indexer(", SymbolTable.Instance.IsCs2DslSymbol(leftPsym) ? string.Empty : "extern", leftPsym.IsStatic ? "static" : "instance");
                if (leftPsym.IsStatic) {
                    string fullName = ClassInfo.GetFullName(leftPsym.ContainingType);
                    CodeBuilder.Append(fullName);
                } else {
                    OutputExpressionSyntax(leftElementAccess.Expression);
                }
                CodeBuilder.Append(", ");
                if (!leftPsym.IsStatic) {
                    string fnOfIntf = "null";
                    CheckExplicitInterfaceAccess(leftPsym.SetMethod, ref fnOfIntf);
                    CodeBuilder.AppendFormat("{0}, ", fnOfIntf);
                }
                string manglingName = NameMangling(leftPsym.SetMethod);
                CodeBuilder.AppendFormat("\"{0}\", ", manglingName);
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                ii.Init(leftPsym.SetMethod, leftElementAccess.ArgumentList, m_Model);
                OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ArrayToParams, false, leftElementAccess, ii.ArgConversions.ToArray());
                CodeBuilder.Append(", ");
                OutputExpressionSyntax(assign.Right, opd);
                CodeBuilder.Append(")");
            } else if (leftOper.Kind == OperationKind.ArrayElementReferenceExpression) {
                if (SymbolTable.UseArrayGetSet) {
                    CodeBuilder.Append("arrayset(");
                    OutputExpressionSyntax(leftElementAccess.Expression);
                    CodeBuilder.Append(", ");
                    VisitBracketedArgumentList(leftElementAccess.ArgumentList);
                    CodeBuilder.Append(", ");
                    OutputExpressionSyntax(assign.Right, opd);
                    CodeBuilder.Append(")");
                } else {
                    if (!toplevel) {
                        CodeBuilder.Append("(function(){ ");
                    }
                    OutputExpressionSyntax(leftElementAccess.Expression);
                    CodeBuilder.Append("[");
                    VisitBracketedArgumentList(leftElementAccess.ArgumentList);
                    CodeBuilder.Append("] = ");
                    OutputExpressionSyntax(assign.Right, opd);
                    if (!toplevel) {
                        CodeBuilder.Append("; return(");
                        OutputExpressionSyntax(assign.Right, opd);
                        CodeBuilder.Append("); })()");
                    }
                }
            } else {
                Log(assign, "unknown set element symbol !");
            }
        }
        private void VisitAssignmentLeftCondAccess(ClassInfo ci, AssignmentExpressionSyntax assign, ISymbol leftSym, ConditionalAccessExpressionSyntax leftCondAccess, IConversionExpression opd)
        {
            CodeBuilder.Append("condaccess(");
            OutputExpressionSyntax(leftCondAccess.Expression);
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
                    CodeBuilder.Append("(function(){ return(");
                    CodeBuilder.AppendFormat("set{0}{1}indexer(", SymbolTable.Instance.IsCs2DslSymbol(psym) ? string.Empty : "extern", psym.IsStatic ? "static" : "instance");
                    if (psym.IsStatic) {
                        string fullName = ClassInfo.GetFullName(psym.ContainingType);
                        CodeBuilder.Append(fullName);
                    } else {
                        OutputExpressionSyntax(leftCondAccess.Expression);
                    }
                    CodeBuilder.Append(", ");
                    if (!psym.IsStatic) {
                        string fnOfIntf = "null";
                        CheckExplicitInterfaceAccess(psym.SetMethod, ref fnOfIntf);
                        CodeBuilder.AppendFormat("{0}, ", fnOfIntf);
                    }
                    string manglingName = NameMangling(psym.SetMethod);
                    CodeBuilder.AppendFormat("\"{0}\", ", manglingName);
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                    List<ExpressionSyntax> args = new List<ExpressionSyntax> { leftCondAccess.WhenNotNull };
                    ii.Init(psym.SetMethod, args, m_Model);
                    OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ArrayToParams, false, leftCondAccess, ii.ArgConversions.ToArray());
                    CodeBuilder.Append(", ");
                    OutputExpressionSyntax(assign.Right, opd);
                    CodeBuilder.Append(")");
                    CodeBuilder.Append("); })");
                } else if (bindingOper.Kind == OperationKind.ArrayElementReferenceExpression) {
                    if (SymbolTable.UseArrayGetSet) {
                        CodeBuilder.Append("arrayset(");
                        OutputExpressionSyntax(leftCondAccess.Expression);
                        CodeBuilder.Append(", ");
                        OutputExpressionSyntax(leftCondAccess.WhenNotNull);
                        CodeBuilder.Append(", ");
                        OutputExpressionSyntax(assign.Right, opd);
                        CodeBuilder.Append(")");
                    } else {
                        CodeBuilder.Append("(function(){ ");
                        OutputExpressionSyntax(leftCondAccess.Expression);
                        CodeBuilder.Append("[");
                        OutputExpressionSyntax(leftCondAccess.WhenNotNull);
                        CodeBuilder.Append("] = ");
                        OutputExpressionSyntax(assign.Right, opd);
                        CodeBuilder.Append("; return(");
                        OutputExpressionSyntax(assign.Right, opd);
                        CodeBuilder.Append("); })");
                    }
                } else {
                    ReportIllegalSymbol(assign, symInfo);
                }
            } else {
                CodeBuilder.Append("(function(){ ");
                OutputExpressionSyntax(leftCondAccess.Expression);
                OutputExpressionSyntax(leftCondAccess.WhenNotNull);
                CodeBuilder.Append(" = ");
                OutputExpressionSyntax(assign.Right, opd);
                CodeBuilder.Append("; return(");
                OutputExpressionSyntax(assign.Right, opd);
                CodeBuilder.Append("); })");
            }
            CodeBuilder.Append(")");
        }
        private void VisitAssignmentInvocation(ClassInfo ci, string op, string baseOp, AssignmentExpressionSyntax assign, InvocationExpressionSyntax invocation, IConversionExpression opd, IConversionExpression lopd, IConversionExpression ropd, ICompoundAssignmentExpression compAssignInfo)
        {
            string localName = string.Format("__assigninvoke_{0}", GetSourcePosForVar(invocation));
            SymbolInfo symInfo = m_Model.GetSymbolInfo(invocation);
            IMethodSymbol sym = symInfo.Symbol as IMethodSymbol;
            if (null == sym || op != "=" && (null == compAssignInfo || null == compAssignInfo.Target || null == compAssignInfo.Value)) {
                ReportIllegalSymbol(invocation, symInfo);
            } else {
                //处理ref/out参数
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                ii.Init(sym, invocation.ArgumentList, m_Model);
                if (sym.IsStatic || sym.IsExtensionMethod) {
                    AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
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

                MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                if (null != memberAccess) {
                    if (memberAccess.OperatorToken.Text == "->") {
                        Log(memberAccess, "Unsupported -> member access !");
                    }

                    bool outputEqualOp = false;
                    int ct = ii.ReturnArgs.Count;
                    if (op != "=") {
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.Append(" = ");
                        ProcessBinaryOperator(assign, ref baseOp);
                        string functor;
                        if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                            CodeBuilder.AppendFormat("{0}(", functor);
                            OutputExpressionSyntax(assign.Left, lopd);
                            CodeBuilder.Append(", ");
                        } else {
                            CodeBuilder.Append("execbinary(");
                            CodeBuilder.AppendFormat("\"{0}\", ", baseOp);
                            OutputExpressionSyntax(assign.Left, lopd);
                            CodeBuilder.Append(", ");
                        }
                        if (null != ropd && ropd.UsesOperatorMethod) {
                            IMethodSymbol msym = ropd.OperatorMethod;
                            InvocationInfo iop = new InvocationInfo(GetCurMethodSemanticInfo());
                            iop.Init(msym, (List<ExpressionSyntax>)null, m_Model);
                            OutputConversionInvokePrefix(iop);
                        }
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("(function(){{ local({0}); multiassign({1}", localName, localName);
                            outputEqualOp = true;
                        }
                    } else if (null != opd && opd.UsesOperatorMethod) {
                        IMethodSymbol msym = opd.OperatorMethod;
                        InvocationInfo iop = new InvocationInfo(GetCurMethodSemanticInfo());
                        iop.Init(msym, (List<ExpressionSyntax>)null, m_Model);
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.Append(" = ");
                        OutputConversionInvokePrefix(iop);
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("(function(){{ local({0}); multiassign({1}", localName, localName);
                            outputEqualOp = true;
                        }
                    } else {
                        if (ct > 0) {
                            CodeBuilder.Append("multiassign(");
                        }
                        OutputExpressionSyntax(assign.Left);
                        outputEqualOp = true;
                    }

                    if (ct > 0) {
                        CodeBuilder.Append(", ");
                        OutputExpressionList(ii.ReturnArgs);
                        CodeBuilder.Append(")");
                    }
                    if (outputEqualOp) {
                        CodeBuilder.Append(" = ");
                    }
                    ii.OutputInvocation(CodeBuilder, this, memberAccess.Expression, true, m_Model, memberAccess);
                    if (op != "=") {
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("; return({0}); }})()", localName);
                        }
                        if (null != ropd && ropd.UsesOperatorMethod) {
                            CodeBuilder.Append(")");
                        }
                        CodeBuilder.AppendFormat(", {0}, {1}, {2}, {3}", leftType, rightType, leftTypeKind, rightTypeKind);
                        CodeBuilder.Append(")");
                    } else if (null != opd && opd.UsesOperatorMethod) {
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("; return({0}); }})()", localName);
                        }
                        CodeBuilder.Append(")");
                    }
                } else {
                    bool outputEqualOp = false;
                    int ct = ii.ReturnArgs.Count;
                    if (op != "=") {
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.Append(" = ");
                        ProcessBinaryOperator(assign, ref baseOp);
                        string functor;
                        if (s_BinaryFunctor.TryGetValue(baseOp, out functor)) {
                            CodeBuilder.AppendFormat("{0}(", functor);
                            OutputExpressionSyntax(assign.Left, lopd);
                            CodeBuilder.Append(", ");
                        } else {
                            CodeBuilder.Append("execbinary(");
                            CodeBuilder.AppendFormat("\"{0}\", ", baseOp);
                            OutputExpressionSyntax(assign.Left, lopd);
                            CodeBuilder.Append(", ");
                        }
                        if (null != ropd && ropd.UsesOperatorMethod) {
                            IMethodSymbol msym = ropd.OperatorMethod;
                            InvocationInfo iop = new InvocationInfo(GetCurMethodSemanticInfo());
                            iop.Init(msym, (List<ExpressionSyntax>)null, m_Model);
                            OutputConversionInvokePrefix(iop);
                        }
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("(function(){{ local({0}); multiassign({1}", localName, localName);
                            outputEqualOp = true;
                        }
                    } else if (null != opd && opd.UsesOperatorMethod) {
                        IMethodSymbol msym = opd.OperatorMethod;
                        InvocationInfo iop = new InvocationInfo(GetCurMethodSemanticInfo());
                        iop.Init(msym, (List<ExpressionSyntax>)null, m_Model);
                        OutputExpressionSyntax(assign.Left);
                        CodeBuilder.Append(" = ");
                        OutputConversionInvokePrefix(iop);
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("(function(){{ local({0}); multiassign({1}", localName, localName);
                            outputEqualOp = true;
                        }
                    } else {
                        if (ct > 0) {
                            CodeBuilder.Append("multiassign(");
                        }
                        OutputExpressionSyntax(assign.Left);
                        outputEqualOp = true;
                    }

                    if (ct > 0) {
                        CodeBuilder.Append(", ");
                        OutputExpressionList(ii.ReturnArgs);
                        CodeBuilder.Append(")");
                    }
                    if (outputEqualOp) {
                        CodeBuilder.Append(" = ");
                    }
                    ii.OutputInvocation(CodeBuilder, this, invocation.Expression, false, m_Model, invocation);
                    if (op != "=") {
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("; return({0}); }})()", localName);
                        }
                        if (null != ropd && ropd.UsesOperatorMethod) {
                            CodeBuilder.Append(")");
                        }
                        CodeBuilder.AppendFormat(", {0}, {1}, {2}, {3}", leftType, rightType, leftTypeKind, rightTypeKind);
                        CodeBuilder.Append(")");
                    } else if (null != opd && opd.UsesOperatorMethod) {
                        if (ct > 0) {
                            CodeBuilder.AppendFormat("; return({0}); }})()", localName);
                        }
                        CodeBuilder.Append(")");
                    }
                }
            }
        }
        private void VisitAssignmentDelegation(ClassInfo ci, string op, string baseOp, AssignmentExpressionSyntax assign, IOperation leftOper, ISymbol leftSym, IConversionExpression opd)
        {
            if (null == leftSym) {
                Log(assign, "assignment delegation, left symbol == null");
                return;
            }
            bool isEvent = leftOper is IEventReferenceExpression;
            string prefix;
            if (SymbolTable.Instance.IsCs2DslSymbol(leftSym)) {
                prefix = string.Empty;
            } else {
                prefix = "extern";
            }
            string postfix;
            if (op == "=") {
                postfix = "set";
            } else if (baseOp == "+") {
                postfix = "add";
            } else if (baseOp == "-") {
                postfix = "remove";
            } else {
                Log(assign, "Unsupported delegation operator {0} !", op);
                postfix = "error";
            }
            bool isStatic = leftSym.IsStatic;
            string containingName = ClassInfo.GetFullName(leftSym.ContainingType);
            CodeBuilder.AppendFormat("{0}delegation{1}", prefix, postfix);
            CodeBuilder.Append("(");
            CodeBuilder.AppendFormat("{0}, {1}, ", isEvent ? "true" : "false", isStatic ? "true" : "false");
            if (leftSym.Kind == SymbolKind.Field || leftSym.Kind == SymbolKind.Property || leftSym.Kind == SymbolKind.Event) {
                var memberAccess = assign.Left as MemberAccessExpressionSyntax;
                if (null != memberAccess) {
                    CodeBuilder.AppendFormat("\"{0}:{1}\", ", containingName, memberAccess.Name.Identifier.Text);
                    OutputExpressionSyntax(memberAccess.Expression);
                    CodeBuilder.Append(", ");
                    string intf = "null";
                    string mname = string.Format("\"{0}\"", memberAccess.Name.Identifier.Text);
                    CheckExplicitInterfaceAccess(leftSym, ref intf, ref mname);
                    CodeBuilder.AppendFormat("{0}, {1}", intf, mname);
                } else if (leftSym.ContainingType == ci.SemanticInfo || leftSym.ContainingType == ci.SemanticInfo.OriginalDefinition || ci.IsInherit(leftSym.ContainingType)) {
                    CodeBuilder.AppendFormat("\"{0}:{1}\", ", containingName, leftSym.Name);
                    if (leftSym.IsStatic)
                        CodeBuilder.AppendFormat("{0}, nil, ", ClassInfo.GetFullName(leftSym.ContainingType));
                    else
                        CodeBuilder.Append("this, null, ");
                    CodeBuilder.AppendFormat("\"{0}\"", leftSym.Name);
                } else {
                    CodeBuilder.AppendFormat("\"{0}:{1}\", ", containingName, leftSym.Name);
                    CodeBuilder.Append("newobj, null, ");
                    CodeBuilder.AppendFormat("\"{0}\"", leftSym.Name);
                }
            } else {
                CodeBuilder.AppendFormat("\"{0}:{1}\", ", containingName, leftSym.Name);
                OutputExpressionSyntax(assign.Left);
                CodeBuilder.Append(", null, null");
            }
            CodeBuilder.Append(", ");
            OutputExpressionSyntax(assign.Right, opd);
            CodeBuilder.Append(")");
        }
        private void VisitInvocation(ClassInfo ci, InvocationExpressionSyntax invocation, string expTerminater, bool toplevel)
        {
            string localName = string.Format("__invoke_{0}", GetSourcePosForVar(invocation));
            SymbolInfo symInfo = m_Model.GetSymbolInfo(invocation);
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
            } else {
                //处理ref/out参数
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                ii.Init(sym, invocation.ArgumentList, m_Model);
                if (sym.IsStatic || sym.IsExtensionMethod) {
                    AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                }

                MemberAccessExpressionSyntax memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                if (null != memberAccess) {
                    if (memberAccess.OperatorToken.Text == "->") {
                        Log(memberAccess, "Unsupported -> member access !");
                    }

                    if (ii.ReturnArgs.Count > 0) {
                        if (!toplevel) {
                            CodeBuilder.AppendFormat("(function(){{ local({0}); multiassign({1}, ", localName, localName);
                        } else if (!sym.ReturnsVoid) {
                            CodeBuilder.AppendFormat("local({0}); multiassign({1}, ", localName, localName);
                        } else {
                            CodeBuilder.Append("multiassign(");
                        }
                        OutputExpressionList(ii.ReturnArgs);
                        CodeBuilder.Append(") = ");
                    }
                    ii.OutputInvocation(CodeBuilder, this, memberAccess.Expression, true, m_Model, memberAccess);
                    if (ii.ReturnArgs.Count > 0) {
                        if (!toplevel) {
                            CodeBuilder.AppendFormat("; return({0}); }})()", localName);
                        }
                    }
                    CodeBuilder.AppendFormat("{0}", expTerminater);
                    if (expTerminater.Length > 0)
                        CodeBuilder.AppendLine();
                } else {
                    if (ii.ReturnArgs.Count > 0) {
                        if (!toplevel) {
                            CodeBuilder.AppendFormat("(function(){{ local({0}); multiassign({1}, ", localName, localName);
                        } else if (!sym.ReturnsVoid) {
                            CodeBuilder.AppendFormat("local({0}); multiassign({1}, ", localName, localName);
                        } else {
                            CodeBuilder.Append("multiassign(");
                        }
                        OutputExpressionList(ii.ReturnArgs);
                        CodeBuilder.Append(") = ");
                    }
                    ii.OutputInvocation(CodeBuilder, this, invocation.Expression, false, m_Model, invocation);
                    if (ii.ReturnArgs.Count > 0) {
                        if (!toplevel) {
                            CodeBuilder.AppendFormat("; return({0}); }})()", localName);
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