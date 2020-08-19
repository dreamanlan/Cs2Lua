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
                if (isLastNode) {
                    CodeBuilder.AppendFormat("{0}block{{", GetIndentString());
                    CodeBuilder.AppendLine();
                }

                if (SymbolTable.EnableComplexTryUsing && mi.TryUsingLayer > 0 && mi.TryCatchUsingOrLoopSwitchStack.Peek()) {
                    //return(3)代表是tryusing块里的break语句
                    CodeBuilder.AppendFormat("{0}return(3);", GetIndentString());
                    CodeBuilder.AppendLine();
                }
                else {
                    CodeBuilder.AppendFormat("{0}break;", GetIndentString());
                    CodeBuilder.AppendLine();
                }

                if (isLastNode) {
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
                if (isLastNode) {
                    CodeBuilder.AppendFormat("{0}block{{", GetIndentString());
                    CodeBuilder.AppendLine();
                }

                if (SymbolTable.EnableComplexTryUsing && mi.TryUsingLayer > 0 && mi.TryCatchUsingOrLoopSwitchStack.Peek()) {
                    //return(2)代表是tryusing块里的continue语句
                    CodeBuilder.AppendFormat("{0}return(2);", GetIndentString());
                    CodeBuilder.AppendLine();
                }
                else {
                    CodeBuilder.AppendFormat("{0}break;", GetIndentString());
                    CodeBuilder.AppendLine();
                }

                if (isLastNode) {
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

            if (SymbolTable.EnableComplexTryUsing && mi.TryUsingLayer > 0) {
                if (null != node.Expression) {
                    IConversionExpression opd = null;
                    var iret = m_Model.GetOperationEx(node) as IReturnStatement;
                    if (null != iret) {
                        opd = iret.ReturnedValue as IConversionExpression;
                    }
                    CodeBuilder.AppendFormat("{0}{1} = ", GetIndentString(), mi.ReturnVarName);
                    OutputExpressionSyntax(node.Expression, opd);
                    CodeBuilder.AppendLine(";");
                }
                //return(1)代表是tryusing块里的return语句
                CodeBuilder.AppendFormat("{0}return(1);", GetIndentString());
                CodeBuilder.AppendLine();
            }
            else {
                string prestr;
                if (mi.SemanticInfo.MethodKind == MethodKind.Constructor) {
                    CodeBuilder.AppendFormat("{0}return(this", GetIndentString());
                    prestr = ", ";
                }
                else {
                    CodeBuilder.AppendFormat("{0}return(", GetIndentString());
                    prestr = string.Empty;
                }
                if (null != node.Expression) {
                    CodeBuilder.Append(prestr);
                    IConversionExpression opd = null;
                    var iret = m_Model.GetOperationEx(node) as IReturnStatement;
                    if (null != iret) {
                        opd = iret.ReturnedValue as IConversionExpression;
                    }
                    OutputExpressionSyntax(node.Expression, opd);
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
            var oper = m_Model.GetOperationEx(node) as IWhileUntilLoopStatement;
            IConversionExpression opd = null;
            if (null != oper) {
                opd = oper.Condition as IConversionExpression;
            }
            OutputExpressionSyntax(node.Condition, opd);
            CodeBuilder.AppendLine(" ){");
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}local{{{1} = false;}};", GetIndentString(), ci.BreakFlagVarName);
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
                    CodeBuilder.AppendFormat("{0}local{{{1} = false;}};", GetIndentString(), ci.BreakFlagVarName);
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
            var oper = m_Model.GetOperationEx(node) as IWhileUntilLoopStatement;
            IConversionExpression opd = null;
            if (null != oper) {
                opd = oper.Condition as IConversionExpression;
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
                var oper = m_Model.GetOperationEx(node) as IForLoopStatement;
                IConversionExpression opd = null;
                if (null != oper) {
                    opd = oper.Condition as IConversionExpression;
                }
                OutputExpressionSyntax(node.Condition, opd);
            }
            else {
                CodeBuilder.Append("true");
            }
            CodeBuilder.AppendLine(" ){");
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}local{{{1} = false;}};", GetIndentString(), ci.BreakFlagVarName);
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

            CodeBuilder.AppendFormat("{0}foreach({1}, getiterator(", GetIndentString(), node.Identifier.Text);
            IConversionExpression opd = null;
            var oper = m_Model.GetOperationEx(node) as IForEachLoopStatement;
            if (null != oper) {
                opd = oper.Collection as IConversionExpression;
            }
            OutputExpressionSyntax(node.Expression, opd);
            CodeBuilder.AppendLine(")){");
            if (ci.HaveContinue) {
                if (ci.HaveBreak) {
                    CodeBuilder.AppendFormat("{0}local{{{1} = false;}};", GetIndentString(), ci.BreakFlagVarName);
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
        public override void VisitIfStatement(IfStatementSyntax node)
        {
            CodeBuilder.AppendFormat("{0}if( ", GetIndentString());
            var oper = m_Model.GetOperationEx(node) as IIfStatement;
            IConversionExpression opd = null;
            if (null != oper) {
                opd = oper.Condition as IConversionExpression;
            }
            OutputExpressionSyntax(node.Condition, opd);
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
                CodeBuilder.AppendFormat("{0}}}elseif( ", GetIndentString());
                var oper = m_Model.GetOperationEx(node) as IIfStatement;
                IConversionExpression opd = null;
                if (null != oper) {
                    opd = oper.Condition as IConversionExpression;
                }
                OutputExpressionSyntax(ifNode.Condition, opd);
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

            CodeBuilder.AppendFormat("{0}local{{{1} = ", GetIndentString(), varName);
            IConversionExpression opd = null;
            var oper = m_Model.GetOperationEx(node) as ISwitchStatement;
            if (null != oper) {
                opd = oper.Value as IConversionExpression;
            }
            OutputExpressionSyntax(node.Expression, opd);
            CodeBuilder.AppendLine(";};");

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
                    var oper = m_Model.GetOperationEx(node.Expression);
                    var type = oper.Type;
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