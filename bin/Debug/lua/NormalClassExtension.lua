require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";
require "NormalClass";

NormalClassExtension = {
	__define_class = function()
		local static = NormalClassExtension;

		local static_methods = {
			TestExtension__NormalClass = function(obj)
			end,
			TestExtension__NormalClass__System_Int32 = function(obj, a)
			end,
			TestExtension2__INormal = function(obj)
			end,
			TestExtension2__INormal__System_Int32__System_Int32 = function(obj, a, b)
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

		return defineclass(nil, "NormalClassExtension", static, static_methods, static_fields_build, static_props, static_events, nil, nil, nil, nil, nil, nil, false);
	end,
};

NormalClassExtension.__define_class();
