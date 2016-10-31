using UnityEngine;
using System.Collections.Generic;
using System.Text;

public interface IStartupPlugin
{
    void Start(GameObject obj);
}
public interface IStartupPluginFactory
{
    IStartupPlugin CreateInstance();
}
public sealed class StartupPluginFactory<T> : IStartupPluginFactory where T : IStartupPlugin, new()
{
    public IStartupPlugin CreateInstance()
    {
        return new T();
    }
}
