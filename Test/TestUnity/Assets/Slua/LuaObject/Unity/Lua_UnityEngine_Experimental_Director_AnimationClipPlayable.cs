using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Director_AnimationClipPlayable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable o;
			o=new UnityEngine.Experimental.Director.AnimationClipPlayable();
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
	static public int get_handle(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.handle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_handle(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			UnityEngine.Experimental.Director.PlayableHandle v;
			checkValueType(l,2,out v);
			self.handle=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_clip(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clip);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_speed(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.speed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_speed(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.speed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_applyFootIK(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.applyFootIK);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_applyFootIK(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.applyFootIK=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Director.AnimationClipPlayable");
		addMember(l,"handle",get_handle,set_handle,true);
		addMember(l,"clip",get_clip,null,true);
		addMember(l,"speed",get_speed,set_speed,true);
		addMember(l,"applyFootIK",get_applyFootIK,set_applyFootIK,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Director.AnimationClipPlayable),typeof(UnityEngine.Experimental.Director.AnimationPlayable));
	}
}
