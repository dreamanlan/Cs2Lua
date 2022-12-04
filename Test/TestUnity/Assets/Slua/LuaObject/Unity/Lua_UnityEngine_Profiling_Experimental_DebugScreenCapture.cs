using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Profiling_Experimental_DebugScreenCapture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Profiling.Experimental.DebugScreenCapture o;
			o=new UnityEngine.Profiling.Experimental.DebugScreenCapture();
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
	static public int get_imageFormat(IntPtr l) {
		try {
			UnityEngine.Profiling.Experimental.DebugScreenCapture self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.imageFormat);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_imageFormat(IntPtr l) {
		try {
			UnityEngine.Profiling.Experimental.DebugScreenCapture self;
			checkValueType(l,1,out self);
			UnityEngine.TextureFormat v;
			checkEnum(l,2,out v);
			self.imageFormat=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_width(IntPtr l) {
		try {
			UnityEngine.Profiling.Experimental.DebugScreenCapture self;
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
	static public int set_width(IntPtr l) {
		try {
			UnityEngine.Profiling.Experimental.DebugScreenCapture self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.width=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_height(IntPtr l) {
		try {
			UnityEngine.Profiling.Experimental.DebugScreenCapture self;
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
	static public int set_height(IntPtr l) {
		try {
			UnityEngine.Profiling.Experimental.DebugScreenCapture self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.height=v;
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
		getTypeTable(l,"UnityEngine.Profiling.Experimental.DebugScreenCapture");
		addMember(l,ctor_s);
		addMember(l,"imageFormat",get_imageFormat,set_imageFormat,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Profiling.Experimental.DebugScreenCapture),typeof(System.ValueType));
	}
}
