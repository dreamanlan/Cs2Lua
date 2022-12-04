using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ComputeBufferMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ComputeBufferMode");
		addMember(l,0,"Immutable");
		addMember(l,1,"Dynamic");
		addMember(l,2,"Circular");
		addMember(l,3,"StreamOut");
		addMember(l,4,"SubUpdates");
		LuaDLL.lua_pop(l, 1);
	}
}
