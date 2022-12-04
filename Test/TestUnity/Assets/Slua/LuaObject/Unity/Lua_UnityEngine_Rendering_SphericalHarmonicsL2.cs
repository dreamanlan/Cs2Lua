using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_SphericalHarmonicsL2 : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 o;
			o=new UnityEngine.Rendering.SphericalHarmonicsL2();
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
	static public int Clear(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 self;
			checkValueType(l,1,out self);
			self.Clear();
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
	static public int AddAmbientLight(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 self;
			checkValueType(l,1,out self);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			self.AddAmbientLight(a1);
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
	static public int AddDirectionalLight(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.AddDirectionalLight(a1,a2,a3);
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
	static public int Evaluate(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3[] a1;
			checkArray(l,2,out a1);
			UnityEngine.Color[] a2;
			checkArray(l,3,out a2);
			self.Evaluate(a1,a2);
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
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 self;
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
	static public int Equals__SphericalHarmonicsL2(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.SphericalHarmonicsL2 a1;
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
	static public int op_Multiply__SphericalHarmonicsL2__Single_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			var ret=a1*a2;
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
	static public int op_Multiply__Single__SphericalHarmonicsL2_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			UnityEngine.Rendering.SphericalHarmonicsL2 a2;
			checkValueType(l,2,out a2);
			var ret=a1*a2;
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
	static public int op_Addition_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.SphericalHarmonicsL2 a2;
			checkValueType(l,2,out a2);
			var ret=a1+a2;
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
			UnityEngine.Rendering.SphericalHarmonicsL2 a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.SphericalHarmonicsL2 a2;
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
			UnityEngine.Rendering.SphericalHarmonicsL2 a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.SphericalHarmonicsL2 a2;
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.SphericalHarmonicsL2");
		addMember(l,ctor_s);
		addMember(l,Clear);
		addMember(l,AddAmbientLight);
		addMember(l,AddDirectionalLight);
		addMember(l,Evaluate);
		addMember(l,Equals__Object);
		addMember(l,Equals__SphericalHarmonicsL2);
		addMember(l,op_Multiply__SphericalHarmonicsL2__Single_s);
		addMember(l,op_Multiply__Single__SphericalHarmonicsL2_s);
		addMember(l,op_Addition_s);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.SphericalHarmonicsL2),typeof(System.ValueType));
	}
}
