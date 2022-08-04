using System;
using UnityEngine;

namespace Presentation
{
    public class Lobby : MonoBehaviour
    {
        [field: SerializeField] private RectTransform lobbyMenu;

        private GameObject _mainMenu;
        
        private void Start()
        {
            _mainMenu = GameObject.FindWithTag("MainScreen");
        }

        public void OpenLobby()
        {
            _mainMenu.transform.gameObject.SetActive(false);
            lobbyMenu.transform.gameObject.SetActive(true);
        }
    }
}