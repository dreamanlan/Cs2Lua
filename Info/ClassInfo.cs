using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Semantics;

namespace RoslynTool.CsToLua
{
    internal class ClassInfo
    {
        internal bool IsEnum = false;
        internal bool IsEntryClass = false;
        internal bool IsValueType = false;

        internal string Key = string.Empty;
        internal string BaseKey = string.Empty;

        internal string Namespace = string.Empty;
        internal string ClassName = string.Empty;
        internal string BaseNamespace = string.Empty;
        internal string BaseClassName = string.Empty;

        internal string ExportConstructor = string.Empty;
        internal MethodInfo ExportConstructorInfo = null;
        internal HashSet<string> References = new HashSet<string>();
        internal HashSet<string> IgnoreReferences = new HashSet<string>();
                
        internal bool ExistConstructor = false;
        internal bool ExistStaticConstructor = false;

        internal INamedTypeSymbol SemanticInfo = null;
        internal ClassSymbolInfo ClassSemanticInfo = null;

        internal StringBuilder CurrentCodeBuilder = null;

        internal StringBuilder BeforeOuterCodeBuilder = new StringBuilder();
        internal StringBuilder AfterOuterCodeBuilder = new StringBuilder();

        internal StringBuilder InstanceFunctionCodeBuilder = new StringBuilder();
        internal StringBuilder InstanceFieldCodeBuilder = new StringBuilder();
        internal StringBuilder InstancePropertyCodeBuilder = new StringBuilder();
        internal StringBuilder InstanceEventCodeBuilder = new StringBuilder();

        internal StringBuilder StaticFunctionCodeBuilder = new StringBuilder();
        internal StringBuilder StaticFieldCodeBuilder = new StringBuilder();
        internal StringBuilder StaticPropertyCodeBuilder = new StringBuilder();
        internal StringBuilder StaticEventCodeBuilder = new StringBuilder();

        internal StringBuilder InstanceInitializerCodeBuilder = new StringBuilder();
        internal StringBuilder StaticInitializerCodeBuilder = new StringBuilder();

        internal Dictionary<string, StringBuilder> ExtensionCodeBuilders = new Dictionary<string, StringBuilder>();

        internal Dictionary<string, ClassInfo> InnerClasses = new Dictionary<string, ClassInfo>();

        internal void Init(INamedTypeSymbol sym, ClassSymbolInfo info)
        {
            IsEnum = sym.TypeKind == TypeKind.Enum;
            IsEntryClass = HasAttribute(sym, "Cs2Lua.EntryAttribute");
            IsValueType = sym.IsValueType;

            Namespace = string.Empty;
            ClassName = string.Empty;
            BaseNamespace = string.Empty;
            BaseClassName = string.Empty;

            ExistConstructor = false;
            ExistStaticConstructor = false;
            SemanticInfo = sym;
            ClassSemanticInfo = info;

            Namespace = GetNamespaces(sym);
            ClassName = sym.Name;
            BaseNamespace = null == sym.BaseType ? string.Empty : GetNamespaces(sym.BaseType);
            BaseClassName = null == sym.BaseType ? string.Empty : sym.BaseType.Name;
            
            Key = GetFullName(sym);
            BaseKey = GetFullName(sym.BaseType);
            if (BaseKey == "System.Object" || BaseKey == "System.ValueType") {
                BaseKey = string.Empty;
            }

            References.Clear();
            IgnoreReferences.Clear();
        }
        internal void AddReference(ISymbol sym, INamedTypeSymbol curClassSym)
        {
            var arrType = sym as IArrayTypeSymbol;
            if (null != arrType) {
                AddReference(arrType.ElementType, curClassSym);
            } else {
                var refType = sym as INamedTypeSymbol;
                if (null == refType) {
                    refType = sym.ContainingType;
                }
                if (null != refType) {
                    AddReference(refType, curClassSym);
                } else {
                    Logger.Instance.ReportIllegalType(sym);
                }
            }
        }
        internal void AddReference(INamedTypeSymbol refType, INamedTypeSymbol curClassSym)
        {
            while (null != refType.ContainingType) {
                refType = refType.ContainingType;
            }
            string key = GetFullName(refType);
            if (null != refType && refType != curClassSym && refType.ContainingAssembly == curClassSym.ContainingAssembly && !refType.IsAnonymousType && refType.TypeKind != TypeKind.Delegate) {
                if (!string.IsNullOrEmpty(key) && !References.Contains(key) && key != Key) {
                    bool isIgnore = ClassInfo.HasAttribute(refType, "Cs2Lua.IgnoreAttribute");
                    if (isIgnore) {
                        IgnoreReferences.Add(key);
                    } else {
                        References.Add(key);
                    }
                }
            }
        }

