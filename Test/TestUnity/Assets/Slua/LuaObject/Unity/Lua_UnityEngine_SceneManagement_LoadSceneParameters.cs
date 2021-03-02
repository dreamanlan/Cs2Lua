using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_SceneManagement_LoadSceneParameters : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.SceneManagement.LoadSceneParameters o;
			o=new UnityEngine.SceneManagement.LoadSceneParameters();
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
	static public int ctor__LoadSceneMode_s(IntPtr l) {
		try {
			UnityEngine.SceneManagement.LoadSceneParameters o;
			UnityEngine.SceneManagement.LoadSceneMode a1;
			checkEnum(l,1,out a1);
			o=new UnityEngine.SceneManagement.LoadSceneParameters(a1);
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
	static public int ctor__LoadSceneMode__LocalPhysicsMode_s(IntPtr l) {
		try {
			UnityEngine.SceneManagement.LoadSceneParameters o;
			UnityEngine.SceneManagement.LoadSceneMode a1;
			checkEnum(l,1,out a1);
			UnityEngine.SceneManagement.LocalPhysicsMode a2;
			checkEnum(l,2,out a2);
			o=new UnityEngine.SceneManagement.LoadSceneParameters(a1,a2);
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
	static public int get_loadSceneMode(IntPtr l) {
		try {
			UnityEngine.SceneManagement.LoadSceneParameters self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.loadSceneMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_loadSceneMode(IntPtr l) {
		try {
			UnityEngine.SceneManagement.LoadSceneParameters self;
			checkValueType(l,1,out self);
			UnityEngine.SceneManagement.LoadSceneMode v;
			checkEnum(l,2,out v);
			self.loadSceneMode=v;
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
	static public int get_localPhysicsMode(IntPtr l) {
		try {
			UnityEngine.SceneManagement.LoadSceneParameters self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.localPhysicsMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_localPhysicsMode(IntPtr l) {
		try {
			UnityEngine.SceneManagement.LoadSceneParameters self;
			checkValueType(l,1,out self);
			UnityEngine.SceneManagement.LocalPhysicsMode v;
			checkEnum(l,2,out v);
			self.localPhysicsMode=v;
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
		getTypeTable(l,"UnityEngine.SceneManagement.LoadSceneParameters");
		addMember(l,ctor_s);
		addMember(l,ctor__LoadSceneMode_s);
		addMember(l,ctor__LoadSceneMode__LocalPhysicsMode_s);
		addMember(l,"loadSceneMode",get_loadSceneMode,set_loadSceneMode,true);
		addMember(l,"localPhysicsMode",get_localPhysicsMode,set_localPhysicsMode,true);
		createTypeMetatable(l,null, typeof(UnityEngine.SceneManagement.LoadSceneParameters),typeof(System.ValueType));
	}
}
