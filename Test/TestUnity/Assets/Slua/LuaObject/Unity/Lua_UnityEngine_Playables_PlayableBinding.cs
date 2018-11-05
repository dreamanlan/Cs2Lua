using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Playables_PlayableBinding : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBinding o;
			o=new UnityEngine.Playables.PlayableBinding();
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
	static public int get_None(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Playables.PlayableBinding.None);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DefaultDuration(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Playables.PlayableBinding.DefaultDuration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_streamName(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBinding self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.streamName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_streamName(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBinding self;
			checkValueType(l,1,out self);
			string v;
			checkType(l,2,out v);
			self.streamName=v;
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
	static public int get_streamType(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBinding self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.streamType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_streamType(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBinding self;
			checkValueType(l,1,out self);
			UnityEngine.Playables.DataStreamType v;
			checkEnum(l,2,out v);
			self.streamType=v;
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
	static public int get_sourceObject(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBinding self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sourceObject);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sourceObject(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBinding self;
			checkValueType(l,1,out self);
			UnityEngine.Object v;
			checkType(l,2,out v);
			self.sourceObject=v;
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
	static public int get_sourceBindingType(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBinding self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sourceBindingType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sourceBindingType(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBinding self;
			checkValueType(l,1,out self);
			System.Type v;
			checkType(l,2,out v);
			self.sourceBindingType=v;
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
		getTypeTable(l,"UnityEngine.Playables.PlayableBinding");
		addMember(l,"None",get_None,null,false);
		addMember(l,"DefaultDuration",get_DefaultDuration,null,false);
		addMember(l,"streamName",get_streamName,set_streamName,true);
		addMember(l,"streamType",get_streamType,set_streamType,true);
		addMember(l,"sourceObject",get_sourceObject,set_sourceObject,true);
		addMember(l,"sourceBindingType",get_sourceBindingType,set_sourceBindingType,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Playables.PlayableBinding),typeof(System.ValueType));
	}
}
