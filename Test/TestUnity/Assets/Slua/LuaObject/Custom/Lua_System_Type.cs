using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Type : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsEnumDefined(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.IsEnumDefined(a1);
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
	static public int GetEnumName(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.GetEnumName(a1);
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
	static public int GetEnumNames(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetEnumNames();
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
	static public int FindInterfaces(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Reflection.TypeFilter a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			var ret=self.FindInterfaces(a1,a2);
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
	static public int FindMembers(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Reflection.MemberTypes a1;
			checkEnum(l,2,out a1);
			System.Reflection.BindingFlags a2;
			checkEnum(l,3,out a2);
			System.Reflection.MemberFilter a3;
			LuaDelegation.checkDelegate(l,4,out a3);
			System.Object a4;
			checkType(l,5,out a4);
			var ret=self.FindMembers(a1,a2,a3,a4);
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
	static public int IsSubclassOf(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.IsSubclassOf(a1);
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
	static public int IsAssignableFrom(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.IsAssignableFrom(a1);
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
	static public int GetElementType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetElementType();
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
	static public int GetArrayRank(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetArrayRank();
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
	static public int GetGenericTypeDefinition(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetGenericTypeDefinition();
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
	static public int GetGenericArguments(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetGenericArguments();
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
	static public int GetGenericParameterConstraints(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetGenericParameterConstraints();
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
	static public int GetConstructor__A_Type(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Type[] a1;
			checkArray(l,2,out a1);
			var ret=self.GetConstructor(a1);
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
	static public int GetConstructor__BindingFlags__Binder__A_Type__A_ParameterModifier(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Reflection.BindingFlags a1;
			checkEnum(l,2,out a1);
			System.Reflection.Binder a2;
			checkType(l,3,out a2);
			System.Type[] a3;
			checkArray(l,4,out a3);
			System.Reflection.ParameterModifier[] a4;
			checkArray(l,5,out a4);
			var ret=self.GetConstructor(a1,a2,a3,a4);
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
	static public int GetConstructor__BindingFlags__Binder__CallingConventions__A_Type__A_ParameterModifier(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Reflection.BindingFlags a1;
			checkEnum(l,2,out a1);
			System.Reflection.Binder a2;
			checkType(l,3,out a2);
			System.Reflection.CallingConventions a3;
			checkEnum(l,4,out a3);
			System.Type[] a4;
			checkArray(l,5,out a4);
			System.Reflection.ParameterModifier[] a5;
			checkArray(l,6,out a5);
			var ret=self.GetConstructor(a1,a2,a3,a4,a5);
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
	static public int GetConstructors(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetConstructors();
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
	static public int GetConstructors__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Reflection.BindingFlags a1;
			checkEnum(l,2,out a1);
			var ret=self.GetConstructors(a1);
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
	static public int GetEvent__String(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetEvent(a1);
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
	static public int GetEvent__String__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Reflection.BindingFlags a2;
			checkEnum(l,3,out a2);
			var ret=self.GetEvent(a1,a2);
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
	static public int GetEvents(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetEvents();
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
	static public int GetEvents__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Reflection.BindingFlags a1;
			checkEnum(l,2,out a1);
			var ret=self.GetEvents(a1);
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
	static public int GetField__String(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetField(a1);
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
	static public int GetField__String__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Reflection.BindingFlags a2;
			checkEnum(l,3,out a2);
			var ret=self.GetField(a1,a2);
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
	static public int GetFields(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetFields();
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
	static public int GetFields__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Reflection.BindingFlags a1;
			checkEnum(l,2,out a1);
			var ret=self.GetFields(a1);
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
	static public int GetMember__String(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetMember(a1);
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
	static public int GetMember__String__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Reflection.BindingFlags a2;
			checkEnum(l,3,out a2);
			var ret=self.GetMember(a1,a2);
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
	static public int GetMember__String__MemberTypes__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Reflection.MemberTypes a2;
			checkEnum(l,3,out a2);
			System.Reflection.BindingFlags a3;
			checkEnum(l,4,out a3);
			var ret=self.GetMember(a1,a2,a3);
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
	static public int GetMembers(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetMembers();
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
	static public int GetMembers__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Reflection.BindingFlags a1;
			checkEnum(l,2,out a1);
			var ret=self.GetMembers(a1);
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
	static public int GetMethod__String(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetMethod(a1);
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
	static public int GetMethod__String__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Reflection.BindingFlags a2;
			checkEnum(l,3,out a2);
			var ret=self.GetMethod(a1,a2);
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
	static public int GetMethod__String__A_Type(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type[] a2;
			checkArray(l,3,out a2);
			var ret=self.GetMethod(a1,a2);
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
	static public int GetMethod__String__A_Type__A_ParameterModifier(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type[] a2;
			checkArray(l,3,out a2);
			System.Reflection.ParameterModifier[] a3;
			checkArray(l,4,out a3);
			var ret=self.GetMethod(a1,a2,a3);
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
	static public int GetMethod__String__Int32__A_Type(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Type[] a3;
			checkArray(l,4,out a3);
			var ret=self.GetMethod(a1,a2,a3);
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
	static public int GetMethod__String__Int32__A_Type__A_ParameterModifier(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Type[] a3;
			checkArray(l,4,out a3);
			System.Reflection.ParameterModifier[] a4;
			checkArray(l,5,out a4);
			var ret=self.GetMethod(a1,a2,a3,a4);
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
	static public int GetMethod__String__BindingFlags__Binder__A_Type__A_ParameterModifier(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Reflection.BindingFlags a2;
			checkEnum(l,3,out a2);
			System.Reflection.Binder a3;
			checkType(l,4,out a3);
			System.Type[] a4;
			checkArray(l,5,out a4);
			System.Reflection.ParameterModifier[] a5;
			checkArray(l,6,out a5);
			var ret=self.GetMethod(a1,a2,a3,a4,a5);
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
	static public int GetMethod__String__BindingFlags__Binder__CallingConventions__A_Type__A_ParameterModifier(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Reflection.BindingFlags a2;
			checkEnum(l,3,out a2);
			System.Reflection.Binder a3;
			checkType(l,4,out a3);
			System.Reflection.CallingConventions a4;
			checkEnum(l,5,out a4);
			System.Type[] a5;
			checkArray(l,6,out a5);
			System.Reflection.ParameterModifier[] a6;
			checkArray(l,7,out a6);
			var ret=self.GetMethod(a1,a2,a3,a4,a5,a6);
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
	static public int GetMethod__String__Int32__BindingFlags__Binder__A_Type__A_ParameterModifier(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Reflection.BindingFlags a3;
			checkEnum(l,4,out a3);
			System.Reflection.Binder a4;
			checkType(l,5,out a4);
			System.Type[] a5;
			checkArray(l,6,out a5);
			System.Reflection.ParameterModifier[] a6;
			checkArray(l,7,out a6);
			var ret=self.GetMethod(a1,a2,a3,a4,a5,a6);
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
	static public int GetMethod__String__Int32__BindingFlags__Binder__CallingConventions__A_Type__A_ParameterModifier(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Reflection.BindingFlags a3;
			checkEnum(l,4,out a3);
			System.Reflection.Binder a4;
			checkType(l,5,out a4);
			System.Reflection.CallingConventions a5;
			checkEnum(l,6,out a5);
			System.Type[] a6;
			checkArray(l,7,out a6);
			System.Reflection.ParameterModifier[] a7;
			checkArray(l,8,out a7);
			var ret=self.GetMethod(a1,a2,a3,a4,a5,a6,a7);
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
	static public int GetMethods(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetMethods();
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
	static public int GetMethods__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Reflection.BindingFlags a1;
			checkEnum(l,2,out a1);
			var ret=self.GetMethods(a1);
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
	static public int GetNestedType__String(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetNestedType(a1);
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
	static public int GetNestedType__String__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Reflection.BindingFlags a2;
			checkEnum(l,3,out a2);
			var ret=self.GetNestedType(a1,a2);
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
	static public int GetNestedTypes(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetNestedTypes();
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
	static public int GetNestedTypes__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Reflection.BindingFlags a1;
			checkEnum(l,2,out a1);
			var ret=self.GetNestedTypes(a1);
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
	static public int GetProperty__String(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetProperty(a1);
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
	static public int GetProperty__String__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Reflection.BindingFlags a2;
			checkEnum(l,3,out a2);
			var ret=self.GetProperty(a1,a2);
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
	static public int GetProperty__String__Type(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type a2;
			checkType(l,3,out a2);
			var ret=self.GetProperty(a1,a2);
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
	static public int GetProperty__String__A_Type(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type[] a2;
			checkArray(l,3,out a2);
			var ret=self.GetProperty(a1,a2);
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
	static public int GetProperty__String__Type__A_Type(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type a2;
			checkType(l,3,out a2);
			System.Type[] a3;
			checkArray(l,4,out a3);
			var ret=self.GetProperty(a1,a2,a3);
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
	static public int GetProperty__String__Type__A_Type__A_ParameterModifier(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type a2;
			checkType(l,3,out a2);
			System.Type[] a3;
			checkArray(l,4,out a3);
			System.Reflection.ParameterModifier[] a4;
			checkArray(l,5,out a4);
			var ret=self.GetProperty(a1,a2,a3,a4);
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
	static public int GetProperty__String__BindingFlags__Binder__Type__A_Type__A_ParameterModifier(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Reflection.BindingFlags a2;
			checkEnum(l,3,out a2);
			System.Reflection.Binder a3;
			checkType(l,4,out a3);
			System.Type a4;
			checkType(l,5,out a4);
			System.Type[] a5;
			checkArray(l,6,out a5);
			System.Reflection.ParameterModifier[] a6;
			checkArray(l,7,out a6);
			var ret=self.GetProperty(a1,a2,a3,a4,a5,a6);
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
	static public int GetProperties(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetProperties();
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
	static public int GetProperties__BindingFlags(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Reflection.BindingFlags a1;
			checkEnum(l,2,out a1);
			var ret=self.GetProperties(a1);
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
	static public int GetDefaultMembers(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetDefaultMembers();
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
	static public int InvokeMember__String__BindingFlags__Binder__Object__A_Object(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Reflection.BindingFlags a2;
			checkEnum(l,3,out a2);
			System.Reflection.Binder a3;
			checkType(l,4,out a3);
			System.Object a4;
			checkType(l,5,out a4);
			System.Object[] a5;
			checkArray(l,6,out a5);
			var ret=self.InvokeMember(a1,a2,a3,a4,a5);
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
	static public int InvokeMember__String__BindingFlags__Binder__Object__A_Object__CultureInfo(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Reflection.BindingFlags a2;
			checkEnum(l,3,out a2);
			System.Reflection.Binder a3;
			checkType(l,4,out a3);
			System.Object a4;
			checkType(l,5,out a4);
			System.Object[] a5;
			checkArray(l,6,out a5);
			System.Globalization.CultureInfo a6;
			checkType(l,7,out a6);
			var ret=self.InvokeMember(a1,a2,a3,a4,a5,a6);
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
	static public int InvokeMember__String__BindingFlags__Binder__Object__A_Object__A_ParameterModifier__CultureInfo__A_String(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Reflection.BindingFlags a2;
			checkEnum(l,3,out a2);
			System.Reflection.Binder a3;
			checkType(l,4,out a3);
			System.Object a4;
			checkType(l,5,out a4);
			System.Object[] a5;
			checkArray(l,6,out a5);
			System.Reflection.ParameterModifier[] a6;
			checkArray(l,7,out a6);
			System.Globalization.CultureInfo a7;
			checkType(l,8,out a7);
			System.String[] a8;
			checkArray(l,9,out a8);
			var ret=self.InvokeMember(a1,a2,a3,a4,a5,a6,a7,a8);
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
	static public int GetInterface__String(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetInterface(a1);
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
	static public int GetInterface__String__Boolean(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			var ret=self.GetInterface(a1,a2);
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
	static public int GetInterfaces(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetInterfaces();
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
	static public int GetInterfaceMap(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.GetInterfaceMap(a1);
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
	static public int IsInstanceOfType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.IsInstanceOfType(a1);
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
	static public int IsEquivalentTo(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.IsEquivalentTo(a1);
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
	static public int GetEnumUnderlyingType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetEnumUnderlyingType();
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
	static public int GetEnumValues(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.GetEnumValues();
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
	static public int MakeArrayType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.MakeArrayType();
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
	static public int MakeArrayType__Int32(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.MakeArrayType(a1);
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
	static public int MakeByRefType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.MakeByRefType();
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
	static public int MakeGenericType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Type[] a1;
			checkParams(l,2,out a1);
			var ret=self.MakeGenericType(a1);
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
	static public int MakePointerType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.MakePointerType();
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
	static new public int ToString(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			var ret=self.ToString();
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
	static public int Equals__Object(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
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
	static public int Equals__Type(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			System.Type a1;
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
	static public int GetTypeHandle_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			var ret=System.Type.GetTypeHandle(a1);
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
	static public int GetTypeArray_s(IntPtr l) {
		try {
			System.Object[] a1;
			checkArray(l,1,out a1);
			var ret=System.Type.GetTypeArray(a1);
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
	static public int GetTypeCode_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			var ret=System.Type.GetTypeCode(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTypeFromCLSID__Guid_s(IntPtr l) {
		try {
			System.Guid a1;
			checkValueType(l,1,out a1);
			var ret=System.Type.GetTypeFromCLSID(a1);
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
	static public int GetTypeFromCLSID__Guid__Boolean_s(IntPtr l) {
		try {
			System.Guid a1;
			checkValueType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			var ret=System.Type.GetTypeFromCLSID(a1,a2);
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
	static public int GetTypeFromCLSID__Guid__String_s(IntPtr l) {
		try {
			System.Guid a1;
			checkValueType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.Type.GetTypeFromCLSID(a1,a2);
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
	static public int GetTypeFromCLSID__Guid__String__Boolean_s(IntPtr l) {
		try {
			System.Guid a1;
			checkValueType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			var ret=System.Type.GetTypeFromCLSID(a1,a2,a3);
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
	static public int GetTypeFromProgID__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.Type.GetTypeFromProgID(a1);
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
	static public int GetTypeFromProgID__String__Boolean_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			var ret=System.Type.GetTypeFromProgID(a1,a2);
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
	static public int GetTypeFromProgID__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.Type.GetTypeFromProgID(a1,a2);
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
	static public int GetTypeFromProgID__String__String__Boolean_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			var ret=System.Type.GetTypeFromProgID(a1,a2,a3);
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
	static public int MakeGenericMethodParameter_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=System.Type.MakeGenericMethodParameter(a1);
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
	static public int GetTypeFromHandle_s(IntPtr l) {
		try {
			System.RuntimeTypeHandle a1;
			checkValueType(l,1,out a1);
			var ret=System.Type.GetTypeFromHandle(a1);
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
	static public int GetType__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.Type.GetType(a1);
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
	static public int GetType__String__Boolean_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			var ret=System.Type.GetType(a1,a2);
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
	static public int GetType__String__Boolean__Boolean_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			var ret=System.Type.GetType(a1,a2,a3);
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
			System.Type a1;
			checkType(l,1,out a1);
			System.Type a2;
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
			System.Type a1;
			checkType(l,1,out a1);
			System.Type a2;
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
	static public int ReflectionOnlyGetType_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			var ret=System.Type.ReflectionOnlyGetType(a1,a2,a3);
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
	static public int get_Delimiter(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Type.Delimiter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_EmptyTypes(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Type.EmptyTypes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Missing(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Type.Missing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsSerializable(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsSerializable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ContainsGenericParameters(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ContainsGenericParameters);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsVisible(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsVisible);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_MemberType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.MemberType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Namespace(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Namespace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_AssemblyQualifiedName(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.AssemblyQualifiedName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_FullName(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.FullName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Assembly(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Assembly);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Module(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Module);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsNested(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsNested);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DeclaringType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.DeclaringType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DeclaringMethod(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.DeclaringMethod);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ReflectedType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ReflectedType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_UnderlyingSystemType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.UnderlyingSystemType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsTypeDefinition(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsTypeDefinition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsArray(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsArray);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsByRef(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsByRef);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsPointer(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsPointer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsConstructedGenericType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsConstructedGenericType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsGenericParameter(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsGenericParameter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsGenericTypeParameter(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsGenericTypeParameter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsGenericMethodParameter(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsGenericMethodParameter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsGenericType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsGenericType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsGenericTypeDefinition(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsGenericTypeDefinition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsVariableBoundArray(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsVariableBoundArray);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsByRefLike(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsByRefLike);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_HasElementType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.HasElementType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_GenericTypeArguments(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.GenericTypeArguments);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_GenericParameterPosition(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.GenericParameterPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_GenericParameterAttributes(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.GenericParameterAttributes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Attributes(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.Attributes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsAbstract(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsAbstract);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsImport(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsImport);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsSealed(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsSealed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsSpecialName(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsSpecialName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsClass(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsClass);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsNestedAssembly(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsNestedAssembly);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsNestedFamANDAssem(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsNestedFamANDAssem);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsNestedFamily(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsNestedFamily);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsNestedFamORAssem(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsNestedFamORAssem);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsNestedPrivate(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsNestedPrivate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsNestedPublic(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsNestedPublic);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsNotPublic(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsNotPublic);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsPublic(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsPublic);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsAutoLayout(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsAutoLayout);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsExplicitLayout(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsExplicitLayout);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsLayoutSequential(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsLayoutSequential);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsAnsiClass(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsAnsiClass);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsAutoClass(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsAutoClass);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsUnicodeClass(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsUnicodeClass);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsCOMObject(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsCOMObject);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsContextful(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsContextful);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsEnum(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsEnum);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsMarshalByRef(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsMarshalByRef);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsPrimitive(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsPrimitive);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsValueType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsValueType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsSignatureType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsSignatureType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsSecurityCritical(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsSecurityCritical);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsSecuritySafeCritical(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsSecuritySafeCritical);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsSecurityTransparent(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsSecurityTransparent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_StructLayoutAttribute(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.StructLayoutAttribute);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_TypeInitializer(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.TypeInitializer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_TypeHandle(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.TypeHandle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_GUID(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.GUID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_BaseType(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.BaseType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DefaultBinder(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Type.DefaultBinder);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsInterface(IntPtr l) {
		try {
			System.Type self=(System.Type)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsInterface);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Type");
		addMember(l,IsEnumDefined);
		addMember(l,GetEnumName);
		addMember(l,GetEnumNames);
		addMember(l,FindInterfaces);
		addMember(l,FindMembers);
		addMember(l,IsSubclassOf);
		addMember(l,IsAssignableFrom);
		addMember(l,GetElementType);
		addMember(l,GetArrayRank);
		addMember(l,GetGenericTypeDefinition);
		addMember(l,GetGenericArguments);
		addMember(l,GetGenericParameterConstraints);
		addMember(l,GetConstructor__A_Type);
		addMember(l,GetConstructor__BindingFlags__Binder__A_Type__A_ParameterModifier);
		addMember(l,GetConstructor__BindingFlags__Binder__CallingConventions__A_Type__A_ParameterModifier);
		addMember(l,GetConstructors);
		addMember(l,GetConstructors__BindingFlags);
		addMember(l,GetEvent__String);
		addMember(l,GetEvent__String__BindingFlags);
		addMember(l,GetEvents);
		addMember(l,GetEvents__BindingFlags);
		addMember(l,GetField__String);
		addMember(l,GetField__String__BindingFlags);
		addMember(l,GetFields);
		addMember(l,GetFields__BindingFlags);
		addMember(l,GetMember__String);
		addMember(l,GetMember__String__BindingFlags);
		addMember(l,GetMember__String__MemberTypes__BindingFlags);
		addMember(l,GetMembers);
		addMember(l,GetMembers__BindingFlags);
		addMember(l,GetMethod__String);
		addMember(l,GetMethod__String__BindingFlags);
		addMember(l,GetMethod__String__A_Type);
		addMember(l,GetMethod__String__A_Type__A_ParameterModifier);
		addMember(l,GetMethod__String__Int32__A_Type);
		addMember(l,GetMethod__String__Int32__A_Type__A_ParameterModifier);
		addMember(l,GetMethod__String__BindingFlags__Binder__A_Type__A_ParameterModifier);
		addMember(l,GetMethod__String__BindingFlags__Binder__CallingConventions__A_Type__A_ParameterModifier);
		addMember(l,GetMethod__String__Int32__BindingFlags__Binder__A_Type__A_ParameterModifier);
		addMember(l,GetMethod__String__Int32__BindingFlags__Binder__CallingConventions__A_Type__A_ParameterModifier);
		addMember(l,GetMethods);
		addMember(l,GetMethods__BindingFlags);
		addMember(l,GetNestedType__String);
		addMember(l,GetNestedType__String__BindingFlags);
		addMember(l,GetNestedTypes);
		addMember(l,GetNestedTypes__BindingFlags);
		addMember(l,GetProperty__String);
		addMember(l,GetProperty__String__BindingFlags);
		addMember(l,GetProperty__String__Type);
		addMember(l,GetProperty__String__A_Type);
		addMember(l,GetProperty__String__Type__A_Type);
		addMember(l,GetProperty__String__Type__A_Type__A_ParameterModifier);
		addMember(l,GetProperty__String__BindingFlags__Binder__Type__A_Type__A_ParameterModifier);
		addMember(l,GetProperties);
		addMember(l,GetProperties__BindingFlags);
		addMember(l,GetDefaultMembers);
		addMember(l,InvokeMember__String__BindingFlags__Binder__Object__A_Object);
		addMember(l,InvokeMember__String__BindingFlags__Binder__Object__A_Object__CultureInfo);
		addMember(l,InvokeMember__String__BindingFlags__Binder__Object__A_Object__A_ParameterModifier__CultureInfo__A_String);
		addMember(l,GetInterface__String);
		addMember(l,GetInterface__String__Boolean);
		addMember(l,GetInterfaces);
		addMember(l,GetInterfaceMap);
		addMember(l,IsInstanceOfType);
		addMember(l,IsEquivalentTo);
		addMember(l,GetEnumUnderlyingType);
		addMember(l,GetEnumValues);
		addMember(l,MakeArrayType);
		addMember(l,MakeArrayType__Int32);
		addMember(l,MakeByRefType);
		addMember(l,MakeGenericType);
		addMember(l,MakePointerType);
		addMember(l,ToString);
		addMember(l,Equals__Object);
		addMember(l,Equals__Type);
		addMember(l,GetTypeHandle_s);
		addMember(l,GetTypeArray_s);
		addMember(l,GetTypeCode_s);
		addMember(l,GetTypeFromCLSID__Guid_s);
		addMember(l,GetTypeFromCLSID__Guid__Boolean_s);
		addMember(l,GetTypeFromCLSID__Guid__String_s);
		addMember(l,GetTypeFromCLSID__Guid__String__Boolean_s);
		addMember(l,GetTypeFromProgID__String_s);
		addMember(l,GetTypeFromProgID__String__Boolean_s);
		addMember(l,GetTypeFromProgID__String__String_s);
		addMember(l,GetTypeFromProgID__String__String__Boolean_s);
		addMember(l,MakeGenericMethodParameter_s);
		addMember(l,GetTypeFromHandle_s);
		addMember(l,GetType__String_s);
		addMember(l,GetType__String__Boolean_s);
		addMember(l,GetType__String__Boolean__Boolean_s);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,ReflectionOnlyGetType_s);
		addMember(l,"Delimiter",get_Delimiter,null,false);
		addMember(l,"EmptyTypes",get_EmptyTypes,null,false);
		addMember(l,"Missing",get_Missing,null,false);
		addMember(l,"FilterAttribute",null,null,false);
		addMember(l,"FilterName",null,null,false);
		addMember(l,"FilterNameIgnoreCase",null,null,false);
		addMember(l,"IsSerializable",get_IsSerializable,null,true);
		addMember(l,"ContainsGenericParameters",get_ContainsGenericParameters,null,true);
		addMember(l,"IsVisible",get_IsVisible,null,true);
		addMember(l,"MemberType",get_MemberType,null,true);
		addMember(l,"Namespace",get_Namespace,null,true);
		addMember(l,"AssemblyQualifiedName",get_AssemblyQualifiedName,null,true);
		addMember(l,"FullName",get_FullName,null,true);
		addMember(l,"Assembly",get_Assembly,null,true);
		addMember(l,"Module",get_Module,null,true);
		addMember(l,"IsNested",get_IsNested,null,true);
		addMember(l,"DeclaringType",get_DeclaringType,null,true);
		addMember(l,"DeclaringMethod",get_DeclaringMethod,null,true);
		addMember(l,"ReflectedType",get_ReflectedType,null,true);
		addMember(l,"UnderlyingSystemType",get_UnderlyingSystemType,null,true);
		addMember(l,"IsTypeDefinition",get_IsTypeDefinition,null,true);
		addMember(l,"IsArray",get_IsArray,null,true);
		addMember(l,"IsByRef",get_IsByRef,null,true);
		addMember(l,"IsPointer",get_IsPointer,null,true);
		addMember(l,"IsConstructedGenericType",get_IsConstructedGenericType,null,true);
		addMember(l,"IsGenericParameter",get_IsGenericParameter,null,true);
		addMember(l,"IsGenericTypeParameter",get_IsGenericTypeParameter,null,true);
		addMember(l,"IsGenericMethodParameter",get_IsGenericMethodParameter,null,true);
		addMember(l,"IsGenericType",get_IsGenericType,null,true);
		addMember(l,"IsGenericTypeDefinition",get_IsGenericTypeDefinition,null,true);
		addMember(l,"IsVariableBoundArray",get_IsVariableBoundArray,null,true);
		addMember(l,"IsByRefLike",get_IsByRefLike,null,true);
		addMember(l,"HasElementType",get_HasElementType,null,true);
		addMember(l,"GenericTypeArguments",get_GenericTypeArguments,null,true);
		addMember(l,"GenericParameterPosition",get_GenericParameterPosition,null,true);
		addMember(l,"GenericParameterAttributes",get_GenericParameterAttributes,null,true);
		addMember(l,"Attributes",get_Attributes,null,true);
		addMember(l,"IsAbstract",get_IsAbstract,null,true);
		addMember(l,"IsImport",get_IsImport,null,true);
		addMember(l,"IsSealed",get_IsSealed,null,true);
		addMember(l,"IsSpecialName",get_IsSpecialName,null,true);
		addMember(l,"IsClass",get_IsClass,null,true);
		addMember(l,"IsNestedAssembly",get_IsNestedAssembly,null,true);
		addMember(l,"IsNestedFamANDAssem",get_IsNestedFamANDAssem,null,true);
		addMember(l,"IsNestedFamily",get_IsNestedFamily,null,true);
		addMember(l,"IsNestedFamORAssem",get_IsNestedFamORAssem,null,true);
		addMember(l,"IsNestedPrivate",get_IsNestedPrivate,null,true);
		addMember(l,"IsNestedPublic",get_IsNestedPublic,null,true);
		addMember(l,"IsNotPublic",get_IsNotPublic,null,true);
		addMember(l,"IsPublic",get_IsPublic,null,true);
		addMember(l,"IsAutoLayout",get_IsAutoLayout,null,true);
		addMember(l,"IsExplicitLayout",get_IsExplicitLayout,null,true);
		addMember(l,"IsLayoutSequential",get_IsLayoutSequential,null,true);
		addMember(l,"IsAnsiClass",get_IsAnsiClass,null,true);
		addMember(l,"IsAutoClass",get_IsAutoClass,null,true);
		addMember(l,"IsUnicodeClass",get_IsUnicodeClass,null,true);
		addMember(l,"IsCOMObject",get_IsCOMObject,null,true);
		addMember(l,"IsContextful",get_IsContextful,null,true);
		addMember(l,"IsEnum",get_IsEnum,null,true);
		addMember(l,"IsMarshalByRef",get_IsMarshalByRef,null,true);
		addMember(l,"IsPrimitive",get_IsPrimitive,null,true);
		addMember(l,"IsValueType",get_IsValueType,null,true);
		addMember(l,"IsSignatureType",get_IsSignatureType,null,true);
		addMember(l,"IsSecurityCritical",get_IsSecurityCritical,null,true);
		addMember(l,"IsSecuritySafeCritical",get_IsSecuritySafeCritical,null,true);
		addMember(l,"IsSecurityTransparent",get_IsSecurityTransparent,null,true);
		addMember(l,"StructLayoutAttribute",get_StructLayoutAttribute,null,true);
		addMember(l,"TypeInitializer",get_TypeInitializer,null,true);
		addMember(l,"TypeHandle",get_TypeHandle,null,true);
		addMember(l,"GUID",get_GUID,null,true);
		addMember(l,"BaseType",get_BaseType,null,true);
		addMember(l,"DefaultBinder",get_DefaultBinder,null,false);
		addMember(l,"IsInterface",get_IsInterface,null,true);
		createTypeMetatable(l,null, typeof(System.Type),typeof(System.Reflection.MemberInfo));
	}
}
