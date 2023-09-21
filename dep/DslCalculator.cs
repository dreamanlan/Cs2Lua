using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Linq;

#pragma warning disable 8600,8601,8602,8603,8604,8618,8619,8620,8625
namespace DslExpression
{
    public static class CalculatorValueConverter
    {
        public static CalculatorValue ToCalculatorValue<T>(T v)
        {
            var from = s_FromBoxedValue as FromGenericDelegation<CalculatorValue, T>;
            if (null != from)
                return from(v);
            return CalculatorValue.NullObject;
        }
        public static object ToObject<T>(T v)
        {
            var from = s_FromObject as FromGenericDelegation<object, T>;
            if (null != from)
                return from(v);
            return null;
        }
        public static string ToString<T>(T v)
        {
            var from = s_FromString as FromGenericDelegation<string, T>;
            if (null != from)
                return from(v);
            return null;
        }
        public static bool ToBool<T>(T v)
        {
            var from = s_FromBool as FromGenericDelegation<bool, T>;
            if (null != from)
                return from(v);
            return false;
        }
        public static char ToChar<T>(T v)
        {
            var from = s_FromChar as FromGenericDelegation<char, T>;
            if (null != from)
                return from(v);
            return (char)0;
        }
        public static sbyte ToSByte<T>(T v)
        {
            var from = s_FromSByte as FromGenericDelegation<sbyte, T>;
            if (null != from)
                return from(v);
            return 0;
        }
        public static short ToShort<T>(T v)
        {
            var from = s_FromShort as FromGenericDelegation<short, T>;
            if (null != from)
                return from(v);
            return 0;
        }
        public static int ToInt<T>(T v)
        {
            var from = s_FromInt as FromGenericDelegation<int, T>;
            if (null != from)
                return from(v);
            return 0;
        }
        public static long ToLong<T>(T v)
        {
            var from = s_FromLong as FromGenericDelegation<long, T>;
            if (null != from)
                return from(v);
            return 0;
        }
        public static byte ToByte<T>(T v)
        {
            var from = s_FromByte as FromGenericDelegation<byte, T>;
            if (null != from)
                return from(v);
            return 0;
        }
        public static ushort ToUShort<T>(T v)
        {
            var from = s_FromUShort as FromGenericDelegation<ushort, T>;
            if (null != from)
                return from(v);
            return 0;
        }
        public static uint ToUInt<T>(T v)
        {
            var from = s_FromUInt as FromGenericDelegation<uint, T>;
            if (null != from)
                return from(v);
            return 0;
        }
        public static ulong ToULong<T>(T v)
        {
            var from = s_FromULong as FromGenericDelegation<ulong, T>;
            if (null != from)
                return from(v);
            return 0;
        }
        public static float ToFloat<T>(T v)
        {
            var from = s_FromFloat as FromGenericDelegation<float, T>;
            if (null != from)
                return from(v);
            return 0;
        }
        public static double ToDouble<T>(T v)
        {
            var from = s_FromDouble as FromGenericDelegation<double, T>;
            if (null != from)
                return from(v);
            return 0;
        }
        public static decimal ToDecimal<T>(T v)
        {
            var from = s_FromDecimal as FromGenericDelegation<decimal, T>;
            if (null != from)
                return from(v);
            return 0;
        }

