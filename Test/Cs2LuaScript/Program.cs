using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

internal static class Cs2LuaType
{
    [Cs2Dsl.TranslateTo("Cs2LuaTypeImpl", "Cs2LuaTypeImpl.GetFullName")]
    internal static string GetFullName(System.Type type)
    {
        return type.AssemblyQualifiedName;
    }
}

[Cs2Dsl.Ignore]
internal static class Cs2LuaLibrary
{
    internal static bool IsCs2Lua(object o)
    {
        return false;
    }
    internal static string FormatString(string fmt, params object[] args)
    {
        return string.Format(fmt, args);
    }
    internal static string ToString<T>(T val)
    {
        return val.ToString();
    }
    internal static System.Type GetType<T>(T val)
    {
        return val.GetType();
    }
    public static int Max(int a, int b)
    {
        return Mathf.Max(a, b);
    }
    public static uint Max(uint a, uint b)
    {
        return a >= b ? a : b;
    }
    public static float Max(float a, float b)
    {
        return Mathf.Max(a, b);
    }
    public static int Min(int a, int b)
    {
        return Mathf.Min(a, b);
    }
    public static uint Min(uint a, uint b)
    {
        return a <= b ? a : b;
    }
    public static float Min(float a, float b)
    {
        return Mathf.Min(a, b);
    }
}

[Cs2Dsl.Require("lualib_valuetypescript")]
[Cs2Dsl.Entry]
public static class Program
{
    [Cs2Dsl.Ignore]
    public static void InitDll()
    {
        PluginManager.Instance.RegisterTickFactory("MyScript", new TickPluginFactory<MyScript>());
        PluginManager.Instance.RegisterStartupFactory("Mandelbrot", new StartupPluginFactory<Mandelbrot>());
    }
    public static void Init()
    {
        //使用c#代码时需要的初始化（平台相关代码，不会转换为lua代码，cs2lua在翻译时会添加__DSL__宏，可以据此设定代码是否要转换为lua）
#if __DSL__
#else
        InitDll();
#endif
        //公共初始化（也就是逻辑相关的代码）
    }
    private static void Main(string[] args)
    {
        Init();
    }
}