require "cs2lua__utility";
require "cs2lua__namespaces";

UIDemo.UICommon_CT = {
	StaticCreateCustomComponent = function(T, CT, strName, pParent)
		local pObj; pObj = newexternobject(UnityEngine.GameObject, "UnityEngine.GameObject", "ctor", (function(obj) UnityEngine.GameObject.__install_TopLevel_SecondLevel_FooExtension(obj); end), {}, strName);
		if (pObj ~= nil) then
			if (pParent ~= nil) then
				pObj.transform.parent = pParent;
			end;
			pObj:AddComponent(CT);
			return pObj:AddComponent(T);
		else
			UnityEngine.Debug.LogError(System.String.Concat(wrapstring("Error! NULL="), T:ToString()));
		end;
		return nil;
	end,
	cctor = function()
	end,

	__new_object = function(...)
		return newobject(UIDemo.UICommon_CT, nil, {}, ...);
	end,
	__define_class = function()
		local static = UIDemo.UICommon_CT;
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			CreateCustomComponent = function(this, T, strName, pParent)
				local pObj; pObj = newexternobject(UnityEngine.GameObject, "UnityEngine.GameObject", "ctor", (function(obj) UnityEngine.GameObject.__install_TopLevel_SecondLevel_FooExtension(obj); end), {}, strName);
				if (pObj ~= nil) then
					if (pParent ~= nil) then
						pObj.transform.parent = pParent;
					end;
					pObj:AddComponent(this.__type_params[1]);
					return pObj:AddComponent(T);
				else
					UnityEngine.Debug.LogError(System.String.Concat(wrapstring("Error! NULL="), T:ToString()));
				end;
				return nil;
			end,
			ctor = function(this, CT)
				this:__ctor(CT);
			end,
			__ctor = function(this, CT)
				if this.__ctor_called then
					return;
				else
					this.__ctor_called = true;
				end
				this.__type_params = {CT};
			end,
		};

		local instance_build = function()
			local instance_fields = {
				__ctor_called = false,
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "UIDemo.UICommon_CT", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


UIDemo.UICommon_CT.__define_class();

