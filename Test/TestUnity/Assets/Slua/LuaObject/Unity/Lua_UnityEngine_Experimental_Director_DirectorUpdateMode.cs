using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Experimental_Director_DirectorUpdateMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Director.DirectorUpdateMode");
		addMember(l,0,"DSPClock");
		addMember(l,1,"GameTime");
		addMember(l,2,"UnscaledGameTime");
		addMember(l,3,"Manual");
		LuaDLL.lua_pop(l, 1);
	}
}
