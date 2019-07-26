using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RasterState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Experimental.Rendering.RasterState o;
			if(argc==5){
				UnityEngine.Rendering.CullMode a1;
				checkEnum(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Boolean a4;
				checkType(l,5,out a4);
				o=new UnityEngine.Experimental.Rendering.RasterState(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc<=2){
				o=new UnityEngine.Experimental.Rendering.RasterState();
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
			pushValue(l,UnityEngine.Experimental.Rendering.RasterState.Default);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cullingMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RasterState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.cullingMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cullingMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RasterState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CullMode v;
			checkEnum(l,2,out v);
			self.cullingMode=v;
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
	static public int get_depthClip(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RasterState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.depthClip);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_depthClip(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RasterState self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.depthClip=v;
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
	static public int get_offsetUnits(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RasterState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.offsetUnits);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_offsetUnits(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RasterState self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.offsetUnits=v;
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
	static public int get_offsetFactor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RasterState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.offsetFactor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_offsetFactor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RasterState self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.offsetFactor=v;
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
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RasterState");
		addMember(l,"Default",get_Default,null,false);
		addMember(l,"cullingMode",get_cullingMode,set_cullingMode,true);
		addMember(l,"depthClip",get_depthClip,set_depthClip,true);
		addMember(l,"offsetUnits",get_offsetUnits,set_offsetUnits,true);
		addMember(l,"offsetFactor",get_offsetFactor,set_offsetFactor,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.RasterState),typeof(System.ValueType));
	}
}
