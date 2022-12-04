using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_ShaderConstantType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.ShaderConstantType");
		addMember(l,0,"Vector");
		addMember(l,1,"Matrix");
		addMember(l,2,"Struct");
		LuaDLL.lua_pop(l, 1);
	}
}
