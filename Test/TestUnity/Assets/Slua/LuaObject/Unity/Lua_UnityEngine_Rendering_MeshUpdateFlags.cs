using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_MeshUpdateFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.MeshUpdateFlags");
		addMember(l,0,"Default");
		addMember(l,1,"DontValidateIndices");
		addMember(l,2,"DontResetBoneBounds");
		addMember(l,4,"DontNotifyMeshUsers");
		addMember(l,8,"DontRecalculateBounds");
		LuaDLL.lua_pop(l, 1);
	}
}
