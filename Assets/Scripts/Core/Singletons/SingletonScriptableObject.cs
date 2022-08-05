using UnityEngine;

namespace Core.Singletons
{
    public abstract class SingletonScriptableObject<T> : ScriptableObject where T : SingletonScriptableObject<T>
    {
        private static T _mInstance;

        public static T Instance
        {
            get
            {
                if (_mInstance != null) return _mInstance;
                return FindObjectOfType(typeof(T)) as T;
            }
        }

        protected bool Exists()
        {
            return (_mInstance != null);
        }

        private void Awake()
        {
            if (_mInstance != null) return;
            _mInstance = this as T;
        }

        private void OnApplicationQuit()
        {
            _mInstance = null;
        }
    }
}