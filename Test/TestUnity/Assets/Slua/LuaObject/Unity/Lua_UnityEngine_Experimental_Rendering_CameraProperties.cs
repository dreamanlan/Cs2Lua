using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_CameraProperties : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.CameraProperties o;
			o=new UnityEngine.Experimental.Rendering.CameraProperties();
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
	static public int GetShadowCullingPlane(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.CameraProperties self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetShadowCullingPlane(a1);
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
	static public int SetShadowCullingPlane(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.CameraProperties self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Plane a2;
			checkValueType(l,3,out a2);
			self.SetShadowCullingPlane(a1,a2);
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
	static public int GetCameraCullingPlane(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.CameraProperties self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetCameraCullingPlane(a1);
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
	static public int SetCameraCullingPlane(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.CameraProperties self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Plane a2;
			checkValueType(l,3,out a2);
			self.SetCameraCullingPlane(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.CameraProperties");
		addMember(l,GetShadowCullingPlane);
		addMember(l,SetShadowCullingPlane);
		addMember(l,GetCameraCullingPlane);
		addMember(l,SetCameraCullingPlane);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.CameraProperties),typeof(System.ValueType));
	}
}
