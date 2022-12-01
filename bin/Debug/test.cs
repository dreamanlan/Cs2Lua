using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using UnityEngine;

[Cs2Dsl.Ignore]
class LuaConsole
{
    public static void Print(params object[] args)
    {
    }
}

[Cs2Dsl.Ignore]
public static class DclApi
{
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int dcl_per_thread_init();
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void dcl_per_thread_release();

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void free_all_per_thread_data();

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong begin_data_block_struct(int field_count);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void end_data_block_struct(ulong struct_id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void remove_all_data_block_struct();
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void data_block_field_basic(ulong struct_id, int index, int field_type);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void data_block_field_struct(ulong struct_id, int index, int field_type, ulong field_struct_id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void data_block_field_max_size(ulong struct_id, uint index, uint max_size);

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void finalize_data_block(ulong structId, ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void finalize_jce_proto(int protoId, ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void handle_finalized_memory(int maxCountPerThread);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void clear_all_finalize_info();

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong alloc_data_block(int size);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void free_data_block(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void free_data_block_recursively(ulong structId, ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr get_data_block(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_data_block_size(ulong id);

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool get_data_block_bool(ulong id, int offset);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern sbyte get_data_block_int8(ulong id, int offset);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern short get_data_block_int16(ulong id, int offset);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_data_block_int32(ulong id, int offset);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern long get_data_block_int64(ulong id, int offset);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte get_data_block_uint8(ulong id, int offset);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ushort get_data_block_uint16(ulong id, int offset);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint get_data_block_uint32(ulong id, int offset);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong get_data_block_uint64(ulong id, int offset);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern float get_data_block_float(ulong id, int offset);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern double get_data_block_double(ulong id, int offset);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_data_block_bool(ulong id, int offset, bool val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_data_block_int8(ulong id, int offset, sbyte val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_data_block_int16(ulong id, int offset, short val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_data_block_int32(ulong id, int offset, int val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_data_block_int64(ulong id, int offset, long val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_data_block_uint8(ulong id, int offset, byte val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_data_block_uint16(ulong id, int offset, ushort val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_data_block_uint32(ulong id, int offset, uint val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_data_block_uint64(ulong id, int offset, ulong val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_data_block_float(ulong id, int offset, float val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_data_block_double(ulong id, int offset, double val);

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong alloc_array(uint element_size, uint num, uint max_size);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void free_array(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_array_length(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_array_length(ulong id, int len);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_array_element_size(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern sbyte get_array_element_int8(ulong id, uint index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_array_element_int8(ulong id, uint index, sbyte data);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern short get_array_element_int16(ulong id, uint index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_array_element_int16(ulong id, uint index, short data);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_array_element_int32(ulong id, uint index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_array_element_int32(ulong id, uint index, int data);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern long get_array_element_int64(ulong id, uint index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_array_element_int64(ulong id, uint index, long data);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte get_array_element_uint8(ulong id, uint index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_array_element_uint8(ulong id, uint index, byte data);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ushort get_array_element_uint16(ulong id, uint index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_array_element_uint16(ulong id, uint index, ushort data);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint get_array_element_uint32(ulong id, uint index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_array_element_uint32(ulong id, uint index, uint data);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong get_array_element_uint64(ulong id, uint index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_array_element_uint64(ulong id, uint index, ulong data);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern float get_array_element_float(ulong id, uint index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_array_element_float(ulong id, uint index, float data);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern double get_array_element_double(ulong id, uint index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool set_array_element_double(ulong id, uint index, double data);

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong alloc_empty_string();
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong alloc_string(string str);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void free_string(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong duplicate_string(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr get_cstring(ulong id);
    public unsafe static string get_string(ulong id)
    {
        IntPtr v = get_cstring(id);
        if (v.ToPointer() == null) {
            return null;
        }
        return Marshal.PtrToStringAnsi(v);
    }
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_copy(ulong id, StringBuilder buf, ulong space);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_copy_substr(ulong id, StringBuilder buf, ulong space, ulong count, ulong pos);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void string_clear(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void string_reserve_space(ulong id, ulong space);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern long string_get_length(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern sbyte string_get_char(ulong id, ulong pos);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int string_compare(ulong id, ulong other);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool string_contains(ulong id, ulong other);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern long string_index_of(ulong id, ulong other, ulong pos);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern long string_last_index_of(ulong id, ulong other, ulong pos);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void string_append(ulong id, ulong other);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void string_append_substr(ulong id, ulong other, ulong pos, ulong count);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void string_erase(ulong id, ulong pos, ulong count);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void string_insert(ulong id, ulong pos, ulong other);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void string_insert_substr(ulong id, ulong pos, ulong other, ulong other_pos, ulong count);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void string_replace(ulong id, ulong pos, ulong count, ulong other);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void string_replace_substr(ulong id, ulong pos, ulong count, ulong other, ulong pos2, ulong count2);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_replace_all(ulong id, ulong what, ulong with);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void string_swap(ulong id, ulong other);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_concat(ulong id, ulong other);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_substr(ulong id, ulong pos, ulong count);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool StrInt64MapIterateCallback(ulong key, long val);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool StrUInt64MapIterateCallback(ulong key, ulong val);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool StrDoubleMapIterateCallback(ulong key, double val);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Int64Int64MapIterateCallback(long key, long val);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Int64UInt64MapIterateCallback(long key, ulong val);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Int64DoubleMapIterateCallback(long key, double val);

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong alloc_container(uint element_type);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void free_container(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void container_clear(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void container_reserve_space(ulong id, ulong space);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern long container_get_size(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern long int64_vector_index_of_element(ulong id, long val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern long int64_vector_get_element(ulong id, ulong index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_vector_set_element(ulong id, ulong index, long val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_vector_push_back(ulong id, long val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_vector_pop_back(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_vector_erase(ulong id, ulong index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern long uint64_vector_index_of_element(ulong id, ulong val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong uint64_vector_get_element(ulong id, ulong index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool uint64_vector_set_element(ulong id, ulong index, ulong val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool uint64_vector_push_back(ulong id, ulong val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool uint64_vector_pop_back(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool uint64_vector_erase(ulong id, ulong index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern long uint64_vector_index_of_element_string(ulong id, ulong val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern long double_vector_index_of_element(ulong id, double val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern double double_vector_get_element(ulong id, ulong index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool double_vector_set_element(ulong id, ulong index, double val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool double_vector_push_back(ulong id, double val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool double_vector_pop_back(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool double_vector_erase(ulong id, ulong index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool iterate_string_int64_map(ulong id, StrInt64MapIterateCallback callback);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern long string_int64_map_get_element(ulong id, ulong key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_int64_map_get_key(ulong id, ulong key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_int64_map_set_element(ulong id, ulong key, long val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_int64_map_add_element(ulong id, ulong key, long val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool string_int64_map_remove_element(ulong id, ulong key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool string_int64_map_contains(ulong id, ulong key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool iterate_string_uint64_map(ulong id, StrUInt64MapIterateCallback callback);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_uint64_map_get_element(ulong id, ulong key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_uint64_map_get_key(ulong id, ulong key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_uint64_map_set_element(ulong id, ulong key, ulong val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_uint64_map_add_element(ulong id, ulong key, ulong val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool string_uint64_map_remove_element(ulong id, ulong key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool string_uint64_map_contains(ulong id, ulong key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool iterate_string_double_map(ulong id, StrDoubleMapIterateCallback callback);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern double string_double_map_get_element(ulong id, ulong key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_double_map_get_key(ulong id, ulong key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_double_map_set_element(ulong id, ulong key, double val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong string_double_map_add_element(ulong id, ulong key, double val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool string_double_map_remove_element(ulong id, ulong key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool string_double_map_contains(ulong id, ulong key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool iterate_int64_int64_map(ulong id, Int64Int64MapIterateCallback callback);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern long int64_int64_map_get_element(ulong id, long key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_int64_map_set_element(ulong id, long key, long val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_int64_map_add_element(ulong id, long key, long val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_int64_map_remove_element(ulong id, long key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_int64_map_contains(ulong id, long key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool iterate_int64_uint64_map(ulong id, Int64UInt64MapIterateCallback callback);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong int64_uint64_map_get_element(ulong id, long key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_uint64_map_set_element(ulong id, long key, ulong val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_uint64_map_add_element(ulong id, long key, ulong val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_uint64_map_remove_element(ulong id, long key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_uint64_map_contains(ulong id, long key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool iterate_int64_double_map(ulong id, Int64DoubleMapIterateCallback callback);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern double int64_double_map_get_element(ulong id, long key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_double_map_set_element(ulong id, long key, double val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_double_map_add_element(ulong id, long key, double val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_double_map_remove_element(ulong id, long key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool int64_double_map_contains(ulong id, long key);

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void set_table_root_path(string rootPath);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong alloc_table(int fieldCount);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void set_table_field_name(ulong id, uint index, string fieldName);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void set_table_field_type(ulong id, uint index, int fieldType);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void finish_table_struct(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void load_table(ulong id, string file, string keyField);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void free_table_lookup_info();
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void free_table(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void free_all_table();
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong get_table_record_count(ulong id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong get_table_record(ulong id, ulong index);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_table_record_index_by_key_int(ulong id, int key);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_table_record_index_by_key_string(ulong id, ulong key);

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong begin_jce_protocol_struct(int field_count);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void end_jce_protocol_struct(ulong struct_id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void remove_all_jce_protocol_struct();
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void jce_protocol_field_basic(ulong struct_id, int index, int tag, int field_type);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void jce_protocol_field_struct(ulong struct_id, int index, int tag, int field_type, ulong field_struct_id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void jce_protocol_field_default_value_uint64(ulong struct_id, int index, ulong def_val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void jce_protocol_field_default_value_double(ulong struct_id, int index, double def_val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void jce_protocol_field_default_value_string(ulong struct_id, int index, string def_val);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void jce_protocol_field_max_size(ulong struct_id, uint index, uint max_size);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void map_jce_protocol_struct(int proto_id, ulong struct_id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong query_jce_protocol_struct(int proto_id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong decode_jce_protocol(int proto_id, IntPtr buf, int size);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int encode_jce_protocol(int proto_id, ulong handle, IntPtr buf, int size);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool free_jce_protocol(int proto_id, ulong handle);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong alloc_jce_protocol_from_pool(int proto_id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool recycle_jce_protocol_to_pool(int proto_id, ulong handle);

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void clear_post_transfer_station(bool onlyIfQueueIsEmpty);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void clear_receive_transfer_station(bool onlyIfQueueIsEmpty);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void post_jce_proto(int op, int proto_id, ulong data_block_id);
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int receive_jce_proto(out int proto_id, out ulong data_block_id);

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern void free_all_const_string();

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_data_block_count();
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_string_count();
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_string_ref_count();
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_readonly_data_block_count();
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_const_string_count();
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_table_count();
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_jce_proto_struct_count();
    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int get_data_block_struct_count();

    [DllImport("cppmodule", CallingConvention = CallingConvention.Cdecl)]
    public static extern int luaopen_dcl_api(IntPtr L);
}

namespace DataBlockDefine
{
    public enum ContainerTypeEnum : uint
    {
        Int64Vector = 1,
        UInt64Vector,
        DoubleVector,
        StrInt64Map,
        StrUInt64Map,
        StrDoubleMap,
        Int64Int64Map,
        Int64UInt64Map,
        Int64DoubleMap,
    }
    public enum DataBlockFieldTypeEnum : int
    {
        DataBoolField = 1,
        DataInt8Field,
        DataUInt8Field,
        DataInt16Field,
        DataUInt16Field,
        DataInt32Field,
        DataUInt32Field,
        DataInt64Field,
        DataUInt64Field,
        DataFloatField,
        DataDoubleField,
        DataStringField,
        DataBoolArrayField,
        DataInt8ArrayField,
        DataUInt8ArrayField,
        DataInt16ArrayField,
        DataUInt16ArrayField,
        DataInt32ArrayField,
        DataUInt32ArrayField,
        DataInt64ArrayField,
        DataUInt64ArrayField,
        DataFloatArrayField,
        DataDoubleArrayField,
        DataStringArrayField,
        DataStructField,
        DataStructArrayField,
        DataInt64VectorField,
        DataUInt64VectorField,
        DataDoubleVectorField,
        DataStrVectorField,
        DataStructVectorField,
        DataStrInt64MapField,
        DataStrUInt64MapField,
        DataStrDoubleMapField,
        DataStrStrMapField,
        DataStrStructMapField,
        DataInt64Int64MapField,
        DataInt64UInt64MapField,
        DataInt64DoubleMapField,
        DataInt64StrMapField,
        DataInt64StructMapField,
    }
    public enum TableFieldTypeEnum : int
    {
        TableInt32Field = 1,
        TableInt64Field,
        TableFloatField,
        TableStringField,
        TableInt32ArrayField,
        TableInt64ArrayField,
        TableFloatArrayField,
        TableStringArrayField,
    }
    public enum JceFieldTypeEnum : int
    {
        JceBoolField = 1,
        JceInt8Field,
        JceUInt8Field,
        JceInt16Field,
        JceUInt16Field,
        JceInt32Field,
        JceUInt32Field,
        JceInt64Field,
        JceUInt64Field,
        JceFloatField,
        JceDoubleField,
        JceStringField,
        JceBoolListField,
        JceInt8ListField,
        JceUInt8ListField,
        JceInt16ListField,
        JceUInt16ListField,
        JceInt32ListField,
        JceUInt32ListField,
        JceInt64ListField,
        JceUInt64ListField,
        JceFloatListField,
        JceDoubleListField,
        JceStringListField,
        JceStructField,
        JceStructListField,
    }
    public enum JceOperationEnum : int
    {
        Nothing = 0,
        Post,
        Recycle,
        PostAndRecycle
    }
    public delegate IDataBlock NewDataBlockDelegation();
    public interface IDataBlock
    {
        ulong GetDataBlockId();
        void Init();
        void Release();
        void Attach(ulong dataBlockId);
        void Detach();
    }
    public interface IFinalizableDataBlock : IDataBlock
    {
        void DoFinalize();
    }
    public interface IJceProto : IFinalizableDataBlock
    {
        void Recycle();
        int Encode(IntPtr buf, int len);
        void Decode(IntPtr buf, int len);
        void Post(JceOperationEnum op);
    }
    public class BaseIntegerArray : IDataBlock
    {
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
                m_DataBlockId = 0;
            }
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public int GetLength()
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_length(m_DataBlockId);
            }
            else {
                return 0;
            }
        }

        protected bool m_IsValid;
        protected ulong m_DataBlockId;
    }
    public class Int8Array : BaseIntegerArray
    {
        public void Reset(uint size)
        {
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
            }
            m_DataBlockId = DclApi.alloc_array(sizeof(sbyte), size, size);
        }
        public sbyte GetData(int index)
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_element_int8(m_DataBlockId, (uint)index);
            }
            else {
                return 0;
            }
        }
        public void SetData(int index, sbyte val)
        {
            if (m_DataBlockId != 0) {
                DclApi.set_array_element_int8(m_DataBlockId, (uint)index, val);
            }
        }
    }
    public class UInt8Array : BaseIntegerArray
    {
        public void Reset(uint size)
        {
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
            }
            m_DataBlockId = DclApi.alloc_array(sizeof(byte), size, size);
        }
        public byte GetData(int index)
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_element_uint8(m_DataBlockId, (uint)index);
            }
            else {
                return 0;
            }
        }
        public void SetData(int index, byte val)
        {
            if (m_DataBlockId != 0) {
                DclApi.set_array_element_uint8(m_DataBlockId, (uint)index, val);
            }
        }
    }
    public class Int16Array : BaseIntegerArray
    {
        public void Reset(uint size)
        {
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
            }
            m_DataBlockId = DclApi.alloc_array(sizeof(short), size, size);
        }
        public short GetData(int index)
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_element_int16(m_DataBlockId, (uint)index);
            }
            else {
                return 0;
            }
        }
        public void SetData(int index, short val)
        {
            if (m_DataBlockId != 0) {
                DclApi.set_array_element_int16(m_DataBlockId, (uint)index, val);
            }
        }
    }
    public class UInt16Array : BaseIntegerArray
    {
        public void Reset(uint size)
        {
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
            }
            m_DataBlockId = DclApi.alloc_array(sizeof(ushort), size, size);
        }
        public ushort GetData(int index)
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_element_uint16(m_DataBlockId, (uint)index);
            }
            else {
                return 0;
            }
        }
        public void SetData(int index, ushort val)
        {
            if (m_DataBlockId != 0) {
                DclApi.set_array_element_uint16(m_DataBlockId, (uint)index, val);
            }
        }
    }
    public class Int32Array : BaseIntegerArray
    {
        public void Reset(uint size)
        {
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
            }
            m_DataBlockId = DclApi.alloc_array(sizeof(int), size, size);
        }
        public int GetData(int index)
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_element_int32(m_DataBlockId, (uint)index);
            }
            else {
                return 0;
            }
        }
        public void SetData(int index, int val)
        {
            if (m_DataBlockId != 0) {
                DclApi.set_array_element_int32(m_DataBlockId, (uint)index, val);
            }
        }
    }
    public class UInt32Array : BaseIntegerArray
    {
        public void Reset(uint size)
        {
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
            }
            m_DataBlockId = DclApi.alloc_array(sizeof(uint), size, size);
        }
        public uint GetData(int index)
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_element_uint32(m_DataBlockId, (uint)index);
            }
            else {
                return 0;
            }
        }
        public void SetData(int index, uint val)
        {
            if (m_DataBlockId != 0) {
                DclApi.set_array_element_uint32(m_DataBlockId, (uint)index, val);
            }
        }
    }
    public class Int64Array : BaseIntegerArray
    {
        public void Reset(uint size)
        {
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
            }
            m_DataBlockId = DclApi.alloc_array(sizeof(long), size, size);
        }
        public long GetData(int index)
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_element_int64(m_DataBlockId, (uint)index);
            }
            else {
                return 0;
            }
        }
        public void SetData(int index, long val)
        {
            if (m_DataBlockId != 0) {
                DclApi.set_array_element_int64(m_DataBlockId, (uint)index, val);
            }
        }
    }
    public class UInt64Array : BaseIntegerArray
    {
        public void Reset(uint size)
        {
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
            }
            m_DataBlockId = DclApi.alloc_array(sizeof(ulong), size, size);
        }
        public ulong GetData(int index)
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_element_uint64(m_DataBlockId, (uint)index);
            }
            else {
                return 0;
            }
        }
        public void SetData(int index, ulong val)
        {
            if (m_DataBlockId != 0) {
                DclApi.set_array_element_uint64(m_DataBlockId, (uint)index, val);
            }
        }
    }
    public class FloatArray : BaseIntegerArray
    {
        public void Reset(uint size)
        {
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
            }
            m_DataBlockId = DclApi.alloc_array(sizeof(float), size, size);
        }
        public float GetData(int index)
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_element_float(m_DataBlockId, (uint)index);
            }
            else {
                return 0;
            }
        }
        public void SetData(int index, float val)
        {
            if (m_DataBlockId != 0) {
                DclApi.set_array_element_float(m_DataBlockId, (uint)index, val);
            }
        }
    }
    public class DoubleArray : BaseIntegerArray
    {
        public void Reset(uint size)
        {
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
            }
            m_DataBlockId = DclApi.alloc_array(sizeof(double), size, size);
        }
        public double GetData(int index)
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_element_double(m_DataBlockId, (uint)index);
            }
            else {
                return 0;
            }
        }
        public void SetData(int index, double val)
        {
            if (m_DataBlockId != 0) {
                DclApi.set_array_element_double(m_DataBlockId, (uint)index, val);
            }
        }
    }

    public class CString : IDataBlock
    {
        public CString()
        { }
        public CString(string str)
        {
            Init();
            SetString(str);
        }
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            m_StringCache = null;
            if (m_DataBlockId != 0) {
                DclApi.free_string(m_DataBlockId);
                m_DataBlockId = 0;
            }
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            m_StringCache = null;
            m_DataBlockId = 0;
            m_IsValid = false;
        }

        public string GetString()
        {
            if (null == m_StringCache && m_DataBlockId != 0) {
                m_StringCache = DclApi.get_string(m_DataBlockId);
            }
            return m_StringCache;
        }
        public void SetString(string val)
        {
            m_StringCache = val;
            if (m_DataBlockId != 0) {
                DclApi.free_string(m_DataBlockId);
            }
            m_DataBlockId = DclApi.alloc_string(m_StringCache);
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
        private string m_StringCache;
    }

    public class Int64Vector : IDataBlock
    {
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_DataBlockId = DclApi.alloc_container((int)ContainerTypeEnum.Int64Vector);
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            DclApi.free_container(m_DataBlockId);
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            m_DataBlockId = 0;
            m_IsValid = false;
        }

        public void Reserve(int space)
        {
            DclApi.container_reserve_space(m_DataBlockId, (ulong)space);
        }
        public int GetCount()
        {
            return (int)DclApi.container_get_size(m_DataBlockId);
        }
        public long GetData(int index)
        {
            if (index >= 0 && index < GetCount()) {
                return DclApi.int64_vector_get_element(m_DataBlockId, (ulong)index);
            }
            return 0;
        }
        public void SetData(int index, long data)
        {
            if (index >= 0 && index < GetCount()) {
                DclApi.int64_vector_set_element(m_DataBlockId, (ulong)index, data);
            }
        }
        public int IndexOf(long data)
        {
            for (int ix = 0; ix < GetCount(); ++ix) {
                if (GetData(ix) == data)
                    return ix;
            }
            return -1;
        }
        public long GetLast()
        {
            return GetData(GetCount() - 1);
        }
        public void AddLast(long data)
        {
            DclApi.int64_vector_push_back(m_DataBlockId, data);
        }
        public void RemoveLast()
        {
            DclApi.int64_vector_pop_back(m_DataBlockId);
        }
        public void Remove(long data)
        {
            int index = IndexOf(data);
            RemoveAt(index);
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < GetCount()) {
                DclApi.int64_vector_erase(m_DataBlockId, (ulong)index);
            }
        }
        public void Clear()
        {
            DclApi.container_clear(m_DataBlockId);
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
    }
    public class DoubleVector : IDataBlock
    {
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_DataBlockId = DclApi.alloc_container((int)ContainerTypeEnum.DoubleVector);
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            DclApi.free_container(m_DataBlockId);
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            m_DataBlockId = 0;
            m_IsValid = false;
        }

        public void Reserve(int space)
        {
            DclApi.container_reserve_space(m_DataBlockId, (ulong)space);
        }
        public int GetCount()
        {
            return (int)DclApi.container_get_size(m_DataBlockId);
        }
        public double GetData(int index)
        {
            if (index >= 0 && index < GetCount()) {
                return DclApi.double_vector_get_element(m_DataBlockId, (ulong)index);
            }
            return 0;
        }
        public void SetData(int index, double data)
        {
            if (index >= 0 && index < GetCount()) {
                DclApi.double_vector_set_element(m_DataBlockId, (ulong)index, data);
            }
        }
        public int IndexOf(double data)
        {
            return (int)DclApi.double_vector_index_of_element(m_DataBlockId, data);
        }
        public double GetLast()
        {
            return GetData(GetCount() - 1);
        }
        public void AddLast(double data)
        {
            DclApi.double_vector_push_back(m_DataBlockId, data);
        }
        public void RemoveLast()
        {
            DclApi.double_vector_pop_back(m_DataBlockId);
        }
        public void Remove(long data)
        {
            int index = IndexOf(data);
            RemoveAt(index);
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < GetCount()) {
                DclApi.double_vector_erase(m_DataBlockId, (ulong)index);
            }
        }
        public void Clear()
        {
            DclApi.container_clear(m_DataBlockId);
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
    }
    public class StringVector : IDataBlock
    {
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_DataBlockId = DclApi.alloc_container((int)ContainerTypeEnum.UInt64Vector);
            m_DataWrap.Clear();
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            Clear();
            DclApi.free_container(m_DataBlockId);
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            int ct = (int)DclApi.container_get_size(m_DataBlockId);
            for (int ix = 0; ix < ct; ++ix) {
                ulong strId = DclApi.uint64_vector_get_element(m_DataBlockId, (ulong)ix);
                CString cstr = new CString();
                cstr.Attach(strId);
                m_DataWrap.Add(cstr);
            }
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            foreach (var str in m_DataWrap) {
                str.Detach();
            }
            m_DataWrap.Clear();
            m_DataBlockId = 0;
            m_IsValid = false;
        }

        public void Reserve(int space)
        {
            m_DataWrap.Capacity = space;
            DclApi.container_reserve_space(m_DataBlockId, (ulong)space);
        }
        public int GetCount()
        {
            return m_DataWrap.Count;
        }
        public CString GetData(int index)
        {
            if (index >= 0 && index < GetCount()) {
                return m_DataWrap[index];
            }
            return null;
        }
        public void SetData(int index, CString data)
        {
            if (index >= 0 && index < GetCount()) {
                var oldData = m_DataWrap[index];
                if (null != oldData) {
                    oldData.Release();
                }
                m_DataWrap[index] = data;
                DclApi.uint64_vector_set_element(m_DataBlockId, (ulong)index, null == data ? 0 : data.GetDataBlockId());
            }
        }
        public int IndexOf(CString data)
        {
            for (int ix = 0; ix < GetCount(); ++ix) {
                if (GetData(ix) == data)
                    return ix;
            }
            return -1;
        }
        public CString GetLast()
        {
            if (GetCount() > 0)
                return GetData(GetCount() - 1);
            else
                return null;
        }
        public void AddLast(CString data)
        {
            m_DataWrap.Add(data);
            DclApi.uint64_vector_push_back(m_DataBlockId, null == data ? 0 : data.GetDataBlockId());
        }
        public void RemoveLast()
        {
            if (m_DataWrap.Count > 0) {
                var oldData = m_DataWrap[m_DataWrap.Count - 1];
                if (null != oldData) {
                    oldData.Release();
                }
                m_DataWrap.RemoveAt(m_DataWrap.Count - 1);
                DclApi.uint64_vector_pop_back(m_DataBlockId);
            }
        }
        public void Remove(CString data)
        {
            int index = IndexOf(data);
            if (index >= 0) {
                if (null != data) {
                    data.Release();
                }
                RemoveAt(index);
            }
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < GetCount()) {
                var oldData = m_DataWrap[index];
                if (null != oldData) {
                    oldData.Release();
                }
                m_DataWrap.RemoveAt(index);
                DclApi.uint64_vector_erase(m_DataBlockId, (ulong)index);
            }
        }
        public void Clear()
        {
            foreach (var str in m_DataWrap) {
                str.Release();
            }
            m_DataWrap.Clear();
            DclApi.container_clear(m_DataBlockId);
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
        private List<CString> m_DataWrap = new List<CString>();
    }
    public class DataBlockVector : IDataBlock
    {
        public NewDataBlockDelegation OnNewDataBlock;
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_DataBlockId = DclApi.alloc_container((int)ContainerTypeEnum.UInt64Vector);
            m_DataWrap.Clear();
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            foreach (var elem in m_DataWrap) {
                if (null != elem) {
                    elem.Release();
                }
            }
            m_DataWrap.Clear();
            DclApi.free_container(m_DataBlockId);
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            long ct = DclApi.container_get_size(dataBlockId);
            for (long ix = 0; ix < ct; ++ix) {
                var elem = OnNewDataBlock();
                elem.Attach(DclApi.uint64_vector_get_element(dataBlockId, (ulong)ix));
                m_DataWrap.Add(elem);
            }
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            foreach (var elem in m_DataWrap) {
                if (null != elem) {
                    elem.Detach();
                }
            }
            m_DataWrap.Clear();
            m_DataBlockId = 0;
            m_IsValid = false;
        }

        public void Reserve(int space)
        {
            m_DataWrap.Capacity = space;
            DclApi.container_reserve_space(m_DataBlockId, (ulong)space);
        }
        public int GetCount()
        {
            return m_DataWrap.Count;
        }
        public T GetData<T>(int index) where T : IDataBlock
        {
            if (index >= 0 && index < m_DataWrap.Count) {
                return (T)m_DataWrap[index];
            }
            return default(T);
        }
        public void SetData(int index, IDataBlock data)
        {
            if (index >= 0 && index < m_DataWrap.Count) {
                m_DataWrap[index] = data;
                DclApi.uint64_vector_set_element(m_DataBlockId, (ulong)index, data.GetDataBlockId());
            }
        }
        public int IndexOf(IDataBlock data)
        {
            return m_DataWrap.IndexOf(data);
        }
        public T GetLast<T>() where T : IDataBlock
        {
            return GetData<T>(GetCount() - 1);
        }
        public void AddLast(IDataBlock data)
        {
            m_DataWrap.Add(data);
            DclApi.uint64_vector_push_back(m_DataBlockId, data.GetDataBlockId());
        }
        public void RemoveLast()
        {
            if (m_DataWrap.Count > 0) {
                m_DataWrap.RemoveAt(m_DataWrap.Count - 1);
                DclApi.uint64_vector_pop_back(m_DataBlockId);
            }
        }
        public void Remove(IDataBlock data)
        {
            int index = IndexOf(data);
            RemoveAt(index);
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < m_DataWrap.Count) {
                m_DataWrap.RemoveAt(index);
                DclApi.uint64_vector_erase(m_DataBlockId, (ulong)index);
            }
        }
        public void Clear()
        {
            m_DataWrap.Clear();
            DclApi.container_clear(m_DataBlockId);
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
        private List<IDataBlock> m_DataWrap = new List<IDataBlock>();
    }

    public class Int64Int64Map : IDataBlock
    {
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_DataBlockId = DclApi.alloc_container((int)ContainerTypeEnum.Int64Int64Map);
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            DclApi.free_container(m_DataBlockId);
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            m_DataBlockId = 0;
            m_IsValid = false;
        }

        public int GetCount()
        {
            return (int)DclApi.container_get_size(m_DataBlockId);
        }
        public long GetData(long key)
        {
            return DclApi.int64_int64_map_get_element(m_DataBlockId, key);
        }
        public void SetData(long key, long val)
        {
            DclApi.int64_int64_map_set_element(m_DataBlockId, key, val);
        }
        public void Add(long key, long val)
        {
            DclApi.int64_int64_map_add_element(m_DataBlockId, key, val);
        }
        public void Remove(long key)
        {
            DclApi.int64_int64_map_remove_element(m_DataBlockId, key);
        }
        public bool Contains(long key)
        {
            return DclApi.int64_int64_map_contains(m_DataBlockId, key);
        }
        public void Clear()
        {
            DclApi.container_clear(m_DataBlockId);
        }
        public void Iterate(Func<long, long, bool> callback)
        {
            DclApi.iterate_int64_int64_map(m_DataBlockId, (k, v) => { return callback(k, v); });
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
    }
    public class Int64DoubleMap : IDataBlock
    {
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_DataBlockId = DclApi.alloc_container((int)ContainerTypeEnum.Int64DoubleMap);
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            DclApi.free_container(m_DataBlockId);
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            m_DataBlockId = 0;
            m_IsValid = false;
        }

        public int GetCount()
        {
            return (int)DclApi.container_get_size(m_DataBlockId);
        }
        public double GetData(long key)
        {
            return DclApi.int64_double_map_get_element(m_DataBlockId, key);
        }
        public void SetData(long key, double val)
        {
            DclApi.int64_double_map_set_element(m_DataBlockId, key, val);
        }
        public void Add(long key, double val)
        {
            DclApi.int64_double_map_add_element(m_DataBlockId, key, val);
        }
        public void Remove(long key)
        {
            DclApi.int64_double_map_remove_element(m_DataBlockId, key);
        }
        public bool Contains(long key)
        {
            return DclApi.int64_double_map_contains(m_DataBlockId, key);
        }
        public void Clear()
        {
            DclApi.container_clear(m_DataBlockId);
        }
        public void Iterate(Func<long, double, bool> callback)
        {
            DclApi.iterate_int64_double_map(m_DataBlockId, (k, v) => { return callback(k, v); });
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
    }
    public class Int64StringMap : IDataBlock
    {
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_DataBlockId = DclApi.alloc_container((int)ContainerTypeEnum.Int64UInt64Map);
            m_DataWrap.Clear();
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            Clear();
            DclApi.free_container(m_DataBlockId);
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            if (dataBlockId != 0) {
                DclApi.iterate_int64_uint64_map(dataBlockId, (k, v) => {
                    var elem = new CString();
                    elem.Attach(v);
                    m_DataWrap.Add(k, elem);
                    return true;
                });
            }
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            foreach (var pair in m_DataWrap) {
                var elem = pair.Value;
                if (null != elem)
                    elem.Detach();
            }
            m_DataWrap.Clear();
            m_DataBlockId = 0;
            m_IsValid = false;
        }

        public int GetCount()
        {
            return m_DataWrap.Count;
        }
        public CString GetData(long key)
        {
            CString ret;
            m_DataWrap.TryGetValue(key, out ret);
            return ret;
        }
        public void SetData(long key, CString val)
        {
            CString oldVal;
            if (m_DataWrap.TryGetValue(key, out oldVal)) {
                oldVal.Release();
            }
            m_DataWrap[key] = val;
            DclApi.int64_uint64_map_set_element(m_DataBlockId, key, null == val ? 0 : val.GetDataBlockId());
        }
        public void Add(long key, CString val)
        {
            m_DataWrap.Add(key, val);
            DclApi.int64_uint64_map_add_element(m_DataBlockId, key, null == val ? 0 : val.GetDataBlockId());
        }
        public void Remove(long key)
        {
            CString oldVal;
            if (m_DataWrap.TryGetValue(key, out oldVal)) {
                oldVal.Release();
            }
            m_DataWrap.Remove(key);
            DclApi.int64_uint64_map_remove_element(m_DataBlockId, key);
        }
        public bool Contains(long key)
        {
            return m_DataWrap.ContainsKey(key);
        }
        public void Clear()
        {
            foreach (var pair in m_DataWrap) {
                var elem = pair.Value;
                if (null != elem)
                    elem.Release();
            }
            m_DataWrap.Clear();
            DclApi.container_clear(m_DataBlockId);
        }
        public void Iterate(Func<long, CString, bool> callback)
        {
            foreach (var pair in m_DataWrap) {
                if (!callback(pair.Key, pair.Value))
                    break;
            }
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
        private Dictionary<long, CString> m_DataWrap = new Dictionary<long, CString>();
    }
    public class Int64DataBlockMap : IDataBlock
    {
        public NewDataBlockDelegation OnNewDataBlock;
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_DataBlockId = DclApi.alloc_container((int)ContainerTypeEnum.Int64UInt64Map);
            m_DataWrap.Clear();
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            Clear();
            DclApi.free_container(m_DataBlockId);
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            if (dataBlockId != 0) {
                DclApi.iterate_int64_uint64_map(dataBlockId, (k, v) => {
                    var elem = OnNewDataBlock();
                    elem.Attach(v);
                    m_DataWrap.Add(k, elem);
                    return true;
                });
            }
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            foreach (var pair in m_DataWrap) {
                var elem = pair.Value;
                if (null != elem)
                    elem.Detach();
            }
            m_DataWrap.Clear();
            m_DataBlockId = 0;
            m_IsValid = false;
        }

        public int GetCount()
        {
            return m_DataWrap.Count;
        }
        public T GetData<T>(long key) where T : IDataBlock
        {
            IDataBlock v;
            m_DataWrap.TryGetValue(key, out v);
            return (T)v;
        }
        public void SetData(long key, IDataBlock val)
        {
            m_DataWrap[key] = val;
            DclApi.int64_uint64_map_set_element(m_DataBlockId, key, val.GetDataBlockId());
        }
        public void Add(long key, IDataBlock val)
        {
            m_DataWrap.Add(key, val);
            DclApi.int64_uint64_map_add_element(m_DataBlockId, key, val.GetDataBlockId());
        }
        public void Remove(long key)
        {
            m_DataWrap.Remove(key);
            DclApi.int64_uint64_map_remove_element(m_DataBlockId, key);
        }
        public bool Contains(long key)
        {
            return m_DataWrap.ContainsKey(key);
        }
        public void Clear()
        {
            foreach (var pair in m_DataWrap) {
                var elem = pair.Value;
                if (null != elem)
                    elem.Release();
            }
            m_DataWrap.Clear();
            DclApi.container_clear(m_DataBlockId);
        }
        public void Iterate(Func<long, IDataBlock, bool> callback)
        {
            foreach (var pair in m_DataWrap) {
                if (!callback(pair.Key, pair.Value))
                    break;
            }
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
        private Dictionary<long, IDataBlock> m_DataWrap = new Dictionary<long, IDataBlock>();
    }

    public class StringInt64Map : IDataBlock
    {
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_DataBlockId = DclApi.alloc_container((int)ContainerTypeEnum.StrInt64Map);
            m_DataWrap.Clear();
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            Clear();
            DclApi.free_container(m_DataBlockId);
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            if (dataBlockId != 0) {
                DclApi.iterate_string_int64_map(dataBlockId, (k, v) => {
                    CString key = new CString();
                    key.Attach(k);
                    m_DataWrap.Add(k, key);
                    return true;
                });
            }
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            foreach (var pair in m_DataWrap) {
                var key = pair.Value;
                key.Detach();
            }
            m_DataWrap.Clear();
            m_DataBlockId = 0;
            m_IsValid = false;
        }

        public int GetCount()
        {
            return m_DataWrap.Count;
        }
        public long GetData(CString key)
        {
            return DclApi.string_int64_map_get_element(m_DataBlockId, null == key ? 0 : key.GetDataBlockId());
        }
        public void SetData(CString key, long val)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong oldKey = DclApi.string_int64_map_get_key(m_DataBlockId, key.GetDataBlockId());
                ulong mapKey = DclApi.string_int64_map_set_element(m_DataBlockId, key.GetDataBlockId(), val);
                if (oldKey != mapKey) {
                    CString oldKeyObj;
                    if (m_DataWrap.TryGetValue(oldKey, out oldKeyObj)) {
                        oldKeyObj.Release();
                    }
                }
                if (mapKey != key.GetDataBlockId()) {
                    CString newKey = new CString();
                    newKey.Attach(mapKey);
                    m_DataWrap[mapKey] = newKey;
                }
                else {
                    m_DataWrap[mapKey] = key;
                }
            }
        }
        public void Add(CString key, long val)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong mapKey = DclApi.string_int64_map_add_element(m_DataBlockId, key.GetDataBlockId(), val);
                CString newKey = new CString();
                newKey.Attach(mapKey);
                m_DataWrap.Add(mapKey, newKey);
            }
        }
        public void Remove(CString key)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong mapKey = DclApi.string_int64_map_get_key(m_DataBlockId, key.GetDataBlockId());
                CString keyObj;
                if (m_DataWrap.TryGetValue(mapKey, out keyObj)) {
                    keyObj.Release();
                }
                DclApi.string_int64_map_remove_element(m_DataBlockId, key.GetDataBlockId());
            }
        }
        public bool Contains(CString key)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                return DclApi.string_int64_map_contains(m_DataBlockId, key.GetDataBlockId());
            }
            return false;
        }
        public void Clear()
        {
            foreach (var pair in m_DataWrap) {
                var key = pair.Value;
                key.Release();
            }
            m_DataWrap.Clear();
            DclApi.container_clear(m_DataBlockId);
        }
        public void Iterate(Func<CString, long, bool> callback)
        {
            DclApi.iterate_string_int64_map(m_DataBlockId, (k, v) => {
                CString kObj;
                if (m_DataWrap.TryGetValue(k, out kObj))
                    return callback(kObj, v);
                else
                    return false;
            });
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
        private Dictionary<ulong, CString> m_DataWrap = new Dictionary<ulong, CString>();
    }
    public class StringDoubleMap : IDataBlock
    {
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_DataBlockId = DclApi.alloc_container((int)ContainerTypeEnum.StrDoubleMap);
            m_DataWrap.Clear();
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            Clear();
            DclApi.free_container(m_DataBlockId);
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            if (dataBlockId != 0) {
                DclApi.iterate_string_double_map(dataBlockId, (k, v) => {
                    CString key = new CString();
                    key.Attach(k);
                    m_DataWrap.Add(k, key);
                    return true;
                });
            }
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            foreach (var pair in m_DataWrap) {
                var key = pair.Value;
                key.Detach();
            }
            m_DataWrap.Clear();
            m_DataBlockId = 0;
            m_IsValid = false;
        }

        public int GetCount()
        {
            return m_DataWrap.Count;
        }
        public double GetData(CString key)
        {
            return DclApi.string_double_map_get_element(m_DataBlockId, null == key ? 0 : key.GetDataBlockId());
        }
        public void SetData(CString key, double val)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong oldKey = DclApi.string_double_map_get_key(m_DataBlockId, key.GetDataBlockId());
                ulong mapKey = DclApi.string_double_map_set_element(m_DataBlockId, key.GetDataBlockId(), val);
                if (oldKey != mapKey) {
                    CString oldKeyObj;
                    if (m_DataWrap.TryGetValue(oldKey, out oldKeyObj)) {
                        oldKeyObj.Release();
                    }
                }
                if (mapKey != key.GetDataBlockId()) {
                    CString newKey = new CString();
                    newKey.Attach(mapKey);
                    m_DataWrap[mapKey] = newKey;
                }
                else {
                    m_DataWrap[mapKey] = key;
                }
            }
        }
        public void Add(CString key, double val)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong mapKey = DclApi.string_double_map_add_element(m_DataBlockId, key.GetDataBlockId(), val);
                CString newKey = new CString();
                newKey.Attach(mapKey);
                m_DataWrap.Add(mapKey, newKey);
            }
        }
        public void Remove(CString key)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong mapKey = DclApi.string_double_map_get_key(m_DataBlockId, key.GetDataBlockId());
                CString keyObj;
                if (m_DataWrap.TryGetValue(mapKey, out keyObj)) {
                    keyObj.Release();
                }
                DclApi.string_double_map_remove_element(m_DataBlockId, key.GetDataBlockId());
            }
        }
        public bool Contains(CString key)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                return DclApi.string_double_map_contains(m_DataBlockId, key.GetDataBlockId());
            }
            return false;
        }
        public void Clear()
        {
            foreach (var pair in m_DataWrap) {
                var key = pair.Value;
                key.Release();
            }
            m_DataWrap.Clear();
            DclApi.container_clear(m_DataBlockId);
        }
        public void Iterate(Func<CString, double, bool> callback)
        {
            DclApi.iterate_string_double_map(m_DataBlockId, (k, v) => {
                CString kObj;
                if (m_DataWrap.TryGetValue(k, out kObj))
                    return callback(kObj, v);
                else
                    return false;
            });
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
        private Dictionary<ulong, CString> m_DataWrap = new Dictionary<ulong, CString>();
    }
    public class StringStringMap : IDataBlock
    {
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_DataBlockId = DclApi.alloc_container((int)ContainerTypeEnum.StrUInt64Map);
            m_DataWrap.Clear();
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            Clear();
            DclApi.free_container(m_DataBlockId);
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            if (dataBlockId != 0) {
                DclApi.iterate_string_uint64_map(dataBlockId, (k, v) => {
                    CString key = new CString();
                    key.Attach(k);
                    CString val = new CString();
                    val.Attach(v);
                    m_DataWrap.Add(k, new KeyValue { Key = key, Value = val });
                    return true;
                });
            }
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            foreach (var pair in m_DataWrap) {
                var kv = pair.Value;
                kv.Key.Detach();
                if (null != kv.Value) {
                    kv.Value.Detach();
                }
            }
            m_DataWrap.Clear();
            m_DataBlockId = 0;
            m_IsValid = false;
        }

        public int GetCount()
        {
            return m_DataWrap.Count;
        }
        public CString GetData(CString key)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong k = DclApi.string_uint64_map_get_key(m_DataBlockId, key.GetDataBlockId());
                KeyValue kv;
                if (m_DataWrap.TryGetValue(k, out kv)) {
                    return kv.Value;
                }
            }
            return null;
        }
        public void SetData(CString key, CString val)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong oldKey = DclApi.string_uint64_map_get_key(m_DataBlockId, key.GetDataBlockId());
                ulong mapKey = DclApi.string_uint64_map_set_element(m_DataBlockId, key.GetDataBlockId(), null == val ? 0 : val.GetDataBlockId());
                if (oldKey != mapKey) {
                    KeyValue kv;
                    if (m_DataWrap.TryGetValue(oldKey, out kv)) {
                        kv.Key.Release();
                        if (null != kv.Value) {
                            kv.Value.Release();
                        }
                    }
                }
                if (mapKey != key.GetDataBlockId()) {
                    KeyValue newKV = new KeyValue();
                    newKV.Key = new CString();
                    newKV.Key.Attach(mapKey);
                    newKV.Value = val;
                    m_DataWrap[mapKey] = newKV;
                }
                else {
                    m_DataWrap[mapKey] = new KeyValue { Key = key, Value = val };
                }
            }
        }
        public void Add(CString key, CString val)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong mapKey = DclApi.string_uint64_map_add_element(m_DataBlockId, key.GetDataBlockId(), null == val ? 0 : val.GetDataBlockId());
                KeyValue newKV = new KeyValue();
                newKV.Key = new CString();
                newKV.Key.Attach(mapKey);
                newKV.Value = val;
                m_DataWrap.Add(mapKey, newKV);
            }
        }
        public void Remove(CString key)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong mapKey = DclApi.string_uint64_map_get_key(m_DataBlockId, key.GetDataBlockId());
                KeyValue kv;
                if (m_DataWrap.TryGetValue(mapKey, out kv)) {
                    kv.Key.Release();
                    if (null != kv.Value) {
                        kv.Value.Release();
                    }
                }
                DclApi.string_uint64_map_remove_element(m_DataBlockId, key.GetDataBlockId());
            }
        }
        public bool Contains(CString key)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                return DclApi.string_int64_map_contains(m_DataBlockId, key.GetDataBlockId());
            }
            return false;
        }
        public void Clear()
        {
            foreach (var pair in m_DataWrap) {
                var kv = pair.Value;
                kv.Key.Release();
                if (null != kv.Value) {
                    kv.Value.Release();
                }
            }
            m_DataWrap.Clear();
            DclApi.container_clear(m_DataBlockId);
        }
        public void Iterate(Func<CString, CString, bool> callback)
        {
            foreach (var pair in m_DataWrap) {
                var kv = pair.Value;
                if (!callback(kv.Key, kv.Value))
                    break;
            }
        }

        private struct KeyValue
        {
            public CString Key;
            public CString Value;
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
        private Dictionary<ulong, KeyValue> m_DataWrap = new Dictionary<ulong, KeyValue>();
    }
    public class StringDataBlockMap : IDataBlock
    {
        public NewDataBlockDelegation OnNewDataBlock;
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_DataBlockId = DclApi.alloc_container((int)ContainerTypeEnum.StrUInt64Map);
            m_DataWrap.Clear();
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            Clear();
            DclApi.free_container(m_DataBlockId);
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            if (dataBlockId != 0) {
                DclApi.iterate_string_uint64_map(dataBlockId, (k, v) => {
                    CString key = new CString();
                    key.Attach(k);
                    IDataBlock val = OnNewDataBlock();
                    val.Attach(v);
                    m_DataWrap.Add(k, new KeyValue { Key = key, Value = val });
                    return true;
                });
            }
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            foreach (var pair in m_DataWrap) {
                var kv = pair.Value;
                kv.Key.Detach();
                if (null != kv.Value) {
                    kv.Value.Detach();
                }
            }
            m_DataWrap.Clear();
            m_DataBlockId = 0;
            m_IsValid = false;
        }

        public int GetCount()
        {
            return m_DataWrap.Count;
        }
        public T GetData<T>(CString key) where T : IDataBlock
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong k = DclApi.string_uint64_map_get_key(m_DataBlockId, key.GetDataBlockId());
                KeyValue kv;
                if (m_DataWrap.TryGetValue(k, out kv)) {
                    return (T)kv.Value;
                }
            }
            return default(T);
        }
        public void SetData(CString key, IDataBlock val)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong oldKey = DclApi.string_uint64_map_get_key(m_DataBlockId, key.GetDataBlockId());
                ulong mapKey = DclApi.string_uint64_map_set_element(m_DataBlockId, key.GetDataBlockId(), null == val ? 0 : val.GetDataBlockId());
                if (oldKey != mapKey) {
                    KeyValue kv;
                    if (m_DataWrap.TryGetValue(oldKey, out kv)) {
                        kv.Key.Release();
                        if (null != kv.Value) {
                            kv.Value.Release();
                        }
                    }
                }
                if (mapKey != key.GetDataBlockId()) {
                    KeyValue newKV = new KeyValue();
                    newKV.Key = new CString();
                    newKV.Key.Attach(mapKey);
                    newKV.Value = val;
                    m_DataWrap[mapKey] = newKV;
                }
                else {
                    m_DataWrap[mapKey] = new KeyValue { Key = key, Value = val };
                }
            }
        }
        public void Add(CString key, IDataBlock val)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong mapKey = DclApi.string_uint64_map_add_element(m_DataBlockId, key.GetDataBlockId(), null == val ? 0 : val.GetDataBlockId());
                KeyValue newKV = new KeyValue();
                newKV.Key = new CString();
                newKV.Key.Attach(mapKey);
                newKV.Value = val;
                m_DataWrap.Add(mapKey, newKV);
            }
        }
        public void Remove(CString key)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                ulong mapKey = DclApi.string_uint64_map_get_key(m_DataBlockId, key.GetDataBlockId());
                KeyValue kv;
                if (m_DataWrap.TryGetValue(mapKey, out kv)) {
                    kv.Key.Release();
                    if (null != kv.Value) {
                        kv.Value.Release();
                    }
                }
                DclApi.string_uint64_map_remove_element(m_DataBlockId, key.GetDataBlockId());
            }
        }
        public bool Contains(CString key)
        {
            if (null != key && key.GetDataBlockId() != 0) {
                return DclApi.string_int64_map_contains(m_DataBlockId, key.GetDataBlockId());
            }
            return false;
        }
        public void Clear()
        {
            foreach (var pair in m_DataWrap) {
                var kv = pair.Value;
                kv.Key.Release();
                if (null != kv.Value) {
                    kv.Value.Release();
                }
            }
            m_DataWrap.Clear();
            DclApi.container_clear(m_DataBlockId);
        }
        public void Iterate(Func<CString, IDataBlock, bool> callback)
        {
            foreach (var pair in m_DataWrap) {
                var kv = pair.Value;
                if (!callback(kv.Key, kv.Value))
                    break;
            }
        }

        private struct KeyValue
        {
            internal CString Key;
            internal IDataBlock Value;
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
        private Dictionary<ulong, KeyValue> m_DataWrap = new Dictionary<ulong, KeyValue>();
    }

    public class Int32ArrayField : BaseIntegerArray
    {
        public long GetData(int index)
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_element_int32(m_DataBlockId, (uint)index);
            }
            else {
                return 0;
            }
        }
    }
    public class Int64ArrayField : BaseIntegerArray
    {
        public long GetData(int index)
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_element_int64(m_DataBlockId, (uint)index);
            }
            else {
                return 0;
            }
        }
    }
    public class FloatArrayField : BaseIntegerArray
    {
        public float GetData(int index)
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_element_float(m_DataBlockId, (uint)index);
            }
            else {
                return 0;
            }
        }
    }
    public class StringArrayField : IDataBlock
    {
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            foreach (var str in m_DataWrap) {
                str.Release();
            }
            m_DataWrap.Clear();
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
                m_DataBlockId = 0;
            }
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            int len = DclApi.get_array_length(m_DataBlockId);
            for (uint ix = 0; ix < (uint)len; ++ix) {
                CString str = new CString();
                str.Attach(DclApi.get_array_element_uint64(m_DataBlockId, ix));
                m_DataWrap.Add(str);
            }
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            foreach (var str in m_DataWrap) {
                str.Detach();
            }
            m_DataWrap.Clear();
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public int GetLength()
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_length(m_DataBlockId);
            }
            else {
                return 0;
            }
        }
        public CString GetData(int index)
        {
            if (index >= 0 && index < m_DataWrap.Count) {
                return m_DataWrap[index];
            }
            else {
                return null;
            }
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
        private List<CString> m_DataWrap = new List<CString>();
    }

    public class JceStringArray : IDataBlock
    {
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            foreach (var str in m_DataWrap) {
                DclApi.free_string(str.GetDataBlockId());
            }
            m_DataWrap.Clear();
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
                m_DataBlockId = 0;
            }
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            if (dataBlockId != 0) {
                int len = DclApi.get_array_length(dataBlockId);
                m_DataWrap.Capacity = len;
                for (int ix = 0; ix < len; ++ix) {
                    ulong strId = DclApi.get_array_element_uint64(dataBlockId, (uint)ix);
                    var cstr = new CString();
                    cstr.Attach(strId);
                    m_DataWrap.Add(cstr);
                }
            }
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            foreach (var str in m_DataWrap) {
                str.Detach();
            }
            m_DataWrap.Clear();
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public int GetLength()
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_length(m_DataBlockId);
            }
            else {
                return 0;
            }
        }

        public void Reset(uint size)
        {
            if (m_DataBlockId != 0) {
                foreach (var str in m_DataWrap) {
                    DclApi.free_string(str.GetDataBlockId());
                }
                m_DataWrap.Clear();
                DclApi.free_array(m_DataBlockId);
            }
            m_DataBlockId = DclApi.alloc_array(sizeof(ulong), size, size);
            m_DataWrap.Capacity = (int)size;
            for (uint ix = 0; ix < size; ++ix) {
                var cstr = new CString();
                m_DataWrap.Add(cstr);
            }
        }
        public CString GetData(int index)
        {
            if (index >= 0 && index < m_DataWrap.Count) {
                return m_DataWrap[index];
            }
            else {
                return null;
            }
        }
        public void SetData(int index, CString val)
        {
            if (m_DataBlockId != 0) {
                if (index >= 0 && index < m_DataWrap.Count) {
                    m_DataWrap[index] = val;
                }
                DclApi.set_array_element_uint64(m_DataBlockId, (uint)index, val.GetDataBlockId());
            }
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
        private List<CString> m_DataWrap = new List<CString>();
    }
    public class JceStructArray : IDataBlock
    {
        public NewDataBlockDelegation OnNewDataBlock;
        public ulong GetDataBlockId()
        {
            return m_DataBlockId;
        }
        public void Init()
        {
            if (m_IsValid)
                return;
            m_IsValid = true;
        }
        public void Release()
        {
            if (!m_IsValid)
                return;
            foreach (var obj in m_DataWrap) {
                obj.Release();
            }
            m_DataWrap.Clear();
            if (m_DataBlockId != 0) {
                DclApi.free_array(m_DataBlockId);
                m_DataBlockId = 0;
            }
            m_IsValid = false;
        }
        public void Attach(ulong dataBlockId)
        {
            if (m_IsValid)
                return;
            m_DataBlockId = dataBlockId;
            if (dataBlockId != 0) {
                int len = DclApi.get_array_length(dataBlockId);
                m_DataWrap.Capacity = len;
                for (int ix = 0; ix < len; ++ix) {
                    ulong objId = DclApi.get_array_element_uint64(dataBlockId, (uint)ix);
                    var obj = OnNewDataBlock();
                    obj.Attach(objId);
                    m_DataWrap.Add(obj);
                }
            }
            m_IsValid = true;
        }
        public void Detach()
        {
            if (!m_IsValid)
                return;
            foreach (var obj in m_DataWrap) {
                obj.Detach();
            }
            m_DataWrap.Clear();
            m_DataBlockId = 0;
            m_IsValid = false;
        }
        public int GetLength()
        {
            if (m_DataBlockId != 0) {
                return DclApi.get_array_length(m_DataBlockId);
            }
            else {
                return 0;
            }
        }

        public void Reset(uint size)
        {
            if (m_DataBlockId != 0) {
                foreach (var obj in m_DataWrap) {
                    obj.Release();
                }
                m_DataWrap.Clear();
                DclApi.free_array(m_DataBlockId);
            }
            m_DataBlockId = DclApi.alloc_array(sizeof(ulong), size, size);
            m_DataWrap.Capacity = (int)size;
            for (uint ix = 0; ix < size; ++ix) {
                var obj = OnNewDataBlock();
                m_DataWrap.Add(obj);
            }
        }
        public T GetData<T>(int index) where T : IDataBlock
        {
            if (index >= 0 && index < m_DataWrap.Count) {
                return (T)m_DataWrap[index];
            }
            else {
                return default(T);
            }
        }
        public void SetData(int index, IDataBlock val)
        {
            if (m_DataBlockId != 0) {
                if (index >= 0 && index < m_DataWrap.Count) {
                    m_DataWrap[index] = val;
                }
                DclApi.set_array_element_uint64(m_DataBlockId, (uint)index, val.GetDataBlockId());
            }
        }

        private bool m_IsValid;
        private ulong m_DataBlockId;
        private List<IDataBlock> m_DataWrap = new List<IDataBlock>();
    }
    static class TestClass
    {
        public static void test(string? str)
        {
            Console.WriteLine("{0}", str?.Length);
        }
        public static void Call()
        {
            string? abc = null;
            abc = "test";
            test(abc);
        }
    }
}

