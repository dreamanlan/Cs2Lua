using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;

internal sealed class Cs2LuaMethodInfo
{
    internal string MethodName = string.Empty;
    internal bool ExistParam = false;
    internal bool ExistReturnParam = false;

    internal void Init(MethodInfo mi, System.Type type)
    {
        int ct = 0;
        var ms = Cs2LuaCodeGen.GetMethods(type);
        foreach (var m in ms) {
            if (m.Name == mi.Name) {
                ++ct;
            }
        }

        if (ct > 1) {
            MethodName = CalcMethodMangling(mi);
        } else {
            MethodName = mi.Name;
        }

        var ps = mi.GetParameters();
        ExistParam = ps.Length > 0;
        ExistReturnParam = false;
        foreach (var param in ps) {
            if (param.IsOut || param.ParameterType.IsByRef) {
                ExistReturnParam = true;
                break;
            }
        }
    }

    private static string CalcMethodMangling(MethodInfo mi)
    {
        if (null == mi)
            return string.Empty;
        StringBuilder sb = new StringBuilder();
        string name = mi.Name;
        if (name[0] == '.')
            name = name.Substring(1);
        sb.Append(name);
        var ps = mi.GetParameters();
        foreach (var param in ps) {
            sb.Append("__");
            if (param.IsOut) {
                sb.Append("Out_");
            } else if (param.ParameterType.IsByRef) {
                sb.Append("Ref_");
            }
            var pt = param.ParameterType;
            if (pt.IsArray) {
                sb.Append("Arr_");
                var arrType = pt.GetElementType();
                string fn;
                fn = CalcFullName(arrType);
                sb.Append(fn.Replace('.', '_'));
            } else if (pt.IsByRef) {
                pt = pt.GetElementType();
                string fn = CalcFullName(pt);
                sb.Append(fn.Replace('.', '_'));
            } else {
                string fn = CalcFullName(pt);
                sb.Append(fn.Replace('.', '_'));
            }
        }
        return sb.ToString();
    }
    private static string CalcFullName(System.Type type)
    {
        if (null == type)
            return string.Empty;
        List<string> list = new List<string>();
        list.Add(CalcNameWithTypeArguments(type));
        string ns = type.Namespace;
        var ct = type.DeclaringType;
        string name = string.Empty;
        if (null != ct) {
            name = CalcNameWithTypeArguments(ct);
        }
        while (null != ct && name.Length > 0) {
            list.Insert(0, name);
            ns = ct.Namespace;
            ct = ct.DeclaringType;
            if (null != ct) {
                name = CalcNameWithTypeArguments(ct);
            } else {
                name = string.Empty;
            }
        }
        if (!string.IsNullOrEmpty(ns)) {
            list.Insert(0, ns);
        }
        return string.Join(".", list.ToArray());
    }
    private static string CalcNameWithTypeArguments(System.Type type)
    {
        if (null == type)
            return string.Empty;
        List<string> list = new List<string>();
        if (type.IsGenericType) {
            string name = type.Name;
            int ix = name.IndexOf('`');
            if (ix > 0)
                list.Add(name.Substring(0, ix));
            else
                list.Add(name);
        } else {
            list.Add(type.Name);
        }
        var ts = type.GetGenericArguments();
        foreach (var arg in ts) {
            if (arg.IsGenericParameter) {
                list.Add(arg.Name);
            } else {
                var fn = CalcFullName(arg);
                list.Add(fn.Replace(".", "_"));
            }
        }
        return string.Join("_", list.ToArray());
    }
}

public static class Cs2LuaCodeGen
{
    [MenuItem("工具/Build/GenCs2LuaInterface", false, 100)]
    public static void GenInterfaces()
    {
    }

    [MenuItem("工具/Build/GenCs2LuaProxy", false, 100)]
    public static void GenProxies()
    {
    }

