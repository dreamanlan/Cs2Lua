using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Touch : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Touch o;
			o=new UnityEngine.Touch();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fingerId(IntPtr l) {
		try {
			UnityEngine.Touch self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.fingerId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		try {
			UnityEngine.Touch self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rawPosition(IntPtr l) {
		try {
			UnityEngine.Touch self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.rawPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaPosition(IntPtr l) {
		try {
			UnityEngine.Touch self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.deltaPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaTime(IntPtr l) {
		try {
			UnityEngine.Touch self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.deltaTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tapCount(IntPtr l) {
		try {
			UnityEngine.Touch self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.tapCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_phase(IntPtr l) {
		try {
			UnityEngine.Touch self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.phase);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressure(IntPtr l) {
		try {
			UnityEngine.Touch self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.pressure);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maximumPossiblePressure(IntPtr l) {
		try {
			UnityEngine.Touch self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.maximumPossiblePressure);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		try {
			UnityEngine.Touch self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_altitudeAngle(IntPtr l) {
		try {
			UnityEngine.Touch self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.altitudeAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_azimuthAngle(IntPtr l) {
		try {
			UnityEngine.Touch self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.azimuthAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		try {
			UnityEngine.Touch self;
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
	static public int get_radiusVariance(IntPtr l) {
		try {
			UnityEngine.Touch self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.radiusVariance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Touch");
		addMember(l,"fingerId",get_fingerId,null,true);
		addMember(l,"position",get_position,null,true);
		addMember(l,"rawPosition",get_rawPosition,null,true);
		addMember(l,"deltaPosition",get_deltaPosition,null,true);
		addMember(l,"deltaTime",get_deltaTime,null,true);
		addMember(l,"tapCount",get_tapCount,null,true);
		addMember(l,"phase",get_phase,null,true);
		addMember(l,"pressure",get_pressure,null,true);
		addMember(l,"maximumPossiblePressure",get_maximumPossiblePressure,null,true);
		addMember(l,"type",get_type,null,true);
		addMember(l,"altitudeAngle",get_altitudeAngle,null,true);
		addMember(l,"azimuthAngle",get_azimuthAngle,null,true);
		addMember(l,"radius",get_radius,null,true);
		addMember(l,"radiusVariance",get_radiusVariance,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Touch),typeof(System.ValueType));
	}
}
