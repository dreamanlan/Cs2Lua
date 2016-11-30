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
        #region 异常处理

        public override void VisitThrowStatement(ThrowStatementSyntax node)
        {
            //忽略
        }
        public override void VisitTryStatement(TryStatementSyntax node)
        {
            if (null != node.Block) {
                CodeBuilder.AppendFormat("{0}do", GetIndentString());
                CodeBuilder.AppendLine();
                ++m_Indent;
                VisitBlock(node.Block);
                --m_Indent;
                CodeBuilder.AppendFormat("{0}end;", GetIndentString());
                CodeBuilder.AppendLine();
            }
            foreach (var clause in node.Catches) {
                VisitCatchClause(clause);
            }
            if (null != node.Finally) {
                VisitFinallyClause(node.Finally);
            }
        }
        public override void VisitCatchClause(CatchClauseSyntax node)
        {
            if (null != node.Declaration) {
                VisitCatchDeclaration(node.Declaration);
            }
            if (null != node.Filter) {
                VisitCatchFilterClause(node.Filter);
            }
            //忽略
            //VisitBlock(node.Block);
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
            CodeBuilder.AppendFormat("{0}do", GetIndentString());
            CodeBuilder.AppendLine();
            ++m_Indent;
            VisitBlock(node.Block);
            --m_Indent;
            CodeBuilder.AppendFormat("{0}end;", GetIndentString());
            CodeBuilder.AppendLine();
        }
        #endregion
    }
}