using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Playables_MaterialEffectPlayable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Playables.MaterialEffectPlayable o;
			o=new UnityEngine.Experimental.Playables.MaterialEffectPlayable();
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
			UnityEngine.Experimental.Playables.MaterialEffectPlayable self;
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
	static public int Equals__MaterialEffectPlayable(IntPtr l) {
		try {
			UnityEngine.Experimental.Playables.MaterialEffectPlayable self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Playables.MaterialEffectPlayable a1;
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
			UnityEngine.Experimental.Playables.MaterialEffectPlayable self;
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
	static public int GetMaterial(IntPtr l) {
		try {
			UnityEngine.Experimental.Playables.MaterialEffectPlayable self;
			checkValueType(l,1,out self);
			var ret=self.GetMaterial();
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
	static public int SetMaterial(IntPtr l) {
		try {
			UnityEngine.Experimental.Playables.MaterialEffectPlayable self;
			checkValueType(l,1,out self);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			self.SetMaterial(a1);
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
	static public int GetPass(IntPtr l) {
		try {
			UnityEngine.Experimental.Playables.MaterialEffectPlayable self;
			checkValueType(l,1,out self);
			var ret=self.GetPass();
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
	static public int SetPass(IntPtr l) {
		try {
			UnityEngine.Experimental.Playables.MaterialEffectPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.SetPass(a1);
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
	static public int Create_s(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableGraph a1;
			checkValueType(l,1,out a1);
			UnityEngine.Material a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Experimental.Playables.MaterialEffectPlayable.Create(a1,a2,a3);
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
			UnityEngine.Experimental.Playables.MaterialEffectPlayable a1;
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
			var ret=(UnityEngine.Experimental.Playables.MaterialEffectPlayable)a1;
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
		getTypeTable(l,"UnityEngine.Experimental.Playables.MaterialEffectPlayable");
		addMember(l,ctor_s);
		addMember(l,GetHandle);
		addMember(l,Equals__MaterialEffectPlayable);
		addMember(l,Equals__Object);
		addMember(l,GetMaterial);
		addMember(l,SetMaterial);
		addMember(l,GetPass);
		addMember(l,SetPass);
		addMember(l,Create_s);
		addMember(l,op_Implicit_s);
		addMember(l,op_Explicit_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Playables.MaterialEffectPlayable),typeof(System.ValueType));
	}
}
