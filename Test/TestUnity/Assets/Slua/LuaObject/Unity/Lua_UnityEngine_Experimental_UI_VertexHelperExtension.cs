using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_UI_VertexHelperExtension : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddVert_s(IntPtr l) {
		try {
			UnityEngine.UI.VertexHelper a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Color32 a3;
			checkValueType(l,3,out a3);
			UnityEngine.Vector2 a4;
			checkType(l,4,out a4);
			UnityEngine.Vector2 a5;
			checkType(l,5,out a5);
			UnityEngine.Vector2 a6;
			checkType(l,6,out a6);
			UnityEngine.Vector2 a7;
			checkType(l,7,out a7);
			UnityEngine.Vector3 a8;
			checkType(l,8,out a8);
			UnityEngine.Vector4 a9;
			checkType(l,9,out a9);
			UnityEngine.Experimental.UI.VertexHelperExtension.AddVert(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.UI.VertexHelperExtension");
		addMember(l,AddVert_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.UI.VertexHelperExtension));
	}
}
