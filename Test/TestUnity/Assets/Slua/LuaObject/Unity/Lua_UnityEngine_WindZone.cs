using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_WindZone : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mode(IntPtr l) {
		try {
			UnityEngine.WindZone self=(UnityEngine.WindZone)checkSelf(l);
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
			UnityEngine.WindZone self=(UnityEngine.WindZone)checkSelf(l);
			UnityEngine.WindZoneMode v;
			checkEnum(l,2,out v);
			self.mode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_radius(IntPtr l) {
		try {
			UnityEngine.WindZone self=(UnityEngine.WindZone)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.radius);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_radius(IntPtr l) {
		try {
			UnityEngine.WindZone self=(UnityEngine.WindZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.radius=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_windMain(IntPtr l) {
		try {
			UnityEngine.WindZone self=(UnityEngine.WindZone)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.windMain);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_windMain(IntPtr l) {
		try {
			UnityEngine.WindZone self=(UnityEngine.WindZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.windMain=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_windTurbulence(IntPtr l) {
		try {
			UnityEngine.WindZone self=(UnityEngine.WindZone)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.windTurbulence);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_windTurbulence(IntPtr l) {
		try {
			UnityEngine.WindZone self=(UnityEngine.WindZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.windTurbulence=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_windPulseMagnitude(IntPtr l) {
		try {
			UnityEngine.WindZone self=(UnityEngine.WindZone)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.windPulseMagnitude);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_windPulseMagnitude(IntPtr l) {
		try {
			UnityEngine.WindZone self=(UnityEngine.WindZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.windPulseMagnitude=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_windPulseFrequency(IntPtr l) {
		try {
			UnityEngine.WindZone self=(UnityEngine.WindZone)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.windPulseFrequency);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_windPulseFrequency(IntPtr l) {
		try {
			UnityEngine.WindZone self=(UnityEngine.WindZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.windPulseFrequency=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WindZone");
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"radius",get_radius,set_radius,true);
		addMember(l,"windMain",get_windMain,set_windMain,true);
		addMember(l,"windTurbulence",get_windTurbulence,set_windTurbulence,true);
		addMember(l,"windPulseMagnitude",get_windPulseMagnitude,set_windPulseMagnitude,true);
		addMember(l,"windPulseFrequency",get_windPulseFrequency,set_windPulseFrequency,true);
		createTypeMetatable(l,null, typeof(UnityEngine.WindZone),typeof(UnityEngine.Component));
	}
}
