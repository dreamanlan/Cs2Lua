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
        internal string Key
        {
            get
            {
                return (string.IsNullOrEmpty(Namespace) ? string.Empty : Namespace + ".") + ClassName;
            }
        }

        internal string Namespace = string.Empty;
        internal string ClassName = string.Empty;
        internal string BaseNamespace = string.Empty;
        internal string BaseClassName = string.Empty;

        internal string ExportConstructor = string.Empty;
        internal MethodInfo ExportConstructorInfo = null;
        internal HashSet<string> References = new HashSet<string>();

        internal INamedTypeSymbol SemanticInfo = null;

        internal StringBuilder CurrentSourceCodeBuilder = null;

        internal StringBuilder BeforeOuterCodeBuilder = new StringBuilder();
        internal StringBuilder AfterOuterCodeBuilder = new StringBuilder();

        internal StringBuilder InstanceFunctionSourceCodeBuilder = new StringBuilder();
        internal StringBuilder InstanceFieldSourceCodeBuilder = new StringBuilder();
        internal StringBuilder InstancePropertySourceCodeBuilder = new StringBuilder();
        internal StringBuilder InstanceEventSourceCodeBuilder = new StringBuilder();

        internal StringBuilder StaticFunctionSourceCodeBuilder = new StringBuilder();
        internal StringBuilder StaticFieldSourceCodeBuilder = new StringBuilder();
        internal StringBuilder StaticPropertySourceCodeBuilder = new StringBuilder();
        internal StringBuilder StaticEventSourceCodeBuilder = new StringBuilder();

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

            SemanticInfo = sym;

            Namespace = GetNamespaces(sym);
            ClassName = sym.Name;
            BaseNamespace = null == sym.BaseType ? string.Empty : GetNamespaces(sym.BaseType);
            BaseClassName = null == sym.BaseType ? string.Empty : sym.BaseType.Name;
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

        private static string CalcFullName(ISymbol type, bool includeSelfName)
        {
            List<string> list = new List<string>();
            if (includeSelfName)
                list.Add(type.Name);
            INamespaceSymbol ns = type.ContainingNamespace;
            var ct = type.ContainingType;
            while (null != ct && ct.Name.Length > 0) {
                list.Insert(0, ct.Name);
                ns = ct.ContainingNamespace;
                ct = ct.ContainingType;
            }
            while (null != ns && ns.Name.Length > 0) {
                list.Insert(0, ns.Name);
                ns = ns.ContainingNamespace;
            }
            return string.Join(".", list.ToArray());
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

        internal void Init(IMethodSymbol sym, ArgumentListSyntax argList)
        {
            Args.Clear();
            ReturnArgs.Clear();

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
