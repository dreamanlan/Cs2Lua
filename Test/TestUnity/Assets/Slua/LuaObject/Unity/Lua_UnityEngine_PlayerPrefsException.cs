using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PlayerPrefsException : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.PlayerPrefsException o;
			System.String a1;
			checkType(l,2,out a1);
			o=new UnityEngine.PlayerPrefsException(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PlayerPrefsException");
		createTypeMetatable(l,constructor, typeof(UnityEngine.PlayerPrefsException),typeof(System.Exception));
	}
}
