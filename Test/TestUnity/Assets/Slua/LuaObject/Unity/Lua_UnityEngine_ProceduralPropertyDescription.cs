using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ProceduralPropertyDescription : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription o;
			o=new UnityEngine.ProceduralPropertyDescription();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_name(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_name(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.name=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_label(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.label);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_label(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.label=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_group(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.group);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_group(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.group=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_type(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_type(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			UnityEngine.ProceduralPropertyType v;
			checkEnum(l,2,out v);
			self.type=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hasRange(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasRange);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_hasRange(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.hasRange=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_minimum(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.minimum);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_minimum(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.minimum=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maximum(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maximum);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maximum(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.maximum=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_step(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.step);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_step(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.step=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enumOptions(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enumOptions);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enumOptions(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.enumOptions=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_componentLabels(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.componentLabels);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_componentLabels(IntPtr l) {
		try {
			UnityEngine.ProceduralPropertyDescription self=(UnityEngine.ProceduralPropertyDescription)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.componentLabels=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ProceduralPropertyDescription");
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"label",get_label,set_label,true);
		addMember(l,"group",get_group,set_group,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"hasRange",get_hasRange,set_hasRange,true);
		addMember(l,"minimum",get_minimum,set_minimum,true);
		addMember(l,"maximum",get_maximum,set_maximum,true);
		addMember(l,"step",get_step,set_step,true);
		addMember(l,"enumOptions",get_enumOptions,set_enumOptions,true);
		addMember(l,"componentLabels",get_componentLabels,set_componentLabels,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ProceduralPropertyDescription));
	}
}
