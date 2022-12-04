using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Animations_MuscleHandle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Animations.MuscleHandle o;
			o=new UnityEngine.Animations.MuscleHandle();
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
	static public int ctor__BodyDof_s(IntPtr l) {
		try {
			UnityEngine.Animations.MuscleHandle o;
			UnityEngine.BodyDof a1;
			checkEnum(l,1,out a1);
			o=new UnityEngine.Animations.MuscleHandle(a1);
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
	static public int ctor__HeadDof_s(IntPtr l) {
		try {
			UnityEngine.Animations.MuscleHandle o;
			UnityEngine.HeadDof a1;
			checkEnum(l,1,out a1);
			o=new UnityEngine.Animations.MuscleHandle(a1);
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
	static public int ctor__HumanPartDof__LegDof_s(IntPtr l) {
		try {
			UnityEngine.Animations.MuscleHandle o;
			UnityEngine.HumanPartDof a1;
			checkEnum(l,1,out a1);
			UnityEngine.LegDof a2;
			checkEnum(l,2,out a2);
			o=new UnityEngine.Animations.MuscleHandle(a1,a2);
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
	static public int ctor__HumanPartDof__ArmDof_s(IntPtr l) {
		try {
			UnityEngine.Animations.MuscleHandle o;
			UnityEngine.HumanPartDof a1;
			checkEnum(l,1,out a1);
			UnityEngine.ArmDof a2;
			checkEnum(l,2,out a2);
			o=new UnityEngine.Animations.MuscleHandle(a1,a2);
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
	static public int ctor__HumanPartDof__FingerDof_s(IntPtr l) {
		try {
			UnityEngine.Animations.MuscleHandle o;
			UnityEngine.HumanPartDof a1;
			checkEnum(l,1,out a1);
			UnityEngine.FingerDof a2;
			checkEnum(l,2,out a2);
			o=new UnityEngine.Animations.MuscleHandle(a1,a2);
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
	static public int GetMuscleHandles_s(IntPtr l) {
		try {
			UnityEngine.Animations.MuscleHandle[] a1;
			checkArray(l,1,out a1);
			UnityEngine.Animations.MuscleHandle.GetMuscleHandles(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_humanPartDof(IntPtr l) {
		try {
			UnityEngine.Animations.MuscleHandle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.humanPartDof);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_dof(IntPtr l) {
		try {
			UnityEngine.Animations.MuscleHandle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.dof);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_name(IntPtr l) {
		try {
			UnityEngine.Animations.MuscleHandle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_muscleHandleCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Animations.MuscleHandle.muscleHandleCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Animations.MuscleHandle");
		addMember(l,ctor_s);
		addMember(l,ctor__BodyDof_s);
		addMember(l,ctor__HeadDof_s);
		addMember(l,ctor__HumanPartDof__LegDof_s);
		addMember(l,ctor__HumanPartDof__ArmDof_s);
		addMember(l,ctor__HumanPartDof__FingerDof_s);
		addMember(l,GetMuscleHandles_s);
		addMember(l,"humanPartDof",get_humanPartDof,null,true);
		addMember(l,"dof",get_dof,null,true);
		addMember(l,"name",get_name,null,true);
		addMember(l,"muscleHandleCount",get_muscleHandleCount,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Animations.MuscleHandle),typeof(System.ValueType));
	}
}
