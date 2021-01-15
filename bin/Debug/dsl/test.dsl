require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("strlist");
require("vector3list");
require("datachangecallbackinfo");
require("cs2luaobjectpoolex_datachangecallbackinfo");

class(Test) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(Test, "g_Test", typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		ToList = deffunc(1)args(T, enumer){
			local(__method_ret_193_4_200_5);
			local(r); r = newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_T", typeargs(T), typekinds(TypeKind.TypeParameter), "ctor", literallist("g_System_Collections_Generic_List_T", typeargs(T), typekinds(TypeKind.TypeParameter)));
			foreach(__foreach_196_8_198_9, v, enumer, System.Collections.Generic.IEnumerable_T, System.Collections.Generic.IEnumerable_T, true){
				callexterninstance(r, System.Collections.Generic.List_T, "Add", v);
			};
			__method_ret_193_4_200_5 = r;
			return(__method_ret_193_4_200_5);
		}options[needfuncinfo(true), rettype(return, System.Collections.Generic.List_T, TypeKind.Class, 0), paramtype(T, null, TypeKind.TypeParameter, 0), paramtype(enumer, System.Collections.Generic.IEnumerable_T, TypeKind.Interface, 0)];
		cctor = deffunc(0)args(){
			callstatic(Test, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(Test.__cctor_called){
				return();
			}else{
				Test.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		get_Item = deffunc(1)args(this, ...){
			local(__method_ret_114_4_118_5);
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			__method_ret_114_4_118_5 = arraygetstruct(true, System.Nullable_T, SymbolKind.Parameter, args, 1);
			return(__method_ret_114_4_118_5);
		}options[needfuncinfo(true), rettype(return, System.Nullable_T, TypeKind.Struct, 0), paramtype(..., System.Nullable_T, TypeKind.Array, 0)];
		set_Item = deffunc(0)args(this, ...){
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			local(value); value = paramsremove(args);
			arraysetstruct(true, true, System.Nullable_T, SymbolKind.Parameter, args, 1, value);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0), paramtype(..., System.Nullable_T, TypeKind.Array, 0)];
		Init = deffunc(0)args(this){
			local(items); items = literalarray(System.String, TypeKind.Class, "ȫ��", "������", "�ɽ�ȡ", "�����", "δ��ȡ");
			callinstance(getinstance(SymbolKind.Field, this, Test, "m_DataChangeCallBackInfoPool"), Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "Init__Func_1_T__Action_1_T", null, null);
			local(strlist); strlist = newlist(StrList, "g_StrList", typeargs(), typekinds(), "ctor", literallist("g_StrList", typeargs(), typekinds()));
			callexterninstance(strlist, System.Collections.Generic.List_T, "Add", getexternstatic(SymbolKind.Field, System.String, "Empty"));
			callexterninstance(strlist, System.Collections.Generic.List_T, "Sort__Comparison_1_T", deffunc(1)args(a, b){ local(__lambda_125_21_125_45); __lambda_125_21_125_45 = invokeforbasicvalue(a, false, System.String, "CompareTo__String", b); return(__lambda_125_21_125_45); }options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0), paramtype(a, System.String, TypeKind.Class, 0), paramtype(b, System.String, TypeKind.Class, 0)]);
			local(intlist); intlist = newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_System_Int32", typeargs(System.Int32), typekinds(TypeKind.Struct), "ctor", literallist("g_System_Collections_Generic_List_System_Int32", typeargs(System.Int32), typekinds(TypeKind.Struct)));
			callexterninstance(intlist, System.Collections.Generic.List_T, "Add", 1);
			local(sa); sa = getexterninstanceindexer(StrList, strlist, System.Collections.Generic.List_T, "get_Item", 1, 0);
			callexterninstance(intlist, System.Collections.Generic.List_T, "Sort__Comparison_1_T", deffunc(1)args(a, b){ local(__lambda_129_21_129_45); __lambda_129_21_129_45 = invokeforbasicvalue(a, false, System.Int32, "CompareTo__Int32", b); return(__lambda_129_21_129_45); }options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0), paramtype(a, System.Int32, TypeKind.Struct, 0), paramtype(b, System.Int32, TypeKind.Struct, 0)]);
			local(iaa); iaa = condexp(execbinary("!=", null, strlist, System.Object, System.Object, TypeKind.Class, TypeKind.Class), false, function(){ funcobjret(getexterninstance(SymbolKind.Property, strlist, System.Collections.Generic.List_T, "Count")); }, false, function(){ funcobjret(getexterninstance(SymbolKind.Property, intlist, System.Collections.Generic.List_T, "Count")); });
			local(aa); aa = literalarray(System.Int32, TypeKind.Struct, 1, 2, 3, 4, 5);
			local(bb); bb = literalarray(System.Int32, TypeKind.Struct, literalarray(System.Int32, TypeKind.Struct, 1, 2), literalarray(System.Int32, TypeKind.Struct, 3, 4), literalarray(System.Int32, TypeKind.Struct, 5, 6));
			local(ia); ia = bb[1][2];
			foreachlist(__foreach_ix_134_8_136_9, __foreach_exp_134_8_136_9, s, strlist, StrList, System.Collections.Generic.List_T, true){
				callexternstatic(System.Console, "WriteLine__String", s);
			};
			foreacharray(__foreach_ix_137_8_139_9, __foreach_exp_137_8_139_9, v, aa, 1, true){
				callexternstatic(System.Console, "WriteLine__Int32", v);
			};
			foreacharray(__foreach_ix_140_8_142_9, __foreach_exp_140_8_142_9, v, bb, 2, true){
				callexternstatic(System.Console, "WriteLine__Int32", v);
			};
			local(act); act = typecast(( deffunc(0)args(){
				callexternstatic(System.Console, "Write__Int32", ia);
			}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0)] ), "System.Action", TypeKind.Delegate);
			local(cc); cc = callstatic(Test, "ToList", System.Int32, aa);
			local(v3list); v3list = newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_UnityEngine_Vector3", typeargs(UnityEngine.Vector3), typekinds(TypeKind.Struct), "ctor", literallist("g_System_Collections_Generic_List_UnityEngine_Vector3", typeargs(UnityEngine.Vector3), typekinds(TypeKind.Struct)));
			callexterninstance(v3list, System.Collections.Generic.List_T, "Add", wrapvaluearg(System.Collections.Generic.List_T, System.Collections.Generic.List_T, UnityEngine.Vector3, getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero")));
			local(nv3list); nv3list = newlist(Vector3List, "g_Vector3List", typeargs(), typekinds(), "ctor", literallist("g_Vector3List", typeargs(), typekinds()));
			callexterninstance(nv3list, System.Collections.Generic.List_T, "Add", wrapvaluearg(Vector3List, System.Collections.Generic.List_T, UnityEngine.Vector3, getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero")));
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0)];
		testcall = deffunc(1)args(this){
			local(__method_ret_150_4_155_5);
			arraysetstruct(true, true, UnityEngine.Vector3, SymbolKind.Field, getinstance(SymbolKind.Field, this, Test, "m_Vs"), 1, getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero"));
			local(v); v = arraygetstruct(true, UnityEngine.Vector3, SymbolKind.Field, getinstance(SymbolKind.Field, this, Test, "m_Vs"), 1);
			__method_ret_150_4_155_5 = 1;
			return(__method_ret_150_4_155_5);
		}options[needfuncinfo(true), rettype(return, System.Int32, TypeKind.Struct, 0)];
		test = deffunc(1)args(this){
			local(__method_ret_156_4_192_5);
			local(a); a = 2;
			local(b); b = 0;
			local(c); c = 1;
			local(aa); aa = deffunc(1)args(){
				local(__method_ret_159_31_172_9);
				local(__try_ret_160_12_165_13, __try_retval_160_12_165_13); multiassign(__try_ret_160_12_165_13, __try_retval_160_12_165_13) = dsltry(false, __try_ret_160_12_165_13){
					callexternstatic(System.Console, "Write__String", dslstrtocsstr("test"));
				};
				local(__catch_handled_160_12_165_13, __catch_retval_160_12_165_13); __catch_handled_160_12_165_13 = false;
				__catch_retval_160_12_165_13 = dslcatch(__catch_handled_160_12_165_13, __try_retval_160_12_165_13, __try_ret_160_12_165_13,
					function(ex){
						__catch_handled_160_12_165_13 = true;
					}
				);
				local(__try_ret_166_12_171_13, __try_retval_166_12_171_13); multiassign(__try_ret_166_12_171_13, __try_retval_166_12_171_13) = dsltry(false, __try_ret_166_12_171_13){
					block{
					__method_ret_159_31_172_9 = callinstance(this, Test, "testcall");
					__try_retval_166_12_171_13 = 1;
					break;
					};
				};
				if(__try_ret_166_12_171_13){
					if(__try_retval_166_12_171_13){
					if(__try_retval_166_12_171_13==1){
						return(__method_ret_159_31_172_9);
					};
					};
				};
				local(__catch_handled_166_12_171_13, __catch_retval_166_12_171_13); __catch_handled_166_12_171_13 = false;
				__catch_retval_166_12_171_13 = dslcatch(__catch_handled_166_12_171_13, __try_retval_166_12_171_13, __try_ret_166_12_171_13,
					function(ex){
						__catch_handled_166_12_171_13 = true;
						block{
						__method_ret_159_31_172_9 = 0;
						return(1);
						};
					}
				);
				if(__catch_retval_166_12_171_13){
				if(__catch_retval_166_12_171_13==1){
					return(__method_ret_159_31_172_9);
				};
				};
				return(null);
			}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0)];
			local(__try_ret_174_8_179_9, __try_retval_174_8_179_9); multiassign(__try_ret_174_8_179_9, __try_retval_174_8_179_9) = dsltryfunc(__try_retval_174_8_179_9, __try_func_174_8_179_9, this, 2){
				callexternstatic(System.Console, "Write__String", dslstrtocsstr("test"));
			}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0)];
			local(__catch_handled_174_8_179_9, __catch_retval_174_8_179_9); __catch_handled_174_8_179_9 = false;
			__catch_retval_174_8_179_9 = dslcatch(__catch_handled_174_8_179_9, __try_retval_174_8_179_9, __try_ret_174_8_179_9,
				function(ex){
					__catch_handled_174_8_179_9 = true;
				}
			);
			local(__try_ret_180_8_189_9, __try_retval_180_8_189_9); multiassign(__try_ret_180_8_189_9, __try_retval_180_8_189_9, __method_ret_156_4_192_5) = dsltryfunc(__try_retval_180_8_189_9, __try_func_180_8_189_9, this, 2, __method_ret_156_4_192_5, aa){
				block{
				__method_ret_156_4_192_5 = callexterndelegation(aa, "System.Func_TResult.Invoke");
				return(1, __method_ret_156_4_192_5);
				};
			}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0), rettype(__method_ret_156_4_192_5, System.Int32, TypeKind.Struct, 1), paramtype(__method_ret_156_4_192_5, System.Int32, TypeKind.Struct, 1), paramtype(aa, System.Func_TResult, Delegate, 0)];
			if(__try_ret_180_8_189_9){
				callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("{0} {1} {2}"), a, b, c);
				if(__try_retval_180_8_189_9){
				if(__try_retval_180_8_189_9==1){
					return(__method_ret_156_4_192_5);
				};
				};
			};
			local(__catch_handled_180_8_189_9, __catch_retval_180_8_189_9); __catch_handled_180_8_189_9 = false;
			__catch_retval_180_8_189_9 = dslcatch(__catch_handled_180_8_189_9, __try_retval_180_8_189_9, __try_ret_180_8_189_9,
				function(e){
					__catch_handled_180_8_189_9 = true;
					callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("ex:{0} {1} {2}"), a, b, c);
					block{
					__method_ret_156_4_192_5 = 0;
					return(1);
					};
				}
			);
			callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("{0} {1} {2}"), a, b, c);
			if(__catch_retval_180_8_189_9){
			if(__catch_retval_180_8_189_9==1){
				return(__method_ret_156_4_192_5);
			};
			};
			if(! __try_ret_180_8_189_9){
				callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("{0} {1} {2}"), a, b, c);
			};
			setinstance(SymbolKind.Field, this, Test, "m_IntVal", condexp(execbinary(">", a, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), false, function(){ funcobjret(callexterndelegation(aa, "System.Func_TResult.Invoke")); }, false, function(){ funcobjret(c); }));
			return(__method_ret_156_4_192_5);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0)];
		ctor = deffunc(0)args(this){
			callinstance(this, Test, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, Test, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, Test, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, Test, "m_DataChangeCallBackInfoPool", newobject(Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "g_Cs2LuaObjectPoolEx_DataChangeCallBackInfo", typeargs(DataChangeCallBackInfo), typekinds(TypeKind.Class), "ctor", null));
			setinstance(SymbolKind.Field, this, Test, "m_Vs", newmultiarray(UnityEngine.Vector3, TypeKind.Struct, defaultvalue(UnityEngine.Vector3, "UnityEngine.Vector3", true), 1, 10));
		}options[needfuncinfo(true)];
	};
	instance_fields {
		m_DataChangeCallBackInfoPool = null;
		m_IntVal = 0;
		m_Vs = null;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		get_Item(MethodKind.PropertyGet, Accessibility.Public){
		};
		set_Item(MethodKind.PropertySet, Accessibility.Public){
		};
		Init(MethodKind.Ordinary, Accessibility.Public){
		};
		testcall(MethodKind.Ordinary, Accessibility.Public){
		};
		test(MethodKind.Ordinary, Accessibility.Public){
		};
		ToList(MethodKind.Ordinary, Accessibility.Internal){
			static(true);
			generic(true);
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {
		m_DataChangeCallBackInfoPool(Accessibility.Private){
		};
		m_IntVal(Accessibility.Private){
		};
		m_Vs(Accessibility.Private){
		};
	};
};



