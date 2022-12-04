using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RTClearFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.RTClearFlags");
		addMember(l,0,"None");
		addMember(l,1,"Color");
		addMember(l,2,"Depth");
		addMember(l,3,"ColorDepth");
		addMember(l,4,"Stencil");
		addMember(l,5,"ColorStencil");
		addMember(l,6,"DepthStencil");
		addMember(l,7,"All");
		LuaDLL.lua_pop(l, 1);
	}
}
