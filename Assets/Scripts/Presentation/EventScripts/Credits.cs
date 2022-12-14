using UnityEngine;
using UnityEngine.InputSystem;

namespace Presentation.EventScripts
{
    public class Credits : MonoBehaviour
    {
        [field: SerializeField] private RectTransform CreditsMenu { get; set; }

        [field: SerializeField] private RectTransform MainMenu { get; set; }

        private void Update()
        {
            if (!Keyboard.current.escapeKey.isPressed)
                return;
            
            MainMenu.transform.gameObject.SetActive(true);
            CreditsMenu.transform.gameObject.SetActive(false);
        }
    
        public void OpenCredits()
        {
            MainMenu.transform.gameObject.SetActive(false);
            CreditsMenu.transform.gameObject.SetActive(true);
        }
    }
}