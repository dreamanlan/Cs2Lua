// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

namespace SLua
{

    /// <summary>
    /// A bridge between UnityEngine.Debug.LogXXX and standalone.LogXXX
    /// </summary>
    public class Logger
    {

        public static void Log(string msg, bool hasStacktrace = false)
        {
            if (hasStacktrace) {
                // Disable Stacktrace so we can jump
                var Type = UnityEngine.Application.GetStackTraceLogType(UnityEngine.LogType.Error);
                UnityEngine.Application.SetStackTraceLogType(UnityEngine.LogType.Error, UnityEngine.StackTraceLogType.None);
                UnityEngine.Debug.Log(msg);
                UnityEngine.Application.SetStackTraceLogType(UnityEngine.LogType.Error, Type);
            }
            else {
                UnityEngine.Debug.Log(msg);
            }
        }
        public static void LogError(string msg, bool hasStacktrace = false)
        {
            if (hasStacktrace) {
                // Disable Stacktrace so we can jump
                var Type = UnityEngine.Application.GetStackTraceLogType(UnityEngine.LogType.Error);
                UnityEngine.Application.SetStackTraceLogType(UnityEngine.LogType.Error, UnityEngine.StackTraceLogType.None);
                UnityEngine.Debug.LogError(msg);
                UnityEngine.Application.SetStackTraceLogType(UnityEngine.LogType.Error, Type);
            }
            else {
                UnityEngine.Debug.LogError(msg);
            }
        }

        public static void LogWarning(string msg, bool hasStacktrace = false)
        {
            if (hasStacktrace) {
                // Disable Stacktrace so we can jump
                var Type = UnityEngine.Application.GetStackTraceLogType(UnityEngine.LogType.Error);
                UnityEngine.Application.SetStackTraceLogType(UnityEngine.LogType.Error, UnityEngine.StackTraceLogType.None);
                UnityEngine.Debug.LogWarning(msg);
                UnityEngine.Application.SetStackTraceLogType(UnityEngine.LogType.Error, Type);
            }
            else {
                UnityEngine.Debug.LogWarning(msg);
            }
        }
        public static void LogLuaStack(IntPtr L, string msg)
        {
            LuaDLL.lua_getfield(L, LuaIndexes.LUA_GLOBALSINDEX, "debug");
            LuaDLL.lua_getfield(L, -1, "traceback");
            LuaDLL.lua_remove(L, -2);
            LuaDLL.lua_pushstring(L, msg);
            LuaDLL.lua_pushinteger(L, 2);
            LuaDLL.lua_call(L, 2, 1);
            LogWarning(LuaDLL.lua_tostring(L, -1));
        }
    }


}