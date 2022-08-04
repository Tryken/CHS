using Core.GameManagers;
using Core.Singletons;
using UnityEngine;

namespace Core.GameModes
{
    public class GameModeManager : SingletonMonoBehaviour<GameModeManager>
    {
        private void Start()
        {
            LoadGameMode("CustomHeroSurvival/main.lua");
        }

        private static void LoadGameMode(string gameModeName)
        {
            ScriptEngine.InitScriptEngine(gameModeName);
            
            GameManager.Instance.SetState(GameManagerState.Init);
        }
    }
}
