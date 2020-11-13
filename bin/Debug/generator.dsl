script(wrapoutstruct)args($funcData, $sb, $indent)
{
    //wrapoutstruct(funcInfo, v, classObj)
    return(false);
};

script(wrapoutexternstruct)args($funcData, $sb, $indent)
{
    //wrapoutexternstruct(funcInfo, v, classObj)
    $v = getargument($funcData, 0);
    $classObj = getargument($funcData, 1);
    
    if($classObj=="UnityEngine.Vector2"){
        usefunc("wrap_out_vector2", "(funcInfo, v, classObj)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(0,0)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Vector3"){
        usefunc("wrap_out_vector3", "(funcInfo, v, classObj)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:    
            local obj = UnityEngine.Vector3.New(0,0,0)
            table.insert(funcInfo.v3_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Vector4"){
        usefunc("wrap_out_vector4", "(funcInfo, v, classObj)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:    
            local obj = UnityEngine.Vector4.New(0,0,0,1)
            table.insert(funcInfo.v4_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Quaternion"){
        usefunc("wrap_out_quaternion", "(funcInfo, v, classObj)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:   
            local obj = UnityEngine.Quaternion.New(0,0,0,1)
            table.insert(funcInfo.q_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Color"){
        usefunc("wrap_out_color", "(funcInfo, v, classObj)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:   
            local obj = UnityEngine.Color.New(0,0,0,1)
            table.insert(funcInfo.c_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Color32"){
        usefunc("wrap_out_color32", "(funcInfo, v, classObj)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:   
            local obj = Color32Pool.Alloc()
            table.insert(funcInfo.c32_list, obj)
            return obj
        :};
        return(true);
    };
    return(false);
};

script(wrapstruct)args($funcData, $sb, $indent)
{
    //wrapstruct(funcInfo, v, classObj)
    return(false);
};

script(wrapexternstruct)args($funcData, $sb, $indent)
{
    //wrapexternstruct(funcInfo, v, classObj)
    $v = getargument($funcData, 0);
    $classObj = getargument($funcData, 1);
    
    if($classObj=="UnityEngine.Vector2"){
        usefunc("wrap_vector2","(funcInfo, v, classObj)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(v.x,v.y)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Vector3"){
        usefunc("wrap_vector3","(funcInfo, v, classObj)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(v.x,v.y,v.z)
            table.insert(funcInfo.v3_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Vector4"){
        usefunc("wrap_vector4","(funcInfo, v, classObj)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector4.New(v.x,v.y,v.z,v.w)
            table.insert(funcInfo.v4_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Quaternion"){
        usefunc("wrap_quaternion","(funcInfo, v, classObj)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Quaternion.New(v.x,v.y,v.z,v.w)
            table.insert(funcInfo.q_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Color"){
        usefunc("wrap_color","(funcInfo, v, classObj)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.New(v.r,v.g,v.b,v.a)
            table.insert(funcInfo.c_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($classObj=="UnityEngine.Color32"){
        usefunc("wrap_color32","(funcInfo, v, classObj)", $funcData, $sb, $indent, "__cs2lua_func_info")
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

script(getexternstaticstructmember)args($funcData, $sb, $indent)
{
    //getexternstaticstructmember(funcInfo, symKind, class, member)
    $symKind = getargument($funcData, 0);
    $class = getargument($funcData, 1);
    $member = getargument($funcData, 2);
    
    if($class=="UnityEngine.Vector2" && $member=="zero"){        
        usefunc("get_vector2_zero", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(0,0)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector2" && $member=="one"){
        usefunc("get_vector2_one", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(1,1)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector2" && $member=="up"){
        usefunc("get_vector2_up", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(0,1)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector2" && $member=="down"){
        usefunc("get_vector2_down", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector2.New(0,-1)
            table.insert(funcInfo.v2_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="zero"){
        usefunc("get_vector3_zero", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,0,0)
            table.insert(funcInfo.v3_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="one"){
        usefunc("get_vector3_one", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(1,1,1)
            table.insert(funcInfo.v3_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="left"){
        usefunc("get_vector3_left", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(-1,0,0)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="right"){
        usefunc("get_vector3_right", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(1,0,0)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="forward"){
        usefunc("get_vector3_forward", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,0,1)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="back"){
        usefunc("get_vector3_back", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,0,-1)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="up"){
        usefunc("get_vector3_up", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,1,0)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector3" && $member=="down"){
        usefunc("get_vector3_down", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector3.New(0,-1,0)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector4" && $member=="zero"){
        usefunc("get_vector4_zero", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector4.New(0,0,0,0)
            table.insert(funcInfo.v4_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector4" && $member=="one"){
        usefunc("get_vector4_one", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Vector4.New(1,1,1,1)
            table.insert(funcInfo.v4_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Quaternion" && $member=="identity"){
        usefunc("get_quaternion_identity", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Quaternion.New(0,0,0,1)
            table.insert(funcInfo.q_list, obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="white"){
        usefunc("get_unity_color_white", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.white
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="red"){
        usefunc("get_unity_color_red", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.red
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="green"){
        usefunc("get_unity_color_green", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.green
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="blue"){
        usefunc("get_unity_color_blue", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.blue
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="black"){
        usefunc("get_unity_color_black", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.black
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="gray"){
        usefunc("get_unity_color_gray", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.gray
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Color" && $member=="yellow"){
        usefunc("get_unity_color_yellow", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local obj = UnityEngine.Color.yellow
            table.insert(funcInfo.c_list , obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="CsLibrary.DateTime" && $member=="Now"){
        usefunc("get_datetime_now", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
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
        usefunc("get_audiomanager_listener_pos", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local _,x,y,z = CsLibrary.AudioManager.GetListenerPos(Slua.out, Slua.out, Slua.out)        
            local obj = UnityEngine.Vector3.New(x,y,z)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="CsLibrary.UnityGeometry" && $member=="InvalidPos"){
        usefunc("get_unitygeometry_invalidpos", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local x,y,z = CsLibrary.UnityGeometry.GetInvalidPos(Slua.out, Slua.out, Slua.out)        
            local obj = UnityEngine.Vector3.New(x,y,z)
            table.insert(funcInfo.v3_list,obj)
            return obj
        :};
        return(true);
    }
    elseif($class=="CsLibrary.UnityGeometry" && $member=="InvalidDir2D"){
        usefunc("get_unitygeometry_invaliddir2d", "(funcInfo, symKind, class, member)", $funcData, $sb, $indent, "__cs2lua_func_info")
        {:
            local x,y = CsLibrary.UnityGeometry.GetInvalidDir2D(Slua.out, Slua.out, Slua.out)        
            local obj = UnityEngine.Vector2.New(x,y)
            table.insert(funcInfo.v2_list,obj)
            return obj
        :};
        return(true);
    };
    return(false);
};

script(getexterninstancestructmember)args($funcData, $sb, $indent)
{
    //getexterninstancestructmember(funcInfo, symKind, obj, class, member)
    $symKind = getargument($funcData, 0);
    $class = getargument($funcData, 2);
    $member = getargument($funcData, 3);
    
    if($class=="UnityEngine.Transform"){
        if($member=="position"){
            usefunc("get_tranform_position","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetPosition(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localPosition"){
            usefunc("get_tranform_localposition","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetLocalPosition(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="rotation"){
            usefunc("get_tranform_rotation","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z,w = Utility.GetRotation(obj, Slua.out, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localRotation"){
            usefunc("get_tranform_localrotation","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z,w = Utility.GetLocalRotation(obj, Slua.out, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="eulerAngles"){
            usefunc("get_tranform_eulerangles","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetEulerAngles(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localEulerAngles"){
            usefunc("get_tranform_localeulerangles","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetLocalEulerAngles(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localScale"){
            usefunc("get_tranform_localscale","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetLocalScale(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="lossyScale"){
            usefunc("get_tranform_lossyscale","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetLossyScale(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="forward"){
            usefunc("get_tranform_forward","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetForward(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="right"){
            usefunc("get_tranform_right","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetRight(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="up"){
            usefunc("get_tranform_up","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GetUp(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.EntityTransform"){
        if($member=="position"){
            usefunc("get_entitytranform_position","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetPosition(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localPosition"){
            usefunc("get_entitytranform_localposition","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetLocalPosition(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="rotation"){
            usefunc("get_entitytranform_rotation","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z,w = obj:GetRotation(Slua.out, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localRotation"){
            usefunc("get_entitytranform_localrotation","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z,w = obj:GetLocalRotation(Slua.out, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Quaternion.New(x,y,z,w)
                table.insert(funcInfo.q_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="eulerAngles"){
            usefunc("get_entitytranform_eulerangles","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetEulerAngles(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localEulerAngles"){
            usefunc("get_entitytranform_localeulerangles","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetLocalEulerAngles(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="localScale"){
            usefunc("get_entitytranform_localscale","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("get_movementinfo_position","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetPosition(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="CsLibrary.EntityInfo"){
        if($member=="LastMoveDir"){
            usefunc("get_entityinfo_lastmovedir","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y = obj:GetLastMoveDir(Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="swordHangPosOffset"){
            usefunc("get_entityinfo_swordhangposoffset","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetSwordHangPosOffset(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="swordHangRotOffset"){
            usefunc("get_entityinfo_swordhangrotoffset","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("get_entityviewmodel_position","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetPosition(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="SyncOffset"){
            usefunc("get_entityviewmodel_syncoffset","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("get_aistateinfo_homepos","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetHomePos(Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="TargetPosition"){
            usefunc("get_aistateinfo_targetposition","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("get_gobject_position","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = Utility.GObjectGetPosition(obj, Slua.out, Slua.out, Slua.out)
                local v = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="scale"){
            usefunc("get_gobject_scale","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y = Utility.GObjectGetScale(obj, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="size"){
            usefunc("get_gobject_size","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y = Utility.GObjectGetSize(obj, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        }
        elseif($member=="xy"){
            usefunc("get_gobject_xy","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y = Utility.GObjectGetXY(obj, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class=="FairyGUI.GTextField"){
        if($member=="color"){
            usefunc("get_gtextfield_color","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,r,g,b,a = Utility.GTextFieldGetColor(obj, Slua.out, Slua.out, Slua.out, Slua.out)
                local c = UnityEngine.Color.New(r,g,b,a)
                table.insert(funcInfo.c_list,c)
                return c
            :};
            return(true);
        };
    }
    elseif($class=="FairyGUI.InputEvent"){
        if($member=="position"){
            usefunc("get_inputevent_position","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("get_stage_touchposition","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y = Utility.StageTouchPositionXY(obj, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        };
    }
    elseif($class== "UnityEngine.Vector2"){
        if($member=="normalized"){
            usefunc("get_vector2_normalized","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("get_vector3_normalized","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("get_audiomanager_listener_pos","(funcInfo, symKind, obj, class, member)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = obj:GetListenerPos(Slua.out, Slua.out, Slua.out)
                local v3 = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list , v3)
                return v3
            :};
            return(true);
        };
    };
    return(false);
};

script(callexterndelegationreturnstruct)args($funcData, $sb, $indent)
{
    //callexterndelegationreturnstruct(funcInfo, funcobj, funcobjname, ...)
    return(false);
};

script(callexternextensionreturnstruct)args($funcData, $sb, $indent)
{
    //callexternextensionreturnstruct(funcInfo, class, member, ...)
    return(false);
};

script(callexternstaticreturnstruct)args($funcData, $sb, $indent)
{
    //callexternstaticreturnstruct(funcInfo, class, member, ...)
    $class = getargument($funcData, 0);
    $member = getargument($funcData, 1);    
    
    if($class=="Vector3Extension" && $member=="XZ"){
        usefunc("call_vector3_xz","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_vector2_lerp","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_vector2_lerpunclamped","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_vector2_movetowards","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_vector2_clampmagnitude","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_vector2_smoothdamp","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_vector3_clampmagnitude","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local oriV3,maxLength = ...
                local targetV3 = UnityEngine.Vector3.ClampMagnitude(oriV3,maxLength)
                table.insert(funcInfo.v3_list,targetV3)
                return targetV3
            :};
            return(true);
        }
        elseif($member=="Cross"){
            usefunc("call_vector3_cross","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local lv3,rv3 = ...
                local targetV3 = UnityEngine.Vector3.Cross(lv3,rv3)
                table.insert(funcInfo.v3_list,targetV3)
                return targetV3
            :};
            return(true);
        }
        elseif($member=="Lerp"){
            usefunc("call_vector3_lerp","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local fromV3 , toV3 , t = ...
                local targetV3 = UnityEngine.Vector3.Lerp(fromV3,toV3,t)
                table.insert(funcInfo.v3_list , targetV3)
                return targetV3
            :};
            return(true);
        }
        elseif($member=="RotateTowards"){
            usefunc("call_vector3_rotatetowards","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
        if($member=="Euler"){
            usefunc("call_quaternion_euler","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local sig , x, y,z = ...
                local qua = UnityEngine.Quaternion.Euler(sig,x,y,z)
                table.insert(funcInfo.q_list , qua)
                return qua
            :};
            return(true);
        }
        elseif($member=="Inverse"){
            usefunc("call_quaternion_inverse","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local rotation = ...
                local qua = UnityEngine.Quaternion.Inverse(rotation)
                table.insert(funcInfo.q_list , qua)
                return qua
            :};
            return(true);
        }
        elseif($member=="AngleAxis"){
            usefunc("call_quaternion_angleaxis","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_quaternion_lookrotation","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_quaternion_rotatetowards","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
    elseif($class=="CsLibrary.AvatarSystem" && $member=="ConvertHsvToRgb"){
        usefunc("call_avatarsystem_converthsvtorgb","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
        if($member=="ReCalcPosition"){
            usefunc("call_movementutility_recalcposition","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,pos,isFly = ...
                local x,y,z
                if getobjtypename(pos)=="WORLD_POS" then
                    _,x,y,z = CsLibrary.MovementUtility.ReCalcPositionMsgPosForCs2Lua(pos,isFly,Slua.out,Slua.out,Slua.out)
                else
                    _,x,y,z = CsLibrary.MovementUtility.ReCalcPositionV3ForCs2Lua(pos,isFly,Slua.out,Slua.out,Slua.out)
                end
                local obj = UnityEngine.Vector3.New(x,y,z)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        }
        elseif($member=="GetPositionOnGround"){
            usefunc("call_movementutility_getpositiononground","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local _,x,y,z = ...
                local t = getobjtypename(x)
                if t=="Vector2" then
                    local ox,oy,oz = CsLibrary.MovementUtility.GetPositionOnGroundV2ToXYZ(x,Slua.out,Slua.out,Slua.out)
                    local obj = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, obj)
                    return obj
                elseif t=="Vector3" then
                    local ox,oy,oz = CsLibrary.MovementUtility.GetPositionOnGroundV3ToXYZ(x,Slua.out,Slua.out,Slua.out)
                    local obj = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, obj)
                    return obj
                elseif z==nil then
                    local ox,oy,oz = CsLibrary.MovementUtility.GetPositionOnGroundXYToXYZ(x,y,Slua.out,Slua.out,Slua.out)
                    local obj = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, obj)
                    return obj
                else
                    local ox,oy,oz = CsLibrary.MovementUtility.GetPositionOnGroundXYZToXYZ(x,y,z,Slua.out,Slua.out,Slua.out)
                    local obj = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, obj)
                    return obj
                end
            :};
            return(true);
        }
        elseif($member=="GetPositionOnNavMesh"){
            usefunc("call_movementutility_getpositiononnavmesh","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_movementutility_trysampleposonnavmesh","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_movementutility_checkposbeyondnavmesh","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_movementutility_walkonnavmesh","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_movementutility_getraycastposinnavmesh3","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_movementutility_scenecollidertrymove","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_skillutils_fromworlddir","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_skillutils_worldpos2vector3","(funcInfo, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local worldPos = ...
                local ox,oy,oz = PluginFramework.Skill.SkillUtils.WorldPosToV3(worldPos,Slua.out,Slua.out,Slua.out)
                local obj = UnityEngine.Vector3.New(ox,oy,oz)
                table.insert(funcInfo.v3_list, obj)
                return obj
            :};
            return(true);
        };
    };
    return(false);
};

script(callexterninstancereturnstruct)args($funcData, $sb, $indent)
{
    //callexterninstancereturnstruct(funcInfo, obj, class, member, ...)
    $symKind = getargument($funcData, 0);
    $class = getargument($funcData, 2);
    $member = getargument($funcData, 3);
        
    if($class=="UnityEngine.Transform"){
        if($member=="TransformDirection"){
            usefunc("call_transform_transformdirection","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local argnum = select('#', ...)
                local sig,x,y,z = ...
                if argnum>3 then
                    local _,ox,oy,oz = Utility.TransformDirectionXYZ(obj, x, y, z, Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, v)
                    return v
                else
                    local _,ox,oy,oz = Utility.TransformDirectionV3(obj, x, Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, v)
                    return v
                end
            :};
            return(true);
        }
        elseif($member=="TransformPoint"){
            usefunc("call_transform_transformpoint","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local argnum = select('#', ...)
                local sig,x,y,z = ...
                if argnum>3 then
                    local _,ox,oy,oz = Utility.TransformPointXYZ(obj, x, y, z, Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, v)
                    return v
                else
                    local _,ox,oy,oz = Utility.TransformPointV3(obj, x, Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, v)
                    return v
                end
            :};
            return(true);
        }
        elseif($member=="TransformVector"){
            usefunc("call_transform_transformvector","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local argnum = select('#', ...)
                local sig,x,y,z = ...
                if argnum>3 then
                    local _,ox,oy,oz = Utility.TransformVectorXYZ(obj, x, y, z, Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, v)
                    return v
                else
                    local _,ox,oy,oz = Utility.TransformVectorV3(obj, x, Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, v)
                    return v
                end
            :};
            return(true);
        }
        elseif($member=="InverseTransformDirection"){
            usefunc("call_transform_inversetransformdirection","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local argnum = select('#', ...)
                local sig,x,y,z = ...
                if argnum>3 then
                    local _,ox,oy,oz = Utility.InverseTransformDirectionXYZ(obj, x, y, z, Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, v)
                    return v
                else
                    local _,ox,oy,oz = Utility.InverseTransformDirectionV3(obj, x, Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, v)
                    return v
                end
            :};
            return(true);
        }
        elseif($member=="InverseTransformPoint"){
            usefunc("call_transform_inversetransformpoint","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local argnum = select('#', ...)
                local sig,x,y,z = ...
                if argnum>3 then
                    local _,ox,oy,oz = Utility.InverseTransformPointXYZ(obj, x, y, z, Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, v)
                    return v
                else
                    local _,ox,oy,oz = Utility.InverseTransformPointV3(obj, x, Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, v)
                    return v
                end
            :};
            return(true);
        }
        elseif($member=="InverseTransformVector"){
            usefunc("call_transform_inversetransformvector","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local argnum = select('#', ...)
                local sig,x,y,z = ...
                if argnum>3 then
                    local _,ox,oy,oz = Utility.InverseTransformVectorXYZ(obj, x, y, z, Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, v)
                    return v
                else
                    local _,ox,oy,oz = Utility.InverseTransformVectorV3(obj, x, Slua.out, Slua.out, Slua.out)
                    local v = UnityEngine.Vector3.New(ox,oy,oz)
                    table.insert(funcInfo.v3_list, v)
                    return v
                end
            :};
            return(true);
        };
    }
    elseif($class==CsLibrary.EntityTransform){
        if($member=="TransformDirection"){ 
            usefunc("call_entitytransform_transformdirection","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_entitytransform_transformpoint","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_entitytransform_transformvector","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_entitytransform_inversetransformdirection","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_entitytransform_inversetransformpoint","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_entitytransform_inversetransformvector","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
    elseif($class==FairyGUI.DisplayObject){
        if($member=="GlobalToLocal"){
            usefunc("call_displayobject_globaltolocal","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
            usefunc("call_gobject_localtoglobal","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
    elseif($class==FairyGUI.GObject){
        if($member=="GlobalToLocal"){
            usefunc("call_gobject_globaltolocal","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                if getobjtypename(ptOrRt)=="Rect" then
                    local _,ptOrRt = ...
                    local _,x,y,w,h = Utility.GObjectGlobalToLocalRect(obj, ptOrRt, Slua.out, Slua.out, Slua.out, Slua.out)
                    local v = RectPool.Alloc()
                    v.x=x
                    v.y=y
                    v.width=w
                    v.height=h
                    table.insert(funcInfo.rt_list,v)
                    return v
                else                    
                    local _,ptOrRt = ...
                    local _,x,y = Utility.GObjectGlobalToLocal(obj, ptOrRt, Slua.out, Slua.out)
                    local v = UnityEngine.Vector2.New(x,y)
                    table.insert(funcInfo.v2_list, v)
                    return v
                end
            :};
            return(true);
        }
        elseif($member=="LocalToGlobal"){
            usefunc("call_gobject_localtoglobal","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                if getobjtypename(ptOrRt)=="Rect" then
                    local _,ptOrRt = ...
                    local _,x,y,w,h = Utility.GObjectLocalToGlobalRect(obj, ptOrRt, Slua.out, Slua.out, Slua.out, Slua.out)
                    local v = RectPool.Alloc()
                    v.x=x
                    v.y=y
                    v.width=w
                    v.height=h
                    table.insert(funcInfo.rt_list,v)
                    return v
                else
                    local _,ptOrRt = ...
                    local _,x,y = Utility.GObjectLocalToGlobal(obj, ptOrRt, Slua.out, Slua.out)
                    local v = UnityEngine.Vector2.New(x,y)
                    table.insert(funcInfo.v2_list, v)
                    return v
                end
            :};
        };
    }
    elseif($class==FairyGUI.Stage){
        if($member=="GetTouchPosition"){
            usefunc("call_stage_gettouchposition","(funcInfo, obj, class, member, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
            {:
                local touchId = ...
                local _,x,y = Utility.StageGetTouchPosition(obj, touchId, Slua.out, Slua.out)
                local v = UnityEngine.Vector2.New(x,y)
                table.insert(funcInfo.v2_list, v)
                return v
            :};
            return(true);
        };
    };
    return(false);
};

script(recycleandkeepstructvalue)args($funcData, $sb, $indent)
{
    //recycleandkeepstructvalue(funcInfo, fieldType, oldVal, newVal)
    $fieldType = getargument($funcData, 0);
        
    if($fieldType=="UnityEngine.Vector2"){
        usefunc("recycle_and_keep_vector2","(funcInfo, fieldType, oldVal, newVal)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
        usefunc("recycle_and_keep_vector3","(funcInfo, fieldType, oldVal, newVal)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
        usefunc("recycle_and_keep_vector4","(funcInfo, fieldType, oldVal, newVal)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
        usefunc("recycle_and_keep_quaternion","(funcInfo, fieldType, oldVal, newVal)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
        usefunc("recycle_and_keep_color","(funcInfo, fieldType, oldVal, newVal)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
        usefunc("recycle_and_keep_color32","(funcInfo, fieldType, oldVal, newVal)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
        usefunc("recycle_and_keep_rect","(funcInfo, fieldType, oldVal, newVal)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
    elseif($fieldType=="sLibrary.DateTime"){
        usefunc("recycle_and_keep_datetime","(funcInfo, fieldType, oldVal, newVal)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
        usefunc("recycle_and_keep_timespan","(funcInfo, fieldType, oldVal, newVal)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
    };
    return(false);
};

script(newstruct)args($funcData, $sb, $indent)
{
    //newstruct(funcInfo, class, typeargs, typekinds, ctor, initializer, ...)
    return(false);
};

script(newexternstruct)args($funcData, $sb, $indent)
{
    //newexternstruct(funcInfo, class, typeargs, typekinds, initializer, ...)
    $class = getargument($funcData, 0);
    
    if($class=="System.Nullable_T"){
        usefunc("new_nullable","(funcInfo, class, typeargs, typekinds, initializer, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
        {:
            return nil
        :};
        return(true);
    }
    elseif($class=="System.Collections.Generic.KeyValuePair_TKey_TValue"){
        usefunc("new_keyvaluepair","(funcInfo, class, typeargs, typekinds, initializer, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
        {:
            local arg1,arg2 = ...
            return {Key = arg1, Value = arg2}
        :};
        return(true);
    }
    elseif($class=="UnityEngine.Vector2"){
        usefunc("new_vector2","(funcInfo, class, typeargs, typekinds, initializer, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
        usefunc("new_vector3","(funcInfo, class, typeargs, typekinds, initializer, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
        {:
            local _,x,y,z = ...
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
        usefunc("new_vector4","(funcInfo, class, typeargs, typekinds, initializer, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
        {:
            local _,x,y,z,w = ...
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
        usefunc("new_quaternion","(funcInfo, class, typeargs, typekinds, initializer, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
        usefunc("new_color","(funcInfo, class, typeargs, typekinds, initializer, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
        {:
            local _,r,g,b,a = ...
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
        usefunc("new_color32","(funcInfo, class, typeargs, typekinds, initializer, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
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
        usefunc("new_rect","(funcInfo, class, typeargs, typekinds, initializer, ...)",$funcData, $sb, $indent,"__cs2lua_func_info")
        {:
            local _,p1,p2,p3,p4 = ...
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

script(newobject)args($funcData, $sb, $indent)
{
    //newobject(funcInfo, class, typeargs, typekinds, ctor, initializer, ...)
    return(false);
};

script(newexternobject)args($funcData, $sb, $indent)
{
    //newexternobject(funcInfo, class, typeargs, typekinds, initializer, ...)
    return(false);
};