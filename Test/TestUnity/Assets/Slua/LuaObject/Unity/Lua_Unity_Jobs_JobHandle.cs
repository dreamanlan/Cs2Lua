using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Jobs_JobHandle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			Unity.Jobs.JobHandle o;
			o=new Unity.Jobs.JobHandle();
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
	static public int Complete(IntPtr l) {
		try {
			Unity.Jobs.JobHandle self;
			checkValueType(l,1,out self);
			self.Complete();
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CompleteAll__R_JobHandle__R_JobHandle_s(IntPtr l) {
		try {
			Unity.Jobs.JobHandle a1;
			checkValueType(l,1,out a1);
			Unity.Jobs.JobHandle a2;
			checkValueType(l,2,out a2);
			Unity.Jobs.JobHandle.CompleteAll(ref a1,ref a2);
			pushValue(l,true);
			pushValue(l,a1);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CompleteAll__R_JobHandle__R_JobHandle__R_JobHandle_s(IntPtr l) {
		try {
			Unity.Jobs.JobHandle a1;
			checkValueType(l,1,out a1);
			Unity.Jobs.JobHandle a2;
			checkValueType(l,2,out a2);
			Unity.Jobs.JobHandle a3;
			checkValueType(l,3,out a3);
			Unity.Jobs.JobHandle.CompleteAll(ref a1,ref a2,ref a3);
			pushValue(l,true);
			pushValue(l,a1);
			pushValue(l,a2);
			pushValue(l,a3);
			return 4;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ScheduleBatchedJobs_s(IntPtr l) {
		try {
			Unity.Jobs.JobHandle.ScheduleBatchedJobs();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CombineDependencies__JobHandle__JobHandle_s(IntPtr l) {
		try {
			Unity.Jobs.JobHandle a1;
			checkValueType(l,1,out a1);
			Unity.Jobs.JobHandle a2;
			checkValueType(l,2,out a2);
			var ret=Unity.Jobs.JobHandle.CombineDependencies(a1,a2);
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
	static public int CombineDependencies__JobHandle__JobHandle__JobHandle_s(IntPtr l) {
		try {
			Unity.Jobs.JobHandle a1;
			checkValueType(l,1,out a1);
			Unity.Jobs.JobHandle a2;
			checkValueType(l,2,out a2);
			Unity.Jobs.JobHandle a3;
			checkValueType(l,3,out a3);
			var ret=Unity.Jobs.JobHandle.CombineDependencies(a1,a2,a3);
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
	static public int CheckFenceIsDependencyOrDidSyncFence_s(IntPtr l) {
		try {
			Unity.Jobs.JobHandle a1;
			checkValueType(l,1,out a1);
			Unity.Jobs.JobHandle a2;
			checkValueType(l,2,out a2);
			var ret=Unity.Jobs.JobHandle.CheckFenceIsDependencyOrDidSyncFence(a1,a2);
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
	static public int get_IsCompleted(IntPtr l) {
		try {
			Unity.Jobs.JobHandle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.IsCompleted);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"Unity.Jobs.JobHandle");
		addMember(l,ctor_s);
		addMember(l,Complete);
		addMember(l,CompleteAll__R_JobHandle__R_JobHandle_s);
		addMember(l,CompleteAll__R_JobHandle__R_JobHandle__R_JobHandle_s);
		addMember(l,ScheduleBatchedJobs_s);
		addMember(l,CombineDependencies__JobHandle__JobHandle_s);
		addMember(l,CombineDependencies__JobHandle__JobHandle__JobHandle_s);
		addMember(l,CheckFenceIsDependencyOrDidSyncFence_s);
		addMember(l,"IsCompleted",get_IsCompleted,null,true);
		createTypeMetatable(l,null, typeof(Unity.Jobs.JobHandle),typeof(System.ValueType));
	}
}
