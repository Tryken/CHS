using UnityEngine;

namespace Core.Singletons
{
    public abstract class SingletonScriptableObject<T> : ScriptableObject where T : SingletonScriptableObject<T>, new()
    {
        private static T _mInstance;

        public static T Instance => _mInstance != null ? _mInstance : CreateInstance<T>();

        public bool Exists()
        {
            return (_mInstance != null);
        }
        
        private void OnApplicationQuit()
        {
            _mInstance = null;
        }
    }
}