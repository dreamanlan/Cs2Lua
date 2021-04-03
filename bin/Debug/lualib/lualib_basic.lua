---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--reference:https://github.com/yanghuan/CSharp.lua/blob/master/CSharp.lua/CoreSystem.Lua/CoreSystem/String.lua
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

local char = string.char
local rep = string.rep
local lower = string.lower
local upper = string.upper
local byte = string.byte
local sub = string.sub
local find = string.find
local gsub = string.gsub
local tconcat = table.concat

local function charsize(ch)
    if not ch then return 0
    elseif ch >=252 then return 6
    elseif ch >= 248 and ch < 252 then return 5
    elseif ch >= 240 and ch < 248 then return 4
    elseif ch >= 224 and ch < 240 then return 3
    elseif ch >= 192 and ch < 224 then return 2
    elseif ch < 192 then return 1
    end
end

-- 计算utf8字符串字符数, 各种字符都按一个字符计算
-- 例如utf8len("1你好") => 3
local function utf8len(str)
    local len = 0
    local aNum = 0 --字母个数
    local hNum = 0 --汉字个数
    local currentIndex = 1
    while currentIndex <= #str do
        local char = string.byte(str, currentIndex)
        local cs = charsize(char)
        currentIndex = currentIndex + cs
        len = len +1
        if cs == 1 then 
            aNum = aNum + 1
        elseif cs >= 2 then 
            hNum = hNum + 1
        end
    end
    return len, aNum, hNum
end

-- 截取utf8 字符串
-- str:            要截取的字符串
-- startChar:    开始字符下标,从1开始
-- numChars:    要截取的字符长度
local function utf8sub(str, startChar, numChars)
    local startIndex = 1
    while startChar > 1 do
        local char = string.byte(str, startIndex)
        startIndex = startIndex + charsize(char)
        startChar = startChar - 1
    end

    local currentIndex = startIndex

    while numChars > 0 and currentIndex <= #str do
        local char = string.byte(str, currentIndex)
        currentIndex = currentIndex + charsize(char)
        numChars = numChars -1
    end
    return string.sub(str, startIndex, currentIndex - 1)
end

local function escape(s)
    return gsub(s, "([%%%^%.])", "%%%1")
end

local function checkIndex(value, startIndex, count)
    local len = #value
    if not startIndex then
      startIndex, count = 0, len
    elseif not count then
      if startIndex < 0 or startIndex > len then
        error("startIndex out of range")
      end
      count = len - startIndex
    else
      if startIndex < 0 or startIndex > len then
        error("startIndex out of range")
      end
      if count < 0 or count > len - startIndex then
        error("count out of range")
      end
    end
    return startIndex, count, len
end

local function onlycheckIndex(value, startIndex)
    local len = #value
    if not startIndex then
        startIndex = 0
    else
        if startIndex < 0 or startIndex > len then
            error("startIndex out of range")
        end
    end
    return startIndex, len
end

local function compare(strA, strB, ignoreCase)
    if strA == nil then
      if strB == nil then
        return 0
      end
      return -1
    elseif strB == nil then
      return 1
    end
  
    if ignoreCase then
      strA, strB = lower(strA), lower(strB)
    end
  
    if strA < strB then return -1 end
    if strA > strB then return 1 end
    return 0
end

local function replace(this, a, b)
	a = csstrtoluastr(a)
	b = csstrtoluastr(b)
    if type(a) == "number" then
      a, b = char(a), char(b)
    end
    return gsub(this, escape(a), b)
end

local function split(this, strings, count, options) 
    local t = {}
    local find = find
    if type(strings) == "table" then
      if #strings == 0 then
        return wraparray(t)
      end
  
      if type(strings[1]) == "string" then
        find = findAny
      else
        strings = char(unpack(strings))
        strings = escape(strings)
        strings = "[" .. strings .. "]"
      end
    elseif type(strings) == "string" then       
      strings = escape(strings)         
    else
      strings = char(strings)
      strings = escape(strings)
    end
  
    local len = 1
    local startIndex = 1
    while true do
      local posBegin, posEnd = find(this, strings, startIndex)
      posBegin = posBegin or 0
      local subStr = sub(this, startIndex, posBegin -1)
      if options ~= 1 or #subStr > 0 then
        t[len] = subStr
        len = len + 1
        if count then
          count = count -1
          if count == 0 then
            if posBegin ~= 0 then
              t[len - 1] = sub(this, startIndex)
            end
            break
          end
        end
      end
      if posBegin == 0 then
        break
      end 
      startIndex = posEnd + 1
    end   
    return wraparray(t)
end

