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
            luaInited = false;
            StartCoroutine(StartupLua(className));
        } else {
            monoBehaviourProxy = new MonoBehaviourProxy(this);
            csObject = PluginManager.Instance.CreateStartup(className);
            csObject.Init(gameObject, monoBehaviourProxy);
        }
    }

    private IEnumerator StartupLua(string className)
    {
        while (!Cs2LuaAssembly.Instance.LuaInited)
            yield return null;
        svr = Cs2LuaAssembly.Instance.LuaSvr;
		string fileName = LuaClassFileName.ToLower();
        var sb = new System.Text.StringBuilder();
        sb.Append("require ");
        sb.Append('"');
        sb.Append(fileName);
        sb.Append('"');
        svr.luaState.doString(sb.ToString());
        classObj = (LuaTable)svr.luaState[className];
        self = (LuaTable)((LuaFunction)classObj["__new_object"]).call();
        init = (LuaFunction)self["Init"];
        call = (LuaFunction)self["Call"];
        if (null != init) {
            init.call(self, gameObject, this);
        }
        luaInited = true;
        yield return null;
    }

    private void CallScript(object[] args)
    {
        if (args.Length > 0) {
            if (PluginType == PluginType.Lua) {
                if (luaInited && null != call) {
                    ArrayList arr = new ArrayList();
                    arr.Add(self);
                    arr.AddRange(args);
                    call.call(arr.ToArray());
                }
            } else {
                if (null != csObject) {
                    string name = args[0] as string;
                    ArrayList arr = new ArrayList(args);
                    arr.RemoveAt(0);
                    if (args.Length == 1)
                        csObject.Call(name);
                    else if (args.Length == 2)
                        csObject.Call(name, args[1]);
                    else
                        csObject.Call(name, arr.ToArray());
                }
            }
        }
    }

    private IStartupPlugin csObject;
    
    private LuaSvr svr;
    private LuaTable classObj;
    private LuaTable self;
    private LuaFunction init;
    private LuaFunction call;
    private bool luaInited;
    private MonoBehaviourProxy monoBehaviourProxy;
}
