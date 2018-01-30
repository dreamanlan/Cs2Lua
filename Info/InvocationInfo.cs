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
        internal bool IsExtensionMethod = false;
        internal bool IsComponentGetOrAdd = false;
        internal bool IsBasicValueMethod = false;
        internal bool IsArrayStaticMethod = false;
        internal ExpressionSyntax FirstRefArray = null;
        internal ExpressionSyntax SecondRefArray = null;

        internal IMethodSymbol MethodSymbol = null;

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
                    TryAddExternEnum(ClassKey, arg.Expression, model);
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
                            //方法的out参数，为与Slua的机制一致，在调用时传入__cs2lua_out，这里用null标记一下，在实际输出参数时再变为__cs2lua_out
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
                        if (decl.Length == 1) {
                            var node = param.DeclaringSyntaxReferences[0].GetSyntax() as ParameterSyntax;
                            if (null != node) {
                                var exp = node.Default.Value;
                                var tree = node.SyntaxTree;
                                var newModel = SymbolTable.Instance.Compilation.GetSemanticModel(tree, true);
                                if (null != newModel) {
                                    var oper = newModel.GetOperation(exp);
                                    //var dsym = newModel.GetSymbolInfo(exp).Symbol;
                                    DefaultValueArgs.Add(new ArgDefaultValueInfo { Value = param.ExplicitDefaultValue, OperOrSym = oper });
                                }
                            }
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
                    TryAddExternEnum(ClassKey, arg.Expression, model);
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
                            //方法的out参数，为与Slua的机制一致，在调用时传入__cs2lua_out，这里用null标记一下，在实际输出参数时再变为__cs2lua_out
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
                        if (decl.Length == 1) {
                            var node = param.DeclaringSyntaxReferences[0].GetSyntax() as ParameterSyntax;
                            if (null != node) {
                                var exp = node.Default.Value;
                                var tree = node.SyntaxTree;
                                var newModel = SymbolTable.Instance.Compilation.GetSemanticModel(tree, true);
                                if (null != newModel) {
                                    var oper = newModel.GetOperation(exp);
                                    //var dsym = newModel.GetSymbolInfo(exp).Symbol;
                                    DefaultValueArgs.Add(new ArgDefaultValueInfo { Value = param.ExplicitDefaultValue, OperOrSym = oper });
                                }
                            }
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
                    TryAddExternEnum(ClassKey, arg, model);
                    Args.Add(arg);
                    if (i < opds.Length)
                        ArgConversions.Add(opds[i]);
                    else
                        ArgConversions.Add(null);
                }
            }
        }
        
        internal void OutputInvocation(StringBuilder codeBuilder, CsLuaTranslater cs2lua, ExpressionSyntax exp, bool isMemberAccess, SemanticModel model, SyntaxNode node)
        {
            IMethodSymbol sym = MethodSymbol;
            string mname = cs2lua.NameMangling(IsExtensionMethod && null != sym.ReducedFrom ? sym.ReducedFrom : sym);
            string prestr = string.Empty;
            if (isMemberAccess) {
                string fnOfIntf = "nil";
                bool isExplicitInterfaceInvoke = cs2lua.CheckExplicitInterfaceAccess(sym, ref fnOfIntf);
                if (sym.MethodKind == MethodKind.DelegateInvoke) {
                    var memberAccess  = node as MemberAccessExpressionSyntax;
                    if (null != memberAccess) {
                        cs2lua.OutputExpressionSyntax(exp);
                        codeBuilder.Append(".");
                        codeBuilder.Append(memberAccess.Name);
                        codeBuilder.Append("(");
                    } else {
                        //error;
                    }
                } else if (isExplicitInterfaceInvoke) {
                    codeBuilder.Append("invokewithinterface(");
                    cs2lua.OutputExpressionSyntax(exp);
                    codeBuilder.Append(", ");
                    codeBuilder.AppendFormat("{0}, \"{1}\"", fnOfIntf, mname);
                    prestr = ", ";
                } else if (IsExtensionMethod) {
                    codeBuilder.Append(ClassKey);
                    codeBuilder.Append(".");
                    codeBuilder.Append(mname);
                    codeBuilder.Append("(");
                } else if (IsBasicValueMethod) {
                    string ckey = CalcInvokeTarget(ClassKey, cs2lua, exp, model);
                    codeBuilder.Append("invokeforbasicvalue(");
                    cs2lua.OutputExpressionSyntax(exp);
                    codeBuilder.Append(", ");
                    codeBuilder.AppendFormat("{0}, {1}, \"{2}\"", ClassKey == SymbolTable.PrefixExternClassName("System.Enum") ? "true" : "false", ckey, mname);
                    prestr = ", ";
                } else if (IsArrayStaticMethod) {
                    codeBuilder.Append("invokearraystaticmethod(");
                    if (null == FirstRefArray) {
                        codeBuilder.Append("nil, ");
                    } else {
                        cs2lua.OutputExpressionSyntax(FirstRefArray);
                        codeBuilder.Append(", ");
                    }
                    if (null == SecondRefArray) {
                        codeBuilder.Append("nil, ");
                    } else {
                        cs2lua.OutputExpressionSyntax(SecondRefArray);
                        codeBuilder.Append(", ");
                    }
                    codeBuilder.AppendFormat("\"{0}\"", mname);
                    prestr = ", ";
                } else {
                    if (sym.IsStatic) {
                        codeBuilder.Append(ClassKey);
                        codeBuilder.Append(".");
                    } else {
                        cs2lua.OutputExpressionSyntax(exp);
                        codeBuilder.Append(":");
                    }
                    codeBuilder.Append(mname);
                    codeBuilder.Append("(");
                }
            } else {
                if (sym.MethodKind == MethodKind.DelegateInvoke) {
                    cs2lua.OutputExpressionSyntax(exp);
                } else if (sym.IsStatic) {
                    codeBuilder.AppendFormat("{0}.", ClassKey);
                    codeBuilder.Append(mname);
                } else {
                    codeBuilder.Append("this:");
                    codeBuilder.Append(mname);
                }
                codeBuilder.Append("(");
            }
            if (Args.Count + DefaultValueArgs.Count + GenericTypeArgs.Count > 0) {
                codeBuilder.Append(prestr);
            }
            bool useTypeNameString = false;
            if(IsComponentGetOrAdd && SymbolTable.LuaComponentByString){
                var tArgs = sym.TypeArguments;
                if (tArgs.Length > 0 && SymbolTable.Instance.IsCs2LuaSymbol(tArgs[0])) {
                    useTypeNameString = true;
                }
            }
            if (IsExtensionMethod) {
                var args = new List<ExpressionSyntax>();
                args.Add(exp);
                args.AddRange(Args);
                cs2lua.OutputArgumentList(args, DefaultValueArgs, GenericTypeArgs, ArrayToParams, useTypeNameString, node, ArgConversions.ToArray());
            } else {
                cs2lua.OutputArgumentList(Args, DefaultValueArgs, GenericTypeArgs, ArrayToParams, useTypeNameString, node, ArgConversions.ToArray());
            }
            codeBuilder.Append(")");
        }

        private void Init(IMethodSymbol sym)
        {
            MethodSymbol = sym;

            Args.Clear();
            ArgConversions.Clear();
            ReturnArgs.Clear();
            GenericTypeArgs.Clear();
            
            ClassKey = ClassInfo.GetFullName(sym.ContainingType);
            GenericClassKey = ClassInfo.GetFullNameWithTypeParameters(sym.ContainingType);
            IsExtensionMethod = sym.IsExtensionMethod && SymbolTable.Instance.IsCs2LuaSymbol(sym);
            IsBasicValueMethod = SymbolTable.IsBasicValueMethod(sym);
            IsArrayStaticMethod = ClassKey == SymbolTable.PrefixExternClassName("System.Array") && sym.IsStatic;

            if ((ClassKey == SymbolTable.PrefixExternClassName("UnityEngine.GameObject") || ClassKey == SymbolTable.PrefixExternClassName("UnityEngine.Component")) && (sym.Name.StartsWith("GetComponent") || sym.Name.StartsWith("AddComponent"))) {
                IsComponentGetOrAdd = true;
            }

            if (sym.IsGenericMethod) {
                foreach (var arg in sym.TypeArguments) {
                    GenericTypeArgs.Add(arg);
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

        internal static void TryAddExternEnum(string classKey, ExpressionSyntax exp, SemanticModel model)
        {
            if (classKey == SymbolTable.PrefixExternClassName("System.Enum")) {
                var oper = model.GetOperation(exp);
                if (!SymbolTable.Instance.IsCs2LuaSymbol(oper.Type) && oper.Type.TypeKind == TypeKind.Enum) {
                    string ckey = ClassInfo.GetFullName(oper.Type);
                    SymbolTable.Instance.AddExternEnum(ckey, oper.Type);
                } else {
                    var typeOf = oper as ITypeOfExpression;
                    if (null != typeOf && !SymbolTable.Instance.IsCs2LuaSymbol(typeOf.TypeOperand) && typeOf.TypeOperand.TypeKind == TypeKind.Enum) {
                        string ckey = ClassInfo.GetFullName(typeOf.TypeOperand);
                        SymbolTable.Instance.AddExternEnum(ckey, typeOf.TypeOperand);
                    }
                }
            }
        }

        internal static string CalcInvokeTarget(string classKey, CsLuaTranslater cs2lua, ExpressionSyntax exp, SemanticModel model)
        {
            TryAddExternEnum(classKey, exp, model);
            string ckey = classKey;
            if (classKey == SymbolTable.PrefixExternClassName("System.Enum")) {
                var oper = model.GetOperation(exp);
                if (oper.Type.TypeKind == TypeKind.Enum) {
                    var ci = cs2lua.GetCurClassInfo();
                    ci.AddReference(oper.Type);

                    ckey = ClassInfo.GetFullName(oper.Type);
                }
            }
            return ckey;
        }
    }
}