using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RendererUtils_RendererListDesc : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc o;
			o=new UnityEngine.Rendering.RendererUtils.RendererListDesc();
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
	static public int ctor__ShaderTagId__CullingResults__Camera_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc o;
			UnityEngine.Rendering.ShaderTagId a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.CullingResults a2;
			checkValueType(l,2,out a2);
			UnityEngine.Camera a3;
			checkType(l,3,out a3);
			o=new UnityEngine.Rendering.RendererUtils.RendererListDesc(a1,a2,a3);
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
	static public int ctor__A_ShaderTagId__CullingResults__Camera_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc o;
			UnityEngine.Rendering.ShaderTagId[] a1;
			checkArray(l,1,out a1);
			UnityEngine.Rendering.CullingResults a2;
			checkValueType(l,2,out a2);
			UnityEngine.Camera a3;
			checkType(l,3,out a3);
			o=new UnityEngine.Rendering.RendererUtils.RendererListDesc(a1,a2,a3);
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
	static public int IsValid(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			var ret=self.IsValid();
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
	static public int get_sortingCriteria(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.sortingCriteria);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sortingCriteria(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.SortingCriteria v;
			checkEnum(l,2,out v);
			self.sortingCriteria=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rendererConfiguration(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.rendererConfiguration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rendererConfiguration(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.PerObjectData v;
			checkEnum(l,2,out v);
			self.rendererConfiguration=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderQueueRange(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.renderQueueRange);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_renderQueueRange(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderQueueRange v;
			checkValueType(l,2,out v);
			self.renderQueueRange=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overrideMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.overrideMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overrideMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			UnityEngine.Material v;
			checkType(l,2,out v);
			self.overrideMaterial=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_excludeObjectMotionVectors(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.excludeObjectMotionVectors);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_excludeObjectMotionVectors(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.excludeObjectMotionVectors=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_layerMask(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.layerMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_layerMask(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.layerMask=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overrideMaterialPassIndex(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.overrideMaterialPassIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overrideMaterialPassIndex(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererListDesc self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.overrideMaterialPassIndex=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.RendererUtils.RendererListDesc");
		addMember(l,ctor_s);
		addMember(l,ctor__ShaderTagId__CullingResults__Camera_s);
		addMember(l,ctor__A_ShaderTagId__CullingResults__Camera_s);
		addMember(l,IsValid);
		addMember(l,"sortingCriteria",get_sortingCriteria,set_sortingCriteria,true);
		addMember(l,"rendererConfiguration",get_rendererConfiguration,set_rendererConfiguration,true);
		addMember(l,"renderQueueRange",get_renderQueueRange,set_renderQueueRange,true);
		addMember(l,"overrideMaterial",get_overrideMaterial,set_overrideMaterial,true);
		addMember(l,"excludeObjectMotionVectors",get_excludeObjectMotionVectors,set_excludeObjectMotionVectors,true);
		addMember(l,"layerMask",get_layerMask,set_layerMask,true);
		addMember(l,"overrideMaterialPassIndex",get_overrideMaterialPassIndex,set_overrideMaterialPassIndex,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.RendererUtils.RendererListDesc),typeof(System.ValueType));
	}
}
