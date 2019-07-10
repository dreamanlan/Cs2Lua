using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_FormatUsage : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.FormatUsage");
		addMember(l,0,"Sample");
		addMember(l,1,"Linear");
		addMember(l,3,"Render");
		addMember(l,4,"Blend");
		addMember(l,8,"LoadStore");
		addMember(l,9,"MSAA2x");
		addMember(l,10,"MSAA4x");
		addMember(l,11,"MSAA8x");
		LuaDLL.lua_pop(l, 1);
	}
}
