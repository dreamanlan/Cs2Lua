using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Experimental_Director_FrameData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData o;
			o=new UnityEngine.Experimental.Director.FrameData();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateId(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.updateId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.time);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastTime(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lastTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaTime(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.deltaTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_timeScale(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.timeScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dTime(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.dTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dLastTime(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.dLastTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dDeltaTime(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.dDeltaTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dtimeScale(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.dtimeScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Director.FrameData");
		addMember(l,"updateId",get_updateId,null,true);
		addMember(l,"time",get_time,null,true);
		addMember(l,"lastTime",get_lastTime,null,true);
		addMember(l,"deltaTime",get_deltaTime,null,true);
		addMember(l,"timeScale",get_timeScale,null,true);
		addMember(l,"dTime",get_dTime,null,true);
		addMember(l,"dLastTime",get_dLastTime,null,true);
		addMember(l,"dDeltaTime",get_dDeltaTime,null,true);
		addMember(l,"dtimeScale",get_dtimeScale,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Director.FrameData),typeof(System.ValueType));
	}
}
