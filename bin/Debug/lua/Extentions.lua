require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";
require "cs2lua__interfaces";

Extentions = {
	__define_class = function()
		local static = Extentions;

		local static_methods = {
			timeInMillisecond = function(dateTime)
				return invokeintegeroperator(0, "/", dateTime.Ticks, 10000, System.Int64, System.Int64);
			end,
			timeSince1970 = function(dateTime)
				return typecast(( invokeintegeroperator(0, "/", Extentions.timeSince1970InMillisecond(dateTime), 1000, System.Int64, System.Int64) ), System.Int64, false);
			end,
			timeSince1970InMillisecond = function(dateTime)
--return (long)(Time.realtimeSinceStartup * 1000);
				if (Extentions.dateTime1970.Ticks == 0) then
--Debug.LogError("Ticks = 0");
					Extentions.dateTime1970 = System.DateTime.Parse("1970-1-1");
				end;
				local v; v = 4;
				local ts; ts = (dateTime - Extentions.dateTime1970);
				return typecast(ts.TotalMilliseconds, System.Int64, false);
			end,
			findChildRecursively = function(transform, childName, maxDepth)
				local child; child = transform:FindChild(childName);
				if (invokeexternoperator(UnityEngine.Object, "op_Equality", child, nil) and (maxDepth > 0)) then
					local childCount; childCount = transform.childCount;
					local i; i = 0;
					while (i < childCount) do
						child = Extentions.findChildRecursively(transform:GetChild(i), childName, invokeintegeroperator(3, "-", maxDepth, 1, System.Int32, System.Int32));
						if invokeexternoperator(UnityEngine.Object, "op_Inequality", child, nil) then
							break;
						end;
						do
						break;
						end;
					i = invokeintegeroperator(2, "+", i, 1, System.Int32, System.Int32);
					end;
				end;
				return child;
			end,
			searchChildRecursively = function(transform, childName, maxDepth)
				if (invokeforbasicvalue(transform.name, false, System.String, "IndexOf", childName) ~= -1) then
					return transform;
				end;
				local count; count = transform.childCount;
				if (maxDepth > 0) then
					local i; i = 0;
					while (i < count) do
						local nowNode; nowNode = transform:GetChild(i);
						local searchRes; searchRes = Extentions.searchChildRecursively(nowNode, childName, invokeintegeroperator(3, "-", maxDepth, 1, System.Int32, System.Int32));
						if invokeexternoperator(UnityEngine.Object, "op_Inequality", searchRes, nil) then
							return searchRes;
						end;
					i = invokeintegeroperator(2, "+", i, 1, System.Int32, System.Int32);
					end;
				end;
				return nil;
			end,
			isFirstTimeToStart = function()
				local isFirstTimeStart; isFirstTimeStart = UnityEngine.PlayerPrefs.GetInt("isFirstTimeToStart", 1);
				return (isFirstTimeStart == 1);
			end,
			AddSorted = function(T, list, item)
				if (list.Count == 0) then
					list:Add(item);
					return ;
				end;
				if (getexterninstanceindexer(list, nil, "get_Item", invokeintegeroperator(3, "-", list.Count, 1, System.Int32, System.Int32)):CompareTo(item) <= 0) then
					list:Add(item);
					return ;
				end;
				if (getexterninstanceindexer(list, nil, "get_Item", 0):CompareTo(item) >= 0) then
					list:Insert(0, item);
					return ;
				end;
				local index; index = list:BinarySearch(item);
				if (index < 0) then
					index = invokeintegeroperator(12, "~", nil, index, nil, System.Int32);
				end;
				list:Insert(index, item);
			end,
			cctor = function()
				Extentions.__cctor();
			end,
			__cctor = function()
				if Extentions.__cctor_called then
					return;
				else
					Extentions.__cctor_called = true;
				end
				Extentions.dateTime1970 = newexternobject(System.DateTime, "System.DateTime", nil, {});
			end,
		};

		local static_fields_build = function()
			local static_fields = {
				dateTime1970 = __cs2lua_nil_field_value,
				__cctor_called = false,
			};
			return static_fields;
		end;
		local static_props = nil;
		local static_events = nil;

		return defineclass(nil, "Extentions", static, static_methods, static_fields_build, static_props, static_events, nil, nil, nil, nil, nil, nil, false);
	end,
};
--namespace UIDemo
--{
--    public class UICommonHeader : MonoBehaviour, IEventListener
--    {
--        public delegate void OnBackBtnHandler();
--        public GameObject TitleContainer;
--        public GameObject OptionContainer;
--        public GameObject MailCountObj;
--        public UILabel MailCount;
--        public UILabel GoldValue;
--        public UILabel TicketValue;
--        public UILabel DiamondValue;
--        public UILabel TitleCaption;
--        public GameObject FadeInAni;
--        public GameObject FadeOutAni;
--        public event OnBackBtnHandler OnBackBtn = null;
--        void OnEnable()
--        {
--            AttachEvent();
--            UpdateUI();
--        }
--        void OnDisable()
--        {
--            DetachEvent();
--        }
--        public void UpdateUI()
--        {
--            UpdateMailUI();
--            UpdateMoneyUI();
--        }
--        public void UpdateMailUI()
--        {
--            int nMailCount = MailSystem.instance().GetNewMailCount();
--            UICommon.SetActive(MailCountObj, nMailCount > 0);
--            if (nMailCount > 0)
--            {
--                MailCount.text = nMailCount.ToString();
--            }
--        }
--        public void UpdateMoneyUI()
--        {
--            GoldValue.text = UICommon.GetCurrencyText(CharacterSystem.instance().MyInfo.GoldValue);
--            TicketValue.text = UICommon.GetCurrencyText(CharacterSystem.instance().MyInfo.TicketValue);
--            DiamondValue.text = UICommon.GetCurrencyText(CharacterSystem.instance().MyInfo.DiamondValue);
--        }
--        public void SetTitle(string strTitle)
--        {
--            if(strTitle.Length == 0)
--            {
--                UICommon.SetActive(TitleContainer, false);
--                UICommon.SetActive(OptionContainer, true);
--            }
--            else
--            {
--                UICommon.SetActive(TitleContainer, true);
--                UICommon.SetActive(OptionContainer, false);
--                TitleCaption.text = strTitle;
--            }
--        }
--        public void StartFadeIn()
--        {
--            UICommon.SetActive(FadeInAni, false);
--            UICommon.SetActive(FadeOutAni, false);
--            FadeInAni.SetActive(true);
--        }
--        public void StartFadeOut()
--        {
--            UICommon.SetActive(FadeInAni, false);
--            UICommon.SetActive(FadeOutAni, false);
--            FadeOutAni.SetActive(true);
--        }
--        #region BtnEvent
--        public void OnSettingBtnClick()
--        {
--            GameEntry.StateManager.PushStateFadeOut(typeof(HFEStateSetting));
--        }
--        public void OnMailBtnClick()
--        {
--            GameEntry.StateManager.PushStateFadeOut(typeof(HFEStateMail));
--        }
--        public void OnGiftBtnClick()
--        {
--            UICommonTip.ShowText("��Ҫ���ң��ߣ�", UICommonTip.ColError);
--        }
--        public void OnGoldClick()
--        {
--            UICommonTip.ShowText("��Ҫ���ң��ߣ�", UICommonTip.ColError);
--        }
--        public void OnGameGOldClick()
--        {
--            UICommonTip.ShowText("��Ҫ���ң��ߣ�", UICommonTip.ColError);
--        }
--        public void OnDiamondClick()
--        {
--            UICommonTip.ShowText("��Ҫ���ң��ߣ�", UICommonTip.ColError);
--        }
--        public void OnBackBtnClick()
--        {
--            if(OnBackBtn != null)
--            {
--                OnBackBtn();
--            }
--            else
--            {
--                GameEntry.StateManager.PopStateFadeOut();
--            }
--        }
--        #endregion
--        static public UICommonHeader GetActive()
--        {
--            GameObject pHeader = GameEntry.uiMgr.Show(UIHudDef.UI_COMMON_HEADER);
--            if (pHeader == null)
--            {
--                return null;
--            }
--            return pHeader.GetComponent<UICommonHeader>();
--        }
--        static public void Show(string strTitle, OnBackBtnHandler pHander = null)
--        {
--            GameObject pHeader = GameEntry.uiMgr.Show(UIHudDef.UI_COMMON_HEADER);
--            if (pHeader == null)
--            {
--                return;
--            }
--            UICommonHeader pUICommonHeader = pHeader.GetComponent<UICommonHeader>();
--            if(pUICommonHeader == null)
--            {
--                return;
--            }
--            pUICommonHeader.SetTitle(strTitle);
--            pUICommonHeader.OnBackBtn = pHander;
--        }
--        static public void Hide()
--        {
--            GameEntry.uiMgr.Hide(UIHudDef.UI_COMMON_HEADER);
--        }
--        #region Event
--        public bool OnFireEvent(uint key, object param1, object param2)
--        {
--            switch(key)
--            {
--                case (uint)EventDef.Character_MailChanged:
--                    {
--                        UpdateMailUI();
--                    } break;
--                case (uint)EventDef.Character_MoneyChanged:
--                    {
--                        UpdateMoneyUI();
--                    } break;
--            }
--            return false;
--        }
--        public int GetListenerPriority(uint eventKey)
--        {
--            return 0;
--        }
--        public void AttachEvent()
--        {
--            GameEntry.rootEventDispatcher.AttachListenerNow(this, (uint)EventDef.Character_MailChanged);
--            GameEntry.rootEventDispatcher.AttachListenerNow(this, (uint)EventDef.Character_MoneyChanged);
--        }
--        public void DetachEvent()
--        {
--            GameEntry.rootEventDispatcher.DetachListenerNow(this, (uint)EventDef.Character_MailChanged);
--            GameEntry.rootEventDispatcher.DetachListenerNow(this, (uint)EventDef.Character_MoneyChanged);
--        }
--        #endregion
--    }
--}
--local obj = TopLevel.Child2.Bar:new();
--obj:Test();



Extentions.__define_class();
