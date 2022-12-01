require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("datablockdefine__baseintegerarray");

class(DataBlockDefine.DoubleArray, DataBlockDefine.BaseIntegerArray, false) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.DoubleArray, "g_DataBlockDefine_DoubleArray", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.BaseIntegerArray, "cctor");
			callstatic(DataBlockDefine.DoubleArray, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.DoubleArray.__cctor_called){
				return();
			}else{
				DataBlockDefine.DoubleArray.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		Reset = deffunc(0)args(this, size){
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 855_12_857_13 ){
				callstatic(DclApi, "free_array", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"));
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId") = callstatic(DclApi, "alloc_array", 8, size, size);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(size, System.UInt32, TypeKind.Structure, 0, true)];
		GetData = deffunc(1)args(this, index){
			local(__method_ret_860_8_868_9);
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 862_12_867_13 ){
				__method_ret_860_8_868_9 = callstatic(DclApi, "get_array_element_double", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), typecast(index, System.UInt32, TypeKind.Structure));
				return(__method_ret_860_8_868_9);
			}else{
				__method_ret_860_8_868_9 = 0;
				return(__method_ret_860_8_868_9);
			};
			return(null);
		}options[needfuncinfo(false), rettype(return, System.Double, TypeKind.Structure, 0, true), paramtype(index, System.Int32, TypeKind.Structure, 0, true)];
		SetData = deffunc(0)args(this, index, val){
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 871_12_873_13 ){
				callstatic(DclApi, "set_array_element_double", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), typecast(index, System.UInt32, TypeKind.Structure), val);
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(index, System.Int32, TypeKind.Structure, 0, true), paramtype(val, System.Double, TypeKind.Structure, 0, true)];
		ctor = deffunc(0)args(this){
			buildbaseobj(this, DataBlockDefine.DoubleArray, DataBlockDefine.BaseIntegerArray, "ctor", 0);
			callinstance(this, DataBlockDefine.DoubleArray, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleArray, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.DoubleArray, "__ctor_called", true);
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
		Reset(MethodKind.Ordinary, Accessibility.Public){
		};
		GetData(MethodKind.Ordinary, Accessibility.Public){
		};
		SetData(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



