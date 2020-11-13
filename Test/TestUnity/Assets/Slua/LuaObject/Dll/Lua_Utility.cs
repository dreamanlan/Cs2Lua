using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Utility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			Utility o;
			o=new Utility();
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
	static public int QuaternionFromAngleAxis_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			System.Single a4;
			System.Single a5;
			System.Single a6;
			var ret=Utility.QuaternionFromAngleAxis(a1,a2,out a3,out a4,out a5,out a6);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			pushValue(l,a4);
			pushValue(l,a5);
			pushValue(l,a6);
			return 6;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int QuaternionFromLookRotation_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			System.Single a4;
			System.Single a5;
			System.Single a6;
			var ret=Utility.QuaternionFromLookRotation(a1,a2,out a3,out a4,out a5,out a6);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			pushValue(l,a4);
			pushValue(l,a5);
			pushValue(l,a6);
			return 6;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int QuaternionRotateTowards_s(IntPtr l) {
		try {
			UnityEngine.Quaternion a1;
			checkType(l,1,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			System.Single a5;
			System.Single a6;
			System.Single a7;
			var ret=Utility.QuaternionRotateTowards(a1,a2,a3,out a4,out a5,out a6,out a7);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			pushValue(l,a5);
			pushValue(l,a6);
			pushValue(l,a7);
			return 6;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int QuaternionCalcAngle_s(IntPtr l) {
		try {
			UnityEngine.Quaternion a1;
			checkType(l,1,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,2,out a2);
			var ret=Utility.QuaternionCalcAngle(a1,a2);
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
	static public int Vector3Lerp_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			System.Single a5;
			System.Single a6;
			var ret=Utility.Vector3Lerp(a1,a2,a3,out a4,out a5,out a6);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			pushValue(l,a5);
			pushValue(l,a6);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Vector3LerpUnclamped_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			System.Single a5;
			System.Single a6;
			var ret=Utility.Vector3LerpUnclamped(a1,a2,a3,out a4,out a5,out a6);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			pushValue(l,a5);
			pushValue(l,a6);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Vector2ClampMagnitude_s(IntPtr l) {
		try {
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			System.Single a4;
			var ret=Utility.Vector2ClampMagnitude(a1,a2,out a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			pushValue(l,a4);
			return 4;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Vector2Lerp_s(IntPtr l) {
		try {
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			System.Single a5;
			var ret=Utility.Vector2Lerp(a1,a2,a3,out a4,out a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			pushValue(l,a5);
			return 4;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Vector2LerpUnclamped_s(IntPtr l) {
		try {
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			System.Single a5;
			var ret=Utility.Vector2LerpUnclamped(a1,a2,a3,out a4,out a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			pushValue(l,a5);
			return 4;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Vector2MoveTowards_s(IntPtr l) {
		try {
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			System.Single a5;
			var ret=Utility.Vector2MoveTowards(a1,a2,a3,out a4,out a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			pushValue(l,a5);
			return 4;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Vector2SmoothDamp_s(IntPtr l) {
		try {
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Single a6;
			checkType(l,6,out a6);
			System.Single a7;
			System.Single a8;
			System.Single a9;
			System.Single a10;
			var ret=Utility.Vector2SmoothDamp(a1,a2,a3,a4,a5,a6,out a7,out a8,out a9,out a10);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a7);
			pushValue(l,a8);
			pushValue(l,a9);
			pushValue(l,a10);
			return 6;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPosition_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			System.Single a3;
			System.Single a4;
			var ret=Utility.GetPosition(a1,out a2,out a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLocalPosition_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			System.Single a3;
			System.Single a4;
			var ret=Utility.GetLocalPosition(a1,out a2,out a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetRotation_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			System.Single a3;
			System.Single a4;
			System.Single a5;
			var ret=Utility.GetRotation(a1,out a2,out a3,out a4,out a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			pushValue(l,a5);
			return 6;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLocalRotation_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			System.Single a3;
			System.Single a4;
			System.Single a5;
			var ret=Utility.GetLocalRotation(a1,out a2,out a3,out a4,out a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			pushValue(l,a5);
			return 6;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetEulerAngles_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			System.Single a3;
			System.Single a4;
			var ret=Utility.GetEulerAngles(a1,out a2,out a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLocalEulerAngles_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			System.Single a3;
			System.Single a4;
			var ret=Utility.GetLocalEulerAngles(a1,out a2,out a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLocalScale_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			System.Single a3;
			System.Single a4;
			var ret=Utility.GetLocalScale(a1,out a2,out a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetLossyScale_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			System.Single a3;
			System.Single a4;
			var ret=Utility.GetLossyScale(a1,out a2,out a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetForward_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			System.Single a3;
			System.Single a4;
			var ret=Utility.GetForward(a1,out a2,out a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetRight_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			System.Single a3;
			System.Single a4;
			var ret=Utility.GetRight(a1,out a2,out a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUp_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			System.Single a3;
			System.Single a4;
			var ret=Utility.GetUp(a1,out a2,out a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TransformDirectionV3_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			System.Single a4;
			System.Single a5;
			var ret=Utility.TransformDirectionV3(a1,a2,out a3,out a4,out a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			pushValue(l,a4);
			pushValue(l,a5);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TransformDirectionXYZ_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Single a5;
			System.Single a6;
			System.Single a7;
			var ret=Utility.TransformDirectionXYZ(a1,a2,a3,a4,out a5,out a6,out a7);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a5);
			pushValue(l,a6);
			pushValue(l,a7);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TransformPointV3_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			System.Single a4;
			System.Single a5;
			var ret=Utility.TransformPointV3(a1,a2,out a3,out a4,out a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			pushValue(l,a4);
			pushValue(l,a5);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TransformPointXYZ_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Single a5;
			System.Single a6;
			System.Single a7;
			var ret=Utility.TransformPointXYZ(a1,a2,a3,a4,out a5,out a6,out a7);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a5);
			pushValue(l,a6);
			pushValue(l,a7);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TransformVectorV3_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			System.Single a4;
			System.Single a5;
			var ret=Utility.TransformVectorV3(a1,a2,out a3,out a4,out a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			pushValue(l,a4);
			pushValue(l,a5);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TransformVectorXYZ_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Single a5;
			System.Single a6;
			System.Single a7;
			var ret=Utility.TransformVectorXYZ(a1,a2,a3,a4,out a5,out a6,out a7);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a5);
			pushValue(l,a6);
			pushValue(l,a7);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InverseTransformDirectionV3_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			System.Single a4;
			System.Single a5;
			var ret=Utility.InverseTransformDirectionV3(a1,a2,out a3,out a4,out a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			pushValue(l,a4);
			pushValue(l,a5);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InverseTransformDirectionXYZ_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Single a5;
			System.Single a6;
			System.Single a7;
			var ret=Utility.InverseTransformDirectionXYZ(a1,a2,a3,a4,out a5,out a6,out a7);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a5);
			pushValue(l,a6);
			pushValue(l,a7);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InverseTransformPointV3_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			System.Single a4;
			System.Single a5;
			var ret=Utility.InverseTransformPointV3(a1,a2,out a3,out a4,out a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			pushValue(l,a4);
			pushValue(l,a5);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InverseTransformPointXYZ_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Single a5;
			System.Single a6;
			System.Single a7;
			var ret=Utility.InverseTransformPointXYZ(a1,a2,a3,a4,out a5,out a6,out a7);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a5);
			pushValue(l,a6);
			pushValue(l,a7);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InverseTransformVectorV3_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			System.Single a4;
			System.Single a5;
			var ret=Utility.InverseTransformVectorV3(a1,a2,out a3,out a4,out a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			pushValue(l,a4);
			pushValue(l,a5);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InverseTransformVectorXYZ_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Single a5;
			System.Single a6;
			System.Single a7;
			var ret=Utility.InverseTransformVectorXYZ(a1,a2,a3,a4,out a5,out a6,out a7);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a5);
			pushValue(l,a6);
			pushValue(l,a7);
			return 5;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LuaFormat_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object[] a2;
			checkParams(l,2,out a2);
			var ret=Utility.LuaFormat(a1,a2);
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
	static public int AppendFormat_s(IntPtr l) {
		try {
			System.Text.StringBuilder a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Object[] a3;
			checkParams(l,3,out a3);
			Utility.AppendFormat(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StringGetChar_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=Utility.StringGetChar(a1,a2);
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
	static public int CharToString_s(IntPtr l) {
		try {
			System.Char a1;
			checkType(l,1,out a1);
			var ret=Utility.CharToString(a1);
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
	static public int CharArrayToString_s(IntPtr l) {
		try {
			System.Char[] a1;
			checkArray(l,1,out a1);
			var ret=Utility.CharArrayToString(a1);
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
	static public int Debug_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object[] a2;
			checkParams(l,2,out a2);
			Utility.Debug(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Warn_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object[] a2;
			checkParams(l,2,out a2);
			Utility.Warn(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Error_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object[] a2;
			checkParams(l,2,out a2);
			Utility.Error(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"Utility");
		addMember(l,QuaternionFromAngleAxis_s);
		addMember(l,QuaternionFromLookRotation_s);
		addMember(l,QuaternionRotateTowards_s);
		addMember(l,QuaternionCalcAngle_s);
		addMember(l,Vector3Lerp_s);
		addMember(l,Vector3LerpUnclamped_s);
		addMember(l,Vector2ClampMagnitude_s);
		addMember(l,Vector2Lerp_s);
		addMember(l,Vector2LerpUnclamped_s);
		addMember(l,Vector2MoveTowards_s);
		addMember(l,Vector2SmoothDamp_s);
		addMember(l,GetPosition_s);
		addMember(l,GetLocalPosition_s);
		addMember(l,GetRotation_s);
		addMember(l,GetLocalRotation_s);
		addMember(l,GetEulerAngles_s);
		addMember(l,GetLocalEulerAngles_s);
		addMember(l,GetLocalScale_s);
		addMember(l,GetLossyScale_s);
		addMember(l,GetForward_s);
		addMember(l,GetRight_s);
		addMember(l,GetUp_s);
		addMember(l,TransformDirectionV3_s);
		addMember(l,TransformDirectionXYZ_s);
		addMember(l,TransformPointV3_s);
		addMember(l,TransformPointXYZ_s);
		addMember(l,TransformVectorV3_s);
		addMember(l,TransformVectorXYZ_s);
		addMember(l,InverseTransformDirectionV3_s);
		addMember(l,InverseTransformDirectionXYZ_s);
		addMember(l,InverseTransformPointV3_s);
		addMember(l,InverseTransformPointXYZ_s);
		addMember(l,InverseTransformVectorV3_s);
		addMember(l,InverseTransformVectorXYZ_s);
		addMember(l,LuaFormat_s);
		addMember(l,AppendFormat_s);
		addMember(l,StringGetChar_s);
		addMember(l,CharToString_s);
		addMember(l,CharArrayToString_s);
		addMember(l,Debug_s);
		addMember(l,Warn_s);
		addMember(l,Error_s);
		createTypeMetatable(l,constructor, typeof(Utility));
	}
}
