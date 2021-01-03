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
    /// 一些C#层面合法但cs2lua需要限制的相关用法的类型检查。
    /// </summary>
    internal static class TypeChecker
    {
        internal static void CheckType(SemanticModel model, ITypeSymbol typeSym, SyntaxNode node, IMethodSymbol callerSym)
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
        internal static void CheckMemberAccess(SemanticModel model, MemberAccessExpressionSyntax node, IMethodSymbol callerSym)
        {
            var esym = model.GetSymbolInfoEx(node).Symbol as IEventSymbol;
            var psym = model.GetSymbolInfoEx(node).Symbol as IPropertySymbol;
            var fsym = model.GetSymbolInfoEx(node).Symbol as IFieldSymbol;
            var msym = model.GetSymbolInfoEx(node).Symbol as IMethodSymbol;
            var nodeType = model.GetTypeInfoEx(node).Type;

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
            if (isExtern && null != nodeType) {
                SymbolTable.TryRemoveNullable(ref classType);
                if (null != classType && (classType.TypeKind == TypeKind.Delegate || classType.IsGenericType && SymbolTable.Instance.IsLegalGenericType(classType, true))) {
                    //如果是标记为合法的泛型类或委托类型的成员，则不用再进行类型检查
                }
                else {
                    var type = nodeType as INamedTypeSymbol;
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
        internal static void CheckInvocation(SemanticModel model, IMethodSymbol sym, IList<ExpressionSyntax> args, IList<ArgDefaultValueInfo> nameOrDefValArgs, IList<IConversionOperation> argConversions, SyntaxNode node, IMethodSymbol callerSym)
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
                var oper = null != node ? model.GetOperationEx(node) as IInvocationOperation : null;
                var realType = null != oper && null != oper.Instance ? oper.Instance.Type : null;

                bool isOverload = false;
                ClassSymbolInfo info;
                if (SymbolTable.Instance.ClassSymbols.TryGetValue(ckey, out info)) {
                    info.SymbolOverloadFlags.TryGetValue(sym.Name, out isOverload);
                }

                string callerInfo = string.Empty;
                if (null != callerSym) {
                    var callerClass = ClassInfo.GetFullName(callerSym.ContainingType);
                    var callerMethod = SymbolTable.Instance.NameCs2DslMangling(callerSym);
                    callerInfo = string.Format(" caller:{0}.{1}", callerClass, callerMethod);
                }

                if (sym.IsExtensionMethod && !SymbolTable.Instance.IsLegalExtension(sym.ContainingType)) {
                    //不支持的语法
                    Logger.Instance.Log(node, "unsupported extern extension method {0}.{1} !{2}", ckey, sym.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                }
                else {
                    if (SymbolTable.Instance.IsIllegalMethod(sym)) {
                        Logger.Instance.Log(node, "unsupported extern method {0}.{1} !{2}", ckey, sym.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                    }
                }

                if (sym.ContainingType.TypeKind == TypeKind.Delegate ||
                    (null == realType || realType == sym.ContainingType) && sym.ContainingType.IsGenericType && SymbolTable.Instance.IsLegalGenericType(sym.ContainingType, true) ||
                    sym.IsGenericMethod && SymbolTable.Instance.IsLegalGenericMethod(sym)) {
                    //如果是标记为合法的泛型类或委托类型的成员，则不用再进行类型检查
                }
                else {
                    int ix = 0;
                    foreach (var param in sym.Parameters) {
                        ITypeSymbol _argType = null;
                        if (ix < args.Count)
                            _argType = null != args[ix] ? model.GetTypeInfoEx(args[ix]).Type : null;
                        else if (ix < args.Count + nameOrDefValArgs.Count)
                            _argType = nameOrDefValArgs[ix - args.Count].Type;
                        IConversionOperation argConv = null;
                        if(ix< argConversions.Count)
                            argConv = argConversions[ix];
                        ++ix;
                        INamedTypeSymbol argType = null;
                        if (null != _argType && (null == argConv || null == argConv.OperatorMethod)) {
                            argType = _argType as INamedTypeSymbol;
                        }
                        var paramType = param.Type as INamedTypeSymbol;
                        if (param.IsParams && isOverload) {
                            Logger.Instance.Log(node, "extern overloaded method {0}.{1} parameter {2} is params, please check export api code !{3}", ckey, sym.Name, param.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                            continue;
                        }
                        if (null != paramType && paramType.TypeKind != TypeKind.Delegate) {
                            bool isContainerIntf = paramType.Name == "IEnumerable" || paramType.Name == "ICollection" || paramType.Name == "IDictionary" || paramType.Name == "IList";
                            if (null != realType && SymbolTable.Instance.IsCs2DslSymbol(realType) && isContainerIntf && 
                                null != argType && (argType.IsGenericType || SymbolTable.Instance.IsCs2DslSymbol(argType))) {
                                Logger.Instance.Log(node, "extern method {0}.{1} parameter {2} can't assign a script object to it !{3}", ckey, sym.Name, param.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                            }
                            else if (paramType.IsGenericType) {
                                if (!SymbolTable.Instance.IsLegalParameterGenericType(paramType)) {
                                    Logger.Instance.Log(node, "extern method {0}.{1} parameter {2} is generic type, please replace with non generic type !{3}", ckey, sym.Name, param.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                                }
                            }
                            else {
                                if (SymbolTable.Instance.IsIllegalType(paramType)) {
                                    Logger.Instance.Log(node, "extern method {0}.{1} parameter {2} is unsupported type, please replace with non generic type !{3}", ckey, sym.Name, param.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                                }
                            }
                        }
                    }
                    if (!sym.ReturnsVoid) {
                        var type = sym.ReturnType as INamedTypeSymbol;
                        if (null != type && type.TypeKind != TypeKind.Delegate) {
                            if (type.IsGenericType) {
                                if (!SymbolTable.Instance.IsLegalParameterGenericType(type)) {
                                    Logger.Instance.Log(node, "extern method {0}.{1} return {2} is generic type, please replace with non generic type !{3}", ckey, sym.Name, type.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                                }
                            }
                            else {
                                if (SymbolTable.Instance.IsIllegalType(type)) {
                                    Logger.Instance.Log(node, "extern method {0}.{1} return {2} is unsupported type, please replace with non generic type !{3}", ckey, sym.Name, type.Name, string.IsNullOrEmpty(callerInfo) ? string.Empty : callerInfo);
                                }
                            }
                        }
                    }
                }
            }
        }
        internal static void CheckConvert(SemanticModel model, ITypeSymbol srcTypeSym, ITypeSymbol targetTypeSym, SyntaxNode node, IMethodSymbol callerSym)
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
            if (null != srcNamedTypeSym && null != targetNamedTypeSym) {
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
    }
}
