using UnityEngine;
using System.Collections;
using SLua;

public class LuaClassProxyBase
{
    public string LuaClassFileName
    {
        get { return m_LuaClassFileName; }
    }
    public LuaTable ClassObj
    {
        get { return m_ClassObj; }
    }
    public LuaTable Self
    {
        get { return m_Self; }
    }
    public void LoadLua(string luaClassFileName)
    {
        m_LuaClassFileName = luaClassFileName; 
        PrepareSlua();
    }
    protected LuaFunction GetFunction(string funcName)
    {
        PrepareSlua();
        if (null != m_Self) {
            return (LuaFunction)m_Self[funcName];
        }
        return null;
    }
    protected object CallFunction(LuaFunction func, bool checkParams, params object[] args)
    {
        PrepareSlua();
        object ret = null;
        if (null != func) {
            bool normalCall = true;
            if (checkParams) {
                int ct = args.Length;
                if (ct > 0) {
                    object o = args[ct - 1];
                    System.Type t = o.GetType();
                    if (t.IsArray) {
                        normalCall = false;
                        ArrayList al = new ArrayList();
                        for (int i = 0; i < ct - 1; ++i) {
                            al.Add(args[i]);
                        }
                        al.AddRange(o as ICollection);
                        ret = func.call(al.ToArray());
                    }
                }
            }
            if (normalCall) {
                ret = func.call(args);
            }
        }
        return ret;
    }
    protected T CastTo<T>(object v)
    {
        System.Type t = typeof(T);
        if (t.IsEnum) {
            return (T)System.Convert.ChangeType(v, typeof(int));
        } else {
            return (T)System.Convert.ChangeType(v, t);
        }
    }
    protected virtual void PrepareMembers()
    {
        //重载此函数初始化各成员函数对应的LuaFunction变量
    }

    private void PrepareSlua()
    {
#if !CS2LUA_DEBUG
        if (m_LuaInited)
            return;
        if (!Cs2LuaAssembly.Instance.LuaInited)
            return;
        string className = m_LuaClassFileName.Replace("__", ".");
        m_Svr = Cs2LuaAssembly.Instance.LuaSvr;
        m_Svr.luaState.doFile(m_LuaClassFileName);
        m_ClassObj = (LuaTable)m_Svr.luaState[className];
        m_Self = (LuaTable)((LuaFunction)m_ClassObj["__new_object"]).call();
        if (null != m_Self) {
            PrepareMembers();
            m_LuaInited = true;
        }
#endif
    }

    private string m_LuaClassFileName;
    private LuaSvr m_Svr;
    private LuaTable m_ClassObj;
    private LuaTable m_Self;
    private bool m_LuaInited;
}
