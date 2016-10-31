using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_ExecuteEvents : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.ExecuteEvents");
		addMember(l,"pointerEnterHandler",null,null,true);
		addMember(l,"pointerExitHandler",null,null,true);
		addMember(l,"pointerDownHandler",null,null,true);
		addMember(l,"pointerUpHandler",null,null,true);
		addMember(l,"pointerClickHandler",null,null,true);
		addMember(l,"initializePotentialDrag",null,null,true);
		addMember(l,"beginDragHandler",null,null,true);
		addMember(l,"dragHandler",null,null,true);
		addMember(l,"endDragHandler",null,null,true);
		addMember(l,"dropHandler",null,null,true);
		addMember(l,"scrollHandler",null,null,true);
		addMember(l,"updateSelectedHandler",null,null,true);
		addMember(l,"selectHandler",null,null,true);
		addMember(l,"deselectHandler",null,null,true);
		addMember(l,"moveHandler",null,null,true);
		addMember(l,"submitHandler",null,null,true);
		addMember(l,"cancelHandler",null,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.ExecuteEvents));
	}
}
