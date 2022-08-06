using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Managers.TranslationManagers.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Lua API/Language", fileName = "New Language")]
    public class LanguageSo : SerializedScriptableObject
    {
        [field: SerializeField] public string ID { get; set; }
        [field: SerializeField] public Dictionary<string, string> Translations = new();
    }
}