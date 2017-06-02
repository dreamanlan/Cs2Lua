using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Avatar : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isValid(IntPtr l) {
		try {
			UnityEngine.Avatar self=(UnityEngine.Avatar)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isValid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isHuman(IntPtr l) {
		try {
			UnityEngine.Avatar self=(UnityEngine.Avatar)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isHuman);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Avatar");
		addMember(l,"isValid",get_isValid,null,true);
		addMember(l,"isHuman",get_isHuman,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Avatar),typeof(UnityEngine.Object));
	}
}
