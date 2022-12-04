using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_IO_Path : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ChangeExtension_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.IO.Path.ChangeExtension(a1,a2);
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
	static public int Combine__A_String_s(IntPtr l) {
		try {
			System.String[] a1;
			checkParams(l,1,out a1);
			var ret=System.IO.Path.Combine(a1);
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
	static public int Combine__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.IO.Path.Combine(a1,a2);
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
	static public int Combine__String__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			var ret=System.IO.Path.Combine(a1,a2,a3);
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
	static public int Combine__String__String__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.String a4;
			checkType(l,4,out a4);
			var ret=System.IO.Path.Combine(a1,a2,a3,a4);
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
	static public int GetDirectoryName_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Path.GetDirectoryName(a1);
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
	static public int GetExtension_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Path.GetExtension(a1);
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
	static public int GetFileName_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Path.GetFileName(a1);
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
	static public int GetFileNameWithoutExtension_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Path.GetFileNameWithoutExtension(a1);
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
	static public int GetFullPath__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Path.GetFullPath(a1);
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
	static public int GetFullPath__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.IO.Path.GetFullPath(a1,a2);
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
	static public int GetPathRoot_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Path.GetPathRoot(a1);
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
	static public int GetTempFileName_s(IntPtr l) {
		try {
			var ret=System.IO.Path.GetTempFileName();
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
	static public int GetTempPath_s(IntPtr l) {
		try {
			var ret=System.IO.Path.GetTempPath();
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
	static public int HasExtension_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Path.HasExtension(a1);
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
	static public int IsPathRooted_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Path.IsPathRooted(a1);
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
	static public int GetInvalidFileNameChars_s(IntPtr l) {
		try {
			var ret=System.IO.Path.GetInvalidFileNameChars();
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
	static public int GetInvalidPathChars_s(IntPtr l) {
		try {
			var ret=System.IO.Path.GetInvalidPathChars();
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
	static public int GetRandomFileName_s(IntPtr l) {
		try {
			var ret=System.IO.Path.GetRandomFileName();
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
	static public int GetRelativePath_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.IO.Path.GetRelativePath(a1,a2);
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
	static public int IsPathFullyQualified_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.IO.Path.IsPathFullyQualified(a1);
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
	static public int get_AltDirectorySeparatorChar(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.IO.Path.AltDirectorySeparatorChar);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DirectorySeparatorChar(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.IO.Path.DirectorySeparatorChar);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_PathSeparator(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.IO.Path.PathSeparator);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_VolumeSeparatorChar(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.IO.Path.VolumeSeparatorChar);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.IO.Path");
		addMember(l,ChangeExtension_s);
		addMember(l,Combine__A_String_s);
		addMember(l,Combine__String__String_s);
		addMember(l,Combine__String__String__String_s);
		addMember(l,Combine__String__String__String__String_s);
		addMember(l,GetDirectoryName_s);
		addMember(l,GetExtension_s);
		addMember(l,GetFileName_s);
		addMember(l,GetFileNameWithoutExtension_s);
		addMember(l,GetFullPath__String_s);
		addMember(l,GetFullPath__String__String_s);
		addMember(l,GetPathRoot_s);
		addMember(l,GetTempFileName_s);
		addMember(l,GetTempPath_s);
		addMember(l,HasExtension_s);
		addMember(l,IsPathRooted_s);
		addMember(l,GetInvalidFileNameChars_s);
		addMember(l,GetInvalidPathChars_s);
		addMember(l,GetRandomFileName_s);
		addMember(l,GetRelativePath_s);
		addMember(l,IsPathFullyQualified_s);
		addMember(l,"AltDirectorySeparatorChar",get_AltDirectorySeparatorChar,null,false);
		addMember(l,"DirectorySeparatorChar",get_DirectorySeparatorChar,null,false);
		addMember(l,"PathSeparator",get_PathSeparator,null,false);
		addMember(l,"VolumeSeparatorChar",get_VolumeSeparatorChar,null,false);
		createTypeMetatable(l,null, typeof(System.IO.Path));
	}
}
