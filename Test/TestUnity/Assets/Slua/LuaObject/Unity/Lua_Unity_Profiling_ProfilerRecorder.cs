using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Profiling_ProfilerRecorder : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder o;
			o=new Unity.Profiling.ProfilerRecorder();
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
	static public int ctor__String__Int32__ProfilerRecorderOptions_s(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder o;
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			Unity.Profiling.ProfilerRecorderOptions a3;
			checkEnum(l,3,out a3);
			o=new Unity.Profiling.ProfilerRecorder(a1,a2,a3);
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
	static public int ctor__ProfilerMarker__Int32__ProfilerRecorderOptions_s(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder o;
			Unity.Profiling.ProfilerMarker a1;
			checkValueType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			Unity.Profiling.ProfilerRecorderOptions a3;
			checkEnum(l,3,out a3);
			o=new Unity.Profiling.ProfilerRecorder(a1,a2,a3);
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
	static public int ctor__ProfilerRecorderHandle__Int32__ProfilerRecorderOptions_s(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder o;
			Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle a1;
			checkValueType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			Unity.Profiling.ProfilerRecorderOptions a3;
			checkEnum(l,3,out a3);
			o=new Unity.Profiling.ProfilerRecorder(a1,a2,a3);
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
	static public int ctor__String__String__Int32__ProfilerRecorderOptions_s(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder o;
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			Unity.Profiling.ProfilerRecorderOptions a4;
			checkEnum(l,4,out a4);
			o=new Unity.Profiling.ProfilerRecorder(a1,a2,a3,a4);
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
	static public int ctor__ProfilerCategory__String__Int32__ProfilerRecorderOptions_s(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder o;
			Unity.Profiling.ProfilerCategory a1;
			checkValueType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			Unity.Profiling.ProfilerRecorderOptions a4;
			checkEnum(l,4,out a4);
			o=new Unity.Profiling.ProfilerRecorder(a1,a2,a3,a4);
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
	static public int Start(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			self.Start();
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
	static public int Stop(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			self.Stop();
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
	static public int Reset(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			self.Reset();
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
	static public int GetSample(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetSample(a1);
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
	static public int ToArray(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			var ret=self.ToArray();
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
	static public int Dispose(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			self.Dispose();
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
	static public int StartNew__ProfilerMarker__Int32__ProfilerRecorderOptions_s(IntPtr l) {
		try {
			Unity.Profiling.ProfilerMarker a1;
			checkValueType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			Unity.Profiling.ProfilerRecorderOptions a3;
			checkEnum(l,3,out a3);
			var ret=Unity.Profiling.ProfilerRecorder.StartNew(a1,a2,a3);
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
	static public int StartNew__ProfilerCategory__String__Int32__ProfilerRecorderOptions_s(IntPtr l) {
		try {
			Unity.Profiling.ProfilerCategory a1;
			checkValueType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			Unity.Profiling.ProfilerRecorderOptions a4;
			checkEnum(l,4,out a4);
			var ret=Unity.Profiling.ProfilerRecorder.StartNew(a1,a2,a3,a4);
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
	static public int get_Valid(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.Valid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DataType(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.DataType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_UnitType(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.UnitType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_CurrentValue(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.CurrentValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_CurrentValueAsDouble(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.CurrentValueAsDouble);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_LastValue(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.LastValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_LastValueAsDouble(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.LastValueAsDouble);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Capacity(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.Capacity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Count(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.Count);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsRunning(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.IsRunning);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_WrappedAround(IntPtr l) {
		try {
			Unity.Profiling.ProfilerRecorder self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.WrappedAround);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"Unity.Profiling.ProfilerRecorder");
		addMember(l,ctor_s);
		addMember(l,ctor__String__Int32__ProfilerRecorderOptions_s);
		addMember(l,ctor__ProfilerMarker__Int32__ProfilerRecorderOptions_s);
		addMember(l,ctor__ProfilerRecorderHandle__Int32__ProfilerRecorderOptions_s);
		addMember(l,ctor__String__String__Int32__ProfilerRecorderOptions_s);
		addMember(l,ctor__ProfilerCategory__String__Int32__ProfilerRecorderOptions_s);
		addMember(l,Start);
		addMember(l,Stop);
		addMember(l,Reset);
		addMember(l,GetSample);
		addMember(l,ToArray);
		addMember(l,Dispose);
		addMember(l,StartNew__ProfilerMarker__Int32__ProfilerRecorderOptions_s);
		addMember(l,StartNew__ProfilerCategory__String__Int32__ProfilerRecorderOptions_s);
		addMember(l,"Valid",get_Valid,null,true);
		addMember(l,"DataType",get_DataType,null,true);
		addMember(l,"UnitType",get_UnitType,null,true);
		addMember(l,"CurrentValue",get_CurrentValue,null,true);
		addMember(l,"CurrentValueAsDouble",get_CurrentValueAsDouble,null,true);
		addMember(l,"LastValue",get_LastValue,null,true);
		addMember(l,"LastValueAsDouble",get_LastValueAsDouble,null,true);
		addMember(l,"Capacity",get_Capacity,null,true);
		addMember(l,"Count",get_Count,null,true);
		addMember(l,"IsRunning",get_IsRunning,null,true);
		addMember(l,"WrappedAround",get_WrappedAround,null,true);
		createTypeMetatable(l,null, typeof(Unity.Profiling.ProfilerRecorder),typeof(System.ValueType));
	}
}
