using System;
using SLua;
using System.Collections.Generic;
using UnityEngine.Rendering;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_CommandBuffer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer o;
			o=new UnityEngine.Rendering.CommandBuffer();
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
	static public int ConvertTexture__RenderTargetIdentifier__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			self.ConvertTexture(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ConvertTexture__RenderTargetIdentifier__Int32__RenderTargetIdentifier__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Rendering.RenderTargetIdentifier a3;
			checkValueType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.ConvertTexture(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WaitAllAsyncReadbackRequests(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			self.WaitAllAsyncReadbackRequests();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetInvertCulling(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.SetInvertCulling(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeFloatParam__ComputeShader__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.SetComputeFloatParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeFloatParam__ComputeShader__String__Single(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.SetComputeFloatParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeIntParam__ComputeShader__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.SetComputeIntParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeIntParam__ComputeShader__String__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.SetComputeIntParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeVectorParam__ComputeShader__Int32__Vector4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Vector4 a3;
			checkType(l,4,out a3);
			self.SetComputeVectorParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeVectorParam__ComputeShader__String__Vector4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.Vector4 a3;
			checkType(l,4,out a3);
			self.SetComputeVectorParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeVectorArrayParam__ComputeShader__Int32__A_Vector4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Vector4[] a3;
			checkArray(l,4,out a3);
			self.SetComputeVectorArrayParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeVectorArrayParam__ComputeShader__String__A_Vector4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.Vector4[] a3;
			checkArray(l,4,out a3);
			self.SetComputeVectorArrayParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeMatrixParam__ComputeShader__Int32__Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Matrix4x4 a3;
			checkValueType(l,4,out a3);
			self.SetComputeMatrixParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeMatrixParam__ComputeShader__String__Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.Matrix4x4 a3;
			checkValueType(l,4,out a3);
			self.SetComputeMatrixParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeMatrixArrayParam__ComputeShader__Int32__A_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Matrix4x4[] a3;
			checkArray(l,4,out a3);
			self.SetComputeMatrixArrayParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeMatrixArrayParam__ComputeShader__String__A_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.Matrix4x4[] a3;
			checkArray(l,4,out a3);
			self.SetComputeMatrixArrayParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingShaderPass(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.SetRayTracingShaderPass(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Clear(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			self.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearRandomWriteTargets(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			self.ClearRandomWriteTargets();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetViewport(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			self.SetViewport(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EnableScissorRect(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			self.EnableScissorRect(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DisableScissorRect(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			self.DisableScissorRect();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__RenderTextureDescriptor(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.RenderTextureDescriptor a2;
			checkValueType(l,3,out a2);
			self.GetTemporaryRT(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.GetTemporaryRT(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__RenderTextureDescriptor__FilterMode(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.RenderTextureDescriptor a2;
			checkValueType(l,3,out a2);
			UnityEngine.FilterMode a3;
			checkEnum(l,4,out a3);
			self.GetTemporaryRT(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.GetTemporaryRT(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.FilterMode a5;
			checkEnum(l,6,out a5);
			self.GetTemporaryRT(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.FilterMode a5;
			checkEnum(l,6,out a5);
			UnityEngine.Experimental.Rendering.GraphicsFormat a6;
			checkEnum(l,7,out a6);
			self.GetTemporaryRT(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.FilterMode a5;
			checkEnum(l,6,out a5);
			UnityEngine.RenderTextureFormat a6;
			checkEnum(l,7,out a6);
			self.GetTemporaryRT(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.FilterMode a5;
			checkEnum(l,6,out a5);
			UnityEngine.Experimental.Rendering.GraphicsFormat a6;
			checkEnum(l,7,out a6);
			System.Int32 a7;
			checkType(l,8,out a7);
			self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.FilterMode a5;
			checkEnum(l,6,out a5);
			UnityEngine.RenderTextureFormat a6;
			checkEnum(l,7,out a6);
			UnityEngine.RenderTextureReadWrite a7;
			checkEnum(l,8,out a7);
			self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.FilterMode a5;
			checkEnum(l,6,out a5);
			UnityEngine.Experimental.Rendering.GraphicsFormat a6;
			checkEnum(l,7,out a6);
			System.Int32 a7;
			checkType(l,8,out a7);
			System.Boolean a8;
			checkType(l,9,out a8);
			self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.FilterMode a5;
			checkEnum(l,6,out a5);
			UnityEngine.RenderTextureFormat a6;
			checkEnum(l,7,out a6);
			UnityEngine.RenderTextureReadWrite a7;
			checkEnum(l,8,out a7);
			System.Int32 a8;
			checkType(l,9,out a8);
			self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32__Boolean__RenderTextureMemoryless(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.FilterMode a5;
			checkEnum(l,6,out a5);
			UnityEngine.Experimental.Rendering.GraphicsFormat a6;
			checkEnum(l,7,out a6);
			System.Int32 a7;
			checkType(l,8,out a7);
			System.Boolean a8;
			checkType(l,9,out a8);
			UnityEngine.RenderTextureMemoryless a9;
			checkEnum(l,10,out a9);
			self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.FilterMode a5;
			checkEnum(l,6,out a5);
			UnityEngine.RenderTextureFormat a6;
			checkEnum(l,7,out a6);
			UnityEngine.RenderTextureReadWrite a7;
			checkEnum(l,8,out a7);
			System.Int32 a8;
			checkType(l,9,out a8);
			System.Boolean a9;
			checkType(l,10,out a9);
			self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32__Boolean__RenderTextureMemoryless__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.FilterMode a5;
			checkEnum(l,6,out a5);
			UnityEngine.Experimental.Rendering.GraphicsFormat a6;
			checkEnum(l,7,out a6);
			System.Int32 a7;
			checkType(l,8,out a7);
			System.Boolean a8;
			checkType(l,9,out a8);
			UnityEngine.RenderTextureMemoryless a9;
			checkEnum(l,10,out a9);
			System.Boolean a10;
			checkType(l,11,out a10);
			self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite__Int32__Boolean__RenderTextureMemoryless(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.FilterMode a5;
			checkEnum(l,6,out a5);
			UnityEngine.RenderTextureFormat a6;
			checkEnum(l,7,out a6);
			UnityEngine.RenderTextureReadWrite a7;
			checkEnum(l,8,out a7);
			System.Int32 a8;
			checkType(l,9,out a8);
			System.Boolean a9;
			checkType(l,10,out a9);
			UnityEngine.RenderTextureMemoryless a10;
			checkEnum(l,11,out a10);
			self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite__Int32__Boolean__RenderTextureMemoryless__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.FilterMode a5;
			checkEnum(l,6,out a5);
			UnityEngine.RenderTextureFormat a6;
			checkEnum(l,7,out a6);
			UnityEngine.RenderTextureReadWrite a7;
			checkEnum(l,8,out a7);
			System.Int32 a8;
			checkType(l,9,out a8);
			System.Boolean a9;
			checkType(l,10,out a9);
			UnityEngine.RenderTextureMemoryless a10;
			checkEnum(l,11,out a10);
			System.Boolean a11;
			checkType(l,12,out a11);
			self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRTArray__Int32__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.GetTemporaryRTArray(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.GetTemporaryRTArray(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			UnityEngine.FilterMode a6;
			checkEnum(l,7,out a6);
			self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			UnityEngine.FilterMode a6;
			checkEnum(l,7,out a6);
			UnityEngine.Experimental.Rendering.GraphicsFormat a7;
			checkEnum(l,8,out a7);
			self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			UnityEngine.FilterMode a6;
			checkEnum(l,7,out a6);
			UnityEngine.RenderTextureFormat a7;
			checkEnum(l,8,out a7);
			self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			UnityEngine.FilterMode a6;
			checkEnum(l,7,out a6);
			UnityEngine.Experimental.Rendering.GraphicsFormat a7;
			checkEnum(l,8,out a7);
			System.Int32 a8;
			checkType(l,9,out a8);
			self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			UnityEngine.FilterMode a6;
			checkEnum(l,7,out a6);
			UnityEngine.RenderTextureFormat a7;
			checkEnum(l,8,out a7);
			UnityEngine.RenderTextureReadWrite a8;
			checkEnum(l,9,out a8);
			self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			UnityEngine.FilterMode a6;
			checkEnum(l,7,out a6);
			UnityEngine.Experimental.Rendering.GraphicsFormat a7;
			checkEnum(l,8,out a7);
			System.Int32 a8;
			checkType(l,9,out a8);
			System.Boolean a9;
			checkType(l,10,out a9);
			self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			UnityEngine.FilterMode a6;
			checkEnum(l,7,out a6);
			UnityEngine.RenderTextureFormat a7;
			checkEnum(l,8,out a7);
			UnityEngine.RenderTextureReadWrite a8;
			checkEnum(l,9,out a8);
			System.Int32 a9;
			checkType(l,10,out a9);
			self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32__Boolean__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			UnityEngine.FilterMode a6;
			checkEnum(l,7,out a6);
			UnityEngine.Experimental.Rendering.GraphicsFormat a7;
			checkEnum(l,8,out a7);
			System.Int32 a8;
			checkType(l,9,out a8);
			System.Boolean a9;
			checkType(l,10,out a9);
			System.Boolean a10;
			checkType(l,11,out a10);
			self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			UnityEngine.FilterMode a6;
			checkEnum(l,7,out a6);
			UnityEngine.RenderTextureFormat a7;
			checkEnum(l,8,out a7);
			UnityEngine.RenderTextureReadWrite a8;
			checkEnum(l,9,out a8);
			System.Int32 a9;
			checkType(l,10,out a9);
			System.Boolean a10;
			checkType(l,11,out a10);
			self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReleaseTemporaryRT(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.ReleaseTemporaryRT(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearRenderTarget__Boolean__Boolean__Color(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			UnityEngine.Color a3;
			checkType(l,4,out a3);
			self.ClearRenderTarget(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearRenderTarget__RTClearFlags__Color__Single__UInt32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RTClearFlags a1;
			checkEnum(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			System.UInt32 a4;
			checkType(l,5,out a4);
			self.ClearRenderTarget(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearRenderTarget__Boolean__Boolean__Color__Single(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			UnityEngine.Color a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			self.ClearRenderTarget(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalFloat__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetGlobalFloat(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalFloat__String__Single(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetGlobalFloat(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalInt__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetGlobalInt(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalInt__String__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetGlobalInt(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalInteger__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetGlobalInteger(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalInteger__String__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetGlobalInteger(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalVector__Int32__Vector4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,3,out a2);
			self.SetGlobalVector(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalVector__String__Vector4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,3,out a2);
			self.SetGlobalVector(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalColor__Int32__Color(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			self.SetGlobalColor(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalColor__String__Color(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			self.SetGlobalColor(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalMatrix__Int32__Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			self.SetGlobalMatrix(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalMatrix__String__Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			self.SetGlobalMatrix(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EnableShaderKeyword(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.EnableShaderKeyword(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EnableKeyword__R_GlobalKeyword(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.GlobalKeyword a1;
			checkValueType(l,2,out a1);
			self.EnableKeyword(a1);
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
	static public int EnableKeyword__Material__R_LocalKeyword(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.LocalKeyword a2;
			checkValueType(l,3,out a2);
			self.EnableKeyword(a1,a2);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EnableKeyword__ComputeShader__R_LocalKeyword(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.LocalKeyword a2;
			checkValueType(l,3,out a2);
			self.EnableKeyword(a1,a2);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DisableShaderKeyword(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.DisableShaderKeyword(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DisableKeyword__R_GlobalKeyword(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.GlobalKeyword a1;
			checkValueType(l,2,out a1);
			self.DisableKeyword(a1);
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
	static public int DisableKeyword__Material__R_LocalKeyword(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.LocalKeyword a2;
			checkValueType(l,3,out a2);
			self.DisableKeyword(a1,a2);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DisableKeyword__ComputeShader__R_LocalKeyword(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.LocalKeyword a2;
			checkValueType(l,3,out a2);
			self.DisableKeyword(a1,a2);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetKeyword__R_GlobalKeyword__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.GlobalKeyword a1;
			checkValueType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetKeyword(a1,a2);
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
	static public int SetKeyword__Material__R_LocalKeyword__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.LocalKeyword a2;
			checkValueType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.SetKeyword(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetKeyword__ComputeShader__R_LocalKeyword__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.LocalKeyword a2;
			checkValueType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.SetKeyword(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetViewMatrix(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,2,out a1);
			self.SetViewMatrix(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetProjectionMatrix(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,2,out a1);
			self.SetProjectionMatrix(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetViewProjectionMatrices(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			self.SetViewProjectionMatrices(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalDepthBias(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetGlobalDepthBias(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetExecutionFlags(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.CommandBufferExecutionFlags a1;
			checkEnum(l,2,out a1);
			self.SetExecutionFlags(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalFloatArray__Int32__A_Single(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single[] a2;
			checkArray(l,3,out a2);
			self.SetGlobalFloatArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalFloatArray__String__A_Single(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single[] a2;
			checkArray(l,3,out a2);
			self.SetGlobalFloatArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalVectorArray__Int32__A_Vector4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4[] a2;
			checkArray(l,3,out a2);
			self.SetGlobalVectorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalVectorArray__String__A_Vector4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4[] a2;
			checkArray(l,3,out a2);
			self.SetGlobalVectorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalMatrixArray__Int32__A_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4[] a2;
			checkArray(l,3,out a2);
			self.SetGlobalMatrixArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalMatrixArray__String__A_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4[] a2;
			checkArray(l,3,out a2);
			self.SetGlobalMatrixArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetLateLatchProjectionMatrices(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Matrix4x4[] a1;
			checkArray(l,2,out a1);
			self.SetLateLatchProjectionMatrices(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int MarkLateLatchMatrixShaderPropertyID(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.CameraLateLatchMatrixType a1;
			checkEnum(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.MarkLateLatchMatrixShaderPropertyID(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UnmarkLateLatchMatrix(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.CameraLateLatchMatrixType a1;
			checkEnum(l,2,out a1);
			self.UnmarkLateLatchMatrix(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BeginSample__String(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.BeginSample(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BeginSample__CustomSampler(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Profiling.CustomSampler a1;
			checkType(l,2,out a1);
			self.BeginSample(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EndSample__String(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.EndSample(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EndSample__CustomSampler(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Profiling.CustomSampler a1;
			checkType(l,2,out a1);
			self.EndSample(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IncrementUpdateCount(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			self.IncrementUpdateCount(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetInstanceMultiplier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.UInt32 a1;
			checkType(l,2,out a1);
			self.SetInstanceMultiplier(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			self.SetRenderTarget(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetBinding(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetBinding a1;
			checkValueType(l,2,out a1);
			self.SetRenderTarget(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetIdentifier__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetRenderTarget(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetIdentifier__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			self.SetRenderTarget(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__A_RenderTargetIdentifier__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier[] a1;
			checkArray(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			self.SetRenderTarget(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderBufferLoadAction a2;
			checkEnum(l,3,out a2);
			UnityEngine.Rendering.RenderBufferStoreAction a3;
			checkEnum(l,4,out a3);
			self.SetRenderTarget(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetIdentifier__Int32__CubemapFace(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.CubemapFace a3;
			checkEnum(l,4,out a3);
			self.SetRenderTarget(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetIdentifier__RenderTargetIdentifier__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.SetRenderTarget(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetIdentifier__Int32__CubemapFace__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.CubemapFace a3;
			checkEnum(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetRenderTarget(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetIdentifier__RenderTargetIdentifier__Int32__CubemapFace(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.CubemapFace a4;
			checkEnum(l,5,out a4);
			self.SetRenderTarget(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetBinding__Int32__CubemapFace__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetBinding a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.CubemapFace a3;
			checkEnum(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetRenderTarget(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction__RenderBufferLoadAction__RenderBufferStoreAction(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderBufferLoadAction a2;
			checkEnum(l,3,out a2);
			UnityEngine.Rendering.RenderBufferStoreAction a3;
			checkEnum(l,4,out a3);
			UnityEngine.Rendering.RenderBufferLoadAction a4;
			checkEnum(l,5,out a4);
			UnityEngine.Rendering.RenderBufferStoreAction a5;
			checkEnum(l,6,out a5);
			self.SetRenderTarget(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetIdentifier__RenderTargetIdentifier__Int32__CubemapFace__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.CubemapFace a4;
			checkEnum(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetRenderTarget(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__A_RenderTargetIdentifier__RenderTargetIdentifier__Int32__CubemapFace__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier[] a1;
			checkArray(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.CubemapFace a4;
			checkEnum(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetRenderTarget(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderTarget__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderBufferLoadAction a2;
			checkEnum(l,3,out a2);
			UnityEngine.Rendering.RenderBufferStoreAction a3;
			checkEnum(l,4,out a3);
			UnityEngine.Rendering.RenderTargetIdentifier a4;
			checkValueType(l,5,out a4);
			UnityEngine.Rendering.RenderBufferLoadAction a5;
			checkEnum(l,6,out a5);
			UnityEngine.Rendering.RenderBufferStoreAction a6;
			checkEnum(l,7,out a6);
			self.SetRenderTarget(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBufferData__ComputeBuffer__Array(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeBuffer a1;
			checkType(l,2,out a1);
			System.Array a2;
			checkType(l,3,out a2);
			self.SetBufferData(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBufferData__GraphicsBuffer__Array(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			System.Array a2;
			checkType(l,3,out a2);
			self.SetBufferData(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBufferData__ComputeBuffer__Array__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeBuffer a1;
			checkType(l,2,out a1);
			System.Array a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetBufferData(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBufferData__GraphicsBuffer__Array__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			System.Array a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetBufferData(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBufferCounterValue__ComputeBuffer__UInt32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeBuffer a1;
			checkType(l,2,out a1);
			System.UInt32 a2;
			checkType(l,3,out a2);
			self.SetBufferCounterValue(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBufferCounterValue__GraphicsBuffer__UInt32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			System.UInt32 a2;
			checkType(l,3,out a2);
			self.SetBufferCounterValue(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Dispose(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Release(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			self.Release();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateAsyncGraphicsFence(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			var ret=self.CreateAsyncGraphicsFence();
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
	static public int CreateAsyncGraphicsFence__SynchronisationStage(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.SynchronisationStage a1;
			checkEnum(l,2,out a1);
			var ret=self.CreateAsyncGraphicsFence(a1);
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
	static public int CreateGraphicsFence(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.GraphicsFenceType a1;
			checkEnum(l,2,out a1);
			UnityEngine.Rendering.SynchronisationStageFlags a2;
			checkEnum(l,3,out a2);
			var ret=self.CreateGraphicsFence(a1,a2);
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
	static public int WaitOnAsyncGraphicsFence__GraphicsFence(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.GraphicsFence a1;
			checkValueType(l,2,out a1);
			self.WaitOnAsyncGraphicsFence(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WaitOnAsyncGraphicsFence__GraphicsFence__SynchronisationStage(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.GraphicsFence a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.SynchronisationStage a2;
			checkEnum(l,3,out a2);
			self.WaitOnAsyncGraphicsFence(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WaitOnAsyncGraphicsFence__GraphicsFence__SynchronisationStageFlags(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.GraphicsFence a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.SynchronisationStageFlags a2;
			checkEnum(l,3,out a2);
			self.WaitOnAsyncGraphicsFence(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeFloatParams__ComputeShader__String__A_Single(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Single[] a3;
			checkParams(l,4,out a3);
			self.SetComputeFloatParams(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeFloatParams__ComputeShader__Int32__A_Single(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Single[] a3;
			checkParams(l,4,out a3);
			self.SetComputeFloatParams(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeIntParams__ComputeShader__String__A_Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Int32[] a3;
			checkParams(l,4,out a3);
			self.SetComputeIntParams(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeIntParams__ComputeShader__Int32__A_Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32[] a3;
			checkParams(l,4,out a3);
			self.SetComputeIntParams(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeTextureParam__ComputeShader__Int32__String__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.String a3;
			checkType(l,4,out a3);
			UnityEngine.Rendering.RenderTargetIdentifier a4;
			checkValueType(l,5,out a4);
			self.SetComputeTextureParam(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeTextureParam__ComputeShader__Int32__Int32__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Rendering.RenderTargetIdentifier a4;
			checkValueType(l,5,out a4);
			self.SetComputeTextureParam(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeTextureParam__ComputeShader__Int32__String__RenderTargetIdentifier__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.String a3;
			checkType(l,4,out a3);
			UnityEngine.Rendering.RenderTargetIdentifier a4;
			checkValueType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetComputeTextureParam(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeTextureParam__ComputeShader__Int32__Int32__RenderTargetIdentifier__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Rendering.RenderTargetIdentifier a4;
			checkValueType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetComputeTextureParam(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeTextureParam__ComputeShader__Int32__String__RenderTargetIdentifier__Int32__RenderTextureSubElement(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.String a3;
			checkType(l,4,out a3);
			UnityEngine.Rendering.RenderTargetIdentifier a4;
			checkValueType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			UnityEngine.Rendering.RenderTextureSubElement a6;
			checkEnum(l,7,out a6);
			self.SetComputeTextureParam(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeTextureParam__ComputeShader__Int32__Int32__RenderTargetIdentifier__Int32__RenderTextureSubElement(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Rendering.RenderTargetIdentifier a4;
			checkValueType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			UnityEngine.Rendering.RenderTextureSubElement a6;
			checkEnum(l,7,out a6);
			self.SetComputeTextureParam(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeBufferParam__ComputeShader__Int32__Int32__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.ComputeBuffer a4;
			checkType(l,5,out a4);
			self.SetComputeBufferParam(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeBufferParam__ComputeShader__Int32__String__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.String a3;
			checkType(l,4,out a3);
			UnityEngine.ComputeBuffer a4;
			checkType(l,5,out a4);
			self.SetComputeBufferParam(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeBufferParam__ComputeShader__Int32__Int32__GraphicsBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.GraphicsBuffer a4;
			checkType(l,5,out a4);
			self.SetComputeBufferParam(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeBufferParam__ComputeShader__Int32__String__GraphicsBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.String a3;
			checkType(l,4,out a3);
			UnityEngine.GraphicsBuffer a4;
			checkType(l,5,out a4);
			self.SetComputeBufferParam(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeConstantBufferParam__ComputeShader__Int32__ComputeBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.ComputeBuffer a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetComputeConstantBufferParam(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeConstantBufferParam__ComputeShader__String__ComputeBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.ComputeBuffer a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetComputeConstantBufferParam(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeConstantBufferParam__ComputeShader__Int32__GraphicsBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.GraphicsBuffer a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetComputeConstantBufferParam(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeConstantBufferParam__ComputeShader__String__GraphicsBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.GraphicsBuffer a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetComputeConstantBufferParam(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DispatchCompute__ComputeShader__Int32__ComputeBuffer__UInt32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.ComputeBuffer a3;
			checkType(l,4,out a3);
			System.UInt32 a4;
			checkType(l,5,out a4);
			self.DispatchCompute(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DispatchCompute__ComputeShader__Int32__GraphicsBuffer__UInt32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.GraphicsBuffer a3;
			checkType(l,4,out a3);
			System.UInt32 a4;
			checkType(l,5,out a4);
			self.DispatchCompute(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DispatchCompute__ComputeShader__Int32__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.DispatchCompute(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BuildRayTracingAccelerationStructure__RayTracingAccelerationStructure(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure a1;
			checkType(l,2,out a1);
			self.BuildRayTracingAccelerationStructure(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BuildRayTracingAccelerationStructure__RayTracingAccelerationStructure__Vector3(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.BuildRayTracingAccelerationStructure(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingAccelerationStructure__RayTracingShader__String__RayTracingAccelerationStructure(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure a3;
			checkType(l,4,out a3);
			self.SetRayTracingAccelerationStructure(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingAccelerationStructure__RayTracingShader__Int32__RayTracingAccelerationStructure(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure a3;
			checkType(l,4,out a3);
			self.SetRayTracingAccelerationStructure(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingBufferParam__RayTracingShader__String__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.ComputeBuffer a3;
			checkType(l,4,out a3);
			self.SetRayTracingBufferParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingBufferParam__RayTracingShader__Int32__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.ComputeBuffer a3;
			checkType(l,4,out a3);
			self.SetRayTracingBufferParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingConstantBufferParam__RayTracingShader__Int32__ComputeBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.ComputeBuffer a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetRayTracingConstantBufferParam(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingConstantBufferParam__RayTracingShader__String__ComputeBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.ComputeBuffer a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetRayTracingConstantBufferParam(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingConstantBufferParam__RayTracingShader__Int32__GraphicsBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.GraphicsBuffer a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetRayTracingConstantBufferParam(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingConstantBufferParam__RayTracingShader__String__GraphicsBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.GraphicsBuffer a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetRayTracingConstantBufferParam(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingTextureParam__RayTracingShader__String__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.Rendering.RenderTargetIdentifier a3;
			checkValueType(l,4,out a3);
			self.SetRayTracingTextureParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingTextureParam__RayTracingShader__Int32__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Rendering.RenderTargetIdentifier a3;
			checkValueType(l,4,out a3);
			self.SetRayTracingTextureParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingFloatParam__RayTracingShader__String__Single(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.SetRayTracingFloatParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingFloatParam__RayTracingShader__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.SetRayTracingFloatParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingFloatParams__RayTracingShader__String__A_Single(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Single[] a3;
			checkParams(l,4,out a3);
			self.SetRayTracingFloatParams(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingFloatParams__RayTracingShader__Int32__A_Single(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Single[] a3;
			checkParams(l,4,out a3);
			self.SetRayTracingFloatParams(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingIntParam__RayTracingShader__String__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.SetRayTracingIntParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingIntParam__RayTracingShader__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.SetRayTracingIntParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingIntParams__RayTracingShader__String__A_Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Int32[] a3;
			checkParams(l,4,out a3);
			self.SetRayTracingIntParams(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingIntParams__RayTracingShader__Int32__A_Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32[] a3;
			checkParams(l,4,out a3);
			self.SetRayTracingIntParams(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingVectorParam__RayTracingShader__String__Vector4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.Vector4 a3;
			checkType(l,4,out a3);
			self.SetRayTracingVectorParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingVectorParam__RayTracingShader__Int32__Vector4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Vector4 a3;
			checkType(l,4,out a3);
			self.SetRayTracingVectorParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingVectorArrayParam__RayTracingShader__String__A_Vector4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.Vector4[] a3;
			checkParams(l,4,out a3);
			self.SetRayTracingVectorArrayParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingVectorArrayParam__RayTracingShader__Int32__A_Vector4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Vector4[] a3;
			checkParams(l,4,out a3);
			self.SetRayTracingVectorArrayParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingMatrixParam__RayTracingShader__String__Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.Matrix4x4 a3;
			checkValueType(l,4,out a3);
			self.SetRayTracingMatrixParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingMatrixParam__RayTracingShader__Int32__Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Matrix4x4 a3;
			checkValueType(l,4,out a3);
			self.SetRayTracingMatrixParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingMatrixArrayParam__RayTracingShader__String__A_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			UnityEngine.Matrix4x4[] a3;
			checkValueParams(l,4,out a3);
			self.SetRayTracingMatrixArrayParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRayTracingMatrixArrayParam__RayTracingShader__Int32__A_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Matrix4x4[] a3;
			checkValueParams(l,4,out a3);
			self.SetRayTracingMatrixArrayParam(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DispatchRays(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Experimental.Rendering.RayTracingShader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.UInt32 a3;
			checkType(l,4,out a3);
			System.UInt32 a4;
			checkType(l,5,out a4);
			System.UInt32 a5;
			checkType(l,6,out a5);
			UnityEngine.Camera a6;
			checkType(l,7,out a6);
			self.DispatchRays(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GenerateMips__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			self.GenerateMips(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GenerateMips__RenderTexture(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.RenderTexture a1;
			checkType(l,2,out a1);
			self.GenerateMips(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResolveAntiAliasedSurface(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.RenderTexture a1;
			checkType(l,2,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,3,out a2);
			self.ResolveAntiAliasedSurface(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			self.DrawMesh(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.DrawMesh(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.DrawMesh(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMesh__Mesh__Matrix4x4__Material__Int32__Int32__MaterialPropertyBlock(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			UnityEngine.MaterialPropertyBlock a6;
			checkType(l,7,out a6);
			self.DrawMesh(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawRenderer__Renderer__Material(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Renderer a1;
			checkType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			self.DrawRenderer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawRenderer__Renderer__Material__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Renderer a1;
			checkType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.DrawRenderer(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawRenderer__Renderer__Material__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Renderer a1;
			checkType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.DrawRenderer(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawRendererList(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RendererUtils.RendererList a1;
			checkValueType(l,2,out a1);
			self.DrawRendererList(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProcedural__Matrix4x4__Material__Int32__MeshTopology__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.MeshTopology a4;
			checkEnum(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.DrawProcedural(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProcedural__Matrix4x4__Material__Int32__MeshTopology__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.MeshTopology a4;
			checkEnum(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			self.DrawProcedural(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProcedural__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.MeshTopology a5;
			checkEnum(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			self.DrawProcedural(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProcedural__Matrix4x4__Material__Int32__MeshTopology__Int32__Int32__MaterialPropertyBlock(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.MeshTopology a4;
			checkEnum(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,8,out a7);
			self.DrawProcedural(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProcedural__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.MeshTopology a5;
			checkEnum(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			System.Int32 a7;
			checkType(l,8,out a7);
			self.DrawProcedural(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProcedural__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__Int32__Int32__MaterialPropertyBlock(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.MeshTopology a5;
			checkEnum(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			System.Int32 a7;
			checkType(l,8,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,9,out a8);
			self.DrawProcedural(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__Matrix4x4__Material__Int32__MeshTopology__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.MeshTopology a4;
			checkEnum(l,5,out a4);
			UnityEngine.ComputeBuffer a5;
			checkType(l,6,out a5);
			self.DrawProceduralIndirect(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__Matrix4x4__Material__Int32__MeshTopology__GraphicsBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.MeshTopology a4;
			checkEnum(l,5,out a4);
			UnityEngine.GraphicsBuffer a5;
			checkType(l,6,out a5);
			self.DrawProceduralIndirect(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__Matrix4x4__Material__Int32__MeshTopology__ComputeBuffer__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.MeshTopology a4;
			checkEnum(l,5,out a4);
			UnityEngine.ComputeBuffer a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			self.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.MeshTopology a5;
			checkEnum(l,6,out a5);
			UnityEngine.ComputeBuffer a6;
			checkType(l,7,out a6);
			self.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__Matrix4x4__Material__Int32__MeshTopology__GraphicsBuffer__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.MeshTopology a4;
			checkEnum(l,5,out a4);
			UnityEngine.GraphicsBuffer a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			self.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__GraphicsBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.MeshTopology a5;
			checkEnum(l,6,out a5);
			UnityEngine.GraphicsBuffer a6;
			checkType(l,7,out a6);
			self.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__Matrix4x4__Material__Int32__MeshTopology__ComputeBuffer__Int32__MaterialPropertyBlock(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.MeshTopology a4;
			checkEnum(l,5,out a4);
			UnityEngine.ComputeBuffer a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,8,out a7);
			self.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__ComputeBuffer__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.MeshTopology a5;
			checkEnum(l,6,out a5);
			UnityEngine.ComputeBuffer a6;
			checkType(l,7,out a6);
			System.Int32 a7;
			checkType(l,8,out a7);
			self.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__Matrix4x4__Material__Int32__MeshTopology__GraphicsBuffer__Int32__MaterialPropertyBlock(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.MeshTopology a4;
			checkEnum(l,5,out a4);
			UnityEngine.GraphicsBuffer a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,8,out a7);
			self.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__GraphicsBuffer__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.MeshTopology a5;
			checkEnum(l,6,out a5);
			UnityEngine.GraphicsBuffer a6;
			checkType(l,7,out a6);
			System.Int32 a7;
			checkType(l,8,out a7);
			self.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__ComputeBuffer__Int32__MaterialPropertyBlock(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.MeshTopology a5;
			checkEnum(l,6,out a5);
			UnityEngine.ComputeBuffer a6;
			checkType(l,7,out a6);
			System.Int32 a7;
			checkType(l,8,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,9,out a8);
			self.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__GraphicsBuffer__Int32__MaterialPropertyBlock(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.MeshTopology a5;
			checkEnum(l,6,out a5);
			UnityEngine.GraphicsBuffer a6;
			checkType(l,7,out a6);
			System.Int32 a7;
			checkType(l,8,out a7);
			UnityEngine.MaterialPropertyBlock a8;
			checkType(l,9,out a8);
			self.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstanced__Mesh__Int32__Material__Int32__A_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.Matrix4x4[] a5;
			checkArray(l,6,out a5);
			self.DrawMeshInstanced(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstanced__Mesh__Int32__Material__Int32__A_Matrix4x4__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.Matrix4x4[] a5;
			checkArray(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			self.DrawMeshInstanced(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstanced__Mesh__Int32__Material__Int32__A_Matrix4x4__Int32__MaterialPropertyBlock(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.Matrix4x4[] a5;
			checkArray(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,8,out a7);
			self.DrawMeshInstanced(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstancedProcedural(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			UnityEngine.MaterialPropertyBlock a6;
			checkType(l,7,out a6);
			self.DrawMeshInstancedProcedural(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstancedIndirect__Mesh__Int32__Material__Int32__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.ComputeBuffer a5;
			checkType(l,6,out a5);
			self.DrawMeshInstancedIndirect(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstancedIndirect__Mesh__Int32__Material__Int32__GraphicsBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.GraphicsBuffer a5;
			checkType(l,6,out a5);
			self.DrawMeshInstancedIndirect(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstancedIndirect__Mesh__Int32__Material__Int32__ComputeBuffer__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.ComputeBuffer a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			self.DrawMeshInstancedIndirect(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstancedIndirect__Mesh__Int32__Material__Int32__GraphicsBuffer__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.GraphicsBuffer a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			self.DrawMeshInstancedIndirect(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstancedIndirect__Mesh__Int32__Material__Int32__ComputeBuffer__Int32__MaterialPropertyBlock(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.ComputeBuffer a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,8,out a7);
			self.DrawMeshInstancedIndirect(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstancedIndirect__Mesh__Int32__Material__Int32__GraphicsBuffer__Int32__MaterialPropertyBlock(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.GraphicsBuffer a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			UnityEngine.MaterialPropertyBlock a7;
			checkType(l,8,out a7);
			self.DrawMeshInstancedIndirect(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawOcclusionMesh(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.RectInt a1;
			checkValueType(l,2,out a1);
			self.DrawOcclusionMesh(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRandomWriteTarget__Int32__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			self.SetRandomWriteTarget(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRandomWriteTarget__Int32__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,3,out a2);
			self.SetRandomWriteTarget(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRandomWriteTarget__Int32__GraphicsBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,3,out a2);
			self.SetRandomWriteTarget(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRandomWriteTarget__Int32__ComputeBuffer__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.SetRandomWriteTarget(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRandomWriteTarget__Int32__GraphicsBuffer__Boolean(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.SetRandomWriteTarget(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyCounterValue__ComputeBuffer__ComputeBuffer__UInt32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,3,out a2);
			System.UInt32 a3;
			checkType(l,4,out a3);
			self.CopyCounterValue(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyCounterValue__GraphicsBuffer__ComputeBuffer__UInt32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,3,out a2);
			System.UInt32 a3;
			checkType(l,4,out a3);
			self.CopyCounterValue(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyCounterValue__ComputeBuffer__GraphicsBuffer__UInt32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,3,out a2);
			System.UInt32 a3;
			checkType(l,4,out a3);
			self.CopyCounterValue(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyCounterValue__GraphicsBuffer__GraphicsBuffer__UInt32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,3,out a2);
			System.UInt32 a3;
			checkType(l,4,out a3);
			self.CopyCounterValue(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyTexture__RenderTargetIdentifier__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			self.CopyTexture(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyTexture__RenderTargetIdentifier__Int32__RenderTargetIdentifier__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Rendering.RenderTargetIdentifier a3;
			checkValueType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.CopyTexture(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyTexture__RenderTargetIdentifier__Int32__Int32__RenderTargetIdentifier__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Rendering.RenderTargetIdentifier a4;
			checkValueType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			self.CopyTexture(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyTexture__RenderTargetIdentifier__Int32__Int32__Int32__Int32__Int32__Int32__RenderTargetIdentifier__Int32__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			System.Int32 a7;
			checkType(l,8,out a7);
			UnityEngine.Rendering.RenderTargetIdentifier a8;
			checkValueType(l,9,out a8);
			System.Int32 a9;
			checkType(l,10,out a9);
			System.Int32 a10;
			checkType(l,11,out a10);
			System.Int32 a11;
			checkType(l,12,out a11);
			System.Int32 a12;
			checkType(l,13,out a12);
			self.CopyTexture(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Texture a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			self.Blit(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__RenderTargetIdentifier__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			self.Blit(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__RenderTargetIdentifier__Material(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Texture a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			self.Blit(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__RenderTargetIdentifier__RenderTargetIdentifier__Material(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			self.Blit(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__RenderTargetIdentifier__Vector2__Vector2(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Texture a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,4,out a3);
			UnityEngine.Vector2 a4;
			checkType(l,5,out a4);
			self.Blit(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__Texture__RenderTargetIdentifier__Material__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Texture a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.Blit(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__RenderTargetIdentifier__RenderTargetIdentifier__Vector2__Vector2(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,4,out a3);
			UnityEngine.Vector2 a4;
			checkType(l,5,out a4);
			self.Blit(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__RenderTargetIdentifier__RenderTargetIdentifier__Material__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.Blit(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__RenderTargetIdentifier__RenderTargetIdentifier__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.Blit(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__RenderTargetIdentifier__RenderTargetIdentifier__Material__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.Blit(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Blit__RenderTargetIdentifier__RenderTargetIdentifier__Vector2__Vector2__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,4,out a3);
			UnityEngine.Vector2 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			self.Blit(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalTexture__String__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			self.SetGlobalTexture(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalTexture__Int32__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			self.SetGlobalTexture(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalTexture__String__RenderTargetIdentifier__RenderTextureSubElement(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			UnityEngine.Rendering.RenderTextureSubElement a3;
			checkEnum(l,4,out a3);
			self.SetGlobalTexture(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalTexture__Int32__RenderTargetIdentifier__RenderTextureSubElement(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,3,out a2);
			UnityEngine.Rendering.RenderTextureSubElement a3;
			checkEnum(l,4,out a3);
			self.SetGlobalTexture(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalBuffer__String__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,3,out a2);
			self.SetGlobalBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalBuffer__Int32__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,3,out a2);
			self.SetGlobalBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalBuffer__String__GraphicsBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,3,out a2);
			self.SetGlobalBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalBuffer__Int32__GraphicsBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,3,out a2);
			self.SetGlobalBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalConstantBuffer__ComputeBuffer__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeBuffer a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetGlobalConstantBuffer(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalConstantBuffer__ComputeBuffer__String__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.ComputeBuffer a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetGlobalConstantBuffer(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalConstantBuffer__GraphicsBuffer__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetGlobalConstantBuffer(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalConstantBuffer__GraphicsBuffer__String__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetGlobalConstantBuffer(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetShadowSamplingMode(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rendering.ShadowSamplingMode a2;
			checkEnum(l,3,out a2);
			self.SetShadowSamplingMode(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetSinglePassStereo(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.SinglePassStereoMode a1;
			checkEnum(l,2,out a1);
			self.SetSinglePassStereo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IssuePluginEvent(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.IntPtr a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.IssuePluginEvent(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IssuePluginEventAndData(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.IntPtr a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.IntPtr a3;
			checkType(l,4,out a3);
			self.IssuePluginEventAndData(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IssuePluginCustomBlit(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.IntPtr a1;
			checkType(l,2,out a1);
			System.UInt32 a2;
			checkType(l,3,out a2);
			UnityEngine.Rendering.RenderTargetIdentifier a3;
			checkValueType(l,4,out a3);
			UnityEngine.Rendering.RenderTargetIdentifier a4;
			checkValueType(l,5,out a4);
			System.UInt32 a5;
			checkType(l,6,out a5);
			System.UInt32 a6;
			checkType(l,7,out a6);
			self.IssuePluginCustomBlit(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IssuePluginCustomTextureUpdateV2(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.IntPtr a1;
			checkType(l,2,out a1);
			UnityEngine.Texture a2;
			checkType(l,3,out a2);
			System.UInt32 a3;
			checkType(l,4,out a3);
			self.IssuePluginCustomTextureUpdateV2(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ProcessVTFeedback(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			System.IntPtr a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			System.Int32 a7;
			checkType(l,8,out a7);
			System.Int32 a8;
			checkType(l,9,out a8);
			self.ProcessVTFeedback(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyBuffer(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,3,out a2);
			self.CopyBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SwitchIntoFastMemory(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,2,out a2);
			UnityEngine.Rendering.FastMemoryFlags a3;
			checkEnum(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			self.SwitchIntoFastMemory(a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SwitchOutOfFastMemory(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			self.SwitchOutOfFastMemory(a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_name(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_name(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.name=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sizeInBytes(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sizeInBytes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.CommandBuffer");
		addMember(l,ctor_s);
		addMember(l,ConvertTexture__RenderTargetIdentifier__RenderTargetIdentifier);
		addMember(l,ConvertTexture__RenderTargetIdentifier__Int32__RenderTargetIdentifier__Int32);
		addMember(l,WaitAllAsyncReadbackRequests);
		addMember(l,SetInvertCulling);
		addMember(l,SetComputeFloatParam__ComputeShader__Int32__Single);
		addMember(l,SetComputeFloatParam__ComputeShader__String__Single);
		addMember(l,SetComputeIntParam__ComputeShader__Int32__Int32);
		addMember(l,SetComputeIntParam__ComputeShader__String__Int32);
		addMember(l,SetComputeVectorParam__ComputeShader__Int32__Vector4);
		addMember(l,SetComputeVectorParam__ComputeShader__String__Vector4);
		addMember(l,SetComputeVectorArrayParam__ComputeShader__Int32__A_Vector4);
		addMember(l,SetComputeVectorArrayParam__ComputeShader__String__A_Vector4);
		addMember(l,SetComputeMatrixParam__ComputeShader__Int32__Matrix4x4);
		addMember(l,SetComputeMatrixParam__ComputeShader__String__Matrix4x4);
		addMember(l,SetComputeMatrixArrayParam__ComputeShader__Int32__A_Matrix4x4);
		addMember(l,SetComputeMatrixArrayParam__ComputeShader__String__A_Matrix4x4);
		addMember(l,SetRayTracingShaderPass);
		addMember(l,Clear);
		addMember(l,ClearRandomWriteTargets);
		addMember(l,SetViewport);
		addMember(l,EnableScissorRect);
		addMember(l,DisableScissorRect);
		addMember(l,GetTemporaryRT__Int32__RenderTextureDescriptor);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32);
		addMember(l,GetTemporaryRT__Int32__RenderTextureDescriptor__FilterMode);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32__Int32);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32__Boolean);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite__Int32);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32__Boolean__RenderTextureMemoryless);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite__Int32__Boolean);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32__Boolean__RenderTextureMemoryless__Boolean);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite__Int32__Boolean__RenderTextureMemoryless);
		addMember(l,GetTemporaryRT__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite__Int32__Boolean__RenderTextureMemoryless__Boolean);
		addMember(l,GetTemporaryRTArray__Int32__Int32__Int32__Int32);
		addMember(l,GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32);
		addMember(l,GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode);
		addMember(l,GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat);
		addMember(l,GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat);
		addMember(l,GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32);
		addMember(l,GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite);
		addMember(l,GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32__Boolean);
		addMember(l,GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite__Int32);
		addMember(l,GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__GraphicsFormat__Int32__Boolean__Boolean);
		addMember(l,GetTemporaryRTArray__Int32__Int32__Int32__Int32__Int32__FilterMode__RenderTextureFormat__RenderTextureReadWrite__Int32__Boolean);
		addMember(l,ReleaseTemporaryRT);
		addMember(l,ClearRenderTarget__Boolean__Boolean__Color);
		addMember(l,ClearRenderTarget__RTClearFlags__Color__Single__UInt32);
		addMember(l,ClearRenderTarget__Boolean__Boolean__Color__Single);
		addMember(l,SetGlobalFloat__Int32__Single);
		addMember(l,SetGlobalFloat__String__Single);
		addMember(l,SetGlobalInt__Int32__Int32);
		addMember(l,SetGlobalInt__String__Int32);
		addMember(l,SetGlobalInteger__Int32__Int32);
		addMember(l,SetGlobalInteger__String__Int32);
		addMember(l,SetGlobalVector__Int32__Vector4);
		addMember(l,SetGlobalVector__String__Vector4);
		addMember(l,SetGlobalColor__Int32__Color);
		addMember(l,SetGlobalColor__String__Color);
		addMember(l,SetGlobalMatrix__Int32__Matrix4x4);
		addMember(l,SetGlobalMatrix__String__Matrix4x4);
		addMember(l,EnableShaderKeyword);
		addMember(l,EnableKeyword__R_GlobalKeyword);
		addMember(l,EnableKeyword__Material__R_LocalKeyword);
		addMember(l,EnableKeyword__ComputeShader__R_LocalKeyword);
		addMember(l,DisableShaderKeyword);
		addMember(l,DisableKeyword__R_GlobalKeyword);
		addMember(l,DisableKeyword__Material__R_LocalKeyword);
		addMember(l,DisableKeyword__ComputeShader__R_LocalKeyword);
		addMember(l,SetKeyword__R_GlobalKeyword__Boolean);
		addMember(l,SetKeyword__Material__R_LocalKeyword__Boolean);
		addMember(l,SetKeyword__ComputeShader__R_LocalKeyword__Boolean);
		addMember(l,SetViewMatrix);
		addMember(l,SetProjectionMatrix);
		addMember(l,SetViewProjectionMatrices);
		addMember(l,SetGlobalDepthBias);
		addMember(l,SetExecutionFlags);
		addMember(l,SetGlobalFloatArray__Int32__A_Single);
		addMember(l,SetGlobalFloatArray__String__A_Single);
		addMember(l,SetGlobalVectorArray__Int32__A_Vector4);
		addMember(l,SetGlobalVectorArray__String__A_Vector4);
		addMember(l,SetGlobalMatrixArray__Int32__A_Matrix4x4);
		addMember(l,SetGlobalMatrixArray__String__A_Matrix4x4);
		addMember(l,SetLateLatchProjectionMatrices);
		addMember(l,MarkLateLatchMatrixShaderPropertyID);
		addMember(l,UnmarkLateLatchMatrix);
		addMember(l,BeginSample__String);
		addMember(l,BeginSample__CustomSampler);
		addMember(l,EndSample__String);
		addMember(l,EndSample__CustomSampler);
		addMember(l,IncrementUpdateCount);
		addMember(l,SetInstanceMultiplier);
		addMember(l,SetRenderTarget__RenderTargetIdentifier);
		addMember(l,SetRenderTarget__RenderTargetBinding);
		addMember(l,SetRenderTarget__RenderTargetIdentifier__Int32);
		addMember(l,SetRenderTarget__RenderTargetIdentifier__RenderTargetIdentifier);
		addMember(l,SetRenderTarget__A_RenderTargetIdentifier__RenderTargetIdentifier);
		addMember(l,SetRenderTarget__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction);
		addMember(l,SetRenderTarget__RenderTargetIdentifier__Int32__CubemapFace);
		addMember(l,SetRenderTarget__RenderTargetIdentifier__RenderTargetIdentifier__Int32);
		addMember(l,SetRenderTarget__RenderTargetIdentifier__Int32__CubemapFace__Int32);
		addMember(l,SetRenderTarget__RenderTargetIdentifier__RenderTargetIdentifier__Int32__CubemapFace);
		addMember(l,SetRenderTarget__RenderTargetBinding__Int32__CubemapFace__Int32);
		addMember(l,SetRenderTarget__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction__RenderBufferLoadAction__RenderBufferStoreAction);
		addMember(l,SetRenderTarget__RenderTargetIdentifier__RenderTargetIdentifier__Int32__CubemapFace__Int32);
		addMember(l,SetRenderTarget__A_RenderTargetIdentifier__RenderTargetIdentifier__Int32__CubemapFace__Int32);
		addMember(l,SetRenderTarget__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction);
		addMember(l,SetBufferData__ComputeBuffer__Array);
		addMember(l,SetBufferData__GraphicsBuffer__Array);
		addMember(l,SetBufferData__ComputeBuffer__Array__Int32__Int32__Int32);
		addMember(l,SetBufferData__GraphicsBuffer__Array__Int32__Int32__Int32);
		addMember(l,SetBufferCounterValue__ComputeBuffer__UInt32);
		addMember(l,SetBufferCounterValue__GraphicsBuffer__UInt32);
		addMember(l,Dispose);
		addMember(l,Release);
		addMember(l,CreateAsyncGraphicsFence);
		addMember(l,CreateAsyncGraphicsFence__SynchronisationStage);
		addMember(l,CreateGraphicsFence);
		addMember(l,WaitOnAsyncGraphicsFence__GraphicsFence);
		addMember(l,WaitOnAsyncGraphicsFence__GraphicsFence__SynchronisationStage);
		addMember(l,WaitOnAsyncGraphicsFence__GraphicsFence__SynchronisationStageFlags);
		addMember(l,SetComputeFloatParams__ComputeShader__String__A_Single);
		addMember(l,SetComputeFloatParams__ComputeShader__Int32__A_Single);
		addMember(l,SetComputeIntParams__ComputeShader__String__A_Int32);
		addMember(l,SetComputeIntParams__ComputeShader__Int32__A_Int32);
		addMember(l,SetComputeTextureParam__ComputeShader__Int32__String__RenderTargetIdentifier);
		addMember(l,SetComputeTextureParam__ComputeShader__Int32__Int32__RenderTargetIdentifier);
		addMember(l,SetComputeTextureParam__ComputeShader__Int32__String__RenderTargetIdentifier__Int32);
		addMember(l,SetComputeTextureParam__ComputeShader__Int32__Int32__RenderTargetIdentifier__Int32);
		addMember(l,SetComputeTextureParam__ComputeShader__Int32__String__RenderTargetIdentifier__Int32__RenderTextureSubElement);
		addMember(l,SetComputeTextureParam__ComputeShader__Int32__Int32__RenderTargetIdentifier__Int32__RenderTextureSubElement);
		addMember(l,SetComputeBufferParam__ComputeShader__Int32__Int32__ComputeBuffer);
		addMember(l,SetComputeBufferParam__ComputeShader__Int32__String__ComputeBuffer);
		addMember(l,SetComputeBufferParam__ComputeShader__Int32__Int32__GraphicsBuffer);
		addMember(l,SetComputeBufferParam__ComputeShader__Int32__String__GraphicsBuffer);
		addMember(l,SetComputeConstantBufferParam__ComputeShader__Int32__ComputeBuffer__Int32__Int32);
		addMember(l,SetComputeConstantBufferParam__ComputeShader__String__ComputeBuffer__Int32__Int32);
		addMember(l,SetComputeConstantBufferParam__ComputeShader__Int32__GraphicsBuffer__Int32__Int32);
		addMember(l,SetComputeConstantBufferParam__ComputeShader__String__GraphicsBuffer__Int32__Int32);
		addMember(l,DispatchCompute__ComputeShader__Int32__ComputeBuffer__UInt32);
		addMember(l,DispatchCompute__ComputeShader__Int32__GraphicsBuffer__UInt32);
		addMember(l,DispatchCompute__ComputeShader__Int32__Int32__Int32__Int32);
		addMember(l,BuildRayTracingAccelerationStructure__RayTracingAccelerationStructure);
		addMember(l,BuildRayTracingAccelerationStructure__RayTracingAccelerationStructure__Vector3);
		addMember(l,SetRayTracingAccelerationStructure__RayTracingShader__String__RayTracingAccelerationStructure);
		addMember(l,SetRayTracingAccelerationStructure__RayTracingShader__Int32__RayTracingAccelerationStructure);
		addMember(l,SetRayTracingBufferParam__RayTracingShader__String__ComputeBuffer);
		addMember(l,SetRayTracingBufferParam__RayTracingShader__Int32__ComputeBuffer);
		addMember(l,SetRayTracingConstantBufferParam__RayTracingShader__Int32__ComputeBuffer__Int32__Int32);
		addMember(l,SetRayTracingConstantBufferParam__RayTracingShader__String__ComputeBuffer__Int32__Int32);
		addMember(l,SetRayTracingConstantBufferParam__RayTracingShader__Int32__GraphicsBuffer__Int32__Int32);
		addMember(l,SetRayTracingConstantBufferParam__RayTracingShader__String__GraphicsBuffer__Int32__Int32);
		addMember(l,SetRayTracingTextureParam__RayTracingShader__String__RenderTargetIdentifier);
		addMember(l,SetRayTracingTextureParam__RayTracingShader__Int32__RenderTargetIdentifier);
		addMember(l,SetRayTracingFloatParam__RayTracingShader__String__Single);
		addMember(l,SetRayTracingFloatParam__RayTracingShader__Int32__Single);
		addMember(l,SetRayTracingFloatParams__RayTracingShader__String__A_Single);
		addMember(l,SetRayTracingFloatParams__RayTracingShader__Int32__A_Single);
		addMember(l,SetRayTracingIntParam__RayTracingShader__String__Int32);
		addMember(l,SetRayTracingIntParam__RayTracingShader__Int32__Int32);
		addMember(l,SetRayTracingIntParams__RayTracingShader__String__A_Int32);
		addMember(l,SetRayTracingIntParams__RayTracingShader__Int32__A_Int32);
		addMember(l,SetRayTracingVectorParam__RayTracingShader__String__Vector4);
		addMember(l,SetRayTracingVectorParam__RayTracingShader__Int32__Vector4);
		addMember(l,SetRayTracingVectorArrayParam__RayTracingShader__String__A_Vector4);
		addMember(l,SetRayTracingVectorArrayParam__RayTracingShader__Int32__A_Vector4);
		addMember(l,SetRayTracingMatrixParam__RayTracingShader__String__Matrix4x4);
		addMember(l,SetRayTracingMatrixParam__RayTracingShader__Int32__Matrix4x4);
		addMember(l,SetRayTracingMatrixArrayParam__RayTracingShader__String__A_Matrix4x4);
		addMember(l,SetRayTracingMatrixArrayParam__RayTracingShader__Int32__A_Matrix4x4);
		addMember(l,DispatchRays);
		addMember(l,GenerateMips__RenderTargetIdentifier);
		addMember(l,GenerateMips__RenderTexture);
		addMember(l,ResolveAntiAliasedSurface);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Int32);
		addMember(l,DrawMesh__Mesh__Matrix4x4__Material__Int32__Int32__MaterialPropertyBlock);
		addMember(l,DrawRenderer__Renderer__Material);
		addMember(l,DrawRenderer__Renderer__Material__Int32);
		addMember(l,DrawRenderer__Renderer__Material__Int32__Int32);
		addMember(l,DrawRendererList);
		addMember(l,DrawProcedural__Matrix4x4__Material__Int32__MeshTopology__Int32);
		addMember(l,DrawProcedural__Matrix4x4__Material__Int32__MeshTopology__Int32__Int32);
		addMember(l,DrawProcedural__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__Int32);
		addMember(l,DrawProcedural__Matrix4x4__Material__Int32__MeshTopology__Int32__Int32__MaterialPropertyBlock);
		addMember(l,DrawProcedural__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__Int32__Int32);
		addMember(l,DrawProcedural__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__Int32__Int32__MaterialPropertyBlock);
		addMember(l,DrawProceduralIndirect__Matrix4x4__Material__Int32__MeshTopology__ComputeBuffer);
		addMember(l,DrawProceduralIndirect__Matrix4x4__Material__Int32__MeshTopology__GraphicsBuffer);
		addMember(l,DrawProceduralIndirect__Matrix4x4__Material__Int32__MeshTopology__ComputeBuffer__Int32);
		addMember(l,DrawProceduralIndirect__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__ComputeBuffer);
		addMember(l,DrawProceduralIndirect__Matrix4x4__Material__Int32__MeshTopology__GraphicsBuffer__Int32);
		addMember(l,DrawProceduralIndirect__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__GraphicsBuffer);
		addMember(l,DrawProceduralIndirect__Matrix4x4__Material__Int32__MeshTopology__ComputeBuffer__Int32__MaterialPropertyBlock);
		addMember(l,DrawProceduralIndirect__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__ComputeBuffer__Int32);
		addMember(l,DrawProceduralIndirect__Matrix4x4__Material__Int32__MeshTopology__GraphicsBuffer__Int32__MaterialPropertyBlock);
		addMember(l,DrawProceduralIndirect__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__GraphicsBuffer__Int32);
		addMember(l,DrawProceduralIndirect__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__ComputeBuffer__Int32__MaterialPropertyBlock);
		addMember(l,DrawProceduralIndirect__GraphicsBuffer__Matrix4x4__Material__Int32__MeshTopology__GraphicsBuffer__Int32__MaterialPropertyBlock);
		addMember(l,DrawMeshInstanced__Mesh__Int32__Material__Int32__A_Matrix4x4);
		addMember(l,DrawMeshInstanced__Mesh__Int32__Material__Int32__A_Matrix4x4__Int32);
		addMember(l,DrawMeshInstanced__Mesh__Int32__Material__Int32__A_Matrix4x4__Int32__MaterialPropertyBlock);
		addMember(l,DrawMeshInstancedProcedural);
		addMember(l,DrawMeshInstancedIndirect__Mesh__Int32__Material__Int32__ComputeBuffer);
		addMember(l,DrawMeshInstancedIndirect__Mesh__Int32__Material__Int32__GraphicsBuffer);
		addMember(l,DrawMeshInstancedIndirect__Mesh__Int32__Material__Int32__ComputeBuffer__Int32);
		addMember(l,DrawMeshInstancedIndirect__Mesh__Int32__Material__Int32__GraphicsBuffer__Int32);
		addMember(l,DrawMeshInstancedIndirect__Mesh__Int32__Material__Int32__ComputeBuffer__Int32__MaterialPropertyBlock);
		addMember(l,DrawMeshInstancedIndirect__Mesh__Int32__Material__Int32__GraphicsBuffer__Int32__MaterialPropertyBlock);
		addMember(l,DrawOcclusionMesh);
		addMember(l,SetRandomWriteTarget__Int32__RenderTargetIdentifier);
		addMember(l,SetRandomWriteTarget__Int32__ComputeBuffer);
		addMember(l,SetRandomWriteTarget__Int32__GraphicsBuffer);
		addMember(l,SetRandomWriteTarget__Int32__ComputeBuffer__Boolean);
		addMember(l,SetRandomWriteTarget__Int32__GraphicsBuffer__Boolean);
		addMember(l,CopyCounterValue__ComputeBuffer__ComputeBuffer__UInt32);
		addMember(l,CopyCounterValue__GraphicsBuffer__ComputeBuffer__UInt32);
		addMember(l,CopyCounterValue__ComputeBuffer__GraphicsBuffer__UInt32);
		addMember(l,CopyCounterValue__GraphicsBuffer__GraphicsBuffer__UInt32);
		addMember(l,CopyTexture__RenderTargetIdentifier__RenderTargetIdentifier);
		addMember(l,CopyTexture__RenderTargetIdentifier__Int32__RenderTargetIdentifier__Int32);
		addMember(l,CopyTexture__RenderTargetIdentifier__Int32__Int32__RenderTargetIdentifier__Int32__Int32);
		addMember(l,CopyTexture__RenderTargetIdentifier__Int32__Int32__Int32__Int32__Int32__Int32__RenderTargetIdentifier__Int32__Int32__Int32__Int32);
		addMember(l,Blit__Texture__RenderTargetIdentifier);
		addMember(l,Blit__RenderTargetIdentifier__RenderTargetIdentifier);
		addMember(l,Blit__Texture__RenderTargetIdentifier__Material);
		addMember(l,Blit__RenderTargetIdentifier__RenderTargetIdentifier__Material);
		addMember(l,Blit__Texture__RenderTargetIdentifier__Vector2__Vector2);
		addMember(l,Blit__Texture__RenderTargetIdentifier__Material__Int32);
		addMember(l,Blit__RenderTargetIdentifier__RenderTargetIdentifier__Vector2__Vector2);
		addMember(l,Blit__RenderTargetIdentifier__RenderTargetIdentifier__Material__Int32);
		addMember(l,Blit__RenderTargetIdentifier__RenderTargetIdentifier__Int32__Int32);
		addMember(l,Blit__RenderTargetIdentifier__RenderTargetIdentifier__Material__Int32__Int32);
		addMember(l,Blit__RenderTargetIdentifier__RenderTargetIdentifier__Vector2__Vector2__Int32__Int32);
		addMember(l,SetGlobalTexture__String__RenderTargetIdentifier);
		addMember(l,SetGlobalTexture__Int32__RenderTargetIdentifier);
		addMember(l,SetGlobalTexture__String__RenderTargetIdentifier__RenderTextureSubElement);
		addMember(l,SetGlobalTexture__Int32__RenderTargetIdentifier__RenderTextureSubElement);
		addMember(l,SetGlobalBuffer__String__ComputeBuffer);
		addMember(l,SetGlobalBuffer__Int32__ComputeBuffer);
		addMember(l,SetGlobalBuffer__String__GraphicsBuffer);
		addMember(l,SetGlobalBuffer__Int32__GraphicsBuffer);
		addMember(l,SetGlobalConstantBuffer__ComputeBuffer__Int32__Int32__Int32);
		addMember(l,SetGlobalConstantBuffer__ComputeBuffer__String__Int32__Int32);
		addMember(l,SetGlobalConstantBuffer__GraphicsBuffer__Int32__Int32__Int32);
		addMember(l,SetGlobalConstantBuffer__GraphicsBuffer__String__Int32__Int32);
		addMember(l,SetShadowSamplingMode);
		addMember(l,SetSinglePassStereo);
		addMember(l,IssuePluginEvent);
		addMember(l,IssuePluginEventAndData);
		addMember(l,IssuePluginCustomBlit);
		addMember(l,IssuePluginCustomTextureUpdateV2);
		addMember(l,ProcessVTFeedback);
		addMember(l,CopyBuffer);
		addMember(l,SwitchIntoFastMemory);
		addMember(l,SwitchOutOfFastMemory);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"sizeInBytes",get_sizeInBytes,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.CommandBuffer));
	}
}
