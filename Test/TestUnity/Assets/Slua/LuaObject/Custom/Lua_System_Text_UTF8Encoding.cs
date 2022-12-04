using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Text_UTF8Encoding : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			System.Text.UTF8Encoding o;
			o=new System.Text.UTF8Encoding();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__Boolean_s(IntPtr l) {
		try {
			System.Text.UTF8Encoding o;
			System.Boolean a1;
			checkType(l,1,out a1);
			o=new System.Text.UTF8Encoding(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__Boolean__Boolean_s(IntPtr l) {
		try {
			System.Text.UTF8Encoding o;
			System.Boolean a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			o=new System.Text.UTF8Encoding(a1,a2);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetByteCount__String(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetByteCount(a1);
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
	static public int GetByteCount__A_Char(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			var ret=self.GetByteCount(a1);
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
	static public int GetByteCount__A_Char__Int32__Int32(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.GetByteCount(a1,a2,a3);
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
	static public int GetByteCount__String__Int32__Int32(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.GetByteCount(a1,a2,a3);
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
	static public int GetBytes__A_Char(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			var ret=self.GetBytes(a1);
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
	static public int GetBytes__String(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetBytes(a1);
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
	static public int GetBytes__A_Char__Int32__Int32(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.GetBytes(a1,a2,a3);
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
	static public int GetBytes__String__Int32__Int32(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.GetBytes(a1,a2,a3);
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
	static public int GetBytes__String__Int32__Int32__A_Byte__Int32(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Byte[] a4;
			checkArray(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			var ret=self.GetBytes(a1,a2,a3,a4,a5);
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
	static public int GetBytes__A_Char__Int32__Int32__A_Byte__Int32(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Byte[] a4;
			checkArray(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			var ret=self.GetBytes(a1,a2,a3,a4,a5);
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
	static public int GetCharCount__A_Byte(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			var ret=self.GetCharCount(a1);
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
	static public int GetCharCount__A_Byte__Int32__Int32(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.GetCharCount(a1,a2,a3);
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
	static public int GetChars__A_Byte(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			var ret=self.GetChars(a1);
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
	static public int GetChars__A_Byte__Int32__Int32(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.GetChars(a1,a2,a3);
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
	static public int GetChars__A_Byte__Int32__Int32__A_Char__Int32(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Char[] a4;
			checkArray(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			var ret=self.GetChars(a1,a2,a3,a4,a5);
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
	static public int GetString__A_Byte(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			var ret=self.GetString(a1);
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
	static public int GetString__A_Byte__Int32__Int32(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.GetString(a1,a2,a3);
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
	static public int GetDecoder(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			var ret=self.GetDecoder();
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
	static public int GetEncoder(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			var ret=self.GetEncoder();
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
	static public int GetMaxByteCount(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetMaxByteCount(a1);
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
	static public int GetMaxCharCount(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetMaxCharCount(a1);
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
	static public int GetPreamble(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
			var ret=self.GetPreamble();
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
	static new public int Equals(IntPtr l) {
		try {
			System.Text.UTF8Encoding self=(System.Text.UTF8Encoding)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Text.UTF8Encoding");
		addMember(l,ctor_s);
		addMember(l,ctor__Boolean_s);
		addMember(l,ctor__Boolean__Boolean_s);
		addMember(l,GetByteCount__String);
		addMember(l,GetByteCount__A_Char);
		addMember(l,GetByteCount__A_Char__Int32__Int32);
		addMember(l,GetByteCount__String__Int32__Int32);
		addMember(l,GetBytes__A_Char);
		addMember(l,GetBytes__String);
		addMember(l,GetBytes__A_Char__Int32__Int32);
		addMember(l,GetBytes__String__Int32__Int32);
		addMember(l,GetBytes__String__Int32__Int32__A_Byte__Int32);
		addMember(l,GetBytes__A_Char__Int32__Int32__A_Byte__Int32);
		addMember(l,GetCharCount__A_Byte);
		addMember(l,GetCharCount__A_Byte__Int32__Int32);
		addMember(l,GetChars__A_Byte);
		addMember(l,GetChars__A_Byte__Int32__Int32);
		addMember(l,GetChars__A_Byte__Int32__Int32__A_Char__Int32);
		addMember(l,GetString__A_Byte);
		addMember(l,GetString__A_Byte__Int32__Int32);
		addMember(l,GetDecoder);
		addMember(l,GetEncoder);
		addMember(l,GetMaxByteCount);
		addMember(l,GetMaxCharCount);
		addMember(l,GetPreamble);
		addMember(l,Equals);
		createTypeMetatable(l,null, typeof(System.Text.UTF8Encoding),typeof(System.Text.Encoding));
	}
}
