using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_CustomRenderTexture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			o=new UnityEngine.CustomRenderTexture(a1,a2);
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
	static public int ctor__Int32__Int32__RenderTextureFormat_s(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.RenderTextureFormat a3;
			checkEnum(l,3,out a3);
			o=new UnityEngine.CustomRenderTexture(a1,a2,a3);
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
	static public int ctor__Int32__Int32__DefaultFormat_s(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Experimental.Rendering.DefaultFormat a3;
			checkEnum(l,3,out a3);
			o=new UnityEngine.CustomRenderTexture(a1,a2,a3);
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
	static public int ctor__Int32__Int32__GraphicsFormat_s(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Experimental.Rendering.GraphicsFormat a3;
			checkEnum(l,3,out a3);
			o=new UnityEngine.CustomRenderTexture(a1,a2,a3);
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
	static public int ctor__Int32__Int32__RenderTextureFormat__RenderTextureReadWrite_s(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.RenderTextureFormat a3;
			checkEnum(l,3,out a3);
			UnityEngine.RenderTextureReadWrite a4;
			checkEnum(l,4,out a4);
			o=new UnityEngine.CustomRenderTexture(a1,a2,a3,a4);
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
	static public int Update(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			self.Update();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Update__Int32(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.Update(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Initialize(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			self.Initialize();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearUpdateZones(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			self.ClearUpdateZones();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetDoubleBufferRenderTexture(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			var ret=self.GetDoubleBufferRenderTexture();
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
	static public int EnsureDoubleBufferConsistency(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			self.EnsureDoubleBufferConsistency();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetUpdateZones(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			UnityEngine.CustomRenderTextureUpdateZone[] a1;
			checkArray(l,2,out a1);
			self.SetUpdateZones(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_material(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.material);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_material(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			UnityEngine.Material v;
			checkType(l,2,out v);
			self.material=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_initializationMaterial(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.initializationMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_initializationMaterial(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			UnityEngine.Material v;
			checkType(l,2,out v);
			self.initializationMaterial=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_initializationTexture(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.initializationTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_initializationTexture(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			UnityEngine.Texture v;
			checkType(l,2,out v);
			self.initializationTexture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_initializationSource(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.initializationSource);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_initializationSource(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			UnityEngine.CustomRenderTextureInitializationSource v;
			checkEnum(l,2,out v);
			self.initializationSource=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_initializationColor(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.initializationColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_initializationColor(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.initializationColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_updateMode(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.updateMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_updateMode(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			UnityEngine.CustomRenderTextureUpdateMode v;
			checkEnum(l,2,out v);
			self.updateMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_initializationMode(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.initializationMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_initializationMode(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			UnityEngine.CustomRenderTextureUpdateMode v;
			checkEnum(l,2,out v);
			self.initializationMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_updateZoneSpace(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.updateZoneSpace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_updateZoneSpace(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			UnityEngine.CustomRenderTextureUpdateZoneSpace v;
			checkEnum(l,2,out v);
			self.updateZoneSpace=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_shaderPass(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shaderPass);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shaderPass(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.shaderPass=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cubemapFaceMask(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cubemapFaceMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cubemapFaceMask(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			System.UInt32 v;
			checkType(l,2,out v);
			self.cubemapFaceMask=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_doubleBuffered(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.doubleBuffered);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_doubleBuffered(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.doubleBuffered=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_wrapUpdateZones(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.wrapUpdateZones);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_wrapUpdateZones(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.wrapUpdateZones=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_updatePeriod(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.updatePeriod);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_updatePeriod(IntPtr l) {
		try {
			UnityEngine.CustomRenderTexture self=(UnityEngine.CustomRenderTexture)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.updatePeriod=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CustomRenderTexture");
		addMember(l,ctor__Int32__Int32_s);
		addMember(l,ctor__Int32__Int32__RenderTextureFormat_s);
		addMember(l,ctor__Int32__Int32__DefaultFormat_s);
		addMember(l,ctor__Int32__Int32__GraphicsFormat_s);
		addMember(l,ctor__Int32__Int32__RenderTextureFormat__RenderTextureReadWrite_s);
		addMember(l,Update);
		addMember(l,Update__Int32);
		addMember(l,Initialize);
		addMember(l,ClearUpdateZones);
		addMember(l,GetDoubleBufferRenderTexture);
		addMember(l,EnsureDoubleBufferConsistency);
		addMember(l,SetUpdateZones);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"initializationMaterial",get_initializationMaterial,set_initializationMaterial,true);
		addMember(l,"initializationTexture",get_initializationTexture,set_initializationTexture,true);
		addMember(l,"initializationSource",get_initializationSource,set_initializationSource,true);
		addMember(l,"initializationColor",get_initializationColor,set_initializationColor,true);
		addMember(l,"updateMode",get_updateMode,set_updateMode,true);
		addMember(l,"initializationMode",get_initializationMode,set_initializationMode,true);
		addMember(l,"updateZoneSpace",get_updateZoneSpace,set_updateZoneSpace,true);
		addMember(l,"shaderPass",get_shaderPass,set_shaderPass,true);
		addMember(l,"cubemapFaceMask",get_cubemapFaceMask,set_cubemapFaceMask,true);
		addMember(l,"doubleBuffered",get_doubleBuffered,set_doubleBuffered,true);
		addMember(l,"wrapUpdateZones",get_wrapUpdateZones,set_wrapUpdateZones,true);
		addMember(l,"updatePeriod",get_updatePeriod,set_updatePeriod,true);
		createTypeMetatable(l,null, typeof(UnityEngine.CustomRenderTexture),typeof(UnityEngine.RenderTexture));
	}
}
