using UnityEngine;

namespace Core.Network.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Manager/MasterManager")]
    public class MasterManager : ScriptableObject
    {
        [field: SerializeField] public static GameSettings GameSettings => CreateInstance<GameSettings>();
    }
}
