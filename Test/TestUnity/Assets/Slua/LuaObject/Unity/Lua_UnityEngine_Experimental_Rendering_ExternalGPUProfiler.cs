using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_ExternalGPUProfiler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BeginGPUCapture_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ExternalGPUProfiler.BeginGPUCapture();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EndGPUCapture_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ExternalGPUProfiler.EndGPUCapture();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsAttached_s(IntPtr l) {
		try {
			var ret=UnityEngine.Experimental.Rendering.ExternalGPUProfiler.IsAttached();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.ExternalGPUProfiler");
		addMember(l,BeginGPUCapture_s);
		addMember(l,EndGPUCapture_s);
		addMember(l,IsAttached_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.ExternalGPUProfiler));
	}
}
