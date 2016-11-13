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

        internal void Init(INamedTypeSymbol sym)
        {
            IsEnum = sym.TypeKind == TypeKind.Enum;
            IsEntryClass = HasAttribute(sym, "Cs2Lua.EntryAttribute");

            Namespace = string.Empty;
            ClassName = string.Empty;
            BaseNamespace = string.Empty;
            BaseClassName = string.Empty;

            ExistConstructor = false;
            ExistStaticConstructor = false;
            SemanticInfo = sym;

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
            var refType = sym as INamedTypeSymbol;
            if (null == refType) {
                refType = sym.ContainingType;
            }
            AddReference(refType, curClassSym);
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
            string key = ClassInfo.GetFullName(sym);
            return key;
        }
        internal static string CalcMemberReference(ISymbol sym)
        {
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
            return CalcFullName(type, true);
        }
        internal static string GetNamespaces(ISymbol type)
        {
            if (type.Kind == SymbolKind.Namespace) {
                return CalcFullName(type, true);
            } else {
                return CalcFullName(type, false);
            }
        }
        internal static string CalcFullName(ISymbol type, bool includeSelfName)
        {
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
            return CalcFullNameWithTypeArguments(type, true);
        }
        internal static string GetNamespacesWithTypeArguments(ISymbol type)
        {
            if (type.Kind == SymbolKind.Namespace) {
                return CalcFullNameWithTypeArguments(type, true);
            } else {
                return CalcFullNameWithTypeArguments(type, false);
            }
        }
        internal static string CalcFullNameWithTypeArguments(ISymbol type, bool includeSelfName)
        {
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
            var typeSym = sym as INamedTypeSymbol;
            if (null != typeSym) {
                return CalcNameWithTypeParameters(typeSym);
            } else {
                return sym.Name;
            }
        }
        internal static string CalcNameWithTypeArguments(ISymbol sym)
        {
            var typeSym = sym as INamedTypeSymbol;
            if (null != typeSym) {
                return CalcNameWithTypeArguments(typeSym);
            } else {
                return sym.Name;
            }
        }
        internal static string CalcNameWithTypeParameters(INamedTypeSymbol type)
        {
            List<string> list = new List<string>();
            list.Add(type.Name);
            foreach (var param in type.TypeParameters) {
                list.Add(param.Name);
            }
            return string.Join("_", list.ToArray());
        }
        internal static string CalcNameWithTypeArguments(INamedTypeSymbol type)
        {
            List<string> list = new List<string>();
            list.Add(type.Name);
            foreach (var arg in type.TypeArguments) {
                list.Add(arg.Name);
            }
            return string.Join("_", list.ToArray());
        }

        internal static bool HasAttribute(ISymbol sym, string fullName)
        {
            foreach (var attr in sym.GetAttributes()) {
                string fn = GetFullName(attr.AttributeClass);
                if (fn == fullName)
                    return true;
            }
            return false;
        }
        internal static T GetAttributeArgument<T>(ISymbol sym, string fullName, string argName)
        {
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
    internal class MethodInfo
    {
        internal List<string> ParamNames = new List<string>();
        internal List<string> ReturnParamNames = new List<string>();
        internal List<string> RefParamNames = new List<string>();
        internal List<string> OutParamNames = new List<string>();
        internal List<string> GenericTypeTypeParamNames = new List<string>();
        internal List<string> GenericMethodTypeParamNames = new List<string>();
        internal string OriginalParamsName = string.Empty;
        internal bool ExistReturn = false;
        internal bool ExistYield = false;
        internal bool ExistTypeOf = false;

        internal IMethodSymbol SemanticInfo = null;
        internal IPropertySymbol PropertySemanticInfo = null;
        
        internal void Init(IMethodSymbol sym, SyntaxNode node)
        {
            Init(sym, node, false);
        }
        internal void Init(IMethodSymbol sym, SyntaxNode node, bool existTypeOf)
        {
            ParamNames.Clear();
            ReturnParamNames.Clear();
            RefParamNames.Clear();
            OutParamNames.Clear();
            OriginalParamsName = string.Empty;
            ExistReturn = false;
            ExistYield = false;
            ExistTypeOf = existTypeOf;
            
            SemanticInfo = sym;

            if (sym.IsGenericMethod) {
                foreach (var param in sym.TypeParameters) {
                    ParamNames.Add(param.Name);
                    GenericMethodTypeParamNames.Add(param.Name);
                }
            }

            if (ExistTypeOf && (sym.MethodKind == MethodKind.Constructor || sym.MethodKind == MethodKind.StaticConstructor || sym.IsStatic)) {
                INamedTypeSymbol type = sym.ContainingType;
                while (null != type) {
                    if (type.IsGenericType) {
                        foreach (var param in type.TypeParameters) {
                            ParamNames.Add(param.Name);
                            GenericTypeTypeParamNames.Add(param.Name);
                        }
                    }
                    type = type.ContainingType;
                }
            }

            foreach (var param in sym.Parameters) {
                if (param.IsParams) {
                    ParamNames.Add("...");
                    OriginalParamsName = param.Name;
                } else if (param.RefKind == RefKind.Ref) {
                    ParamNames.Add(param.Name);
                    RefParamNames.Add(param.Name);
                    ReturnParamNames.Add(param.Name);
                } else if (param.RefKind == RefKind.Out) {
                    OutParamNames.Add(param.Name);
                    ReturnParamNames.Add(param.Name);
                } else {
                    ParamNames.Add(param.Name);
                }
            }

            if (!sym.ReturnsVoid) {
                var returnType = ClassInfo.GetFullName(sym.ReturnType);
                if (returnType.StartsWith("System.Collections") && (sym.ReturnType.Name == "IEnumerable" || sym.ReturnType.Name == "IEnumerator")) {
                    var analysis = new YieldAnalysis();
                    analysis.Visit(node);
                    ExistYield = analysis.YieldCount > 0;
                }
            }
        }
    }
    internal class InvocationInfo
    {
        internal string ClassKey = string.Empty;
        internal List<ExpressionSyntax> Args = new List<ExpressionSyntax>();
        internal List<ExpressionSyntax> ReturnArgs = new List<ExpressionSyntax>();
        internal List<ITypeSymbol> GenericTypeArgs = new List<ITypeSymbol>();
        internal bool ArrayToParams = false;

        internal IMethodSymbol MethodSymbol = null;
        internal IAssemblySymbol AssemblySymbol = null;

        internal void Init(IMethodSymbol sym, IAssemblySymbol assemblySym, ArgumentListSyntax argList, bool existTypeOf, SemanticModel model)
        {
            Init(sym, assemblySym, existTypeOf);

            if (null != argList) {
                var args = argList.Arguments;

                int ct = args.Count;
                for (int i = 0; i < ct; ++i) {
                    var arg = args[i];
                    if (i < sym.Parameters.Length) {
                        var param = sym.Parameters[i];
                        if (param.RefKind == RefKind.Ref) {
                            Args.Add(arg.Expression);
                            ReturnArgs.Add(arg.Expression);
                        } else if (param.RefKind == RefKind.Out) {
                            if (sym.ContainingAssembly != assemblySym && SymbolTable.ForSlua) {
                                //外部类的方法的out参数,slua在调用时传入Slua.out,这里用null标记一下，在实际输出参数时再变为Slua.out
                                Args.Add(null);
                            }
                            ReturnArgs.Add(arg.Expression);
                        } else if (param.IsParams) {
                            var argOper = model.GetOperation(arg.Expression);
                            if (null != argOper && null != argOper.Type && argOper.Type.TypeKind == TypeKind.Array && i == ct - 1) {
                                ArrayToParams = true;
                            }
                            Args.Add(arg.Expression);
                        } else {
                            Args.Add(arg.Expression);
                        }
                    } else {
                        Args.Add(arg.Expression);
                    }
                }
            }
        }
        
        internal void Init(IMethodSymbol sym, IAssemblySymbol assemblySym, List<ExpressionSyntax> argList, bool existTypeOf)
        {
            Init(sym, assemblySym, existTypeOf);

            if (null != argList) {
                Args.AddRange(argList);
            }
        }

        private void Init(IMethodSymbol sym, IAssemblySymbol assemblySym, bool existTypeOf)
        {
            MethodSymbol = sym;
            AssemblySymbol = assemblySym;

            Args.Clear();
            ReturnArgs.Clear();
            GenericTypeArgs.Clear();

            ClassKey = ClassInfo.CalcMemberReference(sym);
            
            if (sym.IsGenericMethod) {
                foreach (var arg in sym.TypeArguments) {
                    GenericTypeArgs.Add(arg);
                }
            }

            if (existTypeOf && (sym.MethodKind == MethodKind.Constructor || sym.MethodKind == MethodKind.StaticConstructor || sym.IsStatic)) {
                INamedTypeSymbol type = sym.ContainingType;
                while (null != type) {
                    if (type.IsGenericType) {
                        foreach (var arg in type.TypeArguments) {
                            GenericTypeArgs.Add(arg);
                        }
                    }
                    type = type.ContainingType;
                }
            }
        }
    }
    internal class ContinueInfo
    {
        internal bool IsLoop = false;
        internal bool IsIgnoreBreak = false;
        internal bool HaveContinue = false;
        internal bool HaveBreak = false;
        internal string BreakFlagVarName = string.Empty;

        internal void Init(SwitchSectionSyntax syntax)
        {
            IsLoop = false;
            IsIgnoreBreak = false;
            HaveContinue = false;
            HaveBreak = true;
            BreakFlagVarName = string.Empty;
        }
        internal void Init(StatementSyntax syntax)
        {
            IsLoop = true;
            IsIgnoreBreak = false;
            ContinueAnalysis cont = new ContinueAnalysis();
            cont.Visit(syntax);
            HaveContinue = cont.ContinueCount > 0;
            HaveBreak = cont.BreakCount > 0;
            BreakFlagVarName = string.Format("__compiler_continue_{0}", syntax.GetLocation().GetLineSpan().StartLinePosition.Line);
        }
    }
    internal class SwitchInfo
    {
        internal string SwitchVarName = string.Empty;
    }
    internal class MergedNamespaceInfo
    {
        internal string Name = string.Empty;
        internal Dictionary<string, MergedNamespaceInfo> Namespaces = new Dictionary<string, MergedNamespaceInfo>();
    }
    internal class MergedClassInfo
    {
        internal string Key = string.Empty;
        internal List<ClassInfo> Classes = new List<ClassInfo>();
        internal Dictionary<string, MergedClassInfo> InnerClasses = new Dictionary<string, MergedClassInfo>();
    }
}
