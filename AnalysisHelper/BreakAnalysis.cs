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
    /// 搜索指定代码块内是否存在break语句（排除内嵌的语句块）
    /// </summary>
    internal class BreakAnalysis : CSharpSyntaxWalker
    {
        public int BreakCount
        {
            get { return m_BreakCount; }
        }
        public override void VisitDoStatement(DoStatementSyntax node)
        { }
        public override void VisitWhileStatement(WhileStatementSyntax node)
        { }
        public override void VisitForStatement(ForStatementSyntax node)
        { }
        public override void VisitForEachStatement(ForEachStatementSyntax node)
        { }
        public override void VisitSwitchStatement(SwitchStatementSyntax node)
        { }
        public override void VisitBreakStatement(BreakStatementSyntax node)
        {
            ++m_BreakCount;
        }

        private int m_BreakCount = 0;
    }
}
