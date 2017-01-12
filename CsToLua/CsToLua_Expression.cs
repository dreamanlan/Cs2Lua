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
        #region 相对简单的表达式
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
                    ii.Init(msym, arglist, m_Model);
                    OutputOperatorInvoke(ii, node);
                } else {
                    InvocationInfo ii = new InvocationInfo();
                    var arglist = new List<ExpressionSyntax>() { node.Left, node.Right };
                    ii.Init(msym, arglist, m_Model);
                    OutputOperatorInvoke(ii, node);
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
                    } else if (op == "??") {
                        var rightOper = m_Model.GetOperation(node.Right);
                        bool rightIsConst = null != rightOper && rightOper.ConstantValue.HasValue;
                        if (rightIsConst) {
                            CodeBuilder.Append("true, ");
                            VisitExpressionSyntax(node.Right);
                        } else {
                            CodeBuilder.Append("false, (function() return ");
                            VisitExpressionSyntax(node.Right);
                            CodeBuilder.Append("; end)");
                        }
                    } else {
                        VisitExpressionSyntax(node.Right);
                    }
                    CodeBuilder.Append(")");
                } else if (op == "+") {
                    ProcessAddOrStringConcat(node.Left, node.Right);
                } else if (op == "==" || op == "~=") {
                    ProcessEqualOrNotEqual(op, node.Left, node.Right);
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
            var tOper = m_Model.GetOperation(node.WhenTrue);
            var fOper = m_Model.GetOperation(node.WhenFalse);
            bool trueIsConst = null != tOper && tOper.ConstantValue.HasValue;
            bool falseIsConst = null != fOper && fOper.ConstantValue.HasValue;

            CodeBuilder.Append("condexp(");
            VisitExpressionSyntax(node.Condition);
            if (trueIsConst) {
                CodeBuilder.Append(", true, ");
            } else {
                CodeBuilder.Append(", false, (function() return ");
            }
            VisitExpressionSyntax(node.WhenTrue);
            if (trueIsConst) {
                CodeBuilder.Append(", ");
            } else {
                CodeBuilder.Append("; end), ");
            }
            if (falseIsConst) {
                CodeBuilder.Append("true, ");
            } else {
                CodeBuilder.Append("false, (function() return ");
            }
            VisitExpressionSyntax(node.WhenFalse);
            if (falseIsConst) {
                CodeBuilder.Append(")");
            } else {
                CodeBuilder.Append("; end))");
            }
        }
        public override void VisitThisExpression(ThisExpressionSyntax node)
        {
            CodeBuilder.Append("this");
        }
        public override void VisitBaseExpression(BaseExpressionSyntax node)
        {
            CodeBuilder.Append("this.base");
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
                ii.Init(msym, arglist, m_Model);
                OutputOperatorInvoke(ii, node);
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
                    string functor;
                    if (s_UnaryFunctor.TryGetValue(op, out functor)) {
                        CodeBuilder.AppendFormat("{0}(", functor);
                        VisitExpressionSyntax(node.Operand);
                    } else {
                        CodeBuilder.Append("(");
                        CodeBuilder.Append(op);
                        CodeBuilder.Append(" ");
                        VisitExpressionSyntax(node.Operand);
                    }
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
                ii.Init(msym, arglist, m_Model);
                OutputOperatorInvoke(ii, node);
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
                ii.Init(msym, arglist, m_Model);
                AddReferenceAndTryDeriveGenericTypeInstance(ci, oper.Type);

                OutputOperatorInvoke(ii, node);
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

        #region 相对复杂的表达式
        public override void VisitAssignmentExpression(AssignmentExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();

            string op = node.OperatorToken.Text;
            string baseOp = op.Substring(0, op.Length - 1);

            bool needWrapFunction = true;
            var leftOper = m_Model.GetOperation(node.Left);
            var leftSymbolInfo = m_Model.GetSymbolInfo(node.Left);
            var leftSym = leftSymbolInfo.Symbol;
            var leftPsym = leftSym as IPropertySymbol;
            var leftMemberAccess = node.Left as MemberAccessExpressionSyntax;
            var leftElementAccess = node.Left as ElementAccessExpressionSyntax;
            var leftCondAccess = node.Left as ConditionalAccessExpressionSyntax;
            
            SpecialAssignmentType specialType = SpecialAssignmentType.None;
            if (null != leftMemberAccess && null != leftPsym) {
                if (!leftPsym.IsStatic) {
                    if (CheckExplicitInterfaceAccess(leftPsym)) {
                        specialType = SpecialAssignmentType.PropExplicitImplementInterface;
                    } else if (SymbolTable.IsBasicValueProperty(leftPsym)) {
                        specialType = SpecialAssignmentType.PropForBasicValueType;
                    }
                }
            }
            if (specialType == SpecialAssignmentType.PropExplicitImplementInterface || specialType == SpecialAssignmentType.PropForBasicValueType 
                || null != leftElementAccess || null != leftCondAccess 
                || leftOper.Type.TypeKind == TypeKind.Delegate && (leftSym.Kind != SymbolKind.Local || op != "=")) {
                needWrapFunction = false;
            }
            if (needWrapFunction) {
                //顶层的赋值语句已经处理，这里的赋值都需要包装成lambda函数的样式
                CodeBuilder.Append("(function() ");
            }
            VisitAssignment(ci, op, baseOp, node, string.Empty, false, leftOper, leftSym, leftPsym, leftMemberAccess, leftElementAccess, leftCondAccess, specialType);
            var oper = m_Model.GetOperation(node.Right);
            if (null != leftSym && leftSym.Kind == SymbolKind.Local && null != oper && null != oper.Type && oper.Type.TypeKind == TypeKind.Struct && oper.Type.ContainingAssembly == m_SymbolTable.AssemblySymbol) {
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
                if (sym.IsStatic) {
                    var ci = m_ClassInfoStack.Peek();
                    AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                }
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
                    mi.Init(msym, node);

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
                    var psym = sym as IPropertySymbol;
                    string fnOfIntf = string.Empty;
                    string mname = string.Empty;
                    bool propExplicitImplementInterface = false;
                    bool propForBasicValueType = false;
                    if (null != psym){
                        if (!psym.IsStatic) {
                            propExplicitImplementInterface = CheckExplicitInterfaceAccess(psym, ref fnOfIntf, ref mname);
                            propForBasicValueType = SymbolTable.IsBasicValueProperty(psym);
                        }
                    }
                    if (propExplicitImplementInterface) {
                        CodeBuilder.AppendFormat("getwithinterface(");
                        VisitExpressionSyntax(node.Expression);
                        CodeBuilder.AppendFormat(", \"{0}\", \"{1}\")", fnOfIntf, mname);
                    } else if (propForBasicValueType) {
                        string pname = psym.Name;
                        string cname = ClassInfo.GetFullName(psym.ContainingType);
                        string ckey = InvocationInfo.CalcInvokeTarget(cname, this, node.Expression, m_Model);
                        CodeBuilder.AppendFormat("getforbasicvalue(");
                        VisitExpressionSyntax(node.Expression);
                        CodeBuilder.AppendFormat(", {0}, {1}, \"{2}\")", cname == "System.Enum" ? "true" : "false", ckey, pname);
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
        }
        public override void VisitElementAccessExpression(ElementAccessExpressionSyntax node)
        {
            var oper = m_Model.GetOperation(node);
            var symInfo = m_Model.GetSymbolInfo(node);
            var sym = symInfo.Symbol;
            var psym = sym as IPropertySymbol;
            if (null != sym && sym.IsStatic) {
                var ci = m_ClassInfoStack.Peek();
                AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
            }
            if (null != psym && psym.IsIndexer) {
                CodeBuilder.AppendFormat("get{0}{1}indexer(", psym.ContainingAssembly == m_SymbolTable.AssemblySymbol ? string.Empty : "extern", psym.IsStatic ? "static" : "instance");
                if (psym.IsStatic) {
                    string fullName = ClassInfo.GetFullName(psym.ContainingType);
                    CodeBuilder.Append(fullName);
                } else {
                    VisitExpressionSyntax(node.Expression);
                }
                CodeBuilder.Append(", ");
                if (!psym.IsStatic) {
                    string fnOfIntf = "nil";
                    CheckExplicitInterfaceAccess(psym.GetMethod, ref fnOfIntf);
                    CodeBuilder.AppendFormat("{0}, ", fnOfIntf);
                }
                string manglingName = NameMangling(psym.GetMethod);
                CodeBuilder.AppendFormat("\"{0}\", ", manglingName);
                InvocationInfo ii = new InvocationInfo();
                ii.Init(psym.GetMethod, node.ArgumentList, m_Model);
                OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ArrayToParams, false, node);
                CodeBuilder.Append(")");
            } else if (oper.Kind == OperationKind.ArrayElementReferenceExpression) {
                VisitExpressionSyntax(node.Expression);
                CodeBuilder.Append("[");
                VisitBracketedArgumentList(node.ArgumentList);
                CodeBuilder.Append("]");
            } else if (null != sym) {
                CodeBuilder.AppendFormat("get{0}{1}element(", sym.ContainingAssembly == m_SymbolTable.AssemblySymbol ? string.Empty : "extern", sym.IsStatic ? "static" : "instance");
                if (sym.IsStatic) {
                    string fullName = ClassInfo.GetFullName(sym.ContainingType);
                    CodeBuilder.Append(fullName);
                } else {
                    VisitExpressionSyntax(node.Expression);
                }
                CodeBuilder.Append(", ");
                CodeBuilder.AppendFormat("\"{0}\", ", sym.Name);
                VisitBracketedArgumentList(node.ArgumentList);
                CodeBuilder.Append(")");
            } else {
                ReportIllegalSymbol(node, symInfo);
            }
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
                var sym = symInfo.Symbol;
                var psym = sym as IPropertySymbol;
                if (null != sym && sym.IsStatic) {
                    var ci = m_ClassInfoStack.Peek();
                    AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                }
                if (null != psym && psym.IsIndexer) {
                    CodeBuilder.Append("(function() return ");
                    CodeBuilder.AppendFormat("get{0}{1}indexer(", psym.ContainingAssembly == m_SymbolTable.AssemblySymbol ? string.Empty : "extern", psym.IsStatic ? "static" : "instance");
                    if (psym.IsStatic) {
                        string fullName = ClassInfo.GetFullName(psym.ContainingType);
                        CodeBuilder.Append(fullName);
                    } else {
                        VisitExpressionSyntax(node.Expression);
                    }
                    CodeBuilder.Append(", ");
                    if (!psym.IsStatic) {
                        string fnOfIntf = "nil";
                        CheckExplicitInterfaceAccess(psym.GetMethod, ref fnOfIntf);
                        CodeBuilder.AppendFormat("{0}, ", fnOfIntf);
                    }
                    string manglingName = NameMangling(psym.GetMethod);
                    CodeBuilder.AppendFormat("\"{0}\", ", manglingName);
                    InvocationInfo ii = new InvocationInfo();
                    List<ExpressionSyntax> args = new List<ExpressionSyntax> { node.WhenNotNull };
                    ii.Init(psym.GetMethod, args, m_Model);
                    OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ArrayToParams, false, elementBinding);
                    CodeBuilder.Append(")");
                    CodeBuilder.Append("; end)");
                } else if (oper.Kind == OperationKind.ArrayElementReferenceExpression) {
                    CodeBuilder.Append("(function() return ");
                    VisitExpressionSyntax(node.Expression);
                    CodeBuilder.Append("[");
                    VisitExpressionSyntax(node.WhenNotNull);
                    CodeBuilder.Append(" + 1]");
                    CodeBuilder.Append("; end)");
                } else if (null != sym) {
                    CodeBuilder.Append("(function() return ");
                    CodeBuilder.AppendFormat("get{0}{1}element(", sym.ContainingAssembly == m_SymbolTable.AssemblySymbol ? string.Empty : "extern", sym.IsStatic ? "static" : "instance");
                    if (sym.IsStatic) {
                        string fullName = ClassInfo.GetFullName(sym.ContainingType);
                        CodeBuilder.Append(fullName);
                    } else {
                        VisitExpressionSyntax(node.Expression);
                    }
                    CodeBuilder.Append(", ");
                    CodeBuilder.AppendFormat("\"{0}\", ", sym.Name);
                    VisitExpressionSyntax(node.WhenNotNull);
                    CodeBuilder.Append(")");
                    CodeBuilder.Append("; end)");
                } else {
                    ReportIllegalSymbol(node, symInfo);
                }
            } else {
                CodeBuilder.Append("(function() return ");
                VisitExpressionSyntax(node.Expression);
                VisitExpressionSyntax(node.WhenNotNull);
                CodeBuilder.Append("; end)");
            }
            CodeBuilder.Append(")");
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
                                    CodeBuilder.Append("[tostring(");
                                    VisitToplevelExpression(exp.Expressions[0], string.Empty);
                                    CodeBuilder.Append(")] = ");
                                    VisitToplevelExpression(exp.Expressions[1], string.Empty);
                                } else {
                                    Log(args[i], "Dictionary init error !");
                                }
                                if (i < ct - 1) {
                                    CodeBuilder.Append(", ");
                                }
                            }
                            CodeBuilder.Append("}");
                        } else if (isList) {
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
                ii.Init(sym, node.ArgumentList, m_Model);
                AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);

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
                if (ii.Args.Count + ii.DefaultValueArgs.Count + ii.GenericTypeArgs.Count > 0) {
                    CodeBuilder.Append(", ");
                }
                OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ArrayToParams, false, node);
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
                        mi.Init(msym, node);

                        CodeBuilder.Append("(function(");
                        string paramsString = string.Join(", ", mi.ParamNames.ToArray());
                        CodeBuilder.Append(paramsString);
                        CodeBuilder.Append(") ");
                        if (!msym.ReturnsVoid) {
                            CodeBuilder.Append("return ");
                        }
                        if (msym.IsStatic) {
                            AddReferenceAndTryDeriveGenericTypeInstance(ci, msym);

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
        #endregion
    }
}