using UnityEngine;
using UnityEngine.InputSystem;

namespace Presentation
{
    public class Credits : MonoBehaviour
    {
        [field: SerializeField] private RectTransform CreditsMenu { get; set; }

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
            CreditsMenu.transform.gameObject.SetActive(false);
        }
    
        public void OpenCredits()
        {
            MainMenu.transform.gameObject.SetActive(false);
            CreditsMenu.transform.gameObject.SetActive(true);
        }
    }
}