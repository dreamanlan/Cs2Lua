using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RenderQueueRange : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderQueueRange o;
			o=new UnityEngine.Rendering.RenderQueueRange();
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
	static public int ctor__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderQueueRange o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Rendering.RenderQueueRange(a1,a2);
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
	static public int Equals__RenderQueueRange(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderQueueRange self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderQueueRange a1;
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
			UnityEngine.Rendering.RenderQueueRange self;
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
			UnityEngine.Rendering.RenderQueueRange a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.RenderQueueRange a2;
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
			UnityEngine.Rendering.RenderQueueRange a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.RenderQueueRange a2;
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
	static public int get_minimumBound(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.RenderQueueRange.minimumBound);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maximumBound(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.RenderQueueRange.maximumBound);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_all(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.RenderQueueRange.all);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_opaque(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.RenderQueueRange.opaque);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_transparent(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.RenderQueueRange.transparent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lowerBound(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderQueueRange self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lowerBound);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lowerBound(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderQueueRange self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.lowerBound=v;
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
	static public int get_upperBound(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderQueueRange self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.upperBound);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_upperBound(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderQueueRange self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.upperBound=v;
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
		getTypeTable(l,"UnityEngine.Rendering.RenderQueueRange");
		addMember(l,ctor_s);
		addMember(l,ctor__Int32__Int32_s);
		addMember(l,Equals__RenderQueueRange);
		addMember(l,Equals__Object);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"minimumBound",get_minimumBound,null,false);
		addMember(l,"maximumBound",get_maximumBound,null,false);
		addMember(l,"all",get_all,null,false);
		addMember(l,"opaque",get_opaque,null,false);
		addMember(l,"transparent",get_transparent,null,false);
		addMember(l,"lowerBound",get_lowerBound,set_lowerBound,true);
		addMember(l,"upperBound",get_upperBound,set_upperBound,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.RenderQueueRange),typeof(System.ValueType));
	}
}
