using Core.Networks.ScriptableObjects;
using Core.Singletons;
using UnityEngine;

namespace Core.Managers.GameSettingsManager
{
    public class GameSettingsManager : SingletonMonoBehaviour<GameSettingsManager>
    {
        [field: SerializeField] private GameSettings GameSettingsField { get; set; }

        public static GameSettings GameSettings => Instance.GameSettingsField;
    }
}