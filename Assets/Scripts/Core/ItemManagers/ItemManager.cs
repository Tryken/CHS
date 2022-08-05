using System.Collections.Generic;
using System.Linq;
using Core.ItemManagers.ScriptableObjects;
using Core.Singletons;
using UnityEditor;
using UnityEngine;

namespace Core.ItemManagers
{
    public class ItemManager : SingletonMonoBehaviour<ItemManager>
    {
        private Dictionary<string, ItemSo> items = new();
        
        private void Start()
        {
            AssetDatabase.CreateFolder("Assets/_tmp","Items");  
        }
        
        public ItemSo CreateItemSo(string id)
        {
            var asset = ScriptableObject.CreateInstance<ItemSo>();
            asset.ID = id;
            items.Add(id, asset);
            AssetDatabase.CreateAsset(asset, $"Assets/_tmp/Items/{id}.asset");
            return GetItemSo(id);
        }

        public ItemSo GetItemSo(string id)
        {
            return items.ContainsKey(id) ?  items[id] : null;
        }
        
        public void Clear()
        {
            ItemManagerAPI.Instance.Clear();
        }
    }
}