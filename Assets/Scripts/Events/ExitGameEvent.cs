using System;
using UnityEngine;
using UnityEngine.UI;

namespace Events
{
    public class ExitGameEvent : MonoBehaviour
    {
        [field: SerializeField] private GameEvent exitGame;
        [field: SerializeField] private Button _button;

        private void Start()
        {
            _button.onClick.AddListener(TaskOnClick);
        }

        private void TaskOnClick()
        {
            exitGame?.Invoke();
        }
    }
}