require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("intlist");

class(TestExtension) {
	static_methods {
		Test = deffunc(0)args(list, T, t){
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(TestExtension, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(TestExtension.__cctor_called){
				return();
			}else{
				TestExtension.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

};



