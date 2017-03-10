require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";

Entry = {
	__new_object = function(...)
		return newobject(Entry, "ctor", {}, ...);
	end,
	__define_class = function()
		local static = Entry;

		local static_methods = {
			Main = function()
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
			ctor = function(this, v)
				this.m_Value = v; return this;
			end,
			get_Item__CS_System_Int32 = function(this, ix)
				return this.m_Value;
			end,
			get_Item__CS_System_Int32__CS_System_Int32 = function(this, ix1, ix2)
				return this.m_Value;
			end,
			set_Item = function(this, ix1, ix2, value)
				this.m_Value = value;
			end,
			get_Item__CS_System_Single = wrapenumerable(function(this, ix)
				wrapyield(nil, false, false);
			end),
			get_Val = function(this)
				return this.m_Value;
			end,
			set_Val = function(this, value)
				this.m_Value = value;
			end,
			get_Val3 = function(this)
				return this.m_Value;
			end,
			get_Val4 = wrapenumerable(function(this)
				wrapyield(nil, false, false);
			end),
			Test = function(this, v)
				v = 123;
				return true, v;
			end,
		};

		local instance_fields_build = function()
			local instance_fields = {
				Val2 = 4,
				m_Value = 0,
			};
			return instance_fields;
		end;

		local instance_props = {
			Val = {
				get = instance_methods.get_Val,
				set = instance_methods.set_Val,
			},
			Val3 = {
				get = instance_methods.get_Val3,
			},
			Val4 = {
				get = instance_methods.get_Val4,
			},
		};

		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "Entry", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};
--Entry.Main();

Entry.__define_class();
