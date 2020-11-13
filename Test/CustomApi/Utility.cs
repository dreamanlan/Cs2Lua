using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

public partial class Utility
{
    public static bool QuaternionFromAngleAxis(float angle, Vector3 axis, out float x, out float y, out float z, out float w)
    {
        var q = Quaternion.AngleAxis(angle, axis);
        x = q.x;
        y = q.y;
        z = q.z;
        w = q.w;
        return true;
    }
    public static bool QuaternionFromLookRotation(Vector3 forward, Vector3 upwards, out float x, out float y, out float z, out float w)
    {
        var q = Quaternion.LookRotation(forward, upwards);
        x = q.x;
        y = q.y;
        z = q.z;
        w = q.w;
        return true;
    }
    public static bool QuaternionRotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta, out float x, out float y, out float z, out float w)
    {
        var q = Quaternion.RotateTowards(from, to, maxDegreesDelta);
        x = q.x;
        y = q.y;
        z = q.z;
        w = q.w;
        return true;
    }
    public static float QuaternionCalcAngle(Quaternion q1, Quaternion q2)
    {
        return Quaternion.Angle(q1, q2);
    }
    public static bool Vector3Lerp(Vector3 a, Vector3 b, float t, out float x, out float y, out float z)
    {
        var pt = Vector3.Lerp(a, b, t);
        x = pt.x;
        y = pt.y;
        z = pt.z;
        return true;
    }
    public static bool Vector3LerpUnclamped(Vector3 a, Vector3 b, float t, out float x, out float y, out float z)
    {
        var pt = Vector3.LerpUnclamped(a, b, t);
        x = pt.x;
        y = pt.y;
        z = pt.z;
        return true;
    }
    public static bool Vector2ClampMagnitude(Vector2 vector, float maxLength, out float x, out float y)
    {
        var pt = Vector2.ClampMagnitude(vector, maxLength);
        x = pt.x;
        y = pt.y;
        return true;
    }
    public static bool Vector2Lerp(Vector2 a, Vector2 b, float t, out float x, out float y)
    {
        var pt = Vector2.Lerp(a, b, t);
        x = pt.x;
        y = pt.y;
        return true;
    }
    public static bool Vector2LerpUnclamped(Vector2 a, Vector2 b, float t, out float x, out float y)
    {
        var pt = Vector2.LerpUnclamped(a, b, t);
        x = pt.x;
        y = pt.y;
        return true;
    }
    public static bool Vector2MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta, out float x, out float y)
    {
        var pt = Vector2.MoveTowards(current, target, maxDistanceDelta);
        x = pt.x;
        y = pt.y;
        return true;
    }
    public static bool Vector2SmoothDamp(Vector2 current, Vector2 target, Vector2 currentVelocity, float smoothTime, float maxSpeed, float deltaTime, out float vx, out float vy, out float x, out float y)
    {
        var pt = Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
        vx = currentVelocity.x;
        vy = currentVelocity.y;
        x = pt.x;
        y = pt.y;
        return true;
    }
    public static bool GetPosition(Transform src, out float x, out float y, out float z)
    {
        var v = src.position;
        x = v.x;
        y = v.y;
        z = v.z;
        return true;
    }
    public static bool GetLocalPosition(Transform src, out float x, out float y, out float z)
    {
        var v = src.localPosition;
        x = v.x;
        y = v.y;
        z = v.z;
        return true;
    }
    public static bool GetRotation(Transform src, out float x, out float y, out float z, out float w)
    {
        var v = src.rotation;
        x = v.x;
        y = v.y;
        z = v.z;
        w = v.w;
        return true;
    }
    public static bool GetLocalRotation(Transform src, out float x, out float y, out float z, out float w)
    {
        var v = src.localRotation;
        x = v.x;
        y = v.y;
        z = v.z;
        w = v.w;
        return true;
    }
    public static bool GetEulerAngles(Transform src, out float x, out float y, out float z)
    {
        var v = src.eulerAngles;
        x = v.x;
        y = v.y;
        z = v.z;
        return true;
    }
    public static bool GetLocalEulerAngles(Transform src, out float x, out float y, out float z)
    {
        var v = src.localEulerAngles;
        x = v.x;
        y = v.y;
        z = v.z;
        return true;
    }
    public static bool GetLocalScale(Transform src, out float x, out float y, out float z)
    {
        var v = src.localScale;
        x = v.x;
        y = v.y;
        z = v.z;
        return true;
    }
    public static bool GetLossyScale(Transform src, out float x, out float y, out float z)
    {
        var v = src.lossyScale;
        x = v.x;
        y = v.y;
        z = v.z;
        return true;
    }
    public static bool GetForward(Transform src, out float x, out float y, out float z)
    {
        var v = src.forward;
        x = v.x;
        y = v.y;
        z = v.z;
        return true;
    }
    public static bool GetRight(Transform src, out float x, out float y, out float z)
    {
        var v = src.right;
        x = v.x;
        y = v.y;
        z = v.z;
        return true;
    }
    public static bool GetUp(Transform src, out float x, out float y, out float z)
    {
        var v = src.up;
        x = v.x;
        y = v.y;
        z = v.z;
        return true;
    }
    public static bool TransformDirectionV3(Transform src, Vector3 dir, out float ox, out float oy, out float oz)
    {
        var v = src.TransformDirection(dir);
        ox = v.x;
        oy = v.y;
        oz = v.z;
        return true;
    }
    public static bool TransformDirectionXYZ(Transform src, float x, float y, float z, out float ox, out float oy, out float oz)
    {
        var v = src.TransformDirection(x, y, z);
        ox = v.x;
        oy = v.y;
        oz = v.z;
        return true;
    }
    public static bool TransformPointV3(Transform src, Vector3 dir, out float ox, out float oy, out float oz)
    {
        var v = src.TransformPoint(dir);
        ox = v.x;
        oy = v.y;
        oz = v.z;
        return true;
    }
    public static bool TransformPointXYZ(Transform src, float x, float y, float z, out float ox, out float oy, out float oz)
    {
        var v = src.TransformPoint(x, y, z);
        ox = v.x;
        oy = v.y;
        oz = v.z;
        return true;
    }
    public static bool TransformVectorV3(Transform src, Vector3 dir, out float ox, out float oy, out float oz)
    {
        var v = src.TransformVector(dir);
        ox = v.x;
        oy = v.y;
        oz = v.z;
        return true;
    }
    public static bool TransformVectorXYZ(Transform src, float x, float y, float z, out float ox, out float oy, out float oz)
    {
        var v = src.TransformVector(x, y, z);
        ox = v.x;
        oy = v.y;
        oz = v.z;
        return true;
    }
    public static bool InverseTransformDirectionV3(Transform src, Vector3 dir, out float ox, out float oy, out float oz)
    {
        var v = src.InverseTransformDirection(dir);
        ox = v.x;
        oy = v.y;
        oz = v.z;
        return true;
    }
    public static bool InverseTransformDirectionXYZ(Transform src, float x, float y, float z, out float ox, out float oy, out float oz)
    {
        var v = src.InverseTransformDirection(x, y, z);
        ox = v.x;
        oy = v.y;
        oz = v.z;
        return true;
    }
    public static bool InverseTransformPointV3(Transform src, Vector3 dir, out float ox, out float oy, out float oz)
    {
        var v = src.InverseTransformPoint(dir);
        ox = v.x;
        oy = v.y;
        oz = v.z;
        return true;
    }
    public static bool InverseTransformPointXYZ(Transform src, float x, float y, float z, out float ox, out float oy, out float oz)
    {
        var v = src.InverseTransformPoint(x, y, z);
        ox = v.x;
        oy = v.y;
        oz = v.z;
        return true;
    }
    public static bool InverseTransformVectorV3(Transform src, Vector3 dir, out float ox, out float oy, out float oz)
    {
        var v = src.InverseTransformVector(dir);
        ox = v.x;
        oy = v.y;
        oz = v.z;
        return true;
    }
    public static bool InverseTransformVectorXYZ(Transform src, float x, float y, float z, out float ox, out float oy, out float oz)
    {
        var v = src.InverseTransformVector(x, y, z);
        ox = v.x;
        oy = v.y;
        oz = v.z;
        return true;
    }
    //不要在c#里使用此方法（仅用于lua）
    public static string LuaFormat(string format, params object[] args)
    {
        for (int i = 0; i < args.Length; ++i) {
            if (args[i] is double) {
                double v = (double)args[i];
                if (v - Math.Floor(v) < double.Epsilon) {
                    if (v > 0x7fffffffffffffff) {
                        args[i] = (ulong)v;
                    }
                    else if (v > 0xffffffff || v < -0x80000000) {
                        args[i] = (long)v;
                    }
                    else if (v > 0x7fffffff) {
                        args[i] = (uint)v;
                    }
                    else {
                        args[i] = (int)v;
                    }
                }
            }
        }
        return string.Format(format, args);
    }
    public static void AppendFormat(StringBuilder sb, string format, params object[] args)
    {
        for (int i = 0; i < args.Length; ++i) {
            if (args[i] is double) {
                double v = (double)args[i];
                if (v - Math.Floor(v) < double.Epsilon) {
                    if (v > 0x7fffffffffffffff) {
                        args[i] = (ulong)v;
                    }
                    else if (v > 0xffffffff || v < -0x80000000) {
                        args[i] = (long)v;
                    }
                    else if (v > 0x7fffffff) {
                        args[i] = (uint)v;
                    }
                    else {
                        args[i] = (int)v;
                    }
                }
            }
        }
        sb.AppendFormat(format, args);
    }
    public static char StringGetChar(string str, int index)
    {
        if (index >= 0 && index < str.Length) {
            return str[index];
        }
        return '\0';
    }
    public static string CharToString(char c)
    {
        return c.ToString();
    }
    public static string CharArrayToString(char[] c)
    {
        return new String(c);
    }
    public static void Debug(string fmt, params object[] args)
    {
        if (args.Length == 0)
            UnityEngine.Debug.Log(fmt);
        else
            UnityEngine.Debug.LogFormat(fmt, args);
    }
    public static void Warn(string fmt, params object[] args)
    {
        if (args.Length == 0)
            UnityEngine.Debug.LogWarning(fmt);
        else
            UnityEngine.Debug.LogWarningFormat(fmt, args);
    }
    public static void Error(string fmt, params object[] args)
    {
        if (args.Length == 0)
            UnityEngine.Debug.LogError(fmt);
        else
            UnityEngine.Debug.LogErrorFormat(fmt, args);
    }
}