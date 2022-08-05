using Presentation.ScriptableObjects;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Presentation
{
    public class CreateLobby : MonoBehaviour
    {
        [field: SerializeField] private RectTransform CreateLobbyMenu { get; set; }
        
        [field: SerializeField] private RectTransform MainMenu { get; set; }
        
        private RoomOption RoomOption { get; set; }
        
        private void Update()
        {
            if (!Keyboard.current.escapeKey.isPressed) return;
            MainMenu.transform.gameObject.SetActive(true);
            CreateLobbyMenu.transform.gameObject.SetActive(false);
        }

        public void CreateALobby()
        {
            MainMenu.transform.gameObject.SetActive(false);
            CreateLobbyMenu.transform.gameObject.SetActive(true);
            RoomOption = ScriptableObject.CreateInstance<RoomOption>();
        }
    }
}
