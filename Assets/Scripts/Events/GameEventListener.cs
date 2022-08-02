using System;
using UnityEngine;
using UnityEngine.Events;

namespace Events
{
    /// <summary>
    /// https://www.youtube.com/watch?v=lgA8KirhLEU
    /// </summary>
    public class GameEventListener : MonoBehaviour
    {
        [SerializeField] private GameEvent gameEvent;
        [SerializeField] private UnityEvent unityEvent;

        private void Awake() => gameEvent.Register(this);

        private void OnDestroy() => gameEvent.Deregister(this);

        public void RaiseEvent() => unityEvent.Invoke();
    }
}