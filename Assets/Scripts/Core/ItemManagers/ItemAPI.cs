using MoonSharp.Interpreter;
using UnityEngine;

namespace Core.ItemManagers
{
    public class ItemAPI
    {
        private string id;
        public ItemAPI(string id)
        {
            this.id = id;
        }
        
        public string GetID()
        {
            return id;
        } 
        
        public void SetNameKey(string value)
        {
            ItemManager.Instance.GetItemSo(id).NameKey = value;
        }
        
        public string GetNameKey()
        {
            return ItemManager.Instance.GetItemSo(id).NameKey;
        }
        
        public void SetDescriptionKey(string value)
        {
            ItemManager.Instance.GetItemSo(id).DescriptionKey = value;
        }
        
        public string GetDescriptionKey()
        {
            return ItemManager.Instance.GetItemSo(id).DescriptionKey;
        }
        
    }
}