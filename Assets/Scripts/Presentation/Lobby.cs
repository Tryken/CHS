using UnityEngine;
using UnityEngine.InputSystem;

namespace Presentation
{
    public class Lobby : MonoBehaviour
    {
        [field: SerializeField] private RectTransform LobbyMenu { get; set; }

        private GameObject MainMenu { get; set; }

        private void Start()
        {
            MainMenu = GameObject.FindWithTag("MainScreen");
        }
        
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