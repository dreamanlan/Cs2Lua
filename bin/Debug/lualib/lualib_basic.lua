---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- reference:https://github.com/yanghuan/CSharp.lua/blob/master/CSharp.lua/CoreSystem.Lua/CoreSystem/String.lua
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

local function utf8charsize(ch)
    if not ch then
        return 0
    elseif ch >= 252 then
        return 6
    elseif ch >= 248 and ch < 252 then
        return 5
    elseif ch >= 240 and ch < 248 then
        return 4
    elseif ch >= 224 and ch < 240 then
        return 3
    elseif ch >= 192 and ch < 224 then
        return 2
    elseif ch < 192 then
        return 1
    end
end

-- 计算utf8字符串字符数, 各种字符都按一个字符计算
-- 例如utf8len("1你好") => 3
local function utf8len(str, byteStart, numBytes)
    local len = 0
    local aNum = 0 --字母个数
    local hNum = 0 --汉字个数
    local currentIndex = 1
    if byteStart ~= nil then
        currentIndex = byteStart
    end
    local endIx = #str
    if numBytes ~= nil then
        endIx = currentIndex + numBytes - 1
    end
    while currentIndex <= endIx do
        local char = byte(str, currentIndex)
        local cs = utf8charsize(char)
        currentIndex = currentIndex + cs
        len = len + 1
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
        local char = byte(str, startIndex)
        startIndex = startIndex + utf8charsize(char)
        startChar = startChar - 1
    end

    local currentIndex = startIndex

    while numChars > 0 and currentIndex <= #str do
        local char = byte(str, currentIndex)
        currentIndex = currentIndex + utf8charsize(char)
        numChars = numChars - 1
    end
    return sub(str, startIndex, currentIndex - 1)
end

local function utf8CharIndexToByteIndex(str, charIndex)
    local byteIndex = 1
    while charIndex > 1 do
        local char = byte(str, byteIndex)
        byteIndex = byteIndex + utf8charsize(char)
        charIndex = charIndex - 1
    end
    return byteIndex
end

local function utf8CharIndexCountToByteIndexCount(str, charIndex, numChars)
    local byteIndex = 1
    while charIndex > 1 do
        local char = byte(str, byteIndex)
        byteIndex = byteIndex + utf8charsize(char)
        charIndex = charIndex - 1
    end

    local currentIndex = byteIndex
    if numChars == nil then
        numChars = #str
    end

    while numChars > 0 and currentIndex <= #str do
        local char = byte(str, currentIndex)
        currentIndex = currentIndex + utf8charsize(char)
        numChars = numChars - 1
    end
    return byteIndex, currentIndex - byteIndex
end

local function getUtf8Char(str, charIndex)
    local len = utf8len(str)
    if charIndex < 1 or charIndex > len then
        return 0
    end
    local byteIndex = utf8CharIndexToByteIndex(str, charIndex)
    local ch = byte(str, byteIndex)
    local ct = utf8charsize(ch)
    local v = ch
    local mul = 256
    for i = 1, ct - 1 do
        v = v + byte(str, byteIndex + i) * mul
        mul = mul * 256
    end
    return v
end

local function getUtf8CharArray(str, charIndex, numChars)
    local byteIndex, byteCount = utf8CharIndexCountToByteIndexCount(str, charIndex, numChars)
    local t = {}
    local len = 1
    while len <= numChars do
        local ch = byte(str, byteIndex)
        local ct = utf8charsize(ch)
        local v = ch
        local mul = 256
        for i = 1, ct - 1 do
            v = v + byte(str, byteIndex + i) * mul
            mul = mul * 256
        end
        t[len] = v
        byteIndex = byteIndex + ct
        len = len + 1
    end
    return wraparray(t)
end

--上面的index与lua保持一致，即从1开始
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--下面的index与c#保持一致，即从0开始

local function escape(s)
    return gsub(s, "([%%%^%.])", "%%%1")
end
local function escapeRepl(s)
    return gsub(s, "(%%)", "%%%1")
