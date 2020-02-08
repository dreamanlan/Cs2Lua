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
    internal static class TypeChecker
    {
        internal static void CheckMemberAccess(SemanticModel model, MemberAccessExpressionSyntax node, IMethodSymbol callerSym)
        {
            var esym = model.GetSymbolInfo(node).Symbol as IEventSymbol;
            var psym = model.GetSymbolInfo(node).Symbol as IPropertySymbol;
            var fsym = model.GetSymbolInfo(node).Symbol as IFieldSymbol;
            var msym = model.GetSymbolInfo(node).Symbol as IMethodSymbol;
            var oper = model.GetOperation(node);

            bool isExtern = false;
            INamedTypeSymbol classType = null;
            if (null != esym && !SymbolTable.Instance.IsCs2DslSymbol(esym)) {
                isExtern = true;
                classType = esym.ContainingType;
                Logger.Instance.Log(node, "unsupported extern event '{0}.{1}' !", ClassInfo.GetFullName(esym.ContainingType), esym.Name);
            }
            if (null != psym && !SymbolTable.Instance.IsCs2DslSymbol(psym)) {
                isExtern = true;
                classType = psym.ContainingType;
                if (SymbolTable.Instance.IsIllegalProperty(psym)) {
                    Logger.Instance.Log(node, "unsupported extern property '{0}.{1}' !", ClassInfo.GetFullName(psym.ContainingType), psym.Name);
                }
            }
            if (null != fsym && !SymbolTable.Instance.IsCs2DslSymbol(fsym)) {
                isExtern = true;
                classType = fsym.ContainingType;
                if (SymbolTable.Instance.IsIllegalField(fsym)) {
                    Logger.Instance.Log(node, "unsupported extern field '{0}.{1}' !", ClassInfo.GetFullName(fsym.ContainingType), fsym.Name);
                }
            }
            if (null != msym && !(node.Parent is InvocationExpressionSyntax) && !SymbolTable.Instance.IsCs2DslSymbol(msym.ContainingType)) {
                if (SymbolTable.Instance.IsIllegalMethod(msym)) {
                    Logger.Instance.Log(node, "unsupported extern event '{0}.{1}' !", ClassInfo.GetFullName(msym.ContainingType), msym.Name);
                }
            }
            if (isExtern && null != oper) {
                SymbolTable.TryRemoveNullable(ref classType);
                if (null != classType && (classType.TypeKind == TypeKind.Delegate || classType.IsGenericType && SymbolTable.Instance.IsLegalGenericType(classType, true))) {
                    //如果是标记为合法的泛型类或委托类型的成员，则不用再进行类型检查
                }
                else {
                    var type = oper.Type as INamedTypeSymbol;
                    SymbolTable.TryRemoveNullable(ref type);
                    if (null != type && !SymbolTable.Instance.IsCs2DslSymbol(type) && type.TypeKind != TypeKind.Delegate) {
                        if (type.IsGenericType) {
                            if (!SymbolTable.Instance.IsLegalParameterGenericType(type)) {
                                Logger.Instance.Log(node, "unsupported extern type '{0}' from member access !", SymbolTable.Instance.CalcFullNameAndTypeArguments(type));
                            }
                        }
                        else {
                            if (SymbolTable.Instance.IsIllegalType(type)) {
                                Logger.Instance.Log(node, "unsupported extern type '{0}' from member access !", SymbolTable.Instance.CalcFullNameAndTypeArguments(type));
                            }
                        }
                    }
                }
            }
        }
        internal static void CheckType(ITypeSymbol typeSym, SyntaxNode node, IMethodSymbol callerSym)
        {
            if (!SymbolTable.EnableTranslationCheck) {
                return;
            }
            if (null != callerSym && ClassInfo.HasAttribute(callerSym, "Cs2Dsl.DontCheckAttribute")) {
                return;
            }
            if (null != callerSym && ClassInfo.HasAttribute(callerSym.ContainingType, "Cs2Dsl.DontCheckAttribute")) {
                return;
            }
            var type = typeSym as INamedTypeSymbol;
            SymbolTable.TryRemoveNullable(ref type);
            if (null != type && !SymbolTable.Instance.IsCs2DslSymbol(type)) {
                if (type.IsGenericType) {
                    if (!SymbolTable.Instance.IsLegalGenericType(type)) {
                        Logger.Instance.Log(node, "unsupported extern generic type '{0}' !", SymbolTable.Instance.CalcFullNameAndTypeArguments(type));
                    }
                }
                else {
                    if (SymbolTable.Instance.IsIllegalType(type)) {
                        Logger.Instance.Log(node, "unsupported extern type '{0}' !", SymbolTable.Instance.CalcFullNameAndTypeArguments(type));
                    }
                }
            }
        }
        internal static void CheckConvert(ITypeSymbol srcTypeSym, ITypeSymbol targetTypeSym, SyntaxNode node, IMethodSymbol callerSym)
        {
            if (!SymbolTable.EnableTranslationCheck) {
                return;
            }
            if (null != callerSym && ClassInfo.HasAttribute(callerSym, "Cs2Dsl.DontCheckAttribute")) {
                return;
            }
            if (null != callerSym && ClassInfo.HasAttribute(callerSym.ContainingType, "Cs2Dsl.DontCheckAttribute")) {
                return;
            }
            var srcNamedTypeSym = srcTypeSym as INamedTypeSymbol;
            var targetNamedTypeSym = targetTypeSym as INamedTypeSymbol;
            SymbolTable.TryRemoveNullable(ref srcNamedTypeSym);
            SymbolTable.TryRemoveNullable(ref targetNamedTypeSym);
            if (null != srcNamedTypeSym && null != targetNamedTypeSym){
                if (null != srcNamedTypeSym.ContainingType && ClassInfo.GetFullName(srcNamedTypeSym) == "System.Object" && !SymbolTable.Instance.IsCs2DslSymbol(srcNamedTypeSym.ContainingType) && targetNamedTypeSym.TypeKind != TypeKind.Delegate && (targetNamedTypeSym.IsGenericType || SymbolTable.Instance.IsCs2DslSymbol(targetNamedTypeSym))) {
                    if (!SymbolTable.Instance.IsLegalConvertion(srcNamedTypeSym, targetNamedTypeSym)) {
                        Logger.Instance.Log(node, "can't convert extern type '{0}' to generic type '{1}' !", SymbolTable.Instance.CalcFullNameAndTypeArguments(srcNamedTypeSym), SymbolTable.Instance.CalcFullNameAndTypeArguments(targetNamedTypeSym));
                    }
                }
                else if (null != targetNamedTypeSym.ContainingType && ClassInfo.GetFullName(targetNamedTypeSym) == "System.Object" && !SymbolTable.Instance.IsCs2DslSymbol(targetNamedTypeSym.ContainingType) && srcNamedTypeSym.TypeKind != TypeKind.Delegate && (srcNamedTypeSym.IsGenericType || SymbolTable.Instance.IsCs2DslSymbol(srcNamedTypeSym))) {
                    if (!SymbolTable.Instance.IsLegalConvertion(srcNamedTypeSym, targetNamedTypeSym)) {
                        Logger.Instance.Log(node, "can't convert extern type '{0}' to generic type '{1}' !", SymbolTable.Instance.CalcFullNameAndTypeArguments(srcNamedTypeSym), SymbolTable.Instance.CalcFullNameAndTypeArguments(targetNamedTypeSym));
                    }
                }
                else if (srcNamedTypeSym.TypeKind == TypeKind.Delegate || targetNamedTypeSym.TypeKind == TypeKind.Delegate) {
                    //delegate之间赋值认为合法
                }
                else if (!srcNamedTypeSym.IsGenericType && !SymbolTable.Instance.IsCs2DslSymbol(srcNamedTypeSym) && targetNamedTypeSym.IsGenericType) {
                    if (!SymbolTable.Instance.IsLegalConvertion(srcNamedTypeSym, targetNamedTypeSym)) {
                        Logger.Instance.Log(node, "can't convert extern type '{0}' to generic type '{1}' !", SymbolTable.Instance.CalcFullNameAndTypeArguments(srcNamedTypeSym), SymbolTable.Instance.CalcFullNameAndTypeArguments(targetNamedTypeSym));
                    }
                }
            }
            if (null != targetNamedTypeSym && !SymbolTable.Instance.IsCs2DslSymbol(targetNamedTypeSym) && SymbolTable.Instance.IsIllegalType(targetNamedTypeSym)) {
                Logger.Instance.Log(node, "unsupported extern type '{0}' !", SymbolTable.Instance.CalcFullNameAndTypeArguments(targetNamedTypeSym));
            }
        }
        internal static void CheckInvocation(IMethodSymbol sym, IMethodSymbol callerSym)
        {
            if (!SymbolTable.EnableTranslationCheck) {
                return;
            }
            if (ClassInfo.HasAttribute(sym, "Cs2Dsl.DontCheckAttribute")) {
                return;
            }
            if (null != callerSym && ClassInfo.HasAttribute(callerSym, "Cs2Dsl.DontCheckAttribute")) {
                return;
            }
            if (null != callerSym && ClassInfo.HasAttribute(callerSym.ContainingType, "Cs2Dsl.DontCheckAttribute")) {
                return;
            }

            if (!SymbolTable.Instance.IsCs2DslSymbol(sym)) {
                var ckey = ClassInfo.GetFullName(sym.ContainingType);
                var id = string.Format("{0}.{1}", ckey, sym.Name);
                if (!SymbolTable.Instance.CheckedInvocations.Contains(id)) {
                    SymbolTable.Instance.CheckedInvocations.Add(id);

                    bool isOverload = false;
                    ClassSymbolInfo info;
                    if (SymbolTable.Instance.ClassSymbols.TryGetValue(ckey, out info)) {
                        info.SymbolOverloadFlags.TryGetValue(sym.Name, out isOverload);
                    }

                    string callerInfo = string.Empty;
                    if (null != callerSym) {
                        var callerClass = ClassInfo.GetFullName(callerSym.ContainingType);
                        var callerMethod = SymbolTable.Instance.NameMangling(callerSym);
                        callerInfo = string.Format(" caller:{0}.{1}", callerClass, callerMethod);
                    }

                    if (sym.IsExtensionMethod && !SymbolTable.Instance.IsLegalExtension(sym.ContainingType)) {
                        //不支持的语法
                        Logger.Instance.Log("Translation Error", "unsupported extern extension method {0}.{1} !{2}", ckey, sym.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                    }
                    else {
                        if (SymbolTable.Instance.IsIllegalMethod(sym)) {
                            Logger.Instance.Log("Translation Error", "unsupported extern method {0}.{1} !{2}", ckey, sym.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                        }
                    }

                    if (sym.ContainingType.TypeKind == TypeKind.Delegate || sym.ContainingType.IsGenericType && SymbolTable.Instance.IsLegalGenericType(sym.ContainingType, true) || sym.IsGenericMethod && SymbolTable.Instance.IsLegalGenericMethod(sym)) {
                        //如果是标记为合法的泛型类或委托类型的成员，则不用再进行类型检查
                    }
                    else {
                        foreach (var param in sym.Parameters) {
                            var type = param.Type as INamedTypeSymbol;
                            if (param.IsParams && isOverload) {
                                Logger.Instance.Log("Translation Warning", "extern overloaded method {0}.{1} parameter {2} is params, please check export api code !{3}", ckey, sym.Name, param.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                                continue;
                            }
                            if (null != type && type.TypeKind != TypeKind.Delegate) {
                                if (type.IsGenericType) {
                                    if (!SymbolTable.Instance.IsLegalParameterGenericType(type)) {
                                        Logger.Instance.Log("Translation Error", "extern method {0}.{1} parameter {2} is generic type, please replace with non generic type !{3}", ckey, sym.Name, param.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                                    }
                                }
                                else {
                                    if (SymbolTable.Instance.IsIllegalType(type)) {
                                        Logger.Instance.Log("Translation Error", "extern method {0}.{1} parameter {2} is unsupported type, please replace with non generic type !{3}", ckey, sym.Name, param.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                                    }
                                }
                            }
                        }
                        if (!sym.ReturnsVoid) {
                            var type = sym.ReturnType as INamedTypeSymbol;
                            if (null != type && type.TypeKind != TypeKind.Delegate) {
                                if (type.IsGenericType) {
                                    if (!SymbolTable.Instance.IsLegalParameterGenericType(type)) {
                                        Logger.Instance.Log("Translation Error", "extern method {0}.{1} return {2} is generic type, please replace with non generic type !{3}", ckey, sym.Name, type.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                                    }
                                }
                                else {
                                    if (SymbolTable.Instance.IsIllegalType(type)) {
                                        Logger.Instance.Log("Translation Error", "extern method {0}.{1} return {2} is unsupported type, please replace with non generic type !{3}", ckey, sym.Name, type.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
