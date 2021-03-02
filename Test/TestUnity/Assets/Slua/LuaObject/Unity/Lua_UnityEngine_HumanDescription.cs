﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_HumanDescription : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.HumanDescription o;
			o=new UnityEngine.HumanDescription();
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
	static public int get_human(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.human);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_human(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			UnityEngine.HumanBone[] v;
			checkArray(l,2,out v);
			self.human=v;
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
	static public int get_skeleton(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.skeleton);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_skeleton(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			UnityEngine.SkeletonBone[] v;
			checkArray(l,2,out v);
			self.skeleton=v;
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
	static public int get_upperArmTwist(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.upperArmTwist);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_upperArmTwist(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.upperArmTwist=v;
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
	static public int get_lowerArmTwist(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lowerArmTwist);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lowerArmTwist(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.lowerArmTwist=v;
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
	static public int get_upperLegTwist(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.upperLegTwist);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_upperLegTwist(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.upperLegTwist=v;
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
	static public int get_lowerLegTwist(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lowerLegTwist);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lowerLegTwist(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.lowerLegTwist=v;
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
	static public int get_armStretch(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.armStretch);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_armStretch(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.armStretch=v;
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
	static public int get_legStretch(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.legStretch);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_legStretch(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.legStretch=v;
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
	static public int get_feetSpacing(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.feetSpacing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_feetSpacing(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.feetSpacing=v;
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
	static public int get_hasTranslationDoF(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.hasTranslationDoF);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_hasTranslationDoF(IntPtr l) {
		try {
			UnityEngine.HumanDescription self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.hasTranslationDoF=v;
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
		getTypeTable(l,"UnityEngine.HumanDescription");
		addMember(l,ctor_s);
		addMember(l,"human",get_human,set_human,true);
		addMember(l,"skeleton",get_skeleton,set_skeleton,true);
		addMember(l,"upperArmTwist",get_upperArmTwist,set_upperArmTwist,true);
		addMember(l,"lowerArmTwist",get_lowerArmTwist,set_lowerArmTwist,true);
		addMember(l,"upperLegTwist",get_upperLegTwist,set_upperLegTwist,true);
		addMember(l,"lowerLegTwist",get_lowerLegTwist,set_lowerLegTwist,true);
		addMember(l,"armStretch",get_armStretch,set_armStretch,true);
		addMember(l,"legStretch",get_legStretch,set_legStretch,true);
		addMember(l,"feetSpacing",get_feetSpacing,set_feetSpacing,true);
		addMember(l,"hasTranslationDoF",get_hasTranslationDoF,set_hasTranslationDoF,true);
		createTypeMetatable(l,null, typeof(UnityEngine.HumanDescription),typeof(System.ValueType));
	}
}
