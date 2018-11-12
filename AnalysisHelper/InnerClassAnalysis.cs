using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Semantics;

namespace RoslynTool.CsToDsl
{
    internal class InnerClassAnalysis : CSharpSyntaxWalker
    {
        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            VisitTypeDeclarationSyntax(node);
            base.VisitStructDeclaration(node);
        }
        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            VisitTypeDeclarationSyntax(node);
            base.VisitClassDeclaration(node);
        }

        public InnerClassAnalysis(SemanticModel model)
        {
            m_Model = model;
        }

        private void VisitTypeDeclarationSyntax(TypeDeclarationSyntax node)
        {
            INamedTypeSymbol declSym = m_Model.GetDeclaredSymbol(node);
            SymbolTable.Instance.AddGenericTypeDefine(ClassInfo.GetFullNameWithTypeParameters(declSym), node);
        }

        private SemanticModel m_Model = null;

    }
}