        public static T From<T>(CalculatorValue v)
        {
            var from = s_FromBoxedValue as FromGenericDelegation<T, CalculatorValue>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(object v)
        {
            var from = s_FromObject as FromGenericDelegation<T, object>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(string v)
        {
            var from = s_FromString as FromGenericDelegation<T, string>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(bool v)
        {
            var from = s_FromBool as FromGenericDelegation<T, bool>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(char v)
        {
            var from = s_FromChar as FromGenericDelegation<T, char>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(sbyte v)
        {
            var from = s_FromSByte as FromGenericDelegation<T, sbyte>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(short v)
        {
            var from = s_FromShort as FromGenericDelegation<T, short>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(int v)
        {
            var from = s_FromInt as FromGenericDelegation<T, int>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(long v)
        {
            var from = s_FromLong as FromGenericDelegation<T, long>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(byte v)
        {
            var from = s_FromByte as FromGenericDelegation<T, byte>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(ushort v)
        {
            var from = s_FromUShort as FromGenericDelegation<T, ushort>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(uint v)
        {
            var from = s_FromUInt as FromGenericDelegation<T, uint>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(ulong v)
        {
            var from = s_FromULong as FromGenericDelegation<T, ulong>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(float v)
        {
            var from = s_FromFloat as FromGenericDelegation<T, float>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(double v)
        {
            var from = s_FromDouble as FromGenericDelegation<T, double>;
            if (null != from)
                return from(v);
            return default(T);
        }
        public static T From<T>(decimal v)
        {
            var from = s_FromDecimal as FromGenericDelegation<T, decimal>;
            if (null != from)
                return from(v);
            return default(T);
        }

        internal static T CastTo<T>(object obj)
        {
            if (obj is T) {
                return (T)obj;
            }
            else {
                try {
                    return (T)Convert.ChangeType(obj, typeof(T));
                }
                catch {
                    return default(T);
                }
            }
        }

        private delegate R FromGenericDelegation<R, T>(T v);
        private static FromGenericDelegation<CalculatorValue, CalculatorValue> s_FromBoxedValue = FromHelper<CalculatorValue>;
        private static FromGenericDelegation<bool, bool> s_FromBool = FromHelper<bool>;
        private static FromGenericDelegation<char, char> s_FromChar = FromHelper<char>;
        private static FromGenericDelegation<sbyte, sbyte> s_FromSByte = FromHelper<sbyte>;
        private static FromGenericDelegation<short, short> s_FromShort = FromHelper<short>;
        private static FromGenericDelegation<int, int> s_FromInt = FromHelper<int>;
        private static FromGenericDelegation<long, long> s_FromLong = FromHelper<long>;
        private static FromGenericDelegation<byte, byte> s_FromByte = FromHelper<byte>;
        private static FromGenericDelegation<ushort, ushort> s_FromUShort = FromHelper<ushort>;
        private static FromGenericDelegation<uint, uint> s_FromUInt = FromHelper<uint>;
        private static FromGenericDelegation<ulong, ulong> s_FromULong = FromHelper<ulong>;
        private static FromGenericDelegation<float, float> s_FromFloat = FromHelper<float>;
        private static FromGenericDelegation<double, double> s_FromDouble = FromHelper<double>;
        private static FromGenericDelegation<decimal, decimal> s_FromDecimal = FromHelper<decimal>;
        private static FromGenericDelegation<string, string> s_FromString = FromHelper<string>;
        private static FromGenericDelegation<object, object> s_FromObject = FromHelper<object>;
        private static T FromHelper<T>(T v)
        {
            return v;
        }
    }
    public struct CalculatorValue
    {
        public const int c_ObjectType = 0;
        public const int c_StringType = 1;
        public const int c_BoolType = 2;
        public const int c_CharType = 3;
        public const int c_SByteType = 4;
        public const int c_ShortType = 5;
        public const int c_IntType = 6;
        public const int c_LongType = 7;
        public const int c_ByteType = 8;
        public const int c_UShortType = 9;
        public const int c_UIntType = 10;
        public const int c_ULongType = 11;
        public const int c_FloatType = 12;
        public const int c_DoubleType = 13;
        public const int c_DecimalType = 14;

        [StructLayout(LayoutKind.Explicit)]
        internal struct UnionValue
        {
            [FieldOffset(0)]
            public bool BoolVal;
            [FieldOffset(0)]
            public char CharVal;
            [FieldOffset(0)]
            public sbyte SByteVal;
            [FieldOffset(0)]
            public short ShortVal;
            [FieldOffset(0)]
            public int IntVal;
            [FieldOffset(0)]
            public long LongVal;
            [FieldOffset(0)]
            public byte ByteVal;
            [FieldOffset(0)]
            public ushort UShortVal;
            [FieldOffset(0)]
            public uint UIntVal;
            [FieldOffset(0)]
            public ulong ULongVal;
            [FieldOffset(0)]
            public float FloatVal;
            [FieldOffset(0)]
            public double DoubleVal;
            [FieldOffset(0)]
            public decimal DecimalVal;
        }

        public string StringVal
        {
            get { return ObjectVal as string; }
            set { ObjectVal = value; }
        }
        public int Type;
        public object ObjectVal;
        private UnionValue Union;

        public static implicit operator CalculatorValue(string v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator string(CalculatorValue v)
        {
            return v.GetString();
        }
        public static implicit operator CalculatorValue(bool v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator bool(CalculatorValue v)
        {
            return v.GetBool();
        }
        public static implicit operator CalculatorValue(char v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator char(CalculatorValue v)
        {
            return v.GetChar();
        }
        public static implicit operator CalculatorValue(sbyte v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator sbyte(CalculatorValue v)
        {
            return v.GetSByte();
        }
        public static implicit operator CalculatorValue(short v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator short(CalculatorValue v)
        {
            return v.GetShort();
        }
        public static implicit operator CalculatorValue(int v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator int(CalculatorValue v)
        {
            return v.GetInt();
        }
        public static implicit operator CalculatorValue(long v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator long(CalculatorValue v)
        {
            return v.GetLong();
        }
        public static implicit operator CalculatorValue(byte v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator byte(CalculatorValue v)
        {
            return v.GetByte();
        }
        public static implicit operator CalculatorValue(ushort v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator ushort(CalculatorValue v)
        {
            return v.GetUShort();
        }
        public static implicit operator CalculatorValue(uint v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator uint(CalculatorValue v)
        {
            return v.GetUInt();
        }
        public static implicit operator CalculatorValue(ulong v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator ulong(CalculatorValue v)
        {
            return v.GetULong();
        }
        public static implicit operator CalculatorValue(float v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator float(CalculatorValue v)
        {
            return v.GetFloat();
        }
        public static implicit operator CalculatorValue(double v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator double(CalculatorValue v)
        {
            return v.GetDouble();
        }
        public static implicit operator CalculatorValue(decimal v)
        {
            return CalculatorValue.From(v);
        }
        public static implicit operator decimal(CalculatorValue v)
        {
            return v.GetDecimal();
        }

        public static implicit operator CalculatorValue(Type v)
        {
            return CalculatorValue.FromObject(v);
        }
        public static implicit operator Type(CalculatorValue v)
        {
            return v.ObjectVal as Type;
        }
        public static implicit operator CalculatorValue(ArrayList v)
        {
            return CalculatorValue.FromObject(v);
        }
        public static implicit operator ArrayList(CalculatorValue v)
        {
            return v.ObjectVal as ArrayList;
        }

        public string GetTypeName()
        {
            switch (Type) {
                case c_ObjectType:
                    return "object";
                case c_StringType:
                    return "string";
                case c_BoolType:
                    return "bool";
                case c_CharType:
                    return "char";
                case c_SByteType:
                    return "sbyte";
                case c_ShortType:
                    return "short";
                case c_IntType:
                    return "int";
                case c_LongType:
                    return "long";
                case c_ByteType:
                    return "byte";
                case c_UShortType:
                    return "ushort";
                case c_UIntType:
                    return "uint";
                case c_ULongType:
                    return "ulong";
                case c_FloatType:
                    return "float";
                case c_DoubleType:
                    return "double";
                case c_DecimalType:
                    return "decimal";
                default:
                    return "Unknown";
            }
        }

        public bool IsNullObject
        {
            get { return Type == c_ObjectType && ObjectVal == null; }
        }
        public bool IsNullOrEmptyString
        {
            get { return Type == c_StringType && string.IsNullOrEmpty(StringVal); }
        }
        public bool IsObject
        {
            get {
                return Type == c_ObjectType;
            }
        }
        public bool IsString
        {
            get {
                return Type == c_StringType;
            }
        }
        public bool IsBoolean
        {
            get {
                return Type == c_BoolType;
            }
        }
        public bool IsChar
        {
            get {
                return Type == c_CharType;
            }
        }
        public bool IsSignedInteger {
            get {
                switch (Type) {
                    case c_SByteType:
                    case c_ShortType:
                    case c_IntType:
                    case c_LongType:
                        return true;
                    default:
                        return false;
                }
            }
        }
        public bool IsUnsignedInteger {
            get {
                switch (Type) {
                    case c_ByteType:
                    case c_UShortType:
                    case c_UIntType:
                    case c_ULongType:
                        return true;
                    default:
                        return false;
                }
            }
        }
        public bool IsInteger
        {
            get {
                switch (Type) {
                    case c_SByteType:
                    case c_ShortType:
                    case c_IntType:
                    case c_LongType:
                    case c_ByteType:
                    case c_UShortType:
                    case c_UIntType:
                    case c_ULongType:
                        return true;
                    default:
                        return false;
                }
            }
        }
        public bool IsNumber
        {
            get {
                return Type == c_FloatType || Type == c_DoubleType || Type == c_DecimalType;
            }
        }
        public string AsString
        {
            get {
                return IsString ? StringVal : (IsObject ? ObjectVal as string : null);
            }
        }
        public T As<T>() where T : class
        {
            return IsObject || IsString ? ObjectVal as T : null;
        }
        public object As(Type t)
        {
            if (null == ObjectVal) {
                return null;
            }
            else if (IsObject || IsString) {
                Type st = ObjectVal.GetType();
                if (t.IsAssignableFrom(st) || st.IsSubclassOf(t))
                    return ObjectVal;
                else
                    return null;
            }
            else {
                return null;
            }
        }

        public void SetNullObject()
        {
            Type = c_ObjectType;
            ObjectVal = null;
        }
        public void SetNullString()
        {
            Type = c_StringType;
            StringVal = null;
        }
        public void SetEmptyString()
        {
            Type = c_StringType;
            StringVal = string.Empty;
        }

        public void Set(bool v)
        {
            Type = c_BoolType;
            Union.BoolVal = v;
        }
        public void Set(char v)
        {
            Type = c_CharType;
            Union.CharVal = v;
        }
        public void Set(sbyte v)
        {
            Type = c_SByteType;
            Union.SByteVal = v;
        }
        public void Set(short v)
        {
            Type = c_ShortType;
            Union.ShortVal = v;
        }
        public void Set(int v)
        {
            Type = c_IntType;
            Union.IntVal = v;
        }
        public void Set(long v)
        {
            Type = c_LongType;
            Union.LongVal = v;
        }
        public void Set(byte v)
        {
            Type = c_ByteType;
            Union.ByteVal = v;
        }
        public void Set(ushort v)
        {
            Type = c_UShortType;
            Union.UShortVal = v;
        }
        public void Set(uint v)
        {
            Type = c_UIntType;
            Union.UIntVal = v;
        }
        public void Set(ulong v)
        {
            Type = c_ULongType;
            Union.ULongVal = v;
        }
        public void Set(float v)
        {
            Type = c_FloatType;
            Union.FloatVal = v;
        }
        public void Set(double v)
        {
            Type = c_DoubleType;
            Union.DoubleVal = v;
        }
        public void Set(decimal v)
        {
            Type = c_DecimalType;
            Union.DecimalVal = v;
        }
        public void Set(string v)
        {
            Type = c_StringType;
            StringVal = v;
        }
        public void SetObject(object val)
        {
            if (null == val) {
                SetWithObjectType(val);
                return;
            }
            Type t = val.GetType();
            if (t == typeof(string))
                Set((string)val);
            else if (t == typeof(bool))
                Set((bool)val);
            else if (t == typeof(char))
                Set((char)val);
            else if (t == typeof(sbyte))
                Set((sbyte)val);
            else if (t == typeof(short))
                Set((short)val);
            else if (t == typeof(int))
                Set((int)val);
            else if (t == typeof(long))
                Set((long)val);
            else if (t == typeof(byte))
                Set((byte)val);
            else if (t == typeof(ushort))
                Set((ushort)val);
            else if (t == typeof(uint))
                Set((uint)val);
            else if (t == typeof(ulong))
                Set((ulong)val);
            else if (t == typeof(float))
                Set((float)val);
            else if (t == typeof(double))
                Set((double)val);
            else if (t == typeof(decimal))
                Set((decimal)val);
            else if (t == typeof(CalculatorValue))
                this = (CalculatorValue)val;
            else
                SetWithObjectType(val);
        }
        public void SetWithObjectType(object val)
        {
            Type = c_ObjectType;
            ObjectVal = val;
        }

        public bool GetBool()
        {
            return ToBool();
        }
        public char GetChar()
        {
            return ToChar();
        }
        public sbyte GetSByte()
        {
            return ToSByte();
        }
        public short GetShort()
        {
            return ToShort();
        }
        public int GetInt()
        {
            return ToInt();
        }
        public long GetLong()
        {
            return ToLong();
        }
        public byte GetByte()
        {
            return ToByte();
        }
        public ushort GetUShort()
        {
            return ToUShort();
        }
        public uint GetUInt()
        {
            return ToUInt();
        }
        public ulong GetULong()
        {
            return ToULong();
        }
        public float GetFloat()
        {
            return ToFloat();
        }
        public double GetDouble()
        {
            return ToDouble();
        }
        public decimal GetDecimal()
        {
            return ToDecimal();
        }
        public string GetString()
        {
            return ToString();
        }
        public object GetObject()
        {
            return ToObject();
        }

        public T CastTo<T>()
        {
            Type t = typeof(T);
            if (t == typeof(string))
                return CalculatorValueConverter.From<T>(ToString());
            else if (t == typeof(bool))
                return CalculatorValueConverter.From<T>(ToBool());
            else if (t == typeof(char))
                return CalculatorValueConverter.From<T>(ToChar());
            else if (t == typeof(sbyte))
                return CalculatorValueConverter.From<T>(ToSByte());
            else if (t == typeof(short))
                return CalculatorValueConverter.From<T>(ToShort());
            else if (t == typeof(int))
                return CalculatorValueConverter.From<T>(ToInt());
            else if (t == typeof(long))
                return CalculatorValueConverter.From<T>(ToLong());
            else if (t == typeof(byte))
                return CalculatorValueConverter.From<T>(ToByte());
            else if (t == typeof(ushort))
                return CalculatorValueConverter.From<T>(ToUShort());
            else if (t == typeof(uint))
                return CalculatorValueConverter.From<T>(ToUInt());
            else if (t == typeof(ulong))
                return CalculatorValueConverter.From<T>(ToULong());
            else if (t == typeof(float))
                return CalculatorValueConverter.From<T>(ToFloat());
            else if (t == typeof(double))
                return CalculatorValueConverter.From<T>(ToDouble());
            else if (t == typeof(decimal))
                return CalculatorValueConverter.From<T>(ToDecimal());
            else if (t == typeof(CalculatorValue))
                return CalculatorValueConverter.From<T>(this);
            else if(t == typeof(object))
                return CalculatorValueConverter.From<T>(ToObject());
            else
                return CalculatorValueConverter.CastTo<T>(ToObject());
        }
        public object CastTo(Type t)
        {
            if (t == typeof(string))
                return ToString();
            else if (t == typeof(bool))
                return ToBool();
            else if (t == typeof(char))
                return ToChar();
            else if (t == typeof(sbyte))
                return ToSByte();
            else if (t == typeof(short))
                return ToShort();
            else if (t == typeof(int))
                return ToInt();
            else if (t == typeof(long))
                return ToLong();
            else if (t == typeof(byte))
                return ToByte();
            else if (t == typeof(ushort))
                return ToUShort();
            else if (t == typeof(uint))
                return ToUInt();
            else if (t == typeof(ulong))
                return ToULong();
            else if (t == typeof(float))
                return ToFloat();
            else if (t == typeof(double))
                return ToDouble();
            else if (t == typeof(decimal))
                return ToDecimal();
            else if (t == typeof(CalculatorValue))
                return this;
            else if (t == typeof(object))
                return ToObject();
            else
                return Convert.ChangeType(ToObject(), t);
        }
        public void GenericSet<T>(T val)
        {
            Type t = typeof(T);
            if (t == typeof(string))
                Set(CalculatorValueConverter.ToString<T>(val));
            else if (t == typeof(bool))
                Set(CalculatorValueConverter.ToBool<T>(val));
            else if (t == typeof(char))
                Set(CalculatorValueConverter.ToChar<T>(val));
            else if (t == typeof(sbyte))
                Set(CalculatorValueConverter.ToSByte<T>(val));
            else if (t == typeof(short))
                Set(CalculatorValueConverter.ToShort<T>(val));
            else if (t == typeof(int))
                Set(CalculatorValueConverter.ToInt<T>(val));
            else if (t == typeof(long))
                Set(CalculatorValueConverter.ToLong<T>(val));
            else if (t == typeof(byte))
                Set(CalculatorValueConverter.ToByte<T>(val));
            else if (t == typeof(ushort))
                Set(CalculatorValueConverter.ToUShort<T>(val));
            else if (t == typeof(uint))
                Set(CalculatorValueConverter.ToUInt<T>(val));
            else if (t == typeof(ulong))
                Set(CalculatorValueConverter.ToULong<T>(val));
            else if (t == typeof(float))
                Set(CalculatorValueConverter.ToFloat<T>(val));
            else if (t == typeof(double))
                Set(CalculatorValueConverter.ToDouble<T>(val));
            else if (t == typeof(decimal))
                Set(CalculatorValueConverter.ToDecimal<T>(val));
            else if (t == typeof(CalculatorValue))
                this = CalculatorValueConverter.ToCalculatorValue<T>(val);
            else if (t == typeof(object))
                SetWithObjectType(CalculatorValueConverter.ToObject<T>(val));
            else
                SetWithObjectType(val);
        }
        public void GenericSet(Type t, object val)
        {
            if (null == val) {
                if (t == typeof(string))
                    Set((string)val);
                else
                    SetWithObjectType(val);
                return;
            }
            t = val.GetType();
            if (t == typeof(string))
                Set((string)val);
            else if (t == typeof(bool))
                Set((bool)val);
            else if (t == typeof(char))
                Set((char)val);
            else if (t == typeof(sbyte))
                Set((sbyte)val);
            else if (t == typeof(short))
                Set((short)val);
            else if (t == typeof(int))
                Set((int)val);
            else if (t == typeof(long))
                Set((long)val);
            else if (t == typeof(byte))
                Set((byte)val);
            else if (t == typeof(ushort))
                Set((ushort)val);
            else if (t == typeof(uint))
                Set((uint)val);
            else if (t == typeof(ulong))
                Set((ulong)val);
            else if (t == typeof(float))
                Set((float)val);
            else if (t == typeof(double))
                Set((double)val);
            else if (t == typeof(decimal))
                Set((decimal)val);
            else if (t == typeof(CalculatorValue))
                this = (CalculatorValue)val;
            else
                SetWithObjectType(val);
        }

        public void CopyFrom(CalculatorValue other)
        {
            Type = other.Type;
            switch (Type) {
                case c_ObjectType:
                    ObjectVal = other.ObjectVal;
                    break;
                case c_StringType:
                    StringVal = other.StringVal;
                    break;
                case c_BoolType:
                    Union.BoolVal = other.Union.BoolVal;
                    break;
                case c_CharType:
                    Union.CharVal = other.Union.CharVal;
                    break;
                case c_SByteType:
                    Union.SByteVal = other.Union.SByteVal;
                    break;
                case c_ShortType:
                    Union.ShortVal = other.Union.ShortVal;
                    break;
                case c_IntType:
                    Union.IntVal = other.Union.IntVal;
                    break;
                case c_LongType:
                    Union.LongVal = other.Union.LongVal;
                    break;
                case c_ByteType:
                    Union.ByteVal = other.Union.ByteVal;
                    break;
                case c_UShortType:
                    Union.UShortVal = other.Union.UShortVal;
                    break;
                case c_UIntType:
                    Union.UIntVal = other.Union.UIntVal;
                    break;
                case c_ULongType:
                    Union.ULongVal = other.Union.ULongVal;
                    break;
                case c_FloatType:
                    Union.FloatVal = other.Union.FloatVal;
                    break;
                case c_DoubleType:
                    Union.DoubleVal = other.Union.DoubleVal;
                    break;
                case c_DecimalType:
                    Union.DecimalVal = other.Union.DecimalVal;
                    break;
            }
        }
        public override string ToString()
        {
            switch (Type) {
                case c_ObjectType:
                    return null != ObjectVal ? ObjectVal.ToString() : string.Empty;
                case c_StringType:
                    return null != StringVal ? StringVal : string.Empty;
                case c_BoolType:
                    return Union.BoolVal.ToString();
                case c_CharType:
                    return Union.CharVal.ToString();
                case c_SByteType:
                    return Union.SByteVal.ToString();
                case c_ShortType:
                    return Union.ShortVal.ToString();
                case c_IntType:
                    return Union.IntVal.ToString();
                case c_LongType:
                    return Union.LongVal.ToString();
                case c_ByteType:
                    return Union.ByteVal.ToString();
                case c_UShortType:
                    return Union.UShortVal.ToString();
                case c_UIntType:
                    return Union.UIntVal.ToString();
                case c_ULongType:
                    return Union.ULongVal.ToString();
                case c_FloatType:
                    return Union.FloatVal.ToString();
                case c_DoubleType:
                    return Union.DoubleVal.ToString();
                case c_DecimalType:
                    return Union.DecimalVal.ToString();
            }
            return string.Empty;
        }

        private object ToObject()
        {
            switch (Type) {
                case c_ObjectType:
                case c_StringType:
                    return ObjectVal;
                case c_BoolType:
                    return Union.BoolVal;
                case c_CharType:
                    return Union.CharVal;
                case c_SByteType:
                    return Union.SByteVal;
                case c_ShortType:
                    return Union.ShortVal;
                case c_IntType:
                    return Union.IntVal;
                case c_LongType:
                    return Union.LongVal;
                case c_ByteType:
                    return Union.ByteVal;
                case c_UShortType:
                    return Union.UShortVal;
                case c_UIntType:
                    return Union.UIntVal;
                case c_ULongType:
                    return Union.ULongVal;
                case c_FloatType:
                    return Union.FloatVal;
                case c_DoubleType:
                    return Union.DoubleVal;
                case c_DecimalType:
                    return Union.DecimalVal;
            }
            return null;
        }
        private bool ToBool()
        {
            switch (Type) {
                case c_StringType:
                    if (null != StringVal) {
                        long v;
                        long.TryParse(StringVal, out v);
                        return v != 0;
                    }
                    else {
                        return false;
                    }
                case c_ObjectType:
                    if (null != ObjectVal) {
                        if (ObjectVal is bool) {
                            return (bool)ObjectVal;
                        }
                        else {
                            long v = CalculatorValueConverter.CastTo<long>(ObjectVal);
                            return v != 0;
                        }
                    }
                    else {
                        return false;
                    }
                case c_BoolType:
                    return Union.BoolVal;
                case c_CharType:
                    return Union.CharVal != 0;
                case c_SByteType:
                    return Union.SByteVal != 0;
                case c_ShortType:
                    return Union.ShortVal != 0;
                case c_IntType:
                    return Union.IntVal != 0;
                case c_LongType:
                    return Union.LongVal != 0;
                case c_ByteType:
                    return Union.ByteVal != 0;
                case c_UShortType:
                    return Union.UShortVal != 0;
                case c_UIntType:
                    return Union.UIntVal != 0;
                case c_ULongType:
                    return Union.ULongVal != 0;
                case c_FloatType:
                    return Union.FloatVal != 0;
                case c_DoubleType:
                    return Union.DoubleVal != 0;
                case c_DecimalType:
                    return Union.DecimalVal != 0;
            }
            return false;
        }
        private char ToChar()
        {
            switch (Type) {
                case c_StringType:
                    if (null != StringVal && StringVal.Length > 0) {
                        return StringVal[0];
                    }
                    else {
                        return '\0';
                    }
                case c_ObjectType:
                    if (null != ObjectVal) {
                        if (ObjectVal is char) {
                            return (char)ObjectVal;
                        }
                        else {
                            char v = CalculatorValueConverter.CastTo<char>(ObjectVal);
                            return v;
                        }
                    }
                    else {
                        return '\0';
                    }
                case c_BoolType:
                    return Union.BoolVal ? '\x01' : '\0';
                case c_CharType:
                    return Union.CharVal;
                case c_SByteType:
                    return (char)Union.SByteVal;
                case c_ShortType:
                    return (char)Union.ShortVal;
                case c_IntType:
                    return (char)Union.IntVal;
                case c_LongType:
                    return (char)Union.LongVal;
                case c_ByteType:
                    return (char)Union.ByteVal;
                case c_UShortType:
                    return (char)Union.UShortVal;
                case c_UIntType:
                    return (char)Union.UIntVal;
                case c_ULongType:
                    return (char)Union.ULongVal;
                case c_FloatType:
                    return (char)(int)Union.FloatVal;
                case c_DoubleType:
                    return (char)(long)Union.DoubleVal;
                case c_DecimalType:
                    return (char)(int)Union.DecimalVal;
            }
            return '\0';
        }
        private sbyte ToSByte()
        {
            sbyte v = 0;
            switch (Type) {
                case c_BoolType:
                    return (sbyte)(Union.BoolVal ? 1 : 0);
                case c_CharType:
                    return (sbyte)Union.CharVal;
                case c_SByteType:
                    return Union.SByteVal;
                case c_ShortType:
                    return (sbyte)Union.ShortVal;
                case c_IntType:
                    return (sbyte)Union.IntVal;
                case c_LongType:
                    return (sbyte)Union.LongVal;
                case c_ByteType:
                    return (sbyte)Union.ByteVal;
                case c_UShortType:
                    return (sbyte)Union.UShortVal;
                case c_UIntType:
                    return (sbyte)Union.UIntVal;
                case c_ULongType:
                    return (sbyte)Union.ULongVal;
                case c_FloatType:
                    return (sbyte)Union.FloatVal;
                case c_DoubleType:
                    return (sbyte)Union.DoubleVal;
                case c_DecimalType:
                    return (sbyte)Union.DecimalVal;
                case c_StringType:
                    if (null != StringVal) {
                        sbyte.TryParse(StringVal, out v);
                    }
                    return v;
                case c_ObjectType:
                    if (null != ObjectVal) {
                        v = CalculatorValueConverter.CastTo<sbyte>(ObjectVal);
                    }
                    return v;
            }
            return v;
        }
        private short ToShort()
        {
            short v = 0;
            switch (Type) {
                case c_BoolType:
                    return (short)(Union.BoolVal ? 1 : 0);
                case c_CharType:
                    return (short)Union.CharVal;
                case c_SByteType:
                    return Union.SByteVal;
                case c_ShortType:
                    return Union.ShortVal;
                case c_IntType:
                    return (short)Union.IntVal;
                case c_LongType:
                    return (short)Union.LongVal;
                case c_ByteType:
                    return Union.ByteVal;
                case c_UShortType:
                    return (short)Union.UShortVal;
                case c_UIntType:
                    return (short)Union.UIntVal;
                case c_ULongType:
                    return (short)Union.ULongVal;
                case c_FloatType:
                    return (short)Union.FloatVal;
                case c_DoubleType:
                    return (short)Union.DoubleVal;
                case c_DecimalType:
                    return (short)Union.DecimalVal;
                case c_StringType:
                    if (null != StringVal) {
                        short.TryParse(StringVal, out v);
                    }
                    return v;
                case c_ObjectType:
                    if (null != ObjectVal) {
                        v = CalculatorValueConverter.CastTo<short>(ObjectVal);
                    }
                    return v;
            }
            return v;
        }
        private int ToInt()
        {
            int v = 0;
            switch (Type) {
                case c_BoolType:
                    return Union.BoolVal ? 1 : 0;
                case c_CharType:
                    return Union.CharVal;
                case c_SByteType:
                    return Union.SByteVal;
                case c_ShortType:
                    return Union.ShortVal;
                case c_IntType:
                    return Union.IntVal;
                case c_LongType:
                    return (int)Union.LongVal;
                case c_ByteType:
                    return Union.ByteVal;
                case c_UShortType:
                    return Union.UShortVal;
                case c_UIntType:
                    return (int)Union.UIntVal;
                case c_ULongType:
                    return (int)Union.ULongVal;
                case c_FloatType:
                    return (int)Union.FloatVal;
                case c_DoubleType:
                    return (int)Union.DoubleVal;
                case c_DecimalType:
                    return (int)Union.DecimalVal;
                case c_StringType:
                    if (null != StringVal) {
                        int.TryParse(StringVal, out v);
                    }
                    return v;
                case c_ObjectType:
                    if (null != ObjectVal) {
                        v = CalculatorValueConverter.CastTo<int>(ObjectVal);
                    }
                    return v;
            }
            return v;
        }
        private long ToLong()
        {
            long v = 0;
            switch (Type) {
                case c_BoolType:
                    return Union.BoolVal ? 1 : 0;
                case c_CharType:
                    return Union.CharVal;
                case c_SByteType:
                    return Union.SByteVal;
                case c_ShortType:
                    return Union.ShortVal;
                case c_IntType:
                    return Union.IntVal;
                case c_LongType:
                    return Union.LongVal;
                case c_ByteType:
                    return Union.ByteVal;
                case c_UShortType:
                    return Union.UShortVal;
                case c_UIntType:
                    return Union.UIntVal;
                case c_ULongType:
                    return (long)Union.ULongVal;
                case c_FloatType:
                    return (long)Union.FloatVal;
                case c_DoubleType:
                    return (long)Union.DoubleVal;
                case c_DecimalType:
                    return (long)Union.DecimalVal;
                case c_StringType:
                    if (null != StringVal) {
                        long.TryParse(StringVal, out v);
                    }
                    return v;
                case c_ObjectType:
                    if (null != ObjectVal) {
                        v = CalculatorValueConverter.CastTo<long>(ObjectVal);
                    }
                    return v;
            }
            return v;
        }
        private byte ToByte()
        {
            byte v = 0;
            switch (Type) {
                case c_BoolType:
                    return (byte)(Union.BoolVal ? 1 : 0);
                case c_CharType:
                    return (byte)Union.CharVal;
                case c_SByteType:
                    return (byte)Union.SByteVal;
                case c_ShortType:
                    return (byte)Union.ShortVal;
                case c_IntType:
                    return (byte)Union.IntVal;
                case c_LongType:
                    return (byte)Union.LongVal;
                case c_ByteType:
                    return Union.ByteVal;
                case c_UShortType:
                    return (byte)Union.UShortVal;
                case c_UIntType:
                    return (byte)Union.UIntVal;
                case c_ULongType:
                    return (byte)Union.ULongVal;
                case c_FloatType:
                    return (byte)Union.FloatVal;
                case c_DoubleType:
                    return (byte)Union.DoubleVal;
                case c_DecimalType:
                    return (byte)Union.DecimalVal;
                case c_StringType:
                    if (null != StringVal) {
                        byte.TryParse(StringVal, out v);
                    }
                    return v;
                case c_ObjectType:
                    if (null != ObjectVal) {
                        v = CalculatorValueConverter.CastTo<byte>(ObjectVal);
                    }
                    return v;
            }
            return v;
        }
        private ushort ToUShort()
        {
            ushort v = 0;
            switch (Type) {
                case c_BoolType:
                    return (ushort)(Union.BoolVal ? 1 : 0);
                case c_CharType:
                    return Union.CharVal;
                case c_SByteType:
                    return (ushort)Union.SByteVal;
                case c_ShortType:
                    return (ushort)Union.ShortVal;
                case c_IntType:
                    return (ushort)Union.IntVal;
                case c_LongType:
                    return (ushort)Union.LongVal;
                case c_ByteType:
                    return Union.ByteVal;
                case c_UShortType:
                    return Union.UShortVal;
                case c_UIntType:
                    return (ushort)Union.UIntVal;
                case c_ULongType:
                    return (ushort)Union.ULongVal;
                case c_FloatType:
                    return (ushort)Union.FloatVal;
                case c_DoubleType:
                    return (ushort)Union.DoubleVal;
                case c_DecimalType:
                    return (ushort)Union.DecimalVal;
                case c_StringType:
                    if (null != StringVal) {
                        ushort.TryParse(StringVal, out v);
                    }
                    return v;
                case c_ObjectType:
                    if (null != ObjectVal) {
                        v = CalculatorValueConverter.CastTo<ushort>(ObjectVal);
                    }
                    return v;
            }
            return v;
        }
        private uint ToUInt()
        {
            uint v = 0;
            switch (Type) {
                case c_BoolType:
                    return (uint)(Union.BoolVal ? 1 : 0);
                case c_CharType:
                    return Union.CharVal;
                case c_SByteType:
                    return (uint)Union.SByteVal;
                case c_ShortType:
                    return (uint)Union.ShortVal;
                case c_IntType:
                    return (uint)Union.IntVal;
                case c_LongType:
                    return (uint)Union.LongVal;
                case c_ByteType:
                    return Union.ByteVal;
                case c_UShortType:
                    return Union.UShortVal;
                case c_UIntType:
                    return Union.UIntVal;
                case c_ULongType:
                    return (uint)Union.ULongVal;
                case c_FloatType:
                    return (uint)Union.FloatVal;
                case c_DoubleType:
                    return (uint)Union.DoubleVal;
                case c_DecimalType:
                    return (uint)Union.DecimalVal;
                case c_StringType:
                    if (null != StringVal) {
                        uint.TryParse(StringVal, out v);
                    }
                    return v;
                case c_ObjectType:
                    if (null != ObjectVal) {
                        v = CalculatorValueConverter.CastTo<uint>(ObjectVal);
                    }
                    return v;
            }
            return v;
        }
        private ulong ToULong()
        {
            ulong v = 0;
            switch (Type) {
                case c_BoolType:
                    return (ulong)(Union.BoolVal ? 1 : 0);
                case c_CharType:
                    return (ulong)Union.CharVal;
                case c_SByteType:
                    return (ulong)Union.SByteVal;
                case c_ShortType:
                    return (ulong)Union.ShortVal;
                case c_IntType:
                    return (ulong)Union.IntVal;
                case c_LongType:
                    return (ulong)Union.LongVal;
                case c_ByteType:
                    return Union.ByteVal;
                case c_UShortType:
                    return Union.UShortVal;
                case c_UIntType:
                    return Union.UIntVal;
                case c_ULongType:
                    return Union.ULongVal;
                case c_FloatType:
                    return (ulong)Union.FloatVal;
                case c_DoubleType:
                    return (ulong)Union.DoubleVal;
                case c_DecimalType:
                    return (ulong)Union.DecimalVal;
                case c_StringType:
                    if (null != StringVal) {
                        ulong.TryParse(StringVal, out v);
                    }
                    return v;
                case c_ObjectType:
                    if (null != ObjectVal) {
                        v = CalculatorValueConverter.CastTo<ulong>(ObjectVal);
                    }
                    return v;
            }
            return v;
        }
        private float ToFloat()
        {
            float v = 0;
            switch (Type) {
                case c_BoolType:
                    return Union.BoolVal ? 1 : 0;
                case c_CharType:
                    return Union.CharVal;
                case c_SByteType:
                    return Union.SByteVal;
                case c_ShortType:
                    return Union.ShortVal;
                case c_IntType:
                    return Union.IntVal;
                case c_LongType:
                    return Union.LongVal;
                case c_ByteType:
                    return Union.ByteVal;
                case c_UShortType:
                    return Union.UShortVal;
                case c_UIntType:
                    return Union.UIntVal;
                case c_ULongType:
                    return Union.ULongVal;
                case c_FloatType:
                    return Union.FloatVal;
                case c_DoubleType:
                    return (float)Union.DoubleVal;
                case c_DecimalType:
                    return (float)Union.DecimalVal;
                case c_StringType:
                    if (null != StringVal) {
                        float.TryParse(StringVal, out v);
                    }
                    return v;
                case c_ObjectType:
                    if (null != ObjectVal) {
                        v = CalculatorValueConverter.CastTo<float>(ObjectVal);
                    }
                    return v;
            }
            return v;
        }
        private double ToDouble()
        {
            double v = 0;
            switch (Type) {
                case c_BoolType:
                    return Union.BoolVal ? 1 : 0;
                case c_CharType:
                    return Union.CharVal;
                case c_SByteType:
                    return Union.SByteVal;
                case c_ShortType:
                    return Union.ShortVal;
                case c_IntType:
                    return Union.IntVal;
                case c_LongType:
                    return Union.LongVal;
                case c_ByteType:
                    return Union.ByteVal;
                case c_UShortType:
                    return Union.UShortVal;
                case c_UIntType:
                    return Union.UIntVal;
                case c_ULongType:
                    return Union.ULongVal;
                case c_FloatType:
                    return Union.FloatVal;
                case c_DoubleType:
                    return Union.DoubleVal;
                case c_DecimalType:
                    return (double)Union.DecimalVal;
                case c_StringType:
                    if (null != StringVal) {
                        double.TryParse(StringVal, out v);
                    }
                    return v;
                case c_ObjectType:
                    if (null != ObjectVal) {
                        v = CalculatorValueConverter.CastTo<double>(ObjectVal);
                    }
                    return v;
            }
            return v;
        }
        private decimal ToDecimal()
        {
            decimal v = 0;
            switch (Type) {
                case c_BoolType:
                    return Union.BoolVal ? 1 : 0;
                case c_CharType:
                    return Union.CharVal;
                case c_SByteType:
                    return Union.SByteVal;
                case c_ShortType:
                    return Union.ShortVal;
                case c_IntType:
                    return Union.IntVal;
                case c_LongType:
                    return Union.LongVal;
                case c_ByteType:
                    return Union.ByteVal;
                case c_UShortType:
                    return Union.UShortVal;
                case c_UIntType:
                    return Union.UIntVal;
                case c_ULongType:
                    return Union.ULongVal;
                case c_FloatType:
                    return (decimal)Union.FloatVal;
                case c_DoubleType:
                    return (decimal)Union.DoubleVal;
                case c_DecimalType:
                    return Union.DecimalVal;
                case c_StringType:
                    if (null != StringVal) {
                        decimal.TryParse(StringVal, out v);
                    }
                    return v;
                case c_ObjectType:
                    if (null != ObjectVal) {
                        v = CalculatorValueConverter.CastTo<decimal>(ObjectVal);
                    }
                    return v;
            }
            return v;
        }

        public static CalculatorValue From(bool v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.Set(v);
            return bv;
        }
        public static CalculatorValue From(sbyte v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.Set(v);
            return bv;
        }
        public static CalculatorValue From(short v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.Set(v);
            return bv;
        }
        public static CalculatorValue From(int v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.Set(v);
            return bv;
        }
        public static CalculatorValue From(long v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.Set(v);
            return bv;
        }
        public static CalculatorValue From(byte v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.Set(v);
            return bv;
        }
        public static CalculatorValue From(ushort v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.Set(v);
            return bv;
        }
        public static CalculatorValue From(uint v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.Set(v);
            return bv;
        }
        public static CalculatorValue From(ulong v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.Set(v);
            return bv;
        }
        public static CalculatorValue From(float v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.Set(v);
            return bv;
        }
        public static CalculatorValue From(double v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.Set(v);
            return bv;
        }
        public static CalculatorValue From(decimal v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.Set(v);
            return bv;
        }
        public static CalculatorValue From(string v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.Set(v);
            return bv;
        }
        public static CalculatorValue FromObject(object v)
        {
            CalculatorValue bv = new CalculatorValue();
            bv.SetObject(v);
            return bv;
        }

        public static CalculatorValue NullObject
        {
            get { return s_NullObject; }
        }
        public static CalculatorValue EmptyString
        {
            get { return s_EmptyString; }
        }
        private static CalculatorValue s_NullObject = CalculatorValue.FromObject(null);
        private static CalculatorValue s_EmptyString = CalculatorValue.From(string.Empty);
    }
    public class CalculatorValueListPool
    {
        public List<CalculatorValue> Alloc()
        {
            if (m_Pool.Count > 0)
                return m_Pool.Dequeue();
            else
                return new List<CalculatorValue>();
        }
        public void Recycle(List<CalculatorValue> list)
        {
            if (null != list) {
                m_Pool.Enqueue(list);
            }
        }
        public void Clear()
        {
            m_Pool.Clear();
        }
        public CalculatorValueListPool(int initCapacity)
        {
            m_Pool = new Queue<List<CalculatorValue>>(initCapacity);
        }

        private Queue<List<CalculatorValue>> m_Pool = null;
    }
    public interface IObjectDispatch
    {
        int GetDispatchId(string name);
        CalculatorValue GetProperty(int dispId);
        void SetProperty(int dispId, CalculatorValue val);
        CalculatorValue InvokeMethod(int dispId, List<CalculatorValue> args);
    }
    public interface IExpression
    {
        CalculatorValue Calc();
        bool Load(Dsl.ISyntaxComponent dsl, DslCalculator calculator);
    }
    public interface IExpressionFactory
    {
        IExpression Create();
    }
    public sealed class ExpressionFactoryHelper<T> : IExpressionFactory where T : IExpression, new()
    {
        public IExpression Create()
        {
            return new T();
        }
    }
    public abstract class AbstractExpression : IExpression
    {
        public CalculatorValue Calc()
        {
            CalculatorValue ret = CalculatorValue.NullObject;
            try {
                ret = DoCalc();
            }
            catch (Exception ex) {
                var msg = string.Format("calc:[{0}]", ToString());
                throw new Exception(msg, ex);
            }
            return ret;
        }
        public bool Load(Dsl.ISyntaxComponent dsl, DslCalculator calculator)
        {
            m_Calculator = calculator;
            m_Dsl = dsl;
            Dsl.ValueData valueData = dsl as Dsl.ValueData;
            if (null != valueData) {
                return Load(valueData);
            }
            else {
                Dsl.FunctionData funcData = dsl as Dsl.FunctionData;
                if (null != funcData) {
                    if (funcData.HaveParam()) {
                        var callData = funcData;
                        bool ret = Load(callData);
                        if (!ret) {
                            int num = callData.GetParamNum();
                            List<IExpression> args = new List<IExpression>();
                            for (int ix = 0; ix < num; ++ix) {
                                Dsl.ISyntaxComponent param = callData.GetParam(ix);
                                args.Add(calculator.Load(param));
                            }
                            return Load(args);
                        }
                        return ret;
                    }
                    else {
                        return Load(funcData);
                    }
                }
                else {
                    Dsl.StatementData statementData = dsl as Dsl.StatementData;
                    if (null != statementData) {
                        return Load(statementData);
                    }
                }
            }
            return false;
        }
        public override string ToString()
        {
            return string.Format("{0} line:{1}", base.ToString(), m_Dsl.GetLine());
        }
        protected virtual bool Load(Dsl.ValueData valData) { return false; }
        protected virtual bool Load(IList<IExpression> exps) { return false; }
        protected virtual bool Load(Dsl.FunctionData funcData) { return false; }
        protected virtual bool Load(Dsl.StatementData statementData) { return false; }
        protected abstract CalculatorValue DoCalc();

        protected DslCalculator Calculator
        {
            get { return m_Calculator; }
        }

        private DslCalculator m_Calculator = null;
        private Dsl.ISyntaxComponent m_Dsl = null;

        protected static void CastArgsForCall(Type t, string method, BindingFlags flags, params object[] args)
        {
            var mis = t.GetMember(method, flags);
            foreach (var mi in mis) {
                var info = mi as MethodInfo;
                if (null != info) {
                    var pis = info.GetParameters();
                    if (pis.Length == args.Length) {
                        for (int i = 0; i < pis.Length; ++i) {
                            if (null != args[i] && args[i].GetType() != pis[i].ParameterType && args[i].GetType().Name != "MonoType") {
                                args[i] = CastTo(pis[i].ParameterType, args[i]);
                            }
                        }
                        break;
                    }
                }
            }
        }
        protected static void CastArgsForSet(Type t, string property, BindingFlags flags, params object[] args)
        {
            var p = t.GetProperty(property, flags);
            if (null != p) {
                var info = p.GetSetMethod(true);
                if (null != info) {
                    var pis = info.GetParameters();
                    if (pis.Length == args.Length) {
                        for (int i = 0; i < pis.Length; ++i) {
                            if (null != args[i] && args[i].GetType() != pis[i].ParameterType && args[i].GetType().Name != "MonoType") {
                                args[i] = CastTo(pis[i].ParameterType, args[i]);
                            }
                        }
                    }
                }
            }
            else {
                var f = t.GetField(property, flags);
                if (null != f && args.Length == 1 && null != args[0] && args[0].GetType() != f.FieldType && args[0].GetType().Name != "MonoType") {
                    args[0] = CastTo(f.FieldType, args[0]);
                }
            }
        }
        protected static void CastArgsForGet(Type t, string property, BindingFlags flags, params object[] args)
        {
            var p = t.GetProperty(property, flags);
            if (null != p) {
                var info = p.GetGetMethod(true);
                if (null != info) {
                    var pis = info.GetParameters();
                    if (pis.Length == args.Length) {
                        for (int i = 0; i < pis.Length; ++i) {
                            if (null != args[i] && args[i].GetType() != pis[i].ParameterType && args[i].GetType().Name != "MonoType") {
                                args[i] = CastTo(pis[i].ParameterType, args[i]);
                            }
                        }
                    }
                }
            }
            else {
                var f = t.GetField(property, flags);
                if (null != f && args.Length == 0) {
                }
            }
        }
        protected static T CastTo<T>(object obj)
        {
            if (obj is CalculatorValue) {
                return ((CalculatorValue)obj).CastTo<T>();
            }
            else if (obj is T) {
                return (T)obj;
            }
            else {
                try {
                    return (T)Convert.ChangeType(obj, typeof(T));
                }
                catch (OverflowException) {
                    return (T)Convert.ChangeType(obj.ToString(), typeof(T));
                }
                catch {
                    return default(T);
                }
            }
        }
        protected static object CastTo(Type t, object obj)
        {
            if (null == obj)
                return null;
            Type st = obj.GetType();
            if (obj is CalculatorValue) {
                return ((CalculatorValue)obj).CastTo(t);
            }
            else if (t.IsAssignableFrom(st) || st.IsSubclassOf(t)) {
                return obj;
            }
            else {
                try {
                    return Convert.ChangeType(obj, t);
                }
                catch (OverflowException) {
                    return Convert.ChangeType(obj.ToString(), t);
                }
                catch {
                    return null;
                }
            }
        }
    }
    public abstract class SimpleExpressionBase : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var operands = Calculator.NewCalculatorValueList();
            for (int i = 0; i < m_Exps.Count; ++i) {
                var v = m_Exps[i].Calc();
                operands.Add(v);
            }
            var r = OnCalc(operands);
            Calculator.RecycleCalculatorValueList(operands);
            return r;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Exps = exps;
            return true;
        }
        protected abstract CalculatorValue OnCalc(IList<CalculatorValue> operands);

        private IList<IExpression> m_Exps = null;
    }
    internal sealed class ArgsGet : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            CalculatorValue ret = CalculatorValue.FromObject(Calculator.Arguments);
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            return true;
        }
    }
    internal sealed class ArgGet : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            var ix = m_ArgIndex.Calc().GetInt();
            var args = Calculator.Arguments;
            if (ix >= 0 && ix < args.Count) {
                ret = args[ix];
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            m_ArgIndex = Calculator.Load(callData.GetParam(0));
            return true;
        }

        private IExpression m_ArgIndex;
    }
    internal sealed class ArgNumGet : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = Calculator.Arguments.Count;
            return CalculatorValue.From(ret);
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            return true;
        }
    }
    internal sealed class GlobalVarSet : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            CalculatorValue v = m_Op.Calc();
            if (m_VarIx < int.MaxValue) {
                Calculator.SetGlobalVaraibleByIndex(m_VarIx, v);
            }
            else if (m_VarId.Length > 0) {
                m_VarIx = Calculator.AllocGlobalVariableIndex(m_VarId);
                if (m_VarIx < int.MaxValue) {
                    Calculator.SetGlobalVaraibleByIndex(m_VarIx, v);
                }
                else {
                    Calculator.SetGlobalVariable(m_VarId, v);
                }
            }
            if (m_VarId.Length > 0 && m_VarId[0] != '@') {
                Environment.SetEnvironmentVariable(m_VarId, v.ToString());
            }
            return v;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            Dsl.ISyntaxComponent param1 = callData.GetParam(0);
            Dsl.ISyntaxComponent param2 = callData.GetParam(1);
            m_VarId = param1.GetId();
            m_Op = Calculator.Load(param2);
            return true;
        }

        private string m_VarId;
        private IExpression m_Op;
        private int m_VarIx = int.MaxValue;
    }
    internal sealed class GlobalVarGet : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            if (m_VarId == "break") {
                Calculator.RunState = RunStateEnum.Break;
                return ret;
            }
            else if (m_VarId == "continue") {
                Calculator.RunState = RunStateEnum.Continue;
                return ret;
            }
            else if (m_VarIx < int.MaxValue) {
                ret = Calculator.GetGlobalVaraibleByIndex(m_VarIx);
            }
            else if (m_VarId.Length > 0) {
                m_VarIx = Calculator.GetGlobalVariableIndex(m_VarId);
                if (m_VarIx < int.MaxValue) {
                    ret = Calculator.GetGlobalVaraibleByIndex(m_VarIx);
                }
                else if(Calculator.TryGetGlobalVariable(m_VarId, out var val)) {
                    ret = val;
                }
                else {
                    Calculator.Log("unassigned global var '{0}'", m_VarId);
                }
            }
            if (ret.IsNullObject && m_VarId.Length > 0 && m_VarId[0] != '@') {
                ret = Environment.ExpandEnvironmentVariables(m_VarId);
            }
            return ret;
        }
        protected override bool Load(Dsl.ValueData valData)
        {
            m_VarId = valData.GetId();
            return true;
        }

        private string m_VarId;
        private int m_VarIx = int.MaxValue;
    }
    internal sealed class LocalVarSet : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            CalculatorValue v = m_Op.Calc();
            if (m_VarIx < int.MaxValue) {
                Calculator.SetLocalVaraibleByIndex(m_VarIx, v);
            }
            else if (m_VarId.Length > 0) {
                m_VarIx = Calculator.AllocLocalVariableIndex(m_VarId);
                Calculator.SetLocalVaraibleByIndex(m_VarIx, v);
            }
            return v;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            Dsl.ISyntaxComponent param1 = callData.GetParam(0);
            Dsl.ISyntaxComponent param2 = callData.GetParam(1);
            m_VarId = param1.GetId();
            m_Op = Calculator.Load(param2);
            return true;
        }

        private string m_VarId;
        private IExpression m_Op;
        private int m_VarIx = int.MaxValue;
    }
    internal sealed class LocalVarGet : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            if (m_VarIx < int.MaxValue) {
                ret = Calculator.GetLocalVaraibleByIndex(m_VarIx);
            }
            else if (m_VarId.Length > 0) {
                m_VarIx = Calculator.GetLocalVariableIndex(m_VarId);
                if (m_VarIx < int.MaxValue) {
                    ret = Calculator.GetLocalVaraibleByIndex(m_VarIx);
                }
                else {
                    Calculator.Log("unassigned local var '{0}'", m_VarId);
                }
            }
            return ret;
        }
        protected override bool Load(Dsl.ValueData valData)
        {
            m_VarId = valData.GetId();
            return true;
        }

        private string m_VarId;
        private int m_VarIx = int.MaxValue;
    }
    internal sealed class ConstGet : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            CalculatorValue v = m_Val;
            return v;
        }
        protected override bool Load(Dsl.ValueData valData)
        {
            string id = valData.GetId();
            int idType = valData.GetIdType();
            if (idType == Dsl.ValueData.NUM_TOKEN) {
                if (id.StartsWith("0x")) {
                    long v = long.Parse(id.Substring(2), System.Globalization.NumberStyles.HexNumber);
                    if (v >= int.MinValue && v <= int.MaxValue) {
                        m_Val = (int)v;
                    }
                    else {
                        m_Val = v;
                    }
                }
                else if (id.IndexOf('.') < 0) {
                    long v = long.Parse(id);
                    if (v >= int.MinValue && v <= int.MaxValue) {
                        m_Val = (int)v;
                    }
                    else {
                        m_Val = v;
                    }
                }
                else {
                    double v = double.Parse(id);
                    if (v >= float.MinValue && v <= float.MaxValue) {
                        m_Val = (float)v;
                    }
                    else {
                        m_Val = v;
                    }
                }
            }
            else {
                if (idType == Dsl.ValueData.ID_TOKEN) {
                    if (id == "true")
                        m_Val = true;
                    else if (id == "false")
                        m_Val = false;
                    else
                        m_Val = id;
                }
                else {
                    m_Val = id;
                }
            }
            return true;
        }

        private CalculatorValue m_Val;
    }
    internal sealed class FunctionCall : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var args = Calculator.NewCalculatorValueList();
            foreach (var arg in m_Args) {
                var o = arg.Calc();
                args.Add(o);
            }
            var r = Calculator.Calc(m_Func, args);
            Calculator.RecycleCalculatorValueList(args);
            return r;
        }
        protected override bool Load(Dsl.FunctionData funcData)
        {
            if (!funcData.IsHighOrder && funcData.HaveParam()) {
                m_Func = funcData.GetId();
                int num = funcData.GetParamNum();
                for (int ix = 0; ix < num; ++ix) {
                    Dsl.ISyntaxComponent param = funcData.GetParam(ix);
                    m_Args.Add(Calculator.Load(param));
                }
                return true;
            }
            return false;
        }
        private string m_Func = string.Empty;
        private List<IExpression> m_Args = new List<IExpression>();
    }
    internal sealed class AddExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            var v2 = m_Op2.Calc();
            CalculatorValue v;
            if (v1.IsString || v2.IsString) {
                v = v1.ToString() + v2.ToString();
            }
            else {
                v = v1.GetDouble() + v2.GetDouble();
            }
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class SubExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            var v2 = m_Op2.Calc();
            CalculatorValue v = v1.GetDouble() - v2.GetDouble();
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class MulExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            var v2 = m_Op2.Calc();
            CalculatorValue v = v1.GetDouble() * v2.GetDouble();
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class DivExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            var v2 = m_Op2.Calc();
            CalculatorValue v = v1.GetDouble() / v2.GetDouble();
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class ModExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            var v2 = m_Op2.Calc();
            CalculatorValue v = v1.GetDouble() % v2.GetDouble();
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class BitAndExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            var v2 = m_Op2.Calc();
            CalculatorValue v = v1.GetLong() & v2.GetLong();
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class BitOrExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            var v2 = m_Op2.Calc();
            CalculatorValue v = v1.GetLong() | v2.GetLong();
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class BitXorExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            var v2 = m_Op2.Calc();
            CalculatorValue v = v1.GetLong() ^ v2.GetLong();
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class BitNotExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            CalculatorValue v = ~v1.GetLong();
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            return true;
        }

        private IExpression m_Op1;
    }
    internal sealed class LShiftExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            var v2 = m_Op2.Calc();
            CalculatorValue v = v1.GetLong() << v2.GetInt();
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class RShiftExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            var v2 = m_Op2.Calc();
            CalculatorValue v = v1.GetLong() >> v2.GetInt();
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class MaxExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op1.Calc().GetDouble();
            double v2 = m_Op2.Calc().GetDouble();
            CalculatorValue v = v1 >= v2 ? v1 : v2;
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class MinExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op1.Calc().GetDouble();
            double v2 = m_Op2.Calc().GetDouble();
            CalculatorValue v = v1 <= v2 ? v1 : v2;
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class AbsExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op.Calc().GetDouble();
            CalculatorValue v = v1 >= 0 ? v1 : -v1;
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op = exps[0];
            return true;
        }

        private IExpression m_Op;
    }
    internal sealed class PowExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op1.Calc().GetDouble();
            double v2 = m_Op2.Calc().GetDouble();
            CalculatorValue v = (double)Math.Pow((float)v1, (float)v2);
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class SqrtExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op1.Calc().GetDouble();
            CalculatorValue v = (double)Math.Sqrt((float)v1);
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            return true;
        }

        private IExpression m_Op1;
    }
    internal sealed class LogExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op1.Calc().GetDouble();
            CalculatorValue v = (double)Math.Log((float)v1);
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            return true;
        }

