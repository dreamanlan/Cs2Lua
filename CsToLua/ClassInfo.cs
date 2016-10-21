using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace RoslynTool.CsToLua
{
    internal class ClassInfo
    {
        internal bool IsEnum = false;
        internal bool IsEntryClass = false;

        internal string Key = string.Empty;
        internal string Namespace = string.Empty;
        internal string ClassName = string.Empty;
        internal string BaseNamespace = string.Empty;
        internal string BaseClassName = string.Empty;

        internal string ExportConstructor = string.Empty;
        internal MethodInfo ExportConstructorInfo = null;
        internal HashSet<string> References = new HashSet<string>();
                
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

        internal void Init(INamedTypeSymbol sym)
        {
            IsEnum = sym.TypeKind == TypeKind.Enum;

            IsEntryClass = false;
            foreach (var attr in sym.GetAttributes()) {
                string fullName = ClassInfo.GetFullName(attr.AttributeClass);
                if (fullName == "Cs2Lua.EntryAttribute") {
                    IsEntryClass = true;
                }
            }

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
        }
        internal void AddReference(ISymbol sym, INamedTypeSymbol curClassSym, string key)
        {
            var refType = sym as INamedTypeSymbol;
            if (null == refType) {
                refType = sym.ContainingType;
            }
            if (null != refType && refType != curClassSym && !refType.IsAnonymousType && refType.TypeKind != TypeKind.Delegate) {                
                if (!string.IsNullOrEmpty(key) && !References.Contains(key) && key != Key) {
                    bool isValid = true;
                    foreach (var attr in refType.GetAttributes()) {
                        string fullName = ClassInfo.GetFullName(attr.AttributeClass);
                        if (fullName == "Cs2Lua.IgnoreAttribute") {
                            isValid = false;
                        }
                    }
                    if (isValid) {
                        References.Add(key);
                    }
                }
            }
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
                CalcNameWithTypeParameters(ct);
            }
            while (null != ct && name.Length > 0) {
                list.Insert(0, name);
                ns = ct.ContainingNamespace;
                ct = ct.ContainingType;
                if (null != ct) {
                    CalcNameWithTypeParameters(ct);
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
    }
    internal class MethodInfo
    {
        internal List<string> ParamNames = new List<string>();
        internal List<string> ReturnParamNames = new List<string>();
        internal List<string> RefParamNames = new List<string>();
        internal List<string> OutParamNames = new List<string>();
        internal string OriginalParamsName = string.Empty;
        internal bool ExistReturn = false;

        internal IMethodSymbol SemanticInfo = null;
        internal IPropertySymbol PropertySemanticInfo = null;

        internal void Init(IMethodSymbol sym)
        {
            ParamNames.Clear();
            ReturnParamNames.Clear();
            RefParamNames.Clear();
            OutParamNames.Clear();
            OriginalParamsName = string.Empty;
            ExistReturn = false;
            
            SemanticInfo = sym;

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
        }
    }
    internal class InvocationInfo
    {
        internal string ClassKey = string.Empty;
        internal List<ExpressionSyntax> Args = new List<ExpressionSyntax>();
        internal List<ExpressionSyntax> ReturnArgs = new List<ExpressionSyntax>();
        internal List<ITypeSymbol> GenericTypeArgs = new List<ITypeSymbol>();

        internal void Init(IMethodSymbol sym, ArgumentListSyntax argList)
        {
            Args.Clear();
            ReturnArgs.Clear();
            GenericTypeArgs.Clear();

            ClassKey = ClassInfo.CalcMemberReference(sym);

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
                            ReturnArgs.Add(arg.Expression);
                        } else {
                            Args.Add(arg.Expression);
                        }
                    } else {
                        Args.Add(arg.Expression);
                    }
                }
            }

            if (sym.IsGenericMethod) {
                int ct = sym.TypeArguments.Length;
                for (int i = 0; i < ct; ++i) {
                    var arg = sym.TypeArguments[i];
                    GenericTypeArgs.Add(arg);
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
        internal Dictionary<string, MergedClassInfo> Classes = new Dictionary<string, MergedClassInfo>();
        internal Dictionary<string, MergedNamespaceInfo> Namespaces = new Dictionary<string, MergedNamespaceInfo>();
    }
    internal class MergedClassInfo
    {
        internal string Key = string.Empty;
        internal List<ClassInfo> Classes = new List<ClassInfo>();
    }
}
