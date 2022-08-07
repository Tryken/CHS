using System;
using System.Collections.Generic;
using Core.Managers.ItemManagers.ScriptableObjects;
using Core.Singletons;
using UnityEditor;
using UnityEngine;

namespace Core.Managers.ItemManagers
{
    [Serializable]
    public class ItemManager : SingletonMonoBehaviour<ItemManager>
    {
        public Dictionary<string, ItemSo> Items = new();
        
        private void Start()
        {
            AssetDatabase.CreateFolder("Assets/_tmp","Items");  
        }
        
        public ItemSo CreateItemSo(string id)
        {
            var asset = ScriptableObject.CreateInstance<ItemSo>();
            asset.ID = id;
            Items.Add(id, asset);
            AssetDatabase.CreateAsset(asset, $"Assets/_tmp/Items/{id}.asset");
            return GetItemSo(id);
        }

        public ItemSo GetItemSo(string id)
        {
            return Items.ContainsKey(id) ?  Items[id] : null;
        }
        
        public void Clear()
        {
            ItemManagerAPI.Instance.Clear();
        }
    }
}