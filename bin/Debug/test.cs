using System;
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
                }
                public void Test<G>(G g)
                {
                }
                public void Test2<GG>(T t, TT tt)
                {
                    Type t1 = typeof(GG);
                    Type t2 = typeof(T);
                    Type t3 = typeof(TT);
                    Type t4 = typeof(int);
                }

                private T m_T = default(T);
                private TT m_TT = default(TT);
                private Type m_TypeT = typeof(T);
                private Type m_TypeTT = typeof(TT);
            }

            public static int TTT = 789;
            public GenericClass(ref int v, out int v2)
            {
                m_Test = v + 456;
                v2 = 123;
            }
            private int m_Test = 123;
            private int m_Test2 = TTT + 1;

            static GenericClass()
            {
                s_Test = 9876;
            }
            private static int s_Test = 8765;
        }
        delegate void SimpleEventHandler();
        class FooBase
        {
            internal int m_Ttt = 6789;
        }
        [Cs2Lua.EnableBaseClass]
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

            public Foo():this(0)
            {}
            public Foo(int v):base()
            {
                this.m_Test = v;
            }
            public Foo(int a, int b)
            {}

            public void GTest(GenericClass<int> arg){}
            public void GTest(GenericClass<float> arg){}

            public void Test()
            {
                GenericClass<Test1>.InnerGenericClass<Test2> t = new GenericClass<Test1>.InnerGenericClass<Test2>(new Test1(), new Test2());
                t.Test(123);
                t.Test2<int>(new Test1(), new Test2());
            }

            internal int m_Test = 0;
            internal int m_Test2 = 0;
        } 
    }
}
/*
local obj = TopLevel.Child2.Bar:new();
obj:Test();
*/