require "cs2lua__utility";
require "cs2lua__namespaces";

UIDemo.UICommon = {
	CreateCustomComponent = function(T, strName, pParent)
		local pObj; pObj = newexternobject(UnityEngine.GameObject, "UnityEngine.GameObject", "ctor", (function(obj) UnityEngine.GameObject.__install_TopLevel_SecondLevel_FooExtension(obj); end), {}, strName);
		if (pObj ~= nil) then
			if (pParent ~= nil) then
				pObj.transform.parent = pParent;
			end;
			return pObj:AddComponent(UIDemo.UICommon.T);
		else
			UnityEngine.Debug.LogError(System.String.Concat(wrapstring("Error! NULL="), T:ToString()));
		end;
		return nil;
	end,
	cctor = function()
	end,

	__new_object = function(...)
		return newobject(UIDemo.UICommon, nil, {}, ...);
	end,
	__define_class = function()
		local static = UIDemo.UICommon;
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			ctor = function(this)
			end,
		};

		local instance_build = function()
			local instance_fields = {
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "UIDemo.UICommon", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


UIDemo.UICommon.__define_class();

