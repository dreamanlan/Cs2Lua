using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemCustomData : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemCustomData");
		addMember(l,0,"Custom1");
		addMember(l,1,"Custom2");
		LuaDLL.lua_pop(l, 1);
	}
}
