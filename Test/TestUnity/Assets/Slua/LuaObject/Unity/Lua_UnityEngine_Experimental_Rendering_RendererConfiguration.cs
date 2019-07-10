using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RendererConfiguration : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.RendererConfiguration");
		addMember(l,0,"None");
		addMember(l,1,"PerObjectLightProbe");
		addMember(l,2,"PerObjectReflectionProbes");
		addMember(l,4,"PerObjectLightProbeProxyVolume");
		addMember(l,8,"PerObjectLightmaps");
		addMember(l,16,"ProvideLightIndices");
		addMember(l,32,"PerObjectMotionVectors");
		addMember(l,64,"PerObjectLightIndices8");
		addMember(l,128,"ProvideReflectionProbeIndices");
		addMember(l,256,"PerObjectOcclusionProbe");
		addMember(l,512,"PerObjectOcclusionProbeProxyVolume");
		addMember(l,1024,"PerObjectShadowMask");
		LuaDLL.lua_pop(l, 1);
	}
}
