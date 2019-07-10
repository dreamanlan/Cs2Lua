using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_ScriptableRuntimeReflectionSystem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TickRealtimeProbes(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystem self=(UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystem)checkSelf(l);
			var ret=self.TickRealtimeProbes();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Dispose(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystem self=(UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystem)checkSelf(l);
			((System.IDisposable)self).Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Dispose_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystem self=(UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystem)checkSelf(l);
			((System.IDisposable)self).Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystem");
		addMember(l,TickRealtimeProbes);
		addMember(l,Dispose);
		addMember(l,Dispose_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystem));
	}
}
