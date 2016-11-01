using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using SLua;

public class Cs2LuaStartup : MonoBehaviour
{
    public PluginType PluginType;
    public string LuaClassFileName;

    internal void Start()
    {
        string className = LuaClassFileName.Replace("__",".");
        if (PluginType == PluginType.Lua) {
            StartCoroutine(StartupLua(className));
        } else {
            csObject = PluginManager.Instance.CreateStartup(className);
            csObject.Start(gameObject);
        }
    }

    private IEnumerator StartupLua(string className)
    {
        while (!Cs2LuaAssembly.Instance.LuaInited)
            yield return null;
        svr = Cs2LuaAssembly.Instance.LuaSvr;
        svr.luaState.doFile(LuaClassFileName);
        classObj = (LuaTable)svr.luaState[className];
        self = (LuaTable)((LuaFunction)classObj["__new_object"]).call();
        start = (LuaFunction)self["Start"];
        if (null != start) {
            start.call(self, gameObject);
        }
        yield return null;
    }

    private IStartupPlugin csObject;
    
    private LuaSvr svr;
    private LuaTable classObj;
    private LuaTable self;
    private LuaFunction start;
}
