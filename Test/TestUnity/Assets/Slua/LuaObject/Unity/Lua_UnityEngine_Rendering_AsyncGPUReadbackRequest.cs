using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_AsyncGPUReadbackRequest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Rendering.AsyncGPUReadbackRequest o;
			o=new UnityEngine.Rendering.AsyncGPUReadbackRequest();
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
	static public int Update(IntPtr l) {
		try {
			UnityEngine.Rendering.AsyncGPUReadbackRequest self;
			checkValueType(l,1,out self);
			self.Update();
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
	static public int WaitForCompletion(IntPtr l) {
		try {
			UnityEngine.Rendering.AsyncGPUReadbackRequest self;
			checkValueType(l,1,out self);
			self.WaitForCompletion();
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
	static public int get_done(IntPtr l) {
		try {
			UnityEngine.Rendering.AsyncGPUReadbackRequest self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.done);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hasError(IntPtr l) {
		try {
			UnityEngine.Rendering.AsyncGPUReadbackRequest self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.hasError);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_layerCount(IntPtr l) {
		try {
			UnityEngine.Rendering.AsyncGPUReadbackRequest self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.layerCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_layerDataSize(IntPtr l) {
		try {
			UnityEngine.Rendering.AsyncGPUReadbackRequest self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.layerDataSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_width(IntPtr l) {
		try {
			UnityEngine.Rendering.AsyncGPUReadbackRequest self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_height(IntPtr l) {
		try {
			UnityEngine.Rendering.AsyncGPUReadbackRequest self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depth(IntPtr l) {
		try {
			UnityEngine.Rendering.AsyncGPUReadbackRequest self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.depth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.AsyncGPUReadbackRequest");
		addMember(l,Update);
		addMember(l,WaitForCompletion);
		addMember(l,"done",get_done,null,true);
		addMember(l,"hasError",get_hasError,null,true);
		addMember(l,"layerCount",get_layerCount,null,true);
		addMember(l,"layerDataSize",get_layerDataSize,null,true);
		addMember(l,"width",get_width,null,true);
		addMember(l,"height",get_height,null,true);
		addMember(l,"depth",get_depth,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.AsyncGPUReadbackRequest),typeof(System.ValueType));
	}
}
