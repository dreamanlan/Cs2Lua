using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_InputFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.InputFilter o;
			o=new UnityEngine.Experimental.Rendering.InputFilter();
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
	static public int SetQueuesOpaque(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.InputFilter self;
			checkValueType(l,1,out self);
			self.SetQueuesOpaque();
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
	static public int SetQueuesTransparent(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.InputFilter self;
			checkValueType(l,1,out self);
			self.SetQueuesTransparent();
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
	static public int Default_s(IntPtr l) {
		try {
			var ret=UnityEngine.Experimental.Rendering.InputFilter.Default();
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
	static public int get_renderQueueMin(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.InputFilter self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.renderQueueMin);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_renderQueueMin(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.InputFilter self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.renderQueueMin=v;
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
	static public int get_renderQueueMax(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.InputFilter self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.renderQueueMax);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_renderQueueMax(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.InputFilter self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.renderQueueMax=v;
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
	static public int get_layerMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.InputFilter self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.layerMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_layerMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.InputFilter self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.layerMask=v;
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
		getTypeTable(l,"UnityEngine.Experimental.Rendering.InputFilter");
		addMember(l,SetQueuesOpaque);
		addMember(l,SetQueuesTransparent);
		addMember(l,Default_s);
		addMember(l,"renderQueueMin",get_renderQueueMin,set_renderQueueMin,true);
		addMember(l,"renderQueueMax",get_renderQueueMax,set_renderQueueMax,true);
		addMember(l,"layerMask",get_layerMask,set_layerMask,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.InputFilter),typeof(System.ValueType));
	}
}
