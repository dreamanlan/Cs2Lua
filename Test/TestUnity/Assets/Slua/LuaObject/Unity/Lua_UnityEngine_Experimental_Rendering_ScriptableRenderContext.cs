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
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Experimental.Rendering.FilterResults),typeof(UnityEngine.Experimental.Rendering.DrawRendererSettings),typeof(UnityEngine.Experimental.Rendering.FilterRenderersSettings),typeof(UnityEngine.Experimental.Rendering.RenderStateBlock))){
				UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
				checkValueType(l,1,out self);
				UnityEngine.Experimental.Rendering.FilterResults a1;
				checkValueType(l,2,out a1);
				UnityEngine.Experimental.Rendering.DrawRendererSettings a2;
				checkValueType(l,3,out a2);
				UnityEngine.Experimental.Rendering.FilterRenderersSettings a3;
				checkValueType(l,4,out a3);
				UnityEngine.Experimental.Rendering.RenderStateBlock a4;
				checkValueType(l,5,out a4);
				self.DrawRenderers(a1,ref a2,a3,a4);
				pushValue(l,true);
				pushValue(l,a2);
				setBack(l,self);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Experimental.Rendering.FilterResults),typeof(UnityEngine.Experimental.Rendering.DrawRendererSettings),typeof(UnityEngine.Experimental.Rendering.FilterRenderersSettings),typeof(List<UnityEngine.Experimental.Rendering.RenderStateMapping>))){
				UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
				checkValueType(l,1,out self);
				UnityEngine.Experimental.Rendering.FilterResults a1;
				checkValueType(l,2,out a1);
				UnityEngine.Experimental.Rendering.DrawRendererSettings a2;
				checkValueType(l,3,out a2);
				UnityEngine.Experimental.Rendering.FilterRenderersSettings a3;
				checkValueType(l,4,out a3);
				System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderStateMapping> a4;
				checkType(l,5,out a4);
				self.DrawRenderers(a1,ref a2,a3,a4);
				pushValue(l,true);
				pushValue(l,a2);
				setBack(l,self);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
				checkValueType(l,1,out self);
				UnityEngine.Experimental.Rendering.FilterResults a1;
				checkValueType(l,2,out a1);
				UnityEngine.Experimental.Rendering.DrawRendererSettings a2;
				checkValueType(l,3,out a2);
				UnityEngine.Experimental.Rendering.FilterRenderersSettings a3;
				checkValueType(l,4,out a3);
				self.DrawRenderers(a1,ref a2,a3);
				pushValue(l,true);
				pushValue(l,a2);
				setBack(l,self);
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
	static public int ExecuteCommandBufferAsync(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CommandBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.ComputeQueueType a2;
			checkEnum(l,3,out a2);
			self.ExecuteCommandBufferAsync(a1,a2);
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
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
				checkValueType(l,1,out self);
				UnityEngine.Camera a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.SetupCameraProperties(a1,a2);
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
				checkValueType(l,1,out self);
				UnityEngine.Camera a1;
				checkType(l,2,out a1);
				self.SetupCameraProperties(a1);
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
	static public int StereoEndRender(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.StereoEndRender(a1);
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
	static public int StartMultiEye(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.StartMultiEye(a1);
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
	static public int StopMultiEye(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.StopMultiEye(a1);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EmitWorldGeometryForSceneView_s(IntPtr l) {
		try {
			UnityEngine.Camera a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Rendering.ScriptableRenderContext.EmitWorldGeometryForSceneView(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BeginRenderPassInternal_s(IntPtr l) {
		try {
			System.IntPtr a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Experimental.Rendering.RenderPassAttachment[] a5;
			checkArray(l,5,out a5);
			UnityEngine.Experimental.Rendering.RenderPassAttachment a6;
			checkType(l,6,out a6);
			UnityEngine.Experimental.Rendering.ScriptableRenderContext.BeginRenderPassInternal(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BeginSubPassInternal_s(IntPtr l) {
		try {
			System.IntPtr a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Rendering.RenderPassAttachment[] a2;
			checkArray(l,2,out a2);
			UnityEngine.Experimental.Rendering.RenderPassAttachment[] a3;
			checkArray(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			UnityEngine.Experimental.Rendering.ScriptableRenderContext.BeginSubPassInternal(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EndRenderPassInternal_s(IntPtr l) {
		try {
			System.IntPtr a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Rendering.ScriptableRenderContext.EndRenderPassInternal(a1);
			pushValue(l,true);
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
		addMember(l,ExecuteCommandBufferAsync);
		addMember(l,SetupCameraProperties);
		addMember(l,StereoEndRender);
		addMember(l,StartMultiEye);
		addMember(l,StopMultiEye);
		addMember(l,DrawSkybox);
		addMember(l,EmitWorldGeometryForSceneView_s);
		addMember(l,BeginRenderPassInternal_s);
		addMember(l,BeginSubPassInternal_s);
		addMember(l,EndRenderPassInternal_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.ScriptableRenderContext),typeof(System.ValueType));
	}
}
