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

namespace RoslynTool.CsToDsl
{
    internal partial class CsDslTranslater
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
            var oper = m_Model.GetOperationEx(node) as IHasOperatorMethodExpression;
            if (null != oper && oper.UsesOperatorMethod) {
                IMethodSymbol msym = oper.OperatorMethod;
                var castOper = oper as IConversionExpression;
                if (null != castOper) {
                    var opd = castOper.Operand as IConversionExpression;
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                    var arglist = new List<ExpressionSyntax>() { node.Left };
                    ii.Init(msym, arglist, m_Model, opd);
                    OutputOperatorInvoke(ii, node);
                }
                else {
                    var boper = oper as IBinaryOperatorExpression;
                    var lopd = null == boper ? null : boper.LeftOperand as IConversionExpression;
                    var ropd = null == boper ? null : boper.RightOperand as IConversionExpression;

                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                    var arglist = new List<ExpressionSyntax>() { node.Left, node.Right };
                    ii.Init(msym, arglist, m_Model, lopd, ropd);
                    OutputOperatorInvoke(ii, node);
                }
            }
            else {
                var boper = oper as IBinaryOperatorExpression;
                var lopd = null == boper ? null : boper.LeftOperand as IConversionExpression;
                var ropd = null == boper ? null : boper.RightOperand as IConversionExpression;

                string op = node.OperatorToken.Text;
                string leftType = "null";
                string rightType = "null";
                string leftTypeKind = "null";
                string rightTypeKind = "null";
                if (null != boper) {
                    if (null != boper.LeftOperand) {
                        var ltype = boper.LeftOperand.Type;
                        if (null != ltype) {
                            leftType = ClassInfo.GetFullName(ltype);
                            leftTypeKind = "TypeKind." + ltype.TypeKind.ToString();
                        }
                    }
                    if (null != boper.RightOperand) {
                        var rtype = boper.RightOperand.Type;
                        if (null != rtype) {
                            rightType = ClassInfo.GetFullName(rtype);
                            rightTypeKind = "TypeKind." + rtype.TypeKind.ToString();
                        }
                    }
                }
                ProcessBinaryOperator(node, ref op);
                string functor = string.Empty;
                if (s_BinaryFunctor.TryGetValue(op, out functor)) {
                    CodeBuilder.AppendFormat("{0}(", functor);
                    OutputExpressionSyntax(node.Left, lopd);
                    CodeBuilder.Append(", ");
                    if (op == "as" || op == "is") {
                        var typeInfo = m_Model.GetTypeInfo(node.Right);
                        var type = typeInfo.Type;
                        OutputType(type, node, ci, op);
                        CodeBuilder.AppendFormat(", TypeKind.{0}", type.TypeKind);
                    }
                    else if (op == "??") {
                        var rightOper = m_Model.GetOperationEx(node.Right);
                        bool rightIsConst = null != rightOper && rightOper.ConstantValue.HasValue;
                        if (rightIsConst) {
                            CodeBuilder.Append("true, ");
                            OutputExpressionSyntax(node.Right, ropd);
                        }
                        else {
                            CodeBuilder.Append("false, (function(){ return(");
                            OutputExpressionSyntax(node.Right, ropd);
                            CodeBuilder.Append("); })");
                        }
                    }
                    else {
                        OutputExpressionSyntax(node.Right, ropd);
                    }
                    CodeBuilder.Append(")");
                }
                else {
                    bool handled = false;
                    if (op == "==" || op == "!=") {
                        handled = ProcessEqualOrNotEqual(op, node.Left, node.Right, lopd, ropd);
                    }
                    if (!handled) {
                        CodeBuilder.Append("execbinary(");
                        CodeBuilder.AppendFormat("\"{0}\", ", op);
                        OutputExpressionSyntax(node.Left, lopd);
                        CodeBuilder.Append(", ");
                        OutputExpressionSyntax(node.Right, ropd);
                        CodeBuilder.AppendFormat(", {0}, {1}, {2}, {3}", CsDslTranslater.EscapeType(leftType, leftTypeKind), CsDslTranslater.EscapeType(rightType, rightTypeKind), leftTypeKind, rightTypeKind);
                        CodeBuilder.Append(")");
                    }
                }
            }
        }
        public override void VisitConditionalExpression(ConditionalExpressionSyntax node)
        {
            IConversionExpression opd = null;
            var oper = m_Model.GetOperationEx(node) as IConditionalChoiceExpression;
            if (null != oper) {
                opd = oper.Condition as IConversionExpression;
            }
            var tOper = m_Model.GetOperationEx(node.WhenTrue);
            var fOper = m_Model.GetOperationEx(node.WhenFalse);
            bool trueIsConst = null != tOper && tOper.ConstantValue.HasValue;
            bool falseIsConst = null != fOper && fOper.ConstantValue.HasValue;

            CodeBuilder.Append("condexp(");
            OutputExpressionSyntax(node.Condition, opd);
            if (trueIsConst) {
                CodeBuilder.Append(", true, ");
            }
            else {
                CodeBuilder.Append(", false, (function(){ return(");
            }
            OutputExpressionSyntax(node.WhenTrue);
            if (trueIsConst) {
                CodeBuilder.Append(", ");
            }
            else {
                CodeBuilder.Append("); }), ");
            }
            if (falseIsConst) {
                CodeBuilder.Append("true, ");
            }
            else {
                CodeBuilder.Append("false, (function(){ return(");
            }
            OutputExpressionSyntax(node.WhenFalse);
            if (falseIsConst) {
                CodeBuilder.Append(")");
            }
            else {
                CodeBuilder.Append("); }))");
            }
        }
        public override void VisitThisExpression(ThisExpressionSyntax node)
        {
            CodeBuilder.Append("this");
        }
        public override void VisitBaseExpression(BaseExpressionSyntax node)
        {
            CodeBuilder.Append("getinstance(SymbolKind.Field, this, \"base\")");
        }
        public override void VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
        {
            CodeBuilder.Append("( ");
            OutputExpressionSyntax(node.Expression);
            CodeBuilder.Append(" )");
        }
        public override void VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
        {
            var oper = m_Model.GetOperationEx(node);
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
            }
            else if (null != assignOper && null != assignOper.Target) {
                typeSym = assignOper.Target.Type;
            }
            if (null != typeSym) {
                type = ClassInfo.GetFullName(typeSym);
                typeKind = "TypeKind." + typeSym.TypeKind.ToString();
            }
            if (null != unaryOper && unaryOper.UsesOperatorMethod) {
                IMethodSymbol msym = unaryOper.OperatorMethod;
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                var arglist = new List<ExpressionSyntax>() { node.Operand };
                ii.Init(msym, arglist, m_Model, opd);
                OutputOperatorInvoke(ii, node);
            }
            else if (null != assignOper && assignOper.UsesOperatorMethod) {
                //++/--的重载调这里
                CodeBuilder.Append("(function(){ ");
                OutputExpressionSyntax(node.Operand, opd);
                CodeBuilder.Append(" = ");
                IMethodSymbol msym = assignOper.OperatorMethod;
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                var arglist = new List<ExpressionSyntax>() { node.Operand };
                ii.Init(msym, arglist, m_Model, opd);
                OutputOperatorInvoke(ii, node);
                CodeBuilder.Append("; return(");
                OutputExpressionSyntax(node.Operand, opd);
                CodeBuilder.Append("); })()");
            }
            else {
                string op = node.OperatorToken.Text;
                if (op == "++" || op == "--") {
                    op = op == "++" ? "+" : "-";
                    CodeBuilder.Append("(function(){ ");
                    OutputExpressionSyntax(node.Operand, opd);
                    CodeBuilder.Append(" = ");
                    CodeBuilder.Append("execbinary(");
                    CodeBuilder.AppendFormat("\"{0}\", ", op);
                    OutputExpressionSyntax(node.Operand, opd);
                    CodeBuilder.AppendFormat(", 1, {0}, {1}, {2}, {3}", CsDslTranslater.EscapeType(type, typeKind), CsDslTranslater.EscapeType(type, typeKind), typeKind, typeKind);
                    CodeBuilder.Append(")");
                    CodeBuilder.Append("; return(");
                    OutputExpressionSyntax(node.Operand, opd);
                    CodeBuilder.Append("); })()");
                }
                else {
                    ProcessUnaryOperator(node, ref op);
                    string functor;
                    if (s_UnaryFunctor.TryGetValue(op, out functor)) {
                        CodeBuilder.AppendFormat("{0}(", functor);
                        OutputExpressionSyntax(node.Operand, opd);
                        CodeBuilder.Append(")");
                    }
                    else {
                        CodeBuilder.Append("execunary(");
                        CodeBuilder.AppendFormat("\"{0}\", ", op);
                        OutputExpressionSyntax(node.Operand, opd);
                        CodeBuilder.AppendFormat(", {0}, {1}", CsDslTranslater.EscapeType(type, typeKind), typeKind);
                        CodeBuilder.Append(")");
                    }
                }
            }
        }
        public override void VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
        {
            var oper = m_Model.GetOperationEx(node);
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
            }
            else if (null != assignOper && null != assignOper.Target) {
                typeSym = assignOper.Target.Type;
            }
            if (null != typeSym) {
                type = ClassInfo.GetFullName(typeSym);
                typeKind = "TypeKind." + typeSym.TypeKind.ToString();
            }
            if (null != unaryOper && unaryOper.UsesOperatorMethod) {
                IMethodSymbol msym = unaryOper.OperatorMethod;
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                var arglist = new List<ExpressionSyntax>() { node.Operand };
                ii.Init(msym, arglist, m_Model, opd);
                OutputOperatorInvoke(ii, node);
            }
            else if (null != assignOper && assignOper.UsesOperatorMethod) {
                //++/--的重载调这里
                string op = node.OperatorToken.Text;
                if (op == "++" || op == "--") {
                    string varName = string.Format("__unary_{0}", GetSourcePosForVar(node));
                    CodeBuilder.AppendFormat("(function(){{ local({0}); {0} = ", varName);
                    OutputExpressionSyntax(node.Operand, opd);
                    CodeBuilder.Append("; ");
                    OutputExpressionSyntax(node.Operand, opd);
                    CodeBuilder.Append(" = ");
                    IMethodSymbol msym = assignOper.OperatorMethod;
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                    var arglist = new List<ExpressionSyntax>() { node.Operand };
                    ii.Init(msym, arglist, m_Model, opd);
                    OutputOperatorInvoke(ii, node);
                    CodeBuilder.Append("; return(");
                    CodeBuilder.Append(varName);
                    CodeBuilder.Append("); })()");
                }
                else {
                    CodeBuilder.Append("(function(){ ");
                    OutputExpressionSyntax(node.Operand, opd);
                    CodeBuilder.Append(" = ");
                    IMethodSymbol msym = assignOper.OperatorMethod;
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                    var arglist = new List<ExpressionSyntax>() { node.Operand };
                    ii.Init(msym, arglist, m_Model, opd);
                    OutputOperatorInvoke(ii, node);
                    CodeBuilder.Append("; return(");
                    OutputExpressionSyntax(node.Operand, opd);
                    CodeBuilder.Append("); })()");
                }
            }
            else {
                string op = node.OperatorToken.Text;
                if (op == "++" || op == "--") {
                    op = op == "++" ? "+" : "-";
                    string varName = string.Format("__unary_{0}", GetSourcePosForVar(node));
                    CodeBuilder.AppendFormat("(function(){{ local({0}); {0} = ", varName);
                    OutputExpressionSyntax(node.Operand, opd);
                    CodeBuilder.Append("; ");
                    OutputExpressionSyntax(node.Operand, opd);
                    CodeBuilder.Append(" = ");
                    CodeBuilder.Append("execbinary(");
                    CodeBuilder.AppendFormat("\"{0}\", ", op);
                    OutputExpressionSyntax(node.Operand, opd);
                    CodeBuilder.AppendFormat(", 1, {0}, {1}, {2}, {3}", CsDslTranslater.EscapeType(type, typeKind), CsDslTranslater.EscapeType(type, typeKind), typeKind, typeKind);
                    CodeBuilder.Append(")");
                    CodeBuilder.Append("; return(");
                    CodeBuilder.Append(varName);
                    CodeBuilder.Append("); })()");
                }
                else {
                    ProcessUnaryOperator(node, ref op);
                    string functor;
                    if (s_UnaryFunctor.TryGetValue(op, out functor)) {
                        CodeBuilder.AppendFormat("{0}(", functor);
                        OutputExpressionSyntax(node.Operand, opd);
                        CodeBuilder.Append(")");
                    }
                    else {
                        CodeBuilder.Append("execunary(");
                        CodeBuilder.AppendFormat("\"{0}\", ", op);
                        OutputExpressionSyntax(node.Operand, opd);
                        CodeBuilder.AppendFormat(", {0}, {1}", CsDslTranslater.EscapeType(type, typeKind), typeKind);
                        CodeBuilder.Append(")");
                    }
                }
            }
        }
        public override void VisitSizeOfExpression(SizeOfExpressionSyntax node)
        {
            var oper = m_Model.GetOperationEx(node) as ISizeOfExpression;
            if (oper.ConstantValue.HasValue) {
                OutputConstValue(oper.ConstantValue.Value, oper);
            }
            else {
                ReportIllegalType(oper.Type);
            }
        }
        public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();

            var oper = m_Model.GetOperationEx(node) as ITypeOfExpression;
            var type = oper.TypeOperand;

            TypeChecker.CheckType(type, node, GetCurMethodSemanticInfo());

            CodeBuilder.Append("typeof(");
            OutputType(type, node, ci, "typeof");
            CodeBuilder.Append(")");
        }
        public override void VisitCastExpression(CastExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            var oper = m_Model.GetOperationEx(node) as IConversionExpression;
            var opd = oper.Operand as IConversionExpression;
            if (null != oper && oper.UsesOperatorMethod) {
                IMethodSymbol msym = oper.OperatorMethod;
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                var arglist = new List<ExpressionSyntax>() { node.Expression };
                ii.Init(msym, arglist, m_Model, opd);
                AddReferenceAndTryDeriveGenericTypeInstance(ci, oper.Type);

                OutputOperatorInvoke(ii, node);
            }
            else {
                CodeBuilder.Append("typecast(");
                OutputExpressionSyntax(node.Expression, opd);

                var typeInfo = m_Model.GetTypeInfo(node.Type);
                var type = typeInfo.Type;

                var srcOper = m_Model.GetOperationEx(node.Expression);
                if (null != srcOper) {
                    TypeChecker.CheckConvert(srcOper.Type, type, node, GetCurMethodSemanticInfo());
                }
                else {
                    Log(node, "cast type checker failed !");
                }

                CodeBuilder.Append(", ");
                OutputType(type, node, ci, "cast");
                CodeBuilder.AppendFormat(", TypeKind.{0}", type.TypeKind);
                CodeBuilder.Append(")");
            }
        }
        public override void VisitDefaultExpression(DefaultExpressionSyntax node)
        {
            var typeInfo = m_Model.GetTypeInfo(node.Type);
            OutputDefaultValue(typeInfo.Type);
        }
        #endregion

        #region 相对复杂的表达式
        public override void VisitAssignmentExpression(AssignmentExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();

            string op = node.OperatorToken.Text;
            string baseOp = op.Substring(0, op.Length - 1);

            bool needWrapFunction = true;
            var leftMemberAccess = node.Left as MemberAccessExpressionSyntax;
            var leftElementAccess = node.Left as ElementAccessExpressionSyntax;
            var leftCondAccess = node.Left as ConditionalAccessExpressionSyntax;

            var leftOper = m_Model.GetOperationEx(node.Left);
            var leftSymbolInfo = m_Model.GetSymbolInfoEx(node.Left);
            var leftSym = leftSymbolInfo.Symbol;
            var leftPsym = leftSym as IPropertySymbol;
            var leftEsym = leftSym as IEventSymbol;
            var leftFsym = leftSym as IFieldSymbol;
            
            var rightOper = m_Model.GetOperationEx(node.Right);

            var curMethod = GetCurMethodSemanticInfo();
            if (null != leftOper && null != rightOper) {
                TypeChecker.CheckConvert(rightOper.Type, leftOper.Type, node, curMethod);
            }
            else {
                Log(node, "assignment type checker failed ! left oper:{0} right oper:{1}", leftOper, rightOper);
            }

            SpecialAssignmentType specialType = SpecialAssignmentType.None;
            if (null != leftMemberAccess && null != leftPsym) {
                if (!leftPsym.IsStatic) {
                    bool expIsBasicType = false;
                    var expOper = m_Model.GetOperationEx(leftMemberAccess.Expression);
                    if (null != expOper && SymbolTable.IsBasicType(expOper.Type)) {
                        expIsBasicType = true;
                    }
                    if (CheckExplicitInterfaceAccess(leftPsym)) {
                        specialType = SpecialAssignmentType.PropExplicitImplementInterface;
                    }
                    else if (SymbolTable.IsBasicValueProperty(leftPsym) || expIsBasicType) {
                        specialType = SpecialAssignmentType.PropForBasicValueType;
                    }
                }
            }
            if (specialType == SpecialAssignmentType.PropExplicitImplementInterface || specialType == SpecialAssignmentType.PropForBasicValueType
                || null != leftElementAccess || null != leftCondAccess
                || leftOper.Type.TypeKind == TypeKind.Delegate && (leftSym.Kind != SymbolKind.Local || op != "=")) {
                needWrapFunction = false;
            }
            string assignVar = null;
            if (needWrapFunction) {
                assignVar = string.Format("__assign_{0}", GetSourcePosForVar(node));
                //顶层的赋值语句已经处理，这里的赋值都需要包装成lambda函数的样式
                CodeBuilder.AppendFormat("execclosure({0}, true){{ ", assignVar);
            }
            VisitAssignment(ci, op, baseOp, node, string.Empty, false, leftOper, leftSym, leftPsym, leftEsym, leftFsym, leftMemberAccess, leftElementAccess, leftCondAccess, specialType);
            var oper = m_Model.GetOperationEx(node.Right);
            if (null != oper && null != oper.Type && oper.Type.TypeKind == TypeKind.Struct && !CsDslTranslater.IsImplementationOfSys(oper.Type, "IEnumerator")) {
                //只有变量赋值与字段赋值需要处理，其它的都在相应的函数调用里处理了
                if (null != leftSym && leftSym.Kind == SymbolKind.Local || null != leftFsym) {
                    if (SymbolTable.Instance.IsCs2DslSymbol(oper.Type)) {
                        CodeBuilder.Append(GetIndentString());
                        OutputExpressionSyntax(node.Left);
                        CodeBuilder.Append(" = wrapstruct(");
                        OutputExpressionSyntax(node.Left);
                        CodeBuilder.AppendFormat(", {0});", ClassInfo.GetFullName(oper.Type));
                        CodeBuilder.AppendLine();
                    }
                    else {
                        string ns = ClassInfo.GetNamespaces(oper.Type);
                        if (ns != "System") {
                            CodeBuilder.Append(GetIndentString());
                            OutputExpressionSyntax(node.Left);
                            CodeBuilder.Append(" = wrapexternstruct(");
                            OutputExpressionSyntax(node.Left);
                            CodeBuilder.AppendFormat(", {0});", ClassInfo.GetFullName(oper.Type));
                            CodeBuilder.AppendLine();
                        }
                    }
                }
            }
            if (needWrapFunction) {
                //这里假定赋值语句左边是多次访问不变的左值（暂未想到满足所有情形的解决方案）
                CodeBuilder.AppendFormat("; {0} = ", assignVar);
                OutputExpressionSyntax(node.Left);
                CodeBuilder.Append("; }");
            }
        }
        public override void VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            VisitInvocation(ci, node, string.Empty, false);
        }
        public override void VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
        {
            TypeChecker.CheckMemberAccess(m_Model, node, GetCurMethodSemanticInfo());

            SymbolInfo symInfo = m_Model.GetSymbolInfoEx(node);
            var sym = symInfo.Symbol;

            string className = string.Empty;
            if (null != sym && sym.IsStatic && null != sym.ContainingType) {
                className = ClassInfo.GetFullName(sym.ContainingType);
            }

            bool isExtern = false;
            if (null != sym) {
                isExtern = !SymbolTable.Instance.IsCs2DslSymbol(sym);
                if (sym.IsStatic) {
                    var ci = m_ClassInfoStack.Peek();
                    AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                }
            }
            else {
                ReportIllegalSymbol(node, symInfo);
            }
            if (node.Parent is InvocationExpressionSyntax) {
                var msym = sym as IMethodSymbol;
                string manglingName = NameMangling(msym);
                if (string.IsNullOrEmpty(className)) {
                    if(isExtern)
                        CodeBuilder.Append("getexterninstance(SymbolKind.");
                    else
                        CodeBuilder.Append("getinstance(SymbolKind.");
                    CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(sym));
                    CodeBuilder.Append(", ");
                    OutputExpressionSyntax(node.Expression);
                    CodeBuilder.Append(", \"");
                }
                else {
                    if (isExtern)
                        CodeBuilder.Append("getexternstatic(SymbolKind.");
                    else
                        CodeBuilder.Append("getstatic(SymbolKind.");
                    CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(sym));
                    CodeBuilder.Append(", ");
                    CodeBuilder.Append(className);
                    CodeBuilder.Append(", \"");
                }
                CodeBuilder.Append(manglingName);
                CodeBuilder.Append("\")");
            }
            else {
                var msym = sym as IMethodSymbol;
                if (null != msym) {
                    string manglingName = NameMangling(msym);
                    var mi = new MethodInfo();
                    mi.Init(msym, node);

                    string delegationKey = string.Format("{0}:{1}", ClassInfo.GetFullName(msym.ContainingType), manglingName);
                    string srcPos = GetSourcePosForVar(node);
                    string varName = string.Format("__delegation_{0}", srcPos);
                    string varObjName = string.Format("__delegation_obj_{0}", srcPos);
                    CodeBuilder.Append("(function(){ ");
                    if (string.IsNullOrEmpty(className)) {
                        CodeBuilder.AppendFormat("local({0}); {0} = ", varObjName);
                        OutputExpressionSyntax(node.Expression);
                        CodeBuilder.Append("; ");
                    }
                    string paramsString = string.Join(", ", mi.ParamNames.ToArray());

                    if (string.IsNullOrEmpty(className)) {
                        CodeBuilder.AppendFormat("builddelegation(\"{0}\", {1}, \"{2}\", {3}, {4}, {5}, {6});", paramsString, varName, delegationKey, varObjName, manglingName, msym.ReturnsVoid ? "false" : "true", string.IsNullOrEmpty(className) ? "false" : "true");
                    }
                    else {
                        CodeBuilder.AppendFormat("builddelegation(\"{0}\", {1}, \"{2}\", {3}, {4}, {5}, {6});", paramsString, varName, delegationKey, className, manglingName, msym.ReturnsVoid ? "false" : "true", string.IsNullOrEmpty(className) ? "false" : "true");
                    }

                    CodeBuilder.Append(" })()");
                }
                else {
                    var psym = sym as IPropertySymbol;
                    string mname = string.Empty;
                    bool propExplicitImplementInterface = false;
                    bool propForBasicValueType = false;
                    if (null != psym) {
                        if (!psym.IsStatic) {
                            propExplicitImplementInterface = CheckExplicitInterfaceAccess(psym, ref mname);
                            var expOper = m_Model.GetOperationEx(node.Expression);
                            bool expIsBasicType = false;
                            if (null != expOper && SymbolTable.IsBasicType(expOper.Type)) {
                                expIsBasicType = true;
                            }
                            propForBasicValueType = SymbolTable.IsBasicValueProperty(psym) || expIsBasicType;
                        }
                    }
                    if (propExplicitImplementInterface) {
                        //这里不区分是否外部符号了，委托到动态语言的脚本库实现，可根据对象运行时信息判断
                        CodeBuilder.AppendFormat("getinstance(SymbolKind.Property, ");
                        OutputExpressionSyntax(node.Expression);
                        CodeBuilder.AppendFormat(", \"{0}\")", mname);
                    }
                    else if (propForBasicValueType) {
                        //这里不区分是否外部符号了，委托到动态语言的脚本库实现，可根据对象运行时信息判断
                        string pname = psym.Name;
                        string cname = ClassInfo.GetFullName(psym.ContainingType);
                        bool isEnumClass = psym.ContainingType.TypeKind == TypeKind.Enum || cname == "System.Enum";
                        string ckey = InvocationInfo.CalcInvokeTarget(isEnumClass, cname, this, node.Expression, m_Model);
                        CodeBuilder.AppendFormat("getforbasicvalue(");
                        OutputExpressionSyntax(node.Expression);
                        CodeBuilder.AppendFormat(", {0}, {1}, \"{2}\")", isEnumClass ? "true" : "false", ckey, pname);
                    }
                    else if (null != sym) {                        
                        if (string.IsNullOrEmpty(className)) {
                            if (isExtern)
                                CodeBuilder.Append("getexterninstance(SymbolKind.");
                            else
                                CodeBuilder.Append("getinstance(SymbolKind.");
                            CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(sym));
                            CodeBuilder.Append(", ");
                            OutputExpressionSyntax(node.Expression);
                        }
                        else {
                            if (isExtern)
                                CodeBuilder.Append("getexternstatic(SymbolKind.");
                            else
                                CodeBuilder.Append("getstatic(SymbolKind.");
                            CodeBuilder.Append(SymbolTable.Instance.GetSymbolKind(sym));
                            CodeBuilder.Append(", ");
                            CodeBuilder.Append(className);
                        }
                        CodeBuilder.Append(", ");
                        CodeBuilder.AppendFormat("\"{0}\"", node.Name.Identifier.Text);
                        CodeBuilder.Append(")");
                    }
                    else {
                        if (string.IsNullOrEmpty(className)) {
                            OutputExpressionSyntax(node.Expression);
                        }
                        else {
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
            var oper = m_Model.GetOperationEx(node);
            var symInfo = m_Model.GetSymbolInfoEx(node);
            var sym = symInfo.Symbol;
            var psym = sym as IPropertySymbol;
            if (null != sym && sym.IsStatic) {
                var ci = m_ClassInfoStack.Peek();
                AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
            }
            if (null != psym && psym.IsIndexer) {
                bool isCs2Lua = SymbolTable.Instance.IsCs2DslSymbol(psym);
                CodeBuilder.AppendFormat("get{0}{1}indexer(", isCs2Lua ? string.Empty : "extern", psym.IsStatic ? "static" : "instance");
                if (!isCs2Lua) {
                    INamedTypeSymbol namedTypeSym = null;
                    var expOper = m_Model.GetOperationEx(node.Expression);
                    if (null != expOper) {
                        string fullName = ClassInfo.GetFullName(expOper.Type);
                        CodeBuilder.Append(fullName);
                        namedTypeSym = expOper.Type as INamedTypeSymbol;
                    }
                    else {
                        CodeBuilder.Append("null");
                    }
                    CodeBuilder.Append(", ");
                    OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                    CodeBuilder.Append(", ");
                }
                if (psym.IsStatic) {
                    string fullName = ClassInfo.GetFullName(psym.ContainingType);
                    CodeBuilder.Append(fullName);
                }
                else {
                    OutputExpressionSyntax(node.Expression);
                }
                CodeBuilder.Append(", ");
                string manglingName = NameMangling(psym.GetMethod);
                if (!psym.IsStatic) {
                    CheckExplicitInterfaceAccess(psym.GetMethod, ref manglingName);
                    string fullName = ClassInfo.GetFullName(psym.ContainingType);
                    CodeBuilder.Append(fullName);
                    CodeBuilder.Append(", ");
                }
                CodeBuilder.AppendFormat("\"{0}\", {1}, ", manglingName, psym.GetMethod.Parameters.Length);
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                ii.Init(psym.GetMethod, node.ArgumentList, m_Model);
                OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ExternOverloadedMethodSignature, ii.PostPositionGenericTypeArgs, ii.ArrayToParams, false, node, ii.ArgConversions.ToArray());
                CodeBuilder.Append(")");
            }
            else if (oper.Kind == OperationKind.ArrayElementReferenceExpression) {
                if (SymbolTable.UseArrayGetSet) {
                    CodeBuilder.Append("arrayget(");
                    OutputExpressionSyntax(node.Expression);
                    CodeBuilder.Append(", ");
                    VisitBracketedArgumentList(node.ArgumentList);
                    CodeBuilder.Append(")");
                }
                else {
                    OutputExpressionSyntax(node.Expression);
                    CodeBuilder.Append("[");
                    VisitBracketedArgumentList(node.ArgumentList);
                    CodeBuilder.Append("]");
                }
            }
            else {
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
                var oper = m_Model.GetOperationEx(node.WhenNotNull);
                var symInfo = m_Model.GetSymbolInfoEx(node.WhenNotNull);
                var sym = symInfo.Symbol;
                var psym = sym as IPropertySymbol;
                if (null != sym && sym.IsStatic) {
                    var ci = m_ClassInfoStack.Peek();
                    AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);
                }
                if (null != psym && psym.IsIndexer) {
                    CodeBuilder.Append("(function(){ return(");
                    bool isCs2Lua = SymbolTable.Instance.IsCs2DslSymbol(psym);
                    CodeBuilder.AppendFormat("get{0}{1}indexer(", isCs2Lua ? string.Empty : "extern", psym.IsStatic ? "static" : "instance");
                    if (!isCs2Lua) {
                        INamedTypeSymbol namedTypeSym = null;
                        var expOper = m_Model.GetOperationEx(node.Expression);
                        if (null != expOper) {
                            string fullName = ClassInfo.GetFullName(expOper.Type);
                            CodeBuilder.Append(fullName);
                            namedTypeSym = expOper.Type as INamedTypeSymbol;
                        }
                        else {
                            CodeBuilder.Append("null");
                        }
                        CodeBuilder.Append(", ");
                        OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                        CodeBuilder.Append(", ");
                    }
                    if (psym.IsStatic) {
                        string fullName = ClassInfo.GetFullName(psym.ContainingType);
                        CodeBuilder.Append(fullName);
                    }
                    else {
                        OutputExpressionSyntax(node.Expression);
                    }
                    CodeBuilder.Append(", ");
                    string manglingName = NameMangling(psym.GetMethod);
                    if (!psym.IsStatic) {
                        CheckExplicitInterfaceAccess(psym.GetMethod, ref manglingName);
                        string fullName = ClassInfo.GetFullName(psym.ContainingType);
                        CodeBuilder.Append(fullName);
                        CodeBuilder.Append(", ");
                    }
                    CodeBuilder.AppendFormat("\"{0}\", {1}, ", manglingName, psym.GetMethod.Parameters.Length);
                    InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                    List<ExpressionSyntax> args = new List<ExpressionSyntax> { node.WhenNotNull };
                    ii.Init(psym.GetMethod, args, m_Model);
                    OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ExternOverloadedMethodSignature, ii.PostPositionGenericTypeArgs, ii.ArrayToParams, false, elementBinding, ii.ArgConversions.ToArray());
                    CodeBuilder.Append(")");
                    CodeBuilder.Append("); })");
                }
                else if (oper.Kind == OperationKind.ArrayElementReferenceExpression) {
                    if (SymbolTable.UseArrayGetSet) {
                        CodeBuilder.Append("arrayget(");
                        OutputExpressionSyntax(node.Expression);
                        CodeBuilder.Append(", ");
                        OutputExpressionSyntax(node.WhenNotNull);
                        CodeBuilder.Append(")");
                    }
                    else {
                        CodeBuilder.Append("(function(){ return(");
                        OutputExpressionSyntax(node.Expression);
                        CodeBuilder.Append("[");
                        OutputExpressionSyntax(node.WhenNotNull);
                        CodeBuilder.Append("]");
                        CodeBuilder.Append("); })");
                    }
                }
                else {
                    ReportIllegalSymbol(node, symInfo);
                }
            }
            else {
                CodeBuilder.Append("(function(){ return(");
                OutputExpressionSyntax(node.Expression);
                OutputExpressionSyntax(node.WhenNotNull);
                CodeBuilder.Append("); })");
            }
            CodeBuilder.Append(")");
        }
        public override void VisitMemberBindingExpression(MemberBindingExpressionSyntax node)
        {
            var symInfo = m_Model.GetSymbolInfoEx(node.Name);
            var sym = symInfo.Symbol;
            var msym = sym as IMethodSymbol;
            if (null != msym) {
                string manglingName = NameMangling(msym);
                CodeBuilder.AppendFormat(".{0}", manglingName);
            }
            else {
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
        /// <summary>
        /// 对象创建与初始化是除赋值与函数调外另一个比较复杂的地方，这个函数和后面几个函数完成相关工作。
        /// </summary>
        /// <param name="node"></param>
        public override void VisitInitializerExpression(InitializerExpressionSyntax node)
        {
            var oper = m_Model.GetOperationEx(node);
            if (null != oper) {
                var namedTypeSym = oper.Type as INamedTypeSymbol;
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
                            var args = node.Expressions;
                            int ct = args.Count;
                            CodeBuilder.Append("literaldictionary(");
                            CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                            if (ct > 0)
                                CodeBuilder.Append(", ");
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
                                    OutputExpressionSyntax(exp.Expressions[0], opd1);
                                    CodeBuilder.Append(" => ");
                                    OutputExpressionSyntax(exp.Expressions[1], opd2);
                                }
                                else {
                                    Log(args[i], "Dictionary init error !");
                                }
                                if (i < ct - 1) {
                                    CodeBuilder.Append(", ");
                                }
                            }
                            CodeBuilder.Append(")");
                        }
                        else if (isList) {
                            var args = node.Expressions;
                            int ct = args.Count;
                            CodeBuilder.Append("literallist(");
                            CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                            if (ct > 0)
                                CodeBuilder.Append(", ");
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
                            CodeBuilder.Append(")");
                        }
                        else {
                            var args = node.Expressions;
                            int ct = args.Count;
                            CodeBuilder.Append("literalcollection(");
                            CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                            if (ct > 0)
                                CodeBuilder.Append(", ");
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
                            CodeBuilder.Append(")");
                        }
                    }
                    else {
                        Log(node, "Can't find operation type ! operation info: {0}", oper.ToString());
                    }
                }
                else if (isComplex) {
                    //ComplexElementInitializer，目前未发现roslyn有实际合法的语法实例，执行到这的一般是存在语义错误的语法
                    var args = node.Expressions;
                    int ct = args.Count;
                    CodeBuilder.Append("literalcomplex(");
                    CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                    if (ct > 0)
                        CodeBuilder.Append(", ");
                    for (int i = 0; i < ct; ++i) {
                        OutputExpressionSyntax(args[i], null);
                        if (i < ct - 1) {
                            CodeBuilder.Append(", ");
                        }
                    }
                    CodeBuilder.Append(")");
                }
                else if (isArray) {
                    var args = node.Expressions;
                    var arrInitOper = oper as IArrayInitializer;
                    int ct = args.Count;
                    string elementType = "null";
                    string typeKind = "ErrorType";
                    var arrCreateExp = node.Parent as ArrayCreationExpressionSyntax;
                    if (null != arrCreateExp) {
                        var arrCreate = m_Model.GetOperationEx(arrCreateExp) as IArrayCreationExpression;
                        ITypeSymbol etype = SymbolTable.GetElementType(arrCreate.ElementType);
                        elementType = ClassInfo.GetFullName(etype);
                        typeKind = etype.TypeKind.ToString();
                    }
                    else if (ct > 0) {
                        ITypeSymbol etype = SymbolTable.GetElementType(arrInitOper.ElementValues[0].Type);
                        elementType = ClassInfo.GetFullName(etype);
                        typeKind = etype.TypeKind.ToString();
                    }
                    if (ct > 0) {
                        CodeBuilder.AppendFormat("literalarray({0}, TypeKind.{1}, ", elementType, typeKind);
                        for (int i = 0; i < ct; ++i) {
                            var exp = args[i];
                            IConversionExpression opd = arrInitOper.ElementValues[i] as IConversionExpression;
                            OutputExpressionSyntax(exp, opd);
                            if (i < ct - 1) {
                                CodeBuilder.Append(", ");
                            }
                        }
                        CodeBuilder.Append(")");
                    }
                    else {
                        CodeBuilder.AppendFormat("newarray({0}, TypeKind.{1})", elementType, typeKind);
                    }
                }
                else {
                    //isObjectInitializer
                    bool isCollectionObj = false;
                    var typeSymInfo = oper.Type;
                    if (null != typeSymInfo) {
                        isCollectionObj = IsImplementationOfSys(typeSymInfo, "ICollection");
                    }
                    if (isCollectionObj) {
                        var args = node.Expressions;
                        int ct = args.Count;
                        CodeBuilder.Append("literalcollection(");
                        CsDslTranslater.OutputTypeArgsInfo(CodeBuilder, namedTypeSym);
                        if (ct > 0)
                            CodeBuilder.Append(", ");
                        for (int i = 0; i < ct; ++i) {
                            var exp = args[i];
                            IConversionExpression opd = null;
                            //调用BoundObjectInitializerExpression.Initializers
                            var inits = oper.GetType().InvokeMember("Initializers", BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance, null, oper, null) as IList;
                            if (null != inits && i < inits.Count) {
                                opd = inits[i] as IConversionExpression;
                            }
                            if (args[i] is AssignmentExpressionSyntax) {
                                VisitToplevelExpression(args[i], string.Empty);
                            }
                            else {
                                OutputExpressionSyntax(exp, opd);
                            }
                            if (i < ct - 1)
                                CodeBuilder.Append(",");
                        }
                        CodeBuilder.Append(")");
                    }
                    else {
                        m_ObjectInitializerStack.Push(typeSymInfo);
                        CodeBuilder.Append("(function(newobj){ ");
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
                                VisitToplevelExpression(exp, string.Empty);
                            }
                            else {
                                OutputExpressionSyntax(exp, opd);
                            }
                            CodeBuilder.Append(";");
                        }
                        CodeBuilder.Append(" })");
                        m_ObjectInitializerStack.Pop();
                    }
                }
            }
            else {
                Log(node, "Can't find operation info !");
            }
        }
        public override void VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
        {
            var ci = m_ClassInfoStack.Peek();
            var oper = m_Model.GetOperationEx(node);
            var objectCreate = oper as IObjectCreationExpression;
            if (null != objectCreate) {
                var typeSymInfo = objectCreate.Type;
                var sym = objectCreate.Constructor;

                TypeChecker.CheckType(typeSymInfo, node, GetCurMethodSemanticInfo());

                string fullTypeName = ClassInfo.GetFullName(typeSymInfo);
                var namedTypeSym = typeSymInfo as INamedTypeSymbol;

                //处理ref/out参数
                InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                ii.Init(sym, node.ArgumentList, m_Model);
                AddReferenceAndTryDeriveGenericTypeInstance(ci, sym);

                bool isCollection = IsImplementationOfSys(typeSymInfo, "ICollection");
                bool isExternal = !SymbolTable.Instance.IsCs2DslSymbol(typeSymInfo);

                string ctor = NameMangling(sym);
                string localName = string.Format("__newobject_{0}", GetSourcePosForVar(node));
                if (ii.ReturnArgs.Count > 0) {
                    CodeBuilder.Append("(function(){ ");
                    CodeBuilder.AppendFormat("local({0}); multiassign({1}", localName, localName);
                    CodeBuilder.Append(", ");
                    OutputExpressionList(ii.ReturnArgs, node);
                    CodeBuilder.Append(") = ");
                }
                if (isCollection) {
                    bool isDictionary = IsImplementationOfSys(typeSymInfo, "IDictionary");
                    bool isList = IsImplementationOfSys(typeSymInfo, "IList");
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
                if (null != node.Initializer) {
                    CodeBuilder.Append(", ");
                    VisitInitializerExpression(node.Initializer);
                }
                else {
                    if (isCollection) {
                        bool isDictionary = IsImplementationOfSys(typeSymInfo, "IDictionary");
                        bool isList = IsImplementationOfSys(typeSymInfo, "IList");
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
                if (!string.IsNullOrEmpty(ii.ExternOverloadedMethodSignature) || ii.Args.Count + ii.DefaultValueArgs.Count + ii.GenericTypeArgs.Count > 0) {
                    CodeBuilder.Append(", ");
                }
                OutputArgumentList(ii.Args, ii.DefaultValueArgs, ii.GenericTypeArgs, ii.ExternOverloadedMethodSignature, ii.PostPositionGenericTypeArgs, ii.ArrayToParams, false, node, ii.ArgConversions.ToArray());
                CodeBuilder.Append(")");
                if (ii.ReturnArgs.Count > 0) {
                    CodeBuilder.Append("; ");
                    CodeBuilder.AppendFormat("return({0}); }})()", localName);
                }
            }
            else {
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
                        string varName = string.Format("__delegation_{0}", GetSourcePosForVar(node));

                        CodeBuilder.Append("(function(){ ");

                        string paramsString = string.Join(", ", mi.ParamNames.ToArray());
                        if (msym.IsStatic) {
                            CodeBuilder.AppendFormat("builddelegation(\"{0}\", {1}, \"{2}\", {3}, {4}, {5}, {6});", paramsString, varName, delegationKey, className, manglingName, msym.ReturnsVoid ? "false" : "true", msym.IsStatic ? "true" : "false");
                        }
                        else {
                            CodeBuilder.AppendFormat("builddelegation(\"{0}\", {1}, \"{2}\", {3}, {4}, {5}, {6});", paramsString, varName, delegationKey, "this", manglingName, msym.ReturnsVoid ? "false" : "true", msym.IsStatic ? "true" : "false");
                        }

                        CodeBuilder.Append(" })()");
                    }
                    else {
                        VisitArgumentList(node.ArgumentList);
                    }
                }
                else {
                    var typeParamObjCreate = oper as ITypeParameterObjectCreationExpression;
                    if (null != typeParamObjCreate) {
                        CodeBuilder.Append("newtypeparamobject(");
                        OutputType(typeParamObjCreate.Type, node, ci, "new");
                        CodeBuilder.Append(")");
                    }
                    else {
                        Log(node, "Unknown ObjectCreationExpressionSyntax !");
                    }
                }
            }
        }
        public override void VisitAnonymousObjectCreationExpression(AnonymousObjectCreationExpressionSyntax node)
        {
            CodeBuilder.Append("anonymousobject{");
            int ct = node.Initializers.Count;
            for (int i = 0; i < ct; ++i) {
                var init = node.Initializers[i];
                if (null != init && null != init.NameEquals) {
                    CodeBuilder.Append(init.NameEquals.Name);
                    CodeBuilder.AppendFormat(" {0} ", init.NameEquals.EqualsToken.Text);
                    VisitToplevelExpression(init.Expression, string.Empty);
                    if (i < ct - 1)
                        CodeBuilder.Append(", ");
                }
                else {
                    Log(node, "Unknown AnonymousObjectCreationExpressionSyntax !");
                }
            }
            CodeBuilder.Append("}");
        }
        public override void VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
        {
            if (null == node.Initializer) {
                var oper = m_Model.GetOperationEx(node) as IArrayCreationExpression;
                ITypeSymbol etype = SymbolTable.GetElementType(oper.ElementType);
                string elementType = ClassInfo.GetFullName(etype);
                string typeKind = etype.TypeKind.ToString();
                var rankspecs = node.Type.RankSpecifiers;
                var rankspec = rankspecs[0];
                int rank = rankspec.Rank;
                if (rank >= 1) {
                    CodeBuilder.Append("(function(){");
                    int ct = rankspec.Sizes.Count;
                    for (int i = 0; i < ct; ++i) {
                        CodeBuilder.AppendFormat(" local(d{0}); d{0} = ", i);
                        var exp = rankspec.Sizes[i];
                        OutputExpressionSyntax(exp);
                        if (i == 0) {
                            CodeBuilder.AppendFormat("; local{{arr = newarray({0}, TypeKind.{1}, d0);}}", elementType, typeKind);
                        }
                        CodeBuilder.AppendFormat("; for(i{0}, 1, d{1}){{ arr{2} = ", i, i, GetArraySubscriptString(i));
                        if (i < ct - 1) {
                            CodeBuilder.AppendFormat("newarray({0}, TypeKind.{1}, ", elementType, typeKind);
                            exp = rankspec.Sizes[i + 1];
                            OutputExpressionSyntax(exp);
                            CodeBuilder.Append(");");
                        }
                        else {
                            OutputDefaultValue(etype);
                            CodeBuilder.Append(";");
                        }
                    }
                    for (int i = 0; i < ct; ++i) {
                        CodeBuilder.Append(" };");
                    }
                    CodeBuilder.Append(" return(arr); })()");
                }
                else {
                    CodeBuilder.AppendFormat("newarray({0}, TypeKind.{1})", elementType, typeKind);
                }
            }
            else {
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