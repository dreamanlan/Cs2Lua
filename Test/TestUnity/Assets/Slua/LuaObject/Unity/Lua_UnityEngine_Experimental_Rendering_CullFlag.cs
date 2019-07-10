using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_CullFlag : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.CullFlag");
		addMember(l,0,"None");
		addMember(l,1,"ForceEvenIfCameraIsNotActive");
		addMember(l,2,"OcclusionCull");
		addMember(l,4,"NeedsLighting");
		addMember(l,8,"NeedsReflectionProbes");
		addMember(l,16,"Stereo");
		addMember(l,32,"DisablePerObjectCulling");
		LuaDLL.lua_pop(l, 1);
	}
}
