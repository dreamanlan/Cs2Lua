using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Video_VideoRenderMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Video.VideoRenderMode");
		addMember(l,0,"CameraFarPlane");
		addMember(l,1,"CameraNearPlane");
		addMember(l,2,"RenderTexture");
		addMember(l,3,"MaterialOverride");
		addMember(l,4,"APIOnly");
		LuaDLL.lua_pop(l, 1);
	}
}
