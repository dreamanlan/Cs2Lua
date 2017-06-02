using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AssetBundleRequest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AssetBundleRequest o;
			o=new UnityEngine.AssetBundleRequest();
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
	static public int get_asset(IntPtr l) {
		try {
			UnityEngine.AssetBundleRequest self=(UnityEngine.AssetBundleRequest)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_allAssets(IntPtr l) {
		try {
			UnityEngine.AssetBundleRequest self=(UnityEngine.AssetBundleRequest)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.allAssets);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AssetBundleRequest");
		addMember(l,"asset",get_asset,null,true);
		addMember(l,"allAssets",get_allAssets,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AssetBundleRequest),typeof(UnityEngine.AsyncOperation));
	}
}
