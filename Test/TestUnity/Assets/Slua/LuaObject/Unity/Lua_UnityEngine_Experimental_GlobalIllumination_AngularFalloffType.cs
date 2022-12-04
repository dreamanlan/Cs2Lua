using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_GlobalIllumination_AngularFalloffType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.GlobalIllumination.AngularFalloffType");
		addMember(l,0,"LUT");
		addMember(l,1,"AnalyticAndInnerAngle");
		LuaDLL.lua_pop(l, 1);
	}
}
