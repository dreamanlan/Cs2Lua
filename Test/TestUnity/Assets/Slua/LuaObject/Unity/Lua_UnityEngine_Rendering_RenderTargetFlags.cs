using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RenderTargetFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.RenderTargetFlags");
		addMember(l,0,"None");
		addMember(l,1,"ReadOnlyDepth");
		addMember(l,2,"ReadOnlyStencil");
		addMember(l,3,"ReadOnlyDepthStencil");
		LuaDLL.lua_pop(l, 1);
	}
}
