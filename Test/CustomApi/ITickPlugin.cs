using UnityEngine;
using System.Collections.Generic;
using System.Text;

public interface ITickPlugin
{
    void Init(GameObject obj);
    void Update();
    void FixedUpdate();
    void LateUpdate();
    void Call(string name, params object[] args);
}
public interface ITickPluginFactory
{
    ITickPlugin CreateInstance();
}
public sealed class TickPluginFactory<T> : ITickPluginFactory where T : ITickPlugin, new()
{
    public ITickPlugin CreateInstance()
    {
        return new T();
    }
}
