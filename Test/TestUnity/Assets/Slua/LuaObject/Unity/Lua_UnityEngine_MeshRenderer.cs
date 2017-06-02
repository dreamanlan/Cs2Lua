using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_MeshRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_additionalVertexStreams(IntPtr l) {
		try {
			UnityEngine.MeshRenderer self=(UnityEngine.MeshRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.additionalVertexStreams);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_additionalVertexStreams(IntPtr l) {
		try {
			UnityEngine.MeshRenderer self=(UnityEngine.MeshRenderer)checkSelf(l);
			UnityEngine.Mesh v;
			checkType(l,2,out v);
			self.additionalVertexStreams=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MeshRenderer");
		addMember(l,"additionalVertexStreams",get_additionalVertexStreams,set_additionalVertexStreams,true);
		createTypeMetatable(l,null, typeof(UnityEngine.MeshRenderer),typeof(UnityEngine.Renderer));
	}
}
