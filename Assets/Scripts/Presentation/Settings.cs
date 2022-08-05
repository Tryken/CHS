using UnityEngine;
using UnityEngine.InputSystem;

namespace Presentation
{
    public class Settings : MonoBehaviour
    {
        [field: SerializeField] private RectTransform SettingsMenu { get; set; }

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
            SettingsMenu.transform.gameObject.SetActive(false);
        }
    
        public void OpenSettings()
        {
            MainMenu.transform.gameObject.SetActive(false);
            SettingsMenu.transform.gameObject.SetActive(true);
        }
    }
}