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
				local obj; obj = nil;
				if (not invokeexternoperator(UnityEngine.Object, "op_Implicit", obj)) then
					return nil;
				end;
				wrapyield(0, false, false);
				this:Test2(invokeexternoperator(UnityEngine.Object, "op_Implicit", obj), invokeexternoperator(UnityEngine.Object, "op_Implicit", obj));
				wrapyield(1, false, false);
				local v1; v1 = invokeexternoperator(UnityEngine.Object, "op_Implicit", obj);
				local v2; v2 = invokeexternoperator(UnityEngine.Object, "op_Implicit", obj);
				local v3;
				v3 = invokeexternoperator(UnityEngine.Object, "op_Implicit", obj);
				local v4; v4 = 0;
				v4 = (v4 + typecast(invokeexternoperator(UnityEngine.Object, "op_Implicit", obj), System.Int32, false));
				return nil;
			end),
			Test = function(this)
				delegationset(this, nil, "Fading", (function() return this:NormalEnumerator(); end));
				this:StartCoroutine(this.Fading());
				local obj; obj = nil;
				local f; f = delegationwrap((function(v) return invokeexternoperator(UnityEngine.Object, "op_Implicit", obj); end));
				if invokeexternoperator(UnityEngine.Object, "op_Implicit", obj) then
					this:Test2(true, false);
				end;
				repeat
				until not (invokeexternoperator(UnityEngine.Object, "op_Implicit", obj));
				while invokeexternoperator(UnityEngine.Object, "op_Implicit", obj) do
				end;
				while invokeexternoperator(UnityEngine.Object, "op_Implicit", obj) do
				end;
				return invokeexternoperator(UnityEngine.Object, "op_Implicit", obj);
			end,
			Test2 = function(this, v1, v2)
				if (v1 or v2) then
					UnityEngine.Debug.Log(v1);
					UnityEngine.Debug.Log(v2);
				end;
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
