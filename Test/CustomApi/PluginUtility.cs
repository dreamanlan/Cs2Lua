using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

//MonoBehaviourProxy
public sealed class MonoBehaviourProxy
{
    public MonoBehaviourProxy(UnityEngine.MonoBehaviour monoBehavior)
    {
        m_MonoBehaviour = monoBehavior;
    }
    public void StartCoroutine(IEnumerator routine)
    {
        m_MonoBehaviour.StartCoroutine(routine);
    }
    public void StopAllCoroutines()
    {
        m_MonoBehaviour.StopAllCoroutines();
    }

    public Coroutine StartOneCoroutine(IEnumerator routine)
    {
        return m_MonoBehaviour.StartCoroutine(routine);
    }

    private UnityEngine.MonoBehaviour m_MonoBehaviour = null;
}
