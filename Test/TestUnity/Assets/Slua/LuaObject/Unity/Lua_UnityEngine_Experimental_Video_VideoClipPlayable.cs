using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Video_VideoClipPlayable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Video.VideoClipPlayable o;
			o=new UnityEngine.Experimental.Video.VideoClipPlayable();
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
	static public int GetHandle(IntPtr l) {
		try {
			UnityEngine.Experimental.Video.VideoClipPlayable self;
			checkValueType(l,1,out self);
			var ret=self.GetHandle();
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
	static public int GetClip(IntPtr l) {
		try {
			UnityEngine.Experimental.Video.VideoClipPlayable self;
			checkValueType(l,1,out self);
			var ret=self.GetClip();
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
	static public int SetClip(IntPtr l) {
		try {
			UnityEngine.Experimental.Video.VideoClipPlayable self;
			checkValueType(l,1,out self);
			UnityEngine.Video.VideoClip a1;
			checkType(l,2,out a1);
			self.SetClip(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLooped(IntPtr l) {
		try {
			UnityEngine.Experimental.Video.VideoClipPlayable self;
			checkValueType(l,1,out self);
			var ret=self.GetLooped();
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
	static public int SetLooped(IntPtr l) {
		try {
			UnityEngine.Experimental.Video.VideoClipPlayable self;
			checkValueType(l,1,out self);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.SetLooped(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsPlaying(IntPtr l) {
		try {
			UnityEngine.Experimental.Video.VideoClipPlayable self;
			checkValueType(l,1,out self);
			var ret=self.IsPlaying();
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
	static public int GetStartDelay(IntPtr l) {
		try {
			UnityEngine.Experimental.Video.VideoClipPlayable self;
			checkValueType(l,1,out self);
			var ret=self.GetStartDelay();
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
	static public int GetPauseDelay(IntPtr l) {
		try {
			UnityEngine.Experimental.Video.VideoClipPlayable self;
			checkValueType(l,1,out self);
			var ret=self.GetPauseDelay();
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
	static public int Seek(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.Experimental.Video.VideoClipPlayable self;
				checkValueType(l,1,out self);
				System.Double a1;
				checkType(l,3,out a1);
				System.Double a2;
				checkType(l,4,out a2);
				System.Double a3;
				checkType(l,5,out a3);
				self.Seek(a1,a2,a3);
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Experimental.Video.VideoClipPlayable self;
				checkValueType(l,1,out self);
				System.Double a1;
				checkType(l,3,out a1);
				System.Double a2;
				checkType(l,4,out a2);
				self.Seek(a1,a2);
				pushValue(l,true);
				setBack(l,self);
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
	[UnityEngine.Scripting.Preserve]
	static public int Create_s(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableGraph a1;
			checkValueType(l,1,out a1);
			UnityEngine.Video.VideoClip a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Experimental.Video.VideoClipPlayable.Create(a1,a2,a3);
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
		getTypeTable(l,"UnityEngine.Experimental.Video.VideoClipPlayable");
		addMember(l,GetHandle);
		addMember(l,GetClip);
		addMember(l,SetClip);
		addMember(l,GetLooped);
		addMember(l,SetLooped);
		addMember(l,IsPlaying);
		addMember(l,GetStartDelay);
		addMember(l,GetPauseDelay);
		addMember(l,Seek);
		addMember(l,Create_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Video.VideoClipPlayable),typeof(System.ValueType));
	}
}
