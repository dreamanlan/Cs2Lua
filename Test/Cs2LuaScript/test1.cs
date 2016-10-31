using UnityEngine;
using System.Collections;
using System.Collections.Generic;

class LuaString
{
    public static string Format(string str, params object[] args)
    {
        return string.Format(str, args);
    }
}

class MyScript : ITickPlugin
{   
    public void Init(GameObject obj)
    {
        string s = "test test test from cs2lua !";
        Debug.Log(s);
        
        root = new GameObject("root");

        var slider = GameObject.Find("Canvas/Slider").GetComponent(typeof(UnityEngine.UI.Slider)) as UnityEngine.UI.Slider;
        var counttxt = GameObject.Find("Canvas/Count").GetComponent(typeof(UnityEngine.UI.Text)) as UnityEngine.UI.Text;
        slider.onValueChanged.AddListener((float v) => {
            Reset();
            counttxt.text = LuaString.Format("cube:{0}", v);
            max = (int)v;
        });
        Reset();
    }
    public void Update()
    {
        for (int i = 0; i < cubes.Length; ++i) {
            var offset = i % 2 == 1 ? 5 : -5;
            var nr = r + Mathf.Sin(Time.time) * offset;
            var angle = i % 2 == 1 ? Time.time : -5;
            var b = new Vector3((float)(Mathf.Cos(i * Mathf.PI * 2 / max + angle) * nr), (float)(Mathf.Sin(i * Mathf.PI * 2 / max + angle) * nr), 0);
            cubes[i].transform.position = b;
        }

        if (fogStart <= 0 || t > 1) {
            fogStart = Time.time;
            bgCurrent = Camera.main.backgroundColor;
            int ix = UnityEngine.Random.Range(0, colors.Length);
            bgColor = colors[ix];
        }

        t = (Time.time - fogStart) / 10;
        Camera.main.backgroundColor = Color.Lerp(bgCurrent, bgColor, t);
    }
    [Cs2Lua.Ignore]
    public void FixedUpdate()
    { }
    [Cs2Lua.Ignore]
    public void LateUpdate()
    { }

    private void Reset()
    {
        if (null != cubes) {
            for (int i = 0; i < cubes.Length; ++i) {
                GameObject.Destroy(cubes[i]);
            }
        }
        cubes = new GameObject[max];
        var P = Resources.Load("Particle System");
        for (int i = 0; i < max; ++i) {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3((float)Mathf.Cos(i * Mathf.PI * 2 / max) * r, (float)Mathf.Sin(i * Mathf.PI * 2 / max) * r, 0);
            cube.transform.SetParent(root.transform);
            var mat = cube.GetComponent<Renderer>().material;

            var box = cube.GetComponent(typeof(BoxCollider));
            GameObject.Destroy(box);

            var p = GameObject.Instantiate(P, Vector3.zero, Quaternion.identity) as GameObject;
            p.transform.SetParent(cube.transform);

            int ix = UnityEngine.Random.Range(0, colors.Length);
            mat.color = colors[ix];

            cubes[i] = cube;
        }
    }

    private GameObject root;
    private int r = 10;
    private int max = 400;
    private float t = 0;
    private float fogStart = 0;
    private Color bgCurrent;
    private Color bgColor;
    private GameObject[] cubes = null;
    private Color[] colors = new Color[] { Color.red, Color.blue, Color.green, Color.cyan, Color.grey, Color.white, Color.yellow, Color.magenta, Color.black };
}