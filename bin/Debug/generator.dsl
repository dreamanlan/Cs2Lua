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
        usefunc("wrap_out_vector2", "(funcInfo, v, classObj)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(0,0)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Vector3"){
        usefunc("wrap_out_vector3", "(funcInfo, v, classObj)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:    
            local obj = UnityEngine.Vector3.New(0,0,0)
            table.insert(funcInfo.v3_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Vector4"){
        usefunc("wrap_out_vector4", "(funcInfo, v, classObj)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:    
            local obj = UnityEngine.Vector4.New(0,0,0,1)
            table.insert(funcInfo.v4_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Quaternion"){
        usefunc("wrap_out_quaternion", "(funcInfo, v, classObj)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:   
            local obj = UnityEngine.Quaternion.New(0,0,0,1)
            table.insert(funcInfo.q_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Color"){
        usefunc("wrap_out_color", "(funcInfo, v, classObj)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:   
            local obj = UnityEngine.Color.New(0,0,0,1)
            table.insert(funcInfo.c_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Color32"){
        usefunc("wrap_out_color32", "(funcInfo, v, classObj)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:   
            local obj = Color32Pool.Alloc()
            table.insert(funcInfo.c32_list, obj)
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
    $classObj = getargument($funcData, 1);
    
    if($classObj=="UnityEngine.Vector2"){
        usefunc("wrap_vector2","(funcInfo, v, classObj)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(v.x,v.y)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Vector3"){
        usefunc("wrap_vector3","(funcInfo, v, classObj)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(v.x,v.y,v.z)
            table.insert(funcInfo.v3_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Vector4"){
        usefunc("wrap_vector4","(funcInfo, v, classObj)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector4.New(v.x,v.y,v.z,v.w)
            table.insert(funcInfo.v4_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Quaternion"){
        usefunc("wrap_quaternion","(funcInfo, v, classObj)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Quaternion.New(v.x,v.y,v.z,v.w)
            table.insert(funcInfo.q_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Color"){
        usefunc("wrap_color","(funcInfo, v, classObj)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.New(v.r,v.g,v.b,v.a)
            table.insert(funcInfo.c_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Color32"){
        usefunc("wrap_color32","(funcInfo, v, classObj)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
        usefunc("get_vector2_zero", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(0,0)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector2" && $member=="one"){
        usefunc("get_vector2_one", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(1,1)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector2" && $member=="up"){
        usefunc("get_vector2_up", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(0,1)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector2" && $member=="down"){
        usefunc("get_vector2_down", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(0,-1)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="zero"){
        usefunc("get_vector3_zero", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,0,0)
            table.insert(funcInfo.v3_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="one"){
        usefunc("get_vector3_one", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(1,1,1)
            table.insert(funcInfo.v3_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="left"){
        usefunc("get_vector3_left", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(-1,0,0)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="right"){
        usefunc("get_vector3_right", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(1,0,0)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="forward"){
        usefunc("get_vector3_forward", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,0,1)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="back"){
        usefunc("get_vector3_back", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,0,-1)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="up"){
        usefunc("get_vector3_up", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,1,0)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="down"){
        usefunc("get_vector3_down", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,-1,0)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector4" && $member=="zero"){
        usefunc("get_vector4_zero", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector4.New(0,0,0,0)
            table.insert(funcInfo.v4_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector4" && $member=="one"){
        usefunc("get_vector4_one", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector4.New(1,1,1,1)
            table.insert(funcInfo.v4_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Quaternion" && $member=="identity"){
        usefunc("get_quaternion_identity", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Quaternion.New(0,0,0,1)
            table.insert(funcInfo.q_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="white"){
        usefunc("get_unity_color_white", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.white
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="red"){
        usefunc("get_unity_color_red", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.red
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="green"){
        usefunc("get_unity_color_green", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.green
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="blue"){
        usefunc("get_unity_color_blue", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.blue
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="black"){
        usefunc("get_unity_color_black", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.black
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="gray"){
        usefunc("get_unity_color_gray", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.gray
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="yellow"){
        usefunc("get_unity_color_yellow", "(funcInfo, symKind, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.yellow
            table.insert(funcInfo.c_list , obj)
            return obj
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
    
    if($class=="UnityEngine.Transform"){
        if($member=="position"){
            usefunc("get_tranform_position","(funcInfo, symKind, obj, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetPosition(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localPosition"){
            usefunc("get_tranform_localposition","(funcInfo, symKind, obj, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetLocalPosition(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="rotation"){
            usefunc("get_tranform_rotation","(funcInfo, symKind, obj, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local _,x,y,z,w = Utility.GetRotation(obj, Slua.out, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localRotation"){
            usefunc("get_tranform_localrotation","(funcInfo, symKind, obj, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local _,x,y,z,w = Utility.GetLocalRotation(obj, Slua.out, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="eulerAngles"){
            usefunc("get_tranform_eulerangles","(funcInfo, symKind, obj, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetEulerAngles(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localEulerAngles"){
            usefunc("get_tranform_localeulerangles","(funcInfo, symKind, obj, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetLocalEulerAngles(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localScale"){
            usefunc("get_tranform_localscale","(funcInfo, symKind, obj, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetLocalScale(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="lossyScale"){
            usefunc("get_tranform_lossyscale","(funcInfo, symKind, obj, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetLossyScale(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="forward"){
            usefunc("get_tranform_forward","(funcInfo, symKind, obj, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetForward(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="right"){
            usefunc("get_tranform_right","(funcInfo, symKind, obj, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetRight(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="up"){
            usefunc("get_tranform_up","(funcInfo, symKind, obj, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetUp(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class== "UnityEngine.Vector2"){
        if($member=="normalized"){
            usefunc("get_vector2_normalized","(funcInfo, symKind, obj, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("get_vector3_normalized","(funcInfo, symKind, obj, class, member)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local v3 = obj.normalized
                table.insert(funcInfo.v3_list , v3)
                return v3
            :};
            return(true);
        };
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
    
    if($class=="UnityEngine.Vector2"){
        if($member=="Lerp"){
            usefunc("call_vector2_lerp","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_vector2_lerpunclamped","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_vector2_movetowards","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_vector2_clampmagnitude","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_vector2_smoothdamp","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_vector3_clampmagnitude","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local oriV3,maxLength = ...
                local targetV3 = UnityEngine.Vector3.ClampMagnitude(oriV3,maxLength)
                table.insert(funcInfo.v3_list,targetV3)
                return targetV3
            :};
            return(true);
        }
        elseif($member=="Cross"){
            usefunc("call_vector3_cross","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local lv3,rv3 = ...
                local targetV3 = UnityEngine.Vector3.Cross(lv3,rv3)
                table.insert(funcInfo.v3_list,targetV3)
                return targetV3
            :};
            return(true);
        }
        elseif($member=="Lerp"){
            usefunc("call_vector3_lerp","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local fromV3 , toV3 , t = ...
                local targetV3 = UnityEngine.Vector3.Lerp(fromV3,toV3,t)
                table.insert(funcInfo.v3_list , targetV3)
                return targetV3
            :};
            return(true);
        }
        elseif($member=="RotateTowards"){
            usefunc("call_vector3_rotatetowards","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local curV3 , tarV3 ,maxRad , maxMag = ...
                local targetV3 = UnityEngine.Vector3.RotateTowards(curV3,tarV3,maxRad,maxMag)
                table.insert(funcInfo.v3_list, targetV3)
                return targetV3
            :};
            return(true);
        };
    }
    elseif($class=="UnityEngine.Quaternion"){
        if($member=="Euler__Single__Single__Single"){
            usefunc("call_quaternion_euler","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local x, y, z = ...
                local qua = UnityEngine.Quaternion.Euler__Single__Single__Single(x,y,z)
                table.insert(funcInfo.q_list , qua)
                return qua
            :};
            return(true);
        }
        elseif($member=="Inverse"){
            usefunc("call_quaternion_inverse","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local rotation = ...
                local qua = UnityEngine.Quaternion.Inverse(rotation)
                table.insert(funcInfo.q_list , qua)
                return qua
            :};
            return(true);
        }
        elseif($member=="AngleAxis"){
            usefunc("call_quaternion_angleaxis","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local angle, axis = ...
                local _,x,y,z,w = Utility.QuaternionFromAngleAxis(angle, axis, Slua.out, Slua.out, Slua.out, Slua.out)
                local q = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list , q)
                return q
            :};
            return(true);
        }
        elseif($member=="LookRotation"){
            usefunc("call_quaternion_lookrotation","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local _, forward, upwards = ...
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
            usefunc("call_quaternion_rotatetowards","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local from, to, delta = ...
                local _,x,y,z,w = Utility.QuaternionRotateToward(from, to, delta, Slua.out, Slua.out, Slua.out, Slua.out)
                local q = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list , q)
                return q
            :};
            return(true);
        };
    }
    elseif($class=="UnityEngine.Color"){
        if($member=="Lerp"){
            usefunc("call_color_lerp","(funcInfo, class, member, ...)", $funcData, $funcOpts, $sb, $indent,"__cs2lua_func_info")
            {:
                local c1,c2,t = ...
                local c = UnityEngine.Color.Lerp(c1,c2,t)
                table.insert(funcInfo.c_list, c)
                return c
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
        
    if($class=="UnityEngine.Transform"){
        if($member=="TransformDirection__Single__Single__Single"){
            usefunc("call_transform_transformdirection_xyz","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_transform_transformdirection_v3","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_transform_transformpoint_xyz","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_transform_transformpoint_v3","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_transform_transformvector_xyz","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_transform_transformvector_v3","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_transform_inversetransformdirection_xyz","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_transform_inversetransformdirection_v3","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_transform_inversetransformpoint_xyz","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_transform_inversetransformpoint_v3","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_transform_inversetransformvector_xyz","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_transform_inversetransformvector_v3","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_entitytransform_transformdirection","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_entitytransform_transformpoint","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_entitytransform_transformvector","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_entitytransform_inversetransformdirection","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_entitytransform_inversetransformpoint","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_entitytransform_inversetransformvector","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_displayobject_globaltolocal","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_displayobject_localtoglobal","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_gobject_globaltolocal_rt","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_gobject_globaltolocal_v2","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_gobject_localtoglobal_rt","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_gobject_localtoglobal_v2","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_gobject_localtoroot","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
            usefunc("call_gobject_transformpoint","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
            {:
                local pt, targetSpace = ...
                local _,x,y = Utility.GObjectLocalToGlobal(obj, pt, targetSpace, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }
        elseif($memeber=="TransformRect"){
            usefunc("call_gobject_transformrect","(funcInfo, obj, class, member, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
    };
    return(false);
};

script(recycleandkeepstructvalue)args($funcData, $funcOpts, $sb, $indent)
{
    //recycleandkeepstructvalue(fieldType, oldVal, newVal)
    $fieldType = getargument($funcData, 0);
        
    if($fieldType=="UnityEngine.Vector2"){
        usefunc("recycle_and_keep_vector2","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
        usefunc("recycle_and_keep_vector3","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
        usefunc("recycle_and_keep_vector4","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
        usefunc("recycle_and_keep_quaternion","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
        usefunc("recycle_and_keep_color","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
    elseif($fieldType=="nityEngine.Color32"){
        usefunc("recycle_and_keep_color32","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
        usefunc("recycle_and_keep_rect","(funcInfo, fieldType, oldVal, newVal)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
    };
    return(false);
};

script(newstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //newstruct(class, typeargs, typekinds, ctor, initializer, ...)
    return(false);
};

script(newexternstruct)args($funcData, $funcOpts, $sb, $indent)
{
    //newexternstruct(funcInfo, class, typeargs, typekinds, ctor, initializer, ...)
    $class = getargument($funcData, 0);
    
    if($class=="System.Nullable_T"){
        usefunc("new_nullable","(funcInfo, class, typeargs, typekinds, ctor, initializer, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            return nil
        :};
        return(true);
    }
    elseif($class=="System.Collections.Generic.KeyValuePair_TKey_TValue"){
        usefunc("new_keyvaluepair","(funcInfo, class, typeargs, typekinds, ctor, initializer, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
        {:
            local arg1,arg2 = ...
            return {Key = arg1, Value = arg2}
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector2"){
        usefunc("new_vector2","(funcInfo, class, typeargs, typekinds, ctor, initializer, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
        usefunc("new_vector3","(funcInfo, class, typeargs, typekinds, ctor, initializer, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
        usefunc("new_vector4","(funcInfo, class, typeargs, typekinds, ctor, initializer, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
        usefunc("new_quaternion","(funcInfo, class, typeargs, typekinds, ctor, initializer, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
        usefunc("new_color","(funcInfo, class, typeargs, typekinds, ctor, initializer, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
        usefunc("new_color32","(funcInfo, class, typeargs, typekinds, ctor, initializer, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
        usefunc("new_rect","(funcInfo, class, typeargs, typekinds, ctor, initializer, ...)", $funcData, $funcOpts, $sb, $indent, "__cs2lua_func_info")
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
    };
    return(false);
};
