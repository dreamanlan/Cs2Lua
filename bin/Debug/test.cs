using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Cs2Lua.Ignore]
class LuaConsole
{
    public static void Print(params object[] args)
    {
    }
}

class TestUnity : MonoBehaviour
{
    void Test(params object[] args)
    {
        if (args.Length >= 3) {
            int sagatObjId = (int)args[0];
            int protectObjId = (int)args[1];
            int attackObjId = (int)args[2];
        }
        var t = gameObject.GetComponent<Transform>();
        gameObject.SetActive(true);
        var r = gameObject.renderer;
        gameObject.active=true;
        bool v = true;
        string s = v.ToString();
        int i = 123;
        string s = i.ToString();     
        int i = s.IndexOf('2');
        LuaConsole.Print(i);
    }
}

public class foo<T, K>
{
    public void parse(string a, string b)
    {
        var t = typeof(T);
        var k = typeof(K);
    }
}

public class bar 
{
    public void test()
    {
        foo<int, int> a = new foo<int, int>();
        a.parse("123", "456");
    }
}

namespace UIDemo
{
    class UICommon<CT> where CT : Component
    {
        public static T StaticCreateCustomComponent<T>(string strName, Transform pParent) where T : Component
        {
            GameObject pObj = new GameObject(strName/*, typeof(T)*/);
            if (pObj != null)
            {
                if (pParent != null)
                {
                    pObj.transform.parent = pParent;
                }
                pObj.AddComponent<CT>();
                return pObj.AddComponent<T>();
            }
            else
            {
                Debug.LogError("Error! NULL=" + typeof(T).ToString());
            }
            return null;
        }
        public T CreateCustomComponent<T>(string strName, Transform pParent) where T : Component
        {
            GameObject pObj = new GameObject(strName/*, typeof(T)*/);
            if (pObj != null)
            {
                if (pParent != null)
                {
                    pObj.transform.parent = pParent;
                }
                pObj.AddComponent<CT>();
                return pObj.AddComponent<T>();
            }
            else
            {
                Debug.LogError("Error! NULL=" + typeof(T).ToString());
            }
            return null;
        }
    }
}

namespace TopLevel
{
    using lua = LuaConsole;

    enum TestEnum
    {
        Invalid = int.MinValue,
        One = 1,
        Two,
        Three,
    }

    struct TestStruct
    {
        public int A;
        public int B;
        public int C;
    }

    public interface IRunnable0
    {
        void Test();
    }

    public interface IRunnable<T> : IRunnable0
    {
        void Test2();
        int this[int ix]{get;set;}
        int TestProp {get;set;}
        event Action OnAction;
    }

    public class Runnable : IRunnable<int>
    {
        void IRunnable0.Test()
        {
            LuaConsole.Print("test.");
        }
        int IRunnable<int>.TestProp
        {
            get{return 1;}
            set{}
        }
        public int this[int ix]
        {
            get
            {
                return 1;
            }
            set{}
        }
        public void Test2()
        {

        }
        event Action IRunnable<int>.OnAction
        {
            add{}
            remove{}
        }
    }

    public class TestRunnable
    {
        public void Test()
        {
            IRunnable<int> f = new Runnable();
            f.Test();
            int i = f[0];
            f[0]=i;
            f.TestProp = i;
            i = f.TestProp;
            Action a = ()=>{};
            f.OnAction+=a;
            f.OnAction-=a;
            float t = float.NegativeInfinity;
            t = float.NaN;
        }
    }

    public class Singleton<T> where T : new()
    {
        protected static T ms_instance;
        public static T instance
        {
            get
            {
                if (ms_instance == null) 
                {
                    ms_instance = new T();
                }
                return ms_instance;
            }
            set
            {

            }
        }

        public Singleton()
        {
            if (ms_instance != null)
            {
                Debug.LogError("Cannot have two instances in singleton");
                return;
            }
            ms_instance = (T)(System.Object)this;
        }

        public static void Delete()
        {
            ms_instance = default(T) ;
        }
    }
    
    namespace SecondLevel
    {
        public class GenericClass<T> where T : new()
        {
            public class InnerGenericClass<TT> where TT : new()
            {
                public InnerGenericClass(T v, TT vv)
                {
                    m_T = v;
                    m_TT = vv;
                    T obj1 = new T();
                    TT obj2 = new TT();
                }
                public void Test<G>(G g)
                {
                    T v = g as T;
                    T v = (T)(object)g;
                    Foo f = new Foo();
                    f.Test3();
                }
                public void Test2<GG>(T t, TT tt)
                {
                    Type t1 = typeof(GG);
                    Type t2 = typeof(T);
                    Type t3 = typeof(TT);
                    Type t4 = typeof(int);
                    var v = (TT)t;
                }

