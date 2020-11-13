using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_GC : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddMemoryPressure_s(IntPtr l) {
		try {
			System.Int64 a1;
			checkType(l,1,out a1);
			System.GC.AddMemoryPressure(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveMemoryPressure_s(IntPtr l) {
		try {
			System.Int64 a1;
			checkType(l,1,out a1);
			System.GC.RemoveMemoryPressure(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetGeneration_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "GetGeneration__Int32__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.GC.GetGeneration(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "GetGeneration__Int32__WeakReference", argc, 1,typeof(System.WeakReference))){
				System.WeakReference a1;
				checkType(l,2,out a1);
				var ret=System.GC.GetGeneration(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Collect_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.GCCollectionMode a2;
				checkEnum(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				System.Boolean a4;
				checkType(l,5,out a4);
				System.GC.Collect(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.GCCollectionMode a2;
				checkEnum(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				System.GC.Collect(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.GCCollectionMode a2;
				checkEnum(l,3,out a2);
				System.GC.Collect(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.GC.Collect(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==1){
				System.GC.Collect();
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CollectionCount_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=System.GC.CollectionCount(a1);
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
	static public int KeepAlive_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			System.GC.KeepAlive(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WaitForPendingFinalizers_s(IntPtr l) {
		try {
			System.GC.WaitForPendingFinalizers();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SuppressFinalize_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			System.GC.SuppressFinalize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReRegisterForFinalize_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			System.GC.ReRegisterForFinalize(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTotalMemory_s(IntPtr l) {
		try {
			System.Boolean a1;
			checkType(l,1,out a1);
			var ret=System.GC.GetTotalMemory(a1);
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
	static public int RegisterForFullGCNotification_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.GC.RegisterForFullGCNotification(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CancelFullGCNotification_s(IntPtr l) {
		try {
			System.GC.CancelFullGCNotification();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WaitForFullGCApproach_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.GC.WaitForFullGCApproach(a1);
				pushValue(l,true);
				pushEnum(l,(int)ret);
				return 2;
			}
			else if(argc==1){
				var ret=System.GC.WaitForFullGCApproach();
				pushValue(l,true);
				pushEnum(l,(int)ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WaitForFullGCComplete_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.GC.WaitForFullGCComplete(a1);
				pushValue(l,true);
				pushEnum(l,(int)ret);
				return 2;
			}
			else if(argc==1){
				var ret=System.GC.WaitForFullGCComplete();
				pushValue(l,true);
				pushEnum(l,(int)ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TryStartNoGCRegion_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.Int64 a1;
				checkType(l,2,out a1);
				System.Int64 a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				var ret=System.GC.TryStartNoGCRegion(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "TryStartNoGCRegion__Boolean__Int64__Int64", argc, 1,typeof(System.Int64),typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				System.Int64 a2;
				checkType(l,3,out a2);
				var ret=System.GC.TryStartNoGCRegion(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "TryStartNoGCRegion__Boolean__Int64__Boolean", argc, 1,typeof(System.Int64),typeof(bool))){
				System.Int64 a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=System.GC.TryStartNoGCRegion(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.GC.TryStartNoGCRegion(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EndNoGCRegion_s(IntPtr l) {
		try {
			System.GC.EndNoGCRegion();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_MaxGeneration(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.GC.MaxGeneration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.GC");
		addMember(l,AddMemoryPressure_s);
		addMember(l,RemoveMemoryPressure_s);
		addMember(l,GetGeneration_s);
		addMember(l,Collect_s);
		addMember(l,CollectionCount_s);
		addMember(l,KeepAlive_s);
		addMember(l,WaitForPendingFinalizers_s);
		addMember(l,SuppressFinalize_s);
		addMember(l,ReRegisterForFinalize_s);
		addMember(l,GetTotalMemory_s);
		addMember(l,RegisterForFullGCNotification_s);
		addMember(l,CancelFullGCNotification_s);
		addMember(l,WaitForFullGCApproach_s);
		addMember(l,WaitForFullGCComplete_s);
		addMember(l,TryStartNoGCRegion_s);
		addMember(l,EndNoGCRegion_s);
		addMember(l,"MaxGeneration",get_MaxGeneration,null,false);
		createTypeMetatable(l,null, typeof(System.GC));
	}
}
