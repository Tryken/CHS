using UnityEngine;

namespace Presentation
{
    public class CreateLobby : MonoBehaviour
    {
        [field: SerializeField] private RectTransform createLobbyMenu;

        private GameObject _mainMenu;
        
        private void Start()
        {
            _mainMenu = GameObject.FindWithTag("MainScreen");
        }
    
        public void CreateALobby()
        {
            _mainMenu.transform.gameObject.SetActive(false);
            createLobbyMenu.transform.gameObject.SetActive(true);
        }
    }
}