local function chechLastIndexOf(value, startIndex, count)
    local len = #value
    if not startIndex then
      startIndex, count = len - 1, len
    elseif not count then
      count = len == 0 and 0 or (startIndex + 1)
    end
    if len == 0 then
      if startIndex ~= -1 and startIndex ~= 0 then
        error("startIndex out of range")
      end
      if count ~= 0 then
        error("count out of range")
      end
    end
    if startIndex < 0 or startIndex >= len then
        error("startIndex out of range")
    end
    if count < 0 or startIndex - count + 1 < 0 then
        error("count out of range")
    end
    return startIndex, count, len
end
  
local function lastIndexOf(this, value, startIndex, count, comparisonType)
    startIndex, count = chechLastIndexOf(this, startIndex, count)
    if type(value) == "number" then value = char(value) end
    local ignoreCase = comparisonType and comparisonType % 2 ~= 0
    if ignoreCase then
      this, value = lower(this), lower(value)
    end
    value = escape(value)
    local e = startIndex + 1
    local f = e - count + 1
    local index = -1  
    while true do
      local i, j = find(this, value, f)
      if not i or j > e then
        break
      end
      index = i - 1
      f = j + 1
    end
    return index
end

local function indexOf(this, value, startIndex, count, comparisonType)
    startIndex, count = checkIndex(this, startIndex, count)
    if type(value) == "number" then value = char(value) end
    local ignoreCase = comparisonType and comparisonType % 2 ~= 0
    if ignoreCase then
      this, value = lower(this), lower(value)
    end
    local i, j = find(this, escape(value), startIndex + 1)
    if i then
      local e = startIndex + count
      if j <= e then
        return i - 1
      end
      return - 1
    end
    return -1
