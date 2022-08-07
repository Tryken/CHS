using Photon.Pun;
using Photon.Realtime;

namespace Core.Managers.NetworkManagers
{
    public class TestConnect : MonoBehaviourPunCallbacks
    {
        private void Start()
        {
            print("Connection to Server");
            PhotonNetwork.NickName = NetworkManager.GameSettings.NickName;
            PhotonNetwork.GameVersion = NetworkManager.GameSettings.GameVersion;
            PhotonNetwork.ConnectUsingSettings();
        }

        public override void OnConnectedToMaster()
        {
            print("Connection to Master");
            print(PhotonNetwork.LocalPlayer.NickName);
        }

        public override void OnDisconnected(DisconnectCause cause)
        {
            print("Disconnection from Server : " + cause);
        }
    }
}