    private static void GenInterfaceCode(System.Type type, string name)
    {
        StringBuilder sb = new StringBuilder();
        s_Indent = 0;
        sb.AppendFormat("{0}using System;", GetIndentString());
        sb.AppendLine();
        sb.AppendFormat("{0}using System.Collections;", GetIndentString());
        sb.AppendLine();
        sb.AppendFormat("{0}using System.Collections.Generic;", GetIndentString());
        sb.AppendLine();
        sb.AppendLine();
        sb.AppendFormat("{0}public interface {1}", GetIndentString(), name);
        sb.AppendLine();
        sb.AppendFormat("{0}", GetIndentString());
        sb.AppendLine("{");
        ++s_Indent;
        foreach (var prop in GetProperties(type)) {
            string typeName = SimpleName(prop.PropertyType);
            var ps = prop.GetIndexParameters();
            if (ps.Length > 0) {
                sb.AppendFormat("{0}{1} {2}[", GetIndentString(), typeName, prop.Name);
                OutputParams(sb, ps);
                sb.AppendLine("]");
                sb.AppendFormat("{0}", GetIndentString());
                sb.AppendLine("{");
                ++s_Indent;
                var get = prop.GetGetMethod();
                if (null != get) {
                    sb.AppendFormat("{0}get;", GetIndentString());
                    sb.AppendLine();
                }
                var set = prop.GetSetMethod();
                if (null != set) {
                    sb.AppendFormat("{0}set;", GetIndentString());
                    sb.AppendLine();
                }
                --s_Indent;
                sb.AppendFormat("{0}", GetIndentString());
                sb.AppendLine("}");
            } else {
                sb.AppendFormat("{0}{1} {2}", GetIndentString(), typeName, prop.Name);
                sb.AppendLine();
                sb.AppendFormat("{0}", GetIndentString());
                sb.AppendLine("{");
                ++s_Indent;
                var get = prop.GetGetMethod();
                if (null != get) {
                    sb.AppendFormat("{0}get;", GetIndentString());
                    sb.AppendLine();
                }
                var set = prop.GetSetMethod();
                if (null != set) {
                    sb.AppendFormat("{0}set;", GetIndentString());
                    sb.AppendLine();
                }
                --s_Indent;
                sb.AppendFormat("{0}", GetIndentString());
                sb.AppendLine("}");
            }
        }
        foreach (var method in GetMethods(type)) {
            if (method.IsSpecialName)
                continue;
            string retType = SimpleName(method.ReturnType);
            if (retType == "System.Void")
                retType = "void";
            Cs2LuaMethodInfo mi = new Cs2LuaMethodInfo();
            mi.Init(method, type);
            var ps = method.GetParameters();
            bool existParams = ExistParams(ps);
            sb.AppendFormat("{0}{1} {2}(", GetIndentString(), retType, method.Name);
            OutputParams(sb, ps);
            sb.AppendLine(");");
        }
        --s_Indent;
        sb.AppendFormat("{0}", GetIndentString());
        sb.AppendLine("}");

        File.WriteAllText(Path.Combine(c_InterfaceOutputDir, name + ".cs"), sb.ToString());

        Debug.Log(string.Format("GenInterfaceCode {0}.cs finish.", name));
    }
    private static void GenLuaProxyCode(System.Type type, string name)
    {
        StringBuilder sb = new StringBuilder();
        s_Indent = 0;
        sb.AppendFormat("{0}using System;", GetIndentString());
        sb.AppendLine();
        sb.AppendFormat("{0}using System.Collections;", GetIndentString());
        sb.AppendLine();
        sb.AppendFormat("{0}using System.Collections.Generic;", GetIndentString());
        sb.AppendLine();
        sb.AppendFormat("{0}using SLua;", GetIndentString());
        sb.AppendLine();
        sb.AppendLine();
        bool useSpecClone = false;
        foreach (var method in GetMethods(type)) {
            if (method.IsSpecialName)
                continue;
            if (method.Name == "Clone") {
                useSpecClone = type.Name.EndsWith("Plugin");
                break;
            }
        }
        if (useSpecClone || !type.IsInterface)
            sb.AppendFormat("{0}public class {1} : LuaClassProxyBase", GetIndentString(), name);
        else
            sb.AppendFormat("{0}public class {1} : LuaClassProxyBase, {2}", GetIndentString(), name, type.Name);
        sb.AppendLine();
        sb.AppendFormat("{0}", GetIndentString());
        sb.AppendLine("{");
        ++s_Indent;
        foreach (var prop in GetProperties(type)) {
            string typeName = SimpleName(prop.PropertyType);
            var ps = prop.GetIndexParameters();
            if (ps.Length > 0) {
                sb.AppendFormat("{0}public {1} {2}[", GetIndentString(), typeName, prop.Name);
                OutputParams(sb, ps);
                sb.AppendLine("]");
                sb.AppendFormat("{0}", GetIndentString());
                sb.AppendLine("{");
                ++s_Indent;
                var get = prop.GetGetMethod();
                if (null != get) {
                    sb.AppendFormat("{0}get", GetIndentString());
                    sb.AppendLine();
                    sb.AppendFormat("{0}", GetIndentString());
                    sb.AppendLine("{");
                    ++s_Indent;
                    sb.AppendFormat("{0}var err = LuaFunctionHelper.BeginCall(m_Cs2Lua_{1});", GetIndentString(), get.Name);
                    sb.AppendLine();
                    sb.AppendFormat("{0}LuaFunctionHelper.PushValue(Self);", GetIndentString());
                    sb.AppendLine();
                    OutputArgs(sb, false, ps);
                    sb.AppendFormat("{0}var end_call_res = LuaFunctionHelper.EndCall(err);", GetIndentString());
                    sb.AppendLine();
                    sb.AppendFormat("{0}if (end_call_res) {{", GetIndentString());
                    sb.AppendLine();
                    ++s_Indent;
                    sb.AppendFormat("{0}LuaFunctionHelper.BeginGetResult(err);", GetIndentString());
                    sb.AppendLine();
                    if (IsEnumType(prop.PropertyType)) {
                        sb.AppendFormat("{0}int __cs2lua_ret;", GetIndentString());
                        sb.AppendLine();
                        sb.AppendFormat("{0}LuaFunctionHelper.GetResult(out __cs2lua_ret);", GetIndentString());
                        sb.AppendLine();
                    } else if (IsValueType(prop.PropertyType)) {
                        sb.AppendFormat("{0}{1} __cs2lua_ret;", GetIndentString(), typeName);
                        sb.AppendLine();
                        sb.AppendFormat("{0}LuaFunctionHelper.GetResult(out __cs2lua_ret);", GetIndentString());
                        sb.AppendLine();
                    } else {
                        sb.AppendFormat("{0}object __cs2lua_ret;", GetIndentString());
                        sb.AppendLine();
                        sb.AppendFormat("{0}LuaFunctionHelper.GetResult(out __cs2lua_ret);", GetIndentString());
                        sb.AppendLine();
                    }
                    sb.AppendFormat("{0}LuaFunctionHelper.EndGetResult();", GetIndentString());
                    sb.AppendLine();
                    if (IsEnumType(prop.PropertyType)) {
                        sb.AppendFormat("{0}return ({1})__cs2lua_ret;", GetIndentString(), typeName);
                        sb.AppendLine();
                    } else if (IsValueType(prop.PropertyType) || typeName == "object") {
                        sb.AppendFormat("{0}return __cs2lua_ret;", GetIndentString());
                        sb.AppendLine();
                    } else {
                        sb.AppendFormat("{0}return __cs2lua_ret as {1};", GetIndentString(), typeName);
                        sb.AppendLine();
                    }
                    --s_Indent;
                    sb.AppendFormat("{0}", GetIndentString());
                    sb.AppendLine("} else {");
                    ++s_Indent;
                    OutputDefaultReturnValue(sb, prop.PropertyType, typeName);
                    --s_Indent;
                    sb.AppendFormat("{0}", GetIndentString());
                    sb.AppendLine("}");
                    --s_Indent;
                    sb.AppendFormat("{0}", GetIndentString());
                    sb.AppendLine("}");
                }
                var set = prop.GetSetMethod();
                if (null != set) {
                    sb.AppendFormat("{0}set", GetIndentString());
                    sb.AppendLine();
                    sb.AppendFormat("{0}", GetIndentString());
                    sb.AppendLine("{");
                    ++s_Indent;
                    sb.AppendFormat("{0}var err = LuaFunctionHelper.BeginCall(m_Cs2Lua_{1});", GetIndentString(), set.Name);
                    sb.AppendLine();
                    sb.AppendFormat("{0}LuaFunctionHelper.PushValue(Self);", GetIndentString());
                    sb.AppendLine();
                    OutputArgs(sb, false, ps);
                    sb.AppendFormat("{0}LuaFunctionHelper.PushValue(value);", GetIndentString());
                    sb.AppendLine();
                    sb.AppendFormat("{0}LuaFunctionHelper.EndCallAndDiscardResult(err);", GetIndentString());
                    sb.AppendLine();
                    --s_Indent;
                    sb.AppendFormat("{0}", GetIndentString());
                    sb.AppendLine("}");
                }
                --s_Indent;
                sb.AppendFormat("{0}", GetIndentString());
                sb.AppendLine("}");
            } else {
                sb.AppendFormat("{0}public {1} {2}", GetIndentString(), typeName, prop.Name);
                sb.AppendLine();
                sb.AppendFormat("{0}", GetIndentString());
                sb.AppendLine("{");
                ++s_Indent;
                var get = prop.GetGetMethod();
                if (null != get) {
                    sb.AppendFormat("{0}get", GetIndentString());
                    sb.AppendLine();
                    sb.AppendFormat("{0}", GetIndentString());
                    sb.AppendLine("{");
                    ++s_Indent;
                    sb.AppendFormat("{0}var err = LuaFunctionHelper.BeginCall(m_Cs2Lua_{1});", GetIndentString(), get.Name);
                    sb.AppendLine();
                    sb.AppendFormat("{0}LuaFunctionHelper.PushValue(Self);", GetIndentString());
                    sb.AppendLine();
                    OutputArgs(sb, false, ps);
                    sb.AppendFormat("{0}var end_call_res = LuaFunctionHelper.EndCall(err);", GetIndentString());
                    sb.AppendLine();
                    sb.AppendFormat("{0}if (end_call_res) {{", GetIndentString());
                    sb.AppendLine();
                    ++s_Indent;
                    sb.AppendFormat("{0}LuaFunctionHelper.BeginGetResult(err);", GetIndentString());
                    sb.AppendLine();
                    if (IsEnumType(prop.PropertyType)) {
                        sb.AppendFormat("{0}int __cs2lua_ret;", GetIndentString());
                        sb.AppendLine();
                        sb.AppendFormat("{0}LuaFunctionHelper.GetResult(out __cs2lua_ret);", GetIndentString());
                        sb.AppendLine();
                    } else if (IsValueType(prop.PropertyType)) {
                        sb.AppendFormat("{0}{1} __cs2lua_ret;", GetIndentString(), typeName);
                        sb.AppendLine();
                        sb.AppendFormat("{0}LuaFunctionHelper.GetResult(out __cs2lua_ret);", GetIndentString());
                        sb.AppendLine();
                    } else {
                        sb.AppendFormat("{0}object __cs2lua_ret;", GetIndentString());
                        sb.AppendLine();
                        sb.AppendFormat("{0}LuaFunctionHelper.GetResult(out __cs2lua_ret);", GetIndentString());
                        sb.AppendLine();
                    }
                    sb.AppendFormat("{0}LuaFunctionHelper.EndGetResult();", GetIndentString());
                    sb.AppendLine();
                    if (IsEnumType(prop.PropertyType)) {
                        sb.AppendFormat("{0}return ({1})__cs2lua_ret;", GetIndentString(), typeName);
                        sb.AppendLine();
                    } else if (IsValueType(prop.PropertyType) || typeName == "object") {
                        sb.AppendFormat("{0}return __cs2lua_ret;", GetIndentString());
                        sb.AppendLine();
                    } else {
                        sb.AppendFormat("{0}return __cs2lua_ret as {1};", GetIndentString(), typeName);
                        sb.AppendLine();
                    }
                    --s_Indent;
                    sb.AppendFormat("{0}", GetIndentString());
                    sb.AppendLine("} else {");
                    ++s_Indent;
                    OutputDefaultReturnValue(sb, prop.PropertyType, typeName);
                    --s_Indent;
                    sb.AppendFormat("{0}", GetIndentString());
                    sb.AppendLine("}");
                    --s_Indent;
                    sb.AppendFormat("{0}", GetIndentString());
                    sb.AppendLine("}");
                }
                var set = prop.GetSetMethod();
                if (null != set) {
                    sb.AppendFormat("{0}set", GetIndentString());
                    sb.AppendLine();
                    sb.AppendFormat("{0}", GetIndentString());
                    sb.AppendLine("{");
                    ++s_Indent;
                    sb.AppendFormat("{0}var err = LuaFunctionHelper.BeginCall(m_Cs2Lua_{1});", GetIndentString(), set.Name);
                    sb.AppendLine();
                    sb.AppendFormat("{0}LuaFunctionHelper.PushValue(Self);", GetIndentString());
                    sb.AppendLine();
                    OutputArgs(sb, false, ps);
                    sb.AppendFormat("{0}LuaFunctionHelper.PushValue(value);", GetIndentString());
                    sb.AppendLine();
                    sb.AppendFormat("{0}LuaFunctionHelper.EndCallAndDiscardResult(err);", GetIndentString());
                    sb.AppendLine();
                    --s_Indent;
                    sb.AppendFormat("{0}", GetIndentString());
                    sb.AppendLine("}");
                }
                --s_Indent;
                sb.AppendFormat("{0}", GetIndentString());
                sb.AppendLine("}");
            }
        }
        foreach (var method in GetMethods(type)) {
            if (method.IsSpecialName)
                continue;
            string retType = SimpleName(method.ReturnType);
            if (retType == "System.Void")
                retType = "void";
            else if (retType == "System.Object")
                retType = "object";
            if (useSpecClone && method.Name == "Clone")
                retType = "object";
            Cs2LuaMethodInfo mi = new Cs2LuaMethodInfo();
            mi.Init(method, type);
            var ps = method.GetParameters();
            bool existParams = ExistParams(ps);
            sb.AppendFormat("{0}public {1} {2}(", GetIndentString(), retType, method.Name);
            OutputParams(sb, ps);
            sb.AppendLine(")");
            sb.AppendFormat("{0}", GetIndentString());
            sb.AppendLine("{");
            ++s_Indent;
            sb.AppendFormat("{0}var err = LuaFunctionHelper.BeginCall(m_Cs2Lua_{1});", GetIndentString(), mi.MethodName);
            sb.AppendLine();
            sb.AppendFormat("{0}LuaFunctionHelper.PushValue(Self);", GetIndentString());
            sb.AppendLine();
            OutputArgs(sb, existParams, ps);
            sb.AppendFormat("{0}var end_call_res = LuaFunctionHelper.EndCall(err);", GetIndentString());
            sb.AppendLine();
            OutputMethodCallResult(sb, method, retType, ps);
            --s_Indent;
            sb.AppendFormat("{0}", GetIndentString());
            sb.AppendLine("}");
        }
        sb.AppendLine();
        sb.AppendFormat("{0}protected override void PrepareMembers()", GetIndentString());
        sb.AppendLine();
        sb.AppendFormat("{0}", GetIndentString());
        sb.AppendLine("{");
        ++s_Indent;
        foreach (var prop in GetProperties(type)) {
            var get = prop.GetGetMethod();
            var set = prop.GetSetMethod();
            if (null != get) {
                sb.AppendFormat("{0}m_Cs2Lua_{1} = (LuaFunction)Self[\"{2}\"];", GetIndentString(), get.Name, get.Name);
                sb.AppendLine();
            }
            if (null != set) {
                sb.AppendFormat("{0}m_Cs2Lua_{1} = (LuaFunction)Self[\"{2}\"];", GetIndentString(), set.Name, set.Name);
                sb.AppendLine();
            }
        }
        foreach (var method in GetMethods(type)) {
            if (method.IsSpecialName)
                continue;
            Cs2LuaMethodInfo mi = new Cs2LuaMethodInfo();
            mi.Init(method, type);
            sb.AppendFormat("{0}m_Cs2Lua_{1} = (LuaFunction)Self[\"{2}\"];", GetIndentString(), mi.MethodName, mi.MethodName);
            sb.AppendLine();
        }
        --s_Indent;
        sb.AppendFormat("{0}", GetIndentString());
        sb.AppendLine("}");
        sb.AppendLine();
        foreach (var prop in GetProperties(type)) {
            var get = prop.GetGetMethod();
            var set = prop.GetSetMethod();
            if (null != get) {
                sb.AppendFormat("{0}private LuaFunction m_Cs2Lua_{1};", GetIndentString(), get.Name);
                sb.AppendLine();
            }
            if (null != set) {
                sb.AppendFormat("{0}private LuaFunction m_Cs2Lua_{1};", GetIndentString(), set.Name);
                sb.AppendLine();
            }
        }
        foreach (var method in GetMethods(type)) {
            if (method.IsSpecialName)
                continue;
            Cs2LuaMethodInfo mi = new Cs2LuaMethodInfo();
            mi.Init(method, type);
            sb.AppendFormat("{0}private LuaFunction m_Cs2Lua_{1};", GetIndentString(), mi.MethodName);
            sb.AppendLine();
        }
        --s_Indent;
        sb.AppendFormat("{0}", GetIndentString());
        sb.AppendLine("}");

        File.WriteAllText(Path.Combine(c_LuaProxyOutputDir, name + ".cs"), sb.ToString());

        Debug.Log(string.Format("GenLuaProxyCode {0}.cs finish.", name));
    }
    private static bool ExistParams(params ParameterInfo[] ps)
    {
        bool ret = false;
        int ct = ps.Length;
        if (ct > 0) {
            var pi = ps[ct - 1];
            if (pi.ParameterType.IsArray) {
                ret = true;
            }
        }
        return ret;
    }
    private static void OutputParams(StringBuilder sb, params ParameterInfo[] ps)
    {
        string prestr = string.Empty;
        int ct = ps.Length;
        for (int i = 0; i < ct; ++i) {
            var pi = ps[i];
            sb.Append(prestr);
            if (pi.IsOut) {
                sb.Append("out ");
            } else if (pi.ParameterType.IsByRef) {
                sb.Append("ref ");
            } else if (pi.ParameterType.IsArray && i == ct - 1) {
                sb.Append("params ");
            }
            sb.AppendFormat("{0} {1}", SimpleName(pi.ParameterType), pi.Name);
            prestr = ", ";
        }
    }
    private static void OutputArgs(StringBuilder sb, bool existParams, params ParameterInfo[] ps)
    {
        for (int ix = 0; ix < ps.Length; ++ix) {
            var pi = ps[ix];
            if (pi.IsOut) {
                if (IsValueType(pi.ParameterType)) {
                    sb.AppendFormat("{0}LuaFunctionHelper.PushValue(0);", GetIndentString());

                } else {
                    sb.AppendFormat("{0}LuaFunctionHelper.PushValue(({1})null);", GetIndentString(), SimpleName(pi.ParameterType));
                }
                sb.AppendLine();
            } else if (ix < ps.Length - 1 || !existParams) {
                sb.AppendFormat("{0}LuaFunctionHelper.PushValue({1});", GetIndentString(), pi.Name);
                sb.AppendLine();
            } else {
                sb.AppendFormat("{0}LuaFunctionHelper.PushParams({1});", GetIndentString(), pi.Name);
                sb.AppendLine();
            }
        }
    }
    private static void OutputDefaultOutParam(StringBuilder sb, System.Type paramType, string paramTypeName, string paramName)
    {
        if (IsEnumType(paramType)) {
            sb.AppendFormat("{0}{1} = ({2})0;", GetIndentString(), paramName, paramTypeName);
            sb.AppendLine();
        } else if (IsPrimitiveType(paramType)) {
            if (paramTypeName == "bool")
                sb.AppendFormat("{0}{1} = false;", GetIndentString(), paramName);
            else
                sb.AppendFormat("{0}{1} = ({2})0;", GetIndentString(), paramName, paramTypeName);
            sb.AppendLine();
        } else if (IsValueType(paramType)) {
            sb.AppendFormat("{0}{1} = new {2}();", GetIndentString(), paramName, paramTypeName);
            sb.AppendLine();
        } else {
            sb.AppendFormat("{0}{1} = null;", GetIndentString(), paramName);
            sb.AppendLine();
        }
    }
    private static void OutputDefaultReturnValue(StringBuilder sb, System.Type retType, string retTypeName)
    {
        if (IsEnumType(retType)) {
            sb.AppendFormat("{0}return ({1})0;", GetIndentString(), retTypeName);
            sb.AppendLine();
        } else if (IsPrimitiveType(retType)) {
            if (retTypeName == "bool")
                sb.AppendFormat("{0}return false;", GetIndentString());
            else
                sb.AppendFormat("{0}return ({1})0;", GetIndentString(), retTypeName);
            sb.AppendLine();
        } else if (IsValueType(retType)) {
            sb.AppendFormat("{0}return new {1}();", GetIndentString(), retTypeName);
            sb.AppendLine();
        } else {
            sb.AppendFormat("{0}return null;", GetIndentString());
            sb.AppendLine();
        }
    }
    private static void OutputMethodCallResult(StringBuilder sb, MethodInfo mi, string retType, params ParameterInfo[] ps)
    {
        sb.AppendFormat("{0}if (end_call_res) {{", GetIndentString());
        sb.AppendLine();
        ++s_Indent;
        sb.AppendFormat("{0}LuaFunctionHelper.BeginGetResult(err);", GetIndentString());
        sb.AppendLine();
        if (retType != "void") {
            if (IsEnumType(mi.ReturnType)) {
                sb.AppendFormat("{0}int __cs2lua_ret;", GetIndentString());
                sb.AppendLine();
                sb.AppendFormat("{0}LuaFunctionHelper.GetResult(out __cs2lua_ret);", GetIndentString());
                sb.AppendLine();
            } else if (IsValueType(mi.ReturnType)) {
                sb.AppendFormat("{0}{1} __cs2lua_ret;", GetIndentString(), retType);
                sb.AppendLine();
                sb.AppendFormat("{0}LuaFunctionHelper.GetResult(out __cs2lua_ret);", GetIndentString());
                sb.AppendLine();
            } else {
                sb.AppendFormat("{0}object __cs2lua_ret;", GetIndentString());
                sb.AppendLine();
                sb.AppendFormat("{0}LuaFunctionHelper.GetResult(out __cs2lua_ret);", GetIndentString());
                sb.AppendLine();
            }
        }
        foreach (var pi in ps) {
            if (pi.IsOut || pi.ParameterType.IsByRef) {
                if (IsEnumType(pi.ParameterType)) {
                    sb.AppendFormat("{0}int int_for_{1};", GetIndentString(), pi.Name);
                    sb.AppendLine();
                    sb.AppendFormat("{0}LuaFunctionHelper.GetResult(out int_for_{1});", GetIndentString(), pi.Name);
                    sb.AppendLine();
                    sb.AppendFormat("{0}{1} = ({2})int_for_{3};", GetIndentString(), pi.Name, SimpleName(pi.ParameterType), pi.Name);
                } else if (IsValueType(pi.ParameterType)) {
                    sb.AppendFormat("{0}LuaFunctionHelper.GetResult(out {1});", GetIndentString(), pi.Name);
                } else {
                    sb.AppendFormat("{0}object obj_for_{1};", GetIndentString(), pi.Name);
                    sb.AppendLine();
                    sb.AppendFormat("{0}LuaFunctionHelper.GetResult(out obj_for_{1});", GetIndentString(), pi.Name);
                    sb.AppendLine();
                    sb.AppendFormat("{0}{1} = obj_for_{2} as {3};", GetIndentString(), pi.Name, pi.Name, SimpleName(pi.ParameterType));
                }
                sb.AppendLine();
            }
        }
        sb.AppendFormat("{0}LuaFunctionHelper.EndGetResult();", GetIndentString());
        sb.AppendLine();
        if (retType != "void") {
            if (IsEnumType(mi.ReturnType)) {
                sb.AppendFormat("{0}return ({1})__cs2lua_ret;", GetIndentString(), retType);
                sb.AppendLine();
            } else if (IsValueType(mi.ReturnType) || retType == "object") {
                sb.AppendFormat("{0}return __cs2lua_ret;", GetIndentString());
                sb.AppendLine();
            } else {
                sb.AppendFormat("{0}return __cs2lua_ret as {1};", GetIndentString(), retType);
                sb.AppendLine();
            }
        }
        --s_Indent;
        sb.AppendFormat("{0}", GetIndentString());
        sb.AppendLine("} else {");
        ++s_Indent;
        foreach (var pi in ps) {
            if (pi.IsOut) {
                OutputDefaultOutParam(sb, pi.ParameterType, SimpleName(pi.ParameterType), pi.Name);
            }
        }
        if (retType != "void") {
            OutputDefaultReturnValue(sb, mi.ReturnType, retType);
        }
        --s_Indent;
        sb.AppendFormat("{0}", GetIndentString());
        sb.AppendLine("}");
    }

