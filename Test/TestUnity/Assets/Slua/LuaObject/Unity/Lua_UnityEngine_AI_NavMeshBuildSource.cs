using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_NavMeshBuildSource : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSource o;
			o=new UnityEngine.AI.NavMeshBuildSource();
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
	static public int get_transform(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSource self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.transform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_transform(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSource self;
			checkValueType(l,1,out self);
			UnityEngine.Matrix4x4 v;
			checkValueType(l,2,out v);
			self.transform=v;
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
	static public int get_size(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSource self;
			checkValueType(l,1,out self);
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
			UnityEngine.AI.NavMeshBuildSource self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.size=v;
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
	static public int get_shape(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSource self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.shape);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shape(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSource self;
			checkValueType(l,1,out self);
			UnityEngine.AI.NavMeshBuildSourceShape v;
			checkEnum(l,2,out v);
			self.shape=v;
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
	static public int get_area(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSource self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.area);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_area(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSource self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.area=v;
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
	static public int get_sourceObject(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSource self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sourceObject);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sourceObject(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSource self;
			checkValueType(l,1,out self);
			UnityEngine.Object v;
			checkType(l,2,out v);
			self.sourceObject=v;
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
	static public int get_component(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSource self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.component);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_component(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSource self;
			checkValueType(l,1,out self);
			UnityEngine.Component v;
			checkType(l,2,out v);
			self.component=v;
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
		getTypeTable(l,"UnityEngine.AI.NavMeshBuildSource");
		addMember(l,"transform",get_transform,set_transform,true);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"shape",get_shape,set_shape,true);
		addMember(l,"area",get_area,set_area,true);
		addMember(l,"sourceObject",get_sourceObject,set_sourceObject,true);
		addMember(l,"component",get_component,set_component,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AI.NavMeshBuildSource),typeof(System.ValueType));
	}
}
