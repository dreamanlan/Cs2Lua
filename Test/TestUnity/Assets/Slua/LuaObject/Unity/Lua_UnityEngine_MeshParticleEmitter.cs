using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_MeshParticleEmitter : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MeshParticleEmitter");
		createTypeMetatable(l,null, typeof(UnityEngine.MeshParticleEmitter),typeof(UnityEngine.ParticleEmitter));
	}
}
