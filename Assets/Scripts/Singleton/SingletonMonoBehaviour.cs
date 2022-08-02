﻿using UnityEngine;

namespace Singleton
{
    public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
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