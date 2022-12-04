using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ArticulationJacobian : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.ArticulationJacobian o;
			o=new UnityEngine.ArticulationJacobian();
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
	static public int ctor__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.ArticulationJacobian o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			o=new UnityEngine.ArticulationJacobian(a1,a2);
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
	static public int get_rows(IntPtr l) {
		try {
			UnityEngine.ArticulationJacobian self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.rows);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rows(IntPtr l) {
		try {
			UnityEngine.ArticulationJacobian self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.rows=v;
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
	static public int get_columns(IntPtr l) {
		try {
			UnityEngine.ArticulationJacobian self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.columns);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_columns(IntPtr l) {
		try {
			UnityEngine.ArticulationJacobian self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.columns=v;
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
		getTypeTable(l,"UnityEngine.ArticulationJacobian");
		addMember(l,ctor_s);
		addMember(l,ctor__Int32__Int32_s);
		addMember(l,"rows",get_rows,set_rows,true);
		addMember(l,"columns",get_columns,set_columns,true);
		createTypeMetatable(l,null, typeof(UnityEngine.ArticulationJacobian),typeof(System.ValueType));
	}
}
