require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(DataBlockDefine.CString) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.CString, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.CString.__cctor_called){
				return();
			}else{
				DataBlockDefine.CString.__cctor_called = true;
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
			callinstance(this, DataBlockDefine.CString, "__ctor");
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)],
		ctor__String = deffunc(0)args(this, str){
			callinstance(this, DataBlockDefine.CString, "__ctor");
			callinstance(this, DataBlockDefine.CString, "Init");
			callinstance(this, DataBlockDefine.CString, "SetString", str);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(str, System.String, TypeKind.Class, 0, true)],
		GetDataBlockId = deffunc(1)args(this){
			local(__method_ret_886_8_889_9);
			__method_ret_886_8_889_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_DataBlockId");
			return(__method_ret_886_8_889_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_IsValid"), 892_12_893_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_IsValid"), System.Boolean, TypeKind.Struct), 898_12_899_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_StringCache", null);
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 901_12_904_13 ){
				callstatic(DclApi, "free_string", getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_DataBlockId"));
				setinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_DataBlockId", 0);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_IsValid"), 909_12_910_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_DataBlockId", dataBlockId);
			setinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_IsValid"), System.Boolean, TypeKind.Struct), 916_12_917_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_StringCache", null);
			setinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetString = deffunc(1)args(this){
			local(__method_ret_923_8_929_9);
			if( execbinary("&&", execbinary("==", null, getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_StringCache"), System.String, System.String, TypeKind.Class, TypeKind.Class), execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 925_12_927_13 ){
				getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_StringCache") = callstatic(DclApi, "get_string", getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_DataBlockId"));
			};
			__method_ret_923_8_929_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_StringCache");
			return(__method_ret_923_8_929_9);
		}options[needfuncinfo(false), rettype(return, System.String, TypeKind.Class, 0, true)];
		SetString = deffunc(0)args(this, val){
			setinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_StringCache", val);
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 933_12_935_13 ){
				callstatic(DclApi, "free_string", getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_DataBlockId"));
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_DataBlockId") = callstatic(DclApi, "alloc_string", getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "m_StringCache"));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(val, System.String, TypeKind.Class, 0, true)];
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.CString, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.CString, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		m_IsValid = false;
		m_DataBlockId = 0;
		m_StringCache = null;
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
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		ctor__String(MethodKind.Constructor, Accessibility.Public){
		};
		GetDataBlockId(MethodKind.Ordinary, Accessibility.Public){
		};
		Init(MethodKind.Ordinary, Accessibility.Public){
		};
		Release(MethodKind.Ordinary, Accessibility.Public){
		};
		Attach(MethodKind.Ordinary, Accessibility.Public){
		};
		Detach(MethodKind.Ordinary, Accessibility.Public){
		};
		GetString(MethodKind.Ordinary, Accessibility.Public){
		};
		SetString(MethodKind.Ordinary, Accessibility.Public){
		};
	};
};



