﻿using Sirenix.OdinInspector;

namespace Core.Singletons
{
    public abstract class SingletonMonoBehaviour<T> : SerializedMonoBehaviour where T : SingletonMonoBehaviour<T>
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

        public void Awake()
        {
            if (_mInstance != null)
            {
                return;
            }
            
            _mInstance = this as T;
            DontDestroyOnLoad(transform.root.gameObject);
        }
        
        
        public void OnApplicationQuit()
        {
            _mInstance = null;
        }
    }
}