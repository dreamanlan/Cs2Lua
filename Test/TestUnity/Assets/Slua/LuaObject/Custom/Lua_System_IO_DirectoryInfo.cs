using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_IO_DirectoryInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			System.IO.DirectoryInfo o;
			System.String a1;
			checkType(l,1,out a1);
			o=new System.IO.DirectoryInfo(a1);
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
	static public int CreateSubdirectory__String(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.CreateSubdirectory(a1);
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
	static public int CreateSubdirectory__String__DirectorySecurity(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Security.AccessControl.DirectorySecurity a2;
			checkType(l,3,out a2);
			var ret=self.CreateSubdirectory(a1,a2);
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
	static public int Create(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			self.Create();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Create__DirectorySecurity(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.Security.AccessControl.DirectorySecurity a1;
			checkType(l,2,out a1);
			self.Create(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetFiles(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			var ret=self.GetFiles();
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
	static public int GetFiles__String(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetFiles(a1);
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
	static public int GetFiles__String__SearchOption(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.IO.SearchOption a2;
			checkEnum(l,3,out a2);
			var ret=self.GetFiles(a1,a2);
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
	static public int GetFiles__String__EnumerationOptions(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.IO.EnumerationOptions a2;
			checkType(l,3,out a2);
			var ret=self.GetFiles(a1,a2);
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
	static public int GetFileSystemInfos(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			var ret=self.GetFileSystemInfos();
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
	static public int GetFileSystemInfos__String(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetFileSystemInfos(a1);
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
	static public int GetFileSystemInfos__String__SearchOption(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.IO.SearchOption a2;
			checkEnum(l,3,out a2);
			var ret=self.GetFileSystemInfos(a1,a2);
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
	static public int GetFileSystemInfos__String__EnumerationOptions(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.IO.EnumerationOptions a2;
			checkType(l,3,out a2);
			var ret=self.GetFileSystemInfos(a1,a2);
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
	static public int GetDirectories(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			var ret=self.GetDirectories();
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
	static public int GetDirectories__String(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetDirectories(a1);
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
	static public int GetDirectories__String__SearchOption(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.IO.SearchOption a2;
			checkEnum(l,3,out a2);
			var ret=self.GetDirectories(a1,a2);
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
	static public int GetDirectories__String__EnumerationOptions(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.IO.EnumerationOptions a2;
			checkType(l,3,out a2);
			var ret=self.GetDirectories(a1,a2);
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
	static public int MoveTo(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.MoveTo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Delete(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			self.Delete();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Delete__Boolean(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Delete(a1);
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
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
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
	static public int GetAccessControl__AccessControlSections(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.Security.AccessControl.AccessControlSections a1;
			checkEnum(l,2,out a1);
			var ret=self.GetAccessControl(a1);
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
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			System.Security.AccessControl.DirectorySecurity a1;
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
	static public int get_Parent(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Parent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Root(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Root);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.IO.DirectoryInfo");
		addMember(l,ctor_s);
		addMember(l,CreateSubdirectory__String);
		addMember(l,CreateSubdirectory__String__DirectorySecurity);
		addMember(l,Create);
		addMember(l,Create__DirectorySecurity);
		addMember(l,GetFiles);
		addMember(l,GetFiles__String);
		addMember(l,GetFiles__String__SearchOption);
		addMember(l,GetFiles__String__EnumerationOptions);
		addMember(l,GetFileSystemInfos);
		addMember(l,GetFileSystemInfos__String);
		addMember(l,GetFileSystemInfos__String__SearchOption);
		addMember(l,GetFileSystemInfos__String__EnumerationOptions);
		addMember(l,GetDirectories);
		addMember(l,GetDirectories__String);
		addMember(l,GetDirectories__String__SearchOption);
		addMember(l,GetDirectories__String__EnumerationOptions);
		addMember(l,MoveTo);
		addMember(l,Delete);
		addMember(l,Delete__Boolean);
		addMember(l,GetAccessControl);
		addMember(l,GetAccessControl__AccessControlSections);
		addMember(l,SetAccessControl);
		addMember(l,"Parent",get_Parent,null,true);
		addMember(l,"Root",get_Root,null,true);
		createTypeMetatable(l,null, typeof(System.IO.DirectoryInfo),typeof(System.IO.FileSystemInfo));
	}
}
