using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemScalingMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemScalingMode");
		addMember(l,0,"Hierarchy");
		addMember(l,1,"Local");
		addMember(l,2,"Shape");
		LuaDLL.lua_pop(l, 1);
	}
}
