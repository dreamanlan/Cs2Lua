using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_DrivenRectTransformTracker : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.DrivenRectTransformTracker o;
			o=new UnityEngine.DrivenRectTransformTracker();
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
	static public int Add(IntPtr l) {
		try {
			UnityEngine.DrivenRectTransformTracker self;
			checkValueType(l,1,out self);
			UnityEngine.Object a1;
			checkType(l,2,out a1);
			UnityEngine.RectTransform a2;
			checkType(l,3,out a2);
			UnityEngine.DrivenTransformProperties a3;
			checkEnum(l,4,out a3);
			self.Add(a1,a2,a3);
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
	static public int Clear(IntPtr l) {
		try {
			UnityEngine.DrivenRectTransformTracker self;
			checkValueType(l,1,out self);
			self.Clear();
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
		getTypeTable(l,"UnityEngine.DrivenRectTransformTracker");
		addMember(l,Add);
		addMember(l,Clear);
		createTypeMetatable(l,constructor, typeof(UnityEngine.DrivenRectTransformTracker),typeof(System.ValueType));
	}
}
