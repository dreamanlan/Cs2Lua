using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_GraphicsFence : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.GraphicsFence o;
			o=new UnityEngine.Rendering.GraphicsFence();
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
	static public int get_passed(IntPtr l) {
		try {
			UnityEngine.Rendering.GraphicsFence self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.passed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.GraphicsFence");
		addMember(l,ctor_s);
		addMember(l,"passed",get_passed,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.GraphicsFence),typeof(System.ValueType));
	}
}
