using Core.Singletons;
using UnityEngine;

namespace Core.Networks.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Network/MasterManager")]
    public class MasterManager : SingletonScriptableObject<MasterManager>
    {
        [field: SerializeField]
        public GameSettings GameSettingsfield { get; set; }

        public static GameSettings GameSettings => Instance.GameSettingsfield;
    }
}