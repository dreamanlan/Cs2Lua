using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Graphics : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Graphics o;
			o=new UnityEngine.Graphics();
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
	static public int ClearRandomWriteTargets_s(IntPtr l) {
		try {
			UnityEngine.Graphics.ClearRandomWriteTargets();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ExecuteCommandBuffer_s(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer a1;
			checkType(l,1,out a1);
			UnityEngine.Graphics.ExecuteCommandBuffer(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ExecuteCommandBufferAsync_s(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer a1;
			checkType(l,1,out a1);
			UnityEngine.Rendering.ComputeQueueType a2;
			checkEnum(l,2,out a2);
			UnityEngine.Graphics.ExecuteCommandBufferAsync(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetSetup_s(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup a1;
			checkValueType(l,1,out a1);
			UnityEngine.Graphics.SetRenderTarget(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTexture_s(IntPtr l) {
		try {
			UnityEngine.RenderTexture a1;
			checkType(l,1,out a1);
			UnityEngine.Graphics.SetRenderTarget(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__A_RenderBuffer__RenderBuffer_s(IntPtr l) {
		try {
			UnityEngine.RenderBuffer[] a1;
			checkArray(l,1,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,2,out a2);
			UnityEngine.Graphics.SetRenderTarget(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTexture__Int32_s(IntPtr l) {
		try {
			UnityEngine.RenderTexture a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Graphics.SetRenderTarget(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderBuffer__RenderBuffer_s(IntPtr l) {
		try {
			UnityEngine.RenderBuffer a1;
			checkValueType(l,1,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,2,out a2);
			UnityEngine.Graphics.SetRenderTarget(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTexture__Int32__CubemapFace_s(IntPtr l) {
		try {
			UnityEngine.RenderTexture a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.CubemapFace a3;
			checkEnum(l,3,out a3);
			UnityEngine.Graphics.SetRenderTarget(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderBuffer__RenderBuffer__Int32_s(IntPtr l) {
		try {
			UnityEngine.RenderBuffer a1;
			checkValueType(l,1,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.Graphics.SetRenderTarget(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTexture__Int32__CubemapFace__Int32_s(IntPtr l) {
		try {
			UnityEngine.RenderTexture a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.CubemapFace a3;
			checkEnum(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.SetRenderTarget(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderBuffer__RenderBuffer__Int32__CubemapFace_s(IntPtr l) {
		try {
			UnityEngine.RenderBuffer a1;
			checkValueType(l,1,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.CubemapFace a4;
			checkEnum(l,4,out a4);
			UnityEngine.Graphics.SetRenderTarget(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderBuffer__RenderBuffer__Int32__CubemapFace__Int32_s(IntPtr l) {
		try {
			UnityEngine.RenderBuffer a1;
			checkValueType(l,1,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.CubemapFace a4;
			checkEnum(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Graphics.SetRenderTarget(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRandomWriteTarget__Int32__RenderTexture_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Graphics.SetRandomWriteTarget(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRandomWriteTarget__Int32__ComputeBuffer_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,2,out a2);
			UnityEngine.Graphics.SetRandomWriteTarget(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRandomWriteTarget__Int32__GraphicsBuffer_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,2,out a2);
			UnityEngine.Graphics.SetRandomWriteTarget(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRandomWriteTarget__Int32__ComputeBuffer__Boolean_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			UnityEngine.Graphics.SetRandomWriteTarget(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRandomWriteTarget__Int32__GraphicsBuffer__Boolean_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			UnityEngine.Graphics.SetRandomWriteTarget(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyTexture__Texture__Texture_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			UnityEngine.Graphics.CopyTexture(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyTexture__Texture__Int32__Texture__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Texture a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.CopyTexture(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyTexture__Texture__Int32__Int32__Texture__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.Texture a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.Graphics.CopyTexture(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyTexture__Texture__Int32__Int32__Int32__Int32__Int32__Int32__Texture__Int32__Int32__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.Texture a8;
			checkType(l,8,out a8);
			System.Int32 a9;
			checkType(l,9,out a9);
			System.Int32 a10;
			checkType(l,10,out a10);
			System.Int32 a11;
			checkType(l,11,out a11);
			System.Int32 a12;
			checkType(l,12,out a12);
			UnityEngine.Graphics.CopyTexture(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ConvertTexture__Texture__Texture_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Graphics.ConvertTexture(a1,a2);
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
	static public int ConvertTexture__Texture__Int32__Texture__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Texture a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Graphics.ConvertTexture(a1,a2,a3,a4);
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
	static public int CreateAsyncGraphicsFence_s(IntPtr l) {
		try {
			var ret=UnityEngine.Graphics.CreateAsyncGraphicsFence();
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
	static public int CreateAsyncGraphicsFence__SynchronisationStage_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SynchronisationStage a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Graphics.CreateAsyncGraphicsFence(a1);
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
	static public int CreateGraphicsFence_s(IntPtr l) {
		try {
			UnityEngine.Rendering.GraphicsFenceType a1;
			checkEnum(l,1,out a1);
			UnityEngine.Rendering.SynchronisationStageFlags a2;
			checkEnum(l,2,out a2);
			var ret=UnityEngine.Graphics.CreateGraphicsFence(a1,a2);
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
	static public int WaitOnAsyncGraphicsFence__GraphicsFence_s(IntPtr l) {
		try {
			UnityEngine.Rendering.GraphicsFence a1;
			checkValueType(l,1,out a1);
			UnityEngine.Graphics.WaitOnAsyncGraphicsFence(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WaitOnAsyncGraphicsFence__GraphicsFence__SynchronisationStage_s(IntPtr l) {
		try {
			UnityEngine.Rendering.GraphicsFence a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.SynchronisationStage a2;
			checkEnum(l,2,out a2);
			UnityEngine.Graphics.WaitOnAsyncGraphicsFence(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyBuffer_s(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer a1;
			checkType(l,1,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,2,out a2);
			UnityEngine.Graphics.CopyBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawTexture__Rect__Texture_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			UnityEngine.Graphics.DrawTexture(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawTexture__Rect__Texture__Material_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Graphics.DrawTexture(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawTexture__Rect__Texture__Material__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawTexture__Rect__Texture__Int32__Int32__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawTexture__Rect__Texture__Rect__Int32__Int32__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			UnityEngine.Rect a3;
			checkValueType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawTexture__Rect__Texture__Int32__Int32__Int32__Int32__Material_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.Material a7;
			checkType(l,7,out a7);
			UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawTexture__Rect__Texture__Int32__Int32__Int32__Int32__Material__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.Material a7;
			checkType(l,7,out a7);
			System.Int32 a8;
			checkType(l,8,out a8);
			UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawTexture__Rect__Texture__Rect__Int32__Int32__Int32__Int32__Color_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			UnityEngine.Rect a3;
			checkValueType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.Color a8;
			checkType(l,8,out a8);
			UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawTexture__Rect__Texture__Rect__Int32__Int32__Int32__Int32__Material_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			UnityEngine.Rect a3;
			checkValueType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.Material a8;
			checkType(l,8,out a8);
			UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawTexture__Rect__Texture__Rect__Int32__Int32__Int32__Int32__Material__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			UnityEngine.Rect a3;
			checkValueType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.Material a8;
			checkType(l,8,out a8);
			System.Int32 a9;
			checkType(l,9,out a9);
			UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawTexture__Rect__Texture__Rect__Int32__Int32__Int32__Int32__Color__Material_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			UnityEngine.Rect a3;
			checkValueType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.Color a8;
			checkType(l,8,out a8);
			UnityEngine.Material a9;
			checkType(l,9,out a9);
			UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawTexture__Rect__Texture__Rect__Int32__Int32__Int32__Int32__Color__Material__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			UnityEngine.Rect a3;
			checkValueType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.Color a8;
			checkType(l,8,out a8);
			UnityEngine.Material a9;
			checkType(l,9,out a9);
			System.Int32 a10;
			checkType(l,10,out a10);
			UnityEngine.Graphics.DrawTexture(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RenderMeshIndirect_s(IntPtr l) {
		try {
			UnityEngine.RenderParams a1;
			checkValueType(l,1,out a1);
			UnityEngine.Mesh a2;
			checkType(l,2,out a2);
			UnityEngine.GraphicsBuffer a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Graphics.RenderMeshIndirect(a1,a2,a3,a4,a5);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RenderMeshPrimitives_s(IntPtr l) {
		try {
			UnityEngine.RenderParams a1;
			checkValueType(l,1,out a1);
			UnityEngine.Mesh a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.RenderMeshPrimitives(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RenderPrimitives_s(IntPtr l) {
		try {
			UnityEngine.RenderParams a1;
			checkValueType(l,1,out a1);
			UnityEngine.MeshTopology a2;
			checkEnum(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.RenderPrimitives(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RenderPrimitivesIndexed_s(IntPtr l) {
		try {
			UnityEngine.RenderParams a1;
			checkValueType(l,1,out a1);
			UnityEngine.MeshTopology a2;
			checkEnum(l,2,out a2);
			UnityEngine.GraphicsBuffer a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.Graphics.RenderPrimitivesIndexed(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RenderPrimitivesIndirect_s(IntPtr l) {
		try {
			UnityEngine.RenderParams a1;
			checkValueType(l,1,out a1);
			UnityEngine.MeshTopology a2;
			checkEnum(l,2,out a2);
			UnityEngine.GraphicsBuffer a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Graphics.RenderPrimitivesIndirect(a1,a2,a3,a4,a5);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RenderPrimitivesIndexedIndirect_s(IntPtr l) {
		try {
			UnityEngine.RenderParams a1;
			checkValueType(l,1,out a1);
			UnityEngine.MeshTopology a2;
			checkEnum(l,2,out a2);
			UnityEngine.GraphicsBuffer a3;
			checkType(l,3,out a3);
			UnityEngine.GraphicsBuffer a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.Graphics.RenderPrimitivesIndexedIndirect(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshNow__Mesh__Matrix4x4_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Graphics.DrawMeshNow(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshNow__Mesh__Matrix4x4__Int32_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.Graphics.DrawMeshNow(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshNow__Mesh__Vector3__Quaternion_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Graphics.DrawMeshNow(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshNow__Mesh__Vector3__Quaternion__Int32_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.DrawMeshNow(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Camera a5;
			checkType(l,5,out a5);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Vector3__Quaternion__Material__Int32_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Material a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Camera a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Material a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Camera a6;
			checkType(l,6,out a6);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Material a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Camera a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Camera a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Camera a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			System.Boolean a8;
			checkType(l,8,out a8);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Material a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Camera a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,8,out a8);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Camera a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Rendering.ShadowCastingMode a8;
			checkEnum(l,8,out a8);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__Boolean__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Camera a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			System.Boolean a8;
			checkType(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Material a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Camera a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Camera a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Rendering.ShadowCastingMode a8;
			checkEnum(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Material a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Camera a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,8,out a8);
			UnityEngine.Rendering.ShadowCastingMode a9;
			checkEnum(l,9,out a9);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__Boolean__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Material a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Camera a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			System.Boolean a10;
			checkType(l,10,out a10);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__Boolean__Boolean__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Camera a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			System.Boolean a8;
			checkType(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			System.Boolean a10;
			checkType(l,10,out a10);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Transform_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Camera a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Rendering.ShadowCastingMode a8;
			checkEnum(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			UnityEngine.Transform a10;
			checkType(l,10,out a10);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Material a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Camera a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,8,out a8);
			UnityEngine.Rendering.ShadowCastingMode a9;
			checkEnum(l,9,out a9);
			System.Boolean a10;
			checkType(l,10,out a10);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__Boolean__Boolean__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Material a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Camera a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			System.Boolean a10;
			checkType(l,10,out a10);
			System.Boolean a11;
			checkType(l,11,out a11);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Transform__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Camera a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Rendering.ShadowCastingMode a8;
			checkEnum(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			UnityEngine.Transform a10;
			checkType(l,10,out a10);
			System.Boolean a11;
			checkType(l,11,out a11);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Transform_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Material a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Camera a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,8,out a8);
			UnityEngine.Rendering.ShadowCastingMode a9;
			checkEnum(l,9,out a9);
			System.Boolean a10;
			checkType(l,10,out a10);
			UnityEngine.Transform a11;
			checkType(l,11,out a11);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Transform__LightProbeUsage_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Camera a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Rendering.ShadowCastingMode a8;
			checkEnum(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			UnityEngine.Transform a10;
			checkType(l,10,out a10);
			UnityEngine.Rendering.LightProbeUsage a11;
			checkEnum(l,11,out a11);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Transform__LightProbeUsage__LightProbeProxyVolume_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Camera a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Rendering.ShadowCastingMode a8;
			checkEnum(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			UnityEngine.Transform a10;
			checkType(l,10,out a10);
			UnityEngine.Rendering.LightProbeUsage a11;
			checkEnum(l,11,out a11);
			UnityEngine.LightProbeProxyVolume a12;
			checkType(l,12,out a12);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Transform__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Material a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Camera a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,8,out a8);
			UnityEngine.Rendering.ShadowCastingMode a9;
			checkEnum(l,9,out a9);
			System.Boolean a10;
			checkType(l,10,out a10);
			UnityEngine.Transform a11;
			checkType(l,11,out a11);
			System.Boolean a12;
			checkType(l,12,out a12);
			UnityEngine.Graphics.DrawMesh(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Matrix4x4[] a4;
			checkArray(l,4,out a4);
			UnityEngine.Graphics.DrawMeshInstanced(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Matrix4x4[] a4;
			checkArray(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Graphics.DrawMeshInstanced(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Matrix4x4[] a4;
			checkArray(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.MaterialPropertyBlock a6;
			checkType(l,6,out a6);
			UnityEngine.Graphics.DrawMeshInstanced(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock__ShadowCastingMode_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Matrix4x4[] a4;
			checkArray(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.MaterialPropertyBlock a6;
			checkType(l,6,out a6);
			UnityEngine.Rendering.ShadowCastingMode a7;
			checkEnum(l,7,out a7);
			UnityEngine.Graphics.DrawMeshInstanced(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Matrix4x4[] a4;
			checkArray(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.MaterialPropertyBlock a6;
			checkType(l,6,out a6);
			UnityEngine.Rendering.ShadowCastingMode a7;
			checkEnum(l,7,out a7);
			System.Boolean a8;
			checkType(l,8,out a8);
			UnityEngine.Graphics.DrawMeshInstanced(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Matrix4x4[] a4;
			checkArray(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.MaterialPropertyBlock a6;
			checkType(l,6,out a6);
			UnityEngine.Rendering.ShadowCastingMode a7;
			checkEnum(l,7,out a7);
			System.Boolean a8;
			checkType(l,8,out a8);
			System.Int32 a9;
			checkType(l,9,out a9);
			UnityEngine.Graphics.DrawMeshInstanced(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Matrix4x4[] a4;
			checkArray(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.MaterialPropertyBlock a6;
			checkType(l,6,out a6);
			UnityEngine.Rendering.ShadowCastingMode a7;
			checkEnum(l,7,out a7);
			System.Boolean a8;
			checkType(l,8,out a8);
			System.Int32 a9;
			checkType(l,9,out a9);
			UnityEngine.Camera a10;
			checkType(l,10,out a10);
			UnityEngine.Graphics.DrawMeshInstanced(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera__LightProbeUsage_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Matrix4x4[] a4;
			checkArray(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.MaterialPropertyBlock a6;
			checkType(l,6,out a6);
			UnityEngine.Rendering.ShadowCastingMode a7;
			checkEnum(l,7,out a7);
			System.Boolean a8;
			checkType(l,8,out a8);
			System.Int32 a9;
			checkType(l,9,out a9);
			UnityEngine.Camera a10;
			checkType(l,10,out a10);
			UnityEngine.Rendering.LightProbeUsage a11;
			checkEnum(l,11,out a11);
			UnityEngine.Graphics.DrawMeshInstanced(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera__LightProbeUsage__LightProbeProxyVolume_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Matrix4x4[] a4;
			checkArray(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.MaterialPropertyBlock a6;
			checkType(l,6,out a6);
			UnityEngine.Rendering.ShadowCastingMode a7;
			checkEnum(l,7,out a7);
			System.Boolean a8;
			checkType(l,8,out a8);
			System.Int32 a9;
			checkType(l,9,out a9);
			UnityEngine.Camera a10;
			checkType(l,10,out a10);
			UnityEngine.Rendering.LightProbeUsage a11;
			checkEnum(l,11,out a11);
			UnityEngine.LightProbeProxyVolume a12;
			checkType(l,12,out a12);
			UnityEngine.Graphics.DrawMeshInstanced(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstancedProcedural_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Bounds a4;
			checkValueType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.MaterialPropertyBlock a6;
			checkType(l,6,out a6);
			UnityEngine.Rendering.ShadowCastingMode a7;
			checkEnum(l,7,out a7);
			System.Boolean a8;
			checkType(l,8,out a8);
			System.Int32 a9;
			checkType(l,9,out a9);
			UnityEngine.Camera a10;
			checkType(l,10,out a10);
			UnityEngine.Rendering.LightProbeUsage a11;
			checkEnum(l,11,out a11);
			UnityEngine.LightProbeProxyVolume a12;
			checkType(l,12,out a12);
			UnityEngine.Graphics.DrawMeshInstancedProcedural(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstancedIndirect__Mesh__Int32__Material__Bounds__ComputeBuffer__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera__LightProbeUsage_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Bounds a4;
			checkValueType(l,4,out a4);
			UnityEngine.ComputeBuffer a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Rendering.ShadowCastingMode a8;
			checkEnum(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			System.Int32 a10;
			checkType(l,10,out a10);
			UnityEngine.Camera a11;
			checkType(l,11,out a11);
			UnityEngine.Rendering.LightProbeUsage a12;
			checkEnum(l,12,out a12);
			UnityEngine.Graphics.DrawMeshInstancedIndirect(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstancedIndirect__Mesh__Int32__Material__Bounds__GraphicsBuffer__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera__LightProbeUsage_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Bounds a4;
			checkValueType(l,4,out a4);
			UnityEngine.GraphicsBuffer a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Rendering.ShadowCastingMode a8;
			checkEnum(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			System.Int32 a10;
			checkType(l,10,out a10);
			UnityEngine.Camera a11;
			checkType(l,11,out a11);
			UnityEngine.Rendering.LightProbeUsage a12;
			checkEnum(l,12,out a12);
			UnityEngine.Graphics.DrawMeshInstancedIndirect(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstancedIndirect__Mesh__Int32__Material__Bounds__ComputeBuffer__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera__LightProbeUsage__LightProbeProxyVolume_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Bounds a4;
			checkValueType(l,4,out a4);
			UnityEngine.ComputeBuffer a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Rendering.ShadowCastingMode a8;
			checkEnum(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			System.Int32 a10;
			checkType(l,10,out a10);
			UnityEngine.Camera a11;
			checkType(l,11,out a11);
			UnityEngine.Rendering.LightProbeUsage a12;
			checkEnum(l,12,out a12);
			UnityEngine.LightProbeProxyVolume a13;
			checkType(l,13,out a13);
			UnityEngine.Graphics.DrawMeshInstancedIndirect(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12,a13);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstancedIndirect__Mesh__Int32__Material__Bounds__GraphicsBuffer__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera__LightProbeUsage__LightProbeProxyVolume_s(IntPtr l) {
		try {
			UnityEngine.Mesh a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Bounds a4;
			checkValueType(l,4,out a4);
			UnityEngine.GraphicsBuffer a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Rendering.ShadowCastingMode a8;
			checkEnum(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			System.Int32 a10;
			checkType(l,10,out a10);
			UnityEngine.Camera a11;
			checkType(l,11,out a11);
			UnityEngine.Rendering.LightProbeUsage a12;
			checkEnum(l,12,out a12);
			UnityEngine.LightProbeProxyVolume a13;
			checkType(l,13,out a13);
			UnityEngine.Graphics.DrawMeshInstancedIndirect(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12,a13);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralNow__MeshTopology__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.MeshTopology a1;
			checkEnum(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.Graphics.DrawProceduralNow(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralNow__MeshTopology__GraphicsBuffer__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.MeshTopology a1;
			checkEnum(l,1,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.DrawProceduralNow(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirectNow__MeshTopology__ComputeBuffer__Int32_s(IntPtr l) {
		try {
			UnityEngine.MeshTopology a1;
			checkEnum(l,1,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.Graphics.DrawProceduralIndirectNow(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirectNow__MeshTopology__GraphicsBuffer__Int32_s(IntPtr l) {
		try {
			UnityEngine.MeshTopology a1;
			checkEnum(l,1,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.Graphics.DrawProceduralIndirectNow(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirectNow__MeshTopology__GraphicsBuffer__ComputeBuffer__Int32_s(IntPtr l) {
		try {
			UnityEngine.MeshTopology a1;
			checkEnum(l,1,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,2,out a2);
			UnityEngine.ComputeBuffer a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.DrawProceduralIndirectNow(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirectNow__MeshTopology__GraphicsBuffer__GraphicsBuffer__Int32_s(IntPtr l) {
		try {
			UnityEngine.MeshTopology a1;
			checkEnum(l,1,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,2,out a2);
			UnityEngine.GraphicsBuffer a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.DrawProceduralIndirectNow(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProcedural__Material__Bounds__MeshTopology__Int32__Int32__Camera__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s(IntPtr l) {
		try {
			UnityEngine.Material a1;
			checkType(l,1,out a1);
			UnityEngine.Bounds a2;
			checkValueType(l,2,out a2);
			UnityEngine.MeshTopology a3;
			checkEnum(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Camera a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Rendering.ShadowCastingMode a8;
			checkEnum(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			System.Int32 a10;
			checkType(l,10,out a10);
			UnityEngine.Graphics.DrawProcedural(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProcedural__Material__Bounds__MeshTopology__GraphicsBuffer__Int32__Int32__Camera__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s(IntPtr l) {
		try {
			UnityEngine.Material a1;
			checkType(l,1,out a1);
			UnityEngine.Bounds a2;
			checkValueType(l,2,out a2);
			UnityEngine.MeshTopology a3;
			checkEnum(l,3,out a3);
			UnityEngine.GraphicsBuffer a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.Camera a7;
			checkType(l,7,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,8,out a8);
			UnityEngine.Rendering.ShadowCastingMode a9;
			checkEnum(l,9,out a9);
			System.Boolean a10;
			checkType(l,10,out a10);
			System.Int32 a11;
			checkType(l,11,out a11);
			UnityEngine.Graphics.DrawProcedural(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__Material__Bounds__MeshTopology__ComputeBuffer__Int32__Camera__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s(IntPtr l) {
		try {
			UnityEngine.Material a1;
			checkType(l,1,out a1);
			UnityEngine.Bounds a2;
			checkValueType(l,2,out a2);
			UnityEngine.MeshTopology a3;
			checkEnum(l,3,out a3);
			UnityEngine.ComputeBuffer a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Camera a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Rendering.ShadowCastingMode a8;
			checkEnum(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			System.Int32 a10;
			checkType(l,10,out a10);
			UnityEngine.Graphics.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__Material__Bounds__MeshTopology__GraphicsBuffer__Int32__Camera__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s(IntPtr l) {
		try {
			UnityEngine.Material a1;
			checkType(l,1,out a1);
			UnityEngine.Bounds a2;
			checkValueType(l,2,out a2);
			UnityEngine.MeshTopology a3;
			checkEnum(l,3,out a3);
			UnityEngine.GraphicsBuffer a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Camera a6;
			checkType(l,6,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,7,out a7);
			UnityEngine.Rendering.ShadowCastingMode a8;
			checkEnum(l,8,out a8);
			System.Boolean a9;
			checkType(l,9,out a9);
			System.Int32 a10;
			checkType(l,10,out a10);
			UnityEngine.Graphics.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__Material__Bounds__MeshTopology__GraphicsBuffer__ComputeBuffer__Int32__Camera__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s(IntPtr l) {
		try {
			UnityEngine.Material a1;
			checkType(l,1,out a1);
			UnityEngine.Bounds a2;
			checkValueType(l,2,out a2);
			UnityEngine.MeshTopology a3;
			checkEnum(l,3,out a3);
			UnityEngine.GraphicsBuffer a4;
			checkType(l,4,out a4);
			UnityEngine.ComputeBuffer a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.Camera a7;
			checkType(l,7,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,8,out a8);
			UnityEngine.Rendering.ShadowCastingMode a9;
			checkEnum(l,9,out a9);
			System.Boolean a10;
			checkType(l,10,out a10);
			System.Int32 a11;
			checkType(l,11,out a11);
			UnityEngine.Graphics.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__Material__Bounds__MeshTopology__GraphicsBuffer__GraphicsBuffer__Int32__Camera__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s(IntPtr l) {
		try {
			UnityEngine.Material a1;
			checkType(l,1,out a1);
			UnityEngine.Bounds a2;
			checkValueType(l,2,out a2);
			UnityEngine.MeshTopology a3;
			checkEnum(l,3,out a3);
			UnityEngine.GraphicsBuffer a4;
			checkType(l,4,out a4);
			UnityEngine.GraphicsBuffer a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.Camera a7;
			checkType(l,7,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,8,out a8);
			UnityEngine.Rendering.ShadowCastingMode a9;
			checkEnum(l,9,out a9);
			System.Boolean a10;
			checkType(l,10,out a10);
			System.Int32 a11;
			checkType(l,11,out a11);
			UnityEngine.Graphics.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__RenderTexture_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Graphics.Blit(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__Material_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.Material a2;
			checkType(l,2,out a2);
			UnityEngine.Graphics.Blit(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__RenderTexture__Material_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Graphics.Blit(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__Material__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.Material a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.Graphics.Blit(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__RenderTexture__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.Blit(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__RenderTexture__Vector2__Vector2_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			UnityEngine.Vector2 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.Blit(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__RenderTexture__Material__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.Blit(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__Material__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.Material a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Graphics.Blit(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__RenderTexture__Material__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.Graphics.Blit(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__RenderTexture__Vector2__Vector2__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			UnityEngine.Vector2 a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.Graphics.Blit(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BlitMultiTap__Texture__RenderTexture__Material__A_Vector2_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			UnityEngine.Vector2[] a4;
			checkParams(l,4,out a4);
			UnityEngine.Graphics.BlitMultiTap(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BlitMultiTap__Texture__RenderTexture__Material__Int32__A_Vector2_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Material a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Vector2[] a5;
			checkParams(l,5,out a5);
			UnityEngine.Graphics.BlitMultiTap(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_activeColorGamut(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.Graphics.activeColorGamut);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_activeTier(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.Graphics.activeTier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_activeTier(IntPtr l) {
		try {
			UnityEngine.Rendering.GraphicsTier v;
			checkEnum(l,2,out v);
			UnityEngine.Graphics.activeTier=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_preserveFramebufferAlpha(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Graphics.preserveFramebufferAlpha);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_minOpenGLESVersion(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.Graphics.minOpenGLESVersion);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_activeColorBuffer(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Graphics.activeColorBuffer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_activeDepthBuffer(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Graphics.activeDepthBuffer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Graphics");
		addMember(l,ctor_s);
		addMember(l,ClearRandomWriteTargets_s);
		addMember(l,ExecuteCommandBuffer_s);
		addMember(l,ExecuteCommandBufferAsync_s);
		addMember(l,SetRenderTarget__RenderTargetSetup_s);
		addMember(l,SetRenderTarget__RenderTexture_s);
		addMember(l,SetRenderTarget__A_RenderBuffer__RenderBuffer_s);
		addMember(l,SetRenderTarget__RenderTexture__Int32_s);
		addMember(l,SetRenderTarget__RenderBuffer__RenderBuffer_s);
		addMember(l,SetRenderTarget__RenderTexture__Int32__CubemapFace_s);
		addMember(l,SetRenderTarget__RenderBuffer__RenderBuffer__Int32_s);
		addMember(l,SetRenderTarget__RenderTexture__Int32__CubemapFace__Int32_s);
		addMember(l,SetRenderTarget__RenderBuffer__RenderBuffer__Int32__CubemapFace_s);
		addMember(l,SetRenderTarget__RenderBuffer__RenderBuffer__Int32__CubemapFace__Int32_s);
		addMember(l,SetRandomWriteTarget__Int32__RenderTexture_s);
		addMember(l,SetRandomWriteTarget__Int32__ComputeBuffer_s);
		addMember(l,SetRandomWriteTarget__Int32__GraphicsBuffer_s);
		addMember(l,SetRandomWriteTarget__Int32__ComputeBuffer__Boolean_s);
		addMember(l,SetRandomWriteTarget__Int32__GraphicsBuffer__Boolean_s);
		addMember(l,CopyTexture__Texture__Texture_s);
		addMember(l,CopyTexture__Texture__Int32__Texture__Int32_s);
		addMember(l,CopyTexture__Texture__Int32__Int32__Texture__Int32__Int32_s);
		addMember(l,CopyTexture__Texture__Int32__Int32__Int32__Int32__Int32__Int32__Texture__Int32__Int32__Int32__Int32_s);
		addMember(l,ConvertTexture__Texture__Texture_s);
		addMember(l,ConvertTexture__Texture__Int32__Texture__Int32_s);
		addMember(l,CreateAsyncGraphicsFence_s);
		addMember(l,CreateAsyncGraphicsFence__SynchronisationStage_s);
		addMember(l,CreateGraphicsFence_s);
		addMember(l,WaitOnAsyncGraphicsFence__GraphicsFence_s);
		addMember(l,WaitOnAsyncGraphicsFence__GraphicsFence__SynchronisationStage_s);
		addMember(l,CopyBuffer_s);
		addMember(l,DrawTexture__Rect__Texture_s);
		addMember(l,DrawTexture__Rect__Texture__Material_s);
		addMember(l,DrawTexture__Rect__Texture__Material__Int32_s);
		addMember(l,DrawTexture__Rect__Texture__Int32__Int32__Int32__Int32_s);
		addMember(l,DrawTexture__Rect__Texture__Rect__Int32__Int32__Int32__Int32_s);
		addMember(l,DrawTexture__Rect__Texture__Int32__Int32__Int32__Int32__Material_s);
		addMember(l,DrawTexture__Rect__Texture__Int32__Int32__Int32__Int32__Material__Int32_s);
		addMember(l,DrawTexture__Rect__Texture__Rect__Int32__Int32__Int32__Int32__Color_s);
		addMember(l,DrawTexture__Rect__Texture__Rect__Int32__Int32__Int32__Int32__Material_s);
		addMember(l,DrawTexture__Rect__Texture__Rect__Int32__Int32__Int32__Int32__Material__Int32_s);
		addMember(l,DrawTexture__Rect__Texture__Rect__Int32__Int32__Int32__Int32__Color__Material_s);
		addMember(l,DrawTexture__Rect__Texture__Rect__Int32__Int32__Int32__Int32__Color__Material__Int32_s);
		addMember(l,RenderMeshIndirect_s);
		addMember(l,RenderMeshPrimitives_s);
		addMember(l,RenderPrimitives_s);
		addMember(l,RenderPrimitivesIndexed_s);
		addMember(l,RenderPrimitivesIndirect_s);
		addMember(l,RenderPrimitivesIndexedIndirect_s);
		addMember(l,DrawMeshNow__Mesh__Matrix4x4_s);
		addMember(l,DrawMeshNow__Mesh__Matrix4x4__Int32_s);
		addMember(l,DrawMeshNow__Mesh__Vector3__Quaternion_s);
		addMember(l,DrawMeshNow__Mesh__Vector3__Quaternion__Int32_s);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32_s);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera_s);
		addMember(l,DrawMesh__Mesh__Vector3__Quaternion__Material__Int32_s);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32_s);
		addMember(l,DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera_s);
		addMember(l,DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32_s);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock_s);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__Boolean_s);
		addMember(l,DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock_s);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode_s);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__Boolean__Boolean_s);
		addMember(l,DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__Boolean_s);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean_s);
		addMember(l,DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode_s);
		addMember(l,DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__Boolean__Boolean_s);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__Boolean__Boolean__Boolean_s);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Transform_s);
		addMember(l,DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean_s);
		addMember(l,DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__Boolean__Boolean__Boolean_s);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Transform__Boolean_s);
		addMember(l,DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Transform_s);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Transform__LightProbeUsage_s);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Transform__LightProbeUsage__LightProbeProxyVolume_s);
		addMember(l,DrawMesh__Mesh__Vector3__Quaternion__Material__Int32__Camera__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Transform__Boolean_s);
		addMember(l,DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4_s);
		addMember(l,DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32_s);
		addMember(l,DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock_s);
		addMember(l,DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock__ShadowCastingMode_s);
		addMember(l,DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean_s);
		addMember(l,DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s);
		addMember(l,DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera_s);
		addMember(l,DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera__LightProbeUsage_s);
		addMember(l,DrawMeshInstanced__Mesh__Int32__Material__A_Matrix4x4__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera__LightProbeUsage__LightProbeProxyVolume_s);
		addMember(l,DrawMeshInstancedProcedural_s);
		addMember(l,DrawMeshInstancedIndirect__Mesh__Int32__Material__Bounds__ComputeBuffer__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera__LightProbeUsage_s);
		addMember(l,DrawMeshInstancedIndirect__Mesh__Int32__Material__Bounds__GraphicsBuffer__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera__LightProbeUsage_s);
		addMember(l,DrawMeshInstancedIndirect__Mesh__Int32__Material__Bounds__ComputeBuffer__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera__LightProbeUsage__LightProbeProxyVolume_s);
		addMember(l,DrawMeshInstancedIndirect__Mesh__Int32__Material__Bounds__GraphicsBuffer__Int32__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32__Camera__LightProbeUsage__LightProbeProxyVolume_s);
		addMember(l,DrawProceduralNow__MeshTopology__Int32__Int32_s);
		addMember(l,DrawProceduralNow__MeshTopology__GraphicsBuffer__Int32__Int32_s);
		addMember(l,DrawProceduralIndirectNow__MeshTopology__ComputeBuffer__Int32_s);
		addMember(l,DrawProceduralIndirectNow__MeshTopology__GraphicsBuffer__Int32_s);
		addMember(l,DrawProceduralIndirectNow__MeshTopology__GraphicsBuffer__ComputeBuffer__Int32_s);
		addMember(l,DrawProceduralIndirectNow__MeshTopology__GraphicsBuffer__GraphicsBuffer__Int32_s);
		addMember(l,DrawProcedural__Material__Bounds__MeshTopology__Int32__Int32__Camera__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s);
		addMember(l,DrawProcedural__Material__Bounds__MeshTopology__GraphicsBuffer__Int32__Int32__Camera__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s);
		addMember(l,DrawProceduralIndirect__Material__Bounds__MeshTopology__ComputeBuffer__Int32__Camera__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s);
		addMember(l,DrawProceduralIndirect__Material__Bounds__MeshTopology__GraphicsBuffer__Int32__Camera__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s);
		addMember(l,DrawProceduralIndirect__Material__Bounds__MeshTopology__GraphicsBuffer__ComputeBuffer__Int32__Camera__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s);
		addMember(l,DrawProceduralIndirect__Material__Bounds__MeshTopology__GraphicsBuffer__GraphicsBuffer__Int32__Camera__MaterialPropertyBlock__ShadowCastingMode__Boolean__Int32_s);
		addMember(l,Blit__Texture__RenderTexture_s);
		addMember(l,Blit__Texture__Material_s);
		addMember(l,Blit__Texture__RenderTexture__Material_s);
		addMember(l,Blit__Texture__Material__Int32_s);
		addMember(l,Blit__Texture__RenderTexture__Int32__Int32_s);
		addMember(l,Blit__Texture__RenderTexture__Vector2__Vector2_s);
		addMember(l,Blit__Texture__RenderTexture__Material__Int32_s);
		addMember(l,Blit__Texture__Material__Int32__Int32_s);
		addMember(l,Blit__Texture__RenderTexture__Material__Int32__Int32_s);
		addMember(l,Blit__Texture__RenderTexture__Vector2__Vector2__Int32__Int32_s);
		addMember(l,BlitMultiTap__Texture__RenderTexture__Material__A_Vector2_s);
		addMember(l,BlitMultiTap__Texture__RenderTexture__Material__Int32__A_Vector2_s);
		addMember(l,"activeColorGamut",get_activeColorGamut,null,false);
		addMember(l,"activeTier",get_activeTier,set_activeTier,false);
		addMember(l,"preserveFramebufferAlpha",get_preserveFramebufferAlpha,null,false);
		addMember(l,"minOpenGLESVersion",get_minOpenGLESVersion,null,false);
		addMember(l,"activeColorBuffer",get_activeColorBuffer,null,false);
		addMember(l,"activeDepthBuffer",get_activeDepthBuffer,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Graphics));
	}
}
