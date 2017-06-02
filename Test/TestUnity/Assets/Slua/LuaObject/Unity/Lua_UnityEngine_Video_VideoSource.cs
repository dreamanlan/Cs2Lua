using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Video_VideoSource : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Video.VideoSource");
		addMember(l,0,"VideoClip");
		addMember(l,1,"Url");
		LuaDLL.lua_pop(l, 1);
	}
}
