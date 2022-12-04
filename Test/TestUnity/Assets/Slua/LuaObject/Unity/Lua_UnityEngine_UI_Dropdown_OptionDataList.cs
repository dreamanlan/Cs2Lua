using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UI_Dropdown_OptionDataList : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.UI.Dropdown.OptionDataList o;
			o=new UnityEngine.UI.Dropdown.OptionDataList();
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
		getTypeTable(l,"UnityEngine.UI.Dropdown.OptionDataList");
		addMember(l,ctor_s);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.Dropdown.OptionDataList));
	}
}
