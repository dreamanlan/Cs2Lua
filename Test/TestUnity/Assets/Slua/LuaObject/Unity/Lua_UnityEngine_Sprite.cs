using System;
using SLua;
using System.Collections.Generic;
using UnityEngine.U2D;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Sprite : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPhysicsShapeCount(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			var ret=self.GetPhysicsShapeCount();
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
	static public int GetPhysicsShapePointCount(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPhysicsShapePointCount(a1);
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
	static public int OverrideGeometry(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			UnityEngine.Vector2[] a1;
			checkArray(l,2,out a1);
			System.UInt16[] a2;
			checkArray(l,3,out a2);
			self.OverrideGeometry(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBones(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			var ret=self.GetBones();
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
	static public int SetBones(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			UnityEngine.U2D.SpriteBone[] a2;
			checkArray(l,2,out a2);
			self.SetBones(a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HasVertexAttribute(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			UnityEngine.Rendering.VertexAttribute a2;
			checkEnum(l,2,out a2);
			var ret=self.HasVertexAttribute(a2);
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
	static public int SetVertexCount(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			System.Int32 a2;
			checkType(l,2,out a2);
			self.SetVertexCount(a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetVertexCount(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			var ret=self.GetVertexCount();
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
	static public int Create__Texture2D__Rect__Vector2_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			UnityEngine.Rect a2;
			checkValueType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Sprite.Create(a1,a2,a3);
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
	static public int Create__Texture2D__Rect__Vector2__Single_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			UnityEngine.Rect a2;
			checkValueType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Sprite.Create(a1,a2,a3,a4);
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
	static public int Create__Texture2D__Rect__Vector2__Single__UInt32_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			UnityEngine.Rect a2;
			checkValueType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.UInt32 a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Sprite.Create(a1,a2,a3,a4,a5);
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
	static public int Create__Texture2D__Rect__Vector2__Single__UInt32__SpriteMeshType_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			UnityEngine.Rect a2;
			checkValueType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.UInt32 a5;
			checkType(l,5,out a5);
			UnityEngine.SpriteMeshType a6;
			checkEnum(l,6,out a6);
			var ret=UnityEngine.Sprite.Create(a1,a2,a3,a4,a5,a6);
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
	static public int Create__Texture2D__Rect__Vector2__Single__UInt32__SpriteMeshType__Vector4_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			UnityEngine.Rect a2;
			checkValueType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.UInt32 a5;
			checkType(l,5,out a5);
			UnityEngine.SpriteMeshType a6;
			checkEnum(l,6,out a6);
			UnityEngine.Vector4 a7;
			checkType(l,7,out a7);
			var ret=UnityEngine.Sprite.Create(a1,a2,a3,a4,a5,a6,a7);
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
	static public int Create__Texture2D__Rect__Vector2__Single__UInt32__SpriteMeshType__Vector4__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			UnityEngine.Rect a2;
			checkValueType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.UInt32 a5;
			checkType(l,5,out a5);
			UnityEngine.SpriteMeshType a6;
			checkEnum(l,6,out a6);
			UnityEngine.Vector4 a7;
			checkType(l,7,out a7);
			System.Boolean a8;
			checkType(l,8,out a8);
			var ret=UnityEngine.Sprite.Create(a1,a2,a3,a4,a5,a6,a7,a8);
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
	static public int get_bounds(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bounds);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rect(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_border(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.border);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_texture(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.texture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pixelsPerUnit(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pixelsPerUnit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_spriteAtlasTextureScale(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.spriteAtlasTextureScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_associatedAlphaSplitTexture(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.associatedAlphaSplitTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pivot(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pivot);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isUsingPlaceholder(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isUsingPlaceholder);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_packed(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.packed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_packingMode(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.packingMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_packingRotation(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.packingRotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_textureRect(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textureRect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_textureRectOffset(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textureRectOffset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_vertices(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vertices);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_triangles(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.triangles);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_uv(IntPtr l) {
		try {
			UnityEngine.Sprite self=(UnityEngine.Sprite)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uv);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Sprite");
		addMember(l,GetPhysicsShapeCount);
		addMember(l,GetPhysicsShapePointCount);
		addMember(l,OverrideGeometry);
		addMember(l,GetBones);
		addMember(l,SetBones);
		addMember(l,HasVertexAttribute);
		addMember(l,SetVertexCount);
		addMember(l,GetVertexCount);
		addMember(l,Create__Texture2D__Rect__Vector2_s);
		addMember(l,Create__Texture2D__Rect__Vector2__Single_s);
		addMember(l,Create__Texture2D__Rect__Vector2__Single__UInt32_s);
		addMember(l,Create__Texture2D__Rect__Vector2__Single__UInt32__SpriteMeshType_s);
		addMember(l,Create__Texture2D__Rect__Vector2__Single__UInt32__SpriteMeshType__Vector4_s);
		addMember(l,Create__Texture2D__Rect__Vector2__Single__UInt32__SpriteMeshType__Vector4__Boolean_s);
		addMember(l,"bounds",get_bounds,null,true);
		addMember(l,"rect",get_rect,null,true);
		addMember(l,"border",get_border,null,true);
		addMember(l,"texture",get_texture,null,true);
		addMember(l,"pixelsPerUnit",get_pixelsPerUnit,null,true);
		addMember(l,"spriteAtlasTextureScale",get_spriteAtlasTextureScale,null,true);
		addMember(l,"associatedAlphaSplitTexture",get_associatedAlphaSplitTexture,null,true);
		addMember(l,"pivot",get_pivot,null,true);
		addMember(l,"isUsingPlaceholder",get_isUsingPlaceholder,null,true);
		addMember(l,"packed",get_packed,null,true);
		addMember(l,"packingMode",get_packingMode,null,true);
		addMember(l,"packingRotation",get_packingRotation,null,true);
		addMember(l,"textureRect",get_textureRect,null,true);
		addMember(l,"textureRectOffset",get_textureRectOffset,null,true);
		addMember(l,"vertices",get_vertices,null,true);
		addMember(l,"triangles",get_triangles,null,true);
		addMember(l,"uv",get_uv,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Sprite),typeof(UnityEngine.Object));
	}
}