    internal static IList<PropertyInfo> GetProperties(System.Type t)
    {
        List<PropertyInfo> properties = new List<PropertyInfo>();
        if (null != t) {
            var ps = t.GetProperties(c_BindingFlags);
            if (null != ps)
                properties.AddRange(ps);
            if (null != t.BaseType && t.BaseType != typeof(System.Object) && t.BaseType != typeof(System.ValueType)) {
                properties.AddRange(GetProperties(t.BaseType));
            }
            AddInterfaceProperties(properties, t);
        }
        return properties;
    }
    private static void AddInterfaceProperties(List<PropertyInfo> properties, System.Type t)
    {
        foreach (var intf in t.GetInterfaces()) {
            var ps = intf.GetProperties(c_BindingFlags);
            if (null != ps)
                properties.AddRange(ps);
        }
        foreach (var intf in t.GetInterfaces()) {
            AddInterfaceProperties(properties, intf);
        }
    }
    internal static IList<MethodInfo> GetMethods(System.Type t)
    {
        List<MethodInfo> methods = new List<MethodInfo>();
        if (null != t) {
            var ms = t.GetMethods(c_BindingFlags);
            if (null != ms)
                methods.AddRange(ms);
            if (null != t.BaseType && t.BaseType != typeof(System.Object) && t.BaseType != typeof(System.ValueType)) {
                methods.AddRange(GetMethods(t.BaseType));
            }
            AddInterfaceMethods(methods, t);
        }
        return methods;
    }
    private static void AddInterfaceMethods(List<MethodInfo> methods, System.Type t)
    {
        foreach (var intf in t.GetInterfaces()) {
            var ms = intf.GetMethods(c_BindingFlags);
            if (null != ms)
                methods.AddRange(ms);
        }
        foreach (var intf in t.GetInterfaces()) {
            AddInterfaceMethods(methods, intf);
        }
    }

