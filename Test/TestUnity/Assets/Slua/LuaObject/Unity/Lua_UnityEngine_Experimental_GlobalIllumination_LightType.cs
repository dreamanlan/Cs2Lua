using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_GlobalIllumination_LightType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.GlobalIllumination.LightType");
		addMember(l,0,"Directional");
		addMember(l,1,"Point");
		addMember(l,2,"Spot");
		addMember(l,3,"Rectangle");
		addMember(l,4,"Disc");
		LuaDLL.lua_pop(l, 1);
	}
}
