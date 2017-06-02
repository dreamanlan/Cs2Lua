using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AssetBundleManifest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AssetBundleManifest o;
			o=new UnityEngine.AssetBundleManifest();
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
	static public int GetAllAssetBundles(IntPtr l) {
		try {
			UnityEngine.AssetBundleManifest self=(UnityEngine.AssetBundleManifest)checkSelf(l);
			var ret=self.GetAllAssetBundles();
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
	static public int GetAllAssetBundlesWithVariant(IntPtr l) {
		try {
			UnityEngine.AssetBundleManifest self=(UnityEngine.AssetBundleManifest)checkSelf(l);
			var ret=self.GetAllAssetBundlesWithVariant();
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
	static public int GetAssetBundleHash(IntPtr l) {
		try {
			UnityEngine.AssetBundleManifest self=(UnityEngine.AssetBundleManifest)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetAssetBundleHash(a1);
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
	static public int GetDirectDependencies(IntPtr l) {
		try {
			UnityEngine.AssetBundleManifest self=(UnityEngine.AssetBundleManifest)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetDirectDependencies(a1);
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
	static public int GetAllDependencies(IntPtr l) {
		try {
			UnityEngine.AssetBundleManifest self=(UnityEngine.AssetBundleManifest)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetAllDependencies(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AssetBundleManifest");
		addMember(l,GetAllAssetBundles);
		addMember(l,GetAllAssetBundlesWithVariant);
		addMember(l,GetAssetBundleHash);
		addMember(l,GetDirectDependencies);
		addMember(l,GetAllDependencies);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AssetBundleManifest),typeof(UnityEngine.Object));
	}
}
