using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystem_MinMaxGradient : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient o;
			o=new UnityEngine.ParticleSystem.MinMaxGradient();
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
	static public int ctor__Color_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient o;
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			o=new UnityEngine.ParticleSystem.MinMaxGradient(a1);
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
	static public int ctor__Gradient_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient o;
			UnityEngine.Gradient a1;
			checkType(l,1,out a1);
			o=new UnityEngine.ParticleSystem.MinMaxGradient(a1);
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
	static public int ctor__Color__Color_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient o;
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			UnityEngine.Color a2;
			checkType(l,2,out a2);
			o=new UnityEngine.ParticleSystem.MinMaxGradient(a1,a2);
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
	static public int ctor__Gradient__Gradient_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient o;
			UnityEngine.Gradient a1;
			checkType(l,1,out a1);
			UnityEngine.Gradient a2;
			checkType(l,2,out a2);
			o=new UnityEngine.ParticleSystem.MinMaxGradient(a1,a2);
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
			UnityEngine.ParticleSystem.MinMaxGradient self;
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
			UnityEngine.ParticleSystem.MinMaxGradient self;
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
	static public int op_Implicit__MinMaxGradient__Color_s(IntPtr l) {
		try {
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			UnityEngine.ParticleSystem.MinMaxGradient ret=a1;
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
	static public int op_Implicit__MinMaxGradient__Gradient_s(IntPtr l) {
		try {
			UnityEngine.Gradient a1;
			checkType(l,1,out a1);
			UnityEngine.ParticleSystem.MinMaxGradient ret=a1;
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
			UnityEngine.ParticleSystem.MinMaxGradient self;
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
			UnityEngine.ParticleSystem.MinMaxGradient self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystemGradientMode v;
			checkEnum(l,2,out v);
			self.mode=v;
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
	static public int get_gradientMax(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.gradientMax);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_gradientMax(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient self;
			checkValueType(l,1,out self);
			UnityEngine.Gradient v;
			checkType(l,2,out v);
			self.gradientMax=v;
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
	static public int get_gradientMin(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.gradientMin);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_gradientMin(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient self;
			checkValueType(l,1,out self);
			UnityEngine.Gradient v;
			checkType(l,2,out v);
			self.gradientMin=v;
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
	static public int get_colorMax(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.colorMax);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colorMax(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient self;
			checkValueType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.colorMax=v;
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
	static public int get_colorMin(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.colorMin);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colorMin(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient self;
			checkValueType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.colorMin=v;
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
	static public int get_color(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.color);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_color(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient self;
			checkValueType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.color=v;
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
	static public int get_gradient(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.gradient);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_gradient(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.MinMaxGradient self;
			checkValueType(l,1,out self);
			UnityEngine.Gradient v;
			checkType(l,2,out v);
			self.gradient=v;
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
		getTypeTable(l,"UnityEngine.ParticleSystem.MinMaxGradient");
		addMember(l,ctor_s);
		addMember(l,ctor__Color_s);
		addMember(l,ctor__Gradient_s);
		addMember(l,ctor__Color__Color_s);
		addMember(l,ctor__Gradient__Gradient_s);
		addMember(l,Evaluate__Single);
		addMember(l,Evaluate__Single__Single);
		addMember(l,op_Implicit__MinMaxGradient__Color_s);
		addMember(l,op_Implicit__MinMaxGradient__Gradient_s);
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"gradientMax",get_gradientMax,set_gradientMax,true);
		addMember(l,"gradientMin",get_gradientMin,set_gradientMin,true);
		addMember(l,"colorMax",get_colorMax,set_colorMax,true);
		addMember(l,"colorMin",get_colorMin,set_colorMin,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"gradient",get_gradient,set_gradient,true);
		createTypeMetatable(l,null, typeof(UnityEngine.ParticleSystem.MinMaxGradient),typeof(System.ValueType));
	}
}
