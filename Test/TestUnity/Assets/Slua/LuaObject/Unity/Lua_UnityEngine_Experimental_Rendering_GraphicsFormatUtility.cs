using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_GraphicsFormatUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormatUtility o;
			o=new UnityEngine.Experimental.Rendering.GraphicsFormatUtility();
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
	static public int GetGraphicsFormat__TextureFormat__Boolean_s(IntPtr l) {
		try {
			UnityEngine.TextureFormat a1;
			checkEnum(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(a1,a2);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetGraphicsFormat__RenderTextureFormat__Boolean_s(IntPtr l) {
		try {
			UnityEngine.RenderTextureFormat a1;
			checkEnum(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(a1,a2);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetGraphicsFormat__RenderTextureFormat__RenderTextureReadWrite_s(IntPtr l) {
		try {
			UnityEngine.RenderTextureFormat a1;
			checkEnum(l,1,out a1);
			UnityEngine.RenderTextureReadWrite a2;
			checkEnum(l,2,out a2);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(a1,a2);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTextureFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetTextureFormat(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetDepthBits_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetDepthBits(a1);
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
	static public int GetDepthStencilFormat_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetDepthStencilFormat(a1,a2);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsSRGBFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsSRGBFormat(a1);
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
	static public int IsSwizzleFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsSwizzleFormat(a1);
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
	static public int GetSRGBFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetSRGBFormat(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLinearFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetLinearFormat(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetRenderTextureFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetRenderTextureFormat(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetColorComponentCount_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetColorComponentCount(a1);
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
	static public int GetAlphaComponentCount_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetAlphaComponentCount(a1);
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
	static public int GetComponentCount_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetComponentCount(a1);
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
	static public int GetFormatString_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetFormatString(a1);
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
	static public int IsCompressedFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsCompressedFormat(a1);
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
	static public int IsPackedFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsPackedFormat(a1);
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
	static public int Is16BitPackedFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.Is16BitPackedFormat(a1);
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
	static public int ConvertToAlphaFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.ConvertToAlphaFormat(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsAlphaOnlyFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsAlphaOnlyFormat(a1);
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
	static public int IsAlphaTestFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsAlphaTestFormat(a1);
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
	static public int HasAlphaChannel_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.HasAlphaChannel(a1);
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
	static public int IsDepthFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsDepthFormat(a1);
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
	static public int IsStencilFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsStencilFormat(a1);
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
	static public int IsIEEE754Format_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsIEEE754Format(a1);
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
	static public int IsFloatFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsFloatFormat(a1);
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
	static public int IsHalfFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsHalfFormat(a1);
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
	static public int IsUnsignedFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsUnsignedFormat(a1);
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
	static public int IsSignedFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsSignedFormat(a1);
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
	static public int IsNormFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsNormFormat(a1);
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
	static public int IsUNormFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsUNormFormat(a1);
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
	static public int IsSNormFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsSNormFormat(a1);
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
	static public int IsIntegerFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsIntegerFormat(a1);
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
	static public int IsUIntFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsUIntFormat(a1);
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
	static public int IsSIntFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsSIntFormat(a1);
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
	static public int IsXRFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsXRFormat(a1);
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
	static public int IsDXTCFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsDXTCFormat(a1);
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
	static public int IsRGTCFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsRGTCFormat(a1);
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
	static public int IsBPTCFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsBPTCFormat(a1);
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
	static public int IsBCFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsBCFormat(a1);
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
	static public int IsPVRTCFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsPVRTCFormat(a1);
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
	static public int IsETCFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsETCFormat(a1);
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
	static public int IsEACFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsEACFormat(a1);
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
	static public int IsASTCFormat_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsASTCFormat(a1);
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
	static public int IsCrunchFormat_s(IntPtr l) {
		try {
			UnityEngine.TextureFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsCrunchFormat(a1);
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
	static public int GetSwizzleR_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetSwizzleR(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSwizzleG_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetSwizzleG(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSwizzleB_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetSwizzleB(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSwizzleA_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetSwizzleA(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBlockSize_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockSize(a1);
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
	static public int GetBlockWidth_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockWidth(a1);
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
	static public int GetBlockHeight_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockHeight(a1);
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
	static public int ComputeMipmapSize__Int32__Int32__GraphicsFormat_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Experimental.Rendering.GraphicsFormat a3;
			checkEnum(l,3,out a3);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.ComputeMipmapSize(a1,a2,a3);
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
	static public int ComputeMipmapSize__Int32__Int32__Int32__GraphicsFormat_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.Experimental.Rendering.GraphicsFormat a4;
			checkEnum(l,4,out a4);
			var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.ComputeMipmapSize(a1,a2,a3,a4);
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
		getTypeTable(l,"UnityEngine.Experimental.Rendering.GraphicsFormatUtility");
		addMember(l,ctor_s);
		addMember(l,GetGraphicsFormat__TextureFormat__Boolean_s);
		addMember(l,GetGraphicsFormat__RenderTextureFormat__Boolean_s);
		addMember(l,GetGraphicsFormat__RenderTextureFormat__RenderTextureReadWrite_s);
		addMember(l,GetTextureFormat_s);
		addMember(l,GetDepthBits_s);
		addMember(l,GetDepthStencilFormat_s);
		addMember(l,IsSRGBFormat_s);
		addMember(l,IsSwizzleFormat_s);
		addMember(l,GetSRGBFormat_s);
		addMember(l,GetLinearFormat_s);
		addMember(l,GetRenderTextureFormat_s);
		addMember(l,GetColorComponentCount_s);
		addMember(l,GetAlphaComponentCount_s);
		addMember(l,GetComponentCount_s);
		addMember(l,GetFormatString_s);
		addMember(l,IsCompressedFormat_s);
		addMember(l,IsPackedFormat_s);
		addMember(l,Is16BitPackedFormat_s);
		addMember(l,ConvertToAlphaFormat_s);
		addMember(l,IsAlphaOnlyFormat_s);
		addMember(l,IsAlphaTestFormat_s);
		addMember(l,HasAlphaChannel_s);
		addMember(l,IsDepthFormat_s);
		addMember(l,IsStencilFormat_s);
		addMember(l,IsIEEE754Format_s);
		addMember(l,IsFloatFormat_s);
		addMember(l,IsHalfFormat_s);
		addMember(l,IsUnsignedFormat_s);
		addMember(l,IsSignedFormat_s);
		addMember(l,IsNormFormat_s);
		addMember(l,IsUNormFormat_s);
		addMember(l,IsSNormFormat_s);
		addMember(l,IsIntegerFormat_s);
		addMember(l,IsUIntFormat_s);
		addMember(l,IsSIntFormat_s);
		addMember(l,IsXRFormat_s);
		addMember(l,IsDXTCFormat_s);
		addMember(l,IsRGTCFormat_s);
		addMember(l,IsBPTCFormat_s);
		addMember(l,IsBCFormat_s);
		addMember(l,IsPVRTCFormat_s);
		addMember(l,IsETCFormat_s);
		addMember(l,IsEACFormat_s);
		addMember(l,IsASTCFormat_s);
		addMember(l,IsCrunchFormat_s);
		addMember(l,GetSwizzleR_s);
		addMember(l,GetSwizzleG_s);
		addMember(l,GetSwizzleB_s);
		addMember(l,GetSwizzleA_s);
		addMember(l,GetBlockSize_s);
		addMember(l,GetBlockWidth_s);
		addMember(l,GetBlockHeight_s);
		addMember(l,ComputeMipmapSize__Int32__Int32__GraphicsFormat_s);
		addMember(l,ComputeMipmapSize__Int32__Int32__Int32__GraphicsFormat_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.GraphicsFormatUtility));
	}
}
