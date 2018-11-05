using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RenderPipelineAsset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DestroyCreatedInstances(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			self.DestroyCreatedInstances();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreatePipeline(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			var ret=self.CreatePipeline();
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
	static public int GetTerrainBrushPassIndex(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			var ret=self.GetTerrainBrushPassIndex();
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
	static public int GetDefaultMaterial(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			var ret=self.GetDefaultMaterial();
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
	static public int GetDefaultParticleMaterial(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			var ret=self.GetDefaultParticleMaterial();
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
	static public int GetDefaultLineMaterial(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			var ret=self.GetDefaultLineMaterial();
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
	static public int GetDefaultTerrainMaterial(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			var ret=self.GetDefaultTerrainMaterial();
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
	static public int GetDefaultUIMaterial(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			var ret=self.GetDefaultUIMaterial();
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
	static public int GetDefaultUIOverdrawMaterial(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			var ret=self.GetDefaultUIOverdrawMaterial();
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
	static public int GetDefaultUIETC1SupportedMaterial(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			var ret=self.GetDefaultUIETC1SupportedMaterial();
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
	static public int GetDefault2DMaterial(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			var ret=self.GetDefault2DMaterial();
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
	static public int GetDefaultShader(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			var ret=self.GetDefaultShader();
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
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RenderPipelineAsset");
		addMember(l,DestroyCreatedInstances);
		addMember(l,CreatePipeline);
		addMember(l,GetTerrainBrushPassIndex);
		addMember(l,GetDefaultMaterial);
		addMember(l,GetDefaultParticleMaterial);
		addMember(l,GetDefaultLineMaterial);
		addMember(l,GetDefaultTerrainMaterial);
		addMember(l,GetDefaultUIMaterial);
		addMember(l,GetDefaultUIOverdrawMaterial);
		addMember(l,GetDefaultUIETC1SupportedMaterial);
		addMember(l,GetDefault2DMaterial);
		addMember(l,GetDefaultShader);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.RenderPipelineAsset),typeof(UnityEngine.ScriptableObject));
	}
}
