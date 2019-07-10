using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemOverlapAction : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemOverlapAction");
		addMember(l,0,"Ignore");
		addMember(l,1,"Kill");
		addMember(l,2,"Callback");
		LuaDLL.lua_pop(l, 1);
	}
}
