using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

[Cs2Lua.Ignore]
class LuaConsole
{
    public static void Print(params object[] args)
    {
    }
}

public class Entry
{
    public Entry(int v) => m_Value = v;

    public int this[int ix] => m_Value;

    public int this[int ix1, int ix2]
    {
        get => m_Value;
        set => m_Value = value;
    }

    public IEnumerator this[float ix]
    {
        get{
            yield return null;
        }
    }

    public int Val
    {
        get => m_Value;
        set => m_Value = value;
    }
    
    public int Val2 {get;set;} = 1+3;

    public int Val3 => m_Value;

    public IEnumerator Val4
    {
        get{
            yield return null;
        }
    }

    public bool Test(out int v)
    {
        v = 123;
        return true;
    }

    private int m_Value = 0;

    public static void Main()
    {
    }
}

//Entry.Main();