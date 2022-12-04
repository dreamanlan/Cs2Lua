using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RenderingThreadingMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.RenderingThreadingMode");
		addMember(l,0,"Direct");
		addMember(l,1,"SingleThreaded");
		addMember(l,2,"MultiThreaded");
		addMember(l,3,"LegacyJobified");
		addMember(l,4,"NativeGraphicsJobs");
		addMember(l,5,"NativeGraphicsJobsWithoutRenderThread");
		LuaDLL.lua_pop(l, 1);
	}
}
