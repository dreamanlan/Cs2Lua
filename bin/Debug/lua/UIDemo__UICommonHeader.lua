require "cs2lua__utility";
require "cs2lua__namespaces";

UIDemo.UICommonHeader = {
	GetActive = function()
		local pHeader; pHeader;
		if (pHeader == nil) then
			return nil;
		end;
		return pHeader:GetComponent(UIDemo.UICommonHeader);
	end,
	Show = function(strTitle, pHander)
		local pHeader; pHeader;
		if (pHeader == nil) then
			return ;
		end;
		local pUICommonHeader; pUICommonHeader = pHeader:GetComponent(UIDemo.UICommonHeader);
		if (pUICommonHeader == nil) then
			return ;
		end;
		pUICommonHeader:SetTitle(strTitle);
		delegationset(pUICommonHeader, nil, "OnBackBtn", pHander);
	end,
	Hide = function()
			end,
	cctor = function()
	end,

	__new_object = function(...)
		return newobject(UIDemo.UICommonHeader, nil, {}, ...);
	end,
	__define_class = function()
		local static = UIDemo.UICommonHeader;
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			OnEnable = function(this)
				this:AttachEvent();
				this:UpdateUI();
			end,
			OnDisable = function(this)
				this:DetachEvent();
			end,
			UpdateUI = function(this)
				this:UpdateMailUI();
				this:UpdateMoneyUI();
			end,
			UpdateMailUI = function(this)
				local nMailCount; nMailCount;
								if (nMailCount > 0) then
					this.MailCount.text = invokeforbasicvalue(nMailCount, System.Int32, "ToString");
				end;
			end,
			UpdateMoneyUI = function(this)
				;
				;
				;
			end,
			SetTitle = function(this, strTitle)
				if (strTitle.Length == 0) then
														else
															this.TitleCaption.text = strTitle;
				end;
			end,
			StartFadeIn = function(this)
												this.FadeInAni:SetActive(true);
			end,
			StartFadeOut = function(this)
												this.FadeOutAni:SetActive(true);
			end,
			OnSettingBtnClick = function(this)
							end,
			OnMailBtnClick = function(this)
							end,
			OnGiftBtnClick = function(this)
							end,
			OnGoldClick = function(this)
							end,
			OnGameGOldClick = function(this)
							end,
			OnDiamondClick = function(this)
							end,
			OnBackBtnClick = function(this)
				if (this.OnBackBtn ~= nil) then
					this.OnBackBtn();
				else
									end;
			end,
			OnFireEvent = function(this, key, param1, param2)
				local __compiler_switch_783 = key;
				if __compiler_switch_783 == typecast(EventDef.Character_MailChanged, System.UInt32) then
					this:UpdateMailUI();
				elseif __compiler_switch_783 == typecast(EventDef.Character_MoneyChanged, System.UInt32) then
					this:UpdateMoneyUI();
				end;
				return false;
			end,
			GetListenerPriority = function(this, eventKey)
				return 0;
			end,
			AttachEvent = function(this)
											end,
			DetachEvent = function(this)
											end,
			ctor = function(this)
			end,
		};

		local instance_build = function()
			local instance_fields = {
				TitleContainer = false,
				OptionContainer = false,
				MailCountObj = false,
				MailCount = false,
				GoldValue = false,
				TicketValue = false,
				DiamondValue = false,
				TitleCaption = false,
				FadeInAni = false,
				FadeOutAni = false,
				OnBackBtn = delegationwrap(nil),
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = {
			"IEventListener",
		};

		local interface_map = nil;

		return defineclass(UnityEngine.MonoBehaviour, "UIDemo.UICommonHeader", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


UIDemo.UICommonHeader.__define_class();

--local obj = TopLevel.Child2.Bar:new();
--obj:Test();
