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
    internal class YieldAnalysis : CSharpSyntaxWalker
    {
        public int YieldCount
        {
            get { return m_YieldCount; }
        }
        public override void VisitYieldStatement(YieldStatementSyntax node)
        {
            ++m_YieldCount;
        }

        private int m_YieldCount = 0;
    }
}