                private T m_T = default(T);
                private TT m_TT = default(TT);
                private Type m_TypeT = typeof(T);
                private Type m_TypeTT = typeof(TT);
            }

            public static int TTT = 789;
            public GenericClass(ref int v, out int v2)
            {
                T obj = new T();
                m_Test = v + 456;
                v2 = 123;
            }
            public void Test<G>()
            {
                var t = typeof(G);
            }
            private int m_Test = 123;
            private int m_Test2 = TTT + 1;
            private T m_Inst = new T();

            static GenericClass()
            {
                s_Test = 9876;
            }
            private static int s_Test = int.MaxValue;
            private static float s_Float = float.PositiveInfinity;
            private static T s_Inst = new T();
        }
        delegate void SimpleEventHandler();
        class FooBase
        {
            internal int m_Ttt = 6789;
        }
        [Cs2Lua.EnableInherit]
        class Foo : FooBase
        {
            class Test1
            { }
            class Test2
            { }

            class FooChild
            {
                internal int m_Test1 = 123;
                internal int m_Test2 = 456;
            }

            public event SimpleEventHandler OnSimple;
            public SimpleEventHandler OnSimple2;
            public event SimpleEventHandler EventBridge
            {
                add
                {

                }
                remove
                {

                }
            }
            public static event SimpleEventHandler StaticEventBridge
            {
                add
                {

                }
                remove
                {

                }
            }

            public TestStruct Val
            {
                get
                {
                    return this.m_TS;
                }
                set
                {
                    this.m_TS=value;
                }
            }
            public int this[params TestStruct[] args]
            {
                get
                {
                    return 1;
                }
                set
                {

                }
            }

            public Foo():this(0)
            {}
            public Foo(int v):base()
            {
                this.m_Test = v;
            }
            public Foo(int a, int b)
            {}

            public static Foo operator + (Foo self, Foo other)
            {
                self.m_Test += other.m_Test;
                return self;
            }
            public static Foo operator + (Foo self, int val)
            {
                self.m_Test += val;
                return self;
            }
            public static explicit operator Foo (int a)
            {
                var f = new Foo();
                f.m_Test = a;
                f.Val = new TestStruct();
                var ts = f.Val;
                f[ts,ts]=123;
                int r = f[ts,ts];
                f?[ts,ts]=123;
                r = f?[ts,ts];

                int result = Singleton<Foo>.instance.Test123(1,2);
                Singleton<Foo>.instance = null;
                return f;
            }

            public int Test123(int a = 1, float b = float.NegativeInfinity) => a+b;

            public void GTest(GenericClass<int> arg){}
            public void GTest(GenericClass<float> arg){}

            public IEnumerable Iterator()
            {
                yield return null;
                yield return new UnityEngine.WaitForSeconds(3);
                yield break;
            }

            public IEnumerator Iterator2()
            {
                yield return null;
                yield break;
            }

            public void Test()
            {
                Test123();
                float abc = float.NegativeInfinity;
                GenericClass<Test1>.InnerGenericClass<Test2> t = new GenericClass<Test1>.InnerGenericClass<Test2>(new Test1(), new Test2());
                t.Test(123);
                t.Test2<int>(new Test1(), new Test2());

                int v;
                int vv=TestLocal(out v);

                TestStruct ts = new TestStruct();
                ts.A=1;
                ts.B=2;
                ts.C=3;
                TestStruct ts2 = ts;
                TestStruct ts3;
                ts3=ts;
                TestValueArg(ts);

                if(OnSimple!=null){
                    OnSimple();
                }

                var f = OnSimple;
                if(null!=f){
                    f();
                }
            }

            private int TestLocal(out int v)
            {
                IRunnable ir = new Runnable();
                ir.Test();
                v = 1;
                return 2;
            }
            private int TestValueArg(TestStruct ts)
            {
                ts.A=4;
                ts.B=5;
                ts.C=6;
            }
            private int TestContinueAndReturn()
            {
                for (int i = 0; i < 100; ++i) {
                    if (i < 10) {
                        continue;
                    }
                    return i;
                }
                return -1;
            }
            private void TestSwitch()
            {
                int i=10;
                switch (i) {
                    case 1:
                        return;
                    case 2:
                        return;
                    default:
                        return;
                }
                if (i > 3) {
                    return;
                }
                if (this is FooBase) {
                    return;
                }
            }

            internal int m_Test = 0;
            internal int m_Test2 = 0;
            internal TestStruct m_TS;
            private HashSet<string> m_HashSet = new HashSet<string> { "one", "two", "three" };
        } 

