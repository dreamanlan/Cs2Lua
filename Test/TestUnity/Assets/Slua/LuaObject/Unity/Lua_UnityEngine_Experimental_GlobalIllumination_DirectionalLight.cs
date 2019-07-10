using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_GlobalIllumination_DirectionalLight : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight o;
			o=new UnityEngine.Experimental.GlobalIllumination.DirectionalLight();
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
	static public int get_instanceID(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.instanceID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_instanceID(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.instanceID=v;
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
	static public int get_shadow(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.shadow);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shadow(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.shadow=v;
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
	static public int get_mode(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mode(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.LightMode v;
			checkEnum(l,2,out v);
			self.mode=v;
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
	static public int get_direction(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
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
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.direction=v;
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
	static public int get_color(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.color);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_color(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.LinearColor v;
			checkValueType(l,2,out v);
			self.color=v;
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
	static public int get_indirectColor(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.indirectColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_indirectColor(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.LinearColor v;
			checkValueType(l,2,out v);
			self.indirectColor=v;
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
	static public int get_penumbraWidthRadian(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.penumbraWidthRadian);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_penumbraWidthRadian(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.penumbraWidthRadian=v;
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
		getTypeTable(l,"UnityEngine.Experimental.GlobalIllumination.DirectionalLight");
		addMember(l,"instanceID",get_instanceID,set_instanceID,true);
		addMember(l,"shadow",get_shadow,set_shadow,true);
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"direction",get_direction,set_direction,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"indirectColor",get_indirectColor,set_indirectColor,true);
		addMember(l,"penumbraWidthRadian",get_penumbraWidthRadian,set_penumbraWidthRadian,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.GlobalIllumination.DirectionalLight),typeof(System.ValueType));
	}
}
