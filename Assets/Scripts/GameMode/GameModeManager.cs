using System;
using System.IO;
using MoonSharp.Interpreter;
using UnityEngine;

public class GameModeManager : MonoBehaviour
{
    void Start()
    {
        loadGamemode("CustomHeroSurvival");
    }

    public void loadGamemode(string gameModeName) {
        string gameModeMainSrc = File.ReadAllText("./Assets/Resources/GameModes/" + gameModeName + "/main.lua");
        Script script = new Script(CoreModules.Preset_HardSandbox);
        script.Options.DebugPrint = s => { Debug.Log(s); };

        UserData.RegisterType<EventArgs>();
        UserData.RegisterType<GameManagerAPI>();
        script.Globals["GameManager"] = new GameManagerAPI();

        script.DoString(gameModeMainSrc);

        GameManagerAPI.Instance.RaiseOnInitGame();
    }
}
