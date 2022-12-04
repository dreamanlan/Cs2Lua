using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Text_RegularExpressions_GroupCollection : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetEnumerator(IntPtr l) {
		try {
			System.Text.RegularExpressions.GroupCollection self=(System.Text.RegularExpressions.GroupCollection)checkSelf(l);
			var ret=self.GetEnumerator();
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
	static public int CopyTo__Array__Int32(IntPtr l) {
		try {
			System.Text.RegularExpressions.GroupCollection self=(System.Text.RegularExpressions.GroupCollection)checkSelf(l);
			System.Array a1;
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
	static public int CopyTo__A_Group__Int32(IntPtr l) {
		try {
			System.Text.RegularExpressions.GroupCollection self=(System.Text.RegularExpressions.GroupCollection)checkSelf(l);
			System.Text.RegularExpressions.Group[] a1;
			checkArray(l,2,out a1);
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
	static public int get_IsReadOnly(IntPtr l) {
		try {
			System.Text.RegularExpressions.GroupCollection self=(System.Text.RegularExpressions.GroupCollection)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsReadOnly);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Count(IntPtr l) {
		try {
			System.Text.RegularExpressions.GroupCollection self=(System.Text.RegularExpressions.GroupCollection)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Count);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsSynchronized(IntPtr l) {
		try {
			System.Text.RegularExpressions.GroupCollection self=(System.Text.RegularExpressions.GroupCollection)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsSynchronized);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_SyncRoot(IntPtr l) {
		try {
			System.Text.RegularExpressions.GroupCollection self=(System.Text.RegularExpressions.GroupCollection)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.SyncRoot);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int getItem(IntPtr l) {
		try {
			System.Text.RegularExpressions.GroupCollection self=(System.Text.RegularExpressions.GroupCollection)checkSelf(l);
			LuaTypes t = LuaDLL.lua_type(l, 2);
			if(matchType(l,2,t,typeof(System.Int32))){
				int v;
				checkType(l,2,out v);
				var ret = self[v];
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,2,t,typeof(System.String))){
				string v;
				checkType(l,2,out v);
				var ret = self[v];
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Text.RegularExpressions.GroupCollection");
		addMember(l,GetEnumerator);
		addMember(l,CopyTo__Array__Int32);
		addMember(l,CopyTo__A_Group__Int32);
		addMember(l,getItem);
		addMember(l,"IsReadOnly",get_IsReadOnly,null,true);
		addMember(l,"Count",get_Count,null,true);
		addMember(l,"IsSynchronized",get_IsSynchronized,null,true);
		addMember(l,"SyncRoot",get_SyncRoot,null,true);
		createTypeMetatable(l,null, typeof(System.Text.RegularExpressions.GroupCollection));
	}
}
