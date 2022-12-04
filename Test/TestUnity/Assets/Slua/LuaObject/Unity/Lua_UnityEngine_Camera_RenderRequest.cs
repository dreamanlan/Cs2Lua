using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Camera_RenderRequest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Camera.RenderRequest o;
			o=new UnityEngine.Camera.RenderRequest();
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
	static public int ctor__RenderRequestMode__RenderTexture_s(IntPtr l) {
		try {
			UnityEngine.Camera.RenderRequest o;
			UnityEngine.Camera.RenderRequestMode a1;
			checkEnum(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Camera.RenderRequest(a1,a2);
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
	static public int ctor__RenderRequestMode__RenderRequestOutputSpace__RenderTexture_s(IntPtr l) {
		try {
			UnityEngine.Camera.RenderRequest o;
			UnityEngine.Camera.RenderRequestMode a1;
			checkEnum(l,1,out a1);
			UnityEngine.Camera.RenderRequestOutputSpace a2;
			checkEnum(l,2,out a2);
			UnityEngine.RenderTexture a3;
			checkType(l,3,out a3);
			o=new UnityEngine.Camera.RenderRequest(a1,a2,a3);
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
	static public int get_isValid(IntPtr l) {
		try {
			UnityEngine.Camera.RenderRequest self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.isValid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mode(IntPtr l) {
		try {
			UnityEngine.Camera.RenderRequest self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_result(IntPtr l) {
		try {
			UnityEngine.Camera.RenderRequest self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.result);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_outputSpace(IntPtr l) {
		try {
			UnityEngine.Camera.RenderRequest self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.outputSpace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Camera.RenderRequest");
		addMember(l,ctor_s);
		addMember(l,ctor__RenderRequestMode__RenderTexture_s);
		addMember(l,ctor__RenderRequestMode__RenderRequestOutputSpace__RenderTexture_s);
		addMember(l,"isValid",get_isValid,null,true);
		addMember(l,"mode",get_mode,null,true);
		addMember(l,"result",get_result,null,true);
		addMember(l,"outputSpace",get_outputSpace,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Camera.RenderRequest),typeof(System.ValueType));
	}
}
