using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_DrawRendererSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Experimental.Rendering.DrawRendererSettings o;
			if(argc==3){
				UnityEngine.Camera a1;
				checkType(l,2,out a1);
				UnityEngine.Experimental.Rendering.ShaderPassName a2;
				checkValueType(l,3,out a2);
				o=new UnityEngine.Experimental.Rendering.DrawRendererSettings(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc<=2){
				o=new UnityEngine.Experimental.Rendering.DrawRendererSettings();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetOverrideMaterial(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetOverrideMaterial(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetShaderPassName(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSettings self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Experimental.Rendering.ShaderPassName a2;
			checkValueType(l,3,out a2);
			self.SetShaderPassName(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maxShaderPasses(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.Rendering.DrawRendererSettings.maxShaderPasses);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.DrawRendererSettings");
		addMember(l,SetOverrideMaterial);
		addMember(l,SetShaderPassName);
		addMember(l,"maxShaderPasses",get_maxShaderPasses,null,false);
		addMember(l,"sorting",get_sorting,set_sorting,true);
		addMember(l,"rendererConfiguration",get_rendererConfiguration,set_rendererConfiguration,true);
		addMember(l,"flags",get_flags,set_flags,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.DrawRendererSettings),typeof(System.ValueType));
	}
}
