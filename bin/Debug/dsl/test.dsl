require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("teststruct");
require("siw_devicefirstuse");
require("datachangecallbackinfo");
require("cs2luaobjectpoolex_datachangecallbackinfo");
require("cs2luakeyvaluepair_system_int32_system_int32");

class(Test) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(Test, "g_Test", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		op_Implicit = deffunc(1)args(v){
			local(__method_ret_235_4_238_5);
			__method_ret_235_4_238_5 = newexternobject(System.Exception, "g_System_Exception", typeargs(), typekinds(), "ctor__String", 0, null, callbasicvalue(v, false, System.Int32, "ToString"));
			return(__method_ret_235_4_238_5);
			return(null);
		}options[needfuncinfo(false), rettype(return, System.Exception, TypeKind.Class, 0, true), paramtype(v, System.Int32, TypeKind.Struct, 0, true)];
		ToList = deffunc(1)args(T, enumer){
			local(__method_ret_303_4_311_5);
			callinstance(this, Test, "LoadStartupView_FGUI", "", "", "", 0, false);
			local(r); r = newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_T", typeargs(T), typekinds(TypeKind.TypeParameter), "ctor", 0, literallist("g_System_Collections_Generic_List_T", typeargs(T), typekinds(TypeKind.TypeParameter)));
			foreach(__foreach_307_8_309_9, v, enumer, System.Collections.Generic.IEnumerable_T, System.Collections.Generic.IEnumerable_T, true){
				callexterninstance(r, System.Collections.Generic.List_T, "Add", v);
			};
			__method_ret_303_4_311_5 = r;
			return(__method_ret_303_4_311_5);
		}options[needfuncinfo(true), rettype(return, System.Collections.Generic.List_T, TypeKind.Class, 0, true), paramtype(T, null, TypeKind.TypeParameter, 0, false), paramtype(enumer, System.Collections.Generic.IEnumerable_T, TypeKind.Interface, 0, true)];
		ToArray = deffunc(1)args(T, list){
			local(__method_ret_312_4_317_5);
			local(arr); arr = newmultiarray(T, TypeKind.TypeParameter, null, 1, getinterface(list, System.Collections.Generic.ICollection_T, "Count", "get_Count"));
			callinterface(list, System.Collections.Generic.ICollection_T, "CopyTo", arr, 0);
			__method_ret_312_4_317_5 = arr;
			return(__method_ret_312_4_317_5);
		}options[needfuncinfo(false), rettype(return, Test.T, TypeKind.Array, 0, true), paramtype(T, null, TypeKind.TypeParameter, 0, false), paramtype(list, System.Collections.Generic.IList_T, TypeKind.Interface, 0, true)];
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
			local(__method_ret_239_4_243_5);
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			__method_ret_239_4_243_5 = arraygetstruct(false, SymbolKind.Parameter, System.Nullable_T, args, 1, 1);
			return(__method_ret_239_4_243_5);
		}options[needfuncinfo(true), rettype(return, System.Nullable_T, TypeKind.Struct, 0, true), paramtype(..., System.Nullable_T, TypeKind.Array, 0, true)];
		set_Item = deffunc(0)args(this, ...){
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			local(value); value = paramsremove(args);
			arraysetstruct(false, SymbolKind.Parameter, System.Nullable_T, args, 2, 1, wrapstruct(value, System.Nullable_T)
);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(..., System.Nullable_T, TypeKind.Array, 0, true)];
		Init = deffunc(0)args(this){
			local(a); a = 2;
			local(intlist); intlist = newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_System_Int32", typeargs(System.Int32), typekinds(TypeKind.Struct), "ctor", 0, literallist("g_System_Collections_Generic_List_System_Int32", typeargs(System.Int32), typekinds(TypeKind.Struct)));
			callexterninstance(intlist, System.Collections.Generic.List_T, "Add", 1);
			local(ts); ts = newstruct(TestStruct, "g_TestStruct", typeargs(), typekinds(), "ctor", 0, null);
			callexterninstance(intlist, System.Collections.Generic.List_T, "Add", wrapstructargument(invokeoperator(System.Int32, TestStruct, "op_Implicit", wrapstructargument(ts, TestStruct, OperationKind.LocalReference, SymbolKind.Local, TestStruct, TestStruct)), TestStruct, OperationKind.LocalReference, SymbolKind.Local, System.Collections.Generic.List_T, System.Collections.Generic.List_T));
			local(rs); rs = linq()from(function(){ funcobjret(a); })where(function(score){ funcobjret(execbinary(">", score, 80, , System.Int32, TypeKind.Error, TypeKind.Struct)); })select(function(score){ funcobjret(score); })end();
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		testcall = deffunc(1)args(this){
			local(__method_ret_255_4_258_5);
			__method_ret_255_4_258_5 = 1;
			return(__method_ret_255_4_258_5);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		test = deffunc(1)args(this){
			local(__method_ret_259_4_297_5);
			local(a); a = 2;
			local(b); b = 0;
			local(c); c = 1;
			local(aa); aa = deffunc(1)args(){
				local(__method_ret_262_31_275_9);
				local(__try_ret_263_12_268_13, __try_retval_263_12_268_13); multiassign(__try_ret_263_12_268_13, __try_retval_263_12_268_13) = dsltry(false, __try_ret_263_12_268_13){
					callexternstatic(System.Console, "Write__String", dslstrtocsstr("test"));
				};
				local(__catch_handled_263_12_268_13, __catch_retval_263_12_268_13); __catch_handled_263_12_268_13 = false;
				__catch_retval_263_12_268_13 = dslcatch(__catch_handled_263_12_268_13, __try_retval_263_12_268_13, __try_ret_263_12_268_13,
					function(ex){
						__catch_handled_263_12_268_13 = true;
					}
				);
				local(__try_ret_269_12_274_13, __try_retval_269_12_274_13); multiassign(__try_ret_269_12_274_13, __try_retval_269_12_274_13) = dsltry(false, __try_ret_269_12_274_13){
					block{
					__method_ret_262_31_275_9 = lualib_call(2, [null], this, Test, "testcall");
					__try_retval_269_12_274_13 = 1;
					break;
					};
				};
				if(__try_ret_269_12_274_13){
					if(__try_retval_269_12_274_13){
					if(__try_retval_269_12_274_13==1){
						return(__method_ret_262_31_275_9);
					};
					};
				};
				local(__catch_handled_269_12_274_13, __catch_retval_269_12_274_13); __catch_handled_269_12_274_13 = false;
				__catch_retval_269_12_274_13 = dslcatch(__catch_handled_269_12_274_13, __try_retval_269_12_274_13, __try_ret_269_12_274_13,
					function(ex){
						__catch_handled_269_12_274_13 = true;
						block{
						__method_ret_262_31_275_9 = 0;
						return(1);
						};
					}
				);
				if(__catch_retval_269_12_274_13){
				if(__catch_retval_269_12_274_13==1){
					return(__method_ret_262_31_275_9);
				};
				};
				return(null);
			}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
			local(__try_ret_277_8_282_9, __try_retval_277_8_282_9); multiassign(__try_ret_277_8_282_9, __try_retval_277_8_282_9) = dsltryfunc(__try_retval_277_8_282_9, __try_func_277_8_282_9, Test, false, 2){
				callexternstatic(System.Console, "Write__String", dslstrtocsstr("test"));
			}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
			local(__catch_handled_277_8_282_9, __catch_retval_277_8_282_9); __catch_handled_277_8_282_9 = false;
			__catch_retval_277_8_282_9 = dslcatch(__catch_handled_277_8_282_9, __try_retval_277_8_282_9, __try_ret_277_8_282_9,
				function(ex){
					__catch_handled_277_8_282_9 = true;
				}
			);
			local(intlist); intlist = newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_System_Int32", typeargs(System.Int32), typekinds(TypeKind.Struct), "ctor", 0, literallist("g_System_Collections_Generic_List_System_Int32", typeargs(System.Int32), typekinds(TypeKind.Struct)));
			local(__try_ret_284_8_294_9, __try_retval_284_8_294_9); multiassign(__try_ret_284_8_294_9, __try_retval_284_8_294_9, __method_ret_259_4_297_5) = dsltryfunc(__try_retval_284_8_294_9, __try_func_284_8_294_9, Test, false, 2, __method_ret_259_4_297_5, aa){
				block{
				__method_ret_259_4_297_5 = callexterndelegation(aa, "System.Func_TResult.Invoke");
				return(1, __method_ret_259_4_297_5);
				};
			}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true), rettype(__method_ret_259_4_297_5, System.Int32, TypeKind.Struct, 1, true), paramtype(__method_ret_259_4_297_5, System.Int32, TypeKind.Struct, 1, true), paramtype(aa, System.Func_TResult, Delegate, 0, true)];
			if(__try_ret_284_8_294_9){
				callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("{0} {1} {2}"), a, b, c);
				if(__try_retval_284_8_294_9){
				if(__try_retval_284_8_294_9==1){
					return(__method_ret_259_4_297_5);
				};
				};
			};
			local(__catch_handled_284_8_294_9, __catch_retval_284_8_294_9); __catch_handled_284_8_294_9 = false;
			__catch_retval_284_8_294_9 = dslcatch(__catch_handled_284_8_294_9, __try_retval_284_8_294_9, __try_ret_284_8_294_9,
				function(e){
if(typeis(e, System.ArgumentException, TypeKind.Class)){
						__catch_handled_284_8_294_9 = true;
						callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("ex:{0} {1} {2}"), a, b, c);
						dslthrow(a);
						block{
						__method_ret_259_4_297_5 = 0;
						return(1);
						};
					};
				}
			);
			callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("{0} {1} {2}"), a, b, c);
			if(__catch_retval_284_8_294_9){
			if(__catch_retval_284_8_294_9==1){
				return(__method_ret_259_4_297_5);
			};
			};
			if(! __try_ret_284_8_294_9){
				callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("{0} {1} {2}"), a, b, c);
			};
			setinstance(SymbolKind.Field, this, Test, "m_IntVal", condexp(execbinary(">", a, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), false, function(){ funcobjret(callexterndelegation(aa, "System.Func_TResult.Invoke")); }, false, function(){ funcobjret(c); }));
			return(__method_ret_259_4_297_5);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		LoadStartupView_FGUI = deffunc(0)args(this, className, comName, packageName, grp, ForceShow){
			local(dfu); dfu = newobject(SIW_DeviceFirstUse, "g_SIW_DeviceFirstUse", typeargs(), typekinds(), "ctor", 0, null);
			callinstance(dfu, SIW_DeviceFirstUse, "OnSet", 0);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(className, System.String, TypeKind.Class, 0, true), paramtype(comName, System.String, TypeKind.Class, 0, true), paramtype(packageName, System.String, TypeKind.Class, 0, true), paramtype(grp, ViewGroup, TypeKind.Enum, 0, false), paramtype(ForceShow, System.Boolean, TypeKind.Struct, 0, true)];
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
			setinstance(SymbolKind.Field, this, Test, "m_IntIntKeyValue", newobject(Cs2LuaKeyValuePair_System_Int32_System_Int32, "g_Cs2LuaKeyValuePair_System_Int32_System_Int32", typeargs(System.Int32, System.Int32), typekinds(TypeKind.Struct, TypeKind.Struct), "ctor", 0, null));
		}options[needfuncinfo(true)];
	};
	instance_fields {
		m_DataChangeCallBackInfoPool = null;
		m_IntVal = 0;
		m_Vs = null;
		m_IntIntKeyValue = null;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		op_Implicit(MethodKind.Conversion, Accessibility.Public){
			static(true);
		};
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
		m_IntIntKeyValue(Accessibility.Private){
		};
	};
};



