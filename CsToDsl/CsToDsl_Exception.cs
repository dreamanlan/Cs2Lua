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
        #region 异常处理

        public override void VisitThrowStatement(ThrowStatementSyntax node)
        {
            CodeBuilder.AppendFormat("{0}dslthrow(", GetIndentString());
            if (null != node.Expression) {
                IConversionExpression opd = m_Model.GetOperation(node.Expression) as IConversionExpression;
                OutputExpressionSyntax(node.Expression, opd);
            }
            CodeBuilder.AppendLine(");");
        }
        public override void VisitTryStatement(TryStatementSyntax node)
        {
            if (null != node.Block) {
                MethodInfo mi = m_MethodInfoStack.Peek();

                string retVar = string.Format("__try_ret_{0}", GetSourcePosForVar(node));
                string retValVar = string.Format("__try_retval_{0}", GetSourcePosForVar(node));
                string handledVar = string.Format("__try_handled_{0}", GetSourcePosForVar(node));
                string catchRetValVar = string.Format("__try_catch_ret_val_{0}", GetSourcePosForVar(node));

                mi.TryCatchUsingOrLoopSwitchStack.Push(true);

                CodeBuilder.AppendFormat("{0}local({1}, {2}); multiassign({1}, {2}) = dsltry(function(){{", GetIndentString(), retVar, retValVar);
                CodeBuilder.AppendLine();
                ++m_Indent;
                ++mi.TryCatchUsingLayer;
                VisitBlock(node.Block);
                --mi.TryCatchUsingLayer;
                --m_Indent;
                CodeBuilder.AppendFormat("{0}}});", GetIndentString());
                CodeBuilder.AppendLine();

                mi.TryCatchUsingOrLoopSwitchStack.Pop();

                ReturnContinueBreakAnalysis returnAnalysis0 = new ReturnContinueBreakAnalysis();
                returnAnalysis0.Visit(node.Block);
                if (returnAnalysis0.Exist) {
                    OutputTryCatchUsingReturn(returnAnalysis0, mi, retVar, retValVar);
                }

                if (node.Catches.Count > 0) {
                    CodeBuilder.AppendFormat("{0}local({1}, {2}); {1} = false;", GetIndentString(), handledVar, catchRetValVar);
                    CodeBuilder.AppendLine();
                    foreach (var clause in node.Catches) {
                        ReturnContinueBreakAnalysis returnAnalysis1 = new ReturnContinueBreakAnalysis();
                        returnAnalysis1.Visit(clause.Block);
                        mi.TempReturnAnalysisStack.Push(returnAnalysis1);

                        CodeBuilder.AppendFormat("{0}multiassign({1}, {4}) = dslcatch({1}, {2}, {3},", GetIndentString(), handledVar, retVar, retValVar, catchRetValVar);
                        CodeBuilder.AppendLine();
                        ++m_Indent;
                        ++mi.TryCatchUsingLayer;
                        VisitCatchClause(clause);
                        --mi.TryCatchUsingLayer;
                        --m_Indent;
                        CodeBuilder.AppendFormat("{0});", GetIndentString());
                        CodeBuilder.AppendLine();

                        mi.TempReturnAnalysisStack.Pop();

                        if (returnAnalysis1.Exist) {
                            OutputTryCatchUsingReturn(returnAnalysis1, mi, retVar, catchRetValVar);
                        }
                    }
                    if (node.Catches.Count > 1) {
                        if (SymbolTable.EnableTranslationCheck) {
                            Logger.Instance.Log("Translation Warning", "try have multiple catch ! location: {0}", GetSourcePosForLog(node));
                        }
                    }
                }
            }
            if (null != node.Finally) {
                VisitFinallyClause(node.Finally);
            }
        }
        public override void VisitCatchClause(CatchClauseSyntax node)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            mi.TryCatchUsingOrLoopSwitchStack.Push(true);
            ReturnContinueBreakAnalysis returnAnalysis = mi.TempReturnAnalysisStack.Peek();

            string handledVar = string.Format("__catch_handled_{0}", GetSourcePosForVar(node));
            string bodyVar = string.Format("__catch_body_{0}", GetSourcePosForVar(node));
            CodeBuilder.AppendFormat("{0}(function({1}", GetIndentString(), handledVar);
            if (null != node.Declaration) {
                CodeBuilder.Append(", ");
                CodeBuilder.Append(node.Declaration.Identifier.Text);
            }
            CodeBuilder.Append("){");
            CodeBuilder.AppendLine();
            ++m_Indent;
            if (null != node.Filter) {
                CodeBuilder.Append("if(");
                IConversionExpression opd = m_Model.GetOperation(node.Filter.FilterExpression) as IConversionExpression;
                OutputExpressionSyntax(node.Filter.FilterExpression, opd);
                CodeBuilder.Append("){");
                CodeBuilder.AppendLine();
                ++m_Indent;
            }
            CodeBuilder.AppendFormat("{0}{1} = true;", GetIndentString(), handledVar);
            CodeBuilder.AppendLine();
            if (null != node.Filter) {
                --m_Indent;
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
            }
            if (returnAnalysis.Exist) {
                CodeBuilder.AppendFormat("{0}local({1}); {1} = function(){{", GetIndentString(), bodyVar);
                CodeBuilder.AppendLine();
                ++m_Indent;
                VisitBlock(node.Block);
                --m_Indent;
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
                CodeBuilder.AppendFormat("{0}return({1}, {2}());", GetIndentString(), handledVar, bodyVar);
                CodeBuilder.AppendLine();
            }
            else {
                VisitBlock(node.Block);
                CodeBuilder.AppendFormat("{0}return({1}, null);", GetIndentString(), handledVar);
                CodeBuilder.AppendLine();
            }
            --m_Indent;
            CodeBuilder.AppendFormat("{0}}})", GetIndentString());
            CodeBuilder.AppendLine();

            mi.TryCatchUsingOrLoopSwitchStack.Pop();
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
            CodeBuilder.AppendFormat("{0}block{{", GetIndentString());
            CodeBuilder.AppendLine();
            ++m_Indent;
            VisitBlock(node.Block);
            --m_Indent;
            CodeBuilder.AppendFormat("{0}}};", GetIndentString());
            CodeBuilder.AppendLine();
        }
        #endregion
    }
}