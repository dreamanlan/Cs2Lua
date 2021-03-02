﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_RenderTargetSetup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup o;
			o=new UnityEngine.RenderTargetSetup();
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
	static public int ctor__RenderBuffer__RenderBuffer_s(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup o;
			UnityEngine.RenderBuffer a1;
			checkValueType(l,1,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,2,out a2);
			o=new UnityEngine.RenderTargetSetup(a1,a2);
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
	static public int ctor__A_RenderBuffer__RenderBuffer_s(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup o;
			UnityEngine.RenderBuffer[] a1;
			checkArray(l,1,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,2,out a2);
			o=new UnityEngine.RenderTargetSetup(a1,a2);
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
	static public int ctor__RenderBuffer__RenderBuffer__Int32_s(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup o;
			UnityEngine.RenderBuffer a1;
			checkValueType(l,1,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			o=new UnityEngine.RenderTargetSetup(a1,a2,a3);
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
	static public int ctor__A_RenderBuffer__RenderBuffer__Int32_s(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup o;
			UnityEngine.RenderBuffer[] a1;
			checkArray(l,1,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			o=new UnityEngine.RenderTargetSetup(a1,a2,a3);
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
	static public int ctor__RenderBuffer__RenderBuffer__Int32__CubemapFace_s(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup o;
			UnityEngine.RenderBuffer a1;
			checkValueType(l,1,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.CubemapFace a4;
			checkEnum(l,4,out a4);
			o=new UnityEngine.RenderTargetSetup(a1,a2,a3,a4);
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
	static public int ctor__A_RenderBuffer__RenderBuffer__Int32__CubemapFace_s(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup o;
			UnityEngine.RenderBuffer[] a1;
			checkArray(l,1,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.CubemapFace a4;
			checkEnum(l,4,out a4);
			o=new UnityEngine.RenderTargetSetup(a1,a2,a3,a4);
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
	static public int ctor__RenderBuffer__RenderBuffer__Int32__CubemapFace__Int32_s(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup o;
			UnityEngine.RenderBuffer a1;
			checkValueType(l,1,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.CubemapFace a4;
			checkEnum(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			o=new UnityEngine.RenderTargetSetup(a1,a2,a3,a4,a5);
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
	static public int ctor__A_RenderBuffer__RenderBuffer__Int32__CubemapFace__A_RenderBufferLoadAction__A_RenderBufferStoreAction__RenderBufferLoadAction__RenderBufferStoreAction_s(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup o;
			UnityEngine.RenderBuffer[] a1;
			checkArray(l,1,out a1);
			UnityEngine.RenderBuffer a2;
			checkValueType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.CubemapFace a4;
			checkEnum(l,4,out a4);
			UnityEngine.Rendering.RenderBufferLoadAction[] a5;
			checkArray(l,5,out a5);
			UnityEngine.Rendering.RenderBufferStoreAction[] a6;
			checkArray(l,6,out a6);
			UnityEngine.Rendering.RenderBufferLoadAction a7;
			checkEnum(l,7,out a7);
			UnityEngine.Rendering.RenderBufferStoreAction a8;
			checkEnum(l,8,out a8);
			o=new UnityEngine.RenderTargetSetup(a1,a2,a3,a4,a5,a6,a7,a8);
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
	static public int get_color(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.color);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_color(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			UnityEngine.RenderBuffer[] v;
			checkArray(l,2,out v);
			self.color=v;
			setBack(l,(object)self);
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
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
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
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			UnityEngine.RenderBuffer v;
			checkValueType(l,2,out v);
			self.depth=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mipLevel(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.mipLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mipLevel(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.mipLevel=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cubemapFace(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.cubemapFace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cubemapFace(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			UnityEngine.CubemapFace v;
			checkEnum(l,2,out v);
			self.cubemapFace=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depthSlice(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.depthSlice);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_depthSlice(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.depthSlice=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colorLoad(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.colorLoad);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colorLoad(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferLoadAction[] v;
			checkArray(l,2,out v);
			self.colorLoad=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colorStore(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.colorStore);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colorStore(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferStoreAction[] v;
			checkArray(l,2,out v);
			self.colorStore=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depthLoad(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.depthLoad);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_depthLoad(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferLoadAction v;
			checkEnum(l,2,out v);
			self.depthLoad=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depthStore(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.depthStore);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_depthStore(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferStoreAction v;
			checkEnum(l,2,out v);
			self.depthStore=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RenderTargetSetup");
		addMember(l,ctor_s);
		addMember(l,ctor__RenderBuffer__RenderBuffer_s);
		addMember(l,ctor__A_RenderBuffer__RenderBuffer_s);
		addMember(l,ctor__RenderBuffer__RenderBuffer__Int32_s);
		addMember(l,ctor__A_RenderBuffer__RenderBuffer__Int32_s);
		addMember(l,ctor__RenderBuffer__RenderBuffer__Int32__CubemapFace_s);
		addMember(l,ctor__A_RenderBuffer__RenderBuffer__Int32__CubemapFace_s);
		addMember(l,ctor__RenderBuffer__RenderBuffer__Int32__CubemapFace__Int32_s);
		addMember(l,ctor__A_RenderBuffer__RenderBuffer__Int32__CubemapFace__A_RenderBufferLoadAction__A_RenderBufferStoreAction__RenderBufferLoadAction__RenderBufferStoreAction_s);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"depth",get_depth,set_depth,true);
		addMember(l,"mipLevel",get_mipLevel,set_mipLevel,true);
		addMember(l,"cubemapFace",get_cubemapFace,set_cubemapFace,true);
		addMember(l,"depthSlice",get_depthSlice,set_depthSlice,true);
		addMember(l,"colorLoad",get_colorLoad,set_colorLoad,true);
		addMember(l,"colorStore",get_colorStore,set_colorStore,true);
		addMember(l,"depthLoad",get_depthLoad,set_depthLoad,true);
		addMember(l,"depthStore",get_depthStore,set_depthStore,true);
		createTypeMetatable(l,null, typeof(UnityEngine.RenderTargetSetup),typeof(System.ValueType));
	}
}
