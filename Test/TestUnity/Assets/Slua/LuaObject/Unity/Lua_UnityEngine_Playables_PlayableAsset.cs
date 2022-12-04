using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Playables_PlayableAsset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreatePlayable(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableAsset self=(UnityEngine.Playables.PlayableAsset)checkSelf(l);
			UnityEngine.Playables.PlayableGraph a1;
			checkValueType(l,2,out a1);
			UnityEngine.GameObject a2;
			checkType(l,3,out a2);
			var ret=self.CreatePlayable(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_duration(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableAsset self=(UnityEngine.Playables.PlayableAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.duration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Playables.PlayableAsset");
		addMember(l,CreatePlayable);
		addMember(l,"duration",get_duration,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Playables.PlayableAsset),typeof(UnityEngine.ScriptableObject));
	}
}
