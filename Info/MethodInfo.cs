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
    internal class MethodInfo
    {
        internal List<string> ParamNames = new List<string>();
        internal List<string> ReturnParamNames = new List<string>();
        internal List<string> RefParamNames = new List<string>();
        internal List<string> OutParamNames = new List<string>();
        internal HashSet<int> ValueParams = new HashSet<int>();
        internal HashSet<int> ExternValueParams = new HashSet<int>();
        internal List<string> GenericTypeTypeParamNames = new List<string>();
        internal List<string> GenericMethodTypeParamNames = new List<string>();
        internal string OriginalParamsName = string.Empty;
        internal bool ParamsIsValueType = false;
        internal bool ParamsIsExternValueType = false;
        internal bool ExistReturn = false;
        internal bool ExistYield = false;
        internal bool UseExplicitTypeParam = false;

        internal IMethodSymbol SemanticInfo = null;
        internal IPropertySymbol PropertySemanticInfo = null;

        internal void Init(IMethodSymbol sym, IAssemblySymbol assemblySym, SyntaxNode node)
        {
            Init(sym, assemblySym, node, false);
        }
        internal void Init(IMethodSymbol sym, IAssemblySymbol assemblySym, SyntaxNode node, bool useExplicitTypeParam)
        {
            ParamNames.Clear();
            ReturnParamNames.Clear();
            RefParamNames.Clear();
            OutParamNames.Clear();
            OriginalParamsName = string.Empty;
            ExistReturn = false;
            ExistYield = false;
            UseExplicitTypeParam = useExplicitTypeParam;

            SemanticInfo = sym;

            if (sym.IsGenericMethod) {
                foreach (var param in sym.TypeParameters) {
                    ParamNames.Add(param.Name);
                    GenericMethodTypeParamNames.Add(param.Name);
                }
            }

            if (UseExplicitTypeParam && (sym.MethodKind == MethodKind.Constructor || sym.IsStatic && sym.MethodKind != MethodKind.StaticConstructor && !SymbolTable.IsAccessorMethod(sym))) {
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
                    var arrTypeSym = param.Type as IArrayTypeSymbol;
                    if (null != arrTypeSym && arrTypeSym.ElementType.IsValueType) {
                        string ns = ClassInfo.GetNamespaces(arrTypeSym.ElementType);
                        if (arrTypeSym.ElementType.ContainingAssembly == assemblySym)
                            ParamsIsValueType = true;
                        else if (ns != "System") {
                            ParamsIsExternValueType = true;
                        }

                    }
                    ParamNames.Add("...");
                    OriginalParamsName = param.Name;
                    //遇到变参直接结束（变参set_Item会出现后面带一个value参数的情形，在函数实现里处理）
                    break;
                } else if (param.RefKind == RefKind.Ref) {
                    ParamNames.Add(param.Name);
                    RefParamNames.Add(param.Name);
                    ReturnParamNames.Add(param.Name);
                } else if (param.RefKind == RefKind.Out) {
                    OutParamNames.Add(param.Name);
                    ReturnParamNames.Add(param.Name);
                } else {
                    if (param.Type.IsValueType) {
                        string ns = ClassInfo.GetNamespaces(param.Type);
                        if (param.Type.ContainingAssembly == assemblySym)
                            ValueParams.Add(ParamNames.Count);
                        else if (ns != "System")
                            ExternValueParams.Add(ParamNames.Count);
                    }
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
}