using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_AsyncGPUReadback : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WaitAllRequests_s(IntPtr l) {
		try {
			UnityEngine.Rendering.AsyncGPUReadback.WaitAllRequests();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.AsyncGPUReadback");
		addMember(l,WaitAllRequests_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.AsyncGPUReadback));
	}
}
