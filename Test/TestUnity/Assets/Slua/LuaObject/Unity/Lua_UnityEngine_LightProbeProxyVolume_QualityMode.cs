using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightProbeProxyVolume_QualityMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightProbeProxyVolume.QualityMode");
		addMember(l,0,"Low");
		addMember(l,1,"Normal");
		LuaDLL.lua_pop(l, 1);
	}
}
