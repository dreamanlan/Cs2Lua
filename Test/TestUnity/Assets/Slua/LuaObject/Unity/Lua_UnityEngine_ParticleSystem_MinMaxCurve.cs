using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystem_MinMaxCurve : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve o;
			o=new UnityEngine.ParticleSystem.MinMaxCurve();
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
	static public int ctor__Single_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve o;
			System.Single a1;
			checkType(l,1,out a1);
			o=new UnityEngine.ParticleSystem.MinMaxCurve(a1);
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
	static public int ctor__Single__AnimationCurve_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve o;
			System.Single a1;
			checkType(l,1,out a1);
			UnityEngine.AnimationCurve a2;
			checkType(l,2,out a2);
			o=new UnityEngine.ParticleSystem.MinMaxCurve(a1,a2);
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
	static public int ctor__Single__Single_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve o;
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			o=new UnityEngine.ParticleSystem.MinMaxCurve(a1,a2);
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
	static public int ctor__Single__AnimationCurve__AnimationCurve_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve o;
			System.Single a1;
			checkType(l,1,out a1);
			UnityEngine.AnimationCurve a2;
			checkType(l,2,out a2);
			UnityEngine.AnimationCurve a3;
			checkType(l,3,out a3);
			o=new UnityEngine.ParticleSystem.MinMaxCurve(a1,a2,a3);
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
	static public int Evaluate__Single(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.Evaluate(a1);
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
	static public int Evaluate__Single__Single(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.Evaluate(a1,a2);
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
			System.Single a1;
			checkType(l,1,out a1);
			UnityEngine.ParticleSystem.MinMaxCurve ret=a1;
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
	static public int get_mode(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mode(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystemCurveMode v;
			checkEnum(l,2,out v);
			self.mode=v;
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
	static public int get_curveMultiplier(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.curveMultiplier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_curveMultiplier(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.curveMultiplier=v;
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
	static public int get_curveMax(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.curveMax);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_curveMax(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			UnityEngine.AnimationCurve v;
			checkType(l,2,out v);
			self.curveMax=v;
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
	static public int get_curveMin(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.curveMin);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_curveMin(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			UnityEngine.AnimationCurve v;
			checkType(l,2,out v);
			self.curveMin=v;
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
	static public int get_constantMax(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.constantMax);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_constantMax(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.constantMax=v;
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
	static public int get_constantMin(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.constantMin);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_constantMin(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.constantMin=v;
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
	static public int get_constant(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.constant);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_constant(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.constant=v;
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
	static public int get_curve(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.curve);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_curve(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxCurve self;
			checkValueType(l,1,out self);
			UnityEngine.AnimationCurve v;
			checkType(l,2,out v);
			self.curve=v;
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
		getTypeTable(l,"UnityEngine.ParticleSystem.MinMaxCurve");
		addMember(l,ctor_s);
		addMember(l,ctor__Single_s);
		addMember(l,ctor__Single__AnimationCurve_s);
		addMember(l,ctor__Single__Single_s);
		addMember(l,ctor__Single__AnimationCurve__AnimationCurve_s);
		addMember(l,Evaluate__Single);
		addMember(l,Evaluate__Single__Single);
		addMember(l,op_Implicit_s);
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"curveMultiplier",get_curveMultiplier,set_curveMultiplier,true);
		addMember(l,"curveMax",get_curveMax,set_curveMax,true);
		addMember(l,"curveMin",get_curveMin,set_curveMin,true);
		addMember(l,"constantMax",get_constantMax,set_constantMax,true);
		addMember(l,"constantMin",get_constantMin,set_constantMin,true);
		addMember(l,"constant",get_constant,set_constant,true);
		addMember(l,"curve",get_curve,set_curve,true);
		createTypeMetatable(l,null, typeof(UnityEngine.ParticleSystem.MinMaxCurve),typeof(System.ValueType));
	}
}
