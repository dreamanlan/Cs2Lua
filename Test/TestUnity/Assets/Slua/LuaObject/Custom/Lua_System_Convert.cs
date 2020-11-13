using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Convert : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTypeCode_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			var ret=System.Convert.GetTypeCode(a1);
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
	static public int IsDBNull_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			var ret=System.Convert.IsDBNull(a1);
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
	static public int ChangeType_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ChangeType__Object__Object__TypeCode__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.TypeCode),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.TypeCode a2;
				checkEnum(l,3,out a2);
				System.IFormatProvider a3;
				checkType(l,4,out a3);
				var ret=System.Convert.ChangeType(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ChangeType__Object__Object__Type__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.Type),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.Type a2;
				checkType(l,3,out a2);
				System.IFormatProvider a3;
				checkType(l,4,out a3);
				var ret=System.Convert.ChangeType(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ChangeType__Object__Object__TypeCode", argc, 1,typeof(System.Object),typeof(System.TypeCode))){
				System.Object a1;
				checkType(l,2,out a1);
				System.TypeCode a2;
				checkEnum(l,3,out a2);
				var ret=System.Convert.ChangeType(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ChangeType__Object__Object__Type", argc, 1,typeof(System.Object),typeof(System.Type))){
				System.Object a1;
				checkType(l,2,out a1);
				System.Type a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ChangeType(a1,a2);
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
	static public int ToBoolean_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToBoolean__Boolean__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToBoolean(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToBoolean(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToBoolean__Boolean__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToBoolean(a1);
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
	static public int ToChar_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToChar__Char__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToChar(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToChar(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToChar__Char__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToChar(a1);
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
	static public int ToSByte_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToSByte__SByte__String__Int32", argc, 1,typeof(string),typeof(int))){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToSByte(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToSByte(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToSByte(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSByte__SByte__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSByte(a1);
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
	static public int ToByte_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToByte__Byte__String__Int32", argc, 1,typeof(string),typeof(int))){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToByte(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToByte(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToByte(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToByte__Byte__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToByte(a1);
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
	static public int ToInt16_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToInt16__Int16__String__Int32", argc, 1,typeof(string),typeof(int))){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToInt16(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToInt16(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToInt16(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt16__Int16__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt16(a1);
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
	static public int ToUInt16_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToUInt16__UInt16__String__Int32", argc, 1,typeof(string),typeof(int))){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToUInt16(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToUInt16(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToUInt16(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt16__UInt16__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt16(a1);
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
	static public int ToInt32_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToInt32__Int32__String__Int32", argc, 1,typeof(string),typeof(int))){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToInt32(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToInt32(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToInt32(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt32__Int32__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt32(a1);
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
	static public int ToUInt32_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToUInt32__UInt32__String__Int32", argc, 1,typeof(string),typeof(int))){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToUInt32(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToUInt32(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToUInt32(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt32__UInt32__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt32(a1);
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
	static public int ToInt64_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToInt64__Int64__String__Int32", argc, 1,typeof(string),typeof(int))){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToInt64(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToInt64(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToInt64(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToInt64__Int64__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToInt64(a1);
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
	static public int ToUInt64_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToUInt64__UInt64__String__Int32", argc, 1,typeof(string),typeof(int))){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToUInt64(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToUInt64(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToUInt64(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToUInt64__UInt64__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToUInt64(a1);
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
	static public int ToSingle_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToSingle__Single__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToSingle(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToSingle(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToSingle__Single__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToSingle(a1);
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
	static public int ToDouble_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToDouble__Double__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToDouble(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToDouble(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDouble__Double__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDouble(a1);
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
	static public int ToDecimal_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToDecimal__Decimal__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToDecimal(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToDecimal(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDecimal__Decimal__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDecimal(a1);
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
	static public int ToDateTime_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToDateTime__DateTime__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToDateTime(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToDateTime(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToDateTime__DateTime__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToDateTime(a1);
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
	static public int ToString_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ToString__String__Decimal__IFormatProvider", argc, 1,typeof(System.Decimal),typeof(System.IFormatProvider))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Byte__Int32", argc, 1,typeof(System.Byte),typeof(int))){
				System.Byte a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Int16__Int32", argc, 1,typeof(System.Int16),typeof(int))){
				System.Int16 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__DateTime__IFormatProvider", argc, 1,typeof(System.DateTime),typeof(System.IFormatProvider))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__UInt32__IFormatProvider", argc, 1,typeof(System.UInt32),typeof(System.IFormatProvider))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Int64__IFormatProvider", argc, 1,typeof(System.Int64),typeof(System.IFormatProvider))){
				System.Int64 a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Int32__Int32", argc, 1,typeof(int),typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Int32__IFormatProvider", argc, 1,typeof(int),typeof(System.IFormatProvider))){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Int16__IFormatProvider", argc, 1,typeof(System.Int16),typeof(System.IFormatProvider))){
				System.Int16 a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Byte__IFormatProvider", argc, 1,typeof(System.Byte),typeof(System.IFormatProvider))){
				System.Byte a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__SByte__IFormatProvider", argc, 1,typeof(System.SByte),typeof(System.IFormatProvider))){
				System.SByte a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Char__IFormatProvider", argc, 1,typeof(System.Char),typeof(System.IFormatProvider))){
				System.Char a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Boolean__IFormatProvider", argc, 1,typeof(bool),typeof(System.IFormatProvider))){
				System.Boolean a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Object__IFormatProvider", argc, 1,typeof(System.Object),typeof(System.IFormatProvider))){
				System.Object a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__UInt16__IFormatProvider", argc, 1,typeof(System.UInt16),typeof(System.IFormatProvider))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__UInt64__IFormatProvider", argc, 1,typeof(System.UInt64),typeof(System.IFormatProvider))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Int64__Int32", argc, 1,typeof(System.Int64),typeof(int))){
				System.Int64 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Double__IFormatProvider", argc, 1,typeof(double),typeof(System.IFormatProvider))){
				System.Double a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Single__IFormatProvider", argc, 1,typeof(float),typeof(System.IFormatProvider))){
				System.Single a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.Convert.ToString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__UInt64", argc, 1,typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__UInt32", argc, 1,typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__UInt16", argc, 1,typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Object", argc, 1,typeof(System.Object))){
				System.Object a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Byte", argc, 1,typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Char", argc, 1,typeof(System.Char))){
				System.Char a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Boolean", argc, 1,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__DateTime", argc, 1,typeof(System.DateTime))){
				System.DateTime a1;
				checkValueType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ToString__String__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Convert.ToString(a1);
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
	static public int ToBase64String_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.Byte[] a1;
				checkArray(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Base64FormattingOptions a4;
				checkEnum(l,5,out a4);
				var ret=System.Convert.ToBase64String(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				System.Byte[] a1;
				checkArray(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				var ret=System.Convert.ToBase64String(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.Byte[] a1;
				checkArray(l,2,out a1);
				System.Base64FormattingOptions a2;
				checkEnum(l,3,out a2);
				var ret=System.Convert.ToBase64String(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Byte[] a1;
				checkArray(l,2,out a1);
				var ret=System.Convert.ToBase64String(a1);
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
	static public int ToBase64CharArray_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==7){
				System.Byte[] a1;
				checkArray(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Char[] a4;
				checkArray(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				System.Base64FormattingOptions a6;
				checkEnum(l,7,out a6);
				var ret=System.Convert.ToBase64CharArray(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==6){
				System.Byte[] a1;
				checkArray(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Char[] a4;
				checkArray(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				var ret=System.Convert.ToBase64CharArray(a1,a2,a3,a4,a5);
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
	static public int FromBase64String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.Convert.FromBase64String(a1);
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
	static public int FromBase64CharArray_s(IntPtr l) {
		try {
			System.Char[] a1;
			checkArray(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			var ret=System.Convert.FromBase64CharArray(a1,a2,a3);
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
	static public int get_DBNull(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Convert.DBNull);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Convert");
		addMember(l,GetTypeCode_s);
		addMember(l,IsDBNull_s);
		addMember(l,ChangeType_s);
		addMember(l,ToBoolean_s);
		addMember(l,ToChar_s);
		addMember(l,ToSByte_s);
		addMember(l,ToByte_s);
		addMember(l,ToInt16_s);
		addMember(l,ToUInt16_s);
		addMember(l,ToInt32_s);
		addMember(l,ToUInt32_s);
		addMember(l,ToInt64_s);
		addMember(l,ToUInt64_s);
		addMember(l,ToSingle_s);
		addMember(l,ToDouble_s);
		addMember(l,ToDecimal_s);
		addMember(l,ToDateTime_s);
		addMember(l,ToString_s);
		addMember(l,ToBase64String_s);
		addMember(l,ToBase64CharArray_s);
		addMember(l,FromBase64String_s);
		addMember(l,FromBase64CharArray_s);
		addMember(l,"DBNull",get_DBNull,null,false);
		createTypeMetatable(l,null, typeof(System.Convert));
	}
}
