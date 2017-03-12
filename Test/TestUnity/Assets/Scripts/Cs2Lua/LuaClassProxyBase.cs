using UnityEngine;
using System.Collections;
using LuaInterface;
using SLua;

public static class LuaFunctionHelper
{
    public static int BeginCall(LuaFunction func)
    {
        s_Func = func;
        s_ArgNum = 0;
        int error = LuaObject.pushTry(s_Func.L);
        return error;
    }
    public static void PushValue(sbyte v)
    {
        LuaObject.pushValue(s_Func.L, v);
        ++s_ArgNum;
    }
    public static void PushValue(byte i)
    {
        LuaObject.pushValue(s_Func.L, i);
        ++s_ArgNum;
    }
    public static void PushValue(char v)
    {
        LuaObject.pushValue(s_Func.L, v);
        ++s_ArgNum;
    }
    public static void PushValue(short i)
    {
        LuaObject.pushValue(s_Func.L, i);
        ++s_ArgNum;
    }
    public static void PushValue(ushort v)
    {
        LuaObject.pushValue(s_Func.L, v);
        ++s_ArgNum;
    }
    public static void PushValue(int i)
    {
        LuaObject.pushValue(s_Func.L, i);
        ++s_ArgNum;
    }
    public static void PushValue(uint o)
    {
        LuaObject.pushValue(s_Func.L, o);
        ++s_ArgNum;
    }
    public static void PushValue(long i)
    {
        LuaObject.pushValue(s_Func.L, i);
        ++s_ArgNum;
    }
    public static void PushValue(ulong o)
    {
        LuaObject.pushValue(s_Func.L, o);
        ++s_ArgNum;
    }
    public static void PushValue(float o)
    {
        LuaObject.pushValue(s_Func.L, o);
        ++s_ArgNum;
    }
    public static void PushValue(double d)
    {
        LuaObject.pushValue(s_Func.L, d);
        ++s_ArgNum;
    }
    public static void PushValue(bool b)
    {
        LuaObject.pushValue(s_Func.L, b);
        ++s_ArgNum;
    }
    public static void PushValue(string s)
    {
        LuaObject.pushValue(s_Func.L, s);
        ++s_ArgNum;
    }
    public static void PushValue(LuaCSFunction f)
    {
        LuaObject.pushValue(s_Func.L, f);
        ++s_ArgNum;
    }
    public static void PushValue(LuaTable t)
    {
        LuaObject.pushValue(s_Func.L, t);
        ++s_ArgNum;
    }
    public static void PushValue(RaycastHit2D r)
    {
        LuaObject.pushValue(s_Func.L, r);
        ++s_ArgNum;
    }
    public static void PushValue(RaycastHit r)
    {
        LuaObject.pushValue(s_Func.L, r);
        ++s_ArgNum;
    }
    public static void PushValue(UnityEngine.AnimationState o)
    {
        LuaObject.pushValue(s_Func.L, o);
        ++s_ArgNum;
    }
    public static void PushValue(UnityEngine.Object o)
    {
        LuaObject.pushValue(s_Func.L, o);
        ++s_ArgNum;
    }
    public static void PushValue(Quaternion o)
    {
        LuaObject.pushValue(s_Func.L, o);
        ++s_ArgNum;
    }
    public static void PushValue(Vector2 o)
    {
        LuaObject.pushValue(s_Func.L, o);
        ++s_ArgNum;
    }
    public static void PushValue(Vector3 o)
    {
        LuaObject.pushValue(s_Func.L, o);
        ++s_ArgNum;
    }
    public static void PushValue(Vector4 o)
    {
        LuaObject.pushValue(s_Func.L, o);
        ++s_ArgNum;
    }
    public static void PushValue(Color o)
    {
        LuaObject.pushValue(s_Func.L, o);
        ++s_ArgNum;
    }
    public static void PushValue(Color32 c32)
    {
        LuaObject.pushValue(s_Func.L, c32);
        ++s_ArgNum;
    }
    public static void PushValue(object o)
    {
        LuaObject.pushVar(s_Func.L, o);
        ++s_ArgNum;
    }
    public static void PushParams(sbyte[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(byte[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(char[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(short[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(ushort[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(int[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(uint[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(long[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(ulong[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(float[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(double[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(bool[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(string[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(LuaCSFunction[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(LuaTable[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(RaycastHit2D[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(RaycastHit[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(UnityEngine.AnimationState[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(UnityEngine.Object[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(Quaternion[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(Vector2[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(Vector3[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(Vector4[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(Color[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(Color32[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static void PushParams(object[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushVar(s_Func.L, v);
            ++s_ArgNum;
        }
    }
    public static object EndCall(int error)
    {
        return s_Func.callHelper(s_ArgNum, error);
    }

    private static LuaFunction s_Func;
    private static int s_ArgNum;
}

public class LuaClassProxyBase
{
    public string LuaClassFileName
    {
        get { return m_LuaClassFileName; }
    }
    public LuaTable Self
    {
        get { return m_Self; }
        set 
        {
            ResetLua(value);
        }
    }
    public void InitLua(LuaTable self)
    {
        InitLua(self, string.Empty);
    }
    public void InitLua(LuaTable self, string file)
    {
        m_LuaClassFileName = file;
        ResetLua(self);
    }
    public void LoadLua(string luaClassFileName)
    {
        m_LuaClassFileName = luaClassFileName; 
        PrepareSlua();
    }
    /*
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
    */
    protected int BeginCall(LuaFunction func)
    {
        m_Func = func;
        m_ArgNum = 0;
        int error = LuaObject.pushTry(m_Func.L);
        return error;
    }
    protected void PushValue(sbyte v)
    {
        LuaObject.pushValue(m_Func.L, v);
        ++m_ArgNum;
    }
    protected void PushValue(byte i)
    {
        LuaObject.pushValue(m_Func.L, i);
        ++m_ArgNum;
    }
    protected void PushValue(char v)
    {
        LuaObject.pushValue(m_Func.L, v);
        ++m_ArgNum;
    }
    protected void PushValue(short i)
    {
        LuaObject.pushValue(m_Func.L, i);
        ++m_ArgNum;
    }
    protected void PushValue(ushort v)
    {
        LuaObject.pushValue(m_Func.L, v);
        ++m_ArgNum;
    }
    protected void PushValue(int i)
    {
        LuaObject.pushValue(m_Func.L, i);
        ++m_ArgNum;
    }
    protected void PushValue(uint o)
    {
        LuaObject.pushValue(m_Func.L, o);
        ++m_ArgNum;
    }
    protected void PushValue(long i)
    {
        LuaObject.pushValue(m_Func.L, i);
        ++m_ArgNum;
    }
    protected void PushValue(ulong o)
    {
        LuaObject.pushValue(m_Func.L, o);
        ++m_ArgNum;
    }
    protected void PushValue(float o)
    {
        LuaObject.pushValue(m_Func.L, o);
        ++m_ArgNum;
    }
    protected void PushValue(double d)
    {
        LuaObject.pushValue(m_Func.L, d);
        ++m_ArgNum;
    }
    protected void PushValue(bool b)
    {
        LuaObject.pushValue(m_Func.L, b);
        ++m_ArgNum;
    }
    protected void PushValue(string s)
    {
        LuaObject.pushValue(m_Func.L, s);
        ++m_ArgNum;
    }
    protected void PushValue(LuaCSFunction f)
    {
        LuaObject.pushValue(m_Func.L, f);
        ++m_ArgNum;
    }
    protected void PushValue(LuaTable t)
    {
        LuaObject.pushValue(m_Func.L, t);
        ++m_ArgNum;
    }
    protected void PushValue(RaycastHit2D r)
    {
        LuaObject.pushValue(m_Func.L, r);
        ++m_ArgNum;
    }
    protected void PushValue(RaycastHit r)
    {
        LuaObject.pushValue(m_Func.L, r);
        ++m_ArgNum;
    }
    protected void PushValue(UnityEngine.AnimationState o)
    {
        LuaObject.pushValue(m_Func.L, o);
        ++m_ArgNum;
    }
    protected void PushValue(UnityEngine.Object o)
    {
        LuaObject.pushValue(m_Func.L, o);
        ++m_ArgNum;
    }
    protected void PushValue(Quaternion o)
    {
        LuaObject.pushValue(m_Func.L, o);
        ++m_ArgNum;
    }
    protected void PushValue(Vector2 o)
    {
        LuaObject.pushValue(m_Func.L, o);
        ++m_ArgNum;
    }
    protected void PushValue(Vector3 o)
    {
        LuaObject.pushValue(m_Func.L, o);
        ++m_ArgNum;
    }
    protected void PushValue(Vector4 o)
    {
        LuaObject.pushValue(m_Func.L, o);
        ++m_ArgNum;
    }
    protected void PushValue(Color o)
    {
        LuaObject.pushValue(m_Func.L, o);
        ++m_ArgNum;
    }
    protected void PushValue(Color32 c32)
    {
        LuaObject.pushValue(m_Func.L, c32);
        ++m_ArgNum;
    }
    protected void PushValue(object o)
    {
        LuaObject.pushVar(m_Func.L, o);
        ++m_ArgNum;
    }
    protected void PushParams(sbyte[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(byte[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(char[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(short[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(ushort[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(int[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(uint[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(long[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(ulong[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(float[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(double[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(bool[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(string[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(LuaCSFunction[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(LuaTable[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(RaycastHit2D[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(RaycastHit[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(UnityEngine.AnimationState[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(UnityEngine.Object[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(Quaternion[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(Vector2[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(Vector3[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(Vector4[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(Color[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(Color32[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushValue(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected void PushParams(object[] ps)
    {
        int ct = ps.Length;
        for (int ix = 0; ix < ct; ++ix) {
            var v = ps[ix];
            LuaObject.pushVar(m_Func.L, v);
            ++m_ArgNum;
        }
    }
    protected object EndCall(int error)
    {
        return m_Func.callHelper(m_ArgNum, error);
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
        var svr = Cs2LuaAssembly.Instance.LuaSvr;
        svr.luaState.doFile(m_LuaClassFileName);
        var classObj = (LuaTable)svr.luaState[className];
        m_Self = (LuaTable)((LuaFunction)classObj["__new_object"]).call();
        if (null != m_Self) {
            PrepareMembers();
            m_LuaInited = true;
        }
#endif
    }
    private void ResetLua(LuaTable self)
    {
        m_Self = self;
        if (null != m_Self) {
            PrepareMembers();
            m_LuaInited = true;
        }
    }

    private string m_LuaClassFileName;
    private LuaTable m_Self;
    private bool m_LuaInited;

    private LuaFunction m_Func;
    private int m_ArgNum;
}
