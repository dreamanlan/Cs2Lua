using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemJobs_ParticleSystemNativeArray4 : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 o;
			o=new UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4();
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
	static public int getItem(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			var ret = self[v];
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
	static public int setItem(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			UnityEngine.Vector4 c;
			checkType(l,3,out c);
			self[v]=c;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4");
		addMember(l,ctor_s);
		addMember(l,getItem);
		addMember(l,setItem);
		createTypeMetatable(l,null, typeof(UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4),typeof(System.ValueType));
	}
}
