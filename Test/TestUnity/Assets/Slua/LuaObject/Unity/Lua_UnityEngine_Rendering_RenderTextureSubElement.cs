using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RenderTextureSubElement : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.RenderTextureSubElement");
		addMember(l,0,"Color");
		addMember(l,1,"Depth");
		addMember(l,2,"Stencil");
		addMember(l,3,"Default");
		LuaDLL.lua_pop(l, 1);
	}
}
