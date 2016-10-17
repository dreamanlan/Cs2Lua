//test
using System;
using System.Collections.Generic;
//---------------------------------
class LuaConsole
{
    public static void Print(params object[] args)
    {
#if __LUA__
        print(args);
#endif
    }
}

namespace TopLevel 
{     
#region abc
    
    namespace Child1 
    {         
        delegate void SimpleEventHandler();

        class Foo 
        {
            public event SimpleEventHandler OnSimple;
            public SimpleEventHandler OnSimple2;

            public Foo()
            {}
            public Foo(int v)
            {
                this.m_Test = v;
            }

            public void Test(int a, ref int b, out int c, params int[] args)
            {
                Func<int, int> f = p1 => p1;
                f(1);
                Func<int, int, int> f2 = (p1, p2) => { return p1 + p2; };
                f2(1, 2);
                m_Test = a + b + 123;
                b = a < b ? a : b;
                if (a > 0)
                {
                    c = a + b + args[0];
                }
                if (a < b) {
                    c = b - a;
                } else if (a >= b) {
                    c = a - b;
                }
                if (a < b) {
                    c = b - a;
                } else {
                    c = a - b;
                }
                if (a < b) {
                    c = b - a;
                } else if (a < c) {
                    c = a - b;
                } else {
                    c = 0;
                }
            }

            public int Test2(int a, int b, ref int c, out int d)
            {
                c += a + b;
                d = c * 2;
                return c;
            }

            internal int m_Test = 0;
        } 
    } 
    
#endregion

    namespace Child2 
    { 
        enum TestEnum
        {
            One = 0,
            Two,
            Three,
        }
        struct Point
        {
            public static float X;
            public static float Y;
        }
        class Bar : IDictionary<int, int>
        {
            delegate void IntHandler(int v);
            public void Handler()
            {
                var f = delegate() {
                    LuaConsole.Print(1, 2, 3);
                };
                Test(123);
                IntHandler t = Test;
                t(1);
            }
            public void Test()
            {
                var F = Child2.Bar.s_Test;
                Child1.Foo f = new Child1.Foo(123);
                f.OnSimple = this.Handler;
                var ff = new Child1.Foo { m_Test = 456 };
                int a = 0, b = 0, c = 0;
                b = (c += (int)2);
                Dictionary<string, int> dict = new Dictionary<string, int> { { "key", "value" } };
                f.Test(1, ref b, out c, 3);
                LuaConsole.Print(b, c);
                int r = 0;
                r += f.Test2(1, 2, ref b, out c);
                LuaConsole.Print(r, b, c);
                int v;
                v = f.Test2(3, 4, ref b, out c);
                LuaConsole.Print(v, b, c);
                while (a < 10 + 2) {
                    if (a < 5 + 3) continue;
                    ++a;
                }
                do
                {
                    ++b;
                }while(b<100);
                int[] abc = new int[256];
                int[] def = new int[] { 1, 2, 3, 4, 5 };
                int[][][] g0 = new int[3][][];
                int[, ,] h0 = new int[3, 5, 7];
                int[][] g = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
                int[,] h = new int[,] { { 1, 2 }, { 3, 4 } };

                for (int i = 0; i < g0.Length; ++i) {
                    g0[i] = new int[3][];
                    if (1 < 2) break;
                    if (2 < 3) continue;
                    for (int j = 0; j < g0[i].Length; ++j) {
                        g0[i][j] = new int[3];
                    }
                }

                for (int i = 0; i < h0.GetLength(0); ++i) {
                    for (int j = 0; j < h0.GetLength(1); ++j) {
                        for (int k = 0; k < h0.GetLength(2); ++k) {
                            h0[i, j, k] = i * j * k;
                        }
                    }
                }

                var hh = new[] { 5 + 2, 6, 7, 8 };

                switch (a) {
                    case 1:
                    case 3:
                        if (a == 1)
                            break;
                        break;
                    case 4:
                    default:
                        break;
                    case 2:
                        break;
                }

                foreach (var i in def) {
                    s_Test += i;
                }
            }
            public void Test(int v)
            {
                LuaConsole.Print(v);
            }

            public static int s_Test = 123;
        } 
    } 
}
/*
local obj = TopLevel.Child2.Bar:new();
obj.Test();
*/