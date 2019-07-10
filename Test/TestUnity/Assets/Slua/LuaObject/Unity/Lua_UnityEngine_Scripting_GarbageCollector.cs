using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Scripting_GarbageCollector : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_GCMode(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.Scripting.GarbageCollector.GCMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_GCMode(IntPtr l) {
		try {
			UnityEngine.Scripting.GarbageCollector.Mode v;
			checkEnum(l,2,out v);
			UnityEngine.Scripting.GarbageCollector.GCMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Scripting.GarbageCollector");
		addMember(l,"GCMode",get_GCMode,set_GCMode,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Scripting.GarbageCollector));
	}
}
