using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_UVChannelFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.UVChannelFlags");
		addMember(l,1,"UV0");
		addMember(l,2,"UV1");
		addMember(l,4,"UV2");
		addMember(l,8,"UV3");
		LuaDLL.lua_pop(l, 1);
	}
}
