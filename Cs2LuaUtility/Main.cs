using System;

namespace Cs2Lua
{
    [System.AttributeUsage(System.AttributeTargets.All)]
    public sealed class MainAttribute : System.Attribute
    { }

    [System.AttributeUsage(System.AttributeTargets.All)]
    public sealed class IgnoreAttribute : System.Attribute
    { }
}
