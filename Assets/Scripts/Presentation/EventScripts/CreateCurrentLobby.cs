using UnityEngine;

namespace Presentation.EventScripts
{
    public class CreateCurrentLobby : MonoBehaviour
    {
        [field: SerializeField] private RectTransform CreateACurrentLobby { get; set; }

        [field: SerializeField] private RectTransform MainMenu { get; set; }

        public void OpenLobby()
        {
            MainMenu.transform.gameObject.SetActive(false);
            CreateACurrentLobby.transform.gameObject.SetActive(true);
        }
    }
}
