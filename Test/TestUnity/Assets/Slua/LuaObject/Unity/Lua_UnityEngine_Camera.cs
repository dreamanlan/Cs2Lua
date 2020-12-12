﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Camera : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Reset(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			self.Reset();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResetTransparencySortSettings(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			self.ResetTransparencySortSettings();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResetAspect(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			self.ResetAspect();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResetCullingMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			self.ResetCullingMatrix();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetReplacementShader(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Shader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.SetReplacementShader(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResetReplacementShader(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			self.ResetReplacementShader();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTargetBuffers__RenderBuffer__RenderBuffer(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.RenderBuffer a1;
			checkValueType(l,2,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,3,out a2);
			self.SetTargetBuffers(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTargetBuffers__A_RenderBuffer__RenderBuffer(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.RenderBuffer[] a1;
			checkArray(l,2,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,3,out a2);
			self.SetTargetBuffers(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResetWorldToCameraMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			self.ResetWorldToCameraMatrix();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResetProjectionMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			self.ResetProjectionMatrix();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CalculateObliqueMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector4 a1;
			checkType(l,2,out a1);
			var ret=self.CalculateObliqueMatrix(a1);
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
	static public int WorldToScreenPoint__Vector3(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.WorldToScreenPoint(a1);
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
	static public int WorldToScreenPoint__Vector3__MonoOrStereoscopicEye(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Camera.MonoOrStereoscopicEye a2;
			checkEnum(l,3,out a2);
			var ret=self.WorldToScreenPoint(a1,a2);
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
	static public int WorldToViewportPoint__Vector3(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.WorldToViewportPoint(a1);
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
	static public int WorldToViewportPoint__Vector3__MonoOrStereoscopicEye(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Camera.MonoOrStereoscopicEye a2;
			checkEnum(l,3,out a2);
			var ret=self.WorldToViewportPoint(a1,a2);
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
	static public int ViewportToWorldPoint__Vector3(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.ViewportToWorldPoint(a1);
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
	static public int ViewportToWorldPoint__Vector3__MonoOrStereoscopicEye(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Camera.MonoOrStereoscopicEye a2;
			checkEnum(l,3,out a2);
			var ret=self.ViewportToWorldPoint(a1,a2);
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
	static public int ScreenToWorldPoint__Vector3(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.ScreenToWorldPoint(a1);
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
	static public int ScreenToWorldPoint__Vector3__MonoOrStereoscopicEye(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Camera.MonoOrStereoscopicEye a2;
			checkEnum(l,3,out a2);
			var ret=self.ScreenToWorldPoint(a1,a2);
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
	static public int ScreenToViewportPoint(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.ScreenToViewportPoint(a1);
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
	static public int ViewportToScreenPoint(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.ViewportToScreenPoint(a1);
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
	static public int ViewportPointToRay__Vector3(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.ViewportPointToRay(a1);
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
	static public int ViewportPointToRay__Vector3__MonoOrStereoscopicEye(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Camera.MonoOrStereoscopicEye a2;
			checkEnum(l,3,out a2);
			var ret=self.ViewportPointToRay(a1,a2);
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
	static public int ScreenPointToRay__Vector3(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.ScreenPointToRay(a1);
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
	static public int ScreenPointToRay__Vector3__MonoOrStereoscopicEye(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Camera.MonoOrStereoscopicEye a2;
			checkEnum(l,3,out a2);
			var ret=self.ScreenPointToRay(a1,a2);
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
	static public int CalculateFrustumCorners(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			UnityEngine.Camera.MonoOrStereoscopicEye a3;
			checkEnum(l,4,out a3);
			UnityEngine.Vector3[] a4;
			checkArray(l,5,out a4);
			self.CalculateFrustumCorners(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetStereoNonJitteredProjectionMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Camera.StereoscopicEye a1;
			checkEnum(l,2,out a1);
			var ret=self.GetStereoNonJitteredProjectionMatrix(a1);
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
	static public int GetStereoViewMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Camera.StereoscopicEye a1;
			checkEnum(l,2,out a1);
			var ret=self.GetStereoViewMatrix(a1);
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
	static public int CopyStereoDeviceProjectionMatrixToNonJittered(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Camera.StereoscopicEye a1;
			checkEnum(l,2,out a1);
			self.CopyStereoDeviceProjectionMatrixToNonJittered(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetStereoProjectionMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Camera.StereoscopicEye a1;
			checkEnum(l,2,out a1);
			var ret=self.GetStereoProjectionMatrix(a1);
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
	static public int SetStereoProjectionMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Camera.StereoscopicEye a1;
			checkEnum(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			self.SetStereoProjectionMatrix(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResetStereoProjectionMatrices(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			self.ResetStereoProjectionMatrices();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetStereoViewMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Camera.StereoscopicEye a1;
			checkEnum(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			self.SetStereoViewMatrix(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResetStereoViewMatrices(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			self.ResetStereoViewMatrices();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLODMasks(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			var ret=self.GetLODMasks();
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
	static public int GetVisibleLODGroupCount(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			var ret=self.GetVisibleLODGroupCount();
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
	static public int GetVisibleLODGroupAt(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetVisibleLODGroupAt(a1);
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
	static public int GetVisibleLODGroup(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			var ret=self.GetVisibleLODGroup();
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
	static public int RenderToCubemap__Cubemap(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Cubemap a1;
			checkType(l,2,out a1);
			var ret=self.RenderToCubemap(a1);
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
	static public int RenderToCubemap__RenderTexture(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.RenderTexture a1;
			checkType(l,2,out a1);
			var ret=self.RenderToCubemap(a1);
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
	static public int RenderToCubemap__Cubemap__Int32(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Cubemap a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.RenderToCubemap(a1,a2);
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
	static public int RenderToCubemap__RenderTexture__Int32(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.RenderTexture a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.RenderToCubemap(a1,a2);
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
	static public int RenderToCubemap__RenderTexture__Int32__MonoOrStereoscopicEye(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.RenderTexture a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Camera.MonoOrStereoscopicEye a3;
			checkEnum(l,4,out a3);
			var ret=self.RenderToCubemap(a1,a2,a3);
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
	static public int Render(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			self.Render();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RenderWithShader(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Shader a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.RenderWithShader(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RenderDontRestore(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			self.RenderDontRestore();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyFrom(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			self.CopyFrom(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveCommandBuffers(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Rendering.CameraEvent a1;
			checkEnum(l,2,out a1);
			self.RemoveCommandBuffers(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveAllCommandBuffers(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			self.RemoveAllCommandBuffers();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddCommandBuffer(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Rendering.CameraEvent a1;
			checkEnum(l,2,out a1);
			UnityEngine.Rendering.CommandBuffer a2;
			checkType(l,3,out a2);
			self.AddCommandBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddCommandBufferAsync(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Rendering.CameraEvent a1;
			checkEnum(l,2,out a1);
			UnityEngine.Rendering.CommandBuffer a2;
			checkType(l,3,out a2);
			UnityEngine.Rendering.ComputeQueueType a3;
			checkEnum(l,4,out a3);
			self.AddCommandBufferAsync(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveCommandBuffer(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Rendering.CameraEvent a1;
			checkEnum(l,2,out a1);
			UnityEngine.Rendering.CommandBuffer a2;
			checkType(l,3,out a2);
			self.RemoveCommandBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetCommandBuffers(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Rendering.CameraEvent a1;
			checkEnum(l,2,out a1);
			var ret=self.GetCommandBuffers(a1);
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
	static public int CalculateProjectionMatrixFromPhysicalProperties_s(IntPtr l) {
		try {
			UnityEngine.Matrix4x4 a1;
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			UnityEngine.Vector2 a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Single a6;
			checkType(l,6,out a6);
			UnityEngine.Camera.GateFitParameters a7;
			checkValueType(l,7,out a7);
			UnityEngine.Camera.CalculateProjectionMatrixFromPhysicalProperties(out a1,a2,a3,a4,a5,a6,a7);
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
	static public int FocalLengthToFOV_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Camera.FocalLengthToFOV(a1,a2);
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
	static public int FOVToFocalLength_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Camera.FOVToFocalLength(a1,a2);
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
	static public int GetAllCameras_s(IntPtr l) {
		try {
			UnityEngine.Camera[] a1;
			checkArray(l,1,out a1);
			var ret=UnityEngine.Camera.GetAllCameras(a1);
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
	static public int SetupCurrent_s(IntPtr l) {
		try {
			UnityEngine.Camera a1;
			checkType(l,1,out a1);
			UnityEngine.Camera.SetupCurrent(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_onPreCull(IntPtr l) {
		try {
			UnityEngine.Camera.CameraCallback v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) UnityEngine.Camera.onPreCull=v;
			else if(op==1) UnityEngine.Camera.onPreCull+=v;
			else if(op==2) UnityEngine.Camera.onPreCull-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_onPreRender(IntPtr l) {
		try {
			UnityEngine.Camera.CameraCallback v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) UnityEngine.Camera.onPreRender=v;
			else if(op==1) UnityEngine.Camera.onPreRender+=v;
			else if(op==2) UnityEngine.Camera.onPreRender-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_onPostRender(IntPtr l) {
		try {
			UnityEngine.Camera.CameraCallback v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) UnityEngine.Camera.onPostRender=v;
			else if(op==1) UnityEngine.Camera.onPostRender+=v;
			else if(op==2) UnityEngine.Camera.onPostRender-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_nearClipPlane(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.nearClipPlane);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_nearClipPlane(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.nearClipPlane=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_farClipPlane(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.farClipPlane);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_farClipPlane(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.farClipPlane=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_fieldOfView(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fieldOfView);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fieldOfView(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.fieldOfView=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderingPath(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.renderingPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_renderingPath(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.RenderingPath v;
			checkEnum(l,2,out v);
			self.renderingPath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_actualRenderingPath(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.actualRenderingPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_allowHDR(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.allowHDR);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_allowHDR(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.allowHDR=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_allowMSAA(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.allowMSAA);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_allowMSAA(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.allowMSAA=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_allowDynamicResolution(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.allowDynamicResolution);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_allowDynamicResolution(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.allowDynamicResolution=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_forceIntoRenderTexture(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.forceIntoRenderTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_forceIntoRenderTexture(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.forceIntoRenderTexture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_orthographicSize(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.orthographicSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_orthographicSize(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.orthographicSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_orthographic(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.orthographic);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_orthographic(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.orthographic=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_opaqueSortMode(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.opaqueSortMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_opaqueSortMode(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Rendering.OpaqueSortMode v;
			checkEnum(l,2,out v);
			self.opaqueSortMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_transparencySortMode(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.transparencySortMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_transparencySortMode(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.TransparencySortMode v;
			checkEnum(l,2,out v);
			self.transparencySortMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_transparencySortAxis(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.transparencySortAxis);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_transparencySortAxis(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.transparencySortAxis=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depth(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.depth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_depth(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.depth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_aspect(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.aspect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_aspect(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.aspect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_velocity(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.velocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cullingMask(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cullingMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cullingMask(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.cullingMask=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_eventMask(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.eventMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_eventMask(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.eventMask=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_layerCullSpherical(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.layerCullSpherical);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_layerCullSpherical(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.layerCullSpherical=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cameraType(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.cameraType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cameraType(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.CameraType v;
			checkEnum(l,2,out v);
			self.cameraType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_layerCullDistances(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.layerCullDistances);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_layerCullDistances(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			System.Single[] v;
			checkArray(l,2,out v);
			self.layerCullDistances=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useOcclusionCulling(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useOcclusionCulling);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useOcclusionCulling(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useOcclusionCulling=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cullingMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cullingMatrix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cullingMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Matrix4x4 v;
			checkValueType(l,2,out v);
			self.cullingMatrix=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_backgroundColor(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.backgroundColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_backgroundColor(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.backgroundColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_clearFlags(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.clearFlags);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_clearFlags(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.CameraClearFlags v;
			checkEnum(l,2,out v);
			self.clearFlags=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depthTextureMode(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.depthTextureMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_depthTextureMode(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.DepthTextureMode v;
			checkEnum(l,2,out v);
			self.depthTextureMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_clearStencilAfterLightingPass(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clearStencilAfterLightingPass);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_clearStencilAfterLightingPass(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.clearStencilAfterLightingPass=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_usePhysicalProperties(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.usePhysicalProperties);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_usePhysicalProperties(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.usePhysicalProperties=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sensorSize(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sensorSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sensorSize(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.sensorSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lensShift(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lensShift);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lensShift(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.lensShift=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_focalLength(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.focalLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_focalLength(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.focalLength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_gateFit(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.gateFit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_gateFit(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Camera.GateFitMode v;
			checkEnum(l,2,out v);
			self.gateFit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rect(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rect(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Rect v;
			checkValueType(l,2,out v);
			self.rect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pixelRect(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pixelRect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pixelRect(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Rect v;
			checkValueType(l,2,out v);
			self.pixelRect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pixelWidth(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pixelWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pixelHeight(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pixelHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_scaledPixelWidth(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scaledPixelWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_scaledPixelHeight(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scaledPixelHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_targetTexture(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.targetTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_targetTexture(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.RenderTexture v;
			checkType(l,2,out v);
			self.targetTexture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_activeTexture(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.activeTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_targetDisplay(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.targetDisplay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_targetDisplay(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.targetDisplay=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cameraToWorldMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cameraToWorldMatrix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_worldToCameraMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.worldToCameraMatrix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_worldToCameraMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Matrix4x4 v;
			checkValueType(l,2,out v);
			self.worldToCameraMatrix=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_projectionMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.projectionMatrix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_projectionMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Matrix4x4 v;
			checkValueType(l,2,out v);
			self.projectionMatrix=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_nonJitteredProjectionMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.nonJitteredProjectionMatrix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_nonJitteredProjectionMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.Matrix4x4 v;
			checkValueType(l,2,out v);
			self.nonJitteredProjectionMatrix=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useJitteredProjectionMatrixForTransparentRendering(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useJitteredProjectionMatrixForTransparentRendering);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useJitteredProjectionMatrixForTransparentRendering(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useJitteredProjectionMatrixForTransparentRendering=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_previousViewProjectionMatrix(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.previousViewProjectionMatrix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_main(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Camera.main);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_current(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Camera.current);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_scene(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scene);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_scene(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.SceneManagement.Scene v;
			checkValueType(l,2,out v);
			self.scene=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_stereoEnabled(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stereoEnabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_stereoSeparation(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stereoSeparation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_stereoSeparation(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.stereoSeparation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_stereoConvergence(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stereoConvergence);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_stereoConvergence(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.stereoConvergence=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_areVRStereoViewMatricesWithinSingleCullTolerance(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.areVRStereoViewMatricesWithinSingleCullTolerance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_stereoTargetEye(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.stereoTargetEye);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_stereoTargetEye(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			UnityEngine.StereoTargetEyeMask v;
			checkEnum(l,2,out v);
			self.stereoTargetEye=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_stereoActiveEye(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.stereoActiveEye);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_allCamerasCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Camera.allCamerasCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_allCameras(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Camera.allCameras);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_commandBufferCount(IntPtr l) {
		try {
			UnityEngine.Camera self=(UnityEngine.Camera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.commandBufferCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Camera");
		addMember(l,Reset);
		addMember(l,ResetTransparencySortSettings);
		addMember(l,ResetAspect);
		addMember(l,ResetCullingMatrix);
		addMember(l,SetReplacementShader);
		addMember(l,ResetReplacementShader);
		addMember(l,SetTargetBuffers__RenderBuffer__RenderBuffer);
		addMember(l,SetTargetBuffers__A_RenderBuffer__RenderBuffer);
		addMember(l,ResetWorldToCameraMatrix);
		addMember(l,ResetProjectionMatrix);
		addMember(l,CalculateObliqueMatrix);
		addMember(l,WorldToScreenPoint__Vector3);
		addMember(l,WorldToScreenPoint__Vector3__MonoOrStereoscopicEye);
		addMember(l,WorldToViewportPoint__Vector3);
		addMember(l,WorldToViewportPoint__Vector3__MonoOrStereoscopicEye);
		addMember(l,ViewportToWorldPoint__Vector3);
		addMember(l,ViewportToWorldPoint__Vector3__MonoOrStereoscopicEye);
		addMember(l,ScreenToWorldPoint__Vector3);
		addMember(l,ScreenToWorldPoint__Vector3__MonoOrStereoscopicEye);
		addMember(l,ScreenToViewportPoint);
		addMember(l,ViewportToScreenPoint);
		addMember(l,ViewportPointToRay__Vector3);
		addMember(l,ViewportPointToRay__Vector3__MonoOrStereoscopicEye);
		addMember(l,ScreenPointToRay__Vector3);
		addMember(l,ScreenPointToRay__Vector3__MonoOrStereoscopicEye);
		addMember(l,CalculateFrustumCorners);
		addMember(l,GetStereoNonJitteredProjectionMatrix);
		addMember(l,GetStereoViewMatrix);
		addMember(l,CopyStereoDeviceProjectionMatrixToNonJittered);
		addMember(l,GetStereoProjectionMatrix);
		addMember(l,SetStereoProjectionMatrix);
		addMember(l,ResetStereoProjectionMatrices);
		addMember(l,SetStereoViewMatrix);
		addMember(l,ResetStereoViewMatrices);
		addMember(l,GetLODMasks);
		addMember(l,GetVisibleLODGroupCount);
		addMember(l,GetVisibleLODGroupAt);
		addMember(l,GetVisibleLODGroup);
		addMember(l,RenderToCubemap__Cubemap);
		addMember(l,RenderToCubemap__RenderTexture);
		addMember(l,RenderToCubemap__Cubemap__Int32);
		addMember(l,RenderToCubemap__RenderTexture__Int32);
		addMember(l,RenderToCubemap__RenderTexture__Int32__MonoOrStereoscopicEye);
		addMember(l,Render);
		addMember(l,RenderWithShader);
		addMember(l,RenderDontRestore);
		addMember(l,CopyFrom);
		addMember(l,RemoveCommandBuffers);
		addMember(l,RemoveAllCommandBuffers);
		addMember(l,AddCommandBuffer);
		addMember(l,AddCommandBufferAsync);
		addMember(l,RemoveCommandBuffer);
		addMember(l,GetCommandBuffers);
		addMember(l,CalculateProjectionMatrixFromPhysicalProperties_s);
		addMember(l,FocalLengthToFOV_s);
		addMember(l,FOVToFocalLength_s);
		addMember(l,GetAllCameras_s);
		addMember(l,SetupCurrent_s);
		addMember(l,"onPreCull",null,set_onPreCull,false);
		addMember(l,"onPreRender",null,set_onPreRender,false);
		addMember(l,"onPostRender",null,set_onPostRender,false);
		addMember(l,"nearClipPlane",get_nearClipPlane,set_nearClipPlane,true);
		addMember(l,"farClipPlane",get_farClipPlane,set_farClipPlane,true);
		addMember(l,"fieldOfView",get_fieldOfView,set_fieldOfView,true);
		addMember(l,"renderingPath",get_renderingPath,set_renderingPath,true);
		addMember(l,"actualRenderingPath",get_actualRenderingPath,null,true);
		addMember(l,"allowHDR",get_allowHDR,set_allowHDR,true);
		addMember(l,"allowMSAA",get_allowMSAA,set_allowMSAA,true);
		addMember(l,"allowDynamicResolution",get_allowDynamicResolution,set_allowDynamicResolution,true);
		addMember(l,"forceIntoRenderTexture",get_forceIntoRenderTexture,set_forceIntoRenderTexture,true);
		addMember(l,"orthographicSize",get_orthographicSize,set_orthographicSize,true);
		addMember(l,"orthographic",get_orthographic,set_orthographic,true);
		addMember(l,"opaqueSortMode",get_opaqueSortMode,set_opaqueSortMode,true);
		addMember(l,"transparencySortMode",get_transparencySortMode,set_transparencySortMode,true);
		addMember(l,"transparencySortAxis",get_transparencySortAxis,set_transparencySortAxis,true);
		addMember(l,"depth",get_depth,set_depth,true);
		addMember(l,"aspect",get_aspect,set_aspect,true);
		addMember(l,"velocity",get_velocity,null,true);
		addMember(l,"cullingMask",get_cullingMask,set_cullingMask,true);
		addMember(l,"eventMask",get_eventMask,set_eventMask,true);
		addMember(l,"layerCullSpherical",get_layerCullSpherical,set_layerCullSpherical,true);
		addMember(l,"cameraType",get_cameraType,set_cameraType,true);
		addMember(l,"layerCullDistances",get_layerCullDistances,set_layerCullDistances,true);
		addMember(l,"useOcclusionCulling",get_useOcclusionCulling,set_useOcclusionCulling,true);
		addMember(l,"cullingMatrix",get_cullingMatrix,set_cullingMatrix,true);
		addMember(l,"backgroundColor",get_backgroundColor,set_backgroundColor,true);
		addMember(l,"clearFlags",get_clearFlags,set_clearFlags,true);
		addMember(l,"depthTextureMode",get_depthTextureMode,set_depthTextureMode,true);
		addMember(l,"clearStencilAfterLightingPass",get_clearStencilAfterLightingPass,set_clearStencilAfterLightingPass,true);
		addMember(l,"usePhysicalProperties",get_usePhysicalProperties,set_usePhysicalProperties,true);
		addMember(l,"sensorSize",get_sensorSize,set_sensorSize,true);
		addMember(l,"lensShift",get_lensShift,set_lensShift,true);
		addMember(l,"focalLength",get_focalLength,set_focalLength,true);
		addMember(l,"gateFit",get_gateFit,set_gateFit,true);
		addMember(l,"rect",get_rect,set_rect,true);
		addMember(l,"pixelRect",get_pixelRect,set_pixelRect,true);
		addMember(l,"pixelWidth",get_pixelWidth,null,true);
		addMember(l,"pixelHeight",get_pixelHeight,null,true);
		addMember(l,"scaledPixelWidth",get_scaledPixelWidth,null,true);
		addMember(l,"scaledPixelHeight",get_scaledPixelHeight,null,true);
		addMember(l,"targetTexture",get_targetTexture,set_targetTexture,true);
		addMember(l,"activeTexture",get_activeTexture,null,true);
		addMember(l,"targetDisplay",get_targetDisplay,set_targetDisplay,true);
		addMember(l,"cameraToWorldMatrix",get_cameraToWorldMatrix,null,true);
		addMember(l,"worldToCameraMatrix",get_worldToCameraMatrix,set_worldToCameraMatrix,true);
		addMember(l,"projectionMatrix",get_projectionMatrix,set_projectionMatrix,true);
		addMember(l,"nonJitteredProjectionMatrix",get_nonJitteredProjectionMatrix,set_nonJitteredProjectionMatrix,true);
		addMember(l,"useJitteredProjectionMatrixForTransparentRendering",get_useJitteredProjectionMatrixForTransparentRendering,set_useJitteredProjectionMatrixForTransparentRendering,true);
		addMember(l,"previousViewProjectionMatrix",get_previousViewProjectionMatrix,null,true);
		addMember(l,"main",get_main,null,false);
		addMember(l,"current",get_current,null,false);
		addMember(l,"scene",get_scene,set_scene,true);
		addMember(l,"stereoEnabled",get_stereoEnabled,null,true);
		addMember(l,"stereoSeparation",get_stereoSeparation,set_stereoSeparation,true);
		addMember(l,"stereoConvergence",get_stereoConvergence,set_stereoConvergence,true);
		addMember(l,"areVRStereoViewMatricesWithinSingleCullTolerance",get_areVRStereoViewMatricesWithinSingleCullTolerance,null,true);
		addMember(l,"stereoTargetEye",get_stereoTargetEye,set_stereoTargetEye,true);
		addMember(l,"stereoActiveEye",get_stereoActiveEye,null,true);
		addMember(l,"allCamerasCount",get_allCamerasCount,null,false);
		addMember(l,"allCameras",get_allCameras,null,false);
		addMember(l,"commandBufferCount",get_commandBufferCount,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Camera),typeof(UnityEngine.Behaviour));
	}
}
