using Singleton;

namespace GameManager
{
    public class GameManager : SingletonMonoBehaviour<GameManager>
    {
        public static GameManagerState State { get; private set; }
        
    }
}
