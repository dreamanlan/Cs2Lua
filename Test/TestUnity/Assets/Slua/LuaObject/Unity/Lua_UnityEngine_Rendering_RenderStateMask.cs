using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RenderStateMask : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.RenderStateMask");
		addMember(l,0,"Nothing");
		addMember(l,1,"Blend");
		addMember(l,2,"Raster");
		addMember(l,4,"Depth");
		addMember(l,8,"Stencil");
		addMember(l,15,"Everything");
		LuaDLL.lua_pop(l, 1);
	}
}
