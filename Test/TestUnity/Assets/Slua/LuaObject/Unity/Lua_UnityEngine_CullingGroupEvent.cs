using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_CullingGroupEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.CullingGroupEvent o;
			o=new UnityEngine.CullingGroupEvent();
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
	static public int get_index(IntPtr l) {
		try {
			UnityEngine.CullingGroupEvent self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.index);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isVisible(IntPtr l) {
		try {
			UnityEngine.CullingGroupEvent self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.isVisible);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_wasVisible(IntPtr l) {
		try {
			UnityEngine.CullingGroupEvent self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.wasVisible);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hasBecomeVisible(IntPtr l) {
		try {
			UnityEngine.CullingGroupEvent self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.hasBecomeVisible);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hasBecomeInvisible(IntPtr l) {
		try {
			UnityEngine.CullingGroupEvent self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.hasBecomeInvisible);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_currentDistance(IntPtr l) {
		try {
			UnityEngine.CullingGroupEvent self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.currentDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_previousDistance(IntPtr l) {
		try {
			UnityEngine.CullingGroupEvent self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.previousDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CullingGroupEvent");
		addMember(l,"index",get_index,null,true);
		addMember(l,"isVisible",get_isVisible,null,true);
		addMember(l,"wasVisible",get_wasVisible,null,true);
		addMember(l,"hasBecomeVisible",get_hasBecomeVisible,null,true);
		addMember(l,"hasBecomeInvisible",get_hasBecomeInvisible,null,true);
		addMember(l,"currentDistance",get_currentDistance,null,true);
		addMember(l,"previousDistance",get_previousDistance,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.CullingGroupEvent),typeof(System.ValueType));
	}
}
