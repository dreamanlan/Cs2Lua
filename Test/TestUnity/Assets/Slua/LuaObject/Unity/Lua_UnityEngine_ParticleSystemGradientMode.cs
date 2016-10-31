using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystemGradientMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemGradientMode");
		addMember(l,0,"Color");
		addMember(l,1,"Gradient");
		addMember(l,2,"TwoColors");
		addMember(l,3,"TwoGradients");
		LuaDLL.lua_pop(l, 1);
	}
}
