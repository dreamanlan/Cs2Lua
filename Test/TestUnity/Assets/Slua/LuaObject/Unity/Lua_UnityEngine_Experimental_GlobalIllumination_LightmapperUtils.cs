using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_GlobalIllumination_LightmapperUtils : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Extract__LightmapBakeType_s(IntPtr l) {
		try {
			UnityEngine.LightmapBakeType a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.Extract(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Extract__Light__R_DirectionalLight_s(IntPtr l) {
		try {
			UnityEngine.Light a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight a2;
			checkValueType(l,2,out a2);
			UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.Extract(a1,ref a2);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Extract__Light__R_PointLight_s(IntPtr l) {
		try {
			UnityEngine.Light a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.GlobalIllumination.PointLight a2;
			checkValueType(l,2,out a2);
			UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.Extract(a1,ref a2);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Extract__Light__R_SpotLight_s(IntPtr l) {
		try {
			UnityEngine.Light a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.GlobalIllumination.SpotLight a2;
			checkValueType(l,2,out a2);
			UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.Extract(a1,ref a2);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Extract__Light__R_RectangleLight_s(IntPtr l) {
		try {
			UnityEngine.Light a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.GlobalIllumination.RectangleLight a2;
			checkValueType(l,2,out a2);
			UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.Extract(a1,ref a2);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Extract__Light__R_DiscLight_s(IntPtr l) {
		try {
			UnityEngine.Light a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.GlobalIllumination.DiscLight a2;
			checkValueType(l,2,out a2);
			UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.Extract(a1,ref a2);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Extract__Light__O_Cookie_s(IntPtr l) {
		try {
			UnityEngine.Light a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.GlobalIllumination.Cookie a2;
			UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.Extract(a1,out a2);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ExtractIndirect_s(IntPtr l) {
		try {
			UnityEngine.Light a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.ExtractIndirect(a1);
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
	static public int ExtractInnerCone_s(IntPtr l) {
		try {
			UnityEngine.Light a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.ExtractInnerCone(a1);
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
		getTypeTable(l,"UnityEngine.Experimental.GlobalIllumination.LightmapperUtils");
		addMember(l,Extract__LightmapBakeType_s);
		addMember(l,Extract__Light__R_DirectionalLight_s);
		addMember(l,Extract__Light__R_PointLight_s);
		addMember(l,Extract__Light__R_SpotLight_s);
		addMember(l,Extract__Light__R_RectangleLight_s);
		addMember(l,Extract__Light__R_DiscLight_s);
		addMember(l,Extract__Light__O_Cookie_s);
		addMember(l,ExtractIndirect_s);
		addMember(l,ExtractInnerCone_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.GlobalIllumination.LightmapperUtils));
	}
}
