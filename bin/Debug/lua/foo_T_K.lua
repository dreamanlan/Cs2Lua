require "cs2lua__utility";
require "cs2lua__namespaces";

foo_T_K = {
	cctor = function()
	end,

	__new_object = function(...)
		return newobject(foo_T_K, nil, {}, ...);
	end,
	__define_class = function()
		local static = foo_T_K;
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			parse = function(this, a, b)
				local t; t = this.__type_params[1];
				local k; k = this.__type_params[2];
			end,
			ctor = function(this, T, K)
				this:__ctor(T, K);
			end,
			__ctor = function(this, T, K)
				if this.__ctor_called then
					return;
				else
					this.__ctor_called = true;
				end
				this.__type_params = {T, K};
			end,
		};

		local instance_build = function()
			local instance_fields = {
				__ctor_called = false,
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "foo_T_K", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


foo_T_K.__define_class();

