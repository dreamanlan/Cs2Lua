using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Collections_Queue : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			System.Collections.Queue o;
			o=new System.Collections.Queue();
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
	static public int ctor__Int32_s(IntPtr l) {
		try {
			System.Collections.Queue o;
			System.Int32 a1;
			checkType(l,1,out a1);
			o=new System.Collections.Queue(a1);
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
	static public int ctor__ICollection_s(IntPtr l) {
		try {
			System.Collections.Queue o;
			System.Collections.ICollection a1;
			checkType(l,1,out a1);
			o=new System.Collections.Queue(a1);
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
	static public int ctor__Int32__Single_s(IntPtr l) {
		try {
			System.Collections.Queue o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			o=new System.Collections.Queue(a1,a2);
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
	static public int Clone(IntPtr l) {
		try {
			System.Collections.Queue self=(System.Collections.Queue)checkSelf(l);
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
	static public int Clear(IntPtr l) {
		try {
			System.Collections.Queue self=(System.Collections.Queue)checkSelf(l);
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
	static public int CopyTo(IntPtr l) {
		try {
			System.Collections.Queue self=(System.Collections.Queue)checkSelf(l);
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
	static public int Enqueue(IntPtr l) {
		try {
			System.Collections.Queue self=(System.Collections.Queue)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			self.Enqueue(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetEnumerator(IntPtr l) {
		try {
			System.Collections.Queue self=(System.Collections.Queue)checkSelf(l);
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
	static public int Dequeue(IntPtr l) {
		try {
			System.Collections.Queue self=(System.Collections.Queue)checkSelf(l);
			var ret=self.Dequeue();
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
	static public int Peek(IntPtr l) {
		try {
			System.Collections.Queue self=(System.Collections.Queue)checkSelf(l);
			var ret=self.Peek();
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
			System.Collections.Queue self=(System.Collections.Queue)checkSelf(l);
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
	static public int ToArray(IntPtr l) {
		try {
			System.Collections.Queue self=(System.Collections.Queue)checkSelf(l);
			var ret=self.ToArray();
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
	static public int TrimToSize(IntPtr l) {
		try {
			System.Collections.Queue self=(System.Collections.Queue)checkSelf(l);
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
	static public int Synchronized_s(IntPtr l) {
		try {
			System.Collections.Queue a1;
			checkType(l,1,out a1);
			var ret=System.Collections.Queue.Synchronized(a1);
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
	static public int get_Count(IntPtr l) {
		try {
			System.Collections.Queue self=(System.Collections.Queue)checkSelf(l);
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
			System.Collections.Queue self=(System.Collections.Queue)checkSelf(l);
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
			System.Collections.Queue self=(System.Collections.Queue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.SyncRoot);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Collections.Queue");
		addMember(l,ctor_s);
		addMember(l,ctor__Int32_s);
		addMember(l,ctor__ICollection_s);
		addMember(l,ctor__Int32__Single_s);
		addMember(l,Clone);
		addMember(l,Clear);
		addMember(l,CopyTo);
		addMember(l,Enqueue);
		addMember(l,GetEnumerator);
		addMember(l,Dequeue);
		addMember(l,Peek);
		addMember(l,Contains);
		addMember(l,ToArray);
		addMember(l,TrimToSize);
		addMember(l,Synchronized_s);
		addMember(l,"Count",get_Count,null,true);
		addMember(l,"IsSynchronized",get_IsSynchronized,null,true);
		addMember(l,"SyncRoot",get_SyncRoot,null,true);
		createTypeMetatable(l,null, typeof(System.Collections.Queue));
	}
}
