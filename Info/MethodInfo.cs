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
        internal List<string> OutParamNames = new List<string>();
        internal HashSet<int> ValueParams = new HashSet<int>();
        internal HashSet<int> ExternValueParams = new HashSet<int>();
        internal List<string> GenericTypeTypeParamNames = new List<string>();
        internal List<string> GenericMethodTypeParamNames = new List<string>();
        internal string OriginalParamsName = string.Empty;
        internal bool ParamsIsValueType = false;
        internal bool ParamsIsExternValueType = false;
        internal bool ExistYield = false;
        internal bool ExistTopLevelReturn = false;

        internal bool ExistTryCatch = false;
        internal int TryCatchLayer = 0;
        internal string ReturnVarName = string.Empty;

        internal IMethodSymbol SemanticInfo = null;
        internal IPropertySymbol PropertySemanticInfo = null;

        internal void Init(IMethodSymbol sym, SyntaxNode node)
        {
            ParamNames.Clear();
            ReturnParamNames.Clear();
            OutParamNames.Clear();
            OriginalParamsName = string.Empty;
            ExistYield = false;
            ExistTopLevelReturn = false;

            ExistTryCatch = false;
            TryCatchLayer = 0;
            ReturnVarName = string.Empty;

            SemanticInfo = sym;

            if (sym.IsGenericMethod) {
                foreach (var param in sym.TypeParameters) {
                    ParamNames.Add(param.Name);
                    GenericMethodTypeParamNames.Add(param.Name);
                }
            }

            foreach (var param in sym.Parameters) {
                if (param.IsParams) {
                    var arrTypeSym = param.Type as IArrayTypeSymbol;
                    if (null != arrTypeSym && arrTypeSym.ElementType.TypeKind == TypeKind.Struct) {
                        string ns = ClassInfo.GetNamespaces(arrTypeSym.ElementType);
                        if (SymbolTable.Instance.IsCs2LuaSymbol(arrTypeSym.ElementType))
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
                    ReturnParamNames.Add(param.Name);
                } else if (param.RefKind == RefKind.Out) {
                    //实参时out参数传入__cs2lua_out（适应slua与dotnet反射的调用规则，xlua忽略out参数）
                    if (!SymbolTable.ForXlua) {
                        ParamNames.Add(param.Name);
                    }
                    ReturnParamNames.Add(param.Name);
                    OutParamNames.Add(param.Name);
                } else {
                    if (param.Type.TypeKind == TypeKind.Struct) {
                        string ns = ClassInfo.GetNamespaces(param.Type);
                        if (SymbolTable.Instance.IsCs2LuaSymbol(param.Type))
                            ValueParams.Add(ParamNames.Count);
                        else if (ns != "System")
                            ExternValueParams.Add(ParamNames.Count);
                    }
                    ParamNames.Add(param.Name);
                }
            }
            
            if (!sym.ReturnsVoid) {
                var returnType = ClassInfo.GetFullName(sym.ReturnType);
                if (returnType.StartsWith(SymbolTable.PrefixExternClassName("System.Collections")) && (sym.ReturnType.Name == "IEnumerable" || sym.ReturnType.Name == "IEnumerator")) {
                    var analysis = new YieldAnalysis();
                    analysis.Visit(node);
                    ExistYield = analysis.YieldCount > 0;
                }
            }
        }
    }
}