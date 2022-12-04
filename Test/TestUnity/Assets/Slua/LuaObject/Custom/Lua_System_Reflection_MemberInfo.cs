using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Reflection_MemberInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HasSameMetadataDefinitionAs(IntPtr l) {
		try {
			System.Reflection.MemberInfo self=(System.Reflection.MemberInfo)checkSelf(l);
			System.Reflection.MemberInfo a1;
			checkType(l,2,out a1);
			var ret=self.HasSameMetadataDefinitionAs(a1);
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
	static public int IsDefined(IntPtr l) {
		try {
			System.Reflection.MemberInfo self=(System.Reflection.MemberInfo)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			var ret=self.IsDefined(a1,a2);
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
	static public int GetCustomAttributes__Boolean(IntPtr l) {
		try {
			System.Reflection.MemberInfo self=(System.Reflection.MemberInfo)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.GetCustomAttributes(a1);
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
	static public int GetCustomAttributes__Type__Boolean(IntPtr l) {
		try {
			System.Reflection.MemberInfo self=(System.Reflection.MemberInfo)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			var ret=self.GetCustomAttributes(a1,a2);
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
			System.Reflection.MemberInfo self=(System.Reflection.MemberInfo)checkSelf(l);
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
	static public int op_Equality_s(IntPtr l) {
		try {
			System.Reflection.MemberInfo a1;
			checkType(l,1,out a1);
			System.Reflection.MemberInfo a2;
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
			System.Reflection.MemberInfo a1;
			checkType(l,1,out a1);
			System.Reflection.MemberInfo a2;
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
	static public int get_MemberType(IntPtr l) {
		try {
			System.Reflection.MemberInfo self=(System.Reflection.MemberInfo)checkSelf(l);
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
	static public int get_Name(IntPtr l) {
		try {
			System.Reflection.MemberInfo self=(System.Reflection.MemberInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Name);
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
			System.Reflection.MemberInfo self=(System.Reflection.MemberInfo)checkSelf(l);
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
	static public int get_ReflectedType(IntPtr l) {
		try {
			System.Reflection.MemberInfo self=(System.Reflection.MemberInfo)checkSelf(l);
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
	static public int get_Module(IntPtr l) {
		try {
			System.Reflection.MemberInfo self=(System.Reflection.MemberInfo)checkSelf(l);
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
	static public int get_MetadataToken(IntPtr l) {
		try {
			System.Reflection.MemberInfo self=(System.Reflection.MemberInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.MetadataToken);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Reflection.MemberInfo");
		addMember(l,HasSameMetadataDefinitionAs);
		addMember(l,IsDefined);
		addMember(l,GetCustomAttributes__Boolean);
		addMember(l,GetCustomAttributes__Type__Boolean);
		addMember(l,Equals);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"MemberType",get_MemberType,null,true);
		addMember(l,"Name",get_Name,null,true);
		addMember(l,"DeclaringType",get_DeclaringType,null,true);
		addMember(l,"ReflectedType",get_ReflectedType,null,true);
		addMember(l,"Module",get_Module,null,true);
		addMember(l,"MetadataToken",get_MetadataToken,null,true);
		createTypeMetatable(l,null, typeof(System.Reflection.MemberInfo));
	}
}
