using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AreaEffector2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_forceAngle(IntPtr l) {
		try {
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.forceAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_forceAngle(IntPtr l) {
		try {
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.forceAngle=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useGlobalAngle(IntPtr l) {
		try {
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useGlobalAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useGlobalAngle(IntPtr l) {
		try {
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useGlobalAngle=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_forceMagnitude(IntPtr l) {
		try {
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.forceMagnitude);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_forceMagnitude(IntPtr l) {
		try {
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.forceMagnitude=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_forceVariation(IntPtr l) {
		try {
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.forceVariation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_forceVariation(IntPtr l) {
		try {
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.forceVariation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_drag(IntPtr l) {
		try {
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.drag);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_drag(IntPtr l) {
		try {
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.drag=v;
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
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
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
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
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
	static public int get_forceTarget(IntPtr l) {
		try {
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.forceTarget);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_forceTarget(IntPtr l) {
		try {
			UnityEngine.AreaEffector2D self=(UnityEngine.AreaEffector2D)checkSelf(l);
			UnityEngine.EffectorSelection2D v;
			checkEnum(l,2,out v);
			self.forceTarget=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AreaEffector2D");
		addMember(l,"forceAngle",get_forceAngle,set_forceAngle,true);
		addMember(l,"useGlobalAngle",get_useGlobalAngle,set_useGlobalAngle,true);
		addMember(l,"forceMagnitude",get_forceMagnitude,set_forceMagnitude,true);
		addMember(l,"forceVariation",get_forceVariation,set_forceVariation,true);
		addMember(l,"drag",get_drag,set_drag,true);
		addMember(l,"angularDrag",get_angularDrag,set_angularDrag,true);
		addMember(l,"forceTarget",get_forceTarget,set_forceTarget,true);
		createTypeMetatable(l,null, typeof(UnityEngine.AreaEffector2D),typeof(UnityEngine.Effector2D));
	}
}
