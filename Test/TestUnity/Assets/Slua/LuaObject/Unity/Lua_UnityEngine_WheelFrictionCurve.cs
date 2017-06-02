using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_WheelFrictionCurve : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.WheelFrictionCurve o;
			o=new UnityEngine.WheelFrictionCurve();
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
	static public int get_extremumSlip(IntPtr l) {
		try {
			UnityEngine.WheelFrictionCurve self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.extremumSlip);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_extremumSlip(IntPtr l) {
		try {
			UnityEngine.WheelFrictionCurve self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.extremumSlip=v;
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
	static public int get_extremumValue(IntPtr l) {
		try {
			UnityEngine.WheelFrictionCurve self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.extremumValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_extremumValue(IntPtr l) {
		try {
			UnityEngine.WheelFrictionCurve self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.extremumValue=v;
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
	static public int get_asymptoteSlip(IntPtr l) {
		try {
			UnityEngine.WheelFrictionCurve self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.asymptoteSlip);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_asymptoteSlip(IntPtr l) {
		try {
			UnityEngine.WheelFrictionCurve self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.asymptoteSlip=v;
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
	static public int get_asymptoteValue(IntPtr l) {
		try {
			UnityEngine.WheelFrictionCurve self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.asymptoteValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_asymptoteValue(IntPtr l) {
		try {
			UnityEngine.WheelFrictionCurve self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.asymptoteValue=v;
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
	static public int get_stiffness(IntPtr l) {
		try {
			UnityEngine.WheelFrictionCurve self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.stiffness);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_stiffness(IntPtr l) {
		try {
			UnityEngine.WheelFrictionCurve self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.stiffness=v;
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
		getTypeTable(l,"UnityEngine.WheelFrictionCurve");
		addMember(l,"extremumSlip",get_extremumSlip,set_extremumSlip,true);
		addMember(l,"extremumValue",get_extremumValue,set_extremumValue,true);
		addMember(l,"asymptoteSlip",get_asymptoteSlip,set_asymptoteSlip,true);
		addMember(l,"asymptoteValue",get_asymptoteValue,set_asymptoteValue,true);
		addMember(l,"stiffness",get_stiffness,set_stiffness,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.WheelFrictionCurve),typeof(System.ValueType));
	}
}
