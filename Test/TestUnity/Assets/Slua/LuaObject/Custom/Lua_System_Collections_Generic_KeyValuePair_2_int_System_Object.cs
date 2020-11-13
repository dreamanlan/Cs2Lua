﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Collections_Generic_KeyValuePair_2_int_System_Object : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			System.Collections.Generic.KeyValuePair<System.Int32,System.Object> o;
			if(argc==3){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				o=new System.Collections.Generic.KeyValuePair<System.Int32,System.Object>(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc<=2){
				o=new System.Collections.Generic.KeyValuePair<System.Int32,System.Object>();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Key(IntPtr l) {
		try {
			System.Collections.Generic.KeyValuePair<System.Int32,System.Object> self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.Key);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Value(IntPtr l) {
		try {
			System.Collections.Generic.KeyValuePair<System.Int32,System.Object> self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.Value);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"IntObjPair");
		addMember(l,"Key",get_Key,null,true);
		addMember(l,"Value",get_Value,null,true);
		createTypeMetatable(l,constructor, typeof(System.Collections.Generic.KeyValuePair<System.Int32,System.Object>),typeof(System.ValueType));
	}
}
