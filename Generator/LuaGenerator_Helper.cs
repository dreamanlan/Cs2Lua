using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;

namespace Generator
{
    internal static partial class LuaGenerator
    {
        private static bool ExistEmbedFunctionObject(Dsl.FunctionData data)
        {
            if (!data.HaveId() && !data.IsHighOrder && data.GetParamNum() == 1) {
                var func = data.GetParam(0) as Dsl.FunctionData;
                if (null != func) {
                    return ExistEmbedFunctionObject(func);
                }
                else {
                    return false;
                }
            }
            if (data.GetId() == "function" && data.IsHighOrder) {
                var call = data.LowerOrderFunction;
                if (call.GetParamNum() == 0) {
                    foreach (var p in data.Params) {
                        if (ExistFunctionObject(p))
                            return true;
                    }
                }
            }
            return false;
        }
        private static bool ExistFunctionObject(Dsl.ISyntaxComponent data)
        {
            var funcData = data as Dsl.FunctionData;
            if (null != funcData) {
                return ExistFunctionObject(funcData);
            }
            else {
                var stData = data as Dsl.StatementData;
                if (null != stData) {
                    return ExistFunctionObject(stData);
                }
                else {
                    return false;
                }
            }
        }
        private static bool ExistFunctionObject(Dsl.FunctionData data)
        {
            if (!data.IsHighOrder && data.GetId() == "function")
                return true;
            else {
                foreach(var p in data.Params) {
                    if(ExistFunctionObject(p))
                        return true;
                }
                if (data.IsHighOrder) {
                    if (ExistFunctionObject(data.LowerOrderFunction))
                        return true;
                }
                return false;
            }
        }
        private static bool ExistFunctionObject(Dsl.StatementData data)
        {
            foreach(var func in data.Functions) {
                if (ExistFunctionObject(func))
                    return true;
            }
            return false;
        }
        private static void GenerateClosure(Dsl.FunctionData data, StringBuilder sb, int indent, bool forRemove, DslExpression.DslCalculator calculator)
        {
            var fcall = data.LowerOrderFunction;
            bool fullCode = fcall.GetParamId(0) == "true";
            string localName = fcall.GetParamId(1);
            bool needDecl = (bool)Convert.ChangeType(fcall.GetParamId(2), typeof(bool));
            if (forRemove) {
                if (needDecl) {
                    sb.AppendFormatLine("{0}local {1};", GetIndentString(indent), localName);
                }
                GenerateStatements(data, sb, indent, calculator);
            }
            else if (fullCode) {
                sb.AppendLine("(function() ");
                if (data.HaveStatement()) {
                    ++indent;
                    if (needDecl) {
                        sb.AppendFormatLine("{0}local {1};", GetIndentString(indent), localName);
                    }
                    GenerateStatements(data, sb, indent, calculator);
                    sb.AppendFormatLine("{0}return {1};", GetIndentString(indent), localName);
                    --indent;
                }
                sb.AppendFormat("{0}end)()", GetIndentString(indent));
            }
            else {
                sb.Append(localName);
            }
        }
        private static bool CanRemoveClosure(Dsl.ISyntaxComponent param)
        {
            Dsl.FunctionData closure;
            return CanRemoveClosure(param, out closure);
        }
        private static bool CanRemoveClosure(Dsl.ISyntaxComponent param, out Dsl.FunctionData closure)
        {
            bool first = true;
            closure = null;
            return CanRemoveClosure(param, ref first, ref closure);
        }
        private static bool CanRemoveClosure(Dsl.ISyntaxComponent param, ref bool first, ref Dsl.FunctionData closure)
        {
            var funcData = param as Dsl.FunctionData;
            if (null != funcData) {
                return CanRemoveClosure(funcData, ref first, ref closure);
            }
            else {
                var stData = param as Dsl.StatementData;
                if (null != stData) {
                    return CanRemoveClosure(stData, ref first, ref closure);
                }
            }
            closure = null;
            return false;
        }
        private static bool CanRemoveClosure(Dsl.FunctionData param, ref bool first, ref Dsl.FunctionData closure)
        {
            if (param.IsHighOrder) {
                var fcall = param.LowerOrderFunction;
                if(!fcall.IsHighOrder && fcall.GetId() == "execclosure") {
                    closure = param;
                    return first;
                }
                if (CanRemoveClosure(fcall, ref first, ref closure))
                    return true;
                foreach (var p in param.Params) {
                    if (CanRemoveClosure(p, ref first, ref closure))
                        return true;
                    var vd = p as Dsl.ValueData;
                    if (null != vd && vd.GetIdType() == Dsl.ValueData.ID_TOKEN) {
                        first = false;
                    }
                    if (!first)
                        return false;
                }
                return false;
            }
            else {
                foreach (var p in param.Params) {
                    if (CanRemoveClosure(p, ref first, ref closure))
                        return true;
                    var vd = p as Dsl.ValueData;
                    if (null != vd && vd.GetIdType() == Dsl.ValueData.ID_TOKEN) {
                        first = false;
                    }
                    if (!first)
                        return false;
                }
            }
            return false;
        }
        private static bool CanRemoveClosure(Dsl.StatementData param, ref bool first, ref Dsl.FunctionData closure)
        {
            foreach (var func in param.Functions) {
                if (CanRemoveClosure(func, ref first, ref closure))
                    return true;
                if (!first)
                    return false;
            }
            return false;
        }
        private static bool CanSplitPrefixPostfixOperator(Dsl.ISyntaxComponent data)
        {
            Dsl.FunctionData oper;
            bool prefix;
            return CanSplitPrefixPostfixOperator(data, out oper, out prefix);
        }
        private static bool CanSplitPrefixPostfixOperator(Dsl.ISyntaxComponent data, out Dsl.FunctionData oper, out bool prefix)
        {
            oper = null;
            prefix = false;
            Dsl.ValueData var = null;
            if(DetectPrefixPostfixOperator(data, ref oper, ref var, ref prefix) 
                && !DetectVariable(data, oper, var)) {
                return true;
            }
            return false;
        }
        private static void GeneratePrefixPostfixOperator(Dsl.FunctionData data, StringBuilder sb, bool forSplit, DslExpression.DslCalculator calculator)
        {
            string id = data.GetId();
            if (id == "prefixoperator") {
                var fullCode = data.GetParamId(0) == "true";
                var varExp = data.GetParam(1);
                var opExp = data.GetParam(2);
                if (forSplit) {
                    GenerateSyntaxComponent(varExp, sb, 0, false, calculator);
                    sb.Append(" = ");
                    GenerateSyntaxComponent(opExp, sb, 0, false, calculator);
                }
                else if (fullCode) {
                    sb.Append("(function() ");
                    GenerateSyntaxComponent(varExp, sb, 0, false, calculator);
                    sb.Append(" = ");
                    GenerateSyntaxComponent(opExp, sb, 0, false, calculator);
                    sb.Append("; return ");
                    GenerateSyntaxComponent(varExp, sb, 0, false, calculator);
                    sb.Append("; end)()");
                }
                else {
                    GenerateSyntaxComponent(varExp, sb, 0, false, calculator);
                }
            }
            else if (id == "postfixoperator") {
                var fullCode = data.GetParamId(0) == "true";
                var oldVal = data.GetParamId(1);
                var varExp = data.GetParam(2);
                var opExp = data.GetParam(3);
                if (forSplit) {
                    sb.Append("local ");
                    sb.Append(oldVal);
                    sb.Append(" = ");
                    GenerateSyntaxComponent(varExp, sb, 0, false, calculator);
                    sb.Append("; ");
                    GenerateSyntaxComponent(varExp, sb, 0, false, calculator);
                    sb.Append(" = ");
                    GenerateSyntaxComponent(opExp, sb, 0, false, calculator);
                }
                else if (fullCode) {
                    sb.Append("(function() local ");
                    sb.Append(oldVal);
                    sb.Append(" = ");
                    GenerateSyntaxComponent(varExp, sb, 0, false, calculator);
                    sb.Append("; ");
                    GenerateSyntaxComponent(varExp, sb, 0, false, calculator);
                    sb.Append(" = ");
                    GenerateSyntaxComponent(opExp, sb, 0, false, calculator);
                    sb.Append("; return ");
                    sb.Append(oldVal);
                    sb.Append("; end)()");
                }
                else {
                    sb.Append(oldVal);
                }
            }
        }
        private static bool DetectPrefixPostfixOperator(Dsl.ISyntaxComponent data, ref Dsl.FunctionData oper, ref Dsl.ValueData var, ref bool prefix)
        {
            var funcData = data as Dsl.FunctionData;
            if (null != funcData) {
                return DetectPrefixPostfixOperator(funcData, ref oper, ref var, ref prefix);
            }
            else {
                var stData = data as Dsl.StatementData;
                if (null != stData) {
                    return DetectPrefixPostfixOperator(stData, ref oper, ref var, ref prefix);
                }
                else {
                    return false;
                }
            }
        }
        private static bool DetectPrefixPostfixOperator(Dsl.FunctionData data, ref Dsl.FunctionData oper, ref Dsl.ValueData var, ref bool prefix)
        {
            if (data.IsHighOrder) {
                foreach (var p in data.Params) {
                    if (DetectPrefixPostfixOperator(p, ref oper, ref var, ref prefix))
                        return true;
                }
                if (DetectPrefixPostfixOperator(data.LowerOrderFunction, ref oper, ref var, ref prefix))
                    return true;
                return false;
            }
            else {
                if (data.GetId() == "prefixoperator") {
                    var varExp = data.GetParam(1) as Dsl.ValueData;
                    if (null != varExp) {
                        oper = data;
                        var = varExp;
                        prefix = true;
                        return true;
                    }
                }
                else if(data.GetId() == "postfixoperator") {
                    var varExp = data.GetParam(2) as Dsl.ValueData;
                    if (null != varExp) {
                        oper = data;
                        var = varExp;
                        prefix = false;
                        return true;
                    }
                }
                else {
                    foreach (var p in data.Params) {
                        if (DetectPrefixPostfixOperator(p, ref oper, ref var, ref prefix))
                            return true;
                    }
                }
                return false;
            }
        }
        private static bool DetectPrefixPostfixOperator(Dsl.StatementData data, ref Dsl.FunctionData oper, ref Dsl.ValueData var, ref bool prefix)
        {
            foreach (var func in data.Functions) {
                if (DetectPrefixPostfixOperator(func, ref oper, ref var, ref prefix))
                    return true;
            }
            return false;
        }
        private static bool DetectVariable(Dsl.ISyntaxComponent data, Dsl.FunctionData oper, Dsl.ValueData var)
        {
            var funcData = data as Dsl.FunctionData;
            if (null != funcData) {
                return DetectVariable(funcData, oper, var);
            }
            else {
                var stData = data as Dsl.StatementData;
                if (null != stData) {
                    return DetectVariable(stData, oper, var);
                }
                else {
                    var valData = data as Dsl.ValueData;
                    if (null != valData) {
                        return DetectVariable(valData, oper, var);
                    }
                    else {
                        return false;
                    }
                }
            }
        }
        private static bool DetectVariable(Dsl.ValueData data, Dsl.FunctionData oper, Dsl.ValueData var)
        {
            return CompareVariable(data, var);
        }
        private static bool DetectVariable(Dsl.FunctionData data, Dsl.FunctionData oper, Dsl.ValueData var)
        {
            if (data == oper)
                return false;
            if (data.HaveParamOrStatement()) {
                foreach(var p in data.Params) {
                    if (DetectVariable(p, oper, var))
                        return true;
                }
            }
            if (data.IsHighOrder) {
                return DetectVariable(data.LowerOrderFunction, oper, var);
            }
            return false;
        }
        private static bool DetectVariable(Dsl.StatementData data, Dsl.FunctionData oper, Dsl.ValueData var)
        {
            foreach(var func in data.Functions) {
                if (DetectVariable(func, oper, var))
                    return true;
            }
            return false;
        }
        private static bool CompareVariable(Dsl.ValueData data, Dsl.ValueData var)
        {
            return data.GetId() == var.GetId();
        }
    }
}