        internal static bool IsBaseInitializerCalled(ConstructorDeclarationSyntax node, SemanticModel model)
        {
            bool baseInitializerCalled = false;
            var init = node.Initializer;
            if (null != init) {
                var oper = model.GetOperation(init) as IInvocationExpression;
                if (init.ThisOrBaseKeyword.Text == "this") {
                    var constructor = oper.TargetMethod;
                    if (null != constructor) {
                        var decl = constructor.DeclaringSyntaxReferences;
                        if (decl.Length == 1) {
                            var syntax = decl[0].GetSyntax() as ConstructorDeclarationSyntax;
                            if (null != syntax) {
                                return IsBaseInitializerCalled(syntax, model);
                            }
                        }
                    }
                } else if (init.ThisOrBaseKeyword.Text == "base") {
                    baseInitializerCalled = true;
                }
            }
            return baseInitializerCalled;
        }
        internal static string CalcTypeReference(INamedTypeSymbol sym)
        {
            if (null == sym)
                return string.Empty;
            string key = ClassInfo.GetFullName(sym);
            return key;
        }
        internal static string CalcMemberReference(ISymbol sym)
        {
            if (null == sym)
                return string.Empty;
            if (sym.Kind == SymbolKind.NamedType) {
                string key = ClassInfo.GetFullName(sym);
                return key;
            } else {
                string key = ClassInfo.GetFullName(sym.ContainingType);
                return key;
            }
        }

        internal static string GetFullName(ISymbol type)
        {
            if (null == type)
                return string.Empty;
            return CalcFullName(type, true);
        }
        internal static string GetNamespaces(ISymbol type)
        {
            if (null == type)
                return string.Empty;
            if (type.Kind == SymbolKind.Namespace) {
                return CalcFullName(type, true);
            } else {
                return CalcFullName(type, false);
            }
        }
        internal static string CalcFullName(ISymbol type, bool includeSelfName)
        {
            if (null == type)
                return string.Empty;
            List<string> list = new List<string>();
            if (includeSelfName) {
                list.Add(CalcNameWithTypeParameters(type));
            }
            INamespaceSymbol ns = type.ContainingNamespace;
            var ct = type.ContainingType;
            string name = string.Empty;
            if (null != ct) {
                name = CalcNameWithTypeParameters(ct);
            }
            while (null != ct && name.Length > 0) {
                list.Insert(0, name);
                ns = ct.ContainingNamespace;
                ct = ct.ContainingType;
                if (null != ct) {
                    name = CalcNameWithTypeParameters(ct);
                } else {
                    name = string.Empty;
                }
            }
            while (null != ns && ns.Name.Length > 0) {
                list.Insert(0, ns.Name);
                ns = ns.ContainingNamespace;
            }
            return string.Join(".", list.ToArray());
        }
        
