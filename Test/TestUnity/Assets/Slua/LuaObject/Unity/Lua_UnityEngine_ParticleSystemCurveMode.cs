using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemCurveMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemCurveMode");
		addMember(l,0,"Constant");
		addMember(l,1,"Curve");
		addMember(l,2,"TwoCurves");
		addMember(l,3,"TwoConstants");
		LuaDLL.lua_pop(l, 1);
	}
}
