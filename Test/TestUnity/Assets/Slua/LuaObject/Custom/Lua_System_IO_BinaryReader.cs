using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_IO_BinaryReader : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			System.IO.BinaryReader o;
			if(argc==5){
				System.IO.Stream a1;
				checkType(l,3,out a1);
				System.Text.Encoding a2;
				checkType(l,4,out a2);
				System.Boolean a3;
				checkType(l,5,out a3);
				o=new System.IO.BinaryReader(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==4){
				System.IO.Stream a1;
				checkType(l,3,out a1);
				System.Text.Encoding a2;
				checkType(l,4,out a2);
				o=new System.IO.BinaryReader(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==3){
				System.IO.Stream a1;
				checkType(l,3,out a1);
				o=new System.IO.BinaryReader(a1);
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
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
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
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
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
	static public int PeekChar(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.PeekChar();
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
	static public int Read(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Read__Int32__Arr_Char__Int32__Int32", argc, 2,typeof(System.Char[]),typeof(int),typeof(int))){
				System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
				System.Char[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.Read(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Read__Int32__Arr_Byte__Int32__Int32", argc, 2,typeof(System.Byte[]),typeof(int),typeof(int))){
				System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
				System.Byte[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.Read(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
				var ret=self.Read();
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
	static public int ReadBoolean(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadBoolean();
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
	static public int ReadByte(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadByte();
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
	static public int ReadSByte(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadSByte();
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
	static public int ReadChar(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadChar();
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
	static public int ReadInt16(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadInt16();
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
	static public int ReadUInt16(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadUInt16();
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
	static public int ReadInt32(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadInt32();
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
	static public int ReadUInt32(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadUInt32();
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
	static public int ReadInt64(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadInt64();
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
	static public int ReadUInt64(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadUInt64();
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
	static public int ReadSingle(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadSingle();
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
	static public int ReadDouble(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadDouble();
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
	static public int ReadDecimal(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadDecimal();
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
	static public int ReadString(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			var ret=self.ReadString();
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
	static public int ReadChars(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.ReadChars(a1);
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
	static public int ReadBytes(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.ReadBytes(a1);
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
	static public int get_BaseStream(IntPtr l) {
		try {
			System.IO.BinaryReader self=(System.IO.BinaryReader)checkSelf(l);
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
		getTypeTable(l,"System.IO.BinaryReader");
		addMember(l,Close);
		addMember(l,Dispose);
		addMember(l,PeekChar);
		addMember(l,Read);
		addMember(l,ReadBoolean);
		addMember(l,ReadByte);
		addMember(l,ReadSByte);
		addMember(l,ReadChar);
		addMember(l,ReadInt16);
		addMember(l,ReadUInt16);
		addMember(l,ReadInt32);
		addMember(l,ReadUInt32);
		addMember(l,ReadInt64);
		addMember(l,ReadUInt64);
		addMember(l,ReadSingle);
		addMember(l,ReadDouble);
		addMember(l,ReadDecimal);
		addMember(l,ReadString);
		addMember(l,ReadChars);
		addMember(l,ReadBytes);
		addMember(l,Dispose_s);
		addMember(l,"BaseStream",get_BaseStream,null,true);
		createTypeMetatable(l,constructor, typeof(System.IO.BinaryReader));
	}
}
