using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UI_Scrollbar_ScrollEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.UI.Scrollbar.ScrollEvent o;
			o=new UnityEngine.UI.Scrollbar.ScrollEvent();
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
	static public int AddListener(IntPtr l) {
		try {
			UnityEngine.UI.Scrollbar.ScrollEvent self=(UnityEngine.UI.Scrollbar.ScrollEvent)checkSelf(l);
			UnityEngine.Events.UnityAction<System.Single> a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			self.AddListener(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveListener(IntPtr l) {
		try {
			UnityEngine.UI.Scrollbar.ScrollEvent self=(UnityEngine.UI.Scrollbar.ScrollEvent)checkSelf(l);
			UnityEngine.Events.UnityAction<System.Single> a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			self.RemoveListener(a1);
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
			UnityEngine.UI.Scrollbar.ScrollEvent self=(UnityEngine.UI.Scrollbar.ScrollEvent)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.Invoke(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPersistentEventCount(IntPtr l) {
		try {
			UnityEngine.UI.Scrollbar.ScrollEvent self=(UnityEngine.UI.Scrollbar.ScrollEvent)checkSelf(l);
			var ret=self.GetPersistentEventCount();
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
	static public int GetPersistentTarget(IntPtr l) {
		try {
			UnityEngine.UI.Scrollbar.ScrollEvent self=(UnityEngine.UI.Scrollbar.ScrollEvent)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPersistentTarget(a1);
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
	static public int GetPersistentMethodName(IntPtr l) {
		try {
			UnityEngine.UI.Scrollbar.ScrollEvent self=(UnityEngine.UI.Scrollbar.ScrollEvent)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPersistentMethodName(a1);
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
	static public int SetPersistentListenerState(IntPtr l) {
		try {
			UnityEngine.UI.Scrollbar.ScrollEvent self=(UnityEngine.UI.Scrollbar.ScrollEvent)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Events.UnityEventCallState a2;
			checkEnum(l,3,out a2);
			self.SetPersistentListenerState(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveAllListeners(IntPtr l) {
		try {
			UnityEngine.UI.Scrollbar.ScrollEvent self=(UnityEngine.UI.Scrollbar.ScrollEvent)checkSelf(l);
			self.RemoveAllListeners();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		LuaUnityEvent_float.reg(l);
		getTypeTable(l,"UnityEngine.UI.Scrollbar.ScrollEvent");
		addMember(l,AddListener);
		addMember(l,RemoveListener);
		addMember(l,Invoke);
		addMember(l,GetPersistentEventCount);
		addMember(l,GetPersistentTarget);
		addMember(l,GetPersistentMethodName);
		addMember(l,SetPersistentListenerState);
		addMember(l,RemoveAllListeners);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.Scrollbar.ScrollEvent),typeof(LuaUnityEvent_float));
	}
}
