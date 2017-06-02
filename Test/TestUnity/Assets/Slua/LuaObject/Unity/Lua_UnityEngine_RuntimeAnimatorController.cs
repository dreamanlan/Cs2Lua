using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_RuntimeAnimatorController : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.RuntimeAnimatorController o;
			o=new UnityEngine.RuntimeAnimatorController();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_animationClips(IntPtr l) {
		try {
			UnityEngine.RuntimeAnimatorController self=(UnityEngine.RuntimeAnimatorController)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.animationClips);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RuntimeAnimatorController");
		addMember(l,"animationClips",get_animationClips,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.RuntimeAnimatorController),typeof(UnityEngine.Object));
	}
}
