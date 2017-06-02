using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AssetBundleCreateRequest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AssetBundleCreateRequest o;
			o=new UnityEngine.AssetBundleCreateRequest();
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
	static public int get_assetBundle(IntPtr l) {
		try {
			UnityEngine.AssetBundleCreateRequest self=(UnityEngine.AssetBundleCreateRequest)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.assetBundle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AssetBundleCreateRequest");
		addMember(l,"assetBundle",get_assetBundle,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AssetBundleCreateRequest),typeof(UnityEngine.AsyncOperation));
	}
}
