using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_ScriptableRenderContext : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext o;
			o=new UnityEngine.Rendering.ScriptableRenderContext();
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
	static public int EndSubPass(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			self.EndSubPass();
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EndRenderPass(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			self.EndRenderPass();
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Submit(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			self.Submit();
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SubmitForRenderPassValidation(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			var ret=self.SubmitForRenderPassValidation();
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
	static public int DrawRenderers__CullingResults__R_DrawingSettings__R_FilteringSettings(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CullingResults a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.DrawingSettings a2;
			checkValueType(l,3,out a2);
			UnityEngine.Rendering.FilteringSettings a3;
			checkValueType(l,4,out a3);
			self.DrawRenderers(a1,ref a2,ref a3);
			pushValue(l,true);
			pushValue(l,a2);
			pushValue(l,a3);
			setBack(l,(object)self);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawRenderers__CullingResults__R_DrawingSettings__R_FilteringSettings__R_RenderStateBlock(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CullingResults a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.DrawingSettings a2;
			checkValueType(l,3,out a2);
			UnityEngine.Rendering.FilteringSettings a3;
			checkValueType(l,4,out a3);
			UnityEngine.Rendering.RenderStateBlock a4;
			checkValueType(l,5,out a4);
			self.DrawRenderers(a1,ref a2,ref a3,ref a4);
			pushValue(l,true);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			setBack(l,(object)self);
			return 4;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawShadows(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.ShadowDrawingSettings a1;
			checkValueType(l,2,out a1);
			self.DrawShadows(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			setBack(l,(object)self);
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
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CommandBuffer a1;
			checkType(l,2,out a1);
			self.ExecuteCommandBuffer(a1);
			pushValue(l,true);
			setBack(l,(object)self);
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
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CommandBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.ComputeQueueType a2;
			checkEnum(l,3,out a2);
			self.ExecuteCommandBufferAsync(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetupCameraProperties__Camera__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetupCameraProperties(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetupCameraProperties__Camera__Boolean__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.SetupCameraProperties(a1,a2,a3);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StereoEndRender__Camera(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.StereoEndRender(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StereoEndRender__Camera__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.StereoEndRender(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StereoEndRender__Camera__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.StereoEndRender(a1,a2,a3);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartMultiEye__Camera(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.StartMultiEye(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartMultiEye__Camera__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.StartMultiEye(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
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
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.StopMultiEye(a1);
			pushValue(l,true);
			setBack(l,(object)self);
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
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.DrawSkybox(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InvokeOnRenderObjectCallback(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			self.InvokeOnRenderObjectCallback();
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawGizmos(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.GizmoSubset a2;
			checkEnum(l,3,out a2);
			self.DrawGizmos(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawWireOverlay(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.DrawWireOverlay(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawUIOverlay(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.DrawUIOverlay(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Cull(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.ScriptableCullingParameters a1;
			checkValueType(l,2,out a1);
			var ret=self.Cull(ref a1);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a1);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Equals__ScriptableRenderContext(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.ScriptableRenderContext a1;
			checkValueType(l,2,out a1);
			var ret=self.Equals(a1);
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
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Equals(a1);
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
	static public int CreateRendererList(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RendererUtils.RendererListDesc a1;
			checkValueType(l,2,out a1);
			var ret=self.CreateRendererList(a1);
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
	static public int QueryRendererListStatus(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RendererUtils.RendererList a1;
			checkValueType(l,2,out a1);
			var ret=self.QueryRendererListStatus(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
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
			UnityEngine.Rendering.ScriptableRenderContext.EmitWorldGeometryForSceneView(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EmitGeometryForCamera_s(IntPtr l) {
		try {
			UnityEngine.Camera a1;
			checkType(l,1,out a1);
			UnityEngine.Rendering.ScriptableRenderContext.EmitGeometryForCamera(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int op_Equality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.ScriptableRenderContext a2;
			checkValueType(l,2,out a2);
			var ret=(a1==a2);
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
	static public int op_Inequality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.ScriptableRenderContext a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.ScriptableRenderContext a2;
			checkValueType(l,2,out a2);
			var ret=(a1!=a2);
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
		getTypeTable(l,"UnityEngine.Rendering.ScriptableRenderContext");
		addMember(l,ctor_s);
		addMember(l,EndSubPass);
		addMember(l,EndRenderPass);
		addMember(l,Submit);
		addMember(l,SubmitForRenderPassValidation);
		addMember(l,DrawRenderers__CullingResults__R_DrawingSettings__R_FilteringSettings);
		addMember(l,DrawRenderers__CullingResults__R_DrawingSettings__R_FilteringSettings__R_RenderStateBlock);
		addMember(l,DrawShadows);
		addMember(l,ExecuteCommandBuffer);
		addMember(l,ExecuteCommandBufferAsync);
		addMember(l,SetupCameraProperties__Camera__Boolean);
		addMember(l,SetupCameraProperties__Camera__Boolean__Int32);
		addMember(l,StereoEndRender__Camera);
		addMember(l,StereoEndRender__Camera__Int32);
		addMember(l,StereoEndRender__Camera__Int32__Boolean);
		addMember(l,StartMultiEye__Camera);
		addMember(l,StartMultiEye__Camera__Int32);
		addMember(l,StopMultiEye);
		addMember(l,DrawSkybox);
		addMember(l,InvokeOnRenderObjectCallback);
		addMember(l,DrawGizmos);
		addMember(l,DrawWireOverlay);
		addMember(l,DrawUIOverlay);
		addMember(l,Cull);
		addMember(l,Equals__ScriptableRenderContext);
		addMember(l,Equals__Object);
		addMember(l,CreateRendererList);
		addMember(l,QueryRendererListStatus);
		addMember(l,EmitWorldGeometryForSceneView_s);
		addMember(l,EmitGeometryForCamera_s);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.ScriptableRenderContext),typeof(System.ValueType));
	}
}
