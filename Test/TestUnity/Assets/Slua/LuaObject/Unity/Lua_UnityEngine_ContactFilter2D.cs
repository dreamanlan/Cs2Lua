using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ContactFilter2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D o;
			o=new UnityEngine.ContactFilter2D();
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
	static public int NoFilter(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			var ret=self.NoFilter();
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
	static public int SetLayerMask(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			UnityEngine.LayerMask a1;
			checkValueType(l,2,out a1);
			self.SetLayerMask(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearLayerMask(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			self.ClearLayerMask();
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetDepth(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetDepth(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearDepth(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			self.ClearDepth();
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetNormalAngle(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetNormalAngle(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearNormalAngle(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			self.ClearNormalAngle();
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useTriggers(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.useTriggers);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useTriggers(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.useTriggers=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useLayerMask(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.useLayerMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useLayerMask(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.useLayerMask=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useDepth(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.useDepth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useDepth(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.useDepth=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useNormalAngle(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.useNormalAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useNormalAngle(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.useNormalAngle=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_layerMask(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.layerMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_layerMask(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			UnityEngine.LayerMask v;
			checkValueType(l,2,out v);
			self.layerMask=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_minDepth(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.minDepth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_minDepth(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.minDepth=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maxDepth(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.maxDepth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maxDepth(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.maxDepth=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_minNormalAngle(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.minNormalAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_minNormalAngle(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.minNormalAngle=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maxNormalAngle(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.maxNormalAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maxNormalAngle(IntPtr l) {
		try {
			UnityEngine.ContactFilter2D self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.maxNormalAngle=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ContactFilter2D");
		addMember(l,NoFilter);
		addMember(l,SetLayerMask);
		addMember(l,ClearLayerMask);
		addMember(l,SetDepth);
		addMember(l,ClearDepth);
		addMember(l,SetNormalAngle);
		addMember(l,ClearNormalAngle);
		addMember(l,"useTriggers",get_useTriggers,set_useTriggers,true);
		addMember(l,"useLayerMask",get_useLayerMask,set_useLayerMask,true);
		addMember(l,"useDepth",get_useDepth,set_useDepth,true);
		addMember(l,"useNormalAngle",get_useNormalAngle,set_useNormalAngle,true);
		addMember(l,"layerMask",get_layerMask,set_layerMask,true);
		addMember(l,"minDepth",get_minDepth,set_minDepth,true);
		addMember(l,"maxDepth",get_maxDepth,set_maxDepth,true);
		addMember(l,"minNormalAngle",get_minNormalAngle,set_minNormalAngle,true);
		addMember(l,"maxNormalAngle",get_maxNormalAngle,set_maxNormalAngle,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ContactFilter2D),typeof(System.ValueType));
	}
}
