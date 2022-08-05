using Core.Singletons;
using MoonSharp.Interpreter;

namespace Core.ItemManagers
{
    [MoonSharpUserData]
    public class ItemManagerAPI : Singleton<ItemManagerAPI> 
    {
        public ItemAPI CreateItem(string id)
        {
            return ItemManager.Instance.CreateItemSo(id).CreateItemAPI();
        }
        
        [MoonSharpHidden]
        public void Clear()
        {

        }
    }
}