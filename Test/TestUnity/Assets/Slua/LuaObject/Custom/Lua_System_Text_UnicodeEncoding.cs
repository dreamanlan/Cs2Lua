using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Text_UnicodeEncoding : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			System.Text.UnicodeEncoding o;
			if(argc==5){
				System.Boolean a1;
				checkType(l,3,out a1);
				System.Boolean a2;
				checkType(l,4,out a2);
				System.Boolean a3;
				checkType(l,5,out a3);
				o=new System.Text.UnicodeEncoding(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==4){
				System.Boolean a1;
				checkType(l,3,out a1);
				System.Boolean a2;
				checkType(l,4,out a2);
				o=new System.Text.UnicodeEncoding(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				o=new System.Text.UnicodeEncoding();
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
	static public int GetByteCount(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.GetByteCount(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "GetByteCount__Int32__String", argc, 2,typeof(string))){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.GetByteCount(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "GetByteCount__Int32__Arr_Char", argc, 2,typeof(System.Char[]))){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				var ret=self.GetByteCount(a1);
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
	static public int GetBytes(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "GetBytes__Int32__String__Int32__Int32__Arr_Byte__Int32", argc, 2,typeof(string),typeof(int),typeof(int),typeof(System.Byte[]),typeof(int))){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Byte[] a4;
				checkArray(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				var ret=self.GetBytes(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "GetBytes__Int32__Arr_Char__Int32__Int32__Arr_Byte__Int32", argc, 2,typeof(System.Char[]),typeof(int),typeof(int),typeof(System.Byte[]),typeof(int))){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Byte[] a4;
				checkArray(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				var ret=self.GetBytes(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.GetBytes(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "GetBytes__Arr_Byte__Arr_Char", argc, 2,typeof(System.Char[]))){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				var ret=self.GetBytes(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "GetBytes__Arr_Byte__String", argc, 2,typeof(string))){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.GetBytes(a1);
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
	static public int GetCharCount(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.Byte[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.GetCharCount(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.Byte[] a1;
				checkArray(l,3,out a1);
				var ret=self.GetCharCount(a1);
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
	static public int GetChars(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==7){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.Byte[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Char[] a4;
				checkArray(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				var ret=self.GetChars(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.Byte[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.GetChars(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.Byte[] a1;
				checkArray(l,3,out a1);
				var ret=self.GetChars(a1);
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
	static public int GetString(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.Byte[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.GetString(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
				System.Byte[] a1;
				checkArray(l,3,out a1);
				var ret=self.GetString(a1);
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
	static public int GetEncoder(IntPtr l) {
		try {
			System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
			var ret=self.GetEncoder();
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
	static public int GetDecoder(IntPtr l) {
		try {
			System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
			var ret=self.GetDecoder();
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
	static public int GetPreamble(IntPtr l) {
		try {
			System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
			var ret=self.GetPreamble();
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
	static public int GetMaxByteCount(IntPtr l) {
		try {
			System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetMaxByteCount(a1);
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
	static public int GetMaxCharCount(IntPtr l) {
		try {
			System.Text.UnicodeEncoding self=(System.Text.UnicodeEncoding)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetMaxCharCount(a1);
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
	static public int get_CharSize(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Text.UnicodeEncoding.CharSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Text.UnicodeEncoding");
		addMember(l,GetByteCount);
		addMember(l,GetBytes);
		addMember(l,GetCharCount);
		addMember(l,GetChars);
		addMember(l,GetString);
		addMember(l,GetEncoder);
		addMember(l,GetDecoder);
		addMember(l,GetPreamble);
		addMember(l,GetMaxByteCount);
		addMember(l,GetMaxCharCount);
		addMember(l,"CharSize",get_CharSize,null,false);
		createTypeMetatable(l,constructor, typeof(System.Text.UnicodeEncoding),typeof(System.Text.Encoding));
	}
}
