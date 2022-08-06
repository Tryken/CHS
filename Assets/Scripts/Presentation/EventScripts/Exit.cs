using UnityEngine;

namespace Presentation.EventScripts
{
    public class Exit : MonoBehaviour
    {
        public void CloseGame()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }
    }
}
