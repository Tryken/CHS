using Core.Network.ScriptableObjects;
using Photon.Pun;
using Photon.Realtime;

namespace Core.Network
{
    public class TestConnect : MonoBehaviourPunCallbacks
    {
        private void Start()
        {
            print("Connection to Server");
            PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
            PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
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
