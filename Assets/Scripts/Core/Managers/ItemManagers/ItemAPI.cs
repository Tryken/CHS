using Core.Managers.TranslationManagers;

namespace Core.Managers.ItemManagers
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
            var itemSo = ItemManager.Instance.GetItemSo(id);
            itemSo.NameKey = value;
            itemSo.Name = TranslationManager.Instance.GetCurrentTranslation(value);
        }
        
        public string GetNameKey()
        {
            return ItemManager.Instance.GetItemSo(id).NameKey;
        }
        
        public void SetDescriptionKey(string value)
        {
            var itemSo = ItemManager.Instance.GetItemSo(id);
            itemSo.DescriptionKey = value;
            itemSo.Description = TranslationManager.Instance.GetCurrentTranslation(value);

        }
        
        public string GetDescriptionKey()
        {
            return ItemManager.Instance.GetItemSo(id).DescriptionKey;
        }
        
    }
}