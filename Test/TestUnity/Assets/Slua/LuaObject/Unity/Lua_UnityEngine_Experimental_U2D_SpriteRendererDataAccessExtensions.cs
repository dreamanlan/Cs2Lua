using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_U2D_SpriteRendererDataAccessExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetDeformableVertices_s(IntPtr l) {
		try {
			UnityEngine.SpriteRenderer a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Experimental.U2D.SpriteRendererDataAccessExtensions.GetDeformableVertices(a1);
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
	static public int DeactivateDeformableBuffer_s(IntPtr l) {
		try {
			UnityEngine.SpriteRenderer a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.U2D.SpriteRendererDataAccessExtensions.DeactivateDeformableBuffer(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateDeformableBuffer_s(IntPtr l) {
		try {
			UnityEngine.SpriteRenderer a1;
			checkType(l,1,out a1);
			Unity.Jobs.JobHandle a2;
			checkValueType(l,2,out a2);
			UnityEngine.Experimental.U2D.SpriteRendererDataAccessExtensions.UpdateDeformableBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.U2D.SpriteRendererDataAccessExtensions");
		addMember(l,GetDeformableVertices_s);
		addMember(l,DeactivateDeformableBuffer_s);
		addMember(l,UpdateDeformableBuffer_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.U2D.SpriteRendererDataAccessExtensions));
	}
}
