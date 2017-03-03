require "cs2lua__utility";
require "cs2lua__attributes";
require "cs2lua__namespaces";
require "cs2lua__externenums";
require "DelegateTest";

ConvTest = {
	__new_object = function(...)
		return newobject(ConvTest, nil, {}, ...);
	end,
	__define_class = function()
		local static = ConvTest;

		local static_methods = {
			cctor = function()
			end,
		};

		local static_fields_build = function()
			local static_fields = {
				__attributes = ConvTest__Attrs,
			};
			return static_fields;
		end;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			get_Item = function(this, ix)
				return 0;
			end,
			set_Item = function(this, ix, value)
			end,
			get_Prop = function(this)
				return this.m_Val;
			end,
			set_Prop = function(this, value)
				this.m_Val = value;
			end,
			TestConv = function(this, a, b)
				local arr; arr = wraparray{};
				local dt; dt = newobject(DelegateTest, "ctor", {});
				this.Prop = DelegateTest.op_Implicit__DelegateTest(dt);
				setinstanceindexer(this, nil, "set_Item", 0, DelegateTest.op_Implicit__DelegateTest(dt));
				arr[1] = DelegateTest.op_Implicit__DelegateTest(dt);
				local v; v = DelegateTest.op_Implicit__CS_System_Int32(this.Prop);
				local v2; v2 = DelegateTest.op_Implicit__CS_System_Int32(getinstanceindexer(this, nil, "get_Item", 0));
				local v3; v3 = DelegateTest.op_Implicit__CS_System_Int32(arr[1]);
				local vv;
				local vv2;
				local vv3;
				vv = DelegateTest.op_Implicit__CS_System_Int32(this.Prop);
				vv2 = DelegateTest.op_Implicit__CS_System_Int32(getinstanceindexer(this, nil, "get_Item", 0));
				vv3 = DelegateTest.op_Implicit__CS_System_Int32(arr[1]);
				local v4; v4 = DelegateTest.op_Implicit__CS_System_Int32(arr[1]);
				local arr2; arr2 = nil;
				v4 = DelegateTest.op_Implicit__CS_System_Int32(condaccess(arr2, (function() return arr2[1]; end)));
				local vv4; vv4 = DelegateTest.op_Implicit__CS_System_Int32(condaccess(arr2, (function() return arr2[1]; end)));
				local ct; ct = nil;
				dt = DelegateTest.op_Implicit__CS_System_Int32(condaccess(ct, (function() return ct.Prop; end)));
				dt = DelegateTest.op_Implicit__CS_System_Int32(condaccess(ct, (function() return getinstanceindexer(ct, nil, "get_Item", 0); end)));
				local v5; v5 = DelegateTest.op_Implicit__CS_System_Int32(condaccess(ct, (function() return getinstanceindexer(ct, nil, "get_Item", 0); end)));
				local vv5;
				vv5 = DelegateTest.op_Implicit__CS_System_Int32(condaccess(ct, (function() return getinstanceindexer(ct, nil, "get_Item", 0); end)));
				return nil;
			end,
			TestConv2 = function(this, a, b, c)
				local obj; obj = nil;
				local arr; arr = wraparray{invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj), invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj), invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj)};
				local dict; dict = newexterndictionary(CS.System.Collections.Generic.Dictionary_TKey_TValue, "CS.System.Collections.Generic.Dictionary_TKey_TValue", "ctor", {[tostring("1")] = invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj), [tostring("2")] = invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj)});
				local list; list = newexternlist(CS.System.Collections.Generic.List_T, "CS.System.Collections.Generic.List_T", "ctor", {invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj), invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj), invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj)});
				local tarr;
				tarr = wraparray{invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj), invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj), invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj)};
				local tdict;
				tdict = newexterndictionary(CS.System.Collections.Generic.Dictionary_TKey_TValue, "CS.System.Collections.Generic.Dictionary_TKey_TValue", "ctor", {[tostring("1")] = invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj), [tostring("2")] = invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj)});
				local tlist;
				tlist = newexternlist(CS.System.Collections.Generic.List_T, "CS.System.Collections.Generic.List_T", "ctor", {invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj), invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj), invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", obj)});
				local f; f = newexternlist(CS.System.Collections.Generic.List_T, "CS.System.Collections.Generic.List_T", "ctor", {{obj, obj}, {obj, obj}});
				c = 1;
				c = invokeintegeroperator(0, "/", c, 2, CS.System.Int32, CS.System.Int32);
				c = invokeintegeroperator(0, "/", c, 2, CS.System.Int32, CS.System.Int32);
				c = invokeintegeroperator(1, "%", c, 2, CS.System.Int32, CS.System.Int32);
				c = invokeintegeroperator(1, "%", c, 2, CS.System.Int32, CS.System.Int32);
				c = invokeintegeroperator(3, "-", c, 1, CS.System.Int32, CS.System.Int32);
				c = invokeintegeroperator(3, "-", c, 1, CS.System.Int32, CS.System.Int32);
				local d; d = invokeintegeroperator(12, "~", nil, c, nil, CS.System.Int32);
				local cc; cc = ( (function() c = invokeintegeroperator(3, "-", c, 1, CS.System.Int32, CS.System.Int32); return c; end)() );
				cc = ( c );
				c = invokeintegeroperator(3, "-", c, 1, CS.System.Int32, CS.System.Int32);
				return nil, c;
			end,
			TestConv3 = function(this, a, b, c)
				c = 1;
				return nil, c;
			end,
			TestConv4 = function(this, v, v2)
				local __compiler_expbody_88 = ((( (function() v2 = 1; return v2; end)() ) == 1) and invokeexternoperator(CS.UnityEngine.Object, "op_Implicit", newexternobject(CS.UnityEngine.GameObject, "CS.UnityEngine.GameObject", "ctor", {}))); return __compiler_expbody_88, v2;
			end,
			ctor = function(this)
			end,
		};

		local instance_fields_build = function()
			local instance_fields = {
				OnHandleValue = wrapdelegation{},
				OnHandle = delegationwrap(this.OnHandleValue),
				m_Val = DelegateTest.op_Implicit__DelegateTest(newobject(DelegateTest, "ctor", {})),
				__attributes = ConvTest__Attrs,
			};
			return instance_fields;
		end;

		local instance_props = {
			Prop = {
				get = instance_methods.get_Prop,
				set = instance_methods.set_Prop,
			},
		};

		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "ConvTest", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};

ConvTest.__define_class();
