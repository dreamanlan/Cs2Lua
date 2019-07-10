using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightProbes : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetInterpolatedProbe_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Renderer a2;
			checkType(l,2,out a2);
			UnityEngine.Rendering.SphericalHarmonicsL2 a3;
			UnityEngine.LightProbes.GetInterpolatedProbe(a1,a2,out a3);
			pushValue(l,true);
			pushValue(l,a3);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CalculateInterpolatedLightAndOcclusionProbes_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "CalculateInterpolatedLightAndOcclusionProbes__Arr_Vector3__Arr_SphericalHarmonicsL2__Arr_Vector4", argc, 1,typeof(UnityEngine.Vector3[]),typeof(UnityEngine.Rendering.SphericalHarmonicsL2[]),typeof(UnityEngine.Vector4[]))){
				UnityEngine.Vector3[] a1;
				checkArray(l,2,out a1);
				UnityEngine.Rendering.SphericalHarmonicsL2[] a2;
				checkArray(l,3,out a2);
				UnityEngine.Vector4[] a3;
				checkArray(l,4,out a3);
				UnityEngine.LightProbes.CalculateInterpolatedLightAndOcclusionProbes(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "CalculateInterpolatedLightAndOcclusionProbes__List`1_Vector3__List`1_SphericalHarmonicsL2__List`1_Vector4", argc, 1,typeof(List<UnityEngine.Vector3>),typeof(List<UnityEngine.Rendering.SphericalHarmonicsL2>),typeof(List<UnityEngine.Vector4>))){
				System.Collections.Generic.List<UnityEngine.Vector3> a1;
				checkType(l,2,out a1);
				System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> a2;
				checkType(l,3,out a2);
				System.Collections.Generic.List<UnityEngine.Vector4> a3;
				checkType(l,4,out a3);
				UnityEngine.LightProbes.CalculateInterpolatedLightAndOcclusionProbes(a1,a2,a3);
				pushValue(l,true);
				return 1;
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
	static public int get_positions(IntPtr l) {
		try {
			UnityEngine.LightProbes self=(UnityEngine.LightProbes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.positions);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bakedProbes(IntPtr l) {
		try {
			UnityEngine.LightProbes self=(UnityEngine.LightProbes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bakedProbes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bakedProbes(IntPtr l) {
		try {
			UnityEngine.LightProbes self=(UnityEngine.LightProbes)checkSelf(l);
			UnityEngine.Rendering.SphericalHarmonicsL2[] v;
			checkArray(l,2,out v);
			self.bakedProbes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_count(IntPtr l) {
		try {
			UnityEngine.LightProbes self=(UnityEngine.LightProbes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.count);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cellCount(IntPtr l) {
		try {
			UnityEngine.LightProbes self=(UnityEngine.LightProbes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cellCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LightProbes");
		addMember(l,GetInterpolatedProbe_s);
		addMember(l,CalculateInterpolatedLightAndOcclusionProbes_s);
		addMember(l,"positions",get_positions,null,true);
		addMember(l,"bakedProbes",get_bakedProbes,set_bakedProbes,true);
		addMember(l,"count",get_count,null,true);
		addMember(l,"cellCount",get_cellCount,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.LightProbes),typeof(UnityEngine.Object));
	}
}
