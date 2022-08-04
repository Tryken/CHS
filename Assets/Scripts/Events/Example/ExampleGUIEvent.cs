using System;
using UnityEngine;

namespace Events
{
    public class ExampleGUIEvent : MonoBehaviour
    {
        [SerializeField] private GameEvent showGUI;

        private void Update()
        {
            if (!Input.GetKey(KeyCode.Space)) return;
            showGUI?.Invoke();
        }
        
    }
}