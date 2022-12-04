using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_SupportedRenderingFeatures_LightmapMixedBakeModes : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes");
		addMember(l,0,"None");
		addMember(l,1,"IndirectOnly");
		addMember(l,2,"Subtractive");
		addMember(l,4,"Shadowmask");
		LuaDLL.lua_pop(l, 1);
	}
}
