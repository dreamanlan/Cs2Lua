using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_U2D_SpriteDataAccessExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBindPoses_s(IntPtr l) {
		try {
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Experimental.U2D.SpriteDataAccessExtensions.GetBindPoses(a1);
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
	static public int SetBindPoses_s(IntPtr l) {
		try {
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			Unity.Collections.NativeArray<UnityEngine.Matrix4x4> a2;
			checkValueType(l,2,out a2);
			UnityEngine.Experimental.U2D.SpriteDataAccessExtensions.SetBindPoses(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetIndices_s(IntPtr l) {
		try {
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Experimental.U2D.SpriteDataAccessExtensions.GetIndices(a1);
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
	static public int SetIndices_s(IntPtr l) {
		try {
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			Unity.Collections.NativeArray<System.UInt16> a2;
			checkValueType(l,2,out a2);
			UnityEngine.Experimental.U2D.SpriteDataAccessExtensions.SetIndices(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBoneWeights_s(IntPtr l) {
		try {
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Experimental.U2D.SpriteDataAccessExtensions.GetBoneWeights(a1);
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
	static public int SetBoneWeights_s(IntPtr l) {
		try {
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			Unity.Collections.NativeArray<UnityEngine.BoneWeight> a2;
			checkValueType(l,2,out a2);
			UnityEngine.Experimental.U2D.SpriteDataAccessExtensions.SetBoneWeights(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBones_s(IntPtr l) {
		try {
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Experimental.U2D.SpriteDataAccessExtensions.GetBones(a1);
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
			UnityEngine.Experimental.U2D.SpriteBone[] a2;
			checkArray(l,2,out a2);
			UnityEngine.Experimental.U2D.SpriteDataAccessExtensions.SetBones(a1,a2);
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
			var ret=UnityEngine.Experimental.U2D.SpriteDataAccessExtensions.HasVertexAttribute(a1,a2);
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
			UnityEngine.Experimental.U2D.SpriteDataAccessExtensions.SetVertexCount(a1,a2);
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
			var ret=UnityEngine.Experimental.U2D.SpriteDataAccessExtensions.GetVertexCount(a1);
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
		getTypeTable(l,"UnityEngine.Experimental.U2D.SpriteDataAccessExtensions");
		addMember(l,GetBindPoses_s);
		addMember(l,SetBindPoses_s);
		addMember(l,GetIndices_s);
		addMember(l,SetIndices_s);
		addMember(l,GetBoneWeights_s);
		addMember(l,SetBoneWeights_s);
		addMember(l,GetBones_s);
		addMember(l,SetBones_s);
		addMember(l,HasVertexAttribute_s);
		addMember(l,SetVertexCount_s);
		addMember(l,GetVertexCount_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.U2D.SpriteDataAccessExtensions));
	}
}
