using System;
using Core.Networks.ScriptableObjects;
using Core.Singletons;
using UnityEngine;

namespace Core.Managers.NetworkManagers
{
    public class NetworkManager : SingletonMonoBehaviour<NetworkManager>
    {
        [field: SerializeField] private GameSettings GameSettingsField { get; set; }

        public static GameSettings GameSettings => Instance.GameSettingsField;
    }
}