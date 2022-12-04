using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_ShaderPropertyFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.ShaderPropertyFlags");
		addMember(l,0,"None");
		addMember(l,1,"HideInInspector");
		addMember(l,2,"PerRendererData");
		addMember(l,4,"NoScaleOffset");
		addMember(l,8,"Normal");
		addMember(l,16,"HDR");
		addMember(l,32,"Gamma");
		addMember(l,64,"NonModifiableTextureData");
		addMember(l,128,"MainTexture");
		addMember(l,256,"MainColor");
		LuaDLL.lua_pop(l, 1);
	}
}
