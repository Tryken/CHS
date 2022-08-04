using UnityEngine;

namespace Presentation
{
    public class Settings : MonoBehaviour
    {
        [field: SerializeField] private RectTransform settingsMenu;

        private GameObject _mainMenu;
        
        private void Start()
        {
            _mainMenu = GameObject.FindWithTag("MainScreen");
        }
    
        public void OpenSettings()
        {
            _mainMenu.transform.gameObject.SetActive(false);
            settingsMenu.transform.gameObject.SetActive(true);
        }
    }
}