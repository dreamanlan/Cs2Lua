using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_OnDemandRendering : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.OnDemandRendering o;
			o=new UnityEngine.Rendering.OnDemandRendering();
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
	static public int get_willCurrentFrameRender(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.OnDemandRendering.willCurrentFrameRender);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderFrameInterval(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.OnDemandRendering.renderFrameInterval);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_renderFrameInterval(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.Rendering.OnDemandRendering.renderFrameInterval=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_effectiveRenderFrameRate(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.OnDemandRendering.effectiveRenderFrameRate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.OnDemandRendering");
		addMember(l,ctor_s);
		addMember(l,"willCurrentFrameRender",get_willCurrentFrameRender,null,false);
		addMember(l,"renderFrameInterval",get_renderFrameInterval,set_renderFrameInterval,false);
		addMember(l,"effectiveRenderFrameRate",get_effectiveRenderFrameRate,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.OnDemandRendering));
	}
}
