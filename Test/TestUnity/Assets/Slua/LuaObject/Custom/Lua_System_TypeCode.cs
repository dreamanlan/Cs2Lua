using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_TypeCode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"System.TypeCode");
		addMember(l,0,"Empty");
		addMember(l,1,"Object");
		addMember(l,2,"DBNull");
		addMember(l,3,"Boolean");
		addMember(l,4,"Char");
		addMember(l,5,"SByte");
		addMember(l,6,"Byte");
		addMember(l,7,"Int16");
		addMember(l,8,"UInt16");
		addMember(l,9,"Int32");
		addMember(l,10,"UInt32");
		addMember(l,11,"Int64");
		addMember(l,12,"UInt64");
		addMember(l,13,"Single");
		addMember(l,14,"Double");
		addMember(l,15,"Decimal");
		addMember(l,16,"DateTime");
		addMember(l,18,"String");
		LuaDLL.lua_pop(l, 1);
	}
}
