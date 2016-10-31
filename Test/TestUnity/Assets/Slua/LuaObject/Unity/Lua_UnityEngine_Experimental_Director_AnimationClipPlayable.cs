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
	static public int GetInput(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetInput(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInputs(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
				var ret=self.GetInputs();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
				System.Collections.Generic.List<UnityEngine.Experimental.Director.Playable> a1;
				checkType(l,2,out a1);
				self.GetInputs(a1);
				pushValue(l,true);
				return 1;
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
	static public int ClearInputs(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			self.ClearInputs();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetOutput(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetOutput(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetOutputs(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
				var ret=self.GetOutputs();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
				System.Collections.Generic.List<UnityEngine.Experimental.Director.Playable> a1;
				checkType(l,2,out a1);
				self.GetOutputs(a1);
				pushValue(l,true);
				return 1;
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
	static public int Dispose(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInputWeight(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetInputWeight(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetInputWeight(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.SetInputWeight(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PrepareFrame(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			UnityEngine.Experimental.Director.FrameData a1;
			checkValueType(l,2,out a1);
			self.PrepareFrame(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ProcessFrame(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			UnityEngine.Experimental.Director.FrameData a1;
			checkValueType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			self.ProcessFrame(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSetTime(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.OnSetTime(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSetPlayState(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationClipPlayable self=(UnityEngine.Experimental.Director.AnimationClipPlayable)checkSelf(l);
			UnityEngine.Experimental.Director.PlayState a1;
			checkEnum(l,2,out a1);
			self.OnSetPlayState(a1);
			pushValue(l,true);
			return 1;
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
		addMember(l,GetInput);
		addMember(l,GetInputs);
		addMember(l,ClearInputs);
		addMember(l,GetOutput);
		addMember(l,GetOutputs);
		addMember(l,Dispose);
		addMember(l,GetInputWeight);
		addMember(l,SetInputWeight);
		addMember(l,PrepareFrame);
		addMember(l,ProcessFrame);
		addMember(l,OnSetTime);
		addMember(l,OnSetPlayState);
		addMember(l,"clip",get_clip,null,true);
		addMember(l,"speed",get_speed,set_speed,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Director.AnimationClipPlayable),typeof(UnityEngine.Experimental.Director.AnimationPlayable));
	}
}
