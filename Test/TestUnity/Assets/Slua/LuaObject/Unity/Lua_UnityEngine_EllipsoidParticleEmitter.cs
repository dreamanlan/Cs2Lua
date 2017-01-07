using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EllipsoidParticleEmitter : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EllipsoidParticleEmitter");
		createTypeMetatable(l,null, typeof(UnityEngine.EllipsoidParticleEmitter),typeof(UnityEngine.ParticleEmitter));
	}
}
