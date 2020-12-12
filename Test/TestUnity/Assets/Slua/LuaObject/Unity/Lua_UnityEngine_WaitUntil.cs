using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_WaitUntil : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.WaitUntil o;
			System.Func<System.Boolean> a1;
			LuaDelegation.checkDelegate(l,1,out a1);
			o=new UnityEngine.WaitUntil(a1);
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
	static public int get_keepWaiting(IntPtr l) {
		try {
			UnityEngine.WaitUntil self=(UnityEngine.WaitUntil)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.keepWaiting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WaitUntil");
		addMember(l,ctor_s);
		addMember(l,"keepWaiting",get_keepWaiting,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.WaitUntil),typeof(UnityEngine.CustomYieldInstruction));
	}
}
