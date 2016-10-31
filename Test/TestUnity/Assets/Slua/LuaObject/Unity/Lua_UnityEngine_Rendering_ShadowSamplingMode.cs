using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_ShadowSamplingMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.ShadowSamplingMode");
		addMember(l,0,"CompareDepths");
		addMember(l,1,"RawDepth");
		LuaDLL.lua_pop(l, 1);
	}
}
