using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightingSettings_FilterMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightingSettings.FilterMode");
		addMember(l,0,"None");
		addMember(l,1,"Auto");
		addMember(l,2,"Advanced");
		LuaDLL.lua_pop(l, 1);
	}
}
