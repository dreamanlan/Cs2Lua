using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Delegate : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DynamicInvoke(IntPtr l) {
		try {
			System.Delegate self=(System.Delegate)checkSelf(l);
			System.Object[] a1;
			checkParams(l,2,out a1);
			var ret=self.DynamicInvoke(a1);
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
	static public int Clone(IntPtr l) {
		try {
			System.Delegate self=(System.Delegate)checkSelf(l);
			var ret=self.Clone();
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
	static public int GetObjectData(IntPtr l) {
		try {
			System.Delegate self=(System.Delegate)checkSelf(l);
			System.Runtime.Serialization.SerializationInfo a1;
			checkType(l,2,out a1);
			System.Runtime.Serialization.StreamingContext a2;
			checkValueType(l,3,out a2);
			self.GetObjectData(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetInvocationList(IntPtr l) {
		try {
			System.Delegate self=(System.Delegate)checkSelf(l);
			var ret=self.GetInvocationList();
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
	static public int CreateDelegate_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "CreateDelegate__Delegate__Type__Type__String__Boolean__Boolean", argc, 1,typeof(System.Type),typeof(System.Type),typeof(string),typeof(bool),typeof(bool))){
				System.Type a1;
				checkType(l,2,out a1);
				System.Type a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.Boolean a4;
				checkType(l,5,out a4);
				System.Boolean a5;
				checkType(l,6,out a5);
				var ret=System.Delegate.CreateDelegate(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "CreateDelegate__Delegate__Type__Object__String__Boolean__Boolean", argc, 1,typeof(System.Type),typeof(System.Object),typeof(string),typeof(bool),typeof(bool))){
				System.Type a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.Boolean a4;
				checkType(l,5,out a4);
				System.Boolean a5;
				checkType(l,6,out a5);
				var ret=System.Delegate.CreateDelegate(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "CreateDelegate__Delegate__Type__Object__MethodInfo__Boolean", argc, 1,typeof(System.Type),typeof(System.Object),typeof(System.Reflection.MethodInfo),typeof(bool))){
				System.Type a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				System.Reflection.MethodInfo a3;
				checkType(l,4,out a3);
				System.Boolean a4;
				checkType(l,5,out a4);
				var ret=System.Delegate.CreateDelegate(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "CreateDelegate__Delegate__Type__Type__String__Boolean", argc, 1,typeof(System.Type),typeof(System.Type),typeof(string),typeof(bool))){
				System.Type a1;
				checkType(l,2,out a1);
				System.Type a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.Boolean a4;
				checkType(l,5,out a4);
				var ret=System.Delegate.CreateDelegate(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "CreateDelegate__Delegate__Type__Object__String__Boolean", argc, 1,typeof(System.Type),typeof(System.Object),typeof(string),typeof(bool))){
				System.Type a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.Boolean a4;
				checkType(l,5,out a4);
				var ret=System.Delegate.CreateDelegate(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "CreateDelegate__Delegate__Type__Object__MethodInfo", argc, 1,typeof(System.Type),typeof(System.Object),typeof(System.Reflection.MethodInfo))){
				System.Type a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				System.Reflection.MethodInfo a3;
				checkType(l,4,out a3);
				var ret=System.Delegate.CreateDelegate(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "CreateDelegate__Delegate__Type__MethodInfo__Boolean", argc, 1,typeof(System.Type),typeof(System.Reflection.MethodInfo),typeof(bool))){
				System.Type a1;
				checkType(l,2,out a1);
				System.Reflection.MethodInfo a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				var ret=System.Delegate.CreateDelegate(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "CreateDelegate__Delegate__Type__Object__String", argc, 1,typeof(System.Type),typeof(System.Object),typeof(string))){
				System.Type a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				var ret=System.Delegate.CreateDelegate(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "CreateDelegate__Delegate__Type__Type__String", argc, 1,typeof(System.Type),typeof(System.Type),typeof(string))){
				System.Type a1;
				checkType(l,2,out a1);
				System.Type a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				var ret=System.Delegate.CreateDelegate(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.Type a1;
				checkType(l,2,out a1);
				System.Reflection.MethodInfo a2;
				checkType(l,3,out a2);
				var ret=System.Delegate.CreateDelegate(a1,a2);
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
	static public int Combine_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.Delegate a1;
				checkType(l,2,out a1);
				System.Delegate a2;
				checkType(l,3,out a2);
				var ret=System.Delegate.Combine(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc>=2){
				System.Delegate[] a1;
				checkParams(l,2,out a1);
				var ret=System.Delegate.Combine(a1);
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
	static public int Remove_s(IntPtr l) {
		try {
			System.Delegate a1;
			checkType(l,1,out a1);
			System.Delegate a2;
			checkType(l,2,out a2);
			var ret=System.Delegate.Remove(a1,a2);
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
	static public int RemoveAll_s(IntPtr l) {
		try {
			System.Delegate a1;
			checkType(l,1,out a1);
			System.Delegate a2;
			checkType(l,2,out a2);
			var ret=System.Delegate.RemoveAll(a1,a2);
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
	static public int op_Equality_s(IntPtr l) {
		try {
			System.Delegate a1;
			checkType(l,1,out a1);
			System.Delegate a2;
			checkType(l,2,out a2);
			var ret=(a1==a2);
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
	static public int op_Inequality_s(IntPtr l) {
		try {
			System.Delegate a1;
			checkType(l,1,out a1);
			System.Delegate a2;
			checkType(l,2,out a2);
			var ret=(a1!=a2);
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
	static public int get_Method(IntPtr l) {
		try {
			System.Delegate self=(System.Delegate)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Method);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Target(IntPtr l) {
		try {
			System.Delegate self=(System.Delegate)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Target);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Delegate");
		addMember(l,DynamicInvoke);
		addMember(l,Clone);
		addMember(l,GetObjectData);
		addMember(l,GetInvocationList);
		addMember(l,CreateDelegate_s);
		addMember(l,Combine_s);
		addMember(l,Remove_s);
		addMember(l,RemoveAll_s);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"Method",get_Method,null,true);
		addMember(l,"Target",get_Target,null,true);
		createTypeMetatable(l,null, typeof(System.Delegate));
	}
}
