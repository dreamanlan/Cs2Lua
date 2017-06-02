using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Texture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Texture o;
			o=new UnityEngine.Texture();
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
	static public int GetNativeTexturePtr(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			var ret=self.GetNativeTexturePtr();
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
	static public int SetGlobalAnisotropicFilteringLimits_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Texture.SetGlobalAnisotropicFilteringLimits(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_masterTextureLimit(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture.masterTextureLimit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_masterTextureLimit(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.Texture.masterTextureLimit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_anisotropicFiltering(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.Texture.anisotropicFiltering);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_anisotropicFiltering(IntPtr l) {
		try {
			UnityEngine.AnisotropicFiltering v;
			checkEnum(l,2,out v);
			UnityEngine.Texture.anisotropicFiltering=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_width(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_width(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.width=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_height(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_height(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.height=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_dimension(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.dimension);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_dimension(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			UnityEngine.Rendering.TextureDimension v;
			checkEnum(l,2,out v);
			self.dimension=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_filterMode(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.filterMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_filterMode(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			UnityEngine.FilterMode v;
			checkEnum(l,2,out v);
			self.filterMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_anisoLevel(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.anisoLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_anisoLevel(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.anisoLevel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_wrapMode(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.wrapMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_wrapMode(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			UnityEngine.TextureWrapMode v;
			checkEnum(l,2,out v);
			self.wrapMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mipMapBias(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mipMapBias);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mipMapBias(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.mipMapBias=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_texelSize(IntPtr l) {
		try {
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.texelSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Texture");
		addMember(l,GetNativeTexturePtr);
		addMember(l,SetGlobalAnisotropicFilteringLimits_s);
		addMember(l,"masterTextureLimit",get_masterTextureLimit,set_masterTextureLimit,false);
		addMember(l,"anisotropicFiltering",get_anisotropicFiltering,set_anisotropicFiltering,false);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"dimension",get_dimension,set_dimension,true);
		addMember(l,"filterMode",get_filterMode,set_filterMode,true);
		addMember(l,"anisoLevel",get_anisoLevel,set_anisoLevel,true);
		addMember(l,"wrapMode",get_wrapMode,set_wrapMode,true);
		addMember(l,"mipMapBias",get_mipMapBias,set_mipMapBias,true);
		addMember(l,"texelSize",get_texelSize,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Texture),typeof(UnityEngine.Object));
	}
}
