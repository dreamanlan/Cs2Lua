using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Assertions_AssertionException : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Assertions.AssertionException o;
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			o=new UnityEngine.Assertions.AssertionException(a1,a2);
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
	static public int get_Message(IntPtr l) {
		try {
			UnityEngine.Assertions.AssertionException self=(UnityEngine.Assertions.AssertionException)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Message);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Assertions.AssertionException");
		addMember(l,"Message",get_Message,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Assertions.AssertionException),typeof(System.Exception));
	}
}
