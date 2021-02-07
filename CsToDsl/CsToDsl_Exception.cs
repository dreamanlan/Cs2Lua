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
        #region 异常处理

        public override void VisitThrowStatement(ThrowStatementSyntax node)
        {
            CodeBuilder.AppendFormat("{0}dslthrow(", GetIndentString());
            if (null != node.Expression) {
                IConversionOperation opd = m_Model.GetOperationEx(node.Expression) as IConversionOperation;
                OutputExpressionSyntax(node.Expression, opd);
            }
            CodeBuilder.AppendLine(");");
        }
        public override void VisitTryStatement(TryStatementSyntax node)
        {
            if (null != node.Block) {
                ClassInfo ci = m_ClassInfoStack.Peek();
                MethodInfo mi = m_MethodInfoStack.Peek();

                string srcPos = GetSourcePosForVar(node);
                string retVar = string.Format("__try_ret_{0}", srcPos);
                string retValVar = string.Format("__try_retval_{0}", srcPos);
                string handledVar = string.Format("__catch_handled_{0}", srcPos);
                string catchRetValVar = string.Format("__catch_retval_{0}", srcPos);

                mi.TryCatchUsingOrLoopSwitchStack.Push(true);

                ReturnContinueBreakAnalysis returnAnalysis0 = new ReturnContinueBreakAnalysis();
                returnAnalysis0.RetValVar = retValVar;
                returnAnalysis0.Visit(node.Block);
                mi.TempReturnAnalysisStack.Push(returnAnalysis0);

                if (mi.IsAnonymousOrLambdaMethod) {
                    //嵌入函数里的try块不能拆分成方法
                    CodeBuilder.AppendFormat("{0}local({1}, {2}); multiassign({1}, {2}) = dsltry({3}, {1}){{", GetIndentString(), retVar, retValVar, returnAnalysis0.ExistReturnInLoopOrSwitch ? "true" : "false");
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    ++mi.TryUsingLayer;
                    VisitBlock(node.Block);
                    --mi.TryUsingLayer;
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                    CodeBuilder.AppendLine();
                }
                else {
                    //普通函数里的try块拆分成方法
                    var dataFlow = m_Model.AnalyzeDataFlow(node.Block);
                    var ctrlFlow = m_Model.AnalyzeControlFlow(node.Block);
                    List<string> inputs, outputs;
                    string paramsStr;
                    string outParamsStr = mi.CalcTryUsingFuncInfo(dataFlow, ctrlFlow, out inputs, out outputs, out paramsStr);

                    returnAnalysis0.OutParamsStr = outParamsStr;

                    string prestr = ", ";
                    string tryFunc = string.Format("__try_func_{0}", srcPos);
                    bool isStatic = mi.SemanticInfo.IsStatic;

                    CodeBuilder.AppendFormat("{0}local({1}, {2}); multiassign({1}, {2}", GetIndentString(), retVar, retValVar);
                    if (!string.IsNullOrEmpty(outParamsStr)) {
                        CodeBuilder.Append(prestr);
                        CodeBuilder.Append(outParamsStr);
                    }
                    CodeBuilder.AppendFormat(") = dsltryfunc({0}, {1}, {2}, {3}, {4}", retValVar, tryFunc, ci.Key, isStatic ? "true" : "false", dataFlow.DataFlowsOut.Length + (string.IsNullOrEmpty(mi.ReturnVarName) ? 1 : 2));
                    if (!string.IsNullOrEmpty(paramsStr)) {
                        CodeBuilder.Append(prestr);
                        CodeBuilder.Append(paramsStr);
                    }
                    CodeBuilder.AppendLine("){");
                    ++m_Indent;
                    ++mi.TryUsingLayer;
                    VisitBlock(node.Block);
                    if (outputs.Count > 0 && ctrlFlow.ReturnStatements.Length <= 0) {
                        //return(0)代表非try块里的返回语句
                        CodeBuilder.AppendFormat("{0}return(0", GetIndentString());
                        if (!string.IsNullOrEmpty(outParamsStr)) {
                            CodeBuilder.Append(prestr);
                            CodeBuilder.Append(outParamsStr);
                        }
                        CodeBuilder.AppendLine(");");
                    }
                    --mi.TryUsingLayer;
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}}options[{1}];", GetIndentString(), mi.CalcTryUsingFuncOptions(dataFlow, ctrlFlow, inputs, outputs));
                    CodeBuilder.AppendLine();
                }

                mi.TempReturnAnalysisStack.Pop();
                mi.TryCatchUsingOrLoopSwitchStack.Pop();

                if (returnAnalysis0.Exist) {
                    CodeBuilder.AppendFormat("{0}if({1}){{", GetIndentString(), retVar);
                    CodeBuilder.AppendLine();
                    ++m_Indent;
                    if (null != node.Finally) {
                        VisitFinallyClause(node.Finally);
                    }
                    OutputTryCatchUsingReturn(returnAnalysis0, mi, retValVar);
                    --m_Indent;
                    CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                    CodeBuilder.AppendLine();
                }

                if (node.Catches.Count > 0) {
                    CodeBuilder.AppendFormat("{0}local({1}, {2}); {1} = false;", GetIndentString(), handledVar, catchRetValVar);
                    CodeBuilder.AppendLine();
                    foreach (var clause in node.Catches) {
                        ReturnContinueBreakAnalysis returnAnalysis1 = new ReturnContinueBreakAnalysis();
                        returnAnalysis1.RetValVar = null;//catch块代码部分总是包装成一个函数对象
                        returnAnalysis1.Visit(clause.Block);
                        mi.TempReturnAnalysisStack.Push(returnAnalysis1);

                        CodeBuilder.AppendFormat("{0}{1} = dslcatch({2}, {3}, {4},", GetIndentString(), catchRetValVar, handledVar, retValVar, retVar);
                        CodeBuilder.AppendLine();
                        ++m_Indent;
                        ++mi.TryUsingLayer;
                        VisitCatchClause(clause, handledVar);
                        --mi.TryUsingLayer;
                        --m_Indent;
                        CodeBuilder.AppendFormat("{0});", GetIndentString());
                        CodeBuilder.AppendLine();

                        mi.TempReturnAnalysisStack.Pop();

                        if (returnAnalysis1.Exist) {
                            if (null != node.Finally) {
                                VisitFinallyClause(node.Finally);
                            }
                            OutputTryCatchUsingReturn(returnAnalysis1, mi, catchRetValVar);
                        }
                    }
                    if (node.Catches.Count > 1) {
                        if (SymbolTable.EnableTranslationCheck) {
                            Logger.Instance.Log("Translation Warning", "try have multiple catch ! location: {0}", GetSourcePosForLog(node));
                        }
                    }
                }
                if (null != node.Finally) {
                    if (returnAnalysis0.Exist) {
                        CodeBuilder.AppendFormat("{0}if(! {1}){{", GetIndentString(), retVar);
                        CodeBuilder.AppendLine();
                        ++m_Indent;
                        VisitFinallyClause(node.Finally);
                        --m_Indent;
                        CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                        CodeBuilder.AppendLine();
                    }
                    else {
                        VisitFinallyClause(node.Finally);
                    }
                }
            }
        }
        private void VisitCatchClause(CatchClauseSyntax node, string handledVar)
        {
            MethodInfo mi = m_MethodInfoStack.Peek();
            mi.TryCatchUsingOrLoopSwitchStack.Push(true);

            CodeBuilder.AppendFormat("{0}function(", GetIndentString());
            if (null != node.Declaration) {
                CodeBuilder.Append(node.Declaration.Identifier.Text);
            }
            CodeBuilder.Append("){");
            CodeBuilder.AppendLine();
            ++m_Indent;
            if (null != node.Filter) {
                CodeBuilder.Append("if(");
                IConversionOperation opd = m_Model.GetOperationEx(node.Filter.FilterExpression) as IConversionOperation;
                OutputExpressionSyntax(node.Filter.FilterExpression, opd);
                CodeBuilder.Append("){");
                CodeBuilder.AppendLine();
                ++m_Indent;
            }
            CodeBuilder.AppendFormat("{0}{1} = true;", GetIndentString(), handledVar);
            CodeBuilder.AppendLine();
            VisitBlock(node.Block);
            if (null != node.Filter) {
                --m_Indent;
                CodeBuilder.AppendFormat("{0}}};", GetIndentString());
                CodeBuilder.AppendLine();
            }
            --m_Indent;
            CodeBuilder.AppendFormat("{0}}}", GetIndentString());
            CodeBuilder.AppendLine();

            mi.TryCatchUsingOrLoopSwitchStack.Pop();
        }
        public override void VisitCatchClause(CatchClauseSyntax node)
        {
            //忽略
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
            VisitBlock(node.Block);
        }
        #endregion
    }
}