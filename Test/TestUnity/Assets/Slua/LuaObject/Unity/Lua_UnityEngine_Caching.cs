using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Caching : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Caching o;
			o=new UnityEngine.Caching();
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
	static public int ClearCache_s(IntPtr l) {
		try {
			var ret=UnityEngine.Caching.ClearCache();
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
	static public int ClearCache__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Caching.ClearCache(a1);
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
	static public int ClearCachedVersion_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Hash128 a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.Caching.ClearCachedVersion(a1,a2);
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
	static public int ClearOtherCachedVersions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Hash128 a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.Caching.ClearOtherCachedVersions(a1,a2);
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
	static public int ClearAllCachedVersions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Caching.ClearAllCachedVersions(a1);
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
	static public int IsVersionCached__CachedAssetBundle_s(IntPtr l) {
		try {
			UnityEngine.CachedAssetBundle a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.Caching.IsVersionCached(a1);
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
	static public int IsVersionCached__String__Hash128_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Hash128 a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.Caching.IsVersionCached(a1,a2);
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
	static public int MarkAsUsed__CachedAssetBundle_s(IntPtr l) {
		try {
			UnityEngine.CachedAssetBundle a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.Caching.MarkAsUsed(a1);
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
	static public int MarkAsUsed__String__Hash128_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Hash128 a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.Caching.MarkAsUsed(a1,a2);
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
	static public int AddCache_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Caching.AddCache(a1);
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
	static public int GetCacheAt_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Caching.GetCacheAt(a1);
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
	static public int GetCacheByPath_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Caching.GetCacheByPath(a1);
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
	static public int RemoveCache_s(IntPtr l) {
		try {
			UnityEngine.Cache a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.Caching.RemoveCache(a1);
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
	static public int MoveCacheBefore_s(IntPtr l) {
		try {
			UnityEngine.Cache a1;
			checkValueType(l,1,out a1);
			UnityEngine.Cache a2;
			checkValueType(l,2,out a2);
			UnityEngine.Caching.MoveCacheBefore(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int MoveCacheAfter_s(IntPtr l) {
		try {
			UnityEngine.Cache a1;
			checkValueType(l,1,out a1);
			UnityEngine.Cache a2;
			checkValueType(l,2,out a2);
			UnityEngine.Caching.MoveCacheAfter(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_compressionEnabled(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Caching.compressionEnabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_compressionEnabled(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Caching.compressionEnabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ready(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Caching.ready);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cacheCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Caching.cacheCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultCache(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Caching.defaultCache);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_currentCacheForWriting(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Caching.currentCacheForWriting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_currentCacheForWriting(IntPtr l) {
		try {
			UnityEngine.Cache v;
			checkValueType(l,2,out v);
			UnityEngine.Caching.currentCacheForWriting=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Caching");
		addMember(l,ctor_s);
		addMember(l,ClearCache_s);
		addMember(l,ClearCache__Int32_s);
		addMember(l,ClearCachedVersion_s);
		addMember(l,ClearOtherCachedVersions_s);
		addMember(l,ClearAllCachedVersions_s);
		addMember(l,IsVersionCached__CachedAssetBundle_s);
		addMember(l,IsVersionCached__String__Hash128_s);
		addMember(l,MarkAsUsed__CachedAssetBundle_s);
		addMember(l,MarkAsUsed__String__Hash128_s);
		addMember(l,AddCache_s);
		addMember(l,GetCacheAt_s);
		addMember(l,GetCacheByPath_s);
		addMember(l,RemoveCache_s);
		addMember(l,MoveCacheBefore_s);
		addMember(l,MoveCacheAfter_s);
		addMember(l,"compressionEnabled",get_compressionEnabled,set_compressionEnabled,false);
		addMember(l,"ready",get_ready,null,false);
		addMember(l,"cacheCount",get_cacheCount,null,false);
		addMember(l,"defaultCache",get_defaultCache,null,false);
		addMember(l,"currentCacheForWriting",get_currentCacheForWriting,set_currentCacheForWriting,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Caching));
	}
}
