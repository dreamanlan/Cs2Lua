using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_BaseEventData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.EventSystems.BaseEventData o;
			UnityEngine.EventSystems.EventSystem a1;
			checkType(l,2,out a1);
			o=new UnityEngine.EventSystems.BaseEventData(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentInputModule(IntPtr l) {
		try {
			UnityEngine.EventSystems.BaseEventData self=(UnityEngine.EventSystems.BaseEventData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currentInputModule);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectedObject(IntPtr l) {
		try {
			UnityEngine.EventSystems.BaseEventData self=(UnityEngine.EventSystems.BaseEventData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.selectedObject);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectedObject(IntPtr l) {
		try {
			UnityEngine.EventSystems.BaseEventData self=(UnityEngine.EventSystems.BaseEventData)checkSelf(l);
			UnityEngine.GameObject v;
			checkType(l,2,out v);
			self.selectedObject=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.BaseEventData");
		addMember(l,"currentInputModule",get_currentInputModule,null,true);
		addMember(l,"selectedObject",get_selectedObject,set_selectedObject,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.BaseEventData),typeof(UnityEngine.EventSystems.AbstractEventData));
	}
}
