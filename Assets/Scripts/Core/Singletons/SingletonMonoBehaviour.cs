using UnityEngine;

namespace Core.Singletons
{
    public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
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

        public bool Exists()
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