end
local function findAny(s, strings, startIndex)
    local findBegin, findEnd
    for i = 1, #strings do
        local posBegin, posEnd = find(s, strings[i], startIndex, true)
        if posBegin then
            if not findBegin or posBegin < findBegin then
                findBegin, findEnd = posBegin, posEnd
            else
                break
            end
        end
    end
    return findBegin, findEnd
end

local function checkIndex(value, startIndex, count)
    local len = utf8len(value)
    if not startIndex or startIndex < 0 then
        startIndex, count = 0, len
    elseif not count or count <= 0 then
        if startIndex < 0 or startIndex > len then
            error(
                "startIndex " .. tostring(startIndex) .. " out of range [0.." .. tostring(len - 1) .. "] str: " .. value
            )
        end
        count = len - startIndex
    else
        if startIndex < 0 or startIndex > len then
            error(
                "startIndex " .. tostring(startIndex) .. " out of range [0.." .. tostring(len - 1) .. "] str: " .. value
            )
        end
        if count < 0 or startIndex + count > len then
            error(
                "count " ..
                    tostring(count) ..
                        " out of range [0.." ..
                            tostring(len - startIndex) .. "] startIndex: " .. tostring(startIndex) .. " str: " .. value
            )
        end
    end
    return startIndex, count, len
end

local function onlycheckIndex(value, startIndex)
    local len = utf8len(value)
    if not startIndex or startIndex < 0 then
        startIndex = 0
    else
        if startIndex < 0 or startIndex > len then
            error(
                "startIndex " .. tostring(startIndex) .. " out of range [0.." .. tostring(len - 1) .. "] str: " .. value
            )
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

    if strA < strB then
        return -1
    end
    if strA > strB then
        return 1
    end
    return 0
end

local function replace(this, a, b)
    a = csstrtoluastr(a)
    b = csstrtoluastr(b)
    if type(a) == "number" then
        a, b = char(a), char(b)
    end
    return gsub(this, escape(a), escapeRepl(b))
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
            strings = "[" .. strings .. "]"
        end
    elseif type(strings) == "string" then
    else
        strings = char(strings)
    end

    local len = 1
    local startIndex = 1
    while true do
        local posBegin, posEnd = find(this, strings, startIndex, true)
        posBegin = posBegin or 0
        local subStr = sub(this, startIndex, posBegin - 1)
        if options ~= 1 or #subStr > 0 then
            t[len] = subStr
            len = len + 1
            if count then
                count = count - 1
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

local function checkLastIndexOf(value, startIndex, count)
    local len = utf8len(value)
    if not startIndex or startIndex < 0 then
        startIndex, count = len - 1, len
    elseif not count or count <= 0 then
        if len == 0 then
            startIndex = -1
        elseif startIndex < 0 or startIndex > len then
            error(
                "startIndex " .. tostring(startIndex) .. " out of range [0.." .. tostring(len - 1) .. "] str: " .. value
            )
        end
        count = len == 0 and 0 or (startIndex + 1)
    else
        if startIndex < 0 or startIndex > len then
            error(
                "startIndex " .. tostring(startIndex) .. " out of range [0.." .. tostring(len - 1) .. "] str: " .. value
            )
        end
        if count < 0 or startIndex + count > len then
            error(
                "count " ..
                    tostring(count) ..
                        " out of range [0.." ..
                            tostring(len - count) .. "] startIndex: " .. tostring(startIndex) .. " str: " .. value
            )
        end
    end
    return startIndex, count, len
end

local function lastIndexOf(this, value, charIndex, numChars, comparisonType)
    charIndex, numChars = checkLastIndexOf(this, charIndex, numChars)
    local len = utf8len(this)
    local startIndex, count = utf8CharIndexCountToByteIndexCount(this, len - charIndex, numChars)
    startIndex = startIndex - 1
    if type(value) == "number" then
        value = char(value)
    end
    local ignoreCase = comparisonType and comparisonType % 2 ~= 0
    if ignoreCase then
        this, value = lower(this), lower(value)
    end
    local e = startIndex + 1
    local f = e - count + 1
    local index = -1
    while true do
        local i, j = find(this, value, f, true)
        if not i or j > e then
            break
        end
        index = i - 1
        f = j + 1
    end
    if index >= 0 then
        index = utf8len(this, 1, index + 1) - 1
    end
    return index
