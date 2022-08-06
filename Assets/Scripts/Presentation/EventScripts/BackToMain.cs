using UnityEngine;

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