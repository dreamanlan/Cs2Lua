using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_SortFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.SortFlags");
		addMember(l,0,"None");
		addMember(l,1,"SortingLayer");
		addMember(l,2,"RenderQueue");
		addMember(l,4,"BackToFront");
		addMember(l,8,"QuantizedFrontToBack");
		addMember(l,16,"OptimizeStateChanges");
		addMember(l,23,"CommonTransparent");
		addMember(l,32,"CanvasOrder");
		addMember(l,59,"CommonOpaque");
		LuaDLL.lua_pop(l, 1);
	}
}
