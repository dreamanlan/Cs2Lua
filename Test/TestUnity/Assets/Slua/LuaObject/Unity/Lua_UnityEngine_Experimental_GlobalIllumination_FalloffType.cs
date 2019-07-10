using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_GlobalIllumination_FalloffType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.GlobalIllumination.FalloffType");
		addMember(l,0,"InverseSquared");
		addMember(l,1,"InverseSquaredNoRangeAttenuation");
		addMember(l,2,"Linear");
		addMember(l,3,"Legacy");
		addMember(l,4,"Undefined");
		LuaDLL.lua_pop(l, 1);
	}
}
