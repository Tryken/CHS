using UnityEngine;

namespace Singleton
{
    public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T _mInstance;

        protected static T Instance
        {
            get
            {
                if (_mInstance != null) return _mInstance;
                return FindObjectOfType(typeof(T)) as T;
            }
        }

        protected static bool Exists()
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