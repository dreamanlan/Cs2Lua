require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("intlist");

class(TestExtension) {
	static_methods {
		Test = deffunc(0)args(list, T, t){
		};
		cctor = deffunc(0)args(){
			callstatic(TestExtension, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(TestExtension.__cctor_called){
				return;
			}else{
				TestExtension.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

};



