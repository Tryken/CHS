using UnityEngine;

namespace Presentation
{
    public class Credits : MonoBehaviour
    {
        [field: SerializeField] private RectTransform creditsMenu;

        private GameObject _mainMenu;
        
        private void Start()
        {
            _mainMenu = GameObject.FindWithTag("MainScreen");
        }
    
        public void OpenCredits()
        {
            _mainMenu.transform.gameObject.SetActive(false);
            creditsMenu.transform.gameObject.SetActive(true);
        }
    }
}