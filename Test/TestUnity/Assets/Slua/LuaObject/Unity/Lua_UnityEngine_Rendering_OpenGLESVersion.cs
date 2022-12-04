using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_OpenGLESVersion : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.OpenGLESVersion");
		addMember(l,0,"None");
		addMember(l,1,"OpenGLES20");
		addMember(l,2,"OpenGLES30");
		addMember(l,3,"OpenGLES31");
		addMember(l,4,"OpenGLES31AEP");
		addMember(l,5,"OpenGLES32");
		LuaDLL.lua_pop(l, 1);
	}
}
