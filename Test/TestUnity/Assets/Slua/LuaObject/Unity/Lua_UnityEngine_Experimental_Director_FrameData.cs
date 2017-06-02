using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Director_FrameData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
	static public int get_frameId(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.frameId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
	static public int get_weight(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.weight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_effectiveWeight(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.effectiveWeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_effectiveSpeed(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.effectiveSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_evaluationType(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.evaluationType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_seekOccurred(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.FrameData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.seekOccurred);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Director.FrameData");
		addMember(l,"frameId",get_frameId,null,true);
		addMember(l,"deltaTime",get_deltaTime,null,true);
		addMember(l,"weight",get_weight,null,true);
		addMember(l,"effectiveWeight",get_effectiveWeight,null,true);
		addMember(l,"effectiveSpeed",get_effectiveSpeed,null,true);
		addMember(l,"evaluationType",get_evaluationType,null,true);
		addMember(l,"seekOccurred",get_seekOccurred,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Director.FrameData),typeof(System.ValueType));
	}
}
