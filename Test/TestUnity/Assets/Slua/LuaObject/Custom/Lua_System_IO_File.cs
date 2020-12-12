using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_IO_File : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AppendAllText__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.IO.File.AppendAllText(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AppendAllText__String__String__Encoding_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Text.Encoding a3;
			checkType(l,3,out a3);
			System.IO.File.AppendAllText(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AppendText_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.AppendText(a1);
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
	static public int Copy__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.IO.File.Copy(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Copy__String__String__Boolean_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			System.IO.File.Copy(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Create__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.Create(a1);
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
	static public int Create__String__Int32_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=System.IO.File.Create(a1,a2);
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
	static public int Create__String__Int32__FileOptions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.IO.FileOptions a3;
			checkEnum(l,3,out a3);
			var ret=System.IO.File.Create(a1,a2,a3);
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
	static public int Create__String__Int32__FileOptions__FileSecurity_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.IO.FileOptions a3;
			checkEnum(l,3,out a3);
			System.Security.AccessControl.FileSecurity a4;
			checkType(l,4,out a4);
			var ret=System.IO.File.Create(a1,a2,a3,a4);
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
	static public int CreateText_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.CreateText(a1);
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
	static public int Delete_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.IO.File.Delete(a1);
			pushValue(l,true);
			return 1;
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
			var ret=System.IO.File.Exists(a1);
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
			var ret=System.IO.File.GetAccessControl(a1);
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
			var ret=System.IO.File.GetAccessControl(a1,a2);
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
	static public int GetAttributes_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.GetAttributes(a1);
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
	static public int GetCreationTime_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.GetCreationTime(a1);
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
			var ret=System.IO.File.GetCreationTimeUtc(a1);
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
	static public int GetLastAccessTime_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.GetLastAccessTime(a1);
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
			var ret=System.IO.File.GetLastAccessTimeUtc(a1);
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
	static public int GetLastWriteTime_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.GetLastWriteTime(a1);
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
			var ret=System.IO.File.GetLastWriteTimeUtc(a1);
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
	static public int Move_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.IO.File.Move(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Open__String__FileMode_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.IO.FileMode a2;
			checkEnum(l,2,out a2);
			var ret=System.IO.File.Open(a1,a2);
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
	static public int Open__String__FileMode__FileAccess_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.IO.FileMode a2;
			checkEnum(l,2,out a2);
			System.IO.FileAccess a3;
			checkEnum(l,3,out a3);
			var ret=System.IO.File.Open(a1,a2,a3);
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
	static public int Open__String__FileMode__FileAccess__FileShare_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.IO.FileMode a2;
			checkEnum(l,2,out a2);
			System.IO.FileAccess a3;
			checkEnum(l,3,out a3);
			System.IO.FileShare a4;
			checkEnum(l,4,out a4);
			var ret=System.IO.File.Open(a1,a2,a3,a4);
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
	static public int OpenRead_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.OpenRead(a1);
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
	static public int OpenText_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.OpenText(a1);
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
	static public int OpenWrite_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.OpenWrite(a1);
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
	static public int Replace__String__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.IO.File.Replace(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Replace__String__String__String__Boolean_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			System.IO.File.Replace(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
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
			System.Security.AccessControl.FileSecurity a2;
			checkType(l,2,out a2);
			System.IO.File.SetAccessControl(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetAttributes_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.IO.FileAttributes a2;
			checkEnum(l,2,out a2);
			System.IO.File.SetAttributes(a1,a2);
			pushValue(l,true);
			return 1;
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
			System.IO.File.SetCreationTime(a1,a2);
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
			System.IO.File.SetCreationTimeUtc(a1,a2);
			pushValue(l,true);
			return 1;
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
			System.IO.File.SetLastAccessTime(a1,a2);
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
			System.IO.File.SetLastAccessTimeUtc(a1,a2);
			pushValue(l,true);
			return 1;
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
			System.IO.File.SetLastWriteTime(a1,a2);
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
			System.IO.File.SetLastWriteTimeUtc(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadAllBytes_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.ReadAllBytes(a1);
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
	static public int ReadAllLines__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.ReadAllLines(a1);
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
	static public int ReadAllLines__String__Encoding_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Text.Encoding a2;
			checkType(l,2,out a2);
			var ret=System.IO.File.ReadAllLines(a1,a2);
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
	static public int ReadAllText__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.ReadAllText(a1);
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
	static public int ReadAllText__String__Encoding_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Text.Encoding a2;
			checkType(l,2,out a2);
			var ret=System.IO.File.ReadAllText(a1,a2);
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
	static public int WriteAllBytes_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Byte[] a2;
			checkArray(l,2,out a2);
			System.IO.File.WriteAllBytes(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteAllLines__String__A_String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String[] a2;
			checkArray(l,2,out a2);
			System.IO.File.WriteAllLines(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteAllLines__String__IEnumerable_1_String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Collections.Generic.IEnumerable<System.String> a2;
			checkType(l,2,out a2);
			System.IO.File.WriteAllLines(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteAllLines__String__A_String__Encoding_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String[] a2;
			checkArray(l,2,out a2);
			System.Text.Encoding a3;
			checkType(l,3,out a3);
			System.IO.File.WriteAllLines(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteAllLines__String__IEnumerable_1_String__Encoding_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Collections.Generic.IEnumerable<System.String> a2;
			checkType(l,2,out a2);
			System.Text.Encoding a3;
			checkType(l,3,out a3);
			System.IO.File.WriteAllLines(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteAllText__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.IO.File.WriteAllText(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteAllText__String__String__Encoding_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Text.Encoding a3;
			checkType(l,3,out a3);
			System.IO.File.WriteAllText(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Encrypt_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.IO.File.Encrypt(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Decrypt_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.IO.File.Decrypt(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadLines__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.File.ReadLines(a1);
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
	static public int ReadLines__String__Encoding_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Text.Encoding a2;
			checkType(l,2,out a2);
			var ret=System.IO.File.ReadLines(a1,a2);
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
	static public int AppendAllLines__String__IEnumerable_1_String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Collections.Generic.IEnumerable<System.String> a2;
			checkType(l,2,out a2);
			System.IO.File.AppendAllLines(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AppendAllLines__String__IEnumerable_1_String__Encoding_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Collections.Generic.IEnumerable<System.String> a2;
			checkType(l,2,out a2);
			System.Text.Encoding a3;
			checkType(l,3,out a3);
			System.IO.File.AppendAllLines(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.IO.File");
		addMember(l,AppendAllText__String__String_s);
		addMember(l,AppendAllText__String__String__Encoding_s);
		addMember(l,AppendText_s);
		addMember(l,Copy__String__String_s);
		addMember(l,Copy__String__String__Boolean_s);
		addMember(l,Create__String_s);
		addMember(l,Create__String__Int32_s);
		addMember(l,Create__String__Int32__FileOptions_s);
		addMember(l,Create__String__Int32__FileOptions__FileSecurity_s);
		addMember(l,CreateText_s);
		addMember(l,Delete_s);
		addMember(l,Exists_s);
		addMember(l,GetAccessControl__String_s);
		addMember(l,GetAccessControl__String__AccessControlSections_s);
		addMember(l,GetAttributes_s);
		addMember(l,GetCreationTime_s);
		addMember(l,GetCreationTimeUtc_s);
		addMember(l,GetLastAccessTime_s);
		addMember(l,GetLastAccessTimeUtc_s);
		addMember(l,GetLastWriteTime_s);
		addMember(l,GetLastWriteTimeUtc_s);
		addMember(l,Move_s);
		addMember(l,Open__String__FileMode_s);
		addMember(l,Open__String__FileMode__FileAccess_s);
		addMember(l,Open__String__FileMode__FileAccess__FileShare_s);
		addMember(l,OpenRead_s);
		addMember(l,OpenText_s);
		addMember(l,OpenWrite_s);
		addMember(l,Replace__String__String__String_s);
		addMember(l,Replace__String__String__String__Boolean_s);
		addMember(l,SetAccessControl_s);
		addMember(l,SetAttributes_s);
		addMember(l,SetCreationTime_s);
		addMember(l,SetCreationTimeUtc_s);
		addMember(l,SetLastAccessTime_s);
		addMember(l,SetLastAccessTimeUtc_s);
		addMember(l,SetLastWriteTime_s);
		addMember(l,SetLastWriteTimeUtc_s);
		addMember(l,ReadAllBytes_s);
		addMember(l,ReadAllLines__String_s);
		addMember(l,ReadAllLines__String__Encoding_s);
		addMember(l,ReadAllText__String_s);
		addMember(l,ReadAllText__String__Encoding_s);
		addMember(l,WriteAllBytes_s);
		addMember(l,WriteAllLines__String__A_String_s);
		addMember(l,WriteAllLines__String__IEnumerable_1_String_s);
		addMember(l,WriteAllLines__String__A_String__Encoding_s);
		addMember(l,WriteAllLines__String__IEnumerable_1_String__Encoding_s);
		addMember(l,WriteAllText__String__String_s);
		addMember(l,WriteAllText__String__String__Encoding_s);
		addMember(l,Encrypt_s);
		addMember(l,Decrypt_s);
		addMember(l,ReadLines__String_s);
		addMember(l,ReadLines__String__Encoding_s);
		addMember(l,AppendAllLines__String__IEnumerable_1_String_s);
		addMember(l,AppendAllLines__String__IEnumerable_1_String__Encoding_s);
		createTypeMetatable(l,null, typeof(System.IO.File));
	}
}
