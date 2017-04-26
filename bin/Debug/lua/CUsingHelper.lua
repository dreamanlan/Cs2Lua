require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";
require "ZipInputStream";
require "ZipOutputStream";

CUsingHelper = {
	__new_object = function(...)
		return newobject(CUsingHelper, "ctor", nil, ...);
	end,
	__define_class = function()
		local static = CUsingHelper;

		local static_methods = {
			ReadZip = function(bytes)
				local zipInput; zipInput = newobject(ZipInputStream, "ctor", nil, newexternobject(System.IO.MemoryStream, "System.IO.MemoryStream", "ctor", nil, bytes));
				local zipMemory; zipMemory = newexternobject(System.IO.MemoryStream, "System.IO.MemoryStream", "ctor", nil);
				local ZipStream; ZipStream = newobject(ZipOutputStream, "ctor", nil, zipMemory);
				do
					return nil;
				end;
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
			ctor = function(this, a1, a2)
				return this;
			end,
			Dispose = function(this)
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
			"System.IDisposable",
		};

		local interface_map = {
			IDisposable_Dispose = "Dispose",
		};


		return defineclass(nil, "CUsingHelper", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};

CUsingHelper.__define_class();
