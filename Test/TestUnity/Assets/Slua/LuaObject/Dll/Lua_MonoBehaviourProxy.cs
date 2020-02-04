using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_MonoBehaviourProxy : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			MonoBehaviourProxy o;
			UnityEngine.MonoBehaviour a1;
			checkType(l,2,out a1);
			o=new MonoBehaviourProxy(a1);
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
	static public int StartCoroutine(IntPtr l) {
		try {
			MonoBehaviourProxy self=(MonoBehaviourProxy)checkSelf(l);
			System.Collections.IEnumerator a1;
			checkType(l,2,out a1);
			self.StartCoroutine(a1);
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
			MonoBehaviourProxy self=(MonoBehaviourProxy)checkSelf(l);
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
	static public int StartOneCoroutine(IntPtr l) {
		try {
			MonoBehaviourProxy self=(MonoBehaviourProxy)checkSelf(l);
			System.Collections.IEnumerator a1;
			checkType(l,2,out a1);
			var ret=self.StartOneCoroutine(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"MonoBehaviourProxy");
		addMember(l,StartCoroutine);
		addMember(l,StopAllCoroutines);
		addMember(l,StartOneCoroutine);
		createTypeMetatable(l,constructor, typeof(MonoBehaviourProxy));
	}
}
