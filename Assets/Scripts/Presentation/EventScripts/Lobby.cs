using UnityEngine;

namespace Presentation.EventScripts
{
    public class Lobby : MonoBehaviour
    {
        [field: SerializeField] private RectTransform LobbyMenu { get; set; }
        [field: SerializeField] private RectTransform MainMenu { get; set; }

        public void OpenLobby()
        {
            MainMenu.transform.gameObject.SetActive(false);
            LobbyMenu.transform.gameObject.SetActive(true);
        }
    }
}