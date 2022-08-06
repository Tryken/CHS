using Core.Singletons;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Presentation.EventScripts
{
    public class GUIBaseLayer : SingletonMonoBehaviour<GUIBaseLayer>
    {
        private RectTransform MainMenu { get; set; }
        private RectTransform AnotherLobbyMenu { get; set; }
        
        public void Update()
        {
            if (!Keyboard.current.escapeKey.isPressed) return;
            MainMenu.transform.gameObject.SetActive(true);
            AnotherLobbyMenu.transform.gameObject.SetActive(false);
        }

        public void OpenCurrentLobby()
        {
            MainMenu.transform.gameObject.SetActive(false);
            AnotherLobbyMenu.transform.gameObject.SetActive(true);
        }
    }
}