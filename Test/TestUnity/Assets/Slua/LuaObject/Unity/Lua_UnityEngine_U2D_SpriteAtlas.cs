using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_U2D_SpriteAtlas : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSprites(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.U2D.SpriteAtlas self=(UnityEngine.U2D.SpriteAtlas)checkSelf(l);
				UnityEngine.Sprite[] a1;
				checkArray(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				var ret=self.GetSprites(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.U2D.SpriteAtlas self=(UnityEngine.U2D.SpriteAtlas)checkSelf(l);
				UnityEngine.Sprite[] a1;
				checkArray(l,2,out a1);
				var ret=self.GetSprites(a1);
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
	static public int GetSprite(IntPtr l) {
		try {
			UnityEngine.U2D.SpriteAtlas self=(UnityEngine.U2D.SpriteAtlas)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetSprite(a1);
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
	static public int get_isVariant(IntPtr l) {
		try {
			UnityEngine.U2D.SpriteAtlas self=(UnityEngine.U2D.SpriteAtlas)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isVariant);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_tag(IntPtr l) {
		try {
			UnityEngine.U2D.SpriteAtlas self=(UnityEngine.U2D.SpriteAtlas)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tag);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_spriteCount(IntPtr l) {
		try {
			UnityEngine.U2D.SpriteAtlas self=(UnityEngine.U2D.SpriteAtlas)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.spriteCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.U2D.SpriteAtlas");
		addMember(l,GetSprites);
		addMember(l,GetSprite);
		addMember(l,"isVariant",get_isVariant,null,true);
		addMember(l,"tag",get_tag,null,true);
		addMember(l,"spriteCount",get_spriteCount,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.U2D.SpriteAtlas),typeof(UnityEngine.Object));
	}
}
