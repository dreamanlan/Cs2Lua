using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_GraphicsBuffer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer o;
			UnityEngine.GraphicsBuffer.Target a1;
			checkEnum(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			o=new UnityEngine.GraphicsBuffer(a1,a2,a3);
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
	static public int Dispose(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer self=(UnityEngine.GraphicsBuffer)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Release(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer self=(UnityEngine.GraphicsBuffer)checkSelf(l);
			self.Release();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsValid(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer self=(UnityEngine.GraphicsBuffer)checkSelf(l);
			var ret=self.IsValid();
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
	static public int SetData__Array(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer self=(UnityEngine.GraphicsBuffer)checkSelf(l);
			System.Array a1;
			checkType(l,2,out a1);
			self.SetData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetData__Array__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer self=(UnityEngine.GraphicsBuffer)checkSelf(l);
			System.Array a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetData(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetData__Array(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer self=(UnityEngine.GraphicsBuffer)checkSelf(l);
			System.Array a1;
			checkType(l,2,out a1);
			self.GetData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetData__Array__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer self=(UnityEngine.GraphicsBuffer)checkSelf(l);
			System.Array a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.GetData(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetNativeBufferPtr(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer self=(UnityEngine.GraphicsBuffer)checkSelf(l);
			var ret=self.GetNativeBufferPtr();
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
	static public int SetCounterValue(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer self=(UnityEngine.GraphicsBuffer)checkSelf(l);
			System.UInt32 a1;
			checkType(l,2,out a1);
			self.SetCounterValue(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyCount__ComputeBuffer__ComputeBuffer__Int32_s(IntPtr l) {
		try {
			UnityEngine.ComputeBuffer a1;
			checkType(l,1,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.GraphicsBuffer.CopyCount(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyCount__GraphicsBuffer__ComputeBuffer__Int32_s(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer a1;
			checkType(l,1,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.GraphicsBuffer.CopyCount(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyCount__ComputeBuffer__GraphicsBuffer__Int32_s(IntPtr l) {
		try {
			UnityEngine.ComputeBuffer a1;
			checkType(l,1,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.GraphicsBuffer.CopyCount(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyCount__GraphicsBuffer__GraphicsBuffer__Int32_s(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer a1;
			checkType(l,1,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.GraphicsBuffer.CopyCount(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_count(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer self=(UnityEngine.GraphicsBuffer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.count);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_stride(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer self=(UnityEngine.GraphicsBuffer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stride);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_target(IntPtr l) {
		try {
			UnityEngine.GraphicsBuffer self=(UnityEngine.GraphicsBuffer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.target);
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
			UnityEngine.GraphicsBuffer self=(UnityEngine.GraphicsBuffer)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.name=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GraphicsBuffer");
		addMember(l,ctor_s);
		addMember(l,Dispose);
		addMember(l,Release);
		addMember(l,IsValid);
		addMember(l,SetData__Array);
		addMember(l,SetData__Array__Int32__Int32__Int32);
		addMember(l,GetData__Array);
		addMember(l,GetData__Array__Int32__Int32__Int32);
		addMember(l,GetNativeBufferPtr);
		addMember(l,SetCounterValue);
		addMember(l,CopyCount__ComputeBuffer__ComputeBuffer__Int32_s);
		addMember(l,CopyCount__GraphicsBuffer__ComputeBuffer__Int32_s);
		addMember(l,CopyCount__ComputeBuffer__GraphicsBuffer__Int32_s);
		addMember(l,CopyCount__GraphicsBuffer__GraphicsBuffer__Int32_s);
		addMember(l,"count",get_count,null,true);
		addMember(l,"stride",get_stride,null,true);
		addMember(l,"target",get_target,null,true);
		addMember(l,"name",null,set_name,true);
		createTypeMetatable(l,null, typeof(UnityEngine.GraphicsBuffer));
	}
}
