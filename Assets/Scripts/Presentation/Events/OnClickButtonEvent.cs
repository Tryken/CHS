using Events;
using UnityEngine;
using UnityEngine.UI;

namespace Presentation.Events
{
    public class OnClickButtonEvent : MonoBehaviour
    {
        [field: SerializeField] private GameEvent gameEvent { get; set; }

        private Button _button;
    
        private void Start()
        {
            _button = transform.gameObject.GetComponent<Button>();
            _button.onClick.AddListener(TaskOnClick);
        }

        private void TaskOnClick()
        {
            gameEvent?.Invoke();
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(TaskOnClick);
        }
    }
}
