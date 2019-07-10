using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Animations_TransformStreamHandle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.TransformStreamHandle o;
			o=new UnityEngine.Experimental.Animations.TransformStreamHandle();
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
			UnityEngine.Experimental.Animations.TransformStreamHandle self;
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
			UnityEngine.Experimental.Animations.TransformStreamHandle self;
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
			UnityEngine.Experimental.Animations.TransformStreamHandle self;
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
	static public int GetPosition(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.TransformStreamHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			var ret=self.GetPosition(a1);
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
	static public int SetPosition(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.TransformStreamHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.SetPosition(a1,a2);
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
	static public int GetRotation(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.TransformStreamHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			var ret=self.GetRotation(a1);
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
	static public int SetRotation(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.TransformStreamHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,3,out a2);
			self.SetRotation(a1,a2);
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
	static public int GetLocalPosition(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.TransformStreamHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			var ret=self.GetLocalPosition(a1);
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
	static public int SetLocalPosition(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.TransformStreamHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.SetLocalPosition(a1,a2);
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
	static public int GetLocalRotation(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.TransformStreamHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			var ret=self.GetLocalRotation(a1);
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
	static public int SetLocalRotation(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.TransformStreamHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,3,out a2);
			self.SetLocalRotation(a1,a2);
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
	static public int GetLocalScale(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.TransformStreamHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			var ret=self.GetLocalScale(a1);
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
	static public int SetLocalScale(IntPtr l) {
		try {
			UnityEngine.Experimental.Animations.TransformStreamHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Animations.AnimationStream a1;
			checkValueType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.SetLocalScale(a1,a2);
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
		getTypeTable(l,"UnityEngine.Experimental.Animations.TransformStreamHandle");
		addMember(l,IsValid);
		addMember(l,Resolve);
		addMember(l,IsResolved);
		addMember(l,GetPosition);
		addMember(l,SetPosition);
		addMember(l,GetRotation);
		addMember(l,SetRotation);
		addMember(l,GetLocalPosition);
		addMember(l,SetLocalPosition);
		addMember(l,GetLocalRotation);
		addMember(l,SetLocalRotation);
		addMember(l,GetLocalScale);
		addMember(l,SetLocalScale);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Animations.TransformStreamHandle),typeof(System.ValueType));
	}
}
