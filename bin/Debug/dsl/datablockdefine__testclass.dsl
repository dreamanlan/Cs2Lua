require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(DataBlockDefine.TestClass) {
	static_methods {
		test = deffunc(0)args(str){
			callexternstatic(System.Console, "WriteLine__String__Object", dslstrtocsstr("{0}"), condaccess(str, function(){ funcobjret(str.Length); }));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(str, System.String, TypeKind.Class, 0, true)];
		Call = deffunc(0)args(){
			local(abc); abc = null;
			abc = "test";
			callstatic(DataBlockDefine.TestClass, "test", abc);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.TestClass, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.TestClass.__cctor_called){
				return();
			}else{
				DataBlockDefine.TestClass.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

};



