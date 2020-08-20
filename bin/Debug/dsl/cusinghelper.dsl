require("cs2dsl__lualib");
require("cs2dsl__attributes");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("zipinputstream");
require("zipoutputstream");

class(CUsingHelper) {
	static_methods {
		__new_object = function(...){
			return(newobject(CUsingHelper, typeargs(), typekinds(), "ctor", null, ...));
		};
		Test = function(i){
			return(null);
		};
		ReadZip = function(bytes){
			local(__method_ret_40_4_55_2); __method_ret_40_4_55_2 = null;
			local(zipInput); zipInput = newobject(ZipInputStream, typeargs(), typekinds(), "ctor", null, newexternobject(System.IO.MemoryStream, typeargs(), typekinds(), null, "System.IO.MemoryStream:ctor__Arr_Byte", bytes));
			local(zipMemory); zipMemory = newexternobject(System.IO.MemoryStream, typeargs(), typekinds(), null, "System.IO.MemoryStream:ctor");
			local(ZipStream); ZipStream = newobject(ZipOutputStream, typeargs(), typekinds(), "ctor", null, zipMemory);
			local(__try_ret_46_2_54_3, __try_retval_46_2_54_3); multiassign(__try_ret_46_2_54_3, __try_retval_46_2_54_3) = dsltry(false, __try_ret_46_2_54_3){
				block{
				__method_ret_40_4_55_2 = callstatic(CUsingHelper, "Test", 123);
				__try_retval_46_2_54_3 = 1;
				break;
				};
			};
			if(__try_ret_46_2_54_3){
				if(__try_retval_46_2_54_3){
				if(__try_retval_46_2_54_3==1){
					return(__method_ret_40_4_55_2);
				};
				};
			};
			local(__try_handled_46_2_54_3, __try_catch_ret_val_46_2_54_3); __try_handled_46_2_54_3 = false;
			__try_catch_ret_val_46_2_54_3 = dslcatch(__try_handled_46_2_54_3, __try_retval_46_2_54_3, __try_ret_46_2_54_3,
				(function(, ){
					__try_handled_46_2_54_3 = true;
					block{
					__method_ret_40_4_55_2 = null;
					return(1);
					};
					dslthrow();
				})
			);
			if(__try_catch_ret_val_46_2_54_3){
			if(__try_catch_ret_val_46_2_54_3==1){
				return(__method_ret_40_4_55_2);
			};
			};
			return(__method_ret_40_4_55_2);
		};
		cctor = function(){
			callstatic(CUsingHelper, "__cctor");
		};
		__cctor = function(){
			if(CUsingHelper.__cctor_called){
				return;
			}else{
				CUsingHelper.__cctor_called = true;
			};
		};
	};
	static_fields {
		__attributes = CUsingHelper__Attrs;
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this, a1, a2){
			callinstance(this, "__ctor");
			return(this);
		},
		Dispose = function(this){
		};
		__ctor = function(this){
			if(getinstance(SymbolKind.Field, this, "__ctor_called")){
				return;
			}else{
				setinstance(SymbolKind.Field, this, "__ctor_called", true);
			};
		};
	};
	instance_fields {
		__attributes = CUsingHelper__Attrs;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"System.IDisposable";
	};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		Dispose(MethodKind.Ordinary, Accessibility.Public){
		};
		Test(MethodKind.Ordinary, Accessibility.Public){
			static(true);
		};
		ReadZip(MethodKind.Ordinary, Accessibility.Public){
			static(true);
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



