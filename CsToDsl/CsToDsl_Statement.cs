using System;
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
        #region 语句
        public override void VisitEmptyStatement(EmptyStatementSyntax node)
        { }
        public override void VisitBreakStatement(BreakStatementSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            if (m_ContinueInfoStack.Count > 0) {
                var ci = m_ContinueInfoStack.Peek();
                if (ci.IsIgnoreBreak)
                    return;
                if (ci.HaveContinue) {
                    CodeBuilder.AppendFormat("{0}{1} = true;", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }

                bool isLastNode = IsLastNodeOfFor(node);
                if (!isLastNode) {
                    CodeBuilder.AppendFormat("{0}block{{", GetIndentString());
                    CodeBuilder.AppendLine();
                }

                if (mi.TryUsingLayer > 0 && mi.TryCatchUsingOrLoopSwitchStack.Peek()) {
                    var returnAnalysis = mi.TempReturnAnalysisStack.Peek();
                    if (mi.IsAnonymousOrLambdaMethod) {
                        if (returnAnalysis.ExistReturnInLoopOrSwitch || null == returnAnalysis.RetValVar) {
                            //return(3)代表是tryusing块里的break语句
                            CodeBuilder.AppendFormat("{0}return(3);", GetIndentString());
                            CodeBuilder.AppendLine();
                        }
                        else {
                            //可以不使用函数对象实现的try块，不能使用return语句，换成变量赋值与break
                            CodeBuilder.AppendFormat("{0}{1} = 3;", GetIndentString(), returnAnalysis.RetValVar);
                            CodeBuilder.AppendLine();
                            CodeBuilder.AppendFormat("{0}break;", GetIndentString());
                            CodeBuilder.AppendLine();
                        }
                    }
                    else {
                        var outParamsStr = returnAnalysis.OutParamsStr;
                        string prestr = ", ";
                        //return(3)代表是tryusing块里的break语句
                        CodeBuilder.AppendFormat("{0}return(3", GetIndentString());
                        if (!string.IsNullOrEmpty(outParamsStr)) {
                            CodeBuilder.Append(prestr);
                            CodeBuilder.Append(outParamsStr);
                        }
                        CodeBuilder.AppendLine(");");
                    }
                }
                else {
                    CodeBuilder.AppendFormat("{0}break;", GetIndentString());
                    CodeBuilder.AppendLine();
                }

                if (!isLastNode) {
                    CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                    CodeBuilder.AppendLine();
                }
            }
        }
        public override void VisitContinueStatement(ContinueStatementSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            if (m_ContinueInfoStack.Count > 0) {
                var ci = m_ContinueInfoStack.Peek();
                if (ci.IsIgnoreBreak)
                    return;
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}{1} = false;", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }

                bool isLastNode = IsLastNodeOfFor(node);
                if (!isLastNode) {
                    CodeBuilder.AppendFormat("{0}block{{", GetIndentString());
                    CodeBuilder.AppendLine();
                }

                if (mi.TryUsingLayer > 0 && mi.TryCatchUsingOrLoopSwitchStack.Peek()) {
                    var returnAnalysis = mi.TempReturnAnalysisStack.Peek();
                    if (mi.IsAnonymousOrLambdaMethod) {
                        if (returnAnalysis.ExistReturnInLoopOrSwitch || null == returnAnalysis.RetValVar) {
                            //return(2)代表是tryusing块里的continue语句
                            CodeBuilder.AppendFormat("{0}return(2);", GetIndentString());
                            CodeBuilder.AppendLine();
                        }
                        else {
                            //可以不使用函数对象实现的try块，不能使用return语句，换成变量赋值与break
                            CodeBuilder.AppendFormat("{0}{1} = 2;", GetIndentString(), returnAnalysis.RetValVar);
                            CodeBuilder.AppendLine();
                            CodeBuilder.AppendFormat("{0}break;", GetIndentString());
                            CodeBuilder.AppendLine();
                        }
                    }
                    else {
                        var outParamsStr = returnAnalysis.OutParamsStr;
                        string prestr = ", ";
                        //return(2)代表是tryusing块里的continue语句
                        CodeBuilder.AppendFormat("{0}return(2", GetIndentString());
                        if (!string.IsNullOrEmpty(outParamsStr)) {
                            CodeBuilder.Append(prestr);
                            CodeBuilder.Append(outParamsStr);
                        }
                        CodeBuilder.AppendLine(");");
                    }
                }
                else {
                    CodeBuilder.AppendFormat("{0}break;", GetIndentString());
                    CodeBuilder.AppendLine();
                }

                if (!isLastNode) {
                    CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                    CodeBuilder.AppendLine();
                }
            }
        }
        public override void VisitReturnStatement(ReturnStatementSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            mi.ExistTopLevelReturn = IsLastNodeOfMethod(node);

            bool isLastNode = IsLastNodeOfParent(node);
            if (!isLastNode || mi.TryUsingLayer > 0) {
                CodeBuilder.AppendFormat("{0}block{{", GetIndentString());
                CodeBuilder.AppendLine();
            }

            if (null != node.Expression) {
                IConversionOperation opd = null;
                var iret = m_Model.GetOperationEx(node) as IReturnOperation;
                if (null != iret) {
                    opd = iret.ReturnedValue as IConversionOperation;
                }
                var invocation = node.Expression as InvocationExpressionSyntax;
                if (null != invocation) {
                    var ci = m_ClassInfoStack.Peek();
                    CodeBuilder.AppendFormat("{0}", GetIndentString());
                    VisitInvocation(ci, invocation, mi.ReturnVarName, ";", true);
                    if (null != opd && null != opd.OperatorMethod) {
                        IMethodSymbol msym = opd.OperatorMethod;
                        InvocationInfo ii = new InvocationInfo(GetCurMethodSemanticInfo(), node);
                        ii.Init(msym, m_Model);
                        CodeBuilder.AppendFormat("{0}{1}", GetIndentString(), mi.ReturnVarName);
                        CodeBuilder.AppendLine(" = ");
                        OutputConversionInvokePrefix(ii);
                        CodeBuilder.Append(mi.ReturnVarName);
                        CodeBuilder.AppendLine(");");
                    }
                }
                else {
                    CodeBuilder.AppendFormat("{0}{1} = ", GetIndentString(), mi.ReturnVarName);
                    OutputExpressionSyntax(node.Expression, opd);
                    CodeBuilder.AppendLine(";");
                }
            }

            if (mi.TryUsingLayer > 0) {
                var returnAnalysis = mi.TempReturnAnalysisStack.Peek();
                if (mi.IsAnonymousOrLambdaMethod) {
                    if (returnAnalysis.ExistReturnInLoopOrSwitch || null == returnAnalysis.RetValVar) {
                        //return(1)代表是tryusing块里的return语句
                        CodeBuilder.AppendFormat("{0}return(1);", GetIndentString());
                        CodeBuilder.AppendLine();
                    }
                    else {
                        //可以不使用函数对象实现的try块，不能使用return语句，换成变量赋值与break
                        CodeBuilder.AppendFormat("{0}{1} = 1;", GetIndentString(), returnAnalysis.RetValVar);
                        CodeBuilder.AppendLine();
                        CodeBuilder.AppendFormat("{0}break;", GetIndentString());
                        CodeBuilder.AppendLine();
                    }
                }
                else {
                    var outParamsStr = returnAnalysis.OutParamsStr;
                    string prestr = ", ";
                    //return(1)代表是tryusing块里的return语句
                    CodeBuilder.AppendFormat("{0}return(1", GetIndentString());
                    if (!string.IsNullOrEmpty(outParamsStr)) {
                        CodeBuilder.Append(prestr);
                        CodeBuilder.Append(outParamsStr);
                    }
                    CodeBuilder.AppendLine(");");
                }
            }
            else {
                string prestr;
                CodeBuilder.AppendFormat("{0}return({1}", GetIndentString(), mi.ReturnVarName);
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
            }

            if (!isLastNode || mi.TryUsingLayer > 0) {
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitWhileStatement(WhileStatementSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            mi.TryCatchUsingOrLoopSwitchStack.Push(false);

            ContinueInfo ci = new ContinueInfo();
            ci.Init(node.Statement);
            m_ContinueInfoStack.Push(ci);

            CodeBuilder.AppendFormat("{0}while( ", GetIndentString());
            var oper = m_Model.GetOperationEx(node) as IWhileLoopOperation;
            IConversionOperation opd = null;
            if (null != oper) {
                opd = oper.Condition as IConversionOperation;
            }
            OutputExpressionSyntax(node.Condition, opd);
            CodeBuilder.AppendLine(" ){");
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}local({1}); {1} = false;", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}do{{", GetIndentString());
                CodeBuilder.AppendLine();
            }
            ++m_Indent;
            node.Statement.Accept(this);
            --m_Indent;
            if (ci.HaveContinue) {
                CodeBuilder.AppendFormat("{0}}}while(false);", GetIndentString());
                CodeBuilder.AppendLine();
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}if({1}){{break;}};", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
            }
            CodeBuilder.AppendFormat("{0}}};", GetIndentString());
            CodeBuilder.AppendLine();

            m_ContinueInfoStack.Pop();
            mi.TryCatchUsingOrLoopSwitchStack.Pop();
        }
        public override void VisitDoStatement(DoStatementSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            mi.TryCatchUsingOrLoopSwitchStack.Push(false);

            ContinueInfo ci = new ContinueInfo();
            ci.Init(node.Statement);
            m_ContinueInfoStack.Push(ci);

            CodeBuilder.AppendFormat("{0}do{{", GetIndentString());
            CodeBuilder.AppendLine();
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}local({1}); {1} = false;", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}do{{", GetIndentString());
                CodeBuilder.AppendLine();
            }
            ++m_Indent;
            node.Statement.Accept(this);
            --m_Indent;
            if (ci.HaveContinue) {
                CodeBuilder.AppendFormat("{0}}}while(false);", GetIndentString());
                CodeBuilder.AppendLine();
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}if({1}){{break;}};", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
            }
            CodeBuilder.AppendFormat("{0}}}while(", GetIndentString());
            var oper = m_Model.GetOperationEx(node) as IWhileLoopOperation;
            IConversionOperation opd = null;
            if (null != oper) {
                opd = oper.Condition as IConversionOperation;
            }
            OutputExpressionSyntax(node.Condition, opd);
            CodeBuilder.AppendLine(");");

            m_ContinueInfoStack.Pop();
            mi.TryCatchUsingOrLoopSwitchStack.Pop();
        }
        public override void VisitForStatement(ForStatementSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            mi.TryCatchUsingOrLoopSwitchStack.Push(false);

            ContinueInfo ci = new ContinueInfo();
            ci.Init(node.Statement);
            m_ContinueInfoStack.Push(ci);

            if (null != node.Declaration)
                VisitVariableDeclaration(node.Declaration);
            if (null != node.Initializers && node.Initializers.Count > 0) {
                foreach (var exp in node.Initializers) {
                    CodeBuilder.AppendFormat("{0}", GetIndentString());
                    VisitToplevelExpression(exp, ";");
                }
            }
            CodeBuilder.AppendFormat("{0}while( ", GetIndentString());
            if (null != node.Condition) {
                var oper = m_Model.GetOperationEx(node) as IForLoopOperation;
                IConversionOperation opd = null;
                if (null != oper) {
                    opd = oper.Condition as IConversionOperation;
                }
                OutputExpressionSyntax(node.Condition, opd);
            }
            else {
                CodeBuilder.Append("true");
            }
            CodeBuilder.AppendLine(" ){");
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}local({1}); {1} = false;", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}do{{", GetIndentString());
                CodeBuilder.AppendLine();
            }
            ++m_Indent;
            node.Statement.Accept(this);
            --m_Indent;
            if (ci.HaveContinue) {
                CodeBuilder.AppendFormat("{0}}}while(false);", GetIndentString());
                CodeBuilder.AppendLine();
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}if({1}){{break;}};", GetIndentString(), ci.BreakFlagVarName);
                    CodeBuilder.AppendLine();
                }
            }
            foreach (var exp in node.Incrementors) {
                CodeBuilder.AppendFormat("{0}", GetIndentString());
                VisitToplevelExpression(exp, ";");
            }
            CodeBuilder.AppendFormat("{0}}};", GetIndentString());
            CodeBuilder.AppendLine();

            m_ContinueInfoStack.Pop();
            mi.TryCatchUsingOrLoopSwitchStack.Pop();
        }
        public override void VisitForEachStatement(ForEachStatementSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            mi.TryCatchUsingOrLoopSwitchStack.Push(false);

            ContinueInfo ci = new ContinueInfo();
            ci.Init(node.Statement);
            m_ContinueInfoStack.Push(ci);

            IConversionOperation opd = null;
            bool isList = false;
            bool isArray = false;
            bool isArrayClass = false;
            var oper = m_Model.GetOperationEx(node) as IForEachLoopOperation;
            if (null != oper) {
                opd = oper.Collection as IConversionOperation;
            }
            var expType = m_Model.GetTypeInfoEx(node.Expression).Type;
            if (null != expType) {
                isList = IsImplementationOfSys(expType, "IList");
                isArray = expType.TypeKind == TypeKind.Array;
                isArrayClass = ClassInfo.GetFullName(expType) == "System.Array";

                var srcPos = GetSourcePosForVar(node);
                if (isArray || isArrayClass) {
                    int rank = 0;
                    if (isArray) {
                        var arrType = expType as IArrayTypeSymbol;
                        rank = arrType.Rank;
                    }
                    bool isCs2Dsl = SymbolTable.Instance.IsCs2DslSymbol(expType);
                    string varIndex = string.Format("__foreach_ix_{0}", srcPos);
                    string varExp = string.Format("__foreach_exp_{0}", srcPos);
                    CodeBuilder.AppendFormat("{0}foreacharray({1}, {2}, {3}, ", GetIndentString(), varIndex, varExp, node.Identifier.Text);
                    OutputExpressionSyntax(node.Expression, opd);
                    CodeBuilder.Append(", ");
                    CodeBuilder.Append(rank);
                    CodeBuilder.Append(", ");
                    CodeBuilder.Append(isCs2Dsl ? "false" : "true");
                    CodeBuilder.AppendLine("){");
                }
                else if (isList) {
                    string varIndex = string.Format("__foreach_ix_{0}", srcPos);
                    string varExp = string.Format("__foreach_exp_{0}", srcPos);
                    var objType = expType as INamedTypeSymbol;
                    INamedTypeSymbol listType = null;
                    var fobj = objType;
                    IMethodSymbol msym = null;
                    while (null != fobj) {
                        if (HasItemGetMethodDefined(fobj, ref msym)) {
                            listType = fobj;
                            break;
                        }
                        fobj = fobj.BaseType;
                    }
                    string elemTypeName = null;
                    string elemTypeKind = null;
                    if (null != msym) {
                        elemTypeName = ClassInfo.GetFullName(msym.ReturnType);
                        elemTypeKind = "TypeKind." + msym.ReturnType.TypeKind;
                    }
                    if (string.IsNullOrEmpty(elemTypeName))
                        elemTypeName = "null";
                    if (string.IsNullOrEmpty(elemTypeKind))
                        elemTypeKind = "null";
                    bool isCs2Dsl = SymbolTable.Instance.IsCs2DslSymbol(listType);
                    string objTypeName = ClassInfo.GetFullName(objType);
                    string listTypeName = ClassInfo.GetFullName(listType);
                    CodeBuilder.AppendFormat("{0}foreachlist({1}, {2}, {3}, ", GetIndentString(), varIndex, varExp, node.Identifier.Text);
                    OutputExpressionSyntax(node.Expression, opd);
                    CodeBuilder.Append(", ");
                    CodeBuilder.Append(elemTypeName);
                    CodeBuilder.Append(", ");
                    CodeBuilder.Append(elemTypeKind);
                    CodeBuilder.Append(", ");
                    CodeBuilder.Append(objTypeName);
                    CodeBuilder.Append(", ");
                    CodeBuilder.Append(listTypeName);
                    CodeBuilder.Append(", ");
                    CodeBuilder.Append(isCs2Dsl ? "false" : "true");
                    CodeBuilder.AppendLine("){");
                }
                else {
                    MarkNeedFuncInfo();
                    var objType = expType as INamedTypeSymbol;
                    INamedTypeSymbol enumType = null;
                    var fobj = objType;
                    while (null != fobj) {
                        if (HasForeachDefined(fobj)) {
                            enumType = fobj;
                            break;
                        }
                        fobj = fobj.BaseType;
                    }
                    bool isCs2Dsl = SymbolTable.Instance.IsCs2DslSymbol(enumType);
                    string objTypeName = ClassInfo.GetFullName(objType);
                    string enumTypeName = ClassInfo.GetFullName(enumType);
                    string varIter = string.Format("__foreach_{0}", srcPos);
                    CodeBuilder.AppendFormat("{0}foreach({1}, {2}, ", GetIndentString(), varIter, node.Identifier.Text);
                    OutputExpressionSyntax(node.Expression, opd);
                    CodeBuilder.Append(", ");
                    CodeBuilder.Append(objTypeName);
                    CodeBuilder.Append(", ");
                    CodeBuilder.Append(enumTypeName);
                    CodeBuilder.Append(", ");
                    CodeBuilder.Append(isCs2Dsl ? "false" : "true");
                    CodeBuilder.AppendLine("){");
                }
                if (ci.HaveContinue) {
                    if (ci.HaveBreak) {
                        CodeBuilder.AppendFormat("{0}local({1}); {1} = false;", GetIndentString(), ci.BreakFlagVarName);
                        CodeBuilder.AppendLine();
                    }
                    CodeBuilder.AppendFormat("{0}do{{", GetIndentString());
                    CodeBuilder.AppendLine();
                }
                ++m_Indent;
                node.Statement.Accept(this);
                --m_Indent;
                if (ci.HaveContinue) {
                    CodeBuilder.AppendFormat("{0}}}while(false);", GetIndentString());
                    CodeBuilder.AppendLine();
                    if (ci.HaveBreak) {
                        CodeBuilder.AppendFormat("{0}if({1}){{break;}};", GetIndentString(), ci.BreakFlagVarName);
                        CodeBuilder.AppendLine();
                    }
                }
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
            }
            m_ContinueInfoStack.Pop();
            mi.TryCatchUsingOrLoopSwitchStack.Pop();
        }
        public override void VisitIfStatement(IfStatementSyntax node)
        {
            string postfix = GetSourcePosForVar(node);
            CodeBuilder.AppendFormat("{0}if( ", GetIndentString());
            var oper = m_Model.GetOperationEx(node) as IConditionalOperation;
            IConversionOperation opd = null;
            if (null != oper) {
                opd = oper.Condition as IConversionOperation;
            }
            OutputExpressionSyntax(node.Condition, opd);
            CodeBuilder.Append(", ");
            CodeBuilder.Append(postfix);
            CodeBuilder.AppendLine(" ){");
            ++m_Indent;
            node.Statement.Accept(this);
            --m_Indent;
            if (null != node.Else) {
                VisitElseClause(node.Else);
            }
            else {
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitElseClause(ElseClauseSyntax node)
        {
            IfStatementSyntax ifNode = node.Statement as IfStatementSyntax;
            if (null != ifNode) {
                string postfix = GetSourcePosForVar(node);
                CodeBuilder.AppendFormat("{0}}}elseif( ", GetIndentString());
                var oper = m_Model.GetOperationEx(node) as IConditionalOperation;
                IConversionOperation opd = null;
                if (null != oper) {
                    opd = oper.Condition as IConversionOperation;
                }
                OutputExpressionSyntax(ifNode.Condition, opd);
                CodeBuilder.Append(", ");
                CodeBuilder.Append(postfix);
                CodeBuilder.AppendLine(" ){");
                ++m_Indent;
                ifNode.Statement.Accept(this);
                --m_Indent;
                if (null != ifNode.Else) {
                    VisitElseClause(ifNode.Else);
                }
                else {
                    CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                    CodeBuilder.AppendLine();
                }
            }
            else {
                CodeBuilder.AppendFormat("{0}}}else{{", GetIndentString());
                CodeBuilder.AppendLine();
                ++m_Indent;
                node.Statement.Accept(this);
                --m_Indent;
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitSwitchStatement(SwitchStatementSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            mi.TryCatchUsingOrLoopSwitchStack.Push(false);

            string varName = string.Format("__switch_{0}", GetSourcePosForVar(node));
            SwitchInfo si = new SwitchInfo();
            si.SwitchVarName = varName;
            m_SwitchInfoStack.Push(si);

            CodeBuilder.AppendFormat("{0}local({1}); {1} = ", GetIndentString(), varName);
            IConversionOperation opd = null;
            var oper = m_Model.GetOperationEx(node) as ISwitchOperation;
            if (null != oper) {
                opd = oper.Value as IConversionOperation;
            }
            OutputExpressionSyntax(node.Expression, opd);
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
            bool first = true;
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
                }
                else {
                    ci.IsIgnoreBreak = true;
                }

                CodeBuilder.AppendFormat("{0}{1} ", GetIndentString(), first ? "if(" : "}elseif(");
                int lct = section.Labels.Count;
                for (int j = 0; j < lct; ++j) {
                    var label = section.Labels[j] as CaseSwitchLabelSyntax;
                    if (null != label) {
                        if (lct > 1) {
                            CodeBuilder.Append("(");
                        }
                        CodeBuilder.AppendFormat("{0} == ", varName);
                        OutputExpressionSyntax(label.Value);
                        if (lct > 1) {
                            CodeBuilder.Append(")");
                            if (j < lct - 1) {
                                CodeBuilder.Append(" || ");
                            }
                        }
                    }
                }
                CodeBuilder.AppendLine(" ){");
                if (ba.BreakCount > 1) {
                    CodeBuilder.AppendFormat("{0}repeat{{", GetIndentString());
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
                    CodeBuilder.AppendFormat("{0}}}until(0 != 0);", GetIndentString());
                    CodeBuilder.AppendLine();
                }

                m_ContinueInfoStack.Pop();
                first = false;
            }
            if (null != defaultSection) {
                ContinueInfo ci = new ContinueInfo();
                ci.Init(defaultSection);
                m_ContinueInfoStack.Push(ci);

                BreakAnalysis ba = new BreakAnalysis();
                ba.Visit(defaultSection);
                if (ba.BreakCount > 1) {
                    ci.IsIgnoreBreak = false;
                }
                else {
                    ci.IsIgnoreBreak = true;
                }
                if (ct > 1) {
                    CodeBuilder.AppendFormat("{0}}}else{{", GetIndentString());
                }
                else {
                    CodeBuilder.AppendFormat("{0}block{{", GetIndentString());
                }
                CodeBuilder.AppendLine();
                if (ba.BreakCount > 1) {
                    CodeBuilder.AppendFormat("{0}repeat{{", GetIndentString());
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
                    CodeBuilder.AppendFormat("{0}}}until(0 != 0);", GetIndentString());
                    CodeBuilder.AppendLine();
                }
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();

                m_ContinueInfoStack.Pop();
            }
            else if (ct > 0) {
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
            }

            m_SwitchInfoStack.Pop();
            mi.TryCatchUsingOrLoopSwitchStack.Pop();
        }
        public override void VisitUnsafeStatement(UnsafeStatementSyntax node)
        {
            //Log(node, "Unsupported Syntax, ignore it !");
            //忽略
            if (null != node.Block) {
                CodeBuilder.AppendFormat("{0}unsafe{{", GetIndentString());
                CodeBuilder.AppendLine();
                ++m_Indent;
                VisitBlock(node.Block);
                --m_Indent;
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitLockStatement(LockStatementSyntax node)
        {
            //Log(node, "Unsupported Syntax, ignore it !");
            //忽略
            if (null != node.Statement) {
                CodeBuilder.AppendFormat("{0}lock{{", GetIndentString());
                CodeBuilder.AppendLine();
                ++m_Indent;
                node.Statement.Accept(this);
                --m_Indent;
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
            }
        }
        public override void VisitYieldStatement(YieldStatementSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            mi.ExistYield = true;

            if (node.ReturnOrBreakKeyword.Text == "return") {
                CodeBuilder.AppendFormat("{0}wrapyield(", GetIndentString());
                if (null != node.Expression) {
                    var type = m_Model.GetTypeInfoEx(node.Expression).Type;
                    OutputExpressionSyntax(node.Expression);
                    if (null != type && (IsImplementationOfSys(type, "IEnumerable") || IsImplementationOfSys(type, "IEnumerator"))) {
                        CodeBuilder.Append(", true");
                    }
                    else {
                        CodeBuilder.Append(", false");
                    }
                    if (null != type && IsSubclassOf(type, "UnityEngine.YieldInstruction")) {
                        CodeBuilder.Append(", true");
                    }
                    else {
                        CodeBuilder.Append(", false");
                    }
                }
                else {
                    CodeBuilder.Append("null, false, false");
                }
                CodeBuilder.Append(");");
                CodeBuilder.AppendLine();
            }
            else {
                bool isLastNode = IsLastNodeOfParent(node);
                if (!isLastNode) {
                    CodeBuilder.AppendFormat("{0}block{{", GetIndentString());
                    CodeBuilder.AppendLine();
                }

                CodeBuilder.AppendFormat("{0}return(null);", GetIndentString());
                CodeBuilder.AppendLine();

                if (IsLastNodeOfMethod(node)) {
                    mi.ExistTopLevelReturn = true;
                }

                if (!isLastNode) {
                    CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                    CodeBuilder.AppendLine();
                }
            }
        }
        #endregion
    }
}