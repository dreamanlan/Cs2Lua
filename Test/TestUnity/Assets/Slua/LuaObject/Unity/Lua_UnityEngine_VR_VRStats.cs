using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_VR_VRStats : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TryGetGPUTimeLastFrame_s(IntPtr l) {
		try {
			System.Single a1;
			var ret=UnityEngine.VR.VRStats.TryGetGPUTimeLastFrame(out a1);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a1);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TryGetDroppedFrameCount_s(IntPtr l) {
		try {
			System.Int32 a1;
			var ret=UnityEngine.VR.VRStats.TryGetDroppedFrameCount(out a1);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a1);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TryGetFramePresentCount_s(IntPtr l) {
		try {
			System.Int32 a1;
			var ret=UnityEngine.VR.VRStats.TryGetFramePresentCount(out a1);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a1);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.VR.VRStats");
		addMember(l,TryGetGPUTimeLastFrame_s);
		addMember(l,TryGetDroppedFrameCount_s);
		addMember(l,TryGetFramePresentCount_s);
		createTypeMetatable(l,null, typeof(UnityEngine.VR.VRStats));
	}
}
