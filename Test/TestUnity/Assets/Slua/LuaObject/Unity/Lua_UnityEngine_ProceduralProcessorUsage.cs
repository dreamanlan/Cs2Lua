using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ProceduralProcessorUsage : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ProceduralProcessorUsage");
		addMember(l,0,"Unsupported");
		addMember(l,1,"One");
		addMember(l,2,"Half");
		addMember(l,3,"All");
		LuaDLL.lua_pop(l, 1);
	}
}
