using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UnityException : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.UnityException o;
			o=new UnityEngine.UnityException();
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
			UnityEngine.UnityException o;
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.UnityException(a1);
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
	static public int ctor__String__Exception_s(IntPtr l) {
		try {
			UnityEngine.UnityException o;
			System.String a1;
			checkType(l,1,out a1);
			System.Exception a2;
			checkType(l,2,out a2);
			o=new UnityEngine.UnityException(a1,a2);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UnityException");
		addMember(l,ctor_s);
		addMember(l,ctor__String_s);
		addMember(l,ctor__String__Exception_s);
		createTypeMetatable(l,null, typeof(UnityEngine.UnityException),typeof(System.SystemException));
	}
}
