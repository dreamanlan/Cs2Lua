using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemRenderSpace : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemRenderSpace");
		addMember(l,0,"View");
		addMember(l,1,"World");
		addMember(l,2,"Local");
		addMember(l,3,"Facing");
		LuaDLL.lua_pop(l, 1);
	}
}
