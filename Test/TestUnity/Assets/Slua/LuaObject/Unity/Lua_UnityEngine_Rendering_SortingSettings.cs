using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_SortingSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingSettings o;
			o=new UnityEngine.Rendering.SortingSettings();
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
	static public int ctor__Camera_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingSettings o;
			UnityEngine.Camera a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Rendering.SortingSettings(a1);
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
	static public int Equals__SortingSettings(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.SortingSettings a1;
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
			UnityEngine.Rendering.SortingSettings self;
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
			UnityEngine.Rendering.SortingSettings a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.SortingSettings a2;
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
			UnityEngine.Rendering.SortingSettings a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.SortingSettings a2;
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
	static public int get_worldToCameraMatrix(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingSettings self;
			checkValueType(l,1,out self);
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
			UnityEngine.Rendering.SortingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Matrix4x4 v;
			checkValueType(l,2,out v);
			self.worldToCameraMatrix=v;
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
			UnityEngine.Rendering.SortingSettings self;
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
			UnityEngine.Rendering.SortingSettings self;
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
	static public int get_customAxis(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.customAxis);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_customAxis(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.customAxis=v;
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
	static public int get_criteria(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.criteria);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_criteria(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.SortingCriteria v;
			checkEnum(l,2,out v);
			self.criteria=v;
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
	static public int get_distanceMetric(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.distanceMetric);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_distanceMetric(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.DistanceMetric v;
			checkEnum(l,2,out v);
			self.distanceMetric=v;
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
		getTypeTable(l,"UnityEngine.Rendering.SortingSettings");
		addMember(l,ctor_s);
		addMember(l,ctor__Camera_s);
		addMember(l,Equals__SortingSettings);
		addMember(l,Equals__Object);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"worldToCameraMatrix",get_worldToCameraMatrix,set_worldToCameraMatrix,true);
		addMember(l,"cameraPosition",get_cameraPosition,set_cameraPosition,true);
		addMember(l,"customAxis",get_customAxis,set_customAxis,true);
		addMember(l,"criteria",get_criteria,set_criteria,true);
		addMember(l,"distanceMetric",get_distanceMetric,set_distanceMetric,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.SortingSettings),typeof(System.ValueType));
	}
}
