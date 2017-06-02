using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_VisibleReflectionProbe : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe o;
			o=new UnityEngine.Experimental.Rendering.VisibleReflectionProbe();
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
	static public int get_bounds(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
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
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			UnityEngine.Bounds v;
			checkValueType(l,2,out v);
			self.bounds=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_localToWorld(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.localToWorld);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_localToWorld(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			UnityEngine.Matrix4x4 v;
			checkValueType(l,2,out v);
			self.localToWorld=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hdr(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
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
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			UnityEngine.Vector4 v;
			checkType(l,2,out v);
			self.hdr=v;
			setBack(l,self);
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
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
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
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.center=v;
			setBack(l,self);
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
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
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
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.blendDistance=v;
			setBack(l,self);
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
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
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
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.importance=v;
			setBack(l,self);
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
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
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
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.boxProjection=v;
			setBack(l,self);
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
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
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
	static public int get_probe(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleReflectionProbe self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.probe);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.VisibleReflectionProbe");
		addMember(l,"bounds",get_bounds,set_bounds,true);
		addMember(l,"localToWorld",get_localToWorld,set_localToWorld,true);
		addMember(l,"hdr",get_hdr,set_hdr,true);
		addMember(l,"center",get_center,set_center,true);
		addMember(l,"blendDistance",get_blendDistance,set_blendDistance,true);
		addMember(l,"importance",get_importance,set_importance,true);
		addMember(l,"boxProjection",get_boxProjection,set_boxProjection,true);
		addMember(l,"texture",get_texture,null,true);
		addMember(l,"probe",get_probe,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.VisibleReflectionProbe),typeof(System.ValueType));
	}
}
