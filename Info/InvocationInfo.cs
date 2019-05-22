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
    internal class ArgDefaultValueInfo
    {
        internal object Value;
        internal object OperOrSym;
    }
    internal class InvocationInfo
    {
        internal string ClassKey = string.Empty;
        internal string GenericClassKey = string.Empty;
        internal List<ExpressionSyntax> Args = new List<ExpressionSyntax>();
        internal List<IConversionExpression> ArgConversions = new List<IConversionExpression>();
        internal List<ArgDefaultValueInfo> DefaultValueArgs = new List<ArgDefaultValueInfo>();
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
        internal INamedTypeSymbol CallerTypeSymbol = null;

        internal InvocationInfo(IMethodSymbol caller)
        {
            if (null != caller) {
                CallerMethodSymbol = caller;
                CallerTypeSymbol = caller.ContainingType;
            }
        }

        internal void Init(IMethodSymbol sym, ArgumentListSyntax argList, SemanticModel model)
        {
            Init(sym);

            if (null != argList) {
                var moper = model.GetOperation(argList) as IInvocationExpression;
                var args = argList.Arguments;

                IConversionExpression lastConv = null;
                int ct = args.Count;
                for (int i = 0; i < ct; ++i) {
                    var arg = args[i];
                    TryAddExternEnum(IsEnumClass, arg.Expression, model);
                    if (i < sym.Parameters.Length) {
                        var param = sym.Parameters[i];
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
                        } else if (param.RefKind == RefKind.Out) {
                            //方法的out参数，为与脚本引擎的机制一致，在调用时传入__cs2dsl_out，这里用null标记一下，在实际输出参数时再变为__cs2dsl_out
                            Args.Add(null);
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
                    ArgConversions.Add(lastConv);
                }
                for (int i = ct; i < sym.Parameters.Length; ++i) {
                    var param = sym.Parameters[i];
                    if (param.HasExplicitDefaultValue) {
                        var decl = param.DeclaringSyntaxReferences;
                        bool handled = false;
                        if (decl.Length >= 1) {
                            var node = param.DeclaringSyntaxReferences[0].GetSyntax() as ParameterSyntax;
                            if (null != node) {
                                var exp = node.Default.Value;
                                var tree = node.SyntaxTree;
                                var newModel = SymbolTable.Instance.Compilation.GetSemanticModel(tree, true);
                                if (null != newModel) {
                                    var oper = newModel.GetOperation(exp);
                                    //var dsym = newModel.GetSymbolInfo(exp).Symbol;
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

        internal void Init(IMethodSymbol sym, BracketedArgumentListSyntax argList, SemanticModel model)
        {
            Init(sym);

            if (null != argList) {
                var moper = model.GetOperation(argList) as IInvocationExpression;
                var args = argList.Arguments;

                IConversionExpression lastConv = null;
                int ct = args.Count;
                for (int i = 0; i < ct; ++i) {
                    var arg = args[i];
                    TryAddExternEnum(IsEnumClass, arg.Expression, model);
                    if (i < sym.Parameters.Length) {
                        var param = sym.Parameters[i];
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
                        } else if (param.RefKind == RefKind.Out) {
                            //方法的out参数，为与脚本引擎的机制一致，在调用时传入__cs2dsl_out，这里用null标记一下，在实际输出参数时再变为__cs2dsl_out
                            Args.Add(null);
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
                    ArgConversions.Add(lastConv);
                }
                for (int i = ct; i < sym.Parameters.Length; ++i) {
                    var param = sym.Parameters[i];
                    if (param.HasExplicitDefaultValue) {
                        var decl = param.DeclaringSyntaxReferences;
                        bool handled = false;
                        if (decl.Length >= 1) {
                            var node = param.DeclaringSyntaxReferences[0].GetSyntax() as ParameterSyntax;
                            if (null != node) {
                                var exp = node.Default.Value;
                                var tree = node.SyntaxTree;
                                var newModel = SymbolTable.Instance.Compilation.GetSemanticModel(tree, true);
                                if (null != newModel) {
                                    var oper = newModel.GetOperation(exp);
                                    //var dsym = newModel.GetSymbolInfo(exp).Symbol;
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

        internal void Init(IMethodSymbol sym, List<ExpressionSyntax> argList, SemanticModel model, params IConversionExpression[] opds)
        {
            Init(sym);

            if (null != argList) {
                for (int i = 0; i < argList.Count; ++i) {
                    var arg = argList[i];
                    var oper = model.GetOperation(arg);
                    if (null != oper && null != oper.Type && oper.Type.TypeKind == TypeKind.Array) {
                        RecordRefArray(arg);
                    }
                    TryAddExternEnum(IsEnumClass, arg, model);
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
            string mname = cs2dsl.NameMangling(IsExtensionMethod && null != sym.ReducedFrom ? sym.ReducedFrom : sym);
            string prestr = string.Empty;
            if (isMemberAccess) {
                string fnOfIntf = "null";
                var expOper = model.GetOperation(exp);
                bool isExplicitInterfaceInvoke = cs2dsl.CheckExplicitInterfaceAccess(sym, ref fnOfIntf);
                bool expIsBasicType = false;
                if (!sym.IsStatic && null != expOper && SymbolTable.IsBasicType(expOper.Type)) {
                    expIsBasicType = true;
                }
                if (sym.MethodKind == MethodKind.DelegateInvoke) {
                    var memberAccess  = node as MemberAccessExpressionSyntax;
                    if (null != memberAccess) {
                        codeBuilder.Append("callinstance(");
                        cs2dsl.OutputExpressionSyntax(exp);
                        codeBuilder.AppendFormat(", \"{0}\"", memberAccess.Name);
                        prestr = ", ";
                    } else {
                        //error;
                    }
                } else if (isExplicitInterfaceInvoke) {
                    codeBuilder.Append("invokewithinterface(");
                    cs2dsl.OutputExpressionSyntax(exp);
                    codeBuilder.Append(", ");
                    codeBuilder.AppendFormat("{0}, \"{1}\"", fnOfIntf, mname);
                    prestr = ", ";
                } else if (IsExtensionMethod) {
                    codeBuilder.Append("callstatic(");
                    codeBuilder.AppendFormat("{0}, \"{1}\", ", ClassKey, mname);
                } else if (IsBasicValueMethod || expIsBasicType) {
                    string ckey = CalcInvokeTarget(IsEnumClass, ClassKey, cs2dsl, exp, model);
                    codeBuilder.Append("invokeforbasicvalue(");
                    cs2dsl.OutputExpressionSyntax(exp);
                    codeBuilder.Append(", ");
                    codeBuilder.AppendFormat("{0}, {1}, \"{2}\"", IsEnumClass ? "true" : "false", ckey, mname);
                    prestr = ", ";
                } else if (IsArrayStaticMethod) {
                    codeBuilder.Append("invokearraystaticmethod(");
                    if (null == FirstRefArray) {
                        codeBuilder.Append("null, ");
                    } else {
                        cs2dsl.OutputExpressionSyntax(FirstRefArray);
                        codeBuilder.Append(", ");
                    }
                    if (null == SecondRefArray) {
                        codeBuilder.Append("null, ");
                    } else {
                        cs2dsl.OutputExpressionSyntax(SecondRefArray);
                        codeBuilder.Append(", ");
                    }
                    codeBuilder.AppendFormat("\"{0}\"", mname);
                    prestr = ", ";
                } else {
                    if (sym.IsStatic) {
                        codeBuilder.Append("callstatic(");
                        codeBuilder.Append(ClassKey);
                    } else {
                        codeBuilder.Append("callinstance(");
                        cs2dsl.OutputExpressionSyntax(exp);
                    }
                    codeBuilder.AppendFormat(", \"{0}\"", mname);
                    prestr = ", ";
                }
            } else {
                if (sym.MethodKind == MethodKind.DelegateInvoke) {
                    cs2dsl.OutputExpressionSyntax(exp);
                    codeBuilder.Append("(");
                } else if (sym.IsStatic) {
                    codeBuilder.Append("callstatic(");
                    codeBuilder.Append(ClassKey);
                    codeBuilder.AppendFormat(", \"{0}\"", mname);
                    prestr = ", ";
                } else {
                    codeBuilder.Append("callinstance(");
                    codeBuilder.Append("this");
                    codeBuilder.AppendFormat(", \"{0}\"", mname);
                    prestr = ", ";
                }
            }
            if (!string.IsNullOrEmpty(ExternOverloadedMethodSignature) || Args.Count + DefaultValueArgs.Count + GenericTypeArgs.Count > 0) {
                codeBuilder.Append(prestr);
            }
            bool useTypeNameString = false;
            if(IsComponentGetOrAdd && SymbolTable.DslComponentByString){
                var tArgs = sym.TypeArguments;
                if (tArgs.Length > 0 && SymbolTable.Instance.IsCs2DslSymbol(tArgs[0])) {
                    useTypeNameString = true;
                }
            }
            if (IsExtensionMethod) {
                var args = new List<ExpressionSyntax>();
                args.Add(exp);
                args.AddRange(Args);
                cs2dsl.OutputArgumentList(args, DefaultValueArgs, GenericTypeArgs, ExternOverloadedMethodSignature, PostPositionGenericTypeArgs, ArrayToParams, useTypeNameString, node, ArgConversions.ToArray());
            } else {
                cs2dsl.OutputArgumentList(Args, DefaultValueArgs, GenericTypeArgs, ExternOverloadedMethodSignature, PostPositionGenericTypeArgs, ArrayToParams, useTypeNameString, node, ArgConversions.ToArray());
            }
            codeBuilder.Append(")");
        }

        private void Init(IMethodSymbol sym)
        {
            MethodSymbol = sym;
            CheckInvocation(sym);

            Args.Clear();
            ArgConversions.Clear();
            ReturnArgs.Clear();
            GenericTypeArgs.Clear();
            
            ClassKey = ClassInfo.GetFullName(sym.ContainingType);
            GenericClassKey = ClassInfo.GetFullNameWithTypeParameters(sym.ContainingType);
            IsEnumClass = sym.ContainingType.TypeKind == TypeKind.Enum || ClassKey == SymbolTable.PrefixExternClassName("System.Enum");
            IsExtensionMethod = sym.IsExtensionMethod && SymbolTable.Instance.IsCs2DslSymbol(sym);
            IsBasicValueMethod = SymbolTable.IsBasicValueMethod(sym);
            IsArrayStaticMethod = ClassKey == SymbolTable.PrefixExternClassName("System.Array") && sym.IsStatic;
            IsExternMethod = !SymbolTable.Instance.IsCs2DslSymbol(sym);

            if ((ClassKey == SymbolTable.PrefixExternClassName("UnityEngine.GameObject") || ClassKey == SymbolTable.PrefixExternClassName("UnityEngine.Component")) && (sym.Name.StartsWith("GetComponent") || sym.Name.StartsWith("AddComponent"))) {
                IsComponentGetOrAdd = true;
            }

            NonGenericMethodSymbol = null;
            PostPositionGenericTypeArgs = false;
            if (sym.IsGenericMethod) {
                bool existNonGenericVersion = true;
                var ctype = sym.ContainingType;
                var syms = ctype.GetMembers(sym.Name);
                if (null != syms) {
                    foreach(var isym in syms) {
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
                            for(int i = 0; i < sym.Parameters.Length; ++i) {
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
                            } else {
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
            }
            
            ExternOverloadedMethodSignature = string.Empty;
            if (IsExternMethod) {
                var syms = sym.ContainingType.GetMembers(sym.Name);
                if (null != syms) {
                    int mcount = 0;
                    foreach (var isym in syms) {
                        var msym = isym as IMethodSymbol;
                        var fn = ClassInfo.GetFullName(msym.ContainingType);
                        if (null != msym && msym.DeclaredAccessibility == Accessibility.Public && !msym.IsImplicitlyDeclared) {
                            ++mcount;
                        }
                    }
                    if (mcount > 1) {
                        ExternOverloadedMethodSignature = SymbolTable.CalcOverloadedMethodSignature(sym, NonGenericMethodSymbol);
                    }
                }
            }
        }
        
        private void CheckInvocation(IMethodSymbol sym)
        {
            if (!SymbolTable.EnableTranslationCheck) {
                return;
            }
            if (ClassInfo.HasAttribute(sym, "Cs2Dsl.DontCheckAttribute")) {
                return;
            }
            if (null != CallerMethodSymbol && ClassInfo.HasAttribute(CallerMethodSymbol, "Cs2Dsl.DontCheckAttribute")) {
                return;
            }
            if (null != CallerTypeSymbol && ClassInfo.HasAttribute(CallerTypeSymbol, "Cs2Dsl.DontCheckAttribute")) {
                return;
            }

            if (!SymbolTable.Instance.IsCs2DslSymbol(sym)) {
                var ckey = ClassInfo.GetFullName(sym.ContainingType);
                var mkey = SymbolTable.Instance.NameMangling(sym);
                var id = string.Format("{0}.{1}", ckey, mkey);
                if (!SymbolTable.Instance.CheckedInvocations.Contains(id)) {
                    SymbolTable.Instance.CheckedInvocations.Add(id);

                    bool isOverload = false;
                    ClassSymbolInfo info;
                    if (SymbolTable.Instance.ClassSymbols.TryGetValue(ckey, out info)) {
                        info.SymbolOverloadFlags.TryGetValue(sym.Name, out isOverload);
                    }

                    foreach (var param in sym.Parameters) {
                        if (param.IsParams && isOverload) {
                            Logger.Instance.Log("Translation Warning", "extern overloaded method {0}.{1} parameter {2} is params, please check export api code !", ckey, sym.Name, param.Name);
                            continue;
                        }
                        var namedType = param.Type as INamedTypeSymbol;
                        if (null != namedType && !SymbolTable.Instance.IsCs2DslSymbol(namedType) && namedType.IsGenericType && namedType.TypeKind != TypeKind.Delegate) {
                            var fullName = ClassInfo.GetFullName(namedType);
                            Logger.Instance.Log("Translation Warning", "extern method {0}.{1} parameter {2} is generic type, please replace with non generic type !", ckey, sym.Name, param.Name);
                            continue;
                        }
                    }
                }
            }
        }

        private void RecordRefArray(ExpressionSyntax exp)
        {
            if (IsArrayStaticMethod) {
                if (null == FirstRefArray) {
                    FirstRefArray = exp;
                } else if (null == SecondRefArray) {
                    SecondRefArray = exp;
                }
            }
        }

        internal static void TryAddExternEnum(bool isEnumClass, ExpressionSyntax exp, SemanticModel model)
        {
            if (isEnumClass) {
                var oper = model.GetOperation(exp);
                if (!SymbolTable.Instance.IsCs2DslSymbol(oper.Type) && oper.Type.TypeKind == TypeKind.Enum) {
                    string ckey = ClassInfo.GetFullName(oper.Type);
                    SymbolTable.Instance.AddExternEnum(ckey, oper.Type);
                } else {
                    var typeOf = oper as ITypeOfExpression;
                    if (null != typeOf && !SymbolTable.Instance.IsCs2DslSymbol(typeOf.TypeOperand) && typeOf.TypeOperand.TypeKind == TypeKind.Enum) {
                        string ckey = ClassInfo.GetFullName(typeOf.TypeOperand);
                        SymbolTable.Instance.AddExternEnum(ckey, typeOf.TypeOperand);
                    }
                }
            }
        }

        internal static string CalcInvokeTarget(bool isEnumClass, string classKey, CsDslTranslater cs2dsl, ExpressionSyntax exp, SemanticModel model)
        {
            TryAddExternEnum(isEnumClass, exp, model);
            string ckey = classKey;
            if (isEnumClass) {
                var oper = model.GetOperation(exp);
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