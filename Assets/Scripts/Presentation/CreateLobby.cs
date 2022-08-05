using System;
using Presentation.ScriptableObjects;
using UnityEngine;
using UnityEngine.InputSystem;

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

        private void Update()
        {
            if (!Keyboard.current.escapeKey.isPressed) return;
            MainMenu.transform.gameObject.SetActive(true);
            CreateLobbyMenu.transform.gameObject.SetActive(false);
        }

        public void CreateALobby()
        {
            Debug.Log("Hello there");
            MainMenu.transform.gameObject.SetActive(false);
            CreateLobbyMenu.transform.gameObject.SetActive(true);
            RoomOption = ScriptableObject.CreateInstance<RoomOption>();
        }
    }
}
