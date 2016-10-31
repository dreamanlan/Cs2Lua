using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cs2LuaScript
{
    [Cs2Lua.Entry]
    public static class Program
    {
        [Cs2Lua.Ignore]
        public static void InitDll()
        {
            PluginManager.Instance.RegisterTickFactory("MyScript", new TickPluginFactory<MyScript>());
            PluginManager.Instance.RegisterStartupFactory("Mandelbrot", new StartupPluginFactory<Mandelbrot>());
        }
        public static void Init()
        {
            //使用c#代码时需要的初始化（平台相关代码，不会转换为lua代码）
#if __DLL__
            InitDll();
#endif
            //公共初始化（也就是逻辑相关的代码）
        }
        private static void Main(string[] args)
        {
            Init();
        }
    }
}
