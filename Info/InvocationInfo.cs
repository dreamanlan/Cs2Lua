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
    /// 用于翻译方法调用的信息。
    /// </summary>
    internal class ArgDefaultValueInfo
    {
        internal object Value;
        internal object OperOrSym;
        internal ExpressionSyntax Expression;
    }
    internal class InvocationInfo
    {
        internal string ClassKey = string.Empty;
        internal string GenericClassKey = string.Empty;
        internal List<ExpressionSyntax> Args = new List<ExpressionSyntax>();
        internal HashSet<int> DslToObjectArgs = new HashSet<int>();
        internal List<IConversionExpression> ArgConversions = new List<IConversionExpression>();
        internal List<ArgDefaultValueInfo> DefaultValueArgs = new List<ArgDefaultValueInfo>();
        internal HashSet<int> DslToObjectDefArgs = new HashSet<int>();
        internal List<ExpressionSyntax> ReturnArgs = new List<ExpressionSyntax>();
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

        internal InvocationInfo(IMethodSymbol caller, SyntaxNode node)
        {
            CallerMethodSymbol = caller;
            CallerSyntaxNode = node;
        }

        internal void Init(IMethodSymbol sym, ArgumentListSyntax argList, SemanticModel model)
        {
            Init(sym, model);

            if (null != argList) {
                var moper = model.GetOperationEx(argList) as IInvocationExpression;
                var args = argList.Arguments;

                Dictionary<string, ExpressionSyntax> namedArgs = new Dictionary<string, ExpressionSyntax>();
                int ct = 0;
                for (int i = 0; i < args.Count; ++i) {
                    var arg = args[i];
                    var argOper = model.GetOperationEx(arg.Expression);
                    TryAddExternEnum(IsEnumClass, argOper);
                    if (null != arg.NameColon) {
                        namedArgs.Add(arg.NameColon.Name.Identifier.Text, arg.Expression);
                        continue;
                    }
                    if (null != argOper) {
                        TryAddDslToObjectArg(ct, argOper.Type, i);
                    }
                    IConversionExpression lastConv = null;
                    if (ct < sym.Parameters.Length) {
                        var param = sym.Parameters[ct];
                        if (null != moper) {
                            var iarg = moper.GetArgumentMatchingParameter(param);
                            if (null != iarg) {
                                lastConv = iarg.Value as IConversionExpression;
                            }
                        }
                        if (!param.IsParams && param.Type.TypeKind == TypeKind.Array) {
                            RecordRefArray(arg.Expression);
                        }
                        if (param.RefKind == RefKind.Ref) {
                            Args.Add(arg.Expression);
                            ReturnArgs.Add(arg.Expression);
                        }
                        else if (param.RefKind == RefKind.Out) {
                            //方法的out参数，为与脚本引擎的机制一致，在调用时传入__cs2dsl_out，这里用null标记一下，在实际输出参数时再变为__cs2dsl_out
                            Args.Add(null);
                            ReturnArgs.Add(arg.Expression);
                        }
                        else if (param.IsParams) {
                            if (null != argOper && null != argOper.Type && argOper.Type.TypeKind == TypeKind.Array) {
                                ArrayToParams = true;
                            }
                            Args.Add(arg.Expression);
                        }
                        else {
                            Args.Add(arg.Expression);
                        }
                        ++ct;
                    }
                    else {
                        Args.Add(arg.Expression);
                    }
                    ArgConversions.Add(lastConv);
                }
                for (int i = ct; i < sym.Parameters.Length; ++i) {
                    var param = sym.Parameters[i];
                    if (param.HasExplicitDefaultValue) {
                        IConversionExpression lastConv = null;
                        if (null != moper) {
                            var iarg = moper.GetArgumentMatchingParameter(param);
                            if (null != iarg) {
                                lastConv = iarg.Value as IConversionExpression;
                            }
                        }
                        ArgConversions.Add(lastConv);
                        ExpressionSyntax expval;
                        if (namedArgs.TryGetValue(param.Name, out expval)) {
                            var argOper = model.GetOperationEx(expval);
                            if (null != argOper) {
                                TryAddDslToObjectDefArg(i, argOper.Type, i - ct);
                            }
                            DefaultValueArgs.Add(new ArgDefaultValueInfo { Expression = expval });
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
                                        var oper = newModel.GetOperationEx(exp);
                                        if (null != oper) {
                                            TryAddDslToObjectDefArg(i, oper.Type, i - ct);
                                        }
                                        DefaultValueArgs.Add(new ArgDefaultValueInfo { Value = param.ExplicitDefaultValue, OperOrSym = oper });
                                        handled = true;
                                    }
                                }
                            }
                            if (!handled) {
                                DefaultValueArgs.Add(new ArgDefaultValueInfo { Value = param.ExplicitDefaultValue, OperOrSym = null });
                            }
                        }
                    }
                }
            }
        }

        internal void Init(IMethodSymbol sym, BracketedArgumentListSyntax argList, SemanticModel model)
        {
            Init(sym, model);

            if (null != argList) {
                var moper = model.GetOperationEx(argList) as IInvocationExpression;
                var args = argList.Arguments;

                Dictionary<string, ExpressionSyntax> namedArgs = new Dictionary<string, ExpressionSyntax>();
                int ct = 0;
                for (int i = 0; i < args.Count; ++i) {
                    var arg = args[i];
                    var argOper = model.GetOperationEx(arg.Expression);
                    TryAddExternEnum(IsEnumClass, argOper);
                    if (null != arg.NameColon) {
                        namedArgs.Add(arg.NameColon.Name.Identifier.Text, arg.Expression);
                        continue;
                    }
                    if (null != argOper) {
                        TryAddDslToObjectArg(ct, argOper.Type, i);
                    }
                    IConversionExpression lastConv = null;
                    if (ct < sym.Parameters.Length) {
                        var param = sym.Parameters[ct];
                        if (null != moper) {
                            var iarg = moper.GetArgumentMatchingParameter(param);
                            if (null != iarg) {
                                lastConv = iarg.Value as IConversionExpression;
                            }
                        }
                        if (!param.IsParams && param.Type.TypeKind == TypeKind.Array) {
                            RecordRefArray(arg.Expression);
                        }
                        if (param.RefKind == RefKind.Ref) {
                            Args.Add(arg.Expression);
                            ReturnArgs.Add(arg.Expression);
                        }
                        else if (param.RefKind == RefKind.Out) {
                            //方法的out参数，为与脚本引擎的机制一致，在调用时传入__cs2dsl_out，这里用null标记一下，在实际输出参数时再变为__cs2dsl_out
                            Args.Add(null);
                            ReturnArgs.Add(arg.Expression);
                        }
                        else if (param.IsParams) {
                            if (null != argOper && null != argOper.Type && argOper.Type.TypeKind == TypeKind.Array) {
                                ArrayToParams = true;
                            }
                            Args.Add(arg.Expression);
                        }
                        else {
                            Args.Add(arg.Expression);
                        }
                        ++ct;
                    }
                    else {
                        Args.Add(arg.Expression);
                    }
                    ArgConversions.Add(lastConv);
                }
                for (int i = ct; i < sym.Parameters.Length; ++i) {
                    var param = sym.Parameters[i];
                    if (param.HasExplicitDefaultValue) {
                        IConversionExpression lastConv = null;
                        if (null != moper) {
                            var iarg = moper.GetArgumentMatchingParameter(param);
                            if (null != iarg) {
                                lastConv = iarg.Value as IConversionExpression;
                            }
                        }
                        ArgConversions.Add(lastConv);
                        ExpressionSyntax expval;
                        if (namedArgs.TryGetValue(param.Name, out expval)) {
                            var argOper = model.GetOperationEx(expval);
                            if (null != argOper) {
                                TryAddDslToObjectDefArg(i, argOper.Type, i - ct);
                            }
                            DefaultValueArgs.Add(new ArgDefaultValueInfo { Expression = expval });
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
                                        var oper = newModel.GetOperationEx(exp);
                                        if (null != oper) {
                                            TryAddDslToObjectDefArg(i, oper.Type, i - ct);
                                        }
                                        DefaultValueArgs.Add(new ArgDefaultValueInfo { Value = param.ExplicitDefaultValue, OperOrSym = oper });
                                        handled = true;
                                    }
                                }
                            }
                            if (!handled) {
                                DefaultValueArgs.Add(new ArgDefaultValueInfo { Value = param.ExplicitDefaultValue, OperOrSym = null });
                            }
                        }
                    }
                }
            }
        }

        internal void Init(IMethodSymbol sym, List<ExpressionSyntax> argList, SemanticModel model, params IConversionExpression[] opds)
        {
            Init(sym, model);

            if (null != argList) {
                for (int i = 0; i < argList.Count; ++i) {
                    var arg = argList[i];
                    var argOper = model.GetOperationEx(arg);
                    if (null != argOper && null != argOper.Type && argOper.Type.TypeKind == TypeKind.Array) {
                        RecordRefArray(arg);
                    }
                    TryAddExternEnum(IsEnumClass, argOper);
                    if (null != argOper) {
                        TryAddDslToObjectArg(i, argOper.Type, i);
                    }
                    Args.Add(arg);
                    if (i < opds.Length)
                        ArgConversions.Add(opds[i]);
                    else
                        ArgConversions.Add(null);
                }
            }
        }

        internal void OutputInvocation(StringBuilder codeBuilder, CsDslTranslater cs2dsl, ExpressionSyntax exp, bool isMemberAccess, SemanticModel model, SyntaxNode node)
        {
            IMethodSymbol sym = MethodSymbol;
            string mname = cs2dsl.NameMangling(IsExtensionMethod && !IsExternMethod && null != sym.ReducedFrom ? sym.ReducedFrom : sym);
            string prestr = string.Empty;
            bool externReturnStruct = IsExternMethod && !sym.ReturnsVoid && sym.ReturnType.TypeKind == TypeKind.Struct;
            if (isMemberAccess) {
                string fnOfIntf = string.Empty;
                var expOper = model.GetOperationEx(exp);
                bool isExplicitInterfaceInvoke = cs2dsl.CheckExplicitInterfaceAccess(sym, ref fnOfIntf);
                bool expIsBasicType = false;
                if (!sym.IsStatic && null != expOper && SymbolTable.IsBasicType(expOper.Type)) {
                    expIsBasicType = true;
                }
                if (sym.MethodKind == MethodKind.DelegateInvoke) {
                    var memberAccess = node as MemberAccessExpressionSyntax;
                    if (null != memberAccess) {
                        var symInfo = model.GetSymbolInfoEx(node);
                        var masym = symInfo.Symbol as ISymbol;
                        if (null != masym) {
                            bool isCs2Lua = SymbolTable.Instance.IsCs2DslSymbol(masym);
                            string kind = SymbolTable.Instance.GetSymbolKind(masym);
                            string fn = ClassInfo.GetFullName(masym.ContainingType);
                            string dt = ClassInfo.GetFullName(sym);
                            if (externReturnStruct) {
                                codeBuilder.Append("callexterndelegationreturnstruct(getinstance(SymbolKind.");
                            }
                            else if (isCs2Lua) {
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
                    //这里不区分是否外部符号了，委托到动态语言的脚本库实现，可根据对象运行时信息判断
                    if(externReturnStruct)
                        codeBuilder.Append("callexterninstancereturnstruct(");
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
                    if (externReturnStruct)
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
                    string ckey = CalcInvokeTarget(IsEnumClass, ClassKey, cs2dsl, expOper);
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
                        if (externReturnStruct)
                            codeBuilder.Append("callexternstaticreturnstruct(");
                        else if (IsExternMethod)
                            codeBuilder.Append("callexternstatic(");
                        else
                            codeBuilder.Append("callstatic(");
                        codeBuilder.Append(ClassKey);
                    }
                    else {
                        if (externReturnStruct)
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
                    cs2dsl.OutputExpressionSyntax(exp);
                    codeBuilder.Append("(");
                }
                else if (sym.IsStatic) {
                    if (externReturnStruct)
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
                    if (externReturnStruct)
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
            if (!string.IsNullOrEmpty(ExternOverloadedMethodSignature) || Args.Count + DefaultValueArgs.Count + GenericTypeArgs.Count > 0) {
                codeBuilder.Append(prestr);
            }
            bool useTypeNameString = false;
            if (IsComponentGetOrAdd && SymbolTable.DslComponentByString) {
                var tArgs = sym.TypeArguments;
                if (tArgs.Length > 0 && SymbolTable.Instance.IsCs2DslSymbol(tArgs[0])) {
                    useTypeNameString = true;
                }
            }
            TypeChecker.CheckInvocation(model, sym, Args, DefaultValueArgs, ArgConversions, CallerSyntaxNode, CallerMethodSymbol);
            cs2dsl.OutputArgumentList(Args, DslToObjectArgs, DefaultValueArgs, DslToObjectDefArgs, GenericTypeArgs, ExternOverloadedMethodSignature, PostPositionGenericTypeArgs, ArrayToParams, useTypeNameString, node, MethodSymbol, ArgConversions.ToArray());
            codeBuilder.Append(")");
        }

        private void Init(IMethodSymbol sym, SemanticModel model)
        {
            MethodSymbol = sym;
            Model = model;

            Args.Clear();
            DslToObjectArgs.Clear();
            ArgConversions.Clear();
            DefaultValueArgs.Clear();
            DslToObjectDefArgs.Clear();
            ReturnArgs.Clear();
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
            if (sym.IsGenericMethod) {
                bool existNonGenericVersion = !IsExternMethod;
                var ctype = sym.ContainingType;
                var syms = ctype.GetMembers(sym.Name);
                if (null != syms) {
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

            ExternOverloadedMethodSignature = string.Empty;
            if (IsExternMethod) {
                var syms = sym.ContainingType.GetMembers(sym.Name);
                if (null != syms) {
                    int mcount = 0;
                    foreach (var isym in syms) {
                        var msym = isym as IMethodSymbol;
                        var fn = ClassInfo.GetFullName(msym.ContainingType);
                        if (null != msym && msym.IsStatic == sym.IsStatic && msym.DeclaredAccessibility == Accessibility.Public && !msym.IsImplicitlyDeclared && !msym.IsGenericMethod) {
                            ++mcount;
                        }
                    }
                    if (mcount > 1) {
                        ExternOverloadedMethodSignature = SymbolTable.CalcOverloadedMethodSignature(sym, NonGenericMethodSymbol);
                    }
                }
                SymbolTable.Instance.TryAddExternReference(sym);
                if (!sym.ReturnsVoid) {
                    SymbolTable.Instance.TryAddExternReference(sym.ReturnType);
                }
                foreach(var p in sym.Parameters) {
                    if (p.Kind != SymbolKind.TypeParameter) {
                        SymbolTable.Instance.TryAddExternReference(p.Type);
                    }
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

        internal static void TryAddExternEnum(bool isEnumClass, IOperation oper)
        {
            if (isEnumClass) {
                if (!SymbolTable.Instance.IsCs2DslSymbol(oper.Type) && oper.Type.TypeKind == TypeKind.Enum) {
                    string ckey = ClassInfo.GetFullName(oper.Type);
                    SymbolTable.Instance.AddExternEnum(ckey, oper.Type);
                }
                else {
                    var typeOf = oper as ITypeOfExpression;
                    if (null != typeOf && !SymbolTable.Instance.IsCs2DslSymbol(typeOf.TypeOperand) && typeOf.TypeOperand.TypeKind == TypeKind.Enum) {
                        string ckey = ClassInfo.GetFullName(typeOf.TypeOperand);
                        SymbolTable.Instance.AddExternEnum(ckey, typeOf.TypeOperand);
                    }
                }
            }
        }

        internal static string CalcInvokeTarget(bool isEnumClass, string classKey, CsDslTranslater cs2dsl, IOperation oper)
        {
            TryAddExternEnum(isEnumClass, oper);
            string ckey = classKey;
            if (isEnumClass) {
                if (oper.Type.TypeKind == TypeKind.Enum) {
                    var ci = cs2dsl.GetCurClassInfo();
                    ci.AddReference(oper.Type);

                    ckey = ClassInfo.GetFullName(oper.Type);
                }
            }
            return ckey;
        }
    }
}