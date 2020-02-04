using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Utility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			Utility o;
			o=new Utility();
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
	static public int StringGetChar_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=Utility.StringGetChar(a1,a2);
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
	static public int CharToString_s(IntPtr l) {
		try {
			System.Char a1;
			checkType(l,1,out a1);
			var ret=Utility.CharToString(a1);
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
	static public int CharArrayToString_s(IntPtr l) {
		try {
			System.Char[] a1;
			checkArray(l,1,out a1);
			var ret=Utility.CharArrayToString(a1);
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
	static public int Debug_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object[] a2;
			checkParams(l,2,out a2);
			Utility.Debug(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Warn_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object[] a2;
			checkParams(l,2,out a2);
			Utility.Warn(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Error_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object[] a2;
			checkParams(l,2,out a2);
			Utility.Error(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"Utility");
		addMember(l,StringGetChar_s);
		addMember(l,CharToString_s);
		addMember(l,CharArrayToString_s);
		addMember(l,Debug_s);
		addMember(l,Warn_s);
		addMember(l,Error_s);
		createTypeMetatable(l,constructor, typeof(Utility));
	}
}
