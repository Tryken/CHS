using Photon.Pun;

namespace Core.Singletons
{
    public class SingletonMonoBehaviourPunCallbacks : MonoBehaviourPunCallbacks
    {
        private static SingletonMonoBehaviourPunCallbacks _mInstance;
        
        public static SingletonMonoBehaviourPunCallbacks Instance
        {
            get
            {
                if (_mInstance != null) return _mInstance;
                return FindObjectOfType(typeof(SingletonMonoBehaviourPunCallbacks)) as SingletonMonoBehaviourPunCallbacks;
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
            
            _mInstance = this;
            DontDestroyOnLoad(transform.root.gameObject);
        }
        
        
        public void OnApplicationQuit()
        {
            _mInstance = null;
        }
    }
}