using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Cache : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Cache o;
			o=new UnityEngine.Cache();
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
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.Cache self;
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
	static public int Equals__Cache(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			UnityEngine.Cache a1;
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
	static public int ClearCache(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			var ret=self.ClearCache();
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
	static public int ClearCache__Int32(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.ClearCache(a1);
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
			UnityEngine.Cache a1;
			checkValueType(l,1,out a1);
			UnityEngine.Cache a2;
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
			UnityEngine.Cache a1;
			checkValueType(l,1,out a1);
			UnityEngine.Cache a2;
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
	static public int get_valid(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.valid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ready(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.ready);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_readOnly(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.readOnly);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_path(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.path);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_index(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.index);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_spaceFree(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.spaceFree);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maximumAvailableStorageSpace(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.maximumAvailableStorageSpace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maximumAvailableStorageSpace(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			System.Int64 v;
			checkType(l,2,out v);
			self.maximumAvailableStorageSpace=v;
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
	static public int get_spaceOccupied(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.spaceOccupied);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_expirationDelay(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.expirationDelay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_expirationDelay(IntPtr l) {
		try {
			UnityEngine.Cache self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.expirationDelay=v;
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
		getTypeTable(l,"UnityEngine.Cache");
		addMember(l,ctor_s);
		addMember(l,Equals__Object);
		addMember(l,Equals__Cache);
		addMember(l,ClearCache);
		addMember(l,ClearCache__Int32);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"valid",get_valid,null,true);
		addMember(l,"ready",get_ready,null,true);
		addMember(l,"readOnly",get_readOnly,null,true);
		addMember(l,"path",get_path,null,true);
		addMember(l,"index",get_index,null,true);
		addMember(l,"spaceFree",get_spaceFree,null,true);
		addMember(l,"maximumAvailableStorageSpace",get_maximumAvailableStorageSpace,set_maximumAvailableStorageSpace,true);
		addMember(l,"spaceOccupied",get_spaceOccupied,null,true);
		addMember(l,"expirationDelay",get_expirationDelay,set_expirationDelay,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Cache),typeof(System.ValueType));
	}
}
