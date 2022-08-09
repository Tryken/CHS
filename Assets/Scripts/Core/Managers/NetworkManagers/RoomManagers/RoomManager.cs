using System.Collections.Generic;
using Core.Managers.NetworkManagers.RoomManagers.ScriptableObjects;
using Core.Singletons;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Managers.NetworkManagers.RoomManagers
{
    public class RoomManager : SingletonMonoBehaviourPunCallbacks
    {
        private const string FOLDER_NAME = "RoomOption";
        private const string PARENT_FOLDER_NAME = "Assets/_tmp";

        [field: SerializeField] private TMP_InputField TextMeshPro { get; set; }

        [field: SerializeField] private Button ButtonTemplate { get; set; }

        [field: SerializeField] private RectTransform CurrentRoom { get; set; }

        [field: SerializeField] private Transform ContentFromRoomList { get; set; }

        private List<Button> CurrentStoredList { get; set; }
        private List<RoomInfo> CurrentStoredListRoomInfo { get; set; }

        private void Start()
        {
#if UNITY_EDITOR
            AssetDatabase.CreateFolder(PARENT_FOLDER_NAME, FOLDER_NAME);
#endif
        }

        public override void OnJoinedLobby()
        {
            base.OnJoinedLobby();
            Debug.Log("hello there lobby");
        }

        public void CreateRoom()
        {
            if (!PhotonNetwork.IsConnected)
                return;

            Debug.Log("CreateRoom");
            var roomOptionSo = ScriptableObject.CreateInstance<RoomOptionSo>();
#if UNITY_EDITOR
            AssetDatabase.CreateAsset(roomOptionSo, $"{PARENT_FOLDER_NAME}/{FOLDER_NAME}/{TextMeshPro.text}.asset");
#endif
            PhotonNetwork.CreateRoom(TextMeshPro.text, roomOptionSo.ConvertToPhotonRoomOptions(), TypedLobby.Default);
        }

        private void CleanRoomList()
        {
            foreach (var button in CurrentStoredList)
            {
                Destroy(button);
            }

            Debug.LogWarning("Clean up RoomList");
        }

        public override void OnRoomListUpdate(List<RoomInfo> roomList)
        {
            Debug.LogWarning("OnRoomListUpdate");

            CleanRoomList();

            foreach (var roomInfo in roomList)
            {
                var viewName = $"Name: {roomInfo.Name} | Players: {roomInfo.MaxPlayers}";
                var template = Instantiate(ButtonTemplate, ContentFromRoomList);
                template.name = viewName;
                template.onClick.AddListener(() => PhotonNetwork.JoinRoom(roomInfo.Name));
                template.onClick.AddListener(() => CurrentRoom.gameObject.SetActive(true));
                template.gameObject.SetActive(true);
                CurrentStoredList.Add(template);
            }

            base.OnRoomListUpdate(roomList);
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

        public override void OnPlayerEnteredRoom(Player newPlayer)
        {
            Debug.Log("OnPlayerEnteredRoom=" + newPlayer);
        }

        public override void OnPlayerLeftRoom(Player otherPlayer)
        {
            Debug.Log("OnPlayerLeftRoom=" + otherPlayer);
        }

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