using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_IO_DirectoryInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			System.IO.DirectoryInfo o;
			System.String a1;
			checkType(l,2,out a1);
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
	static public int Create(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.Security.AccessControl.DirectorySecurity a1;
				checkType(l,3,out a1);
				self.Create(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				self.Create();
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
	static public int CreateSubdirectory(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Security.AccessControl.DirectorySecurity a2;
				checkType(l,4,out a2);
				var ret=self.CreateSubdirectory(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.CreateSubdirectory(a1);
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
	static public int GetFiles(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.IO.SearchOption a2;
				checkEnum(l,4,out a2);
				var ret=self.GetFiles(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.GetFiles(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				var ret=self.GetFiles();
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
	static public int GetDirectories(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.IO.SearchOption a2;
				checkEnum(l,4,out a2);
				var ret=self.GetDirectories(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.GetDirectories(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				var ret=self.GetDirectories();
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
	static public int GetFileSystemInfos(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.IO.SearchOption a2;
				checkEnum(l,4,out a2);
				var ret=self.GetFileSystemInfos(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.GetFileSystemInfos(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				var ret=self.GetFileSystemInfos();
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
	static public int Delete(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.Boolean a1;
				checkType(l,3,out a1);
				self.Delete(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				self.Delete();
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
	static public int GetAccessControl(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.Security.AccessControl.AccessControlSections a1;
				checkEnum(l,3,out a1);
				var ret=self.GetAccessControl(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				var ret=self.GetAccessControl();
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
	static public int EnumerateDirectories(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.IO.SearchOption a2;
				checkEnum(l,4,out a2);
				var ret=self.EnumerateDirectories(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.EnumerateDirectories(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				var ret=self.EnumerateDirectories();
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
	static public int EnumerateFiles(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.IO.SearchOption a2;
				checkEnum(l,4,out a2);
				var ret=self.EnumerateFiles(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.EnumerateFiles(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				var ret=self.EnumerateFiles();
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
	static public int EnumerateFileSystemInfos(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.IO.SearchOption a2;
				checkEnum(l,4,out a2);
				var ret=self.EnumerateFileSystemInfos(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				var ret=self.EnumerateFileSystemInfos(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
				var ret=self.EnumerateFileSystemInfos();
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
	static public int get_Exists(IntPtr l) {
		try {
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Exists);
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
			System.IO.DirectoryInfo self=(System.IO.DirectoryInfo)checkSelf(l);
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
		addMember(l,Create);
		addMember(l,CreateSubdirectory);
		addMember(l,GetFiles);
		addMember(l,GetDirectories);
		addMember(l,GetFileSystemInfos);
		addMember(l,Delete);
		addMember(l,MoveTo);
		addMember(l,GetAccessControl);
		addMember(l,SetAccessControl);
		addMember(l,EnumerateDirectories);
		addMember(l,EnumerateFiles);
		addMember(l,EnumerateFileSystemInfos);
		addMember(l,"Exists",get_Exists,null,true);
		addMember(l,"Name",get_Name,null,true);
		addMember(l,"Parent",get_Parent,null,true);
		addMember(l,"Root",get_Root,null,true);
		createTypeMetatable(l,constructor, typeof(System.IO.DirectoryInfo),typeof(System.IO.FileSystemInfo));
	}
}
