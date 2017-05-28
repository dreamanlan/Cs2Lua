require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";
require "cs2lua__interfaces";
require "CUsingHelper";

TestUnity = {
	__new_object = function(...)
		return newobject(TestUnity, nil, nil, ...);
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
					local sagatObjId; sagatObjId = typecast(args[1], System.Int32, false);
					local protectObjId; protectObjId = typecast(args[2], System.Int32, false);
					local attackObjId; attackObjId = typecast(args[3], System.Int32, false);
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
				local i; i = getforbasicvalue(this.m_TestString, false, System.String, "Length");
				local c; c = getexterninstanceindexer(this.m_TestString, nil, "get_Chars", 2);
				local equal; equal = (this.m_TestString == s);
				local a; a = wraparray{5, 4, 3, 2, 1};
				local ix; ix = invokearraystaticmethod(a, nil, "IndexOf", System.Int32, a, 3);
				local f; f = delegationwrap(typecast(( (function(vv)
					LuaConsole.Print("test");
				end) ), System.Action_T, false));
				f(123);
				local isLoadingHeadIcon; isLoadingHeadIcon = false;
				local __compiler_using_103 = newobject(CUsingHelper, "ctor", nil, (function()
					isLoadingHeadIcon = true;
				end), (function()
					isLoadingHeadIcon = false;
				end));
				LuaConsole.Print("test");
				__compiler_using_103:Dispose();
				local v1s; v1s = newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "System.Collections.Generic.Dictionary_TKey_TValue", "ctor", {[1] = 2, [3] = 4, [5] = 6});
				local v2s; v2s = newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "System.Collections.Generic.Dictionary_TKey_TValue", "ctor", {[1] = 3, [5] = 4});
				local v0; v0 = LINQ.exec({{"from", (function() return v1s; end)}, {"let", (function(v1) return v1.Value; end)}, {"let", (function(v1, v3) return invokeforbasicvalue(invokeforbasicvalue(v3, false, System.Int32, "ToString"), false, System.String, "Split", wrapchar(' ', 0x020)); end)}, {"from", (function(v1, v3, v4) return ( LINQ.exec({{"from", (function() return v2s; end)}, {"select", (function(v2) return v2; end)}}) ); end)}, {"where", (function(v1, v3, v4, vvvv) return (not System.String.IsNullOrEmpty(v1:ToString())); end)}, {"select", (function(v1, v3, v4, vvvv) return v1:ToString(); end)}});
				local v5; v5 = LINQ.exec({{"from", (function() return v1s; end)}, {"join", (function(v1) return v2s; end), (function(v1, v2) return v1.Key; end), (function(v1, v2) return v2.Key; end)}, {"into"}, {"select", (function(v1, ttt0) return wrapdictionary{v1 = v1, v2 = ttt0:Count(System.Collections.Generic.KeyValuePair_TKey_TValue)}; end)}, {"continuation"}, {"groupby", (function(ttt) return ttt; end), (function(ttt) return ttt.v2; end)}});
				for vv in getiterator(v5) do
				end;
				local vs; vs = newexternlist(System.Collections.Generic.List_T, "System.Collections.Generic.List_T", "ctor", {3, 5, 9, 7, 6});
				local rs; rs = LINQ.exec({{"from", (function() return vs; end)}, {"from", (function(v) return wraparray{v, invokeintegeroperator(2, "+", v, 1, System.Int32, System.Int32), invokeintegeroperator(2, "+", v, 2, System.Int32, System.Int32), invokeintegeroperator(2, "+", v, 3, System.Int32, System.Int32)}; end)}, {"let", (function(v, vv) return invokeintegeroperator(2, "+", v, 1, System.Int32, System.Int32); end)}, {"where", (function(v, vv, v2) return (v > 1); end)}, {"let", (function(v, vv, v2) return invokeintegeroperator(2, "+", v2, 1, System.Int32, System.Int32); end)}, {"where", (function(v, vv, v2, v3) return (v > 4); end)}, {"where", (function(v, vv, v2, v3) return (v < 8); end)}, {"select", (function(v, vv, v2, v3) return wrapdictionary{v1 = v, v2 = v2, v3 = v3}; end)}});
				local s; s = "1232312321";
				local c; c = getexterninstanceindexer(s, nil, "get_Chars", 0);
				local arr; arr = (function() local arr = wraparray{}; local d0 = 2; for i0 = 1,d0 do arr[i0] = {}; local d1 = 3; for i1 = 1,d1 do arr[i0][i1] = {}; local d2 = 4; for i2 = 1,d2 do arr[i0][i1][i2] = 0; end; end; end; return arr; end)();
				local arr2; arr2 = (function() local arr = wraparray{}; local d0 = 8; for i0 = 1,d0 do arr[i0] = {}; local d1 = 8; for i1 = 1,d1 do arr[i0][i1] = {}; local d2 = 8; for i2 = 1,d2 do arr[i0][i1][i2] = defaultvalue(UnityEngine.Vector3, "UnityEngine.Vector3", true); end; end; end; return arr; end)();
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

		return defineclass(UnityEngine.MonoBehaviour, "TestUnity", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


TestUnity.ITest = {__cs2lua_defined = true, __type_name = "TestUnity.ITest", __interfaces = {}, __exist = function(k) return false; end};
TestUnity.ITest2 = {__cs2lua_defined = true, __type_name = "TestUnity.ITest2", __interfaces = {"TestUnity.ITest"}, __exist = function(k) return false; end};
TestUnity.ITest3 = {__cs2lua_defined = true, __type_name = "TestUnity.ITest3", __interfaces = {"TestUnity.ITest2", "TestUnity.ITest"}, __exist = function(k) return false; end};


TestUnity.TestInterface = {
	__new_object = function(...)
		return newobject(TestUnity.TestInterface, nil, nil, ...);
	end,
	__define_class = function()
		local static = TestUnity.TestInterface;

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
		local interfaces = {
			"TestUnity.ITest3",
			"TestUnity.ITest2",
			"TestUnity.ITest",
		};

		local interface_map = nil;

		return defineclass(nil, "TestUnity.TestInterface", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};



TestUnity.TestInterface.__define_class();
TestUnity.__define_class();
