using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightingSettings_Sampling : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightingSettings.Sampling");
		addMember(l,0,"Auto");
		addMember(l,1,"Fixed");
		LuaDLL.lua_pop(l, 1);
	}
}
