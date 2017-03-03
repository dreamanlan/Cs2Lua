require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";
require "LuaConsole";

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
					local sagatObjId; sagatObjId = typecast(args[1], CS.System.Int32, false);
					local protectObjId; protectObjId = typecast(args[2], CS.System.Int32, false);
					local attackObjId; attackObjId = typecast(args[3], CS.System.Int32, false);
				end;
				local t; t = this.gameObject:GetComponent(CS.UnityEngine.Transform);
				this.gameObject:SetActive(true);
				local r; r = this.gameObject.renderer;
				this.gameObject.active = true;
				local v; v = true;
				local s; s = invokeforbasicvalue(v, false, CS.System.Boolean, "ToString");
				local i; i = 123;
				local s; s = invokeforbasicvalue(i, false, CS.System.Int32, "ToString");
				local i; i = invokeforbasicvalue(s, false, CS.System.String, "IndexOf", wrapchar('2', 0x032));
				LuaConsole.Print(i);
				local i; i = getforbasicvalue(this.m_TestString, false, CS.System.String, "Length");
				local c; c = getexterninstanceindexer(this.m_TestString, nil, "get_Chars", 2);
				local equal; equal = (this.m_TestString == s);
				local a; a = wraparray{5, 4, 3, 2, 1};
				local ix; ix = invokearraystaticmethod(a, nil, "IndexOf", CS.System.Int32, a, 3);
			end,
			ctor = function(this)
			end,
		};

		local instance_fields_build = function()
			local instance_fields = {
				m_TestString = "13579",
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(CS.UnityEngine.MonoBehaviour, "TestUnity", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};

TestUnity.__define_class();
