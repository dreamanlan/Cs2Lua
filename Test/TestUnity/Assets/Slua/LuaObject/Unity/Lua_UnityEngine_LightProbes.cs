using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightProbes : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.LightProbes o;
			o=new UnityEngine.LightProbes();
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
		addMember(l,"positions",get_positions,null,true);
		addMember(l,"bakedProbes",get_bakedProbes,set_bakedProbes,true);
		addMember(l,"count",get_count,null,true);
		addMember(l,"cellCount",get_cellCount,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LightProbes),typeof(UnityEngine.Object));
	}
}
