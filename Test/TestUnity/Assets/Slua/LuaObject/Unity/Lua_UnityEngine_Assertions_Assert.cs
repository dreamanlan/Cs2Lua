using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Assertions_Assert : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsTrue_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.Boolean a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.IsTrue(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.Boolean a1;
				checkType(l,2,out a1);
				UnityEngine.Assertions.Assert.IsTrue(a1);
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
	static public int IsFalse_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.Boolean a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.IsFalse(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.Boolean a1;
				checkType(l,2,out a1);
				UnityEngine.Assertions.Assert.IsFalse(a1);
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
	static public int AreApproximatelyEqual_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.String a4;
				checkType(l,5,out a4);
				UnityEngine.Assertions.Assert.AreApproximatelyEqual(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreApproximatelyEqual__Void__Single__Single__String", argc, 1,typeof(float),typeof(float),typeof(string))){
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreApproximatelyEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreApproximatelyEqual__Void__Single__Single__Single", argc, 1,typeof(float),typeof(float),typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreApproximatelyEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreApproximatelyEqual(a1,a2);
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
	static public int AreNotApproximatelyEqual_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.String a4;
				checkType(l,5,out a4);
				UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotApproximatelyEqual__Void__Single__Single__String", argc, 1,typeof(float),typeof(float),typeof(string))){
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotApproximatelyEqual__Void__Single__Single__Single", argc, 1,typeof(float),typeof(float),typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(a1,a2);
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
	static public int AreEqual_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "AreEqual__Void__Int64__Int64__String", argc, 1,typeof(System.Int64),typeof(System.Int64),typeof(string))){
				System.Int64 a1;
				checkType(l,2,out a1);
				System.Int64 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__SByte__SByte__String", argc, 1,typeof(System.SByte),typeof(System.SByte),typeof(string))){
				System.SByte a1;
				checkType(l,2,out a1);
				System.SByte a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__Byte__Byte__String", argc, 1,typeof(System.Byte),typeof(System.Byte),typeof(string))){
				System.Byte a1;
				checkType(l,2,out a1);
				System.Byte a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__Char__Char__String", argc, 1,typeof(System.Char),typeof(System.Char),typeof(string))){
				System.Char a1;
				checkType(l,2,out a1);
				System.Char a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__Int16__Int16__String", argc, 1,typeof(System.Int16),typeof(System.Int16),typeof(string))){
				System.Int16 a1;
				checkType(l,2,out a1);
				System.Int16 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__Object__Object__String", argc, 1,typeof(UnityEngine.Object),typeof(UnityEngine.Object),typeof(string))){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				UnityEngine.Object a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__Int32__Int32__String", argc, 1,typeof(int),typeof(int),typeof(string))){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__UInt32__UInt32__String", argc, 1,typeof(System.UInt32),typeof(System.UInt32),typeof(string))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				System.UInt32 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__UInt16__UInt16__String", argc, 1,typeof(System.UInt16),typeof(System.UInt16),typeof(string))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				System.UInt16 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__UInt64__UInt64__String", argc, 1,typeof(System.UInt64),typeof(System.UInt64),typeof(string))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				System.UInt64 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__UInt64__UInt64", argc, 1,typeof(System.UInt64),typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				System.UInt64 a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__UInt32__UInt32", argc, 1,typeof(System.UInt32),typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				System.UInt32 a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__Int16__Int16", argc, 1,typeof(System.Int16),typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				System.Int16 a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__Char__Char", argc, 1,typeof(System.Char),typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				System.Char a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__Int64__Int64", argc, 1,typeof(System.Int64),typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				System.Int64 a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__Byte__Byte", argc, 1,typeof(System.Byte),typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				System.Byte a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__SByte__SByte", argc, 1,typeof(System.SByte),typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				System.SByte a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__Int32__Int32", argc, 1,typeof(int),typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreEqual__Void__UInt16__UInt16", argc, 1,typeof(System.UInt16),typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				System.UInt16 a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreEqual(a1,a2);
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
	static public int AreNotEqual_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "AreNotEqual__Void__Int64__Int64__String", argc, 1,typeof(System.Int64),typeof(System.Int64),typeof(string))){
				System.Int64 a1;
				checkType(l,2,out a1);
				System.Int64 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__SByte__SByte__String", argc, 1,typeof(System.SByte),typeof(System.SByte),typeof(string))){
				System.SByte a1;
				checkType(l,2,out a1);
				System.SByte a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__Byte__Byte__String", argc, 1,typeof(System.Byte),typeof(System.Byte),typeof(string))){
				System.Byte a1;
				checkType(l,2,out a1);
				System.Byte a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__Char__Char__String", argc, 1,typeof(System.Char),typeof(System.Char),typeof(string))){
				System.Char a1;
				checkType(l,2,out a1);
				System.Char a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__Int16__Int16__String", argc, 1,typeof(System.Int16),typeof(System.Int16),typeof(string))){
				System.Int16 a1;
				checkType(l,2,out a1);
				System.Int16 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__Object__Object__String", argc, 1,typeof(UnityEngine.Object),typeof(UnityEngine.Object),typeof(string))){
				UnityEngine.Object a1;
				checkType(l,2,out a1);
				UnityEngine.Object a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__Int32__Int32__String", argc, 1,typeof(int),typeof(int),typeof(string))){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__UInt32__UInt32__String", argc, 1,typeof(System.UInt32),typeof(System.UInt32),typeof(string))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				System.UInt32 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__UInt16__UInt16__String", argc, 1,typeof(System.UInt16),typeof(System.UInt16),typeof(string))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				System.UInt16 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__UInt64__UInt64__String", argc, 1,typeof(System.UInt64),typeof(System.UInt64),typeof(string))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				System.UInt64 a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__UInt64__UInt64", argc, 1,typeof(System.UInt64),typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				System.UInt64 a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__UInt32__UInt32", argc, 1,typeof(System.UInt32),typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				System.UInt32 a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__Int16__Int16", argc, 1,typeof(System.Int16),typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				System.Int16 a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__Char__Char", argc, 1,typeof(System.Char),typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				System.Char a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__Int64__Int64", argc, 1,typeof(System.Int64),typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				System.Int64 a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__Byte__Byte", argc, 1,typeof(System.Byte),typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				System.Byte a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__SByte__SByte", argc, 1,typeof(System.SByte),typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				System.SByte a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__Int32__Int32", argc, 1,typeof(int),typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "AreNotEqual__Void__UInt16__UInt16", argc, 1,typeof(System.UInt16),typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				System.UInt16 a2;
				checkType(l,3,out a2);
				UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
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
	static public int IsNull_s(IntPtr l) {
		try {
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.IsNull(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsNotNull_s(IntPtr l) {
		try {
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.IsNotNull(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_raiseExceptions(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Assertions.Assert.raiseExceptions);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_raiseExceptions(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			UnityEngine.Assertions.Assert.raiseExceptions=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Assertions.Assert");
		addMember(l,IsTrue_s);
		addMember(l,IsFalse_s);
		addMember(l,AreApproximatelyEqual_s);
		addMember(l,AreNotApproximatelyEqual_s);
		addMember(l,AreEqual_s);
		addMember(l,AreNotEqual_s);
		addMember(l,IsNull_s);
		addMember(l,IsNotNull_s);
		addMember(l,"raiseExceptions",get_raiseExceptions,set_raiseExceptions,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Assertions.Assert));
	}
}
