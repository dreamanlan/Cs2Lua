using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_GlobalIllumination_LinearColor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LinearColor o;
			o=new UnityEngine.Experimental.GlobalIllumination.LinearColor();
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
	static public int Convert_s(IntPtr l) {
		try {
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Experimental.GlobalIllumination.LinearColor.Convert(a1,a2);
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
	static public int Black_s(IntPtr l) {
		try {
			var ret=UnityEngine.Experimental.GlobalIllumination.LinearColor.Black();
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
	static public int get_red(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LinearColor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.red);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_red(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LinearColor self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.red=v;
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
	static public int get_green(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LinearColor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.green);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_green(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LinearColor self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.green=v;
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
	static public int get_blue(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LinearColor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.blue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_blue(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LinearColor self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.blue=v;
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
	static public int get_intensity(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LinearColor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.intensity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_intensity(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LinearColor self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.intensity=v;
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
		getTypeTable(l,"UnityEngine.Experimental.GlobalIllumination.LinearColor");
		addMember(l,Convert_s);
		addMember(l,Black_s);
		addMember(l,"red",get_red,set_red,true);
		addMember(l,"green",get_green,set_green,true);
		addMember(l,"blue",get_blue,set_blue,true);
		addMember(l,"intensity",get_intensity,set_intensity,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.GlobalIllumination.LinearColor),typeof(System.ValueType));
	}
}
