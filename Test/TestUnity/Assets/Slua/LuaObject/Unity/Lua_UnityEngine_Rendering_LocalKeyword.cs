using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_LocalKeyword : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeyword o;
			o=new UnityEngine.Rendering.LocalKeyword();
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
	static public int ctor__Shader__String_s(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeyword o;
			UnityEngine.Shader a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Rendering.LocalKeyword(a1,a2);
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
	static public int ctor__ComputeShader__String_s(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeyword o;
			UnityEngine.ComputeShader a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Rendering.LocalKeyword(a1,a2);
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
	static new public int ToString(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeyword self;
			checkValueType(l,1,out self);
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
			UnityEngine.Rendering.LocalKeyword self;
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
	static public int Equals__LocalKeyword(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeyword self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.LocalKeyword a1;
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
			UnityEngine.Rendering.LocalKeyword a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.LocalKeyword a2;
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
			UnityEngine.Rendering.LocalKeyword a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.LocalKeyword a2;
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
	static public int get_name(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeyword self;
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
	static public int get_isOverridable(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeyword self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.isOverridable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isValid(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeyword self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.isValid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_type(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeyword self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.LocalKeyword");
		addMember(l,ctor_s);
		addMember(l,ctor__Shader__String_s);
		addMember(l,ctor__ComputeShader__String_s);
		addMember(l,ToString);
		addMember(l,Equals__Object);
		addMember(l,Equals__LocalKeyword);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"name",get_name,null,true);
		addMember(l,"isOverridable",get_isOverridable,null,true);
		addMember(l,"isValid",get_isValid,null,true);
		addMember(l,"type",get_type,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.LocalKeyword),typeof(System.ValueType));
	}
}
