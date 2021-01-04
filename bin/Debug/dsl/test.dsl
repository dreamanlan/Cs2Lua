require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("strlist");
require("datachangecallbackinfo");
require("cs2luaobjectpoolex_datachangecallbackinfo");

class(Test) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(Test, typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		ToList = deffunc(1)args(T, enumer){
			local(__method_ret_138_4_145_5);
			local(r); r = newexternlist(System.Collections.Generic.List_T, typeargs(T), typekinds(TypeKind.TypeParameter), "ctor", literallist(typeargs(T), typekinds(TypeKind.TypeParameter)));
			foreach(__foreach_141_8_143_9, v, enumer, System.Collections.Generic.IEnumerable_T, System.Collections.Generic.IEnumerable_T, true){
				callexterninstance(r, System.Collections.Generic.List_T, "Add", v);
			};
			__method_ret_138_4_145_5 = r;
			return(__method_ret_138_4_145_5);
		}options[needfuncinfo(false), rettype(System.Collections.Generic.List_T, TypeKind.Class), paramtype(T, null, TypeKind.TypeParameter), paramtype(enumer, System.Collections.Generic.IEnumerable_T, TypeKind.Interface)];
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
		Init = deffunc(0)args(this){
			local(items); items = literalarray(System.String, TypeKind.Class, "ȫ��", "������", "�ɽ�ȡ", "�����", "δ��ȡ");
			callinstance(getinstance(SymbolKind.Field, this, Test, "m_DataChangeCallBackInfoPool"), Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "Init__Func_1_T__Action_1_T", null, null);
			local(strlist); strlist = newlist(StrList, typeargs(), typekinds(), "ctor", literallist(typeargs(), typekinds()));
			callexterninstance(strlist, System.Collections.Generic.List_T, "Add", getexternstatic(SymbolKind.Field, System.String, "Empty"));
			callexterninstance(strlist, System.Collections.Generic.List_T, "Sort__Comparison_1_T", deffunc(1)args(a, b){ local(__lambda_113_21_113_45); __lambda_113_21_113_45 = invokeforbasicvalue(a, false, System.String, "CompareTo__String", b); return(__lambda_113_21_113_45); }options[needfuncinfo(false), rettype(System.Int32, TypeKind.Struct), paramtype(a, System.String, TypeKind.Class), paramtype(b, System.String, TypeKind.Class)]);
			local(intlist); intlist = newexternlist(System.Collections.Generic.List_T, typeargs(System.Int32), typekinds(TypeKind.Struct), "ctor", literallist(typeargs(System.Int32), typekinds(TypeKind.Struct)));
			callexterninstance(intlist, System.Collections.Generic.List_T, "Add", 1);
			local(sa); sa = getexterninstanceindexer(StrList, strlist, System.Collections.Generic.List_T, "get_Item", 1, 0);
			callexterninstance(intlist, System.Collections.Generic.List_T, "Sort__Comparison_1_T", deffunc(1)args(a, b){ local(__lambda_117_21_117_45); __lambda_117_21_117_45 = invokeforbasicvalue(a, false, System.Int32, "CompareTo__Int32", b); return(__lambda_117_21_117_45); }options[needfuncinfo(false), rettype(System.Int32, TypeKind.Struct), paramtype(a, System.Int32, TypeKind.Struct), paramtype(b, System.Int32, TypeKind.Struct)]);
			local(iaa); iaa = condexp(execbinary("!=", null, strlist, System.Object, System.Object, TypeKind.Class, TypeKind.Class), false, function(){ funcobjret(getexterninstance(SymbolKind.Property, strlist, System.Collections.Generic.List_T, "Count")); }, false, function(){ funcobjret(getexterninstance(SymbolKind.Property, intlist, System.Collections.Generic.List_T, "Count")); });
			local(aa); aa = literalarray(System.Int32, TypeKind.Struct, 1, 2, 3, 4, 5);
			local(bb); bb = literalarray(System.Int32, TypeKind.Struct, literalarray(System.Int32, TypeKind.Struct, 1, 2), literalarray(System.Int32, TypeKind.Struct, 3, 4), literalarray(System.Int32, TypeKind.Struct, 5, 6));
			local(ia); ia = bb[1][2];
			foreachlist(__foreach_ix_122_8_124_9, __foreach_exp_122_8_124_9, s, strlist, StrList, System.Collections.Generic.List_T, true){
				callexternstatic(System.Console, "WriteLine__String", s);
			};
			foreacharray(__foreach_ix_125_8_127_9, __foreach_exp_125_8_127_9, v, aa, 1, true){
				callexternstatic(System.Console, "WriteLine__Int32", v);
			};
			foreacharray(__foreach_ix_128_8_130_9, __foreach_exp_128_8_130_9, v, bb, 2, true){
				callexternstatic(System.Console, "WriteLine__Int32", v);
			};
			local(act); act = typecast(( deffunc(0)args(){
				callexternstatic(System.Console, "Write__Int32", ia);
			}options[needfuncinfo(false), rettype(System.Void, TypeKind.Unknown)] ), "System.Action", TypeKind.Delegate);
			local(cc); cc = callstatic(Test, "ToList", System.Int32, aa);
		}options[needfuncinfo(false), rettype(System.Void, TypeKind.Unknown)];
		test = deffunc(0)args(this){
			local(a); a = deffunc(0)args(){
				callexternstatic(System.Console, "Write__String", dslstrtocsstr("test"));
			}options[needfuncinfo(false), rettype(System.Void, TypeKind.Unknown)];
		}options[needfuncinfo(false), rettype(System.Void, TypeKind.Unknown)];
		ctor = deffunc(0)args(this){
			callinstance(this, Test, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, Test, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, Test, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, Test, "m_DataChangeCallBackInfoPool", newobject(Cs2LuaObjectPoolEx_DataChangeCallBackInfo, typeargs(DataChangeCallBackInfo), typekinds(TypeKind.Class), "ctor", null));
		}options[needfuncinfo(false)];
	};
	instance_fields {
		m_DataChangeCallBackInfoPool = null;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		Init(MethodKind.Ordinary, Accessibility.Public){
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
	};
};



