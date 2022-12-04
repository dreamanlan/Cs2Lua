using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemJobs_ParticleSystemJobData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.ParticleSystemJobData o;
			o=new UnityEngine.ParticleSystemJobs.ParticleSystemJobData();
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
	static public int get_count(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.ParticleSystemJobData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.count);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_positions(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.ParticleSystemJobData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.positions);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_velocities(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.ParticleSystemJobData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.velocities);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_axisOfRotations(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.ParticleSystemJobData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.axisOfRotations);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rotations(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.ParticleSystemJobData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.rotations);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rotationalSpeeds(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.ParticleSystemJobData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.rotationalSpeeds);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sizes(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.ParticleSystemJobData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sizes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_customData1(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.ParticleSystemJobData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.customData1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_customData2(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.ParticleSystemJobData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.customData2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystemJobs.ParticleSystemJobData");
		addMember(l,ctor_s);
		addMember(l,"count",get_count,null,true);
		addMember(l,"positions",get_positions,null,true);
		addMember(l,"velocities",get_velocities,null,true);
		addMember(l,"axisOfRotations",get_axisOfRotations,null,true);
		addMember(l,"rotations",get_rotations,null,true);
		addMember(l,"rotationalSpeeds",get_rotationalSpeeds,null,true);
		addMember(l,"sizes",get_sizes,null,true);
		addMember(l,"customData1",get_customData1,null,true);
		addMember(l,"customData2",get_customData2,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.ParticleSystemJobs.ParticleSystemJobData),typeof(System.ValueType));
	}
}
