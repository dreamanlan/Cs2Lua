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
			return(newobject(CUsingHelper, typeargs(), typekinds(), "ctor", null, ...));
		};
		ReadZip = function(bytes){
			local(__method_ret_36_4_51_2); __method_ret_36_4_51_2 = nil;
			local(zipInput); zipInput = newobject(ZipInputStream, typeargs(), typekinds(), "ctor", null, newexternobject(System.IO.MemoryStream, typeargs(), typekinds(), "System.IO.MemoryStream", "ctor", null, bytes));
			local(zipMemory); zipMemory = newexternobject(System.IO.MemoryStream, typeargs(), typekinds(), "System.IO.MemoryStream", "ctor", null);
			local(ZipStream); ZipStream = newobject(ZipOutputStream, typeargs(), typekinds(), "ctor", null, zipMemory);
			local(__try_ret_42_2_50_3, __try_err_42_2_50_3); multiassign(__try_ret_42_2_50_3, __try_err_42_2_50_3) = dsltry(function(){
				block{
				__method_ret_36_4_51_2 = null;
				return(true);
				};
			});
			local(__try_handled_42_2_50_3); __try_handled_42_2_50_3 = false;
			__try_handled_42_2_50_3 = dslcatch(__try_handled_42_2_50_3, __try_ret_42_2_50_3, __try_err_42_2_50_3,
				(function(__catch_handled_46_2_50_3, ){
					block{
					__method_ret_36_4_51_2 = null;
					return(true);
					};
					dslthrow();
					__catch_handled_46_2_50_3 = true;
					return __catch_handled_46_2_50_3;
				})
			);
			return(__method_ret_36_4_51_2, );
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



