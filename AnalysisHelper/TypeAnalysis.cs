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
    /// 提取当前代码文件内的声明的类型
    /// </summary>
    internal class TypeAnalysis : CSharpSyntaxWalker
    {
        public List<ITypeSymbol> Symbols
        {
            get { return m_Symbols; }
        }
        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            var sym = m_SemanticModel.GetDeclaredSymbol(node);
            m_Symbols.Add(sym);
            base.VisitEnumDeclaration(node);
        }
        public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            var sym = m_SemanticModel.GetDeclaredSymbol(node);
            m_Symbols.Add(sym);
            base.VisitInterfaceDeclaration(node);
        }
        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            var sym = m_SemanticModel.GetDeclaredSymbol(node);
            m_Symbols.Add(sym);
            base.VisitStructDeclaration(node);
        }
        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            var sym = m_SemanticModel.GetDeclaredSymbol(node);
            m_Symbols.Add(sym);
            base.VisitClassDeclaration(node);
        }
        public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
        {
            var sym = m_SemanticModel.GetDeclaredSymbol(node);
            m_Symbols.Add(sym);
            base.VisitDelegateDeclaration(node);
        }

        internal TypeAnalysis(SemanticModel model)
        {
            m_SemanticModel = model;
        }

        private SemanticModel m_SemanticModel = null;
        private List<ITypeSymbol> m_Symbols = new List<ITypeSymbol>();
    }
}
