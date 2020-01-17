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
}