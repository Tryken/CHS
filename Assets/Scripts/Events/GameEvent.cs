using System.Collections.Generic;
using UnityEngine;

namespace Events
{
    [CreateAssetMenu(menuName = "Game Event", fileName = "New Game Event")]
    public class GameEvent : ScriptableObject
    {
        private readonly HashSet<GameEventListener> _listeners = new();

        public void Invoke()
        {
            foreach (var gameEventListener in _listeners)
            {
                gameEventListener.RaiseEvent();
            }
        }

        public void Register(GameEventListener gameEventListener) => _listeners.Add(gameEventListener);
        public void Deregister(GameEventListener gameEventListener) => _listeners.Remove(gameEventListener);
    }
}