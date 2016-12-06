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
    internal class SymbolTable
    {
        internal CSharpCompilation Compilation
        {
            get { return m_Compilation; }
        }
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
        internal Dictionary<string, HashSet<string>> Requires
        {
            get { return m_Requires; }
        }
        internal void Init(CSharpCompilation compilation)
        {
            m_Compilation = compilation;
            m_AssemblySymbol = compilation.Assembly;
            INamespaceSymbol nssym = m_AssemblySymbol.GlobalNamespace;
            InitRecursively(nssym);
        }
        internal void AddRequire(string refClass, string moduleName)
        {
            HashSet<string> hashset;
            if (!m_Requires.TryGetValue(refClass, out hashset)) {
                hashset = new HashSet<string>();
                m_Requires.Add(refClass, hashset);
            }
            if (!hashset.Contains(moduleName)) {
                hashset.Add(moduleName);
            }
        }
        internal string NameMangling(IMethodSymbol sym)
        {
            string ret = GetMethodName(sym);
            if (ret[0] == '.')
                ret = ret.Substring(1);
            string key = ClassInfo.CalcTypeReference(sym.ContainingType);
            ClassSymbolInfo csi;
            if (m_ClassSymbols.TryGetValue(key, out csi)) {
                bool isMangling;
                csi.SymbolOverloadFlags.TryGetValue(ret, out isMangling);
                if (isMangling) {
                    ret = CalcMethodMangling(sym, m_AssemblySymbol);
                }
            }
            return ret;
        }
        internal bool IsFieldCreateSelf(IFieldSymbol sym)
        {
            bool ret = false;
            string key = ClassInfo.CalcTypeReference(sym.ContainingType);
            ClassSymbolInfo csi;
            if (m_ClassSymbols.TryGetValue(key, out csi)) {
                ret = csi.FieldCreateSelfs.ContainsKey(sym.Name);
            }
            return ret;
        }
        internal bool IsUseExplicitTypeParam(IFieldSymbol sym)
        {
            bool ret = false;
            string key = ClassInfo.CalcTypeReference(sym.ContainingType);
            ClassSymbolInfo csi;
            if (m_ClassSymbols.TryGetValue(key, out csi)) {
                ret = csi.FieldUseExplicitTypeParams.ContainsKey(sym.Name);
            }
            return ret;
        }
        internal bool IsUseExplicitTypeParam(IMethodSymbol sym)
        {
            bool ret = false;
            string key = ClassInfo.CalcTypeReference(sym.ContainingType);
            ClassSymbolInfo csi;
            if (m_ClassSymbols.TryGetValue(key, out csi)) {
                string manglingName = CalcMethodMangling(sym, m_AssemblySymbol);
                ret = csi.MethodUseExplicitTypeParams.ContainsKey(manglingName);
            }
            return ret;
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
            string key = ClassInfo.GetFullName(typeSym);
            if (!m_ClassSymbols.ContainsKey(key)) {
                ClassSymbolInfo csi = new ClassSymbolInfo();
                m_ClassSymbols.Add(key, csi);
                csi.Init(typeSym, m_Compilation, this);
            }
            foreach (var newSym in typeSym.GetTypeMembers()) {
                InitRecursively(newSym);
            }
        }
        private SymbolTable() { }

        private CSharpCompilation m_Compilation = null;
        private IAssemblySymbol m_AssemblySymbol = null;
        private Dictionary<string, INamespaceSymbol> m_NamespaceSymbols = new Dictionary<string, INamespaceSymbol>();
        private Dictionary<string, ClassSymbolInfo> m_ClassSymbols = new Dictionary<string, ClassSymbolInfo>();
        private Dictionary<string, HashSet<string>> m_Requires = new Dictionary<string, HashSet<string>>();

        internal static SymbolTable Instance
        {
            get
            {
                return s_Instance;
            }
        }
        private static SymbolTable s_Instance = new SymbolTable();

        internal static string CalcMethodMangling(IMethodSymbol methodSym, IAssemblySymbol assemblySym)
        {
            if (null == methodSym)
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            string name = GetMethodName(methodSym);
            if (name[0] == '.')
                name = name.Substring(1);
            sb.Append(name);
            if (methodSym.ContainingAssembly == assemblySym) {
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
            }
            return sb.ToString();
        }
        internal static string GetMethodName(IMethodSymbol sym)
        {
            if (null == sym) {
                return string.Empty;
            }
            if (sym.ExplicitInterfaceImplementations.Length > 0) {
                int ix = sym.Name.LastIndexOf('.');
                return CalcNameWithFullTypeName(sym.Name.Substring(ix + 1), sym.ContainingType);
            } else {
                return sym.Name;
            }
        }
        internal static string GetPropertyName(IPropertySymbol sym)
        {
            if (null == sym) {
                return string.Empty;
            }
            if (sym.ExplicitInterfaceImplementations.Length > 0) {
                int ix = sym.Name.LastIndexOf('.');
                return CalcNameWithFullTypeName(sym.Name.Substring(ix + 1), sym.ContainingType);
            } else {
                return sym.Name;
            }
        }
        internal static string GetEventName(IEventSymbol sym)
        {
            if (null == sym) {
                return string.Empty;
            }
            if (sym.ExplicitInterfaceImplementations.Length > 0) {
                int ix = sym.Name.LastIndexOf('.');
                return CalcNameWithFullTypeName(sym.Name.Substring(ix + 1), sym.ContainingType);
            } else {
                return sym.Name;
            }
        }
        internal static string CalcNameWithFullTypeName(string name, INamedTypeSymbol typeSym)
        {
            if (null == typeSym) {
                return name;
            } else {
                string ns = ClassInfo.GetFullName(typeSym);
                if (string.IsNullOrEmpty(ns)) {
                    return name;
                } else {
                    return ns.Replace(".", "_") + "_" + name;
                }
            }
        }
        internal static string CheckLuaKeyword(string name, out bool change)
        {
            if (name.StartsWith("@")) {
                change = true;
                return "__compiler_cs_" + name.Substring(1);
            } else if (s_ExtraLuaKeywords.Contains(name)) {
                change = true;
                return "__compiler_lua_" + name;
            } else {
                change = false;                
                return name;
            }
        }
        internal static bool ForSlua
        {
            get { return s_ForSlua; }
            set { s_ForSlua = value; }
        }
        internal static bool NoAutoRequire
        {
            get { return s_NoAutoRequire; }
            set { s_NoAutoRequire = value; }
        }
        internal static bool LuaComponentByString
        {
            get { return s_LuaComponentByString; }
            set { s_LuaComponentByString = value; }
        }

        private static bool s_ForSlua = true;
        private static bool s_NoAutoRequire = false;
        private static bool s_LuaComponentByString = false;

        private static HashSet<string> s_ExtraLuaKeywords = new HashSet<string> {
            "and", "elseif", "end", "function", "local", "nil", "not", "or", "repeat", "then", "until"
        };
    }
}
