using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Collections_BitArray : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__Int32_s(IntPtr l) {
		try {
			System.Collections.BitArray o;
			System.Int32 a1;
			checkType(l,1,out a1);
			o=new System.Collections.BitArray(a1);
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
	static public int ctor__A_Byte_s(IntPtr l) {
		try {
			System.Collections.BitArray o;
			System.Byte[] a1;
			checkArray(l,1,out a1);
			o=new System.Collections.BitArray(a1);
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
	static public int ctor__A_Boolean_s(IntPtr l) {
		try {
			System.Collections.BitArray o;
			System.Boolean[] a1;
			checkArray(l,1,out a1);
			o=new System.Collections.BitArray(a1);
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
	static public int ctor__A_Int32_s(IntPtr l) {
		try {
			System.Collections.BitArray o;
			System.Int32[] a1;
			checkArray(l,1,out a1);
			o=new System.Collections.BitArray(a1);
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
	static public int ctor__BitArray_s(IntPtr l) {
		try {
			System.Collections.BitArray o;
			System.Collections.BitArray a1;
			checkType(l,1,out a1);
			o=new System.Collections.BitArray(a1);
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
	static public int ctor__Int32__Boolean_s(IntPtr l) {
		try {
			System.Collections.BitArray o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			o=new System.Collections.BitArray(a1,a2);
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
	static public int Get(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.Get(a1);
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
	static public int Set(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.Set(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetAll(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.SetAll(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int And(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
			System.Collections.BitArray a1;
			checkType(l,2,out a1);
			var ret=self.And(a1);
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
	static public int Or(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
			System.Collections.BitArray a1;
			checkType(l,2,out a1);
			var ret=self.Or(a1);
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
	static public int Xor(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
			System.Collections.BitArray a1;
			checkType(l,2,out a1);
			var ret=self.Xor(a1);
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
	static public int Not(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
			var ret=self.Not();
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
	static public int RightShift(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.RightShift(a1);
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
	static public int LeftShift(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.LeftShift(a1);
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
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
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
	static public int Clone(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
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
	static public int GetEnumerator(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
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
	static public int get_Length(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
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
	static public int set_Length(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.Length=v;
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
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
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
	static public int get_SyncRoot(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
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
	static public int get_IsSynchronized(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
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
	static public int get_IsReadOnly(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
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
	static public int getItem(IntPtr l) {
		try {
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
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
			System.Collections.BitArray self=(System.Collections.BitArray)checkSelf(l);
			int v;
			checkType(l,2,out v);
			bool c;
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
		getTypeTable(l,"System.Collections.BitArray");
		addMember(l,ctor__Int32_s);
		addMember(l,ctor__A_Byte_s);
		addMember(l,ctor__A_Boolean_s);
		addMember(l,ctor__A_Int32_s);
		addMember(l,ctor__BitArray_s);
		addMember(l,ctor__Int32__Boolean_s);
		addMember(l,Get);
		addMember(l,Set);
		addMember(l,SetAll);
		addMember(l,And);
		addMember(l,Or);
		addMember(l,Xor);
		addMember(l,Not);
		addMember(l,RightShift);
		addMember(l,LeftShift);
		addMember(l,CopyTo);
		addMember(l,Clone);
		addMember(l,GetEnumerator);
		addMember(l,getItem);
		addMember(l,setItem);
		addMember(l,"Length",get_Length,set_Length,true);
		addMember(l,"Count",get_Count,null,true);
		addMember(l,"SyncRoot",get_SyncRoot,null,true);
		addMember(l,"IsSynchronized",get_IsSynchronized,null,true);
		addMember(l,"IsReadOnly",get_IsReadOnly,null,true);
		createTypeMetatable(l,null, typeof(System.Collections.BitArray));
	}
}
