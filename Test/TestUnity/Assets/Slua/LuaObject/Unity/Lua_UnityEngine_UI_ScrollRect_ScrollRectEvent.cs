using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UI_ScrollRect_ScrollRectEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.UI.ScrollRect.ScrollRectEvent o;
			o=new UnityEngine.UI.ScrollRect.ScrollRectEvent();
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
			UnityEngine.UI.ScrollRect.ScrollRectEvent self=(UnityEngine.UI.ScrollRect.ScrollRectEvent)checkSelf(l);
			UnityEngine.Events.UnityAction<UnityEngine.Vector2> a1;
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
			UnityEngine.UI.ScrollRect.ScrollRectEvent self=(UnityEngine.UI.ScrollRect.ScrollRectEvent)checkSelf(l);
			UnityEngine.Events.UnityAction<UnityEngine.Vector2> a1;
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
			UnityEngine.UI.ScrollRect.ScrollRectEvent self=(UnityEngine.UI.ScrollRect.ScrollRectEvent)checkSelf(l);
			UnityEngine.Vector2 a1;
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
			UnityEngine.UI.ScrollRect.ScrollRectEvent self=(UnityEngine.UI.ScrollRect.ScrollRectEvent)checkSelf(l);
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
			UnityEngine.UI.ScrollRect.ScrollRectEvent self=(UnityEngine.UI.ScrollRect.ScrollRectEvent)checkSelf(l);
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
			UnityEngine.UI.ScrollRect.ScrollRectEvent self=(UnityEngine.UI.ScrollRect.ScrollRectEvent)checkSelf(l);
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
			UnityEngine.UI.ScrollRect.ScrollRectEvent self=(UnityEngine.UI.ScrollRect.ScrollRectEvent)checkSelf(l);
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
			UnityEngine.UI.ScrollRect.ScrollRectEvent self=(UnityEngine.UI.ScrollRect.ScrollRectEvent)checkSelf(l);
			self.RemoveAllListeners();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static new public int ToString(IntPtr l) {
		try {
			UnityEngine.UI.ScrollRect.ScrollRectEvent self=(UnityEngine.UI.ScrollRect.ScrollRectEvent)checkSelf(l);
			var ret=self.ToString();
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
	static new public int Equals(IntPtr l) {
		try {
			UnityEngine.UI.ScrollRect.ScrollRectEvent self=(UnityEngine.UI.ScrollRect.ScrollRectEvent)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Equals(a1);
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
		LuaUnityEvent_UnityEngine_Vector2.reg(l);
		getTypeTable(l,"UnityEngine.UI.ScrollRect.ScrollRectEvent");
		addMember(l,ctor_s);
		addMember(l,AddListener);
		addMember(l,RemoveListener);
		addMember(l,Invoke);
		addMember(l,GetPersistentEventCount);
		addMember(l,GetPersistentTarget);
		addMember(l,GetPersistentMethodName);
		addMember(l,SetPersistentListenerState);
		addMember(l,RemoveAllListeners);
		addMember(l,ToString);
		addMember(l,Equals);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.ScrollRect.ScrollRectEvent),typeof(LuaUnityEvent_UnityEngine_Vector2));
	}
}
