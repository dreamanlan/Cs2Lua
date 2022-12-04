using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_GlobalIllumination_RenderSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.RenderSettings o;
			o=new UnityEngine.Experimental.GlobalIllumination.RenderSettings();
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
	static public int get_useRadianceAmbientProbe(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.GlobalIllumination.RenderSettings.useRadianceAmbientProbe);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useRadianceAmbientProbe(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Experimental.GlobalIllumination.RenderSettings.useRadianceAmbientProbe=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.GlobalIllumination.RenderSettings");
		addMember(l,ctor_s);
		addMember(l,"useRadianceAmbientProbe",get_useRadianceAmbientProbe,set_useRadianceAmbientProbe,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.GlobalIllumination.RenderSettings));
	}
}
