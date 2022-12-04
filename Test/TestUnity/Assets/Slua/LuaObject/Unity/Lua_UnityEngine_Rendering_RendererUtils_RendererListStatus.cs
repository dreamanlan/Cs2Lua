using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RendererUtils_RendererListStatus : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.RendererUtils.RendererListStatus");
		addMember(l,0,"kRendererListEmpty");
		addMember(l,1,"kRendererListPopulated");
		addMember(l,-2,"kRendererListInvalid");
		addMember(l,-1,"kRendererListProcessing");
		LuaDLL.lua_pop(l, 1);
	}
}
