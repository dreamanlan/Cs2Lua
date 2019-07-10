using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemStopBehavior : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemStopBehavior");
		addMember(l,0,"StopEmittingAndClear");
		addMember(l,1,"StopEmitting");
		LuaDLL.lua_pop(l, 1);
	}
}
