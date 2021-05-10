// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace SLua
{
    using System.Collections.Generic;
    using System;

    public class CustomExport
    {
        public static void OnGetAssemblyToGenerateExtensionMethod(out List<string> list)
        {
            list = new List<string> {
                "CustomApi",
                "UnityEngine",
                "UnityEngine.CoreModule",
                "UnityEngine.UIModule",
                "UnityEngine.TextRenderingModule",
                "UnityEngine.AnimationModule",
                "UnityEngine.PhysicsModule",
                "UnityEngine.ParticleSystemModule",
                "UnityEngine.ImageConversionModule",
                "UnityEngine.VideoModule",
                "UnityEngine.UI",
            };
        }

        public static void OnAddCustomClass(LuaCodeGen.ExportGenericDelegate add)
        {
            add(typeof(System.Func<int>), null);
            add(typeof(System.Action<int, string>), null);
            add(typeof(System.Action<int, Dictionary<int, object>>), null);
            add(typeof(System.Exception), "System.Exception");
            add(typeof(string), "System.String");
            add(typeof(System.Object), "System.Object");
            add(typeof(System.Array), "System.Array");
            add(typeof(System.Collections.ArrayList), "System.Collections.ArrayList");
            add(typeof(System.Collections.Hashtable), "System.Collections.Hashtable");
            add(typeof(System.Collections.BitArray), "System.Collections.BitArray");
            add(typeof(System.Collections.Queue), "System.Collections.Queue");
            add(typeof(System.Collections.Stack), "System.Collections.Stack");
            add(typeof(System.Collections.SortedList), "System.Collections.SortedList");
            add(typeof(byte[]), "ByteArray");
            add(typeof(System.Boolean), "System.Boolean");
            add(typeof(System.SByte), "System.SByte");
            add(typeof(System.Byte), "System.Byte");
            add(typeof(System.Int16), "System.Int16");
            add(typeof(System.UInt16), "System.UInt16");
            add(typeof(System.Int32), "System.Int32");
            add(typeof(System.UInt32), "System.UInt32");
            add(typeof(System.Int64), "System.Int64");
            add(typeof(System.UInt64), "System.UInt64");
            add(typeof(System.Single), "System.Single");
            add(typeof(System.Double), "System.Double");
            add(typeof(System.Convert), "System.Convert");
            add(typeof(System.TypeCode), "System.TypeCode");
            add(typeof(System.Type), "System.Type");
            add(typeof(System.Reflection.MemberInfo), "System.Reflection.MemberInfo");
            add(typeof(System.IO.File), "System.IO.File");
            add(typeof(System.IO.Path), "System.IO.Path");
            add(typeof(System.IO.Directory), "System.IO.Directory");
            add(typeof(System.IO.DirectoryInfo), "System.IO.DirectoryInfo");
            add(typeof(System.IO.Stream), "System.IO.Stream");
            add(typeof(System.IO.FileStream), "System.IO.FileStream");
            add(typeof(System.IO.BinaryReader), "System.IO.BinaryReader");
            add(typeof(System.IO.BinaryWriter), "System.IO.BinaryWriter");
            add(typeof(System.TimeSpan), "System.TimeSpan");
            add(typeof(System.TimeZone), "System.TimeZone");
            add(typeof(System.Math), "System.Math");
            add(typeof(System.Random), "System.Random");
            add(typeof(System.Delegate), "System.Delegate");
            add(typeof(System.Text.StringBuilder), "System.Text.StringBuilder");
            add(typeof(System.Text.Encoding), "System.Text.Encoding");
            add(typeof(System.Text.ASCIIEncoding), "System.Text.ASCIIEncoding");
            add(typeof(System.Text.UTF8Encoding), "System.Text.UTF8Encoding");
            add(typeof(System.Text.UnicodeEncoding), "System.Text.UnicodeEncoding");
            add(typeof(System.Text.RegularExpressions.Regex), "System.Text.RegularExpressions.Regex");
            add(typeof(System.Text.RegularExpressions.Match), "System.Text.RegularExpressions.Match");
            add(typeof(System.Text.RegularExpressions.MatchCollection), "System.Text.RegularExpressions.MatchCollection");
            add(typeof(System.Text.RegularExpressions.Group), "System.Text.RegularExpressions.Group");
            add(typeof(System.Text.RegularExpressions.GroupCollection), "System.Text.RegularExpressions.GroupCollection");
            add(typeof(System.Text.RegularExpressions.Capture), "System.Text.RegularExpressions.Capture");
            add(typeof(System.Text.RegularExpressions.CaptureCollection), "System.Text.RegularExpressions.CaptureCollection");
            add(typeof(System.GC), "System.GC");
            add(typeof(KeyValuePair<int, int>), "IntIntPair");
            add(typeof(KeyValuePair<int, float>), "IntFloatPair");
            add(typeof(KeyValuePair<int, string>), "IntStrPair");
            add(typeof(KeyValuePair<int, object>), "IntObjPair");
            add(typeof(KeyValuePair<int, UnityEngine.Object>), "IntUobjPair");
            add(typeof(KeyValuePair<string, int>), "StrIntPair");
            add(typeof(KeyValuePair<string, float>), "StrFloatPair");
            add(typeof(KeyValuePair<string, string>), "StrStrPair");
            add(typeof(KeyValuePair<string, object>), "StrObjPair");
            add(typeof(KeyValuePair<string, UnityEngine.Object>), "StrUobjPair");
            // add your custom class here
            // add( type, typename)
            // type is what you want to export
            // typename used for simplify generic type name or rename, like List<int> named to "ListInt", if not a generic type keep typename as null or rename as new type name
        }

        public static HashSet<string> OnAddCustomNamespace()
        {
            return new HashSet<string> {
                //"NLuaTest.Mock"
            };
        }

        public static void OnAddCustomAssembly(ref List<string> list)
        {
            // add your custom assembly here
            // you can build a dll for 3rd library like ngui titled assembly name "NGUI", put it in Assets folder
            // add its name into list, slua will generate all exported interface automatically for you

            //list.Add("NGUI");
            list.Add("CustomApi");
        }

        public static void OnGetCustomAssemblyUseList(out HashSet<string> list)
        {
            list = new HashSet<string> {
            };
        }
        public static void OnGetCustomAssemblyNoUseList(out List<string> list)
        {
            list = new List<string> {
            };
        }

        public static List<string> FunctionFilterList = new List<string>()
        {
            "System.Single.IsFinite",
            "System.Double.IsFinite",
            "System.Type.IsSZArray",
            "System.IO.Stream.CopyToAsync",
            "System.IO.Stream.FlushAsync",
            "System.IO.Stream.ReadAsync",
            "System.IO.Stream.BeginRead",
            "System.IO.Stream.EndRead",
            "System.IO.Stream.WriteAsync",
            "System.IO.Stream.BeginWrite",
            "System.IO.Stream.EndWrite",
            "UnityEngine.Debug.LogFormat",
            "UnityEngine.Debug.LogWarningFormat",
            "UnityEngine.Debug.LogErrorFormat",
            "UnityEngine.Debug.LogAssertionFormat",
            "UnityEngine.WWW.GetMovieTexture",
            "UnityEngine.Font.GetPathsToOSFonts",
        };
        // white list
        public static void OnGetUseList(out HashSet<string> list)
        {
            list = new HashSet<string>
            {

            };
        }
        // black list
        public static void OnGetNoUseList(out List<string> list)
        {
            list = new List<string>
            {      
                "HideInInspector",
                "ExecuteInEditMode",
                "AddComponentMenu",
                "ContextMenu",
                "RequireComponent",
                "DisallowMultipleComponent",
                "SerializeField",
                "AssemblyIsEditorAssembly",
                "Attribute", 
                "Types",
                "UnitySurrogateSelector",
                "TrackedReference",
                "TypeInferenceRules",
                "FFTWindow",
                "RPC",
                "Network",
                "MasterServer",
                "BitStream",
                "HostData",
                "ConnectionTesterStatus",
                "GUI",
                "EventType",
                "EventModifiers",
                "FontStyle",
                "TextAlignment",
                "TextEditor",
                "TextEditorDblClickSnapping",
                "TextGenerator",
                "TextClipping",
                "Gizmos",
                "ADBannerView",
                "ADInterstitialAd",            
                "Android",
                "Tizen",
                "jvalue",
                "iPhone",
                "iOS",
                "Windows",
                "CalendarIdentifier",
                "CalendarUnit",
                "CalendarUnit",
                "ClusterInput",
                "FullScreenMovieControlMode",
                "FullScreenMovieScalingMode",
                "Handheld",
                "LocalNotification",
                "NotificationServices",
                "RemoteNotificationType",      
                "RemoteNotification",
                "SamsungTV",
                "TextureCompressionQuality",
                "TouchScreenKeyboardType",
                "TouchScreenKeyboard",
                "UnityEngineInternal",
                "Terrain",                            
                "Tree",
                "SplatPrototype",
                "DetailPrototype",
                "DetailRenderMode",
                "MeshSubsetCombineUtility",
                "AOT",
                "Social",
                "Enumerator",       
                "SendMouseEvents",               
                "Cursor",
                "Flash",
                "ActionScript",
                "OnRequestRebuild",
                "Ping",
                "ShaderVariantCollection",
                "SimpleJson.Reflection",
                "CoroutineTween",
                "GraphicRebuildTracker",
                "Advertisements",
                "UnityEditor",
			    "WSA",
			    "EventProvider",
			    "Apple",
			    "ClusterInput",
                "CullingParameters",
                "CullResults",
                "ShadowSplitData",
                "DisposeSentinel",
                "ReflectionMethodsCache",
                "MovieTexture",
                "2D",
                "Cache",
                "CachedAssetBundle",
                "Caching",
                "Compute",
                "CharacterController",
                "ConstantForce",
                "ContactPoint",
                "ControllerColliderHit",
                "CrashReport",
                "Cubemap",
                "CullingGroup",
                "CustomRenderTexture",
                "Experimental",
                "Joint",
                "ForceMode",
                "Lightmap",
                "LightProbe",
                "Rendering",
                "Rigidbody",
                "CharacterInfo",
                "LOD",
                "Unsafe",
                "UnityM1Extension",
                "UnityM1Version",
				"ParticleSystemForceField",
                "UnityStats2"
            };
        }
    }
}