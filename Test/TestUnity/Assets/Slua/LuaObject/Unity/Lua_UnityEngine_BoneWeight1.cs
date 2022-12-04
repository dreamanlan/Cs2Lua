using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_BoneWeight1 : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.BoneWeight1 o;
			o=new UnityEngine.BoneWeight1();
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
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.BoneWeight1 self;
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
	static public int Equals__BoneWeight1(IntPtr l) {
		try {
			UnityEngine.BoneWeight1 self;
			checkValueType(l,1,out self);
			UnityEngine.BoneWeight1 a1;
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
	static public int op_Equality_s(IntPtr l) {
		try {
			UnityEngine.BoneWeight1 a1;
			checkValueType(l,1,out a1);
			UnityEngine.BoneWeight1 a2;
			checkValueType(l,2,out a2);
			var ret=(a1==a2);
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
	static public int op_Inequality_s(IntPtr l) {
		try {
			UnityEngine.BoneWeight1 a1;
			checkValueType(l,1,out a1);
			UnityEngine.BoneWeight1 a2;
			checkValueType(l,2,out a2);
			var ret=(a1!=a2);
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
	static public int get_weight(IntPtr l) {
		try {
			UnityEngine.BoneWeight1 self;
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
			UnityEngine.BoneWeight1 self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.weight=v;
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
	static public int get_boneIndex(IntPtr l) {
		try {
			UnityEngine.BoneWeight1 self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.boneIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_boneIndex(IntPtr l) {
		try {
			UnityEngine.BoneWeight1 self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.boneIndex=v;
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
		getTypeTable(l,"UnityEngine.BoneWeight1");
		addMember(l,ctor_s);
		addMember(l,Equals__Object);
		addMember(l,Equals__BoneWeight1);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"weight",get_weight,set_weight,true);
		addMember(l,"boneIndex",get_boneIndex,set_boneIndex,true);
		createTypeMetatable(l,null, typeof(UnityEngine.BoneWeight1),typeof(System.ValueType));
	}
}
