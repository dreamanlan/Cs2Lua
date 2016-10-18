using System;
using UnityEngine;

class LuaConsole
{
    public static void Print(params object[] args)
    {
#if __LUA__
        print(args);
#endif
    }
}

class MyScript
{
    public void Init(GameObject parent)
    {
        var obj = new GameObject("test");
        obj.transform.parent = parent.transform;
        obj.SetActive(true);
        string s = "123";
    }

    public void Update()
    {

    }
}