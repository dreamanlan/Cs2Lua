using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TouchType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.TouchType");
		addMember(l,0,"Direct");
		addMember(l,1,"Indirect");
		addMember(l,2,"Stylus");
		LuaDLL.lua_pop(l, 1);
	}
}
