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
    internal class InvocationInfo
    {
        internal string ClassKey = string.Empty;
        internal List<ExpressionSyntax> Args = new List<ExpressionSyntax>();
        internal List<ExpressionSyntax> ReturnArgs = new List<ExpressionSyntax>();
        internal List<ITypeSymbol> GenericTypeArgs = new List<ITypeSymbol>();
        internal bool ArrayToParams = false;
        internal bool IsComponentGetOrAdd = false;
        internal bool IsBasicValueMethod = false;

        internal IMethodSymbol MethodSymbol = null;
        internal IAssemblySymbol AssemblySymbol = null;

        internal void Init(IMethodSymbol sym, ArgumentListSyntax argList, bool useExplicitTypeParam, SemanticModel model)
        {
            IAssemblySymbol assemblySym = SymbolTable.Instance.AssemblySymbol;
            Init(sym, useExplicitTypeParam);

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
                            if (sym.ContainingAssembly != assemblySym && SymbolTable.ForSlua) {
                                //外部类的方法的out参数,slua在调用时传入Slua.out,这里用null标记一下，在实际输出参数时再变为Slua.out
                                Args.Add(null);
                            }
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
                }
            }
        }

        internal void Init(IMethodSymbol sym, BracketedArgumentListSyntax argList, bool useExplicitTypeParam, SemanticModel model)
        {
            IAssemblySymbol assemblySym = SymbolTable.Instance.AssemblySymbol; 
            Init(sym, useExplicitTypeParam);

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
                            if (sym.ContainingAssembly != assemblySym && SymbolTable.ForSlua) {
                                //外部类的方法的out参数,slua在调用时传入Slua.out,这里用null标记一下，在实际输出参数时再变为Slua.out
                                Args.Add(null);
                            }
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
                }
            }
        }

        internal void Init(IMethodSymbol sym, List<ExpressionSyntax> argList, bool useExplicitTypeParam, SemanticModel model)
        {
            Init(sym, useExplicitTypeParam);

            if (null != argList) {
                for (int i = 0; i < argList.Count; ++i) {
                    var arg = argList[i];
                }
                Args.AddRange(argList);
            }
        }
        
        internal void OutputInvocation(StringBuilder codeBuilder, CsLuaTranslater cs2lua, ExpressionSyntax exp, bool isMemberAccess, SemanticModel model, SyntaxNode node)
        {
            IMethodSymbol sym = MethodSymbol;
            string mname = cs2lua.NameMangling(sym);
            string prestr = string.Empty;
            if (isMemberAccess) {
                string fnOfIntf = "nil";
                bool isExplicitInterfaceInvoke = cs2lua.CheckExplicitInterfaceAccess(sym, ref fnOfIntf);
                if (isExplicitInterfaceInvoke) {
                    codeBuilder.Append("invokewithinterface(");
                    cs2lua.VisitExpressionSyntax(exp);
                    codeBuilder.Append(", ");
                    codeBuilder.AppendFormat("{0}, \"{1}\"", fnOfIntf, mname);
                    prestr = ", ";
                } else {
                    if (IsBasicValueMethod) {
                        codeBuilder.Append("invokeforbasicvalue(");
                        cs2lua.VisitExpressionSyntax(exp);
                        codeBuilder.Append(", ");
                        codeBuilder.AppendFormat("{0}, \"{1}\"", ClassKey, mname);
                        prestr = ", ";
                    } else {
                        if (sym.IsStatic) {
                            codeBuilder.Append(ClassKey);
                            codeBuilder.Append(".");
                        } else {
                            cs2lua.VisitExpressionSyntax(exp);
                            codeBuilder.Append(":");
                        }
                        codeBuilder.Append(mname);
                        codeBuilder.Append("(");
                    }
                }
            } else {
                if (sym.MethodKind == MethodKind.DelegateInvoke) {
                    cs2lua.VisitExpressionSyntax(exp);
                } else if (sym.IsStatic) {
                    codeBuilder.AppendFormat("{0}.", ClassKey);
                    codeBuilder.Append(mname);
                } else {
                    codeBuilder.Append("this:");
                    codeBuilder.Append(mname);
                }
                codeBuilder.Append("(");
            }
            if (Args.Count > 0 || GenericTypeArgs.Count > 0) {
                codeBuilder.Append(prestr);
            }
            bool useTypeNameString = false;
            if(IsComponentGetOrAdd && SymbolTable.LuaComponentByString){
                if (sym.TypeArguments.Length > 0 && sym.TypeArguments[0].ContainingAssembly == AssemblySymbol) {
                    useTypeNameString = true;
                }
            }
            cs2lua.OutputArgumentList(Args, GenericTypeArgs, ArrayToParams, useTypeNameString, node);
            codeBuilder.Append(")");
        }

        private void Init(IMethodSymbol sym, bool useExplicitTypeParam)
        {
            MethodSymbol = sym;
            AssemblySymbol = SymbolTable.Instance.AssemblySymbol;;

            Args.Clear();
            ReturnArgs.Clear();
            GenericTypeArgs.Clear();
            
            ClassKey = ClassInfo.CalcMemberReference(sym);
            IsBasicValueMethod = SymbolTable.IsBasicValueMethod(sym);

            if ((ClassKey == "UnityEngine.GameObject" || ClassKey == "UnityEngine.Component") && (sym.Name.StartsWith("GetComponent") || sym.Name.StartsWith("AddComponent"))) {
                IsComponentGetOrAdd = true;
            }

            if (sym.IsGenericMethod) {
                foreach (var arg in sym.TypeArguments) {
                    GenericTypeArgs.Add(arg);
                }
            }

            if (useExplicitTypeParam && (sym.MethodKind == MethodKind.Constructor || sym.MethodKind == MethodKind.StaticConstructor || sym.IsStatic)) {
                INamedTypeSymbol type = sym.ContainingType;
                while (null != type) {
                    if (type.IsGenericType) {
                        foreach (var arg in type.TypeArguments) {
                            GenericTypeArgs.Add(arg);
                        }
                    }
                    type = type.ContainingType;
                }
            }
        }
    }
}