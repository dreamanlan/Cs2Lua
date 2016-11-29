using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Cs2Lua.Ignore]
class LuaConsole
{
    public static void Print(params object[] args)
    {
    }
}

namespace TopLevel
{
    using lua = LuaConsole;

    enum TestEnum
    {
        One = 1,
        Two,
        Three,
    }

    struct TestStruct
    {
        public int A;
        public int B;
        public int C;
    }

    public class Singleton<T> where T : new()
    {
        protected static T ms_instance;
        public static T instance
        {
            get
            {
                if (ms_instance == null) 
                {
                    ms_instance = new T();
                }
                return ms_instance;
            }
        }

        public Singleton()
        {
            if (ms_instance != null)
            {
                Debug.LogError("Cannot have two instances in singleton");
                return;
            }
            ms_instance = (T)(System.Object)this;
        }

        public static void Delete()
        {
            ms_instance = default(T) ;
        }
    }
    
    namespace SecondLevel
    {
        public class GenericClass<T> where T : new()
        {
            public class InnerGenericClass<TT> where TT : new()
            {
                public InnerGenericClass(T v, TT vv)
                {
                    m_T = v;
                    m_TT = vv;
                    T obj1 = new T();
                    TT obj2 = new TT();
                }
                public void Test<G>(G g)
                {
                    T v = g as T;
                    T v = (T)(object)g;
                    Foo f = new Foo();
                    f.Test3();
                }
                public void Test2<GG>(T t, TT tt)
                {
                    Type t1 = typeof(GG);
                    Type t2 = typeof(T);
                    Type t3 = typeof(TT);
                    Type t4 = typeof(int);
                    var v = (TT)t;
                }

                private T m_T = default(T);
                private TT m_TT = default(TT);
                private Type m_TypeT = typeof(T);
                private Type m_TypeTT = typeof(TT);
            }

            public static int TTT = 789;
            public GenericClass(ref int v, out int v2)
            {
                T obj = new T();
                m_Test = v + 456;
                v2 = 123;
            }
            public void Test<G>()
            {
                var t = typeof(G);
            }
            private int m_Test = 123;
            private int m_Test2 = TTT + 1;
            private T m_Inst = new T();

            static GenericClass()
            {
                s_Test = 9876;
            }
            private static int s_Test = 8765;
            private static T s_Inst = new T();
        }
        delegate void SimpleEventHandler();
        class FooBase
        {
            internal int m_Ttt = 6789;
        }
        [Cs2Lua.EnableInherit]
        class Foo : FooBase
        {
            class Test1
            { }
            class Test2
            { }

            class FooChild
            {
                internal int m_Test1 = 123;
                internal int m_Test2 = 456;
            }

            public event SimpleEventHandler OnSimple;
            public SimpleEventHandler OnSimple2;

            public TestStruct Val
            {
                get
                {
                    return this.m_TS;
                }
                set
                {
                    this.m_TS=value;
                }
            }
            public int this[params TestStruct[] args]
            {
                get
                {
                    return 1;
                }
                set
                {

                }
            }

            public Foo():this(0)
            {}
            public Foo(int v):base()
            {
                this.m_Test = v;
            }
            public Foo(int a, int b)
            {}

            public static Foo operator + (Foo self, Foo other)
            {
                self.m_Test += other.m_Test;
                return self;
            }
            public static Foo operator + (Foo self, int val)
            {
                self.m_Test += val;
                return self;
            }
            public static explicit operator Foo (int a)
            {
                var f = new Foo();
                f.m_Test = a;
                return f;
            }

            public int Test123(int a, int b) => a+b;

            public void GTest(GenericClass<int> arg){}
            public void GTest(GenericClass<float> arg){}

            public IEnumerable Iterator()
            {
                yield return null;
                yield return new UnityEngine.WaitForSeconds(3);
                yield break;
            }

            public IEnumerator Iterator2()
            {
                yield return null;
                yield break;
            }

            public void Test()
            {
                GenericClass<Test1>.InnerGenericClass<Test2> t = new GenericClass<Test1>.InnerGenericClass<Test2>(new Test1(), new Test2());
                t.Test(123);
                t.Test2<int>(new Test1(), new Test2());

                int v;
                int vv=TestLocal(out v);

                TestStruct ts = new TestStruct();
                ts.A=1;
                ts.B=2;
                ts.C=3;
                TestStruct ts2 = ts;
                TestStruct ts3;
                ts3=ts;
                TestValueArg(ts);
            }

            private int TestLocal(out int v)
            {
                v = 1;
                return 2;
            }
            private int TestValueArg(TestStruct ts)
            {
                ts.A=4;
                ts.B=5;
                ts.C=6;
            }
            private int TestContinueAndReturn()
            {
                for (int i = 0; i < 100; ++i) {
                    if (i < 10) {
                        continue;
                    }
                    return i;
                }
                return -1;
            }
            private void TestSwitch()
            {
                int i=10;
                switch (i) {
                    case 1:
                        return;
                    case 2:
                        return;
                    default:
                        return;
                }
                if (i > 3) {
                    return;
                }
                if (this is FooBase) {
                    return;
                }
            }

            internal int m_Test = 0;
            internal int m_Test2 = 0;
            internal TestStruct m_TS;
            private HashSet<string> m_HashSet = new HashSet<string> { "one", "two", "three" };
        } 

        static class FooExtension
        {
            public static void Test3(this Foo obj)
            {
                if (obj.m_Test > 0) {
                    obj.m_Test2 = 678;
                }
                List<List<int>> f = new List<List<int>> { { 1, 2 }, { 2, 3 } };
            }
            public static void Test3(Foo obj, int ix)
            { }
            public static void TestExtern(this GameObject obj)
            { }
            public static void NormalMethod()
            {
                LuaConsole.Print(1, 2, 3, 4, 5);
                Foo f = new Foo();
                Foo ff = new Foo();

                Action f1 = f.Test;
                f1();

                Action f2 = f.Test3;
                f2();

                Test3(f);

                var r = f + ff;

                f+=ff;
                
                var rr = (Foo)123;

                var rrr = 123 as Foo;

                var obj = new GameObject("test test test");

                var arr = new int[] {1,2,3,4,56};
                var v = arr[2];
                var dict = new Dictionary<int,int> {{1,2},{3,4}};
                var v1 = dict?[1];
                List<int> list = null;
                var l = list?.Count;
                list?.Add(1);
                var v2 = list?[3]=1;
                int[] arr2 = new int[]{1,2,3,4};
                var v3 = arr2?[2]; 
                arr2?[3]=345;
                int a=1,b=2,c=3;
                a=b=c++;
            }
        }
    }
}
/*
local obj = TopLevel.Child2.Bar:new();
obj:Test();
*/