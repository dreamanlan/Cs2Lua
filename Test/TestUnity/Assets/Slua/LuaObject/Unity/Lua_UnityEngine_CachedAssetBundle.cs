using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_CachedAssetBundle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.CachedAssetBundle o;
			o=new UnityEngine.CachedAssetBundle();
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
	static public int ctor__String__Hash128_s(IntPtr l) {
		try {
			UnityEngine.CachedAssetBundle o;
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Hash128 a2;
			checkValueType(l,2,out a2);
			o=new UnityEngine.CachedAssetBundle(a1,a2);
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
	static public int get_name(IntPtr l) {
		try {
			UnityEngine.CachedAssetBundle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_name(IntPtr l) {
		try {
			UnityEngine.CachedAssetBundle self;
			checkValueType(l,1,out self);
			string v;
			checkType(l,2,out v);
			self.name=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hash(IntPtr l) {
		try {
			UnityEngine.CachedAssetBundle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.hash);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_hash(IntPtr l) {
		try {
			UnityEngine.CachedAssetBundle self;
			checkValueType(l,1,out self);
			UnityEngine.Hash128 v;
			checkValueType(l,2,out v);
			self.hash=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CachedAssetBundle");
		addMember(l,ctor_s);
		addMember(l,ctor__String__Hash128_s);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"hash",get_hash,set_hash,true);
		createTypeMetatable(l,null, typeof(UnityEngine.CachedAssetBundle),typeof(System.ValueType));
	}
}
