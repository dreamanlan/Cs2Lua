require "cs2lua__utility";
require "cs2lua__namespaces";

TopLevel.Singleton_T = {
	get_instance = function(T)
		if (TopLevel.Singleton_T.ms_instance == nil) then
			TopLevel.Singleton_T.ms_instance = newtypeparamobject(T);
		end;
		return TopLevel.Singleton_T.ms_instance;
	end,
	set_instance = function(value)
	end,
	Delete = function()
		TopLevel.Singleton_T.ms_instance = nil;
	end,
	cctor = function()
	end,

	__new_object = function(...)
		return newobject(TopLevel.Singleton_T, "ctor", {}, ...);
	end,
	__define_class = function()
		local static = TopLevel.Singleton_T;
		local static_fields = {
			ms_instance = true,
		};

		local static_props = {
			instance = {
				get = static.get_instance,
				set = static.set_instance,
			},
		};

		local static_events = nil;

		local instance_methods = {
			ctor = function(this, T)
				if (TopLevel.Singleton_T.ms_instance ~= nil) then
					UnityEngine.Debug.LogError(wrapstring("Cannot have two instances in singleton"));
					return this;
				end;
				TopLevel.Singleton_T.ms_instance = typecast(typecast(this, System.Object), T);
				return this;
			end,
		};

		local instance_build = function()
			local instance_fields = {
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local instance_interfaces = nil;
		local instance_interface_map = nil;

		return defineclass(nil, "TopLevel.Singleton_T", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, instance_interfaces, instance_interface_map, false);
	end,
};


TopLevel.Singleton_T.__define_class();

