using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemCollisionType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemCollisionType");
		addMember(l,0,"Planes");
		addMember(l,1,"World");
		LuaDLL.lua_pop(l, 1);
	}
}
