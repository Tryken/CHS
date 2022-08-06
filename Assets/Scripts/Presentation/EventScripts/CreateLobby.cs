using Presentation.ScriptableObjects;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Presentation.EventScripts
{
    public class CreateLobby : MonoBehaviour
    {
        [field: SerializeField] private RectTransform CreateLobbyMenu { get; set; }
        
        [field: SerializeField] private RectTransform MainMenu { get; set; }
        
        private RoomOption RoomOption { get; set; }

        public void OpenLobby()
        {
            MainMenu.transform.gameObject.SetActive(false);
            CreateLobbyMenu.transform.gameObject.SetActive(true);
            RoomOption = ScriptableObject.CreateInstance<RoomOption>();
        }
    }
}
