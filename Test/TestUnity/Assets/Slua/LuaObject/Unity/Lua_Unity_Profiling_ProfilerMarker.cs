using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Profiling_ProfilerMarker : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			Unity.Profiling.ProfilerMarker o;
			o=new Unity.Profiling.ProfilerMarker();
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
	static public int ctor__String_s(IntPtr l) {
		try {
			Unity.Profiling.ProfilerMarker o;
			System.String a1;
			checkType(l,1,out a1);
			o=new Unity.Profiling.ProfilerMarker(a1);
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
	static public int Begin(IntPtr l) {
		try {
			Unity.Profiling.ProfilerMarker self;
			checkValueType(l,1,out self);
			self.Begin();
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Begin__Object(IntPtr l) {
		try {
			Unity.Profiling.ProfilerMarker self;
			checkValueType(l,1,out self);
			UnityEngine.Object a1;
			checkType(l,2,out a1);
			self.Begin(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int End(IntPtr l) {
		try {
			Unity.Profiling.ProfilerMarker self;
			checkValueType(l,1,out self);
			self.End();
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Auto(IntPtr l) {
		try {
			Unity.Profiling.ProfilerMarker self;
			checkValueType(l,1,out self);
			var ret=self.Auto();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"Unity.Profiling.ProfilerMarker");
		addMember(l,ctor_s);
		addMember(l,ctor__String_s);
		addMember(l,Begin);
		addMember(l,Begin__Object);
		addMember(l,End);
		addMember(l,Auto);
		createTypeMetatable(l,null, typeof(Unity.Profiling.ProfilerMarker),typeof(System.ValueType));
	}
}
