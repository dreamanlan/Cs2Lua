using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_ShadowDrawingSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.ShadowDrawingSettings o;
			o=new UnityEngine.Rendering.ShadowDrawingSettings();
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
	static public int ctor__CullingResults__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rendering.ShadowDrawingSettings o;
			UnityEngine.Rendering.CullingResults a1;
			checkValueType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Rendering.ShadowDrawingSettings(a1,a2);
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
	static public int Equals__ShadowDrawingSettings(IntPtr l) {
		try {
			UnityEngine.Rendering.ShadowDrawingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.ShadowDrawingSettings a1;
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
			UnityEngine.Rendering.ShadowDrawingSettings self;
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
			UnityEngine.Rendering.ShadowDrawingSettings a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.ShadowDrawingSettings a2;
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
			UnityEngine.Rendering.ShadowDrawingSettings a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.ShadowDrawingSettings a2;
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
	static public int get_cullingResults(IntPtr l) {
		try {
			UnityEngine.Rendering.ShadowDrawingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.cullingResults);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cullingResults(IntPtr l) {
		try {
			UnityEngine.Rendering.ShadowDrawingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CullingResults v;
			checkValueType(l,2,out v);
			self.cullingResults=v;
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
	static public int get_lightIndex(IntPtr l) {
		try {
			UnityEngine.Rendering.ShadowDrawingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lightIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightIndex(IntPtr l) {
		try {
			UnityEngine.Rendering.ShadowDrawingSettings self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.lightIndex=v;
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
	static public int get_useRenderingLayerMaskTest(IntPtr l) {
		try {
			UnityEngine.Rendering.ShadowDrawingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.useRenderingLayerMaskTest);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useRenderingLayerMaskTest(IntPtr l) {
		try {
			UnityEngine.Rendering.ShadowDrawingSettings self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.useRenderingLayerMaskTest=v;
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
	static public int get_splitData(IntPtr l) {
		try {
			UnityEngine.Rendering.ShadowDrawingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.splitData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_splitData(IntPtr l) {
		try {
			UnityEngine.Rendering.ShadowDrawingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.ShadowSplitData v;
			checkValueType(l,2,out v);
			self.splitData=v;
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
	static public int get_objectsFilter(IntPtr l) {
		try {
			UnityEngine.Rendering.ShadowDrawingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.objectsFilter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_objectsFilter(IntPtr l) {
		try {
			UnityEngine.Rendering.ShadowDrawingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.ShadowObjectsFilter v;
			checkEnum(l,2,out v);
			self.objectsFilter=v;
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
		getTypeTable(l,"UnityEngine.Rendering.ShadowDrawingSettings");
		addMember(l,ctor_s);
		addMember(l,ctor__CullingResults__Int32_s);
		addMember(l,Equals__ShadowDrawingSettings);
		addMember(l,Equals__Object);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"cullingResults",get_cullingResults,set_cullingResults,true);
		addMember(l,"lightIndex",get_lightIndex,set_lightIndex,true);
		addMember(l,"useRenderingLayerMaskTest",get_useRenderingLayerMaskTest,set_useRenderingLayerMaskTest,true);
		addMember(l,"splitData",get_splitData,set_splitData,true);
		addMember(l,"objectsFilter",get_objectsFilter,set_objectsFilter,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.ShadowDrawingSettings),typeof(System.ValueType));
	}
}
