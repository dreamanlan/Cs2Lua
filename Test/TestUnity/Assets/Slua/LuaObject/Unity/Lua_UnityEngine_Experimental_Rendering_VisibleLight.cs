using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_VisibleLight : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight o;
			o=new UnityEngine.Experimental.Rendering.VisibleLight();
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
	static public int get_lightType(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.lightType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightType(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			UnityEngine.LightType v;
			checkEnum(l,2,out v);
			self.lightType=v;
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
	static public int get_finalColor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.finalColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_finalColor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.finalColor=v;
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
	static public int get_screenRect(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.screenRect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_screenRect(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			UnityEngine.Rect v;
			checkValueType(l,2,out v);
			self.screenRect=v;
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
	static public int get_localToWorld(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.localToWorld);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_localToWorld(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			UnityEngine.Matrix4x4 v;
			checkValueType(l,2,out v);
			self.localToWorld=v;
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
	static public int get_range(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.range);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_range(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.range=v;
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
	static public int get_spotAngle(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.spotAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_spotAngle(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.spotAngle=v;
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
	static public int get_flags(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.flags);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_flags(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.VisibleLightFlags v;
			checkEnum(l,2,out v);
			self.flags=v;
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
	static public int get_light(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.light);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.VisibleLight");
		addMember(l,"lightType",get_lightType,set_lightType,true);
		addMember(l,"finalColor",get_finalColor,set_finalColor,true);
		addMember(l,"screenRect",get_screenRect,set_screenRect,true);
		addMember(l,"localToWorld",get_localToWorld,set_localToWorld,true);
		addMember(l,"range",get_range,set_range,true);
		addMember(l,"spotAngle",get_spotAngle,set_spotAngle,true);
		addMember(l,"flags",get_flags,set_flags,true);
		addMember(l,"light",get_light,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.VisibleLight),typeof(System.ValueType));
	}
}
