using System;
using System.IO;
using System.Net;
using Core.GameManagers;
using MoonSharp.Interpreter;
using UnityEngine;

namespace Core.GameModes
{
    public class ScriptEngine
    {
        private const string BASE_GAME_MODE_PATH = "./Assets/Resources/GameModes";

        private Script script;
        
        public ScriptEngine(Script script)
        {
            this.script = script;
        }
        
        public static ScriptEngine InitScriptEngine(string mainFile)
        {
            var script = new Script(CoreModules.Preset_HardSandbox)
            {
                Options =
                {
                    DebugPrint = Debug.Log,
                    ScriptLoader = new ScriptLoader() 
                    { 
                        ModulePaths = new[] { "?_module.lua" } 
                    }
                }
            };
            
            RegisterGlobals(script);
            
            var mainFilePath = $"{BASE_GAME_MODE_PATH}/{mainFile}";
            var mainSource = File.ReadAllText(mainFilePath);
            script.DoString(mainSource);

            return new ScriptEngine(script);
        }

        private static void RegisterGlobals(Script script)
        {
            UserData.RegisterType<EventArgs>();
            UserData.RegisterType<GameManagerAPI>();
            script.Globals["GameManagerAPI"] = GameManagerAPI.Instance;
        }
    }
}