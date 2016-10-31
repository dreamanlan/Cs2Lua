using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystemCollisionMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemCollisionMode");
		addMember(l,0,"Collision3D");
		addMember(l,1,"Collision2D");
		LuaDLL.lua_pop(l, 1);
	}
}
