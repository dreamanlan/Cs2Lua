using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure_ManagementMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.ManagementMode");
		addMember(l,0,"Manual");
		addMember(l,1,"Automatic");
		LuaDLL.lua_pop(l, 1);
	}
}
