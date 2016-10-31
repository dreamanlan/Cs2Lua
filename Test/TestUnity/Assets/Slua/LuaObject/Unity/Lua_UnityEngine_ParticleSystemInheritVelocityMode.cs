using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystemInheritVelocityMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemInheritVelocityMode");
		addMember(l,0,"Initial");
		addMember(l,1,"Current");
		LuaDLL.lua_pop(l, 1);
	}
}
