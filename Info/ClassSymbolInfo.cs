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
    internal class ClassSymbolInfo
    {
        internal string ClassKey = string.Empty;
        internal string BaseClassKey = string.Empty;
        internal bool ExistAttributes = false;
        internal bool ExistConstructor = false;
        internal bool ExistStaticConstructor = false;
        internal bool GenerateBasicCtor = false;
        internal bool GenerateBasicCctor = false;

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
        internal Dictionary<string, string> InterfaceMethodMap = new Dictionary<string, string>();
        internal List<IMethodSymbol> ExplicitInterfaceImplementationMethods = new List<IMethodSymbol>();
        internal List<IPropertySymbol> ExplicitInterfaceImplementationProperties = new List<IPropertySymbol>();
        internal List<IEventSymbol> ExplicitInterfaceImplementationEvents = new List<IEventSymbol>();

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
            if (BaseClassKey == SymbolTable.PrefixExternClassName("System.Object") || BaseClassKey == SymbolTable.PrefixExternClassName("System.ValueType"))
                BaseClassKey = string.Empty;
            ExistConstructor = false;
            ExistStaticConstructor = false;

            if (typeSym.GetAttributes().Length > 0) {
                ExistAttributes = true;
            }

            bool fieldUseExplicitTypeParams = false;
            bool staticUseExplicitTypeParams = false;
            TypeSymbol = typeSym;
            foreach (var sym in TypeSymbol.GetMembers()) {
                var fsym = sym as IFieldSymbol;
                if (null != fsym) {
                    FieldSymbols.Add(fsym);

                    if (fsym.GetAttributes().Length > 0) {
                        ExistAttributes = true;
                    }
                    CheckFieldUseExplicitTypeParam(fsym, compilation, ref fieldUseExplicitTypeParams, ref staticUseExplicitTypeParams);
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

                    if (msym.GetAttributes().Length > 0) {
                        ExistAttributes = true;
                    }

                    string name = msym.Name;
                    if (name[0] == '.')
                        name = name.Substring(1);
                    string manglingName = SymbolTable.CalcMethodMangling(msym);
                    if (!SymbolOverloadFlags.ContainsKey(name)) {
                        SymbolOverloadFlags.Add(name, false);
                    } else {
                        SymbolOverloadFlags[name] = true;
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
                    GenerateBasicCctor = true;
                } else {
                    fieldUseExplicitTypeParams = true;
                    GenerateBasicCtor = true;
                }
                FieldUseExplicitTypeParams.Add(fsym.Name, fsym);
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
        private void BuildInterfaceInfo(INamedTypeSymbol typeSym, CSharpCompilation compilation, SymbolTable symTable)
        {
            foreach (var intf in typeSym.AllInterfaces) {
                if (!InterfaceSymbols.Contains(intf)) {
                    InterfaceSymbols.Add(intf);
                }
                foreach (var sym in intf.GetMembers()) {
                    var msym = sym as IMethodSymbol;
                    if (null != msym) {
                        var implSym = typeSym.FindImplementationForInterfaceMember(sym) as IMethodSymbol;
                        if (null != implSym) {
                            string name = symTable.NameMangling(msym);
                            name = ClassInfo.CalcNameWithFullTypeName(name, sym.ContainingType);
                            string implName = symTable.NameMangling(implSym);
                            if (!InterfaceMethodMap.ContainsKey(name)) {
                                InterfaceMethodMap.Add(name, implName);
                            }
                        }
                    }
                    var psym = sym as IPropertySymbol;
                    if (null != psym && !psym.IsIndexer) {
                        var implSym = typeSym.FindImplementationForInterfaceMember(sym) as IPropertySymbol;
                        if (null != implSym && !psym.IsIndexer) {
                            string name = SymbolTable.GetPropertyName(psym);
                            name = ClassInfo.CalcNameWithFullTypeName(name, sym.ContainingType);
                            string implName = SymbolTable.GetPropertyName(implSym);
                            if (!InterfaceMethodMap.ContainsKey(name)) {
                                InterfaceMethodMap.Add(name, implName);
                            }
                        }
                    }
                    var esym = sym as IEventSymbol;
                    if (null != esym) {
                        var implSym = typeSym.FindImplementationForInterfaceMember(sym) as IEventSymbol;
                        if (null != implSym) {
                            string name = SymbolTable.GetEventName(esym);
                            name = ClassInfo.CalcNameWithFullTypeName(name, sym.ContainingType);
                            string implName = SymbolTable.GetEventName(implSym);
                            if (!InterfaceMethodMap.ContainsKey(name)) {
                                InterfaceMethodMap.Add(name, implName);
                            }
                        }
                    }
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
                                if (!csi.ExplicitInterfaceImplementationMethods.Contains(implSym))
                                    csi.ExplicitInterfaceImplementationMethods.Add(implSym);
                            }
                        }
                    }
                    var psym = sym as IPropertySymbol;
                    if (null != psym && !psym.IsIndexer && psym.ExplicitInterfaceImplementations.Length > 0) {
                        foreach (var implSym in psym.ExplicitInterfaceImplementations) {
                            string fn = ClassInfo.GetFullName(implSym.ContainingType);
                            ClassSymbolInfo csi;
                            if (symTable.ClassSymbols.TryGetValue(fn, out csi)) {
                                if (!csi.ExplicitInterfaceImplementationProperties.Contains(implSym))
                                    csi.ExplicitInterfaceImplementationProperties.Add(implSym);
                            }
                        }
                    }
                    var esym = sym as IEventSymbol;
                    if (null != esym && esym.ExplicitInterfaceImplementations.Length > 0) {
                        foreach (var implSym in esym.ExplicitInterfaceImplementations) {
                            string fn = ClassInfo.GetFullName(implSym.ContainingType);
                            ClassSymbolInfo csi;
                            if (symTable.ClassSymbols.TryGetValue(fn, out csi)) {
                                if (!csi.ExplicitInterfaceImplementationEvents.Contains(implSym))
                                    csi.ExplicitInterfaceImplementationEvents.Add(implSym);
                            }
                        }
                    }
                }
            }
        }
    }
}