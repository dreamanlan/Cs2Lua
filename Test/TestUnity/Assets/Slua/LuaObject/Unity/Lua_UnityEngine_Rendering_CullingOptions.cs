using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_CullingOptions : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.CullingOptions");
		addMember(l,0,"None");
		addMember(l,1,"ForceEvenIfCameraIsNotActive");
		addMember(l,2,"OcclusionCull");
		addMember(l,4,"NeedsLighting");
		addMember(l,8,"NeedsReflectionProbes");
		addMember(l,16,"Stereo");
		addMember(l,32,"DisablePerObjectCulling");
		addMember(l,64,"ShadowCasters");
		LuaDLL.lua_pop(l, 1);
	}
}
