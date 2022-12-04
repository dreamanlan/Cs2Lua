using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_IO_Stream : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyTo__Stream(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			System.IO.Stream a1;
			checkType(l,2,out a1);
			self.CopyTo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyTo__Stream__Int32(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			System.IO.Stream a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.CopyTo(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Close(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
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
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
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
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
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
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			System.Int64 a1;
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
	static public int SetLength(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			System.Int64 a1;
			checkType(l,2,out a1);
			self.SetLength(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Read(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.Read(a1,a2,a3);
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
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
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
	static public int Write(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
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
	static public int WriteByte(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			System.Byte a1;
			checkType(l,2,out a1);
			self.WriteByte(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DisposeAsync(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
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
	static public int Synchronized_s(IntPtr l) {
		try {
			System.IO.Stream a1;
			checkType(l,1,out a1);
			var ret=System.IO.Stream.Synchronized(a1);
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
	static public int get_Null(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.IO.Stream.Null);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_CanRead(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CanRead);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_CanSeek(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CanSeek);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_CanTimeout(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CanTimeout);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_CanWrite(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CanWrite);
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
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
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
	static public int get_Position(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_Position(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.Position=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ReadTimeout(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ReadTimeout);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_ReadTimeout(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.ReadTimeout=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_WriteTimeout(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.WriteTimeout);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_WriteTimeout(IntPtr l) {
		try {
			System.IO.Stream self=(System.IO.Stream)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.WriteTimeout=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.IO.Stream");
		addMember(l,CopyTo__Stream);
		addMember(l,CopyTo__Stream__Int32);
		addMember(l,Close);
		addMember(l,Dispose);
		addMember(l,Flush);
		addMember(l,Seek);
		addMember(l,SetLength);
		addMember(l,Read);
		addMember(l,ReadByte);
		addMember(l,Write);
		addMember(l,WriteByte);
		addMember(l,DisposeAsync);
		addMember(l,Synchronized_s);
		addMember(l,"Null",get_Null,null,false);
		addMember(l,"CanRead",get_CanRead,null,true);
		addMember(l,"CanSeek",get_CanSeek,null,true);
		addMember(l,"CanTimeout",get_CanTimeout,null,true);
		addMember(l,"CanWrite",get_CanWrite,null,true);
		addMember(l,"Length",get_Length,null,true);
		addMember(l,"Position",get_Position,set_Position,true);
		addMember(l,"ReadTimeout",get_ReadTimeout,set_ReadTimeout,true);
		addMember(l,"WriteTimeout",get_WriteTimeout,set_WriteTimeout,true);
		createTypeMetatable(l,null, typeof(System.IO.Stream),typeof(System.MarshalByRefObject));
	}
}
