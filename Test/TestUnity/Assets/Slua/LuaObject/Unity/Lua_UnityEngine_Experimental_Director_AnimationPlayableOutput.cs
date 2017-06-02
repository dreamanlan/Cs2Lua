using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Director_AnimationPlayableOutput : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationPlayableOutput o;
			o=new UnityEngine.Experimental.Director.AnimationPlayableOutput();
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
			UnityEngine.Experimental.Director.AnimationPlayableOutput self;
			checkValueType(l,1,out self);
			var ret=self.IsValid();
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
			pushValue(l,UnityEngine.Experimental.Director.AnimationPlayableOutput.Null);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_userData(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationPlayableOutput self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.userData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_userData(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationPlayableOutput self;
			checkValueType(l,1,out self);
			UnityEngine.Object v;
			checkType(l,2,out v);
			self.userData=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_target(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationPlayableOutput self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.target);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_target(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationPlayableOutput self;
			checkValueType(l,1,out self);
			UnityEngine.Animator v;
			checkType(l,2,out v);
			self.target=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_weight(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationPlayableOutput self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.weight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_weight(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationPlayableOutput self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.weight=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sourcePlayable(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationPlayableOutput self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sourcePlayable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sourcePlayable(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.AnimationPlayableOutput self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Director.PlayableHandle v;
			checkValueType(l,2,out v);
			self.sourcePlayable=v;
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
		getTypeTable(l,"UnityEngine.Experimental.Director.AnimationPlayableOutput");
		addMember(l,IsValid);
		addMember(l,"Null",get_Null,null,false);
		addMember(l,"userData",get_userData,set_userData,true);
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"weight",get_weight,set_weight,true);
		addMember(l,"sourcePlayable",get_sourcePlayable,set_sourcePlayable,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Director.AnimationPlayableOutput),typeof(System.ValueType));
	}
}
