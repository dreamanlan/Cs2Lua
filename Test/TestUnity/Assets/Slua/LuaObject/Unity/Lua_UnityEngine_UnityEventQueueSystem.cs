using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UnityEventQueueSystem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.UnityEventQueueSystem o;
			o=new UnityEngine.UnityEventQueueSystem();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GenerateEventIdForPayload_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.UnityEventQueueSystem.GenerateEventIdForPayload(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGlobalEventQueue_s(IntPtr l) {
		try {
			var ret=UnityEngine.UnityEventQueueSystem.GetGlobalEventQueue();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UnityEventQueueSystem");
		addMember(l,GenerateEventIdForPayload_s);
		addMember(l,GetGlobalEventQueue_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UnityEventQueueSystem));
	}
}
