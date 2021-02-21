script(wrapoutstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //wrapoutstruct(v, classObj)
    return(false);
};

script(wrapoutexternstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //wrapoutexternstruct(v, classObj)
    $classObj = getargument($funcData, 1);
    
    if($classObj=="UnityEngine.Vector2"){
        usefunc("wrap_out_vector2", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(0,0)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Vector3"){
        usefunc("wrap_out_vector3", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
        {:    
            local obj = UnityEngine.Vector3.New(0,0,0)
            table.insert(funcInfo.v3_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Vector4"){
        usefunc("wrap_out_vector4", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
        {:    
            local obj = UnityEngine.Vector4.New(0,0,0,1)
            table.insert(funcInfo.v4_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Quaternion"){
        usefunc("wrap_out_quaternion", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
        {:   
            local obj = UnityEngine.Quaternion.New(0,0,0,1)
            table.insert(funcInfo.q_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Color"){
        usefunc("wrap_out_color", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
        {:   
            local obj = UnityEngine.Color.New(0,0,0,1)
            table.insert(funcInfo.c_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Color32"){
        usefunc("wrap_out_color32", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
        {:   
            local obj = Color32Pool.Alloc()
            table.insert(funcInfo.c32_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Rect"){
        usefunc("wrap_out_rect", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
        {:   
            local obj = RectPool.Alloc()
            table.insert(funcInfo.rt_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="CsLibrary.DateTime"){
        usefunc("wrap_out_datetime", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
        {:   
            local obj = DateTimePool.Alloc()
            table.insert(funcInfo.dt_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="CsLibrary.TimeSpan"){
        usefunc("wrap_out_timespan", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
        {:   
            local obj = TimeSpanPool.Alloc()
            table.insert(funcInfo.ts_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="CsLibrary.PathInfoPoint"){
        usefunc("wrap_out_pathinfopoint", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
        {:   
            local obj = PathInfoPointPool.Alloc()
            table.insert(funcInfo.pip_list, obj)
            return obj
        :};
        return(true);
    };
    return(false);
};

script(wrapstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //wrapstruct(v, classObj)
    return(false);
};

script(wrapexternstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //wrapexternstruct(v, classObj)
    $varName = getargument($funcData, 0);
    $classObj = getargument($funcData, 1);

    if($classObj=="UnityEngine.Vector2"){
        usefunc("wrap_vector2","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1], "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(v.x,v.y)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Vector3"){
        usefunc("wrap_vector3","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1], "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(v.x,v.y,v.z)
            table.insert(funcInfo.v3_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Vector4"){
        usefunc("wrap_vector4","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1], "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector4.New(v.x,v.y,v.z,v.w)
            table.insert(funcInfo.v4_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Quaternion"){
        usefunc("wrap_quaternion","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1], "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Quaternion.New(v.x,v.y,v.z,v.w)
            table.insert(funcInfo.q_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Color"){
        usefunc("wrap_color","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1], "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.New(v.r,v.g,v.b,v.a)
            table.insert(funcInfo.c_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Color32"){
        usefunc("wrap_color32","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1], "__cs2lua_func_info")
        {:
            local obj = Color32Pool.Alloc()
            obj.r = v.r or 0
            obj.g = v.g or 0
            obj.b = v.b or 0
            obj.a = v.a or 0
            table.insert(funcInfo.c32_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Rect"){
        usefunc("wrap_rect","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1], "__cs2lua_func_info")
        {:
            local obj = RectPool.Alloc();
            obj.x=v.x
            obj.y=v.y
            obj.width=v.width
            obj.height=v.height
            table.insert(funcInfo.rt_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="CsLibrary.DateTime"){
        usefunc("wrap_datetime","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1], "__cs2lua_func_info")
        {:
            local y,m,d,hh,mm,ss,ms =  CsLibrary.DateTime.GetDateTimeValue(v,Slua.out,Slua.out,Slua.out,Slua.out,Slua.out,Slua.out,Slua.out)
            local obj = DateTimePool.Alloc();
            obj:SetDateTime(y,m,d,hh,mm,ss,ms)
            table.insert(funcInfo.dt_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="CsLibrary.TimeSpan"){
        usefunc("wrap_timespan","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1], "__cs2lua_func_info")
        {:
            local obj = TimeSpanPool.Alloc()
            obj:SetTimeDHMSM(v.Days, v.Hours, v.Minutes, v.Seconds, v.Milliseconds)
            table.insert(funcInfo.ts_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="CsLibrary.PathInfoPoint"){
        usefunc("wrap_pathinfopoint","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1], "__cs2lua_func_info")
        {:
            local obj = PathInfoPointPool.Alloc();
            local _,x,y,z = v:GetPoint(Slua.out, Slua.out, Slua.out)
            obj:SetPoint(x,y,z)
            obj.m_Fly = v.m_Fly
            obj.m_StopPoint = v.m_StopPoint
            obj.m_MoveType = v.m_MoveType
            obj.m_JumpIndex = v.m_JumpIndex
            obj.m_SpeedScale = v.m_SpeedScale
            obj.m_Distance = v.m_Distance
            obj.m_LookTargetObjID = v.m_LookTargetObjID
            table.insert(funcInfo.pip_list, obj)
            return obj
        :};
        return(true);
    };
    return(false);
};

script(wrapstructargument)args($funcData, $funcOpts, $sb, $indent)
{
    //wrapstructargument(v, argType, argOperKind, argSymKind, class, callerClass)
    return(false);
};

script(wrapexternstructargument)args($funcData, $funcOpts, $sb, $indent)
{
    //wrapexternstructargument(v, argType, argOperKind, argSymKind, class, callerClass)
    $argType = getargument($funcData, 1);

    if($argType=="UnityEngine.Vector2"){
        usefunc("wrap_vector2","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(v.x,v.y)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($argType=="UnityEngine.Vector3"){
        usefunc("wrap_vector3","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(v.x,v.y,v.z)
            table.insert(funcInfo.v3_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($argType=="UnityEngine.Vector4"){
        usefunc("wrap_vector4","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector4.New(v.x,v.y,v.z,v.w)
            table.insert(funcInfo.v4_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($argType=="UnityEngine.Quaternion"){
        usefunc("wrap_quaternion","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Quaternion.New(v.x,v.y,v.z,v.w)
            table.insert(funcInfo.q_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($argType=="UnityEngine.Color"){
        usefunc("wrap_color","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.New(v.r,v.g,v.b,v.a)
            table.insert(funcInfo.c_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($argType=="UnityEngine.Color32"){
        usefunc("wrap_color32","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            local obj = Color32Pool.Alloc()
            obj.r = v.r or 0
            obj.g = v.g or 0
            obj.b = v.b or 0
            obj.a = v.a or 0
            table.insert(funcInfo.c32_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($argType=="UnityEngine.Rect"){
        usefunc("wrap_rect","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            local obj = RectPool.Alloc();
            obj.x=v.x
            obj.y=v.y
            obj.width=v.width
            obj.height=v.height
            table.insert(funcInfo.rt_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($argType=="CsLibrary.DateTime"){
        usefunc("wrap_datetime","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            local y,m,d,hh,mm,ss,ms =  CsLibrary.DateTime.GetDateTimeValue(v,Slua.out,Slua.out,Slua.out,Slua.out,Slua.out,Slua.out,Slua.out)
            local obj = DateTimePool.Alloc();
            obj:SetDateTime(y,m,d,hh,mm,ss,ms)
            table.insert(funcInfo.dt_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($argType=="CsLibrary.TimeSpan"){
        usefunc("wrap_timespan","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            local obj = TimeSpanPool.Alloc()
            obj:SetTimeDHMSM(v.Days, v.Hours, v.Minutes, v.Seconds, v.Milliseconds)
            table.insert(funcInfo.ts_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($argType=="CsLibrary.PathInfoPoint"){    
        echo("wrapexternstructargument {0}", $argType);
        
        usefunc("wrap_pathinfopoint","(funcInfo, v)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            local obj = PathInfoPointPool.Alloc();
            local _,x,y,z = v:GetPoint(Slua.out, Slua.out, Slua.out)
            obj:SetPoint(x,y,z)
            obj.m_Fly = v.m_Fly
            obj.m_StopPoint = v.m_StopPoint
            obj.m_MoveType = v.m_MoveType
            obj.m_JumpIndex = v.m_JumpIndex
            obj.m_SpeedScale = v.m_SpeedScale
            obj.m_Distance = v.m_Distance
            obj.m_LookTargetObjID = v.m_LookTargetObjID
            table.insert(funcInfo.pip_list, obj)
            return obj
        :};
        return(true);
    };
    return(false);
};

script(wrapstructarguments)args($funcData, $funcOpts, $sb, $indent)
{
    //wrapstructarguments(arr, argType, argOperKind, argSymKind, class, callerClass)
    return(false);
};

script(wrapexternstructarguments)args($funcData, $funcOpts, $sb, $indent)
{
    //wrapexternstructarguments(arr, argType, argOperKind, argSymKind, class, callerClass)
    $argType = getargument($funcData, 1);

    if($argType=="UnityEngine.Vector2"){
        usefunc("wrap_vector2_array","(funcInfo, arr)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            for i,v in ipairs(arr) do
                local obj = UnityEngine.Vector2.New(v.x,v.y)
                table.insert(funcInfo.v2_list, obj)
                arr[i] = obj
            end
            return arr
        :};
        return(true);
    }
    elseif($argType=="UnityEngine.Vector3"){
        usefunc("wrap_vector3_array","(funcInfo, arr)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            for i,v in ipairs(arr) do
                local obj = UnityEngine.Vector3.New(v.x,v.y,v.z)
                table.insert(funcInfo.v3_list, obj)
                arr[i] = obj
            end
            return arr
        :};
        return(true);
    }
    elseif($argType=="UnityEngine.Vector4"){
        usefunc("wrap_vector4_array","(funcInfo, arr)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            for i,v in ipairs(arr) do
                local obj = UnityEngine.Vector4.New(v.x,v.y,v.z,v.w)
                table.insert(funcInfo.v4_list, obj)
                arr[i] = obj
            end
            return arr
        :};
        return(true);
    }
    elseif($argType=="UnityEngine.Quaternion"){
        usefunc("wrap_quaternion_array","(funcInfo, arr)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            for i,v in ipairs(arr) do
                local obj = UnityEngine.Quaternion.New(v.x,v.y,v.z,v.w)
                table.insert(funcInfo.q_list, obj)
                arr[i] = obj
            end
            return arr
        :};
        return(true);
    }
    elseif($argType=="UnityEngine.Color"){
        usefunc("wrap_color_array","(funcInfo, arr)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            for i,v in ipairs(arr) do
                local obj = UnityEngine.Color.New(v.r,v.g,v.b,v.a)
                table.insert(funcInfo.c_list, obj)
                arr[i] = obj
            end
            return arr
        :};
        return(true);
    }
    elseif($argType=="UnityEngine.Color32"){
        usefunc("wrap_color32_array","(funcInfo, arr)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            for i,v in ipairs(arr) do
                local obj = Color32Pool.Alloc()
                obj.r = v.r or 0
                obj.g = v.g or 0
                obj.b = v.b or 0
                obj.a = v.a or 0
                table.insert(funcInfo.c32_list, obj)
                arr[i] = obj
            end
            return arr
        :};
        return(true);
    }
    elseif($argType=="UnityEngine.Rect"){
        usefunc("wrap_Rect_array","(funcInfo, arr)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            for i,v in ipairs(arr) do
                local obj = RectPool.Alloc();
                obj.x=v.x
                obj.y=v.y
                obj.width=v.width
                obj.height=v.height
                table.insert(funcInfo.rt_list,obj)
                arr[i] = obj
            end
            return arr
        :};
        return(true);
    }elseif($argType=="CsLibrary.DateTime"){
        usefunc("wrap_DateTime_array","(funcInfo, arr)", $funcData, $funcOpts, $sb, $indent, [1,2,3,4,5], "__cs2lua_func_info")
        {:
            for i,v in ipairs(arr) do
                local y,m,d,hh,mm,ss,ms =  CsLibrary.DateTime.GetDateTimeValue(v,Slua.out,Slua.out,Slua.out,Slua.out,Slua.out,Slua.out,Slua.out)
                local obj = DateTimePool.Alloc();
                obj:SetDateTime(y,m,d,hh,mm,ss,ms)
                table.insert(funcInfo.dt_list, obj)
                arr[i] = obj
            end
            return arr
        :};
        return(true);
    };
    return(false);
};

script(getexternstaticstructmember)args($funcData, $funcOpts, $sb, $indent)
{
    //getexternstaticstructmember(symKind, class, member)
    $symKind = getargument($funcData, 0);
    $class = getargument($funcData, 1);
    $member = getargument($funcData, 2);
    
    if($class=="UnityEngine.Vector2" && $member=="zero"){        
        usefunc("get_vector2_zero", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(0,0)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector2" && $member=="one"){
        usefunc("get_vector2_one", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(1,1)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector2" && $member=="up"){
        usefunc("get_vector2_up", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(0,1)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector2" && $member=="down"){
        usefunc("get_vector2_down", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(0,-1)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="zero"){
        usefunc("get_vector3_zero", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,0,0)
            table.insert(funcInfo.v3_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="one"){
        usefunc("get_vector3_one", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(1,1,1)
            table.insert(funcInfo.v3_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="left"){
        usefunc("get_vector3_left", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(-1,0,0)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="right"){
        usefunc("get_vector3_right", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(1,0,0)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="forward"){
        usefunc("get_vector3_forward", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,0,1)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="back"){
        usefunc("get_vector3_back", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,0,-1)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="up"){
        usefunc("get_vector3_up", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,1,0)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="down"){
        usefunc("get_vector3_down", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,-1,0)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector4" && $member=="zero"){
        usefunc("get_vector4_zero", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector4.New(0,0,0,0)
            table.insert(funcInfo.v4_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector4" && $member=="one"){
        usefunc("get_vector4_one", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector4.New(1,1,1,1)
            table.insert(funcInfo.v4_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Quaternion" && $member=="identity"){
        usefunc("get_quaternion_identity", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Quaternion.New(0,0,0,1)
            table.insert(funcInfo.q_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="white"){
        usefunc("get_unity_color_white", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.white
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="red"){
        usefunc("get_unity_color_red", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.red
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="green"){
        usefunc("get_unity_color_green", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.green
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="blue"){
        usefunc("get_unity_color_blue", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.blue
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="black"){
        usefunc("get_unity_color_black", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.black
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="gray"){
        usefunc("get_unity_color_gray", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.gray
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="yellow"){
        usefunc("get_unity_color_yellow", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.yellow
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="CsLibrary.DateTime" && $member=="Now"){
        usefunc("get_datetime_now", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local y,m,d,hh,mm,ss,ms = CsLibrary.DateTime.GetNow(Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out)
            local obj = DateTimePool.Alloc()
            obj:SetDateTime(y,m,d,hh,mm,ss,ms)
            table.insert(funcInfo.dt_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="CsLibrary.AudioManager" && $member=="Listener_Pos"){
        usefunc("get_audiomanager_listener_pos", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local _,x,y,z = CsLibrary.AudioManager.GetListenerPos(Slua.out, Slua.out, Slua.out)        
            local obj = UnityEngine.Vector3.New(x,y,z)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="CsLibrary.UnityGeometry" && $member=="InvalidPos"){
        usefunc("get_unitygeometry_invalidpos", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local x,y,z = CsLibrary.UnityGeometry.GetInvalidPos(Slua.out, Slua.out, Slua.out)        
            local obj = UnityEngine.Vector3.New(x,y,z)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="CsLibrary.UnityGeometry" && $member=="InvalidDir2D"){
        usefunc("get_unitygeometry_invaliddir2d", "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local x,y = CsLibrary.UnityGeometry.GetInvalidDir2D(Slua.out, Slua.out, Slua.out)        
            local obj = UnityEngine.Vector2.New(x,y)
            table.insert(funcInfo.v2_list,obj)
            return obj
        :};
        return(true);
    }elseif($class=="UnityEngine.Screen" && $member=="safeArea"){
        usefunc("get_Screen_safearea" ,  "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Screen.safeArea
            table.insert(funcInfo.rt_list,obj)
            return obj
        :};
        return(true);
    }elseif($class=="UnityEngine.Rect" && $member=="zero"){
         usefunc("get_Rect_zero" ,  "(funcInfo)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
        {:
            local rt = RectPool.Alloc();
            rt.x=0
            rt.y=0
            rt.width=0
            rt.height=0
            table.insert(funcInfo.rt_list,rt)
            return rt
        :};
        return(true);
    };
    return(false);
};

script(getexterninstancestructmember)args($funcData, $funcOpts, $sb, $indent)
{
    //getexterninstancestructmember(symKind, obj, class, member)
    $symKind = getargument($funcData, 0);
    $class = getargument($funcData, 2);
    $member = getargument($funcData, 3);
        
    if($class=="UnityEngine.CapsuleCollider"){
        if($member=="center"){
            usefunc("get_capsulecollider_center","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetCapsuleColliderCenter(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="UnityEngine.Transform"){
        if($member=="position"){
            usefunc("get_tranform_position","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetPosition(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localPosition"){
            usefunc("get_tranform_localposition","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetLocalPosition(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="rotation"){
            usefunc("get_tranform_rotation","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z,w = Utility.GetRotation(obj, Slua.out, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localRotation"){
            usefunc("get_tranform_localrotation","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z,w = Utility.GetLocalRotation(obj, Slua.out, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="eulerAngles"){
            usefunc("get_tranform_eulerangles","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetEulerAngles(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localEulerAngles"){
            usefunc("get_tranform_localeulerangles","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetLocalEulerAngles(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localScale"){
            usefunc("get_tranform_localscale","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetLocalScale(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="lossyScale"){
            usefunc("get_tranform_lossyscale","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetLossyScale(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="forward"){
            usefunc("get_tranform_forward","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetForward(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="right"){
            usefunc("get_tranform_right","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetRight(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="up"){
            usefunc("get_tranform_up","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetUp(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="UnityEngine.Rect"){
        if($member=="size"){
            usefunc("get_rect_size","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y = Utility.RectGetSize(obj, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }elseif($member=="position"){
            usefunc("get_rect_position","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y = Utility.RectGetPosition(obj, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.EntityTransform"){
        if($member=="position"){
            usefunc("get_entitytranform_position","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetPosition(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localPosition"){
            usefunc("get_entitytranform_localposition","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetLocalPosition(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="rotation"){
            usefunc("get_entitytranform_rotation","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z,w = obj:GetRotation(Slua.out, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localRotation"){
            usefunc("get_entitytranform_localrotation","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z,w = obj:GetLocalRotation(Slua.out, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="eulerAngles"){
            usefunc("get_entitytranform_eulerangles","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetEulerAngles(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localEulerAngles"){
            usefunc("get_entitytranform_localeulerangles","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetLocalEulerAngles(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localScale"){
            usefunc("get_entitytranform_localscale","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetLocalScale(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.MovementInfo"){
        if($member=="position"){
            usefunc("get_movementinfo_position","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetPosition(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.PathInfoPoint"){
        if($member=="m_Point"){
            usefunc("get_pathinfopoint_point","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetPoint(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.EntityInfo"){
        if($member=="LastMoveDir"){
            usefunc("get_entityinfo_lastmovedir","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y = obj:GetLastMoveDir(Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="swordHangPosOffset"){
            usefunc("get_entityinfo_swordhangposoffset","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetSwordHangPosOffset(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="swordHangRotOffset"){
            usefunc("get_entityinfo_swordhangrotoffset","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z,w = obj:GetSwordHangPosOffset(Slua.out, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.EntityViewModel"){
        if($member=="position"){
            usefunc("get_entityviewmodel_position","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetPosition(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="SyncOffset"){
            usefunc("get_entityviewmodel_syncoffset","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetSyncOffset(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.AiStateInfo"){
        if($member=="HomePos"){
            usefunc("get_aistateinfo_homepos","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetHomePos(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="TargetPosition"){
            usefunc("get_aistateinfo_targetposition","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetTargetPosition(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="FairyGUI.GObject"){
        if($member=="position"){
            usefunc("get_gobject_position","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GObjectGetPosition(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="scale"){
            usefunc("get_gobject_scale","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y = Utility.GObjectGetScale(obj, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="size"){
            usefunc("get_gobject_size","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y = Utility.GObjectGetSize(obj, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="xy"){
            usefunc("get_gobject_xy","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y = Utility.GObjectGetXY(obj, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }elseif($member=="pivot"){
            usefunc("get_gobject_pivot","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y = Utility.GObjectGetPivot(obj, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="FairyGUI.GTextField"){
        if($member=="color"){
            usefunc("get_gtextfield_color","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,r,g,b,a = Utility.GTextFieldGetColor(obj, Slua.out, Slua.out, Slua.out, Slua.out)
                local c = UnityEngine.Color.New(r,g,b,a)
                table.insert(funcInfo.c_list,c)
                return c
            :};
            return(true);
        }
        elseif($member=="strokeColor"){
            usefunc("get_gtextfield_strokeColor","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,r,g,b,a = Utility.GTextFieldGetStrokeColor(obj, Slua.out, Slua.out, Slua.out, Slua.out)
                local c = UnityEngine.Color.New(r,g,b,a)
                table.insert(funcInfo.c_list,c)
                return c
            :};
            return(true);
        };
    }
    elseif($class=="FairyGUI.InputEvent"){
        if($member=="position"){
            usefunc("get_inputevent_position","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y = Utility.InputEventGetPosition(obj, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="FairyGUI.Stage"){
        if($member=="touchPosition"){
            usefunc("get_stage_touchposition","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y = Utility.StageTouchPositionXY(obj, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="FairyGUI.NTexture"){
        if($member=="uvRect"){
            usefunc("get_ntexture_uvrect","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,w,h = Utility.NTextureGetUvRect(obj, Slua.out, Slua.out, Slua.out, Slua.out)
                local rt = RectPool.Alloc();
                rt.x=x
                rt.y=y
                rt.width=w
                rt.height=h
                table.insert(funcInfo.rt_list,rt)
                return rt
            :};
            return(true);
        };
    }
    elseif($class=="FairyGUI.GImage"){
        if($member=="color"){
            usefunc("get_gimage_color","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,r,g,b,a = Utility.GImageGetColor(obj, Slua.out, Slua.out, Slua.out, Slua.out)
                local c = ColorPool.Alloc();
                c.r=r
                c.g=g
                c.b=b
                c.a=a
                table.insert(funcInfo.c_list,c)
                return c
            :};
            return(true);
        };
    }
    elseif($class=="UnityEngine.Vector2"){
        if($member=="normalized"){
            usefunc("get_vector2_normalized","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local v2 = obj.normalized
                table.insert(funcInfo.v2_list , v2)
                return v2
            :};
            return(true);
        };
    }
    elseif($class=="UnityEngine.Vector3"){
        if($member=="normalized"){
            usefunc("get_vector3_normalized","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local v3 = obj.normalized
                table.insert(funcInfo.v3_list , v3)
                return v3
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.AudioManager"){
        if($member=="Listener_Pos"){
            usefunc("get_audiomanager_listener_pos","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetListenerPos(Slua.out, Slua.out, Slua.out)
                local v3 = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list , v3)
                return v3
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.GlobalVariables"){
        if($member=="m_CygEndCamRot"){
            usefunc("get_GlobalVariables_m_CygEndCamRot","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z,w = CsLibrary.GlobalVariables.GetCygEndCamRot(Slua.out, Slua.out, Slua.out, Slua.out)
                local q = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list , q)
                return q
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.AvatarReferOtherParams"){
        if($member=="mingjian_hang_pos_offset"){
            usefunc("get_AvatarReferOtherParams_mingjian_hang_pos_offset","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetHangPosOffset(Slua.out,Slua.out,Slua.out)
                local v3 = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list , v3)
                return v3
            :};
            return(true);
        }
        elseif($member=="mingjian_hang_rot_offset"){
            usefunc("get_AvatarReferOtherParams_mingjian_hang_rot_offset","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z,w = obj:GetHangRotOffset(Slua.out,Slua.out,Slua.out,Slua.out)
                local q = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list , q)
                return q
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.DecalInfo"){
        if($member=="hsv"){
            usefunc("get_DecalInfo_hsv","(funcInfo, obj)", $funcData, $funcOpts, $sb, $indent, [0,2,3], "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetDecalInfoHSV(obj ,Slua.out,Slua.out,Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list , v)
                return v
            :};
            return(true);
        }
    };
    return(false);
};

script(callexterndelegationreturnstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //callexterndelegationreturnstruct(funcobj, funcobjname, ...)
    return(false);
};

script(callexternextensionreturnstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //callexternextensionreturnstruct(class, member, ...)
    return(false);
};

script(callexternstaticreturnstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //callexternstaticreturnstruct(class, member, ...)
    $class = getargument($funcData, 0);
    $member = getargument($funcData, 1);    
    
    if($class=="Vector3Extension" && $member=="XZ"){
        usefunc("call_vector3_xz","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
        {:
            local v3 = ...
            local _,x,z = Vector3Extension.GetXZ(v3, Slua.out, Slua.out)
            local v2 = UnityEngine.Vector2.New(x,z)
            table.insert(funcInfo.v2_list, v2)
            return v2
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector2"){
        if($member=="Lerp"){
            usefunc("call_vector2_lerp","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local a,b,t = ...
                local _,x,z = Utility.Vector2Lerp(a, b, t, Slua.out, Slua.out)
                local v2 = UnityEngine.Vector2.New(x,z)
                table.insert(funcInfo.v2_list, v2)
                return v2
            :};
            return(true);
        }
        elseif($member=="LerpUnclamped"){
            usefunc("call_vector2_lerpunclamped","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local a,b,t = ...
                local _,x,z = Utility.Vector2LerpUnclamped(a, b, t, Slua.out, Slua.out)
                local v2 = UnityEngine.Vector2.New(x,z)
                table.insert(funcInfo.v2_list, v2)
                return v2
            :};
            return(true);
        }
        elseif($member=="MoveTowards"){
            usefunc("call_vector2_movetowards","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local a,b,t = ...
                local _,x,z = Utility.Vector2MoveTowards(a, b, t, Slua.out, Slua.out)
                local v2 = UnityEngine.Vector2.New(x,z)
                table.insert(funcInfo.v2_list, v2)
                return v2
            :};
            return(true);
        }
        elseif($member=="ClampMagnitude"){
            usefunc("call_vector2_clampmagnitude","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local pos,len = ...
                local _,x,z = Utility.Vector2ClampMagnitude(pos, len, Slua.out, Slua.out)
                local v2 = UnityEngine.Vector2.New(x,z)
                table.insert(funcInfo.v2_list, v2)
                return v2
            :};
            return(true);
        }
        elseif($member=="SmoothDamp"){
            usefunc("call_vector2_smoothdamp","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local current,target,velocity,smoothtime,speed,delta = ...
                local _,vx,vz,x,z = Utility.Vector2SmoothDamp(current, target, velocity, smoothtime, speed, delta, Slua.out, Slua.out, Slua.out, Slua.out)
                velocity.x=vx
                velocity.y=vz
                local v2 = UnityEngine.Vector2.New(x,z)
                table.insert(funcInfo.v2_list, v2)
                return v2,velocity
            :};
            return(true);
        };
    }
    elseif($class=="UnityEngine.Vector3"){
        if($member=="ClampMagnitude"){
            usefunc("call_vector3_clampmagnitude","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local oriV3,maxLength = ...
                local targetV3 = UnityEngine.Vector3.ClampMagnitude(oriV3,maxLength)
                table.insert(funcInfo.v3_list,targetV3)
                return targetV3
            :};
            return(true);
        }
        elseif($member=="Cross"){
            usefunc("call_vector3_cross","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local lv3,rv3 = ...
                local targetV3 = UnityEngine.Vector3.Cross(lv3,rv3)
                table.insert(funcInfo.v3_list,targetV3)
                return targetV3
            :};
            return(true);
        }
        elseif($member=="Lerp"){
            usefunc("call_vector3_lerp","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local fromV3 , toV3 , t = ...
                local targetV3 = UnityEngine.Vector3.Lerp(fromV3,toV3,t)
                table.insert(funcInfo.v3_list , targetV3)
                return targetV3
            :};
            return(true);
        }
        elseif($member=="RotateTowards"){
            usefunc("call_vector3_rotatetowards","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local curV3 , tarV3 ,maxRad , maxMag = ...
                local targetV3 = UnityEngine.Vector3.RotateTowards(curV3,tarV3,maxRad,maxMag)
                table.insert(funcInfo.v3_list, targetV3)
                return targetV3
            :};
            return(true);
        }
        elseif($member=="ProjectOnPlane"){
            usefunc("call_vector3_projectonplane","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local a , b  = ...
                local _,x,y,z = Utility.GetVector3ProjectOnPlane(a,b,Slua.out ,Slua.out ,Slua.out)
                local v3 = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v3)
                return v3
            :};
            return(true);
        }
        elseif($member=="Slerp"){
            usefunc("call_vector3_slerp","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local a , b , t = ...
                local _,x,y,z = Utility.GetVector3Slerp(a,b,t,Slua.out ,Slua.out ,Slua.out)
                local v3 = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v3)
                return v3
            :};
            return(true);
        };
    }
    elseif($class=="UnityEngine.Quaternion"){
        if($member=="Euler__Single__Single__Single"){
            usefunc("call_quaternion_euler","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local x, y, z = ...
                local qua = UnityEngine.Quaternion.Euler__Single__Single__Single(x,y,z)
                table.insert(funcInfo.q_list , qua)
                return qua
            :};
            return(true);
        }
        elseif($member=="Euler__Vector3"){
            usefunc("call_quaternion_euler_v3","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local v3 = ...
                local qua = UnityEngine.Quaternion.Euler__Single__Single__Single(v3.x, v3.y, v3.z)
                table.insert(funcInfo.q_list , qua)
                return qua
            :};
            return(true);
        }
        elseif($member=="Inverse"){
            usefunc("call_quaternion_inverse","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local rotation = ...
                local qua = UnityEngine.Quaternion.Inverse(rotation)
                table.insert(funcInfo.q_list , qua)
                return qua
            :};
            return(true);
        }
        elseif($member=="AngleAxis"){
            usefunc("call_quaternion_angleaxis","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local angle, axis = ...
                local _,x,y,z,w = Utility.QuaternionFromAngleAxis(angle, axis, Slua.out, Slua.out, Slua.out, Slua.out)
                local q = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list , q)
                return q
            :};
            return(true);
        }
        elseif($member=="LookRotation__Vector3" || $member=="LookRotation__Vector3__Vector3"){
            usefunc("call_quaternion_lookrotation","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local forward, upwards = ...
                if upwards==nil then
                    upwards = UnityEngine.Vector3.New(0,1,0)
                    table.insert(funcInfo.v3_list, upwards)
                end
                local _,x,y,z,w = Utility.QuaternionFromLookRotation(forward, upwards, Slua.out, Slua.out, Slua.out, Slua.out)
                local q = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list , q)
                return q
            :};
            return(true);
        }
        elseif($member=="RotateTowards"){
            usefunc("call_quaternion_rotatetowards","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local from, to, delta = ...
                local _,x,y,z,w = Utility.QuaternionRotateToward(from, to, delta, Slua.out, Slua.out, Slua.out, Slua.out)
                local q = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list , q)
                return q
            :};
            return(true);
        }
	elseif($member=="Lerp"){
            usefunc("call_quaternion_lerp","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local fromQ, toQ, t = ...
                local targetQ = UnityEngine.Quaternion.Lerp(fromQ,toQ,t)
                table.insert(funcInfo.q_list , targetQ)
                return targetQ
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.AvatarSystem" && $member=="ConvertHsvToRgb"){
        usefunc("call_avatarsystem_converthsvtorgb","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
        {:
            local h,s,v,a = ...
            local x,y,z,w = CsLibrary.AvatarSystem.ConvertHsvToRgbXYZW(h,s,v,a,Slua.out,Slua.out,Slua.out,Slua.out)
            local v4 = UnityEngine.Vector4.New(x,y,z,w)
            table.insert(funcInfo.v4_list, v4)
            return v4
        :};
        return(true);
    }
    elseif($class=="CsLibrary.MovementUtility"){
        if($member=="ReCalcPosition__WORLD_POS__Boolean"){
            usefunc("call_movementutility_recalcposition_wpos","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local pos,isFly = ...
                local _,x,y,z = CsLibrary.MovementUtility.ReCalcPositionMsgPosForCs2Lua(pos,isFly,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        }
        elseif($member=="ReCalcPosition__Vector3__Boolean"){
            usefunc("call_movementutility_recalcposition_v3","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local pos,isFly = ...
                local _,x,y,z = CsLibrary.MovementUtility.ReCalcPositionV3ForCs2Lua(pos,isFly,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        }
        elseif($member=="GetPositionOnGround__Vector2"){
            usefunc("call_movementutility_getpositiononground_v2","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local x = ...
                local ox,oy,oz = CsLibrary.MovementUtility.GetPositionOnGroundV2ToXYZ(x,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        }        
        elseif($member=="GetPositionOnGround__Vector3"){
            usefunc("call_movementutility_getpositiononground_v3","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local x = ...
                local ox,oy,oz = CsLibrary.MovementUtility.GetPositionOnGroundV3ToXYZ(x,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        }
        elseif($member=="GetPositionOnGround__Single__Single"){
            usefunc("call_movementutility_getpositiononground_xy","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local x,y = ...
                local ox,oy,oz = CsLibrary.MovementUtility.GetPositionOnGroundXYToXYZ(x,y,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        }
        elseif($member=="GetPositionOnGround__Single__Single__Single"){
            usefunc("call_movementutility_getpositiononground_xyz","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local x,y,z = ...
                local ox,oy,oz = CsLibrary.MovementUtility.GetPositionOnGroundXYZToXYZ(x,y,z,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        }        
        elseif($member=="GetPositionOnNavMesh"){
            usefunc("call_movementutility_getpositiononnavmesh","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local pos,dist = ...
                local ox,oy,oz = CsLibrary.MovementUtility.GetPositionOnNavMeshXYZ(pos,dist,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        }
        elseif($member=="TrySamplePosOnNavMesh"){
            usefunc("call_movementutility_trysampleposonnavmesh","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local pos,_,dist = ...
                local r,ox,oy,oz = CsLibrary.MovementUtility.TrySamplePosOnNavMeshXYZ(pos,dist,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return r,obj
            :};
            return(true);
        }
        elseif($member=="CheckPosBeyondNavMesh"){
            usefunc("call_movementutility_checkposbeyondnavmesh","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local pos,needDown,dist = ...
                local r,needDown,ox,oy,oz = CsLibrary.MovementUtility.CheckPosBeyondNavMeshXYZ(pos,needDown,dist,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return r,needDown,obj
            :};
            return(true);
        }
        elseif($member=="WalkOnNavMesh"){
            usefunc("call_movementutility_walkonnavmesh","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local from,to = ...
                local ox,oy,oz = CsLibrary.MovementUtility.WalkOnNavMeshXYZ(from,to,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        }
        elseif($member=="GetRayCastPosInNavMesh3"){
            usefunc("call_movementutility_getraycastposinnavmesh3","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local pos = ...
                local r,ox,oy,oz = CsLibrary.MovementUtility.GetRayCastPosInNavMesh3XYZ(pos,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return r,obj
            :};
            return(true);
        }
        elseif($member=="SceneColliderTryMove"){
            usefunc("call_movementutility_scenecollidertrymove","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local oldPos,newPos,radius = ...
                local ox,oy,oz = CsLibrary.MovementUtility.SceneColliderTryMoveXYZ(oldPos,newPos,radius,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        };
    }
    elseif($class=="PluginFramework.Skill.SkillUtils"){
        if($member=="FromWorldDir"){
            usefunc("call_skillutils_fromworlddir","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local worldDir = ...
                local ox,oy,oz = PluginFramework.Skill.SkillUtils.WorldDirToXYZ(worldDir,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        }
        elseif($member=="WorldPos2Vector3"){
            usefunc("call_skillutils_worldpos2vector3","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local worldPos = ...
                local ox,oy,oz = PluginFramework.Skill.SkillUtils.WorldPosToV3(worldPos,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        }
        elseif($member=="CalcDefaultTargetPos"){
            usefunc("call_skillutils_calcdefaulttargetpos","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local casterEntity, skillId = ...
                local ox,oy,oz = PluginFramework.Skill.SkillUtils.CalcDefaultTargetPosXYZ(casterEntity,skillId,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        };
    }elseif($class=="CsLibrary.TimeUtility"){
        if($member=="GetDateTimeBySecond"){
            usefunc("call_TimeUtility_GetDateTimeBySecond","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local timeVal = ...
                local y,m,d,hh,mm,ss,ms = CsLibrary.TimeUtility.GetDateTimeBySecondToLua(timeVal,Slua.out,Slua.out,Slua.out,Slua.out,Slua.out,Slua.out,Slua.out)
                local obj = DateTimePool.Alloc()
                obj:SetDateTime(y,m,d,hh,mm,ss,ms)
                table.insert(funcInfo.dt_list, obj)
                return obj
            :};
            return(true);
        };
    }elseif($class=="UnityEngine.Rect"){
        if($member=="MinMaxRect"){
            usefunc("call_Rect_MinMaxRect","(funcInfo, ...)", $funcData, $funcOpts, $sb, $indent, 2, "__cs2lua_func_info")
            {:
                local xmin,ymin,xmax,ymax = ...
                local rt = RectPool.Alloc()
                rt.x = xmin
                rt.y = ymin
                rt.width = xmax - xmin
                rt.height = ymax - ymin
                table.insert(funcInfo.rt_list, rt)
                return rt
            :};
            return(true);
        };
    };
    return(false);
};

script(callexterninstancereturnstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //callexterninstancereturnstruct(obj, class, member, ...)
    $class = getargument($funcData, 1);
    $member = getargument($funcData, 2);
    
    if($class=="UnityEngine.Camera"){
        if($member=="ViewportPointToRay__Vector3"){
            usefunc("call_camera_viewportpointtoray_ray_v3","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt,eye = ...
                local _,ox,oy,oz,dx,dy,dz = Utility.ViewportPointToRayV3(obj, pt, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out)
                local ori = UnityEngine.Vector3.New(ox,oy,oz)
                local dir = UnityEngine.Vector3.New(dx,dy,dz)
                table.insert(funcInfo.v3_list, ori)
                table.insert(funcInfo.v3_list, dir)
                return UnityEngine.Ray.ctor__Vector3__Vector3(ori,dir)
            :};
            return(true);
        }
        elseif($member=="ViewportPointToRay__Vector3__MonoOrStereoscopicEye"){
            usefunc("call_camera_viewportpointtoray_ray_v3_eye","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt,eye = ...
                if getobjtypename(pt)=="Vector3" then
                    local _,ox,oy,oz,dx,dy,dz = Utility.ViewportPointToRayV3Eye(obj, pt, eye, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out)
                    local ori = UnityEngine.Vector3.New(ox,oy,oz)
                    local dir = UnityEngine.Vector3.New(dx,dy,dz)
                    table.insert(funcInfo.v3_list, ori)
                    table.insert(funcInfo.v3_list, dir)
                    return UnityEngine.Ray.ctor__Vector3__Vector3(ori,dir)
                else
                    local _,ox,oy,oz,dx,dy,dz = Utility.ViewportPointToRayV2Eye(obj, pt, eye, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out)
                    local ori = UnityEngine.Vector3.New(ox,oy,oz)
                    local dir = UnityEngine.Vector3.New(dx,dy,dz)
                    table.insert(funcInfo.v3_list, ori)
                    table.insert(funcInfo.v3_list, dir)
                    return UnityEngine.Ray.ctor__Vector3__Vector3(ori,dir)
                end
            :};
            return(true);
        }
        elseif($member=="WorldToScreenPoint__Vector3"){
            usefunc("call_camera_worldtoscreenpoint_v3","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt,eye = ...
                local _,ox,oy,oz = Utility.WorldToScreenPointV3(obj, pt, Slua.out, Slua.out, Slua.out)
                local ori = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, ori)
                return ori
            :};
            return(true);
        }
        elseif($member=="WorldToScreenPoint__Vector3__MonoOrStereoscopicEye"){
            usefunc("call_camera_worldtoscreenpoint_v3_eye","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt,eye = ...
                local _,ox,oy,oz = Utility.WorldToScreenPointV3Eye(obj, pt, eye, Slua.out, Slua.out, Slua.out)
                local ori = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, ori)
                return ori
            :};
            return(true);
        }
        elseif($member=="WorldToViewportPoint__Vector3"){
            usefunc("call_camera_worldtoviewportpoint_v3","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt,eye = ...
                local _,ox,oy,oz = Utility.WorldToViewportPointV3(obj, pt, Slua.out, Slua.out, Slua.out)
                local ori = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, ori)
                return ori
            :};
            return(true);            
        }
        elseif($member=="WorldToViewportPoint__Vector3__MonoOrStereoscopicEye"){
            usefunc("call_camera_worldtoviewportpoint_v3_eye","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt,eye = ...
                local _,ox,oy,oz = Utility.WorldToViewportPointV3Eye(obj, pt, eye, Slua.out, Slua.out, Slua.out)
                local ori = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, ori)
                return ori
            :};
            return(true);            
        };
    }
    elseif($class=="UnityEngine.Transform"){
        if($member=="TransformDirection__Single__Single__Single"){
            usefunc("call_transform_transformdirection_xyz","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local x,y,z = ...
                local _,ox,oy,oz = Utility.TransformDirectionXYZ(obj, x, y, z, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="TransformDirection__Vector3"){
            usefunc("call_transform_transformdirection_v3","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt = ...
                local _,ox,oy,oz = Utility.TransformDirectionV3(obj, pt, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="TransformPoint__Single__Single__Single"){
            usefunc("call_transform_transformpoint_xyz","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local x,y,z = ...
                local _,ox,oy,oz = Utility.TransformPointXYZ(obj, x, y, z, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="TransformPoint__Vector3"){
            usefunc("call_transform_transformpoint_v3","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt = ...                
                local _,ox,oy,oz = Utility.TransformPointV3(obj, pt, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="TransformVector__Single__Single__Single"){
            usefunc("call_transform_transformvector_xyz","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local x,y,z = ...
                local _,ox,oy,oz = Utility.TransformVectorXYZ(obj, x, y, z, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="TransformVector__Vector3"){
            usefunc("call_transform_transformvector_v3","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt = ...
                local _,ox,oy,oz = Utility.TransformVectorV3(obj, pt, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="InverseTransformDirection__Single__Single__Single"){
            usefunc("call_transform_inversetransformdirection_xyz","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local x,y,z = ...
                local _,ox,oy,oz = Utility.InverseTransformDirectionXYZ(obj, x, y, z, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="InverseTransformDirection__Vector3"){
            usefunc("call_transform_inversetransformdirection_v3","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt = ...
                local _,ox,oy,oz = Utility.InverseTransformDirectionV3(obj, pt, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="InverseTransformPoint__Single__Single__Single"){
            usefunc("call_transform_inversetransformpoint_xyz","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local x,y,z = ...
                local _,ox,oy,oz = Utility.InverseTransformPointXYZ(obj, x, y, z, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="InverseTransformPoint__Vector3"){
            usefunc("call_transform_inversetransformpoint_v3","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt = ...
                local _,ox,oy,oz = Utility.InverseTransformPointV3(obj, pt, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="InverseTransformVector__Single__Single__Single"){
            usefunc("call_transform_inversetransformvector_xyz","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local x,y,z = ...
                local _,ox,oy,oz = Utility.InverseTransformVectorXYZ(obj, x, y, z, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="InverseTransformVector__Vector3"){
            usefunc("call_transform_inversetransformvector_v3","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt = ...
                local _,ox,oy,oz = Utility.InverseTransformVectorV3(obj, pt, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.EntityTransform"){
        if($member=="TransformDirection"){ 
            usefunc("call_entitytransform_transformdirection","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local x = ...           
                local _,ox,oy,oz = obj:TransformDirectionV3(x, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="TransformPoint"){ 
            usefunc("call_entitytransform_transformpoint","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local x = ...           
                local _,ox,oy,oz = obj:TransformPointV3(x, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="TransformVector"){ 
            usefunc("call_entitytransform_transformvector","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local x = ...           
                local _,ox,oy,oz = obj:TransformVectorV3(x, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="InverseTransformDirection"){ 
            usefunc("call_entitytransform_inversetransformdirection","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local x = ...           
                local _,ox,oy,oz = obj:InverseTransformDirectionV3(x, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="InverseTransformPoint"){ 
            usefunc("call_entitytransform_inversetransformpoint","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local x = ...           
                local _,ox,oy,oz = obj:InverseTransformPointV3(x, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="InverseTransformVector"){ 
            usefunc("call_entitytransform_inversetransformvector","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local x = ...           
                local _,ox,oy,oz = obj:InverseTransformVectorV3(x, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="FairyGUI.DisplayObject"){
        if($member=="GlobalToLocal"){
            usefunc("call_displayobject_globaltolocal","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt = ...
                local _,x,y = Utility.DisplayObjectGlobalToLocal(obj, pt, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="LocalToGlobal"){
            usefunc("call_displayobject_localtoglobal","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt = ...
                local _,x,y = Utility.DisplayObjectLocalToGlobal(obj, pt, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="FairyGUI.GObject"){
        if($member=="GlobalToLocal__Rect"){
            usefunc("call_gobject_globaltolocal_rt","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local ptOrRt = ...
                local _,x,y,w,h = Utility.GObjectGlobalToLocalRect(obj, ptOrRt, Slua.out, Slua.out, Slua.out, Slua.out)
                local v = RectPool.Alloc()
                v.x=x
                v.y=y
                v.width=w
                v.height=h
                table.insert(funcInfo.rt_list,v)
                return v
            :};
            return(true);
        }
        elseif($member=="GlobalToLocal__Vector2"){
            usefunc("call_gobject_globaltolocal_v2","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local ptOrRt = ...
                local _,x,y = Utility.GObjectGlobalToLocal(obj, ptOrRt, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="LocalToGlobal__Rect"){
            usefunc("call_gobject_localtoglobal_rt","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local ptOrRt = ...
                local _,x,y,w,h = Utility.GObjectLocalToGlobalRect(obj, ptOrRt, Slua.out, Slua.out, Slua.out, Slua.out)
                local v = RectPool.Alloc()
                v.x=x
                v.y=y
                v.width=w
                v.height=h
                table.insert(funcInfo.rt_list,v)
                return v
            :};
            return(true);
        }        
        elseif($member=="LocalToGlobal__Vector2"){
            usefunc("call_gobject_localtoglobal_v2","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local ptOrRt = ...                
                local _,x,y = Utility.GObjectLocalToGlobal(obj, ptOrRt, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="LocalToRoot"){
            usefunc("call_gobject_localtoroot","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt, root = ...
                local _,x,y = Utility.GObjectLocalToRoot(obj, pt, root, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="TransformPoint"){
            usefunc("call_gobject_transformpoint","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local pt, targetSpace = ...
                local _,x,y = Utility.GObjectTransformPoint(obj, pt, targetSpace, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }
        elseif($memeber=="TransformRect"){
            usefunc("call_gobject_transformrect","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local rt, targetSpace = ...
                local _,x,y,w,h = Utility.GObjectLocalToGlobalRect(obj, rt, targetSpace, Slua.out, Slua.out, Slua.out, Slua.out)
                local v = RectPool.Alloc()
                v.x=x
                v.y=y
                v.width=w
                v.height=h
                table.insert(funcInfo.rt_list,v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="FairyGUI.Stage"){
        if($member=="GetTouchPosition"){
            usefunc("call_stage_gettouchposition","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local touchId = ...
                local _,x,y = Utility.StageGetTouchPosition(obj, touchId, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.DateTime"){
        if($member=="ToLocalTime"){
            usefunc("call_DateTime_ToLocalTime","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local y,m,d,hh,mm,ss,ms = CsLibrary.DateTime.DateTimeToLocalTime(obj,Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out)
                local dt = DateTimePool.Alloc()
                dt:SetDateTimeAndMillisecond(y,m,d,hh,mm,ss,ms)
                table.insert(funcInfo.dt_list, dt)
                return dt
            :};
            return(true);
        }
        elseif($member=="AddSeconds"){
            usefunc("call_DateTime_AddSeconds","(funcInfo, obj, ...)", $funcData, $funcOpts, $sb, $indent, [1,2], "__cs2lua_func_info")
            {:
                local seconds = ...
                local y,m,d,hh,mm,ss,ms = CsLibrary.DateTime.DateTimeAddSeconds(obj,seconds,Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out)
                local dt = DateTimePool.Alloc()
                dt:SetDateTimeAndMillisecond(y,m,d,hh,mm,ss,ms)
                table.insert(funcInfo.dt_list, dt)
                return dt
            :};
            return(true);
        };
    };
    return(false);
};

script(recycleandkeepstructvalue)args($funcData, $funcOpts, $sb, $indent)
{
    //recycleandkeepstructvalue(fieldType, oldVal, newVal)
    $fieldType = getargument($funcData, 0);
    
    if($fieldType=="UnityEngine.Vector2"){
        usefunc("recycle_and_keep_vector2","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            recycleandkeepcheck(funcInfo, fieldType, oldVal, newVal)
            if not rawequal(oldVal,newVal) and oldVal~=nil then
                Vector2Pool.Recycle(oldVal)
            end
            if newVal~=nil then
                luatableremove(funcInfo.v2_list, newVal)
            end
        :};
        return(true);
    }
    elseif($fieldType=="UnityEngine.Vector3"){
        usefunc("recycle_and_keep_vector3","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            recycleandkeepcheck(funcInfo, fieldType, oldVal, newVal)
            if not rawequal(oldVal,newVal) and oldVal~=nil then
                Vector3Pool.Recycle(oldVal)
            end
            if newVal~=nil then
                luatableremove(funcInfo.v3_list, newVal)
            end
        :};
        return(true);
    }
    elseif($fieldType=="UnityEngine.Vector4"){
        usefunc("recycle_and_keep_vector4","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            recycleandkeepcheck(funcInfo, fieldType, oldVal, newVal)
            if not rawequal(oldVal,newVal) and oldVal~=nil then
                Vector4Pool.Recycle(oldVal)
            end
            if newVal~=nil then
                luatableremove(funcInfo.v4_list, newVal)
            end
        :};
        return(true);
    }
    elseif($fieldType=="UnityEngine.Quaternion"){
        usefunc("recycle_and_keep_quaternion","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            recycleandkeepcheck(funcInfo, fieldType, oldVal, newVal)
            if not rawequal(oldVal,newVal) and oldVal~=nil then
                QuaternionPool.Recycle(oldVal)
            end
            if newVal~=nil then
                luatableremove(funcInfo.q_list, newVal)
            end
        :};
        return(true);
    }
    elseif($fieldType=="UnityEngine.Color"){
        usefunc("recycle_and_keep_color","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            recycleandkeepcheck(funcInfo, fieldType, oldVal, newVal)
            if not rawequal(oldVal,newVal) and oldVal~=nil then
                ColorPool.Recycle(oldVal)
            end
            if newVal~=nil then
                luatableremove(funcInfo.c_list, newVal)
            end
        :};
        return(true);
    }
    elseif($fieldType=="UnityEngine.Color32"){
        usefunc("recycle_and_keep_color32","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            recycleandkeepcheck(funcInfo, fieldType, oldVal, newVal)
            if not rawequal(oldVal,newVal) and oldVal~=nil then
                Color32Pool.Recycle(oldVal)
            end
            if newVal~=nil then
                luatableremove(funcInfo.c32_list, newVal)
            end
        :};
        return(true);
    }
    elseif($fieldType=="UnityEngine.Rect"){
        usefunc("recycle_and_keep_rect","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            recycleandkeepcheck(funcInfo, fieldType, oldVal, newVal)
            if not rawequal(oldVal,newVal) and oldVal~=nil then
                RectPool.Recycle(oldVal)
            end
            if newVal~=nil then
                luatableremove(funcInfo.rt_list, newVal)
            end
        :};
        return(true);
    }
    elseif($fieldType=="CsLibrary.DateTime"){
        usefunc("recycle_and_keep_datetime","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            recycleandkeepcheck(funcInfo, fieldType, oldVal, newVal)
            if not rawequal(oldVal,newVal) and oldVal~=nil then
                DateTimePool.Recycle(oldVal)
            end
            if newVal~=nil then
                luatableremove(funcInfo.dt_list, newVal)
            end
        :};
        return(true);
    }
    elseif($fieldType=="CsLibrary.TimeSpan"){
        usefunc("recycle_and_keep_timespan","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            recycleandkeepcheck(funcInfo, fieldType, oldVal, newVal)
            if not rawequal(oldVal,newVal) and oldVal~=nil then
                TimeSpanPool.Recycle(oldVal)
            end
            if newVal~=nil then
                luatableremove(funcInfo.ts_list, newVal)
            end
        :};
        return(true);
    }
    elseif($fieldType=="CsLibrary.PathInfoPoint"){
        usefunc("recycle_and_keep_PathInfoPoint","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            recycleandkeepcheck(funcInfo, fieldType, oldVal, newVal)
            if not rawequal(oldVal,newVal) and oldVal~=nil then
                PathInfoPointPool.Recycle(oldVal)
            end
            if newVal~=nil then
                luatableremove(funcInfo.pip_list, newVal)
            end
        :};
        return(true);
    };
    return(false);
};

script(removefromcallerfuncinfo)args($funcData, $funcOpts, $sb, $indent)
{
    //removefromcallerfuncinfo(class, val)
    $class = getargument($funcData, 0);
    
    if($class=="UnityEngine.Vector2"){
        usefunc("remove_from_caller_func_info_vector2","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(cfi.v2_list, val)
                end
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3"){
        usefunc("remove_from_caller_func_info_vector3","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(cfi.v3_list, val)
                end
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector4"){
        usefunc("remove_from_caller_func_info_vector4","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(cfi.v4_list, val)
                end
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Quaternion"){
        usefunc("remove_from_caller_func_info_quaternion","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(cfi.q_list, val)
                end
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color"){
        usefunc("remove_from_caller_func_info_color","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(cfi.c_list, val)
                end
            end
        :};
        return(true);
    }
    elseif($class=="nityEngine.Color32"){
        usefunc("remove_from_caller_func_info_color32","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(cfi.c32_list, val)
                end
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Rect"){
        usefunc("remove_from_caller_func_info_rect","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(cfi.rt_list, val)
                end
            end
        :};
        return(true);
    }
    elseif($class=="CsLibrary.DateTime"){
        usefunc("remove_from_caller_func_info_datetime","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(cfi.dt_list, val)
                end
            end
        :};
        return(true);
    }
    elseif($class=="CsLibrary.TimeSpan"){
        usefunc("remove_from_caller_func_info_timespan","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(cfi.ts_list, val)
                end
            end
        :};
        return(true);
    }
    elseif($class=="CsLibrary.PathInfoPoint"){
        usefunc("remove_from_caller_func_info_pathinfopoint","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(cfi.pip_list, val)
                end
            end
        :};
        return(true);
    };
    return(false);
};

script(removefromfuncinfo)args($funcData, $funcOpts, $sb, $indent)
{
    //removefromfuncinfo(class, val)
    $class = getargument($funcData, 0);
    
    if($class=="UnityEngine.Vector2"){
        usefunc("remove_from_func_info_vector2","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local result = luatableremove(funcInfo.v2_list, val)
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3"){
        usefunc("remove_from_func_info_vector3","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local result = luatableremove(funcInfo.v3_list, val)
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector4"){
        usefunc("remove_from_func_info_vector4","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local result = luatableremove(funcInfo.v4_list, val)
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Quaternion"){
        usefunc("remove_from_func_info_quaternion","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local result = luatableremove(funcInfo.q_list, val)
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color"){
        usefunc("remove_from_func_info_color","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local result = luatableremove(funcInfo.c_list, val)
            end
        :};
        return(true);
    }
    elseif($class=="nityEngine.Color32"){
        usefunc("remove_from_func_info_color32","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local result = luatableremove(funcInfo.c32_list, val)
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Rect"){
        usefunc("remove_from_func_info_rect","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local result = luatableremove(funcInfo.rt_list, val)
            end
        :};
        return(true);
    }
    elseif($class=="CsLibrary.DateTime"){
        usefunc("remove_from_func_info_datetime","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local result = luatableremove(funcInfo.dt_list, val)
            end
        :};
        return(true);
    }
    elseif($class=="CsLibrary.TimeSpan"){
        usefunc("remove_from_func_info_timespan","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local result = luatableremove(funcInfo.ts_list, val)
            end
        :};
        return(true);
    }
    elseif($class=="CsLibrary.PathInfoPoint"){
        usefunc("remove_from_func_info_pathinfopoint","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local result = luatableremove(funcInfo.pip_list, val)
            end
        :};
        return(true);
    };
    return(false);
};

script(movetocallerfuncinfo)args($funcData, $funcOpts, $sb, $indent)
{
    //movetocallerfuncinfo(class, val)
    $class = getargument($funcData, 0);
    
    if($class=="UnityEngine.Vector2"){
        usefunc("move_to_caller_vector2","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(funcInfo.v2_list, val)
                    if result then
                        table.insert(cfi.v2_list, val)
                    end
                end
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3"){
        usefunc("move_to_caller_vector3","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(funcInfo.v3_list, val)
                    if result then
                        table.insert(cfi.v3_list, val)
                    end
                end
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector4"){
        usefunc("move_to_caller_vector4","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(funcInfo.v4_list, val)
                    if result then
                        table.insert(cfi.v4_list, val)
                    end
                end
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Quaternion"){
        usefunc("move_to_caller_quaternion","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(funcInfo.q_list, val)
                    if result then
                        table.insert(cfi.q_list, val)
                    end
                end
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color"){
        usefunc("move_to_caller_color","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(funcInfo.c_list, val)
                    if result then
                        table.insert(cfi.c_list, val)
                    end
                end
            end
        :};
        return(true);
    }
    elseif($class=="nityEngine.Color32"){
        usefunc("move_to_caller_color32","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(funcInfo.c32_list, val)
                    if result then
                        table.insert(cfi.c32_list, val)
                    end
                end
            end
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Rect"){
        usefunc("move_to_caller_rect","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(funcInfo.rt_list, val)
                    if result then
                        table.insert(cfi.rt_list, val)
                    end
                end
            end
        :};
        return(true);
    }
    elseif($class=="CsLibrary.DateTime"){
        usefunc("move_to_caller_datetime","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(funcInfo.dt_list, val)
                    if result then
                        table.insert(cfi.dt_list, val)
                    end
                end
            end
        :};
        return(true);
    }
    elseif($class=="CsLibrary.TimeSpan"){
        usefunc("move_to_caller_timespan","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(funcInfo.ts_list, val)
                    if result then
                        table.insert(cfi.ts_list, val)
                    end
                end
            end
        :};
        return(true);
    }
    elseif($class=="CsLibrary.PathInfoPoint"){
        usefunc("move_to_caller_pathinfopoint","(funcInfo, class, val)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            if val~=nil then
                local cfi = luagetcallerfuncinfo()
                if cfi then
                    local result = luatableremove(funcInfo.pip_list, val)
                    if result then 
                        table.insert(cfi.pip_list, val)
                    end
                end
            end
        :};
        return(true);
    };
    return(false);
};

script(newstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //newstruct(class, keystr, typeargs, typekinds, ctor, ctorRetCt, initializer, ...)
    return(false);
};

script(newexternstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //newexternstruct(class, keystr, typeargs, typekinds, ctor, ctorRetCt, initializer, ...)
    $class = getargument($funcData, 0);
    
    if($class=="System.Nullable_T"){
        usefunc("new_nullable","(funcInfo, initializer, ...)", $funcData, $funcOpts, $sb, $indent, 6, "__cs2lua_func_info")
        {:
            return nil
        :};
        return(true);
    }
    elseif($class=="System.Collections.Generic.KeyValuePair_TKey_TValue"){
        usefunc("new_keyvaluepair","(funcInfo, initializer, ...)", $funcData, $funcOpts, $sb, $indent, 6, "__cs2lua_func_info")
        {:
            local arg1,arg2 = ...
            return {Key = arg1, Value = arg2}
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector2"){
        usefunc("new_vector2","(funcInfo, initializer, ...)", $funcData, $funcOpts, $sb, $indent, 6, "__cs2lua_func_info")
        {:
            local x,y = ...
            local obj = UnityEngine.Vector2.New(x,y)
            table.insert(funcInfo.v2_list, obj)
            if obj and initializer then
                initializer(obj)
            end
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3"){
        usefunc("new_vector3","(funcInfo, initializer, ...)", $funcData, $funcOpts, $sb, $indent, 6, "__cs2lua_func_info")
        {:
            local x,y,z = ...
            local obj = UnityEngine.Vector3.New(x,y,z)
            table.insert(funcInfo.v3_list, obj)
            if obj and initializer then
                initializer(obj)
            end
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector4"){
        usefunc("new_vector4","(funcInfo, initializer, ...)", $funcData, $funcOpts, $sb, $indent, 6, "__cs2lua_func_info")
        {:
            local x,y,z,w = ...
            local obj = UnityEngine.Vector4.New(x,y,z,w)
            table.insert(funcInfo.v4_list, obj)
            if obj and initializer then
                initializer(obj)
            end
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Quaternion"){
        usefunc("new_quaternion","(funcInfo, initializer, ...)", $funcData, $funcOpts, $sb, $indent, 6, "__cs2lua_func_info")
        {:
            local x,y,z,w = ...
            local obj = UnityEngine.Quaternion.New(x,y,z,w)
            table.insert(funcInfo.q_list, obj)
            if obj and initializer then
                initializer(obj)
            end
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color"){
        usefunc("new_color","(funcInfo, initializer, ...)", $funcData, $funcOpts, $sb, $indent, 6, "__cs2lua_func_info")
        {:
            local r,g,b,a = ...
            local obj = UnityEngine.Color.New(r,g,b,a)
            table.insert(funcInfo.c_list, obj)
            if obj and initializer then
                initializer(obj)
            end
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color32"){
        usefunc("new_color32","(funcInfo, initializer, ...)", $funcData, $funcOpts, $sb, $indent, 6, "__cs2lua_func_info")
        {:
            local r,g,b,a = ...
            local obj = Color32Pool.Alloc()
            obj.r=r or 0
            obj.g=g or 0
            obj.b=b or 0
            obj.a=a or 1
            table.insert(funcInfo.c32_list, obj)
            if obj and initializer then
                initializer(obj)
            end
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Rect"){
        usefunc("new_rect","(funcInfo, initializer, ...)", $funcData, $funcOpts, $sb, $indent, 6, "__cs2lua_func_info")
        {:
            local p1,p2,p3,p4 = ...
            local obj = RectPool.Alloc()
            if p3~=nil and p4~=nil then
                obj.x=p1
                obj.y=p2
                obj.width=p3
                obj.height=p4
            elseif p2~=nil then
                obj.x=p1.x
                obj.y=p1.y
                obj.width=p2.x
                obj.height=p2.y
            elseif p1~=nil then
                obj.x=p1.x
                obj.y=p1.y
                obj.width=p1.width
                obj.height=p1.height
            end
            table.insert(funcInfo.rt_list, obj)
            if obj and initializer then
                initializer(obj)
            end
            return obj
        :};
        return(true);
    }
    elseif($class=="CsLibrary.PathInfoPoint"){
        usefunc("new_pathinfopoint","(funcInfo, initializer, ...)", $funcData, $funcOpts, $sb, $indent, 6, "__cs2lua_func_info")
        {:
            local point,fly,stoppoint,movetype,distance = ...
            local obj =  PathInfoPointPool.Alloc()
            obj.m_Point = point;
            obj.m_Fly = fly or false;
            obj.m_MoveType = movetype or 0;
            obj.m_JumpIndex = -1;
            obj.m_SpeedScale = 1;
            obj.m_Distance = distance;
            obj.m_LookTargetObjID = -1;
            table.insert(funcInfo.pip_list, obj)
            if obj and initializer then
                initializer(obj)
            end
            return obj
        :};
        return(true);
    }
    elseif($class=="CsLibrary.DateTime"){
        usefunc("new_DateTime","(funcInfo, initializer, ...)", $funcData, $funcOpts, $sb, $indent, 6, "__cs2lua_func_info")
        {:
            local argnum = select('#', ...)
            local obj =  DateTimePool.Alloc()
            if argnum == 3 then
                local p1,p2,p3 = ...
                obj:SetDate(p1,p2,p3)
                table.insert(funcInfo.dt_list, obj)
                return obj
            elseif argnum == 6 then
                local p1,p2,p3,p4,p5,p6 = ...
                obj:SetDateTime(p1,p2,p3,p4,p5,p6)
                table.insert(funcInfo.dt_list, obj)
                return obj
            elseif  argnum == 7 then
                local p1,p2,p3,p4,p5,p6,p7 = ...
                obj:SetDateTimeAndMillisecond(p1,p2,p3,p4,p5,p6,p7)
                table.insert(funcInfo.dt_list, obj)
                return obj
            end
        :};
        return(true);
    }
    elseif($class=="CsLibrary.TimeSpan"){
        usefunc("new_TimeSpan","(funcInfo, initializer, ...)", $funcData, $funcOpts, $sb, $indent, 6, "__cs2lua_func_info")
        {:
            local argnum = select('#', ...)
            local obj =  TimeSpanPool.Alloc()
            if argnum == 3 then
                local p1,p2,p3 = ...
                obj:SetTimeHMS(p1,p2,p3)
                table.insert(funcInfo.ts_list, obj)
                return obj
            end
        :};
        return(true);
    };
    return(false);
};

script(invokeexternoperatorreturnstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //invokeexternoperatorreturnstruct(rettype, class, method, ...)
    $rettype = getargument($funcData, 0);
    $class = getargument($funcData, 1);
    $method = getargument($funcData, 2);
    
    //首行的缩进cs2lua已经处理，新行需要自己添加缩进
    //writeindent($sb, $indent);
    writesymbol($sb, "invokeexternoperatorreturnstructimpl");
    writesymbol($sb, "(__cs2lua_func_info, ");
    writearguments($sb, $funcData, $funcOpts, $indent, 0);
    writesymbol($sb, ")");
    return(true);
};

script(literalarray)args($funcData, $funcOpts, $sb, $indent)
{
    //literalarray(classObj, typeKind, ...)
    $class = getargument($funcData, 0);
    $typeKind = getargument($funcData, 1);
    
    if($typeKind == "TypeKind.Struct"){            
        if($class=="UnityEngine.Vector2"){
            usefunc("wrap_vector2_array","(funcInfo, classObj, typeKind, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
            {:
                local newarr = wraparray({...}, nil, classObj, typeKind)
                for i,v in ipairs(newarr) do
                    if v~=nil then
                        luatableremove(funcInfo.v2_list, v)
                    end
                end
                return newarr;
            :};
            return(true);
        }
        elseif($class=="UnityEngine.Vector3"){
            usefunc("wrap_vector3_array","(funcInfo, classObj, typeKind, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
            {:
                local newarr = wraparray({...}, nil, classObj, typeKind)
                for i,v in ipairs(newarr) do
                    if v~=nil then
                        luatableremove(funcInfo.v3_list, v)
                    end
                end
                return newarr;
            :};
            return(true);
        }
        elseif($class=="UnityEngine.Vector4"){
            usefunc("wrap_vector4_array","(funcInfo, classObj, typeKind, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
            {:
                local newarr = wraparray({...}, nil, classObj, typeKind)
                for i,v in ipairs(newarr) do
                    if v~=nil then
                        luatableremove(funcInfo.v4_list, v)
                    end
                end
                return newarr;
            :};
            return(true);
        }
        elseif($class=="UnityEngine.Quaternion"){
            usefunc("wrap_quaternion_array","(funcInfo, classObj, typeKind, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
            {:
                local newarr = wraparray({...}, nil, classObj, typeKind)
                for i,v in ipairs(newarr) do
                    if v~=nil then
                        luatableremove(funcInfo.q_list, v)
                    end
                end
                return newarr;
            :};
            return(true);
        }
        elseif($class=="UnityEngine.Color"){
            usefunc("wrap_color_array","(funcInfo, classObj, typeKind, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
            {:
                local newarr = wraparray({...}, nil, classObj, typeKind)
                for i,v in ipairs(newarr) do
                    if v~=nil then
                        luatableremove(funcInfo.c_list, v)
                    end
                end
                return newarr;
            :};
            return(true);
        }
        elseif($class=="nityEngine.Color32"){
            usefunc("wrap_color32_array","(funcInfo, classObj, typeKind, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
            {:
                local newarr = wraparray({...}, nil, classObj, typeKind)
                for i,v in ipairs(newarr) do
                    if v~=nil then
                        luatableremove(funcInfo.c32_list, v)
                    end
                end
                return newarr;
            :};
            return(true);
        }
        elseif($class=="UnityEngine.Rect"){
            usefunc("wrap_rect_array","(funcInfo, classObj, typeKind, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
            {:
                local newarr = wraparray({...}, nil, classObj, typeKind)
                for i,v in ipairs(newarr) do
                    if v~=nil then
                        luatableremove(funcInfo.rt_list, v)
                    end
                end
                return newarr;
            :};
            return(true);
        }
        elseif($class=="sLibrary.DateTime"){
            usefunc("wrap_datetime_array","(funcInfo, classObj, typeKind, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
            {:
                local newarr = wraparray({...}, nil, classObj, typeKind)
                for i,v in ipairs(newarr) do
                    if v~=nil then
                        luatableremove(funcInfo.dt_list, v)
                    end
                end
                return newarr;
            :};
            return(true);
        }
        elseif($class=="CsLibrary.TimeSpan"){
            usefunc("wrap_timespan_array","(funcInfo, classObj, typeKind, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
            {:
                local newarr = wraparray({...}, nil, classObj, typeKind)
                for i,v in ipairs(newarr) do
                    if v~=nil then
                        luatableremove(funcInfo.ts_list, v)
                    end
                end
                return newarr;
            :};
            return(true);
        };    
    };
    return(false);
};

script(getstaticindexerstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //getstaticindexerstruct(isExtern, elementType, callerClass, class, name, argCount, ...)
    $elementtype = getargument($funcData, 1);
    
    return(false);
};

script(getinstanceindexerstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //getinstanceindexerstruct(isExtern, elementType, callerClass, obj, class, name, argCount, ...)
    $elementType = getargument($funcData, 1);
    $callerClass = getargument($funcData, 2);
    
    echo("getinstanceindexerstruct {0} {1}", $elementType, $callerClass);
    
    if($elementType=="CsLibrary.PathInfoPoint" && $callerClass=="CsLibrary.PathInfoPointList"){
        usefunc("pathinfopoint_list_get","(funcInfo, obj, argCount, ...)", $funcData, $funcOpts, $sb, $indent, [0,1,2,4,5], "__cs2lua_func_info")
        {:
            local index = ...
            local _, x, y, z, fly, stopPoint, moveType, jumpIndex, speedScale, distance, lookTargetObjID = Utility.PathInfoPointListGet(obj, index, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out, Slua.out)
            local retObj = PathInfoPointPool.Alloc()
            table.insert(funcInfo.pip_list, retObj)
            retObj:SetPoint(x,y,z)
            retObj.m_Fly = fly
            retObj.m_StopPoint = stopPoint
            retObj.m_MoveType = moveType
            retObj.m_JumpIndex = jumpIndex
            retObj.m_SpeedScale = speedScale
            retObj.m_Distance = distance
            retObj.m_LookTargetObjID = lookTargetObjID
            return retObj
        :};
        return(true);
    }
    elseif($elementType=="BoxedValue" && $callerClass=="BoxedValueList"){
        /*
        public const int c_ObjectType = 0;
        public const int c_StringType = 1;
        public const int c_BoolType = 2;
        public const int c_CharType = 3;
        public const int c_SByteType = 4;
        public const int c_ShortType = 5;
        public const int c_IntType = 6;
        public const int c_LongType = 7;
        public const int c_ByteType = 8;
        public const int c_UShortType = 9;
        public const int c_UIntType = 10;
        public const int c_ULongType = 11;
        public const int c_FloatType = 12;
        public const int c_DoubleType = 13;
        public const int c_DecimalType = 14;
        public const int c_Vector2Type = 15;
        public const int c_Vector3Type = 16;
        public const int c_Vector4Type = 17;
        public const int c_QuaternionType = 18;
        public const int c_ColorType = 19;
        public const int c_Color32Type = 20;
        */
        usefunc("boxedvalue_list_get","(funcInfo, obj, argCount, ...)", $funcData, $funcOpts, $sb, $indent, [0,1,2,4,5], "__cs2lua_func_info")
        {:
            local index = ...
            local _, type, objVal, numVal, boolVal = Utility.BoxedValueListGet(obj, index, Slua.out, Slua.out, Slua.out, Slua.out)
            local retObj = BoxedValuePool.Alloc()
            table.insert(funcInfo.bv_list, retObj)
            if type==15 then --vector2
                local _,x,y = Utility.BoxedValueListGetV2(obj, index, Slua.out, Slua.out)
                retObj:SetVector2(x,y)
            elseif type==16 then --vector3
                local _,x,y,z = Utility.BoxedValueListGetV3(obj, index, Slua.out, Slua.out, Slua.out)
                retObj:SetVector3(x,y,z)
            elseif type==17 then --vector4
                local _,x,y,z,w = Utility.BoxedValueListGetV4(obj, index, Slua.out, Slua.out, Slua.out, Slua.out)
                retObj:SetVector4(x,y,z,w)
            elseif type==18 then --quaternion
                local _,x,y,z,w = Utility.BoxedValueListGetQuaternion(obj, index, Slua.out, Slua.out, Slua.out, Slua.out)
                retObj:SetQuaternion(x,y,z,w)
            elseif type==19 then --color
                local _,r,g,b,a = Utility.BoxedValueListGetColor(obj, index, Slua.out, Slua.out, Slua.out, Slua.out)
                retObj:SetColor(r,g,b,a)
            elseif type==20 then --color32
                local _,r,g,b,a = Utility.BoxedValueListGetColor32(obj, index, Slua.out, Slua.out, Slua.out, Slua.out)
                retObj:SetColor32(r,g,b,a)
            elseif type==0 then --object
                retObj:SetObject(objVal)
            elseif type==1 then --string
                retObj:SetString(objVal)
            elseif type==2 then --bool
                retObj:SetBool(boolVal)
            else --number
                retObj:SetNumber(numVal)
            end
            return retObj
        :};
        return(true);
    };
    return(false);
};

script(setstaticindexerstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //setstaticindexerstruct(isExtern, elementType, callerClass, class, name, argCount, ...)
    $elementtype = getargument($funcData, 1);
    
    if($elementtype=="UnityEngine.Vector2"){
        usefunc("set_static_indexer_vector2","(funcInfo, isExtern, elementType, callerClass, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, v2 = ...
            if v~=nil then
                luatableremove(funcInfo.v2_list, v2)
            end
            setstaticindexerstruct(isExtern, elementType, callerClass, class, name, argCount, ix, v2)
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Vector3"){
        usefunc("set_static_indexer_vector3","(funcInfo, isExtern, elementType, callerClass, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, v3 = ...
            if v~=nil then
                luatableremove(funcInfo.v3_list, v3)
            end
            setstaticindexerstruct(isExtern, elementType, callerClass, class, name, argCount, ix, v3)
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Vector4"){
        usefunc("set_static_indexer_vector4","(funcInfo, isExtern, elementType, callerClass, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, v4 = ...
            if v~=nil then
                luatableremove(funcInfo.v4_list, v4)
            end
            setstaticindexerstruct(isExtern, elementType, callerClass, class, name, argCount, ix, v4)
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Quaternion"){
        usefunc("set_static_indexer_quaternion","(funcInfo, isExtern, elementType, callerClass, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, q = ...
            if v~=nil then
                luatableremove(funcInfo.q_list, q)
            end
            setstaticindexerstruct(isExtern, elementType, callerClass, class, name, argCount, ix, q)
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Color"){
        usefunc("set_static_indexer_color","(funcInfo, isExtern, elementType, callerClass, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, c = ...
            if v~=nil then
                luatableremove(funcInfo.c_list, c)
            end
            setstaticindexerstruct(isExtern, elementType, callerClass, class, name, argCount, ix, c)
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Color32"){
        usefunc("set_static_indexer_color32","(funcInfo, isExtern, elementType, callerClass, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, c32 = ...
            if v~=nil then
                luatableremove(funcInfo.c32_list, c32)
            end
            setstaticindexerstruct(isExtern, elementType, callerClass, class, name, argCount, ix, c32)
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Rect"){
        usefunc("set_static_indexer_rect","(funcInfo, isExtern, elementType, callerClass, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, rt = ...
            if v~=nil then
                luatableremove(funcInfo.rt_list, rt)
            end
            setstaticindexerstruct(isExtern, elementType, callerClass, class, name, argCount, ix, rt)
        :};
        return(true);
    }
    elseif($elementtype=="CsLibrary.DateTime"){
        usefunc("set_static_indexer_datetime","(funcInfo, isExtern, elementType, callerClass, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, dt = ...
            if v~=nil then
                luatableremove(funcInfo.dt_list, dt)
            end
            setstaticindexerstruct(isExtern, elementType, callerClass, class, name, argCount, ix, dt)
        :};
        return(true);
    }
    elseif($elementtype=="CsLibrary.TimeSpan"){
        usefunc("set_static_indexer_timespan","(funcInfo, isExtern, elementType, callerClass, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, ts = ...
            if v~=nil then
                luatableremove(funcInfo.ts_list, ts)
            end
            setstaticindexerstruct(isExtern, elementType, callerClass, class, name, argCount, ix, ts)
        :};
        return(true);
    }
    elseif($elementtype=="CsLibrary.PathInfoPoint"){
        usefunc("set_static_indexer_pathinfopoint","(funcInfo, isExtern, elementType, callerClass, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, pip = ...
            if v~=nil then
                luatableremove(funcInfo.pip_list, pip)
            end
            setstaticindexerstruct(isExtern, elementType, callerClass, class, name, argCount, ix, pip)
        :};
        return(true);
    };
    return(false);
};

script(setinstanceindexerstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //setinstanceindexerstruct(isExtern, elementType, callerClass, obj, class, name, argCount, ...)
    $elementtype = getargument($funcData, 1);
    
    if($elementtype=="UnityEngine.Vector2"){
        usefunc("set_instance_indexer_vector2","(funcInfo, isExtern, elementType, callerClass, obj, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, v2 = ...
            if v2~=nil then
                luatableremove(funcInfo.v2_list, v2)
            end
            setinstanceindexerstruct(isExtern, elementType, callerClass, obj, class, name, argCount, ix, v2)
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Vector3"){
        usefunc("set_instance_indexer_vector3","(funcInfo, isExtern, elementType, callerClass, obj, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, v3 = ...
            if v3~=nil then
                luatableremove(funcInfo.v3_list, v3)
            end
            setinstanceindexerstruct(isExtern, elementType, callerClass, obj, class, name, argCount, ix, v3)
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Vector4"){
        usefunc("set_instance_indexer_vector4","(funcInfo, isExtern, elementType, callerClass, obj, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, v4 = ...
            if v4~=nil then
                luatableremove(funcInfo.v4_list, v4)
            end
            setinstanceindexerstruct(isExtern, elementType, callerClass, obj, class, name, argCount, ix, v4)
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Quaternion"){
        usefunc("set_instance_indexer_quaternion","(funcInfo, isExtern, elementType, callerClass, obj, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, q = ...
            if q~=nil then
                luatableremove(funcInfo.q_list, q)
            end
            setinstanceindexerstruct(isExtern, elementType, callerClass, obj, class, name, argCount, ix, q)
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Color"){
        usefunc("set_instance_indexer_color","(funcInfo, isExtern, elementType, callerClass, obj, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, c = ...
            if c~=nil then
                luatableremove(funcInfo.c_list, c)
            end
            setinstanceindexerstruct(isExtern, elementType, callerClass, obj, class, name, argCount, ix, c)
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Color32"){
        usefunc("set_instance_indexer_color32","(funcInfo, isExtern, elementType, callerClass, obj, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, c32 = ...
            if c32~=nil then
                luatableremove(funcInfo.c32_list, c32)
            end
            setinstanceindexerstruct(isExtern, elementType, callerClass, obj, class, name, argCount, ix, c32)
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Rect"){
        usefunc("set_instance_indexer_rect","(funcInfo, isExtern, elementType, callerClass, obj, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, rt = ...
            if rt~=nil then
                luatableremove(funcInfo.rt_list, rt)
            end
            setinstanceindexerstruct(isExtern, elementType, callerClass, obj, class, name, argCount, ix, rt)
        :};
        return(true);
    }
    elseif($elementtype=="CsLibrary.DateTime"){
        usefunc("set_instance_indexer_datetime","(funcInfo, isExtern, elementType, callerClass, obj, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, dt = ...
            if dt~=nil then
                luatableremove(funcInfo.dt_list, dt)
            end
            setinstanceindexerstruct(isExtern, elementType, callerClass, obj, class, name, argCount, ix, dt)
        :};
        return(true);
    }
    elseif($elementtype=="CsLibrary.TimeSpan"){
        usefunc("set_instance_indexer_timespan","(funcInfo, isExtern, elementType, callerClass, obj, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, ts = ...
            if ts~=nil then
                luatableremove(funcInfo.ts_list, ts)
            end
            setinstanceindexerstruct(isExtern, elementType, callerClass, obj, class, name, argCount, ix, ts)
        :};
        return(true);
    }
    elseif($elementtype=="CsLibrary.PathInfoPoint"){
        usefunc("set_instance_indexer_pathinfopoint","(funcInfo, isExtern, elementType, callerClass, obj, class, name, argCount, ...)", $funcData, $funcOpts, $sb, $indent, 0, "__cs2lua_func_info")
        {:
            local ix, pip = ...
            if pip~=nil then
                luatableremove(funcInfo.pip_list, pip)
            end
            setinstanceindexerstruct(isExtern, elementType, callerClass, obj, class, name, argCount, ix, pip)
        :};
        return(true);
    };
    return(false);
};

script(arraygetstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //arraygetstruct(arrIsExtern, arrSymKind, elementType, arr, argCount, ...)
    $elementtype = getargument($funcData, 2);
    
    return(false);
};

script(arraysetstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //arraysetstruct(arrIsExtern, arrSymKind, elementType, arr, argCount, ...)
    $elementtype = getargument($funcData, 2);
    
    if($elementtype=="UnityEngine.Vector2"){
        usefunc("set_array_vector2","(funcInfo, arr, ...)", $funcData, $funcOpts, $sb, $indent, [0,1,2,4], "__cs2lua_func_info")
        {:
            local ix, v2 = ...
            if v~=nil then
                luatableremove(funcInfo.v2_list, v2)
            end
            arr[ix] = v2
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Vector3"){
        usefunc("set_array_vector3","(funcInfo, arr, ...)", $funcData, $funcOpts, $sb, $indent, [0,1,2,4], "__cs2lua_func_info")
        {:
            local ix, v3 = ...
            if v~=nil then
                luatableremove(funcInfo.v3_list, v3)
            end
            arr[ix] = v3
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Vector4"){
        usefunc("set_array_vector4","(funcInfo, arr, ...)", $funcData, $funcOpts, $sb, $indent, [0,1,2,4], "__cs2lua_func_info")
        {:
            local ix, v4 = ...
            if v~=nil then
                luatableremove(funcInfo.v4_list, v4)
            end
            arr[ix] = v4
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Quaternion"){
        usefunc("set_array_quaternion","(funcInfo, arr, ...)", $funcData, $funcOpts, $sb, $indent, [0,1,2,4], "__cs2lua_func_info")
        {:
            local ix, q = ...
            if v~=nil then
                luatableremove(funcInfo.q_list, q)
            end
            arr[ix] = q
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Color"){
        usefunc("set_array_color","(funcInfo, arr, ...)", $funcData, $funcOpts, $sb, $indent, [0,1,2,4], "__cs2lua_func_info")
        {:
            local ix, c = ...
            if v~=nil then
                luatableremove(funcInfo.c_list, c)
            end
            arr[ix] = c
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Color32"){
        usefunc("set_array_color32","(funcInfo, arr, ...)", $funcData, $funcOpts, $sb, $indent, [0,1,2,4], "__cs2lua_func_info")
        {:
            local ix, c32 = ...
            if v~=nil then
                luatableremove(funcInfo.c32_list, c32)
            end
            arr[ix] = c32
        :};
        return(true);
    }
    elseif($elementtype=="UnityEngine.Rect"){
        usefunc("set_array_rect","(funcInfo, arr, ...)", $funcData, $funcOpts, $sb, $indent, [0,1,2,4], "__cs2lua_func_info")
        {:
            local ix, rt = ...
            if v~=nil then
                luatableremove(funcInfo.rt_list, rt)
            end
            arr[ix] = rt
        :};
        return(true);
    }
    elseif($elementtype=="CsLibrary.DateTime"){
        usefunc("set_array_datetime","(funcInfo, arr, ...)", $funcData, $funcOpts, $sb, $indent, [0,1,2,4], "__cs2lua_func_info")
        {:
            local ix, dt = ...
            if v~=nil then
                luatableremove(funcInfo.dt_list, dt)
            end
            arr[ix] = dt
        :};
        return(true);
    }
    elseif($elementtype=="CsLibrary.TimeSpan"){
        usefunc("set_array_timespan","(funcInfo, arr, ...)", $funcData, $funcOpts, $sb, $indent, [0,1,2,4], "__cs2lua_func_info")
        {:
            local ix, ts = ...
            if v~=nil then
                luatableremove(funcInfo.ts_list, ts)
            end
            arr[ix] = ts
        :};
        return(true);
    }
    elseif($elementtype=="CsLibrary.PathInfoPoint"){
        usefunc("set_array_pathinfopoint","(funcInfo, arr, ...)", $funcData, $funcOpts, $sb, $indent, [0,1,2,4], "__cs2lua_func_info")
        {:
            local ix, pip = ...
            if v~=nil then
                luatableremove(funcInfo.pip_list, pip)
            end
            arr[ix] = pip
        :};
        return(true);
    };
    
    return(false);
};

script(callexternstructlistinstance)args($funcData, $funcOpts, $sb, $indent)
{
    //callexternstructlistinstance(3, [callerClass, firstTypeArg, firstTypeArgKind, secondTypeArg, secondTypeArgKind], [firstTypeArg, firstTypeArgKind, secondTypeArg, secondTypeArgKind, argType, argTypeKind, argOper, argSym], obj, class, method, ...)
    $class = getargument($funcData, 4);
    $method = getargument($funcData, 5);
    $argtype = getsubargument($funcData, 2, 4);
    
    echo("callexternstructlistinstance: {0}, {1}, {2}.", $class, $method, $argtype);
    
    if($method=="Add"){
        if($argtype=="UnityEngine.Vector2"){
            usefunc("call_ilist_add_vector2","(funcInfo, obj, class, method, ...)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
            {:
                local v2 = ...
                if v2~=nil then
                    luatableremove(funcInfo.v2_list, v2)
                end
                obj[method](obj, ...)
            :};
            return(true);
        }
        elseif($argtype=="UnityEngine.Vector3"){
            usefunc("call_ilist_add_vector3","(funcInfo, obj, class, method, ...)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
            {:
                local v3 = ...
                if v3~=nil then
                    luatableremove(funcInfo.v3_list, v3)
                end
                obj[method](obj, ...)
            :};
            return(true);
        };
    };
    return(false);
};

script(callexternstructcollectioninstance)args($funcData, $funcOpts, $sb, $indent)
{
    //callexternstructcollectioninstance(3, [callerClass, firstTypeArg, firstTypeArgKind, secondTypeArg, secondTypeArgKind], [firstTypeArg, firstTypeArgKind, secondTypeArg, secondTypeArgKind, argType, argTypeKind, argOper, argSym], obj, class, method, ...)
    $class = getargument($funcData, 4);
    $method = getargument($funcData, 5);
    $argtype = getsubargument($funcData, 2, 4);
    
    echo("callexternstructcollectioninstance: {0}, {1}, {2}.", $class, $method, $argtype);
    
    if($method=="Enqueue"){
        if($argtype=="UnityEngine.Vector2"){
            usefunc("call_queue_add_vector2","(funcInfo, obj, class, method, ...)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
            {:
                local v2 = ...
                if v2~=nil then
                    luatableremove(funcInfo.v2_list, v2)
                end
                obj[method](obj, ...)
            :};
            return(true);
        }
        elseif($argtype=="UnityEngine.Vector3"){
            usefunc("call_queue_add_vector3","(funcInfo, obj, class, method, ...)", $funcData, $funcOpts, $sb, $indent, 3, "__cs2lua_func_info")
            {:
                local v3 = ...
                if v3~=nil then
                    luatableremove(funcInfo.v3_list, v3)
                end
                obj[method](obj, ...)
            :};
            return(true);
        };
    };
    return(false);
};

script(get_clientmodule_instance)args($funcData, $funcOpts, $sb, $indent)
{
    //get_clientmodule_instance(typeName, typeKind, symKind, class, name)
    
    usefunc("get_clientmodule_instance","()", $funcData, $funcOpts, $sb, $indent, [0,1,2,3,4])
    {:
        return CsLibrary.ClientModule.Instance
    :};
    return(true);
};

script(get_globalvariables_instance)args($funcData, $funcOpts, $sb, $indent)
{
    //get_globalvariables_instance(typeName, typeKind, symKind, class, name)
    
    usefunc("get_globalvariables_instance","()", $funcData, $funcOpts, $sb, $indent, [0,1,2,3,4])
    {:
        return CsLibrary.GlobalVariables.Instance
    :};
    return(true);
};

script(coroutinehook)args($funcData, $funcOpts, $sb, $indent, $curFile, $curMember, $curId)
{
    if(stringcontains($curId, ["call","extern"])){
        $a = getargument($funcData, 0);
        $b = getargument($funcData, 1);
        $c = getargument($funcData, 2);
        $d = getargument($funcData, 3);
        writelog("coroutinehook {0}({1},{2},{3},{4})",$curId,$a,$b,$c,$d);
    }
    elseif($curId == "getexternstatic"){
        $a = getargument($funcData, 0);
        $b = getargument($funcData, 1);
        $c = getargument($funcData, 2);
        if($b=="UnityEngine.Time"){
            writelog("coroutinehook {0}({1},{2},{3})",$curId,$a,$b,$c);
        };
    };
    return(false);
};