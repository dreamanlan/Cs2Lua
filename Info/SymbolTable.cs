using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        internal Dictionary<string, List<SyntaxNode>> GenericTypeDefines
        {
            get { return m_GenericTypeDefines; }
        }
        internal Dictionary<string, INamedTypeSymbol> GenericTypeInstances
        {
            get { return m_GenericTypeInstances; }
        }
        internal List<ITypeParameterSymbol> TypeParameters
        {
            get { return m_TypeParameters; }
        }
        internal List<ITypeSymbol> TypeArguments
        {
            get { return m_TypeArguments; }
        }
        internal void SetTypeParamsAndArgs(List<ITypeParameterSymbol> typeParams, List<ITypeSymbol> typeArgs, INamedTypeSymbol refType)
        {
            m_TypeParameters.Clear();
            m_TypeArguments.Clear();
            m_TypeParameters.AddRange(typeParams);
            m_TypeArguments.AddRange(typeArgs);
            MergeTypeParamsAndArgs(m_TypeParameters, m_TypeArguments, refType);
        }
        internal ITypeSymbol FindTypeArgument(ITypeSymbol sym)
        {
            ITypeSymbol ret = sym;
            var refType = sym as ITypeParameterSymbol;
            if (null != refType) {
                int ix = IndexOfTypeParameter(m_TypeParameters, refType);
                if (ix >= 0) {
                    ret = m_TypeArguments[ix];
                }
            }
            return ret;
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
        internal void AddGenericTypeDefine(string key, SyntaxNode node)
        {
            List<SyntaxNode> defines;
            if (!m_GenericTypeDefines.TryGetValue(key, out defines)) {
                defines = new List<SyntaxNode>();
                m_GenericTypeDefines.Add(key, defines);
            }
            defines.Add(node);
        }
        internal void AddGenericTypeInstance(string key, INamedTypeSymbol sym)
        {
            if (!m_GenericTypeInstances.ContainsKey(key)) {
                m_GenericTypeInstances.Add(key, sym);
            }
        }
        internal string NameMangling(IMethodSymbol sym)
        {
            string ret = GetMethodName(sym);
            if (ret[0] == '.')
                ret = ret.Substring(1);
            string key = ClassInfo.GetFullNameWithTypeParameters(sym.ContainingType);
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
            string key = ClassInfo.GetFullName(sym.ContainingType);
            ClassSymbolInfo csi;
            if (m_ClassSymbols.TryGetValue(key, out csi)) {
                ret = csi.FieldCreateSelfs.ContainsKey(sym.Name);
            }
            return ret;
        }
        internal bool IsUseExplicitTypeParam(IFieldSymbol sym)
        {
            bool ret = false;
            string key = ClassInfo.GetFullName(sym.ContainingType);
            ClassSymbolInfo csi;
            if (m_ClassSymbols.TryGetValue(key, out csi)) {
                ret = csi.FieldUseExplicitTypeParams.ContainsKey(sym.Name);
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

        private Dictionary<string, List<SyntaxNode>> m_GenericTypeDefines = new Dictionary<string, List<SyntaxNode>>();
        private Dictionary<string, INamedTypeSymbol> m_GenericTypeInstances = new Dictionary<string, INamedTypeSymbol>();

        private List<ITypeParameterSymbol> m_TypeParameters = new List<ITypeParameterSymbol>();
        private List<ITypeSymbol> m_TypeArguments = new List<ITypeSymbol>();
        
        internal static SymbolTable Instance
        {
            get
            {
                return s_Instance;
            }
        }
        private static SymbolTable s_Instance = new SymbolTable();
        
        internal static void MergeTypeParamsAndArgs(List<ITypeParameterSymbol> tParams, List<ITypeSymbol> tArgs, INamedTypeSymbol refType)
        {
            var typeParams = refType.TypeParameters;
            var typeArgs = refType.TypeArguments;
            for (int i = 0; i < typeParams.Length && i < typeArgs.Length; ++i) {
                var t1 = typeParams[i];
                var t2 = typeArgs[i];
                int ix = IndexOfTypeParameter(tParams, t1);
                if (t2.TypeKind != TypeKind.TypeParameter) {
                    if (ix < 0) {
                        tParams.Add(t1);
                        tArgs.Add(t2);
                    } else {
                        tArgs[ix] = t2;
                    }
                } else {
                    int ix2 = IndexOfTypeParameter(tParams, t2);
                    if (ix < 0) {
                        if (ix2 >= 0) {
                            tParams.Add(t1);
                            tArgs.Add(tArgs[ix2]);
                        }
                    } else {
                        if (ix2 >= 0) {
                            tArgs[ix] = tArgs[ix2];
                        }
                    }
                }
            }
            if (null != refType.ContainingType) {
                MergeTypeParamsAndArgs(tParams, tArgs, refType.ContainingType);
            }
        }
        internal static int IndexOfTypeParameter(List<ITypeParameterSymbol> tParams, ITypeSymbol t)
        {
            string name = ClassInfo.GetFullNameWithTypeParameters(t);
            for (int i = 0; i < tParams.Count; ++i) {
                if (name == ClassInfo.GetFullNameWithTypeParameters(tParams[i])) {
                    return i;
                }
            }
            return -1;
        }
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
                        string fn;
                        if (arrSym.ElementType.TypeKind == TypeKind.TypeParameter) {
                            fn = ClassInfo.GetFullNameWithTypeParameters(arrSym.ElementType);
                        } else {
                            fn = ClassInfo.GetFullName(arrSym.ElementType);
                        }
                        sb.Append(fn.Replace('.', '_'));
                    } else if (param.Type.TypeKind == TypeKind.TypeParameter) {
                        string fn = ClassInfo.GetFullNameWithTypeParameters(param.Type);
                        sb.Append(fn.Replace('.', '_'));
                    } else {
                        string fn = ClassInfo.GetFullName(param.Type);
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
                return ClassInfo.CalcNameWithFullTypeName(sym.Name.Substring(ix + 1), sym.ContainingType);
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
                return ClassInfo.CalcNameWithFullTypeName(sym.Name.Substring(ix + 1), sym.ContainingType);
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
                return ClassInfo.CalcNameWithFullTypeName(sym.Name.Substring(ix + 1), sym.ContainingType);
            } else {
                return sym.Name;
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
        internal static bool IsBasicValueProperty(IPropertySymbol sym)
        {
            bool ret = false;
            if (null != sym && !sym.IsStatic && null != sym.ContainingType && sym.ContainingType.IsValueType) {
                if (sym.ContainingType.TypeKind == TypeKind.Enum) {
                    ret = true;
                } else {
                    string type = ClassInfo.GetFullName(sym.ContainingType);
                    ret = IsBasicType(type);
                }
            }
            return ret;
        }
        internal static bool IsBasicValueMethod(IMethodSymbol sym)
        {
            bool ret = false;
            if (null != sym && !sym.IsStatic && null != sym.ContainingType) {
                if (sym.ContainingType.TypeKind == TypeKind.Enum) {
                    ret = true;
                } else {
                    string type = ClassInfo.GetFullName(sym.ContainingType);
                    ret = IsBasicType(type);
                }
            }
            return ret;
        }
        internal static bool IsBasicType(string type)
        {
            return s_BasicTypes.Contains(type);
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
        private static HashSet<string> s_BasicTypes = new HashSet<string> {
            "System.Boolean", "System.Byte", "System.SByte", "System.Int16", "System.UInt16", "System.Int32", "System.UInt32", "System.Int64", "System.UInt64", "System.Single", "System.Double", "System.String"
        };
    }
}
