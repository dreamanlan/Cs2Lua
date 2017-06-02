using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemTrailTextureMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemTrailTextureMode");
		addMember(l,0,"Stretch");
		addMember(l,1,"Tile");
		LuaDLL.lua_pop(l, 1);
	}
}
