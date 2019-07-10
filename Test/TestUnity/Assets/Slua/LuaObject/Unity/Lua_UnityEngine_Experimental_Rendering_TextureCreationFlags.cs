using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_TextureCreationFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.TextureCreationFlags");
		addMember(l,0,"None");
		addMember(l,1,"MipChain");
		addMember(l,64,"Crunch");
		LuaDLL.lua_pop(l, 1);
	}
}
