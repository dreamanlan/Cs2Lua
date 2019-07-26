using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Animations_MuscleHandle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Experimental.Animations.MuscleHandle o;
			if(matchType(l, "ctor__HumanPartDof__LegDof", argc, 2,typeof(UnityEngine.HumanPartDof),typeof(UnityEngine.LegDof))){
				UnityEngine.HumanPartDof a1;
				checkEnum(l,3,out a1);
				UnityEngine.LegDof a2;
				checkEnum(l,4,out a2);
				o=new UnityEngine.Experimental.Animations.MuscleHandle(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__HumanPartDof__ArmDof", argc, 2,typeof(UnityEngine.HumanPartDof),typeof(UnityEngine.ArmDof))){
				UnityEngine.HumanPartDof a1;
				checkEnum(l,3,out a1);
				UnityEngine.ArmDof a2;
				checkEnum(l,4,out a2);
				o=new UnityEngine.Experimental.Animations.MuscleHandle(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__HumanPartDof__FingerDof", argc, 2,typeof(UnityEngine.HumanPartDof),typeof(UnityEngine.FingerDof))){
				UnityEngine.HumanPartDof a1;
				checkEnum(l,3,out a1);
				UnityEngine.FingerDof a2;
				checkEnum(l,4,out a2);
				o=new UnityEngine.Experimental.Animations.MuscleHandle(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__BodyDof", argc, 2,typeof(UnityEngine.BodyDof))){
				UnityEngine.BodyDof a1;
				checkEnum(l,3,out a1);
				o=new UnityEngine.Experimental.Animations.MuscleHandle(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__HeadDof", argc, 2,typeof(UnityEngine.HeadDof))){
				UnityEngine.HeadDof a1;
				checkEnum(l,3,out a1);
				o=new UnityEngine.Experimental.Animations.MuscleHandle(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc<=2){
				o=new UnityEngine.Experimental.Animations.MuscleHandle();
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
	static public int GetMuscleHandles_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.MuscleHandle[] a1;
			checkArray(l,1,out a1);
			UnityEngine.Experimental.Animations.MuscleHandle.GetMuscleHandles(a1);
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
			UnityEngine.Experimental.Animations.MuscleHandle self;
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
			UnityEngine.Experimental.Animations.MuscleHandle self;
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
			UnityEngine.Experimental.Animations.MuscleHandle self;
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
			pushValue(l,UnityEngine.Experimental.Animations.MuscleHandle.muscleHandleCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Animations.MuscleHandle");
		addMember(l,GetMuscleHandles_s);
		addMember(l,"humanPartDof",get_humanPartDof,null,true);
		addMember(l,"dof",get_dof,null,true);
		addMember(l,"name",get_name,null,true);
		addMember(l,"muscleHandleCount",get_muscleHandleCount,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Animations.MuscleHandle),typeof(System.ValueType));
	}
}