        internal static string GetFullNameWithTypeArguments(ISymbol type)
        {
            if (null == type)
                return string.Empty;
            return CalcFullNameWithTypeArguments(type, true);
        }
        internal static string GetNamespacesWithTypeArguments(ISymbol type)
        {
            if (null == type)
                return string.Empty;
            if (type.Kind == SymbolKind.Namespace) {
                return CalcFullNameWithTypeArguments(type, true);
            } else {
                return CalcFullNameWithTypeArguments(type, false);
            }
        }
        internal static string CalcFullNameWithTypeArguments(ISymbol type, bool includeSelfName)
        {
            if (null == type)
                return string.Empty;
            List<string> list = new List<string>();
            if (includeSelfName) {
                list.Add(CalcNameWithTypeArguments(type));
            }
            INamespaceSymbol ns = type.ContainingNamespace;
            var ct = type.ContainingType;
            string name = string.Empty;
            if (null != ct) {
                CalcNameWithTypeArguments(ct);
            }
            while (null != ct && name.Length > 0) {
                list.Insert(0, name);
                ns = ct.ContainingNamespace;
                ct = ct.ContainingType;
                if (null != ct) {
                    CalcNameWithTypeArguments(ct);
                } else {
                    name = string.Empty;
                }
            }
            while (null != ns && ns.Name.Length > 0) {
                list.Insert(0, ns.Name);
                ns = ns.ContainingNamespace;
            }
            return string.Join(".", list.ToArray());
        }

        internal static string CalcNameWithTypeParameters(ISymbol sym)
        {
            if (null == sym)
                return string.Empty;
            var typeSym = sym as INamedTypeSymbol;
            if (null != typeSym) {
                return CalcNameWithTypeParameters(typeSym);
            } else {
                return sym.Name;
            }
        }
        internal static string CalcNameWithTypeArguments(ISymbol sym)
        {
            if (null == sym)
                return string.Empty;
            var typeSym = sym as INamedTypeSymbol;
            if (null != typeSym) {
                return CalcNameWithTypeArguments(typeSym);
            } else {
                return sym.Name;
            }
        }
        internal static string CalcNameWithTypeParameters(INamedTypeSymbol type)
        {
            if (null == type)
                return string.Empty;
            List<string> list = new List<string>();
            list.Add(type.Name);
            foreach (var param in type.TypeParameters) {
                list.Add(param.Name);
            }
            return string.Join("_", list.ToArray());
        }
        internal static string CalcNameWithTypeArguments(INamedTypeSymbol type)
        {
            if (null == type)
                return string.Empty;
            List<string> list = new List<string>();
            list.Add(type.Name);
            foreach (var arg in type.TypeArguments) {
                list.Add(arg.Name);
            }
            return string.Join("_", list.ToArray());
        }

        internal static bool HasAttribute(ISymbol sym, string fullName)
        {
            if (null == sym)
                return false;
            foreach (var attr in sym.GetAttributes()) {
                string fn = GetFullName(attr.AttributeClass);
                if (fn == fullName)
                    return true;
            }
            return false;
        }
        internal static T GetAttributeArgument<T>(ISymbol sym, string fullName, string argName)
        {
            if (null == sym)
                return default(T);
            foreach (var attr in sym.GetAttributes()) {
                string fn = GetFullName(attr.AttributeClass);
                if (fn == fullName) {
                    var args = attr.NamedArguments;
                    foreach (var pair in args) {
                        if (pair.Key == argName) {
                            var arg = pair.Value;
                            return (T)Convert.ChangeType(arg.Value, typeof(T));
                        }
                    }
                }
            }
            return default(T);
        }
        internal static T GetAttributeArgument<T>(ISymbol sym, string fullName, int index)
        {
            if (null == sym)
                return default(T);
            foreach (var attr in sym.GetAttributes()) {
                string fn = GetFullName(attr.AttributeClass);
                if (fn == fullName) {
                    var args = attr.ConstructorArguments;
                    int ct = args.Length;
                    if (index >= 0 && index < ct) {
                        var arg = args[index];
                        return (T)Convert.ChangeType(arg.Value, typeof(T));
                    }
                }
            }
            return default(T);
        }
    }
}
