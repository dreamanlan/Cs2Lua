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
    /// <summary>
    /// 用于翻译方法定义的信息。
    /// </summary>
    internal class MethodInfo
    {
        internal List<string> ParamNames = new List<string>();
        internal List<string> ParamTypes = new List<string>();
        internal List<string> ParamTypeKinds = new List<string>();
        internal List<string> ReturnParamNames = new List<string>();
        internal HashSet<int> ValueParams = new HashSet<int>();
        internal HashSet<int> ExternValueParams = new HashSet<int>();
        internal HashSet<int> OutValueParams = new HashSet<int>();
        internal HashSet<int> OutExternValueParams = new HashSet<int>();
        internal string OriginalParamsName = string.Empty;
        internal string ParamsElementInfo = string.Empty;
        internal bool ExistYield = false;
        internal bool ExistTopLevelReturn = false;
        internal bool NeedFuncInfo = false;
        internal int ReturnValueCount = 0;

        internal bool ExistTry = false;
        internal bool ExistUsing = false;
        internal int TryUsingLayer = 0;
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
            OriginalParamsName = string.Empty;
            ExistYield = false;
            ExistTopLevelReturn = false;

            ExistTry = false;
            TryUsingLayer = 0;
            ReturnVarName = string.Empty;

            SemanticInfo = sym;
            SyntaxNode = node;

            if (!sym.IsExtensionMethod && sym.IsGenericMethod) {
                //不是扩展方法，泛型参数放在参数表最前面
                foreach (var param in sym.TypeParameters) {
                    ParamNames.Add(param.Name);
                    ParamTypes.Add("null");
                    ParamTypeKinds.Add("TypeKind." + param.TypeKind.ToString());
                }
            }

            bool first = true;
            foreach (var param in sym.Parameters) {
                if (param.IsParams) {
                    var arrTypeSym = param.Type as IArrayTypeSymbol;
                    if (null != arrTypeSym) {
                        string elementType = ClassInfo.GetFullName(arrTypeSym.ElementType);
                        string elementTypeKind = "TypeKind." + arrTypeSym.ElementType.TypeKind.ToString();
                        ParamsElementInfo = string.Format("{0}, {1}", elementType, elementTypeKind);
                        if (arrTypeSym.ElementType.IsValueType && !SymbolTable.IsBasicType(arrTypeSym.ElementType) && !CsDslTranslater.IsImplementationOfSys(arrTypeSym.ElementType, "IEnumerator")) {
                            string ns = ClassInfo.GetNamespaces(arrTypeSym.ElementType);
                            if (SymbolTable.Instance.IsCs2DslSymbol(arrTypeSym.ElementType))
                                NeedFuncInfo = true;
                            else if (ns != "System")
                                NeedFuncInfo = true;
                        }
                    }
                    ParamNames.Add("...");
                    ParamTypes.Add(ClassInfo.GetFullName(param.Type));
                    ParamTypeKinds.Add("TypeKind." + param.Type.TypeKind.ToString());
                    OriginalParamsName = param.Name;
                    //遇到变参直接结束（变参set_Item会出现后面带一个value参数的情形，在函数实现里处理）
                    break;
                }
                else if (param.RefKind == RefKind.Ref) {
                    if (param.Type.IsValueType && !SymbolTable.IsBasicType(param.Type) && !CsDslTranslater.IsImplementationOfSys(param.Type, "IEnumerator")) {
                        string ns = ClassInfo.GetNamespaces(param.Type);
                        if (SymbolTable.Instance.IsCs2DslSymbol(param.Type)) {
                            ValueParams.Add(ParamNames.Count);
                            NeedFuncInfo = true;
                        }
                        else if (ns != "System") {
                            ExternValueParams.Add(ParamNames.Count);
                            NeedFuncInfo = true;
                        }
                    }
                    //ref参数与out参数在形参处理时机制相同，实参时out参数传入__cs2dsl_out（适应脚本引擎与dotnet反射的调用规则）
                    ParamNames.Add(param.Name);
                    ParamTypes.Add(ClassInfo.GetFullName(param.Type));
                    ParamTypeKinds.Add("TypeKind." + param.Type.TypeKind.ToString());
                    ReturnParamNames.Add(param.Name);
                }
                else if (param.RefKind == RefKind.Out) {
                    if (param.Type.IsValueType && !SymbolTable.IsBasicType(param.Type) && !CsDslTranslater.IsImplementationOfSys(param.Type, "IEnumerator")) {
                        string ns = ClassInfo.GetNamespaces(param.Type);
                        if (SymbolTable.Instance.IsCs2DslSymbol(param.Type)) {
                            OutValueParams.Add(ParamNames.Count);
                            NeedFuncInfo = true;
                        }
                        else if (ns != "System") {
                            OutExternValueParams.Add(ParamNames.Count);
                            NeedFuncInfo = true;
                        }
                    }
                    //ref参数与out参数在形参处理时机制相同，实参时out参数传入__cs2dsl_out（适应脚本引擎与dotnet反射的调用规则）
                    ParamNames.Add(param.Name);
                    ParamTypes.Add(ClassInfo.GetFullName(param.Type));
                    ParamTypeKinds.Add("TypeKind." + param.Type.TypeKind.ToString());
                    ReturnParamNames.Add(param.Name);
                }
                else {
                    if (param.Type.IsValueType && !SymbolTable.IsBasicType(param.Type) && !CsDslTranslater.IsImplementationOfSys(param.Type, "IEnumerator")) {
                        string ns = ClassInfo.GetNamespaces(param.Type);
                        if (SymbolTable.Instance.IsCs2DslSymbol(param.Type)) {
                            ValueParams.Add(ParamNames.Count);
                            NeedFuncInfo = true;
                        }
                        else if (ns != "System") {
                            ExternValueParams.Add(ParamNames.Count);
                            NeedFuncInfo = true;
                        }
                    }
                    ParamNames.Add(param.Name);
                    ParamTypes.Add(ClassInfo.GetFullName(param.Type));
                    ParamTypeKinds.Add("TypeKind." + param.Type.TypeKind.ToString());
                }
                if (first && sym.IsExtensionMethod && sym.IsGenericMethod) {
                    //扩展方法的泛型参数放在第一个参数后
                    foreach (var tp in sym.TypeParameters) {
                        ParamNames.Add(tp.Name);
                        ParamTypes.Add("null");
                        ParamTypeKinds.Add("TypeKind." + tp.TypeKind.ToString());
                    }
                }
                first = false;
            }

            if (!sym.ReturnsVoid) {
                var returnType = ClassInfo.GetFullName(sym.ReturnType);
                if (returnType.StartsWith("System.Collections") && (sym.ReturnType.Name == "IEnumerable" || sym.ReturnType.Name == "IEnumerator")) {
                    var analysis = new YieldAnalysis();
                    analysis.Visit(node);
                    ExistYield = analysis.YieldCount > 0;
                }
            }

            ReturnValueCount = ReturnParamNames.Count + (sym.ReturnsVoid ? 0 : 1);
        }
    }
}