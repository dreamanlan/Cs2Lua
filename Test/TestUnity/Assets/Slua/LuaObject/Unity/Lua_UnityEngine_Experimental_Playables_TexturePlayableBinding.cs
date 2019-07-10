using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Playables_TexturePlayableBinding : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Create_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Experimental.Playables.TexturePlayableBinding.Create(a1,a2);
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
		getTypeTable(l,"UnityEngine.Experimental.Playables.TexturePlayableBinding");
		addMember(l,Create_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Playables.TexturePlayableBinding));
	}
}
