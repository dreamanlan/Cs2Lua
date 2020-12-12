using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_MonoBehaviour : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsInvoking(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour self=(UnityEngine.MonoBehaviour)checkSelf(l);
			var ret=self.IsInvoking();
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
	static public int IsInvoking__String(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour self=(UnityEngine.MonoBehaviour)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.IsInvoking(a1);
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
	static public int CancelInvoke(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour self=(UnityEngine.MonoBehaviour)checkSelf(l);
			self.CancelInvoke();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CancelInvoke__String(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour self=(UnityEngine.MonoBehaviour)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.CancelInvoke(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Invoke(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour self=(UnityEngine.MonoBehaviour)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.Invoke(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InvokeRepeating(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour self=(UnityEngine.MonoBehaviour)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.InvokeRepeating(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartCoroutine__String(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour self=(UnityEngine.MonoBehaviour)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.StartCoroutine(a1);
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
	static public int StartCoroutine__IEnumerator(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour self=(UnityEngine.MonoBehaviour)checkSelf(l);
			System.Collections.IEnumerator a1;
			checkType(l,2,out a1);
			var ret=self.StartCoroutine(a1);
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
	static public int StartCoroutine__String__Object(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour self=(UnityEngine.MonoBehaviour)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			var ret=self.StartCoroutine(a1,a2);
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
	static public int StopCoroutine__IEnumerator(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour self=(UnityEngine.MonoBehaviour)checkSelf(l);
			System.Collections.IEnumerator a1;
			checkType(l,2,out a1);
			self.StopCoroutine(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopCoroutine__Coroutine(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour self=(UnityEngine.MonoBehaviour)checkSelf(l);
			UnityEngine.Coroutine a1;
			checkType(l,2,out a1);
			self.StopCoroutine(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopCoroutine__String(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour self=(UnityEngine.MonoBehaviour)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.StopCoroutine(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopAllCoroutines(IntPtr l) {
		try {
			UnityEngine.MonoBehaviour self=(UnityEngine.MonoBehaviour)checkSelf(l);
			self.StopAllCoroutines();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int print_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			UnityEngine.MonoBehaviour.print(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MonoBehaviour");
		addMember(l,IsInvoking);
		addMember(l,IsInvoking__String);
		addMember(l,CancelInvoke);
		addMember(l,CancelInvoke__String);
		addMember(l,Invoke);
		addMember(l,InvokeRepeating);
		addMember(l,StartCoroutine__String);
		addMember(l,StartCoroutine__IEnumerator);
		addMember(l,StartCoroutine__String__Object);
		addMember(l,StopCoroutine__IEnumerator);
		addMember(l,StopCoroutine__Coroutine);
		addMember(l,StopCoroutine__String);
		addMember(l,StopAllCoroutines);
		addMember(l,print_s);
		createTypeMetatable(l,null, typeof(UnityEngine.MonoBehaviour),typeof(UnityEngine.Behaviour));
	}
}
