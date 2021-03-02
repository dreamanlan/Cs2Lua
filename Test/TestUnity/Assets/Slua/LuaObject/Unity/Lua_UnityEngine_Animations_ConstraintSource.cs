using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Animations_ConstraintSource : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Animations.ConstraintSource o;
			o=new UnityEngine.Animations.ConstraintSource();
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
	static public int get_sourceTransform(IntPtr l) {
		try {
			UnityEngine.Animations.ConstraintSource self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sourceTransform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sourceTransform(IntPtr l) {
		try {
			UnityEngine.Animations.ConstraintSource self;
			checkValueType(l,1,out self);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.sourceTransform=v;
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
	static public int get_weight(IntPtr l) {
		try {
			UnityEngine.Animations.ConstraintSource self;
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
			UnityEngine.Animations.ConstraintSource self;
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Animations.ConstraintSource");
		addMember(l,ctor_s);
		addMember(l,"sourceTransform",get_sourceTransform,set_sourceTransform,true);
		addMember(l,"weight",get_weight,set_weight,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Animations.ConstraintSource),typeof(System.ValueType));
	}
}
