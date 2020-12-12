using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_MissingReferenceException : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.MissingReferenceException o;
			o=new UnityEngine.MissingReferenceException();
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
			UnityEngine.MissingReferenceException o;
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.MissingReferenceException(a1);
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
			UnityEngine.MissingReferenceException o;
			System.String a1;
			checkType(l,1,out a1);
			System.Exception a2;
			checkType(l,2,out a2);
			o=new UnityEngine.MissingReferenceException(a1,a2);
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
		getTypeTable(l,"UnityEngine.MissingReferenceException");
		addMember(l,ctor_s);
		addMember(l,ctor__String_s);
		addMember(l,ctor__String__Exception_s);
		createTypeMetatable(l,null, typeof(UnityEngine.MissingReferenceException),typeof(System.SystemException));
	}
}
