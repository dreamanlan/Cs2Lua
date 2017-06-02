using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ContactPoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ContactPoint o;
			o=new UnityEngine.ContactPoint();
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
	static public int get_point(IntPtr l) {
		try {
			UnityEngine.ContactPoint self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.point);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_normal(IntPtr l) {
		try {
			UnityEngine.ContactPoint self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.normal);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_thisCollider(IntPtr l) {
		try {
			UnityEngine.ContactPoint self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.thisCollider);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_otherCollider(IntPtr l) {
		try {
			UnityEngine.ContactPoint self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.otherCollider);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_separation(IntPtr l) {
		try {
			UnityEngine.ContactPoint self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.separation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ContactPoint");
		addMember(l,"point",get_point,null,true);
		addMember(l,"normal",get_normal,null,true);
		addMember(l,"thisCollider",get_thisCollider,null,true);
		addMember(l,"otherCollider",get_otherCollider,null,true);
		addMember(l,"separation",get_separation,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ContactPoint),typeof(System.ValueType));
	}
}
