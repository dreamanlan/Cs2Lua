require("cs2lua__utility");
require("cs2lua__attributes");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");
require("zipinputstream");
require("zipoutputstream");

class(CUsingHelper) {
	static_methods {
		__new_object = function(...){
			return(newobject(CUsingHelper, "ctor", null, ...));
		};
		ReadZip = function(bytes){
			local(__compiler_method_ret_36_4_51_2); __compiler_method_ret_36_4_51_2 = nil;
			local(zipInput); zipInput = newobject(ZipInputStream, "ctor", null, newexternobject(System.IO.MemoryStream, "System.IO.MemoryStream", "ctor", null, bytes));
			local(zipMemory); zipMemory = newexternobject(System.IO.MemoryStream, "System.IO.MemoryStream", "ctor", null);
			local(ZipStream); ZipStream = newobject(ZipOutputStream, "ctor", null, zipMemory);
			local(__compiler_try_ret_42_2_50_3, __compiler_try_err_42_2_50_3); multiassign(__compiler_try_ret_42_2_50_3, __compiler_try_err_42_2_50_3) = dsltry(function(){
				block{
				__compiler_method_ret_36_4_51_2 = null;
				return(true);
				};
			});
			local(__compiler_try_handled_42_2_50_3); __compiler_try_handled_42_2_50_3 = false;
			__compiler_try_handled_42_2_50_3 = dslcatch(__compiler_try_handled_42_2_50_3, __compiler_try_ret_42_2_50_3, __compiler_try_err_42_2_50_3,
				(function(__compiler_catch_handled_46_2_50_3, ){
					block{
					__compiler_method_ret_36_4_51_2 = null;
					return(true);
					};
					dslthrow();
					__compiler_catch_handled_46_2_50_3 = true;
					return __compiler_catch_handled_46_2_50_3;
				})
			);
			return(__compiler_method_ret_36_4_51_2, );
		};
		cctor = function(){
		};
	};
	static_fields {
		__attributes = CUsingHelper__Attrs;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this, a1, a2){
			return(this);
		},
		Dispose = function(this){
		};
	};
	instance_fields {
		__attributes = CUsingHelper__Attrs;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"System.IDisposable";
	};
	interface_map {
		IDisposable_Dispose = "Dispose";
	};
};



