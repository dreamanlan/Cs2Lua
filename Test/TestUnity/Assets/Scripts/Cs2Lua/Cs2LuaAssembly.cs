using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Reflection;
using SLua;

internal class Cs2LuaAssembly
{
    internal bool LuaInited
    {
        get { return m_LuaInited; }
    }
    internal Assembly Assembly
    {
        get { return m_Assembly; }
    }
    public LuaSvr LuaSvr
    {
        get { return m_LuaSvr; }
    }
    internal void Init()
    {
        m_LuaSvr.init(null, () => {
            var entry = (LuaTable)m_LuaSvr.start("Program");
            entry.invoke("Init");
            m_LuaInited = true;
        });
#if CS2LUA_DEBUG || UNITY_IOS
        Cs2LuaScript.Program.Init();
#else
        Load(Path.Combine(Application.streamingAssetsPath, "Cs2LuaScript.dll"));
        if (null != m_Assembly) {
            var type = m_Assembly.GetType("Program");
            type.InvokeMember("Init", BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod, null, null, null);
        }
#endif
    }
    internal void Load(string assembly)
    {
        if (File.Exists(assembly)) {
            var bytes = File.ReadAllBytes(assembly);
            Load(bytes);
        }
    }
    internal void Load(byte[] bytes)
    {
        m_Assembly = Assembly.Load(bytes);
    }

    private Assembly m_Assembly = null;
    private LuaSvr m_LuaSvr = new LuaSvr();
    private bool m_LuaInited = false;

    internal static Cs2LuaAssembly Instance
    {
        get { return s_Instance; }
    }
    private static Cs2LuaAssembly s_Instance = new Cs2LuaAssembly();
}
