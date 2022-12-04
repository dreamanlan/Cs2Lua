using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Animations_AnimationScriptPlayable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Animations.AnimationScriptPlayable o;
			o=new UnityEngine.Animations.AnimationScriptPlayable();
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
			UnityEngine.Animations.AnimationScriptPlayable self;
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
	static public int Equals__AnimationScriptPlayable(IntPtr l) {
		try {
			UnityEngine.Animations.AnimationScriptPlayable self;
			checkValueType(l,1,out self);
			UnityEngine.Animations.AnimationScriptPlayable a1;
			checkValueType(l,2,out a1);
			var ret=self.Equals(a1);
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
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.Animations.AnimationScriptPlayable self;
			checkValueType(l,1,out self);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Equals(a1);
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
			UnityEngine.Animations.AnimationScriptPlayable self;
			checkValueType(l,1,out self);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.SetProcessInputs(a1);
			pushValue(l,true);
			setBack(l,(object)self);
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
			UnityEngine.Animations.AnimationScriptPlayable self;
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
	static public int op_Implicit_s(IntPtr l) {
		try {
			UnityEngine.Animations.AnimationScriptPlayable a1;
			checkValueType(l,1,out a1);
			UnityEngine.Playables.Playable ret=a1;
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
	static public int op_Explicit_s(IntPtr l) {
		try {
			UnityEngine.Playables.Playable a1;
			checkValueType(l,1,out a1);
			var ret=(UnityEngine.Animations.AnimationScriptPlayable)a1;
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
			pushValue(l,UnityEngine.Animations.AnimationScriptPlayable.Null);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Animations.AnimationScriptPlayable");
		addMember(l,ctor_s);
		addMember(l,GetHandle);
		addMember(l,Equals__AnimationScriptPlayable);
		addMember(l,Equals__Object);
		addMember(l,SetProcessInputs);
		addMember(l,GetProcessInputs);
		addMember(l,op_Implicit_s);
		addMember(l,op_Explicit_s);
		addMember(l,"Null",get_Null,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Animations.AnimationScriptPlayable),typeof(System.ValueType));
	}
}
