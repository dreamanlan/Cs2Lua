using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemAnimationType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemAnimationType");
		addMember(l,0,"WholeSheet");
		addMember(l,1,"SingleRow");
		LuaDLL.lua_pop(l, 1);
	}
}
