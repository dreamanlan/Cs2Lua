using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_GraphicsJobsSyncPoint : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.GraphicsJobsSyncPoint");
		addMember(l,0,"EndOfFrame");
		addMember(l,1,"AfterScriptUpdate");
		addMember(l,2,"AfterScriptLateUpdate");
		addMember(l,3,"WaitForPresent");
		LuaDLL.lua_pop(l, 1);
	}
}
