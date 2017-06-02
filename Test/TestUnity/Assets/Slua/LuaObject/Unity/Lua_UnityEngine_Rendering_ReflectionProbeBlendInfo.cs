using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Rendering.ReflectionProbeBlendInfo o;
			o=new UnityEngine.Rendering.ReflectionProbeBlendInfo();
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
	static public int get_probe(IntPtr l) {
		try {
			UnityEngine.Rendering.ReflectionProbeBlendInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.probe);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_probe(IntPtr l) {
		try {
			UnityEngine.Rendering.ReflectionProbeBlendInfo self;
			checkValueType(l,1,out self);
			UnityEngine.ReflectionProbe v;
			checkType(l,2,out v);
			self.probe=v;
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
	static public int get_weight(IntPtr l) {
		try {
			UnityEngine.Rendering.ReflectionProbeBlendInfo self;
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
	static public int set_weight(IntPtr l) {
		try {
			UnityEngine.Rendering.ReflectionProbeBlendInfo self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.weight=v;
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
		getTypeTable(l,"UnityEngine.Rendering.ReflectionProbeBlendInfo");
		addMember(l,"probe",get_probe,set_probe,true);
		addMember(l,"weight",get_weight,set_weight,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.ReflectionProbeBlendInfo),typeof(System.ValueType));
	}
}
