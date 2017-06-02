using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AssetBundle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AssetBundle o;
			o=new UnityEngine.AssetBundle();
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
	static public int Contains(IntPtr l) {
		try {
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Contains(a1);
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
	static public int LoadAsset(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string))){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.LoadAsset<UnityEngine.Object>(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.LoadAsset(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Type a2;
				checkType(l,3,out a2);
				var ret=self.LoadAsset(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadAssetAsync(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.LoadAssetAsync(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Type a2;
				checkType(l,3,out a2);
				var ret=self.LoadAssetAsync(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadAssetWithSubAssets(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string))){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.LoadAssetWithSubAssets<UnityEngine.Object>(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.LoadAssetWithSubAssets(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Type a2;
				checkType(l,3,out a2);
				var ret=self.LoadAssetWithSubAssets(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadAssetWithSubAssetsAsync(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.LoadAssetWithSubAssetsAsync(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Type a2;
				checkType(l,3,out a2);
				var ret=self.LoadAssetWithSubAssetsAsync(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadAllAssets(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2)){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				var ret=self.LoadAllAssets<UnityEngine.Object>();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2)){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				var ret=self.LoadAllAssets();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.LoadAllAssets(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadAllAssetsAsync(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				var ret=self.LoadAllAssetsAsync();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.LoadAllAssetsAsync(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Unload(IntPtr l) {
		try {
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Unload(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetAllAssetNames(IntPtr l) {
		try {
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			var ret=self.GetAllAssetNames();
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
	static public int GetAllScenePaths(IntPtr l) {
		try {
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			var ret=self.GetAllScenePaths();
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
	static public int LoadFromFileAsync_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.AssetBundle.LoadFromFileAsync(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.UInt32 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.AssetBundle.LoadFromFileAsync(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String a1;
				checkType(l,1,out a1);
				System.UInt32 a2;
				checkType(l,2,out a2);
				System.UInt64 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.AssetBundle.LoadFromFileAsync(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadFromFile_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.AssetBundle.LoadFromFile(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.UInt32 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.AssetBundle.LoadFromFile(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String a1;
				checkType(l,1,out a1);
				System.UInt32 a2;
				checkType(l,2,out a2);
				System.UInt64 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.AssetBundle.LoadFromFile(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadFromMemoryAsync_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Byte[] a1;
				checkArray(l,1,out a1);
				var ret=UnityEngine.AssetBundle.LoadFromMemoryAsync(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Byte[] a1;
				checkArray(l,1,out a1);
				System.UInt32 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.AssetBundle.LoadFromMemoryAsync(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadFromMemory_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Byte[] a1;
				checkArray(l,1,out a1);
				var ret=UnityEngine.AssetBundle.LoadFromMemory(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Byte[] a1;
				checkArray(l,1,out a1);
				System.UInt32 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.AssetBundle.LoadFromMemory(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mainAsset(IntPtr l) {
		try {
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mainAsset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isStreamedSceneAssetBundle(IntPtr l) {
		try {
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isStreamedSceneAssetBundle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AssetBundle");
		addMember(l,Contains);
		addMember(l,LoadAsset);
		addMember(l,LoadAssetAsync);
		addMember(l,LoadAssetWithSubAssets);
		addMember(l,LoadAssetWithSubAssetsAsync);
		addMember(l,LoadAllAssets);
		addMember(l,LoadAllAssetsAsync);
		addMember(l,Unload);
		addMember(l,GetAllAssetNames);
		addMember(l,GetAllScenePaths);
		addMember(l,LoadFromFileAsync_s);
		addMember(l,LoadFromFile_s);
		addMember(l,LoadFromMemoryAsync_s);
		addMember(l,LoadFromMemory_s);
		addMember(l,"mainAsset",get_mainAsset,null,true);
		addMember(l,"isStreamedSceneAssetBundle",get_isStreamedSceneAssetBundle,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AssetBundle),typeof(UnityEngine.Object));
	}
}
