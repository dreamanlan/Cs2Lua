using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_BatchVisibility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchVisibility o;
			o=new UnityEngine.Rendering.BatchVisibility();
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
	static public int get_offset(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchVisibility self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.offset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_instancesCount(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchVisibility self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.instancesCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_visibleCount(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchVisibility self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.visibleCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_visibleCount(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchVisibility self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.visibleCount=v;
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
		getTypeTable(l,"UnityEngine.Rendering.BatchVisibility");
		addMember(l,ctor_s);
		addMember(l,"offset",get_offset,null,true);
		addMember(l,"instancesCount",get_instancesCount,null,true);
		addMember(l,"visibleCount",get_visibleCount,set_visibleCount,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.BatchVisibility),typeof(System.ValueType));
	}
}
