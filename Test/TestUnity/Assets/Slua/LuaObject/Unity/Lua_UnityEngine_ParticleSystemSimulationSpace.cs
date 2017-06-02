using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemSimulationSpace : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemSimulationSpace");
		addMember(l,0,"Local");
		addMember(l,1,"World");
		addMember(l,2,"Custom");
		LuaDLL.lua_pop(l, 1);
	}
}
