using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_SupportedRenderingFeatures : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures o;
			o=new UnityEngine.Rendering.SupportedRenderingFeatures();
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
			pushValue(l,UnityEngine.Rendering.SupportedRenderingFeatures.active);
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
			UnityEngine.Rendering.SupportedRenderingFeatures v;
			checkType(l,2,out v);
			UnityEngine.Rendering.SupportedRenderingFeatures.active=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_reflectionProbeModes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.reflectionProbeModes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_reflectionProbeModes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			UnityEngine.Rendering.SupportedRenderingFeatures.ReflectionProbeModes v;
			checkEnum(l,2,out v);
			self.reflectionProbeModes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultMixedLightingModes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.defaultMixedLightingModes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_defaultMixedLightingModes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes v;
			checkEnum(l,2,out v);
			self.defaultMixedLightingModes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mixedLightingModes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.mixedLightingModes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mixedLightingModes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes v;
			checkEnum(l,2,out v);
			self.mixedLightingModes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightmapBakeTypes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.lightmapBakeTypes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightmapBakeTypes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			UnityEngine.LightmapBakeType v;
			checkEnum(l,2,out v);
			self.lightmapBakeTypes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightmapsModes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.lightmapsModes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightmapsModes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			UnityEngine.LightmapsMode v;
			checkEnum(l,2,out v);
			self.lightmapsModes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enlightenLightmapper(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enlightenLightmapper);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enlightenLightmapper(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enlightenLightmapper=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enlighten(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enlighten);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enlighten(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enlighten=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightProbeProxyVolumes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lightProbeProxyVolumes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightProbeProxyVolumes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.lightProbeProxyVolumes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_motionVectors(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.motionVectors);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_motionVectors(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.motionVectors=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_receiveShadows(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.receiveShadows);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_receiveShadows(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.receiveShadows=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_reflectionProbes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.reflectionProbes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_reflectionProbes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.reflectionProbes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_reflectionProbesBlendDistance(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.reflectionProbesBlendDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_reflectionProbesBlendDistance(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.reflectionProbesBlendDistance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rendererPriority(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rendererPriority);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rendererPriority(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.rendererPriority=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rendersUIOverlay(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rendersUIOverlay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rendersUIOverlay(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.rendersUIOverlay=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overridesEnvironmentLighting(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.overridesEnvironmentLighting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overridesEnvironmentLighting(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.overridesEnvironmentLighting=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overridesFog(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.overridesFog);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overridesFog(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.overridesFog=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overridesRealtimeReflectionProbes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.overridesRealtimeReflectionProbes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overridesRealtimeReflectionProbes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.overridesRealtimeReflectionProbes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overridesOtherLightingSettings(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.overridesOtherLightingSettings);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overridesOtherLightingSettings(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.overridesOtherLightingSettings=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_editableMaterialRenderQueue(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.editableMaterialRenderQueue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_editableMaterialRenderQueue(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.editableMaterialRenderQueue=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overridesLODBias(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.overridesLODBias);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overridesLODBias(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.overridesLODBias=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overridesMaximumLODLevel(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.overridesMaximumLODLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overridesMaximumLODLevel(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.overridesMaximumLODLevel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rendererProbes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rendererProbes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rendererProbes(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.rendererProbes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_particleSystemInstancing(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.particleSystemInstancing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_particleSystemInstancing(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.particleSystemInstancing=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autoAmbientProbeBaking(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoAmbientProbeBaking);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_autoAmbientProbeBaking(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoAmbientProbeBaking=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autoDefaultReflectionProbeBaking(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoDefaultReflectionProbeBaking);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_autoDefaultReflectionProbeBaking(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoDefaultReflectionProbeBaking=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overridesShadowmask(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.overridesShadowmask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overridesShadowmask(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.overridesShadowmask=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overrideShadowmaskMessage(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.overrideShadowmaskMessage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overrideShadowmaskMessage(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.overrideShadowmaskMessage=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_shadowmaskMessage(IntPtr l) {
		try {
			UnityEngine.Rendering.SupportedRenderingFeatures self=(UnityEngine.Rendering.SupportedRenderingFeatures)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shadowmaskMessage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.SupportedRenderingFeatures");
		addMember(l,ctor_s);
		addMember(l,"active",get_active,set_active,false);
		addMember(l,"reflectionProbeModes",get_reflectionProbeModes,set_reflectionProbeModes,true);
		addMember(l,"defaultMixedLightingModes",get_defaultMixedLightingModes,set_defaultMixedLightingModes,true);
		addMember(l,"mixedLightingModes",get_mixedLightingModes,set_mixedLightingModes,true);
		addMember(l,"lightmapBakeTypes",get_lightmapBakeTypes,set_lightmapBakeTypes,true);
		addMember(l,"lightmapsModes",get_lightmapsModes,set_lightmapsModes,true);
		addMember(l,"enlightenLightmapper",get_enlightenLightmapper,set_enlightenLightmapper,true);
		addMember(l,"enlighten",get_enlighten,set_enlighten,true);
		addMember(l,"lightProbeProxyVolumes",get_lightProbeProxyVolumes,set_lightProbeProxyVolumes,true);
		addMember(l,"motionVectors",get_motionVectors,set_motionVectors,true);
		addMember(l,"receiveShadows",get_receiveShadows,set_receiveShadows,true);
		addMember(l,"reflectionProbes",get_reflectionProbes,set_reflectionProbes,true);
		addMember(l,"reflectionProbesBlendDistance",get_reflectionProbesBlendDistance,set_reflectionProbesBlendDistance,true);
		addMember(l,"rendererPriority",get_rendererPriority,set_rendererPriority,true);
		addMember(l,"rendersUIOverlay",get_rendersUIOverlay,set_rendersUIOverlay,true);
		addMember(l,"overridesEnvironmentLighting",get_overridesEnvironmentLighting,set_overridesEnvironmentLighting,true);
		addMember(l,"overridesFog",get_overridesFog,set_overridesFog,true);
		addMember(l,"overridesRealtimeReflectionProbes",get_overridesRealtimeReflectionProbes,set_overridesRealtimeReflectionProbes,true);
		addMember(l,"overridesOtherLightingSettings",get_overridesOtherLightingSettings,set_overridesOtherLightingSettings,true);
		addMember(l,"editableMaterialRenderQueue",get_editableMaterialRenderQueue,set_editableMaterialRenderQueue,true);
		addMember(l,"overridesLODBias",get_overridesLODBias,set_overridesLODBias,true);
		addMember(l,"overridesMaximumLODLevel",get_overridesMaximumLODLevel,set_overridesMaximumLODLevel,true);
		addMember(l,"rendererProbes",get_rendererProbes,set_rendererProbes,true);
		addMember(l,"particleSystemInstancing",get_particleSystemInstancing,set_particleSystemInstancing,true);
		addMember(l,"autoAmbientProbeBaking",get_autoAmbientProbeBaking,set_autoAmbientProbeBaking,true);
		addMember(l,"autoDefaultReflectionProbeBaking",get_autoDefaultReflectionProbeBaking,set_autoDefaultReflectionProbeBaking,true);
		addMember(l,"overridesShadowmask",get_overridesShadowmask,set_overridesShadowmask,true);
		addMember(l,"overrideShadowmaskMessage",get_overrideShadowmaskMessage,set_overrideShadowmaskMessage,true);
		addMember(l,"shadowmaskMessage",get_shadowmaskMessage,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.SupportedRenderingFeatures));
	}
}
