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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsDefaultAttribute(IntPtr l) {
		try {
			UnityEngine.ImageEffectOpaque self=(UnityEngine.ImageEffectOpaque)checkSelf(l);
			var ret=self.IsDefaultAttribute();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Match(IntPtr l) {
		try {
			UnityEngine.ImageEffectOpaque self=(UnityEngine.ImageEffectOpaque)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Match(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ImageEffectOpaque");
		addMember(l,IsDefaultAttribute);
		addMember(l,Match);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ImageEffectOpaque),typeof(System.Attribute));
	}
}
