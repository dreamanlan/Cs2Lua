using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Transform : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetParent__Transform(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			self.SetParent(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetParent__Transform__Boolean(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetParent(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPositionAndRotation(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,3,out a2);
			self.SetPositionAndRotation(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Translate__Vector3(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.Translate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Translate__Vector3__Space(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Space a2;
			checkEnum(l,3,out a2);
			self.Translate(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Translate__Vector3__Transform(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Transform a2;
			checkType(l,3,out a2);
			self.Translate(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Translate__Single__Single__Single(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.Translate(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Translate__Single__Single__Single__Space(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			UnityEngine.Space a4;
			checkEnum(l,5,out a4);
			self.Translate(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Translate__Single__Single__Single__Transform(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			UnityEngine.Transform a4;
			checkType(l,5,out a4);
			self.Translate(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Rotate__Vector3(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.Rotate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Rotate__Vector3__Space(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Space a2;
			checkEnum(l,3,out a2);
			self.Rotate(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Rotate__Vector3__Single(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.Rotate(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Rotate__Vector3__Single__Space(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			UnityEngine.Space a3;
			checkEnum(l,4,out a3);
			self.Rotate(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Rotate__Single__Single__Single(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.Rotate(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Rotate__Single__Single__Single__Space(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			UnityEngine.Space a4;
			checkEnum(l,5,out a4);
			self.Rotate(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RotateAround(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.RotateAround(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LookAt__Transform(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			self.LookAt(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LookAt__Vector3(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.LookAt(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LookAt__Transform__Vector3(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.LookAt(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LookAt__Vector3__Vector3(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.LookAt(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TransformDirection__Vector3(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.TransformDirection(a1);
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
	static public int TransformDirection__Single__Single__Single(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			var ret=self.TransformDirection(a1,a2,a3);
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
	static public int InverseTransformDirection__Vector3(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.InverseTransformDirection(a1);
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
	static public int InverseTransformDirection__Single__Single__Single(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			var ret=self.InverseTransformDirection(a1,a2,a3);
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
	static public int TransformVector__Vector3(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.TransformVector(a1);
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
	static public int TransformVector__Single__Single__Single(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			var ret=self.TransformVector(a1,a2,a3);
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
	static public int InverseTransformVector__Vector3(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.InverseTransformVector(a1);
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
	static public int InverseTransformVector__Single__Single__Single(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			var ret=self.InverseTransformVector(a1,a2,a3);
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
	static public int TransformPoint__Vector3(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.TransformPoint(a1);
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
	static public int TransformPoint__Single__Single__Single(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			var ret=self.TransformPoint(a1,a2,a3);
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
	static public int InverseTransformPoint__Vector3(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.InverseTransformPoint(a1);
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
	static public int InverseTransformPoint__Single__Single__Single(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			var ret=self.InverseTransformPoint(a1,a2,a3);
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
	static public int DetachChildren(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			self.DetachChildren();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetAsFirstSibling(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			self.SetAsFirstSibling();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetAsLastSibling(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			self.SetAsLastSibling();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetSiblingIndex(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.SetSiblingIndex(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSiblingIndex(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			var ret=self.GetSiblingIndex();
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
	static public int Find(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Find(a1);
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
	static public int IsChildOf(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			var ret=self.IsChildOf(a1);
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
	static public int GetEnumerator(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			var ret=self.GetEnumerator();
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
	static public int GetChild(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetChild(a1);
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
	static public int get_position(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_position(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.position=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_localPosition(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.localPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_localPosition(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.localPosition=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_eulerAngles(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.eulerAngles);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_eulerAngles(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.eulerAngles=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_localEulerAngles(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.localEulerAngles);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_localEulerAngles(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.localEulerAngles=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_right(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.right);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_right(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.right=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_up(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.up);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_up(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.up=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_forward(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.forward);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_forward(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.forward=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rotation(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rotation(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Quaternion v;
			checkType(l,2,out v);
			self.rotation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_localRotation(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.localRotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_localRotation(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Quaternion v;
			checkType(l,2,out v);
			self.localRotation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_localScale(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.localScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_localScale(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.localScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_parent(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.parent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_parent(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.parent=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_worldToLocalMatrix(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.worldToLocalMatrix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_localToWorldMatrix(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.localToWorldMatrix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_root(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.root);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_childCount(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.childCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lossyScale(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lossyScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hasChanged(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasChanged);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_hasChanged(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.hasChanged=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hierarchyCapacity(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hierarchyCapacity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_hierarchyCapacity(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.hierarchyCapacity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hierarchyCount(IntPtr l) {
		try {
			UnityEngine.Transform self=(UnityEngine.Transform)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hierarchyCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Transform");
		addMember(l,SetParent__Transform);
		addMember(l,SetParent__Transform__Boolean);
		addMember(l,SetPositionAndRotation);
		addMember(l,Translate__Vector3);
		addMember(l,Translate__Vector3__Space);
		addMember(l,Translate__Vector3__Transform);
		addMember(l,Translate__Single__Single__Single);
		addMember(l,Translate__Single__Single__Single__Space);
		addMember(l,Translate__Single__Single__Single__Transform);
		addMember(l,Rotate__Vector3);
		addMember(l,Rotate__Vector3__Space);
		addMember(l,Rotate__Vector3__Single);
		addMember(l,Rotate__Vector3__Single__Space);
		addMember(l,Rotate__Single__Single__Single);
		addMember(l,Rotate__Single__Single__Single__Space);
		addMember(l,RotateAround);
		addMember(l,LookAt__Transform);
		addMember(l,LookAt__Vector3);
		addMember(l,LookAt__Transform__Vector3);
		addMember(l,LookAt__Vector3__Vector3);
		addMember(l,TransformDirection__Vector3);
		addMember(l,TransformDirection__Single__Single__Single);
		addMember(l,InverseTransformDirection__Vector3);
		addMember(l,InverseTransformDirection__Single__Single__Single);
		addMember(l,TransformVector__Vector3);
		addMember(l,TransformVector__Single__Single__Single);
		addMember(l,InverseTransformVector__Vector3);
		addMember(l,InverseTransformVector__Single__Single__Single);
		addMember(l,TransformPoint__Vector3);
		addMember(l,TransformPoint__Single__Single__Single);
		addMember(l,InverseTransformPoint__Vector3);
		addMember(l,InverseTransformPoint__Single__Single__Single);
		addMember(l,DetachChildren);
		addMember(l,SetAsFirstSibling);
		addMember(l,SetAsLastSibling);
		addMember(l,SetSiblingIndex);
		addMember(l,GetSiblingIndex);
		addMember(l,Find);
		addMember(l,IsChildOf);
		addMember(l,GetEnumerator);
		addMember(l,GetChild);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"localPosition",get_localPosition,set_localPosition,true);
		addMember(l,"eulerAngles",get_eulerAngles,set_eulerAngles,true);
		addMember(l,"localEulerAngles",get_localEulerAngles,set_localEulerAngles,true);
		addMember(l,"right",get_right,set_right,true);
		addMember(l,"up",get_up,set_up,true);
		addMember(l,"forward",get_forward,set_forward,true);
		addMember(l,"rotation",get_rotation,set_rotation,true);
		addMember(l,"localRotation",get_localRotation,set_localRotation,true);
		addMember(l,"localScale",get_localScale,set_localScale,true);
		addMember(l,"parent",get_parent,set_parent,true);
		addMember(l,"worldToLocalMatrix",get_worldToLocalMatrix,null,true);
		addMember(l,"localToWorldMatrix",get_localToWorldMatrix,null,true);
		addMember(l,"root",get_root,null,true);
		addMember(l,"childCount",get_childCount,null,true);
		addMember(l,"lossyScale",get_lossyScale,null,true);
		addMember(l,"hasChanged",get_hasChanged,set_hasChanged,true);
		addMember(l,"hierarchyCapacity",get_hierarchyCapacity,set_hierarchyCapacity,true);
		addMember(l,"hierarchyCount",get_hierarchyCount,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Transform),typeof(UnityEngine.Component));
	}
}
