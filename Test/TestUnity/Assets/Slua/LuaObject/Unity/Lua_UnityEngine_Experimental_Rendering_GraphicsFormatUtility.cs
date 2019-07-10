using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_GraphicsFormatUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
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
	static public int GetGraphicsFormat_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "GetGraphicsFormat__TextureFormat__Boolean", argc, 1,typeof(UnityEngine.TextureFormat),typeof(bool))){
				UnityEngine.TextureFormat a1;
				checkEnum(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(a1,a2);
				pushValue(l,true);
				pushEnum(l,(int)ret);
				return 2;
			}
			else if(matchType(l, "GetGraphicsFormat__RenderTextureFormat__Boolean", argc, 1,typeof(UnityEngine.RenderTextureFormat),typeof(bool))){
				UnityEngine.RenderTextureFormat a1;
				checkEnum(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(a1,a2);
				pushValue(l,true);
				pushEnum(l,(int)ret);
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
	static public int ComputeMipmapSize_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				UnityEngine.Experimental.Rendering.GraphicsFormat a4;
				checkEnum(l,5,out a4);
				var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.ComputeMipmapSize(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.Experimental.Rendering.GraphicsFormat a3;
				checkEnum(l,4,out a3);
				var ret=UnityEngine.Experimental.Rendering.GraphicsFormatUtility.ComputeMipmapSize(a1,a2,a3);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.GraphicsFormatUtility");
		addMember(l,GetGraphicsFormat_s);
		addMember(l,GetTextureFormat_s);
		addMember(l,IsSRGBFormat_s);
		addMember(l,GetRenderTextureFormat_s);
		addMember(l,GetColorComponentCount_s);
		addMember(l,GetAlphaComponentCount_s);
		addMember(l,GetComponentCount_s);
		addMember(l,IsCompressedFormat_s);
		addMember(l,IsPackedFormat_s);
		addMember(l,Is16BitPackedFormat_s);
		addMember(l,ConvertToAlphaFormat_s);
		addMember(l,IsAlphaOnlyFormat_s);
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
		addMember(l,IsDXTCFormat_s);
		addMember(l,IsRGTCFormat_s);
		addMember(l,IsBPTCFormat_s);
		addMember(l,IsBCFormat_s);
		addMember(l,IsPVRTCFormat_s);
		addMember(l,IsETCFormat_s);
		addMember(l,IsASTCFormat_s);
		addMember(l,IsCrunchFormat_s);
		addMember(l,GetBlockSize_s);
		addMember(l,GetBlockWidth_s);
		addMember(l,GetBlockHeight_s);
		addMember(l,ComputeMipmapSize_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.GraphicsFormatUtility));
	}
}
