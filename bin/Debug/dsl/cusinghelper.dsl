require("cs2dsl__lualib");
require("cs2dsl__attributes");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(CUsingHelper) {
	static_methods {
		__new_object = deffunc(1)args(...){
			return(newobject(CUsingHelper, typeargs(), typekinds(), "ctor", null, ...));
		};
		Test = deffunc(1)args(i){
			return(null);
		};
		ReadZip = deffunc(1)args(bytes){
			local(abc); abc = newmultiarray(System.Int32, TypeKind.Struct, 0, 2, 12, 13);
			local(v); v = 0;
			local(dict); dict = newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, typeargs(System.Int32, System.Int32), typekinds(TypeKind.Struct, TypeKind.Struct), literaldictionary(typeargs(System.Int32, System.Int32), typekinds(TypeKind.Struct, TypeKind.Struct)), "System.Collections.Generic.Dictionary_TKey_TValue:ctor");
			if( execbinary(">", prefixoperator(true, v, execbinary("+", v, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct)), 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
			}else{
				if( execbinary("&&", execclosure(true, __invoke_76_16_76_42, true){ multiassign(__invoke_76_16_76_42, v) = callexterninstance(dict, "TryGetValue", 1, __cs2dsl_out); }, execbinary("==", v, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct) ){
				}elseif( execbinary(">", postfixoperator(true, __unary_78_21_78_24, v, execbinary("+", v, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct)), 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				}elseif( execbinary(">", prefixoperator(true, v, execbinary("-", v, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct)), 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				}else{
				};
			};
			comments {				comment("        if(dict.TryGetValue(1, out v) && v==0) {");
				comment("        }");
				comment("        while (dict.TryGetValue(1, out v) && v == 0) {");
				comment("        }");
				comment("        do {");
				comment("        } while (dict.TryGetValue(1, out v) && v == 0);");
				comment("        ");
				comment("        int v1 = ++v + 2;");
				comment("        int v2 = v++ + 2;");
				comment("        if(++v > 0) {");
				comment("        }");
				comment("        if(v++ > 0) {");
				comment("        }");
				comment("        while(++v > 0) {");
				comment("        }");
				comment("        while (v-- > 0) {");
				comment("        }");
				comment("        do {");
				comment("        } while (++v > 0);");
				comment("        do {");
				comment("        } while (v-- > 0);");
				comment("        ");
			};
			comments {				comment("        ZipInputStream zipInput = new ZipInputStream(new MemoryStream(bytes));");
				comment("\t\tMemoryStream zipMemory = new MemoryStream();");
				comment("\t\tZipOutputStream ZipStream = new ZipOutputStream(zipMemory);");
				comment("\t\ttry");
				comment("\t\t{");
				comment("\t\t\treturn Test(123);");
				comment("\t\t}");
				comment("\t\tcatch (Exception)");
				comment("\t\t{");
				comment("\t\t\treturn null;");
				comment("\t\t\tthrow;");
				comment("\t\t}");
				comment("        ");
			};
			return(null);
		};
		cctor = deffunc(0)args(){
			callstatic(CUsingHelper, "__cctor");
		};
		__cctor = deffunc(0)args(){
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
		ctor = deffunc(0)args(this, a1, a2){
			callinstance(this, "__ctor");
			return(this);
		},
		Dispose = deffunc(0)args(this){
		};
		__ctor = deffunc(0)args(this){
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



