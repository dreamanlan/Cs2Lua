using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Director_FrameData_EvaluationType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Director.FrameData.EvaluationType");
		addMember(l,0,"Evaluate");
		addMember(l,1,"Playback");
		LuaDLL.lua_pop(l, 1);
	}
}
