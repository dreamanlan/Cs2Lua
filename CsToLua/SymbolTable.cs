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
        internal bool ExistConstructor = false;
        internal bool ExistStaticConstructor = false;
        internal INamedTypeSymbol TypeSymbol = null;
        internal List<IFieldSymbol> FieldSymbols = new List<IFieldSymbol>();
        internal List<IMethodSymbol> MethodSymbols = new List<IMethodSymbol>();
        internal List<IPropertySymbol> PropertySymbols = new List<IPropertySymbol>();
        internal List<IEventSymbol> EventSymbols = new List<IEventSymbol>();
        internal Dictionary<string, bool> SymbolOverloadFlags = new Dictionary<string, bool>();

        internal void Init(INamedTypeSymbol typeSym)
        {
            ClassKey = ClassInfo.GetFullName(typeSym);
            ExistConstructor = false;
            ExistStaticConstructor = false;

            TypeSymbol = typeSym;
            foreach (var sym in TypeSymbol.GetMembers()) {
                var fsym = sym as IFieldSymbol;
                if (null != fsym) {
                    FieldSymbols.Add(fsym);
                    continue;
                }                
                var msym = sym as IMethodSymbol;
                if (null != msym) {
                    if (msym.MethodKind == MethodKind.Constructor && !msym.IsImplicitlyDeclared) {
                        ExistConstructor = true;
                    } else if (msym.MethodKind == MethodKind.StaticConstructor && !msym.IsImplicitlyDeclared) {
                        ExistStaticConstructor = true;
                    }
                    MethodSymbols.Add(msym);
                    string name = msym.Name;
                    if (name[0] == '.')
                        name = name.Substring(1);
                    if (!SymbolOverloadFlags.ContainsKey(name)) {
                        SymbolOverloadFlags.Add(name, false);
                    } else {
                        SymbolOverloadFlags[name] = true;
                    }
                    continue;
                }
                var psym = sym as IPropertySymbol;
                if (null != psym) {
                    PropertySymbols.Add(psym);
                    continue;
                }
                var esym = sym as IEventSymbol;
                if (null != esym) {
                    EventSymbols.Add(esym);
                    continue;
                }
            }
        }
    }
    internal class SymbolTable
    {
        internal IAssemblySymbol AssemblySymbol
        {
            get { return m_AssemblySymbol; }
        }
        internal Dictionary<string, INamespaceSymbol> NamespaceSymbols
        {
            get { return m_NamespaceSymbols; }
        }
        internal Dictionary<string, ClassSymbolInfo> ClassSymbols
        {
            get { return m_ClassSymbols; }
        }
        internal string NameMangling(IMethodSymbol sym)
        {
            string ret = sym.Name;
            if (ret[0] == '.')
                ret = ret.Substring(1);
            string key = ClassInfo.CalcTypeReference(sym.ContainingType);
            ClassSymbolInfo csi;
            if (m_ClassSymbols.TryGetValue(key, out csi)) {
                bool isMangling;
                csi.SymbolOverloadFlags.TryGetValue(ret, out isMangling);
                if (isMangling) {
                    ret = CalcMethodMangling(sym);
                }
            }
            return ret;
        }
        internal SymbolTable(IAssemblySymbol assemblySymbol)
        {
            Init(assemblySymbol);
        }

        private void Init(IAssemblySymbol assemblySymbol)
        {
            m_AssemblySymbol = assemblySymbol;
            INamespaceSymbol nssym = m_AssemblySymbol.GlobalNamespace;
            InitRecursively(nssym);
        }
        private void InitRecursively(INamespaceSymbol nssym)
        {
            if (null != nssym) {
                string ns = ClassInfo.GetNamespaces(nssym);
                m_NamespaceSymbols.Add(ns, nssym);
                foreach (var typeSym in nssym.GetTypeMembers()) {
                    InitRecursively(typeSym);
                }
                foreach (var newSym in nssym.GetNamespaceMembers()) {
                    InitRecursively(newSym);
                }
            }
        }
        private void InitRecursively(INamedTypeSymbol typeSym)
        {
            ClassSymbolInfo csi = new ClassSymbolInfo();
            csi.Init(typeSym);
            m_ClassSymbols.Add(csi.ClassKey, csi);
            foreach (var newSym in typeSym.GetTypeMembers()) {
                InitRecursively(newSym);
            }
        }

        private IAssemblySymbol m_AssemblySymbol = null;
        private Dictionary<string, INamespaceSymbol> m_NamespaceSymbols = new Dictionary<string, INamespaceSymbol>();
        private Dictionary<string, ClassSymbolInfo> m_ClassSymbols = new Dictionary<string, ClassSymbolInfo>();

        internal static string CalcMethodMangling(IMethodSymbol methodSym)
        {
            StringBuilder sb = new StringBuilder();
            string name = methodSym.Name;
            if (name[0] == '.')
                name = name.Substring(1);
            sb.Append(name);
            foreach (var param in methodSym.Parameters) {
                sb.Append("__");
                if (param.RefKind == RefKind.Ref) {
                    sb.Append("Ref_");
                } else if (param.RefKind == RefKind.Out) {
                    sb.Append("Out_");
                }
                if (param.Type.Kind == SymbolKind.ArrayType) {
                    sb.Append("Arr_");
                    var arrSym = param.Type as IArrayTypeSymbol;
                    string fn = ClassInfo.GetFullNameWithTypeArguments(arrSym.ElementType);
                    sb.Append(fn.Replace('.', '_'));
                } else {
                    string fn = ClassInfo.GetFullNameWithTypeArguments(param.Type);
                    sb.Append(fn.Replace('.', '_'));
                }
            }
            return sb.ToString();
        }
    }
}
