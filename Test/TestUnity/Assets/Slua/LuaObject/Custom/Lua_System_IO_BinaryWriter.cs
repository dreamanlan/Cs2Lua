using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_IO_BinaryWriter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__Stream_s(IntPtr l) {
		try {
			System.IO.BinaryWriter o;
			System.IO.Stream a1;
			checkType(l,1,out a1);
			o=new System.IO.BinaryWriter(a1);
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
	static public int ctor__Stream__Encoding_s(IntPtr l) {
		try {
			System.IO.BinaryWriter o;
			System.IO.Stream a1;
			checkType(l,1,out a1);
			System.Text.Encoding a2;
			checkType(l,2,out a2);
			o=new System.IO.BinaryWriter(a1,a2);
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
	static public int ctor__Stream__Encoding__Boolean_s(IntPtr l) {
		try {
			System.IO.BinaryWriter o;
			System.IO.Stream a1;
			checkType(l,1,out a1);
			System.Text.Encoding a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			o=new System.IO.BinaryWriter(a1,a2,a3);
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
	static public int DisposeAsync(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			var ret=self.DisposeAsync();
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
	static public int Write__UInt64(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.UInt64 a1;
			checkType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__Int64(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Int64 a1;
			checkType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__UInt32(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.UInt32 a1;
			checkType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__Int32(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__UInt16(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__Int16(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Int16 a1;
			checkType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__Decimal(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Decimal a1;
			checkValueType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__String(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__Char(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__A_Byte(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__SByte(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.SByte a1;
			checkType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__Byte(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Byte a1;
			checkType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__Boolean(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__A_Char(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__Single(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__Double(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Double a1;
			checkType(l,2,out a1);
			self.Write(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__A_Byte__Int32__Int32(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.Write(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write__A_Char__Int32__Int32(IntPtr l) {
		try {
			System.IO.BinaryWriter self=(System.IO.BinaryWriter)checkSelf(l);
			System.Char[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.Write(a1,a2,a3);
			pushValue(l,true);
			return 1;
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
		addMember(l,ctor__Stream_s);
		addMember(l,ctor__Stream__Encoding_s);
		addMember(l,ctor__Stream__Encoding__Boolean_s);
		addMember(l,Close);
		addMember(l,Dispose);
		addMember(l,Flush);
		addMember(l,Seek);
		addMember(l,DisposeAsync);
		addMember(l,Write__UInt64);
		addMember(l,Write__Int64);
		addMember(l,Write__UInt32);
		addMember(l,Write__Int32);
		addMember(l,Write__UInt16);
		addMember(l,Write__Int16);
		addMember(l,Write__Decimal);
		addMember(l,Write__String);
		addMember(l,Write__Char);
		addMember(l,Write__A_Byte);
		addMember(l,Write__SByte);
		addMember(l,Write__Byte);
		addMember(l,Write__Boolean);
		addMember(l,Write__A_Char);
		addMember(l,Write__Single);
		addMember(l,Write__Double);
		addMember(l,Write__A_Byte__Int32__Int32);
		addMember(l,Write__A_Char__Int32__Int32);
		addMember(l,"Null",get_Null,null,false);
		addMember(l,"BaseStream",get_BaseStream,null,true);
		createTypeMetatable(l,null, typeof(System.IO.BinaryWriter));
	}
}
