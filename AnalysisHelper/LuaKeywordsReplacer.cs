using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace RoslynTool.CsToLua
{
    internal class LuaKeywordsReplacer : CSharpSyntaxRewriter
    {
        public override SyntaxToken VisitToken(SyntaxToken token)
        {
            if (token.Kind() == SyntaxKind.IdentifierToken) {
                string id = token.Text;
                bool change;
                string name = SymbolTable.CheckLuaKeyword(id, out change);
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
