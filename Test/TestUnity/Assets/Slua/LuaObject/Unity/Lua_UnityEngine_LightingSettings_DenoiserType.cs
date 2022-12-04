using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightingSettings_DenoiserType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightingSettings.DenoiserType");
		addMember(l,0,"None");
		addMember(l,1,"Optix");
		addMember(l,2,"OpenImage");
		addMember(l,3,"RadeonPro");
		LuaDLL.lua_pop(l, 1);
	}
}
