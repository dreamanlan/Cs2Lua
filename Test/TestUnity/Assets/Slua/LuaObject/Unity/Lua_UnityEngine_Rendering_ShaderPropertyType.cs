using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_ShaderPropertyType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.ShaderPropertyType");
		addMember(l,0,"Color");
		addMember(l,1,"Vector");
		addMember(l,2,"Float");
		addMember(l,3,"Range");
		addMember(l,4,"Texture");
		addMember(l,5,"Int");
		LuaDLL.lua_pop(l, 1);
	}
}
