using UnityEngine;
using System.Collections;
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
    public static bool EndCallAndDiscardResult(int error)
    {
        return s_Func.callAndDiscardResult(s_ArgNum, error);
    }
    public static bool EndCall(int error)
    {
        return s_Func.callForGetResult(s_ArgNum, error);        
    }
    public static int BeginGetResult(int error)
    {
        var L = s_Func.L;
        int top = LuaDLL.lua_gettop(L);
        s_From = error - 1;
        s_ResNum = top - s_From;
        s_ResIndex = 1;
        return s_ResNum;
    }
    public static void EndGetResult()
    {
        var L = s_Func.L;
        if (s_ResNum == 1) {
            LuaDLL.lua_pop(L, 1);
        } else if (s_ResNum > 1) {
            LuaDLL.lua_settop(L, s_From);
        }
    }
    public static bool GetResult(out sbyte res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = 0;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TNUMBER: {
                    res = (sbyte)LuaDLL.lua_tonumber(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = sbyte.Parse(LuaDLL.lua_tostring(L, from));
                    ret = true;
                    break;
                }
            default:
                res = 0;
                break;
        }
        return ret;
    }
    public static bool GetResult(out byte res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = 0;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TNUMBER: {
                    res = (byte)LuaDLL.lua_tonumber(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = byte.Parse(LuaDLL.lua_tostring(L, from));
                    ret = true;
                    break;
                }
            default:
                res = 0;
                break;
        }
        return ret;
    }
    public static bool GetResult(out char res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = (char)0;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TNUMBER: {
                    res = (char)LuaDLL.lua_tonumber(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = char.Parse(LuaDLL.lua_tostring(L, from));
                    ret = true;
                    break;
                }
            default:
                res = (char)0;
                break;
        }
        return ret;
    }
    public static bool GetResult(out short res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = 0;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TNUMBER: {
                    res = (short)LuaDLL.lua_tonumber(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = short.Parse(LuaDLL.lua_tostring(L, from));
                    ret = true;
                    break;
                }
            default:
                res = 0;
                break;
        }
        return ret;
    }
    public static bool GetResult(out ushort res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = 0;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TNUMBER: {
                    res = (ushort)LuaDLL.lua_tonumber(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = ushort.Parse(LuaDLL.lua_tostring(L, from));
                    ret = true;
                    break;
                }
            default:
                res = 0;
                break;
        }
        return ret;
    }
    public static bool GetResult(out int res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = 0;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TNUMBER: {
                    res = (int)LuaDLL.lua_tonumber(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = int.Parse(LuaDLL.lua_tostring(L, from));
                    ret = true;
                    break;
                }
            default:
                res = 0;
                break;
        }
        return ret;
    }
    public static bool GetResult(out uint res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = 0;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TNUMBER: {
                    res = (uint)LuaDLL.lua_tonumber(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = uint.Parse(LuaDLL.lua_tostring(L, from));
                    ret = true;
                    break;
                }
            default:
                res = 0;
                break;
        }
        return ret;
    }
    public static bool GetResult(out long res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = 0;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TNUMBER: {
                    res = (long)LuaDLL.lua_tonumber(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = long.Parse(LuaDLL.lua_tostring(L, from));
                    ret = true;
                    break;
                }
            default:
                res = 0;
                break;
        }
        return ret;
    }
    public static bool GetResult(out ulong res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = 0;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TNUMBER: {
                    res = (ulong)LuaDLL.lua_tonumber(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = ulong.Parse(LuaDLL.lua_tostring(L, from));
                    ret = true;
                    break;
                }
            default:
                res = 0;
                break;
        }
        return ret;
    }
    public static bool GetResult(out float res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = 0;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TNUMBER: {
                    res = (float)LuaDLL.lua_tonumber(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = float.Parse(LuaDLL.lua_tostring(L, from));
                    ret = true;
                    break;
                }
            default:
                res = 0;
                break;
        }
        return ret;
    }
    public static bool GetResult(out double res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = 0;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TNUMBER: {
                    res = (double)LuaDLL.lua_tonumber(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = double.Parse(LuaDLL.lua_tostring(L, from));
                    ret = true;
                    break;
                }
            default:
                res = 0;
                break;
        }
        return ret;
    }
    public static bool GetResult(out bool res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = false;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TBOOLEAN: {
                    res = LuaDLL.lua_toboolean(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = bool.Parse(LuaDLL.lua_tostring(L, from));
                    ret = true;
                    break;
                }
            default:
                res = false;
                break;
        }
        return ret;
    }
    public static bool GetResult(out string res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = null;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TNUMBER: {
                    res = LuaDLL.lua_tonumber(L, from).ToString();
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = LuaDLL.lua_tostring(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TBOOLEAN: {
                    res = LuaDLL.lua_toboolean(L, from).ToString();
                    ret = true;
                    break;
                }
            default:
                res = null;
                break;
        }
        return ret;
    }
    public static bool GetResult(out LuaFunction res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = null;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TFUNCTION: {
                    LuaFunction v;
                    LuaObject.checkType(L, from, out v);
                    res = v;
                    ret = true;
                    break;
                }
            default:
                res = null;
                break;
        }
        return ret;
    }
    public static bool GetResult(out LuaTable res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = null;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TTABLE: {
                    LuaTable v;
                    LuaObject.checkType(L, from, out v);
                    res = v;
                    ret = true;
                    break;
                }
            default:
                res = null;
                break;
        }
        return ret;
    }
    public static bool GetResult(out LuaThread res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = null;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TTHREAD: {
                    LuaThread lt;
                    LuaObject.checkType(L, from, out lt);
                    res = lt;
                    ret = true;
                    break;
                }
            default:
                res = null;
                break;
        }
        return ret;
    }
    public static bool GetResult(out Quaternion res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = Quaternion.identity;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        if (type == LuaTypes.LUA_TTABLE && LuaDLL.luaS_checkluatype(L, from, null) == 1) {
            if (LuaObject.luaTypeCheck(L, from, "Quaternion")) {
                Quaternion v;
                LuaObject.checkType(L, from, out v);
                res = v;
                ret = true;
            } else {
                res = Quaternion.identity;
            }
        } else {
            res = Quaternion.identity;
        }
        return ret;
    }
    public static bool GetResult(out Vector2 res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = Vector2.zero;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        if (type == LuaTypes.LUA_TTABLE && LuaDLL.luaS_checkluatype(L, from, null) == 1) {
            if (LuaObject.luaTypeCheck(L, from, "Vector2")) {
                Vector2 v;
                LuaObject.checkType(L, from, out v);
                res = v;
                ret = true;
            } else {
                res = Vector2.zero;
            }
        } else {
            res = Vector2.zero;
        }
        return ret;
    }
    public static bool GetResult(out Vector3 res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = Vector3.zero;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        if (type == LuaTypes.LUA_TTABLE && LuaDLL.luaS_checkluatype(L, from, null) == 1) {
            if (LuaObject.luaTypeCheck(L, from, "Vector3")) {
                Vector3 v;
                LuaObject.checkType(L, from, out v);
                res = v;
                ret = true;
            } else {
                res = Vector3.zero;
            }
        } else {
            res = Vector3.zero;
        }
        return ret;
    }
    public static bool GetResult(out Vector4 res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = Vector4.zero;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        if (type == LuaTypes.LUA_TTABLE && LuaDLL.luaS_checkluatype(L, from, null) == 1) {
            if (LuaObject.luaTypeCheck(L, from, "Vector4")) {
                Vector4 v;
                LuaObject.checkType(L, from, out v);
                res = v;
                ret = true;
            } else {
                res = Vector4.zero;
            }
        } else {
            res = Vector4.zero;
        }
        return ret;
    }
    public static bool GetResult(out Color res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = new Color();
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        if (type == LuaTypes.LUA_TTABLE && LuaDLL.luaS_checkluatype(L, from, null) == 1) {
            if (LuaObject.luaTypeCheck(L, from, "Color")) {
                Color c;
                LuaObject.checkType(L, from, out c);
                res = c;
                ret = true;
            } else {
                res = new Color();
            }
        } else {
            res = new Color();
        }
        return ret;
    }
    public static bool GetResult(out Color32 res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = new Color32();
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        if (type == LuaTypes.LUA_TTABLE && LuaDLL.luaS_checkluatype(L, from, null) == 1) {
            if (LuaObject.luaTypeCheck(L, from, "Color")) {
                Color c;
                LuaObject.checkType(L, from, out c);
                res = c;
                ret = true;
            } else {
                res = new Color32();
            }
        } else {
            res = new Color32();
        }
        return ret;
    }
    public static bool GetResult(out object res)
    {
        bool ret = false;
        if (s_ResIndex > s_ResNum) {
            res = null;
            return ret;
        }
        int from = s_From + s_ResIndex;
        ++s_ResIndex;
        var L = s_Func.L;

        LuaTypes type = LuaDLL.lua_type(L, from);
        switch (type) {
            case LuaTypes.LUA_TNUMBER: {
                    res = LuaDLL.lua_tonumber(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TSTRING: {
                    res = LuaDLL.lua_tostring(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TBOOLEAN: {
                    res = LuaDLL.lua_toboolean(L, from);
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TFUNCTION: {
                    LuaFunction v;
                    LuaObject.checkType(L, from, out v);
                    res = v;
                    ret = true;
                    break;
                }
            case LuaTypes.LUA_TTABLE: {
                    if (LuaDLL.luaS_checkluatype(L, from, null) == 1) {
                        if (LuaObject.luaTypeCheck(L, from, "Vector2")) {
                            Vector2 v;
                            LuaObject.checkType(L, from, out v);
                            res = v;
                            ret = true;
                            break;
                        } else if (LuaObject.luaTypeCheck(L, from, "Vector3")) {
                            Vector3 v;
                            LuaObject.checkType(L, from, out v);
                            res = v;
                            ret = true;
                            break;
                        } else if (LuaObject.luaTypeCheck(L, from, "Vector4")) {
                            Vector4 v;
                            LuaObject.checkType(L, from, out v);
                            res = v;
                            ret = true;
                            break;
                        } else if (LuaObject.luaTypeCheck(L, from, "Quaternion")) {
                            Quaternion v;
                            LuaObject.checkType(L, from, out v);
                            res = v;
                            ret = true;
                            break;
                        } else if (LuaObject.luaTypeCheck(L, from, "Color")) {
                            Color c;
                            LuaObject.checkType(L, from, out c);
                            res = c;
                            ret = true;
                            break;
                        } else {
                            res = null;
                            break;
                        }
                    } else if (LuaObject.isLuaClass(L, from)) {
                        res = LuaObject.checkObj(L, from);
                        ret = true;
                        break;
                    } else {
                        LuaTable v;
                        LuaObject.checkType(L, from, out v);
                        res = v;
                        ret = true;
                        break;
                    }
                }
            case LuaTypes.LUA_TUSERDATA:
                res = LuaObject.checkObj(L, from);
                ret = true;
                break;
            case LuaTypes.LUA_TTHREAD: {
                    LuaThread lt;
                    LuaObject.checkType(L, from, out lt);
                    res = lt;
                    ret = true;
                    break;
                }
            default:
                res = null;
                break;
        }
        return ret;
    }
    public static T CastTo<T>(object v)
    {
        System.Type t = typeof(T);
        if (t.IsEnum) {
            return (T)System.Convert.ChangeType(v, typeof(int));
        } else {
            return (T)System.Convert.ChangeType(v, t);
        }
    }

    private static LuaFunction s_Func;
    private static int s_ArgNum;

    private static int s_From;
    private static int s_ResIndex;
    private static int s_ResNum;
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
}
