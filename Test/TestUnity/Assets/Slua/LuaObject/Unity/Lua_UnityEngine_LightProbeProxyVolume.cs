using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightProbeProxyVolume : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Update(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			self.Update();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_boundsGlobal(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.boundsGlobal);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sizeCustom(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sizeCustom);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sizeCustom(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.sizeCustom=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_originCustom(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.originCustom);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_originCustom(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.originCustom=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_boundingBoxMode(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.boundingBoxMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_boundingBoxMode(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			UnityEngine.LightProbeProxyVolume.BoundingBoxMode v;
			checkEnum(l,2,out v);
			self.boundingBoxMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_resolutionMode(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.resolutionMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_resolutionMode(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			UnityEngine.LightProbeProxyVolume.ResolutionMode v;
			checkEnum(l,2,out v);
			self.resolutionMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_probePositionMode(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.probePositionMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_probePositionMode(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			UnityEngine.LightProbeProxyVolume.ProbePositionMode v;
			checkEnum(l,2,out v);
			self.probePositionMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_refreshMode(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.refreshMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_refreshMode(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			UnityEngine.LightProbeProxyVolume.RefreshMode v;
			checkEnum(l,2,out v);
			self.refreshMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_probeDensity(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.probeDensity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_probeDensity(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.probeDensity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_gridResolutionX(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gridResolutionX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_gridResolutionX(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.gridResolutionX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_gridResolutionY(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gridResolutionY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_gridResolutionY(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.gridResolutionY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_gridResolutionZ(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gridResolutionZ);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_gridResolutionZ(IntPtr l) {
		try {
			UnityEngine.LightProbeProxyVolume self=(UnityEngine.LightProbeProxyVolume)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.gridResolutionZ=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isFeatureSupported(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.LightProbeProxyVolume.isFeatureSupported);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LightProbeProxyVolume");
		addMember(l,Update);
		addMember(l,"boundsGlobal",get_boundsGlobal,null,true);
		addMember(l,"sizeCustom",get_sizeCustom,set_sizeCustom,true);
		addMember(l,"originCustom",get_originCustom,set_originCustom,true);
		addMember(l,"boundingBoxMode",get_boundingBoxMode,set_boundingBoxMode,true);
		addMember(l,"resolutionMode",get_resolutionMode,set_resolutionMode,true);
		addMember(l,"probePositionMode",get_probePositionMode,set_probePositionMode,true);
		addMember(l,"refreshMode",get_refreshMode,set_refreshMode,true);
		addMember(l,"probeDensity",get_probeDensity,set_probeDensity,true);
		addMember(l,"gridResolutionX",get_gridResolutionX,set_gridResolutionX,true);
		addMember(l,"gridResolutionY",get_gridResolutionY,set_gridResolutionY,true);
		addMember(l,"gridResolutionZ",get_gridResolutionZ,set_gridResolutionZ,true);
		addMember(l,"isFeatureSupported",get_isFeatureSupported,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.LightProbeProxyVolume),typeof(UnityEngine.Behaviour));
	}
}
