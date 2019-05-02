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
    internal class TryCatchUsingAnalysis : CSharpSyntaxWalker
    {
        public bool ExistTryCatch
        {
            get { return m_ExistTryCatch; }
        }
        public bool ExistUsing
        {
            get { return m_ExistUsing; }
        }
        public override void VisitTryStatement(TryStatementSyntax node)
        {
            m_ExistTryCatch = true;
        }
        public override void VisitUsingStatement(UsingStatementSyntax node)
        {
            m_ExistUsing = true;
        }

        private bool m_ExistTryCatch = false;
        private bool m_ExistUsing = false;
    }
}
