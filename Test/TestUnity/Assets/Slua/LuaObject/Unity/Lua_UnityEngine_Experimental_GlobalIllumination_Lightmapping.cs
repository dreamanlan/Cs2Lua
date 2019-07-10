using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_GlobalIllumination_Lightmapping : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetDelegate_s(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate a1;
			LuaDelegation.checkDelegate(l,1,out a1);
			UnityEngine.Experimental.GlobalIllumination.Lightmapping.SetDelegate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetDelegate_s(IntPtr l) {
		try {
			var ret=UnityEngine.Experimental.GlobalIllumination.Lightmapping.GetDelegate();
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
	static public int ResetDelegate_s(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.Lightmapping.ResetDelegate();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.GlobalIllumination.Lightmapping");
		addMember(l,SetDelegate_s);
		addMember(l,GetDelegate_s);
		addMember(l,ResetDelegate_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.GlobalIllumination.Lightmapping));
	}
}
