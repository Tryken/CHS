using Photon.Pun;
using TMPro;
using UnityEngine;

namespace Debug
{
    public class PhotonNetworkApplicationStatistics : MonoBehaviour
    {
        [field: SerializeField] private TMP_Text Text { get; set; }

        private void Update()
        {
            var countOfPlayer = PhotonNetwork.CountOfPlayers;
            var counterOfRooms = PhotonNetwork.CountOfRooms;
            var counterOfInRooms = PhotonNetwork.CountOfPlayersInRooms;
            var counterOfMaster = PhotonNetwork.CountOfPlayersOnMaster;
            Text.text = $"countOfPlayer = {countOfPlayer} | " +
                        $"counterOfRooms = {counterOfRooms} | " +
                        $"counterOfInRooms = {counterOfInRooms} | " +
                        $"counterOfMaster = {counterOfMaster}";
        }
    }
}