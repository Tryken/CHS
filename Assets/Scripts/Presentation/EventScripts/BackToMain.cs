using UnityEngine;
using UnityEngine.InputSystem;

namespace Presentation.EventScripts
{
    public class BackToMain : MonoBehaviour
    {
    
        private const string TAG_MAIN_SCREEN = "MainScreen";
        private Canvas Canvas { get; set; }
    
        private void Start()
        {
            Canvas = FindObjectOfType<Canvas>();
        }

        private void Update()
        {
            if (!Keyboard.current.escapeKey.isPressed)
                return;
            BackToMainMenu();
        }

        public void BackToMainMenu()
        {
            for (var i = 0; i < Canvas.transform.childCount; i++)
            {
                var obj = Canvas.transform.GetChild(i).gameObject;
                obj.SetActive(obj.CompareTag(TAG_MAIN_SCREEN));
            }
        }
    }
}