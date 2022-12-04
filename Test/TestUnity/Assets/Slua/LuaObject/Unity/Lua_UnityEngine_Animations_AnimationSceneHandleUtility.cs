using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Animations_AnimationSceneHandleUtility : LuaObject {
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Animations.AnimationSceneHandleUtility");
		createTypeMetatable(l,null, typeof(UnityEngine.Animations.AnimationSceneHandleUtility));
	}
}
