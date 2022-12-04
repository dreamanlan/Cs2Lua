using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_CustomRenderTextureManager : LuaObject {
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CustomRenderTextureManager");
		createTypeMetatable(l,null, typeof(UnityEngine.CustomRenderTextureManager));
	}
}
