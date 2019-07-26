using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Profiling_ProfilerMarker : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			Unity.Profiling.ProfilerMarker o;
			if(argc==2){
				System.String a1;
				checkType(l,2,out a1);
				o=new Unity.Profiling.ProfilerMarker(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc<=2){
				o=new Unity.Profiling.ProfilerMarker();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Begin(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				Unity.Profiling.ProfilerMarker self;
				checkValueType(l,1,out self);
				UnityEngine.Object a1;
				checkType(l,3,out a1);
				self.Begin(a1);
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			else if(argc==2){
				Unity.Profiling.ProfilerMarker self;
				checkValueType(l,1,out self);
				self.Begin();
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
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
		addMember(l,Begin);
		addMember(l,End);
		addMember(l,Auto);
		createTypeMetatable(l,constructor, typeof(Unity.Profiling.ProfilerMarker),typeof(System.ValueType));
	}
}
