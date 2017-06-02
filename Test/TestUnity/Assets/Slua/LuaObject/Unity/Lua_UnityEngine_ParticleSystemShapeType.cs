using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemShapeType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemShapeType");
		addMember(l,0,"Sphere");
		addMember(l,1,"SphereShell");
		addMember(l,2,"Hemisphere");
		addMember(l,3,"HemisphereShell");
		addMember(l,4,"Cone");
		addMember(l,5,"Box");
		addMember(l,6,"Mesh");
		addMember(l,7,"ConeShell");
		addMember(l,8,"ConeVolume");
		addMember(l,9,"ConeVolumeShell");
		addMember(l,10,"Circle");
		addMember(l,11,"CircleEdge");
		addMember(l,12,"SingleSidedEdge");
		addMember(l,13,"MeshRenderer");
		addMember(l,14,"SkinnedMeshRenderer");
		addMember(l,15,"BoxShell");
		addMember(l,16,"BoxEdge");
		LuaDLL.lua_pop(l, 1);
	}
}
