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

public class foo<T, K>
{
    public void parse(string a, string b)
    {
        var t = typeof(T);
        var k = typeof(K);
        LuaConsole.Print(a, b, t, k);
    }
}

public class GenericClass<T> where T : new()
{
    public class InnerGenericClass<TT>
    {
        public void Test(T t, TT tt)
        {
            LuaConsole.Print(t, tt);
        }
        public static void STest(T t, TT tt)
        {
            LuaConsole.Print("static", t, tt);
            Dictionary<T, TT> dict = new Dictionary<T, TT>();
            dict.Add(t, tt);
            LuaConsole.Print("dict count:", dict.Count);
            foo<T, TT> f = new foo<T, TT>();
            f.parse("abc", "def");
            Singleton<foo<T, TT>>.instance.parse("ghi", "jkl");
        }
    }
}

public class Singleton<T> where T : new()
{
    public Singleton()
    {
        if (ms_instance != null) {
            LuaConsole.Print("Cannot have two instances in singleton");
            return;
        }
        ms_instance = (T)(System.Object)this;
    }
        
    public static T instance
    {
        get
        {
            if (ms_instance == null) {
                ms_instance = new T();
            }
            return ms_instance;
        }
    }

    public static void Delete()
    {
        ms_instance = default(T);
    }

    protected static T ms_instance;
}

public class Test1 : Singleton<Test1>
{
    public void Output()
    {
        LuaConsole.Print("Test1");
    }
}

public class Test2 : Singleton<Test2>
{
    public void Output()
    {
        LuaConsole.Print("Test2");
    }
}

public class Test3 : Singleton<Test3>
{
    public void Output()
    {
        LuaConsole.Print("Test3");
    }
}

public class Entry
{
    public static void Main()
    {
        Test1.instance.Output();
        Test2.instance.Output();
        Test3.instance.Output();
        GenericClass<int>.InnerGenericClass<string> ic = new GenericClass<int>.InnerGenericClass<string>();
        ic.Test(123, "test");
        GenericClass<long>.InnerGenericClass<long>.STest(123, 456);
    }
}

//Entry.Main();