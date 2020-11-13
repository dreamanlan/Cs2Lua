﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_String : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			System.String o;
			if(argc==5){
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				o=new System.String(a1,a2,a3);
				pushValue(l,true);
				pushObject(l,o);
				return 2;
			}
			else if(argc==4){
				System.Char a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				o=new System.String(a1,a2);
				pushValue(l,true);
				pushObject(l,o);
				return 2;
			}
			else if(argc==3){
				System.Char[] a1;
				checkArray(l,3,out a1);
				o=new System.String(a1);
				pushValue(l,true);
				pushObject(l,o);
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
	static public int Equals(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.StringComparison a2;
				checkEnum(l,4,out a2);
				var ret=self.Equals(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Equals__Boolean__String", argc, 2,typeof(string))){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.Equals(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Equals__Boolean__Object", argc, 2,typeof(System.Object))){
				System.String self=(System.String)checkSelf(l);
				System.Object a1;
				checkType(l,3,out a1);
				var ret=self.Equals(a1);
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
	static public int CopyTo(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Char[] a2;
			checkArray(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.CopyTo(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToCharArray(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.String self=(System.String)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.ToCharArray(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String self=(System.String)checkSelf(l);
				var ret=self.ToCharArray();
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
	static public int Split(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Split__Arr_String__Arr_Char__Int32__StringSplitOptions", argc, 2,typeof(System.Char[]),typeof(int),typeof(System.StringSplitOptions))){
				System.String self=(System.String)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.StringSplitOptions a3;
				checkEnum(l,5,out a3);
				var ret=self.Split(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Split__Arr_String__Arr_String__Int32__StringSplitOptions", argc, 2,typeof(System.String[]),typeof(int),typeof(System.StringSplitOptions))){
				System.String self=(System.String)checkSelf(l);
				System.String[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.StringSplitOptions a3;
				checkEnum(l,5,out a3);
				var ret=self.Split(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Split__Arr_String__Arr_Char__Int32", argc, 2,typeof(System.Char[]),typeof(int))){
				System.String self=(System.String)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.Split(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Split__Arr_String__Arr_Char__StringSplitOptions", argc, 2,typeof(System.Char[]),typeof(System.StringSplitOptions))){
				System.String self=(System.String)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.StringSplitOptions a2;
				checkEnum(l,4,out a2);
				var ret=self.Split(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Split__Arr_String__Arr_String__StringSplitOptions", argc, 2,typeof(System.String[]),typeof(System.StringSplitOptions))){
				System.String self=(System.String)checkSelf(l);
				System.String[] a1;
				checkArray(l,3,out a1);
				System.StringSplitOptions a2;
				checkEnum(l,4,out a2);
				var ret=self.Split(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc>=3){
				System.String self=(System.String)checkSelf(l);
				System.Char[] a1;
				checkParams(l,3,out a1);
				var ret=self.Split(a1);
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
	static public int Substring(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.String self=(System.String)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.Substring(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String self=(System.String)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				var ret=self.Substring(a1);
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
	static public int Trim(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.String self=(System.String)checkSelf(l);
				var ret=self.Trim();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc>=3){
				System.String self=(System.String)checkSelf(l);
				System.Char[] a1;
				checkParams(l,3,out a1);
				var ret=self.Trim(a1);
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
	static public int TrimStart(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkParams(l,2,out a1);
			var ret=self.TrimStart(a1);
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
	static public int TrimEnd(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Char[] a1;
			checkParams(l,2,out a1);
			var ret=self.TrimEnd(a1);
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
	static public int IsNormalized(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.String self=(System.String)checkSelf(l);
				System.Text.NormalizationForm a1;
				checkEnum(l,3,out a1);
				var ret=self.IsNormalized(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String self=(System.String)checkSelf(l);
				var ret=self.IsNormalized();
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
	static public int Normalize(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.String self=(System.String)checkSelf(l);
				System.Text.NormalizationForm a1;
				checkEnum(l,3,out a1);
				var ret=self.Normalize(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String self=(System.String)checkSelf(l);
				var ret=self.Normalize();
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
	static public int CompareTo(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "CompareTo__Int32__Object", argc, 2,typeof(System.Object))){
				System.String self=(System.String)checkSelf(l);
				System.Object a1;
				checkType(l,3,out a1);
				var ret=self.CompareTo(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "CompareTo__Int32__String", argc, 2,typeof(string))){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.CompareTo(a1);
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
	static public int Contains(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Contains(a1);
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
	static public int EndsWith(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Boolean a2;
				checkType(l,4,out a2);
				System.Globalization.CultureInfo a3;
				checkType(l,5,out a3);
				var ret=self.EndsWith(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.StringComparison a2;
				checkEnum(l,4,out a2);
				var ret=self.EndsWith(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.EndsWith(a1);
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
	static public int IndexOf(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.StringComparison a4;
				checkEnum(l,6,out a4);
				var ret=self.IndexOf(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "IndexOf__Int32__String__Int32__Int32", argc, 2,typeof(string),typeof(int),typeof(int))){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.IndexOf(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "IndexOf__Int32__String__Int32__StringComparison", argc, 2,typeof(string),typeof(int),typeof(System.StringComparison))){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.StringComparison a3;
				checkEnum(l,5,out a3);
				var ret=self.IndexOf(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "IndexOf__Int32__Char__Int32__Int32", argc, 2,typeof(System.Char),typeof(int),typeof(int))){
				System.String self=(System.String)checkSelf(l);
				System.Char a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.IndexOf(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "IndexOf__Int32__Char__Int32", argc, 2,typeof(System.Char),typeof(int))){
				System.String self=(System.String)checkSelf(l);
				System.Char a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.IndexOf(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "IndexOf__Int32__String__Int32", argc, 2,typeof(string),typeof(int))){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.IndexOf(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "IndexOf__Int32__String__StringComparison", argc, 2,typeof(string),typeof(System.StringComparison))){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.StringComparison a2;
				checkEnum(l,4,out a2);
				var ret=self.IndexOf(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "IndexOf__Int32__Char", argc, 2,typeof(System.Char))){
				System.String self=(System.String)checkSelf(l);
				System.Char a1;
				checkType(l,3,out a1);
				var ret=self.IndexOf(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "IndexOf__Int32__String", argc, 2,typeof(string))){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.IndexOf(a1);
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
	static public int IndexOfAny(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.String self=(System.String)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.IndexOfAny(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				System.String self=(System.String)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.IndexOfAny(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String self=(System.String)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				var ret=self.IndexOfAny(a1);
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
	static public int LastIndexOf(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.StringComparison a4;
				checkEnum(l,6,out a4);
				var ret=self.LastIndexOf(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "LastIndexOf__Int32__String__Int32__Int32", argc, 2,typeof(string),typeof(int),typeof(int))){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.LastIndexOf(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "LastIndexOf__Int32__String__Int32__StringComparison", argc, 2,typeof(string),typeof(int),typeof(System.StringComparison))){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.StringComparison a3;
				checkEnum(l,5,out a3);
				var ret=self.LastIndexOf(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "LastIndexOf__Int32__Char__Int32__Int32", argc, 2,typeof(System.Char),typeof(int),typeof(int))){
				System.String self=(System.String)checkSelf(l);
				System.Char a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.LastIndexOf(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "LastIndexOf__Int32__Char__Int32", argc, 2,typeof(System.Char),typeof(int))){
				System.String self=(System.String)checkSelf(l);
				System.Char a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.LastIndexOf(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "LastIndexOf__Int32__String__Int32", argc, 2,typeof(string),typeof(int))){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.LastIndexOf(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "LastIndexOf__Int32__String__StringComparison", argc, 2,typeof(string),typeof(System.StringComparison))){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.StringComparison a2;
				checkEnum(l,4,out a2);
				var ret=self.LastIndexOf(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "LastIndexOf__Int32__Char", argc, 2,typeof(System.Char))){
				System.String self=(System.String)checkSelf(l);
				System.Char a1;
				checkType(l,3,out a1);
				var ret=self.LastIndexOf(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "LastIndexOf__Int32__String", argc, 2,typeof(string))){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.LastIndexOf(a1);
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
	static public int LastIndexOfAny(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.String self=(System.String)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.LastIndexOfAny(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				System.String self=(System.String)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.LastIndexOfAny(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String self=(System.String)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				var ret=self.LastIndexOfAny(a1);
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
	static public int PadLeft(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.String self=(System.String)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Char a2;
				checkType(l,4,out a2);
				var ret=self.PadLeft(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String self=(System.String)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				var ret=self.PadLeft(a1);
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
	static public int PadRight(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.String self=(System.String)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Char a2;
				checkType(l,4,out a2);
				var ret=self.PadRight(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String self=(System.String)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				var ret=self.PadRight(a1);
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
	static public int StartsWith(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Boolean a2;
				checkType(l,4,out a2);
				System.Globalization.CultureInfo a3;
				checkType(l,5,out a3);
				var ret=self.StartsWith(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.StringComparison a2;
				checkEnum(l,4,out a2);
				var ret=self.StartsWith(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.StartsWith(a1);
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
	static public int ToLower(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.String self=(System.String)checkSelf(l);
				System.Globalization.CultureInfo a1;
				checkType(l,3,out a1);
				var ret=self.ToLower(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String self=(System.String)checkSelf(l);
				var ret=self.ToLower();
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
	static public int ToLowerInvariant(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.ToLowerInvariant();
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
	static public int ToUpper(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.String self=(System.String)checkSelf(l);
				System.Globalization.CultureInfo a1;
				checkType(l,3,out a1);
				var ret=self.ToUpper(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String self=(System.String)checkSelf(l);
				var ret=self.ToUpper();
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
	static public int ToUpperInvariant(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.ToUpperInvariant();
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
			System.String self=(System.String)checkSelf(l);
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
	static public int Insert(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			var ret=self.Insert(a1,a2);
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
	static public int Replace(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Replace__String__Char__Char", argc, 2,typeof(System.Char),typeof(System.Char))){
				System.String self=(System.String)checkSelf(l);
				System.Char a1;
				checkType(l,3,out a1);
				System.Char a2;
				checkType(l,4,out a2);
				var ret=self.Replace(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Replace__String__String__String", argc, 2,typeof(string),typeof(string))){
				System.String self=(System.String)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				var ret=self.Replace(a1,a2);
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
	static public int Remove(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.String self=(System.String)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.Remove(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String self=(System.String)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				var ret=self.Remove(a1);
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
	static public int GetTypeCode(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			var ret=self.GetTypeCode();
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
	static public int Join_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.String a1;
				checkType(l,2,out a1);
				System.String[] a2;
				checkArray(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				var ret=System.String.Join(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Join__String__String__Arr_String", argc, 1,typeof(string),typeof(System.String[]))){
				System.String a1;
				checkType(l,2,out a1);
				System.String[] a2;
				checkParams(l,3,out a2);
				var ret=System.String.Join(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Join__String__String__Arr_Object", argc, 1,typeof(string),typeof(object[]))){
				System.String a1;
				checkType(l,2,out a1);
				System.Object[] a2;
				checkParams(l,3,out a2);
				var ret=System.String.Join(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Join__String__String__IEnumerable`1_String", argc, 1,typeof(string),typeof(IEnumerable<System.String>))){
				System.String a1;
				checkType(l,2,out a1);
				System.Collections.Generic.IEnumerable<System.String> a2;
				checkType(l,3,out a2);
				var ret=System.String.Join(a1,a2);
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
	static public int Equals_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.StringComparison a3;
				checkEnum(l,4,out a3);
				var ret=System.String.Equals(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				var ret=System.String.Equals(a1,a2);
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
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
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
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
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
	static public int IsNullOrEmpty_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.String.IsNullOrEmpty(a1);
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
	static public int IsNullOrWhiteSpace_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.String.IsNullOrWhiteSpace(a1);
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
	static public int Compare_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Compare__Int32__String__Int32__String__Int32__Int32__Boolean__CultureInfo", argc, 1,typeof(string),typeof(int),typeof(string),typeof(int),typeof(int),typeof(bool),typeof(System.Globalization.CultureInfo))){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				System.Boolean a6;
				checkType(l,7,out a6);
				System.Globalization.CultureInfo a7;
				checkType(l,8,out a7);
				var ret=System.String.Compare(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Compare__Int32__String__Int32__String__Int32__Int32__CultureInfo__CompareOptions", argc, 1,typeof(string),typeof(int),typeof(string),typeof(int),typeof(int),typeof(System.Globalization.CultureInfo),typeof(System.Globalization.CompareOptions))){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				System.Globalization.CultureInfo a6;
				checkType(l,7,out a6);
				System.Globalization.CompareOptions a7;
				checkEnum(l,8,out a7);
				var ret=System.String.Compare(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Compare__Int32__String__Int32__String__Int32__Int32__Boolean", argc, 1,typeof(string),typeof(int),typeof(string),typeof(int),typeof(int),typeof(bool))){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				System.Boolean a6;
				checkType(l,7,out a6);
				var ret=System.String.Compare(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Compare__Int32__String__Int32__String__Int32__Int32__StringComparison", argc, 1,typeof(string),typeof(int),typeof(string),typeof(int),typeof(int),typeof(System.StringComparison))){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				System.StringComparison a6;
				checkEnum(l,7,out a6);
				var ret=System.String.Compare(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==6){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				var ret=System.String.Compare(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Compare__Int32__String__String__CultureInfo__CompareOptions", argc, 1,typeof(string),typeof(string),typeof(System.Globalization.CultureInfo),typeof(System.Globalization.CompareOptions))){
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.Globalization.CultureInfo a3;
				checkType(l,4,out a3);
				System.Globalization.CompareOptions a4;
				checkEnum(l,5,out a4);
				var ret=System.String.Compare(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Compare__Int32__String__String__Boolean__CultureInfo", argc, 1,typeof(string),typeof(string),typeof(bool),typeof(System.Globalization.CultureInfo))){
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				System.Globalization.CultureInfo a4;
				checkType(l,5,out a4);
				var ret=System.String.Compare(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Compare__Int32__String__String__Boolean", argc, 1,typeof(string),typeof(string),typeof(bool))){
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				var ret=System.String.Compare(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Compare__Int32__String__String__StringComparison", argc, 1,typeof(string),typeof(string),typeof(System.StringComparison))){
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.StringComparison a3;
				checkEnum(l,4,out a3);
				var ret=System.String.Compare(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				var ret=System.String.Compare(a1,a2);
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
	static public int CompareOrdinal_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				var ret=System.String.CompareOrdinal(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				var ret=System.String.CompareOrdinal(a1,a2);
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
	static public int Format_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				System.IFormatProvider a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.Object a3;
				checkType(l,4,out a3);
				System.Object a4;
				checkType(l,5,out a4);
				System.Object a5;
				checkType(l,6,out a5);
				var ret=System.String.Format(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Format__String__String__Object__Object__Object", argc, 1,typeof(string),typeof(System.Object),typeof(System.Object),typeof(System.Object))){
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				System.Object a3;
				checkType(l,4,out a3);
				System.Object a4;
				checkType(l,5,out a4);
				var ret=System.String.Format(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Format__String__IFormatProvider__String__Object__Object", argc, 1,typeof(System.IFormatProvider),typeof(string),typeof(System.Object),typeof(System.Object))){
				System.IFormatProvider a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.Object a3;
				checkType(l,4,out a3);
				System.Object a4;
				checkType(l,5,out a4);
				var ret=System.String.Format(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Format__String__String__Object__Object", argc, 1,typeof(string),typeof(System.Object),typeof(System.Object))){
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				System.Object a3;
				checkType(l,4,out a3);
				var ret=System.String.Format(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Format__String__IFormatProvider__String__Object", argc, 1,typeof(System.IFormatProvider),typeof(string),typeof(System.Object))){
				System.IFormatProvider a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.Object a3;
				checkType(l,4,out a3);
				var ret=System.String.Format(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Format__String__IFormatProvider__String__Arr_Object", argc, 1,typeof(System.IFormatProvider),typeof(string),typeof(object[]))){
				System.IFormatProvider a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.Object[] a3;
				checkParams(l,4,out a3);
				var ret=System.String.Format(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Format__String__String__Object", argc, 1,typeof(string),typeof(System.Object))){
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				var ret=System.String.Format(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Format__String__String__Arr_Object", argc, 1,typeof(string),typeof(object[]))){
				System.String a1;
				checkType(l,2,out a1);
				System.Object[] a2;
				checkParams(l,3,out a2);
				var ret=System.String.Format(a1,a2);
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
	static public int Copy_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.String.Copy(a1);
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
	static public int Concat_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Concat__String__Object__Object__Object__Object", argc, 1,typeof(System.Object),typeof(System.Object),typeof(System.Object),typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				System.Object a3;
				checkType(l,4,out a3);
				System.Object a4;
				checkType(l,5,out a4);
				var ret=System.String.Concat(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Concat__String__String__String__String__String", argc, 1,typeof(string),typeof(string),typeof(string),typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.String a4;
				checkType(l,5,out a4);
				var ret=System.String.Concat(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Concat__String__Object__Object__Object", argc, 1,typeof(System.Object),typeof(System.Object),typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				System.Object a3;
				checkType(l,4,out a3);
				var ret=System.String.Concat(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Concat__String__String__String__String", argc, 1,typeof(string),typeof(string),typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				var ret=System.String.Concat(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Concat__String__Object__Object", argc, 1,typeof(System.Object),typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				var ret=System.String.Concat(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Concat__String__String__String", argc, 1,typeof(string),typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				var ret=System.String.Concat(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Concat__String__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.String.Concat(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Concat__String__Arr_Object", argc, 1,typeof(object[]))){
				System.Object[] a1;
				checkParams(l,2,out a1);
				var ret=System.String.Concat(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Concat__String__IEnumerable`1_String", argc, 1,typeof(IEnumerable<System.String>))){
				System.Collections.Generic.IEnumerable<System.String> a1;
				checkType(l,2,out a1);
				var ret=System.String.Concat(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Concat__String__Arr_String", argc, 1,typeof(System.String[]))){
				System.String[] a1;
				checkParams(l,2,out a1);
				var ret=System.String.Concat(a1);
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
	static public int Intern_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.String.Intern(a1);
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
	static public int IsInterned_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.String.IsInterned(a1);
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
	static public int get_Empty(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.String.Empty);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Length(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Length);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int getItem(IntPtr l) {
		try {
			System.String self=(System.String)checkSelf(l);
			int v;
			checkType(l,2,out v);
			var ret = self[v];
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.String");
		addMember(l,Equals);
		addMember(l,CopyTo);
		addMember(l,ToCharArray);
		addMember(l,Split);
		addMember(l,Substring);
		addMember(l,Trim);
		addMember(l,TrimStart);
		addMember(l,TrimEnd);
		addMember(l,IsNormalized);
		addMember(l,Normalize);
		addMember(l,CompareTo);
		addMember(l,Contains);
		addMember(l,EndsWith);
		addMember(l,IndexOf);
		addMember(l,IndexOfAny);
		addMember(l,LastIndexOf);
		addMember(l,LastIndexOfAny);
		addMember(l,PadLeft);
		addMember(l,PadRight);
		addMember(l,StartsWith);
		addMember(l,ToLower);
		addMember(l,ToLowerInvariant);
		addMember(l,ToUpper);
		addMember(l,ToUpperInvariant);
		addMember(l,Clone);
		addMember(l,Insert);
		addMember(l,Replace);
		addMember(l,Remove);
		addMember(l,GetTypeCode);
		addMember(l,Join_s);
		addMember(l,Equals_s);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,IsNullOrEmpty_s);
		addMember(l,IsNullOrWhiteSpace_s);
		addMember(l,Compare_s);
		addMember(l,CompareOrdinal_s);
		addMember(l,Format_s);
		addMember(l,Copy_s);
		addMember(l,Concat_s);
		addMember(l,Intern_s);
		addMember(l,IsInterned_s);
		addMember(l,getItem);
		addMember(l,"Empty",get_Empty,null,false);
		addMember(l,"Length",get_Length,null,true);
		createTypeMetatable(l,constructor, typeof(System.String));
	}
}
