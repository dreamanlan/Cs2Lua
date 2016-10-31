using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ImageEffectTransformsToLDR : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ImageEffectTransformsToLDR o;
			o=new UnityEngine.ImageEffectTransformsToLDR();
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
			UnityEngine.ImageEffectTransformsToLDR self=(UnityEngine.ImageEffectTransformsToLDR)checkSelf(l);
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
			UnityEngine.ImageEffectTransformsToLDR self=(UnityEngine.ImageEffectTransformsToLDR)checkSelf(l);
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
		getTypeTable(l,"UnityEngine.ImageEffectTransformsToLDR");
		addMember(l,IsDefaultAttribute);
		addMember(l,Match);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ImageEffectTransformsToLDR),typeof(System.Attribute));
	}
}
