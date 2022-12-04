using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_FilteringSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.FilteringSettings o;
			o=new UnityEngine.Rendering.FilteringSettings();
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
	static public int Equals__FilteringSettings(IntPtr l) {
		try {
			UnityEngine.Rendering.FilteringSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.FilteringSettings a1;
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
			UnityEngine.Rendering.FilteringSettings self;
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
	static public int op_Equality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.FilteringSettings a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.FilteringSettings a2;
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
			UnityEngine.Rendering.FilteringSettings a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.FilteringSettings a2;
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultValue(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.FilteringSettings.defaultValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderQueueRange(IntPtr l) {
		try {
			UnityEngine.Rendering.FilteringSettings self;
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
			UnityEngine.Rendering.FilteringSettings self;
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
	static public int get_layerMask(IntPtr l) {
		try {
			UnityEngine.Rendering.FilteringSettings self;
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
			UnityEngine.Rendering.FilteringSettings self;
			checkValueType(l,1,out self);
			int v;
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
	static public int get_renderingLayerMask(IntPtr l) {
		try {
			UnityEngine.Rendering.FilteringSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.renderingLayerMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_renderingLayerMask(IntPtr l) {
		try {
			UnityEngine.Rendering.FilteringSettings self;
			checkValueType(l,1,out self);
			System.UInt32 v;
			checkType(l,2,out v);
			self.renderingLayerMask=v;
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
	static public int get_excludeMotionVectorObjects(IntPtr l) {
		try {
			UnityEngine.Rendering.FilteringSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.excludeMotionVectorObjects);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_excludeMotionVectorObjects(IntPtr l) {
		try {
			UnityEngine.Rendering.FilteringSettings self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.excludeMotionVectorObjects=v;
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
	static public int get_sortingLayerRange(IntPtr l) {
		try {
			UnityEngine.Rendering.FilteringSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sortingLayerRange);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sortingLayerRange(IntPtr l) {
		try {
			UnityEngine.Rendering.FilteringSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.SortingLayerRange v;
			checkValueType(l,2,out v);
			self.sortingLayerRange=v;
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
		getTypeTable(l,"UnityEngine.Rendering.FilteringSettings");
		addMember(l,ctor_s);
		addMember(l,Equals__FilteringSettings);
		addMember(l,Equals__Object);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"defaultValue",get_defaultValue,null,false);
		addMember(l,"renderQueueRange",get_renderQueueRange,set_renderQueueRange,true);
		addMember(l,"layerMask",get_layerMask,set_layerMask,true);
		addMember(l,"renderingLayerMask",get_renderingLayerMask,set_renderingLayerMask,true);
		addMember(l,"excludeMotionVectorObjects",get_excludeMotionVectorObjects,set_excludeMotionVectorObjects,true);
		addMember(l,"sortingLayerRange",get_sortingLayerRange,set_sortingLayerRange,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.FilteringSettings),typeof(System.ValueType));
	}
}
