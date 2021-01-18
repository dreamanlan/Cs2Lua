require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("datachangecallbackinfo");
require("strlist");
require("vector3list");
require("cs2luaobjectpoolex_datachangecallbackinfo");

class(Test) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(Test, "g_Test", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		LoadStartupView_FGUI = deffunc(0)args(className, comName, packageName, grp, ForceShow){
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0), paramtype(className, System.String, TypeKind.Class, 0), paramtype(comName, System.String, TypeKind.Class, 0), paramtype(packageName, System.String, TypeKind.Class, 0), paramtype(grp, ViewGroup, TypeKind.Enum, 0), paramtype(ForceShow, System.Boolean, TypeKind.Struct, 0)];
		ToList = deffunc(1)args(T, enumer){
			local(__method_ret_213_4_221_5);
			callstatic(Test, "LoadStartupView_FGUI", "", "", "", 0, false);
			local(r); r = newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_T", typeargs(T), typekinds(TypeKind.TypeParameter), "ctor", 0, literallist("g_System_Collections_Generic_List_T", typeargs(T), typekinds(TypeKind.TypeParameter)));
			foreach(__foreach_217_8_219_9, v, enumer, System.Collections.Generic.IEnumerable_T, System.Collections.Generic.IEnumerable_T, true){
				callexterninstance(r, System.Collections.Generic.List_T, "Add", v);
			};
			__method_ret_213_4_221_5 = r;
			return(__method_ret_213_4_221_5);
		}options[needfuncinfo(true), rettype(return, System.Collections.Generic.List_T, TypeKind.Class, 0), paramtype(T, null, TypeKind.TypeParameter, 0), paramtype(enumer, System.Collections.Generic.IEnumerable_T, TypeKind.Interface, 0)];
		ToArray = deffunc(1)args(T, list){
			local(__method_ret_222_4_227_5);
			local(arr); arr = newmultiarray(Test.T, TypeKind.TypeParameter, null, 1, getexterninstance(SymbolKind.Property, list, System.Collections.Generic.ICollection_T, "Count"));
			callexterninstance(list, System.Collections.Generic.ICollection_T, "CopyTo", arr, 0);
			__method_ret_222_4_227_5 = arr;
			return(__method_ret_222_4_227_5);
		}options[needfuncinfo(false), rettype(return, Test.T, TypeKind.Array, 0), paramtype(T, null, TypeKind.TypeParameter, 0), paramtype(list, System.Collections.Generic.IList_T, TypeKind.Interface, 0)];
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
			local(__method_ret_127_4_131_5);
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			__method_ret_127_4_131_5 = arraygetstruct(false, SymbolKind.Parameter, System.Nullable_T, args, 1);
			return(__method_ret_127_4_131_5);
		}options[needfuncinfo(true), rettype(return, System.Nullable_T, TypeKind.Struct, 0), paramtype(..., System.Nullable_T, TypeKind.Array, 0)];
		set_Item = deffunc(0)args(this, ...){
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			local(value); value = paramsremove(args);
			arraysetstruct(false, SymbolKind.Parameter, System.Nullable_T, args, true, 1, value);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0), paramtype(..., System.Nullable_T, TypeKind.Array, 0)];
		Init = deffunc(0)args(this){
			local(items); items = literalarray(System.String, TypeKind.Class, "ȫ��", "������", "�ɽ�ȡ", "�����", "δ��ȡ");
			TestLuaLib(4, [Cs2LuaObjectPoolEx_DataChangeCallBackInfo, DataChangeCallBackInfo, TypeKind.Class, null, null], [null, null, null, null, System.Int32, TypeKind.Struct, OperationKind.Literal, null], [DataChangeCallBackInfo, TypeKind.Class, null, null, System.Func_TResult, TypeKind.Delegate, OperationKind.AnonymousFunction, SymbolKind.Method], [DataChangeCallBackInfo, TypeKind.Class, null, null, System.Action_T, TypeKind.Delegate, OperationKind.AnonymousFunction, SymbolKind.Method], getinstance(SymbolKind.Field, this, Test, "m_DataChangeCallBackInfoPool"), Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "Init__Int32__Func_1_T__Action_1_T", 32, deffunc(1)args(){
				local(__method_ret_135_46_135_92);
				__method_ret_135_46_135_92 = newobject(DataChangeCallBackInfo, "g_DataChangeCallBackInfo", typeargs(), typekinds(), "ctor", 0, null);
				return(__method_ret_135_46_135_92);
			}options[needfuncinfo(false), rettype(return, DataChangeCallBackInfo, TypeKind.Class, 0)], deffunc(0)args(v) {
			}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0), paramtype(v, DataChangeCallBackInfo, TypeKind.Class, 0)]);
			local(strlist); strlist = newlist(StrList, "g_StrList", typeargs(), typekinds(), "ctor", 0, literallist("g_StrList", typeargs(), typekinds()));
			callexterninstance(strlist, System.Collections.Generic.List_T, "Add", getexternstatic(SymbolKind.Field, System.String, "Empty"));
			callexterninstance(strlist, System.Collections.Generic.List_T, "Sort__Comparison_1_T", deffunc(1)args(a, b){ local(__lambda_138_21_138_45); __lambda_138_21_138_45 = invokeforbasicvalue(a, false, System.String, "CompareTo__String", b); return(__lambda_138_21_138_45); }options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0), paramtype(a, System.String, TypeKind.Class, 0), paramtype(b, System.String, TypeKind.Class, 0)]);
			local(intlist); intlist = newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_System_Int32", typeargs(System.Int32), typekinds(TypeKind.Struct), "ctor", 0, literallist("g_System_Collections_Generic_List_System_Int32", typeargs(System.Int32), typekinds(TypeKind.Struct)));
			callexterninstance(intlist, System.Collections.Generic.List_T, "Add", 1);
			local(sa); sa = getexterninstanceindexer(StrList, strlist, System.Collections.Generic.List_T, "get_Item", 1, 0);
			callexterninstance(intlist, System.Collections.Generic.List_T, "Sort__Comparison_1_T", deffunc(1)args(a, b){ local(__lambda_142_21_142_45); __lambda_142_21_142_45 = invokeforbasicvalue(a, false, System.Int32, "CompareTo__Int32", b); return(__lambda_142_21_142_45); }options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0), paramtype(a, System.Int32, TypeKind.Struct, 0), paramtype(b, System.Int32, TypeKind.Struct, 0)]);
			local(iaa); iaa = condexp(execbinary("!=", null, strlist, System.Object, System.Object, TypeKind.Class, TypeKind.Class), false, function(){ funcobjret(getexterninstance(SymbolKind.Property, strlist, System.Collections.Generic.List_T, "Count")); }, false, function(){ funcobjret(getexterninstance(SymbolKind.Property, intlist, System.Collections.Generic.List_T, "Count")); });
			local(aa); aa = literalarray(System.Int32, TypeKind.Struct, 1, 2, 3, 4, 5);
			local(bb); bb = literalarray(System.Int32, TypeKind.Struct, literalarray(System.Int32, TypeKind.Struct, 1, 2), literalarray(System.Int32, TypeKind.Struct, 3, 4), literalarray(System.Int32, TypeKind.Struct, 5, 6));
			local(ia); ia = bb[1][2];
			foreachlist(__foreach_ix_147_8_149_9, __foreach_exp_147_8_149_9, s, strlist, StrList, System.Collections.Generic.List_T, true){
				callexternstatic(System.Console, "WriteLine__String", s);
			};
			foreacharray(__foreach_ix_150_8_152_9, __foreach_exp_150_8_152_9, v, aa, 1, true){
				callexternstatic(System.Console, "WriteLine__Int32", v);
			};
			foreacharray(__foreach_ix_153_8_155_9, __foreach_exp_153_8_155_9, v, bb, 2, true){
				callexternstatic(System.Console, "WriteLine__Int32", v);
			};
			local(act); act = typecast(( deffunc(0)args(){
				callexternstatic(System.Console, "Write__Int32", ia);
			}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0)] ), "System.Action", TypeKind.Delegate);
			local(cc); cc = callstatic(Test, "ToList", System.Int32, aa);
			local(v3list); v3list = newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_UnityEngine_Vector3", typeargs(UnityEngine.Vector3), typekinds(TypeKind.Struct), "ctor", 0, literallist("g_System_Collections_Generic_List_UnityEngine_Vector3", typeargs(UnityEngine.Vector3), typekinds(TypeKind.Struct)));
			callexternstructlistinstance(2, [System.Collections.Generic.List_T, UnityEngine.Vector3, TypeKind.Struct, null, null], [null, null, null, null, UnityEngine.Vector3, TypeKind.Struct, OperationKind.PropertyReference, SymbolKind.Property], v3list, System.Collections.Generic.List_T, "Add", getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero"));
			local(nv3list); nv3list = newlist(Vector3List, "g_Vector3List", typeargs(), typekinds(), "ctor", 0, literallist("g_Vector3List", typeargs(), typekinds()));
			callexterninstance(nv3list, System.Collections.Generic.List_T, "Add", getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero"));
			local(v3); v3 = getinstanceindexerstruct(true, Vector3List, nv3list, System.Collections.Generic.List_T, "get_Item", 1, 0);
			v3 = wrapexternstruct(v3, UnityEngine.Vector3);
			setinstanceindexerstruct(true, Vector3List, nv3list, System.Collections.Generic.List_T, "set_Item", 2, true, 0, v3);
			local(vv3); vv3 = arraygetstruct(false, SymbolKind.Method, UnityEngine.Vector3, callstatic(Test, "ToArray", UnityEngine.Vector3, nv3list), 1);
			vv3 = wrapexternstruct(vv3, UnityEngine.Vector3);
			arraysetstruct(false, SymbolKind.Method, UnityEngine.Vector3, callstatic(Test, "ToArray", UnityEngine.Vector3, nv3list), true, 1, wrapstruct(vv3, UnityEngine.Vector3)
);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0)];
		testcall = deffunc(1)args(this){
			local(__method_ret_167_4_172_5);
			arraysetstruct(false, SymbolKind.Field, UnityEngine.Vector3, getinstance(SymbolKind.Field, this, Test, "m_Vs"), true, 1, getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero"));
			local(v); v = arraygetstruct(false, SymbolKind.Field, UnityEngine.Vector3, getinstance(SymbolKind.Field, this, Test, "m_Vs"), 1);
			v = wrapexternstruct(v, UnityEngine.Vector3);
			__method_ret_167_4_172_5 = 1;
			return(__method_ret_167_4_172_5);
		}options[needfuncinfo(true), rettype(return, System.Int32, TypeKind.Struct, 0)];
		test = deffunc(1)args(this){
			local(__method_ret_173_4_209_5);
			local(a); a = 2;
			local(b); b = 0;
			local(c); c = 1;
			local(aa); aa = deffunc(1)args(){
				local(__method_ret_176_31_189_9);
				local(__try_ret_177_12_182_13, __try_retval_177_12_182_13); multiassign(__try_ret_177_12_182_13, __try_retval_177_12_182_13) = dsltry(false, __try_ret_177_12_182_13){
					callexternstatic(System.Console, "Write__String", dslstrtocsstr("test"));
				};
				local(__catch_handled_177_12_182_13, __catch_retval_177_12_182_13); __catch_handled_177_12_182_13 = false;
				__catch_retval_177_12_182_13 = dslcatch(__catch_handled_177_12_182_13, __try_retval_177_12_182_13, __try_ret_177_12_182_13,
					function(ex){
						__catch_handled_177_12_182_13 = true;
					}
				);
				local(__try_ret_183_12_188_13, __try_retval_183_12_188_13); multiassign(__try_ret_183_12_188_13, __try_retval_183_12_188_13) = dsltry(false, __try_ret_183_12_188_13){
					block{
					__method_ret_176_31_189_9 = callinstance(this, Test, "testcall");
					__try_retval_183_12_188_13 = 1;
					break;
					};
				};
				if(__try_ret_183_12_188_13){
					if(__try_retval_183_12_188_13){
					if(__try_retval_183_12_188_13==1){
						return(__method_ret_176_31_189_9);
					};
					};
				};
				local(__catch_handled_183_12_188_13, __catch_retval_183_12_188_13); __catch_handled_183_12_188_13 = false;
				__catch_retval_183_12_188_13 = dslcatch(__catch_handled_183_12_188_13, __try_retval_183_12_188_13, __try_ret_183_12_188_13,
					function(ex){
						__catch_handled_183_12_188_13 = true;
						block{
						__method_ret_176_31_189_9 = 0;
						return(1);
						};
					}
				);
				if(__catch_retval_183_12_188_13){
				if(__catch_retval_183_12_188_13==1){
					return(__method_ret_176_31_189_9);
				};
				};
				return(null);
			}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0)];
			local(__try_ret_191_8_196_9, __try_retval_191_8_196_9); multiassign(__try_ret_191_8_196_9, __try_retval_191_8_196_9) = dsltryfunc(__try_retval_191_8_196_9, __try_func_191_8_196_9, this, 2){
				callexternstatic(System.Console, "Write__String", dslstrtocsstr("test"));
			}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0)];
			local(__catch_handled_191_8_196_9, __catch_retval_191_8_196_9); __catch_handled_191_8_196_9 = false;
			__catch_retval_191_8_196_9 = dslcatch(__catch_handled_191_8_196_9, __try_retval_191_8_196_9, __try_ret_191_8_196_9,
				function(ex){
					__catch_handled_191_8_196_9 = true;
				}
			);
			local(__try_ret_197_8_206_9, __try_retval_197_8_206_9); multiassign(__try_ret_197_8_206_9, __try_retval_197_8_206_9, __method_ret_173_4_209_5) = dsltryfunc(__try_retval_197_8_206_9, __try_func_197_8_206_9, this, 2, __method_ret_173_4_209_5, aa){
				block{
				__method_ret_173_4_209_5 = callexterndelegation(aa, "System.Func_TResult.Invoke");
				return(1, __method_ret_173_4_209_5);
				};
			}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0), rettype(__method_ret_173_4_209_5, System.Int32, TypeKind.Struct, 1), paramtype(__method_ret_173_4_209_5, System.Int32, TypeKind.Struct, 1), paramtype(aa, System.Func_TResult, Delegate, 0)];
			if(__try_ret_197_8_206_9){
				callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("{0} {1} {2}"), a, b, c);
				if(__try_retval_197_8_206_9){
				if(__try_retval_197_8_206_9==1){
					return(__method_ret_173_4_209_5);
				};
				};
			};
			local(__catch_handled_197_8_206_9, __catch_retval_197_8_206_9); __catch_handled_197_8_206_9 = false;
			__catch_retval_197_8_206_9 = dslcatch(__catch_handled_197_8_206_9, __try_retval_197_8_206_9, __try_ret_197_8_206_9,
				function(e){
					__catch_handled_197_8_206_9 = true;
					callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("ex:{0} {1} {2}"), a, b, c);
					block{
					__method_ret_173_4_209_5 = 0;
					return(1);
					};
				}
			);
			callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("{0} {1} {2}"), a, b, c);
			if(__catch_retval_197_8_206_9){
			if(__catch_retval_197_8_206_9==1){
				return(__method_ret_173_4_209_5);
			};
			};
			if(! __try_ret_197_8_206_9){
				callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("{0} {1} {2}"), a, b, c);
			};
			setinstance(SymbolKind.Field, this, Test, "m_IntVal", condexp(execbinary(">", a, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), false, function(){ funcobjret(callexterndelegation(aa, "System.Func_TResult.Invoke")); }, false, function(){ funcobjret(c); }));
			return(__method_ret_173_4_209_5);
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
			setinstance(SymbolKind.Field, this, Test, "m_DataChangeCallBackInfoPool", newobject(Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "g_Cs2LuaObjectPoolEx_DataChangeCallBackInfo", typeargs(DataChangeCallBackInfo), typekinds(TypeKind.Class), "ctor", 0, null));
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
		LoadStartupView_FGUI(MethodKind.Ordinary, Accessibility.Internal){
			static(true);
		};
		ToList(MethodKind.Ordinary, Accessibility.Internal){
			static(true);
			generic(true);
		};
		ToArray(MethodKind.Ordinary, Accessibility.Internal){
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



