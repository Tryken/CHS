using ExitGames.Client.Photon;
using UnityEngine;

namespace Presentation.ScriptableObjects
{
    /// <summary>
    /// <see cref="https://doc-api.photonengine.com/en/pun/v2/class_photon_1_1_realtime_1_1_room_options.html#a01b2d365fd7a9fea82a9dc1e055801c9"/>
    /// </summary>
    [CreateAssetMenu(menuName = "Network/RoomOption")]
    public class RoomOption : ScriptableObject
    {
        [field: SerializeField] private bool IsVisible { get; set; } = true;
        [field: SerializeField] private bool IsOpen { get; set; } = true;
        [field: SerializeField] private byte MaxPlayers { get; set; } = 12;
        [field: SerializeField] private int PlayerTtl { get; set; }
        [field: SerializeField] private int EmptyRoomTtl { get; set; } = 180000; //3mins
        [field: SerializeField] private bool CleanupCacheOnLeave { get; set; }
        [field: SerializeField] private Hashtable CustomRoomProperties { get; set; }
        [field: SerializeField] private string[] CustomRoomPropertiesForLobby { get; set; }
        [field: SerializeField] private string[] Plugins { get; set; }
        [field: SerializeField] private bool SuppressRoomEvents { get; set; }
        [field: SerializeField] private bool SuppressPlayerInfo { get; set; }
        [field: SerializeField] private bool PublishUserId { get; set; }
        [field: SerializeField] private bool DeleteNullProperties { get; set; }
        [field: SerializeField] private bool BroadcastPropsChangeToAll { get; set; }
    }
}