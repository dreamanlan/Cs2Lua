using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Text_Encoding : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPreamble(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
	static public int Clone(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
	static public int GetByteCount(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
			else if(matchType(l, "GetByteCount__Int32__Arr_Char", argc, 2,typeof(System.Char[]))){
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				var ret=self.GetByteCount(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "GetByteCount__Int32__String", argc, 2,typeof(string))){
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
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
			if(matchType(l, "GetBytes__Int32__Arr_Char__Int32__Int32__Arr_Byte__Int32", argc, 2,typeof(System.Char[]),typeof(int),typeof(int),typeof(System.Byte[]),typeof(int))){
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
			else if(matchType(l, "GetBytes__Int32__String__Int32__Int32__Arr_Byte__Int32", argc, 2,typeof(string),typeof(int),typeof(int),typeof(System.Byte[]),typeof(int))){
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
			else if(argc==5){
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				var ret=self.GetBytes(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "GetBytes__Arr_Byte__String", argc, 2,typeof(string))){
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
	static public int IsAlwaysNormalized(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
				System.Text.NormalizationForm a1;
				checkEnum(l,3,out a1);
				var ret=self.IsAlwaysNormalized(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
				var ret=self.IsAlwaysNormalized();
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
	static public int GetDecoder(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
	static public int GetEncoder(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
	static public int GetMaxByteCount(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
	static public int GetString(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
				System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
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
	static public int Convert_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				System.Text.Encoding a1;
				checkType(l,2,out a1);
				System.Text.Encoding a2;
				checkType(l,3,out a2);
				System.Byte[] a3;
				checkArray(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				var ret=System.Text.Encoding.Convert(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				System.Text.Encoding a1;
				checkType(l,2,out a1);
				System.Text.Encoding a2;
				checkType(l,3,out a2);
				System.Byte[] a3;
				checkArray(l,4,out a3);
				var ret=System.Text.Encoding.Convert(a1,a2,a3);
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
	static public int RegisterProvider_s(IntPtr l) {
		try {
			System.Text.EncodingProvider a1;
			checkType(l,1,out a1);
			System.Text.Encoding.RegisterProvider(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetEncoding_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "GetEncoding__Encoding__Int32__EncoderFallback__DecoderFallback", argc, 1,typeof(int),typeof(System.Text.EncoderFallback),typeof(System.Text.DecoderFallback))){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Text.EncoderFallback a2;
				checkType(l,3,out a2);
				System.Text.DecoderFallback a3;
				checkType(l,4,out a3);
				var ret=System.Text.Encoding.GetEncoding(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "GetEncoding__Encoding__String__EncoderFallback__DecoderFallback", argc, 1,typeof(string),typeof(System.Text.EncoderFallback),typeof(System.Text.DecoderFallback))){
				System.String a1;
				checkType(l,2,out a1);
				System.Text.EncoderFallback a2;
				checkType(l,3,out a2);
				System.Text.DecoderFallback a3;
				checkType(l,4,out a3);
				var ret=System.Text.Encoding.GetEncoding(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "GetEncoding__Encoding__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Text.Encoding.GetEncoding(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "GetEncoding__Encoding__String", argc, 1,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.Text.Encoding.GetEncoding(a1);
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
	static public int GetEncodings_s(IntPtr l) {
		try {
			var ret=System.Text.Encoding.GetEncodings();
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
	static public int get_BodyName(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.BodyName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_EncodingName(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.EncodingName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_HeaderName(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.HeaderName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_WebName(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.WebName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_WindowsCodePage(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.WindowsCodePage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsBrowserDisplay(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsBrowserDisplay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsBrowserSave(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsBrowserSave);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsMailNewsDisplay(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsMailNewsDisplay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsMailNewsSave(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsMailNewsSave);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsSingleByte(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsSingleByte);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_EncoderFallback(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.EncoderFallback);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_EncoderFallback(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			System.Text.EncoderFallback v;
			checkType(l,2,out v);
			self.EncoderFallback=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DecoderFallback(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.DecoderFallback);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_DecoderFallback(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			System.Text.DecoderFallback v;
			checkType(l,2,out v);
			self.DecoderFallback=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsReadOnly(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsReadOnly);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ASCII(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Text.Encoding.ASCII);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_CodePage(IntPtr l) {
		try {
			System.Text.Encoding self=(System.Text.Encoding)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CodePage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Default(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Text.Encoding.Default);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Unicode(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Text.Encoding.Unicode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_BigEndianUnicode(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Text.Encoding.BigEndianUnicode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_UTF7(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Text.Encoding.UTF7);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_UTF8(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Text.Encoding.UTF8);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_UTF32(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Text.Encoding.UTF32);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Text.Encoding");
		addMember(l,GetPreamble);
		addMember(l,Clone);
		addMember(l,GetByteCount);
		addMember(l,GetBytes);
		addMember(l,GetCharCount);
		addMember(l,GetChars);
		addMember(l,IsAlwaysNormalized);
		addMember(l,GetDecoder);
		addMember(l,GetEncoder);
		addMember(l,GetMaxByteCount);
		addMember(l,GetMaxCharCount);
		addMember(l,GetString);
		addMember(l,Convert_s);
		addMember(l,RegisterProvider_s);
		addMember(l,GetEncoding_s);
		addMember(l,GetEncodings_s);
		addMember(l,"BodyName",get_BodyName,null,true);
		addMember(l,"EncodingName",get_EncodingName,null,true);
		addMember(l,"HeaderName",get_HeaderName,null,true);
		addMember(l,"WebName",get_WebName,null,true);
		addMember(l,"WindowsCodePage",get_WindowsCodePage,null,true);
		addMember(l,"IsBrowserDisplay",get_IsBrowserDisplay,null,true);
		addMember(l,"IsBrowserSave",get_IsBrowserSave,null,true);
		addMember(l,"IsMailNewsDisplay",get_IsMailNewsDisplay,null,true);
		addMember(l,"IsMailNewsSave",get_IsMailNewsSave,null,true);
		addMember(l,"IsSingleByte",get_IsSingleByte,null,true);
		addMember(l,"EncoderFallback",get_EncoderFallback,set_EncoderFallback,true);
		addMember(l,"DecoderFallback",get_DecoderFallback,set_DecoderFallback,true);
		addMember(l,"IsReadOnly",get_IsReadOnly,null,true);
		addMember(l,"ASCII",get_ASCII,null,false);
		addMember(l,"CodePage",get_CodePage,null,true);
		addMember(l,"Default",get_Default,null,false);
		addMember(l,"Unicode",get_Unicode,null,false);
		addMember(l,"BigEndianUnicode",get_BigEndianUnicode,null,false);
		addMember(l,"UTF7",get_UTF7,null,false);
		addMember(l,"UTF8",get_UTF8,null,false);
		addMember(l,"UTF32",get_UTF32,null,false);
		createTypeMetatable(l,null, typeof(System.Text.Encoding));
	}
}
