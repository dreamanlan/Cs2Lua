using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Text_StringBuilder : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			System.Text.StringBuilder o;
			o=new System.Text.StringBuilder();
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
	static public int ctor__Int32_s(IntPtr l) {
		try {
			System.Text.StringBuilder o;
			System.Int32 a1;
			checkType(l,1,out a1);
			o=new System.Text.StringBuilder(a1);
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
	static public int ctor__String_s(IntPtr l) {
		try {
			System.Text.StringBuilder o;
			System.String a1;
			checkType(l,1,out a1);
			o=new System.Text.StringBuilder(a1);
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
	static public int ctor__String__Int32_s(IntPtr l) {
		try {
			System.Text.StringBuilder o;
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			o=new System.Text.StringBuilder(a1,a2);
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
	static public int ctor__Int32__Int32_s(IntPtr l) {
		try {
			System.Text.StringBuilder o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			o=new System.Text.StringBuilder(a1,a2);
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
	static public int ctor__String__Int32__Int32__Int32_s(IntPtr l) {
		try {
			System.Text.StringBuilder o;
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			o=new System.Text.StringBuilder(a1,a2,a3,a4);
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
	static public int EnsureCapacity(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.EnsureCapacity(a1);
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
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
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
	static public int ToString__Int32__Int32(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.ToString(a1,a2);
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
	static public int Clear(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			var ret=self.Clear();
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
	static public int Append__Int32(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__Decimal(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Decimal a1;
			checkValueType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__Int64(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int64 a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__Int16(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int16 a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__Byte(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Byte a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__UInt16(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__SByte(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.SByte a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__Boolean(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__UInt64(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.UInt64 a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__StringBuilder(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Text.StringBuilder a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__Object(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__String(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__A_Char(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__Char(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__UInt32(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.UInt32 a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__Single(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__Double(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Double a1;
			checkType(l,2,out a1);
			var ret=self.Append(a1);
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
	static public int Append__Char__Int32(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.Append(a1,a2);
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
	static public int Append__String__Int32__Int32(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.Append(a1,a2,a3);
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
	static public int Append__A_Char__Int32__Int32(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.Append(a1,a2,a3);
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
	static public int Append__StringBuilder__Int32__Int32(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Text.StringBuilder a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.Append(a1,a2,a3);
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
	static public int AppendLine(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			var ret=self.AppendLine();
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
	static public int AppendLine__String(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.AppendLine(a1);
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
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
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
	static public int Insert__Int32__Int32(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
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
	static public int Insert__Int32__UInt64(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.UInt64 a2;
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
	static public int Insert__Int32__UInt32(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.UInt32 a2;
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
	static public int Insert__Int32__UInt16(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.UInt16 a2;
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
	static public int Insert__Int32__Decimal(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Decimal a2;
			checkValueType(l,3,out a2);
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
	static public int Insert__Int32__Int64(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int64 a2;
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
	static public int Insert__Int32__Object(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Object a2;
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
	static public int Insert__Int32__Char(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Char a2;
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
	static public int Insert__Int32__Int16(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int16 a2;
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
	static public int Insert__Int32__Byte(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Byte a2;
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
	static public int Insert__Int32__SByte(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.SByte a2;
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
	static public int Insert__Int32__Boolean(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean a2;
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
	static public int Insert__Int32__String(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
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
	static public int Insert__Int32__A_Char(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Char[] a2;
			checkArray(l,3,out a2);
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
	static public int Insert__Int32__Single(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
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
	static public int Insert__Int32__Double(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Double a2;
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
	static public int Insert__Int32__String__Int32(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.Insert(a1,a2,a3);
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
	static public int Insert__Int32__A_Char__Int32__Int32(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Char[] a2;
			checkArray(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			var ret=self.Insert(a1,a2,a3,a4);
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
	static public int Remove(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
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
	static public int AppendJoin__String__A_Object(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object[] a2;
			checkParams(l,3,out a2);
			var ret=self.AppendJoin(a1,a2);
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
	static public int AppendJoin__String__A_String(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String[] a2;
			checkParams(l,3,out a2);
			var ret=self.AppendJoin(a1,a2);
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
	static public int AppendJoin__Char__A_Object(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			System.Object[] a2;
			checkParams(l,3,out a2);
			var ret=self.AppendJoin(a1,a2);
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
	static public int AppendJoin__Char__A_String(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			System.String[] a2;
			checkParams(l,3,out a2);
			var ret=self.AppendJoin(a1,a2);
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
	static public int AppendFormat__String__Object(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			var ret=self.AppendFormat(a1,a2);
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
	static public int AppendFormat__String__A_Object(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object[] a2;
			checkParams(l,3,out a2);
			var ret=self.AppendFormat(a1,a2);
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
	static public int AppendFormat__String__Object__Object(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			System.Object a3;
			checkType(l,4,out a3);
			var ret=self.AppendFormat(a1,a2,a3);
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
	static public int AppendFormat__IFormatProvider__String__Object(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.IFormatProvider a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Object a3;
			checkType(l,4,out a3);
			var ret=self.AppendFormat(a1,a2,a3);
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
	static public int AppendFormat__IFormatProvider__String__A_Object(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.IFormatProvider a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Object[] a3;
			checkParams(l,4,out a3);
			var ret=self.AppendFormat(a1,a2,a3);
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
	static public int AppendFormat__String__Object__Object__Object(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			System.Object a3;
			checkType(l,4,out a3);
			System.Object a4;
			checkType(l,5,out a4);
			var ret=self.AppendFormat(a1,a2,a3,a4);
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
	static public int AppendFormat__IFormatProvider__String__Object__Object(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.IFormatProvider a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Object a3;
			checkType(l,4,out a3);
			System.Object a4;
			checkType(l,5,out a4);
			var ret=self.AppendFormat(a1,a2,a3,a4);
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
	static public int AppendFormat__IFormatProvider__String__Object__Object__Object(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.IFormatProvider a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Object a3;
			checkType(l,4,out a3);
			System.Object a4;
			checkType(l,5,out a4);
			System.Object a5;
			checkType(l,6,out a5);
			var ret=self.AppendFormat(a1,a2,a3,a4,a5);
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
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
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
	static public int Replace__Char__Char(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
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
	static public int Replace__String__String__Int32__Int32(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			var ret=self.Replace(a1,a2,a3,a4);
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
	static public int Replace__Char__Char__Int32__Int32(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			System.Char a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			var ret=self.Replace(a1,a2,a3,a4);
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
	static public int Equals__StringBuilder(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Text.StringBuilder a1;
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
	static public int Equals__Object(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
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
	static public int get_Capacity(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Capacity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_Capacity(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.Capacity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_MaxCapacity(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.MaxCapacity);
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
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
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
	static public int set_Length(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.Length=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int getItem(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int setItem(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			int v;
			checkType(l,2,out v);
			System.Char c;
			checkType(l,3,out c);
			self[v]=c;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Text.StringBuilder");
		addMember(l,ctor_s);
		addMember(l,ctor__Int32_s);
		addMember(l,ctor__String_s);
		addMember(l,ctor__String__Int32_s);
		addMember(l,ctor__Int32__Int32_s);
		addMember(l,ctor__String__Int32__Int32__Int32_s);
		addMember(l,EnsureCapacity);
		addMember(l,ToString);
		addMember(l,ToString__Int32__Int32);
		addMember(l,Clear);
		addMember(l,Append__Int32);
		addMember(l,Append__Decimal);
		addMember(l,Append__Int64);
		addMember(l,Append__Int16);
		addMember(l,Append__Byte);
		addMember(l,Append__UInt16);
		addMember(l,Append__SByte);
		addMember(l,Append__Boolean);
		addMember(l,Append__UInt64);
		addMember(l,Append__StringBuilder);
		addMember(l,Append__Object);
		addMember(l,Append__String);
		addMember(l,Append__A_Char);
		addMember(l,Append__Char);
		addMember(l,Append__UInt32);
		addMember(l,Append__Single);
		addMember(l,Append__Double);
		addMember(l,Append__Char__Int32);
		addMember(l,Append__String__Int32__Int32);
		addMember(l,Append__A_Char__Int32__Int32);
		addMember(l,Append__StringBuilder__Int32__Int32);
		addMember(l,AppendLine);
		addMember(l,AppendLine__String);
		addMember(l,CopyTo);
		addMember(l,Insert__Int32__Int32);
		addMember(l,Insert__Int32__UInt64);
		addMember(l,Insert__Int32__UInt32);
		addMember(l,Insert__Int32__UInt16);
		addMember(l,Insert__Int32__Decimal);
		addMember(l,Insert__Int32__Int64);
		addMember(l,Insert__Int32__Object);
		addMember(l,Insert__Int32__Char);
		addMember(l,Insert__Int32__Int16);
		addMember(l,Insert__Int32__Byte);
		addMember(l,Insert__Int32__SByte);
		addMember(l,Insert__Int32__Boolean);
		addMember(l,Insert__Int32__String);
		addMember(l,Insert__Int32__A_Char);
		addMember(l,Insert__Int32__Single);
		addMember(l,Insert__Int32__Double);
		addMember(l,Insert__Int32__String__Int32);
		addMember(l,Insert__Int32__A_Char__Int32__Int32);
		addMember(l,Remove);
		addMember(l,AppendJoin__String__A_Object);
		addMember(l,AppendJoin__String__A_String);
		addMember(l,AppendJoin__Char__A_Object);
		addMember(l,AppendJoin__Char__A_String);
		addMember(l,AppendFormat__String__Object);
		addMember(l,AppendFormat__String__A_Object);
		addMember(l,AppendFormat__String__Object__Object);
		addMember(l,AppendFormat__IFormatProvider__String__Object);
		addMember(l,AppendFormat__IFormatProvider__String__A_Object);
		addMember(l,AppendFormat__String__Object__Object__Object);
		addMember(l,AppendFormat__IFormatProvider__String__Object__Object);
		addMember(l,AppendFormat__IFormatProvider__String__Object__Object__Object);
		addMember(l,Replace__String__String);
		addMember(l,Replace__Char__Char);
		addMember(l,Replace__String__String__Int32__Int32);
		addMember(l,Replace__Char__Char__Int32__Int32);
		addMember(l,Equals__StringBuilder);
		addMember(l,Equals__Object);
		addMember(l,getItem);
		addMember(l,setItem);
		addMember(l,"Capacity",get_Capacity,set_Capacity,true);
		addMember(l,"MaxCapacity",get_MaxCapacity,null,true);
		addMember(l,"Length",get_Length,set_Length,true);
		createTypeMetatable(l,null, typeof(System.Text.StringBuilder));
	}
}
