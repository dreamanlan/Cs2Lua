using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_OcclusionPortal : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_open(IntPtr l) {
		try {
			UnityEngine.OcclusionPortal self=(UnityEngine.OcclusionPortal)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.open);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_open(IntPtr l) {
		try {
			UnityEngine.OcclusionPortal self=(UnityEngine.OcclusionPortal)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.open=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.OcclusionPortal");
		addMember(l,"open",get_open,set_open,true);
		createTypeMetatable(l,null, typeof(UnityEngine.OcclusionPortal),typeof(UnityEngine.Component));
	}
}
