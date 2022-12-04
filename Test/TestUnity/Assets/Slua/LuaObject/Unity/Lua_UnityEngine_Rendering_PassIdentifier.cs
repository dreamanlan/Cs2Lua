using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_PassIdentifier : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.PassIdentifier o;
			o=new UnityEngine.Rendering.PassIdentifier();
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
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.Rendering.PassIdentifier self;
			checkValueType(l,1,out self);
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
	static public int Equals__PassIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.PassIdentifier self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.PassIdentifier a1;
			checkValueType(l,2,out a1);
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
			UnityEngine.Rendering.PassIdentifier a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.PassIdentifier a2;
			checkValueType(l,2,out a2);
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
			UnityEngine.Rendering.PassIdentifier a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.PassIdentifier a2;
			checkValueType(l,2,out a2);
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
	static public int get_SubshaderIndex(IntPtr l) {
		try {
			UnityEngine.Rendering.PassIdentifier self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.SubshaderIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_PassIndex(IntPtr l) {
		try {
			UnityEngine.Rendering.PassIdentifier self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.PassIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.PassIdentifier");
		addMember(l,ctor_s);
		addMember(l,Equals__Object);
		addMember(l,Equals__PassIdentifier);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"SubshaderIndex",get_SubshaderIndex,null,true);
		addMember(l,"PassIndex",get_PassIndex,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.PassIdentifier),typeof(System.ValueType));
	}
}
