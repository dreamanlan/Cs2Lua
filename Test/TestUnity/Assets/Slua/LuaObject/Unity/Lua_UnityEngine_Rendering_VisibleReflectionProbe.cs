using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_VisibleReflectionProbe : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe o;
			o=new UnityEngine.Rendering.VisibleReflectionProbe();
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
	static public int Equals__VisibleReflectionProbe(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.VisibleReflectionProbe a1;
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
			UnityEngine.Rendering.VisibleReflectionProbe self;
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
			UnityEngine.Rendering.VisibleReflectionProbe a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.VisibleReflectionProbe a2;
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
			UnityEngine.Rendering.VisibleReflectionProbe a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.VisibleReflectionProbe a2;
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
	static public int get_texture(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
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
	static public int get_reflectionProbe(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.reflectionProbe);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bounds(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
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
	static public int set_bounds(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			UnityEngine.Bounds v;
			checkValueType(l,2,out v);
			self.bounds=v;
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
	static public int get_localToWorldMatrix(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.localToWorldMatrix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_localToWorldMatrix(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			UnityEngine.Matrix4x4 v;
			checkValueType(l,2,out v);
			self.localToWorldMatrix=v;
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
	static public int get_hdrData(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.hdrData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_hdrData(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			UnityEngine.Vector4 v;
			checkType(l,2,out v);
			self.hdrData=v;
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
	static public int get_center(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
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
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.center=v;
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
	static public int get_blendDistance(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
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
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.blendDistance=v;
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
	static public int get_importance(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
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
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.importance=v;
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
	static public int get_isBoxProjection(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.isBoxProjection);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isBoxProjection(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.isBoxProjection=v;
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
		getTypeTable(l,"UnityEngine.Rendering.VisibleReflectionProbe");
		addMember(l,ctor_s);
		addMember(l,Equals__VisibleReflectionProbe);
		addMember(l,Equals__Object);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"texture",get_texture,null,true);
		addMember(l,"reflectionProbe",get_reflectionProbe,null,true);
		addMember(l,"bounds",get_bounds,set_bounds,true);
		addMember(l,"localToWorldMatrix",get_localToWorldMatrix,set_localToWorldMatrix,true);
		addMember(l,"hdrData",get_hdrData,set_hdrData,true);
		addMember(l,"center",get_center,set_center,true);
		addMember(l,"blendDistance",get_blendDistance,set_blendDistance,true);
		addMember(l,"importance",get_importance,set_importance,true);
		addMember(l,"isBoxProjection",get_isBoxProjection,set_isBoxProjection,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.VisibleReflectionProbe),typeof(System.ValueType));
	}
}
