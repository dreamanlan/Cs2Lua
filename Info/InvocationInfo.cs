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

        internal IMethodSymbol MethodSymbol = null;
        internal IAssemblySymbol AssemblySymbol = null;

        internal void Init(IMethodSymbol sym, IAssemblySymbol assemblySym, ArgumentListSyntax argList, bool useExplicitTypeParam, SemanticModel model)
        {
            Init(sym, assemblySym, useExplicitTypeParam);

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

        internal void Init(IMethodSymbol sym, IAssemblySymbol assemblySym, BracketedArgumentListSyntax argList, bool useExplicitTypeParam, SemanticModel model)
        {
            Init(sym, assemblySym, useExplicitTypeParam);

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

        internal void Init(IMethodSymbol sym, IAssemblySymbol assemblySym, List<ExpressionSyntax> argList, bool useExplicitTypeParam, SemanticModel model)
        {
            Init(sym, assemblySym, useExplicitTypeParam);

            if (null != argList) {
                for (int i = 0; i < argList.Count; ++i) {
                    var arg = argList[i];
                }
                Args.AddRange(argList);
            }
        }

        private void Init(IMethodSymbol sym, IAssemblySymbol assemblySym, bool useExplicitTypeParam)
        {
            MethodSymbol = sym;
            AssemblySymbol = assemblySym;

            Args.Clear();
            ReturnArgs.Clear();
            GenericTypeArgs.Clear();

            ClassKey = ClassInfo.CalcMemberReference(sym);

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