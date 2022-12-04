using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_LightProbeUsage : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.LightProbeUsage");
		addMember(l,0,"Off");
		addMember(l,1,"BlendProbes");
		addMember(l,2,"UseProxyVolume");
		addMember(l,4,"CustomProvided");
		LuaDLL.lua_pop(l, 1);
	}
}
