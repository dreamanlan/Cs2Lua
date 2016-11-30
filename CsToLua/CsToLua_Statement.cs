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
            if (null != node.Condition)
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
    }
}