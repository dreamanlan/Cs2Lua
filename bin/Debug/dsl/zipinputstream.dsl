require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("zipoutputstream");
require("intlist");
require("testextension");

class(ZipInputStream) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(ZipInputStream, typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(ZipInputStream, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(ZipInputStream.__cctor_called){
				return();
			}else{
				ZipInputStream.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = deffunc(0)args(this, ms){
			callinstance(this, ZipInputStream, "__ctor");
			local(os); os = ;
			local(os2); os2 = typeas(objecttodsl(callinstance(this, ZipInputStream, "Test", dsltoobject(SymbolKind.Method, false, "ZipInputStream:Test", os), dsltoobject(SymbolKind.Method, false, "ZipInputStream:Test", os), dsltoobject(SymbolKind.Method, false, "ZipInputStream:Test", os))), ZipOutputStream, TypeKind.Class);
			local(intList); intList = newlist(IntList, typeargs(), typekinds(), "ctor", literallist(typeargs(), typekinds()));
			local(a); a = newexternlist(System.Collections.Generic.List_T, typeargs(System.Int32), typekinds(TypeKind.Struct), "ctor__Void", literallist(typeargs(System.Int32), typekinds(TypeKind.Struct)));
			local(aa); aa = newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, typeargs(System.String, UnityEngine.Component), typekinds(TypeKind.Class, TypeKind.Class), "ctor__Void", literaldictionary(typeargs(System.String, UnityEngine.Component), typekinds(TypeKind.Class, TypeKind.Class)));
			callextension(TestExtension, "Test", intList, UnityEngine.ParticleSystem, null);
			callexterninstance(intList, System.Collections.Generic.List_T, "AddRange", a);
			local(gobj); gobj = null;
			local(r); r = callexternstatic(UnityEngine.Object, "Instantiate__Object__Object", gobj);
			local(b); b = callinstance(this, ZipInputStream, "Test2", 124, newexternlist(System.Collections.Generic.List_T, typeargs(System.Int32), typekinds(TypeKind.Struct), "ctor__Void", literallist(typeargs(System.Int32), typekinds(TypeKind.Struct))));
			local(o); o = dsltoobject(SymbolKind.Local, false, "o", literalarray(System.Int32, TypeKind.Struct, 1, 2));
			local(arr); arr = typeas(objecttodsl(o), System.Array, TypeKind.Array);
			local(aa); aa = "123";
			local(bb); bb = "456";
			local(da); da = 1;
			local(db); db = 2;
			local(r); r = execbinary("==", aa, bb, System.Object, System.Object, TypeKind.Class, TypeKind.Class);
			r = execbinary("==", da, db, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct);
			local(ca); ca = getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "white");
			local(cb); cb = getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "black");
			r = invokeexternoperator(System.Boolean, UnityEngine.Color, "op_Equality", ca, cb);
			local(va);
			local(vb);
			multiassign(precode{
				},postcode{
					va = wrapexternstruct(va, UnityEngine.Vector3);
					vb = wrapexternstruct(vb, UnityEngine.Vector3);
				})varlist(va, vb) = callinstance(this, ZipInputStream, "Test3", __cs2dsl_out, __cs2dsl_out);
			return(this);
		}options[needfuncinfo(true)],
		Test = deffunc(1)args(this, o, ...){
			local(__method_ret_62_4_66_5);
			local(args); args = params(System.Object, TypeKind.Class);
			local(v3); v3 = newexternstruct(UnityEngine.Vector3, typeargs(), typekinds(), "ctor__Void__Single__Single__Single", null, 1, 2, 3);
			__method_ret_62_4_66_5 = null;
			return(__method_ret_62_4_66_5);
		}options[needfuncinfo(true)];
		Test2 = deffunc(1)args(this, v, enumer){
			local(__method_ret_67_4_79_5);
			local(__try_ret_69_8_77_9, __try_retval_69_8_77_9); multiassign(__try_ret_69_8_77_9, __try_retval_69_8_77_9) = dsltry(false, __try_ret_69_8_77_9){
				block{
				__method_ret_67_4_79_5 = execbinary("+", a, b, , , TypeKind.Error, TypeKind.Error);
				__try_retval_69_8_77_9 = 1;
				break;
				};
			};
			if(__try_ret_69_8_77_9){
				callexternstatic(UnityEngine.Debug, "Log__Void__Object", dslstrtocsstr("finally"));
				if(__try_retval_69_8_77_9){
				if(__try_retval_69_8_77_9==1){
					return(__method_ret_67_4_79_5);
				};
				};
			};
			local(__catch_handled_69_8_77_9, __catch_retval_69_8_77_9); __catch_handled_69_8_77_9 = false;
			__catch_retval_69_8_77_9 = dslcatch(__catch_handled_69_8_77_9, __try_retval_69_8_77_9, __try_ret_69_8_77_9,
				function(, e){
					__catch_handled_69_8_77_9 = true;
					callexternstatic(UnityEngine.Debug, "LogFormat__Void__String__A_Object", dslstrtocsstr("{0}\n{1}"), getexterninstance(SymbolKind.Property, e, System.Exception, "Message"), getexterninstance(SymbolKind.Property, e, System.Exception, "StackTrace"));
				}
			);
			if(! __try_ret_69_8_77_9){
				callexternstatic(UnityEngine.Debug, "Log__Void__Object", dslstrtocsstr("finally"));
			};
			__method_ret_67_4_79_5 = null;
			return(__method_ret_67_4_79_5);
		}options[needfuncinfo(false)];
		Test3 = deffunc(2)args(this, v1, v2){
			v1 = wrapoutexternstruct(v1, UnityEngine.Vector3);
			v2 = wrapoutexternstruct(v2, UnityEngine.Vector3);
			v1 = getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero");
			v2 = getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero");
			return(v1, v2);
		}options[needfuncinfo(true)];
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, ZipInputStream, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, ZipInputStream, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		Test(MethodKind.Ordinary, Accessibility.Private){
		};
		Test2(MethodKind.Ordinary, Accessibility.Private){
		};
		Test3(MethodKind.Ordinary, Accessibility.Private){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



