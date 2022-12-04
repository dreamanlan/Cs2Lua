using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RendererUtils_RendererList : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererList o;
			o=new UnityEngine.Rendering.RendererUtils.RendererList();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_nullRendererList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.RendererUtils.RendererList.nullRendererList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isValid(IntPtr l) {
		try {
			UnityEngine.Rendering.RendererUtils.RendererList self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.isValid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.RendererUtils.RendererList");
		addMember(l,ctor_s);
		addMember(l,"nullRendererList",get_nullRendererList,null,false);
		addMember(l,"isValid",get_isValid,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.RendererUtils.RendererList),typeof(System.ValueType));
	}
}
