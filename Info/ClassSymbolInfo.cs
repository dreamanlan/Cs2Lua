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
    /// 类的C#语义信息
    /// </summary>
    internal class ClassSymbolInfo
    {
        internal string ClassKey = string.Empty;
        internal string BaseClassKey = string.Empty;
        internal bool ExistAttributes = false;
        internal bool ExistConstructor = false;
        internal bool ExistStaticConstructor = false;

        internal INamedTypeSymbol TypeSymbol = null;
        internal List<IFieldSymbol> FieldSymbols = new List<IFieldSymbol>();
        internal List<IMethodSymbol> MethodSymbols = new List<IMethodSymbol>();
        internal List<IPropertySymbol> PropertySymbols = new List<IPropertySymbol>();
        internal List<IEventSymbol> EventSymbols = new List<IEventSymbol>();
        internal List<INamedTypeSymbol> InterfaceSymbols = new List<INamedTypeSymbol>();
        internal Dictionary<string, bool> SymbolOverloadFlags = new Dictionary<string, bool>();
        internal Dictionary<string, IFieldSymbol> FieldUseExplicitTypeParams = new Dictionary<string, IFieldSymbol>();
        internal Dictionary<string, IFieldSymbol> FieldCreateSelfs = new Dictionary<string, IFieldSymbol>();

        internal bool IsInterface = false;
        internal Dictionary<IMethodSymbol, IMethodSymbol> ExplicitInterfaceImplementationMethods = new Dictionary<IMethodSymbol, IMethodSymbol>();
        internal Dictionary<IPropertySymbol, IPropertySymbol> ExplicitInterfaceImplementationProperties = new Dictionary<IPropertySymbol, IPropertySymbol>();
        internal Dictionary<IEventSymbol, IEventSymbol> ExplicitInterfaceImplementationEvents = new Dictionary<IEventSymbol, IEventSymbol>();

        internal void Init(INamedTypeSymbol typeSym, CSharpCompilation compilation, SymbolTable symTable)
        {
            if (typeSym.TypeKind == TypeKind.Error) {
                Logger.Instance.ReportIllegalType(typeSym);
                return;
            }

            IsInterface = typeSym.TypeKind == TypeKind.Interface;

            foreach (var intf in typeSym.AllInterfaces) {
                string key = ClassInfo.GetFullName(intf);
                ClassSymbolInfo isi;
                if (!symTable.ClassSymbols.TryGetValue(key, out isi)) {
                    isi = new ClassSymbolInfo();
                    symTable.ClassSymbols.Add(key, isi);
                    isi.Init(intf, compilation, symTable);
                }
            }

            ClassKey = ClassInfo.GetFullName(typeSym);
            BaseClassKey = ClassInfo.GetFullName(typeSym.BaseType);
            if (BaseClassKey == "System.Object" || BaseClassKey == "System.ValueType")
                BaseClassKey = string.Empty;
            ExistConstructor = false;
            ExistStaticConstructor = false;

            if (typeSym.GetAttributes().Length > 0) {
                ExistAttributes = true;
            }

            Dictionary<string, int> fieldCounts = new Dictionary<string, int>();
            Dictionary<string, int> methodCounts = new Dictionary<string, int>();
            SymbolTable.Instance.CalcMemberCount(ClassKey, methodCounts, fieldCounts);

            bool fieldUseExplicitTypeParams = false;
            bool staticUseExplicitTypeParams = false;
            TypeSymbol = typeSym;
            var members = typeSym.GetMembers();
            foreach (var sym in members) {
                var fsym = sym as IFieldSymbol;
                if (null != fsym) {
                    FieldSymbols.Add(fsym);

                    if (fsym.GetAttributes().Length > 0) {
                        ExistAttributes = true;
                    }
                    CheckFieldUseExplicitTypeParam(fsym, compilation, ref fieldUseExplicitTypeParams, ref staticUseExplicitTypeParams);
                }
            }
            foreach (var sym in members) {
                var msym = sym as IMethodSymbol;
                if (null != msym) {
                    if (msym.MethodKind == MethodKind.Constructor && !msym.IsImplicitlyDeclared) {
                        ExistConstructor = true;
                    }
                    else if (msym.MethodKind == MethodKind.StaticConstructor && !msym.IsImplicitlyDeclared) {
                        ExistStaticConstructor = true;
                    }
                    MethodSymbols.Add(msym);

                    if (msym.GetAttributes().Length > 0) {
                        ExistAttributes = true;
                    }

                    string name = msym.Name;
                    if (name[0] == '.')
                        name = name.Substring(1);
                    bool isOverloaded;
                    int count;
                    if (msym.MethodKind == MethodKind.Constructor && msym.ContainingType.IsValueType) {
                        //值类型构造都按重载处理，总是会生成一个默认构造
                        isOverloaded = true;
                    }
                    else if (methodCounts.TryGetValue(name, out count)) {
                        isOverloaded = count > 1;
                    }
                    else {
                        isOverloaded = false;
                    }
                    if (!SymbolOverloadFlags.ContainsKey(name)) {
                        SymbolOverloadFlags.Add(name, isOverloaded);
                    }
                    else {
                        SymbolOverloadFlags[name] = isOverloaded;
                    }
                    continue;
                }
                var psym = sym as IPropertySymbol;
                if (null != psym && !psym.IsIndexer) {
                    PropertySymbols.Add(psym);

                    if (psym.GetAttributes().Length > 0) {
                        ExistAttributes = true;
                    }
                    continue;
                }
                var esym = sym as IEventSymbol;
                if (null != esym) {
                    EventSymbols.Add(esym);

                    if (esym.GetAttributes().Length > 0) {
                        ExistAttributes = true;
                    }
                    continue;
                }
            }
            BuildInterfaceInfo(typeSym, compilation, symTable);
        }

        private void CheckFieldUseExplicitTypeParam(IFieldSymbol fsym, Compilation compilation, ref bool fieldUseExplicitTypeParams, ref bool staticFieldUseExplicitTypeParams)
        {
            bool useExplicitTypeParam = false;
            bool createSelf = false;
            foreach (var decl in fsym.DeclaringSyntaxReferences) {
                var node = decl.GetSyntax() as CSharpSyntaxNode;
                if (null != node) {
                    var model = compilation.GetSemanticModel(node.SyntaxTree, true);
                    var analysis = new FieldInitializerAnalysis(model);
                    node.Accept(analysis);
                    if (analysis.UseExplicitTypeParam) {
                        useExplicitTypeParam = true;
                        break;
                    }
                    if (analysis.ObjectCreateType == fsym.ContainingType) {
                        createSelf = true;
                        break;
                    }
                }
            }
            if (useExplicitTypeParam) {
                if (fsym.IsStatic) {
                    staticFieldUseExplicitTypeParams = true;
                }
                else {
                    fieldUseExplicitTypeParams = true;
                }
                FieldUseExplicitTypeParams.Add(fsym.Name, fsym);
            }
            if (createSelf) {
                FieldCreateSelfs.Add(fsym.Name, fsym);
            }
        }
        private void BuildInterfaceInfo(INamedTypeSymbol typeSym, CSharpCompilation compilation, SymbolTable symTable)
        {
            foreach (var intf in typeSym.AllInterfaces) {
                if (!InterfaceSymbols.Contains(intf)) {
                    InterfaceSymbols.Add(intf);
                }
            }
            if (typeSym.TypeKind != TypeKind.Interface) {
                foreach (var sym in typeSym.GetMembers()) {
                    var msym = sym as IMethodSymbol;
                    if (null != msym && msym.ExplicitInterfaceImplementations.Length > 0) {
                        foreach (var implSym in msym.ExplicitInterfaceImplementations) {
                            string fn = ClassInfo.GetFullName(implSym.ContainingType);
                            ClassSymbolInfo csi;
                            if (symTable.ClassSymbols.TryGetValue(fn, out csi)) {
                                if (!csi.ExplicitInterfaceImplementationMethods.ContainsKey(implSym))
                                    csi.ExplicitInterfaceImplementationMethods.Add(implSym, msym);
                            }
                        }
                    }
                    var psym = sym as IPropertySymbol;
                    if (null != psym && !psym.IsIndexer && psym.ExplicitInterfaceImplementations.Length > 0) {
                        foreach (var implSym in psym.ExplicitInterfaceImplementations) {
                            string fn = ClassInfo.GetFullName(implSym.ContainingType);
                            ClassSymbolInfo csi;
                            if (symTable.ClassSymbols.TryGetValue(fn, out csi)) {
                                if (!csi.ExplicitInterfaceImplementationProperties.ContainsKey(implSym))
                                    csi.ExplicitInterfaceImplementationProperties.Add(implSym, psym);
                            }
                        }
                    }
                    var esym = sym as IEventSymbol;
                    if (null != esym && esym.ExplicitInterfaceImplementations.Length > 0) {
                        foreach (var implSym in esym.ExplicitInterfaceImplementations) {
                            string fn = ClassInfo.GetFullName(implSym.ContainingType);
                            ClassSymbolInfo csi;
                            if (symTable.ClassSymbols.TryGetValue(fn, out csi)) {
                                if (!csi.ExplicitInterfaceImplementationEvents.ContainsKey(implSym))
                                    csi.ExplicitInterfaceImplementationEvents.Add(implSym, esym);
                            }
                        }
                    }
                }
            }
        }
    }
}