using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Texture2DArray : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__Int32__Int32__Int32__DefaultFormat__TextureCreationFlags_s(IntPtr l) {
		try {
			UnityEngine.Texture2DArray o;
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
			o=new UnityEngine.Texture2DArray(a1,a2,a3,a4,a5);
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
			UnityEngine.Texture2DArray o;
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
			o=new UnityEngine.Texture2DArray(a1,a2,a3,a4,a5);
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
			UnityEngine.Texture2DArray o;
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
			o=new UnityEngine.Texture2DArray(a1,a2,a3,a4,a5);
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
			UnityEngine.Texture2DArray o;
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
			o=new UnityEngine.Texture2DArray(a1,a2,a3,a4,a5,a6);
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
	static public int ctor__Int32__Int32__Int32__TextureFormat__Int32__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Texture2DArray o;
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
			System.Boolean a6;
			checkType(l,6,out a6);
			o=new UnityEngine.Texture2DArray(a1,a2,a3,a4,a5,a6);
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
	static public int ctor__Int32__Int32__Int32__TextureFormat__Boolean__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Texture2DArray o;
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
			System.Boolean a6;
			checkType(l,6,out a6);
			o=new UnityEngine.Texture2DArray(a1,a2,a3,a4,a5,a6);
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
	static public int GetPixels__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
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
	static public int GetPixels__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.GetPixels(a1,a2);
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
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
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
	static public int GetPixels32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.GetPixels32(a1,a2);
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
	static public int SetPixels__A_Color__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
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
	static public int SetPixels__A_Color__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
			UnityEngine.Color[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.SetPixels(a1,a2,a3);
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
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
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
	static public int SetPixels32__A_Color32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
			UnityEngine.Color32[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.SetPixels32(a1,a2,a3);
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
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
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
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
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
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
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
	static public int get_allSlices(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture2DArray.allSlices);
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
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
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
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
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
			UnityEngine.Texture2DArray self=(UnityEngine.Texture2DArray)checkSelf(l);
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
		getTypeTable(l,"UnityEngine.Texture2DArray");
		addMember(l,ctor__Int32__Int32__Int32__DefaultFormat__TextureCreationFlags_s);
		addMember(l,ctor__Int32__Int32__Int32__GraphicsFormat__TextureCreationFlags_s);
		addMember(l,ctor__Int32__Int32__Int32__TextureFormat__Boolean_s);
		addMember(l,ctor__Int32__Int32__Int32__GraphicsFormat__TextureCreationFlags__Int32_s);
		addMember(l,ctor__Int32__Int32__Int32__TextureFormat__Int32__Boolean_s);
		addMember(l,ctor__Int32__Int32__Int32__TextureFormat__Boolean__Boolean_s);
		addMember(l,GetPixels__Int32);
		addMember(l,GetPixels__Int32__Int32);
		addMember(l,GetPixels32__Int32);
		addMember(l,GetPixels32__Int32__Int32);
		addMember(l,SetPixels__A_Color__Int32);
		addMember(l,SetPixels__A_Color__Int32__Int32);
		addMember(l,SetPixels32__A_Color32__Int32);
		addMember(l,SetPixels32__A_Color32__Int32__Int32);
		addMember(l,Apply);
		addMember(l,Apply__Boolean);
		addMember(l,Apply__Boolean__Boolean);
		addMember(l,"allSlices",get_allSlices,null,false);
		addMember(l,"depth",get_depth,null,true);
		addMember(l,"format",get_format,null,true);
		addMember(l,"isReadable",get_isReadable,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Texture2DArray),typeof(UnityEngine.Texture));
	}
}
