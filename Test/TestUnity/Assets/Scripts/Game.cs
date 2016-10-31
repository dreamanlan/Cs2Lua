using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
    void Awake()
    {
        Cs2LuaAssembly.Instance.Init();
        Cs2LuaAssembly.Instance.Load("Cs2LuaScript.dll");
    }
    void Start()
    {

    }
    void Update()
    {

    }
}
