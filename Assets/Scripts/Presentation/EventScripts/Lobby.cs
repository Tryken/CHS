using UnityEngine;
using UnityEngine.InputSystem;

namespace Presentation.EventScripts
{
    public class Lobby : MonoBehaviour
    {
        [field: SerializeField] private RectTransform LobbyMenu { get; set; }
        [field: SerializeField] private RectTransform MainMenu { get; set; }
        
        private void Update()
        {
            if (!Keyboard.current.escapeKey.isPressed)
                return;
            
            MainMenu.transform.gameObject.SetActive(true);
            LobbyMenu.transform.gameObject.SetActive(false);
        }

        public void OpenLobby()
        {
            MainMenu.transform.gameObject.SetActive(false);
            LobbyMenu.transform.gameObject.SetActive(true);
        }
    }
}