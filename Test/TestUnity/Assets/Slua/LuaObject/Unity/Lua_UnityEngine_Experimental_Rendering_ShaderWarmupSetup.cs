using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_ShaderWarmupSetup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ShaderWarmupSetup o;
			o=new UnityEngine.Experimental.Rendering.ShaderWarmupSetup();
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
	static public int get_vdecl(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ShaderWarmupSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.vdecl);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_vdecl(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.ShaderWarmupSetup self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.VertexAttributeDescriptor[] v;
			checkArray(l,2,out v);
			self.vdecl=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.ShaderWarmupSetup");
		addMember(l,ctor_s);
		addMember(l,"vdecl",get_vdecl,set_vdecl,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.ShaderWarmupSetup),typeof(System.ValueType));
	}
}
