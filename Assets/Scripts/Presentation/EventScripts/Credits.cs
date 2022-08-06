using UnityEngine;
using UnityEngine.InputSystem;

namespace Presentation.EventScripts
{
    public class Credits : MonoBehaviour
    {
        [field: SerializeField] private RectTransform CreditsMenu { get; set; }

        [field: SerializeField] private RectTransform MainMenu { get; set; }
        
        public void OpenCredits()
        {
            MainMenu.transform.gameObject.SetActive(false);
            CreditsMenu.transform.gameObject.SetActive(true);
        }
    }
}