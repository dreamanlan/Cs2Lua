using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_BatchCullingContext : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchCullingContext o;
			o=new UnityEngine.Rendering.BatchCullingContext();
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
	static public int get_lodParameters(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchCullingContext self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lodParameters);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cullingMatrix(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchCullingContext self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.cullingMatrix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_nearPlane(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchCullingContext self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.nearPlane);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.BatchCullingContext");
		addMember(l,ctor_s);
		addMember(l,"lodParameters",get_lodParameters,null,true);
		addMember(l,"cullingMatrix",get_cullingMatrix,null,true);
		addMember(l,"nearPlane",get_nearPlane,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.BatchCullingContext),typeof(System.ValueType));
	}
}
