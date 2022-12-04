using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RenderTargetIdentifier : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier o;
			o=new UnityEngine.Rendering.RenderTargetIdentifier();
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
	static public int ctor__BuiltinRenderTextureType_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier o;
			UnityEngine.Rendering.BuiltinRenderTextureType a1;
			checkEnum(l,1,out a1);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1);
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
	static public int ctor__String_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier o;
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1);
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
	static public int ctor__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier o;
			System.Int32 a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1);
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
	static public int ctor__Texture_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier o;
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1);
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
	static public int ctor__BuiltinRenderTextureType__Int32__CubemapFace__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier o;
			UnityEngine.Rendering.BuiltinRenderTextureType a1;
			checkEnum(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.CubemapFace a3;
			checkEnum(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1,a2,a3,a4);
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
	static public int ctor__String__Int32__CubemapFace__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier o;
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.CubemapFace a3;
			checkEnum(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1,a2,a3,a4);
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
	static public int ctor__Int32__Int32__CubemapFace__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.CubemapFace a3;
			checkEnum(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1,a2,a3,a4);
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
	static public int ctor__RenderTargetIdentifier__Int32__CubemapFace__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier o;
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.CubemapFace a3;
			checkEnum(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1,a2,a3,a4);
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
	static public int ctor__Texture__Int32__CubemapFace__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier o;
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.CubemapFace a3;
			checkEnum(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1,a2,a3,a4);
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
	static public int ctor__RenderBuffer__Int32__CubemapFace__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier o;
			UnityEngine.RenderBuffer a1;
			checkValueType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.CubemapFace a3;
			checkEnum(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			o=new UnityEngine.Rendering.RenderTargetIdentifier(a1,a2,a3,a4);
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
	static new public int ToString(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier self;
			checkValueType(l,1,out self);
			var ret=self.ToString();
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
	static public int Equals__RenderTargetIdentifier(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			var ret=self.Equals(a1);
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
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier self;
			checkValueType(l,1,out self);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Equals(a1);
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
	static public int op_Implicit__RenderTargetIdentifier__BuiltinRenderTextureType_s(IntPtr l) {
		try {
			UnityEngine.Rendering.BuiltinRenderTextureType a1;
			checkEnum(l,1,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier ret=a1;
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
	static public int op_Implicit__RenderTargetIdentifier__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier ret=a1;
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
	static public int op_Implicit__RenderTargetIdentifier__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier ret=a1;
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
	static public int op_Implicit__RenderTargetIdentifier__Texture_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier ret=a1;
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
	static public int op_Implicit__RenderTargetIdentifier__RenderBuffer_s(IntPtr l) {
		try {
			UnityEngine.RenderBuffer a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier ret=a1;
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
	static public int op_Equality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,2,out a2);
			var ret=(a1==a2);
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
	static public int op_Inequality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,2,out a2);
			var ret=(a1!=a2);
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
	static public int get_AllDepthSlices(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.RenderTargetIdentifier.AllDepthSlices);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.RenderTargetIdentifier");
		addMember(l,ctor_s);
		addMember(l,ctor__BuiltinRenderTextureType_s);
		addMember(l,ctor__String_s);
		addMember(l,ctor__Int32_s);
		addMember(l,ctor__Texture_s);
		addMember(l,ctor__BuiltinRenderTextureType__Int32__CubemapFace__Int32_s);
		addMember(l,ctor__String__Int32__CubemapFace__Int32_s);
		addMember(l,ctor__Int32__Int32__CubemapFace__Int32_s);
		addMember(l,ctor__RenderTargetIdentifier__Int32__CubemapFace__Int32_s);
		addMember(l,ctor__Texture__Int32__CubemapFace__Int32_s);
		addMember(l,ctor__RenderBuffer__Int32__CubemapFace__Int32_s);
		addMember(l,ToString);
		addMember(l,Equals__RenderTargetIdentifier);
		addMember(l,Equals__Object);
		addMember(l,op_Implicit__RenderTargetIdentifier__BuiltinRenderTextureType_s);
		addMember(l,op_Implicit__RenderTargetIdentifier__String_s);
		addMember(l,op_Implicit__RenderTargetIdentifier__Int32_s);
		addMember(l,op_Implicit__RenderTargetIdentifier__Texture_s);
		addMember(l,op_Implicit__RenderTargetIdentifier__RenderBuffer_s);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"AllDepthSlices",get_AllDepthSlices,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(System.ValueType));
	}
}
