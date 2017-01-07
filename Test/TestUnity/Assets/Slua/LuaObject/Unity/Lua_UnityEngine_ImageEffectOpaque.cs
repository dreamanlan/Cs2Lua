using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ImageEffectOpaque : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ImageEffectOpaque o;
			o=new UnityEngine.ImageEffectOpaque();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ImageEffectOpaque");
		createTypeMetatable(l,constructor, typeof(UnityEngine.ImageEffectOpaque),typeof(System.Attribute));
	}
}
