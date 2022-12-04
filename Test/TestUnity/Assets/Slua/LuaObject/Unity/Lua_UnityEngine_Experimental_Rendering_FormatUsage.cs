using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_FormatUsage : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.FormatUsage");
		addMember(l,0,"Sample");
		addMember(l,1,"Linear");
		addMember(l,2,"Sparse");
		addMember(l,4,"Render");
		addMember(l,5,"Blend");
		addMember(l,6,"GetPixels");
		addMember(l,7,"SetPixels");
		addMember(l,8,"SetPixels32");
		addMember(l,9,"ReadPixels");
		addMember(l,10,"LoadStore");
		addMember(l,11,"MSAA2x");
		addMember(l,12,"MSAA4x");
		addMember(l,13,"MSAA8x");
		addMember(l,16,"StencilSampling");
		LuaDLL.lua_pop(l, 1);
	}
}
