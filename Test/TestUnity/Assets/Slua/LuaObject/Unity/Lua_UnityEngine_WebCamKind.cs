using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_WebCamKind : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.WebCamKind");
		addMember(l,1,"WideAngle");
		addMember(l,2,"Telephoto");
		addMember(l,3,"ColorAndDepth");
		LuaDLL.lua_pop(l, 1);
	}
}
