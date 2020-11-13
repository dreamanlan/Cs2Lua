using UnityEngine;
using System.IO;
using System.Collections;
using System.Reflection;
using SLua;

public enum PluginType
{
    Native = 0,
    Lua,
}
public class Cs2LuaTick : MonoBehaviour
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
            monoBehaviourProxy = new MonoBehaviourProxy(this);
            csObject = PluginManager.Instance.CreateTick(className);
            csObject.Init(gameObject, monoBehaviourProxy);
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

    private IEnumerator StartupLua(string className)
    {
        while (!Cs2LuaAssembly.Instance.LuaInited)
            yield return null;
		string fileName = LuaClassFileName.ToLower();
        var sb = new System.Text.StringBuilder();
        sb.Append("require ");
        sb.Append('"');
        sb.Append(fileName);
        sb.Append('"');
        LuaState.main.doString(sb.ToString());
        classObj = (LuaTable)LuaState.main[className];
        self = (LuaTable)((LuaFunction)classObj["__new_object"]).call();
        init = (LuaFunction)self["Init"];
        update = (LuaFunction)self["Update"];
        call = (LuaFunction)self["Call"];
        if (null != init) {
            monoBehaviourProxy = new MonoBehaviourProxy(this);
            init.call(self, gameObject, monoBehaviourProxy);
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

    private ITickPlugin csObject;
    
    private LuaTable classObj;
    private LuaTable self;
    private LuaFunction init;
    private LuaFunction update;
    private LuaFunction call;
    private bool luaInited;
    private MonoBehaviourProxy monoBehaviourProxy;
}
