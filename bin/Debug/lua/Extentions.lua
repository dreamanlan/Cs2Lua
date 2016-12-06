require "cs2lua__utility";
require "cs2lua__namespaces";

Extentions = {
	timeInMillisecond = function(dateTime)
		return (dateTime.Ticks / 10000);
	end,
	timeSince1970 = function(dateTime)
		return typecast(( (dateTime:timeSince1970InMillisecond() / 1000) ), System.Int64);
	end,
	timeSince1970InMillisecond = function(dateTime)
--return (long)(Time.realtimeSinceStartup * 1000);
		if (Extentions.dateTime1970.Ticks == 0) then
--Debug.LogError("Ticks = 0");
			Extentions.dateTime1970 = System.DateTime.Parse(wrapstring("1970-1-1"));
		end;
		local ts; ts = (dateTime - Extentions.dateTime1970);
		return typecast(ts.TotalMilliseconds, System.Int64);
	end,
	findChildRecursively = function(transform, childName, maxDepth)
		local child; child = transform:FindChild(childName);
		if ((child == nil) and (maxDepth > 0)) then
			local childCount; childCount = transform.childCount;
			local i; i = 0;
			while (i < childCount) do
				child = transform:GetChild(i):findChildRecursively(childName, (maxDepth - 1));
				if (child ~= nil) then
					break;
				end;
				do
				break;
				end;
			i = i + 1;
			end;
		end;
		return child;
	end,
	searchChildRecursively = function(transform, childName, maxDepth)
		if (transform.name:IndexOf(childName) ~= -1) then
			return transform;
		end;
		local count; count = transform.childCount;
		if (maxDepth > 0) then
			local i; i = 0;
			while (i < count) do
				local nowNode; nowNode = transform:GetChild(i);
				local searchRes; searchRes = Extentions.searchChildRecursively(nowNode, childName, (maxDepth - 1));
				if (searchRes ~= nil) then
					return searchRes;
				end;
			i = i + 1;
			end;
		end;
		return nil;
	end,
	isFirstTimeToStart = function()
		local isFirstTimeStart; isFirstTimeStart = UnityEngine.PlayerPrefs.GetInt(wrapstring("isFirstTimeToStart"), 1);
		return (isFirstTimeStart == 1);
	end,
	AddSorted = function(T, list, item)
		if (list.Count == 0) then
			list:Add(item);
			return ;
		end;
		if (getexterninstanceindexer(list, nil, "get_Item", (list.Count - 1)):CompareTo(item) <= 0) then
			list:Add(item);
			return ;
		end;
		if (getexterninstanceindexer(list, nil, "get_Item", 0):CompareTo(item) >= 0) then
			list:Insert(0, item);
			return ;
		end;
		local index; index = list:BinarySearch(item);
		if (index < 0) then
			index = bitnot(index);
		end;
		list:Insert(index, item);
	end,
	cctor = function()
	end,

	__define_class = function()
		rawset(System.DateTime, "__install_Extentions", (function(obj)
			rawset(obj, "timeInMillisecond", Extentions.timeInMillisecond);
			rawset(obj, "timeSince1970", Extentions.timeSince1970);
			rawset(obj, "timeSince1970InMillisecond", Extentions.timeSince1970InMillisecond);
		end));
		rawset(UnityEngine.Transform, "__install_Extentions", (function(obj)
			rawset(obj, "findChildRecursively", Extentions.findChildRecursively);
			rawset(obj, "searchChildRecursively", Extentions.searchChildRecursively);
		end));
		rawset(System.Collections.Generic.List_T, "__install_Extentions", (function(obj)
			rawset(obj, "AddSorted", Extentions.AddSorted);
		end));
		local static = Extentions;
		local static_fields = {
			dateTime1970 = true,
		};
		local static_props = nil;
		local static_events = nil;

		return defineclass(nil, "Extentions", static, static_fields, static_props, static_events, nil, nil, nil, nil, nil, nil, false);
	end,
};


Extentions.__define_class();

