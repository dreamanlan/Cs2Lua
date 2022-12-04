using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Texture3D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__Int32__Int32__Int32__DefaultFormat__TextureCreationFlags_s(IntPtr l) {
		try {
			UnityEngine.Texture3D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.Experimental.Rendering.DefaultFormat a4;
			checkEnum(l,4,out a4);
			UnityEngine.Experimental.Rendering.TextureCreationFlags a5;
			checkEnum(l,5,out a5);
			o=new UnityEngine.Texture3D(a1,a2,a3,a4,a5);
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
	static public int ctor__Int32__Int32__Int32__GraphicsFormat__TextureCreationFlags_s(IntPtr l) {
		try {
			UnityEngine.Texture3D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.Experimental.Rendering.GraphicsFormat a4;
			checkEnum(l,4,out a4);
			UnityEngine.Experimental.Rendering.TextureCreationFlags a5;
			checkEnum(l,5,out a5);
			o=new UnityEngine.Texture3D(a1,a2,a3,a4,a5);
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
	static public int ctor__Int32__Int32__Int32__TextureFormat__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture3D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.TextureFormat a4;
			checkEnum(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			o=new UnityEngine.Texture3D(a1,a2,a3,a4,a5);
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
	static public int ctor__Int32__Int32__Int32__TextureFormat__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Texture3D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.TextureFormat a4;
			checkEnum(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			o=new UnityEngine.Texture3D(a1,a2,a3,a4,a5);
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
	static public int ctor__Int32__Int32__Int32__GraphicsFormat__TextureCreationFlags__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture3D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.Experimental.Rendering.GraphicsFormat a4;
			checkEnum(l,4,out a4);
			UnityEngine.Experimental.Rendering.TextureCreationFlags a5;
			checkEnum(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			o=new UnityEngine.Texture3D(a1,a2,a3,a4,a5,a6);
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
	static public int ctor__Int32__Int32__Int32__TextureFormat__Int32__IntPtr_s(IntPtr l) {
		try {
			UnityEngine.Texture3D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.TextureFormat a4;
			checkEnum(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			System.IntPtr a6;
			checkType(l,6,out a6);
			o=new UnityEngine.Texture3D(a1,a2,a3,a4,a5,a6);
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
	static public int ctor__Int32__Int32__Int32__TextureFormat__Boolean__IntPtr_s(IntPtr l) {
		try {
			UnityEngine.Texture3D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.TextureFormat a4;
			checkEnum(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			System.IntPtr a6;
			checkType(l,6,out a6);
			o=new UnityEngine.Texture3D(a1,a2,a3,a4,a5,a6);
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
	static public int UpdateExternalTexture(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			System.IntPtr a1;
			checkType(l,2,out a1);
			self.UpdateExternalTexture(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPixels(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			var ret=self.GetPixels();
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
	static public int GetPixels__Int32(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPixels(a1);
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
	static public int GetPixels32(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			var ret=self.GetPixels32();
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
	static public int GetPixels32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPixels32(a1);
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
	static public int SetPixels__A_Color(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			UnityEngine.Color[] a1;
			checkArray(l,2,out a1);
			self.SetPixels(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixels__A_Color__Int32(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			UnityEngine.Color[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetPixels(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixels32__A_Color32(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			UnityEngine.Color32[] a1;
			checkArray(l,2,out a1);
			self.SetPixels32(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixels32__A_Color32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			UnityEngine.Color32[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetPixels32(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Apply(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			self.Apply();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Apply__Boolean(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Apply(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Apply__Boolean__Boolean(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.Apply(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixel__Int32__Int32__Int32__Color(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Color a4;
			checkType(l,5,out a4);
			self.SetPixel(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixel__Int32__Int32__Int32__Color__Int32(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Color a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetPixel(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPixel__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.GetPixel(a1,a2,a3);
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
	static public int GetPixel__Int32__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			var ret=self.GetPixel(a1,a2,a3,a4);
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
	static public int GetPixelBilinear__Single__Single__Single(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			var ret=self.GetPixelBilinear(a1,a2,a3);
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
	static public int GetPixelBilinear__Single__Single__Single__Int32(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			var ret=self.GetPixelBilinear(a1,a2,a3,a4);
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
	static public int CreateExternalTexture_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.TextureFormat a4;
			checkEnum(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			System.IntPtr a6;
			checkType(l,6,out a6);
			var ret=UnityEngine.Texture3D.CreateExternalTexture(a1,a2,a3,a4,a5,a6);
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
	static public int get_depth(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
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
	static public int get_format(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
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
	static public int get_isReadable(IntPtr l) {
		try {
			UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isReadable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Texture3D");
		addMember(l,ctor__Int32__Int32__Int32__DefaultFormat__TextureCreationFlags_s);
		addMember(l,ctor__Int32__Int32__Int32__GraphicsFormat__TextureCreationFlags_s);
		addMember(l,ctor__Int32__Int32__Int32__TextureFormat__Int32_s);
		addMember(l,ctor__Int32__Int32__Int32__TextureFormat__Boolean_s);
		addMember(l,ctor__Int32__Int32__Int32__GraphicsFormat__TextureCreationFlags__Int32_s);
		addMember(l,ctor__Int32__Int32__Int32__TextureFormat__Int32__IntPtr_s);
		addMember(l,ctor__Int32__Int32__Int32__TextureFormat__Boolean__IntPtr_s);
		addMember(l,UpdateExternalTexture);
		addMember(l,GetPixels);
		addMember(l,GetPixels__Int32);
		addMember(l,GetPixels32);
		addMember(l,GetPixels32__Int32);
		addMember(l,SetPixels__A_Color);
		addMember(l,SetPixels__A_Color__Int32);
		addMember(l,SetPixels32__A_Color32);
		addMember(l,SetPixels32__A_Color32__Int32);
		addMember(l,Apply);
		addMember(l,Apply__Boolean);
		addMember(l,Apply__Boolean__Boolean);
		addMember(l,SetPixel__Int32__Int32__Int32__Color);
		addMember(l,SetPixel__Int32__Int32__Int32__Color__Int32);
		addMember(l,GetPixel__Int32__Int32__Int32);
		addMember(l,GetPixel__Int32__Int32__Int32__Int32);
		addMember(l,GetPixelBilinear__Single__Single__Single);
		addMember(l,GetPixelBilinear__Single__Single__Single__Int32);
		addMember(l,CreateExternalTexture_s);
		addMember(l,"depth",get_depth,null,true);
		addMember(l,"format",get_format,null,true);
		addMember(l,"isReadable",get_isReadable,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Texture3D),typeof(UnityEngine.Texture));
	}
}
