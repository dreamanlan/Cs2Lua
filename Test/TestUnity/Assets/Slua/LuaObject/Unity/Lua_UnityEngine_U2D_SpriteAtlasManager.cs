using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_U2D_SpriteAtlasManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.U2D.SpriteAtlasManager o;
			o=new UnityEngine.U2D.SpriteAtlasManager();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.U2D.SpriteAtlasManager");
		addMember(l,ctor_s);
		createTypeMetatable(l,null, typeof(UnityEngine.U2D.SpriteAtlasManager));
	}
}
