require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";

DelegateTest = {
	__new_object = function(...)
		return newobject(DelegateTest, nil, {}, ...);
	end,
	__define_class = function()
		local static = DelegateTest;

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
			NormalEnumerator = wrapenumerable(function(this)
				wrapyield(0, false, false);
				wrapyield(1, false, false);
				return nil;
			end),
			Test = function(this)
				delegationset(this, nil, "Fading", (function() return this:NormalEnumerator(); end));
				return this:StartCoroutine(this.Fading());
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
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(UnityEngine.MonoBehaviour, "DelegateTest", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};

DelegateTest.__define_class();
