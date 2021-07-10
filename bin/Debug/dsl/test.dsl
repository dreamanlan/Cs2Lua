require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("teststruct");
require("strstrdict");
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
			local(__method_ret_239_4_242_5);
			__method_ret_239_4_242_5 = newexternobject(System.Exception, "g_System_Exception", typeargs(), typekinds(), "ctor__String", 0, null, callbasicvalue(v, false, System.Int32, "ToString"));
			return(__method_ret_239_4_242_5);
			return(null);
		}options[needfuncinfo(false), rettype(return, System.Exception, TypeKind.Class, 0, true), paramtype(v, System.Int32, TypeKind.Struct, 0, true)];
		ToList = deffunc(1)args(T, enumer){
			local(__method_ret_360_4_368_5);
			callinstance(this, Test, "LoadStartupView_FGUI", "", "", "", 0, false);
			local(r); r = newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_T", typeargs(T), typekinds(TypeKind.TypeParameter), "ctor", 0, literallist("g_System_Collections_Generic_List_T", typeargs(T), typekinds(TypeKind.TypeParameter)));
			foreach(__foreach_364_8_366_9, v, enumer, System.Collections.Generic.IEnumerable_T, System.Collections.Generic.IEnumerable_T, true){
				callexterninstance(r, System.Collections.Generic.List_T, "Add", v);
			};
			__method_ret_360_4_368_5 = r;
			return(__method_ret_360_4_368_5);
		}options[needfuncinfo(true), rettype(return, System.Collections.Generic.List_T, TypeKind.Class, 0, true), paramtype(T, null, TypeKind.TypeParameter, 0, false), paramtype(enumer, System.Collections.Generic.IEnumerable_T, TypeKind.Interface, 0, true)];
		ToArray = deffunc(1)args(T, list){
			local(__method_ret_369_4_374_5);
			local(arr); arr = newmultiarray(T, TypeKind.TypeParameter, null, 1, getinterface(list, System.Collections.Generic.ICollection_T, "Count", "get_Count"));
			callinterface(list, System.Collections.Generic.ICollection_T, "CopyTo", arr, 0);
			__method_ret_369_4_374_5 = arr;
			return(__method_ret_369_4_374_5);
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
			local(__method_ret_243_4_247_5);
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			__method_ret_243_4_247_5 = arraygetstruct(false, SymbolKind.Parameter, System.Nullable_T, args, 1, 1);
			return(__method_ret_243_4_247_5);
		}options[needfuncinfo(true), rettype(return, System.Nullable_T, TypeKind.Struct, 0, true), paramtype(..., System.Nullable_T, TypeKind.Array, 0, true)];
		set_Item = deffunc(0)args(this, ...){
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			local(args); args = params(System.Nullable_T, TypeKind.Struct);
			local(value); value = paramsremove(args);
			arraysetstruct(false, SymbolKind.Parameter, System.Nullable_T, args, 2, 1, wrapstruct(value, System.Nullable_T));
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(..., System.Nullable_T, TypeKind.Array, 0, true)];
		TestOneV3 = deffunc(1)args(this, v1){
			v1 = wrapoutexternstruct(v1, UnityEngine.Vector3);
			v1 = getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero");
			return(v1);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), rettype(v1, UnityEngine.Vector3, TypeKind.Struct, 2, true), paramtype(v1, UnityEngine.Vector3, TypeKind.Struct, 2, true)];
		TestTwoV3 = deffunc(2)args(this, v1, v2){
			v1 = wrapoutexternstruct(v1, UnityEngine.Vector3);
			v2 = wrapoutexternstruct(v2, UnityEngine.Vector3);
			v1 = getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero");
			v2 = getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero");
			return(v1, v2);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), rettype(v1, UnityEngine.Vector3, TypeKind.Struct, 2, true), rettype(v2, UnityEngine.Vector3, TypeKind.Struct, 2, true), paramtype(v1, UnityEngine.Vector3, TypeKind.Struct, 2, true), paramtype(v2, UnityEngine.Vector3, TypeKind.Struct, 2, true)];
		Init = deffunc(0)args(this){
			local(a); a = 2;
			local(intlist); intlist = newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_System_Int32", typeargs(System.Int32), typekinds(TypeKind.Struct), "ctor", 0, literallist("g_System_Collections_Generic_List_System_Int32", typeargs(System.Int32), typekinds(TypeKind.Struct)));
			callexterninstance(intlist, System.Collections.Generic.List_T, "Add", 1);
			local(ts); ts = newstruct(TestStruct, "g_TestStruct", typeargs(), typekinds(), "ctor", 0, null);
			callexterninstance(intlist, System.Collections.Generic.List_T, "Add", invokeoperator(System.Int32, TestStruct, "op_Implicit", wrapstructargument(ts, TestStruct, OperationKind.LocalReference, SymbolKind.Local)));
			local(rs); rs = linq()from(function(){ funcobjret(a); })where(function(score){ funcobjret(execbinary(">", score, 80, , System.Int32, TypeKind.Error, TypeKind.Struct)); })select(function(score){ funcobjret(score); })end();
			local(a); a = deffunc(0)args(){
				callexternstatic(System.Console, "WriteLine__String__Object", dslstrtocsstr("{0}"), getinstance(SymbolKind.Field, ts, TestStruct, "m_A"));
			}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
			multiassign(precode{
					local(__old_var_0_271_8_271_27); __old_var_0_271_8_271_27 = getinstance(SymbolKind.Field, this, Test, "s_V1");
				},postcode{
					getinstance(SymbolKind.Field, this, Test, "s_V1") = wrapexternstruct(getinstance(SymbolKind.Field, this, Test, "s_V1"), UnityEngine.Vector3);
					local(__new_var_0_271_8_271_27); __new_var_0_271_8_271_27 = getinstance(SymbolKind.Field, this, Test, "s_V1");
					recycleandkeepstructvalue(UnityEngine.Vector3, __old_var_0_271_8_271_27, __new_var_0_271_8_271_27);
				})varlist(getinstance(SymbolKind.Field, this, Test, "s_V1")) = callinstance(this, Test, "TestOneV3", __cs2dsl_out);
			multiassign(precode{
					local(__old_var_0_272_8_272_37); __old_var_0_272_8_272_37 = getinstance(SymbolKind.Field, this, Test, "s_V1");
					local(__old_var_1_272_8_272_37); __old_var_1_272_8_272_37 = getinstance(SymbolKind.Field, this, Test, "s_V2");
				},postcode{
					getinstance(SymbolKind.Field, this, Test, "s_V1") = wrapexternstruct(getinstance(SymbolKind.Field, this, Test, "s_V1"), UnityEngine.Vector3);
					getinstance(SymbolKind.Field, this, Test, "s_V2") = wrapexternstruct(getinstance(SymbolKind.Field, this, Test, "s_V2"), UnityEngine.Vector3);
					local(__new_var_0_272_8_272_37); __new_var_0_272_8_272_37 = getinstance(SymbolKind.Field, this, Test, "s_V1");
					local(__new_var_1_272_8_272_37); __new_var_1_272_8_272_37 = getinstance(SymbolKind.Field, this, Test, "s_V2");
					recycleandkeepstructvalue(UnityEngine.Vector3, __old_var_0_272_8_272_37, __new_var_0_272_8_272_37);
					recycleandkeepstructvalue(UnityEngine.Vector3, __old_var_1_272_8_272_37, __new_var_1_272_8_272_37);
				})varlist(getinstance(SymbolKind.Field, this, Test, "s_V1"), getinstance(SymbolKind.Field, this, Test, "s_V2")) = callinstance(this, Test, "TestTwoV3", __cs2dsl_out, __cs2dsl_out);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), localbecaptured(ts, TestStruct, false)];
		TestImp = deffunc(0)args(this, pos){
			local(o); o = pos;
			o = wrapexternstruct(o, UnityEngine.Vector2);
			local(list); list = typeas(objecttodsl(o), System.Collections.Generic.IList_T, TypeKind.Interface, TypeKind.Struct, System.Int32);
			local(arr); arr = typeas(objecttodsl(o), System.Int32, TypeKind.Array, 2, 1);
			local(dict); dict = newdictionary(StrStrDict, "g_StrStrDict", typeargs(), typekinds(), "ctor", 0, literaldictionary("g_StrStrDict", typeargs(), typekinds()));
			local(v);
			if( execbinary("&&", execbinary("!=", null, dict, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execclosure(true, __invoke_281_28_281_58, true){ multiassign(precode{
				},postcode{
				})varlist(__invoke_281_28_281_58, v) = callexterninstance(dict, System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", dslstrtocsstr("abc"), __cs2dsl_out); }, System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 281_8_286_9 ){
				callexternstatic(System.Console, "WriteLine__String", v);
			}elseif( execbinary("&&", execbinary("!=", null, dict, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execclosure(true, __invoke_284_31_284_62, true){ multiassign(precode{
				},postcode{
				})varlist(__invoke_284_31_284_62, v) = callexterninstance(dict, System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", dslstrtocsstr("abc2"), __cs2dsl_out); }, System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 284_8_286_9 ){
				callexternstatic(System.Console, "WriteLine__String", v);
			};
			while( execbinary("&&", execbinary("!=", null, dict, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execclosure(true, __invoke_287_30_287_61, true){ multiassign(precode{
				},postcode{
				})varlist(__invoke_287_30_287_61, v) = callexterninstance(dict, System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", dslstrtocsstr("abc2"), __cs2dsl_out); }, System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct) ){
				callexternstatic(System.Console, "WriteLine__String", v);
			};
			do{
				callexternstatic(System.Console, "WriteLine__String", v);
			}while(execbinary("&&", execbinary("!=", null, dict, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execclosure(true, __invoke_292_33_292_64, true){ multiassign(precode{
				},postcode{
				})varlist(__invoke_292_33_292_64, v) = callexterninstance(dict, System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", dslstrtocsstr("abc2"), __cs2dsl_out); }, System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct));
			local(vv); vv = getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero");
			setexterninstance(SymbolKind.Field, vv, UnityEngine.Vector3, "x", condexpfunc(true, retval_295_15_295_55, condexp_295_15_295_55, Test, false, v){condexp(execbinary("==", v, "yes", System.String, System.String, TypeKind.Class, TypeKind.Class), true, 123, false, function(){ funcobjret(condexpfunc(true, retval_295_34_295_55, condexp_295_34_295_55, Test, false, v){condexp(execbinary("==", v, "no", System.String, System.String, TypeKind.Class, TypeKind.Class), true, 456, true, 789);}options[needfuncinfo(true), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(v, System.String, Class, 0, true)]); });}options[needfuncinfo(true), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(v, System.String, Class, 0, true)]);
			local(iv); iv = condexpfunc(true, retval_296_17_296_57, condexp_296_17_296_57, Test, false, v){condexp(execbinary("==", v, "yes", System.String, System.String, TypeKind.Class, TypeKind.Class), true, 123, false, function(){ funcobjret(condexpfunc(true, retval_296_36_296_57, condexp_296_36_296_57, Test, false, v){condexp(execbinary("==", v, "no", System.String, System.String, TypeKind.Class, TypeKind.Class), true, 456, true, 789);}options[needfuncinfo(true), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(v, System.String, Class, 0, true)]); });}options[needfuncinfo(true), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(v, System.String, Class, 0, true)];
			callinterface(list, System.Collections.Generic.ICollection_T, "Add", condexpfunc(true, retval_297_17_297_57, condexp_297_17_297_57, Test, false, v){condexp(execbinary("==", v, "yes", System.String, System.String, TypeKind.Class, TypeKind.Class), true, 123, false, function(){ funcobjret(condexpfunc(true, retval_297_36_297_57, condexp_297_36_297_57, Test, false, v){condexp(execbinary("==", v, "no", System.String, System.String, TypeKind.Class, TypeKind.Class), true, 456, true, 789);}options[needfuncinfo(true), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(v, System.String, Class, 0, true)]); });}options[needfuncinfo(true), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(v, System.String, Class, 0, true)]);
			local(statusA); statusA = 3;
			statusA = condexpfunc(true, retval_299_18_299_84, condexp_299_18_299_84, Test, false, statusA){condexp(execbinary("==", statusA, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), true, 2, false, function(){ funcobjret(condexpfunc(true, retval_299_37_299_84, condexp_299_37_299_84, Test, false, statusA){condexp(execbinary("==", statusA, 2, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), true, 1, false, function(){ funcobjret(condexpfunc(true, retval_299_56_299_84, condexp_299_56_299_84, Test, false, statusA){condexp(execbinary("==", statusA, 3, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), true, 0, false, function(){ funcobjret(prefixoperator(true, statusA, execbinary("+", statusA, 1, null, null, null, null))); });}options[needfuncinfo(true), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(statusA, System.Int32, Struct, 0, true)]); });}options[needfuncinfo(true), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(statusA, System.Int32, Struct, 0, true)]); });}options[needfuncinfo(true), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(statusA, System.Int32, Struct, 0, true)];
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(pos, UnityEngine.Vector2, TypeKind.Struct, 0, true)];
		testcall = deffunc(1)args(this){
			local(__method_ret_301_4_313_5);
			local(v3); v3 = getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero");
			callinstance(this, Test, "TestImp", invokeexternoperatorreturnstruct(UnityEngine.Vector2, UnityEngine.Vector2, "op_Implicit__Vector2__Vector3", wrapexternstructargument(v3, UnityEngine.Vector3, OperationKind.LocalReference, SymbolKind.Local)));
			local(c); c = getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "red");
			local(c32); c32 = invokeexternoperatorreturnstruct(UnityEngine.Color32, UnityEngine.Color32, "op_Implicit__Color32__Color", wrapexternstructargument(c, UnityEngine.Color, OperationKind.LocalReference, SymbolKind.Local));
			c32 = wrapexternstruct(c32, UnityEngine.Color);
			c32 = invokeexternoperatorreturnstruct(UnityEngine.Color32, UnityEngine.Color32, "op_Implicit__Color32__Color", wrapexternstructargument(c, UnityEngine.Color, OperationKind.LocalReference, SymbolKind.Local));
			c32 = wrapexternstruct(c32, UnityEngine.Color);
			c32 = callexterndelegationreturnstruct(( typecast(( deffunc(1)args(){
				local(__method_ret_308_31_308_50);
				__method_ret_308_31_308_50 = invokeexternoperatorreturnstruct(UnityEngine.Color32, UnityEngine.Color32, "op_Implicit__Color32__Color", wrapexternstructargument(c, UnityEngine.Color, OperationKind.LocalReference, SymbolKind.Local));
				return(__method_ret_308_31_308_50);
			}options[needfuncinfo(true), rettype(return, UnityEngine.Color32, TypeKind.Struct, 0, true)] ), "System.Func_TResult", TypeKind.Delegate) ), "System.Func_TResult.Invoke");
			c32 = callexterndelegationreturnstruct(( typecast(( deffunc(1)args(){ local(__lambda_309_31_309_38); __lambda_309_31_309_38 = invokeexternoperatorreturnstruct(UnityEngine.Color32, UnityEngine.Color32, "op_Implicit__Color32__Color", wrapexternstructargument(c, UnityEngine.Color, OperationKind.LocalReference, SymbolKind.Local)); return(__lambda_309_31_309_38); }options[needfuncinfo(true), rettype(return, UnityEngine.Color32, TypeKind.Struct, 0, true)] ), "System.Func_TResult", TypeKind.Delegate) ), "System.Func_TResult.Invoke");
			local(data); data = 1;
			local(v); v = typecast(data, System.Int32, TypeKind.Struct);
			__method_ret_301_4_313_5 = 1;
			return(__method_ret_301_4_313_5);
		}options[needfuncinfo(true), rettype(return, System.Int32, TypeKind.Struct, 0, true), localbecaptured(c, UnityEngine.Color, true)];
		testimp = deffunc(1)args(this){
			local(__method_ret_314_4_314_66);
			local(__expbody_314_4_314_66); __expbody_314_4_314_66 = invokeexternoperatorreturnstruct(UnityEngine.Color32, UnityEngine.Color32, "op_Implicit__Color32__Color", getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "red")); return(__expbody_314_4_314_66);
		}options[needfuncinfo(true), rettype(return, UnityEngine.Color32, TypeKind.Struct, 0, true)];
		get_testimp2 = deffunc(1)args(this){
			local(__expbody_315_4_315_65); __expbody_315_4_315_65 = invokeexternoperatorreturnstruct(UnityEngine.Color32, UnityEngine.Color32, "op_Implicit__Color32__Color", getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "red")); return(__expbody_315_4_315_65);
		}options[needfuncinfo(true), rettype(return, UnityEngine.Color32, TypeKind.Struct, 0, true)],
		test = deffunc(1)args(this){
			local(__method_ret_316_4_354_5);
			local(a); a = 2;
			local(b); b = 0;
			local(c); c = 1;
			local(aa); aa = deffunc(1)args(){
				local(__method_ret_319_31_332_9);
				local(__try_ret_320_12_325_13, __try_retval_320_12_325_13); multiassign(__try_ret_320_12_325_13, __try_retval_320_12_325_13) = dsltry(false, __try_ret_320_12_325_13){
					callexternstatic(System.Console, "Write__String", dslstrtocsstr("test"));
				};
				local(__catch_handled_320_12_325_13, __catch_retval_320_12_325_13); __catch_handled_320_12_325_13 = false;
				__catch_retval_320_12_325_13 = dslcatch(__catch_handled_320_12_325_13, __try_retval_320_12_325_13, __try_ret_320_12_325_13,
					function(ex){
						__catch_handled_320_12_325_13 = true;
					}
				);
				local(__try_ret_326_12_331_13, __try_retval_326_12_331_13); multiassign(__try_ret_326_12_331_13, __try_retval_326_12_331_13) = dsltry(false, __try_ret_326_12_331_13){
					block{
					__method_ret_319_31_332_9 = lualib_call(2, [null], this, Test, "testcall");
					__try_retval_326_12_331_13 = 1;
					break;
					};
				};
				if(__try_ret_326_12_331_13){
					if(__try_retval_326_12_331_13){
					if(__try_retval_326_12_331_13==1){
						return(__method_ret_319_31_332_9);
					};
					};
				};
				local(__catch_handled_326_12_331_13, __catch_retval_326_12_331_13); __catch_handled_326_12_331_13 = false;
				__catch_retval_326_12_331_13 = dslcatch(__catch_handled_326_12_331_13, __try_retval_326_12_331_13, __try_ret_326_12_331_13,
					function(ex){
						__catch_handled_326_12_331_13 = true;
						block{
						__method_ret_319_31_332_9 = 0;
						return(1);
						};
					}
				);
				if(__catch_retval_326_12_331_13){
				if(__catch_retval_326_12_331_13==1){
					return(__method_ret_319_31_332_9);
				};
				};
				return(null);
			}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
			local(__try_ret_334_8_339_9, __try_retval_334_8_339_9); multiassign(__try_ret_334_8_339_9, __try_retval_334_8_339_9) = dsltryfunc(__try_ret_334_8_339_9, __try_retval_334_8_339_9, __try_func_334_8_339_9, Test, false, 2){
				callexternstatic(System.Console, "Write__String", dslstrtocsstr("test"));
			}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
			local(__catch_handled_334_8_339_9, __catch_retval_334_8_339_9); __catch_handled_334_8_339_9 = false;
			__catch_retval_334_8_339_9 = dslcatch(__catch_handled_334_8_339_9, __try_retval_334_8_339_9, __try_ret_334_8_339_9,
				function(ex){
					__catch_handled_334_8_339_9 = true;
				}
			);
			local(intlist); intlist = newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_System_Int32", typeargs(System.Int32), typekinds(TypeKind.Struct), "ctor", 0, literallist("g_System_Collections_Generic_List_System_Int32", typeargs(System.Int32), typekinds(TypeKind.Struct)));
			local(__try_retval_341_8_351_9_0); __try_retval_341_8_351_9_0 = __method_ret_316_4_354_5;
			local(__try_ret_341_8_351_9, __try_retval_341_8_351_9); multiassign(__try_ret_341_8_351_9, __try_retval_341_8_351_9, __try_retval_341_8_351_9_0) = dsltryfunc(__try_ret_341_8_351_9, __try_retval_341_8_351_9, __try_func_341_8_351_9, Test, false, 2, __method_ret_316_4_354_5, aa){
				block{
				__method_ret_316_4_354_5 = callexterndelegation(aa, "System.Func_TResult.Invoke");
				return(1, __method_ret_316_4_354_5);
				};
			}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true), rettype(__method_ret_316_4_354_5, System.Int32, TypeKind.Struct, 1, true), paramtype(__method_ret_316_4_354_5, System.Int32, TypeKind.Struct, 1, true), paramtype(aa, System.Func_TResult, Delegate, 0, true)];
			if(__try_ret_341_8_351_9){
				__method_ret_316_4_354_5 = __try_retval_341_8_351_9_0;
			};
			if(__try_ret_341_8_351_9){
				callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("{0} {1} {2}"), a, b, c);
				if(__try_retval_341_8_351_9){
				if(__try_retval_341_8_351_9==1){
					return(__method_ret_316_4_354_5);
				};
				};
			};
			local(__catch_handled_341_8_351_9, __catch_retval_341_8_351_9); __catch_handled_341_8_351_9 = false;
			__catch_retval_341_8_351_9 = dslcatch(__catch_handled_341_8_351_9, __try_retval_341_8_351_9, __try_ret_341_8_351_9,
				function(e){
					if(typeis(e, System.ArgumentException, TypeKind.Class)){
						__catch_handled_341_8_351_9 = true;
						callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("ex:{0} {1} {2}"), a, b, c);
						dslthrow(a);
						block{
						__method_ret_316_4_354_5 = 0;
						return(1);
						};
					};
				}
			);
			callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("{0} {1} {2}"), a, b, c);
			if(__catch_retval_341_8_351_9){
			if(__catch_retval_341_8_351_9==1){
				return(__method_ret_316_4_354_5);
			};
			};
			if(! __try_ret_341_8_351_9){
				callexternstatic(System.Console, "WriteLine__String__Object__Object__Object", dslstrtocsstr("{0} {1} {2}"), a, b, c);
			};
			setinstance(SymbolKind.Field, this, Test, "m_IntVal", condexpfunc(true, retval_353_24_353_40, condexp_353_24_353_40, Test, false){condexp(execbinary(">", a, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), false, function(){ funcobjret(callexterndelegation(aa, "System.Func_TResult.Invoke")); }, false, function(){ funcobjret(c); });}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)]);
			return(__method_ret_316_4_354_5);
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
			setinstance(SymbolKind.Field, this, Test, "s_V1", getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero"));
			recycleandkeepstructvalue(UnityEngine.Vector3, nil, getinstance(SymbolKind.Field, this, Test, "s_V1"));
			setinstance(SymbolKind.Field, this, Test, "s_V2", getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero"));
			recycleandkeepstructvalue(UnityEngine.Vector3, nil, getinstance(SymbolKind.Field, this, Test, "s_V2"));
			setinstance(SymbolKind.Field, this, Test, "m_DataChangeCallBackInfoPool", newobject(Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "g_Cs2LuaObjectPoolEx_DataChangeCallBackInfo", typeargs(DataChangeCallBackInfo), typekinds(TypeKind.Class), "ctor", 0, null));
			setinstance(SymbolKind.Field, this, Test, "m_Vs", newmultiarray(UnityEngine.Vector3, TypeKind.Struct, defaultvalue(UnityEngine.Vector3, "UnityEngine.Vector3", true), 1, 10));
			setinstance(SymbolKind.Field, this, Test, "m_IntIntKeyValue", newobject(Cs2LuaKeyValuePair_System_Int32_System_Int32, "g_Cs2LuaKeyValuePair_System_Int32_System_Int32", typeargs(System.Int32, System.Int32), typekinds(TypeKind.Struct, TypeKind.Struct), "ctor", 0, null));
			setinstance(SymbolKind.Field, this, Test, "m_C32", invokeexternoperatorreturnstruct(UnityEngine.Color32, UnityEngine.Color32, "op_Implicit__Color32__Color", getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "red")));
			recycleandkeepstructvalue(UnityEngine.Color32, nil, getinstance(SymbolKind.Field, this, Test, "m_C32"));
		}options[needfuncinfo(true)];
	};
	instance_fields {
		s_V1 = null;
		s_V2 = null;
		m_DataChangeCallBackInfoPool = null;
		m_IntVal = 0;
		m_Vs = null;
		m_IntIntKeyValue = null;
		m_C32 = null;
		__ctor_called = false;
	};
	instance_props {
		testimp2 = {
			get = instance_methods.get_testimp2;
		};
	};
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
		TestOneV3(MethodKind.Ordinary, Accessibility.Public){
		};
		TestTwoV3(MethodKind.Ordinary, Accessibility.Public){
		};
		Init(MethodKind.Ordinary, Accessibility.Public){
		};
		TestImp(MethodKind.Ordinary, Accessibility.Public){
		};
		testcall(MethodKind.Ordinary, Accessibility.Public){
		};
		testimp(MethodKind.Ordinary, Accessibility.Public){
		};
		get_testimp2(MethodKind.PropertyGet, Accessibility.Public){
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
};



