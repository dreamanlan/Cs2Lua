using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_CommandBuffer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
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
	static public int ConvertTexture(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Rendering.RenderTargetIdentifier a3;
				checkValueType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				self.ConvertTexture(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				self.ConvertTexture(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int RequestAsyncReadback(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==12){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				System.Int32 a6;
				checkType(l,8,out a6);
				System.Int32 a7;
				checkType(l,9,out a7);
				System.Int32 a8;
				checkType(l,10,out a8);
				UnityEngine.TextureFormat a9;
				checkEnum(l,11,out a9);
				System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> a10;
				LuaDelegation.checkDelegate(l,12,out a10);
				self.RequestAsyncReadback(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
				pushValue(l,true);
				return 1;
			}
			else if(argc==11){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				System.Int32 a6;
				checkType(l,8,out a6);
				System.Int32 a7;
				checkType(l,9,out a7);
				System.Int32 a8;
				checkType(l,10,out a8);
				System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> a9;
				LuaDelegation.checkDelegate(l,11,out a9);
				self.RequestAsyncReadback(a1,a2,a3,a4,a5,a6,a7,a8,a9);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "RequestAsyncReadback__ComputeBuffer__Int32__Int32__Action`1_AsyncGPUReadbackRequest", argc, 2,typeof(UnityEngine.ComputeBuffer),typeof(int),typeof(int),typeof(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeBuffer a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> a4;
				LuaDelegation.checkDelegate(l,6,out a4);
				self.RequestAsyncReadback(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "RequestAsyncReadback__Texture__Int32__TextureFormat__Action`1_AsyncGPUReadbackRequest", argc, 2,typeof(UnityEngine.Texture),typeof(int),typeof(UnityEngine.TextureFormat),typeof(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.TextureFormat a3;
				checkEnum(l,5,out a3);
				System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> a4;
				LuaDelegation.checkDelegate(l,6,out a4);
				self.RequestAsyncReadback(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> a3;
				LuaDelegation.checkDelegate(l,5,out a3);
				self.RequestAsyncReadback(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "RequestAsyncReadback__ComputeBuffer__Action`1_AsyncGPUReadbackRequest", argc, 2,typeof(UnityEngine.ComputeBuffer),typeof(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeBuffer a1;
				checkType(l,3,out a1);
				System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> a2;
				LuaDelegation.checkDelegate(l,4,out a2);
				self.RequestAsyncReadback(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "RequestAsyncReadback__Texture__Action`1_AsyncGPUReadbackRequest", argc, 2,typeof(UnityEngine.Texture),typeof(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,3,out a1);
				System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> a2;
				LuaDelegation.checkDelegate(l,4,out a2);
				self.RequestAsyncReadback(a1,a2);
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
	static public int SetComputeFloatParam(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetComputeFloatParam__ComputeShader__Int32__Single", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(float))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Single a3;
				checkType(l,5,out a3);
				self.SetComputeFloatParam(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetComputeFloatParam__ComputeShader__String__Single", argc, 2,typeof(UnityEngine.ComputeShader),typeof(string),typeof(float))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				System.Single a3;
				checkType(l,5,out a3);
				self.SetComputeFloatParam(a1,a2,a3);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeIntParam(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetComputeIntParam__ComputeShader__Int32__Int32", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				self.SetComputeIntParam(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetComputeIntParam__ComputeShader__String__Int32", argc, 2,typeof(UnityEngine.ComputeShader),typeof(string),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				self.SetComputeIntParam(a1,a2,a3);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeVectorParam(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetComputeVectorParam__ComputeShader__Int32__Vector4", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(UnityEngine.Vector4))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Vector4 a3;
				checkType(l,5,out a3);
				self.SetComputeVectorParam(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetComputeVectorParam__ComputeShader__String__Vector4", argc, 2,typeof(UnityEngine.ComputeShader),typeof(string),typeof(UnityEngine.Vector4))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				UnityEngine.Vector4 a3;
				checkType(l,5,out a3);
				self.SetComputeVectorParam(a1,a2,a3);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeVectorArrayParam(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetComputeVectorArrayParam__ComputeShader__Int32__Arr_Vector4", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(UnityEngine.Vector4[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Vector4[] a3;
				checkArray(l,5,out a3);
				self.SetComputeVectorArrayParam(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetComputeVectorArrayParam__ComputeShader__String__Arr_Vector4", argc, 2,typeof(UnityEngine.ComputeShader),typeof(string),typeof(UnityEngine.Vector4[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				UnityEngine.Vector4[] a3;
				checkArray(l,5,out a3);
				self.SetComputeVectorArrayParam(a1,a2,a3);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeMatrixParam(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetComputeMatrixParam__ComputeShader__Int32__Matrix4x4", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Matrix4x4 a3;
				checkValueType(l,5,out a3);
				self.SetComputeMatrixParam(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetComputeMatrixParam__ComputeShader__String__Matrix4x4", argc, 2,typeof(UnityEngine.ComputeShader),typeof(string),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				UnityEngine.Matrix4x4 a3;
				checkValueType(l,5,out a3);
				self.SetComputeMatrixParam(a1,a2,a3);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeMatrixArrayParam(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetComputeMatrixArrayParam__ComputeShader__Int32__Arr_Matrix4x4", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(UnityEngine.Matrix4x4[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Matrix4x4[] a3;
				checkArray(l,5,out a3);
				self.SetComputeMatrixArrayParam(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetComputeMatrixArrayParam__ComputeShader__String__Arr_Matrix4x4", argc, 2,typeof(UnityEngine.ComputeShader),typeof(string),typeof(UnityEngine.Matrix4x4[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				UnityEngine.Matrix4x4[] a3;
				checkArray(l,5,out a3);
				self.SetComputeMatrixArrayParam(a1,a2,a3);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeBufferParam(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetComputeBufferParam__ComputeShader__Int32__Int32__ComputeBuffer", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(int),typeof(UnityEngine.ComputeBuffer))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.ComputeBuffer a4;
				checkType(l,6,out a4);
				self.SetComputeBufferParam(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetComputeBufferParam__ComputeShader__Int32__String__ComputeBuffer", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(string),typeof(UnityEngine.ComputeBuffer))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.String a3;
				checkType(l,5,out a3);
				UnityEngine.ComputeBuffer a4;
				checkType(l,6,out a4);
				self.SetComputeBufferParam(a1,a2,a3,a4);
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
	[UnityEngine.Scripting.Preserve]
	static public int CopyCounterValue(IntPtr l) {
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
	static public int GetTemporaryRT(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==13){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				UnityEngine.FilterMode a5;
				checkEnum(l,7,out a5);
				UnityEngine.RenderTextureFormat a6;
				checkEnum(l,8,out a6);
				UnityEngine.RenderTextureReadWrite a7;
				checkEnum(l,9,out a7);
				System.Int32 a8;
				checkType(l,10,out a8);
				System.Boolean a9;
				checkType(l,11,out a9);
				UnityEngine.RenderTextureMemoryless a10;
				checkEnum(l,12,out a10);
				System.Boolean a11;
				checkType(l,13,out a11);
				self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
				pushValue(l,true);
				return 1;
			}
			else if(argc==12){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				UnityEngine.FilterMode a5;
				checkEnum(l,7,out a5);
				UnityEngine.RenderTextureFormat a6;
				checkEnum(l,8,out a6);
				UnityEngine.RenderTextureReadWrite a7;
				checkEnum(l,9,out a7);
				System.Int32 a8;
				checkType(l,10,out a8);
				System.Boolean a9;
				checkType(l,11,out a9);
				UnityEngine.RenderTextureMemoryless a10;
				checkEnum(l,12,out a10);
				self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
				pushValue(l,true);
				return 1;
			}
			else if(argc==11){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				UnityEngine.FilterMode a5;
				checkEnum(l,7,out a5);
				UnityEngine.RenderTextureFormat a6;
				checkEnum(l,8,out a6);
				UnityEngine.RenderTextureReadWrite a7;
				checkEnum(l,9,out a7);
				System.Int32 a8;
				checkType(l,10,out a8);
				System.Boolean a9;
				checkType(l,11,out a9);
				self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7,a8,a9);
				pushValue(l,true);
				return 1;
			}
			else if(argc==10){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				UnityEngine.FilterMode a5;
				checkEnum(l,7,out a5);
				UnityEngine.RenderTextureFormat a6;
				checkEnum(l,8,out a6);
				UnityEngine.RenderTextureReadWrite a7;
				checkEnum(l,9,out a7);
				System.Int32 a8;
				checkType(l,10,out a8);
				self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7,a8);
				pushValue(l,true);
				return 1;
			}
			else if(argc==9){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				UnityEngine.FilterMode a5;
				checkEnum(l,7,out a5);
				UnityEngine.RenderTextureFormat a6;
				checkEnum(l,8,out a6);
				UnityEngine.RenderTextureReadWrite a7;
				checkEnum(l,9,out a7);
				self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				return 1;
			}
			else if(argc==8){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				UnityEngine.FilterMode a5;
				checkEnum(l,7,out a5);
				UnityEngine.RenderTextureFormat a6;
				checkEnum(l,8,out a6);
				self.GetTemporaryRT(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				return 1;
			}
			else if(argc==7){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				UnityEngine.FilterMode a5;
				checkEnum(l,7,out a5);
				self.GetTemporaryRT(a1,a2,a3,a4,a5);
				pushValue(l,true);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				self.GetTemporaryRT(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "GetTemporaryRT__Int32__Int32__Int32", argc, 2,typeof(int),typeof(int),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				self.GetTemporaryRT(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "GetTemporaryRT__Int32__RenderTextureDescriptor__FilterMode", argc, 2,typeof(int),typeof(UnityEngine.RenderTextureDescriptor),typeof(UnityEngine.FilterMode))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.RenderTextureDescriptor a2;
				checkValueType(l,4,out a2);
				UnityEngine.FilterMode a3;
				checkEnum(l,5,out a3);
				self.GetTemporaryRT(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.RenderTextureDescriptor a2;
				checkValueType(l,4,out a2);
				self.GetTemporaryRT(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporaryRTArray(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==13){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				UnityEngine.FilterMode a6;
				checkEnum(l,8,out a6);
				UnityEngine.RenderTextureFormat a7;
				checkEnum(l,9,out a7);
				UnityEngine.RenderTextureReadWrite a8;
				checkEnum(l,10,out a8);
				System.Int32 a9;
				checkType(l,11,out a9);
				System.Boolean a10;
				checkType(l,12,out a10);
				System.Boolean a11;
				checkType(l,13,out a11);
				self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
				pushValue(l,true);
				return 1;
			}
			else if(argc==12){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				UnityEngine.FilterMode a6;
				checkEnum(l,8,out a6);
				UnityEngine.RenderTextureFormat a7;
				checkEnum(l,9,out a7);
				UnityEngine.RenderTextureReadWrite a8;
				checkEnum(l,10,out a8);
				System.Int32 a9;
				checkType(l,11,out a9);
				System.Boolean a10;
				checkType(l,12,out a10);
				self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
				pushValue(l,true);
				return 1;
			}
			else if(argc==11){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				UnityEngine.FilterMode a6;
				checkEnum(l,8,out a6);
				UnityEngine.RenderTextureFormat a7;
				checkEnum(l,9,out a7);
				UnityEngine.RenderTextureReadWrite a8;
				checkEnum(l,10,out a8);
				System.Int32 a9;
				checkType(l,11,out a9);
				self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6,a7,a8,a9);
				pushValue(l,true);
				return 1;
			}
			else if(argc==10){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				UnityEngine.FilterMode a6;
				checkEnum(l,8,out a6);
				UnityEngine.RenderTextureFormat a7;
				checkEnum(l,9,out a7);
				UnityEngine.RenderTextureReadWrite a8;
				checkEnum(l,10,out a8);
				self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6,a7,a8);
				pushValue(l,true);
				return 1;
			}
			else if(argc==9){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				UnityEngine.FilterMode a6;
				checkEnum(l,8,out a6);
				UnityEngine.RenderTextureFormat a7;
				checkEnum(l,9,out a7);
				self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				return 1;
			}
			else if(argc==8){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				UnityEngine.FilterMode a6;
				checkEnum(l,8,out a6);
				self.GetTemporaryRTArray(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				return 1;
			}
			else if(argc==7){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				self.GetTemporaryRTArray(a1,a2,a3,a4,a5);
				pushValue(l,true);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				self.GetTemporaryRTArray(a1,a2,a3,a4);
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
	static public int ClearRenderTarget(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Boolean a1;
				checkType(l,3,out a1);
				System.Boolean a2;
				checkType(l,4,out a2);
				UnityEngine.Color a3;
				checkType(l,5,out a3);
				System.Single a4;
				checkType(l,6,out a4);
				self.ClearRenderTarget(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Boolean a1;
				checkType(l,3,out a1);
				System.Boolean a2;
				checkType(l,4,out a2);
				UnityEngine.Color a3;
				checkType(l,5,out a3);
				self.ClearRenderTarget(a1,a2,a3);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalFloat(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetGlobalFloat__Int32__Single", argc, 2,typeof(int),typeof(float))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Single a2;
				checkType(l,4,out a2);
				self.SetGlobalFloat(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalFloat__String__Single", argc, 2,typeof(string),typeof(float))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Single a2;
				checkType(l,4,out a2);
				self.SetGlobalFloat(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalInt(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetGlobalInt__Int32__Int32", argc, 2,typeof(int),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				self.SetGlobalInt(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalInt__String__Int32", argc, 2,typeof(string),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				self.SetGlobalInt(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalVector(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetGlobalVector__Int32__Vector4", argc, 2,typeof(int),typeof(UnityEngine.Vector4))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,4,out a2);
				self.SetGlobalVector(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalVector__String__Vector4", argc, 2,typeof(string),typeof(UnityEngine.Vector4))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,4,out a2);
				self.SetGlobalVector(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalColor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetGlobalColor__Int32__Color", argc, 2,typeof(int),typeof(UnityEngine.Color))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.Color a2;
				checkType(l,4,out a2);
				self.SetGlobalColor(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalColor__String__Color", argc, 2,typeof(string),typeof(UnityEngine.Color))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				UnityEngine.Color a2;
				checkType(l,4,out a2);
				self.SetGlobalColor(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalMatrix(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetGlobalMatrix__Int32__Matrix4x4", argc, 2,typeof(int),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,4,out a2);
				self.SetGlobalMatrix(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalMatrix__String__Matrix4x4", argc, 2,typeof(string),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,4,out a2);
				self.SetGlobalMatrix(a1,a2);
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
	static public int SetGlobalFloatArray(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetGlobalFloatArray__Int32__Arr_Single", argc, 2,typeof(int),typeof(System.Single[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Single[] a2;
				checkArray(l,4,out a2);
				self.SetGlobalFloatArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalFloatArray__String__List`1_Single", argc, 2,typeof(string),typeof(List<System.Single>))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Collections.Generic.List<System.Single> a2;
				checkType(l,4,out a2);
				self.SetGlobalFloatArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalFloatArray__Int32__List`1_Single", argc, 2,typeof(int),typeof(List<System.Single>))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Collections.Generic.List<System.Single> a2;
				checkType(l,4,out a2);
				self.SetGlobalFloatArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalFloatArray__String__Arr_Single", argc, 2,typeof(string),typeof(System.Single[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Single[] a2;
				checkArray(l,4,out a2);
				self.SetGlobalFloatArray(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalVectorArray(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetGlobalVectorArray__Int32__Arr_Vector4", argc, 2,typeof(int),typeof(UnityEngine.Vector4[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.Vector4[] a2;
				checkArray(l,4,out a2);
				self.SetGlobalVectorArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalVectorArray__String__List`1_Vector4", argc, 2,typeof(string),typeof(List<UnityEngine.Vector4>))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Collections.Generic.List<UnityEngine.Vector4> a2;
				checkType(l,4,out a2);
				self.SetGlobalVectorArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalVectorArray__Int32__List`1_Vector4", argc, 2,typeof(int),typeof(List<UnityEngine.Vector4>))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Collections.Generic.List<UnityEngine.Vector4> a2;
				checkType(l,4,out a2);
				self.SetGlobalVectorArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalVectorArray__String__Arr_Vector4", argc, 2,typeof(string),typeof(UnityEngine.Vector4[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				UnityEngine.Vector4[] a2;
				checkArray(l,4,out a2);
				self.SetGlobalVectorArray(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalMatrixArray(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetGlobalMatrixArray__Int32__Arr_Matrix4x4", argc, 2,typeof(int),typeof(UnityEngine.Matrix4x4[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.Matrix4x4[] a2;
				checkArray(l,4,out a2);
				self.SetGlobalMatrixArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalMatrixArray__String__List`1_Matrix4x4", argc, 2,typeof(string),typeof(List<UnityEngine.Matrix4x4>))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Collections.Generic.List<UnityEngine.Matrix4x4> a2;
				checkType(l,4,out a2);
				self.SetGlobalMatrixArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalMatrixArray__Int32__List`1_Matrix4x4", argc, 2,typeof(int),typeof(List<UnityEngine.Matrix4x4>))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Collections.Generic.List<UnityEngine.Matrix4x4> a2;
				checkType(l,4,out a2);
				self.SetGlobalMatrixArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalMatrixArray__String__Arr_Matrix4x4", argc, 2,typeof(string),typeof(UnityEngine.Matrix4x4[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				UnityEngine.Matrix4x4[] a2;
				checkArray(l,4,out a2);
				self.SetGlobalMatrixArray(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalBuffer(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetGlobalBuffer__Int32__ComputeBuffer", argc, 2,typeof(int),typeof(UnityEngine.ComputeBuffer))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,4,out a2);
				self.SetGlobalBuffer(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalBuffer__String__ComputeBuffer", argc, 2,typeof(string),typeof(UnityEngine.ComputeBuffer))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,4,out a2);
				self.SetGlobalBuffer(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int BeginSample(IntPtr l) {
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
	static public int EndSample(IntPtr l) {
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
	static public int SetRenderTarget(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==8){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.RenderBufferLoadAction a2;
				checkEnum(l,4,out a2);
				UnityEngine.Rendering.RenderBufferStoreAction a3;
				checkEnum(l,5,out a3);
				UnityEngine.Rendering.RenderTargetIdentifier a4;
				checkValueType(l,6,out a4);
				UnityEngine.Rendering.RenderBufferLoadAction a5;
				checkEnum(l,7,out a5);
				UnityEngine.Rendering.RenderBufferStoreAction a6;
				checkEnum(l,8,out a6);
				self.SetRenderTarget(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRenderTarget__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction__RenderBufferLoadAction__RenderBufferStoreAction", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderBufferLoadAction),typeof(UnityEngine.Rendering.RenderBufferStoreAction),typeof(UnityEngine.Rendering.RenderBufferLoadAction),typeof(UnityEngine.Rendering.RenderBufferStoreAction))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.RenderBufferLoadAction a2;
				checkEnum(l,4,out a2);
				UnityEngine.Rendering.RenderBufferStoreAction a3;
				checkEnum(l,5,out a3);
				UnityEngine.Rendering.RenderBufferLoadAction a4;
				checkEnum(l,6,out a4);
				UnityEngine.Rendering.RenderBufferStoreAction a5;
				checkEnum(l,7,out a5);
				self.SetRenderTarget(a1,a2,a3,a4,a5);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRenderTarget__RenderTargetIdentifier__RenderTargetIdentifier__Int32__CubemapFace__Int32", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(int),typeof(UnityEngine.CubemapFace),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.CubemapFace a4;
				checkEnum(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				self.SetRenderTarget(a1,a2,a3,a4,a5);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRenderTarget__RenderTargetIdentifier__Int32__CubemapFace__Int32", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(int),typeof(UnityEngine.CubemapFace),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.CubemapFace a3;
				checkEnum(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				self.SetRenderTarget(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRenderTarget__RenderTargetIdentifier__RenderTargetIdentifier__Int32__CubemapFace", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(int),typeof(UnityEngine.CubemapFace))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.CubemapFace a4;
				checkEnum(l,6,out a4);
				self.SetRenderTarget(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRenderTarget__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderBufferLoadAction),typeof(UnityEngine.Rendering.RenderBufferStoreAction))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.RenderBufferLoadAction a2;
				checkEnum(l,4,out a2);
				UnityEngine.Rendering.RenderBufferStoreAction a3;
				checkEnum(l,5,out a3);
				self.SetRenderTarget(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRenderTarget__RenderTargetIdentifier__Int32__CubemapFace", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(int),typeof(UnityEngine.CubemapFace))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.CubemapFace a3;
				checkEnum(l,5,out a3);
				self.SetRenderTarget(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRenderTarget__RenderTargetIdentifier__RenderTargetIdentifier__Int32", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				self.SetRenderTarget(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRenderTarget__RenderTargetIdentifier__Int32", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				self.SetRenderTarget(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRenderTarget__RenderTargetIdentifier__RenderTargetIdentifier", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				self.SetRenderTarget(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRenderTarget__Arr_RenderTargetIdentifier__RenderTargetIdentifier", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier[]),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier[] a1;
				checkArray(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				self.SetRenderTarget(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRenderTarget__RenderTargetIdentifier", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				self.SetRenderTarget(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRenderTarget__RenderTargetBinding", argc, 2,typeof(UnityEngine.Rendering.RenderTargetBinding))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetBinding a1;
				checkValueType(l,3,out a1);
				self.SetRenderTarget(a1);
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
	static public int CreateGPUFence(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.SynchronisationStage a1;
				checkEnum(l,3,out a1);
				var ret=self.CreateGPUFence(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				var ret=self.CreateGPUFence();
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
	[UnityEngine.Scripting.Preserve]
	static public int WaitOnGPUFence(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.GPUFence a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.SynchronisationStage a2;
				checkEnum(l,4,out a2);
				self.WaitOnGPUFence(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.GPUFence a1;
				checkValueType(l,3,out a1);
				self.WaitOnGPUFence(a1);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeFloatParams(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetComputeFloatParams__ComputeShader__String__Arr_Single", argc, 2,typeof(UnityEngine.ComputeShader),typeof(string),typeof(System.Single[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				System.Single[] a3;
				checkParams(l,5,out a3);
				self.SetComputeFloatParams(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetComputeFloatParams__ComputeShader__Int32__Arr_Single", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(System.Single[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Single[] a3;
				checkParams(l,5,out a3);
				self.SetComputeFloatParams(a1,a2,a3);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeIntParams(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetComputeIntParams__ComputeShader__String__Arr_Int32", argc, 2,typeof(UnityEngine.ComputeShader),typeof(string),typeof(System.Int32[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				System.Int32[] a3;
				checkParams(l,5,out a3);
				self.SetComputeIntParams(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetComputeIntParams__ComputeShader__Int32__Arr_Int32", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(System.Int32[]))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32[] a3;
				checkParams(l,5,out a3);
				self.SetComputeIntParams(a1,a2,a3);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetComputeTextureParam(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetComputeTextureParam__ComputeShader__Int32__String__RenderTargetIdentifier__Int32", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(string),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.String a3;
				checkType(l,5,out a3);
				UnityEngine.Rendering.RenderTargetIdentifier a4;
				checkValueType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				self.SetComputeTextureParam(a1,a2,a3,a4,a5);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetComputeTextureParam__ComputeShader__Int32__Int32__RenderTargetIdentifier__Int32", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(int),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.Rendering.RenderTargetIdentifier a4;
				checkValueType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				self.SetComputeTextureParam(a1,a2,a3,a4,a5);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetComputeTextureParam__ComputeShader__Int32__String__RenderTargetIdentifier", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(string),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.String a3;
				checkType(l,5,out a3);
				UnityEngine.Rendering.RenderTargetIdentifier a4;
				checkValueType(l,6,out a4);
				self.SetComputeTextureParam(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetComputeTextureParam__ComputeShader__Int32__Int32__RenderTargetIdentifier", argc, 2,typeof(UnityEngine.ComputeShader),typeof(int),typeof(int),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.Rendering.RenderTargetIdentifier a4;
				checkValueType(l,6,out a4);
				self.SetComputeTextureParam(a1,a2,a3,a4);
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
	[UnityEngine.Scripting.Preserve]
	static public int DispatchCompute(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==7){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				self.DispatchCompute(a1,a2,a3,a4,a5);
				pushValue(l,true);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.ComputeShader a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.ComputeBuffer a3;
				checkType(l,5,out a3);
				System.UInt32 a4;
				checkType(l,6,out a4);
				self.DispatchCompute(a1,a2,a3,a4);
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
	[UnityEngine.Scripting.Preserve]
	static public int GenerateMips(IntPtr l) {
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
	static public int DrawMesh(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==8){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,3,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				UnityEngine.MaterialPropertyBlock a6;
				checkType(l,8,out a6);
				self.DrawMesh(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				return 1;
			}
			else if(argc==7){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,3,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				self.DrawMesh(a1,a2,a3,a4,a5);
				pushValue(l,true);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,3,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				self.DrawMesh(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,3,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				self.DrawMesh(a1,a2,a3);
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
	[UnityEngine.Scripting.Preserve]
	static public int DrawRenderer(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Renderer a1;
				checkType(l,3,out a1);
				UnityEngine.Material a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				self.DrawRenderer(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Renderer a1;
				checkType(l,3,out a1);
				UnityEngine.Material a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				self.DrawRenderer(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Renderer a1;
				checkType(l,3,out a1);
				UnityEngine.Material a2;
				checkType(l,4,out a2);
				self.DrawRenderer(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int DrawProcedural(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==9){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Matrix4x4 a1;
				checkValueType(l,3,out a1);
				UnityEngine.Material a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.MeshTopology a4;
				checkEnum(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				System.Int32 a6;
				checkType(l,8,out a6);
				UnityEngine.MaterialPropertyBlock a7;
				checkType(l,9,out a7);
				self.DrawProcedural(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				return 1;
			}
			else if(argc==8){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Matrix4x4 a1;
				checkValueType(l,3,out a1);
				UnityEngine.Material a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.MeshTopology a4;
				checkEnum(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				System.Int32 a6;
				checkType(l,8,out a6);
				self.DrawProcedural(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				return 1;
			}
			else if(argc==7){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Matrix4x4 a1;
				checkValueType(l,3,out a1);
				UnityEngine.Material a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.MeshTopology a4;
				checkEnum(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				self.DrawProcedural(a1,a2,a3,a4,a5);
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
	[UnityEngine.Scripting.Preserve]
	static public int DrawProceduralIndirect(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==9){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Matrix4x4 a1;
				checkValueType(l,3,out a1);
				UnityEngine.Material a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.MeshTopology a4;
				checkEnum(l,6,out a4);
				UnityEngine.ComputeBuffer a5;
				checkType(l,7,out a5);
				System.Int32 a6;
				checkType(l,8,out a6);
				UnityEngine.MaterialPropertyBlock a7;
				checkType(l,9,out a7);
				self.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				return 1;
			}
			else if(argc==8){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Matrix4x4 a1;
				checkValueType(l,3,out a1);
				UnityEngine.Material a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.MeshTopology a4;
				checkEnum(l,6,out a4);
				UnityEngine.ComputeBuffer a5;
				checkType(l,7,out a5);
				System.Int32 a6;
				checkType(l,8,out a6);
				self.DrawProceduralIndirect(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				return 1;
			}
			else if(argc==7){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Matrix4x4 a1;
				checkValueType(l,3,out a1);
				UnityEngine.Material a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.MeshTopology a4;
				checkEnum(l,6,out a4);
				UnityEngine.ComputeBuffer a5;
				checkType(l,7,out a5);
				self.DrawProceduralIndirect(a1,a2,a3,a4,a5);
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
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstanced(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==9){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				UnityEngine.Matrix4x4[] a5;
				checkArray(l,7,out a5);
				System.Int32 a6;
				checkType(l,8,out a6);
				UnityEngine.MaterialPropertyBlock a7;
				checkType(l,9,out a7);
				self.DrawMeshInstanced(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				return 1;
			}
			else if(argc==8){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				UnityEngine.Matrix4x4[] a5;
				checkArray(l,7,out a5);
				System.Int32 a6;
				checkType(l,8,out a6);
				self.DrawMeshInstanced(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				return 1;
			}
			else if(argc==7){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				UnityEngine.Matrix4x4[] a5;
				checkArray(l,7,out a5);
				self.DrawMeshInstanced(a1,a2,a3,a4,a5);
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
	[UnityEngine.Scripting.Preserve]
	static public int DrawMeshInstancedIndirect(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==9){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				UnityEngine.ComputeBuffer a5;
				checkType(l,7,out a5);
				System.Int32 a6;
				checkType(l,8,out a6);
				UnityEngine.MaterialPropertyBlock a7;
				checkType(l,9,out a7);
				self.DrawMeshInstancedIndirect(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				return 1;
			}
			else if(argc==8){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				UnityEngine.ComputeBuffer a5;
				checkType(l,7,out a5);
				System.Int32 a6;
				checkType(l,8,out a6);
				self.DrawMeshInstancedIndirect(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				return 1;
			}
			else if(argc==7){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				UnityEngine.ComputeBuffer a5;
				checkType(l,7,out a5);
				self.DrawMeshInstancedIndirect(a1,a2,a3,a4,a5);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetRandomWriteTarget(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,4,out a2);
				System.Boolean a3;
				checkType(l,5,out a3);
				self.SetRandomWriteTarget(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRandomWriteTarget__Int32__ComputeBuffer", argc, 2,typeof(int),typeof(UnityEngine.ComputeBuffer))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,4,out a2);
				self.SetRandomWriteTarget(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetRandomWriteTarget__Int32__RenderTargetIdentifier", argc, 2,typeof(int),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				self.SetRandomWriteTarget(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int CopyTexture(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==14){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				System.Int32 a6;
				checkType(l,8,out a6);
				System.Int32 a7;
				checkType(l,9,out a7);
				UnityEngine.Rendering.RenderTargetIdentifier a8;
				checkValueType(l,10,out a8);
				System.Int32 a9;
				checkType(l,11,out a9);
				System.Int32 a10;
				checkType(l,12,out a10);
				System.Int32 a11;
				checkType(l,13,out a11);
				System.Int32 a12;
				checkType(l,14,out a12);
				self.CopyTexture(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12);
				pushValue(l,true);
				return 1;
			}
			else if(argc==8){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.Rendering.RenderTargetIdentifier a4;
				checkValueType(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				System.Int32 a6;
				checkType(l,8,out a6);
				self.CopyTexture(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Rendering.RenderTargetIdentifier a3;
				checkValueType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				self.CopyTexture(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				self.CopyTexture(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int Blit(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Blit__Texture__RenderTargetIdentifier__Vector2__Vector2", argc, 2,typeof(UnityEngine.Texture),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,5,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,6,out a4);
				self.Blit(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Blit__Texture__RenderTargetIdentifier__Material__Int32", argc, 2,typeof(UnityEngine.Texture),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Material),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				self.Blit(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Blit__RenderTargetIdentifier__RenderTargetIdentifier__Vector2__Vector2", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,5,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,6,out a4);
				self.Blit(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Blit__RenderTargetIdentifier__RenderTargetIdentifier__Material__Int32", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Material),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				self.Blit(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Blit__Texture__RenderTargetIdentifier__Material", argc, 2,typeof(UnityEngine.Texture),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Material))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				self.Blit(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Blit__RenderTargetIdentifier__RenderTargetIdentifier__Material", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Material))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				UnityEngine.Material a3;
				checkType(l,5,out a3);
				self.Blit(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Blit__Texture__RenderTargetIdentifier", argc, 2,typeof(UnityEngine.Texture),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				self.Blit(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Blit__RenderTargetIdentifier__RenderTargetIdentifier", argc, 2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				self.Blit(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalTexture(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetGlobalTexture__String__RenderTargetIdentifier", argc, 2,typeof(string),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				self.SetGlobalTexture(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetGlobalTexture__Int32__RenderTargetIdentifier", argc, 2,typeof(int),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,4,out a2);
				self.SetGlobalTexture(a1,a2);
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
	static public int Dispose_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
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
		addMember(l,ConvertTexture);
		addMember(l,RequestAsyncReadback);
		addMember(l,SetInvertCulling);
		addMember(l,SetComputeFloatParam);
		addMember(l,SetComputeIntParam);
		addMember(l,SetComputeVectorParam);
		addMember(l,SetComputeVectorArrayParam);
		addMember(l,SetComputeMatrixParam);
		addMember(l,SetComputeMatrixArrayParam);
		addMember(l,SetComputeBufferParam);
		addMember(l,CopyCounterValue);
		addMember(l,Clear);
		addMember(l,ClearRandomWriteTargets);
		addMember(l,SetViewport);
		addMember(l,EnableScissorRect);
		addMember(l,DisableScissorRect);
		addMember(l,GetTemporaryRT);
		addMember(l,GetTemporaryRTArray);
		addMember(l,ReleaseTemporaryRT);
		addMember(l,ClearRenderTarget);
		addMember(l,SetGlobalFloat);
		addMember(l,SetGlobalInt);
		addMember(l,SetGlobalVector);
		addMember(l,SetGlobalColor);
		addMember(l,SetGlobalMatrix);
		addMember(l,EnableShaderKeyword);
		addMember(l,DisableShaderKeyword);
		addMember(l,SetViewMatrix);
		addMember(l,SetProjectionMatrix);
		addMember(l,SetViewProjectionMatrices);
		addMember(l,SetGlobalDepthBias);
		addMember(l,SetGlobalFloatArray);
		addMember(l,SetGlobalVectorArray);
		addMember(l,SetGlobalMatrixArray);
		addMember(l,SetGlobalBuffer);
		addMember(l,BeginSample);
		addMember(l,EndSample);
		addMember(l,SetRenderTarget);
		addMember(l,Dispose);
		addMember(l,Release);
		addMember(l,CreateGPUFence);
		addMember(l,WaitOnGPUFence);
		addMember(l,SetComputeFloatParams);
		addMember(l,SetComputeIntParams);
		addMember(l,SetComputeTextureParam);
		addMember(l,DispatchCompute);
		addMember(l,GenerateMips);
		addMember(l,ResolveAntiAliasedSurface);
		addMember(l,DrawMesh);
		addMember(l,DrawRenderer);
		addMember(l,DrawProcedural);
		addMember(l,DrawProceduralIndirect);
		addMember(l,DrawMeshInstanced);
		addMember(l,DrawMeshInstancedIndirect);
		addMember(l,SetRandomWriteTarget);
		addMember(l,CopyTexture);
		addMember(l,Blit);
		addMember(l,SetGlobalTexture);
		addMember(l,SetShadowSamplingMode);
		addMember(l,IssuePluginEvent);
		addMember(l,IssuePluginEventAndData);
		addMember(l,IssuePluginCustomBlit);
		addMember(l,IssuePluginCustomTextureUpdateV2);
		addMember(l,Dispose_s);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"sizeInBytes",get_sizeInBytes,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.CommandBuffer));
	}
}
