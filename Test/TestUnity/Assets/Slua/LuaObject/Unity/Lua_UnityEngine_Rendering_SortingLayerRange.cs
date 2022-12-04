using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_SortingLayerRange : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingLayerRange o;
			o=new UnityEngine.Rendering.SortingLayerRange();
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
	static public int ctor__Int16__Int16_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingLayerRange o;
			System.Int16 a1;
			checkType(l,1,out a1);
			System.Int16 a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Rendering.SortingLayerRange(a1,a2);
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
	static public int Equals__SortingLayerRange(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingLayerRange self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.SortingLayerRange a1;
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
			UnityEngine.Rendering.SortingLayerRange self;
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
	static public int op_Inequality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingLayerRange a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.SortingLayerRange a2;
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
	static public int op_Equality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingLayerRange a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.SortingLayerRange a2;
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
	static public int get_lowerBound(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingLayerRange self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lowerBound);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lowerBound(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingLayerRange self;
			checkValueType(l,1,out self);
			System.Int16 v;
			checkType(l,2,out v);
			self.lowerBound=v;
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
	static public int get_upperBound(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingLayerRange self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.upperBound);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_upperBound(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingLayerRange self;
			checkValueType(l,1,out self);
			System.Int16 v;
			checkType(l,2,out v);
			self.upperBound=v;
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
	static public int get_all(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.SortingLayerRange.all);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.SortingLayerRange");
		addMember(l,ctor_s);
		addMember(l,ctor__Int16__Int16_s);
		addMember(l,Equals__SortingLayerRange);
		addMember(l,Equals__Object);
		addMember(l,op_Inequality_s);
		addMember(l,op_Equality_s);
		addMember(l,"lowerBound",get_lowerBound,set_lowerBound,true);
		addMember(l,"upperBound",get_upperBound,set_upperBound,true);
		addMember(l,"all",get_all,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.SortingLayerRange),typeof(System.ValueType));
	}
}
