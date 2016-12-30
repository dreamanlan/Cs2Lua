require "cs2lua__utility";
require "cs2lua__namespaces";

TopLevel.Singleton_Foo = {
	__new_object = function(...)
		return newobject(TopLevel.Singleton_Foo, "ctor", {}, ...);
	end,
	__define_class = function()
		local static = TopLevel.Singleton_Foo;

		local static_methods = {
			get_instance = function()
				if (ms_instance == nil) then
					ms_instance = newtypeparamobject(Foo);
				end;
				return ms_instance;
			end,
			set_instance = function(value)
			end,
			Delete = function()
				ms_instance = nil;
			end,
			cctor = function()
			end,
		};

		local static_fields_build = function()
			local static_fields = {
				ms_instance = false,
			};
			return static_fields;
		end;

		local static_props = {
			instance = {
				get = static_methods.get_instance,
				set = static_methods.set_instance,
			},
		};

		local static_events = nil;

		local instance_methods = {
			ctor = function(this)
				if (ms_instance ~= nil) then
					UnityEngine.Debug.LogError(wrapstring("Cannot have two instances in singleton"));
					return this;
				end;
				ms_instance = typecast(typecast(this, System.Object), Foo);
				return this;
			end,
		};

		local instance_fields_build = function()
			local instance_fields = {
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "TopLevel.Singleton_Foo", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


TopLevel.Singleton_Foo.__define_class();

