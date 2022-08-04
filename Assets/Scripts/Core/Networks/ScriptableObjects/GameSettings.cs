using UnityEngine;
using Random = UnityEngine.Random;

namespace Core.Network.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Manager/GameSettings")]
    public class GameSettings : ScriptableObject
    {
        [field: SerializeField] public string GameVersion { get; set; } = "0.0.1";
        [field: SerializeField] public string NickName { get; set; }

        private void OnEnable()
        {
            NickName = "CHS-Player: " + Random.Range(0, int.MaxValue);
        }
    }
}