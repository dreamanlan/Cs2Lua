using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightingSettings_FilterType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightingSettings.FilterType");
		addMember(l,0,"Gaussian");
		addMember(l,1,"ATrous");
		addMember(l,2,"None");
		LuaDLL.lua_pop(l, 1);
	}
}
