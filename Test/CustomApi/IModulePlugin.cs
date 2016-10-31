using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IModulePlugin
{
    void Init();
}
public interface IModulePluginFactory
{
    IModulePlugin CreateInstance();
}
public sealed class ModulePluginFactory<T> : IModulePluginFactory where T : IModulePlugin, new()
{
    public IModulePlugin CreateInstance()
    {
        return new T();
    }
}
