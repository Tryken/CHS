using Presentation.ScriptableObjects;
using UnityEngine;

namespace Presentation
{
    public class CreateLobby : MonoBehaviour
    {
        [field: SerializeField] private RectTransform CreateLobbyMenu { get; set; }
        
        private RoomOption RoomOption { get; set; }
        private GameObject MainMenu { get; set; }
        
        private void Start()
        {
            MainMenu = GameObject.FindWithTag("MainScreen");
        }

        public void CreateALobby()
        {
            MainMenu.transform.gameObject.SetActive(false);
            CreateLobbyMenu.transform.gameObject.SetActive(true);
            RoomOption = ScriptableObject.CreateInstance<RoomOption>();
        }
    }
}
