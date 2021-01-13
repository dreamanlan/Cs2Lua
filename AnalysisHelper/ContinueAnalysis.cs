using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace RoslynTool.CsToDsl
{
    /// <summary>
    /// 分析当前块内的continue语句
    /// </summary>
    internal class ContinueAnalysis : CSharpSyntaxWalker
    {
        public int ContinueCount
        {
            get { return m_ContinueCount; }
        }
        public int BreakCount
        {
            get { return m_BreakCount; }
        }
        public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
        { }
        public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
        { }
        public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
        { }
        public override void VisitDoStatement(DoStatementSyntax node)
        { }
        public override void VisitWhileStatement(WhileStatementSyntax node)
        { }
        public override void VisitForStatement(ForStatementSyntax node)
        { }
        public override void VisitForEachStatement(ForEachStatementSyntax node)
        { }
        public override void VisitSwitchStatement(SwitchStatementSyntax node)
        {
            ++m_InSwitch;
            base.VisitSwitchStatement(node);
            --m_InSwitch;
        }
        public override void VisitContinueStatement(ContinueStatementSyntax node)
        {
            ++m_ContinueCount;
        }
        public override void VisitBreakStatement(BreakStatementSyntax node)
        {
            if (m_InSwitch <= 0) {
                ++m_BreakCount;
            }
        }

        private int m_ContinueCount = 0;
        private int m_BreakCount = 0;
        private int m_InSwitch = 0;
    }
}
