using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_DepthState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.DepthState o;
			o=new UnityEngine.Rendering.DepthState();
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
	static public int ctor__Boolean__CompareFunction_s(IntPtr l) {
		try {
			UnityEngine.Rendering.DepthState o;
			System.Boolean a1;
			checkType(l,1,out a1);
			UnityEngine.Rendering.CompareFunction a2;
			checkEnum(l,2,out a2);
			o=new UnityEngine.Rendering.DepthState(a1,a2);
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
	static public int Equals__DepthState(IntPtr l) {
		try {
			UnityEngine.Rendering.DepthState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.DepthState a1;
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
			UnityEngine.Rendering.DepthState self;
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
			UnityEngine.Rendering.DepthState a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.DepthState a2;
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
			UnityEngine.Rendering.DepthState a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.DepthState a2;
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
	static public int get_defaultValue(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.DepthState.defaultValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_writeEnabled(IntPtr l) {
		try {
			UnityEngine.Rendering.DepthState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.writeEnabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_writeEnabled(IntPtr l) {
		try {
			UnityEngine.Rendering.DepthState self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.writeEnabled=v;
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
	static public int get_compareFunction(IntPtr l) {
		try {
			UnityEngine.Rendering.DepthState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.compareFunction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_compareFunction(IntPtr l) {
		try {
			UnityEngine.Rendering.DepthState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CompareFunction v;
			checkEnum(l,2,out v);
			self.compareFunction=v;
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
		getTypeTable(l,"UnityEngine.Rendering.DepthState");
		addMember(l,ctor_s);
		addMember(l,ctor__Boolean__CompareFunction_s);
		addMember(l,Equals__DepthState);
		addMember(l,Equals__Object);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"defaultValue",get_defaultValue,null,false);
		addMember(l,"writeEnabled",get_writeEnabled,set_writeEnabled,true);
		addMember(l,"compareFunction",get_compareFunction,set_compareFunction,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.DepthState),typeof(System.ValueType));
	}
}
