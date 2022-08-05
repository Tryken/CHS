using UnityEngine;
using UnityEngine.InputSystem;

namespace Presentation
{
    public class Settings : MonoBehaviour
    {
        [field: SerializeField] private RectTransform SettingsMenu { get; set; }
        [field: SerializeField] private RectTransform MainMenu { get; set; }

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