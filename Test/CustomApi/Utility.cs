using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

public partial class Utility
{
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