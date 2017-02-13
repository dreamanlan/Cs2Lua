require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";
require "NormalClassExtension";

TestClass = {
	__new_object = function(...)
		return newobject(TestClass, nil, {}, ...);
	end,
	__define_class = function()
		local static = TestClass;

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
			Test = function(this, obj)
				NormalClassExtension.TestExtension__NormalClass(obj);
				NormalClassExtension.TestExtension2__INormal(obj);
				obj:TestExtension__System_Int32(123);
				local o; o = obj;
				NormalClassExtension.TestExtension2__INormal(o);
			end,
			ctor = function(this)
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

		return defineclass(nil, "TestClass", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};

TestClass.__define_class();
