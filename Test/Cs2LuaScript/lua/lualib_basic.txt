---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- reference:https://github.com/yanghuan/CSharp.lua/blob/master/CSharp.lua/CoreSystem.Lua/CoreSystem/String.lua
-- reference:https://my.oschina.net/u/1175660/blog/1796629
-- reference:https://github.com/britzl/gooey/blob/master/gooey/internal/utf8.lua
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

local c_shift_6  = 2^6
local c_shift_12 = 2^12
local c_shift_18 = 2^18
local function getUnicodeCharFromUtf8Str(str, charIndex)
    local len = utf8len(str)
    if charIndex < 1 or charIndex > len then
        return 0
    end
    local byteIndex = utf8CharIndexToByteIndex(str, charIndex)
    local ch = byte(str, byteIndex)
    local bytes = utf8charsize(ch)
	local unicode = 0

	if bytes == 1 then 
        unicode = ch
    end
	if bytes == 2 then
		local byte0, byte1 = byte(str, byteIndex, byteIndex + 1)
		local code0,code1 = byte0-0xC0,byte1-0x80
		unicode = code0*c_shift_6 + code1
	end
	if bytes == 3 then
		local byte0,byte1,byte2 = byte(str, byteIndex, byteIndex + 2)
		local code0,code1,code2 = byte0-0xE0,byte1-0x80,byte2-0x80
		unicode = code0*c_shift_12 + code1*c_shift_6 + code2
	end
	if bytes == 4 then
		local byte0,byte1,byte2,byte3 = byte(str, byteIndex, byteIndex + 3)
		local code0,code1,code2,code3 = byte0-0xF0,byte1-0x80,byte2-0x80,byte3-0x80
		unicode = code0*c_shift_18 + code1*c_shift_12 + code2*c_shift_6 + code3
	end
	return unicode
end

local function getUnicodeCharArrayFromUtf8Str(str, charIndex, numChars)
    local byteIndex, byteCount = utf8CharIndexCountToByteIndexCount(str, charIndex, numChars)
    local t = {}
    local len = 1
    while len <= numChars do
        local ch = byte(str, byteIndex)
        local ct = utf8charsize(ch)

        local unicode = 0    
        if ct == 1 then 
            unicode = ch
        end
        if ct == 2 then
            local byte0, byte1 = byte(str, byteIndex, byteIndex + 1)
            local code0, code1 = byte0-0xC0, byte1-0x80
            unicode = code0*c_shift_6 + code1
        end
        if ct == 3 then
            local byte0, byte1, byte2 = byte(str, byteIndex, byteIndex + 2)
            local code0, code1, code2 = byte0-0xE0, byte1-0x80, byte2-0x80
            unicode = code0*c_shift_12 + code1*c_shift_6 + code2
        end
        if ct == 4 then
            local byte0, byte1, byte2, byte3 = byte(str, byteIndex, byteIndex + 3)
            local code0, code1, code2, code3 = byte0-0xF0, byte1-0x80, byte2-0x80, byte3-0x80
            unicode = code0*c_shift_18 + code1*c_shift_12 + code2*c_shift_6 + code3
        end
        
        t[len] = unicode
        byteIndex = byteIndex + ct
        len = len + 1
    end
    return wraparray(t)
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

local function unicodeChar2Utf8Char(unicode)
    local unival = unicode
    if type(unicode)=="string" then
        return getUtf8Char(unicode, 1)
    end
    if unival <= 0x7F then
        return unival
    end
    if (unival <= 0x7FF) then
        local byte0 = 0xC0 + math.floor(unival / 0x40);
        local byte1 = 0x80 + (unival % 0x40);
        return byte0 + byte1*256;
    end
    if (unival <= 0xFFFF) then
        local byte0 = 0xE0 +  math.floor(unival / 0x1000);
        local byte1 = 0x80 + (math.floor(unival / 0x40) % 0x40);
        local byte2 = 0x80 + (unival % 0x40);
        return byte0 + byte1 * 256 + byte2 * 256 * 256;
    end
    if (unival <= 0x10FFFF) then
        local code = unival
        local byte3= 0x80 + (code % 0x40);
        code       = math.floor(code / 0x40)
        local byte2= 0x80 + (code % 0x40);
        code       = math.floor(code / 0x40)
        local byte1= 0x80 + (code % 0x40);
        code       = math.floor(code / 0x40)
        local byte0= 0xF0 + code;

        return byte0 + byte1 * 256 + byte2 * 256 * 256 + byte3 * 256 * 256 * 256;
    end
    error('Unicode cannot be greater than U+10FFFF!')
end

--上面的index与lua保持一致，即从1开始
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--下面的index与c#保持一致，即从0开始

local function escape(s)
    return gsub(s, "([%%%^%.])", "%%%1")
