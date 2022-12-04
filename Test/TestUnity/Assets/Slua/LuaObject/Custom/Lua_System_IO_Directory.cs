using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_IO_Directory : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetParent_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.GetParent(a1);
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
	static public int CreateDirectory__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.CreateDirectory(a1);
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
	static public int CreateDirectory__String__DirectorySecurity_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Security.AccessControl.DirectorySecurity a2;
			checkType(l,2,out a2);
			var ret=System.IO.Directory.CreateDirectory(a1,a2);
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
	static public int Exists_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.Exists(a1);
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
	static public int SetCreationTime_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.DateTime a2;
			checkValueType(l,2,out a2);
			System.IO.Directory.SetCreationTime(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetCreationTimeUtc_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.DateTime a2;
			checkValueType(l,2,out a2);
			System.IO.Directory.SetCreationTimeUtc(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetCreationTime_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.GetCreationTime(a1);
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
	static public int GetCreationTimeUtc_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.GetCreationTimeUtc(a1);
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
	static public int SetLastWriteTime_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.DateTime a2;
			checkValueType(l,2,out a2);
			System.IO.Directory.SetLastWriteTime(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetLastWriteTimeUtc_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.DateTime a2;
			checkValueType(l,2,out a2);
			System.IO.Directory.SetLastWriteTimeUtc(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLastWriteTime_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.GetLastWriteTime(a1);
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
	static public int GetLastWriteTimeUtc_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.GetLastWriteTimeUtc(a1);
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
	static public int SetLastAccessTime_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.DateTime a2;
			checkValueType(l,2,out a2);
			System.IO.Directory.SetLastAccessTime(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetLastAccessTimeUtc_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.DateTime a2;
			checkValueType(l,2,out a2);
			System.IO.Directory.SetLastAccessTimeUtc(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLastAccessTime_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.GetLastAccessTime(a1);
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
	static public int GetLastAccessTimeUtc_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.GetLastAccessTimeUtc(a1);
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
	static public int GetFiles__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.GetFiles(a1);
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
	static public int GetFiles__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.IO.Directory.GetFiles(a1,a2);
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
	static public int GetFiles__String__String__SearchOption_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.IO.SearchOption a3;
			checkEnum(l,3,out a3);
			var ret=System.IO.Directory.GetFiles(a1,a2,a3);
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
	static public int GetFiles__String__String__EnumerationOptions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.IO.EnumerationOptions a3;
			checkType(l,3,out a3);
			var ret=System.IO.Directory.GetFiles(a1,a2,a3);
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
	static public int GetDirectories__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.GetDirectories(a1);
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
	static public int GetDirectories__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.IO.Directory.GetDirectories(a1,a2);
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
	static public int GetDirectories__String__String__SearchOption_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.IO.SearchOption a3;
			checkEnum(l,3,out a3);
			var ret=System.IO.Directory.GetDirectories(a1,a2,a3);
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
	static public int GetDirectories__String__String__EnumerationOptions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.IO.EnumerationOptions a3;
			checkType(l,3,out a3);
			var ret=System.IO.Directory.GetDirectories(a1,a2,a3);
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
	static public int GetFileSystemEntries__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.GetFileSystemEntries(a1);
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
	static public int GetFileSystemEntries__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.IO.Directory.GetFileSystemEntries(a1,a2);
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
	static public int GetFileSystemEntries__String__String__SearchOption_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.IO.SearchOption a3;
			checkEnum(l,3,out a3);
			var ret=System.IO.Directory.GetFileSystemEntries(a1,a2,a3);
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
	static public int GetFileSystemEntries__String__String__EnumerationOptions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.IO.EnumerationOptions a3;
			checkType(l,3,out a3);
			var ret=System.IO.Directory.GetFileSystemEntries(a1,a2,a3);
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
	static public int GetDirectoryRoot_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.GetDirectoryRoot(a1);
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
	static public int GetCurrentDirectory_s(IntPtr l) {
		try {
			var ret=System.IO.Directory.GetCurrentDirectory();
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
	static public int SetCurrentDirectory_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.IO.Directory.SetCurrentDirectory(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Move_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.IO.Directory.Move(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Delete__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.IO.Directory.Delete(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Delete__String__Boolean_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			System.IO.Directory.Delete(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLogicalDrives_s(IntPtr l) {
		try {
			var ret=System.IO.Directory.GetLogicalDrives();
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
	static public int GetAccessControl__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Directory.GetAccessControl(a1);
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
	static public int GetAccessControl__String__AccessControlSections_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Security.AccessControl.AccessControlSections a2;
			checkEnum(l,2,out a2);
			var ret=System.IO.Directory.GetAccessControl(a1,a2);
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
	static public int SetAccessControl_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Security.AccessControl.DirectorySecurity a2;
			checkType(l,2,out a2);
			System.IO.Directory.SetAccessControl(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.IO.Directory");
		addMember(l,GetParent_s);
		addMember(l,CreateDirectory__String_s);
		addMember(l,CreateDirectory__String__DirectorySecurity_s);
		addMember(l,Exists_s);
		addMember(l,SetCreationTime_s);
		addMember(l,SetCreationTimeUtc_s);
		addMember(l,GetCreationTime_s);
		addMember(l,GetCreationTimeUtc_s);
		addMember(l,SetLastWriteTime_s);
		addMember(l,SetLastWriteTimeUtc_s);
		addMember(l,GetLastWriteTime_s);
		addMember(l,GetLastWriteTimeUtc_s);
		addMember(l,SetLastAccessTime_s);
		addMember(l,SetLastAccessTimeUtc_s);
		addMember(l,GetLastAccessTime_s);
		addMember(l,GetLastAccessTimeUtc_s);
		addMember(l,GetFiles__String_s);
		addMember(l,GetFiles__String__String_s);
		addMember(l,GetFiles__String__String__SearchOption_s);
		addMember(l,GetFiles__String__String__EnumerationOptions_s);
		addMember(l,GetDirectories__String_s);
		addMember(l,GetDirectories__String__String_s);
		addMember(l,GetDirectories__String__String__SearchOption_s);
		addMember(l,GetDirectories__String__String__EnumerationOptions_s);
		addMember(l,GetFileSystemEntries__String_s);
		addMember(l,GetFileSystemEntries__String__String_s);
		addMember(l,GetFileSystemEntries__String__String__SearchOption_s);
		addMember(l,GetFileSystemEntries__String__String__EnumerationOptions_s);
		addMember(l,GetDirectoryRoot_s);
		addMember(l,GetCurrentDirectory_s);
		addMember(l,SetCurrentDirectory_s);
		addMember(l,Move_s);
		addMember(l,Delete__String_s);
		addMember(l,Delete__String__Boolean_s);
		addMember(l,GetLogicalDrives_s);
		addMember(l,GetAccessControl__String_s);
		addMember(l,GetAccessControl__String__AccessControlSections_s);
		addMember(l,SetAccessControl_s);
		createTypeMetatable(l,null, typeof(System.IO.Directory));
	}
}
