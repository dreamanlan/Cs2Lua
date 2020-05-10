using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

public partial class Utility
{
    //不要在c#里使用此方法（仅用于lua）
    public static string LuaFormat(string format, params object[] args)
    {
        for (int i = 0; i < args.Length; ++i) {
            if (args[i] is double) {
                double v = (double)args[i];
                if (v - Math.Floor(v) < double.Epsilon) {
                    if (v > 0x7fffffffffffffff) {
                        args[i] = (ulong)v;
                    }
                    else if (v > 0xffffffff || v < -0x80000000) {
                        args[i] = (long)v;
                    }
                    else if (v > 0x7fffffff) {
                        args[i] = (uint)v;
                    }
                    else {
                        args[i] = (int)v;
                    }
                }
            }
        }
        return string.Format(format, args);
    }
    public static void AppendFormat(StringBuilder sb, string format, params object[] args)
    {
        for (int i = 0; i < args.Length; ++i) {
            if (args[i] is double) {
                double v = (double)args[i];
                if (v - Math.Floor(v) < double.Epsilon) {
                    if (v > 0x7fffffffffffffff) {
                        args[i] = (ulong)v;
                    }
                    else if (v > 0xffffffff || v < -0x80000000) {
                        args[i] = (long)v;
                    }
                    else if (v > 0x7fffffff) {
                        args[i] = (uint)v;
                    }
                    else {
                        args[i] = (int)v;
                    }
                }
            }
        }
        sb.AppendFormat(format, args);
    }
    public static char StringGetChar(string str, int index)
    {
        if (index >= 0 && index < str.Length) {
            return str[index];
        }
        return '\0';
    }
    public static string CharToString(char c)
    {
        return c.ToString();
    }
    public static string CharArrayToString(char[] c)
    {
        return new String(c);
    }
    public static void Debug(string fmt, params object[] args)
    {
        if (args.Length == 0)
            UnityEngine.Debug.Log(fmt);
        else
            UnityEngine.Debug.LogFormat(fmt, args);
    }
    public static void Warn(string fmt, params object[] args)
    {
        if (args.Length == 0)
            UnityEngine.Debug.LogWarning(fmt);
        else
            UnityEngine.Debug.LogWarningFormat(fmt, args);
    }
    public static void Error(string fmt, params object[] args)
    {
        if (args.Length == 0)
            UnityEngine.Debug.LogError(fmt);
        else
            UnityEngine.Debug.LogErrorFormat(fmt, args);
    }
}