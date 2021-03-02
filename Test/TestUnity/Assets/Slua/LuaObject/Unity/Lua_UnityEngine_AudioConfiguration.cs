﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AudioConfiguration : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.AudioConfiguration o;
			o=new UnityEngine.AudioConfiguration();
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
	static public int get_speakerMode(IntPtr l) {
		try {
			UnityEngine.AudioConfiguration self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.speakerMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_speakerMode(IntPtr l) {
		try {
			UnityEngine.AudioConfiguration self;
			checkValueType(l,1,out self);
			UnityEngine.AudioSpeakerMode v;
			checkEnum(l,2,out v);
			self.speakerMode=v;
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
	static public int get_dspBufferSize(IntPtr l) {
		try {
			UnityEngine.AudioConfiguration self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.dspBufferSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_dspBufferSize(IntPtr l) {
		try {
			UnityEngine.AudioConfiguration self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.dspBufferSize=v;
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
	static public int get_sampleRate(IntPtr l) {
		try {
			UnityEngine.AudioConfiguration self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sampleRate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sampleRate(IntPtr l) {
		try {
			UnityEngine.AudioConfiguration self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.sampleRate=v;
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
	static public int get_numRealVoices(IntPtr l) {
		try {
			UnityEngine.AudioConfiguration self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.numRealVoices);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_numRealVoices(IntPtr l) {
		try {
			UnityEngine.AudioConfiguration self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.numRealVoices=v;
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
	static public int get_numVirtualVoices(IntPtr l) {
		try {
			UnityEngine.AudioConfiguration self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.numVirtualVoices);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_numVirtualVoices(IntPtr l) {
		try {
			UnityEngine.AudioConfiguration self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.numVirtualVoices=v;
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
		getTypeTable(l,"UnityEngine.AudioConfiguration");
		addMember(l,ctor_s);
		addMember(l,"speakerMode",get_speakerMode,set_speakerMode,true);
		addMember(l,"dspBufferSize",get_dspBufferSize,set_dspBufferSize,true);
		addMember(l,"sampleRate",get_sampleRate,set_sampleRate,true);
		addMember(l,"numRealVoices",get_numRealVoices,set_numRealVoices,true);
		addMember(l,"numVirtualVoices",get_numVirtualVoices,set_numVirtualVoices,true);
		createTypeMetatable(l,null, typeof(UnityEngine.AudioConfiguration),typeof(System.ValueType));
	}
}
