using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

[Cs2Dsl.Ignore]
class LuaConsole
{
    public static void Print(params object[] args)
    {
    }
}

class ZipInputStream
{
  public ZipInputStream(MemoryStream ms)
  {}
}

class ZipOutputStream
{
  public ZipOutputStream(MemoryStream ms)
  {}
}

class CUsingHelper : IDisposable
{
    public CUsingHelper(Action a1, Action a2)
    {    
    }
    public void Dispose()
    {
    }
    public static byte[] Test(int i)
    {
        return null;
    }
  
    [System.CLSCompliant(true)]
	public static byte[] ReadZip(byte[] bytes)
	{
        int[,] abc = new int[12, 13];
        int v = 0;
        var dict = new Dictionary<int, int>();
        if (++v > 0) {
        }
        else {
            if (dict.TryGetValue(1, out v) && v == 0) {
            }
            else if (v++ > 0) {
            }
            else if (--v > 0) {
            }
            else {

            }
        }
        /*
        if(dict.TryGetValue(1, out v) && v==0) {

        }
        while (dict.TryGetValue(1, out v) && v == 0) {
        }
        do {
        } while (dict.TryGetValue(1, out v) && v == 0);
        
        int v1 = ++v + 2;
        int v2 = v++ + 2;
        if(++v > 0) {
        }
        if(v++ > 0) {
        }
        while(++v > 0) {
        }
        while (v-- > 0) {
        }
        do {
        } while (++v > 0);
        do {
        } while (v-- > 0);
        */
        /*
        ZipInputStream zipInput = new ZipInputStream(new MemoryStream(bytes));
		MemoryStream zipMemory = new MemoryStream();
		ZipOutputStream ZipStream = new ZipOutputStream(zipMemory);
		try
		{
			return Test(123);
		}
		catch (Exception)
		{
			return null;
			throw;
		}
        */
    }
}