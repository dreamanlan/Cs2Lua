using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_DefaultFormat : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.DefaultFormat");
		addMember(l,0,"LDR");
		addMember(l,1,"HDR");
		addMember(l,2,"DepthStencil");
		addMember(l,3,"Shadow");
		addMember(l,4,"Video");
		LuaDLL.lua_pop(l, 1);
	}
}
