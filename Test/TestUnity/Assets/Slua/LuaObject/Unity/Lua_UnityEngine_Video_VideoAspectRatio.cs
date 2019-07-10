using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Video_VideoAspectRatio : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Video.VideoAspectRatio");
		addMember(l,0,"NoScaling");
		addMember(l,1,"FitVertically");
		addMember(l,2,"FitHorizontally");
		addMember(l,3,"FitInside");
		addMember(l,4,"FitOutside");
		addMember(l,5,"Stretch");
		LuaDLL.lua_pop(l, 1);
	}
}
