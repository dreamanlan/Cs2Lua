using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_CapsulecastCommand : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand o;
			o=new UnityEngine.CapsulecastCommand();
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
	static public int ctor__Vector3__Vector3__Single__Vector3__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand o;
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			o=new UnityEngine.CapsulecastCommand(a1,a2,a3,a4,a5,a6);
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
	static public int ctor__PhysicsScene__Vector3__Vector3__Single__Vector3__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand o;
			UnityEngine.PhysicsScene a1;
			checkValueType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			UnityEngine.Vector3 a5;
			checkType(l,5,out a5);
			System.Single a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			o=new UnityEngine.CapsulecastCommand(a1,a2,a3,a4,a5,a6,a7);
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
	static public int get_point1(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.point1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_point1(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.point1=v;
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
	static public int get_point2(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.point2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_point2(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.point2=v;
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
	static public int get_radius(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.radius);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_radius(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.radius=v;
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
	static public int get_direction(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.direction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_direction(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.direction=v;
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
	static public int get_distance(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.distance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_distance(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.distance=v;
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
			UnityEngine.CapsulecastCommand self;
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
			UnityEngine.CapsulecastCommand self;
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
	static public int get_physicsScene(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.physicsScene);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_physicsScene(IntPtr l) {
		try {
			UnityEngine.CapsulecastCommand self;
			checkValueType(l,1,out self);
			UnityEngine.PhysicsScene v;
			checkValueType(l,2,out v);
			self.physicsScene=v;
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
		getTypeTable(l,"UnityEngine.CapsulecastCommand");
		addMember(l,ctor_s);
		addMember(l,ctor__Vector3__Vector3__Single__Vector3__Single__Int32_s);
		addMember(l,ctor__PhysicsScene__Vector3__Vector3__Single__Vector3__Single__Int32_s);
		addMember(l,"point1",get_point1,set_point1,true);
		addMember(l,"point2",get_point2,set_point2,true);
		addMember(l,"radius",get_radius,set_radius,true);
		addMember(l,"direction",get_direction,set_direction,true);
		addMember(l,"distance",get_distance,set_distance,true);
		addMember(l,"layerMask",get_layerMask,set_layerMask,true);
		addMember(l,"physicsScene",get_physicsScene,set_physicsScene,true);
		createTypeMetatable(l,null, typeof(UnityEngine.CapsulecastCommand),typeof(System.ValueType));
	}
}
