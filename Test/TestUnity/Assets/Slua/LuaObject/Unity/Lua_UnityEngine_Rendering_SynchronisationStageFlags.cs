using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_SynchronisationStageFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.SynchronisationStageFlags");
		addMember(l,1,"VertexProcessing");
		addMember(l,2,"PixelProcessing");
		addMember(l,4,"ComputeProcessing");
		addMember(l,7,"AllGPUOperations");
		LuaDLL.lua_pop(l, 1);
	}
}
