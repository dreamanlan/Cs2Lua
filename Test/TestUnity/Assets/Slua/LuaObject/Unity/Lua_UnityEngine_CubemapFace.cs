using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CubemapFace : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.CubemapFace");
		addMember(l,0,"PositiveX");
		addMember(l,1,"NegativeX");
		addMember(l,2,"PositiveY");
		addMember(l,3,"NegativeY");
		addMember(l,4,"PositiveZ");
		addMember(l,5,"NegativeZ");
		addMember(l,-1,"Unknown");
		LuaDLL.lua_pop(l, 1);
	}
}
