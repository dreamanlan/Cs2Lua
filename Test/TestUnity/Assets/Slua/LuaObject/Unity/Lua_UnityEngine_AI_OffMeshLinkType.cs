using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_OffMeshLinkType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.AI.OffMeshLinkType");
		addMember(l,0,"LinkTypeManual");
		addMember(l,1,"LinkTypeDropDown");
		addMember(l,2,"LinkTypeJumpAcross");
		LuaDLL.lua_pop(l, 1);
	}
}
