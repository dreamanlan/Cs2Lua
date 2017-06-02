using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_DynamicGI : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.DynamicGI o;
			o=new UnityEngine.DynamicGI();
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
	static public int SetEmissive_s(IntPtr l) {
		try {
			UnityEngine.Renderer a1;
			checkType(l,1,out a1);
			UnityEngine.Color a2;
			checkType(l,2,out a2);
			UnityEngine.DynamicGI.SetEmissive(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateEnvironment_s(IntPtr l) {
		try {
			UnityEngine.DynamicGI.UpdateEnvironment();
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
			pushValue(l,true);
			pushValue(l,UnityEngine.DynamicGI.indirectScale);
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
			float v;
			checkType(l,2,out v);
			UnityEngine.DynamicGI.indirectScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_updateThreshold(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.DynamicGI.updateThreshold);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_updateThreshold(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.DynamicGI.updateThreshold=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_synchronousMode(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.DynamicGI.synchronousMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_synchronousMode(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.DynamicGI.synchronousMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.DynamicGI");
		addMember(l,SetEmissive_s);
		addMember(l,UpdateEnvironment_s);
		addMember(l,"indirectScale",get_indirectScale,set_indirectScale,false);
		addMember(l,"updateThreshold",get_updateThreshold,set_updateThreshold,false);
		addMember(l,"synchronousMode",get_synchronousMode,set_synchronousMode,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.DynamicGI));
	}
}
