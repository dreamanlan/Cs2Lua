using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
        internal string BaseClassKey = string.Empty;
        internal bool ExistConstructor = false;
        internal bool ExistStaticConstructor = false;
        internal bool GenerateBasicCtor = false;
        internal bool GenerateBasicCctor = false;
        internal bool GenerateTypeParamFields = false;

        internal INamedTypeSymbol TypeSymbol = null;
        internal List<IFieldSymbol> FieldSymbols = new List<IFieldSymbol>();
        internal List<IMethodSymbol> MethodSymbols = new List<IMethodSymbol>();
        internal List<IPropertySymbol> PropertySymbols = new List<IPropertySymbol>();
        internal List<IEventSymbol> EventSymbols = new List<IEventSymbol>();
        internal Dictionary<string, bool> SymbolOverloadFlags = new Dictionary<string, bool>();
        internal HashSet<string> MethodNames = new HashSet<string>();
        internal Dictionary<string, INamedTypeSymbol> ExtensionClasses = new Dictionary<string, INamedTypeSymbol>();
        internal Dictionary<string, IMethodSymbol> MethodIncludeTypeOfs = new Dictionary<string, IMethodSymbol>();
        internal Dictionary<string, IFieldSymbol> FieldIncludeTypeOfs = new Dictionary<string, IFieldSymbol>();
        internal Dictionary<string, IFieldSymbol> FieldCreateSelfs = new Dictionary<string, IFieldSymbol>();
        internal List<string> GenericTypeParamNames = new List<string>();

        internal void Init(INamedTypeSymbol typeSym, CSharpCompilation compilation, SymbolTable symTable)
        {
            if (typeSym.TypeKind == TypeKind.Error) {
                Logger.Instance.ReportIllegalType(typeSym);
                return;
            }
            ClassKey = ClassInfo.GetFullName(typeSym);
            BaseClassKey = ClassInfo.GetFullName(typeSym.BaseType);
            if (BaseClassKey == "System.Object" || BaseClassKey == "System.ValueType")
                BaseClassKey = string.Empty;
            ExistConstructor = false;
            ExistStaticConstructor = false;

            INamedTypeSymbol type = typeSym;
            while (null != type) {
                if (type.IsGenericType) {
                    foreach (var param in type.TypeParameters) {
                        GenericTypeParamNames.Add(param.Name);
                    }
                }
                type = type.ContainingType;
            }
            
            bool fieldIncludeTypeOf = false;
            bool staticFieldIncludeTypeOf = false;
            TypeSymbol = typeSym;
            foreach (var sym in TypeSymbol.GetMembers()) {
                var fsym = sym as IFieldSymbol;
                if (null != fsym) {
                    FieldSymbols.Add(fsym);

                    CheckFieldIncludeTypeOf(fsym, compilation, ref fieldIncludeTypeOf, ref staticFieldIncludeTypeOf);
                    continue;
                }
            }
            foreach (var sym in TypeSymbol.GetMembers()) {
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
                    string manglingName = SymbolTable.CalcMethodMangling(msym, symTable.AssemblySymbol);
                    if (msym.IsExtensionMethod && msym.Parameters.Length > 0) {
                        var targetType = msym.Parameters[0].Type as INamedTypeSymbol;
                        if (null != targetType) {
                            string key = ClassInfo.GetFullName(targetType);
                            ClassSymbolInfo csi;
                            if (!symTable.ClassSymbols.TryGetValue(key, out csi)) {
                                csi = new ClassSymbolInfo();
                                symTable.ClassSymbols.Add(key, csi);
                                csi.Init(targetType, compilation, symTable);
                            }
                            if (!csi.ExtensionClasses.ContainsKey(ClassKey)) {
                                csi.ExtensionClasses.Add(ClassKey, typeSym);
                                csi.GenerateBasicCtor = true;
                            }
                            bool needMangling;
                            bool isOverloaded;
                            if (csi.SymbolOverloadFlags.TryGetValue(name, out isOverloaded)) {
                                if (csi.MethodNames.Contains(manglingName)) {
                                    continue;
                                }
                                csi.SymbolOverloadFlags[name] = true;
                                needMangling = true;
                            } else {
                                if (SymbolOverloadFlags.TryGetValue(name, out isOverloaded)) {
                                    csi.SymbolOverloadFlags.Add(name, true);
                                    needMangling = true;
                                } else {
                                    csi.SymbolOverloadFlags.Add(name, false);
                                    needMangling = false;
                                }
                            }
                            if (needMangling) {
                                csi.MethodNames.Add(manglingName);

                                SymbolOverloadFlags[name] = true;
                                MethodNames.Add(manglingName);
                            } else {
                                SymbolOverloadFlags.Add(name, false);
                                MethodNames.Add(name);
                            }
                        }
                    } else {
                        if (!SymbolOverloadFlags.ContainsKey(name)) {
                            SymbolOverloadFlags.Add(name, false);

                            MethodNames.Add(name);
                        } else {
                            SymbolOverloadFlags[name] = true;

                            MethodNames.Add(manglingName);
                        }
                    }

                    if (typeSym.IsGenericType) {
                        CheckMethodIncludeTypeOf(msym, symTable.AssemblySymbol, compilation, false);

                        if (fieldIncludeTypeOf && msym.MethodKind == MethodKind.Constructor) {
                            MethodIncludeTypeOfs.Add(manglingName, msym);
                        }
                        if (staticFieldIncludeTypeOf && msym.MethodKind == MethodKind.StaticConstructor) {
                            MethodIncludeTypeOfs.Add(manglingName, msym);
                        }
                    }
                    continue;
                }
                var psym = sym as IPropertySymbol;
                if (null != psym) {
                    PropertySymbols.Add(psym);

                    if (typeSym.IsGenericType) {
                        if (null != psym.GetMethod) {
                            CheckMethodIncludeTypeOf(psym.GetMethod, symTable.AssemblySymbol, compilation, true);
                        }
                        if (null != psym.SetMethod) {
                            CheckMethodIncludeTypeOf(psym.SetMethod, symTable.AssemblySymbol, compilation, true);
                        }
                    }
                    continue;
                }
                var esym = sym as IEventSymbol;
                if (null != esym) {
                    EventSymbols.Add(esym);

                    if (typeSym.IsGenericType) {
                        if (null != esym.AddMethod) {
                            CheckMethodIncludeTypeOf(esym.AddMethod, symTable.AssemblySymbol, compilation, true);
                        }
                        if (null != esym.RemoveMethod) {
                            CheckMethodIncludeTypeOf(esym.RemoveMethod, symTable.AssemblySymbol, compilation, true);
                        }
                    }
                    continue;
                }
            }
        }

        private void CheckFieldIncludeTypeOf(IFieldSymbol fsym, Compilation compilation, ref bool fieldIncludeTypeOf, ref bool staticFieldIncludeTypeOf)
        {
            bool existTypeOf = false;
            bool createSelf = false;
            foreach (var decl in fsym.DeclaringSyntaxReferences) {
                var node = decl.GetSyntax() as CSharpSyntaxNode;
                if (null != node) {
                    var model = compilation.GetSemanticModel(node.SyntaxTree, true);
                    var analysis = new FieldInitializerAnalysis(model);
                    node.Accept(analysis);
                    if (analysis.HaveTypeOf) {
                        existTypeOf = true;
                        break;
                    }
                    if (analysis.ObjectCreateType == fsym.ContainingType) {
                        createSelf = true;
                        break;
                    }
                }
            }
            if (existTypeOf) {
                if (fsym.IsStatic) {
                    staticFieldIncludeTypeOf = true;
                    GenerateBasicCctor = true;
                } else {
                    fieldIncludeTypeOf = true;
                    GenerateBasicCtor = true;
                }
                FieldIncludeTypeOfs.Add(fsym.Name, fsym);
            }
            if (createSelf) {
                if (fsym.IsStatic) {
                    GenerateBasicCctor = true;
                } else {
                    GenerateBasicCtor = true;
                }
                FieldCreateSelfs.Add(fsym.Name, fsym);
            }
        }
        private void CheckMethodIncludeTypeOf(IMethodSymbol msym, IAssemblySymbol assemblySym, Compilation compilation, bool setGenerateBasicFlagIfInclude)
        {
            bool existTypeOf = false;
            foreach (var decl in msym.DeclaringSyntaxReferences) {
                var node = decl.GetSyntax() as CSharpSyntaxNode;
                if (null != node) {
                    var model = compilation.GetSemanticModel(node.SyntaxTree, true);
                    var analysis = new MethodAnalysis(model);
                    node.Accept(analysis);
                    if (analysis.HaveTypeOf) {
                        existTypeOf = true;
                        break;
                    }
                }
            }
            if (existTypeOf) {
                string manglingName = SymbolTable.CalcMethodMangling(msym, assemblySym);
                MethodIncludeTypeOfs.Add(manglingName, msym);
                if (setGenerateBasicFlagIfInclude) {
                    if (!msym.IsStatic) {
                        GenerateBasicCtor = true;
                        GenerateTypeParamFields = true;
                    }
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
        internal Dictionary<string, HashSet<string>> Requires
        {
            get { return m_Requires; }
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
            string ret = sym.Name;
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
        internal bool ExistTypeOf(IFieldSymbol sym)
        {
            bool ret = false;
            string key = ClassInfo.CalcTypeReference(sym.ContainingType);
            ClassSymbolInfo csi;
            if (m_ClassSymbols.TryGetValue(key, out csi)) {
                ret = csi.FieldIncludeTypeOfs.ContainsKey(sym.Name);
            }
            return ret;
        }
        internal bool ExistTypeOf(IMethodSymbol sym)
        {
            bool ret = false;
            string key = ClassInfo.CalcTypeReference(sym.ContainingType);
            ClassSymbolInfo csi;
            if (m_ClassSymbols.TryGetValue(key, out csi)) {
                string manglingName = CalcMethodMangling(sym, m_AssemblySymbol);
                ret = csi.MethodIncludeTypeOfs.ContainsKey(manglingName);
            }
            return ret;
        }
        internal SymbolTable(CSharpCompilation compilation)
        {
            m_Compilation = compilation;
            Init(compilation.Assembly);
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

        private CSharpCompilation m_Compilation = null;
        private IAssemblySymbol m_AssemblySymbol = null;
        private Dictionary<string, INamespaceSymbol> m_NamespaceSymbols = new Dictionary<string, INamespaceSymbol>();
        private Dictionary<string, ClassSymbolInfo> m_ClassSymbols = new Dictionary<string, ClassSymbolInfo>();
        private Dictionary<string, HashSet<string>> m_Requires = new Dictionary<string, HashSet<string>>();

        internal static string CalcMethodMangling(IMethodSymbol methodSym, IAssemblySymbol assemblySym)
        {
            StringBuilder sb = new StringBuilder();
            string name = methodSym.Name;
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
            return WrapMethodName(sb.ToString(), methodSym, assemblySym);
        }
        internal static string CheckLuaKeyword(string name, out bool change)
        {
            if (s_ExtraLuaKeywords.Contains(name)) {
                change = true;
                return "__compiler_" + name;
            } else {
                change = false;                
                return name;
            }
        }
        internal static string WrapMethodName(string name, IMethodSymbol methodSym, IAssemblySymbol assemblySym)
        {
            if (ForSlua && methodSym.IsStatic && methodSym.ContainingAssembly != assemblySym) {
                if (name.StartsWith("op_"))
                    return name;
                else
                    return name + "_s";
            } else {
                return name;
            }
        }
        internal static bool ForSlua
        {
            get { return s_ForSlua; }
            set { s_ForSlua = value; }
        }

        private static bool s_ForSlua = true;
        private static HashSet<string> s_ExtraLuaKeywords = new HashSet<string> {
            "and", "elseif", "end", "function", "local", "nil", "not", "or", "repeat", "then", "until"
        };
    }
}
