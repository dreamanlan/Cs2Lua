using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_DrawRendererSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings o;
			UnityEngine.Experimental.Rendering.CullResults a1;
			checkValueType(l,2,out a1);
			UnityEngine.Camera a2;
			checkType(l,3,out a2);
			UnityEngine.Experimental.Rendering.ShaderPassName a3;
			checkValueType(l,4,out a3);
			o=new UnityEngine.Experimental.Rendering.DrawRendererSettings(a1,a2,a3);
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
	static public int get_sorting(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sorting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sorting(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.DrawRendererSortSettings v;
			checkValueType(l,2,out v);
			self.sorting=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_shaderPassName(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.shaderPassName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shaderPassName(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.ShaderPassName v;
			checkValueType(l,2,out v);
			self.shaderPassName=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_inputFilter(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.inputFilter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_inputFilter(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.InputFilter v;
			checkValueType(l,2,out v);
			self.inputFilter=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rendererConfiguration(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.rendererConfiguration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rendererConfiguration(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RendererConfiguration v;
			checkEnum(l,2,out v);
			self.rendererConfiguration=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_flags(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.flags);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_flags(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.DrawRendererFlags v;
			checkEnum(l,2,out v);
			self.flags=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cullResults(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.CullResults v;
			checkValueType(l,2,out v);
			self.cullResults=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.DrawRendererSettings");
		addMember(l,"sorting",get_sorting,set_sorting,true);
		addMember(l,"shaderPassName",get_shaderPassName,set_shaderPassName,true);
		addMember(l,"inputFilter",get_inputFilter,set_inputFilter,true);
		addMember(l,"rendererConfiguration",get_rendererConfiguration,set_rendererConfiguration,true);
		addMember(l,"flags",get_flags,set_flags,true);
		addMember(l,"cullResults",null,set_cullResults,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.DrawRendererSettings),typeof(System.ValueType));
	}
}
