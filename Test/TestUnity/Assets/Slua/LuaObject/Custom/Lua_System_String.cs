using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_String : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__A_Char_s(IntPtr l) {
		try {
			System.String o;
			System.Char[] a1;
			checkArray(l,1,out a1);
			o=new System.String(a1);
			pushValue(l,true);
			pushObject(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__Char__Int32_s(IntPtr l) {
		try {
			System.String o;
			System.Char a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			o=new System.String(a1,a2);
			pushValue(l,true);
			pushObject(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__A_Char__Int32__Int32_s(IntPtr l) {
		try {
			System.String o;
			System.Char[] a1;
			checkArray(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			o=new System.String(a1,a2,a3);
			pushValue(l,true);
			pushObject(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Equals__Object(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Equals(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Equals__String(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Equals(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Equals__String__StringComparison(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.StringComparison a2;
			checkEnum(l,3,out a2);
			var ret=self.Equals(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyTo(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Char[] a2;
			checkArray(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.CopyTo(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToCharArray(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.ToCharArray();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToCharArray__Int32__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.ToCharArray(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Split__A_Char(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkParams(l,2,out a1);
			var ret=self.Split(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Split__A_Char__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.Split(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Split__A_Char__StringSplitOptions(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			System.StringSplitOptions a2;
			checkEnum(l,3,out a2);
			var ret=self.Split(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Split__A_String__StringSplitOptions(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String[] a1;
			checkArray(l,2,out a1);
			System.StringSplitOptions a2;
			checkEnum(l,3,out a2);
			var ret=self.Split(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Split__A_Char__Int32__StringSplitOptions(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.StringSplitOptions a3;
			checkEnum(l,4,out a3);
			var ret=self.Split(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Split__A_String__Int32__StringSplitOptions(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.StringSplitOptions a3;
			checkEnum(l,4,out a3);
			var ret=self.Split(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Substring__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.Substring(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Substring__Int32__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.Substring(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Trim(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.Trim();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Trim__A_Char(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkParams(l,2,out a1);
			var ret=self.Trim(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TrimStart(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkParams(l,2,out a1);
			var ret=self.TrimStart(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TrimEnd(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkParams(l,2,out a1);
			var ret=self.TrimEnd(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsNormalized(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.IsNormalized();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsNormalized__NormalizationForm(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Text.NormalizationForm a1;
			checkEnum(l,2,out a1);
			var ret=self.IsNormalized(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Normalize(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.Normalize();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Normalize__NormalizationForm(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Text.NormalizationForm a1;
			checkEnum(l,2,out a1);
			var ret=self.Normalize(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CompareTo__Object(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.CompareTo(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CompareTo__String(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.CompareTo(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Contains(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Contains(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EndsWith__String(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.EndsWith(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EndsWith__String__StringComparison(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.StringComparison a2;
			checkEnum(l,3,out a2);
			var ret=self.EndsWith(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EndsWith__String__Boolean__CultureInfo(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			System.Globalization.CultureInfo a3;
			checkType(l,4,out a3);
			var ret=self.EndsWith(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IndexOf__Char(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			var ret=self.IndexOf(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IndexOf__String(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.IndexOf(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IndexOf__Char__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.IndexOf(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IndexOf__String__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.IndexOf(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IndexOf__String__StringComparison(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.StringComparison a2;
			checkEnum(l,3,out a2);
			var ret=self.IndexOf(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IndexOf__String__Int32__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.IndexOf(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IndexOf__String__Int32__StringComparison(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.StringComparison a3;
			checkEnum(l,4,out a3);
			var ret=self.IndexOf(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IndexOf__Char__Int32__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.IndexOf(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IndexOf__String__Int32__Int32__StringComparison(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.StringComparison a4;
			checkEnum(l,5,out a4);
			var ret=self.IndexOf(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IndexOfAny__A_Char(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			var ret=self.IndexOfAny(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IndexOfAny__A_Char__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.IndexOfAny(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IndexOfAny__A_Char__Int32__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.IndexOfAny(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LastIndexOf__Char(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			var ret=self.LastIndexOf(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LastIndexOf__String(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.LastIndexOf(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LastIndexOf__Char__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.LastIndexOf(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LastIndexOf__String__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.LastIndexOf(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LastIndexOf__String__StringComparison(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.StringComparison a2;
			checkEnum(l,3,out a2);
			var ret=self.LastIndexOf(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LastIndexOf__String__Int32__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.LastIndexOf(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LastIndexOf__String__Int32__StringComparison(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.StringComparison a3;
			checkEnum(l,4,out a3);
			var ret=self.LastIndexOf(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LastIndexOf__Char__Int32__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.LastIndexOf(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LastIndexOf__String__Int32__Int32__StringComparison(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.StringComparison a4;
			checkEnum(l,5,out a4);
			var ret=self.LastIndexOf(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LastIndexOfAny__A_Char(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			var ret=self.LastIndexOfAny(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LastIndexOfAny__A_Char__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.LastIndexOfAny(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LastIndexOfAny__A_Char__Int32__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.LastIndexOfAny(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PadLeft__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.PadLeft(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PadLeft__Int32__Char(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Char a2;
			checkType(l,3,out a2);
			var ret=self.PadLeft(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PadRight__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.PadRight(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PadRight__Int32__Char(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Char a2;
			checkType(l,3,out a2);
			var ret=self.PadRight(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartsWith__String(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.StartsWith(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartsWith__String__StringComparison(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.StringComparison a2;
			checkEnum(l,3,out a2);
			var ret=self.StartsWith(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartsWith__String__Boolean__CultureInfo(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			System.Globalization.CultureInfo a3;
			checkType(l,4,out a3);
			var ret=self.StartsWith(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToLower(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.ToLower();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToLower__CultureInfo(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Globalization.CultureInfo a1;
			checkType(l,2,out a1);
			var ret=self.ToLower(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToLowerInvariant(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.ToLowerInvariant();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToUpper(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.ToUpper();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToUpper__CultureInfo(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Globalization.CultureInfo a1;
			checkType(l,2,out a1);
			var ret=self.ToUpper(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToUpperInvariant(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.ToUpperInvariant();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static new public int ToString(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.ToString();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToString__IFormatProvider(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.IFormatProvider a1;
			checkType(l,2,out a1);
			var ret=self.ToString(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Clone(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.Clone();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Insert(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			var ret=self.Insert(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Replace__Char__Char(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			System.Char a2;
			checkType(l,3,out a2);
			var ret=self.Replace(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Replace__String__String(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			var ret=self.Replace(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Remove__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.Remove(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Remove__Int32__Int32(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.Remove(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTypeCode(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.GetTypeCode();
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetEnumerator(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.GetEnumerator();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Join__String__A_String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String[] a2;
			checkParams(l,2,out a2);
			var ret=System.String.Join(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Join__String__A_Object_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object[] a2;
			checkParams(l,2,out a2);
			var ret=System.String.Join(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Join__String__IEnumerable_1_String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Collections.Generic.IEnumerable<System.String> a2;
			checkType(l,2,out a2);
			var ret=System.String.Join(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Join__String__A_String__Int32__Int32_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String[] a2;
			checkArray(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=System.String.Join(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Equals__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.String.Equals(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Equals__String__String__StringComparison_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.StringComparison a3;
			checkEnum(l,3,out a3);
			var ret=System.String.Equals(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int op_Equality_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=(a1==a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int op_Inequality_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=(a1!=a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsNullOrEmpty_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.String.IsNullOrEmpty(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsNullOrWhiteSpace_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.String.IsNullOrWhiteSpace(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Compare__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.String.Compare(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Compare__String__String__Boolean_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			var ret=System.String.Compare(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Compare__String__String__StringComparison_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.StringComparison a3;
			checkEnum(l,3,out a3);
			var ret=System.String.Compare(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Compare__String__String__CultureInfo__CompareOptions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Globalization.CultureInfo a3;
			checkType(l,3,out a3);
			System.Globalization.CompareOptions a4;
			checkEnum(l,4,out a4);
			var ret=System.String.Compare(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Compare__String__String__Boolean__CultureInfo_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			System.Globalization.CultureInfo a4;
			checkType(l,4,out a4);
			var ret=System.String.Compare(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Compare__String__Int32__String__Int32__Int32_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			var ret=System.String.Compare(a1,a2,a3,a4,a5);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Compare__String__Int32__String__Int32__Int32__Boolean_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Boolean a6;
			checkType(l,6,out a6);
			var ret=System.String.Compare(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Compare__String__Int32__String__Int32__Int32__StringComparison_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.StringComparison a6;
			checkEnum(l,6,out a6);
			var ret=System.String.Compare(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Compare__String__Int32__String__Int32__Int32__Boolean__CultureInfo_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Boolean a6;
			checkType(l,6,out a6);
			System.Globalization.CultureInfo a7;
			checkType(l,7,out a7);
			var ret=System.String.Compare(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Compare__String__Int32__String__Int32__Int32__CultureInfo__CompareOptions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Globalization.CultureInfo a6;
			checkType(l,6,out a6);
			System.Globalization.CompareOptions a7;
			checkEnum(l,7,out a7);
			var ret=System.String.Compare(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CompareOrdinal__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.String.CompareOrdinal(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CompareOrdinal__String__Int32__String__Int32__Int32_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			var ret=System.String.CompareOrdinal(a1,a2,a3,a4,a5);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Format__String__Object_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			var ret=System.String.Format(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Format__String__A_Object_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object[] a2;
			checkParams(l,2,out a2);
			var ret=System.String.Format(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Format__String__Object__Object_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			System.Object a3;
			checkType(l,3,out a3);
			var ret=System.String.Format(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Format__IFormatProvider__String__Object_s(IntPtr l) {
		try {
			System.IFormatProvider a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Object a3;
			checkType(l,3,out a3);
			var ret=System.String.Format(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Format__IFormatProvider__String__A_Object_s(IntPtr l) {
		try {
			System.IFormatProvider a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Object[] a3;
			checkParams(l,3,out a3);
			var ret=System.String.Format(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Format__String__Object__Object__Object_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			System.Object a3;
			checkType(l,3,out a3);
			System.Object a4;
			checkType(l,4,out a4);
			var ret=System.String.Format(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Format__IFormatProvider__String__Object__Object_s(IntPtr l) {
		try {
			System.IFormatProvider a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Object a3;
			checkType(l,3,out a3);
			System.Object a4;
			checkType(l,4,out a4);
			var ret=System.String.Format(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Format__IFormatProvider__String__Object__Object__Object_s(IntPtr l) {
		try {
			System.IFormatProvider a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Object a3;
			checkType(l,3,out a3);
			System.Object a4;
			checkType(l,4,out a4);
			System.Object a5;
			checkType(l,5,out a5);
			var ret=System.String.Format(a1,a2,a3,a4,a5);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Copy_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.String.Copy(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Concat__Object_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			var ret=System.String.Concat(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Concat__A_Object_s(IntPtr l) {
		try {
			System.Object[] a1;
			checkParams(l,1,out a1);
			var ret=System.String.Concat(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Concat__IEnumerable_1_String_s(IntPtr l) {
		try {
			System.Collections.Generic.IEnumerable<System.String> a1;
			checkType(l,1,out a1);
			var ret=System.String.Concat(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Concat__A_String_s(IntPtr l) {
		try {
			System.String[] a1;
			checkParams(l,1,out a1);
			var ret=System.String.Concat(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Concat__Object__Object_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			var ret=System.String.Concat(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Concat__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.String.Concat(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Concat__Object__Object__Object_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			System.Object a3;
			checkType(l,3,out a3);
			var ret=System.String.Concat(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Concat__String__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			var ret=System.String.Concat(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Concat__Object__Object__Object__Object_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			System.Object a3;
			checkType(l,3,out a3);
			System.Object a4;
			checkType(l,4,out a4);
			var ret=System.String.Concat(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Concat__String__String__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.String a4;
			checkType(l,4,out a4);
			var ret=System.String.Concat(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Intern_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.String.Intern(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsInterned_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.String.IsInterned(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Empty(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.String.Empty);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Length(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Length);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int getItem(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			int v;
			checkType(l,2,out v);
			var ret = self[v];
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.String");
		addMember(l,ctor__A_Char_s);
		addMember(l,ctor__Char__Int32_s);
		addMember(l,ctor__A_Char__Int32__Int32_s);
		addMember(l,Equals__Object);
		addMember(l,Equals__String);
		addMember(l,Equals__String__StringComparison);
		addMember(l,CopyTo);
		addMember(l,ToCharArray);
		addMember(l,ToCharArray__Int32__Int32);
		addMember(l,Split__A_Char);
		addMember(l,Split__A_Char__Int32);
		addMember(l,Split__A_Char__StringSplitOptions);
		addMember(l,Split__A_String__StringSplitOptions);
		addMember(l,Split__A_Char__Int32__StringSplitOptions);
		addMember(l,Split__A_String__Int32__StringSplitOptions);
		addMember(l,Substring__Int32);
		addMember(l,Substring__Int32__Int32);
		addMember(l,Trim);
		addMember(l,Trim__A_Char);
		addMember(l,TrimStart);
		addMember(l,TrimEnd);
		addMember(l,IsNormalized);
		addMember(l,IsNormalized__NormalizationForm);
		addMember(l,Normalize);
		addMember(l,Normalize__NormalizationForm);
		addMember(l,CompareTo__Object);
		addMember(l,CompareTo__String);
		addMember(l,Contains);
		addMember(l,EndsWith__String);
		addMember(l,EndsWith__String__StringComparison);
		addMember(l,EndsWith__String__Boolean__CultureInfo);
		addMember(l,IndexOf__Char);
		addMember(l,IndexOf__String);
		addMember(l,IndexOf__Char__Int32);
		addMember(l,IndexOf__String__Int32);
		addMember(l,IndexOf__String__StringComparison);
		addMember(l,IndexOf__String__Int32__Int32);
		addMember(l,IndexOf__String__Int32__StringComparison);
		addMember(l,IndexOf__Char__Int32__Int32);
		addMember(l,IndexOf__String__Int32__Int32__StringComparison);
		addMember(l,IndexOfAny__A_Char);
		addMember(l,IndexOfAny__A_Char__Int32);
		addMember(l,IndexOfAny__A_Char__Int32__Int32);
		addMember(l,LastIndexOf__Char);
		addMember(l,LastIndexOf__String);
		addMember(l,LastIndexOf__Char__Int32);
		addMember(l,LastIndexOf__String__Int32);
		addMember(l,LastIndexOf__String__StringComparison);
		addMember(l,LastIndexOf__String__Int32__Int32);
		addMember(l,LastIndexOf__String__Int32__StringComparison);
		addMember(l,LastIndexOf__Char__Int32__Int32);
		addMember(l,LastIndexOf__String__Int32__Int32__StringComparison);
		addMember(l,LastIndexOfAny__A_Char);
		addMember(l,LastIndexOfAny__A_Char__Int32);
		addMember(l,LastIndexOfAny__A_Char__Int32__Int32);
		addMember(l,PadLeft__Int32);
		addMember(l,PadLeft__Int32__Char);
		addMember(l,PadRight__Int32);
		addMember(l,PadRight__Int32__Char);
		addMember(l,StartsWith__String);
		addMember(l,StartsWith__String__StringComparison);
		addMember(l,StartsWith__String__Boolean__CultureInfo);
		addMember(l,ToLower);
		addMember(l,ToLower__CultureInfo);
		addMember(l,ToLowerInvariant);
		addMember(l,ToUpper);
		addMember(l,ToUpper__CultureInfo);
		addMember(l,ToUpperInvariant);
		addMember(l,ToString);
		addMember(l,ToString__IFormatProvider);
		addMember(l,Clone);
		addMember(l,Insert);
		addMember(l,Replace__Char__Char);
		addMember(l,Replace__String__String);
		addMember(l,Remove__Int32);
		addMember(l,Remove__Int32__Int32);
		addMember(l,GetTypeCode);
		addMember(l,GetEnumerator);
		addMember(l,Join__String__A_String_s);
		addMember(l,Join__String__A_Object_s);
		addMember(l,Join__String__IEnumerable_1_String_s);
		addMember(l,Join__String__A_String__Int32__Int32_s);
		addMember(l,Equals__String__String_s);
		addMember(l,Equals__String__String__StringComparison_s);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,IsNullOrEmpty_s);
		addMember(l,IsNullOrWhiteSpace_s);
		addMember(l,Compare__String__String_s);
		addMember(l,Compare__String__String__Boolean_s);
		addMember(l,Compare__String__String__StringComparison_s);
		addMember(l,Compare__String__String__CultureInfo__CompareOptions_s);
		addMember(l,Compare__String__String__Boolean__CultureInfo_s);
		addMember(l,Compare__String__Int32__String__Int32__Int32_s);
		addMember(l,Compare__String__Int32__String__Int32__Int32__Boolean_s);
		addMember(l,Compare__String__Int32__String__Int32__Int32__StringComparison_s);
		addMember(l,Compare__String__Int32__String__Int32__Int32__Boolean__CultureInfo_s);
		addMember(l,Compare__String__Int32__String__Int32__Int32__CultureInfo__CompareOptions_s);
		addMember(l,CompareOrdinal__String__String_s);
		addMember(l,CompareOrdinal__String__Int32__String__Int32__Int32_s);
		addMember(l,Format__String__Object_s);
		addMember(l,Format__String__A_Object_s);
		addMember(l,Format__String__Object__Object_s);
		addMember(l,Format__IFormatProvider__String__Object_s);
		addMember(l,Format__IFormatProvider__String__A_Object_s);
		addMember(l,Format__String__Object__Object__Object_s);
		addMember(l,Format__IFormatProvider__String__Object__Object_s);
		addMember(l,Format__IFormatProvider__String__Object__Object__Object_s);
		addMember(l,Copy_s);
		addMember(l,Concat__Object_s);
		addMember(l,Concat__A_Object_s);
		addMember(l,Concat__IEnumerable_1_String_s);
		addMember(l,Concat__A_String_s);
		addMember(l,Concat__Object__Object_s);
		addMember(l,Concat__String__String_s);
		addMember(l,Concat__Object__Object__Object_s);
		addMember(l,Concat__String__String__String_s);
		addMember(l,Concat__Object__Object__Object__Object_s);
		addMember(l,Concat__String__String__String__String_s);
		addMember(l,Intern_s);
		addMember(l,IsInterned_s);
		addMember(l,getItem);
		addMember(l,"Empty",get_Empty,null,false);
		addMember(l,"Length",get_Length,null,true);
		createTypeMetatable(l,null, typeof(System.String));
	}
}
