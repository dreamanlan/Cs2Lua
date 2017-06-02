using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_BillboardAsset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
	static public int GetImageTexCoords(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
				var ret=self.GetImageTexCoords();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
				System.Collections.Generic.List<UnityEngine.Vector4> a1;
				checkType(l,2,out a1);
				self.GetImageTexCoords(a1);
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
	static public int SetImageTexCoords(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Vector4[]))){
				UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
				UnityEngine.Vector4[] a1;
				checkArray(l,2,out a1);
				self.SetImageTexCoords(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(List<UnityEngine.Vector4>))){
				UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
				System.Collections.Generic.List<UnityEngine.Vector4> a1;
				checkType(l,2,out a1);
				self.SetImageTexCoords(a1);
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
	static public int GetVertices(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
				var ret=self.GetVertices();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
				System.Collections.Generic.List<UnityEngine.Vector2> a1;
				checkType(l,2,out a1);
				self.GetVertices(a1);
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
	static public int SetVertices(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Vector2[]))){
				UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
				UnityEngine.Vector2[] a1;
				checkArray(l,2,out a1);
				self.SetVertices(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(List<UnityEngine.Vector2>))){
				UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
				System.Collections.Generic.List<UnityEngine.Vector2> a1;
				checkType(l,2,out a1);
				self.SetVertices(a1);
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
	static public int GetIndices(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
				var ret=self.GetIndices();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
				System.Collections.Generic.List<System.UInt16> a1;
				checkType(l,2,out a1);
				self.GetIndices(a1);
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
	static public int SetIndices(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(System.UInt16[]))){
				UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
				System.UInt16[] a1;
				checkArray(l,2,out a1);
				self.SetIndices(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(List<System.UInt16>))){
				UnityEngine.BillboardAsset self=(UnityEngine.BillboardAsset)checkSelf(l);
				System.Collections.Generic.List<System.UInt16> a1;
				checkType(l,2,out a1);
				self.SetIndices(a1);
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.BillboardAsset");
		addMember(l,GetImageTexCoords);
		addMember(l,SetImageTexCoords);
		addMember(l,GetVertices);
		addMember(l,SetVertices);
		addMember(l,GetIndices);
		addMember(l,SetIndices);
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
