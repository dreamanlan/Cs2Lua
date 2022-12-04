using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_PlayerLoop_PreLateUpdate_ParticleSystemBeginUpdateAll : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.PlayerLoop.PreLateUpdate.ParticleSystemBeginUpdateAll o;
			o=new UnityEngine.PlayerLoop.PreLateUpdate.ParticleSystemBeginUpdateAll();
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
		getTypeTable(l,"UnityEngine.PlayerLoop.PreLateUpdate.ParticleSystemBeginUpdateAll");
		addMember(l,ctor_s);
		createTypeMetatable(l,null, typeof(UnityEngine.PlayerLoop.PreLateUpdate.ParticleSystemBeginUpdateAll),typeof(System.ValueType));
	}
}
