using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace RoslynTool.CsToDsl
{
    /// <summary>
    /// 检查指定代码块内try与using语句的使用情况
    /// </summary>
    internal class TryUsingAnalysis : CSharpSyntaxWalker
    {
        public bool ExistTry
        {
            get { return m_ExistTry; }
        }
        public bool ExistUsing
        {
            get { return m_ExistUsing; }
        }
        public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
        { }
        public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
        { }
        public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
        { }
        public override void VisitTryStatement(TryStatementSyntax node)
        {
            m_ExistTry = true;
        }
        public override void VisitUsingStatement(UsingStatementSyntax node)
        {
            m_ExistUsing = true;
        }

        private bool m_ExistTry = false;
        private bool m_ExistUsing = false;
    }
}