        static class FooExtension
        {
            public static void Test3(this Foo obj)
            {
                if (obj.m_Test > 0) {
                    obj.m_Test2 = 678;
                }
                List<List<int>> f = new List<List<int>> { { 1, 2 }, { 2, 3 } };
            }
            public static void Test3(Foo @this, int ix)
            {
                @this.Test123(123,456);
            }
            public static void TestExtern(this GameObject obj)
            { }
            public static void NormalMethod()
            {
                LuaConsole.Print(1, 2, 3, 4, 5);
                Foo f = new Foo();
                Foo ff = new Foo();

                Action f1 = f.Test;
                f1();

                Action f2 = f.Test3;
                f2();

                Test3(f);

                var r = f + ff;

                f+=ff;
                
                var rr = (Foo)123;

                var rrr = 123 as Foo;

                var obj = new GameObject("test test test");

                var arr = new int[] {1,2,3,4,56};
                var v = arr[2];
                var dict = new Dictionary<int,int> {{1,2},{3,4}};
                var v1 = dict?[1];
                List<int> list = null;
                var l = list?.Count;
                list?.Add(1);
                var v2 = list?[3]=1;
                int[] arr2 = new int[]{1,2,3,4};
                var v3 = arr2?[2]; 
                arr2?[3]=345;
                int a=1,b=2,c=3;
                a=b=c++;
            }
        }
    }
}


public static class Extentions
{

	private static DateTime dateTime1970;

	public static long timeInMillisecond(this DateTime dateTime)
	{
		return dateTime.Ticks / 10000;
	}

	public static long timeSince1970(this DateTime dateTime)
	{
		return (long)(dateTime.timeSince1970InMillisecond()/1000);
	}

	public static long timeSince1970InMillisecond(this DateTime dateTime)
	{
		//return (long)(Time.realtimeSinceStartup * 1000);
		if (dateTime1970.Ticks == 0){
			//Debug.LogError("Ticks = 0");
			dateTime1970 = DateTime.Parse("1970-1-1");
		}

		TimeSpan ts = dateTime - dateTime1970;
		return(long)ts.TotalMilliseconds;

	}

    /// <summary>
    /// 搜索指定名字的子节点
    /// 
    /// 默认最多递归16层 保证安全跟性能
    /// </summary>
    /// <param name="transform"></param>
    /// <param name="childName"></param>
    /// <returns></returns>
	public static Transform findChildRecursively(this Transform transform, string childName,int maxDepth = 16)
	{
		Transform child = transform.FindChild(childName);

		if (child == null && maxDepth > 0) {
			int childCount = transform.childCount;
			for (int i=0; i<childCount; i++){
				child = transform.GetChild(i).findChildRecursively(childName,maxDepth - 1);

				if (child != null){
					break;
				}
                break;
			}
		}

		return child;
	}
    
    /// <summary>
    /// 搜索名字包含指定关键字的子节点
    /// 
    /// 默认最多递归16层
    /// </summary>
    /// <param name="transform"></param>
    /// <param name="childName"></param>
    /// <returns></returns>
    public static Transform searchChildRecursively(this Transform transform, string childName,int maxDepth = 16)
    {
        if (transform.name.IndexOf(childName) != -1)
        {
            return  transform;
        }

        int count = transform.childCount;
        if (maxDepth > 0)
        {
            for (int i = 0; i < count; i++)
            {
                Transform nowNode = transform.GetChild(i);
                Transform searchRes = searchChildRecursively(nowNode, childName, maxDepth - 1);
                if (searchRes != null)
                    return searchRes;
            }
        }

        return null;
    }

	public static bool isFirstTimeToStart()
	{
		int isFirstTimeStart = PlayerPrefs.GetInt("isFirstTimeToStart", 1);
		return isFirstTimeStart == 1;
	}

