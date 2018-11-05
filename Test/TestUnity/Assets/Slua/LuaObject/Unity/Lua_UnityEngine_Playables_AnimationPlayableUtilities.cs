using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Playables_AnimationPlayableUtilities : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Play_s(IntPtr l) {
		try {
			UnityEngine.Animator a1;
			checkType(l,1,out a1);
			UnityEngine.Playables.Playable a2;
			checkValueType(l,2,out a2);
			UnityEngine.Playables.PlayableGraph a3;
			checkValueType(l,3,out a3);
			UnityEngine.Playables.AnimationPlayableUtilities.Play(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PlayClip_s(IntPtr l) {
		try {
			UnityEngine.Animator a1;
			checkType(l,1,out a1);
			UnityEngine.AnimationClip a2;
			checkType(l,2,out a2);
			UnityEngine.Playables.PlayableGraph a3;
			var ret=UnityEngine.Playables.AnimationPlayableUtilities.PlayClip(a1,a2,out a3);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PlayMixer_s(IntPtr l) {
		try {
			UnityEngine.Animator a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Playables.PlayableGraph a3;
			var ret=UnityEngine.Playables.AnimationPlayableUtilities.PlayMixer(a1,a2,out a3);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PlayLayerMixer_s(IntPtr l) {
		try {
			UnityEngine.Animator a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Playables.PlayableGraph a3;
			var ret=UnityEngine.Playables.AnimationPlayableUtilities.PlayLayerMixer(a1,a2,out a3);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PlayAnimatorController_s(IntPtr l) {
		try {
			UnityEngine.Animator a1;
			checkType(l,1,out a1);
			UnityEngine.RuntimeAnimatorController a2;
			checkType(l,2,out a2);
			UnityEngine.Playables.PlayableGraph a3;
			var ret=UnityEngine.Playables.AnimationPlayableUtilities.PlayAnimatorController(a1,a2,out a3);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Playables.AnimationPlayableUtilities");
		addMember(l,Play_s);
		addMember(l,PlayClip_s);
		addMember(l,PlayMixer_s);
		addMember(l,PlayLayerMixer_s);
		addMember(l,PlayAnimatorController_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Playables.AnimationPlayableUtilities));
	}
}
