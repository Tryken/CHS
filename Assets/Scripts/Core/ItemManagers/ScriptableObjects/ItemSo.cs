using System;
using UnityEngine;

namespace Core.ItemsManagers.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Lua API/Item", fileName = "New Item")]
    public class ItemSo : ScriptableObject
    {
        [field: SerializeField] public string ID { get; set; }
        [field: SerializeField] public string Name { get; set; }
        [field: SerializeField] public string NameKey { get; set; }
        [field: SerializeField] public string Description { get; set; }
        [field: SerializeField] public string DescriptionKey { get; set; }
    }
}