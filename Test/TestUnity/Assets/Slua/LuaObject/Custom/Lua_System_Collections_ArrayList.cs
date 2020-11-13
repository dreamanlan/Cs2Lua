using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Collections_ArrayList : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			System.Collections.ArrayList o;
			if(matchType(l, "ctor__Void__Int32", argc, 2,typeof(int))){
				System.Int32 a1;
				checkType(l,3,out a1);
				o=new System.Collections.ArrayList(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__ICollection", argc, 2,typeof(System.Collections.ICollection))){
				System.Collections.ICollection a1;
				checkType(l,3,out a1);
				o=new System.Collections.ArrayList(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				o=new System.Collections.ArrayList();
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
	static public int Add(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Add(a1);
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
	static public int AddRange(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			System.Collections.ICollection a1;
			checkType(l,2,out a1);
			self.AddRange(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BinarySearch(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Object a3;
				checkType(l,5,out a3);
				System.Collections.IComparer a4;
				checkType(l,6,out a4);
				var ret=self.BinarySearch(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Object a1;
				checkType(l,3,out a1);
				System.Collections.IComparer a2;
				checkType(l,4,out a2);
				var ret=self.BinarySearch(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Object a1;
				checkType(l,3,out a1);
				var ret=self.BinarySearch(a1);
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
	static public int Clear(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			self.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Clone(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			var ret=self.Clone();
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
	static public int Contains(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Contains(a1);
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
	static public int CopyTo(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Array a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				self.CopyTo(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Array a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				self.CopyTo(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Array a1;
				checkType(l,3,out a1);
				self.CopyTo(a1);
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
	static public int IndexOf(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Object a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.IndexOf(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Object a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.IndexOf(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Object a1;
				checkType(l,3,out a1);
				var ret=self.IndexOf(a1);
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
	static public int Insert(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			self.Insert(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InsertRange(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.ICollection a2;
			checkType(l,3,out a2);
			self.InsertRange(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LastIndexOf(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Object a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				var ret=self.LastIndexOf(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Object a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				var ret=self.LastIndexOf(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Object a1;
				checkType(l,3,out a1);
				var ret=self.LastIndexOf(a1);
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
	static public int Remove(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			self.Remove(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveAt(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.RemoveAt(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveRange(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.RemoveRange(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Reverse(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				self.Reverse(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				self.Reverse();
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
	static public int SetRange(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.ICollection a2;
			checkType(l,3,out a2);
			self.SetRange(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetRange(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.GetRange(a1,a2);
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
	static public int Sort(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Collections.IComparer a3;
				checkType(l,5,out a3);
				self.Sort(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Collections.IComparer a1;
				checkType(l,3,out a1);
				self.Sort(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				self.Sort();
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
	static public int ToArray(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				System.Type a1;
				checkType(l,3,out a1);
				var ret=self.ToArray(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
				var ret=self.ToArray();
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
	static public int TrimToSize(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			self.TrimToSize();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Adapter_s(IntPtr l) {
		try {
			System.Collections.IList a1;
			checkType(l,1,out a1);
			var ret=System.Collections.ArrayList.Adapter(a1);
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
	static public int FixedSize_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "FixedSize__IList__IList", argc, 1,typeof(System.Collections.IList))){
				System.Collections.IList a1;
				checkType(l,2,out a1);
				var ret=System.Collections.ArrayList.FixedSize(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "FixedSize__ArrayList__ArrayList", argc, 1,typeof(System.Collections.ArrayList))){
				System.Collections.ArrayList a1;
				checkType(l,2,out a1);
				var ret=System.Collections.ArrayList.FixedSize(a1);
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
	static public int ReadOnly_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ReadOnly__IList__IList", argc, 1,typeof(System.Collections.IList))){
				System.Collections.IList a1;
				checkType(l,2,out a1);
				var ret=System.Collections.ArrayList.ReadOnly(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "ReadOnly__ArrayList__ArrayList", argc, 1,typeof(System.Collections.ArrayList))){
				System.Collections.ArrayList a1;
				checkType(l,2,out a1);
				var ret=System.Collections.ArrayList.ReadOnly(a1);
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
	static public int Repeat_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=System.Collections.ArrayList.Repeat(a1,a2);
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
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Synchronized__IList__IList", argc, 1,typeof(System.Collections.IList))){
				System.Collections.IList a1;
				checkType(l,2,out a1);
				var ret=System.Collections.ArrayList.Synchronized(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Synchronized__ArrayList__ArrayList", argc, 1,typeof(System.Collections.ArrayList))){
				System.Collections.ArrayList a1;
				checkType(l,2,out a1);
				var ret=System.Collections.ArrayList.Synchronized(a1);
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
	static public int get_Capacity(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Capacity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_Capacity(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.Capacity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Count(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
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
	static public int get_IsFixedSize(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsFixedSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsReadOnly(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
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
	static public int get_IsSynchronized(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
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
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
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
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			int v;
			checkType(l,2,out v);
			var ret = self[v];
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
	static public int setItem(IntPtr l) {
		try {
			System.Collections.ArrayList self=(System.Collections.ArrayList)checkSelf(l);
			int v;
			checkType(l,2,out v);
			System.Object c;
			checkType(l,3,out c);
			self[v]=c;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Collections.ArrayList");
		addMember(l,Add);
		addMember(l,AddRange);
		addMember(l,BinarySearch);
		addMember(l,Clear);
		addMember(l,Clone);
		addMember(l,Contains);
		addMember(l,CopyTo);
		addMember(l,IndexOf);
		addMember(l,Insert);
		addMember(l,InsertRange);
		addMember(l,LastIndexOf);
		addMember(l,Remove);
		addMember(l,RemoveAt);
		addMember(l,RemoveRange);
		addMember(l,Reverse);
		addMember(l,SetRange);
		addMember(l,GetRange);
		addMember(l,Sort);
		addMember(l,ToArray);
		addMember(l,TrimToSize);
		addMember(l,Adapter_s);
		addMember(l,FixedSize_s);
		addMember(l,ReadOnly_s);
		addMember(l,Repeat_s);
		addMember(l,Synchronized_s);
		addMember(l,getItem);
		addMember(l,setItem);
		addMember(l,"Capacity",get_Capacity,set_Capacity,true);
		addMember(l,"Count",get_Count,null,true);
		addMember(l,"IsFixedSize",get_IsFixedSize,null,true);
		addMember(l,"IsReadOnly",get_IsReadOnly,null,true);
		addMember(l,"IsSynchronized",get_IsSynchronized,null,true);
		addMember(l,"SyncRoot",get_SyncRoot,null,true);
		createTypeMetatable(l,constructor, typeof(System.Collections.ArrayList));
	}
}