end
local function escapeRepl(s)
    return gsub(s, "([%%%#])", "%%%1")
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

local function replace(thisStr, a, b)
    thisStr = csstrtoluastr(thisStr)
    a = csstrtoluastr(a)
    b = csstrtoluastr(b)
    if type(a) == "number" then
        a, b = char(a), char(b)
    end
    local tb = {}
    local tbIx = 1
    local len = #thisStr
    local alen = #a    
    local ix = 1
    while ix <= len do
        local nix = find(thisStr, a, ix, true)
        if nix then
            local ss = sub(thisStr, ix, nix - 1)
            tb[tbIx] = ss
            tbIx = tbIx + 1
            ix = nix + alen
            if ix > len then
                tb[tbIx] = ""
            end
        else
            local ss = sub(thisStr, ix)
            tb[tbIx] = ss
            break
        end
    end
    return tconcat(tb, b)
    --return gsub(thisStr, escape(a), escapeRepl(b))
end

local function tolower(thisStr)
    thisStr = csstrtoluastr(thisStr)
    return lower(thisStr)
end

local function toupper(thisStr)
    thisStr = csstrtoluastr(thisStr)
    return upper(thisStr)
end

local function mytostring(thisStr)
    thisStr = csstrtoluastr(thisStr)
    return thisStr
end

local function split(thisStr, strings, count, options)
    local t = {}
    local find = find
    local isPlain = true
    if type(strings) == "table" then
        if #strings == 0 then
            return wraparray(t)
        end

        if type(strings[1]) == "string" then
            find = findAny
        else
            strings = char(unpack(strings))
            strings = "[" .. strings .. "]"
            isPlain = false
        end
    elseif type(strings) == "string" then
    else
        strings = char(strings)
    end

    local len = 1
    local startIndex = 1
    while true do
        local posBegin, posEnd = find(thisStr, strings, startIndex, isPlain)
        posBegin = posBegin or 0
        local subStr = sub(thisStr, startIndex, posBegin - 1)
        if options ~= 1 or #subStr > 0 then
            t[len] = subStr
            len = len + 1
            if count then
                count = count - 1
                if count == 0 then
                    if posBegin ~= 0 then
                        t[len - 1] = sub(thisStr, startIndex)
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

local function lastIndexOf(thisStr, value, charIndex, numChars, comparisonType)
    charIndex, numChars = checkLastIndexOf(thisStr, charIndex, numChars)
    local len = utf8len(thisStr)
    local startIndex, count = utf8CharIndexCountToByteIndexCount(thisStr, len - charIndex, numChars)
    startIndex = startIndex - 1
    if type(value) == "number" then
        value = char(value)
    end
    local ignoreCase = comparisonType and comparisonType % 2 ~= 0
    if ignoreCase then
        thisStr, value = lower(thisStr), lower(value)
    end
    local e = startIndex + 1
    local f = e - count + 1
    local index = -1
    while true do
        local i, j = find(thisStr, value, f, true)
        if not i or j > e then
            break
        end
        index = i - 1
        f = j + 1
    end
    if index >= 0 then
        index = utf8len(thisStr, 1, index + 1) - 1
    end
    return index
end

local function indexOf(thisStr, value, charIndex, numChars, comparisonType)
    charIndex, numChars = checkIndex(thisStr, charIndex, numChars)
    local startIndex, count = utf8CharIndexCountToByteIndexCount(thisStr, charIndex + 1, numChars)
    startIndex = startIndex - 1
    if type(value) == "number" then
        value = char(value)
    end
    local ignoreCase = comparisonType and comparisonType % 2 ~= 0
    if ignoreCase then
        thisStr, value = lower(thisStr), lower(value)
    end
    local i, j = find(thisStr, value, startIndex + 1, true)
    if i then
        local e = startIndex + count
        if j <= e then
            return utf8len(thisStr, 1, i) - 1
        --return i - 1
        end
        return -1
    end
    return -1
