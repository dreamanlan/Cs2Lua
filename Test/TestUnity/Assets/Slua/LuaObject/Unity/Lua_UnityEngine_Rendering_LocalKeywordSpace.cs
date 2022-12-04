using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_LocalKeywordSpace : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeywordSpace o;
			o=new UnityEngine.Rendering.LocalKeywordSpace();
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
	static public int FindKeyword(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeywordSpace self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.FindKeyword(a1);
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
			UnityEngine.Rendering.LocalKeywordSpace self;
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
	static public int Equals__LocalKeywordSpace(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeywordSpace self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.LocalKeywordSpace a1;
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
			UnityEngine.Rendering.LocalKeywordSpace a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.LocalKeywordSpace a2;
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
			UnityEngine.Rendering.LocalKeywordSpace a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.LocalKeywordSpace a2;
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
	static public int get_keywords(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeywordSpace self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.keywords);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_keywordNames(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeywordSpace self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.keywordNames);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_keywordCount(IntPtr l) {
		try {
			UnityEngine.Rendering.LocalKeywordSpace self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.keywordCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.LocalKeywordSpace");
		addMember(l,ctor_s);
		addMember(l,FindKeyword);
		addMember(l,Equals__Object);
		addMember(l,Equals__LocalKeywordSpace);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"keywords",get_keywords,null,true);
		addMember(l,"keywordNames",get_keywordNames,null,true);
		addMember(l,"keywordCount",get_keywordCount,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.LocalKeywordSpace),typeof(System.ValueType));
	}
}
