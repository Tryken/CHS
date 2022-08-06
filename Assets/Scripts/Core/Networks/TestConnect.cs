using Core.Managers.GameSettingsManager;
using Core.Networks.ScriptableObjects;
using Photon.Pun;
using Photon.Realtime;

namespace Core.Networks
{
    public class TestConnect : MonoBehaviourPunCallbacks
    {
        private void Start()
        {
            print("Connection to Server");
            PhotonNetwork.NickName = GameSettingsManager.GameSettings.NickName;
            PhotonNetwork.GameVersion = GameSettingsManager.GameSettings.GameVersion;
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
