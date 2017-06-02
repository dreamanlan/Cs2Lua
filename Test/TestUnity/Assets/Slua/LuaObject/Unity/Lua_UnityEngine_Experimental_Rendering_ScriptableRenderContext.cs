using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_ScriptableRenderContext : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRenderContext o;
			o=new UnityEngine.Experimental.Rendering.ScriptableRenderContext();
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
	static public int Submit(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			self.Submit();
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
	static public int DrawRenderers(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.DrawRendererSettings a1;
			checkValueType(l,2,out a1);
			self.DrawRenderers(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			setBack(l,self);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawShadows(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.DrawShadowsSettings a1;
			checkValueType(l,2,out a1);
			self.DrawShadows(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			setBack(l,self);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ExecuteCommandBuffer(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CommandBuffer a1;
			checkType(l,2,out a1);
			self.ExecuteCommandBuffer(a1);
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
	static public int SetupCameraProperties(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.SetupCameraProperties(a1);
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
	static public int DrawSkybox(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.DrawSkybox(a1);
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
		getTypeTable(l,"UnityEngine.Experimental.Rendering.ScriptableRenderContext");
		addMember(l,Submit);
		addMember(l,DrawRenderers);
		addMember(l,DrawShadows);
		addMember(l,ExecuteCommandBuffer);
		addMember(l,SetupCameraProperties);
		addMember(l,DrawSkybox);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.ScriptableRenderContext),typeof(System.ValueType));
	}
}
