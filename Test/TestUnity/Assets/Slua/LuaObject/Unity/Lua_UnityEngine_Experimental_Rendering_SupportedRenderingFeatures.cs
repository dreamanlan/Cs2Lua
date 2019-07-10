using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_SupportedRenderingFeatures : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures o;
			o=new UnityEngine.Experimental.Rendering.SupportedRenderingFeatures();
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
	static public int get_active(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.Rendering.SupportedRenderingFeatures.active);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_active(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures v;
			checkType(l,2,out v);
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures.active=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_reflectionProbeSupportFlags(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.reflectionProbeSupportFlags);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_reflectionProbeSupportFlags(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures.ReflectionProbeSupportFlags v;
			checkEnum(l,2,out v);
			self.reflectionProbeSupportFlags=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultMixedLightingMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.defaultMixedLightingMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_defaultMixedLightingMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures.LightmapMixedBakeMode v;
			checkEnum(l,2,out v);
			self.defaultMixedLightingMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_supportedMixedLightingModes(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.supportedMixedLightingModes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_supportedMixedLightingModes(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures.LightmapMixedBakeMode v;
			checkEnum(l,2,out v);
			self.supportedMixedLightingModes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_supportedLightmapBakeTypes(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.supportedLightmapBakeTypes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_supportedLightmapBakeTypes(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			UnityEngine.LightmapBakeType v;
			checkEnum(l,2,out v);
			self.supportedLightmapBakeTypes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_supportedLightmapsModes(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.supportedLightmapsModes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_supportedLightmapsModes(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			UnityEngine.LightmapsMode v;
			checkEnum(l,2,out v);
			self.supportedLightmapsModes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rendererSupportsLightProbeProxyVolumes(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rendererSupportsLightProbeProxyVolumes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rendererSupportsLightProbeProxyVolumes(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.rendererSupportsLightProbeProxyVolumes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rendererSupportsMotionVectors(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rendererSupportsMotionVectors);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rendererSupportsMotionVectors(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.rendererSupportsMotionVectors=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rendererSupportsReceiveShadows(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rendererSupportsReceiveShadows);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rendererSupportsReceiveShadows(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.rendererSupportsReceiveShadows=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rendererSupportsReflectionProbes(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rendererSupportsReflectionProbes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rendererSupportsReflectionProbes(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.rendererSupportsReflectionProbes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rendererSupportsRendererPriority(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rendererSupportsRendererPriority);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rendererSupportsRendererPriority(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.rendererSupportsRendererPriority=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rendererOverridesEnvironmentLighting(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rendererOverridesEnvironmentLighting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rendererOverridesEnvironmentLighting(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.rendererOverridesEnvironmentLighting=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rendererOverridesFog(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rendererOverridesFog);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rendererOverridesFog(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.rendererOverridesFog=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rendererOverridesOtherLightingSettings(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rendererOverridesOtherLightingSettings);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rendererOverridesOtherLightingSettings(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.SupportedRenderingFeatures self=(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.rendererOverridesOtherLightingSettings=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.SupportedRenderingFeatures");
		addMember(l,"active",get_active,set_active,false);
		addMember(l,"reflectionProbeSupportFlags",get_reflectionProbeSupportFlags,set_reflectionProbeSupportFlags,true);
		addMember(l,"defaultMixedLightingMode",get_defaultMixedLightingMode,set_defaultMixedLightingMode,true);
		addMember(l,"supportedMixedLightingModes",get_supportedMixedLightingModes,set_supportedMixedLightingModes,true);
		addMember(l,"supportedLightmapBakeTypes",get_supportedLightmapBakeTypes,set_supportedLightmapBakeTypes,true);
		addMember(l,"supportedLightmapsModes",get_supportedLightmapsModes,set_supportedLightmapsModes,true);
		addMember(l,"rendererSupportsLightProbeProxyVolumes",get_rendererSupportsLightProbeProxyVolumes,set_rendererSupportsLightProbeProxyVolumes,true);
		addMember(l,"rendererSupportsMotionVectors",get_rendererSupportsMotionVectors,set_rendererSupportsMotionVectors,true);
		addMember(l,"rendererSupportsReceiveShadows",get_rendererSupportsReceiveShadows,set_rendererSupportsReceiveShadows,true);
		addMember(l,"rendererSupportsReflectionProbes",get_rendererSupportsReflectionProbes,set_rendererSupportsReflectionProbes,true);
		addMember(l,"rendererSupportsRendererPriority",get_rendererSupportsRendererPriority,set_rendererSupportsRendererPriority,true);
		addMember(l,"rendererOverridesEnvironmentLighting",get_rendererOverridesEnvironmentLighting,set_rendererOverridesEnvironmentLighting,true);
		addMember(l,"rendererOverridesFog",get_rendererOverridesFog,set_rendererOverridesFog,true);
		addMember(l,"rendererOverridesOtherLightingSettings",get_rendererOverridesOtherLightingSettings,set_rendererOverridesOtherLightingSettings,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.SupportedRenderingFeatures));
	}
}
