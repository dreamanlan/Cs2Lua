using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UI_Outline : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ModifyMesh(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "ModifyMesh__VertexHelper", argc, 2,typeof(UnityEngine.UI.VertexHelper))){
				UnityEngine.UI.Outline self=(UnityEngine.UI.Outline)checkSelf(l);
				UnityEngine.UI.VertexHelper a1;
				checkType(l,3,out a1);
				self.ModifyMesh(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "ModifyMesh__Mesh", argc, 2,typeof(UnityEngine.Mesh))){
				UnityEngine.UI.Outline self=(UnityEngine.UI.Outline)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,3,out a1);
				self.ModifyMesh(a1);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Outline");
		addMember(l,ModifyMesh);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.Outline),typeof(UnityEngine.UI.Shadow));
	}
}
