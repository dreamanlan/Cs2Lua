using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_MotionVectorGenerationMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.MotionVectorGenerationMode");
		addMember(l,0,"Camera");
		addMember(l,1,"Object");
		addMember(l,2,"ForceNoMotion");
		LuaDLL.lua_pop(l, 1);
	}
}
