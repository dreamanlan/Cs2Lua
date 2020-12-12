using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UI_BaseMeshEffect : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ModifyMesh__Mesh(IntPtr l) {
		try {
			UnityEngine.UI.BaseMeshEffect self=(UnityEngine.UI.BaseMeshEffect)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			self.ModifyMesh(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ModifyMesh__VertexHelper(IntPtr l) {
		try {
			UnityEngine.UI.BaseMeshEffect self=(UnityEngine.UI.BaseMeshEffect)checkSelf(l);
			UnityEngine.UI.VertexHelper a1;
			checkType(l,2,out a1);
			self.ModifyMesh(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.BaseMeshEffect");
		addMember(l,ModifyMesh__Mesh);
		addMember(l,ModifyMesh__VertexHelper);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.BaseMeshEffect),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
