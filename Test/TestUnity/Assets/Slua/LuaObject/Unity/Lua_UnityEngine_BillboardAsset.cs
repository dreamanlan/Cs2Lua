using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_BillboardAsset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.BillboardAsset o;
			o=new UnityEngine.BillboardAsset();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		try {
			UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		try {
			UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
			float v;
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
	static public int get_height(IntPtr l) {
		try {
			UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		try {
			UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
			float v;
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
	static public int get_bottom(IntPtr l) {
		try {
			UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bottom);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bottom(IntPtr l) {
		try {
			UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.bottom=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_imageCount(IntPtr l) {
		try {
			UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.imageCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertexCount(IntPtr l) {
		try {
			UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vertexCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_indexCount(IntPtr l) {
		try {
			UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.indexCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		try {
			UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.material);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		try {
			UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
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
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.BillboardAsset");
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"bottom",get_bottom,set_bottom,true);
		addMember(l,"imageCount",get_imageCount,null,true);
		addMember(l,"vertexCount",get_vertexCount,null,true);
		addMember(l,"indexCount",get_indexCount,null,true);
		addMember(l,"material",get_material,set_material,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.BillboardAsset),typeof(UnityEngine.Object));
	}
}
