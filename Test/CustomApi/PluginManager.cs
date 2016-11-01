using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public interface IObjectPluginFactory
{
    object CreateInstance();
}
public sealed class ObjectPluginFactory<T> : IObjectPluginFactory where T : new()
{
    public object CreateInstance()
    {
        return new T();
    }
}
public class PluginManager
{
    public object CreateObject(string name)
    {
        IObjectPluginFactory factory;
        if (m_ObjectFactories.TryGetValue(name, out factory)) {
            return factory.CreateInstance();
        }
        return null;
    }
    public IStartupPlugin CreateStartup(string name)
    {
        IStartupPluginFactory factory;
        if (m_StartupFactories.TryGetValue(name, out factory)) {
            return factory.CreateInstance();
        }
        return null;
    }
    public ITickPlugin CreateTick(string name)
    {
        ITickPluginFactory factory;
        if (m_TickFactories.TryGetValue(name, out factory)) {
            return factory.CreateInstance();
        }
        return null;
    }
    public void RegisterObjectFactory(string name, IObjectPluginFactory factory)
    {
        if (!m_ObjectFactories.ContainsKey(name)) {
            m_ObjectFactories.Add(name, factory);
        } else {
            m_ObjectFactories[name] = factory;
        }
    }
    public void RegisterStartupFactory(string name, IStartupPluginFactory factory)
    {
        if (!m_StartupFactories.ContainsKey(name)) {
            m_StartupFactories.Add(name, factory);
        } else {
            m_StartupFactories[name] = factory;
        }
    }
    public void RegisterTickFactory(string name, ITickPluginFactory factory)
    {
        if (!m_TickFactories.ContainsKey(name)) {
            m_TickFactories.Add(name, factory);
        } else {
            m_TickFactories[name] = factory;
        }
    }

    private Dictionary<string, IObjectPluginFactory> m_ObjectFactories = new Dictionary<string, IObjectPluginFactory>();
    private Dictionary<string, IStartupPluginFactory> m_StartupFactories = new Dictionary<string, IStartupPluginFactory>();
    private Dictionary<string, ITickPluginFactory> m_TickFactories = new Dictionary<string, ITickPluginFactory>();

    public static PluginManager Instance
    {
        get { return s_Instance; }
    }
    private static PluginManager s_Instance = new PluginManager();
};
