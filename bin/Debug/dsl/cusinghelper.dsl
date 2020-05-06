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
		ReadZip = function(bytes){
			local(__method_ret_36_4_51_2); __method_ret_36_4_51_2 = null;
			local(zipInput); zipInput = newobject(ZipInputStream, typeargs(), typekinds(), "ctor", null, newexternobject(System.IO.MemoryStream, typeargs(), typekinds(), null, "System.IO.MemoryStream:ctor__Arr_Byte", bytes));
			local(zipMemory); zipMemory = newexternobject(System.IO.MemoryStream, typeargs(), typekinds(), null, "System.IO.MemoryStream:ctor");
			local(ZipStream); ZipStream = newobject(ZipOutputStream, typeargs(), typekinds(), "ctor", null, zipMemory);
			local(__try_ret_42_2_50_3, __try_retval_42_2_50_3); multiassign(__try_ret_42_2_50_3, __try_retval_42_2_50_3) = dsltry(function(){
				block{
				__method_ret_36_4_51_2 = null;
				return(1);
				};
			});
			if(__try_ret_42_2_50_3 && __try_retval_42_2_50_3){
			if(__try_retval_42_2_50_3==1){
				return(__method_ret_36_4_51_2);
			};
			};
			local(__try_handled_42_2_50_3, __try_catch_ret_val_42_2_50_3); __try_handled_42_2_50_3 = false;
			multiassign(__try_handled_42_2_50_3, __try_catch_ret_val_42_2_50_3) = dslcatch(__try_handled_42_2_50_3, __try_ret_42_2_50_3, __try_retval_42_2_50_3,
				(function(__catch_handled_46_2_50_3, ){
					__catch_handled_46_2_50_3 = true;
					local(__catch_body_46_2_50_3); __catch_body_46_2_50_3 = function(){
						block{
						__method_ret_36_4_51_2 = null;
						return(1);
						};
						dslthrow();
					};
					return(__catch_handled_46_2_50_3, __catch_body_46_2_50_3());
				})
			);
			if(__try_ret_42_2_50_3 && __try_catch_ret_val_42_2_50_3){
			if(__try_catch_ret_val_42_2_50_3==1){
				return(__method_ret_36_4_51_2);
			};
			};
			return(__method_ret_36_4_51_2);
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
			if(getinstance(this, "__ctor_called")){
				return;
			}else{
				setinstance(this, "__ctor_called", true);
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
	interface_map {
		IDisposable_Dispose = "Dispose";
	};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		Dispose(MethodKind.Ordinary, Accessibility.Public){
		};
		ReadZip(MethodKind.Ordinary, Accessibility.Public){
			static(true);
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



