﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ImageEffectTransformsToLDR : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ImageEffectTransformsToLDR");
		addMember(l,ctor_s);
		createTypeMetatable(l,null, typeof(UnityEngine.ImageEffectTransformsToLDR),typeof(System.Attribute));
	}
}
