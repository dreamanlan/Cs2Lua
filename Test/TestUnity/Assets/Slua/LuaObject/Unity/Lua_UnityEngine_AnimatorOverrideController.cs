using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimatorOverrideController : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AnimatorOverrideController o;
			o=new UnityEngine.AnimatorOverrideController();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_runtimeAnimatorController(IntPtr l) {
		try {
			UnityEngine.AnimatorOverrideController self=(UnityEngine.AnimatorOverrideController)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.runtimeAnimatorController);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_runtimeAnimatorController(IntPtr l) {
		try {
			UnityEngine.AnimatorOverrideController self=(UnityEngine.AnimatorOverrideController)checkSelf(l);
			UnityEngine.RuntimeAnimatorController v;
			checkType(l,2,out v);
			self.runtimeAnimatorController=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clips(IntPtr l) {
		try {
			UnityEngine.AnimatorOverrideController self=(UnityEngine.AnimatorOverrideController)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clips);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clips(IntPtr l) {
		try {
			UnityEngine.AnimatorOverrideController self=(UnityEngine.AnimatorOverrideController)checkSelf(l);
			UnityEngine.AnimationClipPair[] v;
			checkArray(l,2,out v);
			self.clips=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int getItem(IntPtr l) {
		try {
			UnityEngine.AnimatorOverrideController self=(UnityEngine.AnimatorOverrideController)checkSelf(l);
			LuaTypes t = LuaDLL.lua_type(l, 2);
			if(matchType(l,2,t,typeof(System.String))){
				string v;
				checkType(l,2,out v);
				var ret = self[v];
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,2,t,typeof(UnityEngine.AnimationClip))){
				UnityEngine.AnimationClip v;
				checkType(l,2,out v);
				var ret = self[v];
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
	static public int setItem(IntPtr l) {
		try {
			UnityEngine.AnimatorOverrideController self=(UnityEngine.AnimatorOverrideController)checkSelf(l);
			LuaTypes t = LuaDLL.lua_type(l, 2);
			if(matchType(l,2,t,typeof(System.String))){
				string v;
				checkType(l,2,out v);
				UnityEngine.AnimationClip c;
				checkType(l,3,out c);
				self[v]=c;
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,2,t,typeof(UnityEngine.AnimationClip))){
				UnityEngine.AnimationClip v;
				checkType(l,2,out v);
				UnityEngine.AnimationClip c;
				checkType(l,3,out c);
				self[v]=c;
				pushValue(l,true);
				return 1;
			}
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimatorOverrideController");
		addMember(l,getItem);
		addMember(l,setItem);
		addMember(l,"runtimeAnimatorController",get_runtimeAnimatorController,set_runtimeAnimatorController,true);
		addMember(l,"clips",get_clips,set_clips,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimatorOverrideController),typeof(UnityEngine.RuntimeAnimatorController));
	}
}
