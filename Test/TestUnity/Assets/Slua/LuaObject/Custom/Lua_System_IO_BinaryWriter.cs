using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_IO_BinaryWriter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			System.IO.BinaryWriter o;
			if(argc==5){
				System.IO.Stream a1;
				checkType(l,3,out a1);
				System.Text.Encoding a2;
				checkType(l,4,out a2);
				System.Boolean a3;
				checkType(l,5,out a3);
				o=new System.IO.BinaryWriter(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==4){
				System.IO.Stream a1;
				checkType(l,3,out a1);
				System.Text.Encoding a2;
				checkType(l,4,out a2);
				o=new System.IO.BinaryWriter(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==3){
				System.IO.Stream a1;
				checkType(l,3,out a1);
				o=new System.IO.BinaryWriter(a1);
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
	static public int Close(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			self.Close();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Dispose(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Flush(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			self.Flush();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Seek(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.IO.SeekOrigin a2;
			checkEnum(l,3,out a2);
			var ret=self.Seek(a1,a2);
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
	static public int Write(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Write__Void__Arr_Byte__Int32__Int32", argc, 2,typeof(System.Byte[]),typeof(int),typeof(int))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.Byte[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				self.Write(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__Arr_Char__Int32__Int32", argc, 2,typeof(System.Char[]),typeof(int),typeof(int))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				self.Write(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__String", argc, 2,typeof(string))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__Byte", argc, 2,typeof(System.Byte))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.Byte a1;
				checkType(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__SByte", argc, 2,typeof(System.SByte))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.SByte a1;
				checkType(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__Arr_Byte", argc, 2,typeof(System.Byte[]))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.Byte[] a1;
				checkArray(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__Char", argc, 2,typeof(System.Char))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.Char a1;
				checkType(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__Arr_Char", argc, 2,typeof(System.Char[]))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__Boolean", argc, 2,typeof(bool))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.Boolean a1;
				checkType(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__Int16", argc, 2,typeof(System.Int16))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.Int16 a1;
				checkType(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__UInt16", argc, 2,typeof(System.UInt16))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.UInt16 a1;
				checkType(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__Int32", argc, 2,typeof(int))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__UInt32", argc, 2,typeof(System.UInt32))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.UInt32 a1;
				checkType(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__Int64", argc, 2,typeof(System.Int64))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.Int64 a1;
				checkType(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__UInt64", argc, 2,typeof(System.UInt64))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.UInt64 a1;
				checkType(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__Decimal", argc, 2,typeof(System.Decimal))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.Decimal a1;
				checkValueType(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__Single", argc, 2,typeof(float))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.Single a1;
				checkType(l,3,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "Write__Void__Double", argc, 2,typeof(double))){
				System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
				System.Double a1;
				checkType(l,3,out a1);
				self.Write(a1);
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
	static public int Dispose_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
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
	static public int get_Null(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.IO.BinaryWriter.Null);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_BaseStream(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.BaseStream);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.IO.BinaryWriter");
		addMember(l,Close);
		addMember(l,Dispose);
		addMember(l,Flush);
		addMember(l,Seek);
		addMember(l,Write);
		addMember(l,Dispose_s);
		addMember(l,"Null",get_Null,null,false);
		addMember(l,"BaseStream",get_BaseStream,null,true);
		createTypeMetatable(l,constructor, typeof(System.IO.BinaryWriter));
	}
}
