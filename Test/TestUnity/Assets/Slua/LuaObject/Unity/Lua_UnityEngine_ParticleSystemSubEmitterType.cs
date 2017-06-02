using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemSubEmitterType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemSubEmitterType");
		addMember(l,0,"Birth");
		addMember(l,1,"Collision");
		addMember(l,2,"Death");
		LuaDLL.lua_pop(l, 1);
	}
}
