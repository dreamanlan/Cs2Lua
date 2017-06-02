using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Director_AnimationPlayableGraphExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateAnimationOutput_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph a1;
			checkValueType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UnityEngine.Animator a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.CreateAnimationOutput(a1,a2,a3);
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
	static public int CreateAnimationClipPlayable_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph a1;
			checkValueType(l,1,out a1);
			UnityEngine.AnimationClip a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.CreateAnimationClipPlayable(a1,a2);
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
	static public int CreateAnimationMixerPlayable_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Experimental.Director.PlayableGraph a1;
				checkValueType(l,1,out a1);
				var ret=UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.CreateAnimationMixerPlayable(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Experimental.Director.PlayableGraph a1;
				checkValueType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.CreateAnimationMixerPlayable(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Experimental.Director.PlayableGraph a1;
				checkValueType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.CreateAnimationMixerPlayable(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateAnimatorControllerPlayable_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph a1;
			checkValueType(l,1,out a1);
			UnityEngine.RuntimeAnimatorController a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.CreateAnimatorControllerPlayable(a1,a2);
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
	static public int DestroyOutput_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph a1;
			checkValueType(l,1,out a1);
			UnityEngine.Experimental.Director.AnimationPlayableOutput a2;
			checkValueType(l,2,out a2);
			UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.DestroyOutput(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetAnimationOutputCount_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.GetAnimationOutputCount(a1);
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
	static public int GetAnimationOutput_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph a1;
			checkValueType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.GetAnimationOutput(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions");
		addMember(l,CreateAnimationOutput_s);
		addMember(l,CreateAnimationClipPlayable_s);
		addMember(l,CreateAnimationMixerPlayable_s);
		addMember(l,CreateAnimatorControllerPlayable_s);
		addMember(l,DestroyOutput_s);
		addMember(l,GetAnimationOutputCount_s);
		addMember(l,GetAnimationOutput_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions));
	}
}
