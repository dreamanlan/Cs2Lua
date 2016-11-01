using UnityEngine;
using System.IO;
using System.Collections;
using System.Reflection;
using SLua;

public class Cs2LuaTickWithAllUpdate : MonoBehaviour
{
    public PluginType PluginType;
    public string LuaClassFileName;

    internal void Start()
    {
        string className = LuaClassFileName.Replace("__", ".");
        if (PluginType == PluginType.Lua) {
            luaInited = false;
            StartCoroutine(StartupLua(className));
        } else {
            csObject = PluginManager.Instance.CreateTick(className);
            if (null != csObject) {
                csObject.Init(gameObject);
            }
        }
    }

    internal void Update()
    {
        if (PluginType == PluginType.Lua) {
            if (luaInited && null != update) {
                update.call(self);
            }
        } else {
            if (null != csObject) {
                csObject.Update();
            }
        }
    }

    internal void FixedUpdate()
    {
        if (PluginType == PluginType.Lua) {
            if (luaInited && null != fixedUpdate) {
                fixedUpdate.call(self);
            }
        } else {
            if (null != csObject) {
                csObject.FixedUpdate();
            }
        }
    }

    internal void LateUpdate()
    {
        if (PluginType == PluginType.Lua) {
            if (luaInited && null != lateUpdate) {
                lateUpdate.call(self);
            }
        } else {
            if (null != csObject) {
                csObject.LateUpdate();
            }
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
        init = (LuaFunction)self["Init"];
        update = (LuaFunction)self["Update"];
        if (null != init) {
            init.call(self, gameObject);
        }
        luaInited = true;
        yield return null;
    }

    private ITickPlugin csObject;
    
    private LuaSvr svr;
    private LuaTable classObj;
    private LuaTable self;
    private LuaFunction init;
    private LuaFunction update;
    private LuaFunction fixedUpdate;
    private LuaFunction lateUpdate;
    private bool luaInited;
}
