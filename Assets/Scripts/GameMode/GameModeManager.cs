using System;
using System.IO;
using GameManager;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Serialization;
using Singleton;
using UnityEngine;

namespace GameMode
{
    public class GameModeManager : SingletonMonoBehaviour<GameModeManager>
    {
        private void Start()
        {
            LoadGameMode("CustomHeroSurvival");
        }

        private static void LoadGameMode(string gameModeName)
        {
            var gameModeMainSrc = File.ReadAllText($"./Assets/Resources/GameModes/{gameModeName}/main.lua");
            var script = new Script(CoreModules.Preset_HardSandbox)
            {
                Options =
                {
                    DebugPrint = Debug.Log
                }
            };

            UserData.RegisterType<EventArgs>();
            UserData.RegisterType<GameManagerAPI>();
            script.Globals["GameManager"] = new GameManagerAPI();

            script.DoString(gameModeMainSrc);
            
            GameManagerAPI.Instance.RaiseOnInitGame();
            
            Table dump = UserData.GetDescriptionOfRegisteredTypes(true);
            File.WriteAllText(@"c:\temp\testdump.lua", dump.Serialize());
        }
    }
}
