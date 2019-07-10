using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_PlayerLoop_PostLateUpdate_MemoryFrameMaintenance : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.PlayerLoop.PostLateUpdate.MemoryFrameMaintenance o;
			o=new UnityEngine.Experimental.PlayerLoop.PostLateUpdate.MemoryFrameMaintenance();
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
		getTypeTable(l,"UnityEngine.Experimental.PlayerLoop.PostLateUpdate.MemoryFrameMaintenance");
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.PlayerLoop.PostLateUpdate.MemoryFrameMaintenance),typeof(System.ValueType));
	}
}
