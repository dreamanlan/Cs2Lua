using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Experimental_Director_AnimationClipPlayable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable o;
			UnityEngine.AnimationClip a1;
			checkType(l,2,out a1);
			o=new UnityEngine.Experimental.Director.AnimationClipPlayable(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddInput(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			UnityEngine.Experimental.Director.AnimationPlayable a1;
			checkType(l,2,out a1);
			var ret=self.AddInput(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetInput(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			UnityEngine.Experimental.Director.AnimationPlayable a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.SetInput(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetInputs(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			System.Collections.Generic.IEnumerable<UnityEngine.Experimental.Director.AnimationPlayable> a1;
			checkType(l,2,out a1);
			var ret=self.SetInputs(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveInput(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Experimental.Director.AnimationPlayable))){
				UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
				UnityEngine.Experimental.Director.AnimationPlayable a1;
				checkType(l,2,out a1);
				var ret=self.RemoveInput(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(int))){
				UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.RemoveInput(a1);
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
	static public int RemoveAllInputs(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			var ret=self.RemoveAllInputs();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
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
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Director.AnimationClipPlayable");
		addMember(l,AddInput);
		addMember(l,SetInput);
		addMember(l,SetInputs);
		addMember(l,RemoveInput);
		addMember(l,RemoveAllInputs);
		addMember(l,"clip",get_clip,null,true);
		addMember(l,"speed",get_speed,set_speed,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Director.AnimationClipPlayable),typeof(UnityEngine.Experimental.Director.AnimationPlayable));
	}
}
