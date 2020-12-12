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
	static new public int Equals(IntPtr l) {
		try {
			System.Delegate self=(System.Delegate)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Equals(a1);
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
	static public int CreateDelegate__Type__MethodInfo_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			System.Reflection.MethodInfo a2;
			checkType(l,2,out a2);
			var ret=System.Delegate.CreateDelegate(a1,a2);
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
	static public int CreateDelegate__Type__Object__MethodInfo_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			System.Reflection.MethodInfo a3;
			checkType(l,3,out a3);
			var ret=System.Delegate.CreateDelegate(a1,a2,a3);
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
	static public int CreateDelegate__Type__MethodInfo__Boolean_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			System.Reflection.MethodInfo a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			var ret=System.Delegate.CreateDelegate(a1,a2,a3);
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
	static public int CreateDelegate__Type__Object__String_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			var ret=System.Delegate.CreateDelegate(a1,a2,a3);
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
	static public int CreateDelegate__Type__Type__String_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			System.Type a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			var ret=System.Delegate.CreateDelegate(a1,a2,a3);
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
	static public int CreateDelegate__Type__Object__MethodInfo__Boolean_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			System.Reflection.MethodInfo a3;
			checkType(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			var ret=System.Delegate.CreateDelegate(a1,a2,a3,a4);
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
	static public int CreateDelegate__Type__Type__String__Boolean_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			System.Type a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			var ret=System.Delegate.CreateDelegate(a1,a2,a3,a4);
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
	static public int CreateDelegate__Type__Object__String__Boolean_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			var ret=System.Delegate.CreateDelegate(a1,a2,a3,a4);
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
	static public int CreateDelegate__Type__Type__String__Boolean__Boolean_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			System.Type a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			var ret=System.Delegate.CreateDelegate(a1,a2,a3,a4,a5);
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
	static public int CreateDelegate__Type__Object__String__Boolean__Boolean_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			var ret=System.Delegate.CreateDelegate(a1,a2,a3,a4,a5);
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
	static public int Combine__A_Delegate_s(IntPtr l) {
		try {
			System.Delegate[] a1;
			checkParams(l,1,out a1);
			var ret=System.Delegate.Combine(a1);
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
	static public int Combine__Delegate__Delegate_s(IntPtr l) {
		try {
			System.Delegate a1;
			checkType(l,1,out a1);
			System.Delegate a2;
			checkType(l,2,out a2);
			var ret=System.Delegate.Combine(a1,a2);
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
		addMember(l,Equals);
		addMember(l,GetObjectData);
		addMember(l,GetInvocationList);
		addMember(l,CreateDelegate__Type__MethodInfo_s);
		addMember(l,CreateDelegate__Type__Object__MethodInfo_s);
		addMember(l,CreateDelegate__Type__MethodInfo__Boolean_s);
		addMember(l,CreateDelegate__Type__Object__String_s);
		addMember(l,CreateDelegate__Type__Type__String_s);
		addMember(l,CreateDelegate__Type__Object__MethodInfo__Boolean_s);
		addMember(l,CreateDelegate__Type__Type__String__Boolean_s);
		addMember(l,CreateDelegate__Type__Object__String__Boolean_s);
		addMember(l,CreateDelegate__Type__Type__String__Boolean__Boolean_s);
		addMember(l,CreateDelegate__Type__Object__String__Boolean__Boolean_s);
		addMember(l,Combine__A_Delegate_s);
		addMember(l,Combine__Delegate__Delegate_s);
		addMember(l,Remove_s);
		addMember(l,RemoveAll_s);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"Method",get_Method,null,true);
		addMember(l,"Target",get_Target,null,true);
		createTypeMetatable(l,null, typeof(System.Delegate));
	}
}
