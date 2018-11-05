using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RenderQueueRange : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderQueueRange o;
			o=new UnityEngine.Experimental.Rendering.RenderQueueRange();
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
	static public int get_min(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderQueueRange self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.min);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_min(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderQueueRange self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.min=v;
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
	static public int get_max(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderQueueRange self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.max);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_max(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderQueueRange self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.max=v;
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
	static public int get_all(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.Rendering.RenderQueueRange.all);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_opaque(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.Rendering.RenderQueueRange.opaque);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_transparent(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.Rendering.RenderQueueRange.transparent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RenderQueueRange");
		addMember(l,"min",get_min,set_min,true);
		addMember(l,"max",get_max,set_max,true);
		addMember(l,"all",get_all,null,false);
		addMember(l,"opaque",get_opaque,null,false);
		addMember(l,"transparent",get_transparent,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.RenderQueueRange),typeof(System.ValueType));
	}
}
