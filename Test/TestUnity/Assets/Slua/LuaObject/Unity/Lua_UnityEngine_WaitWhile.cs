using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_WaitWhile : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.WaitWhile o;
			System.Func<System.Boolean> a1;
			LuaDelegation.checkDelegate(l,1,out a1);
			o=new UnityEngine.WaitWhile(a1);
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
			UnityEngine.WaitWhile self=(UnityEngine.WaitWhile)checkSelf(l);
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
		getTypeTable(l,"UnityEngine.WaitWhile");
		addMember(l,ctor_s);
		addMember(l,"keepWaiting",get_keepWaiting,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.WaitWhile),typeof(UnityEngine.CustomYieldInstruction));
	}
}
