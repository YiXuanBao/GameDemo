#if UNITY_EDITOR
using System.IO;
using UnityEngine;
namespace Laro.EditorTools
{

    /// <summary>
    /// 默认编辑器配置项
    /// </summary>
    public class ConstEditor
    {
        public const bool AutoScriptUTF8 = true;//新建脚本时自动修改脚本编码方式为utf-8以支持中文
        
        public static readonly string PrefabsPath = "Assets/GameRes/Prefabs";
        public static readonly string ScenePath = "Assets/GameRes/Scenes";

        public const string BuiltinAssembly = "Assets/GameRes/ScriptsBuiltin/Runtime/Builtin.Runtime.asmdef";
        public const string HotfixAssembly = "Assets/GameRes/Scripts/Hotfix.asmdef";


        public static readonly string UpdatePrefixUri = "http://127.0.0.1/1_0_0_1/";//默认资源下载地址
        internal static readonly string AppUpdateUrl = "https://play.google.com/store/apps/details?id=";


        public const string DataTablePath = "Assets/GameRes/DataTable";
        public const string GameConfigPath = "Assets/GameRes/Config";
        public const string LanguagePath = "Assets/GameRes/Language";
        public const string DataTableCodePath = "Assets/GameRes/Scripts/DataTable";
        public const string UIScriptsPath = "Assets/GameRes/Scripts/UI";
        public const string UIItemScriptsPath = "Assets/GameRes/Scripts/UI/Item";
        public const string UIFormTemplate = "Assets/GameRes/ScriptsBuiltin/Editor/UI/Templates/UIFormTemplate.prefab";
        public const string UIDialogTemplate = "Assets/GameRes/ScriptsBuiltin/Editor/UI/Templates/UIDialogTemplate.prefab";
        public const string UIItemTemplate = "Assets/GameRes/ScriptsBuiltin/Editor/UI/Templates/UIItemTemplate.prefab";
        public const string UIScriptFileTemplate = "Assets/GameRes/ScriptsBuiltin/Editor/UI/Templates/UIScriptFileTemplate.txt";
        public const string UIItemScriptFileTemplate = "Assets/GameRes/ScriptsBuiltin/Editor/UI/Templates/UIItemScriptFileTemplate.txt";
    }
}
#endif