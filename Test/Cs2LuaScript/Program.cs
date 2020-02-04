using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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