end
-- LuaSystemString[method](obj, ...)
LuaSystemString = {
    CompareTo__String = function(thisStr, v)
        if v == nil then
            return 1
        end
        thisStr = csstrtoluastr(thisStr)
        v = csstrtoluastr(v)
        if type(v) ~= "string" then
            error("Arg must be string")
        end
        return compare(thisStr, v)
    end, -- 不确定是哪一种比较方式？忽略大小写？全字匹配？
    Contains = function(thisStr, value)
        if value == nil then
            error("value is nil")
        end
        thisStr = csstrtoluastr(thisStr)
        value = csstrtoluastr(value)
        return find(thisStr, value, 1, true) ~= nil
    end,
    EndsWith__String = function(thisStr, suffix)
        thisStr = csstrtoluastr(thisStr)
        suffix = csstrtoluastr(suffix)
        return suffix == "" or sub(thisStr, -(#suffix)) == suffix
    end,
    Equals__String = function(thisStr, v)
        thisStr = csstrtoluastr(thisStr)
        v = csstrtoluastr(v)
        if type(v) == "string" then
            return thisStr == v
        end
        return false
    end,
    IndexOf__Char = function(thisStr, value)
        thisStr = csstrtoluastr(thisStr)
        value = csstrtoluastr(value)
        return indexOf(thisStr, value, 0, 0, 0)
    end,
    IndexOf__String = function(thisStr, value)
        thisStr = csstrtoluastr(thisStr)
        value = csstrtoluastr(value)
        return indexOf(thisStr, value, 0, 0, 0)
    end,
    IndexOf__String__StringComparison = function(thisStr, value, strComparison)
        thisStr = csstrtoluastr(thisStr)
        value = csstrtoluastr(value)
        return indexOf(thisStr, value, 0, 0, strComparison)
    end,
    Insert = function(thisStr, charIndex, value)
        thisStr = csstrtoluastr(thisStr)
        charIndex = onlycheckIndex(thisStr, charIndex)
        local startIndex = utf8CharIndexToByteIndex(thisStr, charIndex + 1) - 1
        value = csstrtoluastr(value)
        return sub(thisStr, 1, startIndex) .. value .. sub(thisStr, startIndex + 1)
    end,
    LastIndexOf__Char = function(thisStr, value)
        thisStr = csstrtoluastr(thisStr)
        value = csstrtoluastr(value)
        return lastIndexOf(thisStr, value, 0, 0, 0)
    end,
    LastIndexOf__String = function(thisStr, value)
        thisStr = csstrtoluastr(thisStr)
        value = csstrtoluastr(value)
        return lastIndexOf(thisStr, value, 0, 0, 0)
    end,
    LastIndexOf__String__StringComparison = function(thisStr, value, strComparison)
        thisStr = csstrtoluastr(thisStr)
        value = csstrtoluastr(value)
        return lastIndexOf(thisStr, value, 0, 0, strComparison)
    end,
    PadLeft__Int32__Char = function(thisStr, totalWidth, paddingChar)
        thisStr = csstrtoluastr(thisStr)
        local len = #thisStr
        if len >= totalWidth then
            return thisStr
        else
            paddingChar = paddingChar or 0x20
            return rep(char(paddingChar), totalWidth - len) .. thisStr
        end
    end,
    PadRight__Int32__Char = function(thisStr, totalWidth, paddingChar)
        thisStr = csstrtoluastr(thisStr)
        local len = #thisStr
        if len >= totalWidth then
            return thisStr
        else
            paddingChar = paddingChar or 0x20
            return thisStr .. rep(char(paddingChar), totalWidth - len)
        end
    end,
    Remove__Int32 = function(thisStr, charIndex)
        thisStr = csstrtoluastr(thisStr)
        charIndex = onlycheckIndex(thisStr, charIndex)
        local startIndex = utf8CharIndexToByteIndex(thisStr, charIndex + 1) - 1
        return sub(thisStr, 1, startIndex)
    end,
    Remove__Int32__Int32 = function(thisStr, charIndex, numChars)
        thisStr = csstrtoluastr(thisStr)
        charIndex, numChars = checkIndex(thisStr, charIndex, numChars)
        local startIndex, count = utf8CharIndexCountToByteIndexCount(thisStr, charIndex + 1, numChars)
        startIndex = startIndex - 1
        return sub(thisStr, 1, startIndex) .. sub(thisStr, startIndex + 1 + count)
    end,
    Replace__Char__Char = replace,
    Replace__String__String = replace,
    Split__A_Char = function(thisStr, str)
        thisStr = csstrtoluastr(thisStr)
        str = csstrtoluastr(str)
        return split(thisStr, str, 0x7fffffff, 0)
    end,
    Split__A_Char__StringSplitOptions = function(thisStr, str, options)
        thisStr = csstrtoluastr(thisStr)
        str = csstrtoluastr(str)
        return split(thisStr, str, 0x7fffffff, options)
    end,
    StartsWith__String = function(thisStr, prefix)
        thisStr = csstrtoluastr(thisStr)
        prefix = csstrtoluastr(prefix)
        return sub(thisStr, 1, #prefix) == prefix
    end,
    Substring__Int32 = function(thisStr, charIndex)
        thisStr = csstrtoluastr(thisStr)
        local len = utf8len(thisStr)
        if charIndex < 0 or charIndex > len then
            error("charIndex " .. tostring(charIndex) .. " out of range [0.." .. tostring(len - 1) .. "] str: " .. thisStr)
        end
        return utf8sub(thisStr, charIndex + 1, len)
    end,
    Substring__Int32__Int32 = function(thisStr, charIndex, numChars)
        thisStr = csstrtoluastr(thisStr)
        local len = utf8len(thisStr)
        if charIndex < 0 or charIndex > len then
            error("charIndex " .. tostring(charIndex) .. " out of range [0.." .. tostring(len - 1) .. "] str: " .. thisStr)
        end
        if numChars < 0 or charIndex + numChars > len then
            error(
                "numChars " ..
                    tostring(numChars) .. " out of range [0.." .. tostring(len - charIndex) .. "] str: " .. thisStr
            )
        end
        return utf8sub(thisStr, charIndex + 1, numChars)
    end,
    ToCharArray = function(thisStr, charIndex, numChars)
        thisStr = csstrtoluastr(thisStr)
        charIndex, numChars = checkIndex(thisStr, charIndex, numChars)
        return getUnicodeCharArrayFromUtf8Str(thisStr, charIndex + 1, numChars)
    end,
    ToLower = tolower,
    ToString = mytostring,
    ToUpper = toupper,
    Trim = function(thisStr, chars, ...)
        thisStr = csstrtoluastr(thisStr)
        if not chars then
            chars = "^%s*(.-)%s*$"
            return (gsub(thisStr, chars, "%1"))
        else
            local hash = {}
            if type(chars) == "table" then
                for i,v in ipairs(chars) do
                    v = unicodeChar2Utf8Char(v)
                    hash[v] = true
                end
            else
                chars = unicodeChar2Utf8Char(chars)
                hash[chars] = true
                local argnum = select("#", ...)
                for i = 1, argnum do
                    local v = select(i, ...)
                    v = unicodeChar2Utf8Char(v)
                    hash[v] = true
                end
            end
            local len = utf8len(thisStr)
            local st = len
            for i = 1,len do
                local u8char = getUtf8Char(thisStr, i)
                if not hash[u8char] then
                    st = i
                    break
                end
            end
            local ed = st-1
            for i = len,st-1,-1 do
                local u8char = getUtf8Char(thisStr, i)
                if not hash[u8char] then
                    ed = i
                    break
                end
            end
            if st<=ed then
                return utf8sub(thisStr, st, ed-st+1)
            else
                return ""
            end
        end
    end,
    TrimEnd = function(thisStr, chars, ...)
        thisStr = csstrtoluastr(thisStr)
        if not chars then
            chars = "(.-)%s*$"
            return (gsub(thisStr, chars, "%1"))
        else
            local hash = {}
            if type(chars) == "table" then
                for i,v in ipairs(chars) do
                    v = unicodeChar2Utf8Char(v)
                    hash[v] = true
                end
            else
                chars = unicodeChar2Utf8Char(chars)
                hash[chars] = true
                local argnum = select("#", ...)
                for i = 1, argnum do
                    local v = select(i, ...)
                    v = unicodeChar2Utf8Char(v)
                    hash[v] = true
                end
            end
            local len = utf8len(thisStr)
            local ed = 0
            for i = len,0,-1 do
                local u8char = getUtf8Char(thisStr, i)
                if not hash[u8char] then
                    ed = i
                    break
                end
            end
            if 1<=ed then
                return utf8sub(thisStr, 1, ed)
            else
                return ""
            end
        end
    end,
    TrimStart = function(thisStr, chars, ...)
        thisStr = csstrtoluastr(thisStr)
        chars = csstrtoluastr(chars)
        if not chars then
            chars = "^%s*(.-)"
            return (gsub(thisStr, chars, "%1"))
        else
            local hash = {}
            if type(chars) == "table" then
                for i,v in ipairs(chars) do
                    v = unicodeChar2Utf8Char(v)
                    hash[v] = true
                end
            else
                chars = unicodeChar2Utf8Char(chars)
                hash[chars] = true
                local argnum = select("#", ...)
                for i = 1, argnum do
                    local v = select(i, ...)
                    v = unicodeChar2Utf8Char(v)
                    hash[v] = true
                end
            end
            local len = utf8len(thisStr)
            local st = len+1
            for i = 1,len+1 do
                local u8char = getUtf8Char(thisStr, i)
                if not hash[u8char] then
                    st = i
                    break
                end
            end
            if st<=len then
                return utf8sub(thisStr, st, len-st+1)
            else
                return ""
            end
        end
    end,
    GetChar = function(thisStr, index)
        thisStr = csstrtoluastr(thisStr)
        return getUnicodeCharFromUtf8Str(thisStr, index + 1)
    end,
    GetProperty = function(thisStr, name)
        thisStr = csstrtoluastr(thisStr)
        if name == "Length" then
            return utf8len(thisStr)
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
