﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ReflectionProbe : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Reset(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
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
	static public int RenderProbe(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			var ret=self.RenderProbe();
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
	static public int RenderProbe__RenderTexture(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.RenderTexture a1;
			checkType(l,2,out a1);
			var ret=self.RenderProbe(a1);
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
	static public int IsFinishedRendering(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.IsFinishedRendering(a1);
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
	static public int BlendCubemap_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.RenderTexture a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.ReflectionProbe.BlendCubemap(a1,a2,a3,a4);
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
	static public int UpdateCachedState_s(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe.UpdateCachedState();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_size(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.size);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_size(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.size=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_center(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.center);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_center(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.center=v;
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
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
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
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
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
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
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
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
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
	static public int get_intensity(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.intensity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_intensity(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.intensity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bounds(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bounds);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hdr(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hdr);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_hdr(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.hdr=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderDynamicObjects(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.renderDynamicObjects);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_renderDynamicObjects(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.renderDynamicObjects=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_shadowDistance(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shadowDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shadowDistance(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.shadowDistance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_resolution(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.resolution);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_resolution(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.resolution=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cullingMask(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
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
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
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
	static public int get_clearFlags(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
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
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Rendering.ReflectionProbeClearFlags v;
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
	static public int get_backgroundColor(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
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
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
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
	static public int get_blendDistance(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.blendDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_blendDistance(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.blendDistance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_boxProjection(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.boxProjection);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_boxProjection(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.boxProjection=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mode(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mode(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Rendering.ReflectionProbeMode v;
			checkEnum(l,2,out v);
			self.mode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_importance(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.importance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_importance(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.importance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_refreshMode(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.refreshMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_refreshMode(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Rendering.ReflectionProbeRefreshMode v;
			checkEnum(l,2,out v);
			self.refreshMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_timeSlicingMode(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.timeSlicingMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_timeSlicingMode(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Rendering.ReflectionProbeTimeSlicingMode v;
			checkEnum(l,2,out v);
			self.timeSlicingMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bakedTexture(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bakedTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bakedTexture(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Texture v;
			checkType(l,2,out v);
			self.bakedTexture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_customBakedTexture(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.customBakedTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_customBakedTexture(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Texture v;
			checkType(l,2,out v);
			self.customBakedTexture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_realtimeTexture(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.realtimeTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_realtimeTexture(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.RenderTexture v;
			checkType(l,2,out v);
			self.realtimeTexture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_texture(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.texture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_textureHDRDecodeValues(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textureHDRDecodeValues);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_minBakedCubemapResolution(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.ReflectionProbe.minBakedCubemapResolution);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maxBakedCubemapResolution(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.ReflectionProbe.maxBakedCubemapResolution);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultTextureHDRDecodeValues(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.ReflectionProbe.defaultTextureHDRDecodeValues);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultTexture(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.ReflectionProbe.defaultTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ReflectionProbe");
		addMember(l,Reset);
		addMember(l,RenderProbe);
		addMember(l,RenderProbe__RenderTexture);
		addMember(l,IsFinishedRendering);
		addMember(l,BlendCubemap_s);
		addMember(l,UpdateCachedState_s);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"center",get_center,set_center,true);
		addMember(l,"nearClipPlane",get_nearClipPlane,set_nearClipPlane,true);
		addMember(l,"farClipPlane",get_farClipPlane,set_farClipPlane,true);
		addMember(l,"intensity",get_intensity,set_intensity,true);
		addMember(l,"bounds",get_bounds,null,true);
		addMember(l,"hdr",get_hdr,set_hdr,true);
		addMember(l,"renderDynamicObjects",get_renderDynamicObjects,set_renderDynamicObjects,true);
		addMember(l,"shadowDistance",get_shadowDistance,set_shadowDistance,true);
		addMember(l,"resolution",get_resolution,set_resolution,true);
		addMember(l,"cullingMask",get_cullingMask,set_cullingMask,true);
		addMember(l,"clearFlags",get_clearFlags,set_clearFlags,true);
		addMember(l,"backgroundColor",get_backgroundColor,set_backgroundColor,true);
		addMember(l,"blendDistance",get_blendDistance,set_blendDistance,true);
		addMember(l,"boxProjection",get_boxProjection,set_boxProjection,true);
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"importance",get_importance,set_importance,true);
		addMember(l,"refreshMode",get_refreshMode,set_refreshMode,true);
		addMember(l,"timeSlicingMode",get_timeSlicingMode,set_timeSlicingMode,true);
		addMember(l,"bakedTexture",get_bakedTexture,set_bakedTexture,true);
		addMember(l,"customBakedTexture",get_customBakedTexture,set_customBakedTexture,true);
		addMember(l,"realtimeTexture",get_realtimeTexture,set_realtimeTexture,true);
		addMember(l,"texture",get_texture,null,true);
		addMember(l,"textureHDRDecodeValues",get_textureHDRDecodeValues,null,true);
		addMember(l,"minBakedCubemapResolution",get_minBakedCubemapResolution,null,false);
		addMember(l,"maxBakedCubemapResolution",get_maxBakedCubemapResolution,null,false);
		addMember(l,"defaultTextureHDRDecodeValues",get_defaultTextureHDRDecodeValues,null,false);
		addMember(l,"defaultTexture",get_defaultTexture,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.ReflectionProbe),typeof(UnityEngine.Behaviour));
	}
}
