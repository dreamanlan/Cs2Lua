using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Experimental_Director_AnimationPlayable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Experimental.Director.AnimationPlayable o;
			if(argc==1){
				o=new UnityEngine.Experimental.Director.AnimationPlayable();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				System.Boolean a1;
				checkType(l,2,out a1);
				o=new UnityEngine.Experimental.Director.AnimationPlayable(a1);
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
	static public int AddInput(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationPlayable self=(UnityEngine.Experimental.Director.AnimationPlayable)checkSelf(l);
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
			UnityEngine.Experimental.Director.AnimationPlayable self=(UnityEngine.Experimental.Director.AnimationPlayable)checkSelf(l);
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
			UnityEngine.Experimental.Director.AnimationPlayable self=(UnityEngine.Experimental.Director.AnimationPlayable)checkSelf(l);
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
				UnityEngine.Experimental.Director.AnimationPlayable self=(UnityEngine.Experimental.Director.AnimationPlayable)checkSelf(l);
				UnityEngine.Experimental.Director.AnimationPlayable a1;
				checkType(l,2,out a1);
				var ret=self.RemoveInput(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(int))){
				UnityEngine.Experimental.Director.AnimationPlayable self=(UnityEngine.Experimental.Director.AnimationPlayable)checkSelf(l);
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
			UnityEngine.Experimental.Director.AnimationPlayable self=(UnityEngine.Experimental.Director.AnimationPlayable)checkSelf(l);
			var ret=self.RemoveAllInputs();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Director.AnimationPlayable");
		addMember(l,AddInput);
		addMember(l,SetInput);
		addMember(l,SetInputs);
		addMember(l,RemoveInput);
		addMember(l,RemoveAllInputs);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Director.AnimationPlayable),typeof(UnityEngine.Experimental.Director.Playable));
	}
}
