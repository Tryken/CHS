using Photon.Pun;
using UnityEngine;

namespace Core.Managers.NetworkManagers.RoomManagers
{
    public class LeaveRoomManager : MonoBehaviourPunCallbacks
    {
        public void LeaveRoom()
        {
            var resultOfLeaveRoom = PhotonNetwork.LeaveRoom();
            if (!resultOfLeaveRoom)
            {
                Debug.LogWarning("Player is not connected to any room");
            }
        }
        
        public override void OnLeftRoom()
        {
            Debug.Log("OnLeftRoom");
        }
    }
}