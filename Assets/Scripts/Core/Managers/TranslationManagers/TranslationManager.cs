using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Core.Managers.ItemManagers.ScriptableObjects;
using Core.Managers.TranslationManagers.ScriptableObjects;
using Core.Singletons;
using UnityEditor;
using UnityEngine;

namespace Core.Managers.TranslationManagers
{
    public class TranslationManager : SingletonMonoBehaviour<TranslationManager>
    {
        private string currentLanguage = "en-US";
        private readonly Dictionary<string, LanguageSo> _languages = new();
        
        private void Start()
        {
            AssetDatabase.CreateFolder("Assets/_tmp","Languages");  
        }
        
        public LanguageSo CreateLanguageSo(string id)
        {
            var asset = ScriptableObject.CreateInstance<LanguageSo>();
            asset.ID = id;
            _languages.Add(id, asset);
            AssetDatabase.CreateAsset(asset, $"Assets/_tmp/Languages/{id}.asset");
            return GetLanguageSo(id);
        }
        
        public LanguageSo GetLanguageSo(string id)
        {
            return _languages.ContainsKey(id) ?  _languages[id] : null;
        }

        public string GetCurrentTranslation(string key)
        {
            return GetTranslation(currentLanguage, key);
        }

        public string GetTranslation(string id, string key)
        {
            var language = GetLanguageSo(id);
            if (language == null)
            {
                return key;
            }
            return language.Translations.ContainsKey(key) ?  language.Translations[key] : key;
        }

        public void LoadFromCsvFile(string path)
        {
            var csvText = File.ReadAllText(path);
            var grid = CsvParser2.Parse(csvText);
            
            var languages = new string[grid.Length];
            for (var x = 1; x < grid[0].Length; x++)
            {
                var id = grid[0][x];
                CreateLanguageSo(id);
                languages[x] = id;
            }
            
            
            for (var y = 1; y < grid.Length; y++)
            {
                for (var x = 1; x < grid[0].Length; x++)
                {
                    var curLanguage = languages[x];
                    var key = grid[y][0];
                    var value = grid[y][x];
                    GetLanguageSo(curLanguage).Translations.Add(key, value);
                }
            }
        }
        
        public void Clear()
        {
            
        }
    }
}