using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightingSettings_Lightmapper : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightingSettings.Lightmapper");
		addMember(l,0,"Enlighten");
		addMember(l,1,"ProgressiveCPU");
		addMember(l,2,"ProgressiveGPU");
		LuaDLL.lua_pop(l, 1);
	}
}
