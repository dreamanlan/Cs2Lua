using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemShapeMultiModeValue : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemShapeMultiModeValue");
		addMember(l,0,"Random");
		addMember(l,1,"Loop");
		addMember(l,2,"PingPong");
		addMember(l,3,"BurstSpread");
		LuaDLL.lua_pop(l, 1);
	}
}
