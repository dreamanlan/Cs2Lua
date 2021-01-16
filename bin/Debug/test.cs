using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

[Cs2Dsl.Ignore]
class LuaConsole
{
    public static void Print(params object[] args)
    {
    }
}

enum ViewGroup
{
    View = 0,
}

class Constant
{
    internal const string One = "";
    internal const string Two = "";
    internal const string Three = "";
}

public class StrList : List<string>
{
    public StrList():base() { }
    public StrList(int c):base(c) { }
    public StrList(ICollection<string> coll) : base(coll) { }
}

public class Vector3List : List<Vector3>
{
    public Vector3List() : base() { }
    public Vector3List(int c) : base(c) { }
    public Vector3List(ICollection<Vector3> coll) : base(coll) { }
}

public interface ICs2LuaPoolAllocatedObjectEx<T> where T : ICs2LuaPoolAllocatedObjectEx<T>
{
    void InitPool(Cs2LuaObjectPoolEx<T> pool);
    T Downcast();
}
public sealed class Cs2LuaObjectPoolEx<T> where T : ICs2LuaPoolAllocatedObjectEx<T>
{
    public void Init(Func<T> creater, Action<T> destroyer)
    {
        m_Creater = creater;
        m_Destroyer = destroyer;
    }
    [Cs2Dsl.InvokeToLuaLib("TestLuaLib", true)]
    public void Init(int initPoolSize, Func<T> creater, Action<T> destroyer)
    {
        m_Creater = creater;
        m_Destroyer = destroyer;
        for (int i = 0; i < initPoolSize; ++i) {
            T t = creater();
            t.InitPool(this);
            m_UnusedObjects.Enqueue(t);
        }
    }
    public T Alloc()
    {
        if (m_UnusedObjects.Count > 0)
            return m_UnusedObjects.Dequeue();
        else {
            T t = m_Creater();
            if (null != t) {
                t.InitPool(this);
            }
            return t;
        }
    }
    public void Recycle(ICs2LuaPoolAllocatedObjectEx<T> t)
    {
        if (null != t) {
            m_UnusedObjects.Enqueue(t.Downcast());
        }
    }
    public void Clear()
    {
        if (null != m_Destroyer) {
            foreach (var item in m_UnusedObjects) {
                m_Destroyer(item);
            }
        }
        m_UnusedObjects.Clear();
    }
    public int Count
    {
        get {
            return m_UnusedObjects.Count;
        }
    }

    private Queue<T> m_UnusedObjects = new Queue<T>();
    private Func<T> m_Creater = null;
    private Action<T> m_Destroyer = null;
}

internal sealed class DataChangeCallBackInfo : ICs2LuaPoolAllocatedObjectEx<DataChangeCallBackInfo>
{
    public int m_ActorId;

    public DataChangeCallBackInfo()
    {
        reset();
    }
    public void reset()
    {
        m_ActorId = 0;
    }
    public DataChangeCallBackInfo Downcast()
    {
        return this;
    }
    public void InitPool(Cs2LuaObjectPoolEx<DataChangeCallBackInfo> pool)
    {

    }
}

class Test
{
    public int? this[params int?[] args]
    {
        get { return args[0]; }
        set { args[0] = value; }
    }
    public void Init()
    {
        string[] items = { "全部", "进行中", "可接取", "已完成", "未获取" };
        m_DataChangeCallBackInfoPool.Init(32, () => { return new DataChangeCallBackInfo(); }, v => { });
        StrList strlist = new StrList();
        strlist.Add(string.Empty);
        strlist.Sort((a, b) => a.CompareTo(b));
        List<int> intlist = new List<int>();
        intlist.Add(1);
        var sa = strlist[0];
        intlist.Sort((a, b) => a.CompareTo(b));
        int iaa = null != strlist ? strlist.Count : intlist.Count;
        int[] aa = new int[] { 1, 2, 3, 4, 5 };
        int[,] bb = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        var ia = bb[0,1];
        foreach( var s in strlist) {
            Console.WriteLine(s);
        }
        foreach(var v in aa) {
            Console.WriteLine(v);
        }
        foreach(var v in bb) {
            Console.WriteLine(v);
        }
        var act = (Action)(()=> { Console.Write(ia); });
        var cc = ToList(aa);
        List<Vector3> v3list = new List<Vector3>();
        v3list.Add(Vector3.zero);
        Vector3List nv3list = new Vector3List();
        nv3list.Add(Vector3.zero);
        var v3 = ToArray(nv3list)[0];
    }
    public int testcall()
    {
        m_Vs[0] = UnityEngine.Vector3.zero;
        var v = m_Vs[0];
        return 1;
    }
    public int test()
    {
        int a = 2, b = 0, c = 1;
        var aa = new Func<int>(()=> {
            try {
                Console.Write("test");
            }
            catch(Exception ex) {

            }
            try {
                return testcall();
            }
            catch (Exception ex) {
                return 0;
            }
        });

        try {
            Console.Write("test");
        }
        catch (Exception ex) {

        }
        try {
            return aa();
        }
        catch(Exception e) {
            Console.WriteLine("ex:{0} {1} {2}", a, b, c);
            return 0;
        }
        finally {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }

        this.m_IntVal = a > 1 ? aa() : c;
    }
    internal static void LoadStartupView_FGUI(string className, string comName, string packageName, ViewGroup grp = ViewGroup.View, bool ForceShow = false)
    {
    }
    internal static List<T> ToList<T>(IEnumerable<T> enumer)
    {
        LoadStartupView_FGUI(Constant.One, Constant.Two, Constant.Three);
        var r = new List<T>();
        foreach (var v in enumer) {
            r.Add(v);
        }
        return r;
    }
    internal static T[] ToArray<T>(IList<T> list)
    {
        var arr = new T[list.Count];
        list.CopyTo(arr, 0);
        return arr;
    }
    private Cs2LuaObjectPoolEx<DataChangeCallBackInfo> m_DataChangeCallBackInfoPool = new Cs2LuaObjectPoolEx<DataChangeCallBackInfo>();
    private int m_IntVal = 0;
    private Vector3[] m_Vs = new Vector3[10];
}