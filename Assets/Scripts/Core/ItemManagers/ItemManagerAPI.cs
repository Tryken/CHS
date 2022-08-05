using Core.ItemManagers;
using Core.Singletons;

namespace Core.ItemsManagers
{
    public class ItemManagerAPI : Singleton<ItemManagerAPI> 
    {
        public void CreateItem(string id)
        {
            ItemManager.Instance.CreateItem(id);
        }
        
        public void Clear()
        {

        }
    }
}