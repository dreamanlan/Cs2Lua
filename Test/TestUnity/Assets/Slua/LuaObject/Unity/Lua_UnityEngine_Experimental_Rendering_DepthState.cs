using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_DepthState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Experimental.Rendering.DepthState o;
			if(argc==3){
				System.Boolean a1;
				checkType(l,2,out a1);
				UnityEngine.Rendering.CompareFunction a2;
				checkEnum(l,3,out a2);
				o=new UnityEngine.Experimental.Rendering.DepthState(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc<=2){
				o=new UnityEngine.Experimental.Rendering.DepthState();
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
	static public int get_Default(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.Rendering.DepthState.Default);
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
			UnityEngine.Experimental.Rendering.DepthState self;
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
			UnityEngine.Experimental.Rendering.DepthState self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.writeEnabled=v;
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
	static public int get_compareFunction(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DepthState self;
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
			UnityEngine.Experimental.Rendering.DepthState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CompareFunction v;
			checkEnum(l,2,out v);
			self.compareFunction=v;
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
		getTypeTable(l,"UnityEngine.Experimental.Rendering.DepthState");
		addMember(l,"Default",get_Default,null,false);
		addMember(l,"writeEnabled",get_writeEnabled,set_writeEnabled,true);
		addMember(l,"compareFunction",get_compareFunction,set_compareFunction,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.DepthState),typeof(System.ValueType));
	}
}
