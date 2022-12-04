using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_PerObjectData : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.PerObjectData");
		addMember(l,0,"None");
		addMember(l,1,"LightProbe");
		addMember(l,2,"ReflectionProbes");
		addMember(l,4,"LightProbeProxyVolume");
		addMember(l,8,"Lightmaps");
		addMember(l,16,"LightData");
		addMember(l,32,"MotionVectors");
		addMember(l,64,"LightIndices");
		addMember(l,128,"ReflectionProbeData");
		addMember(l,256,"OcclusionProbe");
		addMember(l,512,"OcclusionProbeProxyVolume");
		addMember(l,1024,"ShadowMask");
		LuaDLL.lua_pop(l, 1);
	}
}
