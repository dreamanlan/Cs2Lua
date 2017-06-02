using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_RenderTexture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.RenderTexture o;
			if(argc==6){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				UnityEngine.RenderTextureFormat a4;
				checkEnum(l,5,out a4);
				UnityEngine.RenderTextureReadWrite a5;
				checkEnum(l,6,out a5);
				o=new UnityEngine.RenderTexture(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==5){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				UnityEngine.RenderTextureFormat a4;
				checkEnum(l,5,out a4);
				o=new UnityEngine.RenderTexture(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==4){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				o=new UnityEngine.RenderTexture(a1,a2,a3);
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
	static public int Create(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			var ret=self.Create();
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
	static public int Release(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			self.Release();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsCreated(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			var ret=self.IsCreated();
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
	static public int DiscardContents(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
				self.DiscardContents();
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.DiscardContents(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int MarkRestoreExpected(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			self.MarkRestoreExpected();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GenerateMips(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			self.GenerateMips();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetNativeDepthBufferPtr(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			var ret=self.GetNativeDepthBufferPtr();
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
	static public int SetGlobalShaderProperty(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.SetGlobalShaderProperty(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTemporary_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.RenderTexture.GetTemporary(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.RenderTexture.GetTemporary(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RenderTextureFormat a4;
				checkEnum(l,4,out a4);
				var ret=UnityEngine.RenderTexture.GetTemporary(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RenderTextureFormat a4;
				checkEnum(l,4,out a4);
				UnityEngine.RenderTextureReadWrite a5;
				checkEnum(l,5,out a5);
				var ret=UnityEngine.RenderTexture.GetTemporary(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==6){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RenderTextureFormat a4;
				checkEnum(l,4,out a4);
				UnityEngine.RenderTextureReadWrite a5;
				checkEnum(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.RenderTexture.GetTemporary(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReleaseTemporary_s(IntPtr l) {
		try {
			UnityEngine.RenderTexture a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture.ReleaseTemporary(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SupportsStencil_s(IntPtr l) {
		try {
			UnityEngine.RenderTexture a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.RenderTexture.SupportsStencil(a1);
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
	static public int get_width(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
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
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
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
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
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
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
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
	static public int get_depth(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.depth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_depth(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.depth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isPowerOfTwo(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isPowerOfTwo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isPowerOfTwo(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.isPowerOfTwo=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sRGB(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sRGB);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_format(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.format);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_format(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			UnityEngine.RenderTextureFormat v;
			checkEnum(l,2,out v);
			self.format=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useMipMap(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useMipMap);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useMipMap(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useMipMap=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autoGenerateMips(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoGenerateMips);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_autoGenerateMips(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoGenerateMips=v;
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
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
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
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
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
	static public int get_volumeDepth(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.volumeDepth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_volumeDepth(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.volumeDepth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_antiAliasing(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.antiAliasing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_antiAliasing(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.antiAliasing=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableRandomWrite(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enableRandomWrite);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableRandomWrite(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enableRandomWrite=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colorBuffer(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.colorBuffer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depthBuffer(IntPtr l) {
		try {
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.depthBuffer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_active(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.RenderTexture.active);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_active(IntPtr l) {
		try {
			UnityEngine.RenderTexture v;
			checkType(l,2,out v);
			UnityEngine.RenderTexture.active=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RenderTexture");
		addMember(l,Create);
		addMember(l,Release);
		addMember(l,IsCreated);
		addMember(l,DiscardContents);
		addMember(l,MarkRestoreExpected);
		addMember(l,GenerateMips);
		addMember(l,GetNativeDepthBufferPtr);
		addMember(l,SetGlobalShaderProperty);
		addMember(l,GetTemporary_s);
		addMember(l,ReleaseTemporary_s);
		addMember(l,SupportsStencil_s);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"depth",get_depth,set_depth,true);
		addMember(l,"isPowerOfTwo",get_isPowerOfTwo,set_isPowerOfTwo,true);
		addMember(l,"sRGB",get_sRGB,null,true);
		addMember(l,"format",get_format,set_format,true);
		addMember(l,"useMipMap",get_useMipMap,set_useMipMap,true);
		addMember(l,"autoGenerateMips",get_autoGenerateMips,set_autoGenerateMips,true);
		addMember(l,"dimension",get_dimension,set_dimension,true);
		addMember(l,"volumeDepth",get_volumeDepth,set_volumeDepth,true);
		addMember(l,"antiAliasing",get_antiAliasing,set_antiAliasing,true);
		addMember(l,"enableRandomWrite",get_enableRandomWrite,set_enableRandomWrite,true);
		addMember(l,"colorBuffer",get_colorBuffer,null,true);
		addMember(l,"depthBuffer",get_depthBuffer,null,true);
		addMember(l,"active",get_active,set_active,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.RenderTexture),typeof(UnityEngine.Texture));
	}
}
