using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_SinglePassStereoMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.SinglePassStereoMode");
		addMember(l,0,"None");
		addMember(l,1,"SideBySide");
		addMember(l,2,"Instancing");
		addMember(l,3,"Multiview");
		LuaDLL.lua_pop(l, 1);
	}
}
