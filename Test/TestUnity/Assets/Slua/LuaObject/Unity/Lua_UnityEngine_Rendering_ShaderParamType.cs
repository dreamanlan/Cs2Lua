using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_ShaderParamType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.ShaderParamType");
		addMember(l,0,"Float");
		addMember(l,1,"Int");
		addMember(l,2,"Bool");
		addMember(l,3,"Half");
		addMember(l,4,"Short");
		addMember(l,5,"UInt");
		LuaDLL.lua_pop(l, 1);
	}
}
