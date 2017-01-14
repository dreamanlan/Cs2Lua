using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public delegate IEnumerator FadingCoroutine();
public delegate void OnHandleDelegation();

public class ConvTest
{
    public OnHandleDelegation OnHandleValue;
    public event OnHandleDelegation OnHandle = OnHandleValue;
    public int this[int ix]
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }
    public int Prop
    {
        get
        {
            return m_Val;
        }
        set
        {
            m_Val = value;
        }
    }
    public Object TestConv(int a, int b)
    {
        int[] arr = new int[1];
        DelegateTest dt = new DelegateTest();
        this.Prop = dt;
        this[0]=dt;
        arr[0]=dt;
        DelegateTest v = this.Prop;
        DelegateTest v2 = this[0];
        DelegateTest v3 = arr[0];
        DelegateTest vv,vv2,vv3;
        vv = this.Prop;
        vv2 = this[0];
        vv3 = arr[0];       
        DelegateTest v4 = arr[0];
        int[] arr2 = null;
        v4 = arr2?[0];
        DelegateTest vv4 = arr2?[0];
        ConvTest ct = null;
        dt = ct?.Prop;
        dt = ct?[0];
        DelegateTest v5 = ct?[0];
        DelegateTest vv5;
        vv5 = ct?[0];
        return null;
    }
    public Object TestConv2(int a, int b, out int c)
    {
        Object obj = null;;
        bool[] arr = new bool[]{obj, obj, obj};
        Dictionary<string, bool> dict = new Dictionary<string,bool>{{"1",obj},{"2",obj}};
        List<bool> list = new List<bool>{obj,obj,obj};
        bool[] tarr; tarr = new bool[]{obj, obj, obj};
        Dictionary<string, bool> tdict; tdict = new Dictionary<string,bool>{{"1",obj},{"2",obj}};
        List<bool> tlist; tlist = new List<bool>{obj,obj,obj};
        List<List<bool>> f = new List<List<bool>> { { obj, obj }, { obj, obj } };
        c = 1;
        return null;
    }
    public DelegateTest TestConv3(int a, int b, out int c)
    {
        c = 1;
        return null;
    }
    public bool TestConv4(int v) => new GameObject();

    internal int m_Val = new DelegateTest();
}

public class DelegateTest : MonoBehaviour
{
    public FadingCoroutine Fading;

    public Object this[int ix]
    {
        get { return null; }
        set { }
    }
    public Object ObjProp
    {
        get { return null; }
        set { }
    }

    public IEnumerator NormalEnumerator()
    {
        Object obj = null;
        if (!obj) {
            yield break;
        }
        yield return 0;
        Test2(obj, obj);
        yield return 1;
        bool v1 = obj, v2 = obj;
        bool v3;
        v3 = obj;
        bool vv = Test(obj);
        int v4 = 0;
        v4 += (int)(object)(bool)obj;
        yield break;
    }

    public bool Test(bool v)
    {
        Fading = NormalEnumerator;
        StartCoroutine(Fading());
        GameObject obj = null;
        int v0 = (obj) ? 1 : 0;
        System.Func<bool, bool> f0 = vv => obj;
        System.Func<bool, bool> f = (vv) => obj;
        if (obj) {
            Test2(true, false);
        }
        do {

        } while (obj);
        while (obj) {
        }
        for (; obj; ) {
        }
        ConvTest ct = new ConvTest{m_Val = new DelegateTest()};
        return obj;
    }
    
    private void Test2(bool v1, bool v2)
    {
        if (v1 || v2) {
            Debug.Log(v1);
            Debug.Log(v2);
        }
        ConvTest tc = new ConvTest();
        bool vv = tc.TestConv(1, this);
        bool vv2;
        vv2 = tc.TestConv(1, 2);
        int r;
        bool vv3 = tc.TestConv2(1, this, out r);
        bool vv4;
        vv4 = tc.TestConv2(2, this, out r);
        int vv5;
        vv5 = tc.TestConv3(3, this, out r);
        tc.Prop = 123;
        int vvv = tc.Prop;
        Test(tc.TestConv(this,2));
        Object[] arr = new Object[1] { null };
        Test(arr[0]);
        Test(this.ObjProp);
        Test(this[0]);
    }

    public static implicit operator int(DelegateTest thisObj) => 0;
    public static implicit operator DelegateTest(int v) => new DelegateTest();
}