    private static string SimpleName(System.Type t)
    {
        if (t.IsByRef) {
            t = t.GetElementType();
        }
        string tn = t.Name;
        switch (tn) {
            case "Single":
                return "float";
            case "String":
                return "string";
            case "Double":
                return "double";
            case "Boolean":
                return "bool";
            case "Int32":
                return "int";
            case "Object":
                tn = FullName(t);
                tn = tn.Replace("System.Object", "object");
                return tn;
            default:
                tn = TypeDecl(t);
                tn = tn.Replace("System.Collections.Generic.", "");
                tn = tn.Replace("System.Object", "object");
                return tn;
        }
    }
    private static string FullName(System.Type t)
    {
        if (t.FullName == null) {
            Debug.Log(t.Name);
            return t.Name;
        }
        return FullName(t.FullName);
    }
    private static string FullName(string str)
    {
        if (str == null) {
            throw new System.NullReferenceException();
        }
        return RemoveRef(str.Replace("+", "."));
    }
    private static string TypeDecl(System.Type t)
    {
        if (t.IsGenericType) {
            string ret = GenericBaseName(t);

            string gs = "";
            gs += "<";
            System.Type[] types = t.GetGenericArguments();
            for (int n = 0; n < types.Length; n++) {
                gs += SimpleName(types[n]);
                if (n < types.Length - 1)
                    gs += ",";
            }
            gs += ">";

            ret = Regex.Replace(ret, @"`\d+", gs);
            return ret;
        }
        if (t.IsArray) {
            return TypeDecl(t.GetElementType()) + "[]";
        } else
            return RemoveRef(t.ToString(), false);
    }
    private static string GenericBaseName(System.Type t)
    {
        string n = t.FullName;
        if (n.IndexOf('[') > 0) {
            n = n.Substring(0, n.IndexOf('['));
        }
        return n.Replace("+", ".");
    }
    private static string RemoveRef(string s, bool removearray = true)
    {
        if (s.EndsWith("&")) s = s.Substring(0, s.Length - 1);
        if (s.EndsWith("[]") && removearray) s = s.Substring(0, s.Length - 2);
        if (s.StartsWith(s_Prefixs[0])) s = s.Substring(s_Prefixs[0].Length + 1, s.Length - s_Prefixs[0].Length - 1);

        s = s.Replace("+", ".");
        if (s.Contains("`")) {
            string regstr = @"`\d";
            Regex r = new Regex(regstr, RegexOptions.None);
            s = r.Replace(s, "");
            s = s.Replace("[", "<");
            s = s.Replace("]", ">");
        }
        return s;
    }
    private static bool IsValueType(System.Type t)
    {
        if (t.IsByRef) {
            t = t.GetElementType();
        }
        return t.IsValueType || t.IsEnum || t.IsPrimitive;
    }
    private static bool IsEnumType(System.Type t)
    {
        if (t.IsByRef) {
            t = t.GetElementType();
        }
        return t.IsEnum;
    }
    private static bool IsPrimitiveType(System.Type t)
    {
        if (t.IsByRef) {
            t = t.GetElementType();
        }
        return t.IsPrimitive;
    }
    private static string GetIndentString()
    {
        const string c_IndentString = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t";
        return c_IndentString.Substring(0, s_Indent);
    }

    private static int s_Indent = 0;
    private static string[] s_Prefixs = new string[] { "System.Collections.Generic" };

    private const BindingFlags c_BindingFlags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance;
    private const string c_InterfaceOutputDir = "..\\CustomApi";
    private const string c_LuaProxyOutputDir = "Assets\\Scripts\\Cs2Lua\\GeneratedCode";
}
