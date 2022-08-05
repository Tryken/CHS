using Core.Networks.ScriptableObjects;
using Core.Singletons;
using UnityEngine;

namespace Core.Networks.MasterManagers
{
    public class MasterManager : SingletonMonoBehaviour<MasterManager>
    {
        [field: SerializeField] private GameSettings GameSettingsField { get; set; }

        public static GameSettings GameSettings => Instance.GameSettingsField;
    }
}