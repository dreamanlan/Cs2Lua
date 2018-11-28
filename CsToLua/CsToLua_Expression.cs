using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Reflection;
using System.Collections.Immutable;
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
                    var opd = castOper.Operand as IConversionExpression;
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                    var arglist = new List<ExpressionSyntax>() { node.Left };
                    ii.Init(msym, arglist, m_Model, opd);
                    OutputOperatorInvoke(ii, node);
                } else {
                    var boper = oper as IBinaryOperatorExpression;
                    var lopd = null == boper ? null : boper.LeftOperand as IConversionExpression;
                    var ropd = null == boper ? null : boper.RightOperand as IConversionExpression;

                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                    var arglist = new List<ExpressionSyntax>() { node.Left, node.Right };
                    ii.Init(msym, arglist, m_Model, lopd, ropd);
                    OutputOperatorInvoke(ii, node);
                }
            } else {
                var boper = oper as IBinaryOperatorExpression;
                var lopd = null == boper ? null : boper.LeftOperand as IConversionExpression;
                var ropd = null == boper ? null : boper.RightOperand as IConversionExpression;
                
                string op = node.OperatorToken.Text;
                bool isIntegerOprand = false;
                int integerOpIndex = -1;
                if (null != boper && null != boper.LeftOperand && null != boper.RightOperand) {
                    isIntegerOprand = TryGetSpecialIntegerOperatorIndex(op, out integerOpIndex) && SymbolTable.IsIntegerType(boper.LeftOperand.Type) && SymbolTable.IsIntegerType(boper.RightOperand.Type);
                }
                ProcessBinaryOperator(node, ref op);
                if (isIntegerOprand) {
                    var ltype = boper.LeftOperand.Type;
                    var rtype = boper.RightOperand.Type;
                    CodeBuilder.AppendFormat("invokeintegeroperator({0}, \"{1}\", ", integerOpIndex, op);
                    OutputExpressionSyntax(node.Left, lopd);
                    CodeBuilder.Append(", ");
                    OutputExpressionSyntax(node.Right, ropd);
                    CodeBuilder.AppendFormat(", {0}, {1}", ClassInfo.GetFullName(ltype), ClassInfo.GetFullName(rtype));
                    CodeBuilder.Append(")");
                } else {
                    string functor = string.Empty;
                    if (s_BinaryFunctor.TryGetValue(op, out functor)) {
                        CodeBuilder.AppendFormat("{0}(", functor);
                        OutputExpressionSyntax(node.Left, lopd);
                        CodeBuilder.Append(", ");
                        if (op == "as" || op == "is") {
                            var typeInfo = m_Model.GetTypeInfo(node.Right);
                            var type = typeInfo.Type;
                            OutputType(type, node, ci, op);
                            if (type.TypeKind == TypeKind.Enum) {
                                CodeBuilder.Append(", true");
                            } else {
                                CodeBuilder.Append(", false");
                            }
                        } else if (op == "??") {
                            var rightOper = m_Model.GetOperation(node.Right);
                            bool rightIsConst = null != rightOper && rightOper.ConstantValue.HasValue;
                            if (rightIsConst) {
                                CodeBuilder.Append("true, ");
                                OutputExpressionSyntax(node.Right, ropd);
                            } else {
                                CodeBuilder.Append("false, (function() return ");
                                OutputExpressionSyntax(node.Right, ropd);
                                CodeBuilder.Append("; end)");
                            }
                        } else {
                            OutputExpressionSyntax(node.Right, ropd);
                        }
                        CodeBuilder.Append(")");
                    } else if (op == "+") {
                        ProcessAddOrStringConcat(node.Left, node.Right, lopd, ropd);
                    } else if (op == "==" || op == "~=") {
                        ProcessEqualOrNotEqual(op, node.Left, node.Right, lopd, ropd);
                    } else {
                        CodeBuilder.Append("(");
                        OutputExpressionSyntax(node.Left, lopd);
                        CodeBuilder.AppendFormat(" {0} ", op);
                        OutputExpressionSyntax(node.Right, ropd);
                        CodeBuilder.Append(")");
                    }
                }
            }
        }
        public override void VisitConditionalExpression(ConditionalExpressionSyntax node)
        {
            IConversionExpression opd = null;
            var oper = m_Model.GetOperation(node) as IConditionalChoiceExpression;
            if (null != oper) {
                opd = oper.Condition as IConversionExpression;
            }
            var tOper = m_Model.GetOperation(node.WhenTrue);
            var fOper = m_Model.GetOperation(node.WhenFalse);
            bool trueIsConst = null != tOper && tOper.ConstantValue.HasValue;
            bool falseIsConst = null != fOper && fOper.ConstantValue.HasValue;

            CodeBuilder.Append("condexp(");
            OutputExpressionSyntax(node.Condition, opd);
            if (trueIsConst) {
                CodeBuilder.Append(", true, ");
            } else {
                CodeBuilder.Append(", false, (function() return ");
            }
            OutputExpressionSyntax(node.WhenTrue);
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
            OutputExpressionSyntax(node.WhenFalse);
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
            OutputExpressionSyntax(node.Expression);
            CodeBuilder.Append(" )");
        }
        public override void VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
        {
            var oper = m_Model.GetOperation(node);
            IConversionExpression opd = null;
            var unaryOper = oper as IUnaryOperatorExpression;
            if (null != unaryOper) {
                opd = unaryOper.Operand as IConversionExpression;
            }
            var assignOper = oper as ICompoundAssignmentExpression;
            if (null != assignOper) {
                opd = assignOper.Value as IConversionExpression;
            }
            if (null != unaryOper && unaryOper.UsesOperatorMethod) {
                IMethodSymbol msym = unaryOper.OperatorMethod;
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                var arglist = new List<ExpressionSyntax>() { node.Operand };
                ii.Init(msym, arglist, m_Model, opd);
                OutputOperatorInvoke(ii, node);
            } else if (null != assignOper && assignOper.UsesOperatorMethod) {
                CodeBuilder.Append("(function() ");
                OutputExpressionSyntax(node.Operand, opd);
                CodeBuilder.Append(" = ");
                IMethodSymbol msym = assignOper.OperatorMethod;
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                var arglist = new List<ExpressionSyntax>() { node.Operand };
                ii.Init(msym, arglist, m_Model, opd);
                OutputOperatorInvoke(ii, node);
                CodeBuilder.Append("; return ");
                OutputOperatorInvoke(ii, node);
                CodeBuilder.Append("; end)()");
            } else {
                string op = node.OperatorToken.Text;
                if (op == "++" || op == "--") {
                    op = op == "++" ? "+" : "-";
                    bool isIntegerOperand = false;
                    int integerOpIndex = -1;
                    if (null != assignOper && null != assignOper.Target) {
                        isIntegerOperand = TryGetSpecialIntegerOperatorIndex(op, out integerOpIndex) && SymbolTable.IsIntegerType(assignOper.Target.Type);
                    }
                    CodeBuilder.Append("(function() ");
                    OutputExpressionSyntax(node.Operand, opd);
                    CodeBuilder.Append(" = ");
                    if (isIntegerOperand) {
                        CodeBuilder.AppendFormat("invokeintegeroperator({0}, \"{1}\", ", integerOpIndex, op);
                        OutputExpressionSyntax(node.Operand, opd);
                        CodeBuilder.AppendFormat(", 1, {0}, {1}", ClassInfo.GetFullName(assignOper.Target.Type), ClassInfo.GetFullName(assignOper.Target.Type));
                        CodeBuilder.Append(")");
                    } else {
                        OutputExpressionSyntax(node.Operand, opd);
                        CodeBuilder.Append(" ");
                        CodeBuilder.Append(op);
                        CodeBuilder.Append(" 1");
                    }
                    CodeBuilder.Append("; return ");
                    OutputExpressionSyntax(node.Operand, opd);
                    CodeBuilder.Append("; end)()");
                } else {
                    bool isIntegerOperand = false;
                    int integerOpIndex = -1;
                    if (null != unaryOper && null != unaryOper.Operand) {
                        isIntegerOperand = TryGetSpecialIntegerOperatorIndex(op, out integerOpIndex) && SymbolTable.IsIntegerType(unaryOper.Operand.Type);
                    }
                    ProcessUnaryOperator(node, ref op);
                    if (isIntegerOperand) {
                        CodeBuilder.AppendFormat("invokeintegeroperator({0}, \"{1}\", nil, ", integerOpIndex, op);
                        OutputExpressionSyntax(node.Operand, opd);
                        CodeBuilder.AppendFormat(", nil, {0}", ClassInfo.GetFullName(unaryOper.Operand.Type));
                        CodeBuilder.Append(")");
                    } else {
                        string functor;
                        if (s_UnaryFunctor.TryGetValue(op, out functor)) {
                            CodeBuilder.AppendFormat("{0}(", functor);
                            OutputExpressionSyntax(node.Operand, opd);
                        } else {
                            CodeBuilder.Append("(");
                            CodeBuilder.Append(op);
                            CodeBuilder.Append(" ");
                            OutputExpressionSyntax(node.Operand, opd);
                        }
                        CodeBuilder.Append(")");
                    }
                }
            }
        }
        public override void VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
        {
            var oper = m_Model.GetOperation(node) as IUnaryOperatorExpression;
            IConversionExpression opd = null;
            var assignOper = oper as ICompoundAssignmentExpression;
            if (null != assignOper) {
                opd = assignOper.Value as IConversionExpression;
            }
            if (null != assignOper && assignOper.UsesOperatorMethod) {
                IMethodSymbol msym = assignOper.OperatorMethod;
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                var arglist = new List<ExpressionSyntax>() { node.Operand };
                ii.Init(msym, arglist, m_Model, opd);
                OutputOperatorInvoke(ii, node);
            } else {
                string op = node.OperatorToken.Text;
                if (op == "++" || op == "--") {
                    OutputExpressionSyntax(node.Operand, opd);
                    m_PostfixUnaryExpressions.Enqueue(node);
                }
            }
        }
        public override void VisitSizeOfExpression(SizeOfExpressionSyntax node)
        {
            var oper = m_Model.GetOperation(node) as ISizeOfExpression;
            if (oper.ConstantValue.HasValue) {
                OutputConstValue(oper.ConstantValue.Value, oper);
            } else {
                ReportIllegalType(oper.Type);
            }
        }
        public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();

            var oper = m_Model.GetOperation(node) as ITypeOfExpression;
            var type = oper.TypeOperand;
            bool useTypeOfFunc = SymbolTable.ForXlua && null != type && !SymbolTable.Instance.IsCs2LuaSymbol(type);
            if (useTypeOfFunc) {
                CodeBuilder.Append("typeof(");
            }
            OutputType(type, node, ci, "typeof");
            if (useTypeOfFunc) {
                CodeBuilder.Append(")");
            }
        }
        public override void VisitCastExpression(CastExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            var oper = m_Model.GetOperation(node) as IConversionExpression;
            var opd = oper.Operand as IConversionExpression;
            if (null != oper && oper.UsesOperatorMethod) {
                IMethodSymbol msym = oper.OperatorMethod;
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                var arglist = new List<ExpressionSyntax>() { node.Expression };
                ii.Init(msym, arglist, m_Model, opd);
                AddReferenceAndTryDeriveGenericTypeInstance(ci, oper.Type);

                OutputOperatorInvoke(ii, node);
            } else {
                CodeBuilder.Append("typecast(");
                OutputExpressionSyntax(node.Expression, opd);

                var typeInfo = m_Model.GetTypeInfo(node.Type);
                var type = typeInfo.Type;
                CodeBuilder.Append(", ");
                OutputType(type, node, ci, "cast");
                if (type.TypeKind == TypeKind.Enum) {
                    CodeBuilder.Append(", true");
                } else {
                    CodeBuilder.Append(", false");
                }
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
            if (null != leftSym && leftSym.Kind == SymbolKind.Local && null != oper && null != oper.Type && oper.Type.TypeKind == TypeKind.Struct && SymbolTable.Instance.IsCs2LuaSymbol(oper.Type)) {
                CodeBuilder.AppendFormat("; {0} = wrapvaluetype({1})", leftSym.Name, leftSym.Name);
            }
            if (needWrapFunction) {
                CodeBuilder.Append("; return ");
                OutputExpressionSyntax(node.Left);
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
                    OutputExpressionSyntax(node.Expression);
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

                    string delegationKey = string.Format("{0}:{1}", ClassInfo.GetFullName(msym.ContainingType), manglingName);
                    string varName = string.Format("__compiler_delegation_{0}", GetSourcePosForVar(node));
                    string varObjName = string.Format("__compiler_delegation_obj_{0}", GetSourcePosForVar(node));
                    CodeBuilder.Append("(function() ");
                    if (string.IsNullOrEmpty(className)) {
                        CodeBuilder.AppendFormat("local {0} = ", varObjName);
                        OutputExpressionSyntax(node.Expression);
                        CodeBuilder.Append("; ");
                    }
                    CodeBuilder.AppendFormat("local {0} = ", varName);

                    CodeBuilder.Append("(function(");
                    string paramsString = string.Join(", ", mi.ParamNames.ToArray());
                    CodeBuilder.Append(paramsString);
                    CodeBuilder.Append(") ");
                    if (!msym.ReturnsVoid) {
                        CodeBuilder.Append("return ");
                    }
                    if (string.IsNullOrEmpty(className)) {
                        CodeBuilder.AppendFormat("{0}", varObjName);
                        CodeBuilder.Append(":");
                    } else {
                        CodeBuilder.Append(className);
                        CodeBuilder.Append(".");
                    }
                    CodeBuilder.Append(manglingName);
                    CodeBuilder.AppendFormat("({0}); end)", paramsString);

                    CodeBuilder.AppendFormat("; setdelegationkey({0}, \"{1}\", ", varName, delegationKey);
                    if (string.IsNullOrEmpty(className)) {
                        CodeBuilder.AppendFormat("{0}", varObjName);
                        CodeBuilder.Append(", ");
                        CodeBuilder.AppendFormat("{0}", varObjName);
                    } else {
                        CodeBuilder.Append(className);
                        CodeBuilder.Append(", ");
                        CodeBuilder.Append(className);
                    }
                    CodeBuilder.Append(".");
                    CodeBuilder.Append(manglingName);
                    CodeBuilder.AppendFormat("); return {0}; end)()", varName);
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
                        OutputExpressionSyntax(node.Expression);
                        CodeBuilder.AppendFormat(", \"{0}\", \"{1}\")", fnOfIntf, mname);
                    } else if (propForBasicValueType) {
                        string pname = psym.Name;
                        string cname = ClassInfo.GetFullName(psym.ContainingType);
                        bool isEnumClass = psym.ContainingType.TypeKind == TypeKind.Enum || cname == SymbolTable.PrefixExternClassName("System.Enum");
                        string ckey = InvocationInfo.CalcInvokeTarget(isEnumClass, cname, this, node.Expression, m_Model);
                        CodeBuilder.AppendFormat("getforbasicvalue(");
                        OutputExpressionSyntax(node.Expression);
                        CodeBuilder.AppendFormat(", {0}, {1}, \"{2}\")", isEnumClass ? "true" : "false", ckey, pname);
                    } else {
                        if (string.IsNullOrEmpty(className)) {
                            OutputExpressionSyntax(node.Expression);
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
                CodeBuilder.AppendFormat("get{0}{1}indexer(", SymbolTable.Instance.IsCs2LuaSymbol(psym) ? string.Empty : "extern", psym.IsStatic ? "static" : "instance");
                if (psym.IsStatic) {
                    string fullName = ClassInfo.GetFullName(psym.ContainingType);
                    CodeBuilder.Append(fullName);
                } else {
                    OutputExpressionSyntax(node.Expression);
                }
                CodeBuilder.Append(", ");
                if (!psym.IsStatic) {
                    string fnOfIntf = "nil";
                    CheckExplicitInterfaceAccess(psym.GetMethod, ref fnOfIntf);
                    CodeBuilder.AppendFormat("{0}, ", fnOfIntf);
                }
                string manglingName = NameMangling(psym.GetMethod);
                CodeBuilder.AppendFormat("\"{0}\", ", manglingName);
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                ii.Init(psym.GetMethod, node.ArgumentList, m_Model);
                OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ArrayToParams, false, node, ii.ArgConversions.ToArray());
                CodeBuilder.Append(")");
            } else if (oper.Kind == OperationKind.ArrayElementReferenceExpression) {
                if (SymbolTable.UseArrayGetSet) {
                    CodeBuilder.Append("arrayget(");
                    OutputExpressionSyntax(node.Expression);
                    CodeBuilder.Append(", ");
                    VisitBracketedArgumentList(node.ArgumentList);
                    CodeBuilder.Append(")");
                } else {
                    OutputExpressionSyntax(node.Expression);
                    CodeBuilder.Append("[");
                    VisitBracketedArgumentList(node.ArgumentList);
                    CodeBuilder.Append("]");
                }
            } else {
                ReportIllegalSymbol(node, symInfo);
            }
        }
        public override void VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
        {
            CodeBuilder.Append("condaccess(");
            OutputExpressionSyntax(node.Expression);
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
                    CodeBuilder.AppendFormat("get{0}{1}indexer(", SymbolTable.Instance.IsCs2LuaSymbol(psym) ? string.Empty : "extern", psym.IsStatic ? "static" : "instance");
                    if (psym.IsStatic) {
                        string fullName = ClassInfo.GetFullName(psym.ContainingType);
                        CodeBuilder.Append(fullName);
                    } else {
                        OutputExpressionSyntax(node.Expression);
                    }
                    CodeBuilder.Append(", ");
                    if (!psym.IsStatic) {
                        string fnOfIntf = "nil";
                        CheckExplicitInterfaceAccess(psym.GetMethod, ref fnOfIntf);
                        CodeBuilder.AppendFormat("{0}, ", fnOfIntf);
                    }
                    string manglingName = NameMangling(psym.GetMethod);
                    CodeBuilder.AppendFormat("\"{0}\", ", manglingName);
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                    List<ExpressionSyntax> args = new List<ExpressionSyntax> { node.WhenNotNull };
                    ii.Init(psym.GetMethod, args, m_Model);
                    OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ArrayToParams, false, elementBinding, ii.ArgConversions.ToArray());
                    CodeBuilder.Append(")");
                    CodeBuilder.Append("; end)");
                } else if (oper.Kind == OperationKind.ArrayElementReferenceExpression) {
                    if (SymbolTable.UseArrayGetSet) {
                        CodeBuilder.Append("arrayget(");
                        OutputExpressionSyntax(node.Expression);
                        CodeBuilder.Append(", ");
                        OutputExpressionSyntax(node.WhenNotNull);
                        CodeBuilder.Append(")");
                    } else {
                        CodeBuilder.Append("(function() return ");
                        OutputExpressionSyntax(node.Expression);
                        CodeBuilder.Append("[");
                        OutputExpressionSyntax(node.WhenNotNull);
                        CodeBuilder.Append("]");
                        CodeBuilder.Append("; end)");
                    }
                } else {
                    ReportIllegalSymbol(node, symInfo);
                }
            } else {
                CodeBuilder.Append("(function() return ");
                OutputExpressionSyntax(node.Expression);
                OutputExpressionSyntax(node.WhenNotNull);
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
        public override void VisitImplicitElementAccess(ImplicitElementAccessSyntax node)
        {
            CodeBuilder.Append("[");
            VisitBracketedArgumentList(node.ArgumentList);
            CodeBuilder.Append("]");
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
                    //调用BoundCollectionInitializerExpression.Initializers
                    var inits = oper.GetType().InvokeMember("Initializers", BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance, null, oper, null) as IList;
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
                                    IConversionExpression opd1 = null, opd2 = null;
                                    if (null != inits && i < inits.Count) {
                                        var init = inits[i];
                                        //调用BoundCollectionElementInitializer.Arguments
                                        var initOpers = init.GetType().InvokeMember("Arguments", BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance, null, init, null) as IList;
                                        if (null != initOpers) {
                                            if (0 < initOpers.Count) {
                                                opd1 = initOpers[0] as IConversionExpression;
                                            }
                                            if (1 < initOpers.Count) {
                                                opd2 = initOpers[1] as IConversionExpression;
                                            }
                                        }
                                    }
                                    CodeBuilder.Append("[");
                                    OutputExpressionSyntax(exp.Expressions[0], opd1);
                                    CodeBuilder.Append("] = ");
                                    OutputExpressionSyntax(exp.Expressions[1], opd2);
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
                                IConversionExpression opd = null;
                                if (null != inits && i < inits.Count) {
                                    var init = inits[i];
                                    //调用BoundCollectionElementInitializer.Arguments
                                    var initOpers = init.GetType().InvokeMember("Arguments", BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance, null, init, null) as IList;
                                    if (null != initOpers) {
                                        if (0 < initOpers.Count) {
                                            opd = initOpers[0] as IConversionExpression;
                                        }
                                    }
                                }
                                OutputExpressionSyntax(args[i], opd);
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
                                IConversionExpression opd = null;
                                if (null != inits && i < inits.Count) {
                                    var init = inits[i];
                                    //调用BoundCollectionElementInitializer.Arguments
                                    var initOpers = init.GetType().InvokeMember("Arguments", BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance, null, init, null) as IList;
                                    if (null != initOpers) {
                                        if (0 < initOpers.Count) {
                                            opd = initOpers[0] as IConversionExpression;
                                        }
                                    }
                                }
                                OutputExpressionSyntax(args[i], opd);
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
                    //ComplexElementInitializer，目前未发现roslyn有实际合法的语法实例，执行到这的一般是存在语义错误的语法
                    CodeBuilder.Append("{");
                    var args = node.Expressions;
                    int ct = args.Count;
                    for (int i = 0; i < ct; ++i) {
                        OutputExpressionSyntax(args[i], null);
                        if (i < ct - 1) {
                            CodeBuilder.Append(", ");
                        }
                    }
                    CodeBuilder.Append("}");
                } else if (isArray) {
                    CodeBuilder.Append("wraparray({");
                    var args = node.Expressions;
                    var arrInitOper = oper as IArrayInitializer;
                    int ct = args.Count;
                    for (int i = 0; i < ct; ++i) {
                        var exp = args[i];
                        IConversionExpression opd = arrInitOper.ElementValues[i] as IConversionExpression;
                        OutputExpressionSyntax(exp, opd);
                        if (i < ct - 1) {
                            CodeBuilder.Append(", ");
                        }
                    }
                    CodeBuilder.AppendFormat("}}, {0})", ct);
                } else {
                    //isObjectInitializer
                    bool isCollectionObj = false;
                    var typeSymInfo = oper.Type;
                    if (null != typeSymInfo) {
                        isCollectionObj = IsImplementationOfSys(typeSymInfo, "ICollection");
                    }
                    if (isCollectionObj) {
                        CodeBuilder.Append("{");
                        var args = node.Expressions;
                        int ct = args.Count;
                        for (int i = 0; i < ct; ++i) {
                            var exp = args[i];
                            IConversionExpression opd = null;
                            //调用BoundObjectInitializerExpression.Initializers
                            var inits = oper.GetType().InvokeMember("Initializers", BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance, null, oper, null) as IList;
                            if (null != inits && i < inits.Count) {
                                opd = inits[i] as IConversionExpression;
                            }
                            if (args[i] is AssignmentExpressionSyntax) {
                                VisitToplevelExpressionFirstPass(args[i], string.Empty);
                            } else {
                                OutputExpressionSyntax(exp, opd);
                            }
                            if (i < ct - 1)
                                CodeBuilder.Append(",");
                        }
                        CodeBuilder.Append("}");
                    } else {
                        CodeBuilder.Append("(function(newobj) ");
                        var args = node.Expressions;
                        int ct = args.Count;
                        for (int i = 0; i < ct; ++i) {
                            var exp = args[i];
                            IConversionExpression opd = null;
                            //调用BoundObjectInitializerExpression.Initializers
                            var inits = oper.GetType().InvokeMember("Initializers", BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance, null, oper, null) as IList;
                            if (null != inits && i < inits.Count) {
                                opd = inits[i] as IConversionExpression;
                            }
                            if (exp is AssignmentExpressionSyntax) {
                                VisitToplevelExpressionFirstPass(exp, string.Empty);
                            } else {
                                OutputExpressionSyntax(exp, opd);
                            }
                            CodeBuilder.Append(";");
                        }
                        CodeBuilder.Append(" end)");
                    }
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
                var namedTypeSym = typeSymInfo as INamedTypeSymbol;

                m_ObjectCreateStack.Push(typeSymInfo);

                string fullTypeName = ClassInfo.GetFullName(typeSymInfo);

                //处理ref/out参数
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo());
                ii.Init(sym, node.ArgumentList, m_Model);
                AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);

                bool isCollection = IsImplementationOfSys(typeSymInfo, "ICollection");
                bool isExternal = !SymbolTable.Instance.IsCs2LuaSymbol(typeSymInfo);

                string ctor = NameMangling(sym);
                string localName = string.Format("__compiler_newobject_{0}", GetSourcePosForVar(node));
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
                    if (null != namedTypeSym && SymbolTable.EnableTranslationCheck){
                        var callerMethodSym = GetCurMethodSemanticInfo();
                        var callerTypeSym = GetCurClassSemanticInfo();
                        if (ClassInfo.HasAttribute(namedTypeSym, "Cs2Lua.DontCheckAttribute")) {
                        } else if (null != callerMethodSym && !ClassInfo.HasAttribute(callerMethodSym, "Cs2Lua.DontCheckAttribute")) {
                        } else if (null != callerTypeSym && !ClassInfo.HasAttribute(callerTypeSym, "Cs2Lua.DontCheckAttribute")) {
                        } else if (fullTypeName == SymbolTable.PrefixExternClassName("System.Collections.Generic.KeyValuePair_TKey_TValue")) {
                        } else if (namedTypeSym.IsGenericType && !SymbolTable.Instance.IsCs2LuaSymbol(namedTypeSym)) {
                            Logger.Instance.Log("Translation Warning", "extern class {0} is generic class, can't create object !", fullTypeName);
                        }
                    }
                }
                if (string.IsNullOrEmpty(ctor)) {
                    CodeBuilder.Append("nil");
                } else {
                    CodeBuilder.AppendFormat("\"{0}\"", ctor);
                }
                if (null != node.Initializer) {
                    CodeBuilder.Append(", ");
                    VisitInitializerExpression(node.Initializer);
                } else {
                    if(isCollection)
                        CodeBuilder.Append(", {}");
                    else
                        CodeBuilder.Append(", nil");
                }
                if (ii.Args.Count + ii.DefaultValueArgs.Count + ii.GenericTypeArgs.Count > 0) {
                    CodeBuilder.Append(", ");
                }
                OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ArrayToParams, false, node, ii.ArgConversions.ToArray());
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
                        
                        AddReferenceAndTryDeriveGenericTypeInstance(ci, msym);
                        string className = ClassInfo.GetFullName(msym.ContainingType);
                        string delegationKey = string.Format("{0}:{1}", className, manglingName);
                        string varName = string.Format("__compiler_delegation_{0}", GetSourcePosForVar(node));
                        CodeBuilder.AppendFormat("(function() local {0} = ", varName);

                        CodeBuilder.Append("(function(");
                        string paramsString = string.Join(", ", mi.ParamNames.ToArray());
                        CodeBuilder.Append(paramsString);
                        CodeBuilder.Append(") ");
                        if (!msym.ReturnsVoid) {
                            CodeBuilder.Append("return ");
                        }
                        if (msym.IsStatic) {
                            CodeBuilder.Append(className);
                            CodeBuilder.Append(".");
                        } else {
                            CodeBuilder.Append("this:");
                        }
                        CodeBuilder.Append(manglingName);
                        CodeBuilder.AppendFormat("({0}); end)", paramsString);

                        CodeBuilder.AppendFormat("; setdelegationkey({0}, \"{1}\", ", varName, delegationKey);
                        if (msym.IsStatic) {
                            CodeBuilder.Append(className);
                            CodeBuilder.Append(", ");
                            CodeBuilder.Append(className);
                        } else {
                            CodeBuilder.Append("this, this");
                        }
                        CodeBuilder.Append(".");
                        CodeBuilder.Append(manglingName);
                        CodeBuilder.AppendFormat("); return {0}; end)()", varName);
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
                if (null != init && null != init.NameEquals) {
                    CodeBuilder.Append(init.NameEquals.Name);
                    CodeBuilder.AppendFormat(" {0} ", init.NameEquals.EqualsToken.Text);
                    VisitToplevelExpression(init.Expression, string.Empty);
                    if (i < ct - 1)
                        CodeBuilder.Append(", ");
                } else {
                    Log(node, "Unknown AnonymousObjectCreationExpressionSyntax !");
                }
            }
            CodeBuilder.Append("}");
        }
        public override void VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
        {
            if (null == node.Initializer) {
                var oper = m_Model.GetOperation(node) as IArrayCreationExpression;
                var rankspecs = node.Type.RankSpecifiers;
                var rankspec = rankspecs[0];
                int rank = rankspec.Rank;
                if (rank >= 1) {
                    CodeBuilder.Append("(function()");
                    int ct = rankspec.Sizes.Count;
                    for (int i = 0; i < ct; ++i) {
                        CodeBuilder.AppendFormat(" local d{0} = ", i);
                        var exp = rankspec.Sizes[i];
                        OutputExpressionSyntax(exp);
                        if (i == 0) {
                            CodeBuilder.Append("; local arr = wraparray({}, d0)");
                        }
                        CodeBuilder.AppendFormat("; for i{0} = 1,d{1} do arr{2} = ", i, i, GetArraySubscriptString(i));
                        if (i < ct - 1) {
                            CodeBuilder.Append("wraparray({}, ");
                            exp = rankspec.Sizes[i + 1];
                            OutputExpressionSyntax(exp);
                            CodeBuilder.Append(");");
                        } else {
                            ITypeSymbol etype = null;
                            if (null != oper && null != oper.ElementType) {
                                etype = oper.ElementType;
                                for (; ; ) {
                                    var t = etype as IArrayTypeSymbol;
                                    if (null != t) {
                                        etype = t.ElementType;
                                    } else {
                                        break;
                                    }
                                }
                            }
                            OutputArrayDefaultValue(etype);
                            CodeBuilder.Append(";");
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