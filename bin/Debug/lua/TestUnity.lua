require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";

TestUnity = {
	__new_object = function(...)
		return newobject(TestUnity, nil, {}, ...);
	end,
	__define_class = function()
		local static = TestUnity;

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
			Test = function(this, ...)
				local args = wraparray{...};
				if (args.Length >= 3) then
					local sagatObjId; sagatObjId = typecast(args[1], System.Int32);
					local protectObjId; protectObjId = typecast(args[2], System.Int32);
					local attackObjId; attackObjId = typecast(args[3], System.Int32);
				end;
				local t; t = this.gameObject:GetComponent(UnityEngine.Transform);
				this.gameObject:SetActive(true);
				local r; r = this.gameObject.renderer;
				this.gameObject.active = true;
				local v; v = true;
				local s; s = invokeforbasicvalue(v, false, System.Boolean, "ToString");
				local i; i = 123;
				local s; s = invokeforbasicvalue(i, false, System.Int32, "ToString");
				local i; i = invokeforbasicvalue(s, false, System.String, "IndexOf", wrapchar('2', 0x032));
				LuaConsole.Print(i);
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

		return defineclass(UnityEngine.MonoBehaviour, "TestUnity", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};

TestUnity.__define_class();
