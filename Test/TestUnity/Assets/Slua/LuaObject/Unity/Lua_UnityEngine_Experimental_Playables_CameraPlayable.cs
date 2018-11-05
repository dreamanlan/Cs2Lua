using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Playables_CameraPlayable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Playables.CameraPlayable o;
			o=new UnityEngine.Experimental.Playables.CameraPlayable();
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
			UnityEngine.Experimental.Playables.CameraPlayable self;
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
	static public int GetCamera(IntPtr l) {
		try {
			UnityEngine.Experimental.Playables.CameraPlayable self;
			checkValueType(l,1,out self);
			var ret=self.GetCamera();
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
	static public int SetCamera(IntPtr l) {
		try {
			UnityEngine.Experimental.Playables.CameraPlayable self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.SetCamera(a1);
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
	static public int Create_s(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableGraph a1;
			checkValueType(l,1,out a1);
			UnityEngine.Camera a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Experimental.Playables.CameraPlayable.Create(a1,a2);
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
		getTypeTable(l,"UnityEngine.Experimental.Playables.CameraPlayable");
		addMember(l,GetHandle);
		addMember(l,GetCamera);
		addMember(l,SetCamera);
		addMember(l,Create_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Playables.CameraPlayable),typeof(System.ValueType));
	}
}
