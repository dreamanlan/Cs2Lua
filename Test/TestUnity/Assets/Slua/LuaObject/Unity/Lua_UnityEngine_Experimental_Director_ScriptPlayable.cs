using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Director_ScriptPlayable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnGraphStart(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.ScriptPlayable self=(UnityEngine.Experimental.Director.ScriptPlayable)checkSelf(l);
			self.OnGraphStart();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnGraphStop(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.ScriptPlayable self=(UnityEngine.Experimental.Director.ScriptPlayable)checkSelf(l);
			self.OnGraphStop();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnDestroy(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.ScriptPlayable self=(UnityEngine.Experimental.Director.ScriptPlayable)checkSelf(l);
			self.OnDestroy();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PrepareFrame(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.ScriptPlayable self=(UnityEngine.Experimental.Director.ScriptPlayable)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int ProcessFrame(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.ScriptPlayable self=(UnityEngine.Experimental.Director.ScriptPlayable)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int OnPlayStateChanged(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.ScriptPlayable self=(UnityEngine.Experimental.Director.ScriptPlayable)checkSelf(l);
			UnityEngine.Experimental.Director.FrameData a1;
			checkValueType(l,2,out a1);
			UnityEngine.Experimental.Director.PlayState a2;
			checkEnum(l,3,out a2);
			self.OnPlayStateChanged(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_handle(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.ScriptPlayable self=(UnityEngine.Experimental.Director.ScriptPlayable)checkSelf(l);
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
			UnityEngine.Experimental.Director.ScriptPlayable self=(UnityEngine.Experimental.Director.ScriptPlayable)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Director.ScriptPlayable");
		addMember(l,OnGraphStart);
		addMember(l,OnGraphStop);
		addMember(l,OnDestroy);
		addMember(l,PrepareFrame);
		addMember(l,ProcessFrame);
		addMember(l,OnPlayStateChanged);
		addMember(l,"handle",get_handle,set_handle,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Director.ScriptPlayable),typeof(UnityEngine.Experimental.Director.Playable));
	}
}
