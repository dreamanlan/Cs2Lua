using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_SceneManagement_CreateSceneParameters : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.SceneManagement.CreateSceneParameters o;
			o=new UnityEngine.SceneManagement.CreateSceneParameters();
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
	static public int ctor__LocalPhysicsMode_s(IntPtr l) {
		try {
			UnityEngine.SceneManagement.CreateSceneParameters o;
			UnityEngine.SceneManagement.LocalPhysicsMode a1;
			checkEnum(l,1,out a1);
			o=new UnityEngine.SceneManagement.CreateSceneParameters(a1);
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
	static public int get_localPhysicsMode(IntPtr l) {
		try {
			UnityEngine.SceneManagement.CreateSceneParameters self;
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
			UnityEngine.SceneManagement.CreateSceneParameters self;
			checkValueType(l,1,out self);
			UnityEngine.SceneManagement.LocalPhysicsMode v;
			checkEnum(l,2,out v);
			self.localPhysicsMode=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SceneManagement.CreateSceneParameters");
		addMember(l,ctor_s);
		addMember(l,ctor__LocalPhysicsMode_s);
		addMember(l,"localPhysicsMode",get_localPhysicsMode,set_localPhysicsMode,true);
		createTypeMetatable(l,null, typeof(UnityEngine.SceneManagement.CreateSceneParameters),typeof(System.ValueType));
	}
}
