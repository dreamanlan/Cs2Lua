using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Animations_AnimationScriptPlayable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.AnimationScriptPlayable o;
			o=new UnityEngine.Experimental.Animations.AnimationScriptPlayable();
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
	static public int GetHandle(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.AnimationScriptPlayable self;
			checkValueType(l,1,out self);
			var ret=self.GetHandle();
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
	static public int SetProcessInputs(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.AnimationScriptPlayable self;
			checkValueType(l,1,out self);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.SetProcessInputs(a1);
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
	static public int GetProcessInputs(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.AnimationScriptPlayable self;
			checkValueType(l,1,out self);
			var ret=self.GetProcessInputs();
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
	static public int get_Null(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.Animations.AnimationScriptPlayable.Null);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Animations.AnimationScriptPlayable");
		addMember(l,GetHandle);
		addMember(l,SetProcessInputs);
		addMember(l,GetProcessInputs);
		addMember(l,"Null",get_Null,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Animations.AnimationScriptPlayable),typeof(System.ValueType));
	}
}
