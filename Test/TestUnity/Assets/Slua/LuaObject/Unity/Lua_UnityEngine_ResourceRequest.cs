using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ResourceRequest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ResourceRequest o;
			o=new UnityEngine.ResourceRequest();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asset(IntPtr l) {
		try {
			UnityEngine.ResourceRequest self=(UnityEngine.ResourceRequest)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ResourceRequest");
		addMember(l,"asset",get_asset,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ResourceRequest),typeof(UnityEngine.AsyncOperation));
	}
}
