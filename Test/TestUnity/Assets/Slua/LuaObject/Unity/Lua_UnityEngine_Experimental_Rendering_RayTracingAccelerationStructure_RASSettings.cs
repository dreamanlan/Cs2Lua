using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure_RASSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RASSettings o;
			o=new UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RASSettings();
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
	static public int ctor__ManagementMode__RayTracingModeMask__Int32_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RASSettings o;
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.ManagementMode a1;
			checkEnum(l,1,out a1);
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RayTracingModeMask a2;
			checkEnum(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			o=new UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RASSettings(a1,a2,a3);
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
	static public int get_managementMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RASSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.managementMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_managementMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RASSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.ManagementMode v;
			checkEnum(l,2,out v);
			self.managementMode=v;
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
	static public int get_rayTracingModeMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RASSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.rayTracingModeMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rayTracingModeMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RASSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RayTracingModeMask v;
			checkEnum(l,2,out v);
			self.rayTracingModeMask=v;
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
	static public int get_layerMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RASSettings self;
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
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RASSettings self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.layerMask=v;
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
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RASSettings");
		addMember(l,ctor_s);
		addMember(l,ctor__ManagementMode__RayTracingModeMask__Int32_s);
		addMember(l,"managementMode",get_managementMode,set_managementMode,true);
		addMember(l,"rayTracingModeMask",get_rayTracingModeMask,set_rayTracingModeMask,true);
		addMember(l,"layerMask",get_layerMask,set_layerMask,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RASSettings),typeof(System.ValueType));
	}
}
