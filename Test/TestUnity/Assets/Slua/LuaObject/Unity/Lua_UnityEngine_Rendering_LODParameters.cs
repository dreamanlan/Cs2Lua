using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_LODParameters : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.LODParameters o;
			o=new UnityEngine.Rendering.LODParameters();
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
	static public int Equals__LODParameters(IntPtr l) {
		try {
			UnityEngine.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.LODParameters a1;
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
			UnityEngine.Rendering.LODParameters self;
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
			UnityEngine.Rendering.LODParameters a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.LODParameters a2;
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
			UnityEngine.Rendering.LODParameters a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.LODParameters a2;
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
	static public int get_isOrthographic(IntPtr l) {
		try {
			UnityEngine.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.isOrthographic);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isOrthographic(IntPtr l) {
		try {
			UnityEngine.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.isOrthographic=v;
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
	static public int get_cameraPosition(IntPtr l) {
		try {
			UnityEngine.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.cameraPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cameraPosition(IntPtr l) {
		try {
			UnityEngine.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.cameraPosition=v;
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
	static public int get_fieldOfView(IntPtr l) {
		try {
			UnityEngine.Rendering.LODParameters self;
			checkValueType(l,1,out self);
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
			UnityEngine.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.fieldOfView=v;
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
	static public int get_orthoSize(IntPtr l) {
		try {
			UnityEngine.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.orthoSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_orthoSize(IntPtr l) {
		try {
			UnityEngine.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.orthoSize=v;
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
	static public int get_cameraPixelHeight(IntPtr l) {
		try {
			UnityEngine.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.cameraPixelHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cameraPixelHeight(IntPtr l) {
		try {
			UnityEngine.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.cameraPixelHeight=v;
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
		getTypeTable(l,"UnityEngine.Rendering.LODParameters");
		addMember(l,ctor_s);
		addMember(l,Equals__LODParameters);
		addMember(l,Equals__Object);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"isOrthographic",get_isOrthographic,set_isOrthographic,true);
		addMember(l,"cameraPosition",get_cameraPosition,set_cameraPosition,true);
		addMember(l,"fieldOfView",get_fieldOfView,set_fieldOfView,true);
		addMember(l,"orthoSize",get_orthoSize,set_orthoSize,true);
		addMember(l,"cameraPixelHeight",get_cameraPixelHeight,set_cameraPixelHeight,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.LODParameters),typeof(System.ValueType));
	}
}
