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
    /// 分析指定代码块内yield语句的使用情况
    /// </summary>
    internal class YieldAnalysis : CSharpSyntaxWalker
    {
        public int YieldCount
        {
            get { return m_YieldCount; }
        }
        public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
        { }
        public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
        { }
        public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
        { }
        public override void VisitYieldStatement(YieldStatementSyntax node)
        {
            ++m_YieldCount;
        }

        private int m_YieldCount = 0;
    }
}
