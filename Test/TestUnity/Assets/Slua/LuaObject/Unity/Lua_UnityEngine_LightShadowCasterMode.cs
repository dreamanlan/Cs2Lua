using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightShadowCasterMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightShadowCasterMode");
		addMember(l,0,"Default");
		addMember(l,1,"NonLightmappedOnly");
		addMember(l,2,"Everything");
		LuaDLL.lua_pop(l, 1);
	}
}