    public static void AddSorted<T>(this List<T> list, T item) where T : IComparable<T>
    {
        if (list.Count == 0)
        {
            list.Add(item);
            return;
        }
        if (list[list.Count - 1].CompareTo(item) <= 0)
        {
            list.Add(item);
            return;
        }
        if (list[0].CompareTo(item) >= 0)
        {
            list.Insert(0, item);
            return;
        }
        int index = list.BinarySearch(item);
        if (index < 0)
            index = ~index;
        list.Insert(index, item);
    }
}
/*
namespace UIDemo
{
    public class UICommonHeader : MonoBehaviour, IEventListener
    {
        public delegate void OnBackBtnHandler();

        public GameObject TitleContainer;
        public GameObject OptionContainer;

        public GameObject MailCountObj;
        public UILabel MailCount;

        public UILabel GoldValue;
        public UILabel TicketValue;
        public UILabel DiamondValue;
        public UILabel TitleCaption;

        public GameObject FadeInAni;
        public GameObject FadeOutAni;

        public event OnBackBtnHandler OnBackBtn = null;

        void OnEnable()
        {
            AttachEvent();
            UpdateUI();
        }

        void OnDisable()
        {
            DetachEvent();
        }

        public void UpdateUI()
        {
            UpdateMailUI();
            UpdateMoneyUI();
        }

        public void UpdateMailUI()
        {
            int nMailCount = MailSystem.instance().GetNewMailCount();
            UICommon.SetActive(MailCountObj, nMailCount > 0);
            if (nMailCount > 0)
            {
                MailCount.text = nMailCount.ToString();
            }
        }
        public void UpdateMoneyUI()
        {
            GoldValue.text = UICommon.GetCurrencyText(CharacterSystem.instance().MyInfo.GoldValue);
            TicketValue.text = UICommon.GetCurrencyText(CharacterSystem.instance().MyInfo.TicketValue);
            DiamondValue.text = UICommon.GetCurrencyText(CharacterSystem.instance().MyInfo.DiamondValue);
        }

        public void SetTitle(string strTitle)
        {
            if(strTitle.Length == 0)
            {
                UICommon.SetActive(TitleContainer, false);
                UICommon.SetActive(OptionContainer, true);
            }
            else
            {
                UICommon.SetActive(TitleContainer, true);
                UICommon.SetActive(OptionContainer, false);
                TitleCaption.text = strTitle;
            }
        }

        public void StartFadeIn()
        {
            UICommon.SetActive(FadeInAni, false);
            UICommon.SetActive(FadeOutAni, false);
            FadeInAni.SetActive(true);
        }

        public void StartFadeOut()
        {
            UICommon.SetActive(FadeInAni, false);
            UICommon.SetActive(FadeOutAni, false);
            FadeOutAni.SetActive(true);
        }

        #region BtnEvent
        public void OnSettingBtnClick()
        {
            GameEntry.StateManager.PushStateFadeOut(typeof(HFEStateSetting));
        }

        public void OnMailBtnClick()
        {
            GameEntry.StateManager.PushStateFadeOut(typeof(HFEStateMail));
        }

        public void OnGiftBtnClick()
        {
            UICommonTip.ShowText("不要搞我！哼！", UICommonTip.ColError);
        }

        public void OnGoldClick()
        {
            UICommonTip.ShowText("不要搞我！哼！", UICommonTip.ColError);
        }

        public void OnGameGOldClick()
        {
            UICommonTip.ShowText("不要搞我！哼！", UICommonTip.ColError);
        }

        public void OnDiamondClick()
        {
            UICommonTip.ShowText("不要搞我！哼！", UICommonTip.ColError);
        }

        public void OnBackBtnClick()
        {
            if(OnBackBtn != null)
            {
                OnBackBtn();
            }
            else
            {
                GameEntry.StateManager.PopStateFadeOut();
            }
        }
        #endregion

        static public UICommonHeader GetActive()
        {
            GameObject pHeader = GameEntry.uiMgr.Show(UIHudDef.UI_COMMON_HEADER);
            if (pHeader == null)
            {
                return null;
            }
            return pHeader.GetComponent<UICommonHeader>();
        }
        static public void Show(string strTitle, OnBackBtnHandler pHander = null)
        {
            GameObject pHeader = GameEntry.uiMgr.Show(UIHudDef.UI_COMMON_HEADER);
            if (pHeader == null)
            {
                return;
            }
            UICommonHeader pUICommonHeader = pHeader.GetComponent<UICommonHeader>();
            if(pUICommonHeader == null)
            {
                return;
            }
            pUICommonHeader.SetTitle(strTitle);
            pUICommonHeader.OnBackBtn = pHander;
        }
        static public void Hide()
        {
            GameEntry.uiMgr.Hide(UIHudDef.UI_COMMON_HEADER);
        }

        #region Event
        public bool OnFireEvent(uint key, object param1, object param2)
        {
            switch(key)
            {
                case (uint)EventDef.Character_MailChanged:
                    {
                        UpdateMailUI();
                    } break;
                case (uint)EventDef.Character_MoneyChanged:
                    {
                        UpdateMoneyUI();
                    } break;
            }
            return false;
        }
        public int GetListenerPriority(uint eventKey)
        {
            return 0;
        }
        public void AttachEvent()
        {
            GameEntry.rootEventDispatcher.AttachListenerNow(this, (uint)EventDef.Character_MailChanged);
            GameEntry.rootEventDispatcher.AttachListenerNow(this, (uint)EventDef.Character_MoneyChanged);
        }
        public void DetachEvent()
        {
            GameEntry.rootEventDispatcher.DetachListenerNow(this, (uint)EventDef.Character_MailChanged);
            GameEntry.rootEventDispatcher.DetachListenerNow(this, (uint)EventDef.Character_MoneyChanged);
        }
        #endregion
    }
}
*/
/*
local obj = TopLevel.Child2.Bar:new();
obj:Test();
*/