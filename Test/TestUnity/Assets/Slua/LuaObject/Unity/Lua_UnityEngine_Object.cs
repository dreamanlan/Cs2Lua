﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Object : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Object o;
			o=new UnityEngine.Object();
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
	static public int GetInstanceID(IntPtr l) {
		try {
			UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
			var ret=self.GetInstanceID();
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
	static public int CompareName(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "CompareName__Boolean__Object", argc, 2,typeof(UnityEngine.Object))){
				UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
				UnityEngine.Object a1;
				checkType(l,3,out a1);
				var ret=self.CompareName(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "CompareName__Boolean__String", argc, 2,typeof(string))){
				UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.CompareName(a1);
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
	static public int NameContains(IntPtr l) {
		try {
			UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.NameContains(a1);
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
	static public int op_Implicit_s(IntPtr l) {
		try {
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			System.Boolean ret=a1;
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
	static public int Instantiate_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Instantiate__Object__Object__Vector3__Quaternion__Transform", argc, 1,typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Transform))){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,4,out a3);
				UnityEngine.Transform a4;
				checkType(l,5,out a4);
				var ret=UnityEngine.Object.Instantiate(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Instantiate__Object__Object__Vector3__Quaternion__Transform", argc, 1,typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Transform))){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,4,out a3);
				UnityEngine.Transform a4;
				checkType(l,5,out a4);
				var ret=UnityEngine.Object.Instantiate<UnityEngine.Object>(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Instantiate__Object__Object__Vector3__Quaternion", argc, 1,typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion))){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,4,out a3);
				var ret=UnityEngine.Object.Instantiate(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Instantiate__Object__Object__Transform__Boolean", argc, 1,typeof(UnityEngine.Object),typeof(UnityEngine.Transform),typeof(bool))){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				UnityEngine.Transform a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				var ret=UnityEngine.Object.Instantiate(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Instantiate__Object__Object__Vector3__Quaternion", argc, 1,typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion))){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				UnityEngine.Quaternion a3;
				checkType(l,4,out a3);
				var ret=UnityEngine.Object.Instantiate<UnityEngine.Object>(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Instantiate__Object__Object__Transform__Boolean", argc, 1,typeof(UnityEngine.Object),typeof(UnityEngine.Transform),typeof(bool))){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				UnityEngine.Transform a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				var ret=UnityEngine.Object.Instantiate<UnityEngine.Object>(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Instantiate__Object__Object__Transform", argc, 1,typeof(UnityEngine.Object),typeof(UnityEngine.Transform))){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				UnityEngine.Transform a2;
				checkType(l,3,out a2);
				var ret=UnityEngine.Object.Instantiate(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Instantiate__Object__Object__Transform", argc, 1,typeof(UnityEngine.Object),typeof(UnityEngine.Transform))){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				UnityEngine.Transform a2;
				checkType(l,3,out a2);
				var ret=UnityEngine.Object.Instantiate<UnityEngine.Object>(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Instantiate__Object__Object", argc, 1,typeof(UnityEngine.Object))){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				var ret=UnityEngine.Object.Instantiate(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Instantiate__Object__Object", argc, 1,typeof(UnityEngine.Object))){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				var ret=UnityEngine.Object.Instantiate<UnityEngine.Object>(a1);
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
	static public int Destroy_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				UnityEngine.Object.Destroy(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				UnityEngine.Object.Destroy(a1);
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
	static public int DestroyImmediate_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				UnityEngine.Object.DestroyImmediate(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				UnityEngine.Object.DestroyImmediate(a1);
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
	static public int FindObjectsOfType_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Type a1;
				checkType(l,2,out a1);
				var ret=UnityEngine.Object.FindObjectsOfType(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==1){
				var ret=UnityEngine.Object.FindObjectsOfType<UnityEngine.Object>();
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
	static public int DontDestroyOnLoad_s(IntPtr l) {
		try {
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object.DontDestroyOnLoad(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int FindObjectOfType_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Type a1;
				checkType(l,2,out a1);
				var ret=UnityEngine.Object.FindObjectOfType(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==1){
				var ret=UnityEngine.Object.FindObjectOfType<UnityEngine.Object>();
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
	static public int op_Equality_s(IntPtr l) {
		try {
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
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
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
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
	static public int get_name(IntPtr l) {
		try {
			UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
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
	static public int set_name(IntPtr l) {
		try {
			UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.name=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hideFlags(IntPtr l) {
		try {
			UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.hideFlags);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_hideFlags(IntPtr l) {
		try {
			UnityEngine.Object self=(UnityEngine.Object)checkSelf(l);
			UnityEngine.HideFlags v;
			checkEnum(l,2,out v);
			self.hideFlags=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Object");
		addMember(l,GetInstanceID);
		addMember(l,CompareName);
		addMember(l,NameContains);
		addMember(l,op_Implicit_s);
		addMember(l,Instantiate_s);
		addMember(l,Destroy_s);
		addMember(l,DestroyImmediate_s);
		addMember(l,FindObjectsOfType_s);
		addMember(l,DontDestroyOnLoad_s);
		addMember(l,FindObjectOfType_s);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"hideFlags",get_hideFlags,set_hideFlags,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Object));
	}
}
