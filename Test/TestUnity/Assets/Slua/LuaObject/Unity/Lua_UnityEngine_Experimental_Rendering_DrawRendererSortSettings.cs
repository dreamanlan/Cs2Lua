using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_DrawRendererSortSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSortSettings o;
			o=new UnityEngine.Experimental.Rendering.DrawRendererSortSettings();
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
	static public int get_worldToCameraMatrix(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSortSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.worldToCameraMatrix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_worldToCameraMatrix(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSortSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Matrix4x4 v;
			checkValueType(l,2,out v);
			self.worldToCameraMatrix=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cameraPosition(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSortSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.cameraPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cameraPosition(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSortSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.cameraPosition=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_flags(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSortSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.flags);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_flags(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSortSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.SortFlags v;
			checkEnum(l,2,out v);
			self.flags=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sortOrthographic(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSortSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sortOrthographic);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sortOrthographic(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawRendererSortSettings self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.sortOrthographic=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.DrawRendererSortSettings");
		addMember(l,"worldToCameraMatrix",get_worldToCameraMatrix,set_worldToCameraMatrix,true);
		addMember(l,"cameraPosition",get_cameraPosition,set_cameraPosition,true);
		addMember(l,"flags",get_flags,set_flags,true);
		addMember(l,"sortOrthographic",get_sortOrthographic,set_sortOrthographic,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.DrawRendererSortSettings),typeof(System.ValueType));
	}
}
