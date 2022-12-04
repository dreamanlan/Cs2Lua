using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_ShaderKeywordType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.ShaderKeywordType");
		addMember(l,0,"None");
		addMember(l,2,"BuiltinDefault");
		addMember(l,6,"BuiltinExtra");
		addMember(l,10,"BuiltinAutoStripped");
		addMember(l,16,"UserDefined");
		addMember(l,32,"Plugin");
		LuaDLL.lua_pop(l, 1);
	}
}
