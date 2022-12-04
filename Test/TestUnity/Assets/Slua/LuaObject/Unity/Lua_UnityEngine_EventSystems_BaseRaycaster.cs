using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_EventSystems_BaseRaycaster : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static new public int ToString(IntPtr l) {
		try {
			UnityEngine.EventSystems.BaseRaycaster self=(UnityEngine.EventSystems.BaseRaycaster)checkSelf(l);
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
	static public int get_eventCamera(IntPtr l) {
		try {
			UnityEngine.EventSystems.BaseRaycaster self=(UnityEngine.EventSystems.BaseRaycaster)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.eventCamera);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sortOrderPriority(IntPtr l) {
		try {
			UnityEngine.EventSystems.BaseRaycaster self=(UnityEngine.EventSystems.BaseRaycaster)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sortOrderPriority);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderOrderPriority(IntPtr l) {
		try {
			UnityEngine.EventSystems.BaseRaycaster self=(UnityEngine.EventSystems.BaseRaycaster)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.renderOrderPriority);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rootRaycaster(IntPtr l) {
		try {
			UnityEngine.EventSystems.BaseRaycaster self=(UnityEngine.EventSystems.BaseRaycaster)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rootRaycaster);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.BaseRaycaster");
		addMember(l,ToString);
		addMember(l,"eventCamera",get_eventCamera,null,true);
		addMember(l,"sortOrderPriority",get_sortOrderPriority,null,true);
		addMember(l,"renderOrderPriority",get_renderOrderPriority,null,true);
		addMember(l,"rootRaycaster",get_rootRaycaster,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.BaseRaycaster),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
