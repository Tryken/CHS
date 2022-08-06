using UnityEngine;
using UnityEngine.InputSystem;

namespace Presentation.EventScripts
{
    public class CreateCurrentLobby : MonoBehaviour
    {
        [field: SerializeField] private RectTransform CreateACurrentLobby { get; set; }

        [field: SerializeField] private RectTransform MainMenu { get; set; }

        private void Update()
        {
            if (!Keyboard.current.escapeKey.isPressed)
                return;
            
            MainMenu.transform.gameObject.SetActive(true);
            CreateACurrentLobby.transform.gameObject.SetActive(false);
        }
    
        public void OpenLobby()
        {
            MainMenu.transform.gameObject.SetActive(false);
            CreateACurrentLobby.transform.gameObject.SetActive(true);
        }
    }
}
