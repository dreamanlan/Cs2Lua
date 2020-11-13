using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_IO_FileStream : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			System.IO.FileStream o;
			if(argc==9){
				System.String a1;
				checkType(l,3,out a1);
				System.IO.FileMode a2;
				checkEnum(l,4,out a2);
				System.Security.AccessControl.FileSystemRights a3;
				checkEnum(l,5,out a3);
				System.IO.FileShare a4;
				checkEnum(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				System.IO.FileOptions a6;
				checkEnum(l,8,out a6);
				System.Security.AccessControl.FileSecurity a7;
				checkType(l,9,out a7);
				o=new System.IO.FileStream(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__String__FileMode__FileAccess__FileShare__Int32__Boolean", argc, 2,typeof(string),typeof(System.IO.FileMode),typeof(System.IO.FileAccess),typeof(System.IO.FileShare),typeof(int),typeof(bool))){
				System.String a1;
				checkType(l,3,out a1);
				System.IO.FileMode a2;
				checkEnum(l,4,out a2);
				System.IO.FileAccess a3;
				checkEnum(l,5,out a3);
				System.IO.FileShare a4;
				checkEnum(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				System.Boolean a6;
				checkType(l,8,out a6);
				o=new System.IO.FileStream(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__String__FileMode__FileAccess__FileShare__Int32__FileOptions", argc, 2,typeof(string),typeof(System.IO.FileMode),typeof(System.IO.FileAccess),typeof(System.IO.FileShare),typeof(int),typeof(System.IO.FileOptions))){
				System.String a1;
				checkType(l,3,out a1);
				System.IO.FileMode a2;
				checkEnum(l,4,out a2);
				System.IO.FileAccess a3;
				checkEnum(l,5,out a3);
				System.IO.FileShare a4;
				checkEnum(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				System.IO.FileOptions a6;
				checkEnum(l,8,out a6);
				o=new System.IO.FileStream(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__String__FileMode__FileSystemRights__FileShare__Int32__FileOptions", argc, 2,typeof(string),typeof(System.IO.FileMode),typeof(System.Security.AccessControl.FileSystemRights),typeof(System.IO.FileShare),typeof(int),typeof(System.IO.FileOptions))){
				System.String a1;
				checkType(l,3,out a1);
				System.IO.FileMode a2;
				checkEnum(l,4,out a2);
				System.Security.AccessControl.FileSystemRights a3;
				checkEnum(l,5,out a3);
				System.IO.FileShare a4;
				checkEnum(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				System.IO.FileOptions a6;
				checkEnum(l,8,out a6);
				o=new System.IO.FileStream(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==7){
				System.String a1;
				checkType(l,3,out a1);
				System.IO.FileMode a2;
				checkEnum(l,4,out a2);
				System.IO.FileAccess a3;
				checkEnum(l,5,out a3);
				System.IO.FileShare a4;
				checkEnum(l,6,out a4);
				System.Int32 a5;
				checkType(l,7,out a5);
				o=new System.IO.FileStream(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__String__FileMode__FileAccess__FileShare", argc, 2,typeof(string),typeof(System.IO.FileMode),typeof(System.IO.FileAccess),typeof(System.IO.FileShare))){
				System.String a1;
				checkType(l,3,out a1);
				System.IO.FileMode a2;
				checkEnum(l,4,out a2);
				System.IO.FileAccess a3;
				checkEnum(l,5,out a3);
				System.IO.FileShare a4;
				checkEnum(l,6,out a4);
				o=new System.IO.FileStream(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__SafeFileHandle__FileAccess__Int32__Boolean", argc, 2,typeof(Microsoft.Win32.SafeHandles.SafeFileHandle),typeof(System.IO.FileAccess),typeof(int),typeof(bool))){
				Microsoft.Win32.SafeHandles.SafeFileHandle a1;
				checkType(l,3,out a1);
				System.IO.FileAccess a2;
				checkEnum(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Boolean a4;
				checkType(l,6,out a4);
				o=new System.IO.FileStream(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__String__FileMode__FileAccess", argc, 2,typeof(string),typeof(System.IO.FileMode),typeof(System.IO.FileAccess))){
				System.String a1;
				checkType(l,3,out a1);
				System.IO.FileMode a2;
				checkEnum(l,4,out a2);
				System.IO.FileAccess a3;
				checkEnum(l,5,out a3);
				o=new System.IO.FileStream(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__SafeFileHandle__FileAccess__Int32", argc, 2,typeof(Microsoft.Win32.SafeHandles.SafeFileHandle),typeof(System.IO.FileAccess),typeof(int))){
				Microsoft.Win32.SafeHandles.SafeFileHandle a1;
				checkType(l,3,out a1);
				System.IO.FileAccess a2;
				checkEnum(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				o=new System.IO.FileStream(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__String__FileMode", argc, 2,typeof(string),typeof(System.IO.FileMode))){
				System.String a1;
				checkType(l,3,out a1);
				System.IO.FileMode a2;
				checkEnum(l,4,out a2);
				o=new System.IO.FileStream(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__SafeFileHandle__FileAccess", argc, 2,typeof(Microsoft.Win32.SafeHandles.SafeFileHandle),typeof(System.IO.FileAccess))){
				Microsoft.Win32.SafeHandles.SafeFileHandle a1;
				checkType(l,3,out a1);
				System.IO.FileAccess a2;
				checkEnum(l,4,out a2);
				o=new System.IO.FileStream(a1,a2);
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
	static public int ReadByte(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
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
	static public int WriteByte(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
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
	static public int Read(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
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
	static public int BeginRead(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.AsyncCallback a4;
			LuaDelegation.checkDelegate(l,5,out a4);
			System.Object a5;
			checkType(l,6,out a5);
			var ret=self.BeginRead(a1,a2,a3,a4,a5);
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
	static public int EndRead(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			System.IAsyncResult a1;
			checkType(l,2,out a1);
			var ret=self.EndRead(a1);
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
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
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
	static public int BeginWrite(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.AsyncCallback a4;
			LuaDelegation.checkDelegate(l,5,out a4);
			System.Object a5;
			checkType(l,6,out a5);
			var ret=self.BeginWrite(a1,a2,a3,a4,a5);
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
	static public int EndWrite(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			System.IAsyncResult a1;
			checkType(l,2,out a1);
			self.EndWrite(a1);
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
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
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
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
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
	static public int Flush(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
				System.Boolean a1;
				checkType(l,3,out a1);
				self.Flush(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
				self.Flush();
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
	static public int Lock(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			System.Int64 a1;
			checkType(l,2,out a1);
			System.Int64 a2;
			checkType(l,3,out a2);
			self.Lock(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Unlock(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			System.Int64 a1;
			checkType(l,2,out a1);
			System.Int64 a2;
			checkType(l,3,out a2);
			self.Unlock(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetAccessControl(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			var ret=self.GetAccessControl();
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
	static public int SetAccessControl(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			System.Security.AccessControl.FileSecurity a1;
			checkType(l,2,out a1);
			self.SetAccessControl(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int FlushAsync(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			System.Threading.CancellationToken a1;
			checkValueType(l,2,out a1);
			var ret=self.FlushAsync(a1);
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
	static public int ReadAsync(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Threading.CancellationToken a4;
			checkValueType(l,5,out a4);
			var ret=self.ReadAsync(a1,a2,a3,a4);
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
	static public int WriteAsync(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Threading.CancellationToken a4;
			checkValueType(l,5,out a4);
			var ret=self.WriteAsync(a1,a2,a3,a4);
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
	static public int get_CanRead(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
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
	static public int get_CanWrite(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
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
	static public int get_CanSeek(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
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
	static public int get_IsAsync(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsAsync);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Name(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Name);
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
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
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
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
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
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
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
	static public int get_SafeFileHandle(IntPtr l) {
		try {
			System.IO.FileStream self=(System.IO.FileStream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.SafeFileHandle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.IO.FileStream");
		addMember(l,ReadByte);
		addMember(l,WriteByte);
		addMember(l,Read);
		addMember(l,BeginRead);
		addMember(l,EndRead);
		addMember(l,Write);
		addMember(l,BeginWrite);
		addMember(l,EndWrite);
		addMember(l,Seek);
		addMember(l,SetLength);
		addMember(l,Flush);
		addMember(l,Lock);
		addMember(l,Unlock);
		addMember(l,GetAccessControl);
		addMember(l,SetAccessControl);
		addMember(l,FlushAsync);
		addMember(l,ReadAsync);
		addMember(l,WriteAsync);
		addMember(l,"CanRead",get_CanRead,null,true);
		addMember(l,"CanWrite",get_CanWrite,null,true);
		addMember(l,"CanSeek",get_CanSeek,null,true);
		addMember(l,"IsAsync",get_IsAsync,null,true);
		addMember(l,"Name",get_Name,null,true);
		addMember(l,"Length",get_Length,null,true);
		addMember(l,"Position",get_Position,set_Position,true);
		addMember(l,"SafeFileHandle",get_SafeFileHandle,null,true);
		createTypeMetatable(l,constructor, typeof(System.IO.FileStream),typeof(System.IO.Stream));
	}
}
