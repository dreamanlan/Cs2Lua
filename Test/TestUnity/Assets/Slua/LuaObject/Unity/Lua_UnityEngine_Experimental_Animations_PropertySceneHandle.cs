using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Animations_PropertySceneHandle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.PropertySceneHandle o;
			o=new UnityEngine.Experimental.Animations.PropertySceneHandle();
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
	static public int IsValid(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.PropertySceneHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			var ret=self.IsValid(a1);
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
	static public int Resolve(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.PropertySceneHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			self.Resolve(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsResolved(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.PropertySceneHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			var ret=self.IsResolved(a1);
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
	static public int GetFloat(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.PropertySceneHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			var ret=self.GetFloat(a1);
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
	static public int SetFloat(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.PropertySceneHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetFloat(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetInt(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.PropertySceneHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			var ret=self.GetInt(a1);
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
	static public int SetInt(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.PropertySceneHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetInt(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBool(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.PropertySceneHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			var ret=self.GetBool(a1);
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
	static public int SetBool(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.PropertySceneHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetBool(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Animations.PropertySceneHandle");
		addMember(l,IsValid);
		addMember(l,Resolve);
		addMember(l,IsResolved);
		addMember(l,GetFloat);
		addMember(l,SetFloat);
		addMember(l,GetInt);
		addMember(l,SetInt);
		addMember(l,GetBool);
		addMember(l,SetBool);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Animations.PropertySceneHandle),typeof(System.ValueType));
	}
}
