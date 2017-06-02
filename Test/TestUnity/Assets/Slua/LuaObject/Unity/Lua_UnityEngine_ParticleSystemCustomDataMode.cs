using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemCustomDataMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemCustomDataMode");
		addMember(l,0,"Disabled");
		addMember(l,1,"Vector");
		addMember(l,2,"Color");
		LuaDLL.lua_pop(l, 1);
	}
}
