using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_WaitForPresentSyncPoint : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.WaitForPresentSyncPoint");
		addMember(l,0,"BeginFrame");
		addMember(l,1,"EndFrame");
		LuaDLL.lua_pop(l, 1);
	}
}
