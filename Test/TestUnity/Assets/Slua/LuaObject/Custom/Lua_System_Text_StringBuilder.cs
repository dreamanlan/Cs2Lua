using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Text_StringBuilder : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			System.Text.StringBuilder o;
			if(argc==6){
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				o=new System.Text.StringBuilder(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__String__Int32", argc, 2,typeof(string),typeof(int))){
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				o=new System.Text.StringBuilder(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__Int32__Int32", argc, 2,typeof(int),typeof(int))){
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				o=new System.Text.StringBuilder(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__Int32", argc, 2,typeof(int))){
				System.Int32 a1;
				checkType(l,3,out a1);
				o=new System.Text.StringBuilder(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__String", argc, 2,typeof(string))){
				System.String a1;
				checkType(l,3,out a1);
				o=new System.Text.StringBuilder(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				o=new System.Text.StringBuilder();
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
	static public int EnsureCapacity(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.EnsureCapacity(a1);
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
	static public int Clear(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			var ret=self.Clear();
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
	static public int Append(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Append__StringBuilder__Arr_Char__Int32__Int32", argc, 2,typeof(System.Char[]),typeof(int),typeof(int))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.Append(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__String__Int32__Int32", argc, 2,typeof(string),typeof(int),typeof(int))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.Append(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__Char__Int32", argc, 2,typeof(System.Char),typeof(int))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Char a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.Append(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__UInt32", argc, 2,typeof(System.UInt32))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.UInt32 a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__UInt16", argc, 2,typeof(System.UInt16))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.UInt16 a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__Decimal", argc, 2,typeof(System.Decimal))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Decimal a1;
				checkValueType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__Int64", argc, 2,typeof(System.Int64))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int64 a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__Arr_Char", argc, 2,typeof(System.Char[]))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__Char", argc, 2,typeof(System.Char))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Char a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__Byte", argc, 2,typeof(System.Byte))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Byte a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__SByte", argc, 2,typeof(System.SByte))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.SByte a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__Boolean", argc, 2,typeof(bool))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Boolean a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__UInt64", argc, 2,typeof(System.UInt64))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.UInt64 a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__String", argc, 2,typeof(string))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__Object", argc, 2,typeof(System.Object))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Object a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__Int16", argc, 2,typeof(System.Int16))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int16 a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__Int32", argc, 2,typeof(int))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__Single", argc, 2,typeof(float))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Single a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Append__StringBuilder__Double", argc, 2,typeof(double))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Double a1;
				checkType(l,3,out a1);
				var ret=self.Append(a1);
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
	static public int AppendLine(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.AppendLine(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				var ret=self.AppendLine();
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
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
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
	static public int Insert(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Char[] a2;
				checkArray(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				var ret=self.Insert(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.Insert(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__UInt32", argc, 2,typeof(int),typeof(System.UInt32))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.UInt32 a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__UInt16", argc, 2,typeof(int),typeof(System.UInt16))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.UInt16 a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__Decimal", argc, 2,typeof(int),typeof(System.Decimal))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Decimal a2;
				checkValueType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__Int64", argc, 2,typeof(int),typeof(System.Int64))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int64 a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__Int32", argc, 2,typeof(int),typeof(int))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__UInt64", argc, 2,typeof(int),typeof(System.UInt64))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.UInt64 a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__Char", argc, 2,typeof(int),typeof(System.Char))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Char a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__Int16", argc, 2,typeof(int),typeof(System.Int16))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int16 a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__Byte", argc, 2,typeof(int),typeof(System.Byte))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Byte a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__SByte", argc, 2,typeof(int),typeof(System.SByte))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.SByte a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__Boolean", argc, 2,typeof(int),typeof(bool))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Boolean a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__String", argc, 2,typeof(int),typeof(string))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__Arr_Char", argc, 2,typeof(int),typeof(System.Char[]))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Char[] a2;
				checkArray(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__Object", argc, 2,typeof(int),typeof(System.Object))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Object a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__Single", argc, 2,typeof(int),typeof(float))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Single a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Insert__StringBuilder__Int32__Double", argc, 2,typeof(int),typeof(double))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Double a2;
				checkType(l,4,out a2);
				var ret=self.Insert(a1,a2);
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
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.Remove(a1,a2);
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
	static public int AppendFormat(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==7){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.IFormatProvider a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				System.Object a3;
				checkType(l,5,out a3);
				System.Object a4;
				checkType(l,6,out a4);
				System.Object a5;
				checkType(l,7,out a5);
				var ret=self.AppendFormat(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "AppendFormat__StringBuilder__String__Object__Object__Object", argc, 2,typeof(string),typeof(System.Object),typeof(System.Object),typeof(System.Object))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Object a2;
				checkType(l,4,out a2);
				System.Object a3;
				checkType(l,5,out a3);
				System.Object a4;
				checkType(l,6,out a4);
				var ret=self.AppendFormat(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "AppendFormat__StringBuilder__IFormatProvider__String__Object__Object", argc, 2,typeof(System.IFormatProvider),typeof(string),typeof(System.Object),typeof(System.Object))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.IFormatProvider a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				System.Object a3;
				checkType(l,5,out a3);
				System.Object a4;
				checkType(l,6,out a4);
				var ret=self.AppendFormat(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "AppendFormat__StringBuilder__String__Object__Object", argc, 2,typeof(string),typeof(System.Object),typeof(System.Object))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Object a2;
				checkType(l,4,out a2);
				System.Object a3;
				checkType(l,5,out a3);
				var ret=self.AppendFormat(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "AppendFormat__StringBuilder__IFormatProvider__String__Object", argc, 2,typeof(System.IFormatProvider),typeof(string),typeof(System.Object))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.IFormatProvider a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				System.Object a3;
				checkType(l,5,out a3);
				var ret=self.AppendFormat(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "AppendFormat__StringBuilder__IFormatProvider__String__Arr_Object", argc, 2,typeof(System.IFormatProvider),typeof(string),typeof(object[]))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.IFormatProvider a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				System.Object[] a3;
				checkParams(l,5,out a3);
				var ret=self.AppendFormat(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "AppendFormat__StringBuilder__String__Object", argc, 2,typeof(string),typeof(System.Object))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Object a2;
				checkType(l,4,out a2);
				var ret=self.AppendFormat(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "AppendFormat__StringBuilder__String__Arr_Object", argc, 2,typeof(string),typeof(object[]))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Object[] a2;
				checkParams(l,4,out a2);
				var ret=self.AppendFormat(a1,a2);
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
	static public int Replace(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Replace__StringBuilder__String__String__Int32__Int32", argc, 2,typeof(string),typeof(string),typeof(int),typeof(int))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				var ret=self.Replace(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Replace__StringBuilder__Char__Char__Int32__Int32", argc, 2,typeof(System.Char),typeof(System.Char),typeof(int),typeof(int))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Char a1;
				checkType(l,3,out a1);
				System.Char a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				var ret=self.Replace(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Replace__StringBuilder__String__String", argc, 2,typeof(string),typeof(string))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				var ret=self.Replace(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Replace__StringBuilder__Char__Char", argc, 2,typeof(System.Char),typeof(System.Char))){
				System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
				System.Char a1;
				checkType(l,3,out a1);
				System.Char a2;
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
	static public int get_Capacity(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Capacity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_Capacity(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.Capacity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_MaxCapacity(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.MaxCapacity);
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
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
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
	static public int set_Length(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.Length=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int getItem(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int setItem(IntPtr l) {
		try {
			System.Text.StringBuilder self=(System.Text.StringBuilder)checkSelf(l);
			int v;
			checkType(l,2,out v);
			System.Char c;
			checkType(l,3,out c);
			self[v]=c;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Text.StringBuilder");
		addMember(l,EnsureCapacity);
		addMember(l,Clear);
		addMember(l,Append);
		addMember(l,AppendLine);
		addMember(l,CopyTo);
		addMember(l,Insert);
		addMember(l,Remove);
		addMember(l,AppendFormat);
		addMember(l,Replace);
		addMember(l,getItem);
		addMember(l,setItem);
		addMember(l,"Capacity",get_Capacity,set_Capacity,true);
		addMember(l,"MaxCapacity",get_MaxCapacity,null,true);
		addMember(l,"Length",get_Length,set_Length,true);
		createTypeMetatable(l,constructor, typeof(System.Text.StringBuilder));
	}
}
