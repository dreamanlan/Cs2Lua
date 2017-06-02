using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_BuoyancyEffector2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_surfaceLevel(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.surfaceLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_surfaceLevel(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.surfaceLevel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_density(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.density);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_density(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.density=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_linearDrag(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.linearDrag);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_linearDrag(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.linearDrag=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_angularDrag(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.angularDrag);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_angularDrag(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.angularDrag=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_flowAngle(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.flowAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_flowAngle(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.flowAngle=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_flowMagnitude(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.flowMagnitude);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_flowMagnitude(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.flowMagnitude=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_flowVariation(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.flowVariation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_flowVariation(IntPtr l) {
		try {
			UnityEngine.BuoyancyEffector2D self=(UnityEngine.BuoyancyEffector2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.flowVariation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.BuoyancyEffector2D");
		addMember(l,"surfaceLevel",get_surfaceLevel,set_surfaceLevel,true);
		addMember(l,"density",get_density,set_density,true);
		addMember(l,"linearDrag",get_linearDrag,set_linearDrag,true);
		addMember(l,"angularDrag",get_angularDrag,set_angularDrag,true);
		addMember(l,"flowAngle",get_flowAngle,set_flowAngle,true);
		addMember(l,"flowMagnitude",get_flowMagnitude,set_flowMagnitude,true);
		addMember(l,"flowVariation",get_flowVariation,set_flowVariation,true);
		createTypeMetatable(l,null, typeof(UnityEngine.BuoyancyEffector2D),typeof(UnityEngine.Effector2D));
	}
}
