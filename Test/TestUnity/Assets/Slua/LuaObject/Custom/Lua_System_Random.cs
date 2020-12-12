using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Random : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			System.Random o;
			o=new System.Random();
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
			System.Random o;
			System.Int32 a1;
			checkType(l,1,out a1);
			o=new System.Random(a1);
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
	static public int Next(IntPtr l) {
		try {
			System.Random self=(System.Random)checkSelf(l);
			var ret=self.Next();
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
	static public int Next__Int32(IntPtr l) {
		try {
			System.Random self=(System.Random)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.Next(a1);
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
	static public int Next__Int32__Int32(IntPtr l) {
		try {
			System.Random self=(System.Random)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.Next(a1,a2);
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
	static public int NextDouble(IntPtr l) {
		try {
			System.Random self=(System.Random)checkSelf(l);
			var ret=self.NextDouble();
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
	static public int NextBytes(IntPtr l) {
		try {
			System.Random self=(System.Random)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			self.NextBytes(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Random");
		addMember(l,ctor_s);
		addMember(l,ctor__Int32_s);
		addMember(l,Next);
		addMember(l,Next__Int32);
		addMember(l,Next__Int32__Int32);
		addMember(l,NextDouble);
		addMember(l,NextBytes);
		createTypeMetatable(l,null, typeof(System.Random));
	}
}
