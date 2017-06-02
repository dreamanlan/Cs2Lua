using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightProbeGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_probePositions(IntPtr l) {
		try {
			UnityEngine.LightProbeGroup self=(UnityEngine.LightProbeGroup)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.probePositions);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_probePositions(IntPtr l) {
		try {
			UnityEngine.LightProbeGroup self=(UnityEngine.LightProbeGroup)checkSelf(l);
			UnityEngine.Vector3[] v;
			checkArray(l,2,out v);
			self.probePositions=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LightProbeGroup");
		addMember(l,"probePositions",get_probePositions,set_probePositions,true);
		createTypeMetatable(l,null, typeof(UnityEngine.LightProbeGroup),typeof(UnityEngine.Behaviour));
	}
}
