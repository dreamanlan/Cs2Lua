using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public delegate IEnumerator FadingCoroutine();

public class DelegateTest : MonoBehaviour
{
    public FadingCoroutine Fading;

    public IEnumerator NormalEnumerator()
    {
        yield return 0;
        yield return 1;
        yield break;
    }

    public void Test()
    {
        Fading = NormalEnumerator;
        return StartCoroutine(Fading());
    }
}
