require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

struct(TestStruct) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newstruct(TestStruct, "g_TestStruct", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(true)];
		op_Implicit = deffunc(1)args(ts){
			local(__method_ret_28_4_31_5);
			__method_ret_28_4_31_5 = getinstance(SymbolKind.Field, ts, TestStruct, "m_A");
			return(__method_ret_28_4_31_5);
			return(null);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(ts, TestStruct, TypeKind.Struct, 0, false)];
		cctor = deffunc(0)args(){
			callstatic(TestStruct, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(TestStruct.__cctor_called){
				return();
			}else{
				TestStruct.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = deffunc(0)args(this){
			callinstance(this, TestStruct, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, TestStruct, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, TestStruct, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		m_A = 0;
		m_B = 0;
		m_C = 0;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Struct, Accessibility.Internal) {
		sealed(true);
	};
	method_info {
		op_Implicit(MethodKind.Conversion, Accessibility.Public){
			static(true);
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



