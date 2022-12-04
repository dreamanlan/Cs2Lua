using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_U2D_SpriteDataAccessExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBones_s(IntPtr l) {
		try {
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.U2D.SpriteDataAccessExtensions.GetBones(a1);
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
	static public int SetBones_s(IntPtr l) {
		try {
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			UnityEngine.U2D.SpriteBone[] a2;
			checkArray(l,2,out a2);
			UnityEngine.U2D.SpriteDataAccessExtensions.SetBones(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HasVertexAttribute_s(IntPtr l) {
		try {
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			UnityEngine.Rendering.VertexAttribute a2;
			checkEnum(l,2,out a2);
			var ret=UnityEngine.U2D.SpriteDataAccessExtensions.HasVertexAttribute(a1,a2);
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
	static public int SetVertexCount_s(IntPtr l) {
		try {
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.U2D.SpriteDataAccessExtensions.SetVertexCount(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetVertexCount_s(IntPtr l) {
		try {
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.U2D.SpriteDataAccessExtensions.GetVertexCount(a1);
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
		getTypeTable(l,"UnityEngine.U2D.SpriteDataAccessExtensions");
		addMember(l,GetBones_s);
		addMember(l,SetBones_s);
		addMember(l,HasVertexAttribute_s);
		addMember(l,SetVertexCount_s);
		addMember(l,GetVertexCount_s);
		createTypeMetatable(l,null, typeof(UnityEngine.U2D.SpriteDataAccessExtensions));
	}
}
