using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightingSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.LightingSettings o;
			o=new UnityEngine.LightingSettings();
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
	static public int get_bakedGI(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bakedGI);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bakedGI(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.bakedGI=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_realtimeGI(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.realtimeGI);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_realtimeGI(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.realtimeGI=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_realtimeEnvironmentLighting(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.realtimeEnvironmentLighting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_realtimeEnvironmentLighting(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.realtimeEnvironmentLighting=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autoGenerate(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoGenerate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_autoGenerate(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoGenerate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mixedBakeMode(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.mixedBakeMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mixedBakeMode(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			UnityEngine.MixedLightingMode v;
			checkEnum(l,2,out v);
			self.mixedBakeMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_albedoBoost(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.albedoBoost);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_albedoBoost(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.albedoBoost=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_indirectScale(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.indirectScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_indirectScale(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.indirectScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightmapper(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.lightmapper);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightmapper(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			UnityEngine.LightingSettings.Lightmapper v;
			checkEnum(l,2,out v);
			self.lightmapper=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightmapMaxSize(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lightmapMaxSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightmapMaxSize(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.lightmapMaxSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightmapResolution(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lightmapResolution);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightmapResolution(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.lightmapResolution=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightmapPadding(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lightmapPadding);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightmapPadding(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.lightmapPadding=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightmapCompression(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.lightmapCompression);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightmapCompression(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			UnityEngine.LightmapCompression v;
			checkEnum(l,2,out v);
			self.lightmapCompression=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ao(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ao);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_ao(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.ao=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_aoMaxDistance(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.aoMaxDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_aoMaxDistance(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.aoMaxDistance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_aoExponentIndirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.aoExponentIndirect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_aoExponentIndirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.aoExponentIndirect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_aoExponentDirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.aoExponentDirect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_aoExponentDirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.aoExponentDirect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_extractAO(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.extractAO);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_extractAO(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.extractAO=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_directionalityMode(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.directionalityMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_directionalityMode(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			UnityEngine.LightmapsMode v;
			checkEnum(l,2,out v);
			self.directionalityMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_exportTrainingData(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.exportTrainingData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_exportTrainingData(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.exportTrainingData=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_trainingDataDestination(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.trainingDataDestination);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_trainingDataDestination(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.trainingDataDestination=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_indirectResolution(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.indirectResolution);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_indirectResolution(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.indirectResolution=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_finalGather(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.finalGather);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_finalGather(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.finalGather=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_finalGatherRayCount(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.finalGatherRayCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_finalGatherRayCount(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.finalGatherRayCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_finalGatherFiltering(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.finalGatherFiltering);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_finalGatherFiltering(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.finalGatherFiltering=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sampling(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.sampling);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sampling(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			UnityEngine.LightingSettings.Sampling v;
			checkEnum(l,2,out v);
			self.sampling=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_directSampleCount(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.directSampleCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_directSampleCount(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.directSampleCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_indirectSampleCount(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.indirectSampleCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_indirectSampleCount(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.indirectSampleCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maxBounces(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxBounces);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maxBounces(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.maxBounces=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_minBounces(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.minBounces);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_minBounces(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.minBounces=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_prioritizeView(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.prioritizeView);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_prioritizeView(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.prioritizeView=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filteringMode(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.filteringMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filteringMode(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			UnityEngine.LightingSettings.FilterMode v;
			checkEnum(l,2,out v);
			self.filteringMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_denoiserTypeDirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.denoiserTypeDirect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_denoiserTypeDirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			UnityEngine.LightingSettings.DenoiserType v;
			checkEnum(l,2,out v);
			self.denoiserTypeDirect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_denoiserTypeIndirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.denoiserTypeIndirect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_denoiserTypeIndirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			UnityEngine.LightingSettings.DenoiserType v;
			checkEnum(l,2,out v);
			self.denoiserTypeIndirect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_denoiserTypeAO(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.denoiserTypeAO);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_denoiserTypeAO(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			UnityEngine.LightingSettings.DenoiserType v;
			checkEnum(l,2,out v);
			self.denoiserTypeAO=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filterTypeDirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.filterTypeDirect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filterTypeDirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			UnityEngine.LightingSettings.FilterType v;
			checkEnum(l,2,out v);
			self.filterTypeDirect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filterTypeIndirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.filterTypeIndirect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filterTypeIndirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			UnityEngine.LightingSettings.FilterType v;
			checkEnum(l,2,out v);
			self.filterTypeIndirect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filterTypeAO(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.filterTypeAO);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filterTypeAO(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			UnityEngine.LightingSettings.FilterType v;
			checkEnum(l,2,out v);
			self.filterTypeAO=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filteringGaussRadiusDirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.filteringGaussRadiusDirect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filteringGaussRadiusDirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.filteringGaussRadiusDirect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filteringGaussRadiusIndirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.filteringGaussRadiusIndirect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filteringGaussRadiusIndirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.filteringGaussRadiusIndirect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filteringGaussRadiusAO(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.filteringGaussRadiusAO);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filteringGaussRadiusAO(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.filteringGaussRadiusAO=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filteringAtrousPositionSigmaDirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.filteringAtrousPositionSigmaDirect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filteringAtrousPositionSigmaDirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.filteringAtrousPositionSigmaDirect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filteringAtrousPositionSigmaIndirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.filteringAtrousPositionSigmaIndirect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filteringAtrousPositionSigmaIndirect(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.filteringAtrousPositionSigmaIndirect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filteringAtrousPositionSigmaAO(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.filteringAtrousPositionSigmaAO);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filteringAtrousPositionSigmaAO(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.filteringAtrousPositionSigmaAO=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_environmentSampleCount(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.environmentSampleCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_environmentSampleCount(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.environmentSampleCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightProbeSampleCountMultiplier(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lightProbeSampleCountMultiplier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightProbeSampleCountMultiplier(IntPtr l) {
		try {
			UnityEngine.LightingSettings self=(UnityEngine.LightingSettings)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.lightProbeSampleCountMultiplier=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LightingSettings");
		addMember(l,ctor_s);
		addMember(l,"bakedGI",get_bakedGI,set_bakedGI,true);
		addMember(l,"realtimeGI",get_realtimeGI,set_realtimeGI,true);
		addMember(l,"realtimeEnvironmentLighting",get_realtimeEnvironmentLighting,set_realtimeEnvironmentLighting,true);
		addMember(l,"autoGenerate",get_autoGenerate,set_autoGenerate,true);
		addMember(l,"mixedBakeMode",get_mixedBakeMode,set_mixedBakeMode,true);
		addMember(l,"albedoBoost",get_albedoBoost,set_albedoBoost,true);
		addMember(l,"indirectScale",get_indirectScale,set_indirectScale,true);
		addMember(l,"lightmapper",get_lightmapper,set_lightmapper,true);
		addMember(l,"lightmapMaxSize",get_lightmapMaxSize,set_lightmapMaxSize,true);
		addMember(l,"lightmapResolution",get_lightmapResolution,set_lightmapResolution,true);
		addMember(l,"lightmapPadding",get_lightmapPadding,set_lightmapPadding,true);
		addMember(l,"lightmapCompression",get_lightmapCompression,set_lightmapCompression,true);
		addMember(l,"ao",get_ao,set_ao,true);
		addMember(l,"aoMaxDistance",get_aoMaxDistance,set_aoMaxDistance,true);
		addMember(l,"aoExponentIndirect",get_aoExponentIndirect,set_aoExponentIndirect,true);
		addMember(l,"aoExponentDirect",get_aoExponentDirect,set_aoExponentDirect,true);
		addMember(l,"extractAO",get_extractAO,set_extractAO,true);
		addMember(l,"directionalityMode",get_directionalityMode,set_directionalityMode,true);
		addMember(l,"exportTrainingData",get_exportTrainingData,set_exportTrainingData,true);
		addMember(l,"trainingDataDestination",get_trainingDataDestination,set_trainingDataDestination,true);
		addMember(l,"indirectResolution",get_indirectResolution,set_indirectResolution,true);
		addMember(l,"finalGather",get_finalGather,set_finalGather,true);
		addMember(l,"finalGatherRayCount",get_finalGatherRayCount,set_finalGatherRayCount,true);
		addMember(l,"finalGatherFiltering",get_finalGatherFiltering,set_finalGatherFiltering,true);
		addMember(l,"sampling",get_sampling,set_sampling,true);
		addMember(l,"directSampleCount",get_directSampleCount,set_directSampleCount,true);
		addMember(l,"indirectSampleCount",get_indirectSampleCount,set_indirectSampleCount,true);
		addMember(l,"maxBounces",get_maxBounces,set_maxBounces,true);
		addMember(l,"minBounces",get_minBounces,set_minBounces,true);
		addMember(l,"prioritizeView",get_prioritizeView,set_prioritizeView,true);
		addMember(l,"filteringMode",get_filteringMode,set_filteringMode,true);
		addMember(l,"denoiserTypeDirect",get_denoiserTypeDirect,set_denoiserTypeDirect,true);
		addMember(l,"denoiserTypeIndirect",get_denoiserTypeIndirect,set_denoiserTypeIndirect,true);
		addMember(l,"denoiserTypeAO",get_denoiserTypeAO,set_denoiserTypeAO,true);
		addMember(l,"filterTypeDirect",get_filterTypeDirect,set_filterTypeDirect,true);
		addMember(l,"filterTypeIndirect",get_filterTypeIndirect,set_filterTypeIndirect,true);
		addMember(l,"filterTypeAO",get_filterTypeAO,set_filterTypeAO,true);
		addMember(l,"filteringGaussRadiusDirect",get_filteringGaussRadiusDirect,set_filteringGaussRadiusDirect,true);
		addMember(l,"filteringGaussRadiusIndirect",get_filteringGaussRadiusIndirect,set_filteringGaussRadiusIndirect,true);
		addMember(l,"filteringGaussRadiusAO",get_filteringGaussRadiusAO,set_filteringGaussRadiusAO,true);
		addMember(l,"filteringAtrousPositionSigmaDirect",get_filteringAtrousPositionSigmaDirect,set_filteringAtrousPositionSigmaDirect,true);
		addMember(l,"filteringAtrousPositionSigmaIndirect",get_filteringAtrousPositionSigmaIndirect,set_filteringAtrousPositionSigmaIndirect,true);
		addMember(l,"filteringAtrousPositionSigmaAO",get_filteringAtrousPositionSigmaAO,set_filteringAtrousPositionSigmaAO,true);
		addMember(l,"environmentSampleCount",get_environmentSampleCount,set_environmentSampleCount,true);
		addMember(l,"lightProbeSampleCountMultiplier",get_lightProbeSampleCountMultiplier,set_lightProbeSampleCountMultiplier,true);
		createTypeMetatable(l,null, typeof(UnityEngine.LightingSettings),typeof(UnityEngine.Object));
	}
}
