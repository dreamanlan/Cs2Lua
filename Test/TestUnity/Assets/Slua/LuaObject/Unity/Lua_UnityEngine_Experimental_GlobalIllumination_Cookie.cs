using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_GlobalIllumination_Cookie : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.Cookie o;
			o=new UnityEngine.Experimental.GlobalIllumination.Cookie();
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
	static public int Defaults_s(IntPtr l) {
		try {
			var ret=UnityEngine.Experimental.GlobalIllumination.Cookie.Defaults();
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
	static public int get_instanceID(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.Cookie self;
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
			UnityEngine.Experimental.GlobalIllumination.Cookie self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.instanceID=v;
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
	static public int get_scale(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.Cookie self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.scale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_scale(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.Cookie self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.scale=v;
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
	static public int get_sizes(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.Cookie self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sizes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sizes(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.Cookie self;
			checkValueType(l,1,out self);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.sizes=v;
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
		getTypeTable(l,"UnityEngine.Experimental.GlobalIllumination.Cookie");
		addMember(l,ctor_s);
		addMember(l,Defaults_s);
		addMember(l,"instanceID",get_instanceID,set_instanceID,true);
		addMember(l,"scale",get_scale,set_scale,true);
		addMember(l,"sizes",get_sizes,set_sizes,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.GlobalIllumination.Cookie),typeof(System.ValueType));
	}
}
