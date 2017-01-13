require "cs2lua__utility";
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
				local v; v = DelegateTest.op_Implicit__System_Int32(this.Prop);
				local v2; v2 = DelegateTest.op_Implicit__System_Int32(getinstanceindexer(this, nil, "get_Item", 0));
				local v3; v3 = DelegateTest.op_Implicit__System_Int32(arr[1]);
				local vv;
				local vv2;
				local vv3;
				vv = DelegateTest.op_Implicit__System_Int32(this.Prop);
				vv2 = DelegateTest.op_Implicit__System_Int32(getinstanceindexer(this, nil, "get_Item", 0));
				vv3 = DelegateTest.op_Implicit__System_Int32(arr[1]);
				local v4; v4 = DelegateTest.op_Implicit__System_Int32(arr[1]);
				local arr2; arr2 = nil;
				v4 = DelegateTest.op_Implicit__System_Int32(condaccess(arr2, (function() return arr2[1]; end)));
				local vv4; vv4 = DelegateTest.op_Implicit__System_Int32(condaccess(arr2, (function() return arr2[1]; end)));
				local ct; ct = nil;
				dt = DelegateTest.op_Implicit__System_Int32(condaccess(ct, (function() return ct.Prop; end)));
				dt = DelegateTest.op_Implicit__System_Int32(condaccess(ct, (function() return getinstanceindexer(ct, nil, "get_Item", 0); end)));
				local v5; v5 = DelegateTest.op_Implicit__System_Int32(condaccess(ct, (function() return getinstanceindexer(ct, nil, "get_Item", 0); end)));
				local vv5;
				vv5 = DelegateTest.op_Implicit__System_Int32(condaccess(ct, (function() return getinstanceindexer(ct, nil, "get_Item", 0); end)));
				return nil;
			end,
			TestConv2 = function(this, a, b, c)
				c = 1;
				return nil, c;
			end,
			TestConv3 = function(this, a, b, c)
				c = 1;
				return nil, c;
			end,
			ctor = function(this)
			end,
		};

		local instance_fields_build = function()
			local instance_fields = {
				m_Val = 0,
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
