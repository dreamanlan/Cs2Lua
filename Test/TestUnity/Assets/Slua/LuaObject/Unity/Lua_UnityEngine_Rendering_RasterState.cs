using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RasterState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState o;
			o=new UnityEngine.Rendering.RasterState();
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
	static public int ctor__CullMode__Int32__Single__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState o;
			UnityEngine.Rendering.CullMode a1;
			checkEnum(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			o=new UnityEngine.Rendering.RasterState(a1,a2,a3,a4);
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
	static public int Equals__RasterState(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RasterState a1;
			checkValueType(l,2,out a1);
			var ret=self.Equals(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState self;
			checkValueType(l,1,out self);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Equals(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int op_Equality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.RasterState a2;
			checkValueType(l,2,out a2);
			var ret=(a1==a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int op_Inequality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.RasterState a2;
			checkValueType(l,2,out a2);
			var ret=(a1!=a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultValue(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.RasterState.defaultValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cullingMode(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.cullingMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cullingMode(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CullMode v;
			checkEnum(l,2,out v);
			self.cullingMode=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depthClip(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.depthClip);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_depthClip(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.depthClip=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_conservative(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.conservative);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_conservative(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.conservative=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_offsetUnits(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.offsetUnits);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_offsetUnits(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.offsetUnits=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_offsetFactor(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.offsetFactor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_offsetFactor(IntPtr l) {
		try {
			UnityEngine.Rendering.RasterState self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.offsetFactor=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.RasterState");
		addMember(l,ctor_s);
		addMember(l,ctor__CullMode__Int32__Single__Boolean_s);
		addMember(l,Equals__RasterState);
		addMember(l,Equals__Object);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"defaultValue",get_defaultValue,null,false);
		addMember(l,"cullingMode",get_cullingMode,set_cullingMode,true);
		addMember(l,"depthClip",get_depthClip,set_depthClip,true);
		addMember(l,"conservative",get_conservative,set_conservative,true);
		addMember(l,"offsetUnits",get_offsetUnits,set_offsetUnits,true);
		addMember(l,"offsetFactor",get_offsetFactor,set_offsetFactor,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.RasterState),typeof(System.ValueType));
	}
}
