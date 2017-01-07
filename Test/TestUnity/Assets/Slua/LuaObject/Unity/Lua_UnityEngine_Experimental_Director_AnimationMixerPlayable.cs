using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Experimental_Director_AnimationMixerPlayable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Experimental.Director.AnimationMixerPlayable o;
			if(argc==1){
				o=new UnityEngine.Experimental.Director.AnimationMixerPlayable();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				System.Boolean a1;
				checkType(l,2,out a1);
				o=new UnityEngine.Experimental.Director.AnimationMixerPlayable(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetInputs(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationMixerPlayable self=(UnityEngine.Experimental.Director.AnimationMixerPlayable)checkSelf(l);
			UnityEngine.AnimationClip[] a1;
			checkArray(l,2,out a1);
			var ret=self.SetInputs(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Director.AnimationMixerPlayable");
		addMember(l,SetInputs);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Director.AnimationMixerPlayable),typeof(UnityEngine.Experimental.Director.AnimationPlayable));
	}
}
