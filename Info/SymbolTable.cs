using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace RoslynTool.CsToDsl
{
    /// <summary>
    /// 翻译过程中用到的符号信息，也包括翻译所用的dsl配置信息。
    /// </summary>
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
        internal ConcurrentDictionary<string, INamedTypeSymbol> ExternTypes
        {
            get { return m_ExternTypes; }
        }
        internal ConcurrentDictionary<string, INamedTypeSymbol> InternTypes
        {
            get { return m_InternTypes; }
        }
        internal ConcurrentDictionary<string, INamedTypeSymbol> IgnoredTypes
        {
            get { return m_IgnoredTypes; }
        }
        internal ConcurrentDictionary<IPropertySymbol, bool> NoImplProperties
        {
            get { return m_NoImplProperties; }
        }
        internal Dictionary<string, HashSet<string>> Requires
        {
            get { return m_Requires; }
        }
        internal SortedSet<string> ReferencedExternTypes
        {
            get { return m_ReferencedExternTypes; }
        }
        internal ConcurrentDictionary<string, ITypeSymbol> ExternEnums
        {
            get { return m_ExternEnums; }
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
        internal Dictionary<string, List<string>> Cs2DslInterfaces
        {
            get { return m_Cs2DslInterfaces; }
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
        internal void SymbolClassified()
        {
            Console.WriteLine("Symbol size, Extern:{0} Intern:{1} Ignore:{2}", m_ExternTypes.Count, m_InternTypes.Count, m_IgnoredTypes.Count);
        }
        internal string GetSymbolKind(ISymbol sym)
        {
            if (IsFieldSymbolKind(sym))
                return "Field";
            else
                return sym.Kind.ToString();
        }
        internal bool IsFieldSymbolKind(ISymbol sym)
        {
            IPropertySymbol psym = sym as IPropertySymbol;
            if (null != psym) {
                bool val;
                if (m_NoImplProperties.TryGetValue(psym, out val)) {
                    return val;
                }
                else if (IsCs2DslSymbol(psym) && psym.DeclaringSyntaxReferences.Length > 0) {
                    bool noimpl = true;
                    var syntax = psym.DeclaringSyntaxReferences[0].GetSyntax();
                    var node = syntax as PropertyDeclarationSyntax;
                    if (null != node) {
                        foreach (var accessor in node.AccessorList.Accessors) {
                            if (null != accessor.Body || null != accessor.ExpressionBody) {
                                noimpl = false;
                                break;
                            }
                        }
                    }
                    m_NoImplProperties.TryAdd(psym, noimpl);
                    if (noimpl)
                        return true;
                }
            }
            return sym.Kind == SymbolKind.Field;
        }
        internal bool IsIgnoredSymbol(ITypeSymbol sym)
        {
            return m_IgnoredTypes.ContainsKey(ClassInfo.GetFullName(sym));
        }
        internal bool IsCs2DslSymbol(ISymbol sym)
        {
            if (sym.Kind == SymbolKind.Method) {
                return IsCs2DslSymbol(sym as IMethodSymbol);
            }
            else if (sym.Kind == SymbolKind.Field) {
                return IsCs2DslSymbol(sym as IFieldSymbol);
            }
            else if (sym.Kind == SymbolKind.Property) {
                return IsCs2DslSymbol(sym as IPropertySymbol);
            }
            else if (sym.Kind == SymbolKind.Event) {
                return IsCs2DslSymbol(sym as IEventSymbol);
            }
            else {
                var arrSym = sym as IArrayTypeSymbol;
                if (null != arrSym) {
                    return IsCs2DslSymbol(arrSym.ElementType);
                }
                else {
                    var typeSym = sym as ITypeSymbol;
                    if (null != typeSym) {
                        return IsCs2DslSymbol(typeSym);
                    }
                    else {
                        return sym.ContainingAssembly == m_AssemblySymbol;
                    }
                }
            }
        }
        internal bool IsCs2DslSymbol(IMethodSymbol sym)
        {
            return sym.ContainingAssembly == m_AssemblySymbol && !m_ExternTypes.ContainsKey(ClassInfo.SpecialGetFullTypeName(sym.ContainingType, true));
        }
        internal bool IsCs2DslSymbol(IFieldSymbol sym)
        {
            return sym.ContainingAssembly == m_AssemblySymbol && !m_ExternTypes.ContainsKey(ClassInfo.SpecialGetFullTypeName(sym.ContainingType, true));
        }
        internal bool IsCs2DslSymbol(IPropertySymbol sym)
        {
            return sym.ContainingAssembly == m_AssemblySymbol && !m_ExternTypes.ContainsKey(ClassInfo.SpecialGetFullTypeName(sym.ContainingType, true));
        }
        internal bool IsCs2DslSymbol(IEventSymbol sym)
        {
            return sym.ContainingAssembly == m_AssemblySymbol && !m_ExternTypes.ContainsKey(ClassInfo.SpecialGetFullTypeName(sym.ContainingType, true));
        }
        internal bool IsCs2DslSymbol(ITypeSymbol sym)
        {
            var name = ClassInfo.SpecialGetFullTypeName(sym, true);
            if (name == "System.Nullable_T") {
                var nsym = sym as INamedTypeSymbol;
                if (null != nsym) {
                    nsym = nsym.TypeArguments[0] as INamedTypeSymbol;
                    name = ClassInfo.SpecialGetFullTypeName(sym, true);
                    return nsym.ContainingAssembly == m_AssemblySymbol && !m_ExternTypes.ContainsKey(name);
                }
            }
            return sym.ContainingAssembly == m_AssemblySymbol && !m_ExternTypes.ContainsKey(name);
        }
        internal void Init(CSharpCompilation compilation, string cfgPath)
        {
            m_Compilation = compilation;
            m_AssemblySymbol = compilation.Assembly;
            INamespaceSymbol nssym = m_AssemblySymbol.GlobalNamespace;
            BuildInheritTypeTreeRecursively(nssym);
            InitRecursively(nssym);

            Dsl.DslFile dslFile = new Dsl.DslFile();
            if (dslFile.Load(Path.Combine(cfgPath, "rewriter.dsl"), (msg) => { Console.WriteLine(msg); })) {
                foreach (var info in dslFile.DslInfos) {
                    var fid = info.GetId();
                    if (fid != "config")
                        continue;
                    var func = info as Dsl.FunctionData;
                    if (null == func)
                        continue;
                    var call = func.ThisOrLowerOrderCall;
                    var cid = call.GetParamId(0);
                    if (cid == "LegalGenericTypeList") {
                        foreach (var comp in func.Params) {
                            var cd = comp as Dsl.FunctionData;
                            if (null != cd) {
                                var mid = cd.GetId();
                                if (mid == "type") {
                                    var v1 = cd.GetParamId(0);
                                    if (!m_LegalGenericTypes.Contains(v1)) {
                                        m_LegalGenericTypes.Add(v1);
                                    }
                                }
                            }
                        }
                    } else if (cid == "LegalGenericMethodList") {
                        foreach (var comp in func.Params) {
                            var cd = comp as Dsl.FunctionData;
                            if (null != cd) {
                                var mid = cd.GetId();
                                if (mid == "method") {
                                    var v1 = cd.GetParamId(0);
                                    var v2 = cd.GetParamId(1);
                                    var v = string.Format("{0}.{1}", v1, v2);
                                    if (!m_LegalGenericMethods.Contains(v)) {
                                        m_LegalGenericMethods.Add(v);
                                    }
                                }
                            }
                        }
                    } else if (cid == "LegalParameterGenericTypeList") {
                        foreach (var comp in func.Params) {
                            var cd = comp as Dsl.FunctionData;
                            if (null != cd) {
                                var mid = cd.GetId();
                                if (mid == "type") {
                                    var v1 = cd.GetParamId(0);
                                    if (!m_LegalParameterGenericTypes.Contains(v1)) {
                                        m_LegalParameterGenericTypes.Add(v1);
                                    }
                                }
                            }
                        }
                    } else if (cid == "LegalExtensionList") {
                        foreach (var comp in func.Params) {
                            var cd = comp as Dsl.FunctionData;
                            if (null != cd) {
                                var mid = cd.GetId();
                                if (mid == "type") {
                                    var v1 = cd.GetParamId(0);
                                    if (!m_LegalExtensions.Contains(v1)) {
                                        m_LegalExtensions.Add(v1);
                                    }
                                }
                            }
                        }
                    }
                    else if (cid == "LegalConvertionList") {
                        foreach (var comp in func.Params) {
                            var cd = comp as Dsl.FunctionData;
                            if (null != cd) {
                                var mid = cd.GetId();
                                if (mid == "convertion") {
                                    var v1 = cd.GetParamId(0);
                                    var v2 = cd.GetParamId(1);
                                    HashSet<string> targets;
                                    if(!m_LegalConvertions.TryGetValue(v1, out targets)) {
                                        targets = new HashSet<string>();
                                        m_LegalConvertions.Add(v1, targets);
                                    }
                                    if (!targets.Contains(v2)) {
                                        targets.Add(v2);
                                    }
                                }
                            }
                        }
                    } else if (cid == "IllegalTypeList") {
                        foreach (var comp in func.Params) {
                            var cd = comp as Dsl.FunctionData;
                            if (null != cd) {
                                var mid = cd.GetId();
                                if (mid == "type") {
                                    var v1 = cd.GetParamId(0);
                                    if (!m_IllegalTypes.Contains(v1)) {
                                        m_IllegalTypes.Add(v1);
                                    }
                                }
                            }
                        }
                    } else if (cid == "IllegalMethodList") {
                        foreach (var comp in func.Params) {
                            var cd = comp as Dsl.FunctionData;
                            if (null != cd) {
                                var mid = cd.GetId();
                                if (mid == "method") {
                                    var v1 = cd.GetParamId(0);
                                    var v2 = cd.GetParamId(1);
                                    var v = string.Format("{0}.{1}", v1, v2);
                                    if (!m_IllegalMethods.Contains(v)) {
                                        m_IllegalMethods.Add(v);
                                    }
                                }
                            }
                        }
                    } else if (cid == "IllegalPropertyList") {
                        foreach (var comp in func.Params) {
                            var cd = comp as Dsl.FunctionData;
                            if (null != cd) {
                                var mid = cd.GetId();
                                if (mid == "property") {
                                    var v1 = cd.GetParamId(0);
                                    var v2 = cd.GetParamId(1);
                                    var v = string.Format("{0}.{1}", v1, v2);
                                    if (!m_IllegalProperties.Contains(v)) {
                                        m_IllegalProperties.Add(v);
                                    }
                                }
                            }
                        }
                    } else if (cid == "IllegalFieldList") {
                        foreach (var comp in func.Params) {
                            var cd = comp as Dsl.FunctionData;
                            if (null != cd) {
                                var mid = cd.GetId();
                                if (mid == "field") {
                                    var v1 = cd.GetParamId(0);
                                    var v2 = cd.GetParamId(1);
                                    var v = string.Format("{0}.{1}", v1, v2);
                                    if (!m_IllegalFields.Contains(v)) {
                                        m_IllegalFields.Add(v);
                                    }
                                }
                            }
                        }
                    }
                }
            }            

        }
		
        internal bool IsLegalGenericType(INamedTypeSymbol sym)
        {
            return IsLegalGenericType(sym, false);
        }
        internal bool IsLegalGenericType(INamedTypeSymbol sym, bool isAccessMember)
        {
            var name = ClassInfo.GetFullName(sym);
            bool ret = m_LegalGenericTypes.Contains(name);
            if (!ret && sym.IsGenericType) {                
                name = CalcFullNameAndTypeArguments(name, sym);
                ret = m_LegalGenericTypes.Contains(name);
            }
            return ret;
        }
        internal bool IsLegalGenericMethod(IMethodSymbol sym)
        {
            var type = ClassInfo.GetFullName(sym.ContainingType);
            var name = sym.Name;
            var fullName = string.Format("{0}.{1}", type, name);
            bool ret = m_LegalGenericMethods.Contains(fullName);
            return ret;
        }
        internal bool IsLegalParameterGenericType(INamedTypeSymbol sym)
        {
            var name = ClassInfo.GetFullName(sym);
            bool ret = m_LegalParameterGenericTypes.Contains(name);
            if (!ret && sym.IsGenericType) {
                name = CalcFullNameAndTypeArguments(name, sym);
                ret = m_LegalParameterGenericTypes.Contains(name);
            }
            return ret;
        }
        internal bool IsLegalExtension(INamedTypeSymbol sym)
        {
            var name = ClassInfo.GetFullName(sym);
            bool ret = m_LegalExtensions.Contains(name);
            return ret;
        }
        internal bool IsLegalConvertion(INamedTypeSymbol srcSym, INamedTypeSymbol targetSym)
        {
            var srcName = ClassInfo.GetFullName(srcSym);
            var targetName = ClassInfo.GetFullName(targetSym);
            bool ret = false;
            HashSet<string> targets;
            if(m_LegalConvertions.TryGetValue(srcName, out targets)) {
                ret = targets.Contains(targetName);
            }
            string newTargetName = null;
            if (!ret && null != targets && targetSym.IsGenericType) {
                newTargetName = CalcFullNameAndTypeArguments(targetName, targetSym);
                ret = targets.Contains(newTargetName);
            }
            string newSrcName = null;
            if (!ret && srcSym.IsGenericType) {
                newSrcName = CalcFullNameAndTypeArguments(srcName, srcSym);
                if (m_LegalConvertions.TryGetValue(newSrcName, out targets)) {
                    ret = targets.Contains(targetName);
                    if(!ret && targetSym.IsGenericType) {
                        if (null == newTargetName)
                            newTargetName = CalcFullNameAndTypeArguments(targetName, targetSym);
                        ret = targets.Contains(newTargetName);
                    }
                }
            }
            return ret;
        }
        internal bool IsIllegalType(INamedTypeSymbol sym)
        {
            var name = ClassInfo.GetFullName(sym);
            var ret = m_IllegalTypes.Contains(name);
            if (!ret && sym.IsGenericType) {
                var str = CalcFullNameAndTypeArguments(name, sym);
                ret = m_IllegalTypes.Contains(str);
            }
            return ret;
        }
        internal bool IsIllegalMethod(IMethodSymbol sym)
        {
            if (sym.MethodKind == MethodKind.DelegateInvoke)
                return false;
            if (sym.ContainingType.TypeKind == TypeKind.Delegate && sym.Name != "ToString")
                return true;
            var type = ClassInfo.GetFullName(sym.ContainingType);
            var name = sym.Name;
            var fullName = string.Format("{0}.{1}", type, name);
            bool ret = m_IllegalMethods.Contains(fullName);
            return ret;
        }
        internal bool IsIllegalProperty(IPropertySymbol sym)
        {
            if (sym.ContainingType.TypeKind == TypeKind.Delegate)
                return true;
            var type = ClassInfo.GetFullName(sym.ContainingType);
            var name = sym.Name;
            var fullName = string.Format("{0}.{1}", type, name);
            bool ret = m_IllegalProperties.Contains(fullName);
            return ret;
        }
        internal bool IsIllegalField(IFieldSymbol sym)
        {
            if (sym.ContainingType.TypeKind == TypeKind.Delegate)
                return true;
            var type = ClassInfo.GetFullName(sym.ContainingType);
            var name = sym.Name;
            var fullName = string.Format("{0}.{1}", type, name);
            bool ret = m_IllegalFields.Contains(fullName);
            return ret;
        }
        internal string CalcFullNameAndTypeArguments(INamedTypeSymbol sym)
        {
            var name = ClassInfo.GetFullName(sym);
            return CalcFullNameAndTypeArguments(name, sym);
        }
        
        internal void AddRequire(string refClass, string moduleName)
        {
            lock (m_Requires) {
                HashSet<string> hashset;
                if (!m_Requires.TryGetValue(refClass, out hashset)) {
                    hashset = new HashSet<string>();
                    m_Requires.Add(refClass, hashset);
                }
                if (!hashset.Contains(moduleName)) {
                    hashset.Add(moduleName);
                }
            }
        }
        internal void AddExternEnum(string enumKey, ITypeSymbol sym)
        {
            if (!m_ExternEnums.ContainsKey(enumKey)) {
                m_ExternEnums.TryAdd(enumKey, sym);
            }
        }
        internal void AddReferencedExternType(string key)
        {
            lock (m_ReferencedExternTypes) {
                if (!m_ReferencedExternTypes.Contains(key)) {
                    m_ReferencedExternTypes.Add(key);
                }
            }
        }
        internal void AddGenericTypeDefine(string key, SyntaxNode node)
        {
            lock (m_GenericTypeDefines) {
                List<SyntaxNode> defines;
                if (!m_GenericTypeDefines.TryGetValue(key, out defines)) {
                    defines = new List<SyntaxNode>();
                    m_GenericTypeDefines.Add(key, defines);
                }
                defines.Add(node);
            }
        }
        internal void AddGenericTypeInstance(string key, INamedTypeSymbol sym)
        {
            lock (m_GenericTypeInstances) {
                bool ignore = ClassInfo.HasAttribute(sym, "Cs2Dsl.IgnoreAttribute");
                if (!ignore && !m_GenericTypeInstances.ContainsKey(key)) {
                    m_GenericTypeInstances.Add(key, sym);
                }
            }
        }
        internal string NameMangling(IMethodSymbol sym)
        {
            string ret = GetMethodName(sym);
            if (!string.IsNullOrEmpty(ret) && ret[0] == '.')
                ret = ret.Substring(1);
            string key = ClassInfo.GetFullNameWithTypeParameters(sym.ContainingType);
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

        internal void CalcMemberCount(string key, Dictionary<string, int> memberCounts)
        {
            TypeTreeNode typeTreeNode;
            if (m_TypeTreeNodes.TryGetValue(key, out typeTreeNode)) {
                var baseTypeNode = typeTreeNode.BaseTypeNode;
                while (null != baseTypeNode) {
                    var members = baseTypeNode.Type.GetMembers();
                    foreach (var sym in members) {
                        var msym = sym as IMethodSymbol;
                        if (null != msym) {
                            string name = msym.Name;
                            if (name[0] == '.')
                                name = name.Substring(1);
                            if (memberCounts.ContainsKey(name)) {
                                if (!msym.IsOverride) {
                                    ++memberCounts[name];
                                }
                            }
                            else {
                                memberCounts.Add(name, 1);
                            }
                        }
                    }
                    baseTypeNode = baseTypeNode.BaseTypeNode;
                }
                CalcMemberCountRecursively(typeTreeNode, memberCounts);
            }
        }
        private void CalcMemberCountRecursively(TypeTreeNode typeTreeNode, Dictionary<string, int> memberCounts)
        {
            var members = typeTreeNode.Type.GetMembers();
            foreach (var sym in members) {
                var msym = sym as IMethodSymbol;
                if (null != msym) {
                    string name = msym.Name;
                    if (name[0] == '.')
                        name = name.Substring(1);
                    if (memberCounts.ContainsKey(name)) {
                        if (!msym.IsOverride) {
                            ++memberCounts[name];
                        }
                    }
                    else {
                        memberCounts.Add(name, 1);
                    }
                }
            }
            foreach (var cnode in typeTreeNode.ChildTypeNodes) {
                CalcMemberCountRecursively(cnode, memberCounts);
            }
        }
        private string CalcFullNameAndTypeArguments(string name, INamedTypeSymbol sym)
        {
            if (sym.IsGenericType) {
                StringBuilder sb = new StringBuilder();
                sb.Append(name);
                sb.Append('|');
                string prestr = string.Empty;
                foreach (var ta in sym.TypeArguments) {
                    sb.Append(prestr);
                    if (ta.TypeKind == TypeKind.Delegate) {
                        sb.AppendFormat("\"{0}\"", ClassInfo.GetFullName(ta));
                    }
                    else if (ta.TypeKind == TypeKind.TypeParameter) {
                        sb.Append(ta.Name);
                    }
                    else {
                        sb.Append(ClassInfo.GetFullName(ta));
                    }
                    prestr = ", ";
                }
                return sb.ToString();
            }
            else {
                return name;
            }
        }
        private void BuildInheritTypeTreeRecursively(INamespaceSymbol nssym)
        {
            if (null != nssym) {
                foreach (var typeSym in nssym.GetTypeMembers()) {
                    BuildInheritTypeTreeRecursively(typeSym);
                }
                foreach (var newSym in nssym.GetNamespaceMembers()) {
                    BuildInheritTypeTreeRecursively(newSym);
                }
            }
        }
        private void BuildInheritTypeTreeRecursively(INamedTypeSymbol typeSym)
        {
            string key = ClassInfo.GetFullName(typeSym);
            TypeTreeNode typeTreeNode;
            if (!m_TypeTreeNodes.TryGetValue(key, out typeTreeNode)) {
                typeTreeNode = new TypeTreeNode();
                typeTreeNode.Type = typeSym;
                m_TypeTreeNodes.Add(key, typeTreeNode);
            }
            var baseType = typeSym.BaseType;
            if (null != baseType) {
                string baseClassKey = ClassInfo.GetFullName(baseType);
                if (baseClassKey == "System.Object" || baseClassKey == "System.ValueType") {
                }
                else {
                    TypeTreeNode baseTypeTreeNode;
                    if (!m_TypeTreeNodes.TryGetValue(baseClassKey, out baseTypeTreeNode)) {
                        baseTypeTreeNode = new TypeTreeNode();
                        baseTypeTreeNode.Type = baseType;
                        m_TypeTreeNodes.Add(baseClassKey, baseTypeTreeNode);
                    }
                    typeTreeNode.BaseTypeNode = baseTypeTreeNode;
                    baseTypeTreeNode.ChildTypeNodes.Add(typeTreeNode);
                }
            }
            foreach (var newSym in typeSym.GetTypeMembers()) {
                BuildInheritTypeTreeRecursively(newSym);
            }
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

        //这部分在初始构建，不会多线程修改
        private CSharpCompilation m_Compilation = null;
        private IAssemblySymbol m_AssemblySymbol = null;
        private Dictionary<string, INamespaceSymbol> m_NamespaceSymbols = new Dictionary<string, INamespaceSymbol>();
        private Dictionary<string, ClassSymbolInfo> m_ClassSymbols = new Dictionary<string, ClassSymbolInfo>();
        
        //多线程访问部分，注意加锁
        private ConcurrentDictionary<string, INamedTypeSymbol> m_ExternTypes = new ConcurrentDictionary<string, INamedTypeSymbol>();
        private ConcurrentDictionary<string, INamedTypeSymbol> m_InternTypes = new ConcurrentDictionary<string, INamedTypeSymbol>();
        private ConcurrentDictionary<string, INamedTypeSymbol> m_IgnoredTypes = new ConcurrentDictionary<string, INamedTypeSymbol>();
        private ConcurrentDictionary<IPropertySymbol, bool> m_NoImplProperties = new ConcurrentDictionary<IPropertySymbol, bool>();
        private Dictionary<string, HashSet<string>> m_Requires = new Dictionary<string, HashSet<string>>();
        private SortedSet<string> m_ReferencedExternTypes = new SortedSet<string>();
        private ConcurrentDictionary<string, ITypeSymbol> m_ExternEnums = new ConcurrentDictionary<string, ITypeSymbol>();
        private Dictionary<string, List<SyntaxNode>> m_GenericTypeDefines = new Dictionary<string, List<SyntaxNode>>();
        private Dictionary<string, INamedTypeSymbol> m_GenericTypeInstances = new Dictionary<string, INamedTypeSymbol>();
        private Dictionary<string, List<string>> m_Cs2DslInterfaces = new Dictionary<string, List<string>>();

        private List<ITypeParameterSymbol> m_TypeParameters = new List<ITypeParameterSymbol>();
        private List<ITypeSymbol> m_TypeArguments = new List<ITypeSymbol>();

        //初始化时构建，不会多线程修改
        private class TypeTreeNode
        {
            internal INamedTypeSymbol Type;
            internal TypeTreeNode BaseTypeNode;
            internal List<TypeTreeNode> ChildTypeNodes = new List<TypeTreeNode>();
        }
        private Dictionary<string, TypeTreeNode> m_TypeTreeNodes = new Dictionary<string, TypeTreeNode>();
		
        //配置文件数据，初始化后不会再修改
		private HashSet<string> m_LegalGenericTypes = new HashSet<string>();
        private HashSet<string> m_LegalGenericMethods = new HashSet<string>();
        private HashSet<string> m_LegalParameterGenericTypes = new HashSet<string>();
        private HashSet<string> m_LegalExtensions = new HashSet<string>();
        private Dictionary<string, HashSet<string>> m_LegalConvertions = new Dictionary<string, HashSet<string>>();

        private HashSet<string> m_IllegalTypes = new HashSet<string>();
        private HashSet<string> m_IllegalMethods = new HashSet<string>();
        private HashSet<string> m_IllegalProperties = new HashSet<string>();
        private HashSet<string> m_IllegalFields = new HashSet<string>();

        internal static SymbolTable Instance
        {
            get {
                return s_Instance;
            }
        }
        private static SymbolTable s_Instance = new SymbolTable();

        internal static bool TryRemoveNullable(ref INamedTypeSymbol sym)
        {
            bool ret = false;
            if (null != sym) {
                var name = ClassInfo.GetFullName(sym);
                if (name == "System.Nullable_T") {
                    var nsym = sym.TypeArguments[0] as INamedTypeSymbol;
                    if (null != nsym) {
                        sym = nsym;
                        ret = true;
                    }
                }
            }
            return ret;
        }
        //外部导出的api只能使用具体类型，所以调用时泛型参数按提供的参数的类型来生成用于确定调哪个重载版本的签名
        internal static string CalcOverloadedMethodSignature(IMethodSymbol methodSym, IMethodSymbol nonGenericMethodSym)
        {
            if (null == methodSym)
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            var typeSym = methodSym.ContainingType;
            var typeName = ClassInfo.GetFullName(typeSym);
            sb.Append(typeName);
            sb.Append(":");
            string name = methodSym.Name;
            if (!string.IsNullOrEmpty(name) && name[0] == '.')
                name = name.Substring(1);
            sb.Append(name);
            IMethodSymbol msym;
            if (null != nonGenericMethodSym) {
                msym = nonGenericMethodSym;
            }
            else {
                msym = methodSym;
            }
            foreach (var param in msym.Parameters) {
                sb.Append("__");
                CalcMethodParameter(sb, param);
            }
            return sb.ToString();
        }
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
                    }
                    else {
                        tArgs[ix] = t2;
                    }
                }
                else {
                    int ix2 = IndexOfTypeParameter(tParams, t2);
                    if (ix < 0) {
                        if (ix2 >= 0) {
                            tParams.Add(t1);
                            tArgs.Add(tArgs[ix2]);
                        }
                    }
                    else {
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
            string name = ClassInfo.SpecialGetFullTypeNameWithTypeParameters(t);
            for (int i = 0; i < tParams.Count; ++i) {
                if (name == ClassInfo.SpecialGetFullTypeNameWithTypeParameters(tParams[i])) {
                    return i;
                }
            }
            return -1;
        }
        internal static string CalcMethodMangling(IMethodSymbol methodSym)
        {
            IAssemblySymbol assemblySym = SymbolTable.Instance.AssemblySymbol;
            if (null == methodSym)
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            string name = GetMethodName(methodSym);
            if (!string.IsNullOrEmpty(name) && name[0] == '.')
                name = name.Substring(1);
            sb.Append(name);
            if (SymbolTable.Instance.IsCs2DslSymbol(methodSym)) {
                foreach(var tparam in methodSym.TypeParameters) {
                    sb.Append("_");
                    sb.Append(tparam.Name);
                }
                foreach (var param in methodSym.Parameters) {
                    sb.Append("__");
                    if (param.RefKind == RefKind.Ref) {
                        sb.Append("Ref_");
                    }
                    else if (param.RefKind == RefKind.Out) {
                        sb.Append("Out_");
                    }
                    var oriparam = param.OriginalDefinition;
                    if (oriparam.Type.Kind == SymbolKind.ArrayType) {
                        sb.Append("Arr_");
                        var arrSym = oriparam.Type as IArrayTypeSymbol;
                        string fn;
                        if (arrSym.ElementType.TypeKind == TypeKind.TypeParameter) {
                            //fn = ClassInfo.GetFullNameWithTypeParameters(arrSym.ElementType);
                            fn = arrSym.ElementType.Name;
                        }
                        else {
                            fn = ClassInfo.GetFullName(arrSym.ElementType);
                        }
                        sb.Append(fn.Replace('.', '_'));
                    }
                    else if (oriparam.Type.TypeKind == TypeKind.TypeParameter) {
                        //string fn = ClassInfo.GetFullNameWithTypeParameters(oriparam.Type);
                        string fn = oriparam.Type.Name;
                        sb.Append(fn.Replace('.', '_'));
                    }
                    else {
                        //这里使用泛型形参名作为函数签名的一部分，主要是为适应泛型类实例化后仍能保持函数签名一致
                        //因此导致的缺陷是不能支持依靠泛型类型的实参类型来区分的重载函数（这时候就在c#里给函数换个名字吧）
                        string fn = ClassInfo.GetFullName(oriparam.Type);
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
                return sym.Name.Replace('.', '_');
            }
            else {
                return sym.Name;
            }
        }
        internal static string GetPropertyName(IPropertySymbol sym)
        {
            if (null == sym) {
                return string.Empty;
            }
            if (sym.ExplicitInterfaceImplementations.Length > 0) {
                return sym.Name.Replace('.', '_');
            }
            else {
                return sym.Name;
            }
        }
        internal static string GetEventName(IEventSymbol sym)
        {
            if (null == sym) {
                return string.Empty;
            }
            if (sym.ExplicitInterfaceImplementations.Length > 0) {
                return sym.Name.Replace('.', '_');
            }
            else {
                return sym.Name;
            }
        }
        internal static string CheckDslKeyword(string name, out bool change)
        {
            if (name.StartsWith("@")) {
                change = true;
                return "__cs_" + name.Substring(1);
            }
            else if (s_ExtraDslKeywords.Contains(name)) {
                change = true;
                return "__dsl_" + name;
            }
            else {
                change = false;
                return name;
            }
        }
        internal static bool IsBasicValueProperty(IPropertySymbol sym)
        {
            bool ret = false;
            if (null != sym && !sym.IsStatic && null != sym.ContainingType) {
                if (sym.ContainingType.TypeKind == TypeKind.Enum || ClassInfo.GetFullName(sym.ContainingType) == "System.Enum") {
                    ret = true;
                }
                else {
                    string type = ClassInfo.GetFullName(sym.ContainingType);
                    ret = IsBasicType(type, true);
                }
            }
            return ret;
        }
        internal static bool IsBasicValueMethod(IMethodSymbol sym)
        {
            bool ret = false;
            if (null != sym && !sym.IsStatic && null != sym.ContainingType) {
                if (sym.ContainingType.TypeKind == TypeKind.Enum || ClassInfo.GetFullName(sym.ContainingType) == "System.Enum") {
                    ret = true;
                }
                else {
                    string type = ClassInfo.GetFullName(sym.ContainingType);
                    ret = IsBasicType(type, true);
                }
            }
            return ret;
        }
        internal static bool IsBasicType(ITypeSymbol type)
        {
            return IsBasicType(type, true);
        }
        internal static bool IsBasicType(ITypeSymbol type, bool includeString)
        {
            bool ret = false;
            if (type.TypeKind == TypeKind.Enum || ClassInfo.GetFullName(type) == "System.Enum") {
                ret = true;
            }
            else {
                string typeName = ClassInfo.GetFullName(type);
                ret = IsBasicType(typeName, includeString);
            }
            return ret;
        }
        internal static bool IsBasicType(string type, bool includeString)
        {
            if (includeString && type == "System.String")
                return true;
            return s_BasicTypes.Contains(type);
        }
        internal static bool IsIntegerType(ITypeSymbol type)
        {
            bool ret = false;
            if (type.TypeKind == TypeKind.Enum || ClassInfo.GetFullName(type) == "System.Enum") {
                ret = true;
            }
            else {
                string typeName = ClassInfo.GetFullName(type);
                ret = IsIntegerType(typeName);
            }
            return ret;
        }
        internal static bool IsIntegerType(string type)
        {
            return s_IntegerTypes.Contains(type);
        }
        internal static ITypeSymbol GetElementType(ITypeSymbol typeSym)
        {
            while (typeSym.TypeKind == TypeKind.Array) {
                var arrType = typeSym as IArrayTypeSymbol;
                if (null != arrType) {
                    typeSym = arrType.ElementType;
                }
                else {
                    break;
                }
            }
            return typeSym;
        }
        internal static bool NoAutoRequire
        {
            get { return s_NoAutoRequire; }
            set { s_NoAutoRequire = value; }
        }
        internal static bool DslComponentByString
        {
            get { return s_DslComponentByString; }
            set { s_DslComponentByString = value; }
        }
        internal static bool UseArrayGetSet
        {
            get { return s_UseArrayGetSet; }
            set { s_UseArrayGetSet = value; }
        }
        internal static bool ArrayLowerBoundIsOne
        {
            get { return s_ArrayLowerBoundIsOne; }
            set { s_ArrayLowerBoundIsOne = value; }
        }
        internal static bool EnableTranslationCheck
        {
            get { return s_EnableTranslationCheck; }
            set { s_EnableTranslationCheck = value; }
        }
        internal static string SystemDllPath
        {
            get { return s_SystemDllPath; }
            set { s_SystemDllPath = value; }
        }
        internal static bool EnableComplexTryUsing
        {
            get { return s_EnableComplexTryUsing; }
        }

        private static void CalcMethodParameter(StringBuilder sb, IParameterSymbol param)
        {
            if (param.RefKind == RefKind.Ref) {
                sb.Append("Ref_");
            }
            else if (param.RefKind == RefKind.Out) {
                sb.Append("Out_");
            }
            var oriparam = param.OriginalDefinition;
            if (oriparam.Type.Kind == SymbolKind.ArrayType) {
                sb.Append("Arr_");
                var oriArrSym = oriparam.Type as IArrayTypeSymbol;
                var arrSym = param.Type as IArrayTypeSymbol;
                CalcMethodParameterType(sb, oriArrSym.ElementType, arrSym.ElementType);
            }
            else {
                CalcMethodParameterType(sb, oriparam.Type, param.Type);
            }
        }
        private static void CalcMethodParameterType(StringBuilder sb, ITypeSymbol orisym, ITypeSymbol sym)
        {
            if (orisym.Kind == SymbolKind.TypeParameter) {
                var tp = orisym as ITypeParameterSymbol;
                if (tp.ConstraintTypes.Length > 0) {
                    sb.Append(tp.ConstraintTypes[0].Name);
                }
                else {
                    sb.Append("Object");
                }
            }
            else {
                var namedType = orisym as INamedTypeSymbol;
                if (null != namedType && namedType.IsGenericType) {
                    CalcMethodParameterTypeName(sb, sym);
                }
                else {
                    CalcMethodParameterTypeName(sb, orisym);
                }
            }
        }
        private static void CalcMethodParameterTypeName(StringBuilder sb, ITypeSymbol sym)
        {
            INamedTypeSymbol type = sym as INamedTypeSymbol;
            if (null == type) {
                sb.Append(sym.Name);
                return;
            }
            List<string> list = new List<string>();
            if (type.TypeArguments.Length > 0) {
                sb.AppendFormat("{0}`{1}", type.Name, type.TypeArguments.Length);
            }
            else {
                sb.Append(type.Name);
            }
            foreach (var arg in type.TypeArguments) {
                sb.Append('_');
                CalcMethodParameterTypeName(sb, arg);
            }
        }

        private static bool s_NoAutoRequire = false;
        private static bool s_DslComponentByString = false;
        private static bool s_UseArrayGetSet = false;
        private static bool s_ArrayLowerBoundIsOne = true;
        private static bool s_EnableTranslationCheck = false;
        private static string s_SystemDllPath = string.Empty;
        private static bool s_EnableComplexTryUsing = false;

        private static HashSet<string> s_ExtraDslKeywords = new HashSet<string> {
            "and", "elseif", "end", "function", "local", "nil", "not", "or", "repeat", "then", "until"
        };
        private static HashSet<string> s_BasicTypes = new HashSet<string> {
            "System.Boolean", "System.Byte", "System.SByte", "System.Char", "System.Int16", "System.UInt16", "System.Int32", "System.UInt32", "System.Int64", "System.UInt64", "System.Single", "System.Decimal", "System.Double"
        };
        private static HashSet<string> s_IntegerTypes = new HashSet<string> {
            "System.Byte", "System.SByte", "System.Int16", "System.UInt16", "System.Int32", "System.UInt32", "System.Int64", "System.UInt64"
        };
    }
    internal static class SemanticExtension
    {
        internal static SymbolInfo GetSymbolInfoEx(this SemanticModel model, SyntaxNode node)
        {
            SymbolInfo info;
            if(!s_SymbolInfoCache.TryGetValue(node, out info)) {
                info = model.GetSymbolInfo(node);
                s_SymbolInfoCache.TryAdd(node, info);
            }
            return info;
        }
        internal static IOperation GetOperationEx(this SemanticModel model, SyntaxNode node)
        {
            IOperation info = null;
            if (!s_OperationCache.TryGetValue(node, out info)) {
                info = model.GetOperation(node);
                s_OperationCache.TryAdd(node, info);
            }
            return info;
        }

        private static ConcurrentDictionary<SyntaxNode, SymbolInfo> s_SymbolInfoCache = new ConcurrentDictionary<SyntaxNode, SymbolInfo>();
        private static ConcurrentDictionary<SyntaxNode, IOperation> s_OperationCache = new ConcurrentDictionary<SyntaxNode, IOperation>();
    }
}
