require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";
require "ConvTest";

DelegateTest = {
	__new_object = function(...)
		return newobject(DelegateTest, nil, {}, ...);
	end,
	__define_class = function()
		local static = DelegateTest;

		local static_methods = {
			op_Implicit__DelegateTest = function(thisObj)
				return 0;
			end,
			op_Implicit__System_Int32 = function(v)
				return newobject(DelegateTest, "ctor", {});
			end,
			cctor = function()
			end,
		};

		local static_fields_build = function()
			local static_fields = {
			};
			return static_fields;
		end;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			get_Item = function(this, ix)
				return nil;
			end,
			set_Item = function(this, ix, value)
			end,
			get_ObjProp = function(this)
				return nil;
			end,
			set_ObjProp = function(this, value)
			end,
			NormalEnumerator = wrapenumerable(function(this)
				local obj; obj = nil;
				if (not invokeexternoperator(UnityEngine.Object, "op_Implicit", obj)) then
					return nil;
				end;
				wrapyield(0, false, false);
				this:Test2(invokeexternoperator(UnityEngine.Object, "op_Implicit", obj), invokeexternoperator(UnityEngine.Object, "op_Implicit", obj));
				wrapyield(1, false, false);
				local v1; v1 = invokeexternoperator(UnityEngine.Object, "op_Implicit", obj);
				local v2; v2 = invokeexternoperator(UnityEngine.Object, "op_Implicit", obj);
				local v3;
				v3 = invokeexternoperator(UnityEngine.Object, "op_Implicit", obj);
				local vv; vv = this:Test(invokeexternoperator(UnityEngine.Object, "op_Implicit", obj));
				local v4; v4 = 0;
				v4 = (v4 + typecast(typecast(invokeexternoperator(UnityEngine.Object, "op_Implicit", obj), System.Object, false), System.Int32, false));
				return nil;
			end),
			Test = function(this, v)
				delegationset(this, nil, "Fading", (function() return this:NormalEnumerator(); end));
				this:StartCoroutine(this.Fading());
				local obj; obj = nil;
				local v0; v0 = condexp(invokeexternoperator(UnityEngine.Object, "op_Implicit", ( obj )), true, 1, true, 0);
				local f0; f0 = delegationwrap((function(vv) return invokeexternoperator(UnityEngine.Object, "op_Implicit", obj); end));
				local f; f = delegationwrap((function(vv) return invokeexternoperator(UnityEngine.Object, "op_Implicit", obj); end));
				local td; td = delegationwrap((function(a, b, c) local __compiler_lambda_134 = ((a + ( (function() b = 2; return b; end)() )) + ( (function() c = 1; return c; end)() )); return __compiler_lambda_134, b, c; end));
				if invokeexternoperator(UnityEngine.Object, "op_Implicit", obj) then
					this:Test2(true, false);
				end;
				repeat
				until not (invokeexternoperator(UnityEngine.Object, "op_Implicit", obj));
				while invokeexternoperator(UnityEngine.Object, "op_Implicit", obj) do
				end;
				while invokeexternoperator(UnityEngine.Object, "op_Implicit", obj) do
				end;
				local ct; ct = newobject(ConvTest, "ctor", {(function() m_Val = DelegateTest.op_Implicit__DelegateTest(newobject(DelegateTest, "ctor", {})); return m_Val; end)()});
				return invokeexternoperator(UnityEngine.Object, "op_Implicit", obj);
			end,
			Test2 = function(this, v1, v2)
				if (v1 or v2) then
					UnityEngine.Debug.Log(v1);
					UnityEngine.Debug.Log(v2);
				end;
				local tc; tc = newobject(ConvTest, "ctor", {});
				local vv; vv = invokeexternoperator(UnityEngine.Object, "op_Implicit", tc:TestConv(1, DelegateTest.op_Implicit__DelegateTest(this)));
				local vv2;
				vv2 = invokeexternoperator(UnityEngine.Object, "op_Implicit", tc:TestConv(1, 2));
				local r;
				local vv3; vv3 = invokeexternoperator(UnityEngine.Object, "op_Implicit", (function() local __compiler_localdecl_160; __compiler_localdecl_160, r = tc:TestConv2(1, DelegateTest.op_Implicit__DelegateTest(this), __cs2lua_out); return __compiler_localdecl_160; end)());
				local vv4;
				vv4 = invokeexternoperator(UnityEngine.Object, "op_Implicit", (function() local __compiler_assigninvoke_162; __compiler_assigninvoke_162, r = tc:TestConv2(2, DelegateTest.op_Implicit__DelegateTest(this), __cs2lua_out); return __compiler_assigninvoke_162; end)());
				local vv5;
				vv5 = DelegateTest.op_Implicit__DelegateTest((function() local __compiler_assigninvoke_164; __compiler_assigninvoke_164, r = tc:TestConv3(3, DelegateTest.op_Implicit__DelegateTest(this), __cs2lua_out); return __compiler_assigninvoke_164; end)());
				tc.Prop = 123;
				local vvv; vvv = tc.Prop;
				this:Test(invokeexternoperator(UnityEngine.Object, "op_Implicit", tc:TestConv(DelegateTest.op_Implicit__DelegateTest(this), 2)));
				local arr; arr = wraparray{nil};
				this:Test(invokeexternoperator(UnityEngine.Object, "op_Implicit", arr[1]));
				this:Test(invokeexternoperator(UnityEngine.Object, "op_Implicit", this.ObjProp));
				this:Test(invokeexternoperator(UnityEngine.Object, "op_Implicit", getinstanceindexer(this, nil, "get_Item", 0)));
			end,
			ctor = function(this)
			end,
		};

		local instance_fields_build = function()
			local instance_fields = {
				Fading = wrapdelegation{},
			};
			return instance_fields;
		end;

		local instance_props = {
			ObjProp = {
				get = instance_methods.get_ObjProp,
				set = instance_methods.set_ObjProp,
			},
		};

		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(UnityEngine.MonoBehaviour, "DelegateTest", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};

DelegateTest.__define_class();
