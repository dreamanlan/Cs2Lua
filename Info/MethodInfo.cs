using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Operations;

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
        internal List<int> ParamRefOrOuts = new List<int>();
        internal List<bool> ParamIsExterns = new List<bool>();
        internal List<string> ReturnParamNames = new List<string>();
        internal List<string> ReturnParamTypes = new List<string>();
        internal List<string> ReturnParamTypeKinds = new List<string>();
        internal List<int> ReturnParamRefOrOuts = new List<int>();
        internal List<bool> ReturnParamIsExterns = new List<bool>();
        internal HashSet<int> OutValueParams = new HashSet<int>();
        internal HashSet<int> OutExternValueParams = new HashSet<int>();
        internal string OriginalParamsName = string.Empty;
        internal string ParamsElementInfo = string.Empty;
        internal bool ExistYield = false;
        internal bool ExistTopLevelReturn = false;
        internal bool NeedFuncInfo = false;
        internal int ReturnValueCount = 0;
        internal string FunctionOptions = string.Empty;

        internal bool IsAnonymousOrLambdaMethod = false;
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
            IsAnonymousOrLambdaMethod = node is SimpleLambdaExpressionSyntax || node is ParenthesizedLambdaExpressionSyntax || node is AnonymousMethodExpressionSyntax;
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
                    if (param.ConstraintTypes.Length > 0)
                        ParamTypes.Add(ClassInfo.GetFullName(param.ConstraintTypes[0]));
                    else if (param.HasReferenceTypeConstraint)
                        ParamTypes.Add("System.Object");
                    else if (param.HasValueTypeConstraint)
                        ParamTypes.Add("System.ValueType");
                    else
                        ParamTypes.Add("null");
                    ParamTypeKinds.Add("TypeKind." + param.TypeKind.ToString());
                    ParamRefOrOuts.Add(0);
                    ParamIsExterns.Add(false);
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
                    }
                    ParamNames.Add("...");
                    ParamTypes.Add(ClassInfo.GetFullName(param.Type));
                    ParamTypeKinds.Add("TypeKind." + param.Type.TypeKind.ToString());
                    ParamRefOrOuts.Add(0);
                    ParamIsExterns.Add(!SymbolTable.Instance.IsCs2DslSymbol(param.Type));
                    OriginalParamsName = param.Name;
                    //遇到变参直接结束（变参set_Item会出现后面带一个value参数的情形，在函数实现里处理）
                    break;
                }
                else if (param.RefKind == RefKind.Ref) {
                    //ref参数与out参数在形参处理时机制相同，实参时out参数传入__cs2dsl_out（适应脚本引擎与dotnet反射的调用规则）
                    var fn = ClassInfo.GetFullName(param.Type);
                    ParamNames.Add(param.Name);
                    ParamTypes.Add(fn);
                    ParamTypeKinds.Add("TypeKind." + param.Type.TypeKind.ToString());
                    ParamRefOrOuts.Add(1);
                    ParamIsExterns.Add(!SymbolTable.Instance.IsCs2DslSymbol(param.Type));
                    ReturnParamNames.Add(param.Name);
                    ReturnParamTypes.Add(fn);
                    ReturnParamTypeKinds.Add("TypeKind." + param.Type.TypeKind.ToString());
                    ReturnParamRefOrOuts.Add(1);
                    ReturnParamIsExterns.Add(!SymbolTable.Instance.IsCs2DslSymbol(param.Type));
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
                    var fn = ClassInfo.GetFullName(param.Type);
                    ParamNames.Add(param.Name);
                    ParamTypes.Add(fn);
                    ParamTypeKinds.Add("TypeKind." + param.Type.TypeKind.ToString());
                    ParamRefOrOuts.Add(2);
                    ParamIsExterns.Add(!SymbolTable.Instance.IsCs2DslSymbol(param.Type));
                    ReturnParamNames.Add(param.Name);
                    ReturnParamTypes.Add(fn);
                    ReturnParamTypeKinds.Add("TypeKind." + param.Type.TypeKind.ToString());
                    ReturnParamRefOrOuts.Add(2);
                    ReturnParamIsExterns.Add(!SymbolTable.Instance.IsCs2DslSymbol(param.Type));
                }
                else {
                    ParamNames.Add(param.Name);
                    ParamTypes.Add(ClassInfo.GetFullName(param.Type));
                    ParamTypeKinds.Add("TypeKind." + param.Type.TypeKind.ToString());
                    ParamRefOrOuts.Add(0);
                    ParamIsExterns.Add(!SymbolTable.Instance.IsCs2DslSymbol(param.Type));
                }
                if (first && sym.IsExtensionMethod && sym.IsGenericMethod) {
                    //扩展方法的泛型参数放在第一个参数后
                    foreach (var tp in sym.TypeParameters) {
                        ParamNames.Add(tp.Name);
                        if (tp.ConstraintTypes.Length > 0)
                            ParamTypes.Add(ClassInfo.GetFullName(tp.ConstraintTypes[0]));
                        else if (tp.HasReferenceTypeConstraint)
                            ParamTypes.Add("System.Object");
                        else if (tp.HasValueTypeConstraint)
                            ParamTypes.Add("System.ValueType");
                        else
                            ParamTypes.Add("null");
                        ParamTypeKinds.Add("TypeKind." + tp.TypeKind.ToString());
                        ParamRefOrOuts.Add(0);
                        ParamIsExterns.Add(!SymbolTable.Instance.IsCs2DslSymbol(param.Type));
                    }
                }
                first = false;
            }

            if (!sym.ReturnsVoid) {
                string returnType = ClassInfo.GetFullName(sym.ReturnType);
                if (returnType.StartsWith("System.Collections") && (sym.ReturnType.Name == "IEnumerable" || sym.ReturnType.Name == "IEnumerator")) {
                    var analysis = new YieldAnalysis();
                    analysis.Visit(node);
                    ExistYield = analysis.YieldCount > 0;
                }
            }

            ReturnValueCount = ReturnParamNames.Count + (sym.ReturnsVoid ? 0 : 1);
            if (!NeedFuncInfo && ClassInfo.HasAttribute(sym, "Cs2Dsl.NeedFuncInfoAttribute")) {
                NeedFuncInfo = true;
            }
        }

        internal string CalcFunctionOptions()
        {
            if (string.IsNullOrEmpty(FunctionOptions)) {
                string returnName = "return";
                string returnType;
                string returnTypeKind;
                bool returnTypeIsExtern = false;
                if (SemanticInfo.ReturnsVoid) {
                    returnType = "System.Void";
                    returnTypeKind = "TypeKind.Unknown";
                }
                else {
                    returnType = ClassInfo.GetFullName(SemanticInfo.ReturnType);
                    if (SemanticInfo.ReturnType.TypeKind == TypeKind.TypeParameter) {
                        var retTypeParam = SemanticInfo.ReturnType as ITypeParameterSymbol;
                        if (null != retTypeParam && retTypeParam.ConstraintTypes.Length > 0) {
                            returnName = returnType;
                            returnType = ClassInfo.GetFullName(retTypeParam.ConstraintTypes[0]);
                        }
                    }
                    if (string.IsNullOrEmpty(returnType))
                        returnType = "null";
                    returnTypeKind = "TypeKind." + SemanticInfo.ReturnType.TypeKind.ToString();
                    returnTypeIsExtern = !SymbolTable.Instance.IsCs2DslSymbol(SemanticInfo.ReturnType);
                }

                var sb = new StringBuilder();
                sb.AppendFormat("needfuncinfo({0}), rettype({1}, {2}, {3}, 0, {4})", NeedFuncInfo ? "true" : "false", returnName, returnType, returnTypeKind, returnTypeIsExtern ? "true" : "false");
                for (int ix = 0; ix < ReturnParamNames.Count; ++ix) {
                    var name = ReturnParamNames[ix];
                    var type = ReturnParamTypes[ix];
                    if (string.IsNullOrEmpty(type))
                        type = "null";
                    var typekind = ReturnParamTypeKinds[ix];
                    var refOrOut = ReturnParamRefOrOuts[ix];
                    var isExtern = ReturnParamIsExterns[ix];
                    sb.Append(", ");
                    sb.AppendFormat("rettype({0}, {1}, {2}, {3}, {4})", name, type, typekind, refOrOut, isExtern ? "true" : "false");
                }
                for (int ix = 0; ix < ParamNames.Count; ++ix) {
                    var name = ParamNames[ix];
                    var type = ParamTypes[ix];
                    if (string.IsNullOrEmpty(type))
                        type = "null";
                    var typekind = ParamTypeKinds[ix];
                    var refOrOut = ParamRefOrOuts[ix];
                    var isExtern = ParamIsExterns[ix];
                    sb.Append(", ");
                    sb.AppendFormat("paramtype({0}, {1}, {2}, {3}, {4})", name, type, typekind, refOrOut, isExtern ? "true" : "false");
                }
                FunctionOptions = sb.ToString();
            }
            return FunctionOptions;
        }

        internal string CalcTryUsingFuncInfo(DataFlowAnalysis dataFlow, ControlFlowAnalysis ctrlFlow, out List<string> inputs, out List<string> outputs, out string paramsStr)
        {
            var sbIn = new StringBuilder();
            var sbOut = new StringBuilder();
            inputs = new List<string>();
            outputs = new List<string>();
            string prestrIn = string.Empty;
            string prestrOut = string.Empty;
            if (ctrlFlow.ReturnStatements.Length > 0 && !string.IsNullOrEmpty(ReturnVarName)) {
                sbIn.Append(ReturnVarName);
                prestrIn = ", ";
                sbOut.Append(ReturnVarName);
                prestrOut = ", ";
            }
            foreach (var v in dataFlow.DataFlowsIn) {
                if (v.Name == "this")
                    continue;
                inputs.Add(v.Name);
                sbIn.Append(prestrIn);
                sbIn.Append(v.Name);
                prestrIn = ", ";
            }
            foreach (var v in dataFlow.DataFlowsOut) {
                outputs.Add(v.Name);
                if (!inputs.Contains(v.Name)) {
                    sbIn.Append(prestrIn);
                    sbIn.Append(v.Name);
                    prestrIn = ", ";
                }
                sbOut.Append(prestrOut);
                sbOut.Append(v.Name);
                prestrOut = ", ";
            }
            paramsStr = sbIn.ToString();
            return sbOut.ToString();
        }

        internal string CalcTryUsingFuncOptions(DataFlowAnalysis dataFlow, ControlFlowAnalysis ctrlFlow, List<string> inputs, List<string> outputs)
        {
            string returnType = "System.Int32";
            string returnTypeKind = "TypeKind.Struct";
            bool returnTypeIsExtern = false;

            var sb = new StringBuilder();
            sb.AppendFormat("needfuncinfo({0}), rettype(return, {1}, {2}, 0, true)", NeedFuncInfo ? "true" : "false", returnType, returnTypeKind);
            if (ctrlFlow.ReturnStatements.Length > 0 && !string.IsNullOrEmpty(ReturnVarName)) {
                returnType = ClassInfo.GetFullName(SemanticInfo.ReturnType);
                if (string.IsNullOrEmpty(returnType))
                    returnType = "null";
                returnTypeKind = "TypeKind." + SemanticInfo.ReturnType.TypeKind.ToString();
                returnTypeIsExtern = !SymbolTable.Instance.IsCs2DslSymbol(SemanticInfo.ReturnType);
                sb.Append(", ");
                sb.AppendFormat("rettype({0}, {1}, {2}, 1, {3})", ReturnVarName, returnType, returnTypeKind, returnTypeIsExtern ? "true" : "false");
            }
            foreach (var v in dataFlow.DataFlowsOut) {
                sb.Append(", ");
                int refOrOut = 2;
                if (inputs.Contains(v.Name)) {
                    refOrOut = 1;
                }
                var psym = v as IParameterSymbol;
                var lsym = v as ILocalSymbol;
                if (null != psym) {
                    var type = ClassInfo.GetFullName(psym.Type);
                    var typeKind = psym.Type.TypeKind.ToString();
                    bool isExtern = !SymbolTable.Instance.IsCs2DslSymbol(psym.Type);
                    if (string.IsNullOrEmpty(type))
                        type = "null";
                    sb.AppendFormat("rettype({0}, {1}, {2}, {3}, {4})", v.Name, type, typeKind, refOrOut, isExtern ? "true" : "false");
                }
                else if (null != lsym) {
                    var type = ClassInfo.GetFullName(lsym.Type);
                    var typeKind = lsym.Type.TypeKind.ToString();
                    bool isExtern = !SymbolTable.Instance.IsCs2DslSymbol(lsym.Type);
                    if (string.IsNullOrEmpty(type))
                        type = "null";
                    sb.AppendFormat("rettype({0}, {1}, {2}, {3}, {4})", v.Name, type, typeKind, refOrOut, isExtern ? "true" : "false");
                }
            }
            if (ctrlFlow.ReturnStatements.Length > 0 && !string.IsNullOrEmpty(ReturnVarName)) {
                sb.Append(", ");
                sb.AppendFormat("paramtype({0}, {1}, {2}, 1, {3})", ReturnVarName, returnType, returnTypeKind, returnTypeIsExtern ? "true" : "false");
            }
            foreach (var v in dataFlow.DataFlowsIn) {
                if (v.Name == "this")
                    continue;
                sb.Append(", ");
                int refOrOut = 0;
                if (outputs.Contains(v.Name)) {
                    refOrOut = 1;
                }
                var psym = v as IParameterSymbol;
                var lsym = v as ILocalSymbol;
                if (null != psym) {
                    var type = ClassInfo.GetFullName(psym.Type);
                    var typeKind = psym.Type.TypeKind.ToString();
                    bool isExtern = !SymbolTable.Instance.IsCs2DslSymbol(psym.Type);
                    if (string.IsNullOrEmpty(type))
                        type = "null";
                    sb.AppendFormat("paramtype({0}, {1}, {2}, {3}, {4})", v.Name, type, typeKind, refOrOut, isExtern ? "true" : "false");
                }
                else if (null != lsym) {
                    var type = ClassInfo.GetFullName(lsym.Type);
                    var typeKind = lsym.Type.TypeKind.ToString();
                    bool isExtern = !SymbolTable.Instance.IsCs2DslSymbol(lsym.Type);
                    if (string.IsNullOrEmpty(type))
                        type = "null";
                    sb.AppendFormat("paramtype({0}, {1}, {2}, {3}, {4})", v.Name, type, typeKind, refOrOut, isExtern ? "true" : "false");
                }
            }
            foreach (var v in dataFlow.DataFlowsOut) {
                sb.Append(", ");
                int refOrOut = 2;
                if (inputs.Contains(v.Name)) {
                    refOrOut = 1;
                }
                var psym = v as IParameterSymbol;
                var lsym = v as ILocalSymbol;
                if (null != psym) {
                    var type = ClassInfo.GetFullName(psym.Type);
                    var typeKind = psym.Type.TypeKind.ToString();
                    bool isExtern = !SymbolTable.Instance.IsCs2DslSymbol(psym.Type);
                    if (string.IsNullOrEmpty(type))
                        type = "null";
                    sb.AppendFormat("paramtype({0}, {1}, {2}, {3}, {4})", v.Name, type, typeKind, refOrOut, isExtern ? "true" : "false");
                }
                else if (null != lsym) {
                    var type = ClassInfo.GetFullName(lsym.Type);
                    var typeKind = lsym.Type.TypeKind.ToString();
                    bool isExtern = !SymbolTable.Instance.IsCs2DslSymbol(lsym.Type);
                    if (string.IsNullOrEmpty(type))
                        type = "null";
                    sb.AppendFormat("paramtype({0}, {1}, {2}, {3}, {4})", v.Name, type, typeKind, refOrOut, isExtern ? "true" : "false");
                }
            }
            return sb.ToString();
        }
    }
}