        private IExpression m_Op1;
    }
    internal sealed class Log10Exp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op1.Calc().GetDouble();
            CalculatorValue v = (double)Math.Log10((float)v1);
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            return true;
        }

        private IExpression m_Op1;
    }
    internal sealed class FloorExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op1.Calc().GetDouble();
            CalculatorValue v = Math.Floor(v1);
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            return true;
        }

        private IExpression m_Op1;
    }
    internal sealed class CeilExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op1.Calc().GetDouble();
            CalculatorValue v = Math.Ceiling(v1);
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            return true;
        }

        private IExpression m_Op1;
    }
    internal sealed class ClampExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op1.Calc().GetDouble();
            double v2 = m_Op2.Calc().GetDouble();
            double v3 = m_Op3.Calc().GetDouble();
            CalculatorValue v;
            if (v3 < v1)
                v = v1;
            else if (v3 > v2)
                v = v2;
            else
                v = v3;
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            m_Op3 = exps[2];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
        private IExpression m_Op3;
    }
    internal sealed class DistExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            float x1 = (float)m_Op1.Calc().GetDouble();
            float y1 = (float)m_Op2.Calc().GetDouble();
            float x2 = (float)m_Op3.Calc().GetDouble();
            float y2 = (float)m_Op4.Calc().GetDouble();
            CalculatorValue v = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            m_Op3 = exps[2];
            m_Op4 = exps[3];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
        private IExpression m_Op3;
        private IExpression m_Op4;
    }
    internal sealed class DistSqrExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            float x1 = (float)m_Op1.Calc().GetDouble();
            float y1 = (float)m_Op2.Calc().GetDouble();
            float x2 = (float)m_Op3.Calc().GetDouble();
            float y2 = (float)m_Op4.Calc().GetDouble();
            CalculatorValue v = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            m_Op3 = exps[2];
            m_Op4 = exps[3];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
        private IExpression m_Op3;
        private IExpression m_Op4;
    }
    internal sealed class GreatExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op1.Calc().GetDouble();
            double v2 = m_Op2.Calc().GetDouble();
            CalculatorValue v = v1 > v2 ? 1 : 0;
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class GreatEqualExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op1.Calc().GetDouble();
            double v2 = m_Op2.Calc().GetDouble();
            CalculatorValue v = v1 >= v2 ? 1 : 0;
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class LessExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op1.Calc().GetDouble();
            double v2 = m_Op2.Calc().GetDouble();
            CalculatorValue v = v1 < v2 ? 1 : 0;
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class LessEqualExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            double v1 = m_Op1.Calc().GetDouble();
            double v2 = m_Op2.Calc().GetDouble();
            CalculatorValue v = v1 <= v2 ? 1 : 0;
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class EqualExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            var v2 = m_Op2.Calc();
            CalculatorValue v = v1.ToString() == v2.ToString() ? 1 : 0;
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class NotEqualExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            var v2 = m_Op2.Calc();
            CalculatorValue v = v1.ToString() != v2.ToString() ? 1 : 0;
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class AndExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            long v1 = m_Op1.Calc().GetLong();
            long v2 = 0;
            CalculatorValue v = v1 != 0 && (v2 = m_Op2.Calc().GetLong()) != 0 ? 1 : 0;
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class OrExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            long v1 = m_Op1.Calc().GetLong();
            long v2 = 0;
            CalculatorValue v = v1 != 0 || (v2 = m_Op2.Calc().GetLong()) != 0 ? 1 : 0;
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op1 = exps[0];
            m_Op2 = exps[1];
            return true;
        }

        private IExpression m_Op1;
        private IExpression m_Op2;
    }
    internal sealed class NotExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            long val = m_Op.Calc().GetLong();
            CalculatorValue v = val == 0 ? 1 : 0;
            return v;
        }
        protected override bool Load(IList<IExpression> exps)
        {
            m_Op = exps[0];
            return true;
        }

        private IExpression m_Op;
    }
    internal sealed class CondExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var v1 = m_Op1.Calc();
            var v2 = CalculatorValue.NullObject;
            CalculatorValue v3 = CalculatorValue.NullObject;
            CalculatorValue v = v1.GetLong() != 0 ? v2 = m_Op2.Calc() : v3 = m_Op3.Calc();
            return v;
        }
        protected override bool Load(Dsl.StatementData statementData)
        {
            Dsl.FunctionData funcData1 = statementData.First.AsFunction;
            Dsl.FunctionData funcData2 = statementData.Second.AsFunction;
            if (funcData1.IsHighOrder && funcData1.HaveLowerOrderParam() && funcData2.GetId() == ":" && funcData2.HaveParamOrStatement()) {
                Dsl.ISyntaxComponent cond = funcData1.LowerOrderFunction.GetParam(0);
                Dsl.ISyntaxComponent op1 = funcData1.GetParam(0);
                Dsl.ISyntaxComponent op2 = funcData2.GetParam(0);
                m_Op1 = Calculator.Load(cond);
                m_Op2 = Calculator.Load(op1);
                m_Op3 = Calculator.Load(op2);
            }
            else {
                //error
                Calculator.Log("DslCalculator error, {0} line {1}", statementData.ToScriptString(false), statementData.GetLine());
            }
            return true;
        }

        private IExpression m_Op1 = null;
        private IExpression m_Op2 = null;
        private IExpression m_Op3 = null;
    }
    internal sealed class IfExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            CalculatorValue v = 0;
            for (int ix = 0; ix < m_Clauses.Count; ++ix) {
                var clause = m_Clauses[ix];
                if (null != clause.Condition) {
                    var condVal = clause.Condition.Calc();
                    if (condVal.GetLong() != 0) {
                        for (int index = 0; index < clause.Expressions.Count; ++index) {
                            v = clause.Expressions[index].Calc();
                            if (Calculator.RunState != RunStateEnum.Normal) {
                                return v;
                            }
                        }
                        break;
                    }
                }
                else if (ix == m_Clauses.Count - 1) {
                    for (int index = 0; index < clause.Expressions.Count; ++index) {
                        v = clause.Expressions[index].Calc();
                        if (Calculator.RunState != RunStateEnum.Normal) {
                            return v;
                        }
                    }
                    break;
                }
            }
            return v;
        }
        protected override bool Load(Dsl.FunctionData funcData)
        {
            if (funcData.IsHighOrder) {
                Dsl.ISyntaxComponent cond = funcData.LowerOrderFunction.GetParam(0);
                IfExp.Clause item = new IfExp.Clause();
                item.Condition = Calculator.Load(cond);
                for (int ix = 0; ix < funcData.GetParamNum(); ++ix) {
                    IExpression subExp = Calculator.Load(funcData.GetParam(ix));
                    item.Expressions.Add(subExp);
                }
                m_Clauses.Add(item);
            }
            else {
                //error
                Calculator.Log("DslCalculator error, {0} line {1}", funcData.ToScriptString(false), funcData.GetLine());
            }
            return true;
        }
        protected override bool Load(Dsl.StatementData statementData)
        {
            //简化语法if(exp) func(args);语法的处理
            int funcNum = statementData.GetFunctionNum();
            if (funcNum == 2) {
                var first = statementData.First.AsFunction;
                var second = statementData.Second.AsFunction;
                var firstId = first.GetId();
                var secondId = second.GetId();
                if (firstId == "if" && !first.HaveStatement() && !first.HaveExternScript() &&
                        !string.IsNullOrEmpty(secondId) && !second.HaveStatement() && !second.HaveExternScript()) {
                    IfExp.Clause item = new IfExp.Clause();
                    if (first.GetParamNum() > 0) {
                        Dsl.ISyntaxComponent cond = first.GetParam(0);
                        item.Condition = Calculator.Load(cond);
                    }
                    else {
                        //error
                        Calculator.Log("DslCalculator error, {0} line {1}", first.ToScriptString(false), first.GetLine());
                    }
                    IExpression subExp = Calculator.Load(second);
                    item.Expressions.Add(subExp);
                    m_Clauses.Add(item);
                    return true;
                }
            }
            //标准if语句的处理
            foreach (var fd in statementData.Functions) {
                var fData = fd.AsFunction;
                if (fData.GetId() == "if" || fData.GetId() == "elseif") {
                    IfExp.Clause item = new IfExp.Clause();
                    if (fData.IsHighOrder && fData.LowerOrderFunction.GetParamNum() > 0) {
                        Dsl.ISyntaxComponent cond = fData.LowerOrderFunction.GetParam(0);
                        item.Condition = Calculator.Load(cond);
                    }
                    else {
                        //error
                        Calculator.Log("DslCalculator error, {0} line {1}", fData.ToScriptString(false), fData.GetLine());
                    }
                    for (int ix = 0; ix < fData.GetParamNum(); ++ix) {
                        IExpression subExp = Calculator.Load(fData.GetParam(ix));
                        item.Expressions.Add(subExp);
                    }
                    m_Clauses.Add(item);
                }
                else if (fData.GetId() == "else") {
                    if (fData != statementData.Last) {
                        //error
                        Calculator.Log("DslCalculator error, {0} line {1}", fData.ToScriptString(false), fData.GetLine());
                    }
                    else {
                        IfExp.Clause item = new IfExp.Clause();
                        for (int ix = 0; ix < fData.GetParamNum(); ++ix) {
                            IExpression subExp = Calculator.Load(fData.GetParam(ix));
                            item.Expressions.Add(subExp);
                        }
                        m_Clauses.Add(item);
                    }
                }
                else {
                    //error
                    Calculator.Log("DslCalculator error, {0} line {1}", fData.ToScriptString(false), fData.GetLine());
                }
            }
            return true;
        }

        private sealed class Clause
        {
            internal IExpression Condition;
            internal List<IExpression> Expressions = new List<IExpression>();
        }

        private List<Clause> m_Clauses = new List<Clause>();
    }
    internal sealed class WhileExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            CalculatorValue v = 0;
            for (; ; ) {
                var condVal = m_Condition.Calc();
                if (condVal.GetLong() != 0) {
                    for (int index = 0; index < m_Expressions.Count; ++index) {
                        v = m_Expressions[index].Calc();
                        if (Calculator.RunState == RunStateEnum.Continue) {
                            Calculator.RunState = RunStateEnum.Normal;
                            break;
                        }
                        else if (Calculator.RunState != RunStateEnum.Normal) {
                            if (Calculator.RunState == RunStateEnum.Break)
                                Calculator.RunState = RunStateEnum.Normal;
                            return v;
                        }
                    }
                }
                else {
                    break;
                }
            }
            return v;
        }
        protected override bool Load(Dsl.FunctionData funcData)
        {
            if (funcData.IsHighOrder) {
                Dsl.ISyntaxComponent cond = funcData.LowerOrderFunction.GetParam(0);
                m_Condition = Calculator.Load(cond);
                for (int ix = 0; ix < funcData.GetParamNum(); ++ix) {
                    IExpression subExp = Calculator.Load(funcData.GetParam(ix));
                    m_Expressions.Add(subExp);
                }
            }
            else {
                //error
                Calculator.Log("DslCalculator error, {0} line {1}", funcData.ToScriptString(false), funcData.GetLine());
            }
            return true;
        }
        protected override bool Load(Dsl.StatementData statementData)
        {
            //简化语法while(exp) func(args);语法的处理
            if (statementData.GetFunctionNum() == 2) {
                var first = statementData.First.AsFunction;
                var second = statementData.Second.AsFunction;
                var firstId = first.GetId();
                var secondId = second.GetId();
                if (firstId == "while" && !first.HaveStatement() && !first.HaveExternScript() &&
                        !string.IsNullOrEmpty(secondId) && !second.HaveStatement() && !second.HaveExternScript()) {
                    if (first.GetParamNum() > 0) {
                        Dsl.ISyntaxComponent cond = first.GetParam(0);
                        m_Condition = Calculator.Load(cond);
                    }
                    else {
                        //error
                        Calculator.Log("DslCalculator error, {0} line {1}", first.ToScriptString(false), first.GetLine());
                    }
                    IExpression subExp = Calculator.Load(second);
                    m_Expressions.Add(subExp);
                    return true;
                }
            }
            return false;
        }

        private IExpression m_Condition;
        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class LoopExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            CalculatorValue v = 0;
            var count = m_Count.Calc();
            long ct = count.GetLong();
            for (int i = 0; i < ct; ++i) {
                Calculator.SetVariable("$$", i);
                for (int index = 0; index < m_Expressions.Count; ++index) {
                    v = m_Expressions[index].Calc();
                    if (Calculator.RunState == RunStateEnum.Continue) {
                        Calculator.RunState = RunStateEnum.Normal;
                        break;
                    }
                    else if (Calculator.RunState != RunStateEnum.Normal) {
                        if (Calculator.RunState == RunStateEnum.Break)
                            Calculator.RunState = RunStateEnum.Normal;
                        return v;
                    }
                }
            }
            return v;
        }
        protected override bool Load(Dsl.FunctionData funcData)
        {
            if (funcData.IsHighOrder) {
                Dsl.ISyntaxComponent count = funcData.LowerOrderFunction.GetParam(0);
                m_Count = Calculator.Load(count);
                for (int ix = 0; ix < funcData.GetParamNum(); ++ix) {
                    IExpression subExp = Calculator.Load(funcData.GetParam(ix));
                    m_Expressions.Add(subExp);
                }
            }
            else {
                //error
                Calculator.Log("DslCalculator error, {0} line {1}", funcData.ToScriptString(false), funcData.GetLine());
            }
            return true;
        }
        protected override bool Load(Dsl.StatementData statementData)
        {
            //简化语法loop(exp) func(args);语法的处理
            if (statementData.GetFunctionNum() == 2) {
                var first = statementData.First.AsFunction;
                var second = statementData.Second.AsFunction;
                var firstId = first.GetId();
                var secondId = second.GetId();
                if (firstId == "loop" && !first.HaveStatement() && !first.HaveExternScript() &&
                        !string.IsNullOrEmpty(secondId) && !second.HaveStatement() && !second.HaveExternScript()) {
                    if (first.GetParamNum() > 0) {
                        Dsl.ISyntaxComponent exp = first.GetParam(0);
                        m_Count = Calculator.Load(exp);
                    }
                    else {
                        //error
                        Calculator.Log("DslCalculator error, {0} line {1}", first.ToScriptString(false), first.GetLine());
                    }
                    IExpression subExp = Calculator.Load(second);
                    m_Expressions.Add(subExp);
                    return true;
                }
            }
            return false;
        }

        private IExpression m_Count;
        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class LoopListExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            CalculatorValue v = 0;
            var list = m_List.Calc();
            IEnumerable obj = list.As<IEnumerable>();
            if (null != obj) {
                IEnumerator enumer = obj.GetEnumerator();
                while (enumer.MoveNext()) {
                    var val = CalculatorValue.FromObject(enumer.Current);
                    Calculator.SetVariable("$$", val);
                    for (int index = 0; index < m_Expressions.Count; ++index) {
                        v = m_Expressions[index].Calc();
                        if (Calculator.RunState == RunStateEnum.Continue) {
                            Calculator.RunState = RunStateEnum.Normal;
                            break;
                        }
                        else if (Calculator.RunState != RunStateEnum.Normal) {
                            if (Calculator.RunState == RunStateEnum.Break)
                                Calculator.RunState = RunStateEnum.Normal;
                            return v;
                        }
                    }
                }
            }
            return v;
        }
        protected override bool Load(Dsl.FunctionData funcData)
        {
            if (funcData.IsHighOrder) {
                Dsl.ISyntaxComponent list = funcData.LowerOrderFunction.GetParam(0);
                m_List = Calculator.Load(list);
                for (int ix = 0; ix < funcData.GetParamNum(); ++ix) {
                    IExpression subExp = Calculator.Load(funcData.GetParam(ix));
                    m_Expressions.Add(subExp);
                }
            }
            else {
                //error
                Calculator.Log("DslCalculator error, {0} line {1}", funcData.ToScriptString(false), funcData.GetLine());
            }
            return true;
        }
        protected override bool Load(Dsl.StatementData statementData)
        {
            //简化语法looplist(exp) func(args);语法的处理
            if (statementData.GetFunctionNum() == 2) {
                var first = statementData.First.AsFunction;
                var second = statementData.Second.AsFunction;
                var firstId = first.GetId();
                var secondId = second.GetId();
                if (firstId == "looplist" && !first.HaveStatement() && !first.HaveExternScript() &&
                        !string.IsNullOrEmpty(secondId) && !second.HaveStatement() && !second.HaveExternScript()) {
                    if (first.GetParamNum() > 0) {
                        Dsl.ISyntaxComponent exp = first.GetParam(0);
                        m_List = Calculator.Load(exp);
                    }
                    else {
                        //error
                        Calculator.Log("DslCalculator error, {0} line {1}", first.ToScriptString(false), first.GetLine());
                    }
                    IExpression subExp = Calculator.Load(second);
                    m_Expressions.Add(subExp);
                    return true;
                }
            }
            return false;
        }

        private IExpression m_List;
        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class ForeachExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            CalculatorValue v = 0;
            List<object> list = new List<object>();
            for (int ix = 0; ix < m_Elements.Count; ++ix) {
                object val = m_Elements[ix].Calc().GetObject();
                list.Add(val);
            }
            IEnumerator enumer = list.GetEnumerator();
            while (enumer.MoveNext()) {
                var val = CalculatorValue.FromObject(enumer.Current);
                Calculator.SetVariable("$$", val);
                for (int index = 0; index < m_Expressions.Count; ++index) {
                    v = m_Expressions[index].Calc();
                    if (Calculator.RunState == RunStateEnum.Continue) {
                        Calculator.RunState = RunStateEnum.Normal;
                        break;
                    }
                    else if (Calculator.RunState != RunStateEnum.Normal) {
                        if (Calculator.RunState == RunStateEnum.Break)
                            Calculator.RunState = RunStateEnum.Normal;
                        return v;
                    }
                }
            }
            return v;
        }
        protected override bool Load(Dsl.FunctionData funcData)
        {
            if (funcData.IsHighOrder) {
                Dsl.FunctionData callData = funcData.LowerOrderFunction;
                int num = callData.GetParamNum();
                for (int ix = 0; ix < num; ++ix) {
                    Dsl.ISyntaxComponent exp = callData.GetParam(ix);
                    m_Elements.Add(Calculator.Load(exp));
                }
            }
            if (funcData.HaveStatement()) {
                int fnum = funcData.GetParamNum();
                for (int ix = 0; ix < fnum; ++ix) {
                    IExpression subExp = Calculator.Load(funcData.GetParam(ix));
                    m_Expressions.Add(subExp);
                }
            }
            return true;
        }
        protected override bool Load(Dsl.StatementData statementData)
        {
            //简化语法foreach(exp1,exp2,...) func(args);语法的处理
            if (statementData.GetFunctionNum() == 2) {
                var first = statementData.First.AsFunction;
                var second = statementData.Second.AsFunction;
                var firstId = first.GetId();
                var secondId = second.GetId();
                if (firstId == "foreach" && !first.HaveStatement() && !first.HaveExternScript() &&
                        !string.IsNullOrEmpty(secondId) && !second.HaveStatement() && !second.HaveExternScript()) {
                    int num = first.GetParamNum();
                    if (num > 0) {
                        for (int ix = 0; ix < num; ++ix) {
                            Dsl.ISyntaxComponent exp = first.GetParam(ix);
                            m_Elements.Add(Calculator.Load(exp));
                        }
                    }
                    else {
                        //error
                        Calculator.Log("DslCalculator error, {0} line {1}", first.ToScriptString(false), first.GetLine());
                    }
                    IExpression subExp = Calculator.Load(second);
                    m_Expressions.Add(subExp);
                    return true;
                }
            }
            return false;
        }

        private List<IExpression> m_Elements = new List<IExpression>();
        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class ParenthesisExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            CalculatorValue v = 0;
            for (int ix = 0; ix < m_Expressions.Count; ++ix) {
                var exp = m_Expressions[ix];
                v = exp.Calc();
            }
            return v;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class FormatExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            CalculatorValue v = 0;
            string fmt = string.Empty;
            ArrayList al = new ArrayList();
            for (int ix = 0; ix < m_Expressions.Count; ++ix) {
                var exp = m_Expressions[ix];
                v = exp.Calc();
                if (ix == 0)
                    fmt = v.AsString;
                else
                    al.Add(v);
            }
            v = string.Format(fmt, al.ToArray());
            return v;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class GetTypeAssemblyNameExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            if (m_Expressions.Count >= 1) {
                var obj = m_Expressions[0].Calc();
                try {
                    ret = obj.GetType().AssemblyQualifiedName;
                }
                catch (Exception ex) {
                    Calculator.Log("Exception:{0}\n{1}", ex.Message, ex.StackTrace);
                }
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class GetTypeFullNameExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            if (m_Expressions.Count >= 1) {
                var obj = m_Expressions[0].Calc();
                try {
                    ret = obj.GetType().FullName;
                }
                catch (Exception ex) {
                    Calculator.Log("Exception:{0}\n{1}", ex.Message, ex.StackTrace);
                }
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class GetTypeNameExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            if (m_Expressions.Count >= 1) {
                var obj = m_Expressions[0].Calc();
                try {
                    ret = obj.GetType().Name;
                }
                catch (Exception ex) {
                    Calculator.Log("Exception:{0}\n{1}", ex.Message, ex.StackTrace);
                }
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class GetTypeExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            if (m_Expressions.Count >= 1) {
                string type = m_Expressions[0].Calc().AsString;
                try {
                    var r = Type.GetType(type);
                    if (null == r) {
                        Calculator.Log("null == Type.GetType({0})", type);
                    }
                    else {
                        ret = CalculatorValue.FromObject(r);
                    }
                }
                catch (Exception ex) {
                    Calculator.Log("Exception:{0}\n{1}", ex.Message, ex.StackTrace);
                }
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class ChangeTypeExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            if (m_Expressions.Count >= 2) {
                var obj = m_Expressions[0].Calc();
                string type = m_Expressions[1].Calc().AsString;
                try {
                    string str = obj.AsString;
                    if (obj.IsString) {
                        if (0 == type.CompareTo("sbyte")) {
                            ret = CastTo<sbyte>(str);
                        }
                        else if (0 == type.CompareTo("byte")) {
                            ret = CastTo<byte>(str);
                        }
                        else if (0 == type.CompareTo("short")) {
                            ret = CastTo<short>(str);
                        }
                        else if (0 == type.CompareTo("ushort")) {
                            ret = CastTo<ushort>(str);
                        }
                        else if (0 == type.CompareTo("int")) {
                            ret = CastTo<int>(str);
                        }
                        else if (0 == type.CompareTo("uint")) {
                            ret = CastTo<uint>(str);
                        }
                        else if (0 == type.CompareTo("long")) {
                            ret = CastTo<long>(str);
                        }
                        else if (0 == type.CompareTo("ulong")) {
                            ret = CastTo<ulong>(str);
                        }
                        else if (0 == type.CompareTo("float")) {
                            ret = CastTo<float>(str);
                        }
                        else if (0 == type.CompareTo("double")) {
                            ret = CastTo<double>(str);
                        }
                        else if (0 == type.CompareTo("string")) {
                            ret = str;
                        }
                        else if (0 == type.CompareTo("bool")) {
                            ret = CastTo<bool>(str);
                        }
                        else {
                            Type t = Type.GetType(type);
                            if (null != t) {
                                ret = CalculatorValue.FromObject(CastTo(t, str));
                            }
                            else {
                                Calculator.Log("null == Type.GetType({0})", type);
                            }
                        }
                    }
                    else {
                        if (0 == type.CompareTo("sbyte")) {
                            ret = obj.GetSByte();
                        }
                        else if (0 == type.CompareTo("byte")) {
                            ret = obj.GetByte();
                        }
                        else if (0 == type.CompareTo("short")) {
                            ret = obj.GetShort();
                        }
                        else if (0 == type.CompareTo("ushort")) {
                            ret = obj.GetUShort();
                        }
                        else if (0 == type.CompareTo("int")) {
                            ret = obj.GetInt();
                        }
                        else if (0 == type.CompareTo("uint")) {
                            ret = obj.GetUInt();
                        }
                        else if (0 == type.CompareTo("long")) {
                            ret = obj.GetLong();
                        }
                        else if (0 == type.CompareTo("ulong")) {
                            ret = obj.GetULong();
                        }
                        else if (0 == type.CompareTo("float")) {
                            ret = obj.GetFloat();
                        }
                        else if (0 == type.CompareTo("double")) {
                            ret = obj.GetDouble();
                        }
                        else if (0 == type.CompareTo("string")) {
                            ret = obj.GetString();
                        }
                        else if (0 == type.CompareTo("bool")) {
                            ret = obj.GetBool();
                        }
                        else {
                            Type t = Type.GetType(type);
                            if (null != t) {
                                ret = CalculatorValue.FromObject(obj.CastTo(t));
                            }
                            else {
                                Calculator.Log("null == Type.GetType({0})", type);
                            }
                        }
                    }
                }
                catch (Exception ex) {
                    Calculator.Log("Exception:{0}\n{1}", ex.Message, ex.StackTrace);
                }
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class ParseEnumExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            if (m_Expressions.Count >= 2) {
                string type = m_Expressions[0].Calc().AsString;
                string val = m_Expressions[1].Calc().AsString;
                try {
                    Type t = Type.GetType(type);
                    if (null != t) {
                        ret = CalculatorValue.FromObject(Enum.Parse(t, val, true));
                    }
                    else {
                        Calculator.Log("null == Type.GetType({0})", type);
                    }
                }
                catch (Exception ex) {
                    Calculator.Log("Exception:{0}\n{1}", ex.Message, ex.StackTrace);
                }
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class DotnetCallExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            object obj = null;
            string method = null;
            List<CalculatorValue> args = null;
            ArrayList arglist = null;
            IObjectDispatch disp = null;
            for (int ix = 0; ix < m_Expressions.Count; ++ix) {
                var exp = m_Expressions[ix];
                var v = exp.Calc();
                if (ix == 0) {
                    obj = v.GetObject();
                    disp = obj as IObjectDispatch;
                }
                else if (ix == 1) {
                    method = v.AsString;
                }
                else if (null != disp) {
                    if (null == args)
                        args = Calculator.NewCalculatorValueList();
                    args.Add(v);
                }
                else {
                    if (null == arglist)
                        arglist = new ArrayList();
                    arglist.Add(v.GetObject());
                }
            }
            if (null != obj && null != method) {
                if (null != disp) {
                    if (m_DispId < 0) {
                        m_DispId = disp.GetDispatchId(method);
                    }
                    if (m_DispId >= 0) {
                        ret = disp.InvokeMethod(m_DispId, args);
                    }
                    Calculator.RecycleCalculatorValueList(args);
                }
                else {
                    if (null == arglist)
                        arglist = new ArrayList();
                    object[] _args = arglist.ToArray();
                    IDictionary dict = obj as IDictionary;
                    if (null != dict && dict.Contains(method) && dict[method] is Delegate) {
                        var d = dict[method] as Delegate;
                        if (null != d) {
                            ret = CalculatorValue.FromObject(d.DynamicInvoke(_args));
                        }
                    }
                    else {
                        Type t = obj as Type;
                        if (null != t) {
                            try {
                                BindingFlags flags = BindingFlags.Static | BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.NonPublic;
                                CastArgsForCall(t, method, flags, _args);
                                ret = CalculatorValue.FromObject(t.InvokeMember(method, flags, null, null, _args));
                            }
                            catch (Exception ex) {
                                Calculator.Log("InvokeMember {0} Exception:{1}\n{2}", method, ex.Message, ex.StackTrace);
                            }
                        }
                        else {
                            t = obj.GetType();
                            if (null != t) {
                                try {
                                    BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.NonPublic;
                                    CastArgsForCall(t, method, flags, _args);
                                    ret = CalculatorValue.FromObject(t.InvokeMember(method, flags, null, obj, _args));
                                }
                                catch (Exception ex) {
                                    Calculator.Log("InvokeMember {0} Exception:{1}\n{2}", method, ex.Message, ex.StackTrace);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
        private int m_DispId = -1;
    }
    internal sealed class DotnetSetExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            object obj = null;
            string method = null;
            CalculatorValue argv = CalculatorValue.NullObject;
            ArrayList arglist = null;
            IObjectDispatch disp = null;
            for (int ix = 0; ix < m_Expressions.Count; ++ix) {
                var exp = m_Expressions[ix];
                var v = exp.Calc();
                if (ix == 0) {
                    obj = v.GetObject();
                    disp = obj as IObjectDispatch;
                }
                else if (ix == 1) {
                    method = v.AsString;
                }
                else if (null != disp) {
                    argv = v;
                    break;
                }
                else {
                    if (null == arglist)
                        arglist = new ArrayList();
                    arglist.Add(v.GetObject());
                }
            }
            if (null != obj && null != method) {
                if (null != disp) {
                    if (m_DispId < 0) {
                        m_DispId = disp.GetDispatchId(method);
                    }
                    if (m_DispId >= 0) {
                        disp.SetProperty(m_DispId, argv);
                    }
                }
                else {
                    object[] _args = arglist.ToArray();
                    IDictionary dict = obj as IDictionary;
                    if (null != dict && null == obj.GetType().GetMethod(method, BindingFlags.Instance | BindingFlags.Static | BindingFlags.SetField | BindingFlags.SetProperty | BindingFlags.Public | BindingFlags.NonPublic)) {
                        dict[method] = _args[0];
                    }
                    else {
                        Type t = obj as Type;
                        if (null != t) {
                            try {
                                BindingFlags flags = BindingFlags.Static | BindingFlags.SetField | BindingFlags.SetProperty | BindingFlags.Public | BindingFlags.NonPublic;
                                CastArgsForSet(t, method, flags, _args);
                                ret = CalculatorValue.FromObject(t.InvokeMember(method, flags, null, null, _args));
                            }
                            catch (Exception ex) {
                                Calculator.Log("InvokeMember {0} Exception:{1}\n{2}", method, ex.Message, ex.StackTrace);
                            }
                        }
                        else {
                            t = obj.GetType();
                            if (null != t) {
                                try {
                                    BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.SetField | BindingFlags.SetProperty | BindingFlags.Public | BindingFlags.NonPublic;
                                    CastArgsForSet(t, method, flags, _args);
                                    ret = CalculatorValue.FromObject(t.InvokeMember(method, flags, null, obj, _args));
                                }
                                catch (Exception ex) {
                                    Calculator.Log("InvokeMember {0} Exception:{1}\n{2}", method, ex.Message, ex.StackTrace);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
        private int m_DispId = -1;
    }
    internal sealed class DotnetGetExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            object obj = null;
            string method = null;
            ArrayList arglist = null;
            IObjectDispatch disp = null;
            for (int ix = 0; ix < m_Expressions.Count; ++ix) {
                var exp = m_Expressions[ix];
                var v = exp.Calc();
                if (ix == 0) {
                    obj = v.GetObject();
                    disp = obj as IObjectDispatch;
                }
                else if (ix == 1) {
                    method = v.AsString;
                }
                else if (null != disp) {
                    break;
                }
                else {
                    if (null == arglist)
                        arglist = new ArrayList();
                    arglist.Add(v.GetObject());
                }
            }
            if (null != obj && null != method) {
                if (null != disp) {
                    if (m_DispId < 0) {
                        m_DispId = disp.GetDispatchId(method);
                    }
                    if (m_DispId >= 0) {
                        ret = disp.GetProperty(m_DispId);
                    }
                }
                else {
                    if (null == arglist)
                        arglist = new ArrayList();
                    object[] _args = arglist.ToArray();
                    IDictionary dict = obj as IDictionary;
                    if (null != dict && dict.Contains(method)) {
                        ret = CalculatorValue.FromObject(dict[method]);
                    }
                    else {
                        Type t = obj as Type;
                        if (null != t) {
                            try {
                                BindingFlags flags = BindingFlags.Static | BindingFlags.GetField | BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.NonPublic;
                                CastArgsForGet(t, method, flags, _args);
                                ret = CalculatorValue.FromObject(t.InvokeMember(method, flags, null, null, _args));
                            }
                            catch (Exception ex) {
                                Calculator.Log("InvokeMember {0} Exception:{1}\n{2}", method, ex.Message, ex.StackTrace);
                            }
                        }
                        else {
                            t = obj.GetType();
                            if (null != t) {
                                try {
                                    BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.GetField | BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.NonPublic;
                                    CastArgsForGet(t, method, flags, _args);
                                    ret = CalculatorValue.FromObject(t.InvokeMember(method, flags, null, obj, _args));
                                }
                                catch (Exception ex) {
                                    Calculator.Log("InvokeMember {0} Exception:{1}\n{2}", method, ex.Message, ex.StackTrace);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
        private int m_DispId = -1;
    }
    internal sealed class CollectionCallExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            object obj = null;
            object methodObj = null;
            ArrayList arglist = new ArrayList();
            for (int ix = 0; ix < m_Expressions.Count; ++ix) {
                var exp = m_Expressions[ix];
                var v = exp.Calc();
                if (ix == 0) {
                    obj = v.GetObject();
                }
                else if (ix == 1) {
                    methodObj = v.GetObject();
                }
                else {
                    arglist.Add(v.GetObject());
                }
            }
            object[] _args = arglist.ToArray();
            if (null != obj && null != methodObj) {
                IDictionary dict = obj as IDictionary;
                if (null != dict && dict.Contains(methodObj)) {
                    var d = dict[methodObj] as Delegate;
                    if (null != d) {
                        ret = CalculatorValue.FromObject(d.DynamicInvoke(_args));
                    }
                }
                else {
                    IList list = obj as IList;
                    if (null != list && methodObj is int) {
                        int index = (int)methodObj;
                        if (index >= 0 && index < list.Count) {
                            var d = list[index] as Delegate;
                            if (null != d) {
                                ret = CalculatorValue.FromObject(d.DynamicInvoke(_args));
                            }
                        }
                    }
                    else {
                        IEnumerable enumer = obj as IEnumerable;
                        if (null != enumer && methodObj is int) {
                            int index = (int)methodObj;
                            var e = enumer.GetEnumerator();
                            for (int i = 0; i <= index; ++i) {
                                e.MoveNext();
                            }
                            var d = e.Current as Delegate;
                            if (null != d) {
                                ret = CalculatorValue.FromObject(d.DynamicInvoke(_args));
                            }
                        }
                    }
                }
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class CollectionSetExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            object obj = null;
            object methodObj = null;
            object arg = null;
            for (int ix = 0; ix < m_Expressions.Count; ++ix) {
                var exp = m_Expressions[ix];
                var v = exp.Calc();
                if (ix == 0) {
                    obj = v.GetObject();
                }
                else if (ix == 1) {
                    methodObj = v.GetObject();
                }
                else {
                    arg = v.GetObject();
                    break;
                }
            }
            if (null != obj && null != methodObj) {
                IDictionary dict = obj as IDictionary;
                if (null != dict && dict.Contains(methodObj)) {
                    dict[methodObj] = arg;
                }
                else {
                    IList list = obj as IList;
                    if (null != list && methodObj is int) {
                        int index = (int)methodObj;
                        if (index >= 0 && index < list.Count) {
                            list[index] = arg;
                        }
                    }
                }
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class CollectionGetExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            object obj = null;
            object methodObj = null;
            for (int ix = 0; ix < m_Expressions.Count; ++ix) {
                var exp = m_Expressions[ix];
                var v = exp.Calc();
                if (ix == 0) {
                    obj = v.GetObject();
                }
                else if (ix == 1) {
                    methodObj = v.GetObject();
                }
                else {
                    break;
                }
            }
            if (null != obj && null != methodObj) {
                IDictionary dict = obj as IDictionary;
                if (null != dict && dict.Contains(methodObj)) {
                    ret = CalculatorValue.FromObject(dict[methodObj]);
                }
                else {
                    IList list = obj as IList;
                    if (null != list && methodObj is int) {
                        int index = (int)methodObj;
                        if (index >= 0 && index < list.Count) {
                            var d = list[index];
                            ret = CalculatorValue.FromObject(d);
                        }
                    }
                    else {
                        IEnumerable enumer = obj as IEnumerable;
                        if (null != enumer && methodObj is int) {
                            int index = (int)methodObj;
                            var e = enumer.GetEnumerator();
                            for (int i = 0; i <= index; ++i) {
                                e.MoveNext();
                            }
                            ret = CalculatorValue.FromObject(e.Current);
                        }
                    }
                }
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class LinqExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            CalculatorValue v = 0;
            var list = m_List.Calc().GetObject();
            var method = m_Method.Calc().GetString();
            IEnumerable obj = list as IEnumerable;
            if (null != obj && !string.IsNullOrEmpty(method)) {
                if (method == "orderby" || method == "orderbydesc") {
                    bool desc = method == "orderbydesc";
                    List<object> results = new List<object>();
                    IEnumerator enumer = obj.GetEnumerator();
                    while (enumer.MoveNext()) {
                        var val = CalculatorValue.FromObject(enumer.Current);
                        results.Add(val);
                    }
                    results.Sort((object o1, object o2) => {
                        Calculator.SetVariable("$$", CalculatorValue.FromObject(o1));
                        var r1 = CalculatorValue.NullObject;
                        for (int index = 0; index < m_Expressions.Count; ++index) {
                            r1 = m_Expressions[index].Calc();
                        }
                        Calculator.SetVariable("$$", CalculatorValue.FromObject(o2));
                        var r2 = CalculatorValue.NullObject;
                        for (int index = 0; index < m_Expressions.Count; ++index) {
                            r2 = m_Expressions[index].Calc();
                        }
                        int r = 0;
                        if (r1.IsString && r2.IsString) {
                            r = r1.GetString().CompareTo(r2.GetString());
                        }
                        else {
                            double rd1 = r1.GetDouble();
                            double rd2 = r2.GetDouble();
                            r = rd1.CompareTo(rd2);
                        }
                        if (desc)
                            r = -r;
                        return r;
                    });
                    v = CalculatorValue.FromObject(results);
                }
                else if (method == "where") {
                    List<object> results = new List<object>();
                    IEnumerator enumer = obj.GetEnumerator();
                    while (enumer.MoveNext()) {
                        var val = CalculatorValue.FromObject(enumer.Current);

                        Calculator.SetVariable("$$", val);
                        CalculatorValue r = CalculatorValue.NullObject;
                        for (int index = 0; index < m_Expressions.Count; ++index) {
                            r = m_Expressions[index].Calc();
                        }
                        if (r.GetLong() != 0) {
                            results.Add(val);
                        }
                    }
                    v = CalculatorValue.FromObject(results);
                }
                else if (method == "top") {
                    CalculatorValue r = CalculatorValue.NullObject;
                    for (int index = 0; index < m_Expressions.Count; ++index) {
                        r = m_Expressions[index].Calc();
                    }
                    long ct = r.GetLong();
                    List<object> results = new List<object>();
                    IEnumerator enumer = obj.GetEnumerator();
                    while (enumer.MoveNext()) {
                        var val = CalculatorValue.FromObject(enumer.Current);
                        if (ct > 0) {
                            results.Add(val);
                            --ct;
                        }
                    }
                    v = CalculatorValue.FromObject(results);
                }
            }
            return v;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            Dsl.ISyntaxComponent list = callData.GetParam(0);
            m_List = Calculator.Load(list);
            Dsl.ISyntaxComponent method = callData.GetParam(1);
            m_Method = Calculator.Load(method);
            for (int i = 2; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private IExpression m_List;
        private IExpression m_Method;
        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal sealed class IsNullExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            var ret = CalculatorValue.NullObject;
            if (m_Expressions.Count >= 1) {
                var obj = m_Expressions[0].Calc();
                ret = obj.IsNullObject;
            }
            return ret;
        }
        protected override bool Load(Dsl.FunctionData callData)
        {
            for (int i = 0; i < callData.GetParamNum(); ++i) {
                Dsl.ISyntaxComponent param = callData.GetParam(i);
                m_Expressions.Add(Calculator.Load(param));
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal class DotnetLoadExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                string path = operands[0].AsString;
                if (!string.IsNullOrEmpty(path) && File.Exists(path)) {
                    r = CalculatorValue.FromObject(Assembly.LoadFile(path));
                }
            }
            return r;
        }
    }
    internal class DotnetNewExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var assem = operands[0].As<Assembly>();
                string typeName = operands[1].AsString;
                if (null != assem && !string.IsNullOrEmpty(typeName)) {
                    var al = new ArrayList();
                    for (int i = 2; i < operands.Count; ++i) {
                        al.Add(operands[i].GetObject());
                    }
                    r = CalculatorValue.FromObject(assem.CreateInstance(typeName, false, BindingFlags.CreateInstance, null, al.ToArray(), System.Globalization.CultureInfo.CurrentCulture, null));
                }
            }
            return r;
        }
    }
    internal class NewStringBuilderExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 0) {
                r = CalculatorValue.FromObject(new StringBuilder());
            }
            return r;
        }
    }
    internal class AppendFormatExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var sb = operands[0].As<StringBuilder>();
                string fmt = string.Empty;
                var al = new ArrayList();
                for (int i = 1; i < operands.Count; ++i) {
                    if (i == 1)
                        fmt = operands[i].AsString;
                    else
                        al.Add(operands[i].GetObject());
                }
                if (null != sb && !string.IsNullOrEmpty(fmt)) {
                    sb.AppendFormat(fmt, al.ToArray());
                    r = CalculatorValue.FromObject(sb);
                }
            }
            return r;
        }
    }
    internal class AppendLineFormatExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var sb = operands[0].As<StringBuilder>();
                string fmt = string.Empty;
                var al = new ArrayList();
                for (int i = 1; i < operands.Count; ++i) {
                    if (i == 1)
                        fmt = operands[i].AsString;
                    else
                        al.Add(operands[i].GetObject());
                }
                if (null != sb) {
                    if (string.IsNullOrEmpty(fmt)) {
                        sb.AppendLine();
                    }
                    else {
                        sb.AppendFormat(fmt, al.ToArray());
                        sb.AppendLine();
                    }
                    r = CalculatorValue.FromObject(sb);
                }
            }
            return r;
        }
    }
    internal class StringBuilderToStringExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var sb = operands[0].As<StringBuilder>();
                if (null != sb) {
                    r = sb.ToString();
                }
            }
            return r;
        }
    }
    internal class StringJoinExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var sep = operands[0].AsString;
                var list = operands[1].As<IList>();
                if (null != sep && null != list) {
                    string[] strs = new string[list.Count];
                    for (int i = 0; i < list.Count; ++i) {
                        strs[i] = list[i].ToString();
                    }
                    r = string.Join(sep, strs);
                }
            }
            return r;
        }
    }
    internal class StringSplitExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var str = operands[0].AsString;
                var seps = operands[1].As<IList>();
                if (!string.IsNullOrEmpty(str) && null != seps) {
                    char[] cs = new char[seps.Count];
                    for (int i = 0; i < seps.Count; ++i) {
                        string sep = seps[i].ToString();
                        if (sep.Length > 0) {
                            cs[i] = sep[0];
                        }
                        else {
                            cs[i] = '\0';
                        }
                    }
                    r = CalculatorValue.FromObject(str.Split(cs));
                }
            }
            return r;
        }
    }
    internal class StringTrimExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                r = str.Trim();
            }
            return r;
        }
    }
    internal class StringTrimStartExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                r = str.TrimStart();
            }
            return r;
        }
    }
    internal class StringTrimEndExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                r = str.TrimEnd();
            }
            return r;
        }
    }
    internal class StringToLowerExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                r = str.ToLower();
            }
            return r;
        }
    }
    internal class StringToUpperExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                r = str.ToUpper();
            }
            return r;
        }
    }
    internal class StringReplaceExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 3) {
                var str = operands[0].AsString;
                var key = operands[1].AsString;
                var val = operands[2].AsString;
                r = str.Replace(key, val);
            }
            return r;
        }
    }
    internal class StringReplaceCharExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 3) {
                var str = operands[0].AsString;
                var key = operands[1].AsString;
                var val = operands[2].AsString;
                if (null != str && !string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(val)) {
                    r = str.Replace(key[0], val[0]);
                }
            }
            return r;
        }
    }
    internal class MakeStringExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            List<char> chars = new List<char>();
            for (int i = 0; i < operands.Count; ++i) {
                var v = operands[i];
                var str = v.AsString;
                if (null != str) {
                    char c = '\0';
                    if (str.Length > 0) {
                        c = str[0];
                    }
                    chars.Add(c);
                }
                else {
                    char c = operands[i].GetChar();
                    chars.Add(c);
                }
            }
            return new String(chars.ToArray());
        }
    }
    internal class StringContainsExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            bool r = false;
            if (operands.Count >= 2) {
                string str = operands[0].AsString;
                r = true;
                for (int i = 1; i < operands.Count; ++i) {
                    var list = operands[i].As<IList>();
                    if (null != list) {
                        foreach (var o in list) {
                            var key = o as string;
                            if (!string.IsNullOrEmpty(key) && !str.Contains(key)) {
                                return false;
                            }
                        }
                    }
                    else {
                        var key = operands[i].AsString;
                        if (!string.IsNullOrEmpty(key) && !str.Contains(key)) {
                            return false;
                        }
                    }
                }
            }
            return r;
        }
    }
    internal class StringNotContainsExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            bool r = false;
            if (operands.Count >= 2) {
                string str = operands[0].AsString;
                r = true;
                for (int i = 1; i < operands.Count; ++i) {
                    var list = operands[i].As<IList>();
                    if (null != list) {
                        foreach (var o in list) {
                            var key = o as string;
                            if (!string.IsNullOrEmpty(key) && str.Contains(key)) {
                                return false;
                            }
                        }
                    }
                    else {
                        var key = operands[i].AsString;
                        if (!string.IsNullOrEmpty(key) && str.Contains(key)) {
                            return false;
                        }
                    }
                }
            }
            return r;
        }
    }
    internal class StringContainsAnyExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            bool r = false;
            if (operands.Count >= 2) {
                r = true;
                string str = operands[0].AsString;
                for (int i = 1; i < operands.Count; ++i) {
                    var list = operands[i].As<IList>();
                    if (null != list) {
                        foreach (var o in list) {
                            var key = o as string;
                            if (!string.IsNullOrEmpty(key)) {
                                if (str.Contains(key)) {
                                    return true;
                                }
                                else {
                                    r = false;
                                }
                            }
                        }
                    }
                    else {
                        var key = operands[i].AsString;
                        if (!string.IsNullOrEmpty(key)) {
                            if (str.Contains(key)) {
                                return true;
                            }
                            else {
                                r = false;
                            }
                        }
                    }
                }
            }
            return r;
        }
    }
    internal class StringNotContainsAnyExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            bool r = false;
            if (operands.Count >= 2) {
                r = true;
                string str = operands[0].AsString;
                for (int i = 1; i < operands.Count; ++i) {
                    var list = operands[i].As<IList>();
                    if (null != list) {
                        foreach (var o in list) {
                            var key = o as string;
                            if (!string.IsNullOrEmpty(key)) {
                                if (!str.Contains(key)) {
                                    return true;
                                }
                                else {
                                    r = false;
                                }
                            }
                        }
                    }
                    else {
                        var key = operands[i].AsString;
                        if (!string.IsNullOrEmpty(key)) {
                            if (!str.Contains(key)) {
                                return true;
                            }
                            else {
                                r = false;
                            }
                        }
                    }
                }
            }
            return r;
        }
    }
    internal class Str2IntExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                int v;
                if (int.TryParse(str, out v)) {
                    r = v;
                }
            }
            return r;
        }
    }
    internal class Str2UintExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                uint v;
                if (uint.TryParse(str, out v)) {
                    r = v;
                }
            }
            return r;
        }
    }
    internal class Str2LongExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                long v;
                if (long.TryParse(str, out v)) {
                    r = v;
                }
            }
            return r;
        }
    }
    internal class Str2UlongExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                ulong v;
                if (ulong.TryParse(str, out v)) {
                    r = v;
                }
            }
            return r;
        }
    }
    internal class Str2FloatExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                float v;
                if (float.TryParse(str, out v)) {
                    r = v;
                }
            }
            return r;
        }
    }
    internal class Str2DoubleExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                double v;
                if (double.TryParse(str, out v)) {
                    r = v;
                }
            }
            return r;
        }
    }
    internal class Hex2IntExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                int v;
                if (int.TryParse(str, System.Globalization.NumberStyles.AllowHexSpecifier, null, out v)) {
                    r = v;
                }
            }
            return r;
        }
    }
    internal class Hex2UintExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                uint v;
                if (uint.TryParse(str, System.Globalization.NumberStyles.AllowHexSpecifier, null, out v)) {
                    r = v;
                }
            }
            return r;
        }
    }
    internal class Hex2LongExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                long v;
                if (long.TryParse(str, System.Globalization.NumberStyles.AllowHexSpecifier, null, out v)) {
                    r = v;
                }
            }
            return r;
        }
    }
    internal class Hex2UlongExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                ulong v;
                if (ulong.TryParse(str, System.Globalization.NumberStyles.AllowHexSpecifier, null, out v)) {
                    r = v;
                }
            }
            return r;
        }
    }
    internal class DatetimeStrExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var fmt = operands[0].AsString;
                r = DateTime.Now.ToString(fmt);
            }
            else {
                r = DateTime.Now.ToString();
            }
            return r;
        }
    }
    internal class LongDateStrExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            var r = CalculatorValue.FromObject(DateTime.Now.ToLongDateString());
            return r;
        }
    }
    internal class LongTimeStrExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            var r = CalculatorValue.FromObject(DateTime.Now.ToShortDateString());
            return r;
        }
    }
    internal class ShortDateStrExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            var r = CalculatorValue.FromObject(DateTime.Now.ToShortDateString());
            return r;
        }
    }
    internal class ShortTimeStrExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            var r = CalculatorValue.FromObject(DateTime.Now.ToShortTimeString());
            return r;
        }
    }
    internal class IsNullOrEmptyExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var str = operands[0].AsString;
                r = string.IsNullOrEmpty(str);
            }
            return r;
        }
    }
    internal class ArrayExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            object[] r = new object[operands.Count];
            for (int i = 0; i < operands.Count; ++i) {
                r[i] = operands[i].GetObject();
            }
            return CalculatorValue.FromObject(r);
        }
    }
    internal class ToArrayExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var list = operands[0];
                IEnumerable obj = list.As<IEnumerable>();
                if (null != obj) {
                    ArrayList al = new ArrayList();
                    IEnumerator enumer = obj.GetEnumerator();
                    while (enumer.MoveNext()) {
                        var val = CalculatorValue.FromObject(enumer.Current);
                        al.Add(val);
                    }
                    r = CalculatorValue.FromObject(al.ToArray());
                }
            }
            return r;
        }
    }
    internal class ListSizeExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var list = operands[0].As<IList>();
                if (null != list) {
                    r = list.Count;
                }
            }
            return r;
        }
    }
    internal class ListExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            ArrayList al = new ArrayList();
            for (int i = 0; i < operands.Count; ++i) {
                al.Add(operands[i].GetObject());
            }
            r = al;
            return r;
        }
    }
    internal class ListGetExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var list = operands[0].As<IList>();
                var index = operands[1].GetInt();
                var defVal = CalculatorValue.NullObject;
                if (operands.Count >= 3) {
                    defVal = operands[2];
                }
                if (null != list) {
                    if (index >= 0 && index < list.Count) {
                        r = CalculatorValue.FromObject(list[index]);
                    }
                    else {
                        r = defVal;
                    }
                }
            }
            return r;
        }
    }
    internal class ListSetExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 3) {
                var list = operands[0].As<IList>();
                var index = operands[1].GetInt();
                var val = operands[2];
                if (null != list) {
                    if (index >= 0 && index < list.Count) {
                        list[index] = val.GetObject();
                    }
                }
            }
            return r;
        }
    }
    internal class ListIndexOfExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var list = operands[0].As<IList>();
                object val = operands[1];
                if (null != list) {
                    r = list.IndexOf(val);
                }
            }
            return r;
        }
    }
    internal class ListAddExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var list = operands[0].As<IList>();
                object val = operands[1];
                if (null != list) {
                    list.Add(val);
                }
            }
            return r;
        }
    }
    internal class ListRemoveExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var list = operands[0].As<IList>();
                object val = operands[1];
                if (null != list) {
                    list.Remove(val);
                }
            }
            return r;
        }
    }
    internal class ListInsertExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 3) {
                var list = operands[0].As<IList>();
                var index = operands[1].GetInt();
                object val = operands[2].GetObject();
                if (null != list) {
                    list.Insert(index, val);
                }
            }
            return r;
        }
    }
    internal class ListRemoveAtExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var list = operands[0].As<IList>();
                var index = operands[1].GetInt();
                if (null != list) {
                    list.RemoveAt(index);
                }
            }
            return r;
        }
    }
    internal class ListClearExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var list = operands[0].As<IList>();
                if (null != list) {
                    list.Clear();
                }
            }
            return r;
        }
    }
    internal class ListSplitExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var enumer = operands[0].As<IEnumerable>();
                var ct = operands[1].GetInt();
                if (null != enumer) {
                    var e = enumer.GetEnumerator();
                    if (null != e) {
                        ArrayList al = new ArrayList();
                        ArrayList arr = new ArrayList();
                        int ix = 0;
                        while (e.MoveNext()) {
                            if (ix < ct) {
                                arr.Add(e.Current);
                                ++ix;
                            }
                            if (ix >= ct) {
                                al.Add(arr);
                                arr = new ArrayList();
                                ix = 0;
                            }
                        }
                        if (arr.Count > 0) {
                            al.Add(arr);
                        }
                        r = al;
                    }
                }
            }
            return r;
        }
    }
    internal class HashtableSizeExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var dict = operands[0].As<IDictionary>();
                if (null != dict) {
                    r = dict.Count;
                }
            }
            return r;
        }
    }
    internal class HashtableExp : AbstractExpression
    {
        protected override CalculatorValue DoCalc()
        {
            CalculatorValue r = CalculatorValue.NullObject;
            Hashtable dict = new Hashtable();
            for (int i = 0; i < m_Expressions.Count - 1; i += 2) {
                var key = m_Expressions[i].Calc().GetObject();
                var val = m_Expressions[i + 1].Calc().GetObject();
                dict.Add(key, val);
            }
            r = CalculatorValue.FromObject(dict);
            return r;
        }
        protected override bool Load(Dsl.FunctionData funcData)
        {
            for (int i = 0; i < funcData.GetParamNum(); ++i) {
                Dsl.FunctionData callData = funcData.GetParam(i) as Dsl.FunctionData;
                if (null != callData && callData.GetParamNum() == 2) {
                    var expKey = Calculator.Load(callData.GetParam(0));
                    m_Expressions.Add(expKey);
                    var expVal = Calculator.Load(callData.GetParam(1));
                    m_Expressions.Add(expVal);
                }
            }
            return true;
        }

        private List<IExpression> m_Expressions = new List<IExpression>();
    }
    internal class HashtableGetExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var dict = operands[0].As<IDictionary>();
                var index = operands[1].GetObject();
                var defVal = CalculatorValue.NullObject;
                if (operands.Count >= 3) {
                    defVal = operands[2];
                }
                if (null != dict && dict.Contains(index)) {
                    r = CalculatorValue.FromObject(dict[index]);
                }
                else {
                    r = defVal;
                }
            }
            return r;
        }
    }
    internal class HashtableSetExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 3) {
                var dict = operands[0].As<IDictionary>();
                var index = operands[1].GetObject();
                object val = operands[2].GetObject();
                if (null != dict) {
                    dict[index] = val;
                }
            }
            return r;
        }
    }
    internal class HashtableAddExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 3) {
                var dict = operands[0].As<IDictionary>();
                object key = operands[1];
                object val = operands[2];
                if (null != dict && null != key) {
                    dict.Add(key, val);
                }
            }
            return r;
        }
    }
    internal class HashtableRemoveExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var dict = operands[0].As<IDictionary>();
                object key = operands[1];
                if (null != dict && null != key) {
                    dict.Remove(key);
                }
            }
            return r;
        }
    }
    internal class HashtableClearExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var dict = operands[0].As<IDictionary>();
                if (null != dict) {
                    dict.Clear();
                }
            }
            return r;
        }
    }
    internal class HashtableKeysExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var dict = operands[0].As<IDictionary>();
                if (null != dict) {
                    var list = new ArrayList();
                    list.AddRange(dict.Keys);
                    r = list;
                }
            }
            return r;
        }
    }
    internal class HashtableValuesExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var dict = operands[0].As<IDictionary>();
                if (null != dict) {
                    var list = new ArrayList();
                    list.AddRange(dict.Values);
                    r = list;
                }
            }
            return r;
        }
    }
    internal class ListHashtableExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var dict = operands[0].As<IDictionary>();
                if (null != dict) {
                    var list = new ArrayList();
                    foreach (var pair in dict) {
                        list.Add(pair);
                    }
                    r = list;
                }
            }
            return r;
        }
    }
    internal class HashtableSplitExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var dict = operands[0].As<IDictionary>();
                var ct = operands[1].GetInt();
                if (null != dict) {
                    var e = dict.GetEnumerator();
                    if (null != e) {
                        ArrayList al = new ArrayList();
                        Hashtable ht = new Hashtable();
                        int ix = 0;
                        while (e.MoveNext()) {
                            if (ix < ct) {
                                ht.Add(e.Key, e.Value);
                                ++ix;
                            }
                            if (ix >= ct) {
                                al.Add(ht);
                                ht = new Hashtable();
                                ix = 0;
                            }
                        }
                        if (ht.Count > 0) {
                            al.Add(ht);
                        }
                        r = al;
                    }
                }
            }
            return r;
        }
    }
    //stack与queue共用peek函数
    internal class PeekExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var stack = operands[0].As<Stack<object>>();
                var queue = operands[0].As<Queue<object>>();
                if (null != stack) {
                    r = CalculatorValue.FromObject(stack.Peek());
                }
                else if (null != queue) {
                    r = CalculatorValue.FromObject(queue.Peek());
                }
            }
            return r;
        }
    }
    internal class StackSizeExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            int r = 0;
            if (operands.Count >= 1) {
                var stack = operands[0].As<Stack<object>>();
                if (null != stack) {
                    r = stack.Count;
                }
            }
            return r;
        }
    }
    internal class StackExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            var stack = new Stack<object>();
            for (int i = 0; i < operands.Count; ++i) {
                stack.Push(operands[i].GetObject());
            }
            r = CalculatorValue.FromObject(stack);
            return r;
        }
    }
    internal class PushExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var stack = operands[0].As<Stack<object>>();
                var val = operands[1];
                if (null != stack) {
                    stack.Push(val);
                }
            }
            return r;
        }
    }
    internal class PopExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var stack = operands[0].As<Stack<object>>();
                if (null != stack) {
                    r = CalculatorValue.FromObject(stack.Pop());
                }
            }
            return r;
        }
    }
    internal class StackClearExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var stack = operands[0].As<Stack<object>>();
                if (null != stack) {
                    stack.Clear();
                }
            }
            return r;
        }
    }
    internal class QueueSizeExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            int r = 0;
            if (operands.Count >= 1) {
                var queue = operands[0].As<Queue<object>>();
                if (null != queue) {
                    r = queue.Count;
                }
            }
            return r;
        }
    }
    internal class QueueExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            var queue = new Queue<object>();
            for (int i = 0; i < operands.Count; ++i) {
                queue.Enqueue(operands[i].GetObject());
            }
            r = CalculatorValue.FromObject(queue);
            return r;
        }
    }
    internal class EnqueueExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var queue = operands[0].As<Queue<object>>();
                var val = operands[1];
                if (null != queue) {
                    queue.Enqueue(val);
                }
            }
            return r;
        }
    }
    internal class DequeueExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var queue = operands[0].As<Queue<object>>();
                if (null != queue) {
                    r = CalculatorValue.FromObject(queue.Dequeue());
                }
            }
            return r;
        }
    }
    internal class QueueClearExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var queue = operands[0].As<Queue<object>>();
                if (null != queue) {
                    queue.Clear();
                }
            }
            return r;
        }
    }
    internal class SetEnvironmentExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            var ret = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var key = operands[0].AsString;
                var val = operands[1].AsString;
                val = Environment.ExpandEnvironmentVariables(val);
                Environment.SetEnvironmentVariable(key, val);
            }
            return ret;
        }
    }
    internal class GetEnvironmentExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            string ret = string.Empty;
            if (operands.Count >= 1) {
                var key = operands[0].AsString;
                return Environment.GetEnvironmentVariable(key);
            }
            return ret;
        }
    }
    internal class ExpandEnvironmentsExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            string ret = string.Empty;
            if (operands.Count >= 1) {
                var key = operands[0].AsString;
                return Environment.ExpandEnvironmentVariables(key);
            }
            return ret;
        }
    }
    internal class EnvironmentsExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            return CalculatorValue.FromObject(Environment.GetEnvironmentVariables());
        }
    }
    internal class SetCurrentDirectoryExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            string ret = string.Empty;
            if (operands.Count >= 1) {
                var dir = operands[0].AsString;
                Environment.CurrentDirectory = Environment.ExpandEnvironmentVariables(dir);
                ret = dir;
            }
            return ret;
        }
    }
    internal class GetCurrentDirectoryExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            return Environment.CurrentDirectory;
        }
    }
    internal class CommandLineExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            return Environment.CommandLine;
        }
    }
    internal class CommandLineArgsExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            if (operands.Count >= 1) {
                string name = operands[0].AsString;
                if (!string.IsNullOrEmpty(name)) {
                    string[] args = System.Environment.GetCommandLineArgs();
                    int suffixIndex = Array.FindIndex(args, item => item == name);
                    if (suffixIndex != -1 && suffixIndex < args.Length - 1) {
                        return args[suffixIndex + 1];
                    }
                }
                return string.Empty;
            }
            else {
                return CalculatorValue.FromObject(Environment.GetCommandLineArgs());
            }
        }
    }
    internal class OsExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            return Environment.OSVersion.VersionString;
        }
    }
    internal class OsPlatformExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            return Environment.OSVersion.Platform.ToString();
        }
    }
    internal class OsVersionExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            return Environment.OSVersion.Version.ToString();
        }
    }
    internal class GetFullPathExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            string ret = string.Empty;
            if (operands.Count >= 1) {
                var path = operands[0].AsString;
                if (null != path) {
                    path = Environment.ExpandEnvironmentVariables(path);
                    return Path.GetFullPath(path);
                }
            }
            return ret;
        }
    }
    internal class GetPathRootExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            string ret = string.Empty;
            if (operands.Count >= 1) {
                var path = operands[0].AsString;
                if (null != path) {
                    path = Environment.ExpandEnvironmentVariables(path);
                    return Path.GetPathRoot(path);
                }
            }
            return ret;
        }
    }
    internal class GetRandomFileNameExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            return Path.GetRandomFileName();
        }
    }
    internal class GetTempFileNameExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            return Path.GetTempFileName();
        }
    }
    internal class GetTempPathExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            return Path.GetTempPath();
        }
    }
    internal class HasExtensionExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            bool ret = false;
            if (operands.Count >= 1) {
                var path = operands[0].AsString;
                if (null != path) {
                    path = Environment.ExpandEnvironmentVariables(path);
                    return Path.HasExtension(path);
                }
            }
            return ret;
        }
    }
    internal class IsPathRootedExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            bool ret = false;
            if (operands.Count >= 1) {
                var path = operands[0].AsString;
                if (null != path) {
                    path = Environment.ExpandEnvironmentVariables(path);
                    return Path.IsPathRooted(path);
                }
            }
            return ret;
        }
    }
    internal class GetFileNameExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var path = operands[0].AsString;
                if (null != path) {
                    path = Environment.ExpandEnvironmentVariables(path);
                    r = Path.GetFileName(path);
                }
            }
            return r;
        }
    }
    internal class GetFileNameWithoutExtensionExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var path = operands[0].AsString;
                if (null != path) {
                    path = Environment.ExpandEnvironmentVariables(path);
                    r = Path.GetFileNameWithoutExtension(path);
                }
            }
            return r;
        }
    }
    internal class GetExtensionExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var path = operands[0].AsString;
                if (null != path) {
                    path = Environment.ExpandEnvironmentVariables(path);
                    r = Path.GetExtension(path);
                }
            }
            return r;
        }
    }
    internal class GetDirectoryNameExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var path = operands[0].AsString;
                if (null != path) {
                    path = Environment.ExpandEnvironmentVariables(path);
                    r = Path.GetDirectoryName(path);
                }
            }
            return r;
        }
    }
    internal class CombinePathExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var path1 = operands[0].AsString;
                var path2 = operands[1].AsString;
                if (null != path1 && null != path2) {
                    path1 = Environment.ExpandEnvironmentVariables(path1);
                    path2 = Environment.ExpandEnvironmentVariables(path2);
                    r = Path.Combine(path1, path2);
                }
            }
            return r;
        }
    }
    internal class ChangeExtensionExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 2) {
                var path = operands[0].AsString;
                var ext = operands[1].AsString;
                if (null != path && null != ext) {
                    path = Environment.ExpandEnvironmentVariables(path);
                    r = Path.ChangeExtension(path, ext);
                }
            }
            return r;
        }
    }
    internal class EchoExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var obj = operands[0];
                if (obj.IsString) {
                    var fmt = obj.StringVal;
                    if (operands.Count > 1 && null != fmt) {
                        ArrayList arrayList = new ArrayList();
                        for (int i = 1; i < operands.Count; ++i) {
                            arrayList.Add(operands[i].GetObject());
                        }
                        Console.WriteLine(fmt, arrayList.ToArray());
                    }
                    else {
                        Console.WriteLine(obj.GetObject());
                    }
                }
                else {
                    Console.WriteLine(obj.GetObject());
                }
            }
            else {
                Console.WriteLine();
            }
            return r;
        }
    }
    internal class CallStackExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            var r = System.Environment.StackTrace;
            return CalculatorValue.FromObject(r);
        }
    }
    internal class CallExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var func = operands[0].AsString;
                if (null != func) {
                    var args = Calculator.NewCalculatorValueList();
                    for (int i = 1; i < operands.Count; ++i) {
                        args.Add(operands[i]);
                    }
                    r = Calculator.Calc(func, args);
                    Calculator.RecycleCalculatorValueList(args);
                }
            }
            return r;
        }
    }
    internal class ReturnExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            Calculator.RunState = RunStateEnum.Return;
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                r = operands[0];
            }
            return r;
        }
    }
    internal class RedirectExp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            Calculator.RunState = RunStateEnum.Redirect;
            if (operands.Count >= 1) {
                List<string> args = new List<string>();
                for (int i = 0; i < operands.Count; ++i) {
                    var arg = operands[i].ToString();
                    args.Add(arg);
                }
                return CalculatorValue.FromObject(args);
            }
            return CalculatorValue.NullObject;
        }
    }
    internal class CalcMd5Exp : SimpleExpressionBase
    {
        protected override CalculatorValue OnCalc(IList<CalculatorValue> operands)
        {
            CalculatorValue r = CalculatorValue.NullObject;
            if (operands.Count >= 1) {
                var file = operands[0].AsString;
                if (null != file) {
                    r = CalcMD5(file);
                }
            }
            return r;
        }
        public string CalcMD5(string file)
        {
            byte[] array = null;
            using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
                MD5 md5 = MD5.Create();
                array = md5.ComputeHash(stream);
                stream.Close();
            }
            if (null != array) {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < array.Length; i++) {
                    stringBuilder.Append(array[i].ToString("x2"));
                }
                return stringBuilder.ToString();
            }
            else {
                return string.Empty;
            }
        }
    }
    public enum RunStateEnum
    {
        Normal = 0,
        Break,
        Continue,
        Return,
        Redirect,
    }
    public sealed class DslCalculator
    {
        public delegate bool TryGetVariableDelegation(string v, out CalculatorValue result);
        public delegate bool TrySetVariableDelegation(string v, ref CalculatorValue result);
        public delegate bool LoadFailbackDelegation(Dsl.ISyntaxComponent comp, DslCalculator calculator, out IExpression expression);
        public class FuncInfo
        {
            public Dictionary<string, int> LocalVarIndexes = new Dictionary<string, int>();
            public List<IExpression> Codes = new List<IExpression>();

            public void BuildArgNameIndexes(IList<string> argNames)
            {
                if (null != argNames) {
                    for (int ix = 0; ix < argNames.Count; ++ix) {
                        LocalVarIndexes[argNames[ix]] = -1 - ix;
                    }
                }
            }
        }

        public Dsl.DslLogDelegation OnLog;
        public TryGetVariableDelegation OnTryGetVariable;
        public TrySetVariableDelegation OnTrySetVariable;
        public LoadFailbackDelegation OnLoadFailback;

        public bool Inited { get { return m_Inited; } }
        public void Init()
        {
            m_Inited = true;

            Register("args", new ExpressionFactoryHelper<ArgsGet>());
            Register("arg", new ExpressionFactoryHelper<ArgGet>());
            Register("argnum", new ExpressionFactoryHelper<ArgNumGet>());
            Register("+", new ExpressionFactoryHelper<AddExp>());
            Register("-", new ExpressionFactoryHelper<SubExp>());
            Register("*", new ExpressionFactoryHelper<MulExp>());
            Register("/", new ExpressionFactoryHelper<DivExp>());
            Register("%", new ExpressionFactoryHelper<ModExp>());
            Register("&", new ExpressionFactoryHelper<BitAndExp>());
            Register("|", new ExpressionFactoryHelper<BitOrExp>());
            Register("^", new ExpressionFactoryHelper<BitXorExp>());
            Register("~", new ExpressionFactoryHelper<BitNotExp>());
            Register("<<", new ExpressionFactoryHelper<LShiftExp>());
            Register(">>", new ExpressionFactoryHelper<RShiftExp>());
            Register("max", new ExpressionFactoryHelper<MaxExp>());
            Register("min", new ExpressionFactoryHelper<MinExp>());
            Register("abs", new ExpressionFactoryHelper<AbsExp>());
            Register("pow", new ExpressionFactoryHelper<PowExp>());
            Register("sqrt", new ExpressionFactoryHelper<SqrtExp>());
            Register("log", new ExpressionFactoryHelper<LogExp>());
            Register("log10", new ExpressionFactoryHelper<Log10Exp>());
            Register("floor", new ExpressionFactoryHelper<FloorExp>());
            Register("ceil", new ExpressionFactoryHelper<CeilExp>());
            Register("clamp", new ExpressionFactoryHelper<ClampExp>());
            Register("dist", new ExpressionFactoryHelper<DistExp>());
            Register("distsqr", new ExpressionFactoryHelper<DistSqrExp>());
            Register(">", new ExpressionFactoryHelper<GreatExp>());
            Register(">=", new ExpressionFactoryHelper<GreatEqualExp>());
            Register("<", new ExpressionFactoryHelper<LessExp>());
            Register("<=", new ExpressionFactoryHelper<LessEqualExp>());
            Register("==", new ExpressionFactoryHelper<EqualExp>());
            Register("!=", new ExpressionFactoryHelper<NotEqualExp>());
            Register("&&", new ExpressionFactoryHelper<AndExp>());
            Register("||", new ExpressionFactoryHelper<OrExp>());
            Register("!", new ExpressionFactoryHelper<NotExp>());
            Register("?", new ExpressionFactoryHelper<CondExp>());
            Register("if", new ExpressionFactoryHelper<IfExp>());
            Register("while", new ExpressionFactoryHelper<WhileExp>());
            Register("loop", new ExpressionFactoryHelper<LoopExp>());
            Register("looplist", new ExpressionFactoryHelper<LoopListExp>());
            Register("foreach", new ExpressionFactoryHelper<ForeachExp>());
            Register("format", new ExpressionFactoryHelper<FormatExp>());
            Register("gettypeassemblyname", new ExpressionFactoryHelper<GetTypeAssemblyNameExp>());
            Register("gettypefullname", new ExpressionFactoryHelper<GetTypeFullNameExp>());
            Register("gettypename", new ExpressionFactoryHelper<GetTypeNameExp>());
            Register("gettype", new ExpressionFactoryHelper<GetTypeExp>());
            Register("changetype", new ExpressionFactoryHelper<ChangeTypeExp>());
            Register("parseenum", new ExpressionFactoryHelper<ParseEnumExp>());
            Register("dotnetcall", new ExpressionFactoryHelper<DotnetCallExp>());
            Register("dotnetset", new ExpressionFactoryHelper<DotnetSetExp>());
            Register("dotnetget", new ExpressionFactoryHelper<DotnetGetExp>());
            Register("collectioncall", new ExpressionFactoryHelper<CollectionCallExp>());
            Register("collectionset", new ExpressionFactoryHelper<CollectionSetExp>());
            Register("collectionget", new ExpressionFactoryHelper<CollectionGetExp>());
            Register("linq", new ExpressionFactoryHelper<LinqExp>());
            Register("isnull", new ExpressionFactoryHelper<IsNullExp>());
            Register("dotnetload", new ExpressionFactoryHelper<DotnetLoadExp>());
            Register("dotnetnew", new ExpressionFactoryHelper<DotnetNewExp>());
            Register("newstringbuilder", new ExpressionFactoryHelper<NewStringBuilderExp>());
            Register("appendformat", new ExpressionFactoryHelper<AppendFormatExp>());
            Register("appendlineformat", new ExpressionFactoryHelper<AppendLineFormatExp>());
            Register("stringbuildertostring", new ExpressionFactoryHelper<StringBuilderToStringExp>());
            Register("stringjoin", new ExpressionFactoryHelper<StringJoinExp>());
            Register("stringsplit", new ExpressionFactoryHelper<StringSplitExp>());
            Register("stringtrim", new ExpressionFactoryHelper<StringTrimExp>());
            Register("stringtrimstart", new ExpressionFactoryHelper<StringTrimStartExp>());
            Register("stringtrimend", new ExpressionFactoryHelper<StringTrimEndExp>());
            Register("stringtolower", new ExpressionFactoryHelper<StringToLowerExp>());
            Register("stringtoupper", new ExpressionFactoryHelper<StringToUpperExp>());
            Register("stringreplace", new ExpressionFactoryHelper<StringReplaceExp>());
            Register("stringreplacechar", new ExpressionFactoryHelper<StringReplaceCharExp>());
            Register("makestring", new ExpressionFactoryHelper<MakeStringExp>());
            Register("stringcontains", new ExpressionFactoryHelper<StringContainsExp>());
            Register("stringnotcontains", new ExpressionFactoryHelper<StringNotContainsExp>());
            Register("stringcontainsany", new ExpressionFactoryHelper<StringContainsAnyExp>());
            Register("stringnotcontainsany", new ExpressionFactoryHelper<StringNotContainsAnyExp>());
            Register("str2int", new ExpressionFactoryHelper<Str2IntExp>());
            Register("str2uint", new ExpressionFactoryHelper<Str2UintExp>());
            Register("str2long", new ExpressionFactoryHelper<Str2LongExp>());
            Register("str2ulong", new ExpressionFactoryHelper<Str2UlongExp>());
            Register("str2float", new ExpressionFactoryHelper<Str2FloatExp>());
            Register("str2double", new ExpressionFactoryHelper<Str2DoubleExp>());
            Register("hex2int", new ExpressionFactoryHelper<Hex2IntExp>());
            Register("hex2uint", new ExpressionFactoryHelper<Hex2UintExp>());
            Register("hex2long", new ExpressionFactoryHelper<Hex2LongExp>());
            Register("hex2ulong", new ExpressionFactoryHelper<Hex2UlongExp>());
            Register("datetimestr", new ExpressionFactoryHelper<DatetimeStrExp>());
            Register("longdatestr", new ExpressionFactoryHelper<LongDateStrExp>());
            Register("longtimestr", new ExpressionFactoryHelper<LongTimeStrExp>());
            Register("shortdatestr", new ExpressionFactoryHelper<ShortDateStrExp>());
            Register("shorttimestr", new ExpressionFactoryHelper<ShortTimeStrExp>());
            Register("isnullorempty", new ExpressionFactoryHelper<IsNullOrEmptyExp>());
            Register("array", new ExpressionFactoryHelper<ArrayExp>());
            Register("toarray", new ExpressionFactoryHelper<ToArrayExp>());
            Register("listsize", new ExpressionFactoryHelper<ListSizeExp>());
            Register("list", new ExpressionFactoryHelper<ListExp>());
            Register("listget", new ExpressionFactoryHelper<ListGetExp>());
            Register("listset", new ExpressionFactoryHelper<ListSetExp>());
            Register("listindexof", new ExpressionFactoryHelper<ListIndexOfExp>());
            Register("listadd", new ExpressionFactoryHelper<ListAddExp>());
            Register("listremove", new ExpressionFactoryHelper<ListRemoveExp>());
            Register("listinsert", new ExpressionFactoryHelper<ListInsertExp>());
            Register("listremoveat", new ExpressionFactoryHelper<ListRemoveAtExp>());
            Register("listclear", new ExpressionFactoryHelper<ListClearExp>());
            Register("listsplit", new ExpressionFactoryHelper<ListSplitExp>());
            Register("hashtablesize", new ExpressionFactoryHelper<HashtableSizeExp>());
            Register("hashtable", new ExpressionFactoryHelper<HashtableExp>());
            Register("hashtableget", new ExpressionFactoryHelper<HashtableGetExp>());
            Register("hashtableset", new ExpressionFactoryHelper<HashtableSetExp>());
            Register("hashtableadd", new ExpressionFactoryHelper<HashtableAddExp>());
            Register("hashtableremove", new ExpressionFactoryHelper<HashtableRemoveExp>());
            Register("hashtableclear", new ExpressionFactoryHelper<HashtableClearExp>());
            Register("hashtablekeys", new ExpressionFactoryHelper<HashtableKeysExp>());
            Register("hashtablevalues", new ExpressionFactoryHelper<HashtableValuesExp>());
            Register("listhashtable", new ExpressionFactoryHelper<ListHashtableExp>());
            Register("hashtablesplit", new ExpressionFactoryHelper<HashtableSplitExp>());
            Register("peek", new ExpressionFactoryHelper<PeekExp>());
            Register("stacksize", new ExpressionFactoryHelper<StackSizeExp>());
            Register("stack", new ExpressionFactoryHelper<StackExp>());
            Register("push", new ExpressionFactoryHelper<PushExp>());
            Register("pop", new ExpressionFactoryHelper<PopExp>());
            Register("stackclear", new ExpressionFactoryHelper<StackClearExp>());
            Register("queuesize", new ExpressionFactoryHelper<QueueSizeExp>());
            Register("queue", new ExpressionFactoryHelper<QueueExp>());
            Register("enqueue", new ExpressionFactoryHelper<EnqueueExp>());
            Register("dequeue", new ExpressionFactoryHelper<DequeueExp>());
            Register("queueclear", new ExpressionFactoryHelper<QueueClearExp>());
            Register("setenv", new ExpressionFactoryHelper<SetEnvironmentExp>());
            Register("getenv", new ExpressionFactoryHelper<GetEnvironmentExp>());
            Register("expand", new ExpressionFactoryHelper<ExpandEnvironmentsExp>());
            Register("envs", new ExpressionFactoryHelper<EnvironmentsExp>());
            Register("cd", new ExpressionFactoryHelper<SetCurrentDirectoryExp>());
            Register("pwd", new ExpressionFactoryHelper<GetCurrentDirectoryExp>());
            Register("cmdline", new ExpressionFactoryHelper<CommandLineExp>());
            Register("cmdlineargs", new ExpressionFactoryHelper<CommandLineArgsExp>());
            Register("os", new ExpressionFactoryHelper<OsExp>());
            Register("osplatform", new ExpressionFactoryHelper<OsPlatformExp>());
            Register("osversion", new ExpressionFactoryHelper<OsVersionExp>());
            Register("getfullpath", new ExpressionFactoryHelper<GetFullPathExp>());
            Register("getpathroot", new ExpressionFactoryHelper<GetPathRootExp>());
            Register("getrandomfilename", new ExpressionFactoryHelper<GetRandomFileNameExp>());
            Register("gettempfilename", new ExpressionFactoryHelper<GetTempFileNameExp>());
            Register("gettemppath", new ExpressionFactoryHelper<GetTempPathExp>());
            Register("hasextension", new ExpressionFactoryHelper<HasExtensionExp>());
            Register("ispathrooted", new ExpressionFactoryHelper<IsPathRootedExp>());
            Register("getfilename", new ExpressionFactoryHelper<GetFileNameExp>());
            Register("getfilenamewithoutextension", new ExpressionFactoryHelper<GetFileNameWithoutExtensionExp>());
            Register("getextension", new ExpressionFactoryHelper<GetExtensionExp>());
            Register("getdirectoryname", new ExpressionFactoryHelper<GetDirectoryNameExp>());
            Register("combinepath", new ExpressionFactoryHelper<CombinePathExp>());
            Register("changeextension", new ExpressionFactoryHelper<ChangeExtensionExp>());
            Register("echo", new ExpressionFactoryHelper<EchoExp>());
            Register("callstack", new ExpressionFactoryHelper<CallStackExp>());
            Register("call", new ExpressionFactoryHelper<CallExp>());
            Register("return", new ExpressionFactoryHelper<ReturnExp>());
            Register("redirect", new ExpressionFactoryHelper<RedirectExp>());
            Register("calcmd5", new ExpressionFactoryHelper<CalcMd5Exp>());
        }
        public void Register(string name, IExpressionFactory factory)
        {
            if (!m_ExpressionFactories.ContainsKey(name)) {
                m_ExpressionFactories.Add(name, factory);
            }
            else {
                m_ExpressionFactories[name] = factory;
            }
        }
        public void Clear()
        {
            m_Funcs.Clear();
            m_Stack.Clear();
            m_NamedGlobalVariableIndexes.Clear();
            m_GlobalVariables.Clear();
        }
        public void ClearGlobalVariables()
        {
            m_NamedGlobalVariableIndexes.Clear();
            m_GlobalVariables.Clear();
        }
        public IEnumerable<string> GlobalVariableNames
        {
            get { return m_NamedGlobalVariableIndexes.Keys; }
        }
        public void RemoveGlobalVariable(string v)
        {
            int index;
            if (m_NamedGlobalVariableIndexes.TryGetValue(v, out index)) {
                SetGlobalVaraibleByIndex(index, CalculatorValue.NullObject);
                m_NamedGlobalVariableIndexes.Remove(v);
            }
        }
        public bool TryGetGlobalVariable(string v, out CalculatorValue result)
        {
            if (null != OnTryGetVariable && OnTryGetVariable(v, out result)) {
                return true;
            }
            else if (m_NamedGlobalVariableIndexes.TryGetValue(v, out var index)) {
                result = GetGlobalVaraibleByIndex(index);
                return true;
            }
            else {
                result = CalculatorValue.NullObject;
                return false;
            }
        }
        public CalculatorValue GetGlobalVariable(string v)
        {
            CalculatorValue result;
            TryGetGlobalVariable(v, out result);
            return result;
        }
        public void SetGlobalVariable(string v, CalculatorValue val)
        {
            if (null != OnTrySetVariable && OnTrySetVariable(v, ref val)) {

            }
            else if (m_NamedGlobalVariableIndexes.TryGetValue(v, out var index)) {
                SetGlobalVaraibleByIndex(index, val);
            }
            else {
                int ix = m_NamedGlobalVariableIndexes.Count;
                m_NamedGlobalVariableIndexes.Add(v, ix);
                m_GlobalVariables.Add(val);
            }
        }
        public void LoadDsl(string dslFile)
        {
            Dsl.DslFile file = new Dsl.DslFile();
            string path = dslFile;
            if (file.Load(path, OnLog)) {
                foreach (Dsl.ISyntaxComponent info in file.DslInfos) {
                    LoadDsl(info);
                }
            }
        }
        public void LoadDsl(Dsl.ISyntaxComponent info)
        {
            if (info.GetId() != "script")
                return;
            var func = info as Dsl.FunctionData;
            string id;
            FuncInfo funcInfo = null;
            if (null != func) {
                if (func.IsHighOrder)
                    id = func.LowerOrderFunction.GetParamId(0);
                else
                    return;
            }
            else {
                var statement = info as Dsl.StatementData;
                if (null != statement && statement.GetFunctionNum() == 2) {
                    id = statement.First.AsFunction.GetParamId(0);
                    func = statement.Second.AsFunction;
                    if (func.GetId() == "args" && func.IsHighOrder) {
                        if (func.LowerOrderFunction.GetParamNum() > 0) {
                            funcInfo = new FuncInfo();
                            foreach (var p in func.LowerOrderFunction.Params) {
                                string argName = p.GetId();
                                int ix = funcInfo.LocalVarIndexes.Count;
                                funcInfo.LocalVarIndexes.Add(argName, -1 - ix);
                            }
                        }
                    }
                    else {
                        return;
                    }
                }
                else {
                    return;
                }
            }
            if (null == funcInfo)
                funcInfo = new FuncInfo();
            foreach (Dsl.ISyntaxComponent comp in func.Params) {
                var exp = Load(comp);
                if (null != exp) {
                    funcInfo.Codes.Add(exp);
                }
            }
            m_Funcs[id] = funcInfo;
        }
        public void LoadDsl(string func, Dsl.FunctionData dslFunc)
        {
            LoadDsl(func, null, dslFunc);
        }
        public void LoadDsl(string func, IList<string> argNames, Dsl.FunctionData dslFunc)
        {
            FuncInfo funcInfo = null;
            if (null != argNames && argNames.Count > 0) {
                funcInfo = new FuncInfo();
                foreach (var argName in argNames) {
                    int ix = funcInfo.LocalVarIndexes.Count;
                    funcInfo.LocalVarIndexes.Add(argName, -1 - ix);
                }
            }
            if (null == funcInfo)
                funcInfo = new FuncInfo();
            LoadDsl(dslFunc.Params, funcInfo.Codes);
            m_Funcs[func] = funcInfo;
        }
        public void LoadDsl(IList<Dsl.ISyntaxComponent> statements, List<IExpression> exps)
        {
            foreach (Dsl.ISyntaxComponent comp in statements) {
                var exp = Load(comp);
                if (null != exp) {
                    exps.Add(exp);
                }
            }
        }
        public List<CalculatorValue> NewCalculatorValueList()
        {
            return m_Pool.Alloc();
        }
        public void RecycleCalculatorValueList(List<CalculatorValue> list)
        {
            list.Clear();
            m_Pool.Recycle(list);
        }
        public CalculatorValue Calc(string func)
        {
            var args = NewCalculatorValueList();
            var r = Calc(func, args);
            RecycleCalculatorValueList(args);
            return r;
        }
        public CalculatorValue Calc(string func, CalculatorValue arg1)
        {
            var args = NewCalculatorValueList();
            args.Add(arg1);
            var r = Calc(func, args);
            RecycleCalculatorValueList(args);
            return r;
        }
        public CalculatorValue Calc(string func, CalculatorValue arg1, CalculatorValue arg2)
        {
            var args = NewCalculatorValueList();
            args.Add(arg1);
            args.Add(arg2);
            var r = Calc(func, args);
            RecycleCalculatorValueList(args);
            return r;
        }
        public CalculatorValue Calc(string func, CalculatorValue arg1, CalculatorValue arg2, CalculatorValue arg3)
        {
            var args = NewCalculatorValueList();
            args.Add(arg1);
            args.Add(arg2);
            args.Add(arg3);
            var r = Calc(func, args);
            RecycleCalculatorValueList(args);
            return r;
        }
        public CalculatorValue Calc(string func, List<CalculatorValue> args)
        {
            CalculatorValue ret = 0;
            FuncInfo funcInfo;
            if (m_Funcs.TryGetValue(func, out funcInfo)) {
                ret = Calc<object>(args, null, funcInfo);
            }
            return ret;
        }
        ///funcContext is recorded on the stack and its members can be accessed through custom apis (see parsing of no-argument variables in 'Load')  
        ///it's like args, but with a fixed parameter name and is mainly used to invoke snippets of code.
        public CalculatorValue Calc<T>(T funcContext, FuncInfo funcInfo) where T : class
        {
            return Calc(null, funcContext, funcInfo);
        }
        public CalculatorValue CalcInCurrentContext(IList<IExpression> exps)
        {
            CalculatorValue ret = 0;
            for (int i = 0; i < exps.Count; ++i) {
                var exp = exps[i];
                try {
                    ret = exp.Calc();
                    if (m_RunState == RunStateEnum.Return) {
                        m_RunState = RunStateEnum.Normal;
                        break;
                    }
                    else if (m_RunState == RunStateEnum.Redirect) {
                        break;
                    }
                }
                catch (DirectoryNotFoundException ex5) {
                    Log("calc:[{0}] exception:{1}\n{2}", exp.ToString(), ex5.Message, ex5.StackTrace);
                    OutputInnerException(ex5);
                }
                catch (FileNotFoundException ex4) {
                    Log("calc:[{0}] exception:{1}\n{2}", exp.ToString(), ex4.Message, ex4.StackTrace);
                    OutputInnerException(ex4);
                }
                catch (IOException ex3) {
                    Log("calc:[{0}] exception:{1}\n{2}", exp.ToString(), ex3.Message, ex3.StackTrace);
                    OutputInnerException(ex3);
                    ret = -1;
                }
                catch (UnauthorizedAccessException ex2) {
                    Log("calc:[{0}] exception:{1}\n{2}", exp.ToString(), ex2.Message, ex2.StackTrace);
                    OutputInnerException(ex2);
                    ret = -1;
                }
                catch (NotSupportedException ex1) {
                    Log("calc:[{0}] exception:{1}\n{2}", exp.ToString(), ex1.Message, ex1.StackTrace);
                    OutputInnerException(ex1);
                    ret = -1;
                }
                catch (Exception ex) {
                    Log("calc:[{0}] exception:{1}\n{2}", exp.ToString(), ex.Message, ex.StackTrace);
                    OutputInnerException(ex);
                    ret = -1;
                    break;
                }
            }
            return ret;
        }
        private CalculatorValue Calc<T>(List<CalculatorValue> args, T funcContext, FuncInfo funcInfo) where T : class
        {
            LocalStackPush(args, funcContext, funcInfo);
            try {
                return CalcInCurrentContext(funcInfo.Codes);
            }
            finally {
                LocalStackPop();
            }
        }
        public RunStateEnum RunState
        {
            get { return m_RunState; }
            internal set { m_RunState = value; }
        }
        public void Log(string fmt, params object[] args)
        {
            if (null != OnLog) {
                if (args.Length == 0)
                    OnLog(fmt);
                else
                    OnLog(string.Format(fmt, args));
            }
        }
        public void Log(object arg)
        {
            if (null != OnLog) {
                OnLog(string.Format("{0}", arg));
            }
        }
        public T GetFuncContext<T>() where T : class
        {
            var stackInfo = m_Stack.Peek();
            return stackInfo.FuncContext as T;
        }
        public IList<CalculatorValue> Arguments
        {
            get {
                var stackInfo = m_Stack.Peek();
                return stackInfo.Args;
            }
        }
        public bool TryGetVariable(string v, out CalculatorValue result)
        {
            bool ret = false;
            if (v.Length > 0) {
                if (v[0] == '@') {
                    ret = TryGetGlobalVariable(v, out result);
                }
                else if (v[0] == '$') {
                    ret = TryGetLocalVariable(v, out result);
                }
                else {
                    ret = TryGetGlobalVariable(v, out result);
                }
            }
            else {
                result = CalculatorValue.NullObject;
            }
            return ret;
        }
        public CalculatorValue GetVariable(string v)
        {
            CalculatorValue result = CalculatorValue.NullObject;
            if (v.Length > 0) {
                if (v[0] == '@') {
                    result = GetGlobalVariable(v);
                }
                else if (v[0] == '$') {
                    result = GetLocalVariable(v);
                }
                else {
                    result = GetGlobalVariable(v);
                }
            }
            return result;
        }
        public void SetVariable(string v, CalculatorValue val)
        {
            if (v.Length > 0) {
                if (v[0] == '@') {
                    SetGlobalVariable(v, val);
                }
                else if (v[0] == '$') {
                    SetLocalVariable(v, val);
                }
                else {
                    SetGlobalVariable(v, val);
                }
            }
        }
        public IExpression Load(Dsl.ISyntaxComponent comp)
        {
            Dsl.ValueData valueData = comp as Dsl.ValueData;
            Dsl.FunctionData funcData = null;
            if (null != valueData) {
                int idType = valueData.GetIdType();
                if (idType == Dsl.ValueData.ID_TOKEN) {
                    string id = valueData.GetId();
                    var p = Create(id);
                    if (null != p) {
                        //将无参数名字转换为无参函数调用
                        Dsl.FunctionData fd = new Dsl.FunctionData();
                        fd.Name.CopyFrom(valueData);
                        fd.SetParenthesisParamClass();
                        if (!p.Load(fd, this)) {
                            //error
                            Log("DslCalculator error, {0} line {1}", comp.ToScriptString(false), comp.GetLine());
                        }
                        return p;
                    }
                    else if (id == "true" || id == "false") {
                        ConstGet constExp = new ConstGet();
                        constExp.Load(comp, this);
                        return constExp;
                    }
                    else if (id.Length > 0 && id[0] == '$') {
                        LocalVarGet varExp = new LocalVarGet();
                        varExp.Load(comp, this);
                        return varExp;
                    }
                    else {
                        GlobalVarGet varExp = new GlobalVarGet();
                        varExp.Load(comp, this);
                        return varExp;
                    }
                }
                else {
                    ConstGet constExp = new ConstGet();
                    constExp.Load(comp, this);
                    return constExp;
                }
            }
            else {
                funcData = comp as Dsl.FunctionData;
                if (null != funcData) {
                    if (funcData.HaveParam()) {
                        var callData = funcData;
                        if (!callData.HaveId() && !callData.IsHighOrder && (callData.GetParamClass() == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PARENTHESIS || callData.GetParamClass() == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_BRACKET)) {
                            switch (callData.GetParamClass()) {
                                case (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PARENTHESIS:
                                    int num = callData.GetParamNum();
                                    if (num == 1) {
                                        Dsl.ISyntaxComponent param = callData.GetParam(0);
                                        return Load(param);
                                    }
                                    else {
                                        ParenthesisExp exp = new ParenthesisExp();
                                        exp.Load(comp, this);
                                        return exp;
                                    }
                                case (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_BRACKET: {
                                        ArrayExp exp = new ArrayExp();
                                        exp.Load(comp, this);
                                        return exp;
                                    }
                                default:
                                    return null;
                            }
                        }
                        else if (!callData.HaveParam()) {
                            //退化
                            valueData = callData.Name;
                            return Load(valueData);
                        }
                        else {
                            int paramClass = callData.GetParamClass();
                            string op = callData.GetId();
                            if (op == "=") {//赋值
                                Dsl.FunctionData innerCall = callData.GetParam(0) as Dsl.FunctionData;
                                if (null != innerCall) {
                                    //obj.property = val -> dotnetset(obj, property, val)
                                    int innerParamClass = innerCall.GetParamClass();
                                    if (innerParamClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD ||
                                      innerParamClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_BRACKET ||
                                      innerParamClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD_BRACE ||
                                      innerParamClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD_BRACKET ||
                                      innerParamClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD_PARENTHESIS) {
                                        Dsl.FunctionData newCall = new Dsl.FunctionData();
                                        if (innerParamClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD)
                                            newCall.Name = new Dsl.ValueData("dotnetset", Dsl.ValueData.ID_TOKEN);
                                        else
                                            newCall.Name = new Dsl.ValueData("collectionset", Dsl.ValueData.ID_TOKEN);
                                        newCall.SetParenthesisParamClass();
                                        if (innerCall.IsHighOrder) {
                                            newCall.Params.Add(innerCall.LowerOrderFunction);
                                            newCall.Params.Add(ConvertMember(innerCall.GetParam(0), innerCall.GetParamClass()));
                                            newCall.Params.Add(callData.GetParam(1));
                                        }
                                        else {
                                            newCall.Params.Add(innerCall.Name);
                                            newCall.Params.Add(ConvertMember(innerCall.GetParam(0), innerCall.GetParamClass()));
                                            newCall.Params.Add(callData.GetParam(1));
                                        }

                                        return Load(newCall);
                                    }
                                }
                                IExpression exp = null;
                                string name = callData.GetParamId(0);
                                if (name.Length > 0 && name[0] == '$') {
                                    exp = new LocalVarSet();
                                }
                                else {
                                    exp = new GlobalVarSet();
                                }
                                if (null != exp) {
                                    exp.Load(comp, this);
                                }
                                else {
                                    //error
                                    Log("DslCalculator error, {0} line {1}", callData.ToScriptString(false), callData.GetLine());
                                }
                                return exp;
                            }
                            else {
                                if (callData.IsHighOrder) {
                                    Dsl.FunctionData innerCall = callData.LowerOrderFunction;
                                    int innerParamClass = innerCall.GetParamClass();
                                    if (paramClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PARENTHESIS && (
                                        innerParamClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD ||
                                        innerParamClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_BRACKET ||
                                        innerParamClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD_BRACE ||
                                        innerParamClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD_BRACKET ||
                                        innerParamClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD_PARENTHESIS)) {
                                        //obj.member(a,b,...) or obj[member](a,b,...) or obj.(member)(a,b,...) or obj.[member](a,b,...) or obj.{member}(a,b,...) -> dotnetcall(obj,member,a,b,...)
                                        string apiName;
                                        string member = innerCall.GetParamId(0);
                                        if (member == "orderby" || member == "orderbydesc" || member == "where" || member == "top") {
                                            apiName = "linq";
                                        }
                                        else if(innerParamClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD) {
                                            apiName = "dotnetcall";
                                        }
                                        else {
                                            apiName = "collectioncall";
                                        }
                                        Dsl.FunctionData newCall = new Dsl.FunctionData();
                                        newCall.Name = new Dsl.ValueData(apiName, Dsl.ValueData.ID_TOKEN);
                                        newCall.SetParenthesisParamClass();
                                        if (innerCall.IsHighOrder) {
                                            newCall.Params.Add(innerCall.LowerOrderFunction);
                                            newCall.Params.Add(ConvertMember(innerCall.GetParam(0), innerCall.GetParamClass()));
                                            for (int i = 0; i < callData.GetParamNum(); ++i) {
                                                Dsl.ISyntaxComponent p = callData.Params[i];
                                                newCall.Params.Add(p);
                                            }
                                        }
                                        else {
                                            newCall.Params.Add(innerCall.Name);
                                            newCall.Params.Add(ConvertMember(innerCall.GetParam(0), innerCall.GetParamClass()));
                                            for (int i = 0; i < callData.GetParamNum(); ++i) {
                                                Dsl.ISyntaxComponent p = callData.Params[i];
                                                newCall.Params.Add(p);
                                            }
                                        }

                                        return Load(newCall);
                                    }
                                }
                                if (paramClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD ||
                                  paramClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_BRACKET ||
                                  paramClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD_BRACE ||
                                  paramClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD_BRACKET ||
                                  paramClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD_PARENTHESIS) {
                                    //obj.property or obj[property] or obj.(property) or obj.[property] or obj.{property} -> dotnetget(obj,property)
                                    Dsl.FunctionData newCall = new Dsl.FunctionData();
                                    if(paramClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD)
                                        newCall.Name = new Dsl.ValueData("dotnetget", Dsl.ValueData.ID_TOKEN);
                                    else
                                        newCall.Name = new Dsl.ValueData("collectionget", Dsl.ValueData.ID_TOKEN);
                                    newCall.SetParenthesisParamClass();
                                    if (callData.IsHighOrder) {
                                        newCall.Params.Add(callData.LowerOrderFunction);
                                        newCall.Params.Add(ConvertMember(callData.GetParam(0), callData.GetParamClass()));
                                    }
                                    else {
                                        newCall.Params.Add(callData.Name);
                                        newCall.Params.Add(ConvertMember(callData.GetParam(0), callData.GetParamClass()));
                                    }

                                    return Load(newCall);
                                }
                            }
                        }
                    }
                    else {
                        if (funcData.HaveStatement()) {
                            if (!funcData.HaveId() && !funcData.IsHighOrder) {
                                HashtableExp exp = new HashtableExp();
                                exp.Load(comp, this);
                                return exp;
                            }
                        }
                        else if (!funcData.HaveExternScript()) {
                            //退化
                            valueData = funcData.Name;
                            return Load(valueData);
                        }
                    }
                }
            }
            IExpression ret = Create(comp.GetId());
            if (null == ret) {
                if (null != funcData && !funcData.IsHighOrder) {
                    ret = new FunctionCall();
                }
            }
            if (null != ret) {
                Dsl.StatementData stData = comp as Dsl.StatementData;
                if (null != stData) {
                    Dsl.ValueData first = stData.First.AsValue;
                    if (null != first) {
                        //将命令行语法转换为函数调用语法
                        Dsl.FunctionData fd = new Dsl.FunctionData();
                        fd.Name = first;
                        for (int argi = 1; argi < stData.GetFunctionNum(); ++argi) {
                            var pfd = stData.GetFunction(argi);
                            fd.AddParam(pfd);
                        }
                        if (!ret.Load(fd, this)) {
                            //error
                            Log("DslCalculator error, {0} line {1}", comp.ToScriptString(false), comp.GetLine());
                        }
                        return ret;
                    }
                }
                if (!ret.Load(comp, this)) {
                    //error
                    Log("DslCalculator error, {0} line {1}", comp.ToScriptString(false), comp.GetLine());
                }
            }
            else if (null == OnLoadFailback || !OnLoadFailback(comp, this, out ret)) {
                //error
                Log("DslCalculator error, {0} line {1}", comp.ToScriptString(false), comp.GetLine());
            }
            return ret;
        }
        internal int AllocGlobalVariableIndex(string name)
        {
            int ix;
            if (null != OnTryGetVariable && OnTryGetVariable(name, out var val)) {
                ix = int.MaxValue;
            }
            else if (!m_NamedGlobalVariableIndexes.TryGetValue(name, out ix)) {
                ix = m_NamedGlobalVariableIndexes.Count;
                m_NamedGlobalVariableIndexes.Add(name, ix);
                m_GlobalVariables.Add(CalculatorValue.NullObject);
            }
            return ix;
        }
        internal int AllocLocalVariableIndex(string name)
        {
            int ix;
            if (!LocalVariableIndexes.TryGetValue(name, out ix)) {
                ix = LocalVariableIndexes.Count;
                LocalVariableIndexes.Add(name, ix);
                LocalVariables.Add(CalculatorValue.NullObject);
            }
            return ix;
        }
        internal int GetGlobalVariableIndex(string name)
        {
            int ix;
            if (!m_NamedGlobalVariableIndexes.TryGetValue(name, out ix)) {
                ix = int.MaxValue;
            }
            return ix;
        }
        internal int GetLocalVariableIndex(string name)
        {
            int ix;
            if (!LocalVariableIndexes.TryGetValue(name, out ix)) {
                ix = int.MaxValue;
            }
            return ix;
        }
        internal CalculatorValue GetGlobalVaraibleByIndex(int ix)
        {
            return m_GlobalVariables[ix];
        }
        internal CalculatorValue GetLocalVaraibleByIndex(int ix)
        {
            if (ix >= 0) {
                return LocalVariables[ix];
            }
            else {
                int argIx = -1 - ix;
                if (argIx >= 0 && argIx < Arguments.Count)
                    return Arguments[argIx];
                else
                    return CalculatorValue.NullObject;
            }
        }
        internal void SetGlobalVaraibleByIndex(int ix, CalculatorValue val)
        {
            m_GlobalVariables[ix] = val;
        }
        internal void SetLocalVaraibleByIndex(int ix, CalculatorValue val)
        {
            if (ix >= 0) {
                LocalVariables[ix] = val;
            }
            else {
                int argIx = -1 - ix;
                if (argIx >= 0 && argIx < Arguments.Count)
                    Arguments[argIx] = val;
            }
        }

        private void LocalStackPush<T>(List<CalculatorValue> args, T funcContext, FuncInfo funcInfo) where T : class
        {
            var si = StackInfo.New();
            if (null != args) {
                si.Args.AddRange(args);
            }
            si.Init(funcInfo, funcContext);
            m_Stack.Push(si);
        }
        private void LocalStackPop()
        {
            var poped = m_Stack.Pop();
            if (null != poped) {
                poped.Recycle();
            }
        }
        private Dsl.ISyntaxComponent ConvertMember(Dsl.ISyntaxComponent p, int paramClass)
        {
            var pvd = p as Dsl.ValueData;
            if (null != pvd && pvd.IsId() && (paramClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD
                || paramClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_POINTER
                || paramClass == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_QUESTION_PERIOD)) {
                pvd.SetType(Dsl.ValueData.STRING_TOKEN);
                return pvd;
            }
            else {
                return p;
            }
        }

        private IExpression Create(string name)
        {
            IExpression ret = null;
            IExpressionFactory factory;
            if (m_ExpressionFactories.TryGetValue(name, out factory)) {
                ret = factory.Create();
            }
            return ret;
        }
        private void OutputInnerException(Exception ex)
        {
            while (null != ex.InnerException) {
                ex = ex.InnerException;
                Log("\t=> exception:{0} stack:{1}", ex.Message, ex.StackTrace);
            }
        }

        private bool TryGetLocalVariable(string v, out CalculatorValue result)
        {
            int index;
            if (LocalVariableIndexes.TryGetValue(v, out index)) {
                result = GetLocalVaraibleByIndex(index);
                return true;
            }
            else {
                result = CalculatorValue.NullObject;
                return false;
            }
        }

        private CalculatorValue GetLocalVariable(string v)
        {
            CalculatorValue result;
            TryGetLocalVariable(v, out result);
            return result;
        }
        private void SetLocalVariable(string v, CalculatorValue val)
        {
            int index;
            if (LocalVariableIndexes.TryGetValue(v, out index)) {
                SetLocalVaraibleByIndex(index, val);
            }
            else {
                int ix = LocalVariableIndexes.Count;
                LocalVariableIndexes.Add(v, ix);
                LocalVariables.Add(val);
            }
        }
        private Dictionary<string, int> LocalVariableIndexes
        {
            get {
                var stackInfo = m_Stack.Peek();
                return stackInfo.FuncInfo.LocalVarIndexes;
            }
        }
        private List<CalculatorValue> LocalVariables
        {
            get {
                var stackInfo = m_Stack.Peek();
                return stackInfo.LocalVars;
            }
        }

        private class StackInfo
        {
            internal FuncInfo FuncInfo = null;
            internal object FuncContext = null;
            internal List<CalculatorValue> Args = new List<CalculatorValue>();
            internal List<CalculatorValue> LocalVars = new List<CalculatorValue>();

            internal void Init(FuncInfo funcInfo, object funcContext)
            {
                FuncInfo = funcInfo;
                FuncContext = funcContext;
                LocalVars.Capacity = funcInfo.LocalVarIndexes.Count;
                for (int ix = 0; ix < funcInfo.LocalVarIndexes.Count; ++ix) {
                    LocalVars.Add(CalculatorValue.NullObject);
                }
            }
            internal void Recycle()
            {
                FuncInfo = null;
                FuncContext = null;
                Args.Clear();
                LocalVars.Clear();

                s_Pool.Recycle(this);
            }
            internal static StackInfo New()
            {
                return s_Pool.Alloc();
            }
            private static SimpleObjectPool<StackInfo> s_Pool = new SimpleObjectPool<StackInfo>();
        }

        private bool m_Inited = false;
        private RunStateEnum m_RunState = RunStateEnum.Normal;
        private Dictionary<string, FuncInfo> m_Funcs = new Dictionary<string, FuncInfo>();
        private Stack<StackInfo> m_Stack = new Stack<StackInfo>();
        private Dictionary<string, int> m_NamedGlobalVariableIndexes = new Dictionary<string, int>();
        private List<CalculatorValue> m_GlobalVariables = new List<CalculatorValue>();
        private Dictionary<string, IExpressionFactory> m_ExpressionFactories = new Dictionary<string, IExpressionFactory>();
        private CalculatorValueListPool m_Pool = new CalculatorValueListPool(16);
    }

    public class SimpleObjectPool<T> where T : new()
    {
        public SimpleObjectPool()
        {
            m_UnusedObjects = new Queue<T>();
        }
        public SimpleObjectPool(int initPoolSize)
        {
            m_UnusedObjects = new Queue<T>(initPoolSize);
            Init(initPoolSize);
        }
        public void Init(int initPoolSize)
        {
            for (int i = 0; i < initPoolSize; ++i) {
                T t = new T();
                Recycle(t);
            }
        }
        public T Alloc()
        {
            if (m_UnusedObjects.Count > 0) {
                var t = m_UnusedObjects.Dequeue();
                m_HashCodes.Remove(t.GetHashCode());
                return t;
            }
            else {
                T t = new T();
                return t;
            }
        }
        public void Recycle(T t)
        {
            if (null != t && m_UnusedObjects.Count < m_PoolSize) {
                int hashCode = t.GetHashCode();
                if (!m_HashCodes.Contains(hashCode)) {
                    m_HashCodes.Add(hashCode);
                    m_UnusedObjects.Enqueue(t);
                }
            }
        }
        public void Clear()
        {
            m_HashCodes.Clear();
            m_UnusedObjects.Clear();
        }
        public int Count
        {
            get {
                return m_UnusedObjects.Count;
            }
        }

        private HashSet<int> m_HashCodes = new HashSet<int>();
        private Queue<T> m_UnusedObjects = new Queue<T>();
        private int m_PoolSize = 4096;
    }
}
#pragma warning restore 8600,8601,8602,8603,8604,8618,8619,8620,8625
