using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UI_Button_ButtonClickedEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.UI.Button.ButtonClickedEvent o;
			o=new UnityEngine.UI.Button.ButtonClickedEvent();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Button.ButtonClickedEvent");
		addMember(l,ctor_s);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.Button.ButtonClickedEvent),typeof(UnityEngine.Events.UnityEvent));
	}
}
