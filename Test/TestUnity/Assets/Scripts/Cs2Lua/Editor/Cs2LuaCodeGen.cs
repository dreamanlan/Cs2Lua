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
        var ms = type.GetMethods();
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
    [MenuItem("工具/Build/GenCs2LuaProxy", false, 100)]
    public static void GenCode()
    {
        //GenCode(typeof(ILogicModuleProxy), "Cs2LuaLogicModuleProxy");
    }

    private static void GenCode(System.Type type, string name)
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
        sb.AppendFormat("{0}public class {1} : LuaClassProxyBase, {2}", GetIndentString(), name, type.Name);
        sb.AppendLine();
        sb.AppendFormat("{0}", GetIndentString());
        sb.AppendLine("{");
        ++s_Indent;
        foreach (var prop in type.GetProperties()) {
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
                    if (IsValueType(prop.PropertyType)) {
                        sb.AppendFormat("{0}return base.CastTo<{1}>(base.CallFunction(m_Cs2Lua_{2}, false, Self, ", GetIndentString(), typeName, get.Name);
                        OutputArgs(sb, ps);
                        sb.AppendLine("));");
                    } else {
                        sb.AppendFormat("{0}return base.CallFunction(m_Cs2Lua_{1}, false, Self, ", GetIndentString(), get.Name);
                        OutputArgs(sb, ps);
                        sb.AppendFormat(") as {0};", typeName);
                        sb.AppendLine();
                    }
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
                    sb.AppendFormat("{0}base.CallFunction(m_Cs2Lua_{1}, false, Self, ", GetIndentString(), set.Name);
                    OutputArgs(sb, ps);
                    sb.AppendLine(", value);");
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
                    if (IsValueType(prop.PropertyType))
                        sb.AppendFormat("{0}return base.CastTo<{1}>(base.CallFunction(m_Cs2Lua_{2}, false, Self));", GetIndentString(), typeName, get.Name);
                    else
                        sb.AppendFormat("{0}return base.CallFunction(m_Cs2Lua_{1}, false, Self) as {2};", GetIndentString(), get.Name, typeName);
                    sb.AppendLine();
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
                    sb.AppendFormat("{0}base.CallFunction(m_Cs2Lua_{1}, false, Self, value);", GetIndentString(), set.Name);
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
        foreach (var method in type.GetMethods()) {
            if (method.IsSpecialName)
                continue;
            string retType = SimpleName(method.ReturnType);
            if(retType=="System.Void")
                retType="void";
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
            OutputPreMethodCall(sb, method.GetParameters());
            sb.AppendFormat("{0}", GetIndentString());
            if (retType != "void" || mi.ExistReturnParam) {
                sb.Append("var __cs2lua_ret = ");
            }
            sb.AppendFormat("base.CallFunction(m_Cs2Lua_{0}, {1}, Self", mi.MethodName, existParams ? "true" : "false");
            if (mi.ExistParam) {
                sb.Append(", ");
            }
            OutputArgs(sb, ps);
            sb.Append(")");
            if(mi.ExistReturnParam){
                sb.Append(" as object[]");
            }
            sb.AppendLine(";");
            OutputPostMethodCall(sb, retType, ps);
            if (retType != "void") {
                if (IsValueType(method.ReturnType)) {
                    if (mi.ExistReturnParam)
                        sb.AppendFormat("{0}return base.CastTo<{1}>(__cs2lua_ret[0]);", GetIndentString(), retType);
                    else
                        sb.AppendFormat("{0}return base.CastTo<{1}>(__cs2lua_ret);", GetIndentString(), retType);
                } else {
                    if (mi.ExistReturnParam)
                        sb.AppendFormat("{0}return __cs2lua_ret[0] as {1};", GetIndentString(), retType);
                    else
                        sb.AppendFormat("{0}return __cs2lua_ret as {1};", GetIndentString(), retType);
                }
                sb.AppendLine();
            }
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
        foreach (var prop in type.GetProperties()) {
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
        foreach (var method in type.GetMethods()) {
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
        foreach (var prop in type.GetProperties()) {
            var get=prop.GetGetMethod();
            var set=prop.GetSetMethod();
            if (null != get) {
                sb.AppendFormat("{0}private LuaFunction m_Cs2Lua_{1};", GetIndentString(), get.Name);
                sb.AppendLine();
            }
            if (null != set) {
                sb.AppendFormat("{0}private LuaFunction m_Cs2Lua_{1};", GetIndentString(), set.Name);
                sb.AppendLine();
            }
        }
        foreach (var method in type.GetMethods()) {
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

        File.WriteAllText(Path.Combine(c_OutputDir, name + ".cs"), sb.ToString());

        Debug.Log(string.Format("GenCode {0}.cs finish.", name));
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
    private static void OutputArgs(StringBuilder sb, params ParameterInfo[] ps)
    {
        string prestr = string.Empty;
        foreach (var pi in ps) {
            sb.Append(prestr);
            sb.AppendFormat("{0}", pi.Name);
            prestr = ", ";
        }
    }
    private static void OutputPreMethodCall(StringBuilder sb, params ParameterInfo[] ps)
    {
        foreach (var pi in ps) {
            if (pi.IsOut) {
                sb.AppendFormat("{0}{1} = ({2}){3};", GetIndentString(), pi.Name, SimpleName(pi.ParameterType), IsValueType(pi.ParameterType) ? "0" : "null");
                sb.AppendLine();
            }
        }
    }
    private static void OutputPostMethodCall(StringBuilder sb, string retType, params ParameterInfo[] ps)
    {
        int ix = 0;
        if (retType != "void") {
            ix = 1;
        }
        foreach (var pi in ps) {
            if (pi.IsOut || pi.ParameterType.IsByRef) {
                if(IsValueType(pi.ParameterType))
                    sb.AppendFormat("{0}{1} = base.CastTo<{2}>(__cs2lua_ret[{3}]);", GetIndentString(), pi.Name, SimpleName(pi.ParameterType), ix);
                else
                    sb.AppendFormat("{0}{1} = __cs2lua_ret[{2}] as {3};", GetIndentString(), pi.Name, ix, SimpleName(pi.ParameterType));
                sb.AppendLine();
                ++ix;
            }
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
                return FullName(t);
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
    private static string GetIndentString()
    {
        const string c_IndentString = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t";
        return c_IndentString.Substring(0, s_Indent);
    }

    private static int s_Indent = 0;
    private static string[] s_Prefixs = new string[] { "System.Collections.Generic" };

    private const string c_OutputDir = "Assets\\Scripts\\Cs2Lua\\GeneratedCode";
}
