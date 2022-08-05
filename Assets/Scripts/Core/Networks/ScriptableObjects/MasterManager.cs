using UnityEngine;

namespace Core.Networks.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Network/MasterManager")]
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