using Core.GameModes;
using Core.Managers.GameManagers;
using Core.Managers.ItemManagers;
using Core.Singletons;
using UnityEngine;

namespace Core.Managers.GameModeManagers
{
    public class GameModeManager : SingletonMonoBehaviour<GameModeManager>
    {
        public static string BASE_GAME_MODE_PATH = "./Assets/Resources/GameModes";
        
        [field:SerializeField]
        public string CurrentGameMode { get; private set; }

        private void Start()
        {
            LoadGameMode("CustomHeroSurvival");
        }

        public void LoadGameMode(string gameModeName)
        {
            if (CurrentGameMode != "")
            {
                GameManager.Instance.SetState(GameManagerState.Close);
            }
            
            CurrentGameMode = gameModeName;
            ScriptEngine.InitScriptEngine(gameModeName);
            
            GameManager.Instance.SetState(GameManagerState.Init);
        }

        public void ClearGameManager()
        {
            GameManager.Instance.Clear();
            ItemManager.Instance.Clear();
        }
    }
}
