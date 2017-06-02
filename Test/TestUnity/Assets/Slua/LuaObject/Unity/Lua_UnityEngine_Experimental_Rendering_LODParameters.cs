using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_LODParameters : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.LODParameters o;
			o=new UnityEngine.Experimental.Rendering.LODParameters();
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
	static public int get_isOrthographic(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.LODParameters self;
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
			UnityEngine.Experimental.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.isOrthographic=v;
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
	static public int get_cameraPosition(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.LODParameters self;
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
			UnityEngine.Experimental.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.cameraPosition=v;
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
	static public int get_fieldOfView(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.LODParameters self;
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
			UnityEngine.Experimental.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.fieldOfView=v;
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
	static public int get_orthoSize(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.LODParameters self;
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
			UnityEngine.Experimental.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.orthoSize=v;
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
	static public int get_cameraPixelHeight(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.LODParameters self;
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
			UnityEngine.Experimental.Rendering.LODParameters self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.cameraPixelHeight=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.LODParameters");
		addMember(l,"isOrthographic",get_isOrthographic,set_isOrthographic,true);
		addMember(l,"cameraPosition",get_cameraPosition,set_cameraPosition,true);
		addMember(l,"fieldOfView",get_fieldOfView,set_fieldOfView,true);
		addMember(l,"orthoSize",get_orthoSize,set_orthoSize,true);
		addMember(l,"cameraPixelHeight",get_cameraPixelHeight,set_cameraPixelHeight,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.LODParameters),typeof(System.ValueType));
	}
}