end
-- LuaSystemString[method](obj, ...)
LuaSystemString = {
    CompareTo__String = function (this, v)
        if v == nil then return 1 end
        v = csstrtoluastr(v)
        if type(v) ~= "string" then
            error("Arg must be string")
        end
        return compare(this, v)
    end,     -- 不确定是哪一种比较方式？忽略大小写？全字匹配？
    Contains = function (this, value)
        if value == nil then
            error("value is nil")
        end
        value = csstrtoluastr(value)
        return find(this, escape(value)) ~= nil
    end,
    EndsWith__String = function (this, suffix)
        suffix = csstrtoluastr(suffix)
        return suffix == "" or sub(this, -#suffix) == suffix
    end,
    Equals__String = function (this, v)
		v = csstrtoluastr(v)
        if type(v) == "string" then
          return this == v
        end
        return false
    end,
    IndexOf__Char = function (this, value)
		value = csstrtoluastr(value)
        return indexOf(this, value, 0, #this, 0)
    end,
    IndexOf__String = function (this, value)
		value = csstrtoluastr(value)
        return indexOf(this, value, 0, #this, 0)
    end,
    IndexOf__String__StringComparison = function (this, value, strComparison)
		value = csstrtoluastr(value)
        return indexOf(this, value, 0, #this, strComparison)
    end,
    Insert = function (this, startIndex, value)
		value = csstrtoluastr(value)
        if startIndex < 0 or startIndex > #this then error("startIndex out of range") end
        return sub(this, 1, startIndex) .. value .. sub(this, startIndex + 1)
    end,
    LastIndexOf__Char = function (this, value)
		value = csstrtoluastr(value)
        return lastIndexOf(this, value, #this-1, #this, 0)
    end,
    LastIndexOf__String = function (this, value)
		value = csstrtoluastr(value)
        return lastIndexOf(this, value, #this-1, #this, 0)
    end,
    LastIndexOf__String__StringComparison = function (this, value, strComparison)
		value = csstrtoluastr(value)
        return lastIndexOf(this, value, #this-1, #this, strComparison)
    end,
    PadLeft__Int32__Char = function (this, totalWidth, paddingChar) 
        local len = #this;
        if len >= totalWidth then
          return this
        else
          paddingChar = paddingChar or 0x20
          return rep(char(paddingChar), totalWidth - len) .. this
        end
    end,
    PadRight__Int32__Char = function (this, totalWidth, paddingChar) 
        local len = #this
        if len >= totalWidth then
          return this
        else
          paddingChar = paddingChar or 0x20
          return this .. rep(char(paddingChar), totalWidth - len)
        end
    end,
    Remove__Int32 = function (this, startIndex) 
        startIndex = onlycheckIndex(this, startIndex)
        return sub(this, 1, startIndex)
    end,
    Remove__Int32__Int32 = function (this, startIndex, count) 
        startIndex, count = checkIndex(this, startIndex, count)
        return sub(this, 1, startIndex) .. sub(this, startIndex + 1 + count)
    end,
    Replace__Char__Char = replace,
    Replace__String__String = replace,
    Split__A_Char = function (this, str)
		str = csstrtoluastr(str)
        return split(this, str, 0x7fffffff, 0)
    end,
    Split__A_Char__StringSplitOptions = function (this, str, options)
		str = csstrtoluastr(str)
        return split(this, str, 0x7fffffff, options)
    end,
    StartsWith__String = function (this, prefix)
        prefix = csstrtoluastr(prefix)
        return sub(this, 1, #prefix) == prefix
    end,
    Substring__Int32 = function (this, startIndex)
        startIndex, length = onlycheckIndex(this, startIndex)
        return utf8sub(this, startIndex + 1, length)
    end,
    Substring__Int32__Int32 = function (this, startIndex, count)
        startIndex, count = checkIndex(this, startIndex, count)
        return utf8sub(this, startIndex + 1, startIndex + count)
    end,
    ToCharArray = function (str, startIndex, count)
        startIndex, count = checkIndex(str, startIndex, count)
        local t = {}
        local len = 1
        for i = startIndex + 1, startIndex + count do
        t[len] = byte(str, i)
        len = len + 1
        end
        return wraparray(t)
    end,
    ToLower = lower,
    ToString = tostring,
    ToUpper = upper,
    Trim = function (this, chars, ...)
		chars = csstrtoluastr(chars)
        if not chars then
            chars = "^%s*(.-)%s*$"
          else
            if type(chars) == "table" then
              chars = char(unpack(chars))
            else
              chars = char(chars, ...)
            end
            chars = escape(chars)
            chars = "^[" .. chars .. "]*(.-)[" .. chars .. "]*$"
          end
          return (gsub(this, chars, "%1"))
    end,
    TrimEnd = function (this, chars, ...)
		chars = csstrtoluastr(chars)
        if not chars then
          chars = "(.-)%s*$"
        else
          if type(chars) == "table" then
            chars = char(unpack(chars))
          else
            chars = char(chars, ...)
          end
          chars = escape(chars)
          chars = "(.-)[" .. chars .. "]*$"
        end
        return (gsub(this, chars, "%1"))
    end,  
    TrimStart = function(this, chars, ...)
		chars = csstrtoluastr(chars)
        if not chars then
          chars = "^%s*(.-)"
        else
          if type(chars) == "table" then
            chars = char(unpack(chars))
          else
            chars = char(chars, ...)
          end
          chars = escape(chars)
          chars = "^[" .. chars .. "]*(.-)"
        end
        return (gsub(this, chars, "%1"))
    end,  

    -- local lengthFn = function (t) return #t end
    -- getLength = lengthFn
    -- getCount = lengthFn
    -- get = get
    GetProperty = function(obj, name)
        if name == "Length" then
            return utf8len(obj)
        elseif name == "Empty" then
            return ""
        end
    end,
    -- SetProperty = function(obj, name, val)
    -- end
}

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

ArrayStaticMethods = {
    IndexOf__Array__Object = function(firstArray ,secondArray, method, ...)
        local arg1 ,arg2 = ...
        return  firstArray:IndexOf(arg2)
    end,
    IndexOf =  function(firstArray ,secondArray, method, ...)
        local arg1 ,arg2 = ...
        return  firstArray:IndexOf(arg2)
    end,
    Sort =  function(firstArray ,secondArray, method, ...)
        local arg1 ,arg2 = ...
        return table.sort(
            firstArray,
            function(a, b)
                return arg2(a, b) < 0
            end
        )
    end,
    Reverse__Array = function(firstArray ,secondArray, method, ...)
        local arg1 ,arg2 = ...
        firstArray = table.sort(
            firstArray,
            function(a,b)
                return 1
            end
        )
        return nil
    end,
    Find = function(firstArray ,secondArray, method, ...)
        local arg1 ,arg2 = ...
        local ct = __get_array_count(arg1)
        for i = 1, ct do
            local v = rawget(arg1, i)
            if arg2(v) then
                return v
            end
        end
        return nil
    end,
    FindIndex = function(firstArray ,secondArray, method, ...)
        local arg1 ,arg2 = ...
        local ct = __get_array_count(arg1)
        for i = 1, ct do
            local v = rawget(arg1, i)
            if arg2(v) then
                return i-1
            end
        end
        return -1
    end,
    Copy__Array__Int32__Array__Int32__Int32 = function(firstArray ,secondArray, method, ...)
        local __,__,arg3 ,arg4, arg5 = ...
        local ct = __get_array_count(arg1)
        for i = arg2 + 1, arg2 + arg5 do
            local v = rawget(arg1, i)
            rawset(arg3 , arg4 + 1 , v)
            arg4 = arg4 + 1;
        end
        return nil
    end,
}

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
