using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_GlobalIllumination_LightmapperUtils : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Extract_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Extract__Light__Ref_DirectionalLight", argc, 1,typeof(UnityEngine.Light),typeof(UnityEngine.Experimental.GlobalIllumination.DirectionalLight))){
				UnityEngine.Light a1;
				checkType(l,2,out a1);
				UnityEngine.Experimental.GlobalIllumination.DirectionalLight a2;
				checkValueType(l,3,out a2);
				UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.Extract(a1,ref a2);
				pushValue(l,true);
				pushValue(l,a2);
				return 2;
			}
			else if(matchType(l, "Extract__Light__Ref_PointLight", argc, 1,typeof(UnityEngine.Light),typeof(UnityEngine.Experimental.GlobalIllumination.PointLight))){
				UnityEngine.Light a1;
				checkType(l,2,out a1);
				UnityEngine.Experimental.GlobalIllumination.PointLight a2;
				checkValueType(l,3,out a2);
				UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.Extract(a1,ref a2);
				pushValue(l,true);
				pushValue(l,a2);
				return 2;
			}
			else if(matchType(l, "Extract__Light__Ref_SpotLight", argc, 1,typeof(UnityEngine.Light),typeof(UnityEngine.Experimental.GlobalIllumination.SpotLight))){
				UnityEngine.Light a1;
				checkType(l,2,out a1);
				UnityEngine.Experimental.GlobalIllumination.SpotLight a2;
				checkValueType(l,3,out a2);
				UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.Extract(a1,ref a2);
				pushValue(l,true);
				pushValue(l,a2);
				return 2;
			}
			else if(matchType(l, "Extract__Light__Ref_RectangleLight", argc, 1,typeof(UnityEngine.Light),typeof(UnityEngine.Experimental.GlobalIllumination.RectangleLight))){
				UnityEngine.Light a1;
				checkType(l,2,out a1);
				UnityEngine.Experimental.GlobalIllumination.RectangleLight a2;
				checkValueType(l,3,out a2);
				UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.Extract(a1,ref a2);
				pushValue(l,true);
				pushValue(l,a2);
				return 2;
			}
			else if(matchType(l, "Extract__Light__Ref_DiscLight", argc, 1,typeof(UnityEngine.Light),typeof(UnityEngine.Experimental.GlobalIllumination.DiscLight))){
				UnityEngine.Light a1;
				checkType(l,2,out a1);
				UnityEngine.Experimental.GlobalIllumination.DiscLight a2;
				checkValueType(l,3,out a2);
				UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.Extract(a1,ref a2);
				pushValue(l,true);
				pushValue(l,a2);
				return 2;
			}
			else if(argc==2){
				UnityEngine.LightmapBakeType a1;
				checkEnum(l,2,out a1);
				var ret=UnityEngine.Experimental.GlobalIllumination.LightmapperUtils.Extract(a1);
				pushValue(l,true);
				pushEnum(l,(int)ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
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
		addMember(l,Extract_s);
		addMember(l,ExtractIndirect_s);
		addMember(l,ExtractInnerCone_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.GlobalIllumination.LightmapperUtils));
	}
}
