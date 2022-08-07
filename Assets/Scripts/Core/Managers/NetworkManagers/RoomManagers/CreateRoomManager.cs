using Core.Managers.NetworkManagers.RoomManagers.ScriptableObjects;
using Photon.Pun;
using TMPro;
using UnityEditor;
using UnityEngine;

namespace Core.Managers.NetworkManagers.RoomManagers
{
    public class CreateRoomManager : MonoBehaviourPunCallbacks
    {
        private const string FOLDER_NAME = "RoomOption";
        private const string PARENT_FOLDER_NAME = "Assets/_tmp";

        [field: SerializeField] private TMP_InputField TextMeshPro { get; set; }
        
        private void Start()
        {
            AssetDatabase.CreateFolder(PARENT_FOLDER_NAME,FOLDER_NAME); 
        }

        public void CreateRoom()
        {
            if (!PhotonNetwork.IsConnected)
                return;

            var roomOptionSo = ScriptableObject.CreateInstance<RoomOptionSo>();
            AssetDatabase.CreateAsset(roomOptionSo, $"{PARENT_FOLDER_NAME}/{FOLDER_NAME}/{TextMeshPro.text}.asset");
            PhotonNetwork.CreateRoom(TextMeshPro.text, roomOptionSo.ConvertToPhotonRoomOptions());
        }
        
        public override void OnJoinedRoom()
        {
            Debug.Log("Join to room");
        }

        public override void OnCreatedRoom()
        {
            Debug.Log("Create a Room");
        }

        public override void OnCreateRoomFailed(short returnCode, string message)
        {
            Debug.Log($"Failed {returnCode} - {message}");
        }
    }
}