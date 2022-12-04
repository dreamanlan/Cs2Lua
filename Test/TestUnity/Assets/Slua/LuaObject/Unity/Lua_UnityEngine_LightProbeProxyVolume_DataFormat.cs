using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightProbeProxyVolume_DataFormat : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightProbeProxyVolume.DataFormat");
		addMember(l,0,"HalfFloat");
		addMember(l,1,"Float");
		LuaDLL.lua_pop(l, 1);
	}
}
