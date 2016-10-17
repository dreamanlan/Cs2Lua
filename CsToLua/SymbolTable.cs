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
    internal class ClassSymbolInfo
    {
        internal string ClassKey = string.Empty;
        internal ITypeSymbol TypeSymbol = null;
        internal List<IFieldSymbol> FieldSymbols = new List<IFieldSymbol>();
        internal List<IMethodSymbol> MethodSymbols = new List<IMethodSymbol>();
        internal List<IPropertySymbol> PropertySymbols = new List<IPropertySymbol>();
        internal List<IEventSymbol> EventSymbols = new List<IEventSymbol>();
        internal Dictionary<string, bool> SymbolFlags = new Dictionary<string, bool>();
    }
    internal class SymbolTable
    {
        internal SymbolTable(IAssemblySymbol assemblySymbol)
        {
            m_AssemblySymbol = assemblySymbol;
            Init();
        }
        
        private void Init()
        {

        }

        private IAssemblySymbol m_AssemblySymbol = null;
        private Dictionary<string, INamespaceSymbol> m_NamespaceSymbols = new Dictionary<string, INamespaceSymbol>();
        private Dictionary<string, ClassSymbolInfo> m_ClassSymbols = new Dictionary<string, ClassSymbolInfo>();
        private Dictionary<string, string> m_SymbolUniqueNames = new Dictionary<string, string>();
    }
}
