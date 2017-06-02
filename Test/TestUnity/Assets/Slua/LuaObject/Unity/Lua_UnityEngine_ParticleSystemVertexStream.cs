using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemVertexStream : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemVertexStream");
		addMember(l,0,"Position");
		addMember(l,1,"Normal");
		addMember(l,2,"Tangent");
		addMember(l,3,"Color");
		addMember(l,4,"UV");
		addMember(l,5,"UV2");
		addMember(l,6,"UV3");
		addMember(l,7,"UV4");
		addMember(l,8,"AnimBlend");
		addMember(l,9,"AnimFrame");
		addMember(l,10,"Center");
		addMember(l,11,"VertexID");
		addMember(l,12,"SizeX");
		addMember(l,13,"SizeXY");
		addMember(l,14,"SizeXYZ");
		addMember(l,15,"Rotation");
		addMember(l,16,"Rotation3D");
		addMember(l,17,"RotationSpeed");
		addMember(l,18,"RotationSpeed3D");
		addMember(l,19,"Velocity");
		addMember(l,20,"Speed");
		addMember(l,21,"AgePercent");
		addMember(l,22,"InvStartLifetime");
		addMember(l,23,"StableRandomX");
		addMember(l,24,"StableRandomXY");
		addMember(l,25,"StableRandomXYZ");
		addMember(l,26,"StableRandomXYZW");
		addMember(l,27,"VaryingRandomX");
		addMember(l,28,"VaryingRandomXY");
		addMember(l,29,"VaryingRandomXYZ");
		addMember(l,30,"VaryingRandomXYZW");
		addMember(l,31,"Custom1X");
		addMember(l,32,"Custom1XY");
		addMember(l,33,"Custom1XYZ");
		addMember(l,34,"Custom1XYZW");
		addMember(l,35,"Custom2X");
		addMember(l,36,"Custom2XY");
		addMember(l,37,"Custom2XYZ");
		addMember(l,38,"Custom2XYZW");
		LuaDLL.lua_pop(l, 1);
	}
}
