using System;
using Core.Network.ScriptableObjects;
using UnityEngine;

namespace Core.Networks.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Manager/MasterManager")]
    public class MasterManager : ScriptableObject
    {
        public static GameSettings GameSettings
        {
            get
            {
                if (GameSettings is null)
                {
                    CreateInstance<GameSettings>();
                }

                return GameSettings;
            }
        }
    }
}