using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Singleton
{
    public class ExampleSingleton : Singleton<ExampleSingleton>
    {
        private void Start()
        {
            Debug.Log("My name is " + Instance.name);
            Debug.Log("I am here " + Exists());
        }
    }
}