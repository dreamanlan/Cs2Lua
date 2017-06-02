using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemRenderMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemRenderMode");
		addMember(l,0,"Billboard");
		addMember(l,1,"Stretch");
		addMember(l,2,"HorizontalBillboard");
		addMember(l,3,"VerticalBillboard");
		addMember(l,4,"Mesh");
		addMember(l,5,"None");
		LuaDLL.lua_pop(l, 1);
	}
}
