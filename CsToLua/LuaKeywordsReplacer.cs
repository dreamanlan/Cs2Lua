using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using RoslynTool.CsToLua;

namespace RoslynTool.CsToLua
{
    internal class LuaKeywordsReplacer : CSharpSyntaxRewriter
    {
        public override SyntaxToken VisitToken(SyntaxToken token)
        {
            if (token.Kind() == SyntaxKind.IdentifierToken) {
                bool change;
                string name = SymbolTable.CheckLuaKeyword(token.Text, out change);
                if (change && !token.IsKeyword()) {
                    return SyntaxFactory.Identifier(token.LeadingTrivia, name, token.TrailingTrivia);
                } else {
                    return base.VisitToken(token);
                }
            } else {
                return base.VisitToken(token);
            }
        }
    }
}
