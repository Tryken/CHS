using UnityEngine;

namespace Core.Singletons.Examples
{
    public class ExampleSingletonMonoBehaviour : SingletonMonoBehaviour<ExampleSingletonMonoBehaviour>
    {
        private void Start()
        {
            Debug.Log("My name is " + Instance.name);
            Debug.Log("I am here " + Exists());
        }
    }
}