using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemCollisionQuality : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemCollisionQuality");
		addMember(l,0,"High");
		addMember(l,1,"Medium");
		addMember(l,2,"Low");
		LuaDLL.lua_pop(l, 1);
	}
}
