using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Semantics;

namespace RoslynTool.CsToDsl
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
        internal bool ExistUsing = false;
        internal int TryCatchUsingLayer = 0;
        internal string ReturnVarName = string.Empty;
        internal Stack<bool> TryCatchUsingOrLoopSwitchStack = new Stack<bool>();

        internal IMethodSymbol SemanticInfo = null;
        internal SyntaxNode SyntaxNode = null;

        internal Stack<ReturnContinueBreakAnalysis> TempReturnAnalysisStack = new Stack<ReturnContinueBreakAnalysis>();

        internal void Init(IMethodSymbol sym, SyntaxNode node)
        {
            TryCatchUsingOrLoopSwitchStack.Clear();
            TempReturnAnalysisStack.Clear();

            ParamNames.Clear();
            ReturnParamNames.Clear();
            OutParamNames.Clear();
            OriginalParamsName = string.Empty;
            ExistYield = false;
            ExistTopLevelReturn = false;

            ExistTryCatch = false;
            TryCatchUsingLayer = 0;
            ReturnVarName = string.Empty;

            SemanticInfo = sym;
            SyntaxNode = node;

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
                        if (SymbolTable.Instance.IsCs2DslSymbol(arrTypeSym.ElementType))
                            ParamsIsValueType = true;
                        else if (ns != "System") {
                            ParamsIsExternValueType = true;
                        }

                    }
                    ParamNames.Add("...");
                    OriginalParamsName = param.Name;
                    //遇到变参直接结束（变参set_Item会出现后面带一个value参数的情形，在函数实现里处理）
                    break;
                }
                else if (param.RefKind == RefKind.Ref) {
                    //ref参数与out参数在形参处理时机制相同，实参时out参数传入__cs2dsl_out（适应脚本引擎与dotnet反射的调用规则）
                    ParamNames.Add(string.Format("ref({0})", param.Name));
                    ReturnParamNames.Add(param.Name);
                }
                else if (param.RefKind == RefKind.Out) {
                    //ref参数与out参数在形参处理时机制相同，实参时out参数传入__cs2dsl_out（适应脚本引擎与dotnet反射的调用规则）
                    ParamNames.Add(string.Format("out({0})", param.Name));
                    ReturnParamNames.Add(param.Name);
                    OutParamNames.Add(param.Name);
                }
                else {
                    if (param.Type.TypeKind == TypeKind.Struct) {
                        string ns = ClassInfo.GetNamespaces(param.Type);
                        if (SymbolTable.Instance.IsCs2DslSymbol(param.Type))
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