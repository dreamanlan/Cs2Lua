require("cs2dsl__syslib");
require("cs2dsl__attributes");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(DataBlockDefine.DclApi) {
	static_methods {
		get_string = deffunc(1)args(id){
			local(__method_ret_272_8_279_9);
			local(v); v = callstatic(DataBlockDefine.DclApi, "get_cstring", id);
			if( execbinary("==", callexterninstancereturnstruct(v, System.IntPtr, "ToPointer"), null, , , TypeKind.Pointer, TypeKind.Pointer), 275_12_277_13 ){
				__method_ret_272_8_279_9 = null;
				return(__method_ret_272_8_279_9);
			};
			__method_ret_272_8_279_9 = callexternstatic(System.Runtime.InteropServices.Marshal, "PtrToStringAnsi__IntPtr", wrapexternstructargument(v, System.IntPtr, OperationKind.LocalReference, SymbolKind.Local));
			return(__method_ret_272_8_279_9);
		}options[needfuncinfo(true), rettype(return, System.String, TypeKind.Class, 0, true), paramtype(id, System.UInt64, TypeKind.Struct, 0, true)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.DclApi, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.DclApi.__cctor_called){
				return();
			}else{
				DataBlockDefine.DclApi.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__attributes = DataBlockDefine__DclApi__Attrs;
		__cctor_called = false;
	};
	static_props {};
	static_events {};

};



