require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("transform");

class(Extentions) {
	static_methods {
		timeInMillisecond = function(dateTime){
			return(execbinary("/", getinstance(dateTime, "Ticks"), 10000, System.Int64, System.Int64, TypeKind.Struct, TypeKind.Struct));
		};
		timeSince1970 = function(dateTime){
			return(typecast(( execbinary("/", callextension(Extentions, "timeSince1970InMillisecond", dateTime), 1000, System.Int64, System.Int64, TypeKind.Struct, TypeKind.Struct) ), System.Int64, TypeKind.Struct));
		};
		timeSince1970InMillisecond = function(dateTime){
			comment("return (long)(Time.realtimeSinceStartup * 1000);");
			if( execbinary("==", getinstance(getstatic(Extentions, "dateTime1970"), "Ticks"), 0, System.Int64, System.Int64, TypeKind.Struct, TypeKind.Struct) ){
				comment("Debug.LogError(\"Ticks = 0\");");
				getstatic(Extentions, "dateTime1970") = callstatic(System.DateTime, "Parse", "System.DateTime:Parse__String", "1970-1-1");
			};
			local(v); v = 4;
			local(ts); ts = invokeexternoperator(System.TimeSpan, System.DateTime, "op_Subtraction", "System.DateTime:op_Subtraction__DateTime__DateTime", dateTime, getstatic(Extentions, "dateTime1970"));
			return(typecast(getinstance(ts, "TotalMilliseconds"), System.Int64, TypeKind.Struct));
		};
		findChildRecursively = function(transform, childName, maxDepth){
;
			if( execbinary("&&", 			return(child);
		};
		searchChildRecursively = function(transform, childName, maxDepth){
			if( execbinary("!=", , -1, , System.Int32, TypeKind.Error, TypeKind.Struct) ){
				return(transform);
			};
			local(count); count = transform.childCount;
			if( execbinary(">", maxDepth, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				local(i); i = 0;
				while( execbinary("<", i, count, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
;
					local(searchRes); searchRes = callstatic(Extentions, "searchChildRecursively", nowNode, childName, execbinary("-", maxDepth, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
					if( 				i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
				};
			};
			return(null);
		};
		isFirstTimeToStart = function(){
;
			return(execbinary("==", isFirstTimeStart, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
		};
		AddSorted = function(T, list, item){
			if( execbinary("==", getinstance(list, "Count"), 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				callinstance(list, "Add", item);
				return();
			};
			if( execbinary("<=", callinstance(getexterninstanceindexer(System.Collections.Generic.List_T, typeargs(T), typekinds(TypeKind.TypeParameter), list, null, System.Collections.Generic.List_T, "get_Item", 1, execbinary("-", getinstance(list, "Count"), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct)), "CompareTo", item), 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				callinstance(list, "Add", item);
				return();
			};
			if( execbinary(">=", callinstance(getexterninstanceindexer(System.Collections.Generic.List_T, typeargs(T), typekinds(TypeKind.TypeParameter), list, null, System.Collections.Generic.List_T, "get_Item", 1, 0), "CompareTo", item), 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				callinstance(list, "Insert", 0, item);
				return();
			};
			local(index); index = callinstance(list, "BinarySearch", "System.Collections.Generic.List_T:BinarySearch__Object", item);
			if( execbinary("<", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				index = execunary("~", index, System.Int32, TypeKind.Struct);
			};
			callinstance(list, "Insert", index, item);
		};
		cctor = function(){
			callstatic(Extentions, "__cctor");
		};
		__cctor = function(){
			if(Extentions.__cctor_called){
				return;
			}else{
				Extentions.__cctor_called = true;
			};
			Extentions.dateTime1970 = newexternobject(System.DateTime, typeargs(), typekinds(), null);
		};
	};
	static_fields {
		dateTime1970 = null;
		__cctor_called = false;
	};
	static_props {};
	static_events {};

};
comments {	comment("namespace UIDemo");
	comment("{");
	comment("    public class UICommonHeader : MonoBehaviour, IEventListener");
	comment("    {");
	comment("        public delegate void OnBackBtnHandler();");
	comment("        public GameObject TitleContainer;");
	comment("        public GameObject OptionContainer;");
	comment("        public GameObject MailCountObj;");
	comment("        public UILabel MailCount;");
	comment("        public UILabel GoldValue;");
	comment("        public UILabel TicketValue;");
	comment("        public UILabel DiamondValue;");
	comment("        public UILabel TitleCaption;");
	comment("        public GameObject FadeInAni;");
	comment("        public GameObject FadeOutAni;");
	comment("        public event OnBackBtnHandler OnBackBtn = null;");
	comment("        void OnEnable()");
	comment("        {");
	comment("            AttachEvent();");
	comment("            UpdateUI();");
	comment("        }");
	comment("        void OnDisable()");
	comment("        {");
	comment("            DetachEvent();");
	comment("        }");
	comment("        public void UpdateUI()");
	comment("        {");
	comment("            UpdateMailUI();");
	comment("            UpdateMoneyUI();");
	comment("        }");
	comment("        public void UpdateMailUI()");
	comment("        {");
	comment("            int nMailCount = MailSystem.instance().GetNewMailCount();");
	comment("            UICommon.SetActive(MailCountObj, nMailCount > 0);");
	comment("            if (nMailCount > 0)");
	comment("            {");
	comment("                MailCount.text = nMailCount.ToString();");
	comment("            }");
	comment("        }");
	comment("        public void UpdateMoneyUI()");
	comment("        {");
	comment("            GoldValue.text = UICommon.GetCurrencyText(CharacterSystem.instance().MyInfo.GoldValue);");
	comment("            TicketValue.text = UICommon.GetCurrencyText(CharacterSystem.instance().MyInfo.TicketValue);");
	comment("            DiamondValue.text = UICommon.GetCurrencyText(CharacterSystem.instance().MyInfo.DiamondValue);");
	comment("        }");
	comment("        public void SetTitle(string strTitle)");
	comment("        {");
	comment("            if(strTitle.Length == 0)");
	comment("            {");
	comment("                UICommon.SetActive(TitleContainer, false);");
	comment("                UICommon.SetActive(OptionContainer, true);");
	comment("            }");
	comment("            else");
	comment("            {");
	comment("                UICommon.SetActive(TitleContainer, true);");
	comment("                UICommon.SetActive(OptionContainer, false);");
	comment("                TitleCaption.text = strTitle;");
	comment("            }");
	comment("        }");
	comment("        public void StartFadeIn()");
	comment("        {");
	comment("            UICommon.SetActive(FadeInAni, false);");
	comment("            UICommon.SetActive(FadeOutAni, false);");
	comment("            FadeInAni.SetActive(true);");
	comment("        }");
	comment("        public void StartFadeOut()");
	comment("        {");
	comment("            UICommon.SetActive(FadeInAni, false);");
	comment("            UICommon.SetActive(FadeOutAni, false);");
	comment("            FadeOutAni.SetActive(true);");
	comment("        }");
	comment("        #region BtnEvent");
	comment("        public void OnSettingBtnClick()");
	comment("        {");
	comment("            GameEntry.StateManager.PushStateFadeOut(typeof(HFEStateSetting));");
	comment("        }");
	comment("        public void OnMailBtnClick()");
	comment("        {");
	comment("            GameEntry.StateManager.PushStateFadeOut(typeof(HFEStateMail));");
	comment("        }");
	comment("        public void OnGiftBtnClick()");
	comment("        {");
	comment("            UICommonTip.ShowText(\"��Ҫ���ң��ߣ�\", UICommonTip.ColError);");
	comment("        }");
	comment("        public void OnGoldClick()");
	comment("        {");
	comment("            UICommonTip.ShowText(\"��Ҫ���ң��ߣ�\", UICommonTip.ColError);");
	comment("        }");
	comment("        public void OnGameGOldClick()");
	comment("        {");
	comment("            UICommonTip.ShowText(\"��Ҫ���ң��ߣ�\", UICommonTip.ColError);");
	comment("        }");
	comment("        public void OnDiamondClick()");
	comment("        {");
	comment("            UICommonTip.ShowText(\"��Ҫ���ң��ߣ�\", UICommonTip.ColError);");
	comment("        }");
	comment("        public void OnBackBtnClick()");
	comment("        {");
	comment("            if(OnBackBtn != null)");
	comment("            {");
	comment("                OnBackBtn();");
	comment("            }");
	comment("            else");
	comment("            {");
	comment("                GameEntry.StateManager.PopStateFadeOut();");
	comment("            }");
	comment("        }");
	comment("        #endregion");
	comment("        static public UICommonHeader GetActive()");
	comment("        {");
	comment("            GameObject pHeader = GameEntry.uiMgr.Show(UIHudDef.UI_COMMON_HEADER);");
	comment("            if (pHeader == null)");
	comment("            {");
	comment("                return null;");
	comment("            }");
	comment("            return pHeader.GetComponent<UICommonHeader>();");
	comment("        }");
	comment("        static public void Show(string strTitle, OnBackBtnHandler pHander = null)");
	comment("        {");
	comment("            GameObject pHeader = GameEntry.uiMgr.Show(UIHudDef.UI_COMMON_HEADER);");
	comment("            if (pHeader == null)");
	comment("            {");
	comment("                return;");
	comment("            }");
	comment("            UICommonHeader pUICommonHeader = pHeader.GetComponent<UICommonHeader>();");
	comment("            if(pUICommonHeader == null)");
	comment("            {");
	comment("                return;");
	comment("            }");
	comment("            pUICommonHeader.SetTitle(strTitle);");
	comment("            pUICommonHeader.OnBackBtn = pHander;");
	comment("        }");
	comment("        static public void Hide()");
	comment("        {");
	comment("            GameEntry.uiMgr.Hide(UIHudDef.UI_COMMON_HEADER);");
	comment("        }");
	comment("        #region Event");
	comment("        public bool OnFireEvent(uint key, object param1, object param2)");
	comment("        {");
	comment("            switch(key)");
	comment("            {");
	comment("                case (uint)EventDef.Character_MailChanged:");
	comment("                    {");
	comment("                        UpdateMailUI();");
	comment("                    } break;");
	comment("                case (uint)EventDef.Character_MoneyChanged:");
	comment("                    {");
	comment("                        UpdateMoneyUI();");
	comment("                    } break;");
	comment("            }");
	comment("            return false;");
	comment("        }");
	comment("        public int GetListenerPriority(uint eventKey)");
	comment("        {");
	comment("            return 0;");
	comment("        }");
	comment("        public void AttachEvent()");
	comment("        {");
	comment("            GameEntry.rootEventDispatcher.AttachListenerNow(this, (uint)EventDef.Character_MailChanged);");
	comment("            GameEntry.rootEventDispatcher.AttachListenerNow(this, (uint)EventDef.Character_MoneyChanged);");
	comment("        }");
	comment("        public void DetachEvent()");
	comment("        {");
	comment("            GameEntry.rootEventDispatcher.DetachListenerNow(this, (uint)EventDef.Character_MailChanged);");
	comment("            GameEntry.rootEventDispatcher.DetachListenerNow(this, (uint)EventDef.Character_MoneyChanged);");
	comment("        }");
	comment("        #endregion");
	comment("    }");
	comment("}");
};
comments {	comment("local obj = TopLevel.Child2.Bar:new();");
	comment("obj:Test();");
};



