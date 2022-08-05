using System.IO;
using Core.ItemsManagers;
using Core.ItemsManagers.ScriptableObjects;
using Core.Singletons;
using UnityEditor;
using UnityEngine;

namespace Core.ItemManagers
{
    public class ItemManager : SingletonMonoBehaviour<ItemManager>
    {

        public void CreateItem(string id)
        {
            AssetDatabase.CreateFolder("Assets/_tmp","Items");  
            var asset = ScriptableObject.CreateInstance<ItemSo>();
            AssetDatabase.CreateAsset(asset, $"Assets/_tmp/Items/{id}.asset");
        }
        
        public void Clear()
        {
            ItemManagerAPI.Instance.Clear();
        }
    }
}