end

local function indexOf(this, value, charIndex, numChars, comparisonType)
    charIndex, numChars = checkIndex(this, charIndex, numChars)
    local startIndex, count = utf8CharIndexCountToByteIndexCount(this, charIndex + 1, numChars)
    startIndex = startIndex - 1
    if type(value) == "number" then
        value = char(value)
    end
    local ignoreCase = comparisonType and comparisonType % 2 ~= 0
    if ignoreCase then
        this, value = lower(this), lower(value)
    end
    local i, j = find(this, value, startIndex + 1, true)
    if i then
        local e = startIndex + count
        if j <= e then
            return utf8len(this, 1, i) - 1
        --return i - 1
        end
        return -1
    end
    return -1
end
-- LuaSystemString[method](obj, ...)
LuaSystemString = {
    CompareTo__String = function(this, v)
        if v == nil then
            return 1
        end
        v = csstrtoluastr(v)
        if type(v) ~= "string" then
            error("Arg must be string")
        end
        return compare(this, v)
    end, -- 不确定是哪一种比较方式？忽略大小写？全字匹配？
    Contains = function(this, value)
        if value == nil then
            error("value is nil")
        end
        value = csstrtoluastr(value)
        return find(this, value, 1, true) ~= nil
    end,
    EndsWith__String = function(this, suffix)
        suffix = csstrtoluastr(suffix)
        return suffix == "" or sub(this, -(#suffix)) == suffix
    end,
    Equals__String = function(this, v)
        v = csstrtoluastr(v)
        if type(v) == "string" then
            return this == v
        end
        return false
    end,
    IndexOf__Char = function(this, value)
        value = csstrtoluastr(value)
        return indexOf(this, value, 0, 0, 0)
    end,
    IndexOf__String = function(this, value)
        value = csstrtoluastr(value)
        return indexOf(this, value, 0, 0, 0)
    end,
    IndexOf__String__StringComparison = function(this, value, strComparison)
        value = csstrtoluastr(value)
        return indexOf(this, value, 0, 0, strComparison)
    end,
    Insert = function(this, charIndex, value)
        charIndex = onlycheckIndex(this, charIndex)
        local startIndex = utf8CharIndexToByteIndex(this, charIndex + 1) - 1
        value = csstrtoluastr(value)
        return sub(this, 1, startIndex) .. value .. sub(this, startIndex + 1)
    end,
    LastIndexOf__Char = function(this, value)
        value = csstrtoluastr(value)
        return lastIndexOf(this, value, 0, 0, 0)
    end,
    LastIndexOf__String = function(this, value)
        value = csstrtoluastr(value)
        return lastIndexOf(this, value, 0, 0, 0)
    end,
    LastIndexOf__String__StringComparison = function(this, value, strComparison)
        value = csstrtoluastr(value)
        return lastIndexOf(this, value, 0, 0, strComparison)
    end,
    PadLeft__Int32__Char = function(this, totalWidth, paddingChar)
        local len = #this
        if len >= totalWidth then
            return this
        else
            paddingChar = paddingChar or 0x20
            return rep(char(paddingChar), totalWidth - len) .. this
        end
    end,
    PadRight__Int32__Char = function(this, totalWidth, paddingChar)
        local len = #this
        if len >= totalWidth then
            return this
        else
            paddingChar = paddingChar or 0x20
            return this .. rep(char(paddingChar), totalWidth - len)
        end
    end,
    Remove__Int32 = function(this, charIndex)
        charIndex = onlycheckIndex(this, charIndex)
        local startIndex = utf8CharIndexToByteIndex(this, charIndex + 1) - 1
        return sub(this, 1, startIndex)
    end,
    Remove__Int32__Int32 = function(this, charIndex, numChars)
        charIndex, numChars = checkIndex(this, charIndex, numChars)
        local startIndex, count = utf8CharIndexCountToByteIndexCount(this, charIndex + 1, numChars)
        startIndex = startIndex - 1
        return sub(this, 1, startIndex) .. sub(this, startIndex + 1 + count)
    end,
    Replace__Char__Char = replace,
    Replace__String__String = replace,
    Split__A_Char = function(this, str)
        str = csstrtoluastr(str)
        return split(this, str, 0x7fffffff, 0)
    end,
    Split__A_Char__StringSplitOptions = function(this, str, options)
        str = csstrtoluastr(str)
        return split(this, str, 0x7fffffff, options)
    end,
    StartsWith__String = function(this, prefix)
        prefix = csstrtoluastr(prefix)
        return sub(this, 1, #prefix) == prefix
    end,
    Substring__Int32 = function(this, charIndex)
        local len = utf8len(this)
        if charIndex < 0 or charIndex > len then
            error("charIndex " .. tostring(charIndex) .. " out of range [0.." .. tostring(len - 1) .. "] str: " .. this)
        end
        return utf8sub(this, charIndex + 1, len)
    end,
    Substring__Int32__Int32 = function(this, charIndex, numChars)
        local len = utf8len(this)
        if charIndex < 0 or charIndex > len then
            error("charIndex " .. tostring(charIndex) .. " out of range [0.." .. tostring(len - 1) .. "] str: " .. this)
        end
        if numChars < 0 or charIndex + numChars > len then
            error(
                "numChars " ..
                    tostring(numChars) .. " out of range [0.." .. tostring(len - charIndex) .. "] str: " .. this
            )
        end
        return utf8sub(this, charIndex + 1, numChars)
    end,
    ToCharArray = function(str, charIndex, numChars)
        charIndex, numChars = checkIndex(str, charIndex, numChars)
        return getUtf8CharArray(str, charIndex + 1, numChars)
    end,
    ToLower = lower,
    ToString = tostring,
    ToUpper = upper,
    Trim = function(this, chars, ...)
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
    TrimEnd = function(this, chars, ...)
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
    GetChar = function(obj, index)
        return getUtf8Char(obj, index + 1)
    end,
    GetProperty = function(obj, name)
        if name == "Length" then
            return utf8len(obj)
        elseif name == "Empty" then
            return ""
        end
    end
    -- SetProperty = function(obj, name, val)
    -- end
}

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

ArrayStaticMethods = {
    IndexOf__Array__Object = function(firstArray, secondArray, method, ...)
        local arg1, arg2 = ...
        return firstArray:IndexOf(arg2)
    end,
    IndexOf = function(firstArray, secondArray, method, ...)
        local arg1, arg2 = ...
        return firstArray:IndexOf(arg2)
    end,
    Sort = function(firstArray, secondArray, method, ...)
        local arg1, arg2 = ...
        return table.sort(
            firstArray,
            function(a, b)
                return arg2(a, b) < 0
            end
        )
    end,
    Reverse__Array = function(firstArray, secondArray, method, ...)
        local arg1, arg2 = ...
        firstArray =
            table.sort(
            firstArray,
            function(a, b)
                return 1
            end
        )
        return nil
    end,
    Find = function(firstArray, secondArray, method, ...)
        local arg1, arg2 = ...
        local ct = __get_array_count(arg1)
        for i = 1, ct do
            local v = rawget(arg1, i)
            if arg2(v) then
                return v
            end
        end
        return nil
    end,
    FindIndex = function(firstArray, secondArray, method, ...)
        local arg1, arg2 = ...
        local ct = __get_array_count(arg1)
        for i = 1, ct do
            local v = rawget(arg1, i)
            if arg2(v) then
                return i - 1
            end
        end
        return -1
    end,
    Copy__Array__Int32__Array__Int32__Int32 = function(firstArray, secondArray, method, ...)
        local __, __, arg3, arg4, arg5 = ...
        local ct = __get_array_count(arg1)
        for i = arg2 + 1, arg2 + arg5 do
            local v = rawget(arg1, i)
            rawset(arg3, arg4 + 1, v)
            arg4 = arg4 + 1
        end
        return nil
    end
}

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
