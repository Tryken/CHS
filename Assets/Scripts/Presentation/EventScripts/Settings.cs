using UnityEngine;

namespace Presentation.EventScripts
{
    public class Settings : MonoBehaviour
    {
        [field: SerializeField] private RectTransform SettingsMenu { get; set; }
        [field: SerializeField] private RectTransform MainMenu { get; set; }
        
        public void OpenSettings()
        {
            MainMenu.transform.gameObject.SetActive(false);
            SettingsMenu.transform.gameObject.SetActive(true);
        }
    }
}