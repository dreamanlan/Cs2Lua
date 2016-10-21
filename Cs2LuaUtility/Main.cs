using System;

namespace Cs2Lua
{
    [System.AttributeUsage(System.AttributeTargets.All)]
    public sealed class IgnoreAttribute : System.Attribute
    { }

    [System.AttributeUsage(System.AttributeTargets.All)]
    public sealed class RequireAttribute : System.Attribute
    {
        public string LuaModuleName
        {
            get { return m_LuaModuleName; }
            set { m_LuaModuleName = value; }
        }
        public RequireAttribute(string luaModuleName)
        {
            m_LuaModuleName = luaModuleName;
        }

        private string m_LuaModuleName = string.Empty;
    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public sealed class EntryAttribute : System.Attribute
    { }

    [System.AttributeUsage(System.AttributeTargets.Constructor)]
    public sealed class ExportAttribute : System.Attribute
    { }
}
