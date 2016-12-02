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
        internal bool GenerateTypeParamFields = false;

        internal INamedTypeSymbol TypeSymbol = null;
        internal List<IFieldSymbol> FieldSymbols = new List<IFieldSymbol>();
        internal List<IMethodSymbol> MethodSymbols = new List<IMethodSymbol>();
        internal List<IPropertySymbol> PropertySymbols = new List<IPropertySymbol>();
        internal List<IEventSymbol> EventSymbols = new List<IEventSymbol>();
        internal List<INamedTypeSymbol> InterfaceSymbols = new List<INamedTypeSymbol>();
        internal Dictionary<string, bool> SymbolOverloadFlags = new Dictionary<string, bool>();
        internal HashSet<string> MethodNames = new HashSet<string>();
        internal Dictionary<string, INamedTypeSymbol> ExtensionClasses = new Dictionary<string, INamedTypeSymbol>();
        internal Dictionary<string, IMethodSymbol> MethodUseExplicitTypeParams = new Dictionary<string, IMethodSymbol>();
        internal Dictionary<string, IFieldSymbol> FieldUseExplicitTypeParams = new Dictionary<string, IFieldSymbol>();
        internal Dictionary<string, IFieldSymbol> FieldCreateSelfs = new Dictionary<string, IFieldSymbol>();
        internal List<string> GenericTypeParamNames = new List<string>();
        internal Dictionary<string, string> InterfaceMethodMap = new Dictionary<string, string>();

        internal void Init(INamedTypeSymbol typeSym, CSharpCompilation compilation, SymbolTable symTable)
        {
            if (typeSym.TypeKind == TypeKind.Error) {
                Logger.Instance.ReportIllegalType(typeSym);
                return;
            }
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

            INamedTypeSymbol type = typeSym;
            while (null != type) {
                if (type.IsGenericType) {
                    foreach (var param in type.TypeParameters) {
                        GenericTypeParamNames.Add(param.Name);
                    }
                }
                type = type.ContainingType;
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
                        CheckMethodUseExplicitTypeParam(msym, symTable.AssemblySymbol, compilation, msym.MethodKind != MethodKind.Constructor);

                        if (fieldUseExplicitTypeParams && msym.MethodKind == MethodKind.Constructor) {
                            if (!MethodUseExplicitTypeParams.ContainsKey(manglingName))
                                MethodUseExplicitTypeParams.Add(manglingName, msym);
                        }
                        if (staticUseExplicitTypeParams && msym.MethodKind == MethodKind.StaticConstructor) {
                            if (!MethodUseExplicitTypeParams.ContainsKey(manglingName))
                                MethodUseExplicitTypeParams.Add(manglingName, msym);
                        }
                    }
                    continue;
                }
                var psym = sym as IPropertySymbol;
                if (null != psym && !psym.IsIndexer) {
                    PropertySymbols.Add(psym);

                    if (psym.GetAttributes().Length > 0) {
                        ExistAttributes = true;
                    }

                    if (typeSym.IsGenericType) {
                        if (null != psym.GetMethod) {
                            CheckMethodUseExplicitTypeParam(psym.GetMethod, symTable.AssemblySymbol, compilation, true);
                        }
                        if (null != psym.SetMethod) {
                            CheckMethodUseExplicitTypeParam(psym.SetMethod, symTable.AssemblySymbol, compilation, true);
                        }
                    }
                    continue;
                }
                var esym = sym as IEventSymbol;
                if (null != esym) {
                    EventSymbols.Add(esym);

                    if (esym.GetAttributes().Length > 0) {
                        ExistAttributes = true;
                    }

                    if (typeSym.IsGenericType) {
                        if (null != esym.AddMethod) {
                            CheckMethodUseExplicitTypeParam(esym.AddMethod, symTable.AssemblySymbol, compilation, true);
                        }
                        if (null != esym.RemoveMethod) {
                            CheckMethodUseExplicitTypeParam(esym.RemoveMethod, symTable.AssemblySymbol, compilation, true);
                        }
                    }
                    continue;
                }
            }
            BuildInterfaceMethodMap(typeSym, compilation, symTable);
            BuildInterfaces(typeSym);
        }

        private void CheckFieldUseExplicitTypeParam(IFieldSymbol fsym, Compilation compilation, ref bool fieldIncludeTypeOf, ref bool staticFieldIncludeTypeOf)
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
                    staticFieldIncludeTypeOf = true;
                    GenerateBasicCctor = true;
                } else {
                    fieldIncludeTypeOf = true;
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
        private void CheckMethodUseExplicitTypeParam(IMethodSymbol msym, IAssemblySymbol assemblySym, Compilation compilation, bool setGenerateBasicFlagIfInclude)
        {
            bool useExplicitTypeParam = false;
            foreach (var decl in msym.DeclaringSyntaxReferences) {
                var node = decl.GetSyntax() as CSharpSyntaxNode;
                if (null != node) {
                    var model = compilation.GetSemanticModel(node.SyntaxTree, true);
                    var analysis = new MethodAnalysis(model);
                    node.Accept(analysis);
                    if (analysis.UseExplicitTypeParam) {
                        useExplicitTypeParam = true;
                        break;
                    }
                }
            }
            if (useExplicitTypeParam) {
                string manglingName = SymbolTable.CalcMethodMangling(msym, assemblySym);
                if (!MethodUseExplicitTypeParams.ContainsKey(manglingName)) {
                    MethodUseExplicitTypeParams.Add(manglingName, msym);
                }
                if (setGenerateBasicFlagIfInclude) {
                    //静态函数的generic参数直接作函数参数，非静态的函数又非构造函数需要借助类型参数成员
                    if (!msym.IsStatic) {
                        GenerateBasicCtor = true;
                        GenerateTypeParamFields = true;
                    }
                }
            }
        }
        private void BuildInterfaceMethodMap(INamedTypeSymbol typeSym, CSharpCompilation compilation, SymbolTable symTable)
        {
            foreach (var intf in typeSym.AllInterfaces) {
                foreach (var sym in intf.GetMembers()) {
                    var msym = sym as IMethodSymbol;
                    if (null != msym) {
                        var implSym = typeSym.FindImplementationForInterfaceMember(sym) as IMethodSymbol;
                        if (null != implSym) {
                            string name = symTable.NameMangling(msym);
                            string implName = symTable.NameMangling(implSym);
                            if (!InterfaceMethodMap.ContainsKey(name)) {
                                InterfaceMethodMap.Add(name, implName);
                            }
                        }
                    }
                    var psym = sym as IPropertySymbol;
                    if (null != psym) {
                        var implSym = typeSym.FindImplementationForInterfaceMember(sym) as IPropertySymbol;
                        if (null != implSym && !psym.IsIndexer) {
                            string name = SymbolTable.GetPropertyName(psym);
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
                            string implName = SymbolTable.GetEventName(implSym);
                            if (!InterfaceMethodMap.ContainsKey(name)) {
                                InterfaceMethodMap.Add(name, implName);
                            }
                        }
                    }
                }
            }
        }
        private void BuildInterfaces(INamedTypeSymbol typeSym)
        {
            foreach (var intf in typeSym.AllInterfaces) {
                if (!InterfaceSymbols.Contains(intf)) {
                    InterfaceSymbols.Add(intf);
                }

                BuildInterfaces(intf);
            }
        }
    }
}