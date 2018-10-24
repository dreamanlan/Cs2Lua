using System;

namespace Cs2Lua
{
    [System.AttributeUsage(System.AttributeTargets.All)]
    public sealed class DontCheckAttribute : System.Attribute
    { }

    [System.AttributeUsage(System.AttributeTargets.All)]
    public sealed class IgnoreAttribute : System.Attribute
    { }

    [System.AttributeUsage(System.AttributeTargets.All)]
    public sealed class RequireAttribute : System.Attribute
    {
        public RequireAttribute(string luaModuleName)
        {
            m_LuaModuleName = luaModuleName;
        }

        private string m_LuaModuleName = string.Empty;
    }

    [System.AttributeUsage(System.AttributeTargets.Method)]
    public sealed class TranslateToAttribute : System.Attribute
    {
        public TranslateToAttribute(string luaModuleName, string targetMethodName)
        {
            m_LuaModuleName = luaModuleName;
            m_TargetMethodName = targetMethodName;
        }

        private string m_LuaModuleName = string.Empty;
        private string m_TargetMethodName = string.Empty;
    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public sealed class EntryAttribute : System.Attribute
    { }

    [System.AttributeUsage(System.AttributeTargets.Constructor)]
    public sealed class ExportAttribute : System.Attribute
    { }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public sealed class EnableInheritAttribute : System.Attribute
    { }
}
