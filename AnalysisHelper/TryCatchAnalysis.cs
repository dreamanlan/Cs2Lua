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
    internal class TryCatchAnalysis : CSharpSyntaxWalker
    {
        public bool Exist
        {
            get { return m_Exist; }
        }
        public override void VisitTryStatement(TryStatementSyntax node)
        {
            m_Exist = true;
        }

        private bool m_Exist = false;
    }
}
