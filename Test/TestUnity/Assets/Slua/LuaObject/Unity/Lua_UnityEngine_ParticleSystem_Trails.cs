using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystem_Trails : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.Trails o;
			o=new UnityEngine.ParticleSystem.Trails();
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
	static public int get_capacity(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.Trails self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.capacity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_capacity(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.Trails self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.capacity=v;
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
		getTypeTable(l,"UnityEngine.ParticleSystem.Trails");
		addMember(l,ctor_s);
		addMember(l,"capacity",get_capacity,set_capacity,true);
		createTypeMetatable(l,null, typeof(UnityEngine.ParticleSystem.Trails),typeof(System.ValueType));
	}
}
