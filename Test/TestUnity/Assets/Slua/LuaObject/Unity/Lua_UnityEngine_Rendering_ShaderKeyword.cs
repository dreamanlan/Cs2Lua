using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_ShaderKeyword : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeyword o;
			o=new UnityEngine.Rendering.ShaderKeyword();
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
	static public int ctor__String_s(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeyword o;
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Rendering.ShaderKeyword(a1);
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
			UnityEngine.Rendering.ShaderKeyword o;
			UnityEngine.Shader a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Rendering.ShaderKeyword(a1,a2);
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
			UnityEngine.Rendering.ShaderKeyword o;
			UnityEngine.ComputeShader a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Rendering.ShaderKeyword(a1,a2);
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
	static public int IsValid(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeyword self;
			checkValueType(l,1,out self);
			var ret=self.IsValid();
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
	static public int IsValid__ComputeShader(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeyword self;
			checkValueType(l,1,out self);
			UnityEngine.ComputeShader a1;
			checkType(l,2,out a1);
			var ret=self.IsValid(a1);
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
	static public int IsValid__Shader(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeyword self;
			checkValueType(l,1,out self);
			UnityEngine.Shader a1;
			checkType(l,2,out a1);
			var ret=self.IsValid(a1);
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
			UnityEngine.Rendering.ShaderKeyword self;
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
	static public int GetGlobalKeywordType_s(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeyword a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.Rendering.ShaderKeyword.GetGlobalKeywordType(a1);
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
	static public int IsKeywordLocal_s(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeyword a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.Rendering.ShaderKeyword.IsKeywordLocal(a1);
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
			UnityEngine.Rendering.ShaderKeyword self;
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
	static public int get_index(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeyword self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.index);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.ShaderKeyword");
		addMember(l,ctor_s);
		addMember(l,ctor__String_s);
		addMember(l,ctor__Shader__String_s);
		addMember(l,ctor__ComputeShader__String_s);
		addMember(l,IsValid);
		addMember(l,IsValid__ComputeShader);
		addMember(l,IsValid__Shader);
		addMember(l,ToString);
		addMember(l,GetGlobalKeywordType_s);
		addMember(l,IsKeywordLocal_s);
		addMember(l,"name",get_name,null,true);
		addMember(l,"index",get_index,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.ShaderKeyword),typeof(System.ValueType));
	}
}
