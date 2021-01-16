using System;

namespace Cs2Dsl
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
        public RequireAttribute(params string[] scriptModuleNames)
        {
            m_ScriptModuleNames = scriptModuleNames;
        }

        private string[] m_ScriptModuleNames = null;
    }

    [System.AttributeUsage(System.AttributeTargets.Method)]
    public sealed class TranslateToAttribute : System.Attribute
    {
        public TranslateToAttribute(string scriptModuleName, string targetMethodName)
        {
            m_ScriptModuleName = scriptModuleName;
            m_TargetMethodName = targetMethodName;
        }

        private string m_ScriptModuleName = string.Empty;
        private string m_TargetMethodName = string.Empty;
    }

    [System.AttributeUsage(System.AttributeTargets.Method)]
    public sealed class InvokeToLuaLibAttribute : System.Attribute
    {
        public InvokeToLuaLibAttribute(string luaLibFuncName, bool addTypeInfo)
        {
            m_LuaLibFunctionName = luaLibFuncName;
            m_AddTypeInfo = addTypeInfo;
        }

        private string m_LuaLibFunctionName = string.Empty;
        private bool m_AddTypeInfo = false;
    }

    [System.AttributeUsage(System.AttributeTargets.Method)]
    public sealed class NeedFuncInfoAttribute : System.Attribute
    { }

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
