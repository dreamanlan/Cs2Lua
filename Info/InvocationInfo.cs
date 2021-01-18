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
    /// 用于翻译方法调用的信息。
    /// </summary>
    internal class ArgDefaultValueInfo
    {
        internal object Value;
        internal ITypeSymbol Type;
        internal IOperation Operation;
        internal ISymbol Symbol;
        internal ExpressionSyntax Expression;
    }
    internal class InvocationInfo
    {
        internal string ClassKey = string.Empty;
        internal string GenericClassKey = string.Empty;
        internal List<ExpressionSyntax> Args = new List<ExpressionSyntax>();
        internal List<ITypeSymbol> ArgTypes = new List<ITypeSymbol>();
        internal List<IOperation> ArgOperations = new List<IOperation>();
        internal List<ISymbol> ArgSymbols = new List<ISymbol>();
        internal HashSet<int> DslToObjectArgs = new HashSet<int>();
        internal List<IConversionOperation> ArgConversions = new List<IConversionOperation>();
        internal List<ArgDefaultValueInfo> NameOrDefaultValueArgs = new List<ArgDefaultValueInfo>();
        internal HashSet<int> DslToObjectDefArgs = new HashSet<int>();
        internal List<ExpressionSyntax> ReturnArgs = new List<ExpressionSyntax>();
        internal List<bool> ReturnValueArgFlags = new List<bool>();
        internal List<ITypeSymbol> ReturnArgTypes = new List<ITypeSymbol>();
        internal List<IOperation> ReturnArgOperations = new List<IOperation>();
        internal List<ISymbol> ReturnArgSymbols = new List<ISymbol>();
        internal List<ITypeSymbol> GenericTypeArgs = new List<ITypeSymbol>();
        internal bool ArrayToParams = false;
        internal bool PostPositionGenericTypeArgs = false;
        internal bool IsEnumClass = false;
        internal bool IsExtensionMethod = false;
        internal bool IsComponentGetOrAdd = false;
        internal bool IsBasicValueMethod = false;
        internal bool IsArrayStaticMethod = false;
        internal bool IsExternMethod = false;
        internal string ExternOverloadedMethodSignature = string.Empty;
        internal ExpressionSyntax FirstRefArray = null;
        internal ExpressionSyntax SecondRefArray = null;

        internal IMethodSymbol MethodSymbol = null;
        internal IMethodSymbol NonGenericMethodSymbol = null;
        internal IMethodSymbol CallerMethodSymbol = null;
        internal SyntaxNode CallerSyntaxNode = null;
        internal SemanticModel Model = null;

        internal InvocationInfo()
        {
        }
        internal InvocationInfo(IMethodSymbol caller, SyntaxNode node)
        {
            CallerMethodSymbol = caller;
            CallerSyntaxNode = node;
        }

        internal void Init(IMethodSymbol sym, SemanticModel model)
        {
            MethodSymbol = sym;
            Model = model;

            Args.Clear();
            ArgTypes.Clear();
            DslToObjectArgs.Clear();
            ArgConversions.Clear();
            NameOrDefaultValueArgs.Clear();
            DslToObjectDefArgs.Clear();
            ReturnArgs.Clear();
            ReturnValueArgFlags.Clear();
            ReturnArgTypes.Clear();
            ReturnArgSymbols.Clear();
            GenericTypeArgs.Clear();

            ClassKey = ClassInfo.GetFullName(sym.ContainingType);
            GenericClassKey = ClassInfo.GetFullNameWithTypeParameters(sym.ContainingType);
            IsEnumClass = sym.ContainingType.TypeKind == TypeKind.Enum || ClassKey == "System.Enum";
            IsExtensionMethod = sym.IsExtensionMethod;
            IsBasicValueMethod = SymbolTable.IsBasicValueMethod(sym);
            IsArrayStaticMethod = ClassKey == "System.Array" && sym.IsStatic;
            IsExternMethod = !SymbolTable.Instance.IsCs2DslSymbol(sym);

            if ((ClassKey == "UnityEngine.GameObject" || ClassKey == "UnityEngine.Component") && (sym.Name.StartsWith("GetComponent") || sym.Name.StartsWith("AddComponent"))) {
                IsComponentGetOrAdd = true;
            }

            NonGenericMethodSymbol = null;
            PostPositionGenericTypeArgs = false;
            ExternOverloadedMethodSignature = string.Empty;
            if (IsExternMethod) {
                var syms = sym.ContainingType.GetMembers(sym.Name);
                if (sym.IsGenericMethod) {
                    bool existNonGenericVersion = false;
                    if (null != syms) {
                        //寻找匹配的非泛型版本
                        foreach (var isym in syms) {
                            var msym = isym as IMethodSymbol;
                            if (null != msym && !msym.IsGenericMethod && msym.Parameters.Length == sym.Parameters.Length + sym.TypeParameters.Length) {
                                existNonGenericVersion = true;
                                for (int i = 0; i < sym.TypeParameters.Length; ++i) {
                                    var psym = msym.Parameters[i];
                                    if (psym.Type.Name != "Type") {
                                        existNonGenericVersion = false;
                                        break;
                                    }
                                }
                                for (int i = 0; i < sym.Parameters.Length; ++i) {
                                    var psym1 = msym.Parameters[i + sym.TypeParameters.Length];
                                    var psym2 = sym.Parameters[i];
                                    if (psym1.Type.Name != psym2.Type.Name && psym2.OriginalDefinition.Type.TypeKind != TypeKind.TypeParameter) {
                                        existNonGenericVersion = false;
                                        break;
                                    }
                                }
                                if (existNonGenericVersion) {
                                    NonGenericMethodSymbol = msym;
                                    PostPositionGenericTypeArgs = false;
                                }
                                else {
                                    existNonGenericVersion = true;
                                    for (int i = 0; i < sym.Parameters.Length; ++i) {
                                        var psym1 = msym.Parameters[i];
                                        var psym2 = sym.Parameters[i];
                                        if (psym1.Type.Name != psym2.Type.Name && psym2.OriginalDefinition.Type.TypeKind != TypeKind.TypeParameter) {
                                            existNonGenericVersion = false;
                                            break;
                                        }
                                    }
                                    for (int i = 0; i < sym.TypeParameters.Length; ++i) {
                                        var psym = msym.Parameters[i + sym.Parameters.Length];
                                        if (psym.Type.Name != "Type") {
                                            existNonGenericVersion = false;
                                            break;
                                        }
                                    }
                                    if (existNonGenericVersion) {
                                        NonGenericMethodSymbol = msym;
                                        PostPositionGenericTypeArgs = true;
                                    }
                                }
                                if (existNonGenericVersion)
                                    break;
                            }
                        }

                        if (!existNonGenericVersion) {
                            //寻找匹配的变参版本
                            foreach (var isym in syms) {
                                var msym = isym as IMethodSymbol;
                                if (null != msym && !msym.IsGenericMethod && msym.Parameters.Length > 0 && msym.Parameters.Length <= sym.Parameters.Length) {
                                    bool existParamsVersion = true;
                                    var lastPsym = msym.Parameters[msym.Parameters.Length - 1];
                                    if (lastPsym.IsParams) {
                                        for (int i = 0; i < msym.Parameters.Length; ++i) {
                                            var psym1 = msym.Parameters[i];
                                            var psym2 = sym.Parameters[i];
                                            if (i < msym.Parameters.Length - 1 && psym1.Type.Name != psym2.Type.Name) {
                                                existParamsVersion = false;
                                                break;
                                            }
                                        }
                                    }
                                    if (existParamsVersion) {
                                        NonGenericMethodSymbol = msym;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    if (existNonGenericVersion) {
                        foreach (var arg in sym.TypeArguments) {
                            GenericTypeArgs.Add(arg);
                        }
                    }
                    else {
                        //没有找到参数匹配的非泛型版本，则不传递泛型参数类型
                        //这样处理可以适应2类可能有效的情形：
                        //1、如果有多个重载函数，其中有一个object类型变参，则其他泛型参数版本会适配到这个非泛型变参版本
                        //2、有一些方法不需要明确传递泛型参数类型（比如普通实参可推导出泛型参数类型并且泛型参数类型在函数中不明确使用）
                    }
                }

                if (null != syms) {
                    int mcount = 0;
                    if (sym.MethodKind == MethodKind.Constructor && sym.ContainingType.IsValueType) {
                        //值类型构造总是按重载处理，默认构造总是会生成
                        mcount = 2;
                    }
                    else {
                        foreach (var isym in syms) {
                            var msym = isym as IMethodSymbol;
                            if (msym.Parameters.Length == 0) {
                                if (msym.Name == "GetType")
                                    continue;
                                if (msym.Name == "GetHashCode")
                                    continue;
                            }
                            var fn = ClassInfo.GetFullName(msym.ContainingType);
                            if (null != msym && msym.IsStatic == sym.IsStatic && msym.DeclaredAccessibility == Accessibility.Public && !msym.IsImplicitlyDeclared && !msym.IsGenericMethod && !ClassInfo.HasAttribute(msym, "System.ObsoleteAttribute")) {
                                bool existPointer = false;
                                foreach (var partype in msym.Parameters) {
                                    if (partype.Type.TypeKind == TypeKind.Pointer) {
                                        existPointer = true;
                                        break;
                                    }
                                }
                                if (!existPointer) {
                                    ++mcount;
                                }
                            }
                        }
                    }
                    if (mcount > 1) {
                        ExternOverloadedMethodSignature = SymbolTable.CalcExternOverloadedMethodSignature(sym, NonGenericMethodSymbol);
                    }
                }
                SymbolTable.Instance.TryAddExternReference(sym);
                if (!sym.ReturnsVoid) {
                    SymbolTable.Instance.TryAddExternReference(sym.ReturnType);
                }
                foreach (var p in sym.Parameters) {
                    if (p.Kind != SymbolKind.TypeParameter) {
                        SymbolTable.Instance.TryAddExternReference(p.Type);
                    }
                }
            }
            else if (sym.IsGenericMethod) {
                foreach (var arg in sym.TypeArguments) {
                    GenericTypeArgs.Add(arg);
                }
            }
            if (sym.IsGenericMethod) {
                foreach (var t in sym.TypeArguments) {
                    if (t.TypeKind != TypeKind.TypeParameter) {
                        SymbolTable.Instance.TryAddExternReference(t);
                    }
                }
            }
        }
        internal void Init(IMethodSymbol sym, ArgumentListSyntax argList, SemanticModel model)
        {
            Init(sym, model);

            if (null != argList) {
                var moper = model.GetOperationEx(argList) as IInvocationOperation;
                var args = argList.Arguments;

                Dictionary<string, ExpressionSyntax> namedArgs = new Dictionary<string, ExpressionSyntax>();
                int ct = 0;
                for (int i = 0; i < args.Count; ++i) {
                    var arg = args[i];
                    var argSym = model.GetSymbolInfoEx(arg.Expression).Symbol;
                    var argOper = model.GetOperationEx(arg.Expression);
                    var argType = model.GetTypeInfoEx(arg.Expression).Type;
                    if (null == argType && null != argOper)
                        argType = argOper.Type;
                    TryAddExternEnum(IsEnumClass, argType, null);
                    if (null != arg.NameColon) {
                        namedArgs.Add(arg.NameColon.Name.Identifier.Text, arg.Expression);
                        continue;
                    }
                    if (null != argType) {
                        TryAddDslToObjectArg(ct, argType, i);
                    }
                    IConversionOperation lastConv = null;
                    if (ct < sym.Parameters.Length) {
                        var param = sym.Parameters[ct];
                        if (null != moper) {
                            var iarg = GetArgumentMatchingParameter(moper, param);
                            if (null != iarg) {
                                lastConv = iarg.Value as IConversionOperation;
                            }
                        }
                        if (!param.IsParams && param.Type.TypeKind == TypeKind.Array) {
                            RecordRefArray(arg.Expression);
                        }
                        if (param.RefKind == RefKind.Ref) {
                            Args.Add(arg.Expression);
                            ArgTypes.Add(argType);
                            ArgOperations.Add(argOper);
                            ArgSymbols.Add(argSym);
                            ReturnArgs.Add(arg.Expression);
                            ReturnArgTypes.Add(argType);
                            ReturnArgOperations.Add(argOper);
                            ReturnArgSymbols.Add(argSym);
                            if (null != argType && argType.IsValueType && !SymbolTable.IsBasicType(argType)) {
                                ReturnValueArgFlags.Add(true);
                            }
                            else {
                                ReturnValueArgFlags.Add(false);
                            }
                        }
                        else if (param.RefKind == RefKind.Out) {
                            //方法的out参数，为与脚本引擎的机制一致，在调用时传入__cs2dsl_out，这里用null标记一下，在实际输出参数时再变为__cs2dsl_out
                            Args.Add(null);
                            ArgTypes.Add(argType);
                            ArgOperations.Add(argOper);
                            ArgSymbols.Add(argSym);
                            ReturnArgs.Add(arg.Expression);
                            ReturnArgTypes.Add(argType);
                            ReturnArgOperations.Add(argOper);
                            ReturnArgSymbols.Add(argSym);
                            if (null != argType && argType.IsValueType && !SymbolTable.IsBasicType(argType)) {
                                ReturnValueArgFlags.Add(true);
                            }
                            else {
                                ReturnValueArgFlags.Add(false);
                            }
                        }
                        else if (param.IsParams) {
                            if (null != argType && argType.TypeKind == TypeKind.Array) {
                                ArrayToParams = true;
                            }
                            Args.Add(arg.Expression);
                            ArgTypes.Add(argType);
                            ArgOperations.Add(argOper);
                            ArgSymbols.Add(argSym);
                        }
                        else {
                            Args.Add(arg.Expression);
                            ArgTypes.Add(argType);
                            ArgOperations.Add(argOper);
                            ArgSymbols.Add(argSym);
                        }
                        ++ct;
                    }
                    else {
                        Args.Add(arg.Expression);
                        ArgTypes.Add(argType);
                        ArgOperations.Add(argOper);
                        ArgSymbols.Add(argSym);
                    }
                    ArgConversions.Add(lastConv);
                }
                for (int i = ct; i < sym.Parameters.Length; ++i) {
                    var param = sym.Parameters[i];
                    IConversionOperation lastConv = null;
                    if (null != moper) {
                        var iarg = GetArgumentMatchingParameter(moper, param);
                        if (null != iarg) {
                            lastConv = iarg.Value as IConversionOperation;
                        }
                    }
                    ArgConversions.Add(lastConv);
                    ExpressionSyntax expval;
                    if (namedArgs.TryGetValue(param.Name, out expval)) {
                        var argSym = model.GetSymbolInfoEx(expval).Symbol;
                        var argOper = model.GetOperationEx(expval);
                        var argType = model.GetTypeInfoEx(expval).Type;
                        if (null == argType && null != argOper)
                            argType = argOper.Type;
                        if (null != argType) {
                            TryAddDslToObjectDefArg(i, argType, i - ct);
                        }
                        NameOrDefaultValueArgs.Add(new ArgDefaultValueInfo { Expression = expval, Type = argType, Operation = argOper, Symbol = argSym });
                    }
                    else if (param.HasExplicitDefaultValue) {
                        var decl = param.DeclaringSyntaxReferences;
                        bool handled = false;
                        if (decl.Length >= 1) {
                            var node = param.DeclaringSyntaxReferences[0].GetSyntax() as ParameterSyntax;
                            if (null != node) {
                                var exp = node.Default.Value;
                                var tree = node.SyntaxTree;
                                var newModel = SymbolTable.Instance.Compilation.GetSemanticModel(tree, true);
                                if (null != newModel) {
                                    var argSym = newModel.GetSymbolInfoEx(exp).Symbol;
                                    var argOper = newModel.GetOperationEx(exp);
                                    var argType = newModel.GetTypeInfoEx(exp).Type;
                                    if (null == argType && null != argOper)
                                        argType = argOper.Type;
                                    if (null != argType) {
                                        TryAddDslToObjectDefArg(i, argType, i - ct);
                                    }
                                    NameOrDefaultValueArgs.Add(new ArgDefaultValueInfo { Value = param.ExplicitDefaultValue, Type = argType, Operation = argOper, Symbol = argSym });
                                    handled = true;
                                }
                            }
                        }
                        if (!handled) {
                            NameOrDefaultValueArgs.Add(new ArgDefaultValueInfo { Value = param.ExplicitDefaultValue, Type = null, Operation = null, Symbol = null });
                        }
                    }
                }
            }
        }
        internal void Init(IMethodSymbol sym, BracketedArgumentListSyntax argList, SemanticModel model)
        {
            Init(sym, model);

            if (null != argList) {
                var moper = model.GetOperationEx(argList) as IInvocationOperation;
                var args = argList.Arguments;

                Dictionary<string, ExpressionSyntax> namedArgs = new Dictionary<string, ExpressionSyntax>();
                int ct = 0;
                for (int i = 0; i < args.Count; ++i) {
                    var arg = args[i];
                    var argSym = model.GetSymbolInfoEx(arg.Expression).Symbol;
                    var argOper = model.GetOperationEx(arg.Expression);
                    var argType = model.GetTypeInfoEx(arg.Expression).Type;
                    if (null == argType && null != argOper)
                        argType = argOper.Type;
                    TryAddExternEnum(IsEnumClass, argType, argOper);
                    if (null != arg.NameColon) {
                        namedArgs.Add(arg.NameColon.Name.Identifier.Text, arg.Expression);
                        continue;
                    }
                    if (null != argType) {
                        TryAddDslToObjectArg(ct, argType, i);
                    }
                    IConversionOperation lastConv = null;
                    if (ct < sym.Parameters.Length) {
                        var param = sym.Parameters[ct];
                        if (null != moper) {
                            var iarg = GetArgumentMatchingParameter(moper, param);
                            if (null != iarg) {
                                lastConv = iarg.Value as IConversionOperation;
                            }
                        }
                        if (!param.IsParams && param.Type.TypeKind == TypeKind.Array) {
                            RecordRefArray(arg.Expression);
                        }
                        if (param.RefKind == RefKind.Ref) {
                            Args.Add(arg.Expression);
                            ArgTypes.Add(argType);
                            ArgOperations.Add(argOper);
                            ArgSymbols.Add(argSym);
                            ReturnArgs.Add(arg.Expression);
                            ReturnArgTypes.Add(argType);
                            ReturnArgOperations.Add(argOper);
                            ReturnArgSymbols.Add(argSym);
                            if (null != argType && argType.IsValueType && !SymbolTable.IsBasicType(argType)) {
                                ReturnValueArgFlags.Add(true);
                            }
                            else {
                                ReturnValueArgFlags.Add(false);
                            }
                        }
                        else if (param.RefKind == RefKind.Out) {
                            //方法的out参数，为与脚本引擎的机制一致，在调用时传入__cs2dsl_out，这里用null标记一下，在实际输出参数时再变为__cs2dsl_out
                            Args.Add(null);
                            ArgTypes.Add(argType);
                            ArgOperations.Add(argOper);
                            ArgSymbols.Add(argSym);
                            ReturnArgs.Add(arg.Expression);
                            ReturnArgTypes.Add(argType);
                            ReturnArgOperations.Add(argOper);
                            ReturnArgSymbols.Add(argSym);
                            if (null != argType && argType.IsValueType && !SymbolTable.IsBasicType(argType)) {
                                ReturnValueArgFlags.Add(true);
                            }
                            else {
                                ReturnValueArgFlags.Add(false);
                            }
                        }
                        else if (param.IsParams) {
                            if (null != argType && argType.TypeKind == TypeKind.Array) {
                                ArrayToParams = true;
                            }
                            Args.Add(arg.Expression);
                            ArgTypes.Add(argType);
                            ArgOperations.Add(argOper);
                            ArgSymbols.Add(argSym);
                        }
                        else {
                            Args.Add(arg.Expression);
                            ArgTypes.Add(argType);
                            ArgOperations.Add(argOper);
                            ArgSymbols.Add(argSym);
                        }
                        ++ct;
                    }
                    else {
                        Args.Add(arg.Expression);
                        ArgTypes.Add(argType);
                        ArgOperations.Add(argOper);
                        ArgSymbols.Add(argSym);
                    }
                    ArgConversions.Add(lastConv);
                }
                for (int i = ct; i < sym.Parameters.Length; ++i) {
                    var param = sym.Parameters[i];
                    if (param.HasExplicitDefaultValue) {
                        IConversionOperation lastConv = null;
                        if (null != moper) {
                            var iarg = GetArgumentMatchingParameter(moper, param);
                            if (null != iarg) {
                                lastConv = iarg.Value as IConversionOperation;
                            }
                        }
                        ArgConversions.Add(lastConv);
                        ExpressionSyntax expval;
                        if (namedArgs.TryGetValue(param.Name, out expval)) {
                            var argSym = model.GetSymbolInfoEx(expval).Symbol;
                            var argOper = model.GetOperationEx(expval);
                            var argType = model.GetTypeInfoEx(expval).Type;
                            if (null == argType && null != argOper)
                                argType = argOper.Type;
                            if (null != argType) {
                                TryAddDslToObjectDefArg(i, argType, i - ct);
                            }
                            NameOrDefaultValueArgs.Add(new ArgDefaultValueInfo { Expression = expval, Type = argType, Operation = argOper, Symbol = argSym });
                        }
                        else {
                            var decl = param.DeclaringSyntaxReferences;
                            bool handled = false;
                            if (decl.Length >= 1) {
                                var node = param.DeclaringSyntaxReferences[0].GetSyntax() as ParameterSyntax;
                                if (null != node) {
                                    var exp = node.Default.Value;
                                    var tree = node.SyntaxTree;
                                    var newModel = SymbolTable.Instance.Compilation.GetSemanticModel(tree, true);
                                    if (null != newModel) {
                                        var argSym = newModel.GetSymbolInfoEx(exp).Symbol;
                                        var argOper = newModel.GetOperationEx(exp);
                                        var argType = newModel.GetTypeInfoEx(exp).Type;
                                        if (null == argType && null != argOper)
                                            argType = argOper.Type;
                                        if (null != argType) {
                                            TryAddDslToObjectDefArg(i, argType, i - ct);
                                        }
                                        NameOrDefaultValueArgs.Add(new ArgDefaultValueInfo { Value = param.ExplicitDefaultValue, Type = argType, Operation = argOper, Symbol = argSym });
                                        handled = true;
                                    }
                                }
                            }
                            if (!handled) {
                                NameOrDefaultValueArgs.Add(new ArgDefaultValueInfo { Value = param.ExplicitDefaultValue, Type = null, Operation = null, Symbol = null });
                            }
                        }
                    }
                }
            }
        }
        internal void Init(IMethodSymbol sym, List<ExpressionSyntax> argList, SemanticModel model, params IConversionOperation[] opds)
        {
            Init(sym, model);

            if (null != argList) {
                for (int i = 0; i < argList.Count; ++i) {
                    var arg = argList[i];
                    var argSym = model.GetSymbolInfoEx(arg).Symbol;
                    var argOper = model.GetOperationEx(arg);
                    var argType = model.GetTypeInfoEx(arg).Type;
                    if (null == argType && null != argOper)
                        argType = argOper.Type;
                    if (null != argType && argType.TypeKind == TypeKind.Array) {
                        RecordRefArray(arg);
                    }
                    TryAddExternEnum(IsEnumClass, argType, argOper);
                    if (null != argType) {
                        TryAddDslToObjectArg(i, argType, i);
                    }
                    Args.Add(arg);
                    ArgTypes.Add(argType);
                    ArgOperations.Add(argOper);
                    ArgSymbols.Add(argSym);
                    if (i < opds.Length)
                        ArgConversions.Add(opds[i]);
                    else
                        ArgConversions.Add(null);
                }
            }
        }

        internal string GetMethodName()
        {
            if (!string.IsNullOrEmpty(ExternOverloadedMethodSignature)) {
                return ExternOverloadedMethodSignature;
            }
            else if (IsExternMethod) {
                string ret = MethodSymbol.Name;
                if (!string.IsNullOrEmpty(ret) && ret[0] == '.')
                    ret = ret.Substring(1);
                return ret;
            }
            else {
                return SymbolTable.Instance.NameCs2DslMangling(IsExtensionMethod && null != MethodSymbol.ReducedFrom ? MethodSymbol.ReducedFrom : MethodSymbol);
            }
        }

        internal void OutputStructFieldsValue(StringBuilder codeBuilder, int indent, CsDslTranslater cs2dsl, string varPrefix, string varPostfix)
        {
            for (int i = 0; i < ReturnValueArgFlags.Count; ++i) {
                bool flag = ReturnValueArgFlags[i];
                if (flag) {
                    var exp = ReturnArgs[i];
                    var type = ReturnArgTypes[i];
                    var leftSym = ReturnArgSymbols[i];
                    if (null != leftSym && SymbolTable.Instance.IsCs2DslSymbol(leftSym) && SymbolTable.Instance.IsFieldSymbolKind(leftSym)) {
                        codeBuilder.Append(CsDslTranslater.GetIndentString(indent));
                        codeBuilder.AppendFormat("local({0}_{1}_{2}); {0}_{1}_{2} = ", varPrefix, i, varPostfix);
                        cs2dsl.OutputExpressionSyntax(exp);
                        codeBuilder.AppendLine(";");
                    }
                }
            }
        }

        internal void OutputWrapStructFields(StringBuilder codeBuilder, int indent, CsDslTranslater cs2dsl)
        {
            for (int i = 0; i < ReturnValueArgFlags.Count; ++i) {
                bool flag = ReturnValueArgFlags[i];
                if (flag) {
                    var exp = ReturnArgs[i];
                    var type = ReturnArgTypes[i];
                    var leftSym = ReturnArgSymbols[i];
                    if (null != leftSym && (leftSym.Kind == SymbolKind.Local || leftSym.Kind == SymbolKind.Parameter || SymbolTable.Instance.IsFieldSymbolKind(leftSym))) {
                        if (SymbolTable.Instance.IsCs2DslSymbol(type)) {
                            cs2dsl.MarkNeedFuncInfo();
                            codeBuilder.Append(CsDslTranslater.GetIndentString(indent));
                            cs2dsl.OutputExpressionSyntax(exp);
                            codeBuilder.Append(" = wrapstruct(");
                            cs2dsl.OutputExpressionSyntax(exp);
                            codeBuilder.AppendFormat(", {0});", ClassInfo.GetFullName(type));
                            codeBuilder.AppendLine();
                        }
                        else {
                            string ns = ClassInfo.GetNamespaces(type);
                            if (ns != "System") {
                                cs2dsl.MarkNeedFuncInfo();
                                codeBuilder.Append(CsDslTranslater.GetIndentString(indent));
                                cs2dsl.OutputExpressionSyntax(exp);
                                codeBuilder.Append(" = wrapexternstruct(");
                                cs2dsl.OutputExpressionSyntax(exp);
                                codeBuilder.AppendFormat(", {0});", ClassInfo.GetFullName(type));
                                codeBuilder.AppendLine();
                            }
                        }
                    }
                }
            }
        }

        internal void OutputRecycleAndKeepStructFields(StringBuilder codeBuilder, int indent, CsDslTranslater cs2dsl, string oldVarPrefix, string newVarPrefix, string varPostfix)
        {
            for (int i = 0; i < ReturnValueArgFlags.Count; ++i) {
                bool flag = ReturnValueArgFlags[i];
                if (flag) {
                    var exp = ReturnArgs[i];
                    var type = ReturnArgTypes[i];
                    var leftSym = ReturnArgSymbols[i];
                    if (null != leftSym && SymbolTable.Instance.IsCs2DslSymbol(leftSym) && SymbolTable.Instance.IsFieldSymbolKind(leftSym)) {
                        cs2dsl.MarkNeedFuncInfo();
                        string fieldType = fieldType = ClassInfo.GetFullName(type);
                        //回收旧值，保持新值
                        codeBuilder.Append(CsDslTranslater.GetIndentString(indent));
                        codeBuilder.Append("recycleandkeepstructvalue(");
                        codeBuilder.Append(fieldType);
                        codeBuilder.AppendFormat(", {0}_{2}_{3}, {1}_{2}_{3});", oldVarPrefix, newVarPrefix, i, varPostfix);
                        codeBuilder.AppendLine();
                    }
                }
            }
        }

        internal void OutputInvokeToLuaLibPrefix(StringBuilder codeBuilder, string luaLibFunc, ITypeSymbol callerType)
        {
            //luaLibFunc名称应已区分了方法是否静态、是否返回值类型、是否外部方法等，所以不再在参数里提供相关信息
            int ct = Args.Count + NameOrDefaultValueArgs.Count;
            var callerClassName = ClassInfo.GetFullName(callerType);
            if (string.IsNullOrEmpty(callerClassName))
                callerClassName = "null";
            string prestr = ", ";
            codeBuilder.Append(luaLibFunc);
            codeBuilder.Append("(");
            codeBuilder.Append(ct + 2);
            codeBuilder.Append(prestr);
            codeBuilder.Append("[");
            codeBuilder.Append(callerClassName);
            var namedCallerType = callerType as INamedTypeSymbol;
            if (null != namedCallerType) {
                ITypeSymbol firstTypeArg = null;
                ITypeSymbol secondTypeArg = null;
                if (namedCallerType.TypeArguments.Length > 0) {
                    firstTypeArg = namedCallerType.TypeArguments[0];
                }
                if (namedCallerType.TypeArguments.Length > 1) {
                    secondTypeArg = namedCallerType.TypeArguments[1];
                }
                string firstTypeName = "null";
                string firstTypeKind = "null";
                if (null != firstTypeArg) {
                    firstTypeName = ClassInfo.GetFullName(firstTypeArg);
                    firstTypeKind = "TypeKind." + firstTypeArg.TypeKind.ToString();
                }
                string secondTypeName = "null";
                string secondTypeKind = "null";
                if (null != secondTypeArg) {
                    secondTypeName = ClassInfo.GetFullName(secondTypeArg);
                    secondTypeKind = "TypeKind." + secondTypeArg.TypeKind.ToString();
                }
                codeBuilder.Append(prestr);
                codeBuilder.Append(firstTypeName);
                codeBuilder.Append(prestr);
                codeBuilder.Append(firstTypeKind);
                codeBuilder.Append(prestr);
                codeBuilder.Append(secondTypeName);
                codeBuilder.Append(prestr);
                codeBuilder.Append(secondTypeKind);
            }
            codeBuilder.Append("]");
            for (int i = 0; i < Args.Count; ++i) {
                var argType = ArgTypes[i];
                if (null == argType && MethodSymbol.Parameters.Length > 0) {
                    if (i < MethodSymbol.Parameters.Length) {
                        argType = MethodSymbol.Parameters[i].Type;
                    }
                    else {
                        argType = MethodSymbol.Parameters[MethodSymbol.Parameters.Length - 1].Type;
                    }
                }
                var arrType = argType as IArrayTypeSymbol;
                ITypeSymbol firstTypeArg = null;
                ITypeSymbol secondTypeArg = null;
                if (null != arrType) {
                    firstTypeArg = arrType.ElementType;
                }
                else {
                    var namedArgType = argType as INamedTypeSymbol;
                    if (null != namedArgType) {
                        if (namedArgType.TypeArguments.Length > 0) {
                            firstTypeArg = namedArgType.TypeArguments[0];
                        }
                        if (namedArgType.TypeArguments.Length > 1) {
                            secondTypeArg = namedArgType.TypeArguments[1];
                        }
                    }
                }
                var argOper = ArgOperations[i];
                var argSym = ArgSymbols[i];
                string firstTypeName = "null";
                string firstTypeKind = "null";
                if (null != firstTypeArg) {
                    firstTypeName = ClassInfo.GetFullName(firstTypeArg);
                    firstTypeKind = "TypeKind." + firstTypeArg.TypeKind.ToString();
                }
                string secondTypeName = "null";
                string secondTypeKind = "null";
                if (null != secondTypeArg) {
                    secondTypeName = ClassInfo.GetFullName(secondTypeArg);
                    secondTypeKind = "TypeKind." + secondTypeArg.TypeKind.ToString();
                }
                string argTypeName = ClassInfo.GetFullName(argType);
                if (string.IsNullOrEmpty(argTypeName))
                    argTypeName = "null";
                string argTypeKind = null != argType ? "TypeKind." + argType.TypeKind.ToString() : "null";
                string argOperKind = null != argOper ? "OperationKind." + argOper.Kind.ToString() : "null";
                string argSymKind = null != argSym ? "SymbolKind." + argSym.Kind.ToString() : "null";
                codeBuilder.Append(prestr);
                codeBuilder.Append("[");
                codeBuilder.Append(firstTypeName);
                codeBuilder.Append(prestr);
                codeBuilder.Append(firstTypeKind);
                codeBuilder.Append(prestr);
                codeBuilder.Append(secondTypeName);
                codeBuilder.Append(prestr);
                codeBuilder.Append(secondTypeKind);
                codeBuilder.Append(prestr);
                codeBuilder.Append(argTypeName);
                codeBuilder.Append(prestr);
                codeBuilder.Append(argTypeKind);
                codeBuilder.Append(prestr);
                codeBuilder.Append(argOperKind);
                codeBuilder.Append(prestr);
                codeBuilder.Append(argSymKind);
                codeBuilder.Append("]");
            }
            for (int i = 0; i < NameOrDefaultValueArgs.Count; ++i) {
                var nameArg = NameOrDefaultValueArgs[i];
                var argType = nameArg.Type;
                if (null == argType && MethodSymbol.Parameters.Length > 0) {
                    if (Args.Count + i < MethodSymbol.Parameters.Length) {
                        argType = MethodSymbol.Parameters[Args.Count + i].Type;
                    }
                    else {
                        argType = MethodSymbol.Parameters[MethodSymbol.Parameters.Length - 1].Type;
                    }
                }
                var arrType = argType as IArrayTypeSymbol;
                ITypeSymbol firstTypeArg = null;
                ITypeSymbol secondTypeArg = null;
                if (null != arrType) {
                    firstTypeArg = arrType.ElementType;
                }
                else {
                    var namedArgType = argType as INamedTypeSymbol;
                    if (null != namedArgType) {
                        if (namedArgType.TypeArguments.Length > 0) {
                            firstTypeArg = namedArgType.TypeArguments[0];
                        }
                        if (namedArgType.TypeArguments.Length > 1) {
                            secondTypeArg = namedArgType.TypeArguments[1];
                        }
                    }
                }
                var argOper = nameArg.Operation;
                var argSym = nameArg.Symbol;
                string firstTypeName = "null";
                string firstTypeKind = "null";
                if (null != firstTypeArg) {
                    firstTypeName = ClassInfo.GetFullName(firstTypeArg);
                    firstTypeKind = "TypeKind." + firstTypeArg.TypeKind.ToString();
                }
                string secondTypeName = "null";
                string secondTypeKind = "null";
                if (null != secondTypeArg) {
                    secondTypeName = ClassInfo.GetFullName(secondTypeArg);
                    secondTypeKind = "TypeKind." + secondTypeArg.TypeKind.ToString();
                }
                string argTypeName = ClassInfo.GetFullName(argType);
                if (string.IsNullOrEmpty(argTypeName))
                    argTypeName = "null";
                string argTypeKind = null != arrType ? "TypeKind." + arrType.TypeKind.ToString() : (null != argType ? "TypeKind." + argType.TypeKind.ToString() : "null");
                string argOperKind = null != argOper ? "OperationKind." + argOper.Kind.ToString() : "null";
                string argSymKind = null != argSym ? "SymbolKind." + argSym.Kind.ToString() : "null";
                codeBuilder.Append(prestr);
                codeBuilder.Append("[");
                codeBuilder.Append(firstTypeName);
                codeBuilder.Append(prestr);
                codeBuilder.Append(firstTypeKind);
                codeBuilder.Append(prestr);
                codeBuilder.Append(secondTypeName);
                codeBuilder.Append(prestr);
                codeBuilder.Append(secondTypeKind);
                codeBuilder.Append(prestr);
                codeBuilder.Append(argTypeName);
                codeBuilder.Append(prestr);
                codeBuilder.Append(argTypeKind);
                codeBuilder.Append(prestr);
                codeBuilder.Append(argOperKind);
                codeBuilder.Append(prestr);
                codeBuilder.Append(argSymKind);
                codeBuilder.Append("]");
            }
            codeBuilder.Append(prestr);
        }

        internal void OutputInvocation(StringBuilder codeBuilder, CsDslTranslater cs2dsl, ExpressionSyntax exp, bool isMemberAccess, SemanticModel model, SyntaxNode node)
        {
            IMethodSymbol sym = MethodSymbol;
            string mname = GetMethodName();
            string prestr = string.Empty;
            bool isExternMethodReturnStruct = IsExternMethod && !sym.ReturnsVoid && sym.ReturnType.IsValueType && !SymbolTable.IsBasicType(sym.ReturnType);
            if (isExternMethodReturnStruct) {
                cs2dsl.MarkNeedFuncInfo();
            }
            var expType = model.GetTypeInfoEx(exp).Type;
            if (null == expType) {
                var expOper = model.GetOperationEx(exp);
                if (null != expOper)
                    expType = expOper.Type;
            }
            var namedExpType = expType as INamedTypeSymbol;

            string luaLibFunc = ClassInfo.GetAttributeArgument<string>(sym, "Cs2Dsl.InvokeToLuaLibAttribute", 0);
            bool addTypeInfo = ClassInfo.GetAttributeArgument<bool>(sym, "Cs2Dsl.InvokeToLuaLibAttribute", 1);
            if (null != namedExpType && namedExpType.TypeArguments.Length > 0 && string.IsNullOrEmpty(luaLibFunc)) {
                bool isCollection = CsDslTranslater.IsImplementationOfSys(expType, "ICollection");
                if (isCollection) {
                    bool haveValueTypeArg = false;
                    foreach(var tp in namedExpType.TypeArguments) {
                        if (tp.IsValueType && !SymbolTable.IsBasicType(tp)) {
                            haveValueTypeArg = true;
                            break;
                        }
                    }
                    if (haveValueTypeArg) {
                        bool isDictionary = CsDslTranslater.IsImplementationOfSys(expType, "IDictionary");
                        bool isList = CsDslTranslater.IsImplementationOfSys(expType, "IList");
                        if (isDictionary)
                            luaLibFunc = string.Format("call{0}structdictionary{1}", IsExternMethod ? "extern" : string.Empty, !sym.IsStatic ? "instance" : (IsExtensionMethod ? "extension" : "static"));
                        else if (isList)
                            luaLibFunc = string.Format("call{0}structlist{1}", IsExternMethod ? "extern" : string.Empty, !sym.IsStatic ? "instance" : (IsExtensionMethod ? "extension" : "static"));
                        else
                            luaLibFunc = string.Format("call{0}structcollection{1}", IsExternMethod ? "extern" : string.Empty, !sym.IsStatic ? "instance" : (IsExtensionMethod ? "extension" : "static"));
                        addTypeInfo = true;
                    }
                }
            }
            if (isMemberAccess) {
                string fnOfIntf = string.Empty;
                bool isExplicitInterfaceInvoke = cs2dsl.CheckExplicitInterfaceAccess(sym, ref fnOfIntf);
                bool expIsBasicType = false;
                if (!sym.IsStatic && null != expType && SymbolTable.IsBasicType(expType)) {
                    expIsBasicType = true;
                }
                if (sym.MethodKind == MethodKind.DelegateInvoke) {
                    var memberAccess = node as MemberAccessExpressionSyntax;
                    if (null != memberAccess) {
                        var symInfo = model.GetSymbolInfoEx(node);
                        var masym = symInfo.Symbol as ISymbol;
                        if (null != masym) {
                            bool isCs2Dsl = SymbolTable.Instance.IsCs2DslSymbol(masym);
                            string kind = SymbolTable.Instance.GetSymbolKind(masym);
                            string fn = ClassInfo.GetFullName(masym.ContainingType);
                            string dt = ClassInfo.GetFullName(sym);
                            if (isExternMethodReturnStruct) {
                                codeBuilder.Append("callexterndelegationreturnstruct(getinstance(SymbolKind.");
                            }
                            else if (isCs2Dsl) {
                                codeBuilder.AppendFormat("call{0}delegation(getinstance(SymbolKind.", IsExternMethod ? "extern" : string.Empty);
                            }
                            else {
                                codeBuilder.AppendFormat("call{0}delegation(getexterninstance(SymbolKind.", IsExternMethod ? "extern" : string.Empty);
                            }
                            codeBuilder.Append(kind);
                            codeBuilder.Append(", ");
                            cs2dsl.OutputExpressionSyntax(exp);
                            codeBuilder.AppendFormat(", {0}, \"{1}\"), \"{2}\"", fn, memberAccess.Name, dt);
                            prestr = ", ";
                        }
                        else {
                            //error;
                        }
                    }
                    else {
                        //error;
                    }
                }
                else if (isExplicitInterfaceInvoke) {
                    if(isExternMethodReturnStruct)
                        codeBuilder.Append("callexterninstancereturnstruct(");
                    else if (IsExternMethod)
                        codeBuilder.Append("callexterninstance(");
                    else
                        codeBuilder.Append("callinstance(");
                    cs2dsl.OutputExpressionSyntax(exp);
                    codeBuilder.Append(", ");
                    codeBuilder.Append(ClassKey);
                    codeBuilder.Append(", ");
                    codeBuilder.AppendFormat("\"{0}\"", fnOfIntf);
                    prestr = ", ";
                }
                else if (IsExtensionMethod) {
                    if (!string.IsNullOrEmpty(luaLibFunc))
                        OutputInvokeToLuaLibPrefix(codeBuilder, luaLibFunc, expType);
                    else if (isExternMethodReturnStruct)
                        codeBuilder.Append("callexternextensionreturnstruct(");
                    else if (IsExternMethod)
                        codeBuilder.Append("callexternextension(");
                    else
                        codeBuilder.Append("callextension(");
                    codeBuilder.AppendFormat("{0}, \"{1}\", ", ClassKey, mname);
                    cs2dsl.OutputExpressionSyntax(exp);
                    prestr = ", ";
                }
                else if (IsBasicValueMethod || expIsBasicType) {
                    //这里不区分是否外部符号了，委托到动态语言的脚本库实现，可根据对象运行时信息判断
                    string ckey = CalcInvokeTarget(IsEnumClass, ClassKey, cs2dsl, expType);
                    codeBuilder.Append("invokeforbasicvalue(");
                    cs2dsl.OutputExpressionSyntax(exp);
                    codeBuilder.Append(", ");
                    codeBuilder.AppendFormat("{0}, {1}, \"{2}\"", IsEnumClass ? "true" : "false", ckey, mname);
                    prestr = ", ";
                }
                else if (IsArrayStaticMethod) {
                    //这里不区分是否外部符号了，委托到动态语言的脚本库实现，可根据对象运行时信息判断
                    codeBuilder.Append("invokearraystaticmethod(");
                    if (null == FirstRefArray) {
                        codeBuilder.Append("null, ");
                    }
                    else {
                        cs2dsl.OutputExpressionSyntax(FirstRefArray);
                        codeBuilder.Append(", ");
                    }
                    if (null == SecondRefArray) {
                        codeBuilder.Append("null, ");
                    }
                    else {
                        cs2dsl.OutputExpressionSyntax(SecondRefArray);
                        codeBuilder.Append(", ");
                    }
                    codeBuilder.AppendFormat("\"{0}\"", mname);
                    prestr = ", ";
                }
                else {
                    if (sym.IsStatic) {
                        if (!string.IsNullOrEmpty(luaLibFunc))
                            OutputInvokeToLuaLibPrefix(codeBuilder, luaLibFunc, expType);
                        else if (isExternMethodReturnStruct)
                            codeBuilder.Append("callexternstaticreturnstruct(");
                        else if (IsExternMethod)
                            codeBuilder.Append("callexternstatic(");
                        else
                            codeBuilder.Append("callstatic(");
                        codeBuilder.Append(ClassKey);
                    }
                    else {
                        if (!string.IsNullOrEmpty(luaLibFunc))
                            OutputInvokeToLuaLibPrefix(codeBuilder, luaLibFunc, expType);
                        else if (isExternMethodReturnStruct)
                            codeBuilder.Append("callexterninstancereturnstruct(");
                        else if (IsExternMethod)
                            codeBuilder.Append("callexterninstance(");
                        else
                            codeBuilder.Append("callinstance(");
                        cs2dsl.OutputExpressionSyntax(exp);
                        codeBuilder.Append(", ");
                        codeBuilder.Append(ClassKey);
                    }
                    codeBuilder.AppendFormat(", \"{0}\"", mname);
                    prestr = ", ";
                }
            }
            else {
                if (sym.MethodKind == MethodKind.DelegateInvoke) {
                    string dt = ClassInfo.GetFullName(sym);
                    if (isExternMethodReturnStruct) {
                        codeBuilder.Append("callexterndelegationreturnstruct(");
                    }
                    else {
                        codeBuilder.AppendFormat("call{0}delegation(", IsExternMethod ? "extern" : string.Empty);
                    }
                    cs2dsl.OutputExpressionSyntax(exp);
                    codeBuilder.AppendFormat(", \"{0}\"", dt);
                    prestr = ", ";
                }
                else {
                    if (sym.IsStatic) {
                        if (!string.IsNullOrEmpty(luaLibFunc))
                            OutputInvokeToLuaLibPrefix(codeBuilder, luaLibFunc, expType);
                        else if (isExternMethodReturnStruct)
                            codeBuilder.Append("callexternstaticreturnstruct(");
                        else if (IsExternMethod)
                            codeBuilder.Append("callexternstatic(");
                        else
                            codeBuilder.Append("callstatic(");
                        codeBuilder.Append(ClassKey);
                        codeBuilder.AppendFormat(", \"{0}\"", mname);
                        prestr = ", ";
                    }
                    else {
                        if (!string.IsNullOrEmpty(luaLibFunc))
                            OutputInvokeToLuaLibPrefix(codeBuilder, luaLibFunc, expType);
                        else if (isExternMethodReturnStruct)
                            codeBuilder.Append("callexterninstancereturnstruct(");
                        else if (IsExternMethod)
                            codeBuilder.Append("callexterninstance(");
                        else
                            codeBuilder.Append("callinstance(");
                        codeBuilder.Append("this");
                        codeBuilder.AppendFormat(", {0}, \"{1}\"", ClassKey, mname);
                        prestr = ", ";
                    }
                }
            }
            if (Args.Count + NameOrDefaultValueArgs.Count + GenericTypeArgs.Count > 0) {
                codeBuilder.Append(prestr);
            }
            bool useTypeNameString = false;
            if (IsComponentGetOrAdd && SymbolTable.DslComponentByString) {
                var tArgs = sym.TypeArguments;
                if (tArgs.Length > 0 && SymbolTable.Instance.IsCs2DslSymbol(tArgs[0])) {
                    useTypeNameString = true;
                }
            }
            TypeChecker.CheckInvocation(model, sym, Args, NameOrDefaultValueArgs, ArgConversions, CallerSyntaxNode, CallerMethodSymbol);
            cs2dsl.OutputArgumentList(this, expType, useTypeNameString, node);
            codeBuilder.Append(")");
        }
        
        private IArgumentOperation GetArgumentMatchingParameter(IInvocationOperation oper, IParameterSymbol param)
        {
            foreach(var arg in oper.Arguments) {
                if (arg.Parameter == param)
                    return arg;
            }
            return null;
        }
        private void RecordRefArray(ExpressionSyntax exp)
        {
            if (IsArrayStaticMethod) {
                if (null == FirstRefArray) {
                    FirstRefArray = exp;
                }
                else if (null == SecondRefArray) {
                    SecondRefArray = exp;
                }
            }
        }

        private void TryAddDslToObjectArg(int paramIx, ITypeSymbol arg, int ix)
        {
            if (null != arg) {
                var param = GetParamType(paramIx);
                if (IsDslToObject(param, arg)) {
                    DslToObjectArgs.Add(ix);
                }
            }
        }
        private void TryAddDslToObjectDefArg(int paramIx, ITypeSymbol arg, int ix)
        {
            if (null != arg) {
                var param = GetParamType(paramIx);
                if (IsDslToObject(param, arg)) {
                    DslToObjectDefArgs.Add(ix);
                }
            }
        }
        private ITypeSymbol GetParamType(int paramIx)
        {
            ITypeSymbol type;
            IParameterSymbol param;
            if (paramIx < MethodSymbol.Parameters.Length) {
                param = MethodSymbol.Parameters[paramIx];
            }
            else {
                param = MethodSymbol.Parameters[MethodSymbol.Parameters.Length - 1];
            }
            if (param.IsParams) {
                var arrParam = param.Type as IArrayTypeSymbol;
                type = arrParam.ElementType;
            }
            else {
                type = param.Type;
            }
            return type;
        }

        /// <summary>
        /// 备忘：只要是lua类型转换到object或反过来就应该进行处理，这样能在语义上保证处理是完全的。
        /// 这是为啥local变量与lua里的函数参数也要检查的原因。(比如存在这种情形，delegation是可以
        /// 被赋值给一个变量，传递到其他地方后再调用的，如果只对非lua类成员与函数调用参数进行检查，
        /// 就可能漏掉这种情形。另一方面，除非作为custom data的情况，通常也应避免这种转型到object
        /// 的用法，在所有转换的地方进行处理也提供了对滥用的检查机会)
        /// </summary>
        /// <param name="param"></param>
        /// <param name="arg"></param>
        /// <returns></returns>
        internal static bool IsDslToObject(ITypeSymbol param, ITypeSymbol arg)
        {
            if (null != arg) {
                string leftFullName = ClassInfo.GetFullName(param);
                if (leftFullName == "System.Object"){
                    if (SymbolTable.Instance.IsCs2DslSymbol(arg)) {
                        return true;
                    }
                    if (arg.TypeKind == TypeKind.Array) {
                        return true;
                    }
                    var namedType = arg as INamedTypeSymbol;
                    if (null != namedType && namedType.IsGenericType && CsDslTranslater.IsImplementationOfSys(arg, "ICollection")) {
                        return true;
                    }
                }
            }
            return false;
        }
        internal static bool IsObjectToDsl(ITypeSymbol param, ITypeSymbol arg)
        {
            if (null != arg) {
                string rightFullName = ClassInfo.GetFullName(arg);
                if (rightFullName == "System.Object") {
                    if (SymbolTable.Instance.IsCs2DslSymbol(param)) {
                        return true;
                    }
                    if (param.TypeKind == TypeKind.Array) {
                        return true;
                    }
                    var namedType = param as INamedTypeSymbol;
                    if (null != namedType && namedType.IsGenericType && CsDslTranslater.IsImplementationOfSys(param, "ICollection")) {
                        return true;
                    }
                }
            }
            return false;
        }

        internal static void TryAddExternEnum(bool isEnumClass, ITypeSymbol type, IOperation oper)
        {
            if (isEnumClass) {
                if (null != oper) {
                    type = oper.Type;
                }
                if (null != type && !SymbolTable.Instance.IsCs2DslSymbol(type) && type.TypeKind == TypeKind.Enum) {
                    string ckey = ClassInfo.GetFullName(type);
                    SymbolTable.Instance.AddExternEnum(ckey, type);
                }
                else if (null != oper) {
                    var typeOf = oper as ITypeOfOperation;
                    if (null != typeOf && !SymbolTable.Instance.IsCs2DslSymbol(typeOf.TypeOperand) && typeOf.TypeOperand.TypeKind == TypeKind.Enum) {
                        string ckey = ClassInfo.GetFullName(typeOf.TypeOperand);
                        SymbolTable.Instance.AddExternEnum(ckey, typeOf.TypeOperand);
                    }
                }
            }
        }

        internal static string CalcInvokeTarget(bool isEnumClass, string classKey, CsDslTranslater cs2dsl, ITypeSymbol type)
        {
            TryAddExternEnum(isEnumClass, type, null);
            string ckey = classKey;
            if (isEnumClass && null != type) {
                if (type.TypeKind == TypeKind.Enum) {
                    var ci = cs2dsl.GetCurClassInfo();
                    ci.AddReference(type);

                    ckey = ClassInfo.GetFullName(type);
                }
            }
            return ckey;
        }
    }
}