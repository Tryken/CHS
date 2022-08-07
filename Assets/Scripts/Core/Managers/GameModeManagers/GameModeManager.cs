using Core.Managers.GameManagers;
using Core.Managers.ItemManagers;
using Core.Managers.TranslationManagers;
using Core.ScriptEngines;
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
            if (!string.IsNullOrEmpty(CurrentGameMode))
            {
                GameManager.Instance.SetState(GameManagerState.Close);
            }
            CurrentGameMode = gameModeName;
            
            TranslationManager.Instance.LoadFromCsvFile($"{BASE_GAME_MODE_PATH}/{CurrentGameMode}/translation.csv");
            
            ScriptEngine.InitScriptEngine(gameModeName);
            
            GameManager.Instance.SetState(GameManagerState.Init);
        }

        public void ClearGameManager()
        {
            GameManager.Instance.Clear();
            ItemManager.Instance.Clear();
            TranslationManager.Instance.Clear();
        }
    }
}
