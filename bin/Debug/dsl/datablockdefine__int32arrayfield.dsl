require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("datablockdefine__baseintegerarray");

class(DataBlockDefine.Int32ArrayField, DataBlockDefine.BaseIntegerArray, false) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.Int32ArrayField, "g_DataBlockDefine_Int32ArrayField", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.BaseIntegerArray, "cctor");
			callstatic(DataBlockDefine.Int32ArrayField, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.Int32ArrayField.__cctor_called){
				return();
			}else{
				DataBlockDefine.Int32ArrayField.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		GetData = deffunc(1)args(this, index){
			local(__method_ret_2340_8_2348_9);
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2342_12_2347_13 ){
				__method_ret_2340_8_2348_9 = callstatic(DataBlockDefine.DclApi, "get_array_element_int32", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), typecast(index, System.UInt32, TypeKind.Struct));
				return(__method_ret_2340_8_2348_9);
			}else{
				__method_ret_2340_8_2348_9 = 0;
				return(__method_ret_2340_8_2348_9);
			};
			return(null);
		}options[needfuncinfo(false), rettype(return, System.Int64, TypeKind.Struct, 0, true), paramtype(index, System.Int32, TypeKind.Struct, 0, true)];
		ctor = deffunc(0)args(this){
			buildbaseobj(this, DataBlockDefine.Int32ArrayField, DataBlockDefine.BaseIntegerArray, "ctor", 0);
			callinstance(this, DataBlockDefine.Int32ArrayField, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.Int32ArrayField, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.Int32ArrayField, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"DataBlockDefine.IDataBlock";
	};

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		GetData(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



