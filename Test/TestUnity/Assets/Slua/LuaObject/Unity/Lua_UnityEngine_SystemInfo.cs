using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SystemInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.SystemInfo o;
			o=new UnityEngine.SystemInfo();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SupportsRenderTextureFormat_s(IntPtr l) {
		try {
			UnityEngine.RenderTextureFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.SystemInfo.SupportsRenderTextureFormat(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SupportsTextureFormat_s(IntPtr l) {
		try {
			UnityEngine.TextureFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.SystemInfo.SupportsTextureFormat(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_operatingSystem(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.operatingSystem);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_processorType(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.processorType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_processorFrequency(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.processorFrequency);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_processorCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.processorCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_systemMemorySize(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.systemMemorySize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsMemorySize(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.graphicsMemorySize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsDeviceName(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.graphicsDeviceName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsDeviceVendor(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.graphicsDeviceVendor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsDeviceID(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.graphicsDeviceID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsDeviceVendorID(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.graphicsDeviceVendorID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsDeviceType(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.SystemInfo.graphicsDeviceType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsDeviceVersion(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.graphicsDeviceVersion);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsShaderLevel(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.graphicsShaderLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsMultiThreaded(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.graphicsMultiThreaded);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsShadows(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsShadows);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsRawShadowDepthSampling(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsRawShadowDepthSampling);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsRenderTextures(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsRenderTextures);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsRenderToCubemap(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsRenderToCubemap);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsImageEffects(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsImageEffects);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supports3DTextures(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supports3DTextures);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsComputeShaders(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsComputeShaders);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsInstancing(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsInstancing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsSparseTextures(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsSparseTextures);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportedRenderTargetCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportedRenderTargetCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsStencil(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsStencil);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_npotSupport(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.SystemInfo.npotSupport);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deviceUniqueIdentifier(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.deviceUniqueIdentifier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deviceName(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.deviceName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deviceModel(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.deviceModel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsAccelerometer(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsAccelerometer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsGyroscope(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsGyroscope);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsLocationService(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsLocationService);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsVibration(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsVibration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsAudio(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.supportsAudio);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deviceType(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.SystemInfo.deviceType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxTextureSize(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SystemInfo.maxTextureSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SystemInfo");
		addMember(l,SupportsRenderTextureFormat_s);
		addMember(l,SupportsTextureFormat_s);
		addMember(l,"operatingSystem",get_operatingSystem,null,false);
		addMember(l,"processorType",get_processorType,null,false);
		addMember(l,"processorFrequency",get_processorFrequency,null,false);
		addMember(l,"processorCount",get_processorCount,null,false);
		addMember(l,"systemMemorySize",get_systemMemorySize,null,false);
		addMember(l,"graphicsMemorySize",get_graphicsMemorySize,null,false);
		addMember(l,"graphicsDeviceName",get_graphicsDeviceName,null,false);
		addMember(l,"graphicsDeviceVendor",get_graphicsDeviceVendor,null,false);
		addMember(l,"graphicsDeviceID",get_graphicsDeviceID,null,false);
		addMember(l,"graphicsDeviceVendorID",get_graphicsDeviceVendorID,null,false);
		addMember(l,"graphicsDeviceType",get_graphicsDeviceType,null,false);
		addMember(l,"graphicsDeviceVersion",get_graphicsDeviceVersion,null,false);
		addMember(l,"graphicsShaderLevel",get_graphicsShaderLevel,null,false);
		addMember(l,"graphicsMultiThreaded",get_graphicsMultiThreaded,null,false);
		addMember(l,"supportsShadows",get_supportsShadows,null,false);
		addMember(l,"supportsRawShadowDepthSampling",get_supportsRawShadowDepthSampling,null,false);
		addMember(l,"supportsRenderTextures",get_supportsRenderTextures,null,false);
		addMember(l,"supportsRenderToCubemap",get_supportsRenderToCubemap,null,false);
		addMember(l,"supportsImageEffects",get_supportsImageEffects,null,false);
		addMember(l,"supports3DTextures",get_supports3DTextures,null,false);
		addMember(l,"supportsComputeShaders",get_supportsComputeShaders,null,false);
		addMember(l,"supportsInstancing",get_supportsInstancing,null,false);
		addMember(l,"supportsSparseTextures",get_supportsSparseTextures,null,false);
		addMember(l,"supportedRenderTargetCount",get_supportedRenderTargetCount,null,false);
		addMember(l,"supportsStencil",get_supportsStencil,null,false);
		addMember(l,"npotSupport",get_npotSupport,null,false);
		addMember(l,"deviceUniqueIdentifier",get_deviceUniqueIdentifier,null,false);
		addMember(l,"deviceName",get_deviceName,null,false);
		addMember(l,"deviceModel",get_deviceModel,null,false);
		addMember(l,"supportsAccelerometer",get_supportsAccelerometer,null,false);
		addMember(l,"supportsGyroscope",get_supportsGyroscope,null,false);
		addMember(l,"supportsLocationService",get_supportsLocationService,null,false);
		addMember(l,"supportsVibration",get_supportsVibration,null,false);
		addMember(l,"supportsAudio",get_supportsAudio,null,false);
		addMember(l,"deviceType",get_deviceType,null,false);
		addMember(l,"maxTextureSize",get_maxTextureSize,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SystemInfo));
	}
}
