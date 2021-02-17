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

struct TestStruct
{    
    internal int m_A;
    internal int m_B;
    internal int m_C;

    public static implicit operator int(TestStruct ts)
    {
        return ts.m_A;
    }
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

public class StrStrDict : Dictionary<string, string>
{
    public StrStrDict() { }
    public StrStrDict(int capacity) : base(capacity) { }
    public StrStrDict(IDictionary<string, string> dict) : base(dict) { }
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

public sealed class Cs2LuaKeyValuePair<TKey, TValue>
{
    private TKey key;
    private TValue value;

    public Cs2LuaKeyValuePair(TKey key, TValue value)
    {
        this.key = key;
        this.value = value;
    }

    public Cs2LuaKeyValuePair()
    {
        var t1 = typeof(TKey);
        var t2 = typeof(TValue);
        t2 = (TValue)t1;
        this.key = default(TKey);
        this.value = default(TValue);
    }

    public TKey Key
    {
        get { return key; }
    }

    public TValue Value
    {
        get { return value; }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append('[');
        if ((object)this.Key != null)
            stringBuilder.Append(this.Key.ToString());
        stringBuilder.Append(", ");
        if ((object)this.Value != null)
            stringBuilder.Append(this.Value.ToString());
        stringBuilder.Append(']');
        return stringBuilder.ToString();
    }
}


internal class SettingInfoWrapper
{
    public virtual void OnInit() { }
    public virtual int OnGet() { return -1; }
    public virtual int OnSet(int _value) { return -1; }
    public virtual int OnSave() { return -1; }
    public virtual int OnLoad() { return -1; }
    public virtual int OnCache() { return -1; }
    public virtual int OnRestore() { return -1; }
}

sealed class SIW_DeviceFirstUse : SettingInfoWrapper
{
    public override void OnInit()
    {
    }
    public override int OnLoad()
    {
        return -1;
    }
    public override int OnSet(int _value)
    {
        return base.OnSet(_value);
    }
}

public interface IDict
{
    void Add(object val);
}
public abstract class AbstractDictClass : IDict
{
    public void Add(object val)
    {
        AddImpl(val);
    }
    protected abstract void AddImpl(object val);
}
public sealed class DictClass : AbstractDictClass
{
    protected override void AddImpl(object val)
    {
    }
}

class Test
{
    public static implicit operator Exception(int v)
    {
        return new Exception(v.ToString());
    }
    public int? this[params int?[] args]
    {
        get { return args[0]; }
        set { args[0] = value; }
    }
    public void Init()
    {
        int a = 2;
        List<int> intlist = new List<int>();
        intlist.Add(1);
        var ts = new TestStruct();
        intlist.Add(ts);
        var rs = from score in a
                 where score > 80
                 select score;
    }
    public int testcall()
    {
        object data = 1;
        int v = (int)data;
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
        List<int> intlist = new List<int>();
        try {
            return aa();
        }
        catch(Exception e) when(e is System.ArgumentException) {
            Console.WriteLine("ex:{0} {1} {2}", a, b, c);
            throw a;
            return 0;
        }       
        finally {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }

        this.m_IntVal = a > 1 ? aa() : c;
    }
    internal void LoadStartupView_FGUI(string className, string comName, string packageName, ViewGroup grp = ViewGroup.View, bool ForceShow = false)
    {
        SIW_DeviceFirstUse dfu = new SIW_DeviceFirstUse();
        dfu.OnSet(0);
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
    private Cs2LuaKeyValuePair<int, int> m_IntIntKeyValue = new Cs2LuaKeyValuePair<int, int>();
}