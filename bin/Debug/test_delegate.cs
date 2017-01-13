using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public delegate IEnumerator FadingCoroutine();

public class DelegateTest : MonoBehaviour
{
    public FadingCoroutine Fading;

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
        int v4 = 0;
        v4 += (int)(bool)obj;
        yield break;
    }

    public bool Test()
    {
        Fading = NormalEnumerator;
        StartCoroutine(Fading());
        GameObject obj = null;
        System.Func<bool, bool> f = (v) => obj;
        if (obj) {
            Test2(true, false);
        }
        do {

        } while (obj);
        while (obj) {
        }
        for (; obj; ) {
        }
        return obj;
    }

    private void Test2(bool v1, bool v2)
    {
        if (v1 || v2) {
            Debug.Log(v1);
            Debug.Log(v2);
        }
    }
}
