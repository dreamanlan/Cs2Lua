using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public interface INormal
{

}

public class NormalClass : INormal
{
    public void TestExtension(int a)
    {

    }
    public void TestExtension(int a, int b)
    {

    }
}

public static class NormalClassExtension
{
    public static void TestExtension(this NormalClass obj)
    {

    }
    public static void TestExtension(this NormalClass obj, int a)
    {

    }
    public static void TestExtension2(this INormal obj)
    {

    }
    public static void TestExtension2(this INormal obj, int a, int b)
    {

    }
}

public class TestClass
{
    public void Test(NormalClass obj)
    {
        obj.TestExtension();
        obj.TestExtension2();
        obj.TestExtension(123);
        INormal o = obj;
        o.TestExtension2();
    }
}
