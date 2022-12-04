using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RenderPipelineAsset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_terrainBrushPassIndex(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.terrainBrushPassIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderingLayerMaskNames(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.renderingLayerMaskNames);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_prefixedRenderingLayerMaskNames(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.prefixedRenderingLayerMaskNames);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autodeskInteractiveShader(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autodeskInteractiveShader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autodeskInteractiveTransparentShader(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autodeskInteractiveTransparentShader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autodeskInteractiveMaskedShader(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autodeskInteractiveMaskedShader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_terrainDetailLitShader(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.terrainDetailLitShader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_terrainDetailGrassShader(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.terrainDetailGrassShader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_terrainDetailGrassBillboardShader(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.terrainDetailGrassBillboardShader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultParticleMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultParticleMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultLineMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultLineMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultTerrainMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultTerrainMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultUIMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultUIMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultUIOverdrawMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultUIOverdrawMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultUIETC1SupportedMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultUIETC1SupportedMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_default2DMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.default2DMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_default2DMaskMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.default2DMaskMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultShader(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultShader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultSpeedTree7Shader(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultSpeedTree7Shader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultSpeedTree8Shader(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipelineAsset self=(UnityEngine.Rendering.RenderPipelineAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultSpeedTree8Shader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.RenderPipelineAsset");
		addMember(l,"terrainBrushPassIndex",get_terrainBrushPassIndex,null,true);
		addMember(l,"renderingLayerMaskNames",get_renderingLayerMaskNames,null,true);
		addMember(l,"prefixedRenderingLayerMaskNames",get_prefixedRenderingLayerMaskNames,null,true);
		addMember(l,"defaultMaterial",get_defaultMaterial,null,true);
		addMember(l,"autodeskInteractiveShader",get_autodeskInteractiveShader,null,true);
		addMember(l,"autodeskInteractiveTransparentShader",get_autodeskInteractiveTransparentShader,null,true);
		addMember(l,"autodeskInteractiveMaskedShader",get_autodeskInteractiveMaskedShader,null,true);
		addMember(l,"terrainDetailLitShader",get_terrainDetailLitShader,null,true);
		addMember(l,"terrainDetailGrassShader",get_terrainDetailGrassShader,null,true);
		addMember(l,"terrainDetailGrassBillboardShader",get_terrainDetailGrassBillboardShader,null,true);
		addMember(l,"defaultParticleMaterial",get_defaultParticleMaterial,null,true);
		addMember(l,"defaultLineMaterial",get_defaultLineMaterial,null,true);
		addMember(l,"defaultTerrainMaterial",get_defaultTerrainMaterial,null,true);
		addMember(l,"defaultUIMaterial",get_defaultUIMaterial,null,true);
		addMember(l,"defaultUIOverdrawMaterial",get_defaultUIOverdrawMaterial,null,true);
		addMember(l,"defaultUIETC1SupportedMaterial",get_defaultUIETC1SupportedMaterial,null,true);
		addMember(l,"default2DMaterial",get_default2DMaterial,null,true);
		addMember(l,"default2DMaskMaterial",get_default2DMaskMaterial,null,true);
		addMember(l,"defaultShader",get_defaultShader,null,true);
		addMember(l,"defaultSpeedTree7Shader",get_defaultSpeedTree7Shader,null,true);
		addMember(l,"defaultSpeedTree8Shader",get_defaultSpeedTree8Shader,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.RenderPipelineAsset),typeof(UnityEngine.ScriptableObject));
	}
}
