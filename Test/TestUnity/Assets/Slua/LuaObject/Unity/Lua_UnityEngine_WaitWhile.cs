using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_WaitWhile : LuaObject {
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
		addMember(l,"keepWaiting",get_keepWaiting,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.WaitWhile),typeof(UnityEngine.CustomYieldInstruction));
	}
}
