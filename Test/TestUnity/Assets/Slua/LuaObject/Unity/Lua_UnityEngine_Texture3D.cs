using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Texture3D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Texture3D o;
			if(matchType(l, "ctor__Void__Int32__Int32__Int32__GraphicsFormat__TextureCreationFlags", argc, 2,typeof(int),typeof(int),typeof(int),typeof(UnityEngine.Experimental.Rendering.GraphicsFormat),typeof(UnityEngine.Experimental.Rendering.TextureCreationFlags))){
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.Experimental.Rendering.GraphicsFormat a4;
				checkEnum(l,6,out a4);
				UnityEngine.Experimental.Rendering.TextureCreationFlags a5;
				checkEnum(l,7,out a5);
				o=new UnityEngine.Texture3D(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l, "ctor__Void__Int32__Int32__Int32__TextureFormat__Boolean", argc, 2,typeof(int),typeof(int),typeof(int),typeof(UnityEngine.TextureFormat),typeof(bool))){
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				UnityEngine.TextureFormat a4;
				checkEnum(l,6,out a4);
				System.Boolean a5;
				checkType(l,7,out a5);
				o=new UnityEngine.Texture3D(a1,a2,a3,a4,a5);
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
	static public int GetPixels(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				var ret=self.GetPixels(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				var ret=self.GetPixels();
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
	static public int GetPixels32(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				var ret=self.GetPixels32(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				var ret=self.GetPixels32();
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
	static public int SetPixels(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				UnityEngine.Color[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				self.SetPixels(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				UnityEngine.Color[] a1;
				checkArray(l,3,out a1);
				self.SetPixels(a1);
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
	static public int SetPixels32(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				UnityEngine.Color32[] a1;
				checkArray(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				self.SetPixels32(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				UnityEngine.Color32[] a1;
				checkArray(l,3,out a1);
				self.SetPixels32(a1);
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
	static public int Apply(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				System.Boolean a1;
				checkType(l,3,out a1);
				System.Boolean a2;
				checkType(l,4,out a2);
				self.Apply(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				System.Boolean a1;
				checkType(l,3,out a1);
				self.Apply(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Texture3D self=(UnityEngine.Texture3D)checkSelf(l);
				self.Apply();
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
		addMember(l,GetPixels);
		addMember(l,GetPixels32);
		addMember(l,SetPixels);
		addMember(l,SetPixels32);
		addMember(l,Apply);
		addMember(l,"depth",get_depth,null,true);
		addMember(l,"format",get_format,null,true);
		addMember(l,"isReadable",get_isReadable,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Texture3D),typeof(UnityEngine.Texture));
	}
}
