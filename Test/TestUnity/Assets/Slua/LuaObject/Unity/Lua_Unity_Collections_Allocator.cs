﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Collections_Allocator : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"Unity.Collections.Allocator");
		addMember(l,0,"Invalid");
		addMember(l,1,"None");
		addMember(l,2,"Temp");
		addMember(l,3,"TempJob");
		addMember(l,4,"Persistent");
		addMember(l,5,"AudioKernel");
		LuaDLL.lua_pop(l, 1);
	